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
        Me.ByteTextBox = New System.Windows.Forms.TextBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonsTextBox = New System.Windows.Forms.TextBox()
        Me.MachineTempTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.AnalogCoordsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
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
        Me.PortsComboBox.Location = New System.Drawing.Point(6, 43)
        Me.PortsComboBox.Name = "PortsComboBox"
        Me.PortsComboBox.Size = New System.Drawing.Size(78, 24)
        Me.PortsComboBox.TabIndex = 15
        '
        'AnalogCoordsGroupBox
        '
        Me.AnalogCoordsGroupBox.Controls.Add(Me.ByteTextBox)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.ConnectButton)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.Label4)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.ButtonsTextBox)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.Label3)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.PortsComboBox)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.MachineTempTextBox)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.Label2)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.Label1)
        Me.AnalogCoordsGroupBox.Location = New System.Drawing.Point(12, 327)
        Me.AnalogCoordsGroupBox.Name = "AnalogCoordsGroupBox"
        Me.AnalogCoordsGroupBox.Size = New System.Drawing.Size(397, 111)
        Me.AnalogCoordsGroupBox.TabIndex = 17
        Me.AnalogCoordsGroupBox.TabStop = False
        Me.AnalogCoordsGroupBox.Text = "Serial"
        '
        'ByteTextBox
        '
        Me.ByteTextBox.Location = New System.Drawing.Point(6, 73)
        Me.ByteTextBox.Name = "ByteTextBox"
        Me.ByteTextBox.Size = New System.Drawing.Size(184, 22)
        Me.ByteTextBox.TabIndex = 18
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(90, 39)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(100, 28)
        Me.ConnectButton.TabIndex = 18
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Buttons"
        '
        'ButtonsTextBox
        '
        Me.ButtonsTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonsTextBox.Location = New System.Drawing.Point(300, 66)
        Me.ButtonsTextBox.Name = "ButtonsTextBox"
        Me.ButtonsTextBox.ReadOnly = True
        Me.ButtonsTextBox.Size = New System.Drawing.Size(66, 22)
        Me.ButtonsTextBox.TabIndex = 13
        '
        'MachineTempTextBox
        '
        Me.MachineTempTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MachineTempTextBox.Location = New System.Drawing.Point(217, 66)
        Me.MachineTempTextBox.Name = "MachineTempTextBox"
        Me.MachineTempTextBox.ReadOnly = True
        Me.MachineTempTextBox.Size = New System.Drawing.Size(66, 22)
        Me.MachineTempTextBox.TabIndex = 10
        Me.MachineTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Y"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "X"
        '
        'RoomTempTextBox
        '
        Me.RoomTempTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RoomTempTextBox.Location = New System.Drawing.Point(102, 241)
        Me.RoomTempTextBox.Name = "RoomTempTextBox"
        Me.RoomTempTextBox.ReadOnly = True
        Me.RoomTempTextBox.Size = New System.Drawing.Size(66, 22)
        Me.RoomTempTextBox.TabIndex = 9
        Me.RoomTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer10ms
        '
        Me.Timer10ms.Interval = 10
        '
        'TempHighTextBox
        '
        Me.TempHighTextBox.Location = New System.Drawing.Point(174, 241)
        Me.TempHighTextBox.Name = "TempHighTextBox"
        Me.TempHighTextBox.ReadOnly = True
        Me.TempHighTextBox.Size = New System.Drawing.Size(76, 22)
        Me.TempHighTextBox.TabIndex = 18
        Me.TempHighTextBox.Text = "90°"
        Me.TempHighTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TempLowTextBox
        '
        Me.TempLowTextBox.Location = New System.Drawing.Point(20, 241)
        Me.TempLowTextBox.Name = "TempLowTextBox"
        Me.TempLowTextBox.ReadOnly = True
        Me.TempLowTextBox.Size = New System.Drawing.Size(76, 22)
        Me.TempLowTextBox.TabIndex = 19
        Me.TempLowTextBox.Text = "50°"
        Me.TempLowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 16)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Low"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(188, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "High"
        '
        'TempLowDecreaseButton
        '
        Me.TempLowDecreaseButton.Location = New System.Drawing.Point(20, 269)
        Me.TempLowDecreaseButton.Name = "TempLowDecreaseButton"
        Me.TempLowDecreaseButton.Size = New System.Drawing.Size(35, 34)
        Me.TempLowDecreaseButton.TabIndex = 22
        Me.TempLowDecreaseButton.Text = "<"
        Me.TempLowDecreaseButton.UseVisualStyleBackColor = True
        '
        'TempLowIncreaseButton
        '
        Me.TempLowIncreaseButton.Location = New System.Drawing.Point(61, 269)
        Me.TempLowIncreaseButton.Name = "TempLowIncreaseButton"
        Me.TempLowIncreaseButton.Size = New System.Drawing.Size(35, 34)
        Me.TempLowIncreaseButton.TabIndex = 23
        Me.TempLowIncreaseButton.Text = ">"
        Me.TempLowIncreaseButton.UseVisualStyleBackColor = True
        '
        'TempHighDecreaseButton
        '
        Me.TempHighDecreaseButton.Location = New System.Drawing.Point(174, 269)
        Me.TempHighDecreaseButton.Name = "TempHighDecreaseButton"
        Me.TempHighDecreaseButton.Size = New System.Drawing.Size(35, 34)
        Me.TempHighDecreaseButton.TabIndex = 24
        Me.TempHighDecreaseButton.Text = "<"
        Me.TempHighDecreaseButton.UseVisualStyleBackColor = True
        '
        'TempHighIncreaseButton
        '
        Me.TempHighIncreaseButton.Location = New System.Drawing.Point(215, 269)
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
        Me.ModeTextBox.Location = New System.Drawing.Point(413, 75)
        Me.ModeTextBox.Name = "ModeTextBox"
        Me.ModeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ModeTextBox.TabIndex = 27
        '
        'FanModeTextBox
        '
        Me.FanModeTextBox.Location = New System.Drawing.Point(565, 75)
        Me.FanModeTextBox.Name = "FanModeTextBox"
        Me.FanModeTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FanModeTextBox.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Current Temperature"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(417, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Mode"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(562, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Fan Mode"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(417, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Fan Status"
        '
        'FanStatusTextBox
        '
        Me.FanStatusTextBox.Location = New System.Drawing.Point(420, 197)
        Me.FanStatusTextBox.Name = "FanStatusTextBox"
        Me.FanStatusTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FanStatusTextBox.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(589, 178)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 16)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Fault Indicator"
        '
        'FaultTextBox
        '
        Me.FaultTextBox.Location = New System.Drawing.Point(592, 197)
        Me.FaultTextBox.Name = "FaultTextBox"
        Me.FaultTextBox.Size = New System.Drawing.Size(100, 22)
        Me.FaultTextBox.TabIndex = 34
        '
        'HVACSmartHomeController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.FaultTextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FanStatusTextBox)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label3 As Label
    Friend WithEvents PortsComboBox As ComboBox
    Friend WithEvents AnalogCoordsGroupBox As GroupBox
    Friend WithEvents RoomTempTextBox As TextBox
    Friend WithEvents MachineTempTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer10ms As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonsTextBox As TextBox
    Friend WithEvents ConnectButton As Button
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
End Class
