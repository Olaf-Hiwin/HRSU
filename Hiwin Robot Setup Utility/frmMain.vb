Imports System.Net
Imports System.Reflection
Imports System.Text
Imports System.Threading

Public Class frmMain

    Public HROBOT As Integer                                                                        ' Robot connection ID
    Public IsConnected As Boolean = False                                                           ' Robot connection flag
    Private ConnFeed As CallBackFun = New CallBackFun(AddressOf EventFun)                           ' Event header for the callback function
    Private CallBackStr As String = String.Empty                                                    ' Callback message
    Private CallBackLog As String = String.Empty                                                    ' Log of the callback messages
    Private ProdVers As ProductsVersions                                                            ' Products versions information structure

    ' Enumerations and structures declaration

    Private Enum Command_
        ' Callback instruction commands (provided to HRSS)

        NOTIFY = 0                                                                              ' Notify (request data)
        CLEAR_ALARM = 1450                                                                      ' Clear alarm
        DELETE_HRSS = 2162                                                                      ' Delete HRSS backup
        DW_CATERPILLAR = 2165                                                                   ' Download Caterpillar
        EX_EXT_TASK = 4000                                                                      ' Execute external task
        TASK_START = 4001                                                                       ' Start a task
        TASK_STOP = 4004                                                                        ' Stop a task
        DW_FILE = 4009                                                                          ' Download file
        UPDATE_HRSS = 4011                                                                      ' Update the HRSS software
        ART_ROB_INFO = 4151                                                                     ' Articulated robot information
        TCP_IP_COMM = 4202                                                                      ' Establish TCP/IP communicaiton connection
        EXT_AX_MAST = 4290                                                                      ' External axis mastering
        API_INST_PRS = 4701                                                                     ' API instruction parsing
        IO_MOD_SAVE = 4709                                                                      ' Save module IO
        DIO_SET = 63774                                                                         ' Set DIO

    End Enum

    Private Enum Result_
        ' Callback instruction results (feedback from HRSS)

        GEN_RES = 0                                                                             ' General result which depends on command value
        DW_FILE_NE = 201                                                                        ' Download file does not exist
        DIO_SET_SUCC = 500                                                                      ' DIO set successfully
        IO_MOD_SAVE_SUCC = 501                                                                  ' Module IO saved successfully
        API_INST_PRS_FAILED = 1000                                                              ' API instruction parsing failed
        ALREADY_MOTION = 2006                                                                   ' There is already motion executing before executing task_start
        ERROR_OPEN_FILE_FAIL = 4011                                                             ' task_start file open error
        HRSS_TASK_START_NAME_ERR = 4012                                                         ' task_start file name error
        HRSS_TASK_START_ALREADY_EX = 4013                                                       ' ext_task_start already executing
        HRSS_TASK_START_FINISH = 4014                                                           ' task_start start executing
        HRSS_TAST_STOP = 4018                                                                   ' Stop task
        HRSS_UPDATE_FILE_ERROR = 4020                                                           ' HRSS upload file error
        HRSS_UPDATE_FILE_TRANSFER_ERROR = 4021                                                  ' Update file send failed
        HRSS_UPDATE_FILE_UNARCHIVER_ERROR = 4022                                                ' HRSS update file failed
        HRSS_HARD_DISK_CAPACITY_IS_NOT_ENOUTH = 4023                                            ' HRSS insufficient hardware capacity
        HRSS_DEL_BACKUP_FAILED = 4024                                                           ' Delete HRSS backup file failed; file does not exist
        HRSS_DEL_BACKUP_SUCC = 4025                                                             ' Delete HRSS backup file successful
        HRSS_START_UPDATE = 4026                                                                ' HRSS start updating
        HRSS_UPDATE_FILE_TRANSFER_SUCCESS = 4027                                                ' HRSS update file sent successfully
        HRSS_START_CLEAR_ALARM = 4028                                                           ' Start clearing alarm
        HRSS_FINISH_CLEAR_ALARM = 4029                                                          ' End clearing alarm
        HRSS_ALARM_NOTIFY = 4030                                                                ' Alarm and error code occurred
        HRSS_BATTERY_WARRING = 4031                                                             ' Battery warning
        HRSS_BATTERY_ALARM = 4032                                                               ' Battery alarm
        HRSS_BATTERY_NORMAL = 4033                                                              ' Battery normal
        HRSS_NETWORK_MSG_NOTIFY = 4034                                                          ' Network communication message
        HRSS_RS232_MSG_NOTIFY = 4035                                                            ' RS232 communication message
        HRSS_MODBUS_MSG_NOTIFY = 4036                                                           ' Modbus Monitor message
        HRSS_DW_CATERPILLAR_FAILED = 4044                                                       ' Download Caterpillar failed
        HRSS_EXT_AX_MAST_START = 4047                                                           ' External axis Mastering starts executing
        HRSS_EXT_AX_MAST_END = 4048                                                             ' External axis Mastering ended
        HRSS_EXT_MAST_FAILED_MOV = 4049                                                         ' External axis Mastering failed; there is an external axis currently moving
        HRSS_EXT_MAST_FAILED = 4050                                                             ' External axis Mastering failed
        HRSS_SI_VAL_CHANGED = 4144                                                              ' System Input value changed
        HRSS_SO_VAL_CHANGED = 4145                                                              ' System Output value changed
        HRSS_PROGRAM_LINE_NUMBER_NOTIFY = 4700                                                  ' The row number of the program is currently executing
        HRSS_ROBOT_INFO_NOTIFY = 4702                                                           ' Notify changed value (HRSS mode, motion status, etc.)
        HRSS_TIMER_VAL_CHANGED = 4703                                                           ' Timer value changed
        HRSS_COUNTER_VAL_CHANGED = 4704                                                         ' Counter value changed
        HRSS_MI_VAL_CHANGED = 4705                                                              ' Module Input value changed
        HRSS_MO_VAL_CHANGED = 4706                                                              ' Module Output value changed
        HRSS_FI_VAL_CHANGED = 4707                                                              ' Fieldbus Input value changed
        HRSS_FO_VAL_CHANGED = 4708                                                              ' Fieldbus Output value changed
        HRSS_PR_VAL_CHANGED = 4710                                                              ' PR changed, off_on, index, mode, position
        HRSS_DI_VAL_CHANGED = 4711                                                              ' Digital Input value changed
        HRSS_DO_VAL_CHANGED = 4712                                                              ' Digital Output value changed
        HRSS_UT_HIST_REC_INF = 4713                                                             ' Utilization history record information
        HRSS_UT_START = 4714                                                                    ' Utilization start, when task_start starts executing
        HRSS_UT_END = 4715                                                                      ' Utilization end, when task_start stops
        HRSS_TO_SDK = 4716                                                                      ' Messages that HRSS sends to SDK
        HRSS_PR_COMM_MSG = 4717                                                                 ' What comments of PR have messages
        HRSS_EXT_AX_SENS_LIM_LIGHT_DISP = 4718                                                  ' External axis sensor limit light display
        TCP_IP_COMM_FAILED = 9999                                                               ' TCP/IP communication connection failed

    End Enum

    Private Structure ProductsVersions
        Public v_HRSDK As String
        Public v_HRSS As String
        Public t_robot As String
    End Structure

    ' General subs/functions

    Private Sub EventFun(command As UInt16, result As UInt16, ByRef msg As UInt16, length As Integer)
        ' Reads the result of the callback event.
        ' Many results can refer to the same command; see Software_Development_Kit-(E).pdf, pages 37-39

        Dim tmpTxt As String = String.Empty

        Select Case command                                                                     ' Current callback command
            Case Command_.NOTIFY
                Select Case result
                    Case Result_.HRSS_ALARM_NOTIFY
                        For i As Integer = 0 To length - 1
                            tmpTxt = tmpTxt & (Asc(msg.ToString()))
                        Next i
                        CallBackStr = "[Notify] Alarm: " & tmpTxt
                    Case Result_.HRSS_BATTERY_WARRING
                        CallBackStr = "[Notify] Battery Status: Warning"
                    Case Result_.HRSS_BATTERY_ALARM
                        CallBackStr = "[Notify] Battery Status: Alarm"
                    Case Result_.HRSS_BATTERY_NORMAL
                        CallBackStr = "[Notify] Battery Status: Normal"
                    Case Result_.HRSS_NETWORK_MSG_NOTIFY
                        CallBackStr = "[Notify] Network communication message"
                    Case Result_.HRSS_RS232_MSG_NOTIFY
                        CallBackStr = "[Notify] RS232 communication message"
                    Case Result_.HRSS_MODBUS_MSG_NOTIFY
                        CallBackStr = "[Notify] Modbus Monitor message"
                    Case Result_.HRSS_SI_VAL_CHANGED
                        CallBackStr = "[Notify] System Input value changed"
                    Case Result_.HRSS_SO_VAL_CHANGED
                        CallBackStr = "[Notify] System Output value changed"
                    Case Result_.HRSS_PROGRAM_LINE_NUMBER_NOTIFY
                        CallBackStr = "[Notify] The row number of the program is currently executing"
                    Case Result_.HRSS_ROBOT_INFO_NOTIFY
                        CallBackStr = "[Notify] Notify changed value (HRSS mode, motion status, etc.)"
                    Case Result_.HRSS_TIMER_VAL_CHANGED
                        CallBackStr = "[Notify] Timer value changed"
                    Case Result_.HRSS_COUNTER_VAL_CHANGED
                        CallBackStr = "[Notify] Counter value changed"
                    Case Result_.HRSS_MI_VAL_CHANGED
                        CallBackStr = "[Notify] Module Input value changed"
                    Case Result_.HRSS_MO_VAL_CHANGED
                        CallBackStr = "[Notify] Module Output value changed"
                    Case Result_.HRSS_FI_VAL_CHANGED
                        CallBackStr = "[Notify] FieldBus Input value changed"
                    Case Result_.HRSS_FO_VAL_CHANGED
                        CallBackStr = "[Notify] FieldBus Output value changed"
                    Case Result_.HRSS_PR_VAL_CHANGED
                        CallBackStr = "[Notify] PR changed, off_on, Index, mode, position"
                    Case Result_.HRSS_DI_VAL_CHANGED
                        CallBackStr = "[Notify] Digital Input value changed"
                    Case Result_.HRSS_DO_VAL_CHANGED
                        CallBackStr = "[Notify] Digital Output value changed"
                    Case Result_.HRSS_UT_HIST_REC_INF
                        CallBackStr = "[Notify] Utilization history record information"
                    Case Result_.HRSS_UT_START
                        CallBackStr = "[Notify] Utilization start, when task_start starts executing"
                    Case Result_.HRSS_UT_END
                        CallBackStr = "[Notify] Utilization end, when task_start stops"
                    Case Result_.HRSS_TO_SDK
                        CallBackStr = "[Notify] Messages that HRSS sends To SDK"
                    Case Result_.HRSS_PR_COMM_MSG
                        CallBackStr = "[Notify] Which comments Of PR have messages"
                    Case Result_.HRSS_EXT_AX_SENS_LIM_LIGHT_DISP
                        CallBackStr = "[Notify] External axis sensor limit light display"
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.CLEAR_ALARM
                Select Case result
                    Case Result_.HRSS_START_CLEAR_ALARM
                        CallBackStr = "[Notify] Start to clean alarm."
                    Case Result_.HRSS_FINISH_CLEAR_ALARM
                        CallBackStr = "[Notify] Finish cleaning alarm."
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.DELETE_HRSS
                Select Case result
                    Case Result_.HRSS_DEL_BACKUP_FAILED
                        CallBackStr = "[Notify] Delete HRSS backup file failed; file does not exist."
                    Case Result_.HRSS_DEL_BACKUP_SUCC
                        CallBackStr = "[Notify] Delete HRSS backup file successful."
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.DW_CATERPILLAR
                Select Case result
                    Case Result_.HRSS_DW_CATERPILLAR_FAILED
                        CallBackStr = "[Notify] Download Caterpillar failed."
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.EX_EXT_TASK
                Select Case result
                    Case Result_.GEN_RES
                        CallBackStr = "[Notify] Execute ext_task_start."
                    Case Result_.HRSS_TASK_START_ALREADY_EX
                        CallBackStr = "[Notify] ext_task_start already executing."
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.TASK_START
                Select Case result
                    Case Result_.ALREADY_MOTION
                        CallBackStr = "[Notify] There is already motion executing before executing task_start."
                    Case Result_.HRSS_TASK_START_FINISH
                        CallBackStr = "[Notify] Task start finish."
                    Case Result_.ERROR_OPEN_FILE_FAIL
                        CallBackStr = "[Notify] Open file failed."
                    Case Result_.HRSS_TASK_START_NAME_ERR
                        CallBackStr = "[Notify] task_start file name error."
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.TASK_STOP
                Select Case result
                    Case Result_.HRSS_TAST_STOP
                        CallBackStr = "[Notify] Stop task"
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.DW_FILE
                Select Case result
                    Case Result_.GEN_RES
                        CallBackStr = "[Notify] Download file"
                    Case Result_.DW_FILE_NE
                        CallBackStr = "[Notify] Download file does not exist."
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.UPDATE_HRSS
                Select Case result
                    Case Result_.HRSS_UPDATE_FILE_ERROR
                        CallBackStr = "[Notify] Updated file error."
                    Case Result_.HRSS_UPDATE_FILE_TRANSFER_ERROR
                        CallBackStr = "[Notify] File transfer failure."
                    Case Result_.HRSS_UPDATE_FILE_UNARCHIVER_ERROR
                        CallBackStr = "[Notify] Updated file compression failure."
                    Case Result_.HRSS_HARD_DISK_CAPACITY_IS_NOT_ENOUTH
                        CallBackStr = "[Notify] Insufficient of controller space."
                    Case Result_.HRSS_START_UPDATE
                        CallBackStr = "[Notify] Start to update HRSS."
                    Case Result_.HRSS_UPDATE_FILE_TRANSFER_SUCCESS
                        CallBackStr = "[Notify] Upload update file success."
                    Case Else
                        CallBackStr = "[Notify] Offline can not be updated."
                End Select
            Case Command_.ART_ROB_INFO
                Select Case result
                    Case Result_.GEN_RES
                        CallBackStr = "[Notify] Articulated robot information."
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.TCP_IP_COMM
                Select Case result
                    Case Result_.GEN_RES
                        CallBackStr = "[Notify] TCP/IP communication connection successful."
                    Case Result_.TCP_IP_COMM_FAILED
                        CallBackStr = "[Notify] TCP/IP communication connection failed."
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.EXT_AX_MAST
                Select Case result
                    Case Result_.HRSS_EXT_AX_MAST_START
                        CallBackStr = "[Notify] External axis Mastering starts executing"
                    Case Result_.HRSS_EXT_AX_MAST_END
                        CallBackStr = "[Notify] External axis Mastering ended"
                    Case Result_.HRSS_EXT_MAST_FAILED_MOV
                        CallBackStr = "[Notify] External axis Mastering failed; there is an external axis currently moving."
                    Case Result_.HRSS_EXT_MAST_FAILED
                        CallBackStr = "[Notify] External axis Mastering failed."
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.API_INST_PRS
                Select Case result
                    Case Result_.API_INST_PRS_FAILED
                        CallBackStr = "[Notify] API instructing parsing failed."
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.IO_MOD_SAVE
                Select Case result
                    Case Result_.IO_MOD_SAVE_SUCC
                        CallBackStr = "[Notify] Module IO saved successfully."
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Command_.DIO_SET
                Select Case result
                    Case Result_.DIO_SET_SUCC
                        CallBackStr = "[Notify] DIO set successfully."
                    Case Else
                        CallBackStr = "INVALID HRSDK CODE!"
                End Select
            Case Else
                CallBackStr = "INVALID HRSDK CODE!"
        End Select

    End Sub

    Private Function ConnectDisconnect() As ProductsVersions
        ' Connects/disconnect to/from a robot

        Dim result As ProductsVersions

        Dim v As StringBuilder = New StringBuilder(256)
        Dim z As StringBuilder = New StringBuilder(256)
        Dim y As StringBuilder = New StringBuilder(256)
        Dim ovr As Integer
        Dim testid As Integer

        Try
            If IsConnected = False Then                                                                 ' Connects
                HROBOT = open_connection(txtIP.Text, 1, ConnFeed)
                get_hrsdk_version(v)
                get_hrss_version(HROBOT, z)
                get_robot_type(HROBOT, y)
                result.v_HRSDK = v.ToString()
                result.v_HRSS = z.ToString()
                result.t_robot = y.ToString()
                If get_hrss_mode(HROBOT) <> 3 Then
                    MsgBox("Please make sure that EXT mode is set.", MsgBoxStyle.Exclamation)
                Else
                    IsConnected = True
                    set_connection_level(HROBOT, 1)
                    ovr = get_override_ratio(HROBOT)
                    trkSpeed.Value = ovr
                    btnUpdate.Enabled = True
                    '  btnTime.Enabled = True
                    btnResetAll.Enabled = True
                    btnPrePos.Enabled = True
                    btnClearPrg.Enabled = True
                    ' btnContMov.Enabled = True
                    ' btnRepeat.Enabled = True
                    btnLibrary.Enabled = True
                    btnClearAlarms.Enabled = True
                    trkSpeed.Enabled = True
                    lbl1.Enabled = True
                    lbl100.Enabled = True
                    lblSpeed.Enabled = True
                    txtIP.Enabled = False
                    ssConnectionStatus.Text = "Robot: " & result.t_robot & ", HRSS version: " & result.v_HRSS & ", HRSDK version: " & result.v_HRSDK
                    btnConnect.BackgroundImage = My.Resources.OnOff_on
                End If
            Else                                                                                        ' Disconnects
                disconnect(HROBOT)
                result.v_HRSDK = String.Empty
                result.v_HRSS = String.Empty
                result.t_robot = String.Empty
                IsConnected = False
                btnUpdate.Enabled = False
                btnTime.Enabled = False
                btnResetAll.Enabled = False
                btnPrePos.Enabled = False
                btnClearPrg.Enabled = False
                btnContMov.Enabled = False
                btnRepeat.Enabled = False
                btnLibrary.Enabled = False
                btnClearAlarms.Enabled = False
                trkSpeed.Enabled = False
                lbl1.Enabled = False
                lbl100.Enabled = False
                lblSpeed.Enabled = False
                txtIP.Enabled = True
                ssConnectionStatus.Text = "Robot disconnected"
                btnConnect.BackgroundImage = My.Resources.OnOff
            End If
        Catch ex As Exception
            result.v_HRSDK = String.Empty
            result.v_HRSS = String.Empty
            result.t_robot = String.Empty
            MsgBox(ex.Message)
        End Try

        Return result

    End Function

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        ProdVers = ConnectDisconnect()

    End Sub

    ' UI

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Icon = My.Resources.HiwinRobotSetup

    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        btnConnect.Left = Me.Width - 105
        trkSpeed.Left = Me.Width - 105
        lbl1.Left = Me.Width - 72
        lbl100.Left = Me.Width - 72
        lblSpeed.Left = Me.Width - 72
        txtIP.Left = Me.Width - 105

    End Sub

    ' Program utilities

    Private Sub trkSpeed_Scroll(sender As Object, e As EventArgs) Handles trkSpeed.Scroll
        ' Changes the current speed of the robot

        If IsConnected Then

            set_override_ratio(HROBOT, trkSpeed.Value)

        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Updates the HRSS version after selecting a valid setup file path

        Dim res As Integer

        If IsConnected Then

            If ofdUpdate.ShowDialog = DialogResult.OK Then
                res = update_hrss(HROBOT, ofdUpdate.FileName)

                If res <> 0 Then MsgBox("Error updating HRSS. Error code: " & res, MsgBoxStyle.Exclamation)
            End If

        End If

    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        ' Changes time settings

        If IsConnected Then

            frmTime.ShowDialog()

        End If

    End Sub

    Private Sub btnResetAll_Click(sender As Object, e As EventArgs) Handles btnResetAll.Click
        ' Resets all registries, bases, tools, payloads

        If IsConnected Then
            frmProgress.Show()
            frmProgress.lblStatus.Text = "Clearing DI..."
            frmProgress.pb.Value = 0
            frmProgress.Refresh()
            ClearAllDI()
            frmProgress.lblStatus.Text = "Clearing DO..."
            frmProgress.pb.Value = 1 * 100 / 18
            frmProgress.Refresh()
            ClearAllDO()
            frmProgress.lblStatus.Text = "Clearing RO..."
            frmProgress.pb.Value = 2 * 100 / 18
            frmProgress.Refresh()
            ClearAllRO()
            frmProgress.lblStatus.Text = "Clearing VO..."
            frmProgress.pb.Value = 3 * 100 / 18
            frmProgress.Refresh()
            ClearAllVO()
            frmProgress.lblStatus.Text = "Clearing SI..."
            frmProgress.pb.Value = 4 * 100 / 18
            frmProgress.Refresh()
            ClearAllSI()
            frmProgress.lblStatus.Text = "Clearing SO..."
            frmProgress.pb.Value = 5 * 100 / 18
            frmProgress.Refresh()
            ClearAllSO()
            frmProgress.lblStatus.Text = "Clearing MI..."
            frmProgress.pb.Value = 6 * 100 / 18
            frmProgress.Refresh()
            ClearAllMI()
            frmProgress.lblStatus.Text = "Clearing MO..."
            frmProgress.pb.Value = 7 * 100 / 18
            frmProgress.Refresh()
            ClearAllMO()
            frmProgress.lblStatus.Text = "Clearing C..."
            frmProgress.pb.Value = 8 * 100 / 18
            frmProgress.Refresh()
            ClearAllC()
            frmProgress.lblStatus.Text = "Clearing T..."
            frmProgress.pb.Value = 9 * 100 / 18
            frmProgress.Refresh()
            ClearAllT()
            frmProgress.lblStatus.Text = "Clearing SRW..."
            frmProgress.pb.Value = 10 * 100 / 18
            frmProgress.Refresh()
            ClearAllSRW()
            frmProgress.lblStatus.Text = "Clearing bases..."
            frmProgress.pb.Value = 11 * 100 / 18
            frmProgress.Refresh()
            ClearAllBases()
            frmProgress.lblStatus.Text = "Clearing tools..."
            frmProgress.pb.Value = 12 * 100 / 18
            frmProgress.Refresh()
            ClearAllTools()
            frmProgress.lblStatus.Text = "Clearing payloads..."
            frmProgress.pb.Value = 13 * 100 / 18
            frmProgress.Refresh()
            ClearAllPayloads()
            frmProgress.lblStatus.Text = "Clearing RSR..."
            frmProgress.pb.Value = 14 * 100 / 18
            frmProgress.Refresh()
            ClearAllRSR()
            frmProgress.lblStatus.Text = "Clearing user alarms..."
            frmProgress.pb.Value = 15 * 100 / 18
            frmProgress.Refresh()
            ClearAllUserAlarms()
            frmProgress.lblStatus.Text = "Clearing PR..."
            frmProgress.pb.Value = 16 * 100 / 18
            frmProgress.Refresh()
            ClearAllPR()
            frmProgress.lblStatus.Text = "Clearing DIO settings..."
            frmProgress.pb.Value = 17 * 100 / 18
            frmProgress.Refresh()
            ClearAllDIOSettings()
            frmProgress.lblStatus.Text = "Clearing soft limits..."
            ClearAllSoftLimitSettings()
            frmProgress.pb.Value = 18 * 100 / 18
            frmProgress.Hide()
        End If

    End Sub

    Private Sub btnPrePos_Click(sender As Object, e As EventArgs) Handles btnPrePos.Click
        ' Disables the PrePos check and restores the default warning settings and home position

        Dim SysInfo(3) As Integer
        Dim PortInfo(6) As Integer
        Dim AxisInfo(7) As Double

        set_home_warning_setting(HROBOT, {1, 1, 1, 1, 1, 1, 1, 1, 1}, {1, 1, 1, 1, 1, 1, 1, 1, 1})
        set_home_setting_enable(HROBOT, False)
        get_robot_data(HROBOT, SysInfo, PortInfo, AxisInfo)
        Select Case SysInfo(2)
            Case 4                                                                                      ' 4 axis robot
                set_home_point(HROBOT, {0, 0, 0, 0, 0, 0})
            Case 6                                                                                      ' 6 axis robot
                set_home_point(HROBOT, {0, 0, 0, 0, -90, 0})
        End Select
        set_ext_home_point(HROBOT, {0, 0, 0})

    End Sub

    Private Sub btnClearPrg_Click(sender As Object, e As EventArgs) Handles btnClearPrg.Click
        ' Removes all installed programs

        Dim nFilesAndFolders As Integer = get_prog_number(HROBOT)                       ' Total number of files and folders
        Dim promptText As String = String.Empty
        Dim FileFolderName As New StringBuilder
        Dim FilesAndFolders As New List(Of String)

        ' Retrieves the list of files and folders in the robot controller
        If nFilesAndFolders > 0 Then
            FilesAndFolders.Clear()
            For i = 0 To nFilesAndFolders - 1
                get_prog_name(HROBOT, i, FileFolderName)
                FilesAndFolders.Add(FileFolderName.ToString)
            Next
            ' Separates files and folders and deletes them
            For Each elem In FilesAndFolders
                If StrComp(Strings.Right(elem, 4), ".hrb") = 0 Then
                    delete_file(HROBOT, elem)
                Else
                    delete_folder(HROBOT, elem)
                End If
            Next

        End If

    End Sub

    Private Sub btnContMov_Click(sender As Object, e As EventArgs) Handles btnContMov.Click
        ' Performs the continuous movement test to check possible issues with the robot

        frmContMov.Show()

    End Sub

    Private Sub btnRepeat_Click(sender As Object, e As EventArgs) Handles btnRepeat.Click
        ' Performs the repeatability test to verify the robot position repeatability

        frmRepeat.Show()

    End Sub

    Private Sub btnLibrary_Click(sender As Object, e As EventArgs) Handles btnLibrary.Click
        ' Loads the programs from the Hiwin library

        Dim di As New IO.DirectoryInfo(Application.StartupPath & "\HIWIN_Library\")
        Dim hrbFi As IO.FileInfo() = di.GetFiles("*.hrb")

        new_folder(HROBOT, "HIWIN_Library")
        For Each fi As IO.FileInfo In hrbFi
            send_file(HROBOT, Application.StartupPath & "\HIWIN_Library\" & fi.Name, "HIWIN_Library\" & fi.Name)
        Next

    End Sub

    Private Sub btnClearAlarms_Click(sender As Object, e As EventArgs) Handles btnClearAlarms.Click
        ' Clears alarms

        If IsConnected Then clear_alarm(HROBOT)

    End Sub

    ' Subs and functions used in the code

    Sub String2UShort(str As String, new_comment As UShort())
        ' Converts a String into a UShort array

        For i As Integer = 0 To str.Length - 1
            new_comment(i) = Convert.ToUInt16(str(i))
        Next

    End Sub

    Function UShort2String(comment As UShort()) As String
        ' Converts a UShort array into a String

        Dim result As String = String.Empty

        If comment.Length > 0 Then
            For i = 0 To comment.Length
                result = result & comment(i)
            Next
        Else
            result = "NULL"
        End If

        Return result

    End Function

    Private Sub ClearAllDI()
        ' Clears all DI comments and SIM checkboxes

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        For i = 1 To 48
            frmProgress.lblStatus.Text = "Clearing DI (" & i & "/48)..."
            frmProgress.Refresh()
            set_DI_simulation_Enable(HROBOT, i, False)
            set_digital_input_comment(HROBOT, i, empty_comment)
        Next

    End Sub

    Private Sub ClearAllDO()
        ' Clears all DO values and comments

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        For i = 1 To 48
            frmProgress.lblStatus.Text = "Clearing DO (" & i & "/48)..."
            frmProgress.Refresh()
            set_digital_output(HROBOT, i, False)
            set_digital_output_comment(HROBOT, i, empty_comment)
        Next

    End Sub

    Private Sub ClearAllRO()
        ' Clears all RO values

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        For i = 1 To 8
            frmProgress.lblStatus.Text = "Clearing RO (" & i & "/8)..."
            frmProgress.Refresh()
            set_robot_output(HROBOT, i, False)
        Next

    End Sub

    Private Sub ClearAllVO()
        ' Clears all VO values

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        For i = 1 To 3
            frmProgress.lblStatus.Text = "Clearing VO (" & i & "/3)..."
            frmProgress.Refresh()
            set_valve_output(HROBOT, i, False)
        Next

    End Sub

    Private Sub ClearAllMI()
        ' Clears all MI values

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        For i = 1 To 32
            frmProgress.lblStatus.Text = "Clearing MI (" & i & "/32)..."
            frmProgress.Refresh()
            set_module_input_start(HROBOT, i, 0)
            set_module_input_end(HROBOT, i, 0)
            set_module_input_comment(HROBOT, i, empty_comment)
            set_module_input_simulation(HROBOT, i, False)
            set_module_input_type(HROBOT, i, 0)
            set_module_input_value(HROBOT, i, False)
        Next

    End Sub

    Private Sub ClearAllMO()
        ' Clears all MO values

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        For i = 1 To 32
            frmProgress.lblStatus.Text = "Clearing MO (" & i & "/32)..."
            frmProgress.Refresh()
            set_module_output_start(HROBOT, i, 0)
            set_module_output_end(HROBOT, i, 0)
            set_module_output_comment(HROBOT, i, empty_comment)
            set_module_output_type(HROBOT, i, 0)
            set_module_output_value(HROBOT, i, False)
        Next

    End Sub

    Private Sub ClearAllSI()
        ' Clears all SI comments and SIM checkboxes

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        For i = 1 To 211
            frmProgress.lblStatus.Text = "Clearing SI (" & i & "/211)..."
            frmProgress.Refresh()
            set_fieldbus_input_comment(HROBOT, i, empty_comment)
            set_fieldbus_input_sim(HROBOT, i, 0)
        Next

    End Sub

    Private Sub ClearAllSO()
        ' Clears all SO values and comments

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        For i = 1 To 211
            frmProgress.lblStatus.Text = "Clearing SO (" & i & "/211)..."
            frmProgress.Refresh()
            set_fieldbus_output(HROBOT, i, 0)
            set_fieldbus_output_comment(HROBOT, i, empty_comment)
        Next

    End Sub

    Private Sub ClearAllC()
        ' Clears all C values and comments

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        For i = 1 To 20
            frmProgress.lblStatus.Text = "Clearing C (" & i & "/20)..."
            frmProgress.Refresh()
            set_counter(HROBOT, i, 0)
            set_counter_name(HROBOT, i, empty_comment)
        Next

    End Sub

    Private Sub ClearAllT()
        ' Clears all T values and comments

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        For i = 1 To 20
            frmProgress.lblStatus.Text = "Clearing T (" & i & "/20)..."
            frmProgress.Refresh()
            set_timer(HROBOT, i, 0)
            set_timer_name(HROBOT, i, empty_comment)
        Next

    End Sub

    Private Sub ClearAllSRW()
        ' Clears all SRW values and comments

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        ' Dim testParam(40) As UShort
        ' Dim testStr As String = String.Empty

        For i = 1 To 32
            frmProgress.lblStatus.Text = "Clearing SRW (" & i & "/32)..."
            frmProgress.Refresh()
            set_fieldbus_rs_comment(HROBOT, i, empty_comment)
            clean_fieldbus_rs_parameter(HROBOT, i)
            set_fieldbus_srw_array(HROBOT, {i}, {0}, 1)
            '   set_fieldbus_rs_parameter(HROBOT, i, testParam)
        Next

        ' get_fieldbus_rs_parameter(HROBOT, 6, testParam)
        ' For i = 0 To 39
        '     testStr = testStr & testParam(i) & "|"
        '  Next
        ' testStr = testStr & vbCrLf

        ' testParam(0) = Encoding.UTF8.GetBytes("3")(0) * (2 ^ 8) + Encoding.UTF8.GetBytes("A")(0)
        ' testParam(1) = Encoding.UTF8.GetBytes("T")(0) * (2 ^ 8) + Encoding.UTF8.GetBytes("_")(0)
        ' testParam(2) = Encoding.UTF8.GetBytes("R")(0) * (2 ^ 8) + Encoding.UTF8.GetBytes("O")(0)
        ' testParam(3) = Encoding.UTF8.GetBytes("U")(0) * (2 ^ 8) + Encoding.UTF8.GetBytes("Q")(0)
        ' testParam(4) = Encoding.UTF8.GetBytes("E")(0)
        ' For i = 5 To 39
        ' testParam(i) = 0
        ' Next

        ' testParam(0) = Encoding.UTF8.GetBytes("C")(0) * (2 ^ 8) + Encoding.UTF8.GetBytes("A")(0)
        ' testParam(1) = Encoding.UTF8.GetBytes("_")(0) * (2 ^ 8) + Encoding.UTF8.GetBytes("C")(0)
        ' testParam(2) = Encoding.UTF8.GetBytes("I")(0) * (2 ^ 8) + Encoding.UTF8.GetBytes("T")(0)
        ' testParam(3) = Encoding.UTF8.GetBytes("E")(0) * (2 ^ 8) + Encoding.UTF8.GetBytes("M")(0)
        ' For i = 4 To 39
        '  testParam(i) = 0
        ' Next

    End Sub

    Private Sub ClearAllBases()
        ' Clears all the bases

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        For i = 1 To 31
            frmProgress.lblStatus.Text = "Clearing bases (" & i & "/31)..."
            frmProgress.Refresh()
            clear_base_data(HROBOT, i)
        Next
        set_base_number(HROBOT, 0)

    End Sub

    Private Sub ClearAllTools()
        ' Clears all the tools

        Dim empty_comment(40) As UShort
        String2UShort(String.Empty, empty_comment)

        For i = 1 To 15
            frmProgress.lblStatus.Text = "Clearing tools (" & i & "/15)..."
            frmProgress.Refresh()
            clear_tool_data(HROBOT, i)
        Next
        set_tool_number(HROBOT, 0)

    End Sub

    Private Sub ClearAllPayloads()
        ' Clears all the payloads

        set_payload_active(HROBOT, 0)
        For i = 1 To 19
            frmProgress.lblStatus.Text = "Clearing payloads (" & i & "/19)..."
            frmProgress.Refresh()
            set_payload_config(HROBOT, i, {0, 0, 0, 0, 0, 0, 0}, New StringBuilder(String.Empty))
        Next

    End Sub

    Private Sub ClearAllRSR()
        ' Clears all RSR slots

        For i = 1 To 4
            frmProgress.lblStatus.Text = "Clearing RSR (" & i & "/4)..."
            frmProgress.Refresh()
            remove_rsr(HROBOT, i)
        Next

    End Sub

    Private Sub ClearAllUserAlarms()
        ' Clears all user alarm prompts

        For i = 1 To 10
            set_user_alarm_setting_message(HROBOT, i, New StringBuilder("User Setting Error"))
        Next

    End Sub

    Private Sub ClearAllPR()
        ' Clears all point registers

        For i = 1 To 4000
            frmProgress.lblStatus.Text = "Clearing PR (" & i & "/4000)..."
            frmProgress.Refresh()
            remove_pr(HROBOT, i)
        Next

    End Sub

    Private Sub ClearAllDIOSettings()
        ' Clears the DIO settings

        Dim txt As New StringBuilder("User Define Alarm")

        set_digital_setting(HROBOT, {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, txt)

    End Sub

    Private Sub ClearAllSoftLimitSettings()
        ' Clears the soft limit settings

        Dim empty3(3) As Double
        Dim empty6(6) As Double

        enable_cart_soft_limit(HROBOT, False)
        enable_joint_soft_limit(HROBOT, False)
        set_cart_soft_limit(HROBOT, empty3, empty3)
        set_joint_soft_limit(HROBOT, empty6, empty6)

    End Sub

    Private Sub GetErrorMessage()
        ' Gets the text of the last error message

        Dim msg(40) As UShort
        Dim byteArr(2) As Byte
        Dim StrPrompt As String = String.Empty
        get_error_msg(HROBOT, msg)
        For i = 0 To msg.Length - 1
            byteArr = BitConverter.GetBytes(msg(i))
            StrPrompt = StrPrompt & ChrW(byteArr(0)) & ChrW(byteArr(1))
        Next
        MsgBox(StrPrompt)

    End Sub

End Class