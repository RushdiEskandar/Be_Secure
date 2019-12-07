<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFLocker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFLocker))
        Me.lblFLocker = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtFLocation = New System.Windows.Forms.TextBox()
        Me.btnLock = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFLocker
        '
        Me.lblFLocker.AutoSize = True
        Me.lblFLocker.BackColor = System.Drawing.Color.Transparent
        Me.lblFLocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFLocker.ForeColor = System.Drawing.Color.Coral
        Me.lblFLocker.Location = New System.Drawing.Point(58, 20)
        Me.lblFLocker.Name = "lblFLocker"
        Me.lblFLocker.Size = New System.Drawing.Size(247, 20)
        Me.lblFLocker.TabIndex = 0
        Me.lblFLocker.Text = "Lock Your Folder with 'Be Secure'"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.BackColor = System.Drawing.Color.Transparent
        Me.lblLocation.Location = New System.Drawing.Point(12, 67)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(79, 13)
        Me.lblLocation.TabIndex = 1
        Me.lblLocation.Text = "Folder location:"
        '
        'txtFLocation
        '
        Me.txtFLocation.Location = New System.Drawing.Point(97, 60)
        Me.txtFLocation.Name = "txtFLocation"
        Me.txtFLocation.Size = New System.Drawing.Size(177, 20)
        Me.txtFLocation.TabIndex = 2
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.SpringGreen
        Me.btnLock.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLock.Location = New System.Drawing.Point(136, 96)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(97, 36)
        Me.btnLock.TabIndex = 3
        Me.btnLock.Text = "Lock/Unlock Folder"
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'FolderBrowserDialog1
        '
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Coral
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(4, 177)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "<-Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmFLocker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(346, 225)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnLock)
        Me.Controls.Add(Me.txtFLocation)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblFLocker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmFLocker"
        Me.Text = "[Server] Folder Locker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFLocker As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtFLocation As TextBox
    Friend WithEvents btnLock As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnBack As Button
End Class
