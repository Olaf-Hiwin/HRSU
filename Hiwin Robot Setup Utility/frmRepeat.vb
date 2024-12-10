Imports System.Threading

Public Class frmRepeat

    Public IsRepeatRunning As Boolean = False
    Dim Iterations As Integer = 0
    Public listeningThr As Thread = Nothing

    Private Sub btnPointFarCopy_Click(sender As Object, e As EventArgs) Handles btnPointFarCopy.Click

        Dim currPos(6) As Double
        Dim res As Integer

        If frmMain.IsConnected Then
            res = get_current_joint(frmMain.HROBOT, currPos)
            If res <> 0 Then
                MsgBox("Error reading robot configuration. Error code: " & res, MsgBoxStyle.Exclamation)
            Else
                txtPointFarA1.Text = currPos(0)
                txtPointFarA2.Text = currPos(1)
                txtPointFarA3.Text = currPos(2)
                txtPointFarA4.Text = currPos(3)
                txtPointFarA5.Text = currPos(4)
                txtPointFarA6.Text = currPos(5)
            End If
        End If

    End Sub

    Private Sub btnPointApproachCopy_Click(sender As Object, e As EventArgs) Handles btnPointApproachCopy.Click

        Dim currPos(6) As Double
        Dim res As Integer

        If frmMain.IsConnected Then
            res = get_current_joint(frmMain.HROBOT, currPos)
            If res <> 0 Then
                MsgBox("Error reading robot configuration. Error code: " & res, MsgBoxStyle.Exclamation)
            Else
                txtPointApproachA1.Text = currPos(0)
                txtPointApproachA2.Text = currPos(1)
                txtPointApproachA3.Text = currPos(2)
                txtPointApproachA4.Text = currPos(3)
                txtPointApproachA5.Text = currPos(4)
                txtPointApproachA6.Text = currPos(5)
            End If
        End If

    End Sub

    Private Sub btnPointContactCopy_Click(sender As Object, e As EventArgs) Handles btnPointContactCopy.Click

        Dim currPos(6) As Double
        Dim res As Integer

        If frmMain.IsConnected Then
            res = get_current_joint(frmMain.HROBOT, currPos)
            If res <> 0 Then
                MsgBox("Error reading robot configuration. Error code: " & res, MsgBoxStyle.Exclamation)
            Else
                txtPointContactA1.Text = currPos(0)
                txtPointContactA2.Text = currPos(1)
                txtPointContactA3.Text = currPos(2)
                txtPointContactA4.Text = currPos(3)
                txtPointContactA5.Text = currPos(4)
                txtPointContactA6.Text = currPos(5)
            End If
        End If

    End Sub

    Private Sub btnA1Plus_Click(sender As Object, e As EventArgs) Handles btnA1Plus.Click

        Dim res As Integer
        Dim currPos(6) As Double

        If frmMain.IsConnected Then
            get_current_joint(frmMain.HROBOT, currPos)
            res = ptp_axis(frmMain.HROBOT, 0, {currPos(0) + 10, currPos(1), currPos(2), currPos(3), currPos(4), currPos(5)})
        End If

    End Sub

    Private Sub btnA1Minus_Click(sender As Object, e As EventArgs) Handles btnA1Minus.Click

        Dim res As Integer
        Dim currPos(6) As Double

        If frmMain.IsConnected Then
            get_current_joint(frmMain.HROBOT, currPos)
            res = ptp_axis(frmMain.HROBOT, 0, {currPos(0) - 10, currPos(1), currPos(2), currPos(3), currPos(4), currPos(5)})
        End If

    End Sub

    Private Sub btnA2Plus_Click(sender As Object, e As EventArgs) Handles btnA2Plus.Click

        Dim res As Integer
        Dim currPos(6) As Double

        If frmMain.IsConnected Then
            get_current_joint(frmMain.HROBOT, currPos)
            res = ptp_axis(frmMain.HROBOT, 0, {currPos(0), currPos(1) + 10, currPos(2), currPos(3), currPos(4), currPos(5)})
        End If

    End Sub

    Private Sub btnA2Minus_Click(sender As Object, e As EventArgs) Handles btnA2Minus.Click

        Dim res As Integer
        Dim currPos(6) As Double

        If frmMain.IsConnected Then
            get_current_joint(frmMain.HROBOT, currPos)
            res = ptp_axis(frmMain.HROBOT, 0, {currPos(0), currPos(1) - 10, currPos(2), currPos(3), currPos(4), currPos(5)})
        End If

    End Sub

    Private Sub btnA3Plus_Click(sender As Object, e As EventArgs) Handles btnA3Plus.Click

        Dim res As Integer
        Dim currPos(6) As Double

        If frmMain.IsConnected Then
            get_current_joint(frmMain.HROBOT, currPos)
            res = ptp_axis(frmMain.HROBOT, 0, {currPos(0), currPos(1), currPos(2) + 10, currPos(3), currPos(4), currPos(5)})
        End If

    End Sub

    Private Sub btnA3Minus_Click(sender As Object, e As EventArgs) Handles btnA3Minus.Click

        Dim res As Integer
        Dim currPos(6) As Double

        If frmMain.IsConnected Then
            get_current_joint(frmMain.HROBOT, currPos)
            res = ptp_axis(frmMain.HROBOT, 0, {currPos(0), currPos(1), currPos(2) - 10, currPos(3), currPos(4), currPos(5)})
        End If

    End Sub

    Private Sub btnA4Plus_Click(sender As Object, e As EventArgs) Handles btnA4Plus.Click

        Dim res As Integer
        Dim currPos(6) As Double

        If frmMain.IsConnected Then
            get_current_joint(frmMain.HROBOT, currPos)
            res = ptp_axis(frmMain.HROBOT, 0, {currPos(0), currPos(1), currPos(2), currPos(3) + 10, currPos(4), currPos(5)})
        End If

    End Sub

    Private Sub btnA4Minus_Click(sender As Object, e As EventArgs) Handles btnA4Minus.Click

        Dim res As Integer
        Dim currPos(6) As Double

        If frmMain.IsConnected Then
            get_current_joint(frmMain.HROBOT, currPos)
            res = ptp_axis(frmMain.HROBOT, 0, {currPos(0), currPos(1), currPos(2), currPos(3) - 10, currPos(4), currPos(5)})
        End If

    End Sub

    Private Sub btnA5Plus_Click(sender As Object, e As EventArgs) Handles btnA5Plus.Click

        Dim res As Integer
        Dim currPos(6) As Double

        If frmMain.IsConnected Then
            get_current_joint(frmMain.HROBOT, currPos)
            res = ptp_axis(frmMain.HROBOT, 0, {currPos(0), currPos(1), currPos(2), currPos(3), currPos(4) + 10, currPos(5)})
        End If

    End Sub

    Private Sub btnA5Minus_Click(sender As Object, e As EventArgs) Handles btnA5Minus.Click

        Dim res As Integer
        Dim currPos(6) As Double

        If frmMain.IsConnected Then
            get_current_joint(frmMain.HROBOT, currPos)
            res = ptp_axis(frmMain.HROBOT, 0, {currPos(0), currPos(1), currPos(2), currPos(3), currPos(4) - 10, currPos(5)})
        End If

    End Sub

    Private Sub btnA6Plus_Click(sender As Object, e As EventArgs) Handles btnA6Plus.Click

        Dim res As Integer
        Dim currPos(6) As Double

        If frmMain.IsConnected Then
            get_current_joint(frmMain.HROBOT, currPos)
            res = ptp_axis(frmMain.HROBOT, 0, {currPos(0), currPos(1), currPos(2), currPos(3), currPos(4), currPos(5) + 10})
        End If

    End Sub

    Private Sub btnA6Minus_Click(sender As Object, e As EventArgs) Handles btnA6Minus.Click

        Dim res As Integer
        Dim currPos(6) As Double

        If frmMain.IsConnected Then
            get_current_joint(frmMain.HROBOT, currPos)
            res = ptp_axis(frmMain.HROBOT, 0, {currPos(0), currPos(1), currPos(2), currPos(3), currPos(4), currPos(5) - 10})
        End If

    End Sub

    Private Sub StartStop(sender As Object, e As EventArgs) Handles btnStart.Click, btnStop.Click

        If IsRepeatRunning = False Then
            btnA1Plus.Enabled = False
            btnA1Minus.Enabled = False
            btnA2Plus.Enabled = False
            btnA2Minus.Enabled = False
            btnA3Plus.Enabled = False
            btnA3Minus.Enabled = False
            btnA4Plus.Enabled = False
            btnA4Minus.Enabled = False
            btnA5Plus.Enabled = False
            btnA5Minus.Enabled = False
            btnA6Plus.Enabled = False
            btnA6Minus.Enabled = False
            btnStart.Enabled = False
            btnStop.Enabled = True
            btnPointFarCopy.Enabled = False
            btnPointApproachCopy.Enabled = False
            btnPointContactCopy.Enabled = False
            nudIterations.Enabled = False
            nudReading.Enabled = False
            IsRepeatRunning = True
            Iterations = 0
            lblPerformed.Text = "Performed iterations: 0"
            StartListeningThread()
        Else
            motion_abort(frmMain.HROBOT)
            btnA1Plus.Enabled = True
            btnA1Minus.Enabled = True
            btnA2Plus.Enabled = True
            btnA2Minus.Enabled = True
            btnA3Plus.Enabled = True
            btnA3Minus.Enabled = True
            btnA4Plus.Enabled = True
            btnA4Minus.Enabled = True
            btnA5Plus.Enabled = True
            btnA5Minus.Enabled = True
            btnA6Plus.Enabled = True
            btnA6Minus.Enabled = True
            btnStart.Enabled = True
            btnStop.Enabled = False
            btnPointFarCopy.Enabled = True
            btnPointApproachCopy.Enabled = True
            btnPointContactCopy.Enabled = True
            nudIterations.Enabled = True
            nudReading.Enabled = True
            IsRepeatRunning = False
            If listeningThr.IsAlive Then listeningThr.Abort()
        End If

    End Sub

    Private Sub IterationsCycle()

        If frmMain.IsConnected Then
            If IsRepeatRunning Then
                If Iterations = 0 Then ptp_axis(frmMain.HROBOT, 0, {txtPointApproachA1.Text, txtPointApproachA2.Text, txtPointApproachA3.Text, txtPointApproachA4.Text, txtPointApproachA5.Text, txtPointApproachA6.Text})
                While Iterations <= CInt(nudIterations.Value)
                    ptp_axis(frmMain.HROBOT, 0, {txtPointFarA1.Text, txtPointFarA2.Text, txtPointFarA3.Text, txtPointFarA4.Text, txtPointFarA5.Text, txtPointFarA6.Text})
                    ptp_axis(frmMain.HROBOT, 0, {txtPointApproachA1.Text, txtPointApproachA2.Text, txtPointApproachA3.Text, txtPointApproachA4.Text, txtPointApproachA5.Text, txtPointApproachA6.Text})
                    lin_axis(frmMain.HROBOT, 0, 0, {txtPointContactA1.Text, txtPointContactA2.Text, txtPointContactA3.Text, txtPointContactA4.Text, txtPointContactA5.Text, txtPointContactA6.Text})
                    motion_delay(frmMain.HROBOT, CInt(nudReading.Value))
                    lin_axis(frmMain.HROBOT, 0, 0, {txtPointApproachA1.Text, txtPointApproachA2.Text, txtPointApproachA3.Text, txtPointApproachA4.Text, txtPointApproachA5.Text, txtPointApproachA6.Text})
                    While get_command_count(frmMain.HROBOT) > 0
                    End While
                    Iterations += 1
                    SetITLBL(lblPerformed, Iterations)
                End While
            End If
        End If

    End Sub

    Public Sub StartListeningThread()
        ' Starts the listening thread to update the I/O data

        listeningThr = New Thread(AddressOf IterationCycleThread)                       ' Initializes a new listening thread instance
        listeningThr.Start()                                                            ' Starts the listening thread
        listeningThr.IsBackground = True                                                ' Sets the thread in background

    End Sub

    Private Sub IterationCycleThread()
        ' Performs the cyclic iteration

        While True

            If IsRepeatRunning Then
                IterationsCycle()
            End If

        End While

    End Sub

    Public Delegate Sub SetIterationLabel(itLbl As System.Windows.Forms.Label, val As Integer)

    Public Sub SetITLBL(itLbl As System.Windows.Forms.Label, val As Integer)
        ' Updates a ListView item with the given data

        If itLbl IsNot Nothing Then
            If itLbl.InvokeRequired Then
                itLbl.Invoke(New SetIterationLabel(AddressOf SetITLBL), New Object() {itLbl, val})
                Return
            End If
            itLbl.Text = "Performed iterations: " & val
        End If

    End Sub

End Class