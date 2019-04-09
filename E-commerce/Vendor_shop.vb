
Imports System.Data.SqlClient
Public Class vendorshop

    Dim isnotnull As Object = Nothing
    Private Sub Productcombobox_Click(sender As Object, e As EventArgs) Handles productcombobox.Click
        productcombobox.Items.Clear()
        productcombobox.Items.Add("Manage Product")
        productcombobox.Items.Add("Add Product")
        'If (productcombobox.SelectedItem > -1) Then
        '    productlabellbl.Visible = False



        'End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub Settingcombobox_Click(sender As Object, e As EventArgs) Handles settingcombobox.Click
        settingcombobox.Items.Clear()
        settingcombobox.Items.Add("Your Profile")

        'If (settingcombobox.SelectedItem > -1) Then
        '    settinglabellbl.Visible = False

        'End If
    End Sub

    'Private Sub ordercombobox_Click(sender As Object, e As EventArgs)
    '    ordercombobox.Items.Clear()
    '    ordercombobox.Items.Add("Manage Order")
    '    If (ordercombobox.SelectedItem > -1) Then
    '        orderlabellbl.Visible = False

    '    End If
    'End Sub

    Private Sub Productcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles productcombobox.SelectedIndexChanged

        If productcombobox.SelectedIndex = 1 Then
            Dim addproduct As New pp
            addproduct.Show()
            Me.Hide()
        ElseIf productcombobox.SelectedIndex = 0 Then
            Dim editproductform As New ProductEdit
            editproductform.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Vendorshop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        LoadingProductname()
    End Sub
    Public Function LoadingProductname()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];  SELECT VendorTB.VendorFirstname ,VendorTB.StoreName FROM [E-commerce].[dbo].[VendorTB]"


        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()

            If myreader.Read() Then
                Label24.Text = myreader.GetValue(0)
                Label23.Text = myreader.GetValue(1)



            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label24

    End Function
    Private Sub Ordercombobox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Settingcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles settingcombobox.SelectedIndexChanged
        If settingcombobox.SelectedIndex = 0 Then
            Dim settingform As New editsettingform
            settingform.Show()
            Me.Hide()



        End If
    End Sub

    Private Sub Productlabellbl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Exitsystem()

    End Sub
    Public Function Exitsystem()
        Dim appexit As DialogResult
        appexit = MessageBox.Show("Do you want to LOGOUT", "MAGASIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If appexit = DialogResult.Yes Then
            Start_up_page.Show()
            Me.Hide()
        End If
        Return appexit
    End Function
End Class
