<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editsettingform
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
        Dim VendorIDLabel As System.Windows.Forms.Label
        Dim VendorFirstnameLabel As System.Windows.Forms.Label
        Dim VendorLastnameLabel As System.Windows.Forms.Label
        Dim StoreNameLabel As System.Windows.Forms.Label
        Dim VendorRegionLabel As System.Windows.Forms.Label
        Dim VendorPhoneLabel As System.Windows.Forms.Label
        Dim VendorEmailLabel As System.Windows.Forms.Label
        Dim VendorPasswordLabel As System.Windows.Forms.Label
        Dim VendorAddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editsettingform))
        Me._E_commerceDataSet = New E_commerce._E_commerceDataSet()
        Me.VendorTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorTBTableAdapter = New E_commerce._E_commerceDataSetTableAdapters.VendorTBTableAdapter()
        Me.TableAdapterManager = New E_commerce._E_commerceDataSetTableAdapters.TableAdapterManager()
        Me.VendorTBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorIDTextBox = New System.Windows.Forms.TextBox()
        Me.VendorFirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.VendorLastnameTextBox = New System.Windows.Forms.TextBox()
        Me.StoreNameTextBox = New System.Windows.Forms.TextBox()
        Me.VendorRegionTextBox = New System.Windows.Forms.TextBox()
        Me.VendorPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.VendorEmailTextBox = New System.Windows.Forms.TextBox()
        Me.VendorPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.VendorAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        VendorIDLabel = New System.Windows.Forms.Label()
        VendorFirstnameLabel = New System.Windows.Forms.Label()
        VendorLastnameLabel = New System.Windows.Forms.Label()
        StoreNameLabel = New System.Windows.Forms.Label()
        VendorRegionLabel = New System.Windows.Forms.Label()
        VendorPhoneLabel = New System.Windows.Forms.Label()
        VendorEmailLabel = New System.Windows.Forms.Label()
        VendorPasswordLabel = New System.Windows.Forms.Label()
        VendorAddressLabel = New System.Windows.Forms.Label()
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorTBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VendorIDLabel
        '
        VendorIDLabel.AutoSize = True
        VendorIDLabel.Location = New System.Drawing.Point(21, 58)
        VendorIDLabel.Name = "VendorIDLabel"
        VendorIDLabel.Size = New System.Drawing.Size(75, 17)
        VendorIDLabel.TabIndex = 2
        VendorIDLabel.Text = "Vendor ID:"
        '
        'VendorFirstnameLabel
        '
        VendorFirstnameLabel.AutoSize = True
        VendorFirstnameLabel.Location = New System.Drawing.Point(21, 86)
        VendorFirstnameLabel.Name = "VendorFirstnameLabel"
        VendorFirstnameLabel.Size = New System.Drawing.Size(124, 17)
        VendorFirstnameLabel.TabIndex = 4
        VendorFirstnameLabel.Text = "Vendor Firstname:"
        '
        'VendorLastnameLabel
        '
        VendorLastnameLabel.AutoSize = True
        VendorLastnameLabel.Location = New System.Drawing.Point(21, 114)
        VendorLastnameLabel.Name = "VendorLastnameLabel"
        VendorLastnameLabel.Size = New System.Drawing.Size(124, 17)
        VendorLastnameLabel.TabIndex = 6
        VendorLastnameLabel.Text = "Vendor Lastname:"
        '
        'StoreNameLabel
        '
        StoreNameLabel.AutoSize = True
        StoreNameLabel.Location = New System.Drawing.Point(21, 142)
        StoreNameLabel.Name = "StoreNameLabel"
        StoreNameLabel.Size = New System.Drawing.Size(87, 17)
        StoreNameLabel.TabIndex = 8
        StoreNameLabel.Text = "Store Name:"
        '
        'VendorRegionLabel
        '
        VendorRegionLabel.AutoSize = True
        VendorRegionLabel.Location = New System.Drawing.Point(21, 170)
        VendorRegionLabel.Name = "VendorRegionLabel"
        VendorRegionLabel.Size = New System.Drawing.Size(107, 17)
        VendorRegionLabel.TabIndex = 10
        VendorRegionLabel.Text = "Vendor Region:"
        '
        'VendorPhoneLabel
        '
        VendorPhoneLabel.AutoSize = True
        VendorPhoneLabel.Location = New System.Drawing.Point(21, 198)
        VendorPhoneLabel.Name = "VendorPhoneLabel"
        VendorPhoneLabel.Size = New System.Drawing.Size(103, 17)
        VendorPhoneLabel.TabIndex = 12
        VendorPhoneLabel.Text = "Vendor Phone:"
        '
        'VendorEmailLabel
        '
        VendorEmailLabel.AutoSize = True
        VendorEmailLabel.Location = New System.Drawing.Point(21, 226)
        VendorEmailLabel.Name = "VendorEmailLabel"
        VendorEmailLabel.Size = New System.Drawing.Size(96, 17)
        VendorEmailLabel.TabIndex = 14
        VendorEmailLabel.Text = "Vendor Email:"
        '
        'VendorPasswordLabel
        '
        VendorPasswordLabel.AutoSize = True
        VendorPasswordLabel.Location = New System.Drawing.Point(21, 254)
        VendorPasswordLabel.Name = "VendorPasswordLabel"
        VendorPasswordLabel.Size = New System.Drawing.Size(123, 17)
        VendorPasswordLabel.TabIndex = 16
        VendorPasswordLabel.Text = "Vendor Password:"
        '
        'VendorAddressLabel
        '
        VendorAddressLabel.AutoSize = True
        VendorAddressLabel.Location = New System.Drawing.Point(21, 282)
        VendorAddressLabel.Name = "VendorAddressLabel"
        VendorAddressLabel.Size = New System.Drawing.Size(114, 17)
        VendorAddressLabel.TabIndex = 18
        VendorAddressLabel.Text = "Vendor Address:"
        '
        '_E_commerceDataSet
        '
        Me._E_commerceDataSet.DataSetName = "_E_commerceDataSet"
        Me._E_commerceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendorTBBindingSource
        '
        Me.VendorTBBindingSource.DataMember = "VendorTB"
        Me.VendorTBBindingSource.DataSource = Me._E_commerceDataSet
        '
        'VendorTBTableAdapter
        '
        Me.VendorTBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTBTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTBTableAdapter = Nothing
        Me.TableAdapterManager.DetailsTBTableAdapter = Nothing
        Me.TableAdapterManager.OrderTBTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategoryTBTableAdapter = Nothing
        Me.TableAdapterManager.ProductOptionTBTableAdapter = Nothing
        Me.TableAdapterManager.ProductTBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = E_commerce._E_commerceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorTBTableAdapter = Me.VendorTBTableAdapter
        '
        'VendorTBDataGridView
        '
        Me.VendorTBDataGridView.AutoGenerateColumns = False
        Me.VendorTBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VendorTBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.VendorTBDataGridView.DataSource = Me.VendorTBBindingSource
        Me.VendorTBDataGridView.Location = New System.Drawing.Point(257, 58)
        Me.VendorTBDataGridView.Name = "VendorTBDataGridView"
        Me.VendorTBDataGridView.RowTemplate.Height = 24
        Me.VendorTBDataGridView.Size = New System.Drawing.Size(846, 100)
        Me.VendorTBDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "VendorFirstname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "VendorFirstname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "VendorLastname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "VendorLastname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "StoreName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "StoreName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "VendorRegion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "VendorRegion"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "VendorPhone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "VendorPhone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "VendorEmail"
        Me.DataGridViewTextBoxColumn7.HeaderText = "VendorEmail"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "VendorPassword"
        Me.DataGridViewTextBoxColumn8.HeaderText = "VendorPassword"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "VendorAddress"
        Me.DataGridViewTextBoxColumn9.HeaderText = "VendorAddress"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'VendorIDTextBox
        '
        Me.VendorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorID", True))
        Me.VendorIDTextBox.Enabled = False
        Me.VendorIDTextBox.Location = New System.Drawing.Point(151, 55)
        Me.VendorIDTextBox.Name = "VendorIDTextBox"
        Me.VendorIDTextBox.ReadOnly = True
        Me.VendorIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorIDTextBox.TabIndex = 3
        '
        'VendorFirstnameTextBox
        '
        Me.VendorFirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorFirstname", True))
        Me.VendorFirstnameTextBox.Location = New System.Drawing.Point(151, 83)
        Me.VendorFirstnameTextBox.Name = "VendorFirstnameTextBox"
        Me.VendorFirstnameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorFirstnameTextBox.TabIndex = 5
        '
        'VendorLastnameTextBox
        '
        Me.VendorLastnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorLastname", True))
        Me.VendorLastnameTextBox.Location = New System.Drawing.Point(151, 111)
        Me.VendorLastnameTextBox.Name = "VendorLastnameTextBox"
        Me.VendorLastnameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorLastnameTextBox.TabIndex = 7
        '
        'StoreNameTextBox
        '
        Me.StoreNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "StoreName", True))
        Me.StoreNameTextBox.Location = New System.Drawing.Point(151, 139)
        Me.StoreNameTextBox.Name = "StoreNameTextBox"
        Me.StoreNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StoreNameTextBox.TabIndex = 9
        '
        'VendorRegionTextBox
        '
        Me.VendorRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorRegion", True))
        Me.VendorRegionTextBox.Location = New System.Drawing.Point(151, 167)
        Me.VendorRegionTextBox.Name = "VendorRegionTextBox"
        Me.VendorRegionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorRegionTextBox.TabIndex = 11
        '
        'VendorPhoneTextBox
        '
        Me.VendorPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorPhone", True))
        Me.VendorPhoneTextBox.Location = New System.Drawing.Point(151, 195)
        Me.VendorPhoneTextBox.Name = "VendorPhoneTextBox"
        Me.VendorPhoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorPhoneTextBox.TabIndex = 13
        '
        'VendorEmailTextBox
        '
        Me.VendorEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorEmail", True))
        Me.VendorEmailTextBox.Location = New System.Drawing.Point(151, 223)
        Me.VendorEmailTextBox.Name = "VendorEmailTextBox"
        Me.VendorEmailTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorEmailTextBox.TabIndex = 15
        '
        'VendorPasswordTextBox
        '
        Me.VendorPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorPassword", True))
        Me.VendorPasswordTextBox.Location = New System.Drawing.Point(151, 251)
        Me.VendorPasswordTextBox.Name = "VendorPasswordTextBox"
        Me.VendorPasswordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorPasswordTextBox.TabIndex = 17
        '
        'VendorAddressTextBox
        '
        Me.VendorAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorAddress", True))
        Me.VendorAddressTextBox.Location = New System.Drawing.Point(151, 279)
        Me.VendorAddressTextBox.Name = "VendorAddressTextBox"
        Me.VendorAddressTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorAddressTextBox.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(289, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(404, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(973, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Back To Shop"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'editsettingform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1117, 330)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(VendorIDLabel)
        Me.Controls.Add(Me.VendorIDTextBox)
        Me.Controls.Add(VendorFirstnameLabel)
        Me.Controls.Add(Me.VendorFirstnameTextBox)
        Me.Controls.Add(VendorLastnameLabel)
        Me.Controls.Add(Me.VendorLastnameTextBox)
        Me.Controls.Add(StoreNameLabel)
        Me.Controls.Add(Me.StoreNameTextBox)
        Me.Controls.Add(VendorRegionLabel)
        Me.Controls.Add(Me.VendorRegionTextBox)
        Me.Controls.Add(VendorPhoneLabel)
        Me.Controls.Add(Me.VendorPhoneTextBox)
        Me.Controls.Add(VendorEmailLabel)
        Me.Controls.Add(Me.VendorEmailTextBox)
        Me.Controls.Add(VendorPasswordLabel)
        Me.Controls.Add(Me.VendorPasswordTextBox)
        Me.Controls.Add(VendorAddressLabel)
        Me.Controls.Add(Me.VendorAddressTextBox)
        Me.Controls.Add(Me.VendorTBDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "editsettingform"
        Me.Text = "Settings"
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorTBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _E_commerceDataSet As _E_commerceDataSet
    Friend WithEvents VendorTBBindingSource As BindingSource
    Friend WithEvents VendorTBTableAdapter As _E_commerceDataSetTableAdapters.VendorTBTableAdapter
    Friend WithEvents TableAdapterManager As _E_commerceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VendorTBDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents VendorIDTextBox As TextBox
    Friend WithEvents VendorFirstnameTextBox As TextBox
    Friend WithEvents VendorLastnameTextBox As TextBox
    Friend WithEvents StoreNameTextBox As TextBox
    Friend WithEvents VendorRegionTextBox As TextBox
    Friend WithEvents VendorPhoneTextBox As TextBox
    Friend WithEvents VendorEmailTextBox As TextBox
    Friend WithEvents VendorPasswordTextBox As TextBox
    Friend WithEvents VendorAddressTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
