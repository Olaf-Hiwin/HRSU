<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ss = New System.Windows.Forms.StatusStrip()
        Me.ssConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnTime = New System.Windows.Forms.Button()
        Me.btnResetAll = New System.Windows.Forms.Button()
        Me.btnPrePos = New System.Windows.Forms.Button()
        Me.btnClearPrg = New System.Windows.Forms.Button()
        Me.btnContMov = New System.Windows.Forms.Button()
        Me.btnRepeat = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.trkSpeed = New System.Windows.Forms.TrackBar()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl100 = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.ofdUpdate = New System.Windows.Forms.OpenFileDialog()
        Me.btnClearAlarms = New System.Windows.Forms.Button()
        Me.btnLibrary = New System.Windows.Forms.Button()
        Me.txtHRSDKDebug = New System.Windows.Forms.TextBox()
        Me.ss.SuspendLayout()
        CType(Me.trkSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ss
        '
        Me.ss.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssConnectionStatus})
        Me.ss.Location = New System.Drawing.Point(0, 213)
        Me.ss.Name = "ss"
        Me.ss.Size = New System.Drawing.Size(802, 22)
        Me.ss.TabIndex = 0
        Me.ss.Text = "StatusStrip1"
        '
        'ssConnectionStatus
        '
        Me.ssConnectionStatus.Name = "ssConnectionStatus"
        Me.ssConnectionStatus.Size = New System.Drawing.Size(113, 17)
        Me.ssConnectionStatus.Text = "Robot disconnected"
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(12, 12)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(182, 58)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update HRSS"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnTime
        '
        Me.btnTime.Enabled = False
        Me.btnTime.Location = New System.Drawing.Point(200, 12)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(182, 58)
        Me.btnTime.TabIndex = 3
        Me.btnTime.Text = "Change time settings"
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'btnResetAll
        '
        Me.btnResetAll.Enabled = False
        Me.btnResetAll.Location = New System.Drawing.Point(388, 12)
        Me.btnResetAll.Name = "btnResetAll"
        Me.btnResetAll.Size = New System.Drawing.Size(182, 58)
        Me.btnResetAll.TabIndex = 4
        Me.btnResetAll.Text = "Reset all data"
        Me.btnResetAll.UseVisualStyleBackColor = True
        '
        'btnPrePos
        '
        Me.btnPrePos.Enabled = False
        Me.btnPrePos.Location = New System.Drawing.Point(12, 76)
        Me.btnPrePos.Name = "btnPrePos"
        Me.btnPrePos.Size = New System.Drawing.Size(182, 58)
        Me.btnPrePos.TabIndex = 5
        Me.btnPrePos.Text = "Reset home settings"
        Me.btnPrePos.UseVisualStyleBackColor = True
        '
        'btnClearPrg
        '
        Me.btnClearPrg.Enabled = False
        Me.btnClearPrg.Location = New System.Drawing.Point(200, 76)
        Me.btnClearPrg.Name = "btnClearPrg"
        Me.btnClearPrg.Size = New System.Drawing.Size(182, 58)
        Me.btnClearPrg.TabIndex = 6
        Me.btnClearPrg.Text = "Clear programs"
        Me.btnClearPrg.UseVisualStyleBackColor = True
        '
        'btnContMov
        '
        Me.btnContMov.Enabled = False
        Me.btnContMov.Location = New System.Drawing.Point(388, 76)
        Me.btnContMov.Name = "btnContMov"
        Me.btnContMov.Size = New System.Drawing.Size(182, 58)
        Me.btnContMov.TabIndex = 7
        Me.btnContMov.Text = "Continuous movement test"
        Me.btnContMov.UseVisualStyleBackColor = True
        '
        'btnRepeat
        '
        Me.btnRepeat.Enabled = False
        Me.btnRepeat.Location = New System.Drawing.Point(12, 140)
        Me.btnRepeat.Name = "btnRepeat"
        Me.btnRepeat.Size = New System.Drawing.Size(182, 58)
        Me.btnRepeat.TabIndex = 8
        Me.btnRepeat.Text = "Repeatability test"
        Me.btnRepeat.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.BackgroundImage = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.OnOff
        Me.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConnect.Location = New System.Drawing.Point(713, 12)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 75)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'trkSpeed
        '
        Me.trkSpeed.Enabled = False
        Me.trkSpeed.Location = New System.Drawing.Point(713, 106)
        Me.trkSpeed.Maximum = 100
        Me.trkSpeed.Minimum = 1
        Me.trkSpeed.Name = "trkSpeed"
        Me.trkSpeed.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trkSpeed.Size = New System.Drawing.Size(45, 104)
        Me.trkSpeed.TabIndex = 9
        Me.trkSpeed.TickFrequency = 10
        Me.trkSpeed.Value = 50
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Enabled = False
        Me.lbl1.Location = New System.Drawing.Point(746, 190)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(21, 13)
        Me.lbl1.TabIndex = 10
        Me.lbl1.Text = "1%"
        '
        'lbl100
        '
        Me.lbl100.AutoSize = True
        Me.lbl100.Enabled = False
        Me.lbl100.Location = New System.Drawing.Point(746, 112)
        Me.lbl100.Name = "lbl100"
        Me.lbl100.Size = New System.Drawing.Size(33, 13)
        Me.lbl100.TabIndex = 11
        Me.lbl100.Text = "100%"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Enabled = False
        Me.lblSpeed.Location = New System.Drawing.Point(746, 153)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(38, 13)
        Me.lblSpeed.TabIndex = 12
        Me.lblSpeed.Text = "Speed"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(713, 87)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(75, 20)
        Me.txtIP.TabIndex = 13
        Me.txtIP.Text = "127.0.0.1"
        '
        'ofdUpdate
        '
        Me.ofdUpdate.Filter = "Executable files (*.exe)|*.exe"
        Me.ofdUpdate.Title = "HRSS update executable selection"
        '
        'btnClearAlarms
        '
        Me.btnClearAlarms.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClearAlarms.Enabled = False
        Me.btnClearAlarms.Location = New System.Drawing.Point(388, 140)
        Me.btnClearAlarms.Name = "btnClearAlarms"
        Me.btnClearAlarms.Size = New System.Drawing.Size(182, 58)
        Me.btnClearAlarms.TabIndex = 14
        Me.btnClearAlarms.Text = "Clear alarms"
        Me.btnClearAlarms.UseVisualStyleBackColor = False
        '
        'btnLibrary
        '
        Me.btnLibrary.Enabled = False
        Me.btnLibrary.Location = New System.Drawing.Point(200, 140)
        Me.btnLibrary.Name = "btnLibrary"
        Me.btnLibrary.Size = New System.Drawing.Size(182, 58)
        Me.btnLibrary.TabIndex = 15
        Me.btnLibrary.Text = "Load library programs"
        Me.btnLibrary.UseVisualStyleBackColor = True
        '
        'txtHRSDKDebug
        '
        Me.txtHRSDKDebug.Location = New System.Drawing.Point(576, 12)
        Me.txtHRSDKDebug.Multiline = True
        Me.txtHRSDKDebug.Name = "txtHRSDKDebug"
        Me.txtHRSDKDebug.ReadOnly = True
        Me.txtHRSDKDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtHRSDKDebug.Size = New System.Drawing.Size(131, 186)
        Me.txtHRSDKDebug.TabIndex = 16
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 235)
        Me.Controls.Add(Me.txtHRSDKDebug)
        Me.Controls.Add(Me.btnLibrary)
        Me.Controls.Add(Me.btnClearAlarms)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lbl100)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.trkSpeed)
        Me.Controls.Add(Me.btnRepeat)
        Me.Controls.Add(Me.btnContMov)
        Me.Controls.Add(Me.btnClearPrg)
        Me.Controls.Add(Me.btnPrePos)
        Me.Controls.Add(Me.btnResetAll)
        Me.Controls.Add(Me.btnTime)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.ss)
        Me.MinimumSize = New System.Drawing.Size(700, 274)
        Me.Name = "frmMain"
        Me.Text = "Hiwin Robot Setup Utility for HRSS3 v0.1.2"
        Me.ss.ResumeLayout(False)
        Me.ss.PerformLayout()
        CType(Me.trkSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ss As StatusStrip
    Friend WithEvents ssConnectionStatus As ToolStripStatusLabel
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnTime As Button
    Friend WithEvents btnResetAll As Button
    Friend WithEvents btnPrePos As Button
    Friend WithEvents btnClearPrg As Button
    Friend WithEvents btnContMov As Button
    Friend WithEvents btnRepeat As Button
    Friend WithEvents trkSpeed As TrackBar
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl100 As Label
    Friend WithEvents lblSpeed As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents ofdUpdate As OpenFileDialog
    Friend WithEvents btnClearAlarms As Button
    Friend WithEvents btnLibrary As Button
    Friend WithEvents txtHRSDKDebug As TextBox
End Class
