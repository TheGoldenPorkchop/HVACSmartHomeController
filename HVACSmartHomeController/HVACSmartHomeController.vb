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

    Sub AnalogRead()
        Dim data(0) As Byte
        data(0) = &H53 'Read Analog
        Try
            SerialPort1.Write(data, 0, 1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetPorts()
        Try
            Connect()
        Catch ex As Exception
            MsgBox("Connect your Qy@ Board")
        End Try
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            AnalogRead()

            CheckForIllegalCrossThreadCalls = False
            Dim numberOfBytes = SerialPort1.BytesToRead
            Dim buffer(numberOfBytes - 1) As Byte
            Dim got As Integer = SerialPort1.Read(buffer, 0, numberOfBytes)
            Dim XCoordinate As Integer
            Dim YCoordinate As Integer

            'BytesToReadTextBox.Text = CStr(numberOfBytes)

            If got > 0 Then
                XCoordinate = CInt((buffer(0) / 256) * 100)
                YCoordinate = CInt((buffer(2) / 256) * 100)

                Static oldX As Integer = XCoordinate
                Static oldY As Integer = YCoordinate


                XAnalogTextBox.Text = CStr(XCoordinate)
                YAnalogTextBox.Text = CStr(YCoordinate)

                oldX = XCoordinate
                oldY = YCoordinate
            End If
        Catch ex As Exception
            Timer1.Stop()
            MsgBox("Try Reconnecting your QY@ Board")
        End Try


    End Sub
End Class
