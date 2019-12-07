<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaptcha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaptcha))
        Me.lblCaptcha = New System.Windows.Forms.Label()
        Me.btnSound = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtCaptcha = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.bxCaptcha = New Lab1.Captcha()
        CType(Me.bxCaptcha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCaptcha
        '
        Me.lblCaptcha.AutoSize = True
        Me.lblCaptcha.BackColor = System.Drawing.Color.Transparent
        Me.lblCaptcha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaptcha.ForeColor = System.Drawing.Color.OliveDrab
        Me.lblCaptcha.Location = New System.Drawing.Point(159, 20)
        Me.lblCaptcha.Name = "lblCaptcha"
        Me.lblCaptcha.Size = New System.Drawing.Size(129, 24)
        Me.lblCaptcha.TabIndex = 3
        Me.lblCaptcha.Text = "Captcha Form"
        '
        'btnSound
        '
        Me.btnSound.BackColor = System.Drawing.Color.Sienna
        Me.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSound.Location = New System.Drawing.Point(340, 112)
        Me.btnSound.Name = "btnSound"
        Me.btnSound.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSound.Size = New System.Drawing.Size(78, 23)
        Me.btnSound.TabIndex = 7
        Me.btnSound.Text = "Play"
        Me.btnSound.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Coral
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(340, 66)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(78, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(163, 210)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(98, 31)
        Me.btnSubmit.TabIndex = 9
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtCaptcha
        '
        Me.txtCaptcha.Location = New System.Drawing.Point(102, 171)
        Me.txtCaptcha.Name = "txtCaptcha"
        Me.txtCaptcha.Size = New System.Drawing.Size(232, 20)
        Me.txtCaptcha.TabIndex = 8
        '
        'BackgroundWorker1
        '
        '
        'bxCaptcha
        '
        Me.bxCaptcha.BackColor = System.Drawing.Color.Transparent
        Me.bxCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bxCaptcha.CaptchaTextLength = 8
        Me.bxCaptcha.Location = New System.Drawing.Point(93, 66)
        Me.bxCaptcha.Name = "bxCaptcha"
        Me.bxCaptcha.NumberOfLines = 50
        Me.bxCaptcha.RandomCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmopqrstuvwxyz!#$%^&*()1234567890"
        Me.bxCaptcha.Size = New System.Drawing.Size(241, 69)
        Me.bxCaptcha.TabIndex = 10
        Me.bxCaptcha.TabStop = False
        Me.bxCaptcha.TextColor = System.Drawing.Color.Black
        '
        'frmCaptcha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(445, 280)
        Me.Controls.Add(Me.bxCaptcha)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtCaptcha)
        Me.Controls.Add(Me.btnSound)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblCaptcha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmCaptcha"
        Me.Text = "[Server] Are you a Robot?"
        CType(Me.bxCaptcha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCaptcha As Label
    Friend WithEvents btnSound As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtCaptcha As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bxCaptcha As Captcha
End Class
