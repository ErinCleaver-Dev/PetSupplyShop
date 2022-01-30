<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ProductList = New System.Windows.Forms.ListBox()
        Me.lblPetSupplyShop = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.Quantity = New System.Windows.Forms.ColumnHeader()
        Me.ItemPrice = New System.Windows.Forms.ColumnHeader()
        Me.Price = New System.Windows.Forms.ColumnHeader()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblCheckOut = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bntAddToCart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.BntCheckOut = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ProductList
        '
        Me.ProductList.FormattingEnabled = True
        Me.ProductList.ItemHeight = 15
        Me.ProductList.Items.AddRange(New Object() {"Dry Cat Food", "Wet Cat Food", "mouses", "Bird Food", "Dry dog food", "Wet Dog food", "Cat litter", "Puppy pads", "pets"})
        Me.ProductList.Location = New System.Drawing.Point(12, 110)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.Size = New System.Drawing.Size(126, 169)
        Me.ProductList.TabIndex = 0
        '
        'lblPetSupplyShop
        '
        Me.lblPetSupplyShop.AutoSize = True
        Me.lblPetSupplyShop.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPetSupplyShop.Location = New System.Drawing.Point(52, 9)
        Me.lblPetSupplyShop.Name = "lblPetSupplyShop"
        Me.lblPetSupplyShop.Size = New System.Drawing.Size(501, 86)
        Me.lblPetSupplyShop.TabIndex = 1
        Me.lblPetSupplyShop.Text = "Pet Supply Shop"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.Quantity, Me.ItemPrice, Me.Price})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(165, 110)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(454, 373)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Name = "ColumnHeader1"
        Me.ColumnHeader1.Text = "Product Name"
        Me.ColumnHeader1.Width = 150
        '
        'Quantity
        '
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Text = "Quantity"
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Quantity.Width = 100
        '
        'ItemPrice
        '
        Me.ItemPrice.Name = "ItemPrice"
        Me.ItemPrice.Text = "Item Price"
        Me.ItemPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ItemPrice.Width = 100
        '
        'Price
        '
        Me.Price.Name = "Price"
        Me.Price.Text = "Price"
        Me.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Price.Width = 100
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(12, 293)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(53, 15)
        Me.lblQuantity.TabIndex = 4
        Me.lblQuantity.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(72, 293)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(66, 23)
        Me.txtQuantity.TabIndex = 5
        '
        'lblCheckOut
        '
        Me.lblCheckOut.AutoSize = True
        Me.lblCheckOut.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCheckOut.Location = New System.Drawing.Point(705, 110)
        Me.lblCheckOut.Name = "lblCheckOut"
        Me.lblCheckOut.Size = New System.Drawing.Size(126, 32)
        Me.lblCheckOut.TabIndex = 6
        Me.lblCheckOut.Text = "Check Out"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(736, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cash Only"
        '
        'bntAddToCart
        '
        Me.bntAddToCart.Location = New System.Drawing.Point(12, 348)
        Me.bntAddToCart.Name = "bntAddToCart"
        Me.bntAddToCart.Size = New System.Drawing.Size(135, 23)
        Me.bntAddToCart.TabIndex = 8
        Me.bntAddToCart.Text = "Add To Cart"
        Me.bntAddToCart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(661, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total"
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(731, 180)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(100, 23)
        Me.TxtTotal.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(661, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cash"
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(731, 219)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(100, 23)
        Me.txtCash.TabIndex = 12
        '
        'BntCheckOut
        '
        Me.BntCheckOut.Location = New System.Drawing.Point(722, 256)
        Me.BntCheckOut.Name = "BntCheckOut"
        Me.BntCheckOut.Size = New System.Drawing.Size(75, 23)
        Me.BntCheckOut.TabIndex = 13
        Me.BntCheckOut.Text = "Check Out"
        Me.BntCheckOut.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(705, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 30)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Change Given"
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Location = New System.Drawing.Point(681, 332)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(52, 15)
        Me.lblQuarters.TabIndex = 15
        Me.lblQuarters.Text = "Quarters"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(763, 329)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(84, 23)
        Me.TextBox1.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(763, 363)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(84, 23)
        Me.TextBox2.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(681, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Dimes"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(763, 401)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(84, 23)
        Me.TextBox3.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(681, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Nickels"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(763, 440)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(84, 23)
        Me.TextBox4.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(681, 443)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Pennies"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 508)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BntCheckOut)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bntAddToCart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblCheckOut)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPetSupplyShop)
        Me.Controls.Add(Me.ProductList)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductList As ListBox
    Friend WithEvents lblPetSupplyShop As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Product As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents ItemPrice As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblCheckOut As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents bntAddToCart As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCash As TextBox
    Friend WithEvents BntCheckOut As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblQuarters As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
End Class
