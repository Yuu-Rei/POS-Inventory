Imports System.Data.OleDb
Imports System.Net.Security
Imports System.Xml

Public Class productSelection
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\storedb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As String

    Sub stockDeduct()
        Try
            con.Open()

            sql = "UPDATE tblitems SET QTY='" & Val(DataGridView1.CurrentRow.Cells(2).Value) - Val(productAmount.Text) & "' WHERE PRODUCT_ID=" & Val(DataGridView1.CurrentRow.Cells(0).Value) & ""
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

    Sub refreshrecord()
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Try
            con.Open()

            sql = "SELECT PRODUCT_ID, ITEMNAME, PRICE, AMOUNT, SUBTOTAL FROM tblpos"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            posForm.tblposDataGrid.DataSource = dt

            Dim posTotal As String
            Dim counter As Integer

            counter = dt.Rows.Count - 1

            posTotal = posForm.totalLabel.Text

            posTotal = posTotal + posForm.tblposDataGrid.Rows(counter).Cells(4).Value
            posForm.totalLabel.Text = posTotal

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
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


    Private Sub productSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Try
            con.Open()

            sql = "select * from tblitems"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles productSearch.Click
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter

        Try
            con.Open()

            sql = "SELECT * FROM tblitems WHERE ITEMNAME LIKE '%" & searchInput.Text & "%'"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles productRegister.Click

        Dim regDate As DateTime = DateTime.Now
        Dim strDate As String = regDate.ToString("yyyy-MM-dd")



        Dim productQuantity As Integer = Val(DataGridView1.CurrentRow.Cells(2).Value)
        Dim quantityInput As Integer = productAmount.Text

        If productQuantity <> 0 And quantityInput < productQuantity Then
            Try
                con.Open()

                sql = "INSERT INTO tblpos (PRODUCT_ID, ITEMNAME, PRICE, AMOUNT, SUBTOTAL, CURRENTDATE) values ('" & DataGridView1.CurrentRow.Cells(0).Value & "','" & DataGridView1.CurrentRow.Cells(1).Value & "', '" & DataGridView1.CurrentRow.Cells(3).Value & "' , '" & Val(productAmount.Text) & "' , '" & Val(DataGridView1.CurrentRow.Cells(3).Value) * Val(productAmount.Text) & "', '" & strDate & "')"
                cmd.Connection = con
                cmd.CommandText = sql


                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Product has been registered succesfully")
                Else
                    MsgBox("Registration failed")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                stockDeduct()
                refreshrecord()


            End Try
        Else
            MsgBox("Few or Out of Stock!")
        End If

    End Sub

    Private Sub searchInput_TextChanged(sender As Object, e As EventArgs) Handles searchInput.TextChanged

    End Sub
End Class