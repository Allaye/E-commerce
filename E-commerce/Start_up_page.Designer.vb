<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start_up_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start_up_page))
        Me.Customerbtn = New System.Windows.Forms.Button()
        Me.Vendorbtn = New System.Windows.Forms.Button()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Customerbtn
        '
        Me.Customerbtn.BackColor = System.Drawing.Color.CadetBlue
        Me.Customerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Customerbtn.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Customerbtn.Location = New System.Drawing.Point(340, 448)
        Me.Customerbtn.Name = "Customerbtn"
        Me.Customerbtn.Size = New System.Drawing.Size(117, 36)
        Me.Customerbtn.TabIndex = 11
        Me.Customerbtn.Text = "Customer"
        Me.Customerbtn.UseVisualStyleBackColor = False
        '
        'Vendorbtn
        '
        Me.Vendorbtn.BackColor = System.Drawing.Color.CadetBlue
        Me.Vendorbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Vendorbtn.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Vendorbtn.Location = New System.Drawing.Point(578, 448)
        Me.Vendorbtn.Name = "Vendorbtn"
        Me.Vendorbtn.Size = New System.Drawing.Size(125, 36)
        Me.Vendorbtn.TabIndex = 12
        Me.Vendorbtn.Text = "Vendor"
        Me.Vendorbtn.UseVisualStyleBackColor = False
        '
        'Exitbtn
        '
        Me.Exitbtn.BackColor = System.Drawing.Color.Red
        Me.Exitbtn.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Exitbtn.Location = New System.Drawing.Point(461, 490)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(117, 35)
        Me.Exitbtn.TabIndex = 13
        Me.Exitbtn.Text = "Exit"
        Me.Exitbtn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Bisque
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(938, 81)
        Me.Panel3.TabIndex = 48
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(849, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "About Us"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label24.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.MediumVioletRed
        Me.Label24.Location = New System.Drawing.Point(-2, -2)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(189, 50)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Magasin"
        '
        'Start_up_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(938, 579)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Exitbtn)
        Me.Controls.Add(Me.Vendorbtn)
        Me.Controls.Add(Me.Customerbtn)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximumSize = New System.Drawing.Size(956, 626)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "Start_up_page"
        Me.Text = "Start_up_page"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Customerbtn As Button
    Friend WithEvents Vendorbtn As Button
    Friend WithEvents Exitbtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Button1 As Button
End Class
