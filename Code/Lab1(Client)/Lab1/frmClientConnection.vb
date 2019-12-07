Imports System.Net.Sockets
Imports System.Text
Imports System.Net
Imports System.IO

Public Class frmClientConnection
    Public TCPClient As New TcpClient
    Dim strFileBrowse As String

    Private Sub frmClientConnection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        'TabControl1.TabPages.Remove(TabPage2)
        lblStatus.Text = "choose file destination"
    End Sub


    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        TCPClient.Connect(txtIP.Text, txtPort.Text)

        If TCPClient.Connected Then
            gbConnection.Enabled = False
            Logs.Items.Add("You have connected to " & TCPClient.Client.RemoteEndPoint.ToString)
            Timer1.Enabled = True
            ' TabControl1.TabPages.Insert(1, TabPage2)

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMenu.Show()
        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim NetStream As NetworkStream = TCPClient.GetStream()

        If Not TCPClient.Connected Then
            Logs.Items.Add("Connection lost, please try to connect it again")

        End If

        If NetStream.DataAvailable Then
            Dim bytes(TCPClient.ReceiveBufferSize) As Byte
            NetStream.Read(bytes, 0, CInt(TCPClient.ReceiveBufferSize))
            Chat.Items.Add("Server: " + Encoding.ASCII.GetString(bytes))
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim NetStream As NetworkStream = TCPClient.GetStream()
        Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(txtChat.Text)
        NetStream.Write(sendBytes, 0, sendBytes.Length)
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        TabPage2.BackColor = Color.Transparent
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        TabPage1.BackColor = Color.Transparent
    End Sub



    Private Sub btnSendFile_Click(sender As Object, e As EventArgs) Handles btnSendFile.Click
        Const portNo = 500
        'Const FILE_NAME = "C:\Users\Public\1.txt"
        Dim FILE_NAME = strFileBrowse
        Dim tcpClient As New System.Net.Sockets.TcpClient
        tcpClient.Connect("127.0.0.1", portNo)

        Dim NWStream As NetworkStream = tcpClient.GetStream
        Dim bytesToSend(tcpClient.ReceiveBufferSize) As Byte

        Dim fs As FileStream
        fs = New FileStream(FILE_NAME, FileMode.Open,
                    FileAccess.Read)
        Dim numBytesRead As Integer = fs.Read(bytesToSend,
                    0, bytesToSend.Length)
        fs.Close()

        '---send the text
        lblStatus.Text = "Sending.."
        NWStream.Write(bytesToSend, 0, numBytesRead)

        Console.ReadLine()
        tcpClient.Close()
        lblStatus.Text = "Sent"
    End Sub

    Private Sub btnBrowseFileSend_Click(sender As Object, e As EventArgs) Handles btnBrowseFileSend.Click
        'Setup the open dialog.

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Title = "Choose a file to send"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "All Files (*.*) | *.*"

        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            strFileBrowse = OpenFileDialog1.FileName
            txtFileLocation.Text = strFileBrowse
            lblStatus.Text = "send the file"
        End If
    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub
End Class