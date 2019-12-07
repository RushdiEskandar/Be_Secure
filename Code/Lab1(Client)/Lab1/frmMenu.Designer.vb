<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.btnEncDec = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnFolderLocker = New System.Windows.Forms.Button()
        Me.btnHash = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAVscanner = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.BackColor = System.Drawing.Color.Transparent
        Me.lblMenu.ForeColor = System.Drawing.Color.Purple
        Me.lblMenu.Location = New System.Drawing.Point(129, 9)
        Me.lblMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(49, 20)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Menu"
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.PaleGreen
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.ForeColor = System.Drawing.Color.Black
        Me.btnConnect.Location = New System.Drawing.Point(85, 226)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(153, 50)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Establish connection"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'btnEncDec
        '
        Me.btnEncDec.BackColor = System.Drawing.Color.PaleGreen
        Me.btnEncDec.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnEncDec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEncDec.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncDec.ForeColor = System.Drawing.Color.Black
        Me.btnEncDec.Location = New System.Drawing.Point(84, 52)
        Me.btnEncDec.Name = "btnEncDec"
        Me.btnEncDec.Size = New System.Drawing.Size(154, 33)
        Me.btnEncDec.TabIndex = 2
        Me.btnEncDec.Text = "Encrypt/Decrypt Files"
        Me.btnEncDec.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Gold
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Black
        Me.btnLogout.Location = New System.Drawing.Point(128, 377)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(64, 30)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnFolderLocker
        '
        Me.btnFolderLocker.BackColor = System.Drawing.Color.PaleGreen
        Me.btnFolderLocker.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFolderLocker.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFolderLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFolderLocker.ForeColor = System.Drawing.Color.Black
        Me.btnFolderLocker.Location = New System.Drawing.Point(84, 153)
        Me.btnFolderLocker.Name = "btnFolderLocker"
        Me.btnFolderLocker.Size = New System.Drawing.Size(154, 34)
        Me.btnFolderLocker.TabIndex = 4
        Me.btnFolderLocker.Text = "Folder Locker"
        Me.btnFolderLocker.UseVisualStyleBackColor = False
        '
        'btnHash
        '
        Me.btnHash.BackColor = System.Drawing.Color.PaleGreen
        Me.btnHash.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnHash.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHash.ForeColor = System.Drawing.Color.Black
        Me.btnHash.Location = New System.Drawing.Point(84, 102)
        Me.btnHash.Name = "btnHash"
        Me.btnHash.Size = New System.Drawing.Size(154, 42)
        Me.btnHash.TabIndex = 5
        Me.btnHash.Text = "Hash Generator"
        Me.btnHash.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(129, 203)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "TCP/IP"
        '
        'btnAVscanner
        '
        Me.btnAVscanner.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAVscanner.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAVscanner.ForeColor = System.Drawing.Color.Black
        Me.btnAVscanner.Location = New System.Drawing.Point(85, 318)
        Me.btnAVscanner.Name = "btnAVscanner"
        Me.btnAVscanner.Size = New System.Drawing.Size(153, 10)
        Me.btnAVscanner.TabIndex = 7
        Me.btnAVscanner.Text = "AV Scanner"
        Me.btnAVscanner.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(342, 419)
        Me.Controls.Add(Me.btnAVscanner)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHash)
        Me.Controls.Add(Me.btnFolderLocker)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnEncDec)
        Me.Controls.Add(Me.btnConnect)
        Me.Controls.Add(Me.lblMenu)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Purple
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMenu"
        Me.Text = "[Client] Personal Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMenu As Label
    Friend WithEvents btnConnect As Button
    Friend WithEvents btnEncDec As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnFolderLocker As Button
    Friend WithEvents btnHash As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAVscanner As Button
End Class
