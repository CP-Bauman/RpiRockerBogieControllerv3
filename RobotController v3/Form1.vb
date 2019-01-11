Imports CefSharp.WinForms
Imports CefSharp
Imports System.Runtime.InteropServices
Public Class frmRobotController
    'declare all variables 
    Public LeftX As Integer
    Public LeftX2 As Integer
    Public LeftY As Integer
    Public LeftY2 As Integer
    Public RightX As Integer
    Public RightX2 As Integer
    Public rightY As Integer
    Public RightY2 As Integer
    Public btnAmount As Integer
    Public btnAmount2 As Integer
    Public btnID As Integer
    Public btnID2 As Integer
    Public Dpad As Integer
    Public Dpad2 As Integer
    Public CurrentIP As String
    Public TurnWheels As Boolean = True
    Public CPUTemp As String
    Public SignalLevel As Integer
    Public LinkQuality As Integer
    Public Lights As Boolean = True
    Public Camera As Boolean = True
    Public UptimeMin As Integer = 0
    Public UptimeHour As Integer = 0
    Public uptime As String
    Public GyroX As String = "0"
    Public GyroY As String = "0"
    Public GyroZ As String = "0"
    Public Gyro As String
    Public AccelerometerX As String = "0"
    Public AccelerometerY As String = "0"
    Public AccelerometerZ As String = "0"
    Public accelerometer As String
    Public CompassX As String = "0"
    Public CompassY As String = "0"
    Public CompassZ As String = "0"
    Public Compass As String
    Public Pressure As String
    Public MQ5 As String
    Public MQ7 As String
    Public BatteryPercent As Integer
    Public BatteryVolt As Double
    Public TempandHum As String
    Public Sensors As String
    Public Temperature As String
    Public Humidity As String
    Public Battery As String
    Public Altimeter As String
    Public angle As Double
    Public angle2 As Double
    Public direction As Integer
    Public distance As String
    Public Uptimesec As Integer = 0
    Private WithEvents browser As ChromiumWebBrowser

    Public Sub New()
        'Program from https://thechriskent.com/2014/08/18/embedded-chromium-in-winforms/ modified by Christiaan Bauman
        InitializeComponent()

        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)

        browser = New ChromiumWebBrowser() With {
          .Dock = DockStyle.Fill
         }
        pnlCamera.Controls.Add(browser)

    End Sub
    Sub StopWheels()
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=AE&Speed1=0") 'stop robot
    End Sub


    Sub Turn()
        'create sub  Turn to later shorten code
        If TurnWheels = True Then
            btnTurn.Text = "Straight Wheels"
            btnLeft.Enabled = True
            btnRight.Enabled = True
            btnForward.Enabled = False
            btnBackward.Enabled = False
            TurnWheels = False
            wbTurnWheels.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=BG&Speed1=2400&Channel2=CF&Speed2=3700")
        ElseIf TurnWheels = False Then
            btnTurn.Text = "Turn Wheels"
            btnLeft.Enabled = False
            btnRight.Enabled = False
            btnForward.Enabled = True
            btnBackward.Enabled = True
            TurnWheels = True
            wbTurnWheels.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=BCFG&Speed1=3050")
        End If

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Declare Function joyGetPosEx Lib "winmm.dll" (ByVal uJoyID As Integer, ByRef pji As JOYINFOEX) As Integer

    <StructLayout(LayoutKind.Sequential)>
    Public Structure JOYINFOEX
        Public dwSize As Integer
        Public dwFlags As Integer
        Public dwXpos As Integer
        Public dwYpos As Integer
        Public dwZpos As Integer
        Public dwRpos As Integer
        Public dwUpos As Integer
        Public dwVpos As Integer
        Public dwButtons As Integer
        Public dwButtonNumber As Integer
        Public dwPOV As Integer
        Public dwReserved1 As Integer
        Public dwReserved2 As Integer
    End Structure

    Dim myjoyEX As JOYINFOEX
    Private Sub btnGamepads_Click(sender As Object, e As EventArgs) Handles btnGamepads.Click
        'if button gamepads is clicked then 
        If btnGamepads.Text = "Turn On Gamepad" Then 'togglable button
            btnGamepads.Text = "Turn Off Gamepad"
            myjoyEX.dwSize = 64
            myjoyEX.dwFlags = &HFF ' All information
            tmrJoystick.Interval = 10  'Update joystick at 100 hz
            tmrJoystick.Start() 'start joystick timer
        ElseIf btnGamepads.Text = "Turn Off Gamepad" Then 'togglable button
            btnGamepads.Text = "Turn On Gamepad"
            tmrJoystick.Stop() 'stop joystick timer
        End If
    End Sub

    Private Sub tmrJoystick_Tick(sender As Object, e As EventArgs) Handles tmrJoystick.Tick
        Dim WheelAngle As Integer
        Dim AngleRaw As Integer
        ' Get the joystick information
        ' Program from https://social.msdn.microsoft.com/Forums/vstudio/en-US/af28b35b-d756-4d87-94c6-ced882ab20a5/reading-input-data-from-joystick-in-visual-basic?forum=vbgeneral Modified by Christiaan Bauman
        Call joyGetPosEx(0, myjoyEX)

        With myjoyEX
            LeftX = (.dwXpos - 32767.5) / 655.35 'convert raw values to more easy useable values
            LeftY = (.dwYpos - 32767.5) / -655.35
            RightX = (.dwZpos - 32767.5) / 655.35
            rightY = (.dwRpos - 32767.5) / -655.35
            Dpad = .dwPOV / 100
            btnID = .dwButtons
            btnAmount = .dwButtonNumber
            'show al gamepad values on screen
            lblLeftX.Text = "Left X:  " + LeftX.ToString
            lblLeftY.Text = "Left Y:  " + LeftY.ToString
            lblRightX.Text = "Left X:  " + RightX.ToString
            lblRightY.Text = "Right Y:  " + rightY.ToString
            lblButtonType.Text = "Button ID:  " + btnID.ToString
            lblButtonAmount.Text = "Button amount:  " + btnAmount.ToString
            lblDpad.Text = "POV:  " + Dpad.ToString


            If Dpad = 0 And tbrCamY.Value < 115 Then
                tbrCamY.Value = tbrCamY.Value + 1
            End If
            If Dpad = 180 And tbrCamY.Value > -90 Then
                tbrCamY.Value = tbrCamY.Value - 1
            End If
            If Dpad = 90 And tbrCamX.Value < 135 Then
                tbrCamX.Value = tbrCamX.Value + 1
            End If
            If Dpad = 270 And tbrCamX.Value > -130 Then
                tbrCamX.Value = tbrCamX.Value - 1
            End If
            If Dpad <> Dpad2 Then
                Dpad2 = Dpad
                If Dpad = 655 Then
                    Dim YAngle As Integer
                    Dim YRaw As Integer
                    YAngle = tbrCamY.Value
                    YRaw = -YAngle * (420 / 27) + 3000
                    Dim XAngle As Integer
                    Dim XRaw As Integer
                    XAngle = tbrCamX.Value
                    XRaw = -XAngle * (420 / 27) + 3000
                    wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=D&Speed1=" & XRaw & "&Channel2=H&Speed2=" & YRaw)
                End If
            End If
            If btnID <> btnID2 Then
                btnID2 = btnID
                If btnID = 64 Then
                    btnLights.PerformClick()
                End If
                If btnID = 16 Then
                    btnCam.PerformClick()
                End If
            End If

            'If LeftY > 0 Then
            '    direction = Math.Atan(LeftX / LeftY) * (180 / Math.PI)
            '    lblDirection.Text = direction
            'End If
            'If (LeftY < 0) And (LeftX < 0) Then
            '    direction = (Math.Atan(LeftX / LeftY) * (180 / Math.PI)) - 180
            '    lblDirection.Text = direction
            'End If
            'If (LeftY < 0) And (LeftX > 0) Then
            '    direction = (Math.Atan(LeftX / LeftY) * (180 / Math.PI)) + 180
            '    lblDirection.Text = direction
            'End If
            'If (LeftY = 0) And (LeftX < 0) Then
            '    direction = -90
            '    lblDirection.Text = direction
            'End If
            'If (LeftY = 0) And (LeftX > 0) Then
            '    direction = 90
            '    lblDirection.Text = direction
            'End If
            'If (LeftY < 0) And (LeftX = 0) Then
            '    direction = 180
            '    lblDirection.Text = direction
            'End If
            'If (LeftY > 0) And (LeftX = 0) Then
            '    direction = 0
            '    lblDirection.Text = direction
            'End If

            'WheelAngle = (direction / 90) * 45
            'lblWheelAngle.Text = WheelAngle


        End With

    End Sub

    Private Sub btnForward_MouseDown(sender As Object, e As MouseEventArgs) Handles btnForward.MouseDown
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=A&Speed1=2000&Channel2=E&Speed2=4000") 'drive forward
    End Sub

    Private Sub btnForward_MouseUp(sender As Object, e As MouseEventArgs) Handles btnForward.MouseUp
        StopWheels()
    End Sub

    Private Sub btnBackward_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBackward.MouseDown
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=A&Speed1=4000&Channel2=E&Speed2=2000") 'drive backward
    End Sub

    Private Sub btnBackward_MouseUp(sender As Object, e As MouseEventArgs) Handles btnBackward.MouseUp
        StopWheels()
    End Sub

    Private Sub btnRight_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRight.MouseDown
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=AE&Speed1=4000") 'turn right
    End Sub

    Private Sub btnLeft_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLeft.MouseDown
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=AE&Speed1=2000") 'turn left
    End Sub

    Private Sub btnLeft_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLeft.MouseUp
        StopWheels()
    End Sub

    Private Sub btnRight_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRight.MouseUp
        StopWheels()
    End Sub

    Private Sub frmRobotController_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentIP = My.Settings.IP
        tmrSensors.Interval = 1000
        tmrSensors.Start()
        wbSensors.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Sensor=True")
        browser.Load("http://" & CurrentIP & "/html") 'load camera 1 into webbrowser
    End Sub

    Private Sub btnLights_Click(sender As Object, e As EventArgs) Handles btnLights.Click
        If Lights = False Then
            btnLights.Text = "Turn Lights Off"
            Lights = True
            wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Lights=On") 'Turn Lights on or off
        ElseIf Lights = True Then
            btnLights.Text = "Turn Lights On"
            Lights = False
            wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Lights=Off") 'Turn Lights on or off
        End If
    End Sub

    Private Sub btnTurn_Click(sender As Object, e As EventArgs) Handles btnTurn.Click
        Turn()
    End Sub

    Private Sub tmrSensors_Tick(sender As Object, e As EventArgs) Handles tmrSensors.Tick
        Try
            Sensors = wbSensors.DocumentText
            Temperature = Mid(Sensors, InStr(Sensors, "TempStart") + 9, InStr(Sensors, "TempEnd") - (InStr(Sensors, "TempStart") + 9))
            Humidity = Mid(Sensors, InStr(Sensors, "HumStart") + 8, InStr(Sensors, "HumEnd") - (InStr(Sensors, "HumStart") + 8))
            CPUTemp = Mid(Sensors, InStr(Sensors, "CPUStart") + 8, InStr(Sensors, "CPUEnd") - (InStr(Sensors, "CPUStart") + 8))
            uptime = Mid(Sensors, InStr(Sensors, "UpStart") + 7, InStr(Sensors, "UpEnd") - (InStr(Sensors, "UpStart") + 7))
            distance = Mid(Sensors, InStr(Sensors, "DistStart") + 9, InStr(Sensors, "DistEnd") - (InStr(Sensors, "DistStart") + 9))
            Gyro = Mid(Sensors, InStr(Sensors, "GyroStart") + 9, InStr(Sensors, "GyroEnd") - (InStr(Sensors, "GyroStart") + 9))
            accelerometer = Mid(Sensors, InStr(Sensors, "AccelStart") + 10, InStr(Sensors, "AccelEnd") - (InStr(Sensors, "AccelStart") + 10))
            Compass = Mid(Sensors, InStr(Sensors, "MagStart") + 8, InStr(Sensors, "MagEnd") - (InStr(Sensors, "MagStart") + 8))
            Pressure = Mid(Sensors, InStr(Sensors, "PresStart") + 9, InStr(Sensors, "PresEnd") - (InStr(Sensors, "PresStart") + 9))
            MQ5 = Mid(Sensors, InStr(Sensors, "MQ5Start") + 8, InStr(Sensors, "MQ5End") - (InStr(Sensors, "MQ5Start") + 8))
            MQ7 = Mid(Sensors, InStr(Sensors, "MQ7Start") + 8, InStr(Sensors, "MQ7End") - (InStr(Sensors, "MQ7Start") + 8))
            BatteryVolt = Mid(Sensors, InStr(Sensors, "BatStart") + 8, InStr(Sensors, "BatEnd") - (InStr(Sensors, "BatStart") + 8))
        Catch SensorError As ArgumentException
        Finally
            Dim ping As New Net.NetworkInformation.Ping
            Dim ms = ping.Send(CurrentIP).RoundtripTime()
            lblPing.Text = "Ping:  " & ms & " ms"
            UptimeHour = Math.Truncate(uptime / 3600)
            UptimeMin = Math.Truncate((uptime Mod 3600) / 60)
            Uptimesec = Math.Truncate(uptime Mod 60)
            wbSensors.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Sensor=True")
            lblSensors.Text = "Temperature:  " + Temperature + "°C" + vbNewLine + "Humidity:  " + Humidity + "%" + vbNewLine + "Distance:  " + distance + "cm" + vbNewLine + "Metahne:  " + MQ5 + " ppm " + vbNewLine + "Carbon Monoxide:  " + MQ7 + " ppm " + vbNewLine
            lblCPUTemp.Text = "CPU Temperature:  " + CPUTemp
            lblUptime.Text = "Uptime:  " + Str(UptimeHour) + " Hours " + Str(UptimeMin) + " Minutes " + Str(Uptimesec) + " Seconds "
            lblVoltage.Text = "Battery Voltage:  " + Str(BatteryVolt) + " V"
            lblPercentage.Text = "Battery Percentage:  " + Str(pbBattery.Value) + " %"
            If BatteryVolt > 13 Then
                pbBattery.Value = 90 + ((BatteryVolt - 13) * 5)
            ElseIf BatteryVolt > 12 And BatteryVolt <= 13 Then
                pbBattery.Value = 20 + ((BatteryVolt - 11) * 70)
            ElseIf BatteryVolt > 10 And BatteryVolt <= 12 Then
                pbBattery.Value = ((BatteryVolt - 10) * 10)
            Else pbBattery.Value = 0
            End If
        End Try
    End Sub
    Private Sub tbrCamX_MouseUp(sender As Object, e As MouseEventArgs) Handles tbrCamX.MouseUp
        Dim XAngle As Integer
        Dim XRaw As Integer
        XAngle = tbrCamX.Value
        XRaw = -XAngle * (420 / 27) + 3000
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=D&Speed1=" & XRaw)
    End Sub

    Private Sub gbSensors_Enter(sender As Object, e As EventArgs) Handles gbSensors.Enter

    End Sub

    Private Sub tbrCamY_Scroll(sender As Object, e As EventArgs) Handles tbrCamY.Scroll

    End Sub

    Private Sub tbrCamY_MouseUp(sender As Object, e As MouseEventArgs) Handles tbrCamY.MouseUp
        Dim YAngle As Integer
        Dim YRaw As Integer
        YAngle = tbrCamY.Value
        YRaw = -YAngle * (420 / 27) + 3000
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=H&Speed1=" & YRaw)
    End Sub

    Private Sub btnReboot_Click(sender As Object, e As EventArgs) Handles btnReboot.Click
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Power=reboot")
    End Sub

    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Power=off")
    End Sub

    Private Sub cbAngle_CheckedChanged(sender As Object, e As EventArgs) Handles cbAngle.CheckedChanged
        If cbAngle.Checked = False Then
            tbTopple.Enabled = False
            wbOnScreen.Navigate("http:/" & CurrentIP & "/cgi-bin/robot_code/robot.py?Topple=False")
        Else
            tbTopple.Enabled = True
            wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Topple=" + Str(tbTopple.Value))
        End If
    End Sub

    Private Sub tbTopple_MouseUp(sender As Object, e As MouseEventArgs) Handles tbTopple.MouseUp
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Topple=" + Str(tbTopple.Value))
    End Sub

    Private Sub btnCam_Click(sender As Object, e As EventArgs) Handles btnCam.Click
        If Camera = False Then
            browser.Load("http://" & CurrentIP & "/html/")
            btnCam.Text = "Camera 1"
            Camera = True
        ElseIf Camera = True Then
            browser.Load("http://" & CurrentIP & ":3400")
            btnCam.Text = "Camera 2"
            Camera = False
        End If
    End Sub
End Class