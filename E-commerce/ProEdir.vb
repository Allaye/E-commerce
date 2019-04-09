Imports System.Data.SqlClient
Public Class ProEdir
    Private Sub ProductTBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductTBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)

    End Sub

    Private Sub ProEdir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2

        ProductIDTextBox.Enabled = False

        ProductSkuTextBox.Enabled = False
        ProductNameTextBox.Enabled = False
        ProductPriceTextBox.Enabled = False
        ProductWeightTextBox.Enabled = False
        ProductStockTextBox.Enabled = False
        ProductLiveCheckBox.Enabled = False
        CategoryIDTextBox.Enabled = False
        ProductColorTextBox.Enabled = False
        ProductSizeComboBox.Enabled = False
        ProductImagePictureBox.Enabled = False
        ProductIDTextBox1.Enabled = False
        ProductDiscpTextBox.Enabled = False
        CategoryNameComboBox.Enabled = False

        'TODO: This line of code loads data into the '_E_commerceDataSet.CategoryTB' table. You can move, or remove it, as needed.
        ' Me.CategoryTBTableAdapter.Fill(Me._E_commerceDataSet.CategoryTB)
        'TODO: This line of code loads data into the '_E_commerceDataSet.ProductTB' table. You can move, or remove it, as needed.
        ' Me.ProductTBTableAdapter.Fill(Me._E_commerceDataSet.ProductTB)

    End Sub
    Private Function Updatequery()
        Dim sqlselect1 As String = "use [E-commerce]; UPDATE CategoryTB SET CategoryName = '" + CategoryNameComboBox.Text + "', ProductSize = '" + ProductSizeComboBox.Text + "', ProductColor = '" + ProductColorTextBox.Text + "' WHERE CategoryID = '" + CategoryIDTextBox.Text + "' "
        Dim sqlSelect As String = "use [E-commerce];UPDATE ProductTB  set ProductSku = '" + ProductSkuTextBox.Text + "' , ProductName = '" + ProductNameTextBox.Text + "' , ProductPrice ='" + ProductPriceTextBox.Text + "' ,  ProductWeight = '" + ProductWeightTextBox.Text + "' , ProductDiscp = '" + ProductDiscpTextBox.Text + "' , ProductStock ='" + ProductStockTextBox.Text + "' , ProductLive = '" + ProductLiveCheckBox.Text + "' WHERE ProductID =  '" + ProductIDTextBox.Text + "' "
        Try
            Dim con As New SqlConnection("Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
            ' Dim sqlcmd As New SqlCommand("UPDATE ProductTB  SET ProductSku = '" + ProductSkuTextBox.Text + "' and ProductName = '" + ProductNameTextBox.Text + "' , ProductName = '" + ProductNameTextBox.Text + "' , ProductLive ='" + ProductLiveCheckBox.Text + "'  WHERE ProductID =  '" + ProductIDTextBox.Text + "' ", con)

            '  '  and ProductLive = '" + ProductLiveCheckBox.Text + "'and   ProductImage ='" + ProductImagePictureBox + "'  WHERE ProductID =  '" + ProductIDTextBox.Text + "' ", con)
            Dim table = New DataTable()

            con.Open()
            Dim da As New SqlDataAdapter(sqlSelect, con)
            Dim da1 As New SqlDataAdapter(sqlselect1, con)
            da.Fill(table)
            da1.Fill(table)
            'Return table
            Return table
        Catch ex As Exception
            ' log message inste
            Throw ' don't use throw new Exception or throw ex '

        End Try

    End Function
    Private Sub Savebtn_Click(sender As Object, e As EventArgs) Handles Savebtn.Click
        Updatequery()

    End Sub

    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        ProductIDTextBox.Enabled = True

        ProductSkuTextBox.Enabled = True
        ProductNameTextBox.Enabled = True
        ProductPriceTextBox.Enabled = True
        ProductWeightTextBox.Enabled = True
        ProductStockTextBox.Enabled = True
        ProductLiveCheckBox.Enabled = True
        CategoryIDTextBox.Enabled = True
        ProductColorTextBox.Enabled = True
        ProductSizeComboBox.Enabled = True
        ProductImagePictureBox.Enabled = True
        ProductIDTextBox1.Enabled = True
        ProductDiscpTextBox.Enabled = True
        CategoryNameComboBox.Enabled = True
    End Sub
    Private Function Deletequery() As DataTable
        Dim sqlselect1 As String = "use [E-commerce]; DELETE FROM CategoryTB WHERE CategoryID = '" + CategoryIDTextBox.Text + "'  "
        Dim sqlSelect As String = "use [E-commerce]; DELETE FROM ProductTB WHERE ProductID =  '" + ProductIDTextBox.Text + "'"

        Try
            Dim con As New SqlConnection("Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
            ' Dim sqlcmd As New SqlCommand("UPDATE ProductTB  Set ProductSku = '" + ProductSkuTextBox.Text + "' and ProductName = '" + ProductNameTextBox.Text + "' , ProductName = '" + ProductNameTextBox.Text + "' , ProductLive ='" + ProductLiveCheckBox.Text + "'  WHERE ProductID =  '" + ProductIDTextBox.Text + "' ", con)

            '  '  and ProductLive = '" + ProductLiveCheckBox.Text + "'and   ProductImage ='" + ProductImagePictureBox + "'  WHERE ProductID =  '" + ProductIDTextBox.Text + "' ", con)
            Dim table = New DataTable()

            con.Open()
            Dim da As New SqlDataAdapter(sqlSelect, con)
            Dim da1 As New SqlDataAdapter(sqlselect1, con)
            da.Fill(table)
            da1.Fill(table)
            Return table
            MsgBox("Items Deleted")
            ' Return table
        Catch ex As Exception
            ' log message inste
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function
    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        Deletequery()
    End Sub

    Private Sub ProductImagePictureBox_Click(sender As Object, e As EventArgs) Handles ProductImagePictureBox.Click

    End Sub

    Private Sub CategoryNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CategoryNameComboBox.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pe As New ProductEdit
        pe.Show()
        Me.Hide()

    End Sub
End Class