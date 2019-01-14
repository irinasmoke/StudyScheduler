Imports Microsoft.Office.Tools.Ribbon

Public Class Ribbon1

    Private Sub Ribbon1_Load(ByVal sender As System.Object, ByVal e As RibbonUIEventArgs) Handles MyBase.Load

    End Sub


    Private Sub Ribbon1_Load(sender As Object, e As RibbonControlEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As RibbonControlEventArgs) Handles Button2.Click
        Dim win As New Setup_Window
        win.Show() 'Using Show() to make it modeless, ShowDialog() would make it modal
    End Sub

    Private Sub Button1_Click(sender As Object, e As RibbonControlEventArgs)

    End Sub
End Class
