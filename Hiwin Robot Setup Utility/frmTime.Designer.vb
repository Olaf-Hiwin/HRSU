<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTime
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtHour = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMinute = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.btnAddDay = New System.Windows.Forms.Button()
        Me.btnRemoveDay = New System.Windows.Forms.Button()
        Me.btnRemoveHour = New System.Windows.Forms.Button()
        Me.btnAddHour = New System.Windows.Forms.Button()
        Me.btnRemoveMinute = New System.Windows.Forms.Button()
        Me.btnAddMinute = New System.Windows.Forms.Button()
        Me.btnRemoveMonth = New System.Windows.Forms.Button()
        Me.btnAddMonth = New System.Windows.Forms.Button()
        Me.btnRemoveSecond = New System.Windows.Forms.Button()
        Me.btnAddSecond = New System.Windows.Forms.Button()
        Me.btnRemoveYear = New System.Windows.Forms.Button()
        Me.btnAddYear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtHour
        '
        Me.txtHour.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHour.Location = New System.Drawing.Point(238, 32)
        Me.txtHour.Name = "txtHour"
        Me.txtHour.ReadOnly = True
        Me.txtHour.Size = New System.Drawing.Size(38, 35)
        Me.txtHour.TabIndex = 0
        Me.txtHour.Text = "09"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Time (hh:mm:ss)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = ":"
        '
        'txtMinute
        '
        Me.txtMinute.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinute.Location = New System.Drawing.Point(320, 32)
        Me.txtMinute.Name = "txtMinute"
        Me.txtMinute.ReadOnly = True
        Me.txtMinute.Size = New System.Drawing.Size(38, 35)
        Me.txtMinute.TabIndex = 3
        Me.txtMinute.Text = "36"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(386, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = ":"
        '
        'txtSecond
        '
        Me.txtSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecond.Location = New System.Drawing.Point(401, 32)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.ReadOnly = True
        Me.txtSecond.Size = New System.Drawing.Size(38, 35)
        Me.txtSecond.TabIndex = 5
        Me.txtSecond.Text = "40"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date (dd:mm:yyyy)"
        '
        'btnUpdate
        '
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnUpdate.Location = New System.Drawing.Point(128, 138)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(123, 45)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(266, 138)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(123, 45)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(401, 81)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.ReadOnly = True
        Me.txtYear.Size = New System.Drawing.Size(66, 35)
        Me.txtYear.TabIndex = 13
        Me.txtYear.Text = "2024"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(386, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 29)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = ":"
        '
        'txtMonth
        '
        Me.txtMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonth.Location = New System.Drawing.Point(320, 81)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.ReadOnly = True
        Me.txtMonth.Size = New System.Drawing.Size(38, 35)
        Me.txtMonth.TabIndex = 11
        Me.txtMonth.Text = "01"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(304, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = ":"
        '
        'txtDay
        '
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.Location = New System.Drawing.Point(238, 81)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.ReadOnly = True
        Me.txtDay.Size = New System.Drawing.Size(38, 35)
        Me.txtDay.TabIndex = 9
        Me.txtDay.Text = "05"
        '
        'btnAddDay
        '
        Me.btnAddDay.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Add
        Me.btnAddDay.Location = New System.Drawing.Point(275, 81)
        Me.btnAddDay.Name = "btnAddDay"
        Me.btnAddDay.Size = New System.Drawing.Size(32, 19)
        Me.btnAddDay.TabIndex = 14
        Me.btnAddDay.UseVisualStyleBackColor = True
        '
        'btnRemoveDay
        '
        Me.btnRemoveDay.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Remove
        Me.btnRemoveDay.Location = New System.Drawing.Point(275, 98)
        Me.btnRemoveDay.Name = "btnRemoveDay"
        Me.btnRemoveDay.Size = New System.Drawing.Size(32, 19)
        Me.btnRemoveDay.TabIndex = 15
        Me.btnRemoveDay.UseVisualStyleBackColor = True
        '
        'btnRemoveHour
        '
        Me.btnRemoveHour.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Remove
        Me.btnRemoveHour.Location = New System.Drawing.Point(275, 49)
        Me.btnRemoveHour.Name = "btnRemoveHour"
        Me.btnRemoveHour.Size = New System.Drawing.Size(32, 19)
        Me.btnRemoveHour.TabIndex = 17
        Me.btnRemoveHour.UseVisualStyleBackColor = True
        '
        'btnAddHour
        '
        Me.btnAddHour.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Add
        Me.btnAddHour.Location = New System.Drawing.Point(275, 32)
        Me.btnAddHour.Name = "btnAddHour"
        Me.btnAddHour.Size = New System.Drawing.Size(32, 19)
        Me.btnAddHour.TabIndex = 16
        Me.btnAddHour.UseVisualStyleBackColor = True
        '
        'btnRemoveMinute
        '
        Me.btnRemoveMinute.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Remove
        Me.btnRemoveMinute.Location = New System.Drawing.Point(357, 49)
        Me.btnRemoveMinute.Name = "btnRemoveMinute"
        Me.btnRemoveMinute.Size = New System.Drawing.Size(32, 19)
        Me.btnRemoveMinute.TabIndex = 21
        Me.btnRemoveMinute.UseVisualStyleBackColor = True
        '
        'btnAddMinute
        '
        Me.btnAddMinute.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Add
        Me.btnAddMinute.Location = New System.Drawing.Point(357, 32)
        Me.btnAddMinute.Name = "btnAddMinute"
        Me.btnAddMinute.Size = New System.Drawing.Size(32, 19)
        Me.btnAddMinute.TabIndex = 20
        Me.btnAddMinute.UseVisualStyleBackColor = True
        '
        'btnRemoveMonth
        '
        Me.btnRemoveMonth.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Remove
        Me.btnRemoveMonth.Location = New System.Drawing.Point(357, 98)
        Me.btnRemoveMonth.Name = "btnRemoveMonth"
        Me.btnRemoveMonth.Size = New System.Drawing.Size(32, 19)
        Me.btnRemoveMonth.TabIndex = 19
        Me.btnRemoveMonth.UseVisualStyleBackColor = True
        '
        'btnAddMonth
        '
        Me.btnAddMonth.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Add
        Me.btnAddMonth.Location = New System.Drawing.Point(357, 81)
        Me.btnAddMonth.Name = "btnAddMonth"
        Me.btnAddMonth.Size = New System.Drawing.Size(32, 19)
        Me.btnAddMonth.TabIndex = 18
        Me.btnAddMonth.UseVisualStyleBackColor = True
        '
        'btnRemoveSecond
        '
        Me.btnRemoveSecond.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Remove
        Me.btnRemoveSecond.Location = New System.Drawing.Point(438, 49)
        Me.btnRemoveSecond.Name = "btnRemoveSecond"
        Me.btnRemoveSecond.Size = New System.Drawing.Size(32, 19)
        Me.btnRemoveSecond.TabIndex = 25
        Me.btnRemoveSecond.UseVisualStyleBackColor = True
        '
        'btnAddSecond
        '
        Me.btnAddSecond.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Add
        Me.btnAddSecond.Location = New System.Drawing.Point(438, 32)
        Me.btnAddSecond.Name = "btnAddSecond"
        Me.btnAddSecond.Size = New System.Drawing.Size(32, 19)
        Me.btnAddSecond.TabIndex = 24
        Me.btnAddSecond.UseVisualStyleBackColor = True
        '
        'btnRemoveYear
        '
        Me.btnRemoveYear.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Remove
        Me.btnRemoveYear.Location = New System.Drawing.Point(466, 98)
        Me.btnRemoveYear.Name = "btnRemoveYear"
        Me.btnRemoveYear.Size = New System.Drawing.Size(32, 19)
        Me.btnRemoveYear.TabIndex = 23
        Me.btnRemoveYear.UseVisualStyleBackColor = True
        '
        'btnAddYear
        '
        Me.btnAddYear.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Add
        Me.btnAddYear.Location = New System.Drawing.Point(466, 81)
        Me.btnAddYear.Name = "btnAddYear"
        Me.btnAddYear.Size = New System.Drawing.Size(32, 19)
        Me.btnAddYear.TabIndex = 22
        Me.btnAddYear.UseVisualStyleBackColor = True
        '
        'frmTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 195)
        Me.Controls.Add(Me.btnRemoveSecond)
        Me.Controls.Add(Me.btnAddSecond)
        Me.Controls.Add(Me.btnRemoveYear)
        Me.Controls.Add(Me.btnAddYear)
        Me.Controls.Add(Me.btnRemoveMinute)
        Me.Controls.Add(Me.btnAddMinute)
        Me.Controls.Add(Me.btnRemoveMonth)
        Me.Controls.Add(Me.btnAddMonth)
        Me.Controls.Add(Me.btnRemoveHour)
        Me.Controls.Add(Me.btnAddHour)
        Me.Controls.Add(Me.btnRemoveDay)
        Me.Controls.Add(Me.btnAddDay)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMinute)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTime"
        Me.Text = "Change time settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHour As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMinute As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtYear As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDay As TextBox
    Friend WithEvents btnAddDay As Button
    Friend WithEvents btnRemoveDay As Button
    Friend WithEvents btnRemoveHour As Button
    Friend WithEvents btnAddHour As Button
    Friend WithEvents btnRemoveMinute As Button
    Friend WithEvents btnAddMinute As Button
    Friend WithEvents btnRemoveMonth As Button
    Friend WithEvents btnAddMonth As Button
    Friend WithEvents btnRemoveSecond As Button
    Friend WithEvents btnAddSecond As Button
    Friend WithEvents btnRemoveYear As Button
    Friend WithEvents btnAddYear As Button
End Class
