Public Class frmPayment
    '---------------------------- FORM WIDE DATA STORAGE ------------------------------
    Dim DeliveryChargeAdded As Boolean = False

    '--------------------- PROGRAMMER DEFINECD PROCEDURES AND FUNCTIONS ----------------------
    Private Sub ClearCardDetails()
        gbxCardDetails.Hide()
        txtCardName.Clear()
        txtCardNumber.Clear()
        txtCheckDigit.Clear()
    End Sub
    '-------------------------- EVENT RELATED PROCEDURES ------------------------------
    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOrderQuantity.Text = TotalQuantity
        lblOrderTotal.Text = FormatCurrency(TotalCost)
        lblOrderMessage.Text = "You are required to pay the full value of the order = " & FormatCurrency(TotalCost)
        lblOrderMessage.Show()

    End Sub

    Private Sub rbnPickUp_CheckedChanged(sender As Object, e As EventArgs) Handles rbnPickUp.CheckedChanged
        If rbnPickUp.Checked Then
            If DeliveryChargeAdded = True Then
                TotalCost = TotalCost - 3
            End If
            Deposit = 0
            lblOrderTotal.Text = FormatCurrency(TotalCost)
            lblOrderMessage.Text = "You are required to pay the full value of the order = " & FormatCurrency(TotalCost)
            lblOrderMessage.Show()
            DeliveryChargeAdded = False
            pnlDeliveryDetails.Hide()
            txtAmount.Focus()
        End If
    End Sub

    Private Sub rbnDelivery_CheckedChanged(sender As Object, e As EventArgs) Handles rbnDelivery.CheckedChanged
        If rbnDelivery.Checked Then
            TotalCost = TotalCost + 3
            Deposit = TotalCost * 0.1
            DeliveryChargeAdded = True
            lblOrderTotal.Text = FormatCurrency(TotalCost)
            lblOrderMessage.Text = "A charge of £3 has been added to your order. You are required to pay a 10% deposit of " & FormatCurrency(Deposit) & " now, and the remainder upon delivery"
            lblOrderMessage.Show()

            pnlDeliveryDetails.Show()
            txtCustomerName.Focus()

        End If
    End Sub

    Private Sub rbnCash_CheckedChanged(sender As Object, e As EventArgs) Handles rbnCash.CheckedChanged
        Call ClearCardDetails()
    End Sub

    Private Sub rbnCheque_CheckedChanged(sender As Object, e As EventArgs) Handles rbnCheque.CheckedChanged
        Call ClearCardDetails()
    End Sub

    Private Sub rbnDCCard_CheckedChanged(sender As Object, e As EventArgs) Handles rbnDCCard.CheckedChanged
        Call ClearCardDetails()
        If rbnDCCard.Checked Then
            gbxCardDetails.Show()
            txtCardNumber.Focus()
        End If
    End Sub

    Private Sub rbnPayPal_CheckedChanged(sender As Object, e As EventArgs) Handles rbnPayPal.CheckedChanged
        If rbnPayPal.Checked Then
            Call ClearCardDetails()
            Dim webAddress As String = "https://www.paypal.com/uk/webapps/mpp/home"
            Process.Start(webAddress)
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        TotalQuantity = 0
        TotalCost = 0
        OrderLines = 0
        Deposit = 0
        AmountPaid = 0

        frmOrder.Close()
        frmOrder.Show()
        Me.Close()
        frmOrder.Focus()
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        If txtAmount.Text.Trim() = "" Then
            MessageBox.Show("Please Enter Correct Amount")
            Exit Sub

        End If

        If Not IsNumeric(txtAmount.Text.Trim) Then
            MessageBox.Show("Please Enter Correct Amount")
            txtAmount.Clear()
            Exit Sub
        End If

        If rbnPickUp.Checked Then
            Dim CopyAmount As Decimal = Decimal.Parse(txtAmount.Text)
            If CopyAmount <> TotalCost Then
                MessageBox.Show("You must pay the full amount. Please Re-Enter Amount")
                txtAmount.Clear()
                txtAmount.Focus()
                Exit Sub
            End If
        End If

        If rbnDelivery.Checked Then
            Dim CopyAmount As Decimal = Decimal.Parse(txtAmount.Text)
            If CopyAmount <> TotalCost Then
                MessageBox.Show("You must pay the deposit amount. Please Re-Enter Amount")
                txtAmount.Clear()
                txtAmount.Focus()
                Exit Sub
            End If
        End If

        If rbnDCCard.Checked Then
            For Each TextBox In gbxCardDetails.Controls
                If TextBox.Text = "" Then
                    MessageBox.Show("You must add full Debit/Credit card Details")
                    TextBox.Focus()
                End If
            Next
        End If

        If txtCustomerName.Text = "" Then
            MessageBox.Show("You add the customer's name")
            txtCustomerName.Focus()
            Exit Sub
        End If

        If rbnDelivery.Checked Then
            For Each TextBox In pnlDeliveryDetails.Controls
                If TextBox.Text = "" Then
                    MessageBox.Show("You must add full Delivery Details Info")
                    Exit Sub

                End If
            Next


            If dtpDeliveryDate.Value < Today Or dtpDeliveryDate.Value > DateTime.Now.AddDays(7) Then
                MessageBox.Show("Invalid Delivery Date")
                Exit Sub
            End If
        End If
        lblAddress1.Show()

    End Sub
End Class