Imports System.Data
Imports System.Data.SqlClient

Public Class Customersignin

    Dim connection As New SqlConnection("Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
    Private Sub Signin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_E_commerceDataSet.CustomerTB' table. You can move, or remove it, as needed.
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.CustomerTBTableAdapter.Fill(Me._E_commerceDataSet.CustomerTB)

    End Sub



    Private Sub Loginbox_Enter(sender As Object, e As EventArgs)

    End Sub



    Private Sub Usernamelbl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Signupbtn_Click(sender As Object, e As EventArgs)
        Dim cussignup = New customersignup()
        cussignup.Show()
        Me.Hide()
    End Sub

    Private Sub Loginbox_Enter_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Signupbtn_Click_1(sender As Object, e As EventArgs) Handles signupbtn.Click
        Dim cussignup = New customersignup()
        cussignup.Show()
        Me.Hide()
    End Sub
    Private Function LoginQuery()

        Dim command As New SqlCommand("select CustomerEmail, CustomerPassword from CustomerTB where CustomerID ='" + CustomerIDTextBox.Text + "' and CustomerPassword = '" + CustomerPasswordTextBox.Text + "' ", connection)
        '("select * from CustomerTB where CustomerEmail = customeridtxtbox.Text and CustomerPassword = customerpasswordtxtbox.Text", connection)
        'command.Parameters.Add("username", SqlDbType.NVarChar).Value = customeridtxtbox.Text
        ' command.Parameters.Add("password", SqlDbType.NVarChar).Value = customerpasswordtxtbox.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable
        Try
            Dim appexit As DialogResult
            adapter.Fill(table)
            If table.Rows.Count <= 0 Then
                CustomerIDTextBox.Text = ""

                CustomerPasswordTextBox.Text = ""
                MessageBox.Show("Invalid login details ")

            Else
                appexit = MessageBox.Show("Proceed To Login", "MAGASIN", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If appexit = DialogResult.OK Then

                    Dim obj As New Main_shop
                    obj.uname = CustomerIDTextBox.Text
                    obj.Show()
                    Me.Hide()
                End If
            End If

            Return table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Function

    Public Sub Loginbtn_Click_1(sender As Object, e As EventArgs) Handles loginbtn.Click
        LoginQuery()

    End Sub

    Private Sub CustomerTBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomerTBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)

    End Sub

    Public Sub CustomerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIDTextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim home As New Start_up_page
        home.Show()
        Me.Hide()

    End Sub
End Class
