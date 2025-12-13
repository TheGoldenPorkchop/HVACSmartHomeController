'Angel Nava
'Fall 2025
'RCET3371
'HVACSmartHomeController
'github link
Option Strict On
Option Explicit On
Imports System.IO.Ports

Public Class HVACSmartHomeController
    Sub GetPorts()
        Dim ports() = SerialPort1.GetPortNames()
        PortsComboBox.Items.Clear()

        For Each port In ports
            PortsComboBox.Items.Add(port)
        Next
        Try
            PortsComboBox.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Sub Connect()
        SerialPort1.Close()
        SerialPort1.BaudRate = 115200 'Q@ Board Default
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        Try
            SerialPort1.PortName = PortsComboBox.Text
        Catch ex As Exception
            MsgBox("Select or Change your Port via the Combo Box")
        End Try
        'SerialPort1.PortName = "COM5" 'RS232 Cable
        SerialPort1.Open()
    End Sub

    Sub QyatRead()
        Dim data(1) As Byte
        data(0) = &H53 'Read Analog
        data(1) = &H30 'Read Digital
        Try
            SerialPort1.Write(data, 0, 1)
            SerialPort1.Write(data, 1, 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Function SeperateNumberFromSymbol(Value As String) As Double
        Dim num As String()
        num = Split(Value, "°")
        If num(0) = "" Then
            Return 0
        Else
            Dim Number As Double = CDbl(num(0))
            Return Number
        End If
    End Function

    'Event Handlers---------------------------------------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetPorts()
        Try
            Connect()
        Catch ex As Exception
            MsgBox("Connect your Qy@ Board")
        End Try
        Timer10ms.Start()
        Timer30s.Start()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConnectButton.Click
        'test
    End Sub
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        CheckForIllegalCrossThreadCalls = False
        Dim numberOfBytes = SerialPort1.BytesToRead
        Dim buffer(numberOfBytes - 1) As Byte
        Dim got As Integer = SerialPort1.Read(buffer, 0, numberOfBytes)
        Dim XCoordinate As Integer
        Dim YCoordinate As Integer
        Dim buttonsData As Integer
        If got > 0 Then
            If buffer.Length >= 5 Then
                XCoordinate = CInt((buffer(0) * 0.234375) + 40)
                YCoordinate = CInt((buffer(2) * 0.234375) + 40)
                Static oldX As Integer = XCoordinate
                Static oldY As Integer = YCoordinate
                RoomTempTextBox.Text = CStr(XCoordinate)
                MachineTempTextBox.Text = CStr(YCoordinate)
                buttonsData = CInt(buffer(4))
                ButtonsTextBox.Text = CStr(buttonsData)
                oldX = XCoordinate
                oldY = YCoordinate
                ByteTextBox.Text = buffer(0).ToString + " & " + buffer(1).ToString + " & " + buffer(2).ToString + " & " + buffer(3).ToString + " & " + buffer(4).ToString
            End If
        End If
    End Sub

    Private Sub TempLowDecreaseButton_Click(sender As Object, e As EventArgs) Handles TempLowDecreaseButton.Click
        Dim lowTemp As Double = 50
        lowTemp = SeperateNumberFromSymbol(TempLowTextBox.Text)
        lowTemp = lowTemp - 0.5
        If lowTemp < 50 Then
            TempLowTextBox.Text = "50°"
        Else
            If SeperateNumberFromSymbol(TempHighTextBox.Text) >= lowTemp Then

            End If
            TempLowTextBox.Text = CStr(lowTemp) + "°"
        End If
    End Sub
    Private Sub TempLowIncreaseButton_Click(sender As Object, e As EventArgs) Handles TempLowIncreaseButton.Click
        Dim lowTemp As Double = 90
        lowTemp = SeperateNumberFromSymbol(TempLowTextBox.Text)
        lowTemp = lowTemp + 0.5
        If lowTemp > 90 Then
            TempLowTextBox.Text = "90°"
        Else
            If SeperateNumberFromSymbol(TempHighTextBox.Text) <= lowTemp Then
                TempLowTextBox.Text = TempLowTextBox.Text
            Else
                TempLowTextBox.Text = CStr(lowTemp) + "°"
            End If
        End If
    End Sub
    Private Sub TempHighDecreaseButton_Click(sender As Object, e As EventArgs) Handles TempHighDecreaseButton.Click
        Dim highTemp As Double = 50
        highTemp = SeperateNumberFromSymbol(TempHighTextBox.Text)
        highTemp = highTemp - 0.5
        If highTemp < 50 Then
            TempHighTextBox.Text = "50°"
        Else
            If SeperateNumberFromSymbol(TempLowTextBox.Text) >= highTemp Then
                TempHighTextBox.Text = TempHighTextBox.Text
            Else
                TempHighTextBox.Text = CStr(highTemp) + "°"
            End If
        End If
    End Sub
    Private Sub TempHighIncreaseButton_Click(sender As Object, e As EventArgs) Handles TempHighIncreaseButton.Click
        Dim highTemp As Double = 90
        highTemp = SeperateNumberFromSymbol(TempHighTextBox.Text)
        highTemp = highTemp + 0.5
        If highTemp > 90 Then
            TempHighTextBox.Text = "90°"
        Else
            TempHighTextBox.Text = CStr(highTemp) + "°"
        End If
    End Sub


    Dim heatingControl As Boolean = False
    Dim coolingControl As Boolean = False
    Dim hysteresisStart As Boolean = False
    Dim manualControl As Boolean = False
    Dim hasManualHeatEnded As Boolean = False
    Dim hasManualCoolEnded As Boolean = False
    Dim hasOnFanEnded As Boolean = False

    Private Sub Timer10ms_Tick(sender As Object, e As EventArgs) Handles Timer10ms.Tick
        Dim safetyLockTemp As Boolean = False
        Dim pressureLockTemp As Boolean = False
        Dim fan As Boolean = False
        Dim data(1) As Byte 'put bytes into an array
        data(0) = &H20 'Writes to the Digital Output
        QyatRead()
        If ButtonsTextBox.Text IsNot "" Then

            'Safety interlock switch
            If CInt(ButtonsTextBox.Text) Mod 2 = 0 Then
                safetyLockTemp = True 'low
            Else
                safetyLockTemp = False 'high
            End If

            'Heating Control
            If CInt(ButtonsTextBox.Text) Mod 4 < 2 Or CInt(ButtonsTextBox.Text) Mod 4 = 1 Then
                If safetyLockTemp = False And pressureLockTemp = False Then
                    data(1) = &H8 'Fan is on
                    SerialPort1.Write(data, 0, 2) 'Fan is on
                    FanStatusTextBox.Text = "On"
                    ManualControlTimer.Start()
                    heatingControl = True
                    hasManualHeatEnded = False
                End If
            Else
                heatingControl = False
                If hasManualHeatEnded = False Then
                    Timer5s.Start()
                    hasManualHeatEnded = True
                End If
            End If

            'Fan-only mode
            If CInt(ButtonsTextBox.Text) Mod 8 < 4 Then
                data(1) = &H8 'Fan is on
                SerialPort1.Write(data, 0, 2) 'Fan is on
                FanStatusTextBox.Text = "On"
                hasOnFanEnded = False
            Else
                If hasOnFanEnded = False Then
                    data(1) = &H0 'Fan is off
                    SerialPort1.Write(data, 0, 2) 'Fan is off
                    FanStatusTextBox.Text = "Off"
                    hasOnFanEnded = True
                End If
            End If

            'Differential pressure sensor
            If CInt(ButtonsTextBox.Text) Mod 16 < 8 Then
                pressureLockTemp = True
                FaultTextBox.Text = "Pressure Sensore oof"
            Else
                pressureLockTemp = False
            End If

            'Cooling control
            If CInt(ButtonsTextBox.Text) Mod 32 < 16 Then
                If safetyLockTemp = False And pressureLockTemp = False Then
                    data(1) = &H8 'Fan is on
                    SerialPort1.Write(data, 0, 2) 'Fan is on
                    FanStatusTextBox.Text = "On"
                    ManualControlTimer.Start()
                    coolingControl = True
                    hasManualCoolEnded = False
                End If
            Else
                coolingControl = False
                If hasManualCoolEnded = False Then
                    Timer5s.Start()
                    hasManualCoolEnded = True
                End If
            End If

            If CInt(ButtonsTextBox.Text) = 255 Then
                'no buttons i suppose
            End If

        End If
        If safetyLockTemp = False And pressureLockTemp = False Then
            If coolingControl = False And heatingControl = False Then
                If hysteresisStart = False Then
                    If SeperateNumberFromSymbol(RoomTempTextBox.Text) > SeperateNumberFromSymbol(TempHighTextBox.Text) Then
                        data(1) = &H8 'Fan is on
                        SerialPort1.Write(data, 0, 2) 'Fan is on
                        FanStatusTextBox.Text = "On"
                        ModeTextBox.Text = "Cooling"
                        hysteresisStart = True
                    ElseIf SeperateNumberFromSymbol(RoomTempTextBox.Text) < SeperateNumberFromSymbol(TempLowTextBox.Text) Then
                        data(1) = &H8 'Fan is on
                        SerialPort1.Write(data, 0, 2) 'Fan is on
                        FanStatusTextBox.Text = "On"
                        ModeTextBox.Text = "Heating"
                        hysteresisStart = True
                    Else
                        ModeTextBox.Text = "Off"
                    End If
                Else
                    If SeperateNumberFromSymbol(RoomTempTextBox.Text) > (SeperateNumberFromSymbol(TempHighTextBox.Text) - 2) Then
                        data(1) = &H8 'Fan is on
                        SerialPort1.Write(data, 0, 2) 'Fan is on
                        FanStatusTextBox.Text = "On"
                        ModeTextBox.Text = "Cooling"
                    ElseIf SeperateNumberFromSymbol(RoomTempTextBox.Text) < (SeperateNumberFromSymbol(TempLowTextBox.Text) + 2) Then
                        data(1) = &H8 'Fan is on
                        SerialPort1.Write(data, 0, 2) 'Fan is on
                        FanStatusTextBox.Text = "On"
                        ModeTextBox.Text = "Heating"
                    Else
                        data(1) = &H0 'Fan is on
                        SerialPort1.Write(data, 0, 2) 'Fan is on
                        ModeTextBox.Text = "Off"
                        hysteresisStart = False
                        Timer5s.Start()
                    End If
                End If
            End If
        Else
            ModeTextBox.Text = "Safety Locked"
            data(0) = &H20 'Writes to the Digital Output
            data(1) = &H1 'Safety Lock
            SerialPort1.Write(data, 0, 2) 'Fan is off
        End If
    End Sub

    Private Sub Timer30s_Tick(sender As Object, e As EventArgs) Handles Timer30s.Tick
        If ModeTextBox.Text = "Heating" Then
            If SeperateNumberFromSymbol(MachineTempTextBox.Text) > SeperateNumberFromSymbol(RoomTempTextBox.Text) Then
                FaultTextBox.Text = "All Good"
            Else
                FaultTextBox.Text = "Aw Dang It"
            End If
        ElseIf ModeTextBox.Text = "Cooling" Then
            If SeperateNumberFromSymbol(MachineTempTextBox.Text) < SeperateNumberFromSymbol(RoomTempTextBox.Text) Then
                FaultTextBox.Text = "All Good"
            Else
                FaultTextBox.Text = "Aw Dang It"
            End If
        Else
            FaultTextBox.Text = "All good Neutral"
        End If
    End Sub

    Private Sub Timer5s_Tick(sender As Object, e As EventArgs) Handles Timer5s.Tick
        Dim data(1) As Byte 'put bytes into an array
        data(0) = &H20 'Writes to the Digital Output
        RoomTempTextBox.ForeColor = Color.Black
        ModeTextBox.Text = "Off"
        data(1) = &H0 'Fan is off
        SerialPort1.Write(data, 0, 2) 'Fan is off
        FanStatusTextBox.Text = "Off"
        Timer5s.Stop()
    End Sub

    Private Sub ManualControlTimer_Tick(sender As Object, e As EventArgs) Handles ManualControlTimer.Tick
        If heatingControl = True Then
            ModeTextBox.Text = "Manual Heating"
        Else
            If coolingControl = True Then
                ModeTextBox.Text = "Manual Cooling"
            Else
                ModeTextBox.Text = "ermm..."
            End If
        End If
        ManualControlTimer.Stop()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Timer5sBootUp_Tick(sender As Object, e As EventArgs) Handles Timer5sBootUp.Tick

    End Sub
End Class
