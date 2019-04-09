Public Class vendorsignup
    Private Sub Signupbox_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Vendorsignin_Click(sender As Object, e As EventArgs)
        Dim vendorsignin = New Vendor_Signin()
        vendorsignin.Show()
        Me.Hide()

    End Sub

    Private Sub VendorTBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VendorTBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)

    End Sub

    Private Sub Vendor_Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        'TODO: This line of code loads data into the '_E_commerceDataSet.VendorTB' table. You can move, or remove it, as needed.
        Me.VendorTBBindingSource.AddNew()
        Me.VendorTBTableAdapter.Fill(Me._E_commerceDataSet.VendorTB)

    End Sub

    Private Sub Vendorsignupbtn_Click(sender As Object, e As EventArgs) Handles vendorsignupbtn.Click
        Try
            Me.Validate()
            Me.VendorTBBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)
            MsgBox("Registration Successful")
        Catch ex As Exception
            MsgBox(ex.Message, " Unsuccessful Registration")

        End Try
        'Dim vshop As New vendorshop
        'vshop.Show()
        'Me.Hide()


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub VendorIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles VendorIDTextBox.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vs As New Vendor_Signin
        vs.Show()
        Me.Hide()

    End Sub
End Class