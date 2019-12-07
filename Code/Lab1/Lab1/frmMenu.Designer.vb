<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnEncrDecr = New System.Windows.Forms.Button()
        Me.btnFolderLocker = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSocket = New System.Windows.Forms.Label()
        Me.btnHashVer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMenu.ForeColor = System.Drawing.Color.Olive
        Me.lblMenu.Location = New System.Drawing.Point(134, 9)
        Me.lblMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(49, 20)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Menu"
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.SpringGreen
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.ForeColor = System.Drawing.Color.Black
        Me.btnConnect.Location = New System.Drawing.Point(82, 228)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(148, 27)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Socket Listener"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'btnEncrDecr
        '
        Me.btnEncrDecr.BackColor = System.Drawing.Color.SpringGreen
        Me.btnEncrDecr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEncrDecr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncrDecr.ForeColor = System.Drawing.Color.Black
        Me.btnEncrDecr.Location = New System.Drawing.Point(82, 92)
        Me.btnEncrDecr.Name = "btnEncrDecr"
        Me.btnEncrDecr.Size = New System.Drawing.Size(148, 28)
        Me.btnEncrDecr.TabIndex = 3
        Me.btnEncrDecr.Text = "File Encryption/Decryption"
        Me.btnEncrDecr.UseVisualStyleBackColor = False
        '
        'btnFolderLocker
        '
        Me.btnFolderLocker.BackColor = System.Drawing.Color.SpringGreen
        Me.btnFolderLocker.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFolderLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFolderLocker.ForeColor = System.Drawing.Color.Black
        Me.btnFolderLocker.Location = New System.Drawing.Point(82, 52)
        Me.btnFolderLocker.Name = "btnFolderLocker"
        Me.btnFolderLocker.Size = New System.Drawing.Size(148, 28)
        Me.btnFolderLocker.TabIndex = 4
        Me.btnFolderLocker.Text = "Folder Locker"
        Me.btnFolderLocker.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Gold
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(113, 284)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Log out"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblSocket
        '
        Me.lblSocket.AutoSize = True
        Me.lblSocket.BackColor = System.Drawing.Color.Transparent
        Me.lblSocket.Location = New System.Drawing.Point(126, 194)
        Me.lblSocket.Name = "lblSocket"
        Me.lblSocket.Size = New System.Drawing.Size(62, 20)
        Me.lblSocket.TabIndex = 6
        Me.lblSocket.Text = "TCP/IP "
        '
        'btnHashVer
        '
        Me.btnHashVer.BackColor = System.Drawing.Color.SpringGreen
        Me.btnHashVer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHashVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHashVer.ForeColor = System.Drawing.Color.Black
        Me.btnHashVer.Location = New System.Drawing.Point(79, 140)
        Me.btnHashVer.Name = "btnHashVer"
        Me.btnHashVer.Size = New System.Drawing.Size(148, 28)
        Me.btnHashVer.TabIndex = 7
        Me.btnHashVer.Text = "Hash Generator"
        Me.btnHashVer.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(307, 319)
        Me.Controls.Add(Me.btnHashVer)
        Me.Controls.Add(Me.lblSocket)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFolderLocker)
        Me.Controls.Add(Me.btnEncrDecr)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lblMenu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Olive
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMenu"
        Me.Text = "[Server] Personal Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMenu As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnEncrDecr As Button
    Friend WithEvents btnFolderLocker As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSocket As Label
    Friend WithEvents btnHashVer As Button
End Class
