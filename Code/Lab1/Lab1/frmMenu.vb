
Public Class frmMenu



    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        frmServerListener.Show()
        Me.Close()

    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
    End Sub

    Private Sub btnFolderLocker_Click(sender As Object, e As EventArgs) Handles btnFolderLocker.Click
        frmFLocker.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmLogin.Show()
        Me.Close()
    End Sub



    Private Sub btnEncrDecr_Click(sender As Object, e As EventArgs) Handles btnEncrDecr.Click
        frmRijndael.Show()
        Me.Close()
    End Sub

    Private Sub btnHashVer_Click(sender As Object, e As EventArgs) Handles btnHashVer.Click
        frmHashVer.Show()
        Me.Close()

    End Sub
End Class