Public Class frmMenu
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        frmClientConnection.Show()
        Me.Close()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnEncDec_Click(sender As Object, e As EventArgs) Handles btnEncDec.Click
        frmRijndael.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        frmLogin.Show()
        Me.Close()

    End Sub

    Private Sub btnFolderLocker_Click(sender As Object, e As EventArgs) Handles btnFolderLocker.Click
        frmFLocker.Show()
        Me.Close()

    End Sub

    Private Sub btnHash_Click(sender As Object, e As EventArgs) Handles btnHash.Click
        frmHashVer.Show()
        Me.Close()

    End Sub

    Private Sub btnAVscanner_Click(sender As Object, e As EventArgs) Handles btnAVscanner.Click
        frmAVscanner.Show()
        Me.Close()
    End Sub
End Class