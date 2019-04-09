Public Class customersignup
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_E_commerceDataSet.CustomerTB' table. You can move, or remove it, as needed.
        ' Me.CustomerTBTableAdapter.Fill(Me._E_commerceDataSet.CustomerTB)
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
    End Sub

    Private Sub Signin_Click(sender As Object, e As EventArgs)
        Dim cussignin = New Customersignin()
        cussignin.Show()
        Me.Hide()

    End Sub

    Private Sub CustomerTBBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomerTBBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerTBBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) 

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub Customersignupbtn_Click(sender As Object, e As EventArgs) Handles customersignupbtn.Click
        Try
            Me.Validate()
            Me.CustomerTBBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._E_commerceDataSet)
            MsgBox("Registraion Successful")
            Dim login As New Customersignin
            login.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hm As New Customersignin
        hm.Show()
        Me.Hide()

    End Sub
End Class