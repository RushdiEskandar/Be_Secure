Public Class frmCaptcha
    Private Sub frmCaptcha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub



    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub Captcha1_Click(sender As Object, e As EventArgs) Handles bxCaptcha.Click
        bxCaptcha.RandomCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmopqrstuvwxyz1234567890"
        bxCaptcha.CaptchaTextLength = 5
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        bxCaptcha.Refresh()
    End Sub

    Private Sub btnSound_Click(sender As Object, e As EventArgs) Handles btnSound.Click
        Dim SAPI
        Dim captchaChar(bxCaptcha.CaptchaTextLength - 1) As Char
        Dim captchaText As String = bxCaptcha.CaptchaText
        Dim count As Integer
        For count = 0 To captchaText.Length - 1
            captchaChar(count) = Convert.ToChar(captchaText(count))
        Next
        Try
            SAPI = CreateObject("SAPI.spvoice")
            For count = 0 To captchaText.Length - 1
                SAPI.speak(captchaChar(count).ToString)
            Next
        Catch exc As Exception
            MessageBox.Show("An error has occurred: " & exc.Message)
        Finally
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtCaptcha.Text.ToUpper.Equals(bxCaptcha.CaptchaText.ToUpper) Then
            frmLogin.Show()
            Me.Close()
        Else

            MessageBox.Show("Incorrect!", "be secure: Captcha", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtCaptcha_TextChanged(sender As Object, e As EventArgs) Handles txtCaptcha.TextChanged

    End Sub

    Private Sub Captcha1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class