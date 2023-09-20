<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.variation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addprodButton = New System.Windows.Forms.Button()
        Me.itemPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.itemName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.infoVariation = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.infoQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.infoPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.infoName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.barcode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.barcodeInfo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(529, 410)
        Me.DataGridView1.TabIndex = 0
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(547, 12)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(126, 36)
        Me.refreshButton.TabIndex = 1
        Me.refreshButton.Text = "Refresh (F5)"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.barcode)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.variation)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.addprodButton)
        Me.GroupBox2.Controls.Add(Me.itemPrice)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.itemName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(546, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(256, 167)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add New Product"
        '
        'variation
        '
        Me.variation.Location = New System.Drawing.Point(76, 77)
        Me.variation.Name = "variation"
        Me.variation.Size = New System.Drawing.Size(170, 20)
        Me.variation.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Variation: "
        '
        'addprodButton
        '
        Me.addprodButton.Location = New System.Drawing.Point(141, 129)
        Me.addprodButton.Name = "addprodButton"
        Me.addprodButton.Size = New System.Drawing.Size(105, 28)
        Me.addprodButton.TabIndex = 4
        Me.addprodButton.Text = "Add"
        Me.addprodButton.UseVisualStyleBackColor = True
        '
        'itemPrice
        '
        Me.itemPrice.Location = New System.Drawing.Point(76, 103)
        Me.itemPrice.Name = "itemPrice"
        Me.itemPrice.Size = New System.Drawing.Size(170, 20)
        Me.itemPrice.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Price: "
        '
        'itemName
        '
        Me.itemName.Location = New System.Drawing.Point(76, 51)
        Me.itemName.Name = "itemName"
        Me.itemName.Size = New System.Drawing.Size(170, 20)
        Me.itemName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Name: "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.barcodeInfo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.infoVariation)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.infoQuantity)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.updateButton)
        Me.GroupBox3.Controls.Add(Me.infoPrice)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.infoName)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(546, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 195)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Change Product Information"
        '
        'infoVariation
        '
        Me.infoVariation.Location = New System.Drawing.Point(76, 79)
        Me.infoVariation.Name = "infoVariation"
        Me.infoVariation.Size = New System.Drawing.Size(170, 20)
        Me.infoVariation.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Variation: "
        '
        'infoQuantity
        '
        Me.infoQuantity.Location = New System.Drawing.Point(76, 105)
        Me.infoQuantity.Name = "infoQuantity"
        Me.infoQuantity.Size = New System.Drawing.Size(170, 20)
        Me.infoQuantity.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantity: "
        '
        'updateButton
        '
        Me.updateButton.Location = New System.Drawing.Point(140, 157)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(105, 28)
        Me.updateButton.TabIndex = 7
        Me.updateButton.Text = "Update"
        Me.updateButton.UseVisualStyleBackColor = True
        '
        'infoPrice
        '
        Me.infoPrice.Location = New System.Drawing.Point(76, 131)
        Me.infoPrice.Name = "infoPrice"
        Me.infoPrice.Size = New System.Drawing.Size(170, 20)
        Me.infoPrice.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Price:"
        '
        'infoName
        '
        Me.infoName.Location = New System.Drawing.Point(76, 53)
        Me.infoName.Name = "infoName"
        Me.infoName.Size = New System.Drawing.Size(170, 20)
        Me.infoName.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Item Name: "
        '
        'deleteButton
        '
        Me.deleteButton.Location = New System.Drawing.Point(677, 12)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(126, 36)
        Me.deleteButton.TabIndex = 8
        Me.deleteButton.Text = "Delete (DEL)"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'barcode
        '
        Me.barcode.Location = New System.Drawing.Point(76, 25)
        Me.barcode.Name = "barcode"
        Me.barcode.Size = New System.Drawing.Size(170, 20)
        Me.barcode.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Barcode: "
        '
        'barcodeInfo
        '
        Me.barcodeInfo.Location = New System.Drawing.Point(76, 27)
        Me.barcodeInfo.Name = "barcodeInfo"
        Me.barcodeInfo.Size = New System.Drawing.Size(170, 20)
        Me.barcodeInfo.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Barcode:"
        '
        'productsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 434)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "productsForm"
        Me.Text = "Products"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents refreshButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents itemPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents itemName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents addprodButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents updateButton As Button
    Friend WithEvents infoPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents infoName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents infoQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents deleteButton As Button
    Friend WithEvents variation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents infoVariation As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents barcode As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents barcodeInfo As TextBox
    Friend WithEvents Label9 As Label
End Class
