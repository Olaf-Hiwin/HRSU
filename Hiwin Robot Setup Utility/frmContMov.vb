Public Class frmContMov

    Public IsContMovRunning As Boolean = False
    Dim ElapsedTime As Integer = 0

    Private Sub btnPointACopy_Click(sender As Object, e As EventArgs) Handles btnPointACopy.Click

        Dim currPos(6) As Double
        Dim res As Integer

        If frmMain.IsConnected Then
            res = get_current_joint(frmMain.HROBOT, currPos)
            If res <> 0 Then
                MsgBox("Error reading robot configuration. Error code: " & res, MsgBoxStyle.Exclamation)
            Else
                txtPointAA1.Text = currPos(0)
                txtPointAA2.Text = currPos(1)
                txtPointAA3.Text = currPos(2)
                txtPointAA4.Text = currPos(3)
                txtPointAA5.Text = currPos(4)
                txtPointAA6.Text = currPos(5)
            End If
        End If

    End Sub

    Private Sub btnPointBCopy_Click(sender As Object, e As EventArgs) Handles btnPointBCopy.Click

        Dim currPos(6) As Double
        Dim res As Integer

        If frmMain.IsConnected Then
            res = get_current_joint(frmMain.HROBOT, currPos)
            If res <> 0 Then
                MsgBox("Error reading robot configuration. Error code: " & res, MsgBoxStyle.Exclamation)
            Else
                txtPointBA1.Text = currPos(0)
                txtPointBA2.Text = currPos(1)
                txtPointBA3.Text = currPos(2)
                txtPointBA4.Text = currPos(3)
                txtPointBA5.Text = currPos(4)
                txtPointBA6.Text = currPos(5)
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

        If IsContMovRunning = False Then
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
            btnPointACopy.Enabled = False
            btnPointBCopy.Enabled = False
            nudDuration.Enabled = False
            IsContMovRunning = True
            ElapsedTime = 0
            lblElapsed.Text = "Elapsed time: 00 h, 00 m, 00 s"
            tmrElapsed.Start()
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
            btnPointACopy.Enabled = True
            btnPointBCopy.Enabled = True
            nudDuration.Enabled = True
            IsContMovRunning = False
            tmrElapsed.Stop()
        End If

    End Sub

    Private Sub tmrElapsed_Tick(sender As Object, e As EventArgs) Handles tmrElapsed.Tick

        lblElapsed.Text = "Elapsed time: " & HHMMSSFromSeconds(ElapsedTime)

        If ElapsedTime < (CInt(nudDuration.Value) * 60) Then
            MoveCommands()
            ElapsedTime += 1
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
            btnPointACopy.Enabled = True
            btnPointBCopy.Enabled = True
            nudDuration.Enabled = True
            IsContMovRunning = False
            tmrElapsed.Stop()
        End If

    End Sub

    Function HHMMSSFromSeconds(secs As Integer) As String

        Dim res As String = String.Empty
        Dim hh As Integer = 0
        Dim hhstr As String = String.Empty
        Dim mm As Integer = 0
        Dim mmstr As String = String.Empty
        Dim ss As Integer = 0
        Dim ssstr As String = String.Empty

        hh = Math.Floor(secs / 3600)
        mm = Math.Floor((secs - hh * 60) / 60)
        ss = secs - hh * 3600 - mm * 60

        If CStr(hh).Length < 2 Then
            hhstr = "0" & CStr(hh)
        Else
            hhstr = CStr(hh)
        End If
        If CStr(mm).Length < 2 Then
            mmstr = "0" & CStr(mm)
        Else
            mmstr = CStr(mm)
        End If
        If CStr(ss).Length < 2 Then
            ssstr = "0" & CStr(ss)
        Else
            ssstr = CStr(ss)
        End If

        res = hhstr & " h, " & mmstr & " m, " & ssstr & " s"

        Return res

    End Function

    Private Sub MoveCommands()

        If frmMain.IsConnected Then
            ptp_axis(frmMain.HROBOT, 0, {txtPointAA1.Text, txtPointAA2.Text, txtPointAA3.Text, txtPointAA4.Text, txtPointAA5.Text, txtPointAA6.Text})
            ptp_axis(frmMain.HROBOT, 0, {txtPointBA1.Text, txtPointBA2.Text, txtPointBA3.Text, txtPointBA4.Text, txtPointBA5.Text, txtPointBA6.Text})
        End If

    End Sub

End Class