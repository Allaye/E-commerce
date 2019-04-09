Public Class About
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hs As New Start_up_page
        hs.Show()
        Me.Hide()

    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub About_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
    End Sub
End Class