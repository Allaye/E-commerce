Imports System.Data.SqlClient


Public Class Main_shop
    Public Property uname As String
    Private Sub Main_Shop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBox1.Text = form3.textbox1.text Customersignin.CustomerIDTextBox.Text
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Usernamebtn.Text = uname
        ProductImagePictureBox.Image = Nothing
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox5.Image = Nothing

        PictureBox4.Visible = True
        Label5.Visible = True
        Label4.Visible = True
        Label3.Visible = True
        Label14.Visible = True
        Label13.Visible = True
        Label12.Visible = True
        Label8.Visible = True
        Label7.Visible = True
        Label6.Visible = True
        Label17.Text = ""
        Label16.Text = ""
        Label15.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label20.Text = ""
        Label19.Text = ""
        Label18.Text = ""
        Label5.Text = ""
        Label4.Text = ""
        Label3.Text = ""
        Label14.Text = ""
        Label13.Text = " "
        Label12.Text = ""
        Label8.Text = ""
        Label7.Text = ""
        Label6.Text = ""
        LoadingProductname1()
        LoadingProductname()
        LoadingProductname2()
        LoadingProductname3()
        LoadingProductname4()
        LoadingProductname5()
        LoadingProductname6()
        LoadingProductname20()
        LoadPic1()
        LoadPic2()
        LoadPic3()
        LoadPic4()
        LoadPic20()

    End Sub
    Public Function LoadPic20()

        Dim cn As SqlConnection

#Disable Warning IDE0017 ' Simplify object initialization
        cn = New SqlConnection
#Enable Warning IDE0017 ' Simplify object initialization
        cn.ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"

        Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce];SELECT ProductTB.ProductImage  FROM ProductTB WHERE ProductID = 'plate1'")
        cn.Open()
        cmd.Connection = cn

        Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
        cmd.CommandType = CommandType.Text

        ProductImagePictureBox.Image = Image.FromStream(ImgStream)

        ImgStream.Dispose()

        cmd.Connection.Close()
        Return cmd

        'Catch ex As Exception
        '    ' log message instead '
        '    Throw ' don't use throw new Exception or throw ex '
        'End Try
    End Function
    Public Function LoadPic1()

        Dim cn As SqlConnection

#Disable Warning IDE0017 ' Simplify object initialization
        cn = New SqlConnection
#Enable Warning IDE0017 ' Simplify object initialization
        cn.ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"

        Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce];SELECT ProductTB.ProductImage  FROM ProductTB WHERE ProductID = 'bedsheet1'")
        cn.Open()
        cmd.Connection = cn

        Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
        cmd.CommandType = CommandType.Text

        PictureBox4.Image = Image.FromStream(ImgStream)

        ImgStream.Dispose()

        cmd.Connection.Close()

        Return cmd
        'Catch ex As Exception
        '    ' log message instead '
        '    Throw ' don't use throw new Exception or throw ex '
        'End Try
    End Function
    Public Function LoadPic2()

        '  cn = New SqlConnection
        Dim cn As New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce];SELECT ProductTB.ProductImage  FROM ProductTB WHERE ProductName = 'Levis Shoe'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            PictureBox1.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()
            Return cmd

        Catch ex As Exception
            '    ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function
    Public Function LoadingProductname()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductDiscp FROM ProductTB WHERE ProductName = 'Levis Shoe'"


        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()

            If myreader.Read() Then
                Label5.Text = myreader.GetValue(0)
                Label3.Text = myreader.GetValue(1)



            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        Return Label5
        ' con.Close()
    End Function
    Public Function LoadPic3()

        Dim cn As SqlConnection

        cn = New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce];SELECT ProductTB.ProductImage  FROM ProductTB WHERE ProductName = 'PS4'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            PictureBox2.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()
            Return cmd

        Catch ex As Exception
            '    ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function
    Public Function LoadPic4()

        Dim cn As SqlConnection

        cn = New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce];SELECT ProductTB.ProductImage  FROM ProductTB WHERE ProductName = 'Gucci-Watch'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            PictureBox3.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()

            Return PictureBox3
        Catch ex As Exception
            '    ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function
    Public Function LoadingProductname6()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];  Begin Transaction SELECT ProductTB.ProductPrice, ProductTB.ProductDiscp FROM ProductTB WHERE ProductName = 'Gucci-Watch' "

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()

            If myreader.Read() Then
                Label13.Text = myreader.GetValue(0)
                Label12.Text = myreader.GetValue(1)


            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label12
    End Function
    Public Function LoadingProductname4()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductPrice, ProductTB.ProductDiscp FROM ProductTB WHERE ProductName = 'Levis Shoe'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()

            If myreader.Read() Then
                Label4.Text = myreader.GetValue(0)



            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label14
    End Function
    Public Function LoadingProductname3()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp  FROM ProductTB WHERE ProductName = 'Ceramic Plate'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()

            If myreader.Read() Then
                Label20.Text = myreader.GetValue(0)
                Label19.Text = myreader.GetValue(1)
                Label18.Text = myreader.GetValue(2)

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label18
    End Function
    Public Function LoadingProductname20()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp  FROM ProductTB WHERE ProductName = 'cotton bed sheet'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()

            If myreader.Read() Then
                Label8.Text = myreader.GetValue(0)
                Label7.Text = myreader.GetValue(1)
                Label6.Text = myreader.GetValue(2)

            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label8
    End Function


























    Public Function LoadingProductname1()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductDiscp FROM ProductTB WHERE ProductName = 'PS4'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            ' Dim myreader1 As SqlDataReader = cmd1.ExecuteReader()
            If myreader.Read() Then
                Label11.Text = myreader.GetValue(0)
                Label9.Text = myreader.GetValue(1)


            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label9
    End Function
    Public Function LoadingProductname2()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName FROM ProductTB WHERE ProductName = 'Gucci-Watch'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            ' Dim myreader1 As SqlDataReader = cmd1.ExecuteReader()
            If myreader.Read() Then
                Label14.Text = myreader.GetValue(0)


            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        Return Label14
        ' con.Close()
    End Function
    Public Function LoadingProductname5()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductPrice FROM ProductTB WHERE ProductName = 'PS4'"


        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()

            If myreader.Read() Then
                Label10.Text = myreader.GetValue(0)



            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label10
    End Function
    'Private Function getprice1() As DataTable

    '    Dim connection As New SqlConnection("Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
    '    Dim Command As String = "SELECT ProductPrice FROM ProductTB WHERE ProductName = 'PS4'"

    '    Dim adp As New SqlDataAdapter(Command, connection)
    '    connection.Open()
    '    Dim productn As New DataTable
    '    adp.Fill(productn)
    '    Return productn
    'End Function
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ProductTBTableAdapter.FillBy(Me._E_commerceDataSet.ProductTB)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        ' LoadProduct()
    End Sub

    Public Sub Userlbl_Click(sender As Object, e As EventArgs) Handles Userlbl.Click

    End Sub

    Private Sub ProductImagePictureBox_Click(sender As Object, e As EventArgs) Handles ProductImagePictureBox.Click
        '        Select Case ProductImage
        'From ProductTB
        'Order By ProductName DESC
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Homebtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Homebtn_Click_1(sender As Object, e As EventArgs) Handles Homebtn.Click
        ProductImagePictureBox.Image = Nothing
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox5.Image = Nothing

        PictureBox4.Visible = True
        Label5.Visible = True
        Label4.Visible = True
        Label3.Visible = True
        Label14.Visible = True
        Label13.Visible = True
        Label12.Visible = True
        Label8.Visible = True
        Label7.Visible = True
        Label6.Visible = True
        Label17.Text = ""
        Label16.Text = ""
        Label15.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label20.Text = ""
        Label19.Text = ""
        Label18.Text = ""
        Label5.Text = ""
        Label4.Text = ""
        Label3.Text = ""
        Label14.Text = ""
        Label13.Text = " "
        Label12.Text = ""
        Label8.Text = ""
        Label7.Text = ""
        Label6.Text = ""

        PictureBox4.Visible = True
        LoadingProductname20()
        LoadingProductname1()
        LoadingProductname()
        LoadingProductname2()
        LoadingProductname3()
        LoadingProductname4()
        LoadingProductname5()
        LoadingProductname6()
        LoadPic1()
        LoadPic2()
        LoadPic3()
        LoadPic4()
        LoadPic20()

    End Sub




















    ''' <summary>
    ''' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Electronicsbtn_Click(sender As Object, e As EventArgs) Handles Electronicsbtn.Click
        ' Me.BackgroundImage = My.Resources.bg3
        ProductImagePictureBox.Image = Nothing
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Image = Nothing
        PictureBox5.Image = Nothing

        PictureBox4.Visible = True
        Label5.Visible = True
        Label4.Visible = True
        Label3.Visible = True
        Label14.Visible = True
        Label13.Visible = True
        Label12.Visible = True
        Label8.Visible = True
        Label7.Visible = True
        Label6.Visible = True
        Label17.Text = ""
        Label16.Text = ""
        Label15.Text = ""
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label20.Text = ""
        Label19.Text = ""
        Label18.Text = ""
        Label5.Text = ""
        Label4.Text = ""
        Label3.Text = ""
        Label14.Text = ""
        Label13.Text = " "
        Label12.Text = ""
        Label8.Text = ""
        Label7.Text = ""
        Label6.Text = ""
        LoadPic5()
        LoadPic6()
        LoadPic7()
        LoadPic8()
        LoadPic9()
        LoadingProductname7()
        LoadingProductname8()
        LoadingProductname9()
        LoadingProductname10()
        LoadingProductname15()


    End Sub








    Public Function LoadPic7()

        Dim cn As SqlConnection

        cn = New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce]SELECT ProductTB.ProductImage
    FROM     ProductTB INNER JOIN
                      CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
     WHERE CategoryTB.CategoryName= 'Electronic' AND ProductTB.ProductName='PS4'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            ProductImagePictureBox.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()

            Return ProductImagePictureBox
        Catch ex As Exception
            '    ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function

































    Public Function LoadPic6()

        Dim cn As SqlConnection

        cn = New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce]SELECT ProductTB.ProductImage
    FROM     ProductTB INNER JOIN
                      CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
     WHERE CategoryTB.CategoryName= 'Electronic' AND ProductTB.ProductName='macbook'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            PictureBox1.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()

            Return PictureBox1
        Catch ex As Exception
            '    ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function




























    Public Function LoadPic5()

        Dim cn As SqlConnection

        cn = New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce]SELECT ProductTB.ProductImage
    FROM     ProductTB INNER JOIN
                      CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
     WHERE CategoryTB.CategoryName= 'Electronic' AND ProductTB.ProductName='Samsung Galaxy'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            PictureBox2.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()
            Return PictureBox2

        Catch ex As Exception
            '    ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function





























    Public Function LoadPic9()

        Dim cn As SqlConnection

        cn = New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce]SELECT ProductTB.ProductImage
    FROM     ProductTB INNER JOIN
                      CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
     WHERE CategoryTB.CategoryName= 'Electronic' AND ProductTB.ProductName='Gucci-Watch'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            PictureBox4.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()
            Return PictureBox4

        Catch ex As Exception
            '    ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function

































    Public Function LoadingProductname15()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp
    FROM     ProductTB INNER JOIN
                      CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
     WHERE CategoryTB.CategoryName= 'Electronic' AND ProductTB.ProductName='Gucci-Watch'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            ' Dim myreader1 As SqlDataReader = cmd1.ExecuteReader()
            If myreader.Read() Then
                Label8.Text = myreader.GetValue(0)
                Label7.Text = myreader.GetValue(1)
                Label6.Text = myreader.GetValue(2)




            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label7
    End Function
































    Public Function LoadPic8()

        Dim cn As SqlConnection

        cn = New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce]SELECT ProductTB.ProductImage
    FROM     ProductTB INNER JOIN
                      CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
     WHERE CategoryTB.CategoryName= 'Electronic' AND ProductTB.ProductName='Samsung TV'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            PictureBox3.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()
            Return PictureBox3

        Catch ex As Exception
            '    ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function


























    Public Function LoadingProductname9()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp
    FROM     ProductTB INNER JOIN
                      CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
     WHERE CategoryTB.CategoryName= 'Electronic' AND ProductTB.ProductName='Samsung TV'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            ' Dim myreader1 As SqlDataReader = cmd1.ExecuteReader()
            If myreader.Read() Then
                Label14.Text = myreader.GetValue(0)
                Label13.Text = myreader.GetValue(1)
                Label12.Text = myreader.GetValue(2)




            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label12
    End Function




















    Public Function LoadingProductname8()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp
    FROM     ProductTB INNER JOIN
                      CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
     WHERE CategoryTB.CategoryName= 'Electronic' AND ProductTB.ProductName='Samsung Galaxy'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            ' Dim myreader1 As SqlDataReader = cmd1.ExecuteReader()
            If myreader.Read() Then
                Label11.Text = myreader.GetValue(0)
                Label10.Text = myreader.GetValue(1)
                Label9.Text = myreader.GetValue(2)




            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label9
    End Function





























    Public Function LoadingProductname10()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp
FROM     ProductTB INNER JOIN
                  CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
 WHERE CategoryTB.CategoryName= 'Electronic' AND ProductTB.ProductName='PS4'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            ' Dim myreader1 As SqlDataReader = cmd1.ExecuteReader()
            If myreader.Read() Then
                Label20.Text = myreader.GetValue(0)
                Label19.Text = myreader.GetValue(1)
                Label18.Text = myreader.GetValue(2)




            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        Return Label18
        ' con.Close()
    End Function



    Public Function LoadingProductname7()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp
    FROM     ProductTB INNER JOIN
                      CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
     WHERE CategoryTB.CategoryName= 'Electronic' AND ProductTB.ProductName='macbook'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            ' Dim myreader1 As SqlDataReader = cmd1.ExecuteReader()
            If myreader.Read() Then
                Label5.Text = myreader.GetValue(0)
                Label4.Text = myreader.GetValue(1)
                Label3.Text = myreader.GetValue(2)




            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label3
    End Function

























    ''' <summary>
    ''' ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub Homeandlivingbtn_Click(sender As Object, e As EventArgs) Handles Homeandlivingbtn.Click
        ProductImagePictureBox.Image = Nothing
        PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing
        PictureBox4.Visible = True
        PictureBox4.Image = Nothing
        PictureBox5.Image = Nothing
        Label17.Text = ""
        Label16.Text = ""
        Label15.Text = ""
        Label8.Visible = True
        Label7.Visible = True
        Label6.Visible = True
        Label9.Text = ""
        Label10.Text = ""
        Label11.Text = ""
        Label20.Text = ""
        Label19.Text = ""
        Label18.Text = ""
        Label5.Text = ""
        Label4.Text = ""
        Label3.Text = ""
        Label14.Text = ""
        Label13.Text = " "
        Label12.Text = ""
        LoadPic10()
        LoadPic11()
        LoadPic12()
        LoadPic13()
        LoadPic14()
        LoadingProductname14()
        LoadingProductname11()
        LoadingProductname12()
        LoadingProductname13()

        LoadingProductname16()
    End Sub
    ' BEGINING OF HOME&LIVING
    Public Function LoadPic10()

        Dim cn As SqlConnection

        cn = New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce]SELECT ProductTB.ProductImage
FROM     ProductTB INNER JOIN
                  CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
 WHERE CategoryTB.CategoryName= 'Other' AND ProductTB.ProductName='Long sleeve shirt'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            ProductImagePictureBox.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()

            Return ProductImagePictureBox
        Catch ex As Exception
            '    ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function
    Public Function LoadPic11()

        Dim cn As SqlConnection

        cn = New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce]SELECT ProductTB.ProductImage
FROM     ProductTB INNER JOIN
                  CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
 WHERE CategoryTB.CategoryName= 'Other' AND ProductTB.ProductName='Levis Shoe'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            PictureBox3.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()

            Return cmd
        Catch ex As Exception
            '    ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try

    End Function
    Public Function LoadPic12()

        Dim cn As SqlConnection

        cn = New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce]SELECT ProductTB.ProductImage
FROM     ProductTB INNER JOIN
                  CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
 WHERE CategoryTB.CategoryName= 'Other' AND ProductTB.ProductName='cotton bed sheet'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            PictureBox2.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()

            Return PictureBox2
        Catch ex As Exception
            '    ' log message instead '
            Throw
            ' don't use throw new Exception or throw ex '
        End Try
    End Function
    Public Function LoadPic13()

        Dim cn As SqlConnection

        cn = New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce]SELECT ProductTB.ProductImage
FROM     ProductTB INNER JOIN
                  CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
 WHERE CategoryTB.CategoryName= 'Other' AND ProductTB.ProductName='Luis Vitton Bag'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            PictureBox1.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()

            Return PictureBox1
        Catch ex As Exception
            '    ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function
    Public Function LoadPic14()

        Dim cn As SqlConnection

        cn = New SqlConnection With {
            .ConnectionString = "Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True"
        }
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand("use [E-commerce]SELECT ProductTB.ProductImage
FROM     ProductTB INNER JOIN
                  CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
 WHERE CategoryTB.CategoryName= 'Other' AND ProductTB.ProductName='Ceramic Plate'")
            cn.Open()
            cmd.Connection = cn

            Dim ImgStream As New IO.MemoryStream(CType(cmd.ExecuteScalar, Byte()))
            cmd.CommandType = CommandType.Text

            PictureBox4.Image = Image.FromStream(ImgStream)

            ImgStream.Dispose()

            cmd.Connection.Close()
            Return PictureBox4

        Catch ex As Exception
            '    ' log message instead '
            Throw ' don't use throw new Exception or throw ex '
        End Try
    End Function
    Public Function LoadingProductname14()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp
FROM     ProductTB INNER JOIN
                  CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
 WHERE CategoryTB.CategoryName= 'Other' AND ProductTB.ProductName='Long sleeve shirt'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            ' Dim myreader1 As SqlDataReader = cmd1.ExecuteReader()
            If myreader.Read() Then
                Label20.Text = myreader.GetValue(0)
                Label19.Text = myreader.GetValue(1)
                Label18.Text = myreader.GetValue(2)




            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label18
    End Function
    Public Function LoadingProductname11()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp
FROM     ProductTB INNER JOIN
                  CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
 WHERE CategoryTB.CategoryName= 'Other' AND ProductTB.ProductName='Luis Vitton Bag'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            ' Dim myreader1 As SqlDataReader = cmd1.ExecuteReader()
            If myreader.Read() Then
                Label5.Text = myreader.GetValue(0)
                Label4.Text = myreader.GetValue(1)
                Label3.Text = myreader.GetValue(2)




            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label14
    End Function
    Public Function LoadingProductname12()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp
FROM     ProductTB INNER JOIN
                  CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
 WHERE CategoryTB.CategoryName= 'Other' AND ProductTB.ProductName='cotton bed sheet'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            ' Dim myreader1 As SqlDataReader = cmd1.ExecuteReader()
            If myreader.Read() Then
                Label11.Text = myreader.GetValue(0)
                Label10.Text = myreader.GetValue(1)
                Label9.Text = myreader.GetValue(2)




            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label9
    End Function
    Public Function LoadingProductname13()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp
FROM     ProductTB INNER JOIN
                  CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
 WHERE CategoryTB.CategoryName= 'Other' AND ProductTB.ProductName='Levis Shoe'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            ' Dim myreader1 As SqlDataReader = cmd1.ExecuteReader()
            If myreader.Read() Then
                Label14.Text = myreader.GetValue(0)
                Label13.Text = myreader.GetValue(1)
                Label12.Text = myreader.GetValue(2)




            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label12
    End Function


    Public Function LoadingProductname16()
        Dim con As New SqlConnection(" Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
        Dim cmd As SqlCommand

        Dim query As String = "use [E-commerce];SELECT ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp
FROM     ProductTB INNER JOIN
                  CategoryTB ON ProductTB.ProductID = CategoryTB.ProductID
 WHERE CategoryTB.CategoryName= 'Other' AND ProductTB.ProductName='Ceramic Plate'"

        cmd = New SqlCommand(query, con)

        con.Open()
        Try

            Dim myreader As SqlDataReader = cmd.ExecuteReader()
            ' Dim myreader1 As SqlDataReader = cmd1.ExecuteReader()
            If myreader.Read() Then
                Label8.Text = myreader.GetValue(0)
                Label7.Text = myreader.GetValue(1)
                Label6.Text = myreader.GetValue(2)




            End If
            myreader.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        ' con.Close()
        Return Label6
    End Function

    'END OF HOME&LIVING
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Welcomelbl.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Welcomelbl.Location.X + Welcomelbl.Width < 0 Then
            Welcomelbl.Location = New Point(Me.Width, Welcomelbl.Location.Y)
        Else
            Welcomelbl.Location = New Point(Welcomelbl.Location.X - 3, Welcomelbl.Location.Y)
        End If
    End Sub

    Private Sub Usernamebtn_Click(sender As Object, e As EventArgs) Handles Usernamebtn.Click
        Exitsystem()
    End Sub
    Public Function Exitsystem()
        Dim appexit As DialogResult
        appexit = MessageBox.Show("Do you want to LOGOUT", "MAGASIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If appexit = DialogResult.Yes Then
            Start_up_page.Show()
            Me.Hide()
        End If
        Return appexit
    End Function
End Class













































'Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
'    Try
'        Me.ProductTBTableAdapter.FillBy1(Me._E_commerceDataSet.ProductTB, Laptop1ToolStripTextBox.Text)
'    Catch ex As System.Exception
'        System.Windows.Forms.MessageBox.Show(ex.Message)
'    End Try

'End Sub
'.DataBindings = getprice1()
'ProductImagePictureBo
'  Label2.DataBindings = LoadProduct()

' Main_shop
'If (Context.User.Identity.IsAuthenticated) Then
'    ' Finds user name and says Hi
'    lblWelcome.Text = "Hi " + Context.User.Identity.Name

'Else

'    ' It is anonymous user, say hi to guest
'    lblWelcome.Text = "Hi guest"
'End If

'Const sqlSelect As String = "use [E-commerce];SELECT *  FROM ProductTB WHERE ProductID = 'pro1'"
'Dim query1 As String = "use [E-commerce];SELECT ProductTB.ProductImage  FROM ProductTB WHERE ProductID = 'pro1'"
''ProductTB.ProductName, ProductTB.ProductPrice, ProductTB.ProductDiscp FROM ProductTB "
'Try
'    Dim table = New DataTable()
'    Dim con As New SqlConnection("Data Source=ALLAYE\SQLEXPRESS;Initial Catalog=E-commerce;Integrated Security=True")
'    con.Open()
'    Dim da As New SqlDataAdapter(sqlSelect, con)
'    da.Fill(table)
'    Return table
''    TextBox2.Text = table.Rows(0)(2).ToString
'Try