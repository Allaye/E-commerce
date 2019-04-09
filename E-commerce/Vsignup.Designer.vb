<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vsignup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vsignup))
        Dim VendorIDLabel As System.Windows.Forms.Label
        Dim VendorFirstnameLabel As System.Windows.Forms.Label
        Dim VendorLastnameLabel As System.Windows.Forms.Label
        Dim StoreNameLabel As System.Windows.Forms.Label
        Dim VendorRegionLabel As System.Windows.Forms.Label
        Dim VendorPhoneLabel As System.Windows.Forms.Label
        Dim VendorEmailLabel As System.Windows.Forms.Label
        Dim VendorPasswordLabel As System.Windows.Forms.Label
        Dim VendorAddressLabel As System.Windows.Forms.Label
        Me._E_commerceDataSet = New E_commerce._E_commerceDataSet()
        Me.VendorTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorTBTableAdapter = New E_commerce._E_commerceDataSetTableAdapters.VendorTBTableAdapter()
        Me.TableAdapterManager = New E_commerce._E_commerceDataSetTableAdapters.TableAdapterManager()
        Me.VendorTBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.VendorTBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
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
        CType(Me.VendorTBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VendorTBBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.ProductCategoryTBTableAdapter = Nothing
        Me.TableAdapterManager.ProductOptionTBTableAdapter = Nothing
        Me.TableAdapterManager.ProductTBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = E_commerce._E_commerceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorTBTableAdapter = Me.VendorTBTableAdapter
        '
        'VendorTBBindingNavigator
        '
        Me.VendorTBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VendorTBBindingNavigator.BindingSource = Me.VendorTBBindingSource
        Me.VendorTBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VendorTBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VendorTBBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.VendorTBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VendorTBBindingNavigatorSaveItem})
        Me.VendorTBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VendorTBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VendorTBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VendorTBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VendorTBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VendorTBBindingNavigator.Name = "VendorTBBindingNavigator"
        Me.VendorTBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VendorTBBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.VendorTBBindingNavigator.TabIndex = 0
        Me.VendorTBBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 20)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'VendorTBBindingNavigatorSaveItem
        '
        Me.VendorTBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VendorTBBindingNavigatorSaveItem.Image = CType(resources.GetObject("VendorTBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VendorTBBindingNavigatorSaveItem.Name = "VendorTBBindingNavigatorSaveItem"
        Me.VendorTBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.VendorTBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'VendorIDLabel
        '
        VendorIDLabel.AutoSize = True
        VendorIDLabel.Location = New System.Drawing.Point(265, 64)
        VendorIDLabel.Name = "VendorIDLabel"
        VendorIDLabel.Size = New System.Drawing.Size(75, 17)
        VendorIDLabel.TabIndex = 1
        VendorIDLabel.Text = "Vendor ID:"
        '
        'VendorIDTextBox
        '
        Me.VendorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorID", True))
        Me.VendorIDTextBox.Location = New System.Drawing.Point(395, 61)
        Me.VendorIDTextBox.Name = "VendorIDTextBox"
        Me.VendorIDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorIDTextBox.TabIndex = 2
        '
        'VendorFirstnameLabel
        '
        VendorFirstnameLabel.AutoSize = True
        VendorFirstnameLabel.Location = New System.Drawing.Point(265, 92)
        VendorFirstnameLabel.Name = "VendorFirstnameLabel"
        VendorFirstnameLabel.Size = New System.Drawing.Size(124, 17)
        VendorFirstnameLabel.TabIndex = 3
        VendorFirstnameLabel.Text = "Vendor Firstname:"
        '
        'VendorFirstnameTextBox
        '
        Me.VendorFirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorFirstname", True))
        Me.VendorFirstnameTextBox.Location = New System.Drawing.Point(395, 89)
        Me.VendorFirstnameTextBox.Name = "VendorFirstnameTextBox"
        Me.VendorFirstnameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorFirstnameTextBox.TabIndex = 4
        '
        'VendorLastnameLabel
        '
        VendorLastnameLabel.AutoSize = True
        VendorLastnameLabel.Location = New System.Drawing.Point(265, 120)
        VendorLastnameLabel.Name = "VendorLastnameLabel"
        VendorLastnameLabel.Size = New System.Drawing.Size(124, 17)
        VendorLastnameLabel.TabIndex = 5
        VendorLastnameLabel.Text = "Vendor Lastname:"
        '
        'VendorLastnameTextBox
        '
        Me.VendorLastnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorLastname", True))
        Me.VendorLastnameTextBox.Location = New System.Drawing.Point(395, 117)
        Me.VendorLastnameTextBox.Name = "VendorLastnameTextBox"
        Me.VendorLastnameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorLastnameTextBox.TabIndex = 6
        '
        'StoreNameLabel
        '
        StoreNameLabel.AutoSize = True
        StoreNameLabel.Location = New System.Drawing.Point(265, 148)
        StoreNameLabel.Name = "StoreNameLabel"
        StoreNameLabel.Size = New System.Drawing.Size(87, 17)
        StoreNameLabel.TabIndex = 7
        StoreNameLabel.Text = "Store Name:"
        '
        'StoreNameTextBox
        '
        Me.StoreNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "StoreName", True))
        Me.StoreNameTextBox.Location = New System.Drawing.Point(395, 145)
        Me.StoreNameTextBox.Name = "StoreNameTextBox"
        Me.StoreNameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StoreNameTextBox.TabIndex = 8
        '
        'VendorRegionLabel
        '
        VendorRegionLabel.AutoSize = True
        VendorRegionLabel.Location = New System.Drawing.Point(265, 176)
        VendorRegionLabel.Name = "VendorRegionLabel"
        VendorRegionLabel.Size = New System.Drawing.Size(107, 17)
        VendorRegionLabel.TabIndex = 9
        VendorRegionLabel.Text = "Vendor Region:"
        '
        'VendorRegionTextBox
        '
        Me.VendorRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorRegion", True))
        Me.VendorRegionTextBox.Location = New System.Drawing.Point(395, 173)
        Me.VendorRegionTextBox.Name = "VendorRegionTextBox"
        Me.VendorRegionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorRegionTextBox.TabIndex = 10
        '
        'VendorPhoneLabel
        '
        VendorPhoneLabel.AutoSize = True
        VendorPhoneLabel.Location = New System.Drawing.Point(265, 204)
        VendorPhoneLabel.Name = "VendorPhoneLabel"
        VendorPhoneLabel.Size = New System.Drawing.Size(103, 17)
        VendorPhoneLabel.TabIndex = 11
        VendorPhoneLabel.Text = "Vendor Phone:"
        '
        'VendorPhoneTextBox
        '
        Me.VendorPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorPhone", True))
        Me.VendorPhoneTextBox.Location = New System.Drawing.Point(395, 201)
        Me.VendorPhoneTextBox.Name = "VendorPhoneTextBox"
        Me.VendorPhoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorPhoneTextBox.TabIndex = 12
        '
        'VendorEmailLabel
        '
        VendorEmailLabel.AutoSize = True
        VendorEmailLabel.Location = New System.Drawing.Point(265, 232)
        VendorEmailLabel.Name = "VendorEmailLabel"
        VendorEmailLabel.Size = New System.Drawing.Size(96, 17)
        VendorEmailLabel.TabIndex = 13
        VendorEmailLabel.Text = "Vendor Email:"
        '
        'VendorEmailTextBox
        '
        Me.VendorEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorEmail", True))
        Me.VendorEmailTextBox.Location = New System.Drawing.Point(395, 229)
        Me.VendorEmailTextBox.Name = "VendorEmailTextBox"
        Me.VendorEmailTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorEmailTextBox.TabIndex = 14
        '
        'VendorPasswordLabel
        '
        VendorPasswordLabel.AutoSize = True
        VendorPasswordLabel.Location = New System.Drawing.Point(265, 260)
        VendorPasswordLabel.Name = "VendorPasswordLabel"
        VendorPasswordLabel.Size = New System.Drawing.Size(123, 17)
        VendorPasswordLabel.TabIndex = 15
        VendorPasswordLabel.Text = "Vendor Password:"
        '
        'VendorPasswordTextBox
        '
        Me.VendorPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorPassword", True))
        Me.VendorPasswordTextBox.Location = New System.Drawing.Point(395, 257)
        Me.VendorPasswordTextBox.Name = "VendorPasswordTextBox"
        Me.VendorPasswordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorPasswordTextBox.TabIndex = 16
        '
        'VendorAddressLabel
        '
        VendorAddressLabel.AutoSize = True
        VendorAddressLabel.Location = New System.Drawing.Point(265, 288)
        VendorAddressLabel.Name = "VendorAddressLabel"
        VendorAddressLabel.Size = New System.Drawing.Size(114, 17)
        VendorAddressLabel.TabIndex = 17
        VendorAddressLabel.Text = "Vendor Address:"
        '
        'VendorAddressTextBox
        '
        Me.VendorAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorAddress", True))
        Me.VendorAddressTextBox.Location = New System.Drawing.Point(395, 285)
        Me.VendorAddressTextBox.Name = "VendorAddressTextBox"
        Me.VendorAddressTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VendorAddressTextBox.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(409, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Vsignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
        Me.Controls.Add(Me.VendorTBBindingNavigator)
        Me.Name = "Vsignup"
        Me.Text = "Vsignup"
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorTBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VendorTBBindingNavigator.ResumeLayout(False)
        Me.VendorTBBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _E_commerceDataSet As _E_commerceDataSet
    Friend WithEvents VendorTBBindingSource As BindingSource
    Friend WithEvents VendorTBTableAdapter As _E_commerceDataSetTableAdapters.VendorTBTableAdapter
    Friend WithEvents TableAdapterManager As _E_commerceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VendorTBBindingNavigator As BindingNavigator
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
    Friend WithEvents VendorTBBindingNavigatorSaveItem As ToolStripButton
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
End Class
