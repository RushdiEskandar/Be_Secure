<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientConnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientConnection))
        Me.lblClient = New System.Windows.Forms.Label()
        Me.gbConnection = New System.Windows.Forms.GroupBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.Logs = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chat = New System.Windows.Forms.ListBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblChatbox = New System.Windows.Forms.Label()
        Me.lblChat = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnBrowseFileSend = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFileLocation = New System.Windows.Forms.TextBox()
        Me.btnSendFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.gbConnection.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClient
        '
        Me.lblClient.AutoSize = True
        Me.lblClient.BackColor = System.Drawing.Color.Transparent
        Me.lblClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClient.ForeColor = System.Drawing.Color.Coral
        Me.lblClient.Location = New System.Drawing.Point(241, 15)
        Me.lblClient.Name = "lblClient"
        Me.lblClient.Size = New System.Drawing.Size(143, 20)
        Me.lblClient.TabIndex = 1
        Me.lblClient.Text = "TCP/IP Connection"
        '
        'gbConnection
        '
        Me.gbConnection.BackColor = System.Drawing.Color.LightGray
        Me.gbConnection.Controls.Add(Me.btnConnect)
        Me.gbConnection.Controls.Add(Me.txtPort)
        Me.gbConnection.Controls.Add(Me.txtIP)
        Me.gbConnection.Controls.Add(Me.lblPort)
        Me.gbConnection.Controls.Add(Me.lblIP)
        Me.gbConnection.Location = New System.Drawing.Point(25, 52)
        Me.gbConnection.Name = "gbConnection"
        Me.gbConnection.Size = New System.Drawing.Size(280, 151)
        Me.gbConnection.TabIndex = 2
        Me.gbConnection.TabStop = False
        Me.gbConnection.Text = "Client Connection Configuration"
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConnect.ForeColor = System.Drawing.Color.Black
        Me.btnConnect.Location = New System.Drawing.Point(169, 111)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 23)
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(74, 75)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(140, 20)
        Me.txtPort.TabIndex = 3
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(74, 36)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(140, 20)
        Me.txtIP.TabIndex = 2
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(10, 75)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(29, 13)
        Me.lblPort.TabIndex = 1
        Me.lblPort.Text = "Port:"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(7, 36)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(60, 13)
        Me.lblIP.TabIndex = 0
        Me.lblIP.Text = "IP address:"
        '
        'Logs
        '
        Me.Logs.BackColor = System.Drawing.Color.LightGray
        Me.Logs.FormattingEnabled = True
        Me.Logs.Location = New System.Drawing.Point(330, 52)
        Me.Logs.Name = "Logs"
        Me.Logs.Size = New System.Drawing.Size(232, 147)
        Me.Logs.TabIndex = 3
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Coral
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(3, 308)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "<--Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSend.ForeColor = System.Drawing.Color.Black
        Me.btnSend.Location = New System.Drawing.Point(451, 188)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(102, 23)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'txtChat
        '
        Me.txtChat.BackColor = System.Drawing.Color.Gainsboro
        Me.txtChat.Location = New System.Drawing.Point(187, 174)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.Size = New System.Drawing.Size(258, 37)
        Me.txtChat.TabIndex = 6
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(13, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(597, 269)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.lblClient)
        Me.TabPage1.Controls.Add(Me.gbConnection)
        Me.TabPage1.Controls.Add(Me.Logs)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(589, 243)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Client Connection Configuration"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.Chat)
        Me.TabPage2.Controls.Add(Me.lblMessage)
        Me.TabPage2.Controls.Add(Me.lblChatbox)
        Me.TabPage2.Controls.Add(Me.lblChat)
        Me.TabPage2.Controls.Add(Me.txtChat)
        Me.TabPage2.Controls.Add(Me.btnSend)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(589, 243)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Chat"
        '
        'Chat
        '
        Me.Chat.BackColor = System.Drawing.Color.LightGray
        Me.Chat.FormattingEnabled = True
        Me.Chat.Location = New System.Drawing.Point(187, 63)
        Me.Chat.Name = "Chat"
        Me.Chat.Size = New System.Drawing.Size(258, 95)
        Me.Chat.TabIndex = 11
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(128, 174)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(53, 13)
        Me.lblMessage.TabIndex = 10
        Me.lblMessage.Text = "Message:"
        '
        'lblChatbox
        '
        Me.lblChatbox.AutoSize = True
        Me.lblChatbox.Location = New System.Drawing.Point(128, 63)
        Me.lblChatbox.Name = "lblChatbox"
        Me.lblChatbox.Size = New System.Drawing.Size(53, 13)
        Me.lblChatbox.TabIndex = 8
        Me.lblChatbox.Text = "Chat Box:"
        '
        'lblChat
        '
        Me.lblChat.AutoSize = True
        Me.lblChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChat.ForeColor = System.Drawing.Color.Coral
        Me.lblChat.Location = New System.Drawing.Point(269, 14)
        Me.lblChat.Name = "lblChat"
        Me.lblChat.Size = New System.Drawing.Size(87, 20)
        Me.lblChat.TabIndex = 7
        Me.lblChat.Text = "Chat Client"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Transparent
        Me.TabPage3.Controls.Add(Me.btnBrowseFileSend)
        Me.TabPage3.Controls.Add(Me.lblStatus)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.lblSt)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.txtFileLocation)
        Me.TabPage3.Controls.Add(Me.btnSendFile)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(589, 243)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "File Transfer"
        '
        'btnBrowseFileSend
        '
        Me.btnBrowseFileSend.BackColor = System.Drawing.Color.Coral
        Me.btnBrowseFileSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowseFileSend.Location = New System.Drawing.Point(343, 70)
        Me.btnBrowseFileSend.Name = "btnBrowseFileSend"
        Me.btnBrowseFileSend.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowseFileSend.TabIndex = 10
        Me.btnBrowseFileSend.Text = "Browse"
        Me.btnBrowseFileSend.UseVisualStyleBackColor = False
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(157, 104)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 13)
        Me.lblStatus.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Coral
        Me.Label3.Location = New System.Drawing.Point(239, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "File Transfer"
        '
        'lblSt
        '
        Me.lblSt.AutoSize = True
        Me.lblSt.Location = New System.Drawing.Point(111, 104)
        Me.lblSt.Name = "lblSt"
        Me.lblSt.Size = New System.Drawing.Size(40, 13)
        Me.lblSt.TabIndex = 3
        Me.lblSt.Text = "Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "File Location:"
        '
        'txtFileLocation
        '
        Me.txtFileLocation.BackColor = System.Drawing.Color.LightGray
        Me.txtFileLocation.Location = New System.Drawing.Point(114, 71)
        Me.txtFileLocation.Name = "txtFileLocation"
        Me.txtFileLocation.Size = New System.Drawing.Size(215, 20)
        Me.txtFileLocation.TabIndex = 1
        '
        'btnSendFile
        '
        Me.btnSendFile.BackColor = System.Drawing.Color.SpringGreen
        Me.btnSendFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSendFile.Location = New System.Drawing.Point(343, 116)
        Me.btnSendFile.Name = "btnSendFile"
        Me.btnSendFile.Size = New System.Drawing.Size(75, 20)
        Me.btnSendFile.TabIndex = 0
        Me.btnSendFile.Text = "Send File"
        Me.btnSendFile.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmClientConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(625, 358)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClientConnection"
        Me.Text = "[Client] Socket Connection"
        Me.gbConnection.ResumeLayout(False)
        Me.gbConnection.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblClient As Label
    Friend WithEvents gbConnection As GroupBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtIP As TextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents lblIP As Label
    Friend WithEvents Logs As ListBox
    Friend WithEvents btnBack As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnSend As Button
    Friend WithEvents txtChat As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblChat As Label
    Friend WithEvents lblChatbox As Label
    Friend WithEvents Chat As ListBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnSendFile As Button
    Friend WithEvents btnBrowseFileSend As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFileLocation As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
