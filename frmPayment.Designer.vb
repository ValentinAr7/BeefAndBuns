<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.gbxCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.pnlDeliveryDetails = New System.Windows.Forms.Panel()
        Me.txtPostCode = New System.Windows.Forms.MaskedTextBox()
        Me.dtpDeliveryTime = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtpDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.txtStreet = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.gbxPayments = New System.Windows.Forms.GroupBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.gbxCardDetails = New System.Windows.Forms.GroupBox()
        Me.nudExpiryYear = New System.Windows.Forms.NumericUpDown()
        Me.nudExpiryMonth = New System.Windows.Forms.NumericUpDown()
        Me.txtCardNumber = New System.Windows.Forms.MaskedTextBox()
        Me.txtCheckDigit = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCardName = New System.Windows.Forms.TextBox()
        Me.rbnPayPal = New System.Windows.Forms.RadioButton()
        Me.rbnDCCard = New System.Windows.Forms.RadioButton()
        Me.rbnCheque = New System.Windows.Forms.RadioButton()
        Me.rbnCash = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblOrderMessage = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbnDelivery = New System.Windows.Forms.RadioButton()
        Me.rbnPickUp = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOrderTotal = New System.Windows.Forms.Label()
        Me.lblOrderQuantity = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gbxCustomerDetails.SuspendLayout()
        Me.pnlDeliveryDetails.SuspendLayout()
        Me.gbxPayments.SuspendLayout()
        Me.gbxCardDetails.SuspendLayout()
        CType(Me.nudExpiryYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudExpiryMonth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnProcess)
        Me.Panel1.Controls.Add(Me.gbxCustomerDetails)
        Me.Panel1.Controls.Add(Me.gbxPayments)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblOrderMessage)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.rbnDelivery)
        Me.Panel1.Controls.Add(Me.rbnPickUp)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblOrderTotal)
        Me.Panel1.Controls.Add(Me.lblOrderQuantity)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(61, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 599)
        Me.Panel1.TabIndex = 70
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Maroon
        Me.btnCancel.Location = New System.Drawing.Point(431, 501)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(376, 53)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel Order"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnProcess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.ForeColor = System.Drawing.Color.Maroon
        Me.btnProcess.Location = New System.Drawing.Point(49, 501)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(376, 53)
        Me.btnProcess.TabIndex = 20
        Me.btnProcess.Text = "Process Order"
        Me.btnProcess.UseVisualStyleBackColor = False
        '
        'gbxCustomerDetails
        '
        Me.gbxCustomerDetails.Controls.Add(Me.txtCustomerName)
        Me.gbxCustomerDetails.Controls.Add(Me.pnlDeliveryDetails)
        Me.gbxCustomerDetails.Controls.Add(Me.Label16)
        Me.gbxCustomerDetails.Controls.Add(Me.Label17)
        Me.gbxCustomerDetails.Location = New System.Drawing.Point(430, 211)
        Me.gbxCustomerDetails.Name = "gbxCustomerDetails"
        Me.gbxCustomerDetails.Size = New System.Drawing.Size(367, 266)
        Me.gbxCustomerDetails.TabIndex = 63
        Me.gbxCustomerDetails.TabStop = False
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(84, 19)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(267, 26)
        Me.txtCustomerName.TabIndex = 12
        '
        'pnlDeliveryDetails
        '
        Me.pnlDeliveryDetails.Controls.Add(Me.txtPostCode)
        Me.pnlDeliveryDetails.Controls.Add(Me.dtpDeliveryTime)
        Me.pnlDeliveryDetails.Controls.Add(Me.Label19)
        Me.pnlDeliveryDetails.Controls.Add(Me.dtpDeliveryDate)
        Me.pnlDeliveryDetails.Controls.Add(Me.txtTelephone)
        Me.pnlDeliveryDetails.Controls.Add(Me.txtCounty)
        Me.pnlDeliveryDetails.Controls.Add(Me.txtTown)
        Me.pnlDeliveryDetails.Controls.Add(Me.txtStreet)
        Me.pnlDeliveryDetails.Controls.Add(Me.Label18)
        Me.pnlDeliveryDetails.Controls.Add(Me.Label15)
        Me.pnlDeliveryDetails.Controls.Add(Me.Label14)
        Me.pnlDeliveryDetails.Controls.Add(Me.Label13)
        Me.pnlDeliveryDetails.Controls.Add(Me.Label9)
        Me.pnlDeliveryDetails.Controls.Add(Me.Label6)
        Me.pnlDeliveryDetails.Location = New System.Drawing.Point(9, 48)
        Me.pnlDeliveryDetails.Name = "pnlDeliveryDetails"
        Me.pnlDeliveryDetails.Size = New System.Drawing.Size(357, 212)
        Me.pnlDeliveryDetails.TabIndex = 29
        Me.pnlDeliveryDetails.Visible = False
        '
        'txtPostCode
        '
        Me.txtPostCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostCode.Location = New System.Drawing.Point(76, 102)
        Me.txtPostCode.Mask = ">LL09 0LL"
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(79, 26)
        Me.txtPostCode.TabIndex = 16
        '
        'dtpDeliveryTime
        '
        Me.dtpDeliveryTime.CustomFormat = "hh:mm tt"
        Me.dtpDeliveryTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeliveryTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDeliveryTime.Location = New System.Drawing.Point(234, 179)
        Me.dtpDeliveryTime.Name = "dtpDeliveryTime"
        Me.dtpDeliveryTime.ShowUpDown = True
        Me.dtpDeliveryTime.Size = New System.Drawing.Size(108, 26)
        Me.dtpDeliveryTime.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label19.Location = New System.Drawing.Point(198, 187)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 13)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Time:"
        '
        'dtpDeliveryDate
        '
        Me.dtpDeliveryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDeliveryDate.Location = New System.Drawing.Point(76, 179)
        Me.dtpDeliveryDate.Name = "dtpDeliveryDate"
        Me.dtpDeliveryDate.Size = New System.Drawing.Size(108, 26)
        Me.dtpDeliveryDate.TabIndex = 18
        '
        'txtTelephone
        '
        Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(76, 147)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(170, 26)
        Me.txtTelephone.TabIndex = 17
        '
        'txtCounty
        '
        Me.txtCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCounty.Location = New System.Drawing.Point(76, 72)
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(168, 26)
        Me.txtCounty.TabIndex = 15
        '
        'txtTown
        '
        Me.txtTown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTown.Location = New System.Drawing.Point(76, 43)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(168, 26)
        Me.txtTown.TabIndex = 14
        '
        'txtStreet
        '
        Me.txtStreet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreet.Location = New System.Drawing.Point(76, 14)
        Me.txtStreet.Name = "txtStreet"
        Me.txtStreet.Size = New System.Drawing.Size(266, 26)
        Me.txtStreet.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(3, 186)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Delivery Date:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(4, 155)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(65, 13)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Tel Contact:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(4, 110)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Post Code:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(4, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "County:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(4, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Town:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(4, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Street:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Customer Details"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(12, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(38, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "Name:"
        '
        'gbxPayments
        '
        Me.gbxPayments.Controls.Add(Me.txtAmount)
        Me.gbxPayments.Controls.Add(Me.gbxCardDetails)
        Me.gbxPayments.Controls.Add(Me.rbnPayPal)
        Me.gbxPayments.Controls.Add(Me.rbnDCCard)
        Me.gbxPayments.Controls.Add(Me.rbnCheque)
        Me.gbxPayments.Controls.Add(Me.rbnCash)
        Me.gbxPayments.Controls.Add(Me.Label11)
        Me.gbxPayments.Controls.Add(Me.Label24)
        Me.gbxPayments.Controls.Add(Me.Label25)
        Me.gbxPayments.Location = New System.Drawing.Point(48, 211)
        Me.gbxPayments.Name = "gbxPayments"
        Me.gbxPayments.Size = New System.Drawing.Size(367, 266)
        Me.gbxPayments.TabIndex = 62
        Me.gbxPayments.TabStop = False
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(79, 16)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 26)
        Me.txtAmount.TabIndex = 3
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbxCardDetails
        '
        Me.gbxCardDetails.Controls.Add(Me.nudExpiryYear)
        Me.gbxCardDetails.Controls.Add(Me.nudExpiryMonth)
        Me.gbxCardDetails.Controls.Add(Me.txtCardNumber)
        Me.gbxCardDetails.Controls.Add(Me.txtCheckDigit)
        Me.gbxCardDetails.Controls.Add(Me.Label7)
        Me.gbxCardDetails.Controls.Add(Me.Label8)
        Me.gbxCardDetails.Controls.Add(Me.Label10)
        Me.gbxCardDetails.Controls.Add(Me.Label12)
        Me.gbxCardDetails.Controls.Add(Me.txtCardName)
        Me.gbxCardDetails.Location = New System.Drawing.Point(9, 91)
        Me.gbxCardDetails.Name = "gbxCardDetails"
        Me.gbxCardDetails.Size = New System.Drawing.Size(345, 121)
        Me.gbxCardDetails.TabIndex = 41
        Me.gbxCardDetails.TabStop = False
        Me.gbxCardDetails.Text = "Card Details"
        Me.gbxCardDetails.Visible = False
        '
        'nudExpiryYear
        '
        Me.nudExpiryYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudExpiryYear.Location = New System.Drawing.Point(123, 86)
        Me.nudExpiryYear.Maximum = New Decimal(New Integer() {2025, 0, 0, 0})
        Me.nudExpiryYear.Minimum = New Decimal(New Integer() {2014, 0, 0, 0})
        Me.nudExpiryYear.Name = "nudExpiryYear"
        Me.nudExpiryYear.Size = New System.Drawing.Size(59, 26)
        Me.nudExpiryYear.TabIndex = 67
        Me.nudExpiryYear.Value = New Decimal(New Integer() {2014, 0, 0, 0})
        '
        'nudExpiryMonth
        '
        Me.nudExpiryMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudExpiryMonth.Location = New System.Drawing.Point(67, 86)
        Me.nudExpiryMonth.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudExpiryMonth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudExpiryMonth.Name = "nudExpiryMonth"
        Me.nudExpiryMonth.Size = New System.Drawing.Size(50, 26)
        Me.nudExpiryMonth.TabIndex = 66
        Me.nudExpiryMonth.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardNumber.Location = New System.Drawing.Point(67, 54)
        Me.txtCardNumber.Mask = "0000-0000-0000-0000"
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(168, 26)
        Me.txtCardNumber.TabIndex = 9
        '
        'txtCheckDigit
        '
        Me.txtCheckDigit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckDigit.Location = New System.Drawing.Point(299, 55)
        Me.txtCheckDigit.Mask = "000"
        Me.txtCheckDigit.Name = "txtCheckDigit"
        Me.txtCheckDigit.Size = New System.Drawing.Size(35, 26)
        Me.txtCheckDigit.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Expiry Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(261, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "CVV"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Number:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(7, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Name:"
        '
        'txtCardName
        '
        Me.txtCardName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCardName.Location = New System.Drawing.Point(67, 25)
        Me.txtCardName.Name = "txtCardName"
        Me.txtCardName.Size = New System.Drawing.Size(267, 26)
        Me.txtCardName.TabIndex = 8
        '
        'rbnPayPal
        '
        Me.rbnPayPal.AutoSize = True
        Me.rbnPayPal.Location = New System.Drawing.Point(289, 58)
        Me.rbnPayPal.Name = "rbnPayPal"
        Me.rbnPayPal.Size = New System.Drawing.Size(57, 17)
        Me.rbnPayPal.TabIndex = 7
        Me.rbnPayPal.Text = "Paypal"
        Me.rbnPayPal.UseVisualStyleBackColor = True
        '
        'rbnDCCard
        '
        Me.rbnDCCard.AutoSize = True
        Me.rbnDCCard.Location = New System.Drawing.Point(176, 58)
        Me.rbnDCCard.Name = "rbnDCCard"
        Me.rbnDCCard.Size = New System.Drawing.Size(107, 17)
        Me.rbnDCCard.TabIndex = 6
        Me.rbnDCCard.Text = "Debit/Credit Card"
        Me.rbnDCCard.UseVisualStyleBackColor = True
        '
        'rbnCheque
        '
        Me.rbnCheque.AutoSize = True
        Me.rbnCheque.Location = New System.Drawing.Point(110, 58)
        Me.rbnCheque.Name = "rbnCheque"
        Me.rbnCheque.Size = New System.Drawing.Size(62, 17)
        Me.rbnCheque.TabIndex = 5
        Me.rbnCheque.Text = "Cheque"
        Me.rbnCheque.UseVisualStyleBackColor = True
        '
        'rbnCash
        '
        Me.rbnCash.AutoSize = True
        Me.rbnCash.Checked = True
        Me.rbnCash.Location = New System.Drawing.Point(62, 58)
        Me.rbnCash.Name = "rbnCash"
        Me.rbnCash.Size = New System.Drawing.Size(49, 17)
        Me.rbnCash.TabIndex = 4
        Me.rbnCash.TabStop = True
        Me.rbnCash.Text = "Cash"
        Me.rbnCash.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(6, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Method"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(6, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(98, 13)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Payment Details"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(6, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 13)
        Me.Label25.TabIndex = 22
        Me.Label25.Text = "Amount:      £"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(44, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 22)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "How do you wish to pay?"
        '
        'lblOrderMessage
        '
        Me.lblOrderMessage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderMessage.ForeColor = System.Drawing.Color.Red
        Me.lblOrderMessage.Location = New System.Drawing.Point(44, 98)
        Me.lblOrderMessage.Name = "lblOrderMessage"
        Me.lblOrderMessage.Size = New System.Drawing.Size(753, 57)
        Me.lblOrderMessage.TabIndex = 59
        Me.lblOrderMessage.Text = "This contains the required payment instruction"
        Me.lblOrderMessage.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(44, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(305, 22)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Please indicate your order type -"
        '
        'rbnDelivery
        '
        Me.rbnDelivery.AutoSize = True
        Me.rbnDelivery.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnDelivery.ForeColor = System.Drawing.Color.Black
        Me.rbnDelivery.Location = New System.Drawing.Point(461, 49)
        Me.rbnDelivery.Name = "rbnDelivery"
        Me.rbnDelivery.Size = New System.Drawing.Size(95, 28)
        Me.rbnDelivery.TabIndex = 2
        Me.rbnDelivery.Text = "Delivery"
        Me.rbnDelivery.UseVisualStyleBackColor = True
        '
        'rbnPickUp
        '
        Me.rbnPickUp.AutoSize = True
        Me.rbnPickUp.Checked = True
        Me.rbnPickUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbnPickUp.ForeColor = System.Drawing.Color.Black
        Me.rbnPickUp.Location = New System.Drawing.Point(364, 49)
        Me.rbnPickUp.Name = "rbnPickUp"
        Me.rbnPickUp.Size = New System.Drawing.Size(91, 28)
        Me.rbnPickUp.TabIndex = 1
        Me.rbnPickUp.TabStop = True
        Me.rbnPickUp.Text = "Pick-up"
        Me.rbnPickUp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(44, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 22)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Your order consists of"
        '
        'lblOrderTotal
        '
        Me.lblOrderTotal.BackColor = System.Drawing.Color.White
        Me.lblOrderTotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderTotal.Location = New System.Drawing.Point(537, 8)
        Me.lblOrderTotal.Name = "lblOrderTotal"
        Me.lblOrderTotal.Size = New System.Drawing.Size(86, 29)
        Me.lblOrderTotal.TabIndex = 53
        Me.lblOrderTotal.Text = "£0.00"
        Me.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOrderQuantity
        '
        Me.lblOrderQuantity.BackColor = System.Drawing.Color.White
        Me.lblOrderQuantity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderQuantity.Location = New System.Drawing.Point(259, 8)
        Me.lblOrderQuantity.Name = "lblOrderQuantity"
        Me.lblOrderQuantity.Size = New System.Drawing.Size(45, 29)
        Me.lblOrderQuantity.TabIndex = 51
        Me.lblOrderQuantity.Text = "0"
        Me.lblOrderQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(310, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 22)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "meals, at a total cost of"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Maroon
        Me.lblTitle.Location = New System.Drawing.Point(330, 40)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(288, 40)
        Me.lblTitle.TabIndex = 68
        Me.lblTitle.Text = "Order Payment"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(381, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 26)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Beef and Buns"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(975, 710)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPayment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbxCustomerDetails.ResumeLayout(False)
        Me.gbxCustomerDetails.PerformLayout()
        Me.pnlDeliveryDetails.ResumeLayout(False)
        Me.pnlDeliveryDetails.PerformLayout()
        Me.gbxPayments.ResumeLayout(False)
        Me.gbxPayments.PerformLayout()
        Me.gbxCardDetails.ResumeLayout(False)
        Me.gbxCardDetails.PerformLayout()
        CType(Me.nudExpiryYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudExpiryMonth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnProcess As Button
    Friend WithEvents gbxCustomerDetails As GroupBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents pnlDeliveryDetails As Panel
    Friend WithEvents txtPostCode As MaskedTextBox
    Friend WithEvents dtpDeliveryTime As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents dtpDeliveryDate As DateTimePicker
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents txtTown As TextBox
    Friend WithEvents txtStreet As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents gbxPayments As GroupBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents gbxCardDetails As GroupBox
    Friend WithEvents nudExpiryYear As NumericUpDown
    Friend WithEvents nudExpiryMonth As NumericUpDown
    Friend WithEvents txtCardNumber As MaskedTextBox
    Friend WithEvents txtCheckDigit As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCardName As TextBox
    Friend WithEvents rbnPayPal As RadioButton
    Friend WithEvents rbnDCCard As RadioButton
    Friend WithEvents rbnCheque As RadioButton
    Friend WithEvents rbnCash As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblOrderMessage As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rbnDelivery As RadioButton
    Friend WithEvents rbnPickUp As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOrderTotal As Label
    Friend WithEvents lblOrderQuantity As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label2 As Label
End Class
