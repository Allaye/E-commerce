Public Class editsettingform
    Private Sub VendorTBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VendorTBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)

    End Sub

    Private Sub Editsettingform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        'TODO: This line of code loads data into the '_E_commerceDataSet.VendorTB' table. You can move, or remove it, as needed.
        Me.VendorTBTableAdapter.Fill(Me._E_commerceDataSet.VendorTB)

    End Sub

    Private Sub VendorTBDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VendorTBDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Me.VendorTBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.VendorTBBindingSource.CancelEdit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim vshop As New vendorshop
        vshop.Show()
        Me.Hide()

    End Sub
End Class