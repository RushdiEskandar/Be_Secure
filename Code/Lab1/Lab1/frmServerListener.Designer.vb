<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmServerListener
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServerListener))
        Me.lblListener = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.btnListen = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbListener = New System.Windows.Forms.GroupBox()
        Me.Logs = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chat = New System.Windows.Forms.ListBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblChatBox = New System.Windows.Forms.Label()
        Me.lblChat = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.lblFileLocation = New System.Windows.Forms.Label()
        Me.txtFileLocation = New System.Windows.Forms.TextBox()
        Me.btnReceive = New System.Windows.Forms.Button()
        Me.lblFTransfer = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.gbListener.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblListener
        '
        Me.lblListener.AutoSize = True
        Me.lblListener.BackColor = System.Drawing.Color.Transparent
        Me.lblListener.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListener.ForeColor = System.Drawing.Color.IndianRed
        Me.lblListener.Location = New System.Drawing.Point(220, 18)
        Me.lblListener.Name = "lblListener"
        Me.lblListener.Size = New System.Drawing.Size(119, 20)
        Me.lblListener.TabIndex = 0
        Me.lblListener.Text = "TCP/IP Listener"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.BackColor = System.Drawing.Color.Transparent
        Me.lblIP.Location = New System.Drawing.Point(18, 38)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(68, 15)
        Me.lblIP.TabIndex = 1
        Me.lblIP.Text = "IP address:"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.BackColor = System.Drawing.Color.Transparent
        Me.lblPort.Location = New System.Drawing.Point(18, 71)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(32, 15)
        Me.lblPort.TabIndex = 2
        Me.lblPort.Text = "Port:"
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(118, 32)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(115, 21)
        Me.txtIP.TabIndex = 3
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(118, 65)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(115, 21)
        Me.txtPort.TabIndex = 4
        '
        'btnListen
        '
        Me.btnListen.BackColor = System.Drawing.Color.SpringGreen
        Me.btnListen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnListen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnListen.Location = New System.Drawing.Point(118, 112)
        Me.btnListen.Name = "btnListen"
        Me.btnListen.Size = New System.Drawing.Size(115, 23)
        Me.btnListen.TabIndex = 5
        Me.btnListen.Text = "Start Listener"
        Me.btnListen.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Coral
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Location = New System.Drawing.Point(12, 353)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(74, 23)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "<-Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'gbListener
        '
        Me.gbListener.BackColor = System.Drawing.Color.LightGray
        Me.gbListener.Controls.Add(Me.txtIP)
        Me.gbListener.Controls.Add(Me.lblIP)
        Me.gbListener.Controls.Add(Me.btnListen)
        Me.gbListener.Controls.Add(Me.lblPort)
        Me.gbListener.Controls.Add(Me.txtPort)
        Me.gbListener.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbListener.Location = New System.Drawing.Point(15, 57)
        Me.gbListener.Name = "gbListener"
        Me.gbListener.Size = New System.Drawing.Size(264, 146)
        Me.gbListener.TabIndex = 7
        Me.gbListener.TabStop = False
        Me.gbListener.Text = "Server Listener Configuration"
        '
        'Logs
        '
        Me.Logs.BackColor = System.Drawing.Color.LightGray
        Me.Logs.FormattingEnabled = True
        Me.Logs.Location = New System.Drawing.Point(298, 55)
        Me.Logs.Name = "Logs"
        Me.Logs.Size = New System.Drawing.Size(245, 147)
        Me.Logs.TabIndex = 8
        '
        'Timer1
        '
        '
        'txtChat
        '
        Me.txtChat.BackColor = System.Drawing.Color.Gainsboro
        Me.txtChat.Location = New System.Drawing.Point(166, 189)
        Me.txtChat.Multiline = True
        Me.txtChat.Name = "txtChat"
        Me.txtChat.Size = New System.Drawing.Size(260, 35)
        Me.txtChat.TabIndex = 9
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSend.Location = New System.Drawing.Point(440, 201)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(90, 23)
        Me.btnSend.TabIndex = 10
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(578, 267)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbListener)
        Me.TabPage1.Controls.Add(Me.lblListener)
        Me.TabPage1.Controls.Add(Me.Logs)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(570, 241)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Server Listener Configuration"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chat)
        Me.TabPage2.Controls.Add(Me.lblMessage)
        Me.TabPage2.Controls.Add(Me.lblChatBox)
        Me.TabPage2.Controls.Add(Me.lblChat)
        Me.TabPage2.Controls.Add(Me.txtChat)
        Me.TabPage2.Controls.Add(Me.btnSend)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(570, 241)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Chat"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Chat
        '
        Me.Chat.BackColor = System.Drawing.Color.LightGray
        Me.Chat.FormattingEnabled = True
        Me.Chat.Location = New System.Drawing.Point(166, 55)
        Me.Chat.Name = "Chat"
        Me.Chat.Size = New System.Drawing.Size(260, 121)
        Me.Chat.TabIndex = 14
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(107, 189)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(53, 13)
        Me.lblMessage.TabIndex = 13
        Me.lblMessage.Text = "Message:"
        '
        'lblChatBox
        '
        Me.lblChatBox.AutoSize = True
        Me.lblChatBox.Location = New System.Drawing.Point(107, 55)
        Me.lblChatBox.Name = "lblChatBox"
        Me.lblChatBox.Size = New System.Drawing.Size(53, 13)
        Me.lblChatBox.TabIndex = 12
        Me.lblChatBox.Text = "Chat Box:"
        '
        'lblChat
        '
        Me.lblChat.AutoSize = True
        Me.lblChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChat.ForeColor = System.Drawing.Color.Coral
        Me.lblChat.Location = New System.Drawing.Point(270, 21)
        Me.lblChat.Name = "lblChat"
        Me.lblChat.Size = New System.Drawing.Size(43, 20)
        Me.lblChat.TabIndex = 11
        Me.lblChat.Text = "Chat"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblStatus)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.btnBrowse)
        Me.TabPage3.Controls.Add(Me.lblFileLocation)
        Me.TabPage3.Controls.Add(Me.txtFileLocation)
        Me.TabPage3.Controls.Add(Me.btnReceive)
        Me.TabPage3.Controls.Add(Me.lblFTransfer)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(570, 241)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Files Transfer"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(202, 101)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(113, 13)
        Me.lblStatus.TabIndex = 12
        Me.lblStatus.Text = "Choose file destination"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Chocolate
        Me.Label1.Location = New System.Drawing.Point(164, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Note! Encrypted File has file extension "".encrypt"""
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Lime
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBrowse.Location = New System.Drawing.Point(420, 63)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 9
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'lblFileLocation
        '
        Me.lblFileLocation.AutoSize = True
        Me.lblFileLocation.Location = New System.Drawing.Point(99, 71)
        Me.lblFileLocation.Name = "lblFileLocation"
        Me.lblFileLocation.Size = New System.Drawing.Size(62, 13)
        Me.lblFileLocation.TabIndex = 8
        Me.lblFileLocation.Text = "Save file in:"
        '
        'txtFileLocation
        '
        Me.txtFileLocation.Location = New System.Drawing.Point(167, 65)
        Me.txtFileLocation.Name = "txtFileLocation"
        Me.txtFileLocation.Size = New System.Drawing.Size(235, 20)
        Me.txtFileLocation.TabIndex = 7
        '
        'btnReceive
        '
        Me.btnReceive.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReceive.Location = New System.Drawing.Point(420, 110)
        Me.btnReceive.Name = "btnReceive"
        Me.btnReceive.Size = New System.Drawing.Size(75, 23)
        Me.btnReceive.TabIndex = 6
        Me.btnReceive.Text = "Receive"
        Me.btnReceive.UseVisualStyleBackColor = False
        '
        'lblFTransfer
        '
        Me.lblFTransfer.AutoSize = True
        Me.lblFTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFTransfer.ForeColor = System.Drawing.Color.Purple
        Me.lblFTransfer.Location = New System.Drawing.Point(240, 14)
        Me.lblFTransfer.Name = "lblFTransfer"
        Me.lblFTransfer.Size = New System.Drawing.Size(105, 20)
        Me.lblFTransfer.TabIndex = 0
        Me.lblFTransfer.Text = "Files Transfer"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmServerListener
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(607, 409)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmServerListener"
        Me.Text = "[Server] Server Listener"
        Me.gbListener.ResumeLayout(False)
        Me.gbListener.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblListener As Label
    Friend WithEvents lblIP As Label
    Friend WithEvents lblPort As Label
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btnListen As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents gbListener As GroupBox
    Friend WithEvents Logs As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtChat As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Chat As ListBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblChatBox As Label
    Friend WithEvents lblChat As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblFTransfer As Label
    Friend WithEvents btnReceive As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblFileLocation As Label
    Friend WithEvents txtFileLocation As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents lblStatus As Label
    Friend WithEvents Label2 As Label
End Class
