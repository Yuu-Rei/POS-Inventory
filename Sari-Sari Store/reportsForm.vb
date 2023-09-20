Imports System.Data.OleDb
Imports System.Data.SqlTypes

Public Class reportsForm

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\storedb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As Integer
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
    Private Sub reportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshrecord()

        Dim dateTotal As Integer = 0

        For i As Integer = 0 To DataGridView1.RowCount - 1
            dateTotal += DataGridView1.Rows(i).Cells(5).Value
        Next
        If dateTotal = 0 Then
            MessageBox.Show("No Records Found")
        End If

        Label6.Text = dateTotal
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim dt1 As DateTime = DateTimePicker1.Value
        Dim dt2 As DateTime = DateTimePicker2.Value
        Dim da As New OleDb.OleDbDataAdapter
        Try
            con.Open()

            sql = "SELECT * FROM tbltransactions where TRANSACTION_DATE BETWEEN #" & dt1.ToString("yyyy/MM/dd") & "# AND #" & dt2.ToString("yyyy/MM/dd") & "#"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd

            da.Fill(dt)

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

            Dim dateTotal As Integer = 0

            For i As Integer = 0 To DataGridView1.RowCount - 1
                dateTotal += DataGridView1.Rows(i).Cells(5).Value
            Next
            If dateTotal = 0 Then
                MessageBox.Show("No Records Found")
            End If

            Label5.Text = dateTotal
        End Try
    End Sub
End Class