<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRijndael
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRijndael))
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.txtFileToEncrypt = New System.Windows.Forms.TextBox()
        Me.txtDestinationEncrypt = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.txtPassEncrypt = New System.Windows.Forms.TextBox()
        Me.lblFileLocation = New System.Windows.Forms.Label()
        Me.lblFileLocationDestination = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblAlgorithm = New System.Windows.Forms.Label()
        Me.lblEncryption = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPassDecrypt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDestinationDecrypt = New System.Windows.Forms.TextBox()
        Me.txtDecryptFile = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowse.Location = New System.Drawing.Point(253, 128)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'txtFileToEncrypt
        '
        Me.txtFileToEncrypt.Location = New System.Drawing.Point(110, 128)
        Me.txtFileToEncrypt.Name = "txtFileToEncrypt"
        Me.txtFileToEncrypt.Size = New System.Drawing.Size(128, 20)
        Me.txtFileToEncrypt.TabIndex = 2
        '
        'txtDestinationEncrypt
        '
        Me.txtDestinationEncrypt.Location = New System.Drawing.Point(110, 162)
        Me.txtDestinationEncrypt.Name = "txtDestinationEncrypt"
        Me.txtDestinationEncrypt.Size = New System.Drawing.Size(128, 20)
        Me.txtDestinationEncrypt.TabIndex = 3
        '
        'btnEncrypt
        '
        Me.btnEncrypt.BackColor = System.Drawing.Color.RosyBrown
        Me.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEncrypt.Location = New System.Drawing.Point(253, 196)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnEncrypt.TabIndex = 4
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = False
        '
        'txtPassEncrypt
        '
        Me.txtPassEncrypt.Location = New System.Drawing.Point(110, 196)
        Me.txtPassEncrypt.Name = "txtPassEncrypt"
        Me.txtPassEncrypt.Size = New System.Drawing.Size(128, 20)
        Me.txtPassEncrypt.TabIndex = 5
        '
        'lblFileLocation
        '
        Me.lblFileLocation.AutoSize = True
        Me.lblFileLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblFileLocation.Location = New System.Drawing.Point(39, 128)
        Me.lblFileLocation.Name = "lblFileLocation"
        Me.lblFileLocation.Size = New System.Drawing.Size(70, 13)
        Me.lblFileLocation.TabIndex = 6
        Me.lblFileLocation.Text = "File Location:"
        '
        'lblFileLocationDestination
        '
        Me.lblFileLocationDestination.AutoSize = True
        Me.lblFileLocationDestination.BackColor = System.Drawing.Color.Transparent
        Me.lblFileLocationDestination.Location = New System.Drawing.Point(27, 162)
        Me.lblFileLocationDestination.Name = "lblFileLocationDestination"
        Me.lblFileLocationDestination.Size = New System.Drawing.Size(82, 13)
        Me.lblFileLocationDestination.TabIndex = 7
        Me.lblFileLocationDestination.Text = "File Destination:"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.BackColor = System.Drawing.Color.Transparent
        Me.lblKey.Location = New System.Drawing.Point(82, 196)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(28, 13)
        Me.lblKey.TabIndex = 8
        Me.lblKey.Text = "Key:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Purple
        Me.lblTitle.Location = New System.Drawing.Point(313, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(193, 20)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "File Encryption/Decryption"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Coral
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(5, 271)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(55, 23)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "<--Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblAlgorithm
        '
        Me.lblAlgorithm.AutoSize = True
        Me.lblAlgorithm.BackColor = System.Drawing.Color.Transparent
        Me.lblAlgorithm.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblAlgorithm.Location = New System.Drawing.Point(355, 52)
        Me.lblAlgorithm.Name = "lblAlgorithm"
        Me.lblAlgorithm.Size = New System.Drawing.Size(118, 13)
        Me.lblAlgorithm.TabIndex = 11
        Me.lblAlgorithm.Text = "using Rijndael algorithm"
        '
        'lblEncryption
        '
        Me.lblEncryption.AutoSize = True
        Me.lblEncryption.BackColor = System.Drawing.Color.MistyRose
        Me.lblEncryption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncryption.Location = New System.Drawing.Point(138, 98)
        Me.lblEncryption.Name = "lblEncryption"
        Me.lblEncryption.Size = New System.Drawing.Size(71, 16)
        Me.lblEncryption.TabIndex = 12
        Me.lblEncryption.Text = "Encryption"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MistyRose
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(539, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Decryption"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(482, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Key:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(427, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "File Destination:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(440, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "File Location:"
        '
        'txtPassDecrypt
        '
        Me.txtPassDecrypt.Location = New System.Drawing.Point(511, 196)
        Me.txtPassDecrypt.Name = "txtPassDecrypt"
        Me.txtPassDecrypt.Size = New System.Drawing.Size(128, 20)
        Me.txtPassDecrypt.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(654, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Decrypt"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtDestinationDecrypt
        '
        Me.txtDestinationDecrypt.Location = New System.Drawing.Point(511, 162)
        Me.txtDestinationDecrypt.Name = "txtDestinationDecrypt"
        Me.txtDestinationDecrypt.Size = New System.Drawing.Size(128, 20)
        Me.txtDestinationDecrypt.TabIndex = 15
        '
        'txtDecryptFile
        '
        Me.txtDecryptFile.Location = New System.Drawing.Point(511, 128)
        Me.txtDecryptFile.Name = "txtDecryptFile"
        Me.txtDecryptFile.Size = New System.Drawing.Size(128, 20)
        Me.txtDecryptFile.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(654, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmRijndael
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(767, 313)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPassDecrypt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDestinationDecrypt)
        Me.Controls.Add(Me.txtDecryptFile)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblEncryption)
        Me.Controls.Add(Me.lblAlgorithm)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblFileLocationDestination)
        Me.Controls.Add(Me.lblFileLocation)
        Me.Controls.Add(Me.txtPassEncrypt)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.txtDestinationEncrypt)
        Me.Controls.Add(Me.txtFileToEncrypt)
        Me.Controls.Add(Me.btnBrowse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRijndael"
        Me.Text = "[Client] File Encryption/Decryption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents txtFileToEncrypt As TextBox
    Friend WithEvents txtDestinationEncrypt As TextBox
    Friend WithEvents btnEncrypt As Button
    Friend WithEvents txtPassEncrypt As TextBox
    Friend WithEvents lblFileLocation As Label
    Friend WithEvents lblFileLocationDestination As Label
    Friend WithEvents lblKey As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lblAlgorithm As Label
    Friend WithEvents lblEncryption As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassDecrypt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtDestinationDecrypt As TextBox
    Friend WithEvents txtDecryptFile As TextBox
    Friend WithEvents Button2 As Button
End Class
