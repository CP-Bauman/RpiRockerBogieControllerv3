<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRobotController
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
        Me.tbWarnings = New System.Windows.Forms.TextBox()
        Me.btnTurn = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnSetupGamepad = New System.Windows.Forms.Button()
        Me.lblButtonAmount = New System.Windows.Forms.Label()
        Me.btnGamepads = New System.Windows.Forms.Button()
        Me.lblDpad = New System.Windows.Forms.Label()
        Me.lblLeftX = New System.Windows.Forms.Label()
        Me.lblRightY = New System.Windows.Forms.Label()
        Me.lblLeftY = New System.Windows.Forms.Label()
        Me.lblRightX = New System.Windows.Forms.Label()
        Me.lblButtonType = New System.Windows.Forms.Label()
        Me.gbslice = New System.Windows.Forms.GroupBox()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.lblVoltage = New System.Windows.Forms.Label()
        Me.gbBattery = New System.Windows.Forms.GroupBox()
        Me.pbBattery = New System.Windows.Forms.ProgressBar()
        Me.lblUptime = New System.Windows.Forms.Label()
        Me.gbTopple = New System.Windows.Forms.GroupBox()
        Me.cbAngle = New System.Windows.Forms.CheckBox()
        Me.tbTopple = New System.Windows.Forms.TrackBar()
        Me.lblRoll = New System.Windows.Forms.Label()
        Me.lblPitch = New System.Windows.Forms.Label()
        Me.lblTopple = New System.Windows.Forms.Label()
        Me.gbGamepad = New System.Windows.Forms.GroupBox()
        Me.lblRaw = New System.Windows.Forms.Label()
        Me.lblWheelAngle = New System.Windows.Forms.Label()
        Me.lblDirection = New System.Windows.Forms.Label()
        Me.wbGas = New System.Windows.Forms.WebBrowser()
        Me.tbSensors = New System.Windows.Forms.TextBox()
        Me.wbUptime = New System.Windows.Forms.WebBrowser()
        Me.wbTurnWheels = New System.Windows.Forms.WebBrowser()
        Me.wbTempAndHum = New System.Windows.Forms.WebBrowser()
        Me.pnlCamera = New System.Windows.Forms.Panel()
        Me.wbOnScreen = New System.Windows.Forms.WebBrowser()
        Me.wbGyroAccelComp = New System.Windows.Forms.WebBrowser()
        Me.wbSignalLevel = New System.Windows.Forms.WebBrowser()
        Me.wbLinkQuality = New System.Windows.Forms.WebBrowser()
        Me.wbgamepad = New System.Windows.Forms.WebBrowser()
        Me.wbSensors = New System.Windows.Forms.WebBrowser()
        Me.btnBackward = New System.Windows.Forms.Button()
        Me.gbSensors = New System.Windows.Forms.GroupBox()
        Me.lblSensors = New System.Windows.Forms.Label()
        Me.btnSaveSensor = New System.Windows.Forms.Button()
        Me.gbSystem = New System.Windows.Forms.GroupBox()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.btnReboot = New System.Windows.Forms.Button()
        Me.lblCPUTemp = New System.Windows.Forms.Label()
        Me.gbConnection = New System.Windows.Forms.GroupBox()
        Me.lblSignalLevel = New System.Windows.Forms.Label()
        Me.lblLinkQuality = New System.Windows.Forms.Label()
        Me.rbWireless = New System.Windows.Forms.RadioButton()
        Me.rbWired = New System.Windows.Forms.RadioButton()
        Me.gbCamera = New System.Windows.Forms.GroupBox()
        Me.btnLights = New System.Windows.Forms.Button()
        Me.btn3DMap = New System.Windows.Forms.Button()
        Me.tbrCamY = New System.Windows.Forms.TrackBar()
        Me.tbrCamX = New System.Windows.Forms.TrackBar()
        Me.btnCam = New System.Windows.Forms.Button()
        Me.gbControls = New System.Windows.Forms.GroupBox()
        Me.btnSaveWarning = New System.Windows.Forms.Button()
        Me.gbWarnings = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.tmrJoystick = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSensors = New System.Windows.Forms.Timer(Me.components)
        Me.gbBattery.SuspendLayout()
        Me.gbTopple.SuspendLayout()
        CType(Me.tbTopple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGamepad.SuspendLayout()
        Me.pnlCamera.SuspendLayout()
        Me.gbSensors.SuspendLayout()
        Me.gbSystem.SuspendLayout()
        Me.gbConnection.SuspendLayout()
        Me.gbCamera.SuspendLayout()
        CType(Me.tbrCamY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrCamX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbControls.SuspendLayout()
        Me.gbWarnings.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbWarnings
        '
        Me.tbWarnings.Location = New System.Drawing.Point(6, 19)
        Me.tbWarnings.Multiline = True
        Me.tbWarnings.Name = "tbWarnings"
        Me.tbWarnings.ReadOnly = True
        Me.tbWarnings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbWarnings.Size = New System.Drawing.Size(471, 91)
        Me.tbWarnings.TabIndex = 46
        '
        'btnTurn
        '
        Me.btnTurn.Location = New System.Drawing.Point(6, 67)
        Me.btnTurn.Name = "btnTurn"
        Me.btnTurn.Size = New System.Drawing.Size(210, 23)
        Me.btnTurn.TabIndex = 6
        Me.btnTurn.Text = "Turn Wheels"
        Me.btnTurn.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Enabled = False
        Me.btnLeft.Location = New System.Drawing.Point(6, 39)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(66, 23)
        Me.btnLeft.TabIndex = 9
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnForward
        '
        Me.btnForward.Location = New System.Drawing.Point(78, 10)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(66, 23)
        Me.btnForward.TabIndex = 6
        Me.btnForward.Text = "Forward"
        Me.btnForward.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Enabled = False
        Me.btnRight.Location = New System.Drawing.Point(150, 39)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(66, 23)
        Me.btnRight.TabIndex = 8
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnSetupGamepad
        '
        Me.btnSetupGamepad.Location = New System.Drawing.Point(6, 48)
        Me.btnSetupGamepad.Name = "btnSetupGamepad"
        Me.btnSetupGamepad.Size = New System.Drawing.Size(210, 23)
        Me.btnSetupGamepad.TabIndex = 10
        Me.btnSetupGamepad.Text = "Gamepad Help"
        Me.btnSetupGamepad.UseVisualStyleBackColor = True
        '
        'lblButtonAmount
        '
        Me.lblButtonAmount.AutoSize = True
        Me.lblButtonAmount.Location = New System.Drawing.Point(105, 100)
        Me.lblButtonAmount.Name = "lblButtonAmount"
        Me.lblButtonAmount.Size = New System.Drawing.Size(77, 13)
        Me.lblButtonAmount.TabIndex = 8
        Me.lblButtonAmount.Text = "Button Amount"
        '
        'btnGamepads
        '
        Me.btnGamepads.Location = New System.Drawing.Point(6, 19)
        Me.btnGamepads.Name = "btnGamepads"
        Me.btnGamepads.Size = New System.Drawing.Size(210, 23)
        Me.btnGamepads.TabIndex = 0
        Me.btnGamepads.Text = "Turn On Gamepad"
        Me.btnGamepads.UseVisualStyleBackColor = True
        '
        'lblDpad
        '
        Me.lblDpad.AutoSize = True
        Me.lblDpad.Location = New System.Drawing.Point(6, 114)
        Me.lblDpad.Name = "lblDpad"
        Me.lblDpad.Size = New System.Drawing.Size(33, 13)
        Me.lblDpad.TabIndex = 9
        Me.lblDpad.Text = "Dpad"
        '
        'lblLeftX
        '
        Me.lblLeftX.AutoSize = True
        Me.lblLeftX.Location = New System.Drawing.Point(6, 74)
        Me.lblLeftX.Name = "lblLeftX"
        Me.lblLeftX.Size = New System.Drawing.Size(32, 13)
        Me.lblLeftX.TabIndex = 1
        Me.lblLeftX.Text = "LeftX"
        '
        'lblRightY
        '
        Me.lblRightY.AutoSize = True
        Me.lblRightY.Location = New System.Drawing.Point(105, 87)
        Me.lblRightY.Name = "lblRightY"
        Me.lblRightY.Size = New System.Drawing.Size(39, 13)
        Me.lblRightY.TabIndex = 4
        Me.lblRightY.Text = "RightY"
        '
        'lblLeftY
        '
        Me.lblLeftY.AutoSize = True
        Me.lblLeftY.Location = New System.Drawing.Point(6, 87)
        Me.lblLeftY.Name = "lblLeftY"
        Me.lblLeftY.Size = New System.Drawing.Size(32, 13)
        Me.lblLeftY.TabIndex = 2
        Me.lblLeftY.Text = "LeftY"
        '
        'lblRightX
        '
        Me.lblRightX.AutoSize = True
        Me.lblRightX.Location = New System.Drawing.Point(105, 74)
        Me.lblRightX.Name = "lblRightX"
        Me.lblRightX.Size = New System.Drawing.Size(39, 13)
        Me.lblRightX.TabIndex = 3
        Me.lblRightX.Text = "RightX"
        '
        'lblButtonType
        '
        Me.lblButtonType.AutoSize = True
        Me.lblButtonType.Location = New System.Drawing.Point(6, 100)
        Me.lblButtonType.Name = "lblButtonType"
        Me.lblButtonType.Size = New System.Drawing.Size(65, 13)
        Me.lblButtonType.TabIndex = 7
        Me.lblButtonType.Text = "Button Type"
        '
        'gbslice
        '
        Me.gbslice.Location = New System.Drawing.Point(1107, 436)
        Me.gbslice.Name = "gbslice"
        Me.gbslice.Size = New System.Drawing.Size(222, 265)
        Me.gbslice.TabIndex = 45
        Me.gbslice.TabStop = False
        Me.gbslice.Text = "Slice"
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.BackColor = System.Drawing.Color.Transparent
        Me.lblPercentage.Location = New System.Drawing.Point(6, 42)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(62, 13)
        Me.lblPercentage.TabIndex = 7
        Me.lblPercentage.Text = "Percentage"
        '
        'lblVoltage
        '
        Me.lblVoltage.AutoSize = True
        Me.lblVoltage.Location = New System.Drawing.Point(6, 29)
        Me.lblVoltage.Name = "lblVoltage"
        Me.lblVoltage.Size = New System.Drawing.Size(43, 13)
        Me.lblVoltage.TabIndex = 6
        Me.lblVoltage.Text = "Voltage"
        '
        'gbBattery
        '
        Me.gbBattery.Controls.Add(Me.lblPercentage)
        Me.gbBattery.Controls.Add(Me.lblVoltage)
        Me.gbBattery.Controls.Add(Me.pbBattery)
        Me.gbBattery.Controls.Add(Me.lblUptime)
        Me.gbBattery.Location = New System.Drawing.Point(879, 556)
        Me.gbBattery.Name = "gbBattery"
        Me.gbBattery.Size = New System.Drawing.Size(222, 145)
        Me.gbBattery.TabIndex = 44
        Me.gbBattery.TabStop = False
        Me.gbBattery.Text = "Battery"
        '
        'pbBattery
        '
        Me.pbBattery.Location = New System.Drawing.Point(6, 87)
        Me.pbBattery.Name = "pbBattery"
        Me.pbBattery.Size = New System.Drawing.Size(210, 52)
        Me.pbBattery.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbBattery.TabIndex = 5
        Me.pbBattery.Value = 80
        '
        'lblUptime
        '
        Me.lblUptime.AccessibleDescription = "lblBattery"
        Me.lblUptime.AutoSize = True
        Me.lblUptime.Location = New System.Drawing.Point(6, 16)
        Me.lblUptime.Name = "lblUptime"
        Me.lblUptime.Size = New System.Drawing.Size(40, 13)
        Me.lblUptime.TabIndex = 4
        Me.lblUptime.Text = "Uptime"
        '
        'gbTopple
        '
        Me.gbTopple.Controls.Add(Me.cbAngle)
        Me.gbTopple.Controls.Add(Me.tbTopple)
        Me.gbTopple.Controls.Add(Me.lblRoll)
        Me.gbTopple.Controls.Add(Me.lblPitch)
        Me.gbTopple.Controls.Add(Me.lblTopple)
        Me.gbTopple.Location = New System.Drawing.Point(12, 278)
        Me.gbTopple.Name = "gbTopple"
        Me.gbTopple.Size = New System.Drawing.Size(222, 140)
        Me.gbTopple.TabIndex = 43
        Me.gbTopple.TabStop = False
        Me.gbTopple.Text = "Topple"
        '
        'cbAngle
        '
        Me.cbAngle.AutoSize = True
        Me.cbAngle.Checked = True
        Me.cbAngle.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbAngle.Location = New System.Drawing.Point(6, 19)
        Me.cbAngle.Name = "cbAngle"
        Me.cbAngle.Size = New System.Drawing.Size(110, 17)
        Me.cbAngle.TabIndex = 15
        Me.cbAngle.Text = "Topple Protection"
        Me.cbAngle.UseVisualStyleBackColor = True
        '
        'tbTopple
        '
        Me.tbTopple.Location = New System.Drawing.Point(6, 86)
        Me.tbTopple.Maximum = 90
        Me.tbTopple.Minimum = 20
        Me.tbTopple.Name = "tbTopple"
        Me.tbTopple.Size = New System.Drawing.Size(202, 45)
        Me.tbTopple.TabIndex = 16
        Me.tbTopple.Value = 20
        '
        'lblRoll
        '
        Me.lblRoll.AutoSize = True
        Me.lblRoll.Location = New System.Drawing.Point(3, 52)
        Me.lblRoll.Name = "lblRoll"
        Me.lblRoll.Size = New System.Drawing.Size(25, 13)
        Me.lblRoll.TabIndex = 14
        Me.lblRoll.Text = "Roll"
        '
        'lblPitch
        '
        Me.lblPitch.AutoSize = True
        Me.lblPitch.Location = New System.Drawing.Point(3, 39)
        Me.lblPitch.Name = "lblPitch"
        Me.lblPitch.Size = New System.Drawing.Size(31, 13)
        Me.lblPitch.TabIndex = 12
        Me.lblPitch.Text = "Pitch"
        '
        'lblTopple
        '
        Me.lblTopple.AutoSize = True
        Me.lblTopple.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopple.Location = New System.Drawing.Point(3, 65)
        Me.lblTopple.Name = "lblTopple"
        Me.lblTopple.Size = New System.Drawing.Size(188, 16)
        Me.lblTopple.TabIndex = 17
        Me.lblTopple.Text = "Topple protection Threshhold:"
        '
        'gbGamepad
        '
        Me.gbGamepad.Controls.Add(Me.lblRaw)
        Me.gbGamepad.Controls.Add(Me.lblWheelAngle)
        Me.gbGamepad.Controls.Add(Me.lblDirection)
        Me.gbGamepad.Controls.Add(Me.btnSetupGamepad)
        Me.gbGamepad.Controls.Add(Me.lblButtonAmount)
        Me.gbGamepad.Controls.Add(Me.btnGamepads)
        Me.gbGamepad.Controls.Add(Me.lblDpad)
        Me.gbGamepad.Controls.Add(Me.lblLeftX)
        Me.gbGamepad.Controls.Add(Me.lblRightY)
        Me.gbGamepad.Controls.Add(Me.lblLeftY)
        Me.gbGamepad.Controls.Add(Me.lblRightX)
        Me.gbGamepad.Controls.Add(Me.lblButtonType)
        Me.gbGamepad.Location = New System.Drawing.Point(12, 556)
        Me.gbGamepad.Name = "gbGamepad"
        Me.gbGamepad.Size = New System.Drawing.Size(222, 145)
        Me.gbGamepad.TabIndex = 31
        Me.gbGamepad.TabStop = False
        Me.gbGamepad.Text = "Gamepad"
        '
        'lblRaw
        '
        Me.lblRaw.AutoSize = True
        Me.lblRaw.Location = New System.Drawing.Point(6, 129)
        Me.lblRaw.Name = "lblRaw"
        Me.lblRaw.Size = New System.Drawing.Size(39, 13)
        Me.lblRaw.TabIndex = 13
        Me.lblRaw.Text = "Label1"
        '
        'lblWheelAngle
        '
        Me.lblWheelAngle.AutoSize = True
        Me.lblWheelAngle.Location = New System.Drawing.Point(105, 126)
        Me.lblWheelAngle.Name = "lblWheelAngle"
        Me.lblWheelAngle.Size = New System.Drawing.Size(68, 13)
        Me.lblWheelAngle.TabIndex = 12
        Me.lblWheelAngle.Text = "Wheel Angle"
        '
        'lblDirection
        '
        Me.lblDirection.AutoSize = True
        Me.lblDirection.Location = New System.Drawing.Point(105, 113)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(49, 13)
        Me.lblDirection.TabIndex = 11
        Me.lblDirection.Text = "Direction"
        '
        'wbGas
        '
        Me.wbGas.CausesValidation = False
        Me.wbGas.Location = New System.Drawing.Point(394, 443)
        Me.wbGas.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbGas.Name = "wbGas"
        Me.wbGas.Size = New System.Drawing.Size(20, 20)
        Me.wbGas.TabIndex = 41
        Me.wbGas.Visible = False
        '
        'tbSensors
        '
        Me.tbSensors.Location = New System.Drawing.Point(288, 443)
        Me.tbSensors.Name = "tbSensors"
        Me.tbSensors.Size = New System.Drawing.Size(100, 20)
        Me.tbSensors.TabIndex = 40
        Me.tbSensors.Visible = False
        '
        'wbUptime
        '
        Me.wbUptime.Location = New System.Drawing.Point(233, 443)
        Me.wbUptime.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbUptime.Name = "wbUptime"
        Me.wbUptime.Size = New System.Drawing.Size(20, 20)
        Me.wbUptime.TabIndex = 38
        Me.wbUptime.Visible = False
        '
        'wbTurnWheels
        '
        Me.wbTurnWheels.Location = New System.Drawing.Point(207, 443)
        Me.wbTurnWheels.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbTurnWheels.Name = "wbTurnWheels"
        Me.wbTurnWheels.Size = New System.Drawing.Size(20, 20)
        Me.wbTurnWheels.TabIndex = 37
        Me.wbTurnWheels.Visible = False
        '
        'wbTempAndHum
        '
        Me.wbTempAndHum.Location = New System.Drawing.Point(181, 443)
        Me.wbTempAndHum.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbTempAndHum.Name = "wbTempAndHum"
        Me.wbTempAndHum.Size = New System.Drawing.Size(20, 20)
        Me.wbTempAndHum.TabIndex = 36
        Me.wbTempAndHum.Url = New System.Uri("", System.UriKind.Relative)
        Me.wbTempAndHum.Visible = False
        '
        'pnlCamera
        '
        Me.pnlCamera.Controls.Add(Me.wbOnScreen)
        Me.pnlCamera.Controls.Add(Me.wbGyroAccelComp)
        Me.pnlCamera.Controls.Add(Me.wbSignalLevel)
        Me.pnlCamera.Controls.Add(Me.wbTempAndHum)
        Me.pnlCamera.Controls.Add(Me.wbGas)
        Me.pnlCamera.Controls.Add(Me.wbLinkQuality)
        Me.pnlCamera.Controls.Add(Me.wbTurnWheels)
        Me.pnlCamera.Controls.Add(Me.tbSensors)
        Me.pnlCamera.Controls.Add(Me.wbgamepad)
        Me.pnlCamera.Controls.Add(Me.wbSensors)
        Me.pnlCamera.Controls.Add(Me.wbUptime)
        Me.pnlCamera.Location = New System.Drawing.Point(240, 12)
        Me.pnlCamera.Name = "pnlCamera"
        Me.pnlCamera.Size = New System.Drawing.Size(861, 538)
        Me.pnlCamera.TabIndex = 34
        '
        'wbOnScreen
        '
        Me.wbOnScreen.Location = New System.Drawing.Point(65, 39)
        Me.wbOnScreen.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbOnScreen.Name = "wbOnScreen"
        Me.wbOnScreen.ScrollBarsEnabled = False
        Me.wbOnScreen.Size = New System.Drawing.Size(479, 344)
        Me.wbOnScreen.TabIndex = 23
        '
        'wbGyroAccelComp
        '
        Me.wbGyroAccelComp.CausesValidation = False
        Me.wbGyroAccelComp.Location = New System.Drawing.Point(259, 443)
        Me.wbGyroAccelComp.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbGyroAccelComp.Name = "wbGyroAccelComp"
        Me.wbGyroAccelComp.Size = New System.Drawing.Size(20, 20)
        Me.wbGyroAccelComp.TabIndex = 39
        Me.wbGyroAccelComp.Visible = False
        '
        'wbSignalLevel
        '
        Me.wbSignalLevel.Location = New System.Drawing.Point(155, 443)
        Me.wbSignalLevel.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbSignalLevel.Name = "wbSignalLevel"
        Me.wbSignalLevel.Size = New System.Drawing.Size(20, 20)
        Me.wbSignalLevel.TabIndex = 32
        Me.wbSignalLevel.Visible = False
        '
        'wbLinkQuality
        '
        Me.wbLinkQuality.Location = New System.Drawing.Point(129, 443)
        Me.wbLinkQuality.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbLinkQuality.Name = "wbLinkQuality"
        Me.wbLinkQuality.Size = New System.Drawing.Size(20, 20)
        Me.wbLinkQuality.TabIndex = 33
        Me.wbLinkQuality.Visible = False
        '
        'wbgamepad
        '
        Me.wbgamepad.Location = New System.Drawing.Point(77, 443)
        Me.wbgamepad.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbgamepad.Name = "wbgamepad"
        Me.wbgamepad.Size = New System.Drawing.Size(20, 20)
        Me.wbgamepad.TabIndex = 35
        Me.wbgamepad.Visible = False
        '
        'wbSensors
        '
        Me.wbSensors.Location = New System.Drawing.Point(103, 443)
        Me.wbSensors.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbSensors.Name = "wbSensors"
        Me.wbSensors.Size = New System.Drawing.Size(20, 20)
        Me.wbSensors.TabIndex = 27
        Me.wbSensors.Visible = False
        '
        'btnBackward
        '
        Me.btnBackward.Location = New System.Drawing.Point(78, 39)
        Me.btnBackward.Name = "btnBackward"
        Me.btnBackward.Size = New System.Drawing.Size(66, 23)
        Me.btnBackward.TabIndex = 7
        Me.btnBackward.Text = "Backward"
        Me.btnBackward.UseVisualStyleBackColor = True
        '
        'gbSensors
        '
        Me.gbSensors.Controls.Add(Me.lblSensors)
        Me.gbSensors.Controls.Add(Me.btnSaveSensor)
        Me.gbSensors.Location = New System.Drawing.Point(1107, 12)
        Me.gbSensors.Name = "gbSensors"
        Me.gbSensors.Size = New System.Drawing.Size(222, 418)
        Me.gbSensors.TabIndex = 28
        Me.gbSensors.TabStop = False
        Me.gbSensors.Text = "Sensors"
        '
        'lblSensors
        '
        Me.lblSensors.AutoSize = True
        Me.lblSensors.Location = New System.Drawing.Point(6, 16)
        Me.lblSensors.Name = "lblSensors"
        Me.lblSensors.Size = New System.Drawing.Size(45, 13)
        Me.lblSensors.TabIndex = 6
        Me.lblSensors.Text = "Sensors"
        '
        'btnSaveSensor
        '
        Me.btnSaveSensor.Location = New System.Drawing.Point(6, 383)
        Me.btnSaveSensor.Name = "btnSaveSensor"
        Me.btnSaveSensor.Size = New System.Drawing.Size(210, 23)
        Me.btnSaveSensor.TabIndex = 0
        Me.btnSaveSensor.Text = "Save Sensor Values"
        Me.btnSaveSensor.UseVisualStyleBackColor = True
        '
        'gbSystem
        '
        Me.gbSystem.Controls.Add(Me.btnSettings)
        Me.gbSystem.Controls.Add(Me.btnShutdown)
        Me.gbSystem.Controls.Add(Me.btnReboot)
        Me.gbSystem.Controls.Add(Me.lblCPUTemp)
        Me.gbSystem.Location = New System.Drawing.Point(12, 424)
        Me.gbSystem.Name = "gbSystem"
        Me.gbSystem.Size = New System.Drawing.Size(222, 126)
        Me.gbSystem.TabIndex = 26
        Me.gbSystem.TabStop = False
        Me.gbSystem.Text = "System"
        '
        'btnSettings
        '
        Me.btnSettings.Location = New System.Drawing.Point(9, 77)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(207, 23)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'btnShutdown
        '
        Me.btnShutdown.Location = New System.Drawing.Point(9, 48)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(207, 23)
        Me.btnShutdown.TabIndex = 2
        Me.btnShutdown.Text = "Shutdown"
        Me.btnShutdown.UseVisualStyleBackColor = True
        '
        'btnReboot
        '
        Me.btnReboot.Location = New System.Drawing.Point(9, 19)
        Me.btnReboot.Name = "btnReboot"
        Me.btnReboot.Size = New System.Drawing.Size(207, 23)
        Me.btnReboot.TabIndex = 1
        Me.btnReboot.Text = "Restart Robot"
        Me.btnReboot.UseVisualStyleBackColor = True
        '
        'lblCPUTemp
        '
        Me.lblCPUTemp.AutoSize = True
        Me.lblCPUTemp.Location = New System.Drawing.Point(6, 103)
        Me.lblCPUTemp.Name = "lblCPUTemp"
        Me.lblCPUTemp.Size = New System.Drawing.Size(53, 13)
        Me.lblCPUTemp.TabIndex = 0
        Me.lblCPUTemp.Text = "CpuTemp"
        '
        'gbConnection
        '
        Me.gbConnection.Controls.Add(Me.lblSignalLevel)
        Me.gbConnection.Controls.Add(Me.lblLinkQuality)
        Me.gbConnection.Controls.Add(Me.rbWireless)
        Me.gbConnection.Controls.Add(Me.rbWired)
        Me.gbConnection.Location = New System.Drawing.Point(240, 556)
        Me.gbConnection.Name = "gbConnection"
        Me.gbConnection.Size = New System.Drawing.Size(144, 145)
        Me.gbConnection.TabIndex = 25
        Me.gbConnection.TabStop = False
        Me.gbConnection.Text = "Connection"
        '
        'lblSignalLevel
        '
        Me.lblSignalLevel.AutoSize = True
        Me.lblSignalLevel.Location = New System.Drawing.Point(6, 75)
        Me.lblSignalLevel.Name = "lblSignalLevel"
        Me.lblSignalLevel.Size = New System.Drawing.Size(65, 13)
        Me.lblSignalLevel.TabIndex = 7
        Me.lblSignalLevel.Text = "Signal Level"
        '
        'lblLinkQuality
        '
        Me.lblLinkQuality.AutoSize = True
        Me.lblLinkQuality.Location = New System.Drawing.Point(6, 62)
        Me.lblLinkQuality.Name = "lblLinkQuality"
        Me.lblLinkQuality.Size = New System.Drawing.Size(62, 13)
        Me.lblLinkQuality.TabIndex = 6
        Me.lblLinkQuality.Text = "Link Quality"
        '
        'rbWireless
        '
        Me.rbWireless.AutoSize = True
        Me.rbWireless.Location = New System.Drawing.Point(6, 42)
        Me.rbWireless.Name = "rbWireless"
        Me.rbWireless.Size = New System.Drawing.Size(65, 17)
        Me.rbWireless.TabIndex = 5
        Me.rbWireless.TabStop = True
        Me.rbWireless.Text = "Wireless"
        Me.rbWireless.UseVisualStyleBackColor = True
        '
        'rbWired
        '
        Me.rbWired.AutoSize = True
        Me.rbWired.Location = New System.Drawing.Point(6, 19)
        Me.rbWired.Name = "rbWired"
        Me.rbWired.Size = New System.Drawing.Size(53, 17)
        Me.rbWired.TabIndex = 0
        Me.rbWired.TabStop = True
        Me.rbWired.Text = "Wired"
        Me.rbWired.UseVisualStyleBackColor = True
        '
        'gbCamera
        '
        Me.gbCamera.Controls.Add(Me.btnLights)
        Me.gbCamera.Controls.Add(Me.btn3DMap)
        Me.gbCamera.Controls.Add(Me.tbrCamY)
        Me.gbCamera.Controls.Add(Me.tbrCamX)
        Me.gbCamera.Controls.Add(Me.btnCam)
        Me.gbCamera.Location = New System.Drawing.Point(12, 115)
        Me.gbCamera.Name = "gbCamera"
        Me.gbCamera.Size = New System.Drawing.Size(222, 157)
        Me.gbCamera.TabIndex = 24
        Me.gbCamera.TabStop = False
        Me.gbCamera.Text = "Camera"
        '
        'btnLights
        '
        Me.btnLights.Location = New System.Drawing.Point(6, 128)
        Me.btnLights.Name = "btnLights"
        Me.btnLights.Size = New System.Drawing.Size(159, 23)
        Me.btnLights.TabIndex = 7
        Me.btnLights.Text = "Lights On"
        Me.btnLights.UseVisualStyleBackColor = True
        '
        'btn3DMap
        '
        Me.btn3DMap.Location = New System.Drawing.Point(6, 99)
        Me.btn3DMap.Name = "btn3DMap"
        Me.btn3DMap.Size = New System.Drawing.Size(159, 23)
        Me.btn3DMap.TabIndex = 5
        Me.btn3DMap.Text = "3D Map"
        Me.btn3DMap.UseVisualStyleBackColor = True
        '
        'tbrCamY
        '
        Me.tbrCamY.Location = New System.Drawing.Point(171, 19)
        Me.tbrCamY.Maximum = 135
        Me.tbrCamY.Minimum = -90
        Me.tbrCamY.Name = "tbrCamY"
        Me.tbrCamY.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrCamY.Size = New System.Drawing.Size(45, 132)
        Me.tbrCamY.TabIndex = 5
        '
        'tbrCamX
        '
        Me.tbrCamX.Location = New System.Drawing.Point(6, 19)
        Me.tbrCamX.Maximum = 135
        Me.tbrCamX.Minimum = -135
        Me.tbrCamX.Name = "tbrCamX"
        Me.tbrCamX.Size = New System.Drawing.Size(159, 45)
        Me.tbrCamX.TabIndex = 4
        '
        'btnCam
        '
        Me.btnCam.Location = New System.Drawing.Point(6, 70)
        Me.btnCam.Name = "btnCam"
        Me.btnCam.Size = New System.Drawing.Size(159, 23)
        Me.btnCam.TabIndex = 4
        Me.btnCam.Text = "Camera 1"
        Me.btnCam.UseVisualStyleBackColor = True
        '
        'gbControls
        '
        Me.gbControls.Controls.Add(Me.btnTurn)
        Me.gbControls.Controls.Add(Me.btnLeft)
        Me.gbControls.Controls.Add(Me.btnForward)
        Me.gbControls.Controls.Add(Me.btnRight)
        Me.gbControls.Controls.Add(Me.btnBackward)
        Me.gbControls.Location = New System.Drawing.Point(12, 12)
        Me.gbControls.Name = "gbControls"
        Me.gbControls.Size = New System.Drawing.Size(222, 97)
        Me.gbControls.TabIndex = 29
        Me.gbControls.TabStop = False
        Me.gbControls.Text = "Controls"
        '
        'btnSaveWarning
        '
        Me.btnSaveWarning.Location = New System.Drawing.Point(6, 116)
        Me.btnSaveWarning.Name = "btnSaveWarning"
        Me.btnSaveWarning.Size = New System.Drawing.Size(471, 23)
        Me.btnSaveWarning.TabIndex = 47
        Me.btnSaveWarning.Text = "Save Warning Log"
        Me.btnSaveWarning.UseVisualStyleBackColor = True
        '
        'gbWarnings
        '
        Me.gbWarnings.Controls.Add(Me.btnSaveWarning)
        Me.gbWarnings.Controls.Add(Me.tbWarnings)
        Me.gbWarnings.Location = New System.Drawing.Point(390, 556)
        Me.gbWarnings.Name = "gbWarnings"
        Me.gbWarnings.Size = New System.Drawing.Size(483, 145)
        Me.gbWarnings.TabIndex = 30
        Me.gbWarnings.TabStop = False
        Me.gbWarnings.Text = "Warnings"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 707)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(1317, 36)
        Me.btnClose.TabIndex = 46
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'tmrJoystick
        '
        '
        'tmrSensors
        '
        '
        'frmRobotController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1341, 749)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.gbslice)
        Me.Controls.Add(Me.gbBattery)
        Me.Controls.Add(Me.gbTopple)
        Me.Controls.Add(Me.gbGamepad)
        Me.Controls.Add(Me.pnlCamera)
        Me.Controls.Add(Me.gbSensors)
        Me.Controls.Add(Me.gbSystem)
        Me.Controls.Add(Me.gbConnection)
        Me.Controls.Add(Me.gbCamera)
        Me.Controls.Add(Me.gbControls)
        Me.Controls.Add(Me.gbWarnings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRobotController"
        Me.ShowIcon = False
        Me.Text = "Robot Controller"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbBattery.ResumeLayout(False)
        Me.gbBattery.PerformLayout()
        Me.gbTopple.ResumeLayout(False)
        Me.gbTopple.PerformLayout()
        CType(Me.tbTopple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGamepad.ResumeLayout(False)
        Me.gbGamepad.PerformLayout()
        Me.pnlCamera.ResumeLayout(False)
        Me.pnlCamera.PerformLayout()
        Me.gbSensors.ResumeLayout(False)
        Me.gbSensors.PerformLayout()
        Me.gbSystem.ResumeLayout(False)
        Me.gbSystem.PerformLayout()
        Me.gbConnection.ResumeLayout(False)
        Me.gbConnection.PerformLayout()
        Me.gbCamera.ResumeLayout(False)
        Me.gbCamera.PerformLayout()
        CType(Me.tbrCamY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrCamX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbControls.ResumeLayout(False)
        Me.gbWarnings.ResumeLayout(False)
        Me.gbWarnings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbWarnings As TextBox
    Friend WithEvents btnTurn As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnForward As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents btnSetupGamepad As Button
    Friend WithEvents lblButtonAmount As Label
    Friend WithEvents btnGamepads As Button
    Friend WithEvents lblDpad As Label
    Friend WithEvents lblLeftX As Label
    Friend WithEvents lblRightY As Label
    Friend WithEvents lblLeftY As Label
    Friend WithEvents lblRightX As Label
    Friend WithEvents lblButtonType As Label
    Friend WithEvents gbslice As GroupBox
    Friend WithEvents lblPercentage As Label
    Friend WithEvents lblVoltage As Label
    Friend WithEvents gbBattery As GroupBox
    Friend WithEvents pbBattery As ProgressBar
    Friend WithEvents lblUptime As Label
    Friend WithEvents gbTopple As GroupBox
    Friend WithEvents cbAngle As CheckBox
    Friend WithEvents tbTopple As TrackBar
    Friend WithEvents lblRoll As Label
    Friend WithEvents lblPitch As Label
    Friend WithEvents lblTopple As Label
    Friend WithEvents gbGamepad As GroupBox
    Friend WithEvents wbGas As WebBrowser
    Friend WithEvents tbSensors As TextBox
    Friend WithEvents wbUptime As WebBrowser
    Friend WithEvents wbTurnWheels As WebBrowser
    Friend WithEvents wbTempAndHum As WebBrowser
    Friend WithEvents pnlCamera As Panel
    Friend WithEvents btnBackward As Button
    Friend WithEvents gbSensors As GroupBox
    Friend WithEvents lblSensors As Label
    Friend WithEvents btnSaveSensor As Button
    Friend WithEvents wbGyroAccelComp As WebBrowser
    Friend WithEvents wbSignalLevel As WebBrowser
    Friend WithEvents wbLinkQuality As WebBrowser
    Friend WithEvents wbgamepad As WebBrowser
    Friend WithEvents wbSensors As WebBrowser
    Friend WithEvents wbOnScreen As WebBrowser
    Friend WithEvents gbSystem As GroupBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnShutdown As Button
    Friend WithEvents btnReboot As Button
    Friend WithEvents lblCPUTemp As Label
    Friend WithEvents gbConnection As GroupBox
    Friend WithEvents lblSignalLevel As Label
    Friend WithEvents lblLinkQuality As Label
    Friend WithEvents rbWireless As RadioButton
    Friend WithEvents rbWired As RadioButton
    Friend WithEvents gbCamera As GroupBox
    Friend WithEvents btnLights As Button
    Friend WithEvents btn3DMap As Button
    Friend WithEvents tbrCamY As TrackBar
    Friend WithEvents tbrCamX As TrackBar
    Friend WithEvents btnCam As Button
    Friend WithEvents gbControls As GroupBox
    Friend WithEvents btnSaveWarning As Button
    Friend WithEvents gbWarnings As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents tmrJoystick As Timer
    Friend WithEvents lblDirection As Label
    Friend WithEvents lblWheelAngle As Label
    Friend WithEvents lblRaw As Label
    Friend WithEvents tmrSensors As Timer
End Class
