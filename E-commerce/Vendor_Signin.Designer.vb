<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendor_Signin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vendor_Signin))
        Me.VendorPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.VendorTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._E_commerceDataSet = New E_commerce._E_commerceDataSet()
        Me.VendorIDTextBox = New System.Windows.Forms.TextBox()
        Me.signupbtn = New System.Windows.Forms.Button()
        Me.vendorloginbtn = New System.Windows.Forms.Button()
        Me.VendorTBTableAdapter = New E_commerce._E_commerceDataSetTableAdapters.VendorTBTableAdapter()
        Me.TableAdapterManager = New E_commerce._E_commerceDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.passwordlbl = New System.Windows.Forms.Label()
        Me.usernamelbl = New System.Windows.Forms.Label()
        CType(Me.VendorTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VendorPasswordTextBox
        '
        Me.VendorPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorPassword", True))
        Me.VendorPasswordTextBox.Location = New System.Drawing.Point(235, 176)
        Me.VendorPasswordTextBox.Name = "VendorPasswordTextBox"
        Me.VendorPasswordTextBox.Size = New System.Drawing.Size(189, 22)
        Me.VendorPasswordTextBox.TabIndex = 11
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
        'VendorIDTextBox
        '
        Me.VendorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendorTBBindingSource, "VendorID", True))
        Me.VendorIDTextBox.Location = New System.Drawing.Point(235, 104)
        Me.VendorIDTextBox.Name = "VendorIDTextBox"
        Me.VendorIDTextBox.Size = New System.Drawing.Size(189, 22)
        Me.VendorIDTextBox.TabIndex = 10
        '
        'signupbtn
        '
        Me.signupbtn.BackColor = System.Drawing.Color.Cyan
        Me.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signupbtn.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.signupbtn.Location = New System.Drawing.Point(344, 225)
        Me.signupbtn.Name = "signupbtn"
        Me.signupbtn.Size = New System.Drawing.Size(111, 41)
        Me.signupbtn.TabIndex = 9
        Me.signupbtn.Text = "SIGNUP"
        Me.signupbtn.UseVisualStyleBackColor = False
        '
        'vendorloginbtn
        '
        Me.vendorloginbtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.vendorloginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vendorloginbtn.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.vendorloginbtn.Location = New System.Drawing.Point(179, 225)
        Me.vendorloginbtn.Name = "vendorloginbtn"
        Me.vendorloginbtn.Size = New System.Drawing.Size(122, 41)
        Me.vendorloginbtn.TabIndex = 8
        Me.vendorloginbtn.Text = "LOGIN"
        Me.vendorloginbtn.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 123)
        Me.Panel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(911, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 61)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VENDOR SIGN-IN"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.VendorPasswordTextBox)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.VendorIDTextBox)
        Me.GroupBox2.Controls.Add(Me.signupbtn)
        Me.GroupBox2.Controls.Add(Me.vendorloginbtn)
        Me.GroupBox2.Controls.Add(Me.passwordlbl)
        Me.GroupBox2.Controls.Add(Me.usernamelbl)
        Me.GroupBox2.Location = New System.Drawing.Point(185, 204)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(603, 295)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Authentication"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(179, 160)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(183, 87)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'passwordlbl
        '
        Me.passwordlbl.AutoSize = True
        Me.passwordlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordlbl.Location = New System.Drawing.Point(297, 142)
        Me.passwordlbl.Name = "passwordlbl"
        Me.passwordlbl.Size = New System.Drawing.Size(83, 20)
        Me.passwordlbl.TabIndex = 5
        Me.passwordlbl.Text = "Password"
        '
        'usernamelbl
        '
        Me.usernamelbl.AutoSize = True
        Me.usernamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelbl.Location = New System.Drawing.Point(271, 62)
        Me.usernamelbl.Name = "usernamelbl"
        Me.usernamelbl.Size = New System.Drawing.Size(153, 20)
        Me.usernamelbl.TabIndex = 4
        Me.usernamelbl.Text = "Username or Email"
        '
        'Vendor_Signin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 528)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(999, 575)
        Me.MinimumSize = New System.Drawing.Size(800, 575)
        Me.Name = "Vendor_Signin"
        Me.Text = "Vendor_Signin"
        CType(Me.VendorTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vendorloginbtn As Button
    Friend WithEvents signupbtn As Button
    Friend WithEvents _E_commerceDataSet As _E_commerceDataSet
    Friend WithEvents VendorTBBindingSource As BindingSource
    Friend WithEvents VendorTBTableAdapter As _E_commerceDataSetTableAdapters.VendorTBTableAdapter
    Friend WithEvents TableAdapterManager As _E_commerceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VendorPasswordTextBox As TextBox
    Friend WithEvents VendorIDTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents passwordlbl As Label
    Friend WithEvents usernamelbl As Label
    Friend WithEvents Button1 As Button
End Class
