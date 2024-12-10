Public Class frmTime

    Dim tYear As Integer
    Dim tMonth As Integer
    Dim tDay As Integer
    Dim tHour As Integer
    Dim tMinute As Integer
    Dim tSecond As Integer

    ' Initialization

    Private Sub frmTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Reads the current time when opening the window

        Dim res As Integer

        If frmMain.IsConnected Then

            res = get_controller_time(frmMain.HROBOT, tYear, tMonth, tDay, tHour, tMinute, tSecond)

            If res = 0 Then
                txtYear.Text = tYear
                If CStr(tMonth).Length < 2 Then
                    txtMonth.Text = "0" & tMonth
                Else
                    txtMonth.Text = tMonth
                End If
                If CStr(tDay).Length < 2 Then
                    txtDay.Text = "0" & tDay
                Else
                    txtDay.Text = tDay
                End If
                If CStr(tHour).Length < 2 Then
                    txtHour.Text = "0" & tHour
                Else
                    txtHour.Text = tHour
                End If
                If CStr(tMinute).Length < 2 Then
                    txtMinute.Text = "0" & tMinute
                Else
                    txtMinute.Text = tMinute
                End If
                If CStr(tSecond).Length < 2 Then
                    txtSecond.Text = "0" & tSecond
                Else
                    txtSecond.Text = tSecond
                End If
            Else
                MsgBox("Error reading time settings. Error code: " & res, MsgBoxStyle.Exclamation)
            End If

        End If

    End Sub

    ' Time updating

    Private Sub btnAddHour_Click(sender As Object, e As EventArgs) Handles btnAddHour.Click

        If CInt(txtHour.Text) < 23 Then
            txtHour.Text = CInt(txtHour.Text) + 1
            If txtHour.Text.Length < 2 Then txtHour.Text = "0" & txtHour.Text
        End If

    End Sub

    Private Sub btnRemoveHour_Click(sender As Object, e As EventArgs) Handles btnRemoveHour.Click

        If CInt(txtHour.Text) > 0 Then
            txtHour.Text = CInt(txtHour.Text) - 1
            If txtHour.Text.Length < 2 Then txtHour.Text = "0" & txtHour.Text
        End If

    End Sub

    Private Sub btnAddMinute_Click(sender As Object, e As EventArgs) Handles btnAddMinute.Click

        If CInt(txtMinute.Text) < 59 Then
            txtMinute.Text = CInt(txtMinute.Text) + 1
            If txtMinute.Text.Length < 2 Then txtMinute.Text = "0" & txtMinute.Text
        End If

    End Sub

    Private Sub btnRemoveMinute_Click(sender As Object, e As EventArgs) Handles btnRemoveMinute.Click

        If CInt(txtMinute.Text) > 0 Then
            txtMinute.Text = CInt(txtMinute.Text) - 1
            If txtMinute.Text.Length < 2 Then txtMinute.Text = "0" & txtMinute.Text
        End If

    End Sub

    Private Sub btnAddSecond_Click(sender As Object, e As EventArgs) Handles btnAddSecond.Click

        If CInt(txtSecond.Text) < 59 Then
            txtSecond.Text = CInt(txtSecond.Text) + 1
            If txtSecond.Text.Length < 2 Then txtSecond.Text = "0" & txtSecond.Text
        End If

    End Sub

    Private Sub btnRemoveSecond_Click(sender As Object, e As EventArgs) Handles btnRemoveSecond.Click

        If CInt(txtSecond.Text) > 0 Then
            txtSecond.Text = CInt(txtSecond.Text) - 1
            If txtSecond.Text.Length < 2 Then txtSecond.Text = "0" & txtSecond.Text
        End If

    End Sub

    Private Sub btnAddDay_Click(sender As Object, e As EventArgs) Handles btnAddDay.Click

        If CInt(txtDay.Text) < 31 Then
            txtDay.Text = CInt(txtDay.Text) + 1
            If txtDay.Text.Length < 2 Then txtDay.Text = "0" & txtDay.Text
        End If

    End Sub

    Private Sub btnRemoveDay_Click(sender As Object, e As EventArgs) Handles btnRemoveDay.Click

        If CInt(txtDay.Text) > 1 Then
            txtDay.Text = CInt(txtDay.Text) - 1
            If txtDay.Text.Length < 2 Then txtDay.Text = "0" & txtDay.Text
        End If

    End Sub

    Private Sub btnAddMonth_Click(sender As Object, e As EventArgs) Handles btnAddMonth.Click

        If CInt(txtMonth.Text) < 12 Then
            txtMonth.Text = CInt(txtMonth.Text) + 1
            If txtMonth.Text.Length < 2 Then txtMonth.Text = "0" & txtMonth.Text
        End If

    End Sub

    Private Sub btnRemoveMonth_Click(sender As Object, e As EventArgs) Handles btnRemoveMonth.Click

        If CInt(txtMonth.Text) > 1 Then
            txtMonth.Text = CInt(txtMonth.Text) - 1
            If txtMonth.Text.Length < 2 Then txtMonth.Text = "0" & txtMonth.Text
        End If

    End Sub

    Private Sub btnAddYear_Click(sender As Object, e As EventArgs) Handles btnAddYear.Click

        If CInt(txtYear.Text) < 2070 Then
            txtYear.Text = CInt(txtYear.Text) + 1
            If txtYear.Text.Length < 2 Then txtYear.Text = "0" & txtYear.Text
        End If

    End Sub

    Private Sub btnRemoveYear_Click(sender As Object, e As EventArgs) Handles btnRemoveYear.Click

        If CInt(txtYear.Text) > 1970 Then
            txtYear.Text = CInt(txtYear.Text) - 1
            If txtYear.Text.Length < 2 Then txtYear.Text = "0" & txtYear.Text
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim res As Integer

        If frmMain.IsConnected Then

            tYear = CInt(txtYear.Text)
            tMonth = CInt(txtMonth.Text)
            tDay = CInt(txtDay.Text)
            tHour = CInt(txtHour.Text)
            tMinute = CInt(txtMinute.Text)
            tSecond = CInt(txtSecond.Text)

            res = set_controller_time(frmMain.HROBOT, tYear, tMonth, tDay, tHour, tMinute, tSecond)

            If res <> 0 Then

                MsgBox("Error writing time settings. Error code: " & res, MsgBoxStyle.Exclamation)

            End If

        End If

    End Sub

End Class