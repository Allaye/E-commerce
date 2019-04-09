<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductEdit
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductEdit))
        Me.ProductTBDataGridView = New System.Windows.Forms.DataGridView()
        Me.Items = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Shopbtn = New System.Windows.Forms.Button()
        Me._E_commerceDataSet = New E_commerce._E_commerceDataSet()
        Me.ProductTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTBTableAdapter = New E_commerce._E_commerceDataSetTableAdapters.ProductTBTableAdapter()
        Me.TableAdapterManager = New E_commerce._E_commerceDataSetTableAdapters.TableAdapterManager()
        CType(Me.ProductTBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductTBDataGridView
        '
        Me.ProductTBDataGridView.AllowUserToDeleteRows = False
        Me.ProductTBDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ProductTBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductTBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Items})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductTBDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.ProductTBDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ProductTBDataGridView.Location = New System.Drawing.Point(12, 81)
        Me.ProductTBDataGridView.Name = "ProductTBDataGridView"
        Me.ProductTBDataGridView.ReadOnly = True
        Me.ProductTBDataGridView.RowTemplate.Height = 150
        Me.ProductTBDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductTBDataGridView.Size = New System.Drawing.Size(1397, 285)
        Me.ProductTBDataGridView.TabIndex = 1
        '
        'Items
        '
        Me.Items.HeaderText = ""
        Me.Items.Name = "Items"
        Me.Items.ReadOnly = True
        Me.Items.Text = "Edit"
        Me.Items.UseColumnTextForButtonValue = True
        '
        'Shopbtn
        '
        Me.Shopbtn.Location = New System.Drawing.Point(640, 392)
        Me.Shopbtn.Name = "Shopbtn"
        Me.Shopbtn.Size = New System.Drawing.Size(112, 23)
        Me.Shopbtn.TabIndex = 26
        Me.Shopbtn.Text = "Back To Shop"
        Me.Shopbtn.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.CategoryTBTableAdapter = Nothing
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
        'ProductEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1416, 521)
        Me.Controls.Add(Me.Shopbtn)
        Me.Controls.Add(Me.ProductTBDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProductEdit"
        Me.Text = "ProductEdit"
        CType(Me.ProductTBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _E_commerceDataSet As _E_commerceDataSet
    Friend WithEvents ProductTBBindingSource As BindingSource
    Friend WithEvents ProductTBTableAdapter As _E_commerceDataSetTableAdapters.ProductTBTableAdapter
    Friend WithEvents TableAdapterManager As _E_commerceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductTBDataGridView As DataGridView
    Friend WithEvents Shopbtn As Button
    Friend WithEvents Items As DataGridViewButtonColumn
End Class
