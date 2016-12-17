'Phillip Benoit
'10/27/16
'CIS142
'Project 6: Shape Calculator

Option Strict On
Option Explicit On

Public Class frmShapeCalc

    Dim STOP_CALCULATION As Boolean = False

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub optTriangle_CheckedChanged(sender As Object, e As EventArgs) Handles optTriangle.CheckedChanged
        lblLength.Visible = False
        nudLength.Visible = False
        lblResult1lbl.Text = "Area:"
        lblResult2lbl.Text = "Perimeter:"
    End Sub

    Private Sub optPrism_CheckedChanged(sender As Object, e As EventArgs) Handles optPrism.CheckedChanged
        lblLength.Visible = True
        nudLength.Visible = True
        lblResult1lbl.Text = "Volume:"
        lblResult2lbl.Text = "Surface Area:"
    End Sub

    Private Sub CalculateShape() Handles nudSide1.TextChanged, nudSide2.TextChanged, nudSide3.TextChanged, nudLength.TextChanged, optPrism.CheckedChanged
        If STOP_CALCULATION = False Then
            If optTriangle.Checked Then
                fncValidateTriangle()
                Dim shape As Triangle
                shape = New Triangle(CInt(nudSide1.Value), CInt(nudSide2.Value), CInt(nudSide3.Value))
                lblResult1.Text = shape.Area.ToString
                lblResult2.Text = shape.Perimeter.ToString
            Else
                fncValidateTriangle()
                Dim shape As Prism
                shape = New Prism(CInt(nudSide1.Value), CInt(nudSide2.Value), CInt(nudSide3.Value), CInt(nudLength.Value))
                lblResult1.Text = shape.Volume.ToString
                lblResult2.Text = shape.SurfaceArea.ToString
            End If

        End If
    End Sub

    Private Sub fncValidateTriangle()
        Dim foundError As Boolean = False
        If nudSide1.Value + nudSide2.Value <= nudSide3.Value Then
            nudSide3.Value = nudSide1.Value + nudSide2.Value - 1
            nudSide3.Focus()
            nudSide3.Select(0, nudSide3.Text.Length)
            foundError = True
        End If
        If nudSide3.Value + nudSide2.Value <= nudSide1.Value Then
            nudSide1.Value = nudSide3.Value + nudSide2.Value - 1
            nudSide1.Focus()
            nudSide1.Select(0, nudSide1.Text.Length)
            foundError = True
        End If
        If nudSide1.Value + nudSide3.Value <= nudSide2.Value Then
            nudSide2.Value = nudSide1.Value + nudSide3.Value - 1
            nudSide2.Focus()
            nudSide2.Select(0, nudSide2.Text.Length)
            foundError = True
        End If
        If foundError Then MsgBox("The largest side cannot be longer than the smallest two.", vbCritical, "Math Error")
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        STOP_CALCULATION = True
        nudLength.Value = 50
        nudSide1.Value = 50
        nudSide2.Value = 50
        STOP_CALCULATION = False
        nudSide3.Value = 50
    End Sub
End Class

Public Class Triangle
    Public Side1 As Integer
    Public Side2 As Integer
    Public Side3 As Integer
    Public Perimeter As Integer
    Public Area As Decimal

    Sub New(ByRef s1 As Integer, ByRef s2 As Integer, ByRef s3 As Integer)
        Side1 = s1
        Side2 = s2
        Side3 = s3
        Perimeter = Side1 + Side2 + Side3
        Dim p As Decimal
        p = CDec((Perimeter / 2))
        Area = p * (p - Side1) * (p - Side2) * (p - Side3)
        Area = CDec(Math.Sqrt(Area))
        Area = Math.Round(Area, 4)
    End Sub
End Class

Public Class Prism
    Inherits Triangle
    Public Length As Integer
    Public SurfaceArea As Decimal
    Public Volume As Decimal

    Public Sub New(ByRef s1 As Integer, ByRef s2 As Integer, ByRef s3 As Integer, ByRef l As Integer)
        MyBase.New(s1, s2, s3)
        Length = l
        Volume = Area * Length
        SurfaceArea = (Area * 2) + (Side1 * Length) + (Side2 * Length) + (Side3 * Length)
    End Sub
End Class