Imports System.Data.SqlClient
Public Class Vendor_Signin
    Dim connection As New SqlConnection("Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
    Private Sub Signupbtn_Click(sender As Object, e As EventArgs) Handles signupbtn.Click
        Dim vendorsignup = New vendorsignup
        vendorsignup.Show()
        Me.Hide()


    End Sub
    Private Function VloginQuery()

        Dim command As New SqlCommand("select VendorID, VendorPassword from VendorTB where VendorID ='" + VendorIDTextBox.Text + "' and VendorPassword = '" + VendorPasswordTextBox.Text + "' ", connection)
        '("select * from CustomerTB where CustomerEmail = customeridtxtbox.Text and CustomerPassword = customerpasswordtxtbox.Text", connection)
        'command.Parameters.Add("username", SqlDbType.NVarChar).Value = customeridtxtbox.Text
        ' command.Parameters.Add("password", SqlDbType.NVarChar).Value = customerpasswordtxtbox.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable
        Try
            Dim appexit As DialogResult
            adapter.Fill(table)
            If table.Rows.Count <= 0 Then
                MessageBox.Show("Invalid login details ")
                VendorIDTextBox.Text = ""
                VendorPasswordTextBox.Text = ""
            Else
                appexit = MessageBox.Show("Proceed To Login", "MAGASIN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If appexit = DialogResult.OK Then

                    Dim vlog As New vendorshop
                    vlog.Show()
                    Me.Hide()
                End If
            End If
            Return table

        Catch ex As Exception

        End Try

    End Function
    Private Sub Vendorloginbtn_Click(sender As Object, e As EventArgs) Handles vendorloginbtn.Click
        VloginQuery()
        'Dim vendorshop As New vendorshop
        'vendorshop.Show()
        'vendorloginbtn.Hide()


    End Sub

    Private Sub Vendor_Signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        'TODO: This line of code loads data into the '_E_commerceDataSet.VendorTB' table. You can move, or remove it, as needed.
        Me.VendorTBTableAdapter.Fill(Me._E_commerceDataSet.VendorTB)

    End Sub

    Private Sub VendorTBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VendorTBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VendorPasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles VendorPasswordTextBox.TextChanged

    End Sub

    Private Sub VendorIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles VendorIDTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vs As New Start_up_page
        vs.Show()
        Me.Hide()

    End Sub
End Class