<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class productSelection
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.searchInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.productAmount = New System.Windows.Forms.TextBox()
        Me.productRegister = New System.Windows.Forms.Button()
        Me.productSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        'searchInput
        '
        Me.searchInput.Cursor = System.Windows.Forms.Cursors.Default
        Me.searchInput.Location = New System.Drawing.Point(94, 13)
        Me.searchInput.Name = "searchInput"
        Me.searchInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.searchInput.Size = New System.Drawing.Size(323, 20)
        Me.searchInput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Product Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Amount:"
        '
        'productAmount
        '
        Me.productAmount.Cursor = System.Windows.Forms.Cursors.Default
        Me.productAmount.Location = New System.Drawing.Point(334, 210)
        Me.productAmount.Name = "productAmount"
        Me.productAmount.Size = New System.Drawing.Size(83, 20)
        Me.productAmount.TabIndex = 3
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
        'productSearch
        '
        Me.productSearch.Location = New System.Drawing.Point(423, 13)
        Me.productSearch.Name = "productSearch"
        Me.productSearch.Size = New System.Drawing.Size(127, 20)
        Me.productSearch.TabIndex = 6
        Me.productSearch.Text = "Search"
        Me.productSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.productSearch)
        Me.GroupBox1.Controls.Add(Me.searchInput)
        Me.GroupBox1.Controls.Add(Me.productRegister)
        Me.GroupBox1.Controls.Add(Me.productAmount)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 250)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'productSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 267)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "productSelection"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents searchInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents productAmount As TextBox
    Friend WithEvents productRegister As Button
    Friend WithEvents productSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
