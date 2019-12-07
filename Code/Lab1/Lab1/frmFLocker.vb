Imports System.IO
Imports System.Windows.Forms

Public Class frmFLocker
    Public status As String
    Private ARR As String() = New String(5) {}


    Private Sub btnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        status = ARR(0)

        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim direct As DirectoryInfo = New DirectoryInfo(FolderBrowserDialog1.SelectedPath)
            Dim selectedPath As String = direct.Parent.FullName + direct.Name

            If FolderBrowserDialog1.SelectedPath.LastIndexOf(".{") = -1 Then
                If (Not direct.Root.Equals(direct.Parent.FullName)) Then
                    direct.MoveTo(direct.Parent.FullName & "\" & direct.Name & status)
                Else
                    direct.MoveTo(direct.Parent.FullName + direct.Name & status)
                End If
                txtFLocation.Text = FolderBrowserDialog1.SelectedPath
            Else
                status = getStatus(status)
                direct.MoveTo(FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf(".")))
                txtFLocation.Text = FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf("."))
            End If
        End If
    End Sub

    Private Function getStatus(ByVal stat As String)
        For i As Integer = 0 To 5
            If stat.LastIndexOf(ARR(i)) <> -1 Then
                stat = stat.Substring(stat.LastIndexOf(""))
            End If
        Next i
        Return stat
    End Function

    Private Sub frmFLocker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        status = ""
        ARR(0) = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        ARR(1) = ".{21EC2020-3AEA-1069-A2DD-08002B30309D}"
        ARR(2) = ".{2559a1f4-21d7-11d4-bdaf-00c04f60b9f0}"
        ARR(3) = ".{645FF040-5081-101B-9F08-00AA002F954E}"
        ARR(4) = ".{2559a1f1-21d7-11d4-bdaf-00c04f60b9f0}"
        ARR(5) = ".{7007ACC7-3202-11D1-AAD2-00805FC1270E}"
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnUnlock_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtFLocation_TextChanged(sender As Object, e As EventArgs) Handles txtFLocation.TextChanged

    End Sub

    Private Sub FolderBrowserDialog1_HelpRequest(sender As Object, e As EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub
End Class