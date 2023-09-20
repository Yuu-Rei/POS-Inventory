Imports System.Data.OleDb

Public Class creditsForm

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\storedb.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As String

    Sub deleteRecord()


        Try
            con.Open()

            sql = "DELETE * FROM tblcredits WHERE CUSTOMERNAME LIKE '%" & TextBox1.Text & "%'  "
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
    Sub refreshrecord()
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter
        Try
            con.Open()

            sql = "SELECT * FROM tblcredits"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter

        Try
            con.Open()

            sql = "SELECT * FROM tblcredits WHERE CUSTOMERNAME LIKE '%" & TextBox1.Text & "%' "
            cmd.Connection = con
            cmd.CommandText = Sql
            da.SelectCommand = cmd

            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
                Button3.Enabled = True
            Else
                MessageBox.Show("No Records Found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

            Dim creditTotal As String
            Dim creditCounter As Integer

            creditCounter = dt.Rows.Count - 1
            creditTotalLabel.Text = 0
            creditTotal = creditTotalLabel.Text

            For creditCounter = creditCounter To 0 Step -1
                creditTotal = creditTotal + DataGridView1.Rows(creditCounter).Cells(6).Value
                creditTotalLabel.Text = creditTotal
            Next
        End Try
    End Sub

    Private Sub creditsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshrecord()
        Button3.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con.Open()

            sql = "Delete * from tblcredits WHERE CREDIT_ID=" & DataGridView1.CurrentRow.Cells(0).Value & ""
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

    Private Sub enterTenderedButton_Click(sender As Object, e As EventArgs) Handles enterTenderedButton.Click
        changeLabel.Text = tenderedAmountTextBox.Text - creditTotalLabel.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim dt1 As DateTime = DateTimePicker1.Value

            con.Open()

            sql = "INSERT INTO tbltransactions (ITEMNAME, VARIATION, PRICE, AMOUNT, SUBTOTAL, TRANSACTION_DATE) SELECT ITEMNAME, VARIATION, PRICE, AMOUNT, SUBTOTAL, TRANSACTIONDATE FROM tblcredits WHERE CUSTOMERNAME LIKE '%" & TextBox1.Text & "%' AND TRANSACTIONDATE = #" & dt1.ToString("yyyy/MM/dd") & "#"
            cmd.Connection = con
            cmd.CommandText = sql


            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("Paid!")
                Button3.Enabled = False
            Else
                MsgBox("Failed!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
            deleteRecord()
            creditTotalLabel.Text = 0
            changeLabel.Text = 0
        End Try
    End Sub
End Class