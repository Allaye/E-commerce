Public Class pp
    Private Sub CategoryTBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoryTBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoryTBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)

    End Sub

    Private Sub Pp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        'TODO: This line of code loads data into the '_E_commerceDataSet.ProductTB' table. You can move, or remove it, as needed.
        ' Me.ProductTBTableAdapter.Fill(Me._E_commerceDataSet.ProductTB)
        'TODO: This line of code loads data into the '_E_commerceDataSet.CategoryTB' table. You can move, or remove it, as needed.
        ' Me.CategoryTBTableAdapter.Fill(Me._E_commerceDataSet.CategoryTB)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        Try
            Me.Validate()
            Me.CategoryTBBindingSource.EndEdit()
            Me.ProductTBBindingSource.EndEdit()

            Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Imagebtn.Click
        Try
            Me.OpenFileDialog1.ShowDialog()
            ProductImagePictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)
        Catch ex As Exception
            MsgBox("No Image was Selected")
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Addnewbtn.Click
        Try

            Me.ProductTBBindingSource.AddNew()
            Me.CategoryTBBindingSource.AddNew()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Try
            Me.CategoryTBBindingSource.CancelEdit()
            Me.ProductTBBindingSource.CancelEdit()

            MsgBox("Content Cancelled")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CategoryNameComboBox_Click(sender As Object, e As EventArgs) Handles CategoryNameComboBox.Click
        CategoryNameComboBox.Items.Clear()
        CategoryNameComboBox.Items.Add("Electronic")
        CategoryNameComboBox.Items.Add("Other")

    End Sub

    Private Sub ProductSizeComboBox_Click(sender As Object, e As EventArgs) Handles ProductSizeComboBox.Click
        ProductSizeComboBox.Items.Clear()
        ProductSizeComboBox.Items.Add("Small")
        ProductSizeComboBox.Items.Add("Meduim")
        ProductSizeComboBox.Items.Add("Large")
        ProductSizeComboBox.Items.Add("XLarge")

    End Sub

    Private Sub CategoryNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryNameComboBox.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ss As New vendorshop
        ss.Show()
        Me.Hide()
    End Sub

    'Private Sub pp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub
End Class