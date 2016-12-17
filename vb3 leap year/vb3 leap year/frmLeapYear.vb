'Phillip Benoit
'CIS 141
'Project 3 Leap Year Calculator
'9/10/16

Option Strict On
Option Explicit On

Public Class frmLeapYear
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        nudStart.Value = 2016
        nudEnd.Value = 2016
        lblYearsCounted.Text = CType(0, String)
        lblChecksum.Text = CType(0, String)
        lblYearsFound.Text = CType(0, String)
        chkIncludeEnd.Checked = True
        chkIncludeStart.Checked = True
        optEndCE.Checked = True
        optStartCE.Checked = True
        nudStart.Enabled = True
        nudEnd.Enabled = True
        lstDetectedYears.Items.Clear()
        grpStart.Enabled = True
        grpEnd.Enabled = True
        chkIncludeStart.Enabled = True
        chkIncludeEnd.Enabled = True
    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        'change focus to activate number controls in the number boxes and returns string to prevent null entries 
        cmdClear.Focus()
        Dim decStart = nudStart.Value, decEnd = nudEnd.Value
        nudStart.Text = decStart.ToString
        nudEnd.Text = decEnd.ToString
        'converts apropriate starting and ending points
        If optStartBCE.Checked = True Then decStart = 1 - decStart
        If optEndBCE.Checked = True Then decEnd = 1 - decEnd
        If chkIncludeStart.Checked = False Then decStart += 1
        If chkIncludeEnd.Checked = False Then decEnd -= 1
        If decEnd < decStart Then
            MsgBox("Please change your options or ajust the dates.  Your current selections generated a count of: " + CType(decEnd - decStart + 1, String), CType(16, MsgBoxStyle), "Error!")
            Exit Sub
        End If

        'lock objects before calculation and clear results for testing all the loops
        lblChecksum.Text = CType(decEnd - decStart + 1, String)
        lblYearsCounted.Text = CType(0, String)
        lblYearsFound.Text = CType(0, String)
        lstDetectedYears.Items.Clear()
        nudStart.Enabled = False
        nudEnd.Enabled = False
        grpStart.Enabled = False
        grpEnd.Enabled = False
        chkIncludeStart.Enabled = False
        chkIncludeEnd.Enabled = False

        'stepping integer used in all the loops
        Dim intStep As Integer = CType(decStart, Integer)

        If optFor.Checked Then
            For intStep = intStep To CType(decEnd, Integer)
                fncTestYear(intStep)
            Next
        End If

        If optWhile.Checked Then
            While intStep <= decEnd
                fncTestYear(intStep)
                intStep += 1
            End While
        End If

        If optDoWhilePre.Checked Then
            Do While intStep <= decEnd
                fncTestYear(intStep)
                intStep += 1
            Loop
        End If

        If optDoUntilPre.Checked Then
            Do Until intStep > decEnd
                fncTestYear(intStep)
                intStep += 1
            Loop
        End If

        If optDoWhilePost.Checked Then
            Do
                fncTestYear(intStep)
                intStep += 1
            Loop While intStep <= decEnd
        End If

        If optDoUntilPost.Checked Then
            Do
                fncTestYear(intStep)
                intStep += 1
            Loop Until intStep > decEnd
        End If
    End Sub
    Sub fncTestYear(ByVal intTestYear As Integer)
        'tests for leap year and executes appropriate counting and output
        If intTestYear < 1 Then intTestYear -= 1
        If fncLeapTest(intTestYear) Then
            If intTestYear < 0 Then
                lstDetectedYears.Items.Add(Math.Abs(intTestYear).ToString + " BCE")
            Else
                lstDetectedYears.Items.Add(intTestYear.ToString + " CE")
            End If
            lblYearsFound.Text = CType(CType(lblYearsFound.Text, Integer) + 1, String)
        End If
        lblYearsCounted.Text = CType(CType(lblYearsCounted.Text, Integer) + 1, String)
    End Sub
    Public Function fncLeapTest(ByRef intTestYear As Integer) As Boolean
        'returns a boolean indicaing if the given year is a leap year
        If intTestYear Mod 4 <> 0 Then Return False
        If intTestYear Mod 100 <> 0 Then Return True
        If intTestYear Mod 400 <> 0 Then Return False
        Return True
    End Function

End Class
