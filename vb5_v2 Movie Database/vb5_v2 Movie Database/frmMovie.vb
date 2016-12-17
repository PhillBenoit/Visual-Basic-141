'Phillip Benoit
'CIS 141
'10/9/16
'Project 5 Movie Databse

Option Explicit On
Option Strict On

Imports System.ComponentModel

Public Class frmMovie

    Private Sub frmMovie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initial fill query
        VideosTableAdapter.Fill(MovieDataSet.Videos)
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click, mnuEdit.Click
        editModeOn()
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        editModeOn()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        editModeOff()
    End Sub

    'commands for commiting update to database and refreshing the form
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click, mnuSave.Click
        Validate()
        VideosBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(MovieDataSet)
        editModeOff()
    End Sub

    Private Sub cmdKevin_Click(sender As Object, e As EventArgs) Handles cmdKevin.Click, mnuKevin.Click
        'find Kevin Smith movies with saved query
        VideosTableAdapter.KevinSmith(MovieDataSet.Videos)
        grdMovies.Sort(grdMovies.Columns(3), ListSortDirection.Ascending)
        searchModeOn()
    End Sub

    Private Sub cmdAvengers_Click(sender As Object, e As EventArgs) Handles cmdAvengers.Click, mnuAvengers.Click
        'find Robert Downey Jr movies with saved query
        VideosTableAdapter.Avengers(MovieDataSet.Videos)
        grdMovies.Sort(grdMovies.Columns(3), ListSortDirection.Ascending)
        searchModeOn()
    End Sub

    Private Sub cmdFive_Click(sender As Object, e As EventArgs) Handles cmdFive.Click, mnuFive.Click
        'find 5 star movies with saved query
        VideosTableAdapter.Five(MovieDataSet.Videos)
        grdMovies.Sort(grdMovies.Columns(1), ListSortDirection.Ascending)
        searchModeOn()
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click, mnuReset.Click
        'runs the fill query and resets user selected sort option
        VideosTableAdapter.Fill(MovieDataSet.Videos)
        searchModeOff()
        grdMovies.Sort(grdMovies.Columns(0), ListSortDirection.Ascending)
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        End
    End Sub

    'menu items associated with toolbox commands that have hidden properties
    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        cmdDelete.PerformClick()
    End Sub

    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        cmdNew.PerformClick()
    End Sub

    'edit mode on changes objects to allow changing of data and locking out other commands
    Private Sub editModeOn()
        cmdNew.Enabled = False
        mnuNew.Enabled = False
        cmdEdit.Enabled = False
        mnuEdit.Enabled = False
        cmdSave.Enabled = True
        mnuSave.Enabled = True
        cmdKevin.Enabled = False
        mnuKevin.Enabled = False
        cmdAvengers.Enabled = False
        mnuAvengers.Enabled = False
        cmdFive.Enabled = False
        mnuFive.Enabled = False
        cmdReset.Enabled = False
        mnuReset.Enabled = False
        mnuExit.Enabled = False
        mnuAbout.Enabled = False
        txtTitle.ReadOnly = False
        txtDirector.ReadOnly = False
        txtMakeActor.ReadOnly = False
        txtFemaleActor.ReadOnly = False
        nudYear.Enabled = True
        cboGenre.Enabled = True
        cboRaiting.Enabled = True
        cboStar.Enabled = True
        grdMovies.Enabled = False
    End Sub

    'edit mode off changes objects to prevent changing entries and enable searching / navigation
    Private Sub editModeOff()
        cmdNew.Enabled = True
        mnuNew.Enabled = True
        cmdEdit.Enabled = True
        mnuEdit.Enabled = True
        cmdSave.Enabled = False
        mnuSave.Enabled = False
        cmdKevin.Enabled = True
        mnuKevin.Enabled = True
        cmdAvengers.Enabled = True
        mnuAvengers.Enabled = True
        cmdFive.Enabled = True
        mnuFive.Enabled = True
        cmdReset.Enabled = True
        mnuReset.Enabled = True
        mnuExit.Enabled = True
        mnuAbout.Enabled = True
        txtTitle.ReadOnly = True
        txtDirector.ReadOnly = True
        txtMakeActor.ReadOnly = True
        txtFemaleActor.ReadOnly = True
        nudYear.Enabled = False
        cboGenre.Enabled = False
        cboRaiting.Enabled = False
        cboStar.Enabled = False
        grdMovies.Enabled = True
    End Sub

    'caaptures any attempt to exit while in edit mode
    Private Sub frmMovie_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If cmdSave.Enabled Then
            MsgBox("Please Save or Delete your entry before exiting.", vbCritical, "Edit mode enabled")
            e.Cancel = True
        End If
    End Sub

    'prevent blank text entries and highlight the field that was blank
    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        If txtTitle.Text = "" Then
            txtTitle.Text = "Title cannot be blank"
            txtTitle.SelectAll()
        End If
    End Sub

    Private Sub txtDirector_TextChanged(sender As Object, e As EventArgs) Handles txtDirector.TextChanged
        If txtDirector.Text = "" Then
            txtDirector.Text = "Director cannot be blank"
            txtDirector.SelectAll()
        End If
    End Sub

    Private Sub txtMakeActor_TextChanged(sender As Object, e As EventArgs) Handles txtMakeActor.TextChanged
        If txtMakeActor.Text = "" Then
            txtMakeActor.Text = "Male Actor cannot be blank"
            txtMakeActor.SelectAll()
        End If
    End Sub

    Private Sub txtFemaleActor_TextChanged(sender As Object, e As EventArgs) Handles txtFemaleActor.TextChanged
        If txtFemaleActor.Text = "" Then
            txtFemaleActor.Text = "Female Actor cannot be blank"
            txtFemaleActor.SelectAll()
        End If
    End Sub

    'search mode prevents editing and adding new movies while giving visual cue to reset
    Private Sub searchModeOn()
        cmdNew.Enabled = False
        mnuNew.Enabled = False
        mnuEdit.Enabled = False
        cmdEdit.Enabled = False
        cmdReset.BackColor = SystemColors.GradientActiveCaption
    End Sub

    Private Sub searchModeOff()
        cmdNew.Enabled = True
        mnuNew.Enabled = True
        mnuEdit.Enabled = True
        cmdEdit.Enabled = True
        cmdReset.BackColor = SystemColors.Control
        'cmdReset.ForeColor = SystemColors.ControlText
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Me.Visible = False
        frmAboutMovieDB.Visible = True
    End Sub
End Class
