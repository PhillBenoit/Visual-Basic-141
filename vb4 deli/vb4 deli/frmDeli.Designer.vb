<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeli
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeli))
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.PricingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpMeat = New System.Windows.Forms.GroupBox()
        Me.chkRB = New System.Windows.Forms.CheckBox()
        Me.chkTurkey = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.grpCheese = New System.Windows.Forms.GroupBox()
        Me.chkJack = New System.Windows.Forms.CheckBox()
        Me.chkCheddar = New System.Windows.Forms.CheckBox()
        Me.chkSwiss = New System.Windows.Forms.CheckBox()
        Me.grpCondiments = New System.Windows.Forms.GroupBox()
        Me.chkPepper = New System.Windows.Forms.CheckBox()
        Me.chkSalt = New System.Windows.Forms.CheckBox()
        Me.chkVinegar = New System.Windows.Forms.CheckBox()
        Me.chkOil = New System.Windows.Forms.CheckBox()
        Me.chkPickle = New System.Windows.Forms.CheckBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkLettuce = New System.Windows.Forms.CheckBox()
        Me.chkMustard = New System.Windows.Forms.CheckBox()
        Me.chkMayo = New System.Windows.Forms.CheckBox()
        Me.chkKetchup = New System.Windows.Forms.CheckBox()
        Me.chkJalapeños = New System.Windows.Forms.CheckBox()
        Me.grpDrinks = New System.Windows.Forms.GroupBox()
        Me.chkAJ = New System.Windows.Forms.CheckBox()
        Me.chkEvian = New System.Windows.Forms.CheckBox()
        Me.grpBread = New System.Windows.Forms.GroupBox()
        Me.optWheat = New System.Windows.Forms.RadioButton()
        Me.optPumpernickel = New System.Windows.Forms.RadioButton()
        Me.optWhite = New System.Windows.Forms.RadioButton()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotallbl = New System.Windows.Forms.Label()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.PrintDocumentReceipt = New System.Drawing.Printing.PrintDocument()
        Me.ReceiptPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
        Me.mnuMenu.SuspendLayout()
        Me.grpMeat.SuspendLayout()
        Me.grpCheese.SuspendLayout()
        Me.grpCondiments.SuspendLayout()
        Me.grpDrinks.SuspendLayout()
        Me.grpBread.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(561, 24)
        Me.mnuMenu.TabIndex = 0
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'mnuHelp
        '
        Me.mnuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PricingToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'PricingToolStripMenuItem
        '
        Me.PricingToolStripMenuItem.Name = "PricingToolStripMenuItem"
        Me.PricingToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.PricingToolStripMenuItem.Text = "&Pricing"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(108, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'grpMeat
        '
        Me.grpMeat.Controls.Add(Me.chkRB)
        Me.grpMeat.Controls.Add(Me.chkTurkey)
        Me.grpMeat.Controls.Add(Me.chkHam)
        Me.grpMeat.Location = New System.Drawing.Point(25, 46)
        Me.grpMeat.Name = "grpMeat"
        Me.grpMeat.Size = New System.Drawing.Size(129, 126)
        Me.grpMeat.TabIndex = 1
        Me.grpMeat.TabStop = False
        Me.grpMeat.Text = "Meat Options"
        '
        'chkRB
        '
        Me.chkRB.AutoSize = True
        Me.chkRB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRB.Location = New System.Drawing.Point(6, 87)
        Me.chkRB.Name = "chkRB"
        Me.chkRB.Size = New System.Drawing.Size(119, 28)
        Me.chkRB.TabIndex = 23
        Me.chkRB.TabStop = False
        Me.chkRB.Text = "Roast Beef"
        Me.chkRB.UseVisualStyleBackColor = True
        '
        'chkTurkey
        '
        Me.chkTurkey.AutoSize = True
        Me.chkTurkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTurkey.Location = New System.Drawing.Point(6, 53)
        Me.chkTurkey.Name = "chkTurkey"
        Me.chkTurkey.Size = New System.Drawing.Size(87, 28)
        Me.chkTurkey.TabIndex = 22
        Me.chkTurkey.TabStop = False
        Me.chkTurkey.Text = "Turkey"
        Me.chkTurkey.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkHam.Location = New System.Drawing.Point(6, 19)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(69, 28)
        Me.chkHam.TabIndex = 21
        Me.chkHam.Text = "Ham"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'grpCheese
        '
        Me.grpCheese.Controls.Add(Me.chkJack)
        Me.grpCheese.Controls.Add(Me.chkCheddar)
        Me.grpCheese.Controls.Add(Me.chkSwiss)
        Me.grpCheese.Location = New System.Drawing.Point(25, 178)
        Me.grpCheese.Name = "grpCheese"
        Me.grpCheese.Size = New System.Drawing.Size(109, 122)
        Me.grpCheese.TabIndex = 2
        Me.grpCheese.TabStop = False
        Me.grpCheese.Text = "Cheese Options"
        '
        'chkJack
        '
        Me.chkJack.AutoSize = True
        Me.chkJack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJack.Location = New System.Drawing.Point(6, 87)
        Me.chkJack.Name = "chkJack"
        Me.chkJack.Size = New System.Drawing.Size(67, 28)
        Me.chkJack.TabIndex = 33
        Me.chkJack.TabStop = False
        Me.chkJack.Text = "Jack"
        Me.chkJack.UseVisualStyleBackColor = True
        '
        'chkCheddar
        '
        Me.chkCheddar.AutoSize = True
        Me.chkCheddar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCheddar.Location = New System.Drawing.Point(6, 53)
        Me.chkCheddar.Name = "chkCheddar"
        Me.chkCheddar.Size = New System.Drawing.Size(102, 28)
        Me.chkCheddar.TabIndex = 32
        Me.chkCheddar.TabStop = False
        Me.chkCheddar.Text = "Cheddar"
        Me.chkCheddar.UseVisualStyleBackColor = True
        '
        'chkSwiss
        '
        Me.chkSwiss.AutoSize = True
        Me.chkSwiss.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSwiss.Location = New System.Drawing.Point(6, 19)
        Me.chkSwiss.Name = "chkSwiss"
        Me.chkSwiss.Size = New System.Drawing.Size(77, 28)
        Me.chkSwiss.TabIndex = 31
        Me.chkSwiss.Text = "Swiss"
        Me.chkSwiss.UseVisualStyleBackColor = True
        '
        'grpCondiments
        '
        Me.grpCondiments.Controls.Add(Me.chkPepper)
        Me.grpCondiments.Controls.Add(Me.chkSalt)
        Me.grpCondiments.Controls.Add(Me.chkVinegar)
        Me.grpCondiments.Controls.Add(Me.chkOil)
        Me.grpCondiments.Controls.Add(Me.chkPickle)
        Me.grpCondiments.Controls.Add(Me.chkTomato)
        Me.grpCondiments.Controls.Add(Me.chkLettuce)
        Me.grpCondiments.Controls.Add(Me.chkMustard)
        Me.grpCondiments.Controls.Add(Me.chkMayo)
        Me.grpCondiments.Controls.Add(Me.chkKetchup)
        Me.grpCondiments.Location = New System.Drawing.Point(160, 46)
        Me.grpCondiments.Name = "grpCondiments"
        Me.grpCondiments.Size = New System.Drawing.Size(209, 199)
        Me.grpCondiments.TabIndex = 3
        Me.grpCondiments.TabStop = False
        Me.grpCondiments.Text = "Condiment Options"
        '
        'chkPepper
        '
        Me.chkPepper.AutoSize = True
        Me.chkPepper.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPepper.Location = New System.Drawing.Point(111, 166)
        Me.chkPepper.Name = "chkPepper"
        Me.chkPepper.Size = New System.Drawing.Size(91, 28)
        Me.chkPepper.TabIndex = 70
        Me.chkPepper.TabStop = False
        Me.chkPepper.Text = "Pepper"
        Me.chkPepper.UseVisualStyleBackColor = True
        '
        'chkSalt
        '
        Me.chkSalt.AutoSize = True
        Me.chkSalt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSalt.Location = New System.Drawing.Point(111, 132)
        Me.chkSalt.Name = "chkSalt"
        Me.chkSalt.Size = New System.Drawing.Size(59, 28)
        Me.chkSalt.TabIndex = 69
        Me.chkSalt.TabStop = False
        Me.chkSalt.Text = "Salt"
        Me.chkSalt.UseVisualStyleBackColor = True
        '
        'chkVinegar
        '
        Me.chkVinegar.AutoSize = True
        Me.chkVinegar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVinegar.Location = New System.Drawing.Point(6, 166)
        Me.chkVinegar.Name = "chkVinegar"
        Me.chkVinegar.Size = New System.Drawing.Size(95, 28)
        Me.chkVinegar.TabIndex = 68
        Me.chkVinegar.TabStop = False
        Me.chkVinegar.Text = "Vinegar"
        Me.chkVinegar.UseVisualStyleBackColor = True
        '
        'chkOil
        '
        Me.chkOil.AutoSize = True
        Me.chkOil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOil.Location = New System.Drawing.Point(6, 132)
        Me.chkOil.Name = "chkOil"
        Me.chkOil.Size = New System.Drawing.Size(52, 28)
        Me.chkOil.TabIndex = 67
        Me.chkOil.TabStop = False
        Me.chkOil.Text = "Oil"
        Me.chkOil.UseVisualStyleBackColor = True
        '
        'chkPickle
        '
        Me.chkPickle.AutoSize = True
        Me.chkPickle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPickle.Location = New System.Drawing.Point(111, 87)
        Me.chkPickle.Name = "chkPickle"
        Me.chkPickle.Size = New System.Drawing.Size(79, 28)
        Me.chkPickle.TabIndex = 66
        Me.chkPickle.TabStop = False
        Me.chkPickle.Text = "Pickle"
        Me.chkPickle.UseVisualStyleBackColor = True
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTomato.Location = New System.Drawing.Point(111, 53)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(93, 28)
        Me.chkTomato.TabIndex = 65
        Me.chkTomato.TabStop = False
        Me.chkTomato.Text = "Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkLettuce
        '
        Me.chkLettuce.AutoSize = True
        Me.chkLettuce.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLettuce.Location = New System.Drawing.Point(111, 19)
        Me.chkLettuce.Name = "chkLettuce"
        Me.chkLettuce.Size = New System.Drawing.Size(90, 28)
        Me.chkLettuce.TabIndex = 64
        Me.chkLettuce.TabStop = False
        Me.chkLettuce.Text = "Lettuce"
        Me.chkLettuce.UseVisualStyleBackColor = True
        '
        'chkMustard
        '
        Me.chkMustard.AutoSize = True
        Me.chkMustard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMustard.Location = New System.Drawing.Point(6, 87)
        Me.chkMustard.Name = "chkMustard"
        Me.chkMustard.Size = New System.Drawing.Size(96, 28)
        Me.chkMustard.TabIndex = 63
        Me.chkMustard.TabStop = False
        Me.chkMustard.Text = "Mustard"
        Me.chkMustard.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMayo.Location = New System.Drawing.Point(6, 53)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(75, 28)
        Me.chkMayo.TabIndex = 62
        Me.chkMayo.TabStop = False
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkKetchup
        '
        Me.chkKetchup.AutoSize = True
        Me.chkKetchup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKetchup.Location = New System.Drawing.Point(6, 19)
        Me.chkKetchup.Name = "chkKetchup"
        Me.chkKetchup.Size = New System.Drawing.Size(99, 28)
        Me.chkKetchup.TabIndex = 61
        Me.chkKetchup.Text = "Ketchup"
        Me.chkKetchup.UseVisualStyleBackColor = True
        '
        'chkJalapeños
        '
        Me.chkJalapeños.AutoSize = True
        Me.chkJalapeños.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkJalapeños.Location = New System.Drawing.Point(166, 265)
        Me.chkJalapeños.Name = "chkJalapeños"
        Me.chkJalapeños.Size = New System.Drawing.Size(115, 28)
        Me.chkJalapeños.TabIndex = 4
        Me.chkJalapeños.Text = "Jalapeños"
        Me.chkJalapeños.UseVisualStyleBackColor = True
        '
        'grpDrinks
        '
        Me.grpDrinks.Controls.Add(Me.chkAJ)
        Me.grpDrinks.Controls.Add(Me.chkEvian)
        Me.grpDrinks.Location = New System.Drawing.Point(375, 46)
        Me.grpDrinks.Name = "grpDrinks"
        Me.grpDrinks.Size = New System.Drawing.Size(141, 84)
        Me.grpDrinks.TabIndex = 5
        Me.grpDrinks.TabStop = False
        Me.grpDrinks.Text = "Drink Options"
        '
        'chkAJ
        '
        Me.chkAJ.AutoSize = True
        Me.chkAJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAJ.Location = New System.Drawing.Point(6, 53)
        Me.chkAJ.Name = "chkAJ"
        Me.chkAJ.Size = New System.Drawing.Size(129, 28)
        Me.chkAJ.TabIndex = 42
        Me.chkAJ.TabStop = False
        Me.chkAJ.Text = "Apple Juice"
        Me.chkAJ.UseVisualStyleBackColor = True
        '
        'chkEvian
        '
        Me.chkEvian.AutoSize = True
        Me.chkEvian.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEvian.Location = New System.Drawing.Point(6, 19)
        Me.chkEvian.Name = "chkEvian"
        Me.chkEvian.Size = New System.Drawing.Size(76, 28)
        Me.chkEvian.TabIndex = 41
        Me.chkEvian.Text = "Evian"
        Me.chkEvian.UseVisualStyleBackColor = True
        '
        'grpBread
        '
        Me.grpBread.Controls.Add(Me.optWheat)
        Me.grpBread.Controls.Add(Me.optPumpernickel)
        Me.grpBread.Controls.Add(Me.optWhite)
        Me.grpBread.Location = New System.Drawing.Point(375, 137)
        Me.grpBread.Name = "grpBread"
        Me.grpBread.Size = New System.Drawing.Size(158, 122)
        Me.grpBread.TabIndex = 6
        Me.grpBread.TabStop = False
        Me.grpBread.Text = "Bread Options"
        '
        'optWheat
        '
        Me.optWheat.AutoSize = True
        Me.optWheat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optWheat.Location = New System.Drawing.Point(7, 54)
        Me.optWheat.Name = "optWheat"
        Me.optWheat.Size = New System.Drawing.Size(142, 28)
        Me.optWheat.TabIndex = 52
        Me.optWheat.Text = "Whole Wheat"
        Me.optWheat.UseVisualStyleBackColor = True
        '
        'optPumpernickel
        '
        Me.optPumpernickel.AutoSize = True
        Me.optPumpernickel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPumpernickel.Location = New System.Drawing.Point(7, 88)
        Me.optPumpernickel.Name = "optPumpernickel"
        Me.optPumpernickel.Size = New System.Drawing.Size(149, 28)
        Me.optPumpernickel.TabIndex = 53
        Me.optPumpernickel.Text = "Pumpernickel "
        Me.optPumpernickel.UseVisualStyleBackColor = True
        '
        'optWhite
        '
        Me.optWhite.AutoSize = True
        Me.optWhite.Checked = True
        Me.optWhite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optWhite.Location = New System.Drawing.Point(7, 20)
        Me.optWhite.Name = "optWhite"
        Me.optWhite.Size = New System.Drawing.Size(76, 28)
        Me.optWhite.TabIndex = 51
        Me.optWhite.TabStop = True
        Me.optWhite.Text = "White"
        Me.optWhite.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.Location = New System.Drawing.Point(234, 298)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(144, 54)
        Me.cmdPrint.TabIndex = 7
        Me.cmdPrint.Text = "&Looks good!"
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(114, 321)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(82, 31)
        Me.lblTotal.TabIndex = 11
        Me.lblTotal.Text = "$6.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotallbl
        '
        Me.lblTotallbl.AutoSize = True
        Me.lblTotallbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotallbl.Location = New System.Drawing.Point(25, 321)
        Me.lblTotallbl.Name = "lblTotallbl"
        Me.lblTotallbl.Size = New System.Drawing.Size(83, 31)
        Me.lblTotallbl.TabIndex = 12
        Me.lblTotallbl.Text = "Total:"
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(384, 298)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(149, 54)
        Me.cmdClear.TabIndex = 8
        Me.cmdClear.Text = "&Start Over!"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'PrintDocumentReceipt
        '
        '
        'ReceiptPreviewDialog
        '
        Me.ReceiptPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.ReceiptPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.ReceiptPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.ReceiptPreviewDialog.Enabled = True
        Me.ReceiptPreviewDialog.Icon = CType(resources.GetObject("ReceiptPreviewDialog.Icon"), System.Drawing.Icon)
        Me.ReceiptPreviewDialog.Name = "PrintPreviewDialog1"
        Me.ReceiptPreviewDialog.Visible = False
        '
        'frmDeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 371)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.lblTotallbl)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.grpBread)
        Me.Controls.Add(Me.grpDrinks)
        Me.Controls.Add(Me.chkJalapeños)
        Me.Controls.Add(Me.grpCondiments)
        Me.Controls.Add(Me.grpCheese)
        Me.Controls.Add(Me.grpMeat)
        Me.Controls.Add(Me.mnuMenu)
        Me.Name = "frmDeli"
        Me.Text = "Choose Your Combo!"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.grpMeat.ResumeLayout(False)
        Me.grpMeat.PerformLayout()
        Me.grpCheese.ResumeLayout(False)
        Me.grpCheese.PerformLayout()
        Me.grpCondiments.ResumeLayout(False)
        Me.grpCondiments.PerformLayout()
        Me.grpDrinks.ResumeLayout(False)
        Me.grpDrinks.PerformLayout()
        Me.grpBread.ResumeLayout(False)
        Me.grpBread.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMenu As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents PricingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpMeat As GroupBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents chkRB As CheckBox
    Friend WithEvents chkTurkey As CheckBox
    Friend WithEvents grpCheese As GroupBox
    Friend WithEvents chkJack As CheckBox
    Friend WithEvents chkCheddar As CheckBox
    Friend WithEvents chkSwiss As CheckBox
    Friend WithEvents grpCondiments As GroupBox
    Friend WithEvents chkPepper As CheckBox
    Friend WithEvents chkSalt As CheckBox
    Friend WithEvents chkVinegar As CheckBox
    Friend WithEvents chkOil As CheckBox
    Friend WithEvents chkPickle As CheckBox
    Friend WithEvents chkTomato As CheckBox
    Friend WithEvents chkLettuce As CheckBox
    Friend WithEvents chkMustard As CheckBox
    Friend WithEvents chkMayo As CheckBox
    Friend WithEvents chkKetchup As CheckBox
    Friend WithEvents chkJalapeños As CheckBox
    Friend WithEvents grpDrinks As GroupBox
    Friend WithEvents chkAJ As CheckBox
    Friend WithEvents chkEvian As CheckBox
    Friend WithEvents grpBread As GroupBox
    Friend WithEvents optWheat As RadioButton
    Friend WithEvents optPumpernickel As RadioButton
    Friend WithEvents optWhite As RadioButton
    Friend WithEvents cmdPrint As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotallbl As Label
    Friend WithEvents cmdClear As Button
    Friend WithEvents PrintDocumentReceipt As Printing.PrintDocument
    Friend WithEvents ReceiptPreviewDialog As PrintPreviewDialog
End Class
