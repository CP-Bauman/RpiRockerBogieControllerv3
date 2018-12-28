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
    Public CPUTemp As Decimal
    Public SignalLevel As Integer
    Public LinkQuality As Integer
    Public Lights As Boolean = True
    Public Camera As Boolean = True
    Public UptimeMin As Integer
    Public UptimeHour As Integer = 0
    Public uptime As String
    Public GyroX As String = "0"
    Public GyroY As String = "0"
    Public GyroZ As String = "0"
    Public Gyro As String
    Public AccelerometerX As String = "0"
    Public AccelerometerY As String = "0"
    Public AccelerometerZ As String = "0"
    Public CompassX As String = "0"
    Public CompassY As String = "0"
    Public CompassZ As String = "0"
    Public Gas As String
    Public TempandHum As String
    Public angle As Double
    Public angle2 As Double
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
        ' Get the joystick information
        ' Program from https://social.msdn.microsoft.com/Forums/vstudio/en-US/af28b35b-d756-4d87-94c6-ced882ab20a5/reading-input-data-from-joystick-in-visual-basic?forum=vbgeneral Modified by Christiaan Bauman
        Call joyGetPosEx(0, myjoyEX)

        With myjoyEX
            LeftX = (.dwXpos - 32767.5) / 1635 'convert raw values to more easy useable values
            LeftY = (.dwYpos - 32767.5) / 1635
            RightX = (.dwZpos - 32767.5) / 1635
            rightY = (.dwRpos - 32767.5) / 1635
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
        End With

    End Sub

    Private Sub btnForward_MouseDown(sender As Object, e As MouseEventArgs) Handles btnForward.MouseDown
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=A&Speed1=2000?Channel2=E&Speed2=4000") 'drive forward
    End Sub

    Private Sub btnForward_MouseUp(sender As Object, e As MouseEventArgs) Handles btnForward.MouseUp
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=AE&Speed1=0") 'stop robot
    End Sub

    Private Sub btnBackward_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBackward.MouseDown
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=A&Speed1=4000?Channel2=E&Speed2=2000") 'drive backward
    End Sub

    Private Sub btnBackward_MouseUp(sender As Object, e As MouseEventArgs) Handles btnBackward.MouseUp
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=AE&Speed1=0") 'stop robot
    End Sub

    Private Sub btnRight_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRight.MouseDown
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=A&Speed1=2000?Channel2=E&Speed2=2000") 'turn right
    End Sub

    Private Sub btnLeft_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLeft.MouseDown
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=A&Speed1=4000?Channel2=E&Speed2=4000") 'turn left
    End Sub

    Private Sub btnLeft_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLeft.MouseUp
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=AE&Speed1=0") 'stop robot
    End Sub

    Private Sub btnRight_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRight.MouseUp
        wbOnScreen.Navigate("http://" & CurrentIP & "/cgi-bin/robot_code/robot.py?Channel1=AE&Speed1=0") 'stop robot
    End Sub
End Class
