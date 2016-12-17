'Phillip Benoit
'9/3/16
'CIS 141 Project 2
'Change Calculator

Option Strict On
Option Explicit On
Public Class frmChange
    Dim colChange As New List(Of Label)

    Private Sub frmChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colChange.Add(lblTwenties)
        colChange.Add(lblTens)
        colChange.Add(lblFives)
        colChange.Add(lblOnes)
        colChange.Add(lblQuarters)
        colChange.Add(lblDimes)
        colChange.Add(lblNickels)
        colChange.Add(lblPennies)
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        Dim curCash, curTotal, curChange As Decimal

        curTotal = fncTest(txtTotal.Text)
        If curTotal > 1000 Or curTotal <= 0 Then
            MsgBox("Please use a valid total.", vbCritical, "Error!")
            txtTotal.Focus()
            Exit Sub
        End If

        curCash = fncTest(txtCash.Text)
        If curCash < curTotal Then
            MsgBox("Please collect a valid amount of cash greater than the total.", vbCritical, "Error!")
            txtCash.Focus()
            Exit Sub
        End If

        'start of code to change the form to display results
        lblDSCash.Text = ""
        lblDSTotal.Text = "  -"
        txtCash.Text = curCash.ToString("C")
        txtTotal.Text = curTotal.ToString("C")
        txtCash.ReadOnly = True
        txtTotal.ReadOnly = True
        curChange = curCash - curTotal
        lblChange.Text = curChange.ToString("C")
        For index = 0 To colChange.Count - 1
            colChange(index).Text = Fix(curChange / CType(colChange(index).Tag, Decimal)).ToString
            curChange = curChange - (CType(colChange(index).Text, Decimal) * CType(colChange(index).Tag, Decimal))
        Next
        cmdClear.Focus()
        'end code to change form for results
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        lblDSCash.Text = "$"
        lblDSTotal.Text = "- $"
        txtCash.Text = ""
        txtTotal.Text = ""
        lblChange.Text = ""
        txtCash.ReadOnly = False
        txtTotal.ReadOnly = False
        txtCash.Focus()
        For index = 0 To colChange.Count - 1
            colChange(index).Text = ""
        Next
    End Sub

    Function fncTest(ByRef strTestString As String) As Decimal
        Dim curTest As Decimal = 0
        If Decimal.TryParse(strTestString, curTest) Then
            If curTest <> Fix(CType(strTestString, Decimal) * 100) / 100 Then
                curTest = 0
            End If
        End If
        Return curTest
    End Function
End Class
