<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CategoryIDLabel As System.Windows.Forms.Label
        Dim ProductSizeLabel As System.Windows.Forms.Label
        Dim ProductColorLabel As System.Windows.Forms.Label
        Dim CategoryNameLabel As System.Windows.Forms.Label
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim ProductIDLabel1 As System.Windows.Forms.Label
        Dim ProductSkuLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim ProductPriceLabel As System.Windows.Forms.Label
        Dim ProductWeightLabel As System.Windows.Forms.Label
        Dim ProductDiscpLabel As System.Windows.Forms.Label
        Dim ProductStockLabel As System.Windows.Forms.Label
        Dim ProductImageLabel As System.Windows.Forms.Label
        Dim ProductLiveLabel As System.Windows.Forms.Label
        Dim VendorIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pp))
        Me._E_commerceDataSet = New E_commerce._E_commerceDataSet()
        Me.CategoryTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTBTableAdapter = New E_commerce._E_commerceDataSetTableAdapters.CategoryTBTableAdapter()
        Me.TableAdapterManager = New E_commerce._E_commerceDataSetTableAdapters.TableAdapterManager()
        Me.ProductTBTableAdapter = New E_commerce._E_commerceDataSetTableAdapters.ProductTBTableAdapter()
        Me.CategoryTBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CategoryTBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CategoryIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductSizeComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductColorTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryNameComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.ProductTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.ProductSkuTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ProductWeightTextBox = New System.Windows.Forms.TextBox()
        Me.ProductDiscpTextBox = New System.Windows.Forms.TextBox()
        Me.ProductStockTextBox = New System.Windows.Forms.TextBox()
        Me.ProductImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.ProductLiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.Imagebtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Addnewbtn = New System.Windows.Forms.Button()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.VendorIDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CategoryIDLabel = New System.Windows.Forms.Label()
        ProductSizeLabel = New System.Windows.Forms.Label()
        ProductColorLabel = New System.Windows.Forms.Label()
        CategoryNameLabel = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        ProductIDLabel1 = New System.Windows.Forms.Label()
        ProductSkuLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        ProductPriceLabel = New System.Windows.Forms.Label()
        ProductWeightLabel = New System.Windows.Forms.Label()
        ProductDiscpLabel = New System.Windows.Forms.Label()
        ProductStockLabel = New System.Windows.Forms.Label()
        ProductImageLabel = New System.Windows.Forms.Label()
        ProductLiveLabel = New System.Windows.Forms.Label()
        VendorIDLabel = New System.Windows.Forms.Label()
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryTBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategoryTBBindingNavigator.SuspendLayout()
        CType(Me.ProductTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryIDLabel
        '
        CategoryIDLabel.AutoSize = True
        CategoryIDLabel.Location = New System.Drawing.Point(488, 82)
        CategoryIDLabel.Name = "CategoryIDLabel"
        CategoryIDLabel.Size = New System.Drawing.Size(86, 17)
        CategoryIDLabel.TabIndex = 1
        CategoryIDLabel.Text = "Category ID:"
        '
        'ProductSizeLabel
        '
        ProductSizeLabel.AutoSize = True
        ProductSizeLabel.Location = New System.Drawing.Point(488, 110)
        ProductSizeLabel.Name = "ProductSizeLabel"
        ProductSizeLabel.Size = New System.Drawing.Size(92, 17)
        ProductSizeLabel.TabIndex = 3
        ProductSizeLabel.Text = "Product Size:"
        '
        'ProductColorLabel
        '
        ProductColorLabel.AutoSize = True
        ProductColorLabel.Location = New System.Drawing.Point(488, 141)
        ProductColorLabel.Name = "ProductColorLabel"
        ProductColorLabel.Size = New System.Drawing.Size(98, 17)
        ProductColorLabel.TabIndex = 5
        ProductColorLabel.Text = "Product Color:"
        '
        'CategoryNameLabel
        '
        CategoryNameLabel.AutoSize = True
        CategoryNameLabel.Location = New System.Drawing.Point(488, 169)
        CategoryNameLabel.Name = "CategoryNameLabel"
        CategoryNameLabel.Size = New System.Drawing.Size(110, 17)
        CategoryNameLabel.TabIndex = 7
        CategoryNameLabel.Text = "Category Name:"
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(488, 200)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(78, 17)
        ProductIDLabel.TabIndex = 9
        ProductIDLabel.Text = "Product ID:"
        '
        'ProductIDLabel1
        '
        ProductIDLabel1.AutoSize = True
        ProductIDLabel1.Location = New System.Drawing.Point(72, 77)
        ProductIDLabel1.Name = "ProductIDLabel1"
        ProductIDLabel1.Size = New System.Drawing.Size(78, 17)
        ProductIDLabel1.TabIndex = 12
        ProductIDLabel1.Text = "Product ID:"
        '
        'ProductSkuLabel
        '
        ProductSkuLabel.AutoSize = True
        ProductSkuLabel.Location = New System.Drawing.Point(72, 105)
        ProductSkuLabel.Name = "ProductSkuLabel"
        ProductSkuLabel.Size = New System.Drawing.Size(89, 17)
        ProductSkuLabel.TabIndex = 14
        ProductSkuLabel.Text = "Product Sku:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(72, 133)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(102, 17)
        ProductNameLabel.TabIndex = 16
        ProductNameLabel.Text = "Product Name:"
        '
        'ProductPriceLabel
        '
        ProductPriceLabel.AutoSize = True
        ProductPriceLabel.Location = New System.Drawing.Point(72, 161)
        ProductPriceLabel.Name = "ProductPriceLabel"
        ProductPriceLabel.Size = New System.Drawing.Size(97, 17)
        ProductPriceLabel.TabIndex = 18
        ProductPriceLabel.Text = "Product Price:"
        '
        'ProductWeightLabel
        '
        ProductWeightLabel.AutoSize = True
        ProductWeightLabel.Location = New System.Drawing.Point(72, 189)
        ProductWeightLabel.Name = "ProductWeightLabel"
        ProductWeightLabel.Size = New System.Drawing.Size(109, 17)
        ProductWeightLabel.TabIndex = 20
        ProductWeightLabel.Text = "Product Weight:"
        '
        'ProductDiscpLabel
        '
        ProductDiscpLabel.AutoSize = True
        ProductDiscpLabel.Location = New System.Drawing.Point(489, 228)
        ProductDiscpLabel.Name = "ProductDiscpLabel"
        ProductDiscpLabel.Size = New System.Drawing.Size(100, 17)
        ProductDiscpLabel.TabIndex = 22
        ProductDiscpLabel.Text = "Product Discp:"
        '
        'ProductStockLabel
        '
        ProductStockLabel.AutoSize = True
        ProductStockLabel.Location = New System.Drawing.Point(72, 245)
        ProductStockLabel.Name = "ProductStockLabel"
        ProductStockLabel.Size = New System.Drawing.Size(100, 17)
        ProductStockLabel.TabIndex = 24
        ProductStockLabel.Text = "Product Stock:"
        '
        'ProductImageLabel
        '
        ProductImageLabel.AutoSize = True
        ProductImageLabel.Location = New System.Drawing.Point(72, 270)
        ProductImageLabel.Name = "ProductImageLabel"
        ProductImageLabel.Size = New System.Drawing.Size(103, 17)
        ProductImageLabel.TabIndex = 26
        ProductImageLabel.Text = "Product Image:"
        '
        'ProductLiveLabel
        '
        ProductLiveLabel.AutoSize = True
        ProductLiveLabel.Location = New System.Drawing.Point(72, 217)
        ProductLiveLabel.Name = "ProductLiveLabel"
        ProductLiveLabel.Size = New System.Drawing.Size(91, 17)
        ProductLiveLabel.TabIndex = 28
        ProductLiveLabel.Text = "Product Live:"
        '
        'VendorIDLabel
        '
        VendorIDLabel.AutoSize = True
        VendorIDLabel.Location = New System.Drawing.Point(489, 312)
        VendorIDLabel.Name = "VendorIDLabel"
        VendorIDLabel.Size = New System.Drawing.Size(75, 17)
        VendorIDLabel.TabIndex = 33
        VendorIDLabel.Text = "Vendor ID:"
        '
        '_E_commerceDataSet
        '
        Me._E_commerceDataSet.DataSetName = "_E_commerceDataSet"
        Me._E_commerceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryTBBindingSource
        '
        Me.CategoryTBBindingSource.DataMember = "CategoryTB"
        Me.CategoryTBBindingSource.DataSource = Me._E_commerceDataSet
        '
        'CategoryTBTableAdapter
        '
        Me.CategoryTBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTBTableAdapter = Me.CategoryTBTableAdapter
        Me.TableAdapterManager.CustomerTBTableAdapter = Nothing
        Me.TableAdapterManager.DetailsTBTableAdapter = Nothing
        Me.TableAdapterManager.OrderTBTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategoryTBTableAdapter = Nothing
        Me.TableAdapterManager.ProductOptionTBTableAdapter = Nothing
        Me.TableAdapterManager.ProductTBTableAdapter = Me.ProductTBTableAdapter
        Me.TableAdapterManager.UpdateOrder = E_commerce._E_commerceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorTBTableAdapter = Nothing
        '
        'ProductTBTableAdapter
        '
        Me.ProductTBTableAdapter.ClearBeforeFill = True
        '
        'CategoryTBBindingNavigator
        '
        Me.CategoryTBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CategoryTBBindingNavigator.BindingSource = Me.CategoryTBBindingSource
        Me.CategoryTBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CategoryTBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CategoryTBBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CategoryTBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CategoryTBBindingNavigatorSaveItem})
        Me.CategoryTBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CategoryTBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CategoryTBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CategoryTBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CategoryTBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CategoryTBBindingNavigator.Name = "CategoryTBBindingNavigator"
        Me.CategoryTBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CategoryTBBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.CategoryTBBindingNavigator.TabIndex = 0
        Me.CategoryTBBindingNavigator.Text = "BindingNavigator1"
        Me.CategoryTBBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CategoryTBBindingNavigatorSaveItem
        '
        Me.CategoryTBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CategoryTBBindingNavigatorSaveItem.Image = CType(resources.GetObject("CategoryTBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CategoryTBBindingNavigatorSaveItem.Name = "CategoryTBBindingNavigatorSaveItem"
        Me.CategoryTBBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.CategoryTBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CategoryIDTextBox
        '
        Me.CategoryIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryTBBindingSource, "CategoryID", True))
        Me.CategoryIDTextBox.Location = New System.Drawing.Point(604, 79)
        Me.CategoryIDTextBox.Name = "CategoryIDTextBox"
        Me.CategoryIDTextBox.Size = New System.Drawing.Size(121, 22)
        Me.CategoryIDTextBox.TabIndex = 2
        '
        'ProductSizeComboBox
        '
        Me.ProductSizeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryTBBindingSource, "ProductSize", True))
        Me.ProductSizeComboBox.FormattingEnabled = True
        Me.ProductSizeComboBox.Location = New System.Drawing.Point(604, 107)
        Me.ProductSizeComboBox.Name = "ProductSizeComboBox"
        Me.ProductSizeComboBox.Size = New System.Drawing.Size(121, 24)
        Me.ProductSizeComboBox.TabIndex = 4
        '
        'ProductColorTextBox
        '
        Me.ProductColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryTBBindingSource, "ProductColor", True))
        Me.ProductColorTextBox.Location = New System.Drawing.Point(604, 138)
        Me.ProductColorTextBox.Name = "ProductColorTextBox"
        Me.ProductColorTextBox.Size = New System.Drawing.Size(121, 22)
        Me.ProductColorTextBox.TabIndex = 6
        '
        'CategoryNameComboBox
        '
        Me.CategoryNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryTBBindingSource, "CategoryName", True))
        Me.CategoryNameComboBox.FormattingEnabled = True
        Me.CategoryNameComboBox.Location = New System.Drawing.Point(604, 166)
        Me.CategoryNameComboBox.Name = "CategoryNameComboBox"
        Me.CategoryNameComboBox.Size = New System.Drawing.Size(121, 24)
        Me.CategoryNameComboBox.TabIndex = 8
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryTBBindingSource, "ProductID", True))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(604, 197)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(121, 22)
        Me.ProductIDTextBox.TabIndex = 10
        '
        'Savebtn
        '
        Me.Savebtn.Location = New System.Drawing.Point(466, 377)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(75, 23)
        Me.Savebtn.TabIndex = 11
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = True
        '
        'ProductTBBindingSource
        '
        Me.ProductTBBindingSource.DataMember = "ProductTB"
        Me.ProductTBBindingSource.DataSource = Me._E_commerceDataSet
        '
        'ProductIDTextBox1
        '
        Me.ProductIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductID", True))
        Me.ProductIDTextBox1.Location = New System.Drawing.Point(187, 74)
        Me.ProductIDTextBox1.Name = "ProductIDTextBox1"
        Me.ProductIDTextBox1.Size = New System.Drawing.Size(104, 22)
        Me.ProductIDTextBox1.TabIndex = 13
        '
        'ProductSkuTextBox
        '
        Me.ProductSkuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductSku", True))
        Me.ProductSkuTextBox.Location = New System.Drawing.Point(187, 102)
        Me.ProductSkuTextBox.Name = "ProductSkuTextBox"
        Me.ProductSkuTextBox.Size = New System.Drawing.Size(104, 22)
        Me.ProductSkuTextBox.TabIndex = 15
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(187, 130)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(104, 22)
        Me.ProductNameTextBox.TabIndex = 17
        '
        'ProductPriceTextBox
        '
        Me.ProductPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductPrice", True))
        Me.ProductPriceTextBox.Location = New System.Drawing.Point(187, 158)
        Me.ProductPriceTextBox.Name = "ProductPriceTextBox"
        Me.ProductPriceTextBox.Size = New System.Drawing.Size(104, 22)
        Me.ProductPriceTextBox.TabIndex = 19
        '
        'ProductWeightTextBox
        '
        Me.ProductWeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductWeight", True))
        Me.ProductWeightTextBox.Location = New System.Drawing.Point(187, 186)
        Me.ProductWeightTextBox.Name = "ProductWeightTextBox"
        Me.ProductWeightTextBox.Size = New System.Drawing.Size(104, 22)
        Me.ProductWeightTextBox.TabIndex = 21
        '
        'ProductDiscpTextBox
        '
        Me.ProductDiscpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductDiscp", True))
        Me.ProductDiscpTextBox.Location = New System.Drawing.Point(604, 225)
        Me.ProductDiscpTextBox.Multiline = True
        Me.ProductDiscpTextBox.Name = "ProductDiscpTextBox"
        Me.ProductDiscpTextBox.Size = New System.Drawing.Size(157, 80)
        Me.ProductDiscpTextBox.TabIndex = 23
        '
        'ProductStockTextBox
        '
        Me.ProductStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductStock", True))
        Me.ProductStockTextBox.Location = New System.Drawing.Point(187, 242)
        Me.ProductStockTextBox.Name = "ProductStockTextBox"
        Me.ProductStockTextBox.Size = New System.Drawing.Size(104, 22)
        Me.ProductStockTextBox.TabIndex = 25
        '
        'ProductImagePictureBox
        '
        Me.ProductImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductTBBindingSource, "ProductImage", True))
        Me.ProductImagePictureBox.Location = New System.Drawing.Point(187, 270)
        Me.ProductImagePictureBox.Name = "ProductImagePictureBox"
        Me.ProductImagePictureBox.Size = New System.Drawing.Size(236, 168)
        Me.ProductImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductImagePictureBox.TabIndex = 27
        Me.ProductImagePictureBox.TabStop = False
        '
        'ProductLiveCheckBox
        '
        Me.ProductLiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductTBBindingSource, "ProductLive", True))
        Me.ProductLiveCheckBox.Location = New System.Drawing.Point(187, 212)
        Me.ProductLiveCheckBox.Name = "ProductLiveCheckBox"
        Me.ProductLiveCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ProductLiveCheckBox.TabIndex = 29
        Me.ProductLiveCheckBox.Text = "CheckBox1"
        Me.ProductLiveCheckBox.UseVisualStyleBackColor = True
        '
        'Imagebtn
        '
        Me.Imagebtn.Location = New System.Drawing.Point(75, 346)
        Me.Imagebtn.Name = "Imagebtn"
        Me.Imagebtn.Size = New System.Drawing.Size(75, 23)
        Me.Imagebtn.TabIndex = 30
        Me.Imagebtn.Text = "Image"
        Me.Imagebtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Addnewbtn
        '
        Me.Addnewbtn.Location = New System.Drawing.Point(557, 377)
        Me.Addnewbtn.Name = "Addnewbtn"
        Me.Addnewbtn.Size = New System.Drawing.Size(113, 23)
        Me.Addnewbtn.TabIndex = 31
        Me.Addnewbtn.Text = "Add New"
        Me.Addnewbtn.UseVisualStyleBackColor = True
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Location = New System.Drawing.Point(686, 377)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(75, 23)
        Me.Cancelbtn.TabIndex = 32
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = True
        '
        'VendorIDTextBox
        '
        Me.VendorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "VendorID", True))
        Me.VendorIDTextBox.Location = New System.Drawing.Point(604, 312)
        Me.VendorIDTextBox.Name = "VendorIDTextBox"
        Me.VendorIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorIDTextBox.TabIndex = 34
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(666, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Back TO Shop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(800, 458)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(VendorIDLabel)
        Me.Controls.Add(Me.VendorIDTextBox)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.Addnewbtn)
        Me.Controls.Add(Me.Imagebtn)
        Me.Controls.Add(ProductIDLabel1)
        Me.Controls.Add(Me.ProductIDTextBox1)
        Me.Controls.Add(ProductSkuLabel)
        Me.Controls.Add(Me.ProductSkuTextBox)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(ProductPriceLabel)
        Me.Controls.Add(Me.ProductPriceTextBox)
        Me.Controls.Add(ProductWeightLabel)
        Me.Controls.Add(Me.ProductWeightTextBox)
        Me.Controls.Add(ProductDiscpLabel)
        Me.Controls.Add(Me.ProductDiscpTextBox)
        Me.Controls.Add(ProductStockLabel)
        Me.Controls.Add(Me.ProductStockTextBox)
        Me.Controls.Add(ProductImageLabel)
        Me.Controls.Add(Me.ProductImagePictureBox)
        Me.Controls.Add(ProductLiveLabel)
        Me.Controls.Add(Me.ProductLiveCheckBox)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(CategoryIDLabel)
        Me.Controls.Add(Me.CategoryIDTextBox)
        Me.Controls.Add(ProductSizeLabel)
        Me.Controls.Add(Me.ProductSizeComboBox)
        Me.Controls.Add(ProductColorLabel)
        Me.Controls.Add(Me.ProductColorTextBox)
        Me.Controls.Add(CategoryNameLabel)
        Me.Controls.Add(Me.CategoryNameComboBox)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDTextBox)
        Me.Controls.Add(Me.CategoryTBBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pp"
        Me.Text = " Production Creation Page"
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryTBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategoryTBBindingNavigator.ResumeLayout(False)
        Me.CategoryTBBindingNavigator.PerformLayout()
        CType(Me.ProductTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _E_commerceDataSet As _E_commerceDataSet
    Friend WithEvents CategoryTBBindingSource As BindingSource
    Friend WithEvents CategoryTBTableAdapter As _E_commerceDataSetTableAdapters.CategoryTBTableAdapter
    Friend WithEvents TableAdapterManager As _E_commerceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoryTBBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CategoryTBBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CategoryIDTextBox As TextBox
    Friend WithEvents ProductSizeComboBox As ComboBox
    Friend WithEvents ProductColorTextBox As TextBox
    Friend WithEvents CategoryNameComboBox As ComboBox
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents Savebtn As Button
    Friend WithEvents ProductTBTableAdapter As _E_commerceDataSetTableAdapters.ProductTBTableAdapter
    Friend WithEvents ProductTBBindingSource As BindingSource
    Friend WithEvents ProductIDTextBox1 As TextBox
    Friend WithEvents ProductSkuTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents ProductPriceTextBox As TextBox
    Friend WithEvents ProductWeightTextBox As TextBox
    Friend WithEvents ProductDiscpTextBox As TextBox
    Friend WithEvents ProductStockTextBox As TextBox
    Friend WithEvents ProductImagePictureBox As PictureBox
    Friend WithEvents ProductLiveCheckBox As CheckBox
    Friend WithEvents Imagebtn As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Addnewbtn As Button
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents VendorIDTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
