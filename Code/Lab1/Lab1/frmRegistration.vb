Option Strict On
Imports System.IO
'Imports System.Text.RegularExpressions
Imports System.Net.Mail


Public Class frmRegistration

    Public Vericode As String = "Nothing"
    Private StrengthWords() As String = {"Invalid", "Very Weak", "Weak", "Better", "Medium", "Strong", "Perfect"}

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


    Private Function createuser(ByVal vercode As String, ByVal user As String, ByVal password As String) As String
        If vercode = Vericode Then
            If File.Exists(stringToMd5(user) & ".txt") = False Then
                Try
                    My.Computer.FileSystem.WriteAllText(stringToMd5(user) & ".txt", stringToMd5(user) &
                                                        Chr(32) & stringToMd5(password), False)
                    File.SetAttributes(stringToMd5(user) & ".txt", FileAttributes.Hidden)
                    MessageBox.Show("Account has been created successfully", "Be secure: Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Catch ex As Exception
                    'MsgBox("problems occured!" & ex.Message, MsgBoxStyle.Information, "error")
                    MessageBox.Show("problems occured!" & ex.Message, "Be secure: Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Else
                MessageBox.Show("Chosen username has been taken before", "Be secure: Registration Support", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Check verification Code", "Be secure: Support", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        Return vercode
        Return user
        Return password


    End Function



    Private Sub txtPwd_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPwd.KeyUp
        CalculateMeter()

    End Sub

    Sub CalculateMeter()
        Dim score As Integer
        Dim password As String = txtPwd.Text

        If (password.Length > 0) Then score += 1 'Length more than 6 
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") And
           System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") Then
            score += 1 'upper and lower case 
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(password, "\d+") Then
            score += 1 'number 
        End If
        If System.Text.RegularExpressions.Regex.IsMatch(password, "[,!,@,#,$,%,^,&,*,?,_,~,-,/,"",]") Then
            score += 1 'special character 
        End If
        If (password.Length >= 10) Then score += 1 'length more than 9 
        If (password.Length > 15) Then score += 1 'length more than 15

        pbStrength.Value = CInt(score / 6 * 100) 'finding percentage to increase 
        lblProgressbar.Width = 50 * score 'label width is not auto so seeting it to show color amount 
        lblProgressbar.Text = StrengthWords(score) 'Getting strength word from string array declarred above

        lblProgressbar.TextAlign = ContentAlignment.MiddleCenter 'alignning to center can be done one time in design 
        lblProgressbar.BackColor = GetColor(score) 'Getting color and setting pbStrength.ForeColor = GetColor(score) 'does not work unless you disable Visual Styles from application properties

    End Sub

    Private Function GetColor(ByVal score As Integer) As Color
        Select Case score
            Case 0
                Return Color.Red
            Case 1
                Return Color.Red
            Case 2
                Return Color.Purple
            Case 3
                Return Color.LightGreen
            Case 4
                Return Color.MediumSeaGreen
            Case 5
                Return Color.Green
            Case 6
                Return Color.DarkGreen
        End Select
    End Function





    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If (txtUsername.Text.Length = 0) Then
            MessageBox.Show("Username field can not be empty", "Be secure: Support", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (txtPwd.Text.Length = 0) Then
            MessageBox.Show("Password field can not be empty", "Be secure: Support", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (txtEmail.Text.Length = 0) Then
            MessageBox.Show("Email field can not be empty", "Be secure: Support", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (txtVrfCode.Text.Length = 0) Then
            MessageBox.Show("Verification code field can not be empty", "Be secure: Support", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            createuser(txtVrfCode.Text, txtUsername.Text, txtPwd.Text)
            frmLogin.Show()
            Me.Close()
        End If



    End Sub

    ' Private Sub txtPwd_TextChanged(sender As Object, e As EventArgs) Handles txtPwd.TextChanged

    ' End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub



    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles pbStrength.Click

    End Sub

    Private Sub lblProgressbar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblRegistration_Click(sender As Object, e As EventArgs) Handles lblRegistration.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles lvlVrfCode.Click

    End Sub


    Function EmailCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"

        '  Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        Dim emailAddressMatch As System.Text.RegularExpressions.Match = System.Text.RegularExpressions.Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If EmailCheck(txtEmail.Text) = True Then
            lblVerified.Text = "Valid Email!"
            btnSendAC.Enabled = True
        Else
            lblVerified.Text = "Invalid Email!"
            btnSendAC.Enabled = False
        End If


    End Sub

    Private Sub lblVerified_Click(sender As Object, e As EventArgs) Handles lblVerified.Click

    End Sub


    Public Sub btnSendAC_Click(sender As Object, e As EventArgs) Handles btnSendAC.Click
        Dim activationCode As String = Guid.NewGuid().ToString()
        Dim body As String = "Dear " + txtUsername.Text.Trim() + ","
        body += vbCrLf + vbCrLf + "Please use following activation code to activate your account on Be Secure:"
        body += vbCrLf + "Activation Code: " + activationCode
        Vericode = activationCode
        body += vbCrLf + vbCrLf + "If you have any inquiries you can always contact us throuth this email address."
        body += vbCrLf + "With kind regards,"
        body += vbCrLf + "Be Secure Support."

        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("rushdi210663@gmail.com", "733812210")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("oodjtestmail@gmail.com")
            e_mail.To.Add(txtEmail.Text)
            e_mail.Subject = "Be Secure Activation Code"
            e_mail.IsBodyHtml = False
            e_mail.Body = body
            Smtp_Server.Send(e_mail)
            MessageBox.Show("Activation Code has been Sent", "Be secure: Activation Code", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch error_t As Exception
            MsgBox(error_t.ToString)
        End Try
    End Sub

    Private Sub txtPwd_TextChanged(sender As Object, e As EventArgs) Handles txtPwd.TextChanged

    End Sub

    Private Sub txtVrfCode_TextChanged(sender As Object, e As EventArgs) Handles txtVrfCode.TextChanged

    End Sub

    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        btnSendAC.Enabled = False
        'btnRegister.Enabled = False
    End Sub

    Private Sub Label1_Click_3(sender As Object, e As EventArgs) Handles lblProgressbar.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to leave?", "Be secure: Registration handler", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)

        If result = DialogResult.Yes Then
            frmLogin.Show()
            Me.Close()
        Else
            result = DialogResult.No

        End If
    End Sub
End Class
