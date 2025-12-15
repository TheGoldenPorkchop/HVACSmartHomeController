<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HVACSmartHomeController
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PortsComboBox = New System.Windows.Forms.ComboBox()
        Me.AnalogCoordsGroupBox = New System.Windows.Forms.GroupBox()
        Me.UnconnectedRadioButton = New System.Windows.Forms.RadioButton()
        Me.ConnectedRadioButton = New System.Windows.Forms.RadioButton()
        Me.ByteTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonsTextBox = New System.Windows.Forms.TextBox()
        Me.MachineTempTextBox = New System.Windows.Forms.TextBox()
        Me.RoomTempTextBox = New System.Windows.Forms.TextBox()
        Me.Timer10ms = New System.Windows.Forms.Timer(Me.components)
        Me.TempHighTextBox = New System.Windows.Forms.TextBox()
        Me.TempLowTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TempLowDecreaseButton = New System.Windows.Forms.Button()
        Me.TempLowIncreaseButton = New System.Windows.Forms.Button()
        Me.TempHighDecreaseButton = New System.Windows.Forms.Button()
        Me.TempHighIncreaseButton = New System.Windows.Forms.Button()
        Me.Timer30s = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5s = New System.Windows.Forms.Timer(Me.components)
        Me.ManualControlTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ModeTextBox = New System.Windows.Forms.TextBox()
        Me.FanModeTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FanStatusTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FaultTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Timer5sBootUp = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2m = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClockTextBox = New System.Windows.Forms.TextBox()
        Me.AnalogCoordsGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Port Select"
        '
        'PortsComboBox
        '
        Me.PortsComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PortsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PortsComboBox.FormattingEnabled = True
        Me.PortsComboBox.Location = New System.Drawing.Point(9, 46)
        Me.PortsComboBox.Name = "PortsComboBox"
        Me.PortsComboBox.Size = New System.Drawing.Size(106, 25)
        Me.PortsComboBox.TabIndex = 15
        '
        'AnalogCoordsGroupBox
        '
        Me.AnalogCoordsGroupBox.Controls.Add(Me.UnconnectedRadioButton)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.ConnectedRadioButton)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.ByteTextBox)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.ButtonsTextBox)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.Label3)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.PortsComboBox)
        Me.AnalogCoordsGroupBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.AnalogCoordsGroupBox.Location = New System.Drawing.Point(12, 327)
        Me.AnalogCoordsGroupBox.Name = "AnalogCoordsGroupBox"
        Me.AnalogCoordsGroupBox.Size = New System.Drawing.Size(279, 111)
        Me.AnalogCoordsGroupBox.TabIndex = 17
        Me.AnalogCoordsGroupBox.TabStop = False
        Me.AnalogCoordsGroupBox.Text = "Serial"
        '
        'UnconnectedRadioButton
        '
        Me.UnconnectedRadioButton.AutoSize = True
        Me.UnconnectedRadioButton.Checked = True
        Me.UnconnectedRadioButton.Enabled = False
        Me.UnconnectedRadioButton.Location = New System.Drawing.Point(121, 73)
        Me.UnconnectedRadioButton.Name = "UnconnectedRadioButton"
        Me.UnconnectedRadioButton.Size = New System.Drawing.Size(109, 21)
        Me.UnconnectedRadioButton.TabIndex = 20
        Me.UnconnectedRadioButton.TabStop = True
        Me.UnconnectedRadioButton.Text = "Unconnected"
        Me.UnconnectedRadioButton.UseVisualStyleBackColor = True
        '
        'ConnectedRadioButton
        '
        Me.ConnectedRadioButton.AutoSize = True
        Me.ConnectedRadioButton.Enabled = False
        Me.ConnectedRadioButton.Location = New System.Drawing.Point(121, 47)
        Me.ConnectedRadioButton.Name = "ConnectedRadioButton"
        Me.ConnectedRadioButton.Size = New System.Drawing.Size(94, 21)
        Me.ConnectedRadioButton.TabIndex = 19
        Me.ConnectedRadioButton.Text = "Connected"
        Me.ConnectedRadioButton.UseVisualStyleBackColor = True
        '
        'ByteTextBox
        '
        Me.ByteTextBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.ByteTextBox.Location = New System.Drawing.Point(89, 20)
        Me.ByteTextBox.Name = "ByteTextBox"
        Me.ByteTextBox.ReadOnly = True
        Me.ByteTextBox.Size = New System.Drawing.Size(184, 25)
        Me.ByteTextBox.TabIndex = 18
        Me.ByteTextBox.Visible = False
        '
        'ButtonsTextBox
        '
        Me.ButtonsTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonsTextBox.Location = New System.Drawing.Point(9, 74)
        Me.ButtonsTextBox.Name = "ButtonsTextBox"
        Me.ButtonsTextBox.ReadOnly = True
        Me.ButtonsTextBox.Size = New System.Drawing.Size(106, 25)
        Me.ButtonsTextBox.TabIndex = 13
        Me.ButtonsTextBox.Visible = False
        '
        'MachineTempTextBox
        '
        Me.MachineTempTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MachineTempTextBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.MachineTempTextBox.Location = New System.Drawing.Point(353, 137)
        Me.MachineTempTextBox.Name = "MachineTempTextBox"
        Me.MachineTempTextBox.ReadOnly = True
        Me.MachineTempTextBox.Size = New System.Drawing.Size(66, 25)
        Me.MachineTempTextBox.TabIndex = 10
        Me.MachineTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RoomTempTextBox
        '
        Me.RoomTempTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RoomTempTextBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.RoomTempTextBox.Location = New System.Drawing.Point(353, 100)
        Me.RoomTempTextBox.Name = "RoomTempTextBox"
        Me.RoomTempTextBox.ReadOnly = True
        Me.RoomTempTextBox.Size = New System.Drawing.Size(66, 25)
        Me.RoomTempTextBox.TabIndex = 9
        Me.RoomTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer10ms
        '
        Me.Timer10ms.Interval = 10
        '
        'TempHighTextBox
        '
        Me.TempHighTextBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.TempHighTextBox.Location = New System.Drawing.Point(425, 100)
        Me.TempHighTextBox.Name = "TempHighTextBox"
        Me.TempHighTextBox.ReadOnly = True
        Me.TempHighTextBox.Size = New System.Drawing.Size(76, 25)
        Me.TempHighTextBox.TabIndex = 18
        Me.TempHighTextBox.Text = "90°"
        Me.TempHighTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TempLowTextBox
        '
        Me.TempLowTextBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.TempLowTextBox.Location = New System.Drawing.Point(271, 100)
        Me.TempLowTextBox.Name = "TempLowTextBox"
        Me.TempLowTextBox.ReadOnly = True
        Me.TempLowTextBox.Size = New System.Drawing.Size(76, 25)
        Me.TempLowTextBox.TabIndex = 19
        Me.TempLowTextBox.Text = "50°"
        Me.TempLowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(292, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 17)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Low"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(439, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "High"
        '
        'TempLowDecreaseButton
        '
        Me.TempLowDecreaseButton.Location = New System.Drawing.Point(271, 128)
        Me.TempLowDecreaseButton.Name = "TempLowDecreaseButton"
        Me.TempLowDecreaseButton.Size = New System.Drawing.Size(35, 34)
        Me.TempLowDecreaseButton.TabIndex = 22
        Me.TempLowDecreaseButton.Text = "<"
        Me.TempLowDecreaseButton.UseVisualStyleBackColor = True
        '
        'TempLowIncreaseButton
        '
        Me.TempLowIncreaseButton.Location = New System.Drawing.Point(312, 128)
        Me.TempLowIncreaseButton.Name = "TempLowIncreaseButton"
        Me.TempLowIncreaseButton.Size = New System.Drawing.Size(35, 34)
        Me.TempLowIncreaseButton.TabIndex = 23
        Me.TempLowIncreaseButton.Text = ">"
        Me.TempLowIncreaseButton.UseVisualStyleBackColor = True
        '
        'TempHighDecreaseButton
        '
        Me.TempHighDecreaseButton.Location = New System.Drawing.Point(425, 128)
        Me.TempHighDecreaseButton.Name = "TempHighDecreaseButton"
        Me.TempHighDecreaseButton.Size = New System.Drawing.Size(35, 34)
        Me.TempHighDecreaseButton.TabIndex = 24
        Me.TempHighDecreaseButton.Text = "<"
        Me.TempHighDecreaseButton.UseVisualStyleBackColor = True
        '
        'TempHighIncreaseButton
        '
        Me.TempHighIncreaseButton.Location = New System.Drawing.Point(466, 128)
        Me.TempHighIncreaseButton.Name = "TempHighIncreaseButton"
        Me.TempHighIncreaseButton.Size = New System.Drawing.Size(35, 34)
        Me.TempHighIncreaseButton.TabIndex = 25
        Me.TempHighIncreaseButton.Text = ">"
        Me.TempHighIncreaseButton.UseVisualStyleBackColor = True
        '
        'Timer30s
        '
        Me.Timer30s.Interval = 30000
        '
        'Timer5s
        '
        Me.Timer5s.Interval = 5000
        '
        'ManualControlTimer
        '
        Me.ManualControlTimer.Interval = 5000
        '
        'ModeTextBox
        '
        Me.ModeTextBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.ModeTextBox.Location = New System.Drawing.Point(160, 242)
        Me.ModeTextBox.Name = "ModeTextBox"
        Me.ModeTextBox.ReadOnly = True
        Me.ModeTextBox.Size = New System.Drawing.Size(146, 25)
        Me.ModeTextBox.TabIndex = 27
        Me.ModeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FanModeTextBox
        '
        Me.FanModeTextBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.FanModeTextBox.Location = New System.Drawing.Point(526, 222)
        Me.FanModeTextBox.Name = "FanModeTextBox"
        Me.FanModeTextBox.ReadOnly = True
        Me.FanModeTextBox.Size = New System.Drawing.Size(100, 25)
        Me.FanModeTextBox.TabIndex = 28
        Me.FanModeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(344, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 34)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Room" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Temperature"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(204, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Mode"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(540, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Fan Mode"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(537, 250)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 17)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Fan Status"
        '
        'FanStatusTextBox
        '
        Me.FanStatusTextBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.FanStatusTextBox.Location = New System.Drawing.Point(526, 269)
        Me.FanStatusTextBox.Name = "FanStatusTextBox"
        Me.FanStatusTextBox.ReadOnly = True
        Me.FanStatusTextBox.Size = New System.Drawing.Size(100, 25)
        Me.FanStatusTextBox.TabIndex = 32
        Me.FanStatusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(297, 327)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 17)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Fault Indicator"
        '
        'FaultTextBox
        '
        Me.FaultTextBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.FaultTextBox.Location = New System.Drawing.Point(300, 347)
        Me.FaultTextBox.Multiline = True
        Me.FaultTextBox.Name = "FaultTextBox"
        Me.FaultTextBox.ReadOnly = True
        Me.FaultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.FaultTextBox.Size = New System.Drawing.Size(388, 91)
        Me.FaultTextBox.TabIndex = 34
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.ExitButton.Location = New System.Drawing.Point(694, 386)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(94, 52)
        Me.ExitButton.TabIndex = 36
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Timer5sBootUp
        '
        Me.Timer5sBootUp.Interval = 5000
        '
        'Timer2m
        '
        Me.Timer2m.Interval = 120000
        '
        'TimerSerial
        '
        Me.TimerSerial.Interval = 10000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(344, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 34)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Machine" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Temperature"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HVACSmartHomeController.My.Resources.Resources.Spirit_Black
        Me.PictureBox1.Location = New System.Drawing.Point(9, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'ClockTextBox
        '
        Me.ClockTextBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold)
        Me.ClockTextBox.Location = New System.Drawing.Point(271, 12)
        Me.ClockTextBox.Name = "ClockTextBox"
        Me.ClockTextBox.ReadOnly = True
        Me.ClockTextBox.Size = New System.Drawing.Size(230, 25)
        Me.ClockTextBox.TabIndex = 40
        Me.ClockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HVACSmartHomeController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ClockTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.FaultTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FanStatusTextBox)
        Me.Controls.Add(Me.MachineTempTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.RoomTempTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.FanModeTextBox)
        Me.Controls.Add(Me.ModeTextBox)
        Me.Controls.Add(Me.TempHighIncreaseButton)
        Me.Controls.Add(Me.TempHighDecreaseButton)
        Me.Controls.Add(Me.TempLowIncreaseButton)
        Me.Controls.Add(Me.TempLowDecreaseButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TempLowTextBox)
        Me.Controls.Add(Me.TempHighTextBox)
        Me.Controls.Add(Me.AnalogCoordsGroupBox)
        Me.Name = "HVACSmartHomeController"
        Me.Text = "Form1"
        Me.AnalogCoordsGroupBox.ResumeLayout(False)
        Me.AnalogCoordsGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label3 As Label
    Friend WithEvents PortsComboBox As ComboBox
    Friend WithEvents AnalogCoordsGroupBox As GroupBox
    Friend WithEvents RoomTempTextBox As TextBox
    Friend WithEvents MachineTempTextBox As TextBox
    Friend WithEvents Timer10ms As Timer
    Friend WithEvents ButtonsTextBox As TextBox
    Friend WithEvents ByteTextBox As TextBox
    Friend WithEvents TempHighTextBox As TextBox
    Friend WithEvents TempLowTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TempLowDecreaseButton As Button
    Friend WithEvents TempLowIncreaseButton As Button
    Friend WithEvents TempHighDecreaseButton As Button
    Friend WithEvents TempHighIncreaseButton As Button
    Friend WithEvents Timer30s As Timer
    Friend WithEvents Timer5s As Timer
    Friend WithEvents ManualControlTimer As Timer
    Friend WithEvents ModeTextBox As TextBox
    Friend WithEvents FanModeTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents FanStatusTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents FaultTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents Timer5sBootUp As Timer
    Friend WithEvents Timer2m As Timer
    Friend WithEvents UnconnectedRadioButton As RadioButton
    Friend WithEvents ConnectedRadioButton As RadioButton
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ClockTextBox As TextBox
End Class
