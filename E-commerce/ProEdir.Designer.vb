<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProEdir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim ProductSkuLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim ProductPriceLabel As System.Windows.Forms.Label
        Dim ProductWeightLabel As System.Windows.Forms.Label
        Dim ProductDiscpLabel As System.Windows.Forms.Label
        Dim ProductStockLabel As System.Windows.Forms.Label
        Dim ProductImageLabel As System.Windows.Forms.Label
        Dim CategoryIDLabel As System.Windows.Forms.Label
        Dim ProductSizeLabel As System.Windows.Forms.Label
        Dim ProductColorLabel As System.Windows.Forms.Label
        Dim CategoryNameLabel As System.Windows.Forms.Label
        Dim ProductIDLabel1 As System.Windows.Forms.Label
        Dim ProductLiveLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProEdir))
        Me._E_commerceDataSet = New E_commerce._E_commerceDataSet()
        Me.ProductTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTBTableAdapter = New E_commerce._E_commerceDataSetTableAdapters.ProductTBTableAdapter()
        Me.TableAdapterManager = New E_commerce._E_commerceDataSetTableAdapters.TableAdapterManager()
        Me.CategoryTBTableAdapter = New E_commerce._E_commerceDataSetTableAdapters.CategoryTBTableAdapter()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductSkuTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ProductWeightTextBox = New System.Windows.Forms.TextBox()
        Me.ProductDiscpTextBox = New System.Windows.Forms.TextBox()
        Me.ProductStockTextBox = New System.Windows.Forms.TextBox()
        Me.ProductImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.CategoryTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductSizeComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductColorTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryNameComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Savebtn = New System.Windows.Forms.Button()
        Me.ProductLiveCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        ProductIDLabel = New System.Windows.Forms.Label()
        ProductSkuLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        ProductPriceLabel = New System.Windows.Forms.Label()
        ProductWeightLabel = New System.Windows.Forms.Label()
        ProductDiscpLabel = New System.Windows.Forms.Label()
        ProductStockLabel = New System.Windows.Forms.Label()
        ProductImageLabel = New System.Windows.Forms.Label()
        CategoryIDLabel = New System.Windows.Forms.Label()
        ProductSizeLabel = New System.Windows.Forms.Label()
        ProductColorLabel = New System.Windows.Forms.Label()
        CategoryNameLabel = New System.Windows.Forms.Label()
        ProductIDLabel1 = New System.Windows.Forms.Label()
        ProductLiveLabel = New System.Windows.Forms.Label()
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductIDLabel
        '
        ProductIDLabel.AutoSize = True
        ProductIDLabel.Location = New System.Drawing.Point(49, 58)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(78, 17)
        ProductIDLabel.TabIndex = 1
        ProductIDLabel.Text = "Product ID:"
        '
        'ProductSkuLabel
        '
        ProductSkuLabel.AutoSize = True
        ProductSkuLabel.Location = New System.Drawing.Point(49, 86)
        ProductSkuLabel.Name = "ProductSkuLabel"
        ProductSkuLabel.Size = New System.Drawing.Size(89, 17)
        ProductSkuLabel.TabIndex = 3
        ProductSkuLabel.Text = "Product Sku:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(49, 114)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(102, 17)
        ProductNameLabel.TabIndex = 5
        ProductNameLabel.Text = "Product Name:"
        '
        'ProductPriceLabel
        '
        ProductPriceLabel.AutoSize = True
        ProductPriceLabel.Location = New System.Drawing.Point(49, 142)
        ProductPriceLabel.Name = "ProductPriceLabel"
        ProductPriceLabel.Size = New System.Drawing.Size(97, 17)
        ProductPriceLabel.TabIndex = 7
        ProductPriceLabel.Text = "Product Price:"
        '
        'ProductWeightLabel
        '
        ProductWeightLabel.AutoSize = True
        ProductWeightLabel.Location = New System.Drawing.Point(49, 170)
        ProductWeightLabel.Name = "ProductWeightLabel"
        ProductWeightLabel.Size = New System.Drawing.Size(109, 17)
        ProductWeightLabel.TabIndex = 9
        ProductWeightLabel.Text = "Product Weight:"
        '
        'ProductDiscpLabel
        '
        ProductDiscpLabel.AutoSize = True
        ProductDiscpLabel.Location = New System.Drawing.Point(414, 204)
        ProductDiscpLabel.Name = "ProductDiscpLabel"
        ProductDiscpLabel.Size = New System.Drawing.Size(100, 17)
        ProductDiscpLabel.TabIndex = 11
        ProductDiscpLabel.Text = "Product Discp:"
        '
        'ProductStockLabel
        '
        ProductStockLabel.AutoSize = True
        ProductStockLabel.Location = New System.Drawing.Point(49, 199)
        ProductStockLabel.Name = "ProductStockLabel"
        ProductStockLabel.Size = New System.Drawing.Size(100, 17)
        ProductStockLabel.TabIndex = 13
        ProductStockLabel.Text = "Product Stock:"
        '
        'ProductImageLabel
        '
        ProductImageLabel.AutoSize = True
        ProductImageLabel.Location = New System.Drawing.Point(49, 266)
        ProductImageLabel.Name = "ProductImageLabel"
        ProductImageLabel.Size = New System.Drawing.Size(103, 17)
        ProductImageLabel.TabIndex = 15
        ProductImageLabel.Text = "Product Image:"
        '
        'CategoryIDLabel
        '
        CategoryIDLabel.AutoSize = True
        CategoryIDLabel.Location = New System.Drawing.Point(413, 58)
        CategoryIDLabel.Name = "CategoryIDLabel"
        CategoryIDLabel.Size = New System.Drawing.Size(86, 17)
        CategoryIDLabel.TabIndex = 17
        CategoryIDLabel.Text = "Category ID:"
        '
        'ProductSizeLabel
        '
        ProductSizeLabel.AutoSize = True
        ProductSizeLabel.Location = New System.Drawing.Point(413, 86)
        ProductSizeLabel.Name = "ProductSizeLabel"
        ProductSizeLabel.Size = New System.Drawing.Size(92, 17)
        ProductSizeLabel.TabIndex = 19
        ProductSizeLabel.Text = "Product Size:"
        '
        'ProductColorLabel
        '
        ProductColorLabel.AutoSize = True
        ProductColorLabel.Location = New System.Drawing.Point(413, 117)
        ProductColorLabel.Name = "ProductColorLabel"
        ProductColorLabel.Size = New System.Drawing.Size(98, 17)
        ProductColorLabel.TabIndex = 21
        ProductColorLabel.Text = "Product Color:"
        '
        'CategoryNameLabel
        '
        CategoryNameLabel.AutoSize = True
        CategoryNameLabel.Location = New System.Drawing.Point(413, 145)
        CategoryNameLabel.Name = "CategoryNameLabel"
        CategoryNameLabel.Size = New System.Drawing.Size(110, 17)
        CategoryNameLabel.TabIndex = 23
        CategoryNameLabel.Text = "Category Name:"
        '
        'ProductIDLabel1
        '
        ProductIDLabel1.AutoSize = True
        ProductIDLabel1.Location = New System.Drawing.Point(413, 176)
        ProductIDLabel1.Name = "ProductIDLabel1"
        ProductIDLabel1.Size = New System.Drawing.Size(78, 17)
        ProductIDLabel1.TabIndex = 25
        ProductIDLabel1.Text = "Product ID:"
        '
        'ProductLiveLabel
        '
        ProductLiveLabel.AutoSize = True
        ProductLiveLabel.Location = New System.Drawing.Point(49, 233)
        ProductLiveLabel.Name = "ProductLiveLabel"
        ProductLiveLabel.Size = New System.Drawing.Size(91, 17)
        ProductLiveLabel.TabIndex = 34
        ProductLiveLabel.Text = "Product Live:"
        '
        '_E_commerceDataSet
        '
        Me._E_commerceDataSet.DataSetName = "_E_commerceDataSet"
        Me._E_commerceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductTBBindingSource
        '
        Me.ProductTBBindingSource.DataMember = "ProductTB"
        Me.ProductTBBindingSource.DataSource = Me._E_commerceDataSet
        '
        'ProductTBTableAdapter
        '
        Me.ProductTBTableAdapter.ClearBeforeFill = True
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
        'CategoryTBTableAdapter
        '
        Me.CategoryTBTableAdapter.ClearBeforeFill = True
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductID", True))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(164, 55)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ProductIDTextBox.TabIndex = 2
        '
        'ProductSkuTextBox
        '
        Me.ProductSkuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductSku", True))
        Me.ProductSkuTextBox.Location = New System.Drawing.Point(164, 83)
        Me.ProductSkuTextBox.Name = "ProductSkuTextBox"
        Me.ProductSkuTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ProductSkuTextBox.TabIndex = 4
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(164, 111)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ProductNameTextBox.TabIndex = 6
        '
        'ProductPriceTextBox
        '
        Me.ProductPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductPrice", True))
        Me.ProductPriceTextBox.Location = New System.Drawing.Point(164, 139)
        Me.ProductPriceTextBox.Name = "ProductPriceTextBox"
        Me.ProductPriceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ProductPriceTextBox.TabIndex = 8
        '
        'ProductWeightTextBox
        '
        Me.ProductWeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductWeight", True))
        Me.ProductWeightTextBox.Location = New System.Drawing.Point(164, 167)
        Me.ProductWeightTextBox.Name = "ProductWeightTextBox"
        Me.ProductWeightTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ProductWeightTextBox.TabIndex = 10
        '
        'ProductDiscpTextBox
        '
        Me.ProductDiscpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductDiscp", True))
        Me.ProductDiscpTextBox.Location = New System.Drawing.Point(529, 199)
        Me.ProductDiscpTextBox.Multiline = True
        Me.ProductDiscpTextBox.Name = "ProductDiscpTextBox"
        Me.ProductDiscpTextBox.Size = New System.Drawing.Size(219, 102)
        Me.ProductDiscpTextBox.TabIndex = 12
        '
        'ProductStockTextBox
        '
        Me.ProductStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductTBBindingSource, "ProductStock", True))
        Me.ProductStockTextBox.Location = New System.Drawing.Point(164, 196)
        Me.ProductStockTextBox.Name = "ProductStockTextBox"
        Me.ProductStockTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ProductStockTextBox.TabIndex = 14
        '
        'ProductImagePictureBox
        '
        Me.ProductImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductTBBindingSource, "ProductImage", True))
        Me.ProductImagePictureBox.Location = New System.Drawing.Point(52, 286)
        Me.ProductImagePictureBox.Name = "ProductImagePictureBox"
        Me.ProductImagePictureBox.Size = New System.Drawing.Size(297, 159)
        Me.ProductImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductImagePictureBox.TabIndex = 16
        Me.ProductImagePictureBox.TabStop = False
        '
        'CategoryTBBindingSource
        '
        Me.CategoryTBBindingSource.DataMember = "CategoryTB"
        Me.CategoryTBBindingSource.DataSource = Me._E_commerceDataSet
        '
        'CategoryIDTextBox
        '
        Me.CategoryIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryTBBindingSource, "CategoryID", True))
        Me.CategoryIDTextBox.Location = New System.Drawing.Point(529, 55)
        Me.CategoryIDTextBox.Name = "CategoryIDTextBox"
        Me.CategoryIDTextBox.Size = New System.Drawing.Size(121, 22)
        Me.CategoryIDTextBox.TabIndex = 18
        '
        'ProductSizeComboBox
        '
        Me.ProductSizeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryTBBindingSource, "ProductSize", True))
        Me.ProductSizeComboBox.FormattingEnabled = True
        Me.ProductSizeComboBox.Location = New System.Drawing.Point(529, 83)
        Me.ProductSizeComboBox.Name = "ProductSizeComboBox"
        Me.ProductSizeComboBox.Size = New System.Drawing.Size(121, 24)
        Me.ProductSizeComboBox.TabIndex = 20
        '
        'ProductColorTextBox
        '
        Me.ProductColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryTBBindingSource, "ProductColor", True))
        Me.ProductColorTextBox.Location = New System.Drawing.Point(529, 114)
        Me.ProductColorTextBox.Name = "ProductColorTextBox"
        Me.ProductColorTextBox.Size = New System.Drawing.Size(121, 22)
        Me.ProductColorTextBox.TabIndex = 22
        '
        'CategoryNameComboBox
        '
        Me.CategoryNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryTBBindingSource, "CategoryName", True))
        Me.CategoryNameComboBox.FormattingEnabled = True
        Me.CategoryNameComboBox.Location = New System.Drawing.Point(529, 142)
        Me.CategoryNameComboBox.Name = "CategoryNameComboBox"
        Me.CategoryNameComboBox.Size = New System.Drawing.Size(121, 24)
        Me.CategoryNameComboBox.TabIndex = 24
        '
        'ProductIDTextBox1
        '
        Me.ProductIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoryTBBindingSource, "ProductID", True))
        Me.ProductIDTextBox1.Location = New System.Drawing.Point(529, 173)
        Me.ProductIDTextBox1.Name = "ProductIDTextBox1"
        Me.ProductIDTextBox1.Size = New System.Drawing.Size(121, 22)
        Me.ProductIDTextBox1.TabIndex = 26
        '
        'Deletebtn
        '
        Me.Deletebtn.Location = New System.Drawing.Point(673, 334)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(75, 23)
        Me.Deletebtn.TabIndex = 34
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.UseVisualStyleBackColor = True
        '
        'Editbtn
        '
        Me.Editbtn.Location = New System.Drawing.Point(549, 334)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(101, 23)
        Me.Editbtn.TabIndex = 33
        Me.Editbtn.Text = "Enable-Edit"
        Me.Editbtn.UseVisualStyleBackColor = True
        '
        'Savebtn
        '
        Me.Savebtn.Location = New System.Drawing.Point(448, 334)
        Me.Savebtn.Name = "Savebtn"
        Me.Savebtn.Size = New System.Drawing.Size(75, 23)
        Me.Savebtn.TabIndex = 32
        Me.Savebtn.Text = "Save"
        Me.Savebtn.UseVisualStyleBackColor = True
        '
        'ProductLiveCheckBox
        '
        Me.ProductLiveCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductTBBindingSource, "ProductLive", True))
        Me.ProductLiveCheckBox.Location = New System.Drawing.Point(164, 233)
        Me.ProductLiveCheckBox.Name = "ProductLiveCheckBox"
        Me.ProductLiveCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ProductLiveCheckBox.TabIndex = 35
        Me.ProductLiveCheckBox.Text = "CheckBox1"
        Me.ProductLiveCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(719, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProEdir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(794, 472)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ProductLiveLabel)
        Me.Controls.Add(Me.ProductLiveCheckBox)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Savebtn)
        Me.Controls.Add(CategoryIDLabel)
        Me.Controls.Add(Me.CategoryIDTextBox)
        Me.Controls.Add(ProductSizeLabel)
        Me.Controls.Add(Me.ProductSizeComboBox)
        Me.Controls.Add(ProductColorLabel)
        Me.Controls.Add(Me.ProductColorTextBox)
        Me.Controls.Add(CategoryNameLabel)
        Me.Controls.Add(Me.CategoryNameComboBox)
        Me.Controls.Add(ProductIDLabel1)
        Me.Controls.Add(Me.ProductIDTextBox1)
        Me.Controls.Add(ProductIDLabel)
        Me.Controls.Add(Me.ProductIDTextBox)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProEdir"
        Me.Text = "ProEdir"
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _E_commerceDataSet As _E_commerceDataSet
    Friend WithEvents ProductTBBindingSource As BindingSource
    Friend WithEvents ProductTBTableAdapter As _E_commerceDataSetTableAdapters.ProductTBTableAdapter
    Friend WithEvents TableAdapterManager As _E_commerceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoryTBTableAdapter As _E_commerceDataSetTableAdapters.CategoryTBTableAdapter
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents ProductSkuTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents ProductPriceTextBox As TextBox
    Friend WithEvents ProductWeightTextBox As TextBox
    Friend WithEvents ProductDiscpTextBox As TextBox
    Friend WithEvents ProductStockTextBox As TextBox
    Friend WithEvents ProductImagePictureBox As PictureBox
    Friend WithEvents CategoryTBBindingSource As BindingSource
    Friend WithEvents CategoryIDTextBox As TextBox
    Friend WithEvents ProductSizeComboBox As ComboBox
    Friend WithEvents ProductColorTextBox As TextBox
    Friend WithEvents CategoryNameComboBox As ComboBox
    Friend WithEvents ProductIDTextBox1 As TextBox
    Friend WithEvents Deletebtn As Button
    Friend WithEvents Editbtn As Button
    Friend WithEvents Savebtn As Button
    Friend WithEvents ProductLiveCheckBox As CheckBox
    Friend WithEvents Button1 As Button
End Class
