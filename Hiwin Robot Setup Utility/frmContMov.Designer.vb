<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContMov
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
        Me.components = New System.ComponentModel.Container()
        Me.grpPointA = New System.Windows.Forms.GroupBox()
        Me.txtPointAA6 = New System.Windows.Forms.TextBox()
        Me.lblPointAA6 = New System.Windows.Forms.Label()
        Me.txtPointAA5 = New System.Windows.Forms.TextBox()
        Me.lblPointAA5 = New System.Windows.Forms.Label()
        Me.txtPointAA4 = New System.Windows.Forms.TextBox()
        Me.lblPointAA4 = New System.Windows.Forms.Label()
        Me.txtPointAA3 = New System.Windows.Forms.TextBox()
        Me.lblPointAA3 = New System.Windows.Forms.Label()
        Me.txtPointAA2 = New System.Windows.Forms.TextBox()
        Me.lblPointAA2 = New System.Windows.Forms.Label()
        Me.txtPointAA1 = New System.Windows.Forms.TextBox()
        Me.lblPointAA1 = New System.Windows.Forms.Label()
        Me.btnPointACopy = New System.Windows.Forms.Button()
        Me.grpPointB = New System.Windows.Forms.GroupBox()
        Me.txtPointBA6 = New System.Windows.Forms.TextBox()
        Me.lblPointBA6 = New System.Windows.Forms.Label()
        Me.txtPointBA5 = New System.Windows.Forms.TextBox()
        Me.lblPointBA5 = New System.Windows.Forms.Label()
        Me.txtPointBA4 = New System.Windows.Forms.TextBox()
        Me.lblPointBA4 = New System.Windows.Forms.Label()
        Me.txtPointBA3 = New System.Windows.Forms.TextBox()
        Me.lblPointBA3 = New System.Windows.Forms.Label()
        Me.txtPointBA2 = New System.Windows.Forms.TextBox()
        Me.lblPointBA2 = New System.Windows.Forms.Label()
        Me.txtPointBA1 = New System.Windows.Forms.TextBox()
        Me.lblPointBA1 = New System.Windows.Forms.Label()
        Me.btnPointBCopy = New System.Windows.Forms.Button()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.nudDuration = New System.Windows.Forms.NumericUpDown()
        Me.lblMins = New System.Windows.Forms.Label()
        Me.lblElapsed = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnA1Plus = New System.Windows.Forms.Button()
        Me.lblA1 = New System.Windows.Forms.Label()
        Me.btnA1Minus = New System.Windows.Forms.Button()
        Me.btnA2Minus = New System.Windows.Forms.Button()
        Me.lblA2 = New System.Windows.Forms.Label()
        Me.btnA2Plus = New System.Windows.Forms.Button()
        Me.btnA3Minus = New System.Windows.Forms.Button()
        Me.lblA3 = New System.Windows.Forms.Label()
        Me.btnA3Plus = New System.Windows.Forms.Button()
        Me.btnA6Minus = New System.Windows.Forms.Button()
        Me.lblA6 = New System.Windows.Forms.Label()
        Me.btnA6Plus = New System.Windows.Forms.Button()
        Me.btnA5Minus = New System.Windows.Forms.Button()
        Me.lblA5 = New System.Windows.Forms.Label()
        Me.btnA5Plus = New System.Windows.Forms.Button()
        Me.btnA4Minus = New System.Windows.Forms.Button()
        Me.lblA4 = New System.Windows.Forms.Label()
        Me.btnA4Plus = New System.Windows.Forms.Button()
        Me.tmrElapsed = New System.Windows.Forms.Timer(Me.components)
        Me.grpPointA.SuspendLayout()
        Me.grpPointB.SuspendLayout()
        CType(Me.nudDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpPointA
        '
        Me.grpPointA.Controls.Add(Me.txtPointAA6)
        Me.grpPointA.Controls.Add(Me.lblPointAA6)
        Me.grpPointA.Controls.Add(Me.txtPointAA5)
        Me.grpPointA.Controls.Add(Me.lblPointAA5)
        Me.grpPointA.Controls.Add(Me.txtPointAA4)
        Me.grpPointA.Controls.Add(Me.lblPointAA4)
        Me.grpPointA.Controls.Add(Me.txtPointAA3)
        Me.grpPointA.Controls.Add(Me.lblPointAA3)
        Me.grpPointA.Controls.Add(Me.txtPointAA2)
        Me.grpPointA.Controls.Add(Me.lblPointAA2)
        Me.grpPointA.Controls.Add(Me.txtPointAA1)
        Me.grpPointA.Controls.Add(Me.lblPointAA1)
        Me.grpPointA.Controls.Add(Me.btnPointACopy)
        Me.grpPointA.Location = New System.Drawing.Point(12, 12)
        Me.grpPointA.Name = "grpPointA"
        Me.grpPointA.Size = New System.Drawing.Size(364, 133)
        Me.grpPointA.TabIndex = 0
        Me.grpPointA.TabStop = False
        Me.grpPointA.Text = "Point A"
        '
        'txtPointAA6
        '
        Me.txtPointAA6.Location = New System.Drawing.Point(270, 87)
        Me.txtPointAA6.Name = "txtPointAA6"
        Me.txtPointAA6.ReadOnly = True
        Me.txtPointAA6.Size = New System.Drawing.Size(77, 20)
        Me.txtPointAA6.TabIndex = 12
        Me.txtPointAA6.Text = "0"
        '
        'lblPointAA6
        '
        Me.lblPointAA6.AutoSize = True
        Me.lblPointAA6.Location = New System.Drawing.Point(244, 90)
        Me.lblPointAA6.Name = "lblPointAA6"
        Me.lblPointAA6.Size = New System.Drawing.Size(20, 13)
        Me.lblPointAA6.TabIndex = 11
        Me.lblPointAA6.Text = "A6"
        '
        'txtPointAA5
        '
        Me.txtPointAA5.Location = New System.Drawing.Point(270, 61)
        Me.txtPointAA5.Name = "txtPointAA5"
        Me.txtPointAA5.ReadOnly = True
        Me.txtPointAA5.Size = New System.Drawing.Size(77, 20)
        Me.txtPointAA5.TabIndex = 10
        Me.txtPointAA5.Text = "0"
        '
        'lblPointAA5
        '
        Me.lblPointAA5.AutoSize = True
        Me.lblPointAA5.Location = New System.Drawing.Point(244, 64)
        Me.lblPointAA5.Name = "lblPointAA5"
        Me.lblPointAA5.Size = New System.Drawing.Size(20, 13)
        Me.lblPointAA5.TabIndex = 9
        Me.lblPointAA5.Text = "A5"
        '
        'txtPointAA4
        '
        Me.txtPointAA4.Location = New System.Drawing.Point(270, 35)
        Me.txtPointAA4.Name = "txtPointAA4"
        Me.txtPointAA4.ReadOnly = True
        Me.txtPointAA4.Size = New System.Drawing.Size(77, 20)
        Me.txtPointAA4.TabIndex = 8
        Me.txtPointAA4.Text = "0"
        '
        'lblPointAA4
        '
        Me.lblPointAA4.AutoSize = True
        Me.lblPointAA4.Location = New System.Drawing.Point(244, 38)
        Me.lblPointAA4.Name = "lblPointAA4"
        Me.lblPointAA4.Size = New System.Drawing.Size(20, 13)
        Me.lblPointAA4.TabIndex = 7
        Me.lblPointAA4.Text = "A4"
        '
        'txtPointAA3
        '
        Me.txtPointAA3.Location = New System.Drawing.Point(152, 87)
        Me.txtPointAA3.Name = "txtPointAA3"
        Me.txtPointAA3.ReadOnly = True
        Me.txtPointAA3.Size = New System.Drawing.Size(77, 20)
        Me.txtPointAA3.TabIndex = 6
        Me.txtPointAA3.Text = "0"
        '
        'lblPointAA3
        '
        Me.lblPointAA3.AutoSize = True
        Me.lblPointAA3.Location = New System.Drawing.Point(126, 90)
        Me.lblPointAA3.Name = "lblPointAA3"
        Me.lblPointAA3.Size = New System.Drawing.Size(20, 13)
        Me.lblPointAA3.TabIndex = 5
        Me.lblPointAA3.Text = "A3"
        '
        'txtPointAA2
        '
        Me.txtPointAA2.Location = New System.Drawing.Point(152, 61)
        Me.txtPointAA2.Name = "txtPointAA2"
        Me.txtPointAA2.ReadOnly = True
        Me.txtPointAA2.Size = New System.Drawing.Size(77, 20)
        Me.txtPointAA2.TabIndex = 4
        Me.txtPointAA2.Text = "0"
        '
        'lblPointAA2
        '
        Me.lblPointAA2.AutoSize = True
        Me.lblPointAA2.Location = New System.Drawing.Point(126, 64)
        Me.lblPointAA2.Name = "lblPointAA2"
        Me.lblPointAA2.Size = New System.Drawing.Size(20, 13)
        Me.lblPointAA2.TabIndex = 3
        Me.lblPointAA2.Text = "A2"
        '
        'txtPointAA1
        '
        Me.txtPointAA1.Location = New System.Drawing.Point(152, 35)
        Me.txtPointAA1.Name = "txtPointAA1"
        Me.txtPointAA1.ReadOnly = True
        Me.txtPointAA1.Size = New System.Drawing.Size(77, 20)
        Me.txtPointAA1.TabIndex = 2
        Me.txtPointAA1.Text = "0"
        '
        'lblPointAA1
        '
        Me.lblPointAA1.AutoSize = True
        Me.lblPointAA1.Location = New System.Drawing.Point(126, 38)
        Me.lblPointAA1.Name = "lblPointAA1"
        Me.lblPointAA1.Size = New System.Drawing.Size(20, 13)
        Me.lblPointAA1.TabIndex = 1
        Me.lblPointAA1.Text = "A1"
        '
        'btnPointACopy
        '
        Me.btnPointACopy.Location = New System.Drawing.Point(17, 29)
        Me.btnPointACopy.Name = "btnPointACopy"
        Me.btnPointACopy.Size = New System.Drawing.Size(88, 88)
        Me.btnPointACopy.TabIndex = 0
        Me.btnPointACopy.Text = "Copy current robot configuration"
        Me.btnPointACopy.UseVisualStyleBackColor = True
        '
        'grpPointB
        '
        Me.grpPointB.Controls.Add(Me.txtPointBA6)
        Me.grpPointB.Controls.Add(Me.lblPointBA6)
        Me.grpPointB.Controls.Add(Me.txtPointBA5)
        Me.grpPointB.Controls.Add(Me.lblPointBA5)
        Me.grpPointB.Controls.Add(Me.txtPointBA4)
        Me.grpPointB.Controls.Add(Me.lblPointBA4)
        Me.grpPointB.Controls.Add(Me.txtPointBA3)
        Me.grpPointB.Controls.Add(Me.lblPointBA3)
        Me.grpPointB.Controls.Add(Me.txtPointBA2)
        Me.grpPointB.Controls.Add(Me.lblPointBA2)
        Me.grpPointB.Controls.Add(Me.txtPointBA1)
        Me.grpPointB.Controls.Add(Me.lblPointBA1)
        Me.grpPointB.Controls.Add(Me.btnPointBCopy)
        Me.grpPointB.Location = New System.Drawing.Point(12, 151)
        Me.grpPointB.Name = "grpPointB"
        Me.grpPointB.Size = New System.Drawing.Size(364, 133)
        Me.grpPointB.TabIndex = 1
        Me.grpPointB.TabStop = False
        Me.grpPointB.Text = "Point B"
        '
        'txtPointBA6
        '
        Me.txtPointBA6.Location = New System.Drawing.Point(270, 87)
        Me.txtPointBA6.Name = "txtPointBA6"
        Me.txtPointBA6.ReadOnly = True
        Me.txtPointBA6.Size = New System.Drawing.Size(77, 20)
        Me.txtPointBA6.TabIndex = 12
        Me.txtPointBA6.Text = "0"
        '
        'lblPointBA6
        '
        Me.lblPointBA6.AutoSize = True
        Me.lblPointBA6.Location = New System.Drawing.Point(244, 90)
        Me.lblPointBA6.Name = "lblPointBA6"
        Me.lblPointBA6.Size = New System.Drawing.Size(20, 13)
        Me.lblPointBA6.TabIndex = 11
        Me.lblPointBA6.Text = "A6"
        '
        'txtPointBA5
        '
        Me.txtPointBA5.Location = New System.Drawing.Point(270, 61)
        Me.txtPointBA5.Name = "txtPointBA5"
        Me.txtPointBA5.ReadOnly = True
        Me.txtPointBA5.Size = New System.Drawing.Size(77, 20)
        Me.txtPointBA5.TabIndex = 10
        Me.txtPointBA5.Text = "0"
        '
        'lblPointBA5
        '
        Me.lblPointBA5.AutoSize = True
        Me.lblPointBA5.Location = New System.Drawing.Point(244, 64)
        Me.lblPointBA5.Name = "lblPointBA5"
        Me.lblPointBA5.Size = New System.Drawing.Size(20, 13)
        Me.lblPointBA5.TabIndex = 9
        Me.lblPointBA5.Text = "A5"
        '
        'txtPointBA4
        '
        Me.txtPointBA4.Location = New System.Drawing.Point(270, 35)
        Me.txtPointBA4.Name = "txtPointBA4"
        Me.txtPointBA4.ReadOnly = True
        Me.txtPointBA4.Size = New System.Drawing.Size(77, 20)
        Me.txtPointBA4.TabIndex = 8
        Me.txtPointBA4.Text = "0"
        '
        'lblPointBA4
        '
        Me.lblPointBA4.AutoSize = True
        Me.lblPointBA4.Location = New System.Drawing.Point(244, 38)
        Me.lblPointBA4.Name = "lblPointBA4"
        Me.lblPointBA4.Size = New System.Drawing.Size(20, 13)
        Me.lblPointBA4.TabIndex = 7
        Me.lblPointBA4.Text = "A4"
        '
        'txtPointBA3
        '
        Me.txtPointBA3.Location = New System.Drawing.Point(152, 87)
        Me.txtPointBA3.Name = "txtPointBA3"
        Me.txtPointBA3.ReadOnly = True
        Me.txtPointBA3.Size = New System.Drawing.Size(77, 20)
        Me.txtPointBA3.TabIndex = 6
        Me.txtPointBA3.Text = "0"
        '
        'lblPointBA3
        '
        Me.lblPointBA3.AutoSize = True
        Me.lblPointBA3.Location = New System.Drawing.Point(126, 90)
        Me.lblPointBA3.Name = "lblPointBA3"
        Me.lblPointBA3.Size = New System.Drawing.Size(20, 13)
        Me.lblPointBA3.TabIndex = 5
        Me.lblPointBA3.Text = "A3"
        '
        'txtPointBA2
        '
        Me.txtPointBA2.Location = New System.Drawing.Point(152, 61)
        Me.txtPointBA2.Name = "txtPointBA2"
        Me.txtPointBA2.ReadOnly = True
        Me.txtPointBA2.Size = New System.Drawing.Size(77, 20)
        Me.txtPointBA2.TabIndex = 4
        Me.txtPointBA2.Text = "0"
        '
        'lblPointBA2
        '
        Me.lblPointBA2.AutoSize = True
        Me.lblPointBA2.Location = New System.Drawing.Point(126, 64)
        Me.lblPointBA2.Name = "lblPointBA2"
        Me.lblPointBA2.Size = New System.Drawing.Size(20, 13)
        Me.lblPointBA2.TabIndex = 3
        Me.lblPointBA2.Text = "A2"
        '
        'txtPointBA1
        '
        Me.txtPointBA1.Location = New System.Drawing.Point(152, 35)
        Me.txtPointBA1.Name = "txtPointBA1"
        Me.txtPointBA1.ReadOnly = True
        Me.txtPointBA1.Size = New System.Drawing.Size(77, 20)
        Me.txtPointBA1.TabIndex = 2
        Me.txtPointBA1.Text = "0"
        '
        'lblPointBA1
        '
        Me.lblPointBA1.AutoSize = True
        Me.lblPointBA1.Location = New System.Drawing.Point(126, 38)
        Me.lblPointBA1.Name = "lblPointBA1"
        Me.lblPointBA1.Size = New System.Drawing.Size(20, 13)
        Me.lblPointBA1.TabIndex = 1
        Me.lblPointBA1.Text = "A1"
        '
        'btnPointBCopy
        '
        Me.btnPointBCopy.Location = New System.Drawing.Point(17, 29)
        Me.btnPointBCopy.Name = "btnPointBCopy"
        Me.btnPointBCopy.Size = New System.Drawing.Size(88, 88)
        Me.btnPointBCopy.TabIndex = 0
        Me.btnPointBCopy.Text = "Copy current robot configuration"
        Me.btnPointBCopy.UseVisualStyleBackColor = True
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(382, 21)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(72, 13)
        Me.lblDuration.TabIndex = 2
        Me.lblDuration.Text = "Test duration:"
        '
        'nudDuration
        '
        Me.nudDuration.Location = New System.Drawing.Point(460, 19)
        Me.nudDuration.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudDuration.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDuration.Name = "nudDuration"
        Me.nudDuration.Size = New System.Drawing.Size(58, 20)
        Me.nudDuration.TabIndex = 3
        Me.nudDuration.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'lblMins
        '
        Me.lblMins.AutoSize = True
        Me.lblMins.Location = New System.Drawing.Point(524, 21)
        Me.lblMins.Name = "lblMins"
        Me.lblMins.Size = New System.Drawing.Size(28, 13)
        Me.lblMins.TabIndex = 4
        Me.lblMins.Text = "mins"
        '
        'lblElapsed
        '
        Me.lblElapsed.Location = New System.Drawing.Point(382, 51)
        Me.lblElapsed.Name = "lblElapsed"
        Me.lblElapsed.Size = New System.Drawing.Size(170, 13)
        Me.lblElapsed.TabIndex = 5
        Me.lblElapsed.Text = "Elapsed time: 00 h, 00 m, 00 s"
        Me.lblElapsed.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnStart
        '
        Me.btnStart.BackgroundImage = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Play
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.Location = New System.Drawing.Point(399, 73)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(60, 60)
        Me.btnStart.TabIndex = 6
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.BackgroundImage = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources._Stop
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(475, 73)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(60, 60)
        Me.btnStop.TabIndex = 7
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnA1Plus
        '
        Me.btnA1Plus.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Add
        Me.btnA1Plus.Location = New System.Drawing.Point(393, 145)
        Me.btnA1Plus.Name = "btnA1Plus"
        Me.btnA1Plus.Size = New System.Drawing.Size(56, 24)
        Me.btnA1Plus.TabIndex = 8
        Me.btnA1Plus.UseVisualStyleBackColor = True
        '
        'lblA1
        '
        Me.lblA1.AutoSize = True
        Me.lblA1.Location = New System.Drawing.Point(455, 151)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(20, 13)
        Me.lblA1.TabIndex = 9
        Me.lblA1.Text = "A1"
        '
        'btnA1Minus
        '
        Me.btnA1Minus.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Remove
        Me.btnA1Minus.Location = New System.Drawing.Point(483, 145)
        Me.btnA1Minus.Name = "btnA1Minus"
        Me.btnA1Minus.Size = New System.Drawing.Size(56, 24)
        Me.btnA1Minus.TabIndex = 10
        Me.btnA1Minus.UseVisualStyleBackColor = True
        '
        'btnA2Minus
        '
        Me.btnA2Minus.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Remove
        Me.btnA2Minus.Location = New System.Drawing.Point(483, 168)
        Me.btnA2Minus.Name = "btnA2Minus"
        Me.btnA2Minus.Size = New System.Drawing.Size(56, 24)
        Me.btnA2Minus.TabIndex = 13
        Me.btnA2Minus.UseVisualStyleBackColor = True
        '
        'lblA2
        '
        Me.lblA2.AutoSize = True
        Me.lblA2.Location = New System.Drawing.Point(455, 174)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(20, 13)
        Me.lblA2.TabIndex = 12
        Me.lblA2.Text = "A2"
        '
        'btnA2Plus
        '
        Me.btnA2Plus.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Add
        Me.btnA2Plus.Location = New System.Drawing.Point(393, 168)
        Me.btnA2Plus.Name = "btnA2Plus"
        Me.btnA2Plus.Size = New System.Drawing.Size(56, 24)
        Me.btnA2Plus.TabIndex = 11
        Me.btnA2Plus.UseVisualStyleBackColor = True
        '
        'btnA3Minus
        '
        Me.btnA3Minus.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Remove
        Me.btnA3Minus.Location = New System.Drawing.Point(483, 191)
        Me.btnA3Minus.Name = "btnA3Minus"
        Me.btnA3Minus.Size = New System.Drawing.Size(56, 24)
        Me.btnA3Minus.TabIndex = 16
        Me.btnA3Minus.UseVisualStyleBackColor = True
        '
        'lblA3
        '
        Me.lblA3.AutoSize = True
        Me.lblA3.Location = New System.Drawing.Point(455, 197)
        Me.lblA3.Name = "lblA3"
        Me.lblA3.Size = New System.Drawing.Size(20, 13)
        Me.lblA3.TabIndex = 15
        Me.lblA3.Text = "A3"
        '
        'btnA3Plus
        '
        Me.btnA3Plus.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Add
        Me.btnA3Plus.Location = New System.Drawing.Point(393, 191)
        Me.btnA3Plus.Name = "btnA3Plus"
        Me.btnA3Plus.Size = New System.Drawing.Size(56, 24)
        Me.btnA3Plus.TabIndex = 14
        Me.btnA3Plus.UseVisualStyleBackColor = True
        '
        'btnA6Minus
        '
        Me.btnA6Minus.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Remove
        Me.btnA6Minus.Location = New System.Drawing.Point(483, 260)
        Me.btnA6Minus.Name = "btnA6Minus"
        Me.btnA6Minus.Size = New System.Drawing.Size(56, 24)
        Me.btnA6Minus.TabIndex = 25
        Me.btnA6Minus.UseVisualStyleBackColor = True
        '
        'lblA6
        '
        Me.lblA6.AutoSize = True
        Me.lblA6.Location = New System.Drawing.Point(455, 266)
        Me.lblA6.Name = "lblA6"
        Me.lblA6.Size = New System.Drawing.Size(20, 13)
        Me.lblA6.TabIndex = 24
        Me.lblA6.Text = "A6"
        '
        'btnA6Plus
        '
        Me.btnA6Plus.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Add
        Me.btnA6Plus.Location = New System.Drawing.Point(393, 260)
        Me.btnA6Plus.Name = "btnA6Plus"
        Me.btnA6Plus.Size = New System.Drawing.Size(56, 24)
        Me.btnA6Plus.TabIndex = 23
        Me.btnA6Plus.UseVisualStyleBackColor = True
        '
        'btnA5Minus
        '
        Me.btnA5Minus.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Remove
        Me.btnA5Minus.Location = New System.Drawing.Point(483, 237)
        Me.btnA5Minus.Name = "btnA5Minus"
        Me.btnA5Minus.Size = New System.Drawing.Size(56, 24)
        Me.btnA5Minus.TabIndex = 22
        Me.btnA5Minus.UseVisualStyleBackColor = True
        '
        'lblA5
        '
        Me.lblA5.AutoSize = True
        Me.lblA5.Location = New System.Drawing.Point(455, 243)
        Me.lblA5.Name = "lblA5"
        Me.lblA5.Size = New System.Drawing.Size(20, 13)
        Me.lblA5.TabIndex = 21
        Me.lblA5.Text = "A5"
        '
        'btnA5Plus
        '
        Me.btnA5Plus.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Add
        Me.btnA5Plus.Location = New System.Drawing.Point(393, 237)
        Me.btnA5Plus.Name = "btnA5Plus"
        Me.btnA5Plus.Size = New System.Drawing.Size(56, 24)
        Me.btnA5Plus.TabIndex = 20
        Me.btnA5Plus.UseVisualStyleBackColor = True
        '
        'btnA4Minus
        '
        Me.btnA4Minus.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Remove
        Me.btnA4Minus.Location = New System.Drawing.Point(483, 214)
        Me.btnA4Minus.Name = "btnA4Minus"
        Me.btnA4Minus.Size = New System.Drawing.Size(56, 24)
        Me.btnA4Minus.TabIndex = 19
        Me.btnA4Minus.UseVisualStyleBackColor = True
        '
        'lblA4
        '
        Me.lblA4.AutoSize = True
        Me.lblA4.Location = New System.Drawing.Point(455, 220)
        Me.lblA4.Name = "lblA4"
        Me.lblA4.Size = New System.Drawing.Size(20, 13)
        Me.lblA4.TabIndex = 18
        Me.lblA4.Text = "A4"
        '
        'btnA4Plus
        '
        Me.btnA4Plus.Image = Global.Hiwin_Robot_Setup_Utility.My.Resources.Resources.Add
        Me.btnA4Plus.Location = New System.Drawing.Point(393, 214)
        Me.btnA4Plus.Name = "btnA4Plus"
        Me.btnA4Plus.Size = New System.Drawing.Size(56, 24)
        Me.btnA4Plus.TabIndex = 17
        Me.btnA4Plus.UseVisualStyleBackColor = True
        '
        'tmrElapsed
        '
        Me.tmrElapsed.Interval = 1000
        '
        'frmContMov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 295)
        Me.Controls.Add(Me.btnA6Minus)
        Me.Controls.Add(Me.lblA6)
        Me.Controls.Add(Me.btnA6Plus)
        Me.Controls.Add(Me.btnA5Minus)
        Me.Controls.Add(Me.lblA5)
        Me.Controls.Add(Me.btnA5Plus)
        Me.Controls.Add(Me.btnA4Minus)
        Me.Controls.Add(Me.lblA4)
        Me.Controls.Add(Me.btnA4Plus)
        Me.Controls.Add(Me.btnA3Minus)
        Me.Controls.Add(Me.lblA3)
        Me.Controls.Add(Me.btnA3Plus)
        Me.Controls.Add(Me.btnA2Minus)
        Me.Controls.Add(Me.lblA2)
        Me.Controls.Add(Me.btnA2Plus)
        Me.Controls.Add(Me.btnA1Minus)
        Me.Controls.Add(Me.lblA1)
        Me.Controls.Add(Me.btnA1Plus)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblElapsed)
        Me.Controls.Add(Me.lblMins)
        Me.Controls.Add(Me.nudDuration)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.grpPointB)
        Me.Controls.Add(Me.grpPointA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContMov"
        Me.Text = "Continuous movement test"
        Me.grpPointA.ResumeLayout(False)
        Me.grpPointA.PerformLayout()
        Me.grpPointB.ResumeLayout(False)
        Me.grpPointB.PerformLayout()
        CType(Me.nudDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpPointA As GroupBox
    Friend WithEvents btnPointACopy As Button
    Friend WithEvents lblPointAA1 As Label
    Friend WithEvents txtPointAA6 As TextBox
    Friend WithEvents lblPointAA6 As Label
    Friend WithEvents txtPointAA5 As TextBox
    Friend WithEvents lblPointAA5 As Label
    Friend WithEvents txtPointAA4 As TextBox
    Friend WithEvents lblPointAA4 As Label
    Friend WithEvents txtPointAA3 As TextBox
    Friend WithEvents lblPointAA3 As Label
    Friend WithEvents txtPointAA2 As TextBox
    Friend WithEvents lblPointAA2 As Label
    Friend WithEvents txtPointAA1 As TextBox
    Friend WithEvents grpPointB As GroupBox
    Friend WithEvents txtPointBA6 As TextBox
    Friend WithEvents lblPointBA6 As Label
    Friend WithEvents txtPointBA5 As TextBox
    Friend WithEvents lblPointBA5 As Label
    Friend WithEvents txtPointBA4 As TextBox
    Friend WithEvents lblPointBA4 As Label
    Friend WithEvents txtPointBA3 As TextBox
    Friend WithEvents lblPointBA3 As Label
    Friend WithEvents txtPointBA2 As TextBox
    Friend WithEvents lblPointBA2 As Label
    Friend WithEvents txtPointBA1 As TextBox
    Friend WithEvents lblPointBA1 As Label
    Friend WithEvents btnPointBCopy As Button
    Friend WithEvents lblDuration As Label
    Friend WithEvents nudDuration As NumericUpDown
    Friend WithEvents lblMins As Label
    Friend WithEvents lblElapsed As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnA1Plus As Button
    Friend WithEvents lblA1 As Label
    Friend WithEvents btnA1Minus As Button
    Friend WithEvents btnA2Minus As Button
    Friend WithEvents lblA2 As Label
    Friend WithEvents btnA2Plus As Button
    Friend WithEvents btnA3Minus As Button
    Friend WithEvents lblA3 As Label
    Friend WithEvents btnA3Plus As Button
    Friend WithEvents btnA6Minus As Button
    Friend WithEvents lblA6 As Label
    Friend WithEvents btnA6Plus As Button
    Friend WithEvents btnA5Minus As Button
    Friend WithEvents lblA5 As Label
    Friend WithEvents btnA5Plus As Button
    Friend WithEvents btnA4Minus As Button
    Friend WithEvents lblA4 As Label
    Friend WithEvents btnA4Plus As Button
    Friend WithEvents tmrElapsed As Timer
End Class
