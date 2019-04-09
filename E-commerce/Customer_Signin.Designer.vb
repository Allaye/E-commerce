<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customersignin
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
        Dim CustomerPasswordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customersignin))
        Me.poweredlbl = New System.Windows.Forms.Label()
        Me.CustomerPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._E_commerceDataSet = New E_commerce._E_commerceDataSet()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.signupbtn = New System.Windows.Forms.Button()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.CustomerTBTableAdapter = New E_commerce._E_commerceDataSetTableAdapters.CustomerTBTableAdapter()
        Me.TableAdapterManager = New E_commerce._E_commerceDataSetTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.usernamelbl = New System.Windows.Forms.Label()
        CustomerPasswordLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerPasswordLabel
        '
        CustomerPasswordLabel.AutoSize = True
        CustomerPasswordLabel.Location = New System.Drawing.Point(237, 176)
        CustomerPasswordLabel.Name = "CustomerPasswordLabel"
        CustomerPasswordLabel.Size = New System.Drawing.Size(93, 20)
        CustomerPasswordLabel.TabIndex = 6
        CustomerPasswordLabel.Text = " Password:"
        '
        'poweredlbl
        '
        Me.poweredlbl.AutoSize = True
        Me.poweredlbl.Location = New System.Drawing.Point(832, 552)
        Me.poweredlbl.Name = "poweredlbl"
        Me.poweredlbl.Size = New System.Drawing.Size(171, 17)
        Me.poweredlbl.TabIndex = 1
        Me.poweredlbl.Text = "Powered by MicrosoftSQL"
        '
        'CustomerPasswordTextBox
        '
        Me.CustomerPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTBBindingSource, "CustomerPassword", True))
        Me.CustomerPasswordTextBox.Location = New System.Drawing.Point(232, 199)
        Me.CustomerPasswordTextBox.Name = "CustomerPasswordTextBox"
        Me.CustomerPasswordTextBox.Size = New System.Drawing.Size(164, 26)
        Me.CustomerPasswordTextBox.TabIndex = 7
        '
        'CustomerTBBindingSource
        '
        Me.CustomerTBBindingSource.DataMember = "CustomerTB"
        Me.CustomerTBBindingSource.DataSource = Me._E_commerceDataSet
        '
        '_E_commerceDataSet
        '
        Me._E_commerceDataSet.DataSetName = "_E_commerceDataSet"
        Me._E_commerceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerTBBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(232, 135)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(164, 26)
        Me.CustomerIDTextBox.TabIndex = 6
        '
        'signupbtn
        '
        Me.signupbtn.BackColor = System.Drawing.Color.DarkTurquoise
        Me.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signupbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.signupbtn.Location = New System.Drawing.Point(281, 252)
        Me.signupbtn.Name = "signupbtn"
        Me.signupbtn.Size = New System.Drawing.Size(168, 42)
        Me.signupbtn.TabIndex = 5
        Me.signupbtn.Text = "SIGNUP"
        Me.signupbtn.UseVisualStyleBackColor = False
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.DodgerBlue
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.loginbtn.Location = New System.Drawing.Point(99, 252)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(145, 42)
        Me.loginbtn.TabIndex = 4
        Me.loginbtn.Text = "LOGIN"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'CustomerTBTableAdapter
        '
        Me.CustomerTBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoryTBTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTBTableAdapter = Me.CustomerTBTableAdapter
        Me.TableAdapterManager.DetailsTBTableAdapter = Nothing
        Me.TableAdapterManager.OrderTBTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategoryTableAdapter = Nothing
        Me.TableAdapterManager.ProductCategoryTBTableAdapter = Nothing
        Me.TableAdapterManager.ProductOptionTBTableAdapter = Nothing
        Me.TableAdapterManager.ProductTBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = E_commerce._E_commerceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VendorTBTableAdapter = Nothing
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
        Me.Panel2.Size = New System.Drawing.Size(1018, 72)
        Me.Panel2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(940, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 66)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "CUSTOMER SIGN-IN"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(CustomerPasswordLabel)
        Me.GroupBox1.Controls.Add(Me.signupbtn)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.loginbtn)
        Me.GroupBox1.Controls.Add(Me.CustomerPasswordTextBox)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.CustomerIDTextBox)
        Me.GroupBox1.Controls.Add(Me.usernamelbl)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(226, 105)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(533, 373)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Authentication"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(131, 187)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(135, 115)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'usernamelbl
        '
        Me.usernamelbl.AutoSize = True
        Me.usernamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernamelbl.Location = New System.Drawing.Point(237, 112)
        Me.usernamelbl.Name = "usernamelbl"
        Me.usernamelbl.Size = New System.Drawing.Size(153, 20)
        Me.usernamelbl.TabIndex = 3
        Me.usernamelbl.Text = "Username or Email"
        '
        'Customersignin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1018, 568)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.poweredlbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Customersignin"
        Me.Text = "Customer Sign_in"
        CType(Me.CustomerTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._E_commerceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents poweredlbl As Label
    Friend WithEvents signupbtn As Button
    Friend WithEvents loginbtn As Button
    Friend WithEvents _E_commerceDataSet As _E_commerceDataSet
    Friend WithEvents CustomerTBBindingSource As BindingSource
    Friend WithEvents CustomerTBTableAdapter As _E_commerceDataSetTableAdapters.CustomerTBTableAdapter
    Friend WithEvents TableAdapterManager As _E_commerceDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerPasswordTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents usernamelbl As Label
    Friend WithEvents Button1 As Button
    Public WithEvents CustomerIDTextBox As TextBox
End Class
