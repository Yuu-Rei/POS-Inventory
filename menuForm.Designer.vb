<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class menuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.transactionButton = New System.Windows.Forms.PictureBox()
        Me.creditButton = New System.Windows.Forms.PictureBox()
        Me.reportsButton = New System.Windows.Forms.PictureBox()
        Me.inventoryButton = New System.Windows.Forms.PictureBox()
        Me.posButton = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transactionButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.creditButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportsButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.posButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Point of Sale"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(165, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Products"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(288, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Reports"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Credit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(135, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Transactions History"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(288, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Logout"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sari_Sari_Store.My.Resources.Resources.logout1
        Me.PictureBox1.Location = New System.Drawing.Point(260, 147)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'transactionButton
        '
        Me.transactionButton.Image = Global.Sari_Sari_Store.My.Resources.Resources.transaction_history1
        Me.transactionButton.Location = New System.Drawing.Point(141, 147)
        Me.transactionButton.Name = "transactionButton"
        Me.transactionButton.Size = New System.Drawing.Size(93, 90)
        Me.transactionButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.transactionButton.TabIndex = 4
        Me.transactionButton.TabStop = False
        '
        'creditButton
        '
        Me.creditButton.Image = Global.Sari_Sari_Store.My.Resources.Resources.credit
        Me.creditButton.Location = New System.Drawing.Point(24, 147)
        Me.creditButton.Name = "creditButton"
        Me.creditButton.Size = New System.Drawing.Size(93, 90)
        Me.creditButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.creditButton.TabIndex = 3
        Me.creditButton.TabStop = False
        '
        'reportsButton
        '
        Me.reportsButton.Image = Global.Sari_Sari_Store.My.Resources.Resources.report
        Me.reportsButton.Location = New System.Drawing.Point(260, 26)
        Me.reportsButton.Name = "reportsButton"
        Me.reportsButton.Size = New System.Drawing.Size(93, 90)
        Me.reportsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.reportsButton.TabIndex = 2
        Me.reportsButton.TabStop = False
        '
        'inventoryButton
        '
        Me.inventoryButton.Image = Global.Sari_Sari_Store.My.Resources.Resources.inventory
        Me.inventoryButton.Location = New System.Drawing.Point(141, 26)
        Me.inventoryButton.Name = "inventoryButton"
        Me.inventoryButton.Size = New System.Drawing.Size(93, 90)
        Me.inventoryButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.inventoryButton.TabIndex = 1
        Me.inventoryButton.TabStop = False
        '
        'posButton
        '
        Me.posButton.Image = Global.Sari_Sari_Store.My.Resources.Resources.cashier_machine
        Me.posButton.Location = New System.Drawing.Point(24, 26)
        Me.posButton.Name = "posButton"
        Me.posButton.Size = New System.Drawing.Size(93, 90)
        Me.posButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.posButton.TabIndex = 0
        Me.posButton.TabStop = False
        '
        'menuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(386, 263)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.transactionButton)
        Me.Controls.Add(Me.creditButton)
        Me.Controls.Add(Me.reportsButton)
        Me.Controls.Add(Me.inventoryButton)
        Me.Controls.Add(Me.posButton)
        Me.HelpButton = True
        Me.Name = "menuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaRhey-SaRhey Store"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transactionButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.creditButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportsButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.posButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents posButton As PictureBox
    Friend WithEvents inventoryButton As PictureBox
    Friend WithEvents reportsButton As PictureBox
    Friend WithEvents creditButton As PictureBox
    Friend WithEvents transactionButton As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
