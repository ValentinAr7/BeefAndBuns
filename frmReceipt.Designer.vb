<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblOrderRef = New System.Windows.Forms.Label()
        Me.lblCurrentDateTime = New System.Windows.Forms.Label()
        Me.lblDeliveryDateTime = New System.Windows.Forms.Label()
        Me.lblOrderRefrence = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlAddressInfo = New System.Windows.Forms.Panel()
        Me.lblDeliveryDate = New System.Windows.Forms.Label()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblOrderTotal = New System.Windows.Forms.Label()
        Me.lblOrderDeposit = New System.Windows.Forms.Label()
        Me.lblOrderQuantity = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnKitchenReceipt = New System.Windows.Forms.Button()
        Me.btnCustomerReceipt = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblDeliveryMessage = New System.Windows.Forms.Label()
        Me.lvwOrder = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAddressInfo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(201, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(81, 24)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Receipt"
        '
        'lblOrderRef
        '
        Me.lblOrderRef.AutoSize = True
        Me.lblOrderRef.Location = New System.Drawing.Point(21, 102)
        Me.lblOrderRef.Name = "lblOrderRef"
        Me.lblOrderRef.Size = New System.Drawing.Size(53, 13)
        Me.lblOrderRef.TabIndex = 1
        Me.lblOrderRef.Text = "Order Ref"
        '
        'lblCurrentDateTime
        '
        Me.lblCurrentDateTime.AutoSize = True
        Me.lblCurrentDateTime.Location = New System.Drawing.Point(89, 130)
        Me.lblCurrentDateTime.Name = "lblCurrentDateTime"
        Me.lblCurrentDateTime.Size = New System.Drawing.Size(105, 13)
        Me.lblCurrentDateTime.TabIndex = 2
        Me.lblCurrentDateTime.Text = "Inserted current date"
        '
        'lblDeliveryDateTime
        '
        Me.lblDeliveryDateTime.AutoSize = True
        Me.lblDeliveryDateTime.Location = New System.Drawing.Point(21, 130)
        Me.lblDeliveryDateTime.Name = "lblDeliveryDateTime"
        Me.lblDeliveryDateTime.Size = New System.Drawing.Size(30, 13)
        Me.lblDeliveryDateTime.TabIndex = 3
        Me.lblDeliveryDateTime.Text = "Date"
        '
        'lblOrderRefrence
        '
        Me.lblOrderRefrence.AutoSize = True
        Me.lblOrderRefrence.Location = New System.Drawing.Point(89, 102)
        Me.lblOrderRefrence.Name = "lblOrderRefrence"
        Me.lblOrderRefrence.Size = New System.Drawing.Size(121, 13)
        Me.lblOrderRefrence.TabIndex = 4
        Me.lblOrderRefrence.Text = "Inserted Order Refrence"
        '
        'picLogo
        '
        Me.picLogo.Image = Global.BeefAndBuns.My.Resources.Resources.BeefBunsLogo1
        Me.picLogo.Location = New System.Drawing.Point(397, 3)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(68, 59)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 5
        Me.picLogo.TabStop = False
        '
        'pnlAddressInfo
        '
        Me.pnlAddressInfo.Controls.Add(Me.lblDeliveryDate)
        Me.pnlAddressInfo.Controls.Add(Me.lblTelephone)
        Me.pnlAddressInfo.Controls.Add(Me.lblAddress2)
        Me.pnlAddressInfo.Controls.Add(Me.lblAddress1)
        Me.pnlAddressInfo.Controls.Add(Me.Label5)
        Me.pnlAddressInfo.Controls.Add(Me.Label3)
        Me.pnlAddressInfo.Controls.Add(Me.Label1)
        Me.pnlAddressInfo.Location = New System.Drawing.Point(261, 89)
        Me.pnlAddressInfo.Name = "pnlAddressInfo"
        Me.pnlAddressInfo.Size = New System.Drawing.Size(259, 112)
        Me.pnlAddressInfo.TabIndex = 6
        Me.pnlAddressInfo.Visible = False
        '
        'lblDeliveryDate
        '
        Me.lblDeliveryDate.AutoSize = True
        Me.lblDeliveryDate.Location = New System.Drawing.Point(89, 78)
        Me.lblDeliveryDate.Name = "lblDeliveryDate"
        Me.lblDeliveryDate.Size = New System.Drawing.Size(71, 13)
        Me.lblDeliveryDate.TabIndex = 7
        Me.lblDeliveryDate.Text = "Inserted Time"
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(89, 52)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(88, 13)
        Me.lblTelephone.TabIndex = 7
        Me.lblTelephone.Text = "Inserted Contact "
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.Location = New System.Drawing.Point(89, 26)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(165, 13)
        Me.lblAddress2.TabIndex = 8
        Me.lblAddress2.Text = "Inserted Town, County, Postcode"
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.Location = New System.Drawing.Point(89, 13)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(127, 13)
        Me.lblAddress1.TabIndex = 9
        Me.lblAddress1.Text = "Inserted Street and Town"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Delivery By:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Telephone:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Address:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOrderTotal, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOrderDeposit, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOrderQuantity, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBalance, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPayment, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(320, 431)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 122)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(112, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "£0.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(33, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "£0.00"
        Me.Label7.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(112, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "0"
        '
        'lblOrderTotal
        '
        Me.lblOrderTotal.AutoSize = True
        Me.lblOrderTotal.Location = New System.Drawing.Point(3, 24)
        Me.lblOrderTotal.Name = "lblOrderTotal"
        Me.lblOrderTotal.Size = New System.Drawing.Size(54, 13)
        Me.lblOrderTotal.TabIndex = 1
        Me.lblOrderTotal.Text = "Total cost"
        '
        'lblOrderDeposit
        '
        Me.lblOrderDeposit.AutoSize = True
        Me.lblOrderDeposit.Location = New System.Drawing.Point(3, 48)
        Me.lblOrderDeposit.Name = "lblOrderDeposit"
        Me.lblOrderDeposit.Size = New System.Drawing.Size(43, 13)
        Me.lblOrderDeposit.TabIndex = 2
        Me.lblOrderDeposit.Text = "Deposit"
        '
        'lblOrderQuantity
        '
        Me.lblOrderQuantity.AutoSize = True
        Me.lblOrderQuantity.Location = New System.Drawing.Point(3, 0)
        Me.lblOrderQuantity.Name = "lblOrderQuantity"
        Me.lblOrderQuantity.Size = New System.Drawing.Size(90, 17)
        Me.lblOrderQuantity.TabIndex = 0
        Me.lblOrderQuantity.Text = "Number of Meals"
        Me.lblOrderQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblOrderQuantity.UseCompatibleTextRendering = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(112, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "£0.00"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(3, 96)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(46, 13)
        Me.lblBalance.TabIndex = 9
        Me.lblBalance.Text = "Balance"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(3, 72)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(67, 13)
        Me.lblPayment.TabIndex = 9
        Me.lblPayment.Text = "Amount Paid"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(112, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "£0.00"
        '
        'pnlButtons
        '
        Me.pnlButtons.Controls.Add(Me.btnExit)
        Me.pnlButtons.Controls.Add(Me.btnKitchenReceipt)
        Me.pnlButtons.Controls.Add(Me.btnCustomerReceipt)
        Me.pnlButtons.Location = New System.Drawing.Point(24, 574)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(496, 42)
        Me.pnlButtons.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(379, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 36)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnKitchenReceipt
        '
        Me.btnKitchenReceipt.Location = New System.Drawing.Point(181, 2)
        Me.btnKitchenReceipt.Name = "btnKitchenReceipt"
        Me.btnKitchenReceipt.Size = New System.Drawing.Size(154, 39)
        Me.btnKitchenReceipt.TabIndex = 1
        Me.btnKitchenReceipt.Text = "Print Kitchen Receipt"
        Me.btnKitchenReceipt.UseVisualStyleBackColor = True
        '
        'btnCustomerReceipt
        '
        Me.btnCustomerReceipt.Location = New System.Drawing.Point(3, 3)
        Me.btnCustomerReceipt.Name = "btnCustomerReceipt"
        Me.btnCustomerReceipt.Size = New System.Drawing.Size(153, 36)
        Me.btnCustomerReceipt.TabIndex = 0
        Me.btnCustomerReceipt.Text = "Print Customer Receipt"
        Me.btnCustomerReceipt.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(264, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Customer"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(323, 73)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(123, 13)
        Me.lblCustomerName.TabIndex = 11
        Me.lblCustomerName.Text = "Inserted Customer Name"
        '
        'lblDeliveryMessage
        '
        Me.lblDeliveryMessage.AutoSize = True
        Me.lblDeliveryMessage.Location = New System.Drawing.Point(9, 446)
        Me.lblDeliveryMessage.Name = "lblDeliveryMessage"
        Me.lblDeliveryMessage.Size = New System.Drawing.Size(305, 26)
        Me.lblDeliveryMessage.TabIndex = 12
        Me.lblDeliveryMessage.Text = "A delivery charge of £3 has been added to your order." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " You are required to pay t" &
    "he balance upon delivery of the order."
        Me.lblDeliveryMessage.Visible = False
        '
        'lvwOrder
        '
        Me.lvwOrder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lvwOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwOrder.FullRowSelect = True
        Me.lvwOrder.Location = New System.Drawing.Point(-6, 207)
        Me.lvwOrder.Name = "lvwOrder"
        Me.lvwOrder.Size = New System.Drawing.Size(545, 209)
        Me.lvwOrder.TabIndex = 36
        Me.lvwOrder.UseCompatibleStateImageBehavior = False
        Me.lvwOrder.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Burger Meal"
        Me.ColumnHeader1.Width = 79
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Burger Size"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 53
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Onions"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Bacon"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Coleslaw"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Ketchup"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Cheese"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Quantity"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 54
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Meal Cost"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader9.Width = 100
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 686)
        Me.Controls.Add(Me.lvwOrder)
        Me.Controls.Add(Me.lblDeliveryMessage)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.pnlAddressInfo)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblOrderRefrence)
        Me.Controls.Add(Me.lblDeliveryDateTime)
        Me.Controls.Add(Me.lblCurrentDateTime)
        Me.Controls.Add(Me.lblOrderRef)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmReceipt"
        Me.Text = "frmReceipt"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAddressInfo.ResumeLayout(False)
        Me.pnlAddressInfo.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblOrderRef As Label
    Friend WithEvents lblCurrentDateTime As Label
    Friend WithEvents lblDeliveryDateTime As Label
    Friend WithEvents lblOrderRefrence As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents pnlAddressInfo As Panel
    Friend WithEvents lblDeliveryDate As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblAddress2 As Label
    Friend WithEvents lblAddress1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblBalance As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblOrderQuantity As Label
    Friend WithEvents lblOrderTotal As Label
    Friend WithEvents lblOrderDeposit As Label
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnKitchenReceipt As Button
    Friend WithEvents btnCustomerReceipt As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblDeliveryMessage As Label
    Friend WithEvents lvwOrder As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
