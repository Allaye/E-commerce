
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging


Public Class Start_up_page
    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub
    Public Function Exitsystem()
        Dim appexit As DialogResult
        appexit = MessageBox.Show("Do you want to Exit Application", "MAGASIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If appexit = DialogResult.Yes Then
            Application.Exit()
        End If
        Return appexit
    End Function
    Private Sub Start_up_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2

    End Sub

    Private Sub Guestbtn_Click(sender As Object, e As EventArgs)
        Dim shopmain = New Main_shop()
        shopmain.Show()
        Me.Hide()
    End Sub

    Private Sub Customerbtn_Click(sender As Object, e As EventArgs)
        Dim cussignin = New Customersignin()
        cussignin.Show()
        Me.Hide()



    End Sub

    Private Sub Vendorbtn_Click(sender As Object, e As EventArgs)
        Dim vendorsignin = New Vendor_Signin()
        vendorsignin.Show()
        Me.Hide()



    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs)
        '  Label1.TextAlign = ContentAlignment.TopLeft
        '  Me.AutoScaleMode = AutoScaleMode.Dpi
        ' Me.gridControl1.DpiAware = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim MainShop = New Main_shop
        MainShop.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        exitsystem()
    End Sub

    Private Sub Guestbtn_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Customerbtn_Click_1(sender As Object, e As EventArgs) Handles Customerbtn.Click
        Dim cuslogin As New Customersignin
        cuslogin.Show()
        Me.Hide()
    End Sub

    Private Sub Vendorbtn_Click_1(sender As Object, e As EventArgs) Handles Vendorbtn.Click
        Dim vendorsignin = New Vendor_Signin()
        vendorsignin.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ab As New About
        ab.Show()
        Me.Hide()

    End Sub
End Class