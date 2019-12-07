<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistration
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistration))
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.pbStrength = New System.Windows.Forms.ProgressBar()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblVerified = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lvlVrfCode = New System.Windows.Forms.Label()
        Me.txtVrfCode = New System.Windows.Forms.TextBox()
        Me.btnSendAC = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblProgressbar = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(131, 101)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(148, 20)
        Me.txtPwd.TabIndex = 0
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Location = New System.Drawing.Point(41, 108)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(59, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password: "
        Me.ToolTip1.SetToolTip(Me.lblPassword, "Password field can not be empty")
        '
        'pbStrength
        '
        Me.pbStrength.Location = New System.Drawing.Point(132, 125)
        Me.pbStrength.Margin = New System.Windows.Forms.Padding(2)
        Me.pbStrength.Name = "pbStrength"
        Me.pbStrength.Size = New System.Drawing.Size(148, 15)
        Me.pbStrength.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.pbStrength, "fgPassword strength indicatior")
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistration.ForeColor = System.Drawing.Color.Green
        Me.lblRegistration.Location = New System.Drawing.Point(137, 9)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(136, 20)
        Me.lblRegistration.TabIndex = 4
        Me.lblRegistration.Text = "Registration Form"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Location = New System.Drawing.Point(41, 70)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username:"
        Me.ToolTip1.SetToolTip(Me.lblUsername, "Username field can not be empty")
        '
        'txtUsername
        '
        Me.txtUsername.AccessibleDescription = ""
        Me.txtUsername.AccessibleName = ""
        Me.txtUsername.Location = New System.Drawing.Point(131, 63)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(149, 20)
        Me.txtUsername.TabIndex = 6
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Location = New System.Drawing.Point(41, 170)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email:"
        Me.ToolTip1.SetToolTip(Me.lblEmail, "Email field can not be empty.Please use your real email")
        '
        'lblVerified
        '
        Me.lblVerified.AutoSize = True
        Me.lblVerified.BackColor = System.Drawing.Color.Transparent
        Me.lblVerified.Location = New System.Drawing.Point(210, 186)
        Me.lblVerified.Name = "lblVerified"
        Me.lblVerified.Size = New System.Drawing.Size(0, 13)
        Me.lblVerified.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(132, 163)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(148, 20)
        Me.txtEmail.TabIndex = 9
        '
        'lvlVrfCode
        '
        Me.lvlVrfCode.AutoSize = True
        Me.lvlVrfCode.BackColor = System.Drawing.Color.Transparent
        Me.lvlVrfCode.Location = New System.Drawing.Point(41, 211)
        Me.lvlVrfCode.Name = "lvlVrfCode"
        Me.lvlVrfCode.Size = New System.Drawing.Size(90, 13)
        Me.lvlVrfCode.TabIndex = 10
        Me.lvlVrfCode.Text = "Verification Code:"
        Me.ToolTip1.SetToolTip(Me.lvlVrfCode, "Verification code sends to the specified email ")
        '
        'txtVrfCode
        '
        Me.txtVrfCode.Location = New System.Drawing.Point(131, 204)
        Me.txtVrfCode.Name = "txtVrfCode"
        Me.txtVrfCode.Size = New System.Drawing.Size(147, 20)
        Me.txtVrfCode.TabIndex = 11
        '
        'btnSendAC
        '
        Me.btnSendAC.BackColor = System.Drawing.Color.Transparent
        Me.btnSendAC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSendAC.Location = New System.Drawing.Point(286, 163)
        Me.btnSendAC.Name = "btnSendAC"
        Me.btnSendAC.Size = New System.Drawing.Size(123, 21)
        Me.btnSendAC.TabIndex = 12
        Me.btnSendAC.Text = "Send Verification Code"
        Me.ToolTip1.SetToolTip(Me.btnSendAC, "Verification Code sends to the specified email within few minutes")
        Me.btnSendAC.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Location = New System.Drawing.Point(132, 265)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(147, 24)
        Me.btnRegister.TabIndex = 13
        Me.btnRegister.Text = "Register"
        Me.ToolTip1.SetToolTip(Me.btnRegister, "Fill all fields with your personal information")
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'lblProgressbar
        '
        Me.lblProgressbar.AutoSize = True
        Me.lblProgressbar.Location = New System.Drawing.Point(285, 127)
        Me.lblProgressbar.Name = "lblProgressbar"
        Me.lblProgressbar.Size = New System.Drawing.Size(0, 13)
        Me.lblProgressbar.TabIndex = 14
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Coral
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(1, 313)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "<- Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmRegistration
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(428, 348)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblProgressbar)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.btnSendAC)
        Me.Controls.Add(Me.txtVrfCode)
        Me.Controls.Add(Me.lvlVrfCode)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblVerified)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblRegistration)
        Me.Controls.Add(Me.pbStrength)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPwd)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmRegistration"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "[Server] Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPwd As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents pbStrength As ProgressBar
    Friend WithEvents lblRegistration As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblVerified As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lvlVrfCode As Label
    Friend WithEvents txtVrfCode As TextBox
    Friend WithEvents btnSendAC As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblProgressbar As Label
    Friend WithEvents btnBack As Button
End Class
