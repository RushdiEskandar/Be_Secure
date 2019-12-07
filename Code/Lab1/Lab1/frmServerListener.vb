Imports System.Net.Sockets
Imports System.Text
Imports System.Net
Imports System.IO
Public Class frmServerListener
    Public TCPClient As New TcpClient ' public variable as tcpclient

    Dim strFileBrowse As String

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbListener.Enter

    End Sub

    Private Sub txtIP_TextChanged(sender As Object, e As EventArgs) Handles txtIP.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Logs.SelectedIndexChanged

    End Sub

    Private Sub btnListen_Click(sender As Object, e As EventArgs) Handles btnListen.Click
        Dim TCPListener As New TcpListener(System.Net.IPAddress.Parse(txtIP.Text), txtPort.Text) 'parse IP address and Port number
        TCPListener.Start()                                                                      'start listening 
        Logs.Items.Add("Server is awaiting for remote host...")                                  'Once click on button listen add message to LB
        TCPClient = TCPListener.AcceptTcpClient()                                                ' wait to accept client and assign it to variable T                                           '

        If TCPClient.Connected Then                                                              'if tcpclient is connected Then
            Logs.Items.Add(TCPClient.Client.RemoteEndPoint.ToString & " Connected ")             'Add TCPClient information to the Logs

            gbListener.Enabled = False                                                           'Server configuration to False
            Timer1.Enabled = True                                                                'Start timer

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmServerListener_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim NetStream As NetworkStream = TCPClient.GetStream()                                      'Netstream standf for receiving and sending data

        If Not TCPClient.Connected Then
            Logs.Items.Add("Connection lost, please try to connect it again")
        End If

        If NetStream.DataAvailable Then
            Dim bytes(TCPClient.ReceiveBufferSize) As Byte
            NetStream.Read(bytes, 0, CInt(TCPClient.ReceiveBufferSize))
            Chat.Items.Add("Client: " + Encoding.ASCII.GetString(bytes))
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim NetStream As NetworkStream = TCPClient.GetStream()
        Dim sendBytes As [Byte]() = Encoding.ASCII.GetBytes(txtChat.Text)
        NetStream.Write(sendBytes, 0, sendBytes.Length)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnReceive.Click
        Const portNo As Integer = 500
        Dim localAdd As System.Net.IPAddress = IPAddress.Parse("127.0.0.1")
        Dim listener As New TcpListener(localAdd, portNo)
        listener.Start()
        Console.WriteLine("Listening...")
        Dim tcpClient As TcpClient = listener.AcceptTcpClient()
        Dim NWStream As NetworkStream = tcpClient.GetStream


        Const BUFFER_SIZE As Integer = 10
        Dim bytesToRead(BUFFER_SIZE) As Byte
        '---read incoming stream
        Dim textReceived As String

        Do
            Dim numBytesRead As Integer =
        NWStream.Read(bytesToRead, 0, BUFFER_SIZE)
            textReceived += Encoding.ASCII.GetString(bytesToRead,
                   0, numBytesRead)

        Loop Until Not NWStream.DataAvailable



        'Dim bytesToRead(tcpClient.ReceiveBufferSize) As Byte

        '---read incoming stream
        '  Dim numBytesRead As Integer = NWStream.Read(bytesToRead,
        '0, CInt(tcpClient.ReceiveBufferSize))

        '---write the bytes to file
        ' Const FILE_NAME = "C:\Users\Public\2.txt"
        Dim FILE_NAME = strFileBrowse
        Dim fs As System.IO.FileStream
        fs = New FileStream(FILE_NAME, FileMode.CreateNew,
                    FileAccess.Write)
        fs.Write(Encoding.ASCII.GetBytes(textReceived), 0,
                textReceived.Length)
        fs.Close()

        tcpClient.Close()
        listener.Stop()
        Console.ReadLine()
        lblStatus.Text = "file is received"

    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click

    End Sub

    Private Sub btnBrowse_Click_1(sender As Object, e As EventArgs) Handles btnBrowse.Click
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.Title = "Choose location"
        SaveFileDialog1.InitialDirectory = "C:\"
        SaveFileDialog1.Filter = "All Files (*.*) | *.*"

        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            strFileBrowse = SaveFileDialog1.FileName
            txtFileLocation.Text = strFileBrowse
            lblStatus.Text = "you can start receiving file"
        End If
    End Sub
End Class