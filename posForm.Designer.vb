<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class posForm
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
        Me.newItemButton = New System.Windows.Forms.Button()
        Me.tenderedAmountTextBox = New System.Windows.Forms.TextBox()
        Me.paidButton = New System.Windows.Forms.Button()
        Me.creditButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.enterTenderedButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.changeLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tblposDataGrid = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.productSearch = New System.Windows.Forms.Button()
        Me.searchInput = New System.Windows.Forms.TextBox()
        Me.productRegister = New System.Windows.Forms.Button()
        Me.productAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.tblposDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'newItemButton
        '
        Me.newItemButton.Location = New System.Drawing.Point(658, 19)
        Me.newItemButton.Name = "newItemButton"
        Me.newItemButton.Size = New System.Drawing.Size(64, 41)
        Me.newItemButton.TabIndex = 3
        Me.newItemButton.Text = "New Item"
        Me.newItemButton.UseVisualStyleBackColor = True
        '
        'tenderedAmountTextBox
        '
        Me.tenderedAmountTextBox.Location = New System.Drawing.Point(6, 19)
        Me.tenderedAmountTextBox.Name = "tenderedAmountTextBox"
        Me.tenderedAmountTextBox.Size = New System.Drawing.Size(124, 20)
        Me.tenderedAmountTextBox.TabIndex = 8
        '
        'paidButton
        '
        Me.paidButton.Location = New System.Drawing.Point(687, 260)
        Me.paidButton.Name = "paidButton"
        Me.paidButton.Size = New System.Drawing.Size(86, 26)
        Me.paidButton.TabIndex = 12
        Me.paidButton.Text = "Paid"
        Me.paidButton.UseVisualStyleBackColor = True
        '
        'creditButton
        '
        Me.creditButton.Location = New System.Drawing.Point(29, 47)
        Me.creditButton.Name = "creditButton"
        Me.creditButton.Size = New System.Drawing.Size(86, 26)
        Me.creditButton.TabIndex = 14
        Me.creditButton.Text = "Credit"
        Me.creditButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.totalLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(658, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 51)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PHP"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.totalLabel.Location = New System.Drawing.Point(14, 18)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(20, 22)
        Me.totalLabel.TabIndex = 0
        Me.totalLabel.Text = "0"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.enterTenderedButton)
        Me.GroupBox2.Controls.Add(Me.tenderedAmountTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(658, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 74)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tendered Amount"
        '
        'enterTenderedButton
        '
        Me.enterTenderedButton.Location = New System.Drawing.Point(29, 45)
        Me.enterTenderedButton.Name = "enterTenderedButton"
        Me.enterTenderedButton.Size = New System.Drawing.Size(75, 23)
        Me.enterTenderedButton.TabIndex = 9
        Me.enterTenderedButton.Text = "Enter"
        Me.enterTenderedButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.changeLabel)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(658, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(136, 51)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Change"
        '
        'changeLabel
        '
        Me.changeLabel.AutoSize = True
        Me.changeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.changeLabel.Location = New System.Drawing.Point(14, 18)
        Me.changeLabel.Name = "changeLabel"
        Me.changeLabel.Size = New System.Drawing.Size(20, 22)
        Me.changeLabel.TabIndex = 2
        Me.changeLabel.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PHP"
        '
        'tblposDataGrid
        '
        Me.tblposDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tblposDataGrid.Location = New System.Drawing.Point(15, 19)
        Me.tblposDataGrid.Name = "tblposDataGrid"
        Me.tblposDataGrid.ReadOnly = True
        Me.tblposDataGrid.Size = New System.Drawing.Size(637, 357)
        Me.tblposDataGrid.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.Location = New System.Drawing.Point(728, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 41)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Remove Item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 10
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.creditButton)
        Me.GroupBox4.Location = New System.Drawing.Point(658, 292)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(136, 84)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Enter Customer Name"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.tblposDataGrid)
        Me.GroupBox5.Controls.Add(Me.GroupBox4)
        Me.GroupBox5.Controls.Add(Me.newItemButton)
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.paidButton)
        Me.GroupBox5.Controls.Add(Me.GroupBox3)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Controls.Add(Me.GroupBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 1)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(805, 392)
        Me.GroupBox5.TabIndex = 23
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button2)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.DataGridView1)
        Me.GroupBox6.Controls.Add(Me.productSearch)
        Me.GroupBox6.Controls.Add(Me.searchInput)
        Me.GroupBox6.Controls.Add(Me.productRegister)
        Me.GroupBox6.Controls.Add(Me.productAmount)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Location = New System.Drawing.Point(126, 78)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(561, 253)
        Me.GroupBox6.TabIndex = 26
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Product Name or Barcode: "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(10, 42)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(540, 156)
        Me.DataGridView1.TabIndex = 0
        '
        'productSearch
        '
        Me.productSearch.Location = New System.Drawing.Point(423, 13)
        Me.productSearch.Name = "productSearch"
        Me.productSearch.Size = New System.Drawing.Size(127, 20)
        Me.productSearch.TabIndex = 6
        Me.productSearch.Text = "Search"
        Me.productSearch.UseVisualStyleBackColor = True
        '
        'searchInput
        '
        Me.searchInput.Cursor = System.Windows.Forms.Cursors.Default
        Me.searchInput.Location = New System.Drawing.Point(143, 14)
        Me.searchInput.Name = "searchInput"
        Me.searchInput.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.searchInput.Size = New System.Drawing.Size(246, 20)
        Me.searchInput.TabIndex = 1
        '
        'productRegister
        '
        Me.productRegister.Location = New System.Drawing.Point(423, 204)
        Me.productRegister.Name = "productRegister"
        Me.productRegister.Size = New System.Drawing.Size(127, 38)
        Me.productRegister.TabIndex = 5
        Me.productRegister.Text = "Register"
        Me.productRegister.UseVisualStyleBackColor = True
        '
        'productAmount
        '
        Me.productAmount.Cursor = System.Windows.Forms.Cursors.Default
        Me.productAmount.Location = New System.Drawing.Point(334, 210)
        Me.productAmount.Name = "productAmount"
        Me.productAmount.Size = New System.Drawing.Size(83, 20)
        Me.productAmount.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Amount:"
        '
        'posForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 393)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Name = "posForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Point of Sale"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.tblposDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents newItemButton As Button
    Friend WithEvents tenderedAmountTextBox As TextBox
    Friend WithEvents paidButton As Button
    Friend WithEvents creditButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tblposDataGrid As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents enterTenderedButton As Button
    Friend WithEvents changeLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents productSearch As Button
    Friend WithEvents searchInput As TextBox
    Friend WithEvents productRegister As Button
    Friend WithEvents productAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class
