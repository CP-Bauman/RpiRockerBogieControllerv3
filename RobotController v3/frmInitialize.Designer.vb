<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInitiate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnInitiate = New System.Windows.Forms.Button()
        Me.lblConnectionStatus = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.tbIP = New System.Windows.Forms.TextBox()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.wbConnected = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'btnInitiate
        '
        Me.btnInitiate.Location = New System.Drawing.Point(15, 51)
        Me.btnInitiate.Name = "btnInitiate"
        Me.btnInitiate.Size = New System.Drawing.Size(75, 23)
        Me.btnInitiate.TabIndex = 0
        Me.btnInitiate.Text = "Initiate"
        Me.btnInitiate.UseVisualStyleBackColor = True
        '
        'lblConnectionStatus
        '
        Me.lblConnectionStatus.AutoSize = True
        Me.lblConnectionStatus.Location = New System.Drawing.Point(12, 9)
        Me.lblConnectionStatus.Name = "lblConnectionStatus"
        Me.lblConnectionStatus.Size = New System.Drawing.Size(94, 13)
        Me.lblConnectionStatus.TabIndex = 1
        Me.lblConnectionStatus.Text = "Connection Status"
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(137, 51)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'tbIP
        '
        Me.tbIP.Location = New System.Drawing.Point(38, 25)
        Me.tbIP.Name = "tbIP"
        Me.tbIP.Size = New System.Drawing.Size(174, 20)
        Me.tbIP.TabIndex = 3
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(12, 28)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(20, 13)
        Me.lblIP.TabIndex = 5
        Me.lblIP.Text = "IP:"
        '
        'wbConnected
        '
        Me.wbConnected.Location = New System.Drawing.Point(96, 51)
        Me.wbConnected.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbConnected.Name = "wbConnected"
        Me.wbConnected.Size = New System.Drawing.Size(20, 20)
        Me.wbConnected.TabIndex = 6
        Me.wbConnected.Visible = False
        '
        'frmInitiate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(227, 84)
        Me.Controls.Add(Me.wbConnected)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.tbIP)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lblConnectionStatus)
        Me.Controls.Add(Me.btnInitiate)
        Me.Name = "frmInitiate"
        Me.Text = "Initiate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInitiate As Button
    Friend WithEvents lblConnectionStatus As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents tbIP As TextBox
    Friend WithEvents lblIP As Label
    Friend WithEvents wbConnected As WebBrowser
End Class
