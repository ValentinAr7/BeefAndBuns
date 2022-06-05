Public Class frmOrder
    '---------------------------- FORM WIDE DATA STORAGE ------------------------------
    Dim LocationOfImageFiles As String
    '--------------------- USER DEFINECD PROCEDURES AND FUNCTIONS ----------------------
    Private Function CalcCostOfMeal() As Single
        Dim BurgerCost, BurgerPrice As Single    'Local variable

        If nudMealQuantity.Value = 0 Then
            Return 0
        End If

        If rbn2Oz.Checked Then
            BurgerPrice = Val(lbl2OzPrice.Text)
        ElseIf rbn4Oz.Checked Then
            BurgerPrice = Val(lbl4OzPrice.Text)
        Else
            BurgerPrice = Val(lbl8OzPrice.Text)
        End If

        If cbkKetchup.Checked Then
            BurgerPrice = BurgerPrice + 0.1
        End If

        If cbkBacon.Checked Then
            BurgerPrice = BurgerPrice + 0.5
        End If

        If cbkCheese.Checked Then
            BurgerPrice = BurgerPrice + 0.5
        End If

        If cbkColeslaw.Checked Then
            BurgerPrice = BurgerPrice + 0.5
        End If

        If cbkOnions.Checked Then
            BurgerPrice = BurgerPrice + 0.5
        End If

        BurgerCost = BurgerPrice * nudMealQuantity.Value

        Return BurgerCost

    End Function


    '-------------------------- EVENT RELATED PROCEDURES ------------------------------
    Private Sub frmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LocationOfImageFiles = System.IO.Path.GetFullPath(Application.StartupPath & "\..\..\Resources\")
    End Sub

    Private Sub btnHolyrood_Click(sender As Object, e As EventArgs) Handles btnHolyrood.Click
        Dim BurgerImage As String = LocationOfImageFiles & "Holyrood.jpg"   'Indicate the location of the text file
        picBurger.Image = Image.FromFile(BurgerImage)

        lblMealTitle.Text = "The Holyrood Burger Meal"
        lblMealTopping.Text = "Hereford Hop cheese, beer mustard, rocket, red onion, caramelized onion mayo, dill pickle, tomato, lettuce"
        lblMealChips.Text = "String fries"

        lbl2OzPrice.Text = "04.00"
        lbl4OzPrice.Text = "06.00"
        lbl8OzPrice.Text = "07.00"

        rbn4Oz.Checked = True

        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())

        pnlMeal.Show()
    End Sub

    Private Sub rbn2Oz_CheckedChanged(sender As Object, e As EventArgs) Handles rbn2Oz.CheckedChanged
        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())
    End Sub

    Private Sub rbn4Oz_CheckedChanged(sender As Object, e As EventArgs) Handles rbn4Oz.CheckedChanged
        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())
    End Sub

    Private Sub rbn8Oz_CheckedChanged(sender As Object, e As EventArgs) Handles rbn8Oz.CheckedChanged
        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())
    End Sub

    Private Sub cbkOnions_CheckedChanged(sender As Object, e As EventArgs) Handles cbkOnions.CheckedChanged
        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())
    End Sub

    Private Sub cbkBacon_CheckedChanged(sender As Object, e As EventArgs) Handles cbkBacon.CheckedChanged
        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())
    End Sub

    Private Sub cbkColeslaw_CheckedChanged(sender As Object, e As EventArgs) Handles cbkColeslaw.CheckedChanged
        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())
    End Sub

    Private Sub cbkCheese_CheckedChanged(sender As Object, e As EventArgs) Handles cbkCheese.CheckedChanged
        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())
    End Sub

    Private Sub cbkKetchup_CheckedChanged(sender As Object, e As EventArgs) Handles cbkKetchup.CheckedChanged
        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())
    End Sub

    Private Sub nudMealQuantity_ValueChanged(sender As Object, e As EventArgs) Handles nudMealQuantity.ValueChanged
        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())
    End Sub

    Private Sub btnAngus_Click(sender As Object, e As EventArgs) Handles btnAngus.Click
        Dim BurgerImage As String = LocationOfImageFiles & "Angus.jpg"   'Indicate the location of the text file
        picBurger.Image = Image.FromFile(BurgerImage)

        lblMealTitle.Text = "Angus Rare Breed burger"
        lblMealTopping.Text = "Cheese and bacon"
        lblMealChips.Text = "Thick cut"

        lbl2OzPrice.Text = "05.00"
        lbl4OzPrice.Text = "07.00"
        lbl8OzPrice.Text = "08.00"

        rbn4Oz.Checked = True

        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())

        pnlMeal.Show()
    End Sub

    Private Sub btnRoyale_Click(sender As Object, e As EventArgs) Handles btnRoyale.Click
        Dim BurgerImage As String = LocationOfImageFiles & "RoyaleWitCheese.jpg"   'Indicate the location of the text file
        picBurger.Image = Image.FromFile(BurgerImage)

        lblMealTitle.Text = "The 'Royale Wit Cheese'"
        lblMealTopping.Text = "American cheese, iceberg lettuce, tomato, pickles, ketchup and mustard"
        lblMealChips.Text = "Salty fries"

        lbl2OzPrice.Text = "05.20"
        lbl4OzPrice.Text = "06.20"
        lbl8OzPrice.Text = "07.20"

        rbn4Oz.Checked = True

        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())

        pnlMeal.Show()
    End Sub

    Private Sub btnHonest_Click(sender As Object, e As EventArgs) Handles btnHonest.Click
        Dim BurgerImage As String = LocationOfImageFiles & "HonestBurger.jpg"   'Indicate the location of the text file
        picBurger.Image = Image.FromFile(BurgerImage)

        lblMealTitle.Text = "The Honest Burger"
        lblMealTopping.Text = "Red onion relish, smoked bacon, mature cheddar, pickled cucumber and lettuce"
        lblMealChips.Text = "House chips with rosemary salt"

        lbl2OzPrice.Text = "06.00"
        lbl4OzPrice.Text = "08.00"
        lbl8OzPrice.Text = "09.00"

        rbn4Oz.Checked = True

        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())

        pnlMeal.Show()
    End Sub

    Private Sub btnOIAL_Click(sender As Object, e As EventArgs) Handles btnOIAL.Click
        Dim BurgerImage As String = LocationOfImageFiles & "OnceInALifeTime.jpg"   'Indicate the location of the text file
        picBurger.Image = Image.FromFile(BurgerImage)

        lblMealTitle.Text = "Once In A Lifetime Burger"
        lblMealTopping.Text = "Buttermilk fried chicken, pulled pork, melted vintage cheddar, lettuce, onion rings, chow chow slaw"
        lblMealChips.Text = "Medium chunky fries"

        lbl2OzPrice.Text = "09.50"
        lbl4OzPrice.Text = "11.50"
        lbl8OzPrice.Text = "12.50"

        rbn4Oz.Checked = True

        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())

        pnlMeal.Show()
    End Sub

    Private Sub btnPit_Click(sender As Object, e As EventArgs) Handles btnPit.Click
        Dim BurgerImage As String = LocationOfImageFiles & "ThePit.jpg"   'Indicate the location of the text file
        picBurger.Image = Image.FromFile(BurgerImage)

        lblMealTitle.Text = "Pit Burger"
        lblMealTopping.Text = "Sliced brisket, pulled pork, streaky bacon, melted Jack, dill pickle, dirty sauce, mustard, barbecue sauce and oh, an onion ring for good measure"
        lblMealChips.Text = "Skinny, unseasoned for dipping in the 5 homemade sauces"

        lbl2OzPrice.Text = "10.50"
        lbl4OzPrice.Text = "12.50"
        lbl8OzPrice.Text = "13.50"

        rbn4Oz.Checked = True

        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())

        pnlMeal.Show()
    End Sub

    Private Sub btnDoubleCh_Click(sender As Object, e As EventArgs) Handles btnDoubleCh.Click
        Dim BurgerImage As String = LocationOfImageFiles & "DoubleCheeseBurger.jpg"   'Indicate the location of the text file
        picBurger.Image = Image.FromFile(BurgerImage)

        lblMealTitle.Text = "Double Cheeseburger"
        lblMealTopping.Text = "Guacamole, Pineapple, Beetroot, Mustard Mayo, Pickled Coleslaw"
        lblMealChips.Text = "Cowboy Fries (with Chilli, Honey & Garlic)"

        lbl2OzPrice.Text = "04.25"
        lbl4OzPrice.Text = "06.25"
        lbl8OzPrice.Text = "07.25"

        rbn4Oz.Checked = True

        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())

        pnlMeal.Show()
    End Sub

    Private Sub btnRanch_Click(sender As Object, e As EventArgs) Handles btnRanch.Click
        Dim BurgerImage As String = LocationOfImageFiles & "RanchBurger.jpg"   'Indicate the location of the text file
        picBurger.Image = Image.FromFile(BurgerImage)

        lblMealTitle.Text = "Ranch Burger"
        lblMealTopping.Text = "Brioche bun, mayonnaise, grilled bacon, beer battered onion rings, Monterey Jack cheese, barbecue sauce"
        lblMealChips.Text = "Hand-cut chips"

        lbl2OzPrice.Text = "05.75"
        lbl4OzPrice.Text = "07.75"
        lbl8OzPrice.Text = "08.75"

        rbn4Oz.Checked = True

        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())

        pnlMeal.Show()
    End Sub

    Private Sub btnChargrilled_Click(sender As Object, e As EventArgs) Handles btnChargrilled.Click
        Dim BurgerImage As String = LocationOfImageFiles & "Chargrilled.jpg"   'Indicate the location of the text file
        picBurger.Image = Image.FromFile(BurgerImage)

        lblMealTitle.Text = "Chargrilled beef burger with cheese"
        lblMealTopping.Text = "Pickled cucumber, cheese and lettuce with mustard and ketchup sauce"
        lblMealChips.Text = "Skinny fries"

        lbl2OzPrice.Text = "06.00"
        lbl4OzPrice.Text = "08.00"
        lbl8OzPrice.Text = "09.00"

        rbn4Oz.Checked = True

        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())

        pnlMeal.Show()
    End Sub

    Private Sub btnCalifornian_Click(sender As Object, e As EventArgs) Handles btnCalifornian.Click
        Dim BurgerImage As String = LocationOfImageFiles & "TheCalifornian.jpg"   'Indicate the location of the text file
        picBurger.Image = Image.FromFile(BurgerImage)

        lblMealTitle.Text = "The Californian Burger"
        lblMealTopping.Text = "Monterey jack cheese, jalapenos, guacamole and bacon"
        lblMealChips.Text = "fries"

        lbl2OzPrice.Text = "04.50"
        lbl4OzPrice.Text = "05.50"
        lbl8OzPrice.Text = "06.50"

        rbn4Oz.Checked = True

        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())

        pnlMeal.Show()
    End Sub

    Private Sub btnGold_Click(sender As Object, e As EventArgs) Handles btnGold.Click
        Dim BurgerImage As String = LocationOfImageFiles & "AriGold.jpg"   'Indicate the location of the text file
        picBurger.Image = Image.FromFile(BurgerImage)

        lblMealTitle.Text = "Ari Gold With Bacon"
        lblMealTopping.Text = "Cheese, lettuce, tomato, pickled onions, ketchup, Smokey P&B mayo, bacon"
        lblMealChips.Text = "Crispy, with rosemary salt"

        lbl2OzPrice.Text = "03.50"
        lbl4OzPrice.Text = "04.50"
        lbl8OzPrice.Text = "05.50"

        rbn4Oz.Checked = True

        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())

        pnlMeal.Show()
    End Sub

    Private Sub btnDirty_Click(sender As Object, e As EventArgs) Handles btnDirty.Click
        Dim BurgerImage As String = LocationOfImageFiles & "DirtyBurger.jpg"   'Indicate the location of the text file
        picBurger.Image = Image.FromFile(BurgerImage)

        lblMealTitle.Text = "Dirty Burger"
        lblMealTopping.Text = "Hickory onion and bacon relish, sliced pickle, Monterey Jack, house sauce, shredded cabbage and romaine lettuce"
        lblMealChips.Text = "French fries"

        lbl2OzPrice.Text = "06.00"
        lbl4OzPrice.Text = "08.00"
        lbl8OzPrice.Text = "09.00"

        rbn4Oz.Checked = True

        lblMealCost.Text = FormatCurrency(CalcCostOfMeal())

        pnlMeal.Show()
    End Sub

    Private Sub btnAddMeal_Click(sender As Object, e As EventArgs) Handles btnAddMeal.Click
        Dim BurgerSize, ExtraOnions, ExtraBacon, ExtraColeslaw, ExtraCheese, ExtraKetchup As String

        If rbn2Oz.Checked = True Then
            BurgerSize = "2Oz"
        ElseIf rbn4Oz.Checked Then
            BurgerSize = "4Oz"
        Else
            BurgerSize = "8Oz"
        End If

        If cbkBacon.Checked Then
            ExtraBacon = "Yes"
        Else
            ExtraBacon = ""
        End If

        If cbkCheese.Checked Then
            ExtraCheese = "Yes"
        Else
            ExtraCheese = ""
        End If

        If cbkKetchup.Checked Then
            ExtraKetchup = "Yes"
        Else
            ExtraKetchup = ""
        End If

        If cbkColeslaw.Checked Then
            ExtraColeslaw = "Yes"
        Else
            ExtraColeslaw = ""
        End If

        If cbkOnions.Checked Then
            ExtraOnions = "Yes"
        Else
            ExtraOnions = ""
        End If

        Dim CopyOfMealInfo As New ListViewItem
        'First column ca be the listview item's Text
        CopyOfMealInfo.Text = lblMealTitle.Text
        CopyOfMealInfo.SubItems.Add(BurgerSize)
        CopyOfMealInfo.SubItems.Add(ExtraBacon)
        CopyOfMealInfo.SubItems.Add(ExtraColeslaw)
        CopyOfMealInfo.SubItems.Add(ExtraCheese)
        CopyOfMealInfo.SubItems.Add(ExtraKetchup)
        CopyOfMealInfo.SubItems.Add(ExtraOnions)
        CopyOfMealInfo.SubItems.Add(nudMealQuantity.Value)
        CopyOfMealInfo.SubItems.Add(lblMealCost.Text)

        lvwOrder.Items.Add(CopyOfMealInfo)

        TotalCost = TotalCost + CalcCostOfMeal()
        TotalQuantity = TotalQuantity + nudMealQuantity.Value
        lblOrderQuantity.Text = TotalQuantity
        lblOrderTotal.Text = FormatCurrency(TotalCost)

        pnlMeal.Visible = False
        OrderLines = OrderLines + 1

        nudMealQuantity.Value = 1
        rbn2Oz.Checked = True
        rbn4Oz.Checked = True
        rbn8Oz.Checked = True

        cbkOnions.Checked = False
        cbkKetchup.Checked = False
        cbkColeslaw.Checked = False
        cbkBacon.Checked = False
        cbkCheese.Checked = False

        lblMealCost.Text = "0.00"

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim copyPrice, copyQuantity As String
        Dim SubtractValue As Decimal
        Dim SubtractQuantity As Integer
        If lvwOrder.FocusedItem Is Nothing Then
            MessageBox.Show("Make Selection First")
        Else
            copyPrice = lvwOrder.Items.Item(lvwOrder.FocusedItem.Index).SubItems(8).Text
            copyQuantity = lvwOrder.Items.Item(lvwOrder.FocusedItem.Index).SubItems(7).Text
            copyPrice = copyPrice.Replace("£", "")   'the £ sign must be removed before we covert the data to a decimal

            SubtractValue = Decimal.Parse(copyPrice)
            SubtractQuantity = Integer.Parse(copyQuantity)

            TotalCost = TotalCost - SubtractValue
            TotalQuantity = TotalQuantity - SubtractQuantity
            lblOrderQuantity.Text = TotalQuantity
            lblOrderTotal.Text = FormatCurrency(TotalCost)

            OrderLines = OrderLines - 1

        End If

        lvwOrder.FocusedItem.Remove()
        lvwOrder.FocusedItem = Nothing
        lvwOrder.Refresh()

        If TotalQuantity = 0 Then
            btnDelete.Hide()
            btnPay.Hide()
        End If

    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        frmPayment.Show()
        frmPayment.Focus()
        Me.Enabled = False

    End Sub


End Class