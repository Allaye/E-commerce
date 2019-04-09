Imports System.Data.SqlClient
Imports System.IO

Public Class ProductEdit
    Private Sub ProductTBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductTBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)
        '   ProductTBDataGridView.DataSource = GetDataSource()

    End Sub

    Private Function GetDataSource() As DataTable
        Const sqlSelect As String = "use [E-commerce];SELECT ProductTB.ProductImage, ProductTB.ProductID ,ProductTB.ProductLive, ProductTB.ProductSku, ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductWeight, ProductTB.ProductDiscp, ProductTB.ProductStock,  CategoryTB.*
FROM     ProductTB INNER JOIN
                  CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID"
        Try
            Dim table = New DataTable()
            Dim con As New SqlConnection("Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
            con.Open()
            Dim da As New SqlDataAdapter(sqlSelect, con)
            da.Fill(table)
            Return table

        Catch ex As Exception
            ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function
    Private Sub Producteditform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        ProductTBDataGridView.DataSource = GetDataSource()
        'TODO: This line of code loads data into the '_E_commerceDataSet.ProductTB' table. You can move, or remove it, as needed.

        '  ProductCategoryTextBox.Text = String.Empty
        ''ProductCategoryTextBox.Enabled = False
        'Me.ProductTBDataGridView.Visible = False
        'Me.ProductSkuTextBox.Visible = False
        'Me.ProductNameTextBox.Visible = False
        'Me.ProductImagePictureBox.Visible = False
        'Me.ProductLiveCheckBox.Visible = False
        'Me.ProductDiscpTextBox.Visible = False
        'Me.ProductPriceTextBox.Visible = False
        'Me.ProductStockTextBox.Visible = False
        'Me.ProductWeightTextBox.Visible = False
        'Me.ProductTBBindingNavigator.Visible = False
        'Me.deletebtn.Enabled = False
        ' 


    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Try
            Me.ProductTBBindingSource.RemoveCurrent()
            Me.Validate()
            Me.ProductTBBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)
            MsgBox("Deleted")
        Catch ex As Exception
            MsgBox("Product Catalog Empty")
        End Try


    End Sub

    Private Sub ProductTBDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductTBDataGridView.CellContentClick

        ' ProductTBDataGridView.DataSource = GetDataSource()
        Try
            If e.ColumnIndex = 0 Then
                'Dim v As String = MessageTBDataGridView.Rows(e.RowIndex).Cells(0).Value
                Dim formfive As New ProEdir
                ' formthree.Tag = v
                formfive.ProductIDTextBox.Text = ProductTBDataGridView.CurrentRow.Cells(2).Value.ToString
                formfive.ProductSkuTextBox.Text = ProductTBDataGridView.CurrentRow.Cells(4).Value.ToString
                formfive.ProductNameTextBox.Text = ProductTBDataGridView.CurrentRow.Cells(5).Value.ToString
                formfive.ProductPriceTextBox.Text = ProductTBDataGridView.CurrentRow.Cells(6).Value.ToString
                formfive.ProductWeightTextBox.Text = ProductTBDataGridView.CurrentRow.Cells(7).Value.ToString
                formfive.ProductStockTextBox.Text = ProductTBDataGridView.CurrentRow.Cells(9).Value.ToString
                formfive.ProductLiveCheckBox.Text = ProductTBDataGridView.CurrentRow.Cells(3).Value.ToString
                formfive.CategoryIDTextBox.Text = ProductTBDataGridView.CurrentRow.Cells(10).Value.ToString
                formfive.ProductColorTextBox.Text = ProductTBDataGridView.CurrentRow.Cells(12).Value.ToString
                formfive.ProductSizeComboBox.Text = ProductTBDataGridView.CurrentRow.Cells(11).Value.ToString
                Dim bytes As [Byte]() = ProductTBDataGridView.CurrentRow.Cells(1).Value
                Dim ms As New MemoryStream(bytes)
                formfive.ProductImagePictureBox.Image = Image.FromStream(ms)
                '= ProductTBDataGridView.CurrentRow.Cells(1)
                formfive.ProductIDTextBox1.Text = ProductTBDataGridView.CurrentRow.Cells(14).Value.ToString
                formfive.ProductDiscpTextBox.Text = ProductTBDataGridView.CurrentRow.Cells(8).Value.ToString
                formfive.CategoryNameComboBox.Text = ProductTBDataGridView.CurrentRow.Cells(13).Value.ToString
                ProductTBDataGridView.Refresh()
                formfive.ShowDialog()
                Me.Hide()
            End If
        Catch ex As Exception

        End Try





    End Sub

    Private Sub ProductTBBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub Enable_Click(sender As Object, e As EventArgs)
        'ProductCategoryTextBox.Visible = True
        'Me.ProductTBDataGridView.Visible = True

        'Me.ProductSkuTextBox.Visible = True
        'Me.ProductNameTextBox.Visible = True
        'Me.ProductImagePictureBox.Visible = True
        'Me.ProductLiveCheckBox.Visible = True
        'Me.ProductDiscpTextBox.Visible = True
        'Me.ProductPriceTextBox.Visible = True
        'Me.ProductStockTextBox.Visible = True
        'Me.ProductWeightTextBox.Visible = True
        'Me.ProductTBBindingNavigator.Visible = True
        'Me.deletebtn.Enabled = True
        ' Me.ProductTBTableAdapter.Fill(Me._E_commerceDataSet.ProductTB)
    End Sub

    Private Sub ProductSkuTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProductNameTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs)
        ' ProductTBDataGridView.EditMode = DataGridViewEditMode.EditOnEnter
        ' Me.ProductTBDataGridView.BeginEdit(True)

    End Sub

    Private Sub ProductTBBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Shopbtn.Click
        Dim vshop As New vendorshop
        vshop.Show()
        Me.Close()
    End Sub

    'Private Sub producteditform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub
End Class