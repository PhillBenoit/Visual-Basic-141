'Phillip Benoit
'10/3/16
'CIS 141 Project 4
'Deli Order

Option Strict On
Option Explicit On

Imports System.Drawing.Printing

Public Class frmDeli
    'collections used to itterate through groups of check boxes
    Dim colMeat As New List(Of CheckBox)
    Dim colCheese As New List(Of CheckBox)
    Dim colCondiments As New List(Of CheckBox)
    Dim colDrinks As New List(Of CheckBox)
    Dim colBread As New List(Of RadioButton)

    'price constraints
    Dim DRINK_PRICE As Decimal = 2D
    Dim JALAPEÑO_PRICE As Decimal = 0.25D
    Dim EXTRA_MEAT As Decimal = 1.5D
    Dim EXTRA_CHEESE As Decimal = 0.4D
    Dim SANDWICH_PRICE As Decimal = 6D


    Private Sub frmDeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'welcome message
        MsgBox("Welcome to our deli!  Select your options and your total will be updated automatically." +
               "  Click the button to place your order once it looks good!", vbOKOnly, "Welcome!")
        'collections used to itterate through groups of check boxes
        colMeat.Add(chkHam)
        colMeat.Add(chkRB)
        colMeat.Add(chkTurkey)
        colCheese.Add(chkSwiss)
        colCheese.Add(chkJack)
        colCheese.Add(chkCheddar)
        colDrinks.Add(chkAJ)
        colDrinks.Add(chkEvian)
        colBread.Add(optPumpernickel)
        colBread.Add(optWheat)
        colBread.Add(optWhite)
        colCondiments.Add(chkPepper)
        colCondiments.Add(chkSalt)
        colCondiments.Add(chkPickle)
        colCondiments.Add(chkTomato)
        colCondiments.Add(chkLettuce)
        colCondiments.Add(chkOil)
        colCondiments.Add(chkVinegar)
        colCondiments.Add(chkKetchup)
        colCondiments.Add(chkMayo)
        colCondiments.Add(chkMustard)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    'keeps the total updated whenever one of the 9 items is either checked or unchecked
    Private Sub CalculateTotal() Handles chkSwiss.CheckedChanged, chkJalapeños.CheckedChanged, chkJack.CheckedChanged, chkCheddar.CheckedChanged,
            chkHam.CheckedChanged, chkTurkey.CheckedChanged, chkRB.CheckedChanged, chkEvian.CheckedChanged, chkAJ.CheckedChanged
        Dim curTotal = SANDWICH_PRICE
        For Each drink In colDrinks
            If drink.Checked Then curTotal += DRINK_PRICE
        Next
        If chkJalapeños.Checked Then curTotal += JALAPEÑO_PRICE
        curTotal += fncExtraTest(colMeat) * EXTRA_MEAT
        curTotal += fncExtraTest(colCheese) * EXTRA_CHEESE
        lblTotal.Text = curTotal.ToString("C")
    End Sub

    'checks to see if more than one checkbox in a group is checked to calculate prices
    Function fncExtraTest(ByRef colToCount As List(Of CheckBox)) As Integer
        Dim intCounter As Integer = 0
        For Each box In colToCount
            If box.Checked Then intCounter += 1
        Next
        If intCounter <= 1 Then
            intCounter = 0
        Else
            intCounter -= 1
        End If
        Return intCounter
    End Function

    'resets the form
    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        optWhite.Checked = True
        chkJalapeños.Checked = False
        Uncheck(colMeat)
        Uncheck(colCheese)
        Uncheck(colCondiments)
        Uncheck(colDrinks)
        CalculateTotal()
    End Sub

    'loop to uncheck all boxes in a group
    Private Sub Uncheck(ByRef colToUncheck As List(Of CheckBox))
        For Each box In colToUncheck
            box.Checked = False
        Next
    End Sub

    'about program
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAboutDeli.Visible = True
        Visible = False
    End Sub

    'initates print preview
    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        ReceiptPreviewDialog.Document = PrintDocumentReceipt
        ReceiptPreviewDialog.ShowDialog()
    End Sub

    'message box with pricing information
    Private Sub PricingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PricingToolStripMenuItem.Click
        MsgBox("Sandwiches come with one meat, one cheese, & any condiments except jalapeños for $6.00" + vbCrLf +
               "Jalapeños are an extra $0.25" + vbCrLf +
               "Drinks are $2.00 each" + vbCrLf +
               "Each extra meat choice adds $1.50" + vbCrLf +
               "Each extra cheese choice adds $0.40", vbInformation, "Deli Pricing")
    End Sub

    'formats receipt for printing
    Private Sub PrintDocumentReceipt_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocumentReceipt.PrintPage
        Dim stringToPrint = fncGenerateReceipt()
        Try
            e.Graphics.DrawString(stringToPrint, Me.Font, Brushes.Black,
                                  e.MarginBounds, StringFormat.GenericTypographic)
        Catch ex As Exception
            MsgBox("Program encountered a problem with your printer.", vbCritical, "WARNING!")
        End Try
    End Sub

    'extrapolates a text receipt from the information on the form
    Function fncGenerateReceipt() As String
        Dim counter = 0
        Dim returnString = "Thank you for choosing our deli!" + vbCrLf +
            "Your order is as follows:" + vbCrLf + vbCrLf + "Bread choice: "
        For Each bread In colBread
            If bread.Checked Then returnString += bread.Text + vbCrLf
        Next
        returnString += vbCrLf + "Meat choice(s): " + vbCrLf
        For Each meat In colMeat
            If meat.Checked Then
                counter += 1
                returnString += String.Format("{0,-10}", fncPriceExtra(counter, EXTRA_MEAT)) + meat.Text + vbCrLf
            End If
        Next
        If counter = 0 Then returnString += "none" + vbCrLf + vbCrLf Else returnString += vbCrLf
        counter = 0
        returnString += "Cheese choice(s): " + vbCrLf
        For Each cheese In colCheese
            If cheese.Checked Then
                counter += 1
                returnString += String.Format("{0,-10}", fncPriceExtra(counter, EXTRA_CHEESE)) + cheese.Text + vbCrLf
            End If
        Next
        If counter = 0 Then returnString += "none" + vbCrLf + vbCrLf Else returnString += vbCrLf
        counter = 0
        returnString += "Condiment choice(s): " + vbCrLf
        For Each condiment In colCondiments
            If condiment.Checked Then
                counter += 1
                returnString += "          " + condiment.Text + vbCrLf
            End If
        Next
        If chkJalapeños.Checked Then
            counter += 1
            returnString += String.Format("{0,-10}", JALAPEÑO_PRICE.ToString("C")) + chkJalapeños.Text + vbCrLf
        End If
        If counter = 0 Then returnString += "none" + vbCrLf + vbCrLf Else returnString += vbCrLf
        counter = 0
        returnString += "Drink choice(s): " + vbCrLf
        For Each drink In colDrinks
            If drink.Checked Then
                counter += 1
                returnString += String.Format("{0,-10}", DRINK_PRICE.ToString("C")) + drink.Text + vbCrLf
            End If
        Next
        If counter = 0 Then returnString += "none" + vbCrLf + vbCrLf Else returnString += vbCrLf
        returnString += String.Format("{0,-10}", lblTotal.Text) + "Total" + vbCrLf + vbCrLf + "Have a nice day. :)"
        Return returnString
    End Function

    'function to display pricing on extra meat/cheese options
    Function fncPriceExtra(ByRef counter As Integer, ByRef price As Decimal) As String
        If counter = 1 Then Return "inc." Else Return price.ToString("C")
    End Function
End Class