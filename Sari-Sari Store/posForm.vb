Imports System.CodeDom
Imports System.Data.OleDb
Public Class posForm
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\storedb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles newItemButton.Click

        GroupBox6.Visible = True
        GroupBox5.Visible = False

    End Sub

    Sub removeItem()
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter

        Try
            con.Open()

            sql = "SELECT * FROM tblitems WHERE ITEMNAME= '" & tblposDataGrid.CurrentRow.Cells(1).Value & "' AND VARIATION= '" & tblposDataGrid.CurrentRow.Cells(2).Value & "'"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            Else
                MessageBox.Show("No Records Found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Sub stockRestock()


        Try
            con.Open()

            sql = "UPDATE tblitems SET QTY='" & Val(tblposDataGrid.CurrentRow.Cells(4).Value) + Val(DataGridView1.CurrentRow.Cells(3).Value) & "' WHERE BARCODE=" & Val(tblposDataGrid.CurrentRow.Cells(0).Value) & ""
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            totalLabel.Text = Val(totalLabel.Text) - Val(tblposDataGrid.CurrentRow.Cells(5).Value)
            selfRefreshRecord()
        End Try
    End Sub
    Sub refreshCredits()
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Try
            con.Open()

            sql = "SELECT * FROM tblcredits"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            creditsForm.DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Sub deleteRecord()
        Try
            con.Open()

            sql = "Delete * from tblpos"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            refreshrecord()
        End Try
    End Sub

    Sub getTotal()
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Try
            con.Open()

            sql = "SELECT BARCODE, ITEMNAME, VARIATION, PRICE, AMOUNT, SUBTOTAL FROM tblpos"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            tblposDataGrid.DataSource = dt

            Dim posTotal As String
            Dim counter As Integer

            counter = dt.Rows.Count - 1

            posTotal = totalLabel.Text

            posTotal = posTotal + tblposDataGrid.Rows(counter).Cells(5).Value
            totalLabel.Text = posTotal

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Sub refreshrecord()
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Try
            con.Open()

            sql = "SELECT BARCODE, ITEMNAME, VARIATION, PRICE, AMOUNT, SUBTOTAL FROM tblpos"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            tblposDataGrid.DataSource = dt


   
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles enterTenderedButton.Click
        changeLabel.Text = tenderedAmountTextBox.Text - totalLabel.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles paidButton.Click
        Try
            con.Open()

            sql = "INSERT INTO tbltransactions (ITEMNAME, VARIATION, PRICE, AMOUNT, SUBTOTAL, TRANSACTION_DATE) SELECT ITEMNAME, VARIATION, PRICE, AMOUNT, SUBTOTAL, CURRENTDATE FROM tblpos"
            cmd.Connection = con
            cmd.CommandText = sql


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Transaction Done!")

            Else
                MsgBox("Transaction Failed!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            deleteRecord()
            totalLabel.Text = 0
            changeLabel.Text = 0
            tenderedAmountTextBox.Text = ""
        End Try
    End Sub

    Private Sub posForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refreshrecord()

        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Try
            con.Open()

            sql = "SELECT * FROM tblitems"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            removeItem()
            stockRestock()

            con.Open()


            sql = "Delete * from tblpos WHERE BARCODE=" & tblposDataGrid.CurrentRow.Cells(0).Value & ""
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Record has been deleted succesfully")
            Else
                MsgBox("Deletion failed")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            refreshrecord()

        End Try
    End Sub

    Sub updateEmpty()

        Try
            con.Open()

            sql = "UPDATE tblcredits SET CUSTOMERNAME='" & TextBox1.Text & "' WHERE CUSTOMERNAME IS NULL"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub
    Private Sub creditButton_Click(sender As Object, e As EventArgs) Handles creditButton.Click
        Try
            con.Open()

            sql = "INSERT INTO tblcredits (ITEMNAME, VARIATION, PRICE, AMOUNT, SUBTOTAL, TRANSACTIONDATE) SELECT ITEMNAME, VARIATION, PRICE, AMOUNT, SUBTOTAL, CURRENTDATE FROM tblpos"
            cmd.Connection = con
            cmd.CommandText = sql


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Transaction Done!")

            Else
                MsgBox("Transaction Failed!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            updateEmpty()
            refreshCredits()
            deleteRecord()
            totalLabel.Text = 0
            changeLabel.Text = 0
        End Try
    End Sub

    Sub stockDeduct()
        Try
            con.Open()

            sql = "UPDATE tblitems SET QTY='" & Val(DataGridView1.CurrentRow.Cells(3).Value) - Val(productAmount.Text) & "' WHERE BARCODE=" & Val(DataGridView1.CurrentRow.Cells(0).Value) & ""
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            selfRefreshRecord()
        End Try
    End Sub

    Sub selfRefreshRecord()
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Try
            con.Open()

            sql = "SELECT * FROM tblitems"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub productRegister_Click(sender As Object, e As EventArgs) Handles productRegister.Click

        Dim regDate As DateTime = DateTime.Now
        Dim strDate As String = regDate.ToString("yyyy-MM-dd")



        Dim productQuantity As Integer = Val(DataGridView1.CurrentRow.Cells(3).Value)
        Dim quantityInput As Integer = productAmount.Text

        If productQuantity <> 0 And quantityInput <= productQuantity Then
            Try
                con.Open()

                sql = "INSERT INTO tblpos (BARCODE, ITEMNAME, VARIATION ,PRICE, AMOUNT, SUBTOTAL, CURRENTDATE) values ('" & DataGridView1.CurrentRow.Cells(0).Value & "','" & DataGridView1.CurrentRow.Cells(1).Value & "', '" & DataGridView1.CurrentRow.Cells(2).Value & "', '" & DataGridView1.CurrentRow.Cells(4).Value & "' , '" & Val(productAmount.Text) & "' , '" & Val(DataGridView1.CurrentRow.Cells(4).Value) * Val(productAmount.Text) & "', '" & strDate & "')"
                cmd.Connection = con
                cmd.CommandText = sql


                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Product has been registered succesfully")
                    GroupBox6.Visible = False
                    GroupBox5.Visible = True
                Else
                    MsgBox("Registration failed")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                getTotal()
                stockDeduct()



            End Try
        Else
            MsgBox("Few or Out of Stock!")
        End If
    End Sub

    Private Sub productSearch_Click(sender As Object, e As EventArgs) Handles productSearch.Click
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter

        Try
            con.Open()

            sql = "SELECT * FROM tblitems WHERE ITEMNAME LIKE '%" & searchInput.Text & "%' OR BARCODE LIKE '%" & searchInput.Text & "%'"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            Else
                MessageBox.Show("No Records Found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox6.Visible = False
        GroupBox5.Visible = True
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) 
        Try
            stockRestock()
            
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            refreshrecord()
        End Try
    End Sub


End Class