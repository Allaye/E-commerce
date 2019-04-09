<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vendorsignup
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
        Dim VendorIDLabel As System.Windows.Forms.Label
        Dim VendorFirstnameLabel As System.Windows.Forms.Label
        Dim VendorLastnameLabel As System.Windows.Forms.Label
        Dim StoreNameLabel As System.Windows.Forms.Label
        Dim VendorRegionLabel As System.Windows.Forms.Label
        Dim VendorPhoneLabel As System.Windows.Forms.Label
        Dim VendorEmailLabel As System.Windows.Forms.Label
        Dim VendorPasswordLabel As System.Windows.Forms.Label
        Dim VendorAddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vendorsignup))
        Me.VendorIDTextBox = New System.Windows.Forms.TextBox()
        Me.VendorTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._E_commerceDataSet = New E_commerce._E_commerceDataSet()
        Me.VendorFirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.VendorLastnameTextBox = New System.Windows.Forms.TextBox()
        Me.StoreNameTextBox = New System.Windows.Forms.TextBox()
        Me.VendorRegionTextBox = New System.Windows.Forms.TextBox()
        Me.VendorPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.VendorEmailTextBox = New System.Windows.Forms.TextBox()
        Me.VendorPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.VendorAddressTextBox = New System.Windows.Forms.TextBox()
        Me.vendorsignupbtn = New System.Windows.Forms.Button()
        Me.VendorTBTableAdapter = New E_commerce._E_commerceDataSetTableAdapters.VendorTBTableAdapter()
        Me.TableAdapterManager = New E_commerce._E_commerceDataSetTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        VendorIDLabel = New System.Windows.Forms.Label()
        VendorFirstnameLabel = New System.Windows.Forms.Label()
        VendorLastnameLabel = New System.Windows.Forms.Label()
        StoreNameLabel = New System.Windows.Forms.Label()
        VendorRegionLabel = New System.Windows.Forms.Label()
        VendorPhoneLabel = New System.Windows.Forms.Label()
        VendorEmailLabel = New System.Windows.Forms.Label()
        VendorPasswordLabel = New System.Windows.Forms.Label()
        VendorAddressLabel = New System.Windows.Forms.Label()
        CType(Me.VendorTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'VendorIDLabel
        '
        VendorIDLabel.AutoSize = True
        VendorIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VendorIDLabel.Location = New System.Drawing.Point(91, 55)
        VendorIDLabel.Name = "VendorIDLabel"
        VendorIDLabel.Size = New System.Drawing.Size(106, 25)
        VendorIDLabel.TabIndex = 18
        VendorIDLabel.Text = "Vendor ID:"
        '
        'VendorFirstnameLabel
        '
        VendorFirstnameLabel.AutoSize = True
        VendorFirstnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VendorFirstnameLabel.Location = New System.Drawing.Point(91, 82)
        VendorFirstnameLabel.Name = "VendorFirstnameLabel"
        VendorFirstnameLabel.Size = New System.Drawing.Size(173, 25)
        VendorFirstnameLabel.TabIndex = 20
        VendorFirstnameLabel.Text = "Vendor Firstname:"
        '
        'VendorLastnameLabel
        '
        VendorLastnameLabel.AutoSize = True
        VendorLastnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VendorLastnameLabel.Location = New System.Drawing.Point(91, 110)
        VendorLastnameLabel.Name = "VendorLastnameLabel"
        VendorLastnameLabel.Size = New System.Drawing.Size(173, 25)
        VendorLastnameLabel.TabIndex = 22
        VendorLastnameLabel.Text = "Vendor Lastname:"
        '
        'StoreNameLabel
        '
        StoreNameLabel.AutoSize = True
        StoreNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StoreNameLabel.Location = New System.Drawing.Point(91, 138)
        StoreNameLabel.Name = "StoreNameLabel"
        StoreNameLabel.Size = New System.Drawing.Size(122, 25)
        StoreNameLabel.TabIndex = 24
        StoreNameLabel.Text = "Store Name:"
        '
        'VendorRegionLabel
        '
        VendorRegionLabel.AutoSize = True
        VendorRegionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VendorRegionLabel.Location = New System.Drawing.Point(91, 166)
        VendorRegionLabel.Name = "VendorRegionLabel"
        VendorRegionLabel.Size = New System.Drawing.Size(148, 25)
        VendorRegionLabel.TabIndex = 26
        VendorRegionLabel.Text = "Vendor Region:"
        '
        'VendorPhoneLabel
        '
        VendorPhoneLabel.AutoSize = True
        VendorPhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VendorPhoneLabel.Location = New System.Drawing.Point(91, 194)
        VendorPhoneLabel.Name = "VendorPhoneLabel"
        VendorPhoneLabel.Size = New System.Drawing.Size(144, 25)
        VendorPhoneLabel.TabIndex = 28
        VendorPhoneLabel.Text = "Vendor Phone:"
        '
        'VendorEmailLabel
        '
        VendorEmailLabel.AutoSize = True
        VendorEmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VendorEmailLabel.Location = New System.Drawing.Point(91, 222)
        VendorEmailLabel.Name = "VendorEmailLabel"
        VendorEmailLabel.Size = New System.Drawing.Size(135, 25)
        VendorEmailLabel.TabIndex = 30
        VendorEmailLabel.Text = "Vendor Email:"
        '
        'VendorPasswordLabel
        '
        VendorPasswordLabel.AutoSize = True
        VendorPasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VendorPasswordLabel.Location = New System.Drawing.Point(91, 250)
        VendorPasswordLabel.Name = "VendorPasswordLabel"
        VendorPasswordLabel.Size = New System.Drawing.Size(173, 25)
        VendorPasswordLabel.TabIndex = 32
        VendorPasswordLabel.Text = "Vendor Password:"
        '
        'VendorAddressLabel
        '
        VendorAddressLabel.AutoSize = True
        VendorAddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VendorAddressLabel.Location = New System.Drawing.Point(91, 278)
        VendorAddressLabel.Name = "VendorAddressLabel"
        VendorAddressLabel.Size = New System.Drawing.Size(160, 25)
        VendorAddressLabel.TabIndex = 34
        VendorAddressLabel.Text = "Vendor Address:"
        '
        'VendorIDTextBox
        '
        Me.VendorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorID", True))
        Me.VendorIDTextBox.Location = New System.Drawing.Point(280, 59)
        Me.VendorIDTextBox.Name = "VendorIDTextBox"
        Me.VendorIDTextBox.Size = New System.Drawing.Size(228, 22)
        Me.VendorIDTextBox.TabIndex = 19
        '
        'VendorTBBindingSource
        '
        Me.VendorTBBindingSource.DataMember = "VendorTB"
        Me.VendorTBBindingSource.DataSource = Me._E_commerceDataSet
        '
        '_E_commerceDataSet
        '
        Me._E_commerceDataSet.DataSetName = "_E_commerceDataSet"
        Me._E_commerceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendorFirstnameTextBox
        '
        Me.VendorFirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorFirstname", True))
        Me.VendorFirstnameTextBox.Location = New System.Drawing.Point(280, 86)
        Me.VendorFirstnameTextBox.Name = "VendorFirstnameTextBox"
        Me.VendorFirstnameTextBox.Size = New System.Drawing.Size(228, 22)
        Me.VendorFirstnameTextBox.TabIndex = 21
        '
        'VendorLastnameTextBox
        '
        Me.VendorLastnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorLastname", True))
        Me.VendorLastnameTextBox.Location = New System.Drawing.Point(280, 114)
        Me.VendorLastnameTextBox.Name = "VendorLastnameTextBox"
        Me.VendorLastnameTextBox.Size = New System.Drawing.Size(228, 22)
        Me.VendorLastnameTextBox.TabIndex = 23
        '
        'StoreNameTextBox
        '
        Me.StoreNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "StoreName", True))
        Me.StoreNameTextBox.Location = New System.Drawing.Point(280, 142)
        Me.StoreNameTextBox.Name = "StoreNameTextBox"
        Me.StoreNameTextBox.Size = New System.Drawing.Size(228, 22)
        Me.StoreNameTextBox.TabIndex = 25
        '
        'VendorRegionTextBox
        '
        Me.VendorRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorRegion", True))
        Me.VendorRegionTextBox.Location = New System.Drawing.Point(280, 170)
        Me.VendorRegionTextBox.Name = "VendorRegionTextBox"
        Me.VendorRegionTextBox.Size = New System.Drawing.Size(228, 22)
        Me.VendorRegionTextBox.TabIndex = 27
        '
        'VendorPhoneTextBox
        '
        Me.VendorPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorPhone", True))
        Me.VendorPhoneTextBox.Location = New System.Drawing.Point(280, 198)
        Me.VendorPhoneTextBox.Name = "VendorPhoneTextBox"
        Me.VendorPhoneTextBox.Size = New System.Drawing.Size(228, 22)
        Me.VendorPhoneTextBox.TabIndex = 29
        '
        'VendorEmailTextBox
        '
        Me.VendorEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorEmail", True))
        Me.VendorEmailTextBox.Location = New System.Drawing.Point(280, 226)
        Me.VendorEmailTextBox.Name = "VendorEmailTextBox"
        Me.VendorEmailTextBox.Size = New System.Drawing.Size(228, 22)
        Me.VendorEmailTextBox.TabIndex = 31
        '
        'VendorPasswordTextBox
        '
        Me.VendorPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorPassword", True))
        Me.VendorPasswordTextBox.Location = New System.Drawing.Point(280, 254)
        Me.VendorPasswordTextBox.Name = "VendorPasswordTextBox"
        Me.VendorPasswordTextBox.Size = New System.Drawing.Size(228, 22)
        Me.VendorPasswordTextBox.TabIndex = 33
        '
        'VendorAddressTextBox
        '
        Me.VendorAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorAddress", True))
        Me.VendorAddressTextBox.Location = New System.Drawing.Point(280, 282)
        Me.VendorAddressTextBox.Name = "VendorAddressTextBox"
        Me.VendorAddressTextBox.Size = New System.Drawing.Size(228, 22)
        Me.VendorAddressTextBox.TabIndex = 35
        '
        'vendorsignupbtn
        '
        Me.vendorsignupbtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.vendorsignupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vendorsignupbtn.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.vendorsignupbtn.Location = New System.Drawing.Point(203, 345)
        Me.vendorsignupbtn.Name = "vendorsignupbtn"
        Me.vendorsignupbtn.Size = New System.Drawing.Size(130, 47)
        Me.vendorsignupbtn.TabIndex = 18
        Me.vendorsignupbtn.Text = "SIGNUP"
        Me.vendorsignupbtn.UseVisualStyleBackColor = False
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1028, 123)
        Me.Panel2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(958, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 61)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(365, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "VENDOR SIGN-UP"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel3.Controls.Add(VendorIDLabel)
        Me.Panel3.Controls.Add(Me.VendorIDTextBox)
        Me.Panel3.Controls.Add(Me.vendorsignupbtn)
        Me.Panel3.Controls.Add(VendorFirstnameLabel)
        Me.Panel3.Controls.Add(VendorPhoneLabel)
        Me.Panel3.Controls.Add(Me.VendorFirstnameTextBox)
        Me.Panel3.Controls.Add(Me.VendorAddressTextBox)
        Me.Panel3.Controls.Add(VendorLastnameLabel)
        Me.Panel3.Controls.Add(VendorAddressLabel)
        Me.Panel3.Controls.Add(Me.VendorLastnameTextBox)
        Me.Panel3.Controls.Add(Me.VendorPasswordTextBox)
        Me.Panel3.Controls.Add(StoreNameLabel)
        Me.Panel3.Controls.Add(VendorPasswordLabel)
        Me.Panel3.Controls.Add(Me.StoreNameTextBox)
        Me.Panel3.Controls.Add(Me.VendorEmailTextBox)
        Me.Panel3.Controls.Add(VendorRegionLabel)
        Me.Panel3.Controls.Add(VendorEmailLabel)
        Me.Panel3.Controls.Add(Me.VendorRegionTextBox)
        Me.Panel3.Controls.Add(Me.VendorPhoneTextBox)
        Me.Panel3.Location = New System.Drawing.Point(286, 190)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(540, 418)
        Me.Panel3.TabIndex = 4
        '
        'vendorsignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 636)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "vendorsignup"
        Me.Text = "Vendor_Signup"
        CType(Me.VendorTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _E_commerceDataSet As _E_commerceDataSet
    Friend WithEvents VendorTBBindingSource As BindingSource
    Friend WithEvents VendorTBTableAdapter As _E_commerceDataSetTableAdapters.VendorTBTableAdapter
    Friend WithEvents TableAdapterManager As _E_commerceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents vendorsignupbtn As Button
    Friend WithEvents VendorIDTextBox As TextBox
    Friend WithEvents VendorFirstnameTextBox As TextBox
    Friend WithEvents VendorLastnameTextBox As TextBox
    Friend WithEvents StoreNameTextBox As TextBox
    Friend WithEvents VendorRegionTextBox As TextBox
    Friend WithEvents VendorPhoneTextBox As TextBox
    Friend WithEvents VendorEmailTextBox As TextBox
    Friend WithEvents VendorPasswordTextBox As TextBox
    Friend WithEvents VendorAddressTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
End Class
