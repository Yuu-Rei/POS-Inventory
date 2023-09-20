
Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Net.Security
Imports System.Xml
Public Class transactionsForm

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\storedb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As String

    Sub refreshrecord()
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Try
            con.Open()

            sql = "select * from tbltransactions"
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
    Private Sub transactionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshrecord()

    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim dt As New DataTable
        Dim dt1 As DateTime = DateTimePicker1.Value
        Dim da As New OleDb.OleDbDataAdapter
        Try
            con.Open()

            sql = "SELECT * FROM tbltransactions where TRANSACTION_DATE = #" & dt1.ToString("yyyy/MM/dd") & "#"
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con.Open()

            sql = "Delete * from tbltransactions WHERE TRANSACTION_ID=" & Val(DataGridView1.CurrentRow.Cells(0).Value) & ""
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