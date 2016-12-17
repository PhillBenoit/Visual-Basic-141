'Phillip Benoit
'CIS 141
'8/30/16
'Body Mass Index Calculator

Option Explicit On
Option Strict On

Public Class BMICalculator

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        txtBMI.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
        lblStatus.Text = ""
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        Dim sngBMI As Single = Convert.ToSingle(Math.Round((Convert.ToDouble(txtWeight.Text) * 703) / Convert.ToDouble(txtHeight.Text) ^ 2, 1))
        txtBMI.Text = CType(sngBMI, String)
        Select Case sngBMI
            Case 0 To 18.4
                lblStatus.Text = "Underweight"
            Case 18.5 To 24.9
                lblStatus.Text = "Normal"
            Case 25 To 29.9
                lblStatus.Text = "Overweight"
            Case Else
                lblStatus.Text = "Obese"
        End Select
    End Sub

    Private Sub txtHeight_TextChanged(sender As Object, e As EventArgs) Handles txtHeight.TextChanged
        fncTest(txtHeight.Text)
    End Sub

    Private Sub txtWeight_TextChanged(sender As Object, e As EventArgs) Handles txtWeight.TextChanged
        fncTest(txtWeight.Text)
    End Sub

    Function fncTest(ByRef strTestString As String) As String
        'This function tests text to see if it can be converted in to a double and is greater than 0.
        'It is triggered evey time an input box changes and that box's text data is passed by reference for testing.
        'It triggers a warning and clears the box if the data does not pass the tests.
        'It also clears any previous results.

        Dim dblTest As Double
        Dim blnTest As Boolean = True

        txtBMI.Text = ""
        lblStatus.Text = ""

        If Double.TryParse(strTestString, dblTest) Then
            If dblTest <= 0 Then
                blnTest = False
            End If
        ElseIf strTestString <> "" Then
            blnTest = False
        End If

        If blnTest <> True Then
            MsgBox("This program only uses positive numbers.", vbCritical, "Error!")
            strTestString = ""
        End If
    End Function
End Class
