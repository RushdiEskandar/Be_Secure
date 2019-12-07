Option Strict On
Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmLogin

    Dim LoginAttempts As Integer

    Private Function stringToMd5(ByRef Content As String) As String
        Dim M5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim byteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        byteString = M5.ComputeHash(byteString)
        Dim finalString As String = Nothing
        For Each byt As Byte In byteString
            finalString &= byt.ToString("x2")
        Next
        Return finalString.ToUpper()
    End Function


    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnRegistration_Click(sender As Object, e As EventArgs) Handles btnRegistration.Click
        frmRegistration.Show()
        Me.Close()
    End Sub



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If stringToMd5(txtUsername.Text) & Chr(32) & stringToMd5(txtPassword.Text) =
                IO.File.ReadAllText(stringToMd5(txtUsername.Text) & ".txt") Then
                MsgBox("welcome. you have logged on the the server.", MsgBoxStyle.Information)
                frmMenu.Show()
                Me.Close()
            Else
                LoginAttempts = LoginAttempts + 1
                If LoginAttempts = 1 Then
                    lblLoginAttempts.Text = "First attempt out of 3"
                    MessageBox.Show("username or password is wrong", "be secure: First Login Attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf LoginAttempts = 2 Then
                    lblLoginAttempts.Text = "Second attempt out of 3"
                    MessageBox.Show("username or password is wrong", "be secure: Second Login Attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    lblLoginAttempts.Text = "Third attempt out of 3"
                    MessageBox.Show("username or password is wrong", "be secure: Third Login Attempt", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    frmCaptcha.Show()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("invalid credentials", "be secure: support", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmCaptcha.Show()
            Me.Close()
            ' MsgBox(ex.Message, MsgBoxStyle.Information, "error")
        End Try

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class