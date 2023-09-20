Public Class menuForm
    Private Sub posButton_Click(sender As Object, e As EventArgs) Handles posButton.Click

        posForm.Show()
    End Sub

    Private Sub inventoryButton_Click(sender As Object, e As EventArgs) Handles inventoryButton.Click
        productsForm.Show()
    End Sub

    Private Sub transactionButton_Click(sender As Object, e As EventArgs) Handles transactionButton.Click
        transactionsForm.Show()
    End Sub

    Private Sub creditButton_Click(sender As Object, e As EventArgs) Handles creditButton.Click
        creditsForm.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub reportsButton_Click(sender As Object, e As EventArgs) Handles reportsButton.Click
        reportsForm.Show()
    End Sub
End Class