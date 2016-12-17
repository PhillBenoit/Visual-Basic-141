<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMovie
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim lblTitle As System.Windows.Forms.Label
        Dim lblDirector As System.Windows.Forms.Label
        Dim lblMaleActor As System.Windows.Forms.Label
        Dim lblFemaleActor As System.Windows.Forms.Label
        Dim lblMovieIDlbl As System.Windows.Forms.Label
        Dim lblYear As System.Windows.Forms.Label
        Dim lblStar As System.Windows.Forms.Label
        Dim lblRating As System.Windows.Forms.Label
        Dim lblGenre As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovie))
        Me.tolToolbar = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.cmdNew = New System.Windows.Forms.ToolStripButton()
        Me.VideosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovieDataSet = New vb5_v2_Movie_Database.movieDataSet()
        Me.cmdDelete = New System.Windows.Forms.ToolStripButton()
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdKevin = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAvengers = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdFive = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdReset = New System.Windows.Forms.ToolStripButton()
        Me.grdMovies = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuKevin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAvengers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFive = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideosTableAdapter = New vb5_v2_Movie_Database.movieDataSetTableAdapters.VideosTableAdapter()
        Me.TableAdapterManager = New vb5_v2_Movie_Database.movieDataSetTableAdapters.TableAdapterManager()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtDirector = New System.Windows.Forms.TextBox()
        Me.txtMakeActor = New System.Windows.Forms.TextBox()
        Me.txtFemaleActor = New System.Windows.Forms.TextBox()
        Me.lblMovieID = New System.Windows.Forms.Label()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.cboStar = New System.Windows.Forms.ComboBox()
        Me.cboRaiting = New System.Windows.Forms.ComboBox()
        Me.cboGenre = New System.Windows.Forms.ComboBox()
        lblTitle = New System.Windows.Forms.Label()
        lblDirector = New System.Windows.Forms.Label()
        lblMaleActor = New System.Windows.Forms.Label()
        lblFemaleActor = New System.Windows.Forms.Label()
        lblMovieIDlbl = New System.Windows.Forms.Label()
        lblYear = New System.Windows.Forms.Label()
        lblStar = New System.Windows.Forms.Label()
        lblRating = New System.Windows.Forms.Label()
        lblGenre = New System.Windows.Forms.Label()
        CType(Me.tolToolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tolToolbar.SuspendLayout()
        CType(Me.VideosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdMovies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMain.SuspendLayout()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTitle.Location = New System.Drawing.Point(12, 76)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New System.Drawing.Size(50, 24)
        lblTitle.TabIndex = 3
        lblTitle.Text = "Title:"
        '
        'lblDirector
        '
        lblDirector.AutoSize = True
        lblDirector.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDirector.Location = New System.Drawing.Point(404, 76)
        lblDirector.Name = "lblDirector"
        lblDirector.Size = New System.Drawing.Size(80, 24)
        lblDirector.TabIndex = 5
        lblDirector.Text = "Director:"
        '
        'lblMaleActor
        '
        lblMaleActor.AutoSize = True
        lblMaleActor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblMaleActor.Location = New System.Drawing.Point(12, 119)
        lblMaleActor.Name = "lblMaleActor"
        lblMaleActor.Size = New System.Drawing.Size(105, 24)
        lblMaleActor.TabIndex = 7
        lblMaleActor.Text = "Male Actor:"
        '
        'lblFemaleActor
        '
        lblFemaleActor.AutoSize = True
        lblFemaleActor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFemaleActor.Location = New System.Drawing.Point(404, 119)
        lblFemaleActor.Name = "lblFemaleActor"
        lblFemaleActor.Size = New System.Drawing.Size(128, 24)
        lblFemaleActor.TabIndex = 9
        lblFemaleActor.Text = "Female Actor:"
        '
        'lblMovieIDlbl
        '
        lblMovieIDlbl.AutoSize = True
        lblMovieIDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblMovieIDlbl.Location = New System.Drawing.Point(12, 158)
        lblMovieIDlbl.Name = "lblMovieIDlbl"
        lblMovieIDlbl.Size = New System.Drawing.Size(88, 24)
        lblMovieIDlbl.TabIndex = 11
        lblMovieIDlbl.Text = "Movie ID:"
        '
        'lblYear
        '
        lblYear.AutoSize = True
        lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblYear.Location = New System.Drawing.Point(153, 158)
        lblYear.Name = "lblYear"
        lblYear.Size = New System.Drawing.Size(139, 24)
        lblYear.TabIndex = 13
        lblYear.Text = "Year Released:"
        '
        'lblStar
        '
        lblStar.AutoSize = True
        lblStar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStar.Location = New System.Drawing.Point(209, 194)
        lblStar.Name = "lblStar"
        lblStar.Size = New System.Drawing.Size(105, 24)
        lblStar.TabIndex = 15
        lblStar.Text = "Star Rating:"
        '
        'lblRating
        '
        lblRating.AutoSize = True
        lblRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblRating.Location = New System.Drawing.Point(464, 176)
        lblRating.Name = "lblRating"
        lblRating.Size = New System.Drawing.Size(153, 24)
        lblRating.TabIndex = 17
        lblRating.Text = "Academy Rating:"
        '
        'lblGenre
        '
        lblGenre.AutoSize = True
        lblGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblGenre.Location = New System.Drawing.Point(12, 194)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New System.Drawing.Size(68, 24)
        lblGenre.TabIndex = 19
        lblGenre.Text = "Genre:"
        '
        'tolToolbar
        '
        Me.tolToolbar.AddNewItem = Me.cmdNew
        Me.tolToolbar.BindingSource = Me.VideosBindingSource
        Me.tolToolbar.CountItem = Nothing
        Me.tolToolbar.DeleteItem = Me.cmdDelete
        Me.tolToolbar.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tolToolbar.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tolToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdEdit, Me.cmdNew, Me.ToolStripSeparator2, Me.cmdDelete, Me.cmdSave, Me.ToolStripSeparator1, Me.cmdKevin, Me.ToolStripSeparator3, Me.cmdAvengers, Me.ToolStripSeparator4, Me.cmdFive, Me.ToolStripSeparator5, Me.cmdReset})
        Me.tolToolbar.Location = New System.Drawing.Point(0, 24)
        Me.tolToolbar.MoveFirstItem = Nothing
        Me.tolToolbar.MoveLastItem = Nothing
        Me.tolToolbar.MoveNextItem = Nothing
        Me.tolToolbar.MovePreviousItem = Nothing
        Me.tolToolbar.Name = "tolToolbar"
        Me.tolToolbar.PositionItem = Nothing
        Me.tolToolbar.Size = New System.Drawing.Size(774, 39)
        Me.tolToolbar.TabIndex = 0
        Me.tolToolbar.Text = "BindingNavigator1"
        '
        'cmdNew
        '
        Me.cmdNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Image)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeftAutoMirrorImage = True
        Me.cmdNew.Size = New System.Drawing.Size(36, 36)
        Me.cmdNew.Text = "Add New"
        Me.cmdNew.ToolTipText = "Add New Movie"
        '
        'VideosBindingSource
        '
        Me.VideosBindingSource.DataMember = "Videos"
        Me.VideosBindingSource.DataSource = Me.MovieDataSet
        '
        'MovieDataSet
        '
        Me.MovieDataSet.DataSetName = "movieDataSet"
        Me.MovieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdDelete
        '
        Me.cmdDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeftAutoMirrorImage = True
        Me.cmdDelete.Size = New System.Drawing.Size(36, 36)
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.ToolTipText = "Delete Movie"
        '
        'cmdEdit
        '
        Me.cmdEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdEdit.Image = Global.vb5_v2_Movie_Database.My.Resources.Resources.open
        Me.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(36, 36)
        Me.cmdEdit.Text = "ToolStripButton1"
        Me.cmdEdit.ToolTipText = "Edit Movie"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdSave
        '
        Me.cmdSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSave.Enabled = False
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(36, 36)
        Me.cmdSave.Text = "Save Data"
        Me.cmdSave.ToolTipText = "Save Movie"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdKevin
        '
        Me.cmdKevin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdKevin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdKevin.Name = "cmdKevin"
        Me.cmdKevin.Size = New System.Drawing.Size(115, 36)
        Me.cmdKevin.Text = "&Kevin Smith"
        Me.cmdKevin.ToolTipText = "Find all Kevin Smith movies"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'cmdAvengers
        '
        Me.cmdAvengers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdAvengers.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAvengers.Name = "cmdAvengers"
        Me.cmdAvengers.Size = New System.Drawing.Size(184, 36)
        Me.cmdAvengers.Text = "&Avengers Assemble!"
        Me.cmdAvengers.ToolTipText = "Find all Robert Downey Jr. movies"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'cmdFive
        '
        Me.cmdFive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdFive.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFive.Name = "cmdFive"
        Me.cmdFive.Size = New System.Drawing.Size(56, 36)
        Me.cmdFive.Text = "&*****"
        Me.cmdFive.ToolTipText = "Find all five star (*****) movies"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdReset.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(122, 36)
        Me.cmdReset.Text = "&Reset Search"
        Me.cmdReset.ToolTipText = "Show all movies"
        '
        'grdMovies
        '
        Me.grdMovies.AllowUserToAddRows = False
        Me.grdMovies.AllowUserToOrderColumns = True
        Me.grdMovies.AllowUserToResizeRows = False
        Me.grdMovies.AutoGenerateColumns = False
        Me.grdMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMovies.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.grdMovies.DataSource = Me.VideosBindingSource
        Me.grdMovies.Location = New System.Drawing.Point(12, 236)
        Me.grdMovies.Name = "grdMovies"
        Me.grdMovies.ReadOnly = True
        Me.grdMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdMovies.Size = New System.Drawing.Size(742, 234)
        Me.grdMovies.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Movie ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Movie ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Director"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Director"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Year Released"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Year Released"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Male Actor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Male Actor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Female Actor"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Female Actor"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Star Rating"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Star Rating"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Academy Rating"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Academy Rating"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Genre"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Genre"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.mnuSearch, Me.mnuHelp})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(774, 24)
        Me.mnuMain.TabIndex = 2
        Me.mnuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuEdit, Me.ToolStripSeparator9, Me.mnuSave, Me.ToolStripSeparator8, Me.mnuDelete, Me.ToolStripSeparator7, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(107, 22)
        Me.mnuNew.Text = "&New"
        Me.mnuNew.ToolTipText = "Add New Movie"
        '
        'mnuEdit
        '
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(107, 22)
        Me.mnuEdit.Text = "&Edit"
        Me.mnuEdit.ToolTipText = "Edit Movie"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(104, 6)
        '
        'mnuSave
        '
        Me.mnuSave.Enabled = False
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(107, 22)
        Me.mnuSave.Text = "&Save"
        Me.mnuSave.ToolTipText = "Save Movie"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(104, 6)
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(107, 22)
        Me.mnuDelete.Text = "&Delete"
        Me.mnuDelete.ToolTipText = "Delete Movie"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(104, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(107, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuSearch
        '
        Me.mnuSearch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuKevin, Me.mnuAvengers, Me.mnuFive, Me.ToolStripSeparator6, Me.mnuReset})
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.Size = New System.Drawing.Size(119, 20)
        Me.mnuSearch.Text = "&Search Commands"
        '
        'mnuKevin
        '
        Me.mnuKevin.Name = "mnuKevin"
        Me.mnuKevin.Size = New System.Drawing.Size(137, 22)
        Me.mnuKevin.Text = "&Kevin Smith"
        Me.mnuKevin.ToolTipText = "Find all Kevin Smith movies"
        '
        'mnuAvengers
        '
        Me.mnuAvengers.Name = "mnuAvengers"
        Me.mnuAvengers.Size = New System.Drawing.Size(137, 22)
        Me.mnuAvengers.Text = "&Avengers"
        Me.mnuAvengers.ToolTipText = "Find all Robert Downey Jr. movies"
        '
        'mnuFive
        '
        Me.mnuFive.Name = "mnuFive"
        Me.mnuFive.Size = New System.Drawing.Size(137, 22)
        Me.mnuFive.Text = "&Five Stars"
        Me.mnuFive.ToolTipText = "Find all five star (*****) movies"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(134, 6)
        '
        'mnuReset
        '
        Me.mnuReset.Name = "mnuReset"
        Me.mnuReset.Size = New System.Drawing.Size(137, 22)
        Me.mnuReset.Text = "&Reset"
        Me.mnuReset.ToolTipText = "Show all movies"
        '
        'mnuHelp
        '
        Me.mnuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(152, 22)
        Me.mnuAbout.Text = "&About"
        '
        'VideosTableAdapter
        '
        Me.VideosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = vb5_v2_Movie_Database.movieDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VideosTableAdapter = Me.VideosTableAdapter
        '
        'txtTitle
        '
        Me.txtTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "Title", True))
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(68, 73)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(299, 29)
        Me.txtTitle.TabIndex = 4
        Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDirector
        '
        Me.txtDirector.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "Director", True))
        Me.txtDirector.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirector.Location = New System.Drawing.Point(490, 73)
        Me.txtDirector.Name = "txtDirector"
        Me.txtDirector.ReadOnly = True
        Me.txtDirector.Size = New System.Drawing.Size(264, 29)
        Me.txtDirector.TabIndex = 6
        Me.txtDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMakeActor
        '
        Me.txtMakeActor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "Male Actor", True))
        Me.txtMakeActor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMakeActor.Location = New System.Drawing.Point(123, 116)
        Me.txtMakeActor.Name = "txtMakeActor"
        Me.txtMakeActor.ReadOnly = True
        Me.txtMakeActor.Size = New System.Drawing.Size(244, 29)
        Me.txtMakeActor.TabIndex = 8
        Me.txtMakeActor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFemaleActor
        '
        Me.txtFemaleActor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "Female Actor", True))
        Me.txtFemaleActor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFemaleActor.Location = New System.Drawing.Point(538, 116)
        Me.txtFemaleActor.Name = "txtFemaleActor"
        Me.txtFemaleActor.ReadOnly = True
        Me.txtFemaleActor.Size = New System.Drawing.Size(216, 29)
        Me.txtFemaleActor.TabIndex = 10
        Me.txtFemaleActor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblMovieID
        '
        Me.lblMovieID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "Movie ID", True))
        Me.lblMovieID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieID.Location = New System.Drawing.Point(106, 158)
        Me.lblMovieID.Name = "lblMovieID"
        Me.lblMovieID.Size = New System.Drawing.Size(41, 23)
        Me.lblMovieID.TabIndex = 12
        Me.lblMovieID.Text = "999"
        Me.lblMovieID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudYear
        '
        Me.nudYear.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VideosBindingSource, "Year Released", True))
        Me.nudYear.Enabled = False
        Me.nudYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudYear.Location = New System.Drawing.Point(298, 156)
        Me.nudYear.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1950, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.ReadOnly = True
        Me.nudYear.Size = New System.Drawing.Size(69, 29)
        Me.nudYear.TabIndex = 14
        Me.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudYear.Value = New Decimal(New Integer() {1950, 0, 0, 0})
        '
        'cboStar
        '
        Me.cboStar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "Star Rating", True))
        Me.cboStar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStar.Enabled = False
        Me.cboStar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStar.FormattingEnabled = True
        Me.cboStar.Items.AddRange(New Object() {"*", "**", "***", "****", "*****"})
        Me.cboStar.Location = New System.Drawing.Point(320, 191)
        Me.cboStar.Name = "cboStar"
        Me.cboStar.Size = New System.Drawing.Size(60, 32)
        Me.cboStar.TabIndex = 16
        '
        'cboRaiting
        '
        Me.cboRaiting.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "Academy Rating", True))
        Me.cboRaiting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRaiting.Enabled = False
        Me.cboRaiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRaiting.FormattingEnabled = True
        Me.cboRaiting.Items.AddRange(New Object() {"G", "PG", "PG-13", "R", "NC-17"})
        Me.cboRaiting.Location = New System.Drawing.Point(623, 173)
        Me.cboRaiting.Name = "cboRaiting"
        Me.cboRaiting.Size = New System.Drawing.Size(80, 32)
        Me.cboRaiting.TabIndex = 18
        '
        'cboGenre
        '
        Me.cboGenre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VideosBindingSource, "Genre", True))
        Me.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGenre.Enabled = False
        Me.cboGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGenre.FormattingEnabled = True
        Me.cboGenre.Items.AddRange(New Object() {"Action", "Comedy", "Drama", "Horror", "Martial Arts", "Musical", "Romance", "Sci-Fi", "Suspense", "Western"})
        Me.cboGenre.Location = New System.Drawing.Point(86, 191)
        Me.cboGenre.Name = "cboGenre"
        Me.cboGenre.Size = New System.Drawing.Size(117, 32)
        Me.cboGenre.TabIndex = 20
        '
        'frmMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 490)
        Me.Controls.Add(lblGenre)
        Me.Controls.Add(Me.cboGenre)
        Me.Controls.Add(lblRating)
        Me.Controls.Add(Me.cboRaiting)
        Me.Controls.Add(lblStar)
        Me.Controls.Add(Me.cboStar)
        Me.Controls.Add(lblYear)
        Me.Controls.Add(Me.nudYear)
        Me.Controls.Add(lblMovieIDlbl)
        Me.Controls.Add(Me.lblMovieID)
        Me.Controls.Add(lblFemaleActor)
        Me.Controls.Add(Me.txtFemaleActor)
        Me.Controls.Add(lblMaleActor)
        Me.Controls.Add(Me.txtMakeActor)
        Me.Controls.Add(lblDirector)
        Me.Controls.Add(Me.txtDirector)
        Me.Controls.Add(lblTitle)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.grdMovies)
        Me.Controls.Add(Me.tolToolbar)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMovie"
        Me.Text = "Movie Database"
        CType(Me.tolToolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tolToolbar.ResumeLayout(False)
        Me.tolToolbar.PerformLayout()
        CType(Me.VideosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdMovies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MovieDataSet As movieDataSet
    Friend WithEvents VideosBindingSource As BindingSource
    Friend WithEvents VideosTableAdapter As movieDataSetTableAdapters.VideosTableAdapter
    Friend WithEvents TableAdapterManager As movieDataSetTableAdapters.TableAdapterManager
    Friend WithEvents tolToolbar As BindingNavigator
    Friend WithEvents cmdNew As ToolStripButton
    Friend WithEvents cmdDelete As ToolStripButton
    Friend WithEvents cmdSave As ToolStripButton
    Friend WithEvents grdMovies As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents cmdKevin As ToolStripButton
    Friend WithEvents cmdEdit As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents cmdAvengers As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents cmdFive As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents cmdReset As ToolStripButton
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSearch As ToolStripMenuItem
    Friend WithEvents mnuKevin As ToolStripMenuItem
    Friend WithEvents mnuAvengers As ToolStripMenuItem
    Friend WithEvents mnuFive As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents mnuReset As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtDirector As TextBox
    Friend WithEvents txtMakeActor As TextBox
    Friend WithEvents txtFemaleActor As TextBox
    Friend WithEvents lblMovieID As Label
    Friend WithEvents nudYear As NumericUpDown
    Friend WithEvents cboStar As ComboBox
    Friend WithEvents cboRaiting As ComboBox
    Friend WithEvents cboGenre As ComboBox
End Class
