Public Class Vsignup
    Private Sub VendorTBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VendorTBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VendorTBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)

    End Sub

    Private Sub Vsignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_E_commerceDataSet.VendorTB' table. You can move, or remove it, as needed.
        Me.VendorTBTableAdapter.Fill(Me._E_commerceDataSet.VendorTB)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.Validate()
            Me.VendorTBBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)
        Catch ex As Exception

        End Try
    End Sub
End Class