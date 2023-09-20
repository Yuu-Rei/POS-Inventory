Imports System.Data.OleDb

Public Class loginForm
    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\storedb.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM tblusers WHERE USERNAME= '" & usernameTextbox.Text & "' AND PASSWORD='" & passwordTextbox.Text & "'", con)
        Dim user As String = ""
        Dim pass As String = ""

        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader

        If sdr.Read = True Then
            user = sdr("USERNAME")
            pass = sdr("PASSWORD")

            MessageBox.Show("Login Successfully")
            Me.Hide()
            menuForm.Show()
        Else
            MessageBox.Show("Invalid Username or Password")
        End If


    End Sub

End Class
