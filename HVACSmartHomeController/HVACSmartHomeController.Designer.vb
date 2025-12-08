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
        Me.XAnalogTextBox = New System.Windows.Forms.TextBox()
        Me.YAnalogTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.AnalogCoordsGroupBox.Controls.Add(Me.XAnalogTextBox)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.PortsComboBox)
        Me.AnalogCoordsGroupBox.Controls.Add(Me.YAnalogTextBox)
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
        'XAnalogTextBox
        '
        Me.XAnalogTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.XAnalogTextBox.Location = New System.Drawing.Point(217, 39)
        Me.XAnalogTextBox.Name = "XAnalogTextBox"
        Me.XAnalogTextBox.ReadOnly = True
        Me.XAnalogTextBox.Size = New System.Drawing.Size(66, 22)
        Me.XAnalogTextBox.TabIndex = 9
        '
        'YAnalogTextBox
        '
        Me.YAnalogTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.YAnalogTextBox.Location = New System.Drawing.Point(217, 66)
        Me.YAnalogTextBox.Name = "YAnalogTextBox"
        Me.YAnalogTextBox.ReadOnly = True
        Me.YAnalogTextBox.Size = New System.Drawing.Size(66, 22)
        Me.YAnalogTextBox.TabIndex = 10
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
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'HVACSmartHomeController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AnalogCoordsGroupBox)
        Me.Name = "HVACSmartHomeController"
        Me.Text = "Form1"
        Me.AnalogCoordsGroupBox.ResumeLayout(False)
        Me.AnalogCoordsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label3 As Label
    Friend WithEvents PortsComboBox As ComboBox
    Friend WithEvents AnalogCoordsGroupBox As GroupBox
    Friend WithEvents XAnalogTextBox As TextBox
    Friend WithEvents YAnalogTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonsTextBox As TextBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents ByteTextBox As TextBox
End Class
