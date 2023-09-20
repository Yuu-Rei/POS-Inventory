Imports System.Data.OleDb
Public Class productsForm
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\storedb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As Integer
    Private Sub productsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshrecord()
    End Sub

    Sub refreshrecord()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles refreshButton.Click
        refreshrecord()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles addprodButton.Click
        Try
            con.Open()

            sql = "INSERT INTO tblitems (BARCODE, ITEMNAME, VARIATION, QTY, PRICE) values ('" & barcode.Text & "','" & itemName.Text & "', '" & variation.Text & "' ,0 , " & Val(itemPrice.Text) & ")"
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Product has been added succesfully")
            Else
                MsgBox("Product failed to add")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            refreshrecord()
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        barcodeInfo.Text = DataGridView1.CurrentRow.Cells(0).Value
        infoName.Text = DataGridView1.CurrentRow.Cells(1).Value
        infoVariation.Text = DataGridView1.CurrentRow.Cells(2).Value
        infoQuantity.Text = DataGridView1.CurrentRow.Cells(3).Value
        infoPrice.Text = DataGridView1.CurrentRow.Cells(4).Value
    End Sub
    Private Sub updateButton_Click(sender As Object, e As EventArgs) Handles updateButton.Click

        Try
            con.Open()

            sql = "UPDATE tblitems SET BARCODE='" & barcodeInfo.Text & "', ITEMNAME='" & infoName.Text & "', VARIATION='" & infoVariation.Text & "' ,QTY='" & infoQuantity.Text & "' , PRICE='" & infoPrice.Text & "' WHERE BARCODE=" & Val(DataGridView1.CurrentRow.Cells(0).Value) & ""
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Product has been updated succesfully")
            Else
                MsgBox("Update failed")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            refreshrecord()
        End Try
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click

        Try
            con.Open()

            sql = "Delete * from tblitems WHERE BARCODE=" & Val(DataGridView1.CurrentRow.Cells(0).Value) & ""
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


End Class