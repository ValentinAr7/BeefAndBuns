Public Class frmReceipt

    '--------------------- USER DEFINECD PROCEDURES AND FUNCTIONS ----------------------
    Private Sub CopyAnotherOrderLine(ByVal IndexValue)
        Dim CopiedValue As String
        Dim Counter As Byte

        Dim lvi As New ListViewItem
        ' First Column can be the listview item's Text  

        CopiedValue = frmOrder.lvwOrder.Items.Item(IndexValue).SubItems(0).Text
        lvi.Text = CopiedValue

        For Counter = 1 To 8
            CopiedValue = frmOrder.lvwOrder.Items.Item(IndexValue).SubItems(Counter).Text
            lvi.SubItems.Add(CopiedValue)

        Next
        lvwOrder.Items.Add(lvi)
    End Sub






    '-------------------------- EVENT RELATED PROCEDURES ------------------------------
    Private Sub frmReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim scan As Byte

        Dim lvi As New ListViewItem
        ' First Column can be the listview item's Text  

        lblCustomerName.Text =
        lblCustomerName.Text = frmPayment.txtCustomerName.Text
        lblOrderRef.Text = CInt(Int((10001 * Rnd()) + 99999))
        lblCurrentDateTime.Text = Now()


        If frmPayment.rbnDelivery.Checked Then
            lblDeliveryMessage.Show()
            lblAddress1.Text = (frmPayment.txtStreet.Text) & ", " & (frmPayment.txtTown.Text)
            lblAddress2.Text = (frmPayment.txtCounty.Text) & ", " & (frmPayment.txtPostCode.Text)
            lblTelephone.Text = frmPayment.txtTelephone.Text
            lblDeliveryDateTime.Text = CStr(frmPayment.dtpDeliveryDate.Value.Date) & ", at " & frmPayment.dtpDeliveryTime.Value.ToString("HH:mm tt")

            pnlAddressInfo.Show()
        Else
            lblDeliveryMessage.Hide()
            pnlAddressInfo.Hide()
        End If

        Do While scan < OrderLines
            Call CopyAnotherOrderLine(scan)
            scan = scan + 1
        Loop
        lblOrderQuantity.Text = TotalQuantity
        lblOrderTotal.Text = FormatCurrency(TotalCost)
        lblOrderDeposit.Text = FormatCurrency(Deposit)
        lblPayment.Text = FormatCurrency(AmountPaid)
        lblBalance.Text = FormatCurrency(TotalCost - AmountPaid)



    End Sub

    Private Sub btnCustomerReceipt_Click(sender As Object, e As EventArgs) Handles btnCustomerReceipt.Click

        lblTitle.Text = "Customer Receipt"
       lblTitle.Refresh()

       Me.pnlButtons.Hide()
        frmReceipt.Print()MessageBox.show (“receipt sendet to the printer").
pnlButtons.Show()

    End Sub
End Class