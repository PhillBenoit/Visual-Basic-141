<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChange
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
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblDSCash = New System.Windows.Forms.Label()
        Me.lblDSTotal = New System.Windows.Forms.Label()
        Me.lblEquals = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblChangelbl = New System.Windows.Forms.Label()
        Me.lblTwenties = New System.Windows.Forms.Label()
        Me.lblTwentieslbl = New System.Windows.Forms.Label()
        Me.lblTenslbl = New System.Windows.Forms.Label()
        Me.lblTens = New System.Windows.Forms.Label()
        Me.lblFiveslbl = New System.Windows.Forms.Label()
        Me.lblFives = New System.Windows.Forms.Label()
        Me.lblOneslbl = New System.Windows.Forms.Label()
        Me.lblOnes = New System.Windows.Forms.Label()
        Me.lblBills = New System.Windows.Forms.Label()
        Me.lblCoins = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblQuarterslbl = New System.Windows.Forms.Label()
        Me.lblDimeslbl = New System.Windows.Forms.Label()
        Me.lblNickelslbl = New System.Windows.Forms.Label()
        Me.lblPennieslbl = New System.Windows.Forms.Label()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(47, 36)
        Me.txtCash.MaxLength = 7
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(100, 29)
        Me.txtCash.TabIndex = 0
        Me.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(190, 36)
        Me.txtTotal.MaxLength = 7
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 29)
        Me.txtTotal.TabIndex = 1
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblDSCash
        '
        Me.lblDSCash.AutoSize = True
        Me.lblDSCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDSCash.Location = New System.Drawing.Point(21, 39)
        Me.lblDSCash.Name = "lblDSCash"
        Me.lblDSCash.Size = New System.Drawing.Size(20, 24)
        Me.lblDSCash.TabIndex = 9
        Me.lblDSCash.Text = "$"
        '
        'lblDSTotal
        '
        Me.lblDSTotal.AutoSize = True
        Me.lblDSTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDSTotal.Location = New System.Drawing.Point(153, 39)
        Me.lblDSTotal.Name = "lblDSTotal"
        Me.lblDSTotal.Size = New System.Drawing.Size(31, 24)
        Me.lblDSTotal.TabIndex = 10
        Me.lblDSTotal.Text = "- $"
        '
        'lblEquals
        '
        Me.lblEquals.AutoSize = True
        Me.lblEquals.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquals.Location = New System.Drawing.Point(296, 39)
        Me.lblEquals.Name = "lblEquals"
        Me.lblEquals.Size = New System.Drawing.Size(21, 24)
        Me.lblEquals.TabIndex = 11
        Me.lblEquals.Text = "="
        '
        'lblChange
        '
        Me.lblChange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(323, 39)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChange.Size = New System.Drawing.Size(102, 24)
        Me.lblChange.TabIndex = 12
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(72, 9)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(53, 24)
        Me.lblCash.TabIndex = 13
        Me.lblCash.Text = "Cash"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(214, 9)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 24)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.Text = "Total"
        '
        'lblChangelbl
        '
        Me.lblChangelbl.AutoSize = True
        Me.lblChangelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangelbl.Location = New System.Drawing.Point(336, 9)
        Me.lblChangelbl.Name = "lblChangelbl"
        Me.lblChangelbl.Size = New System.Drawing.Size(77, 24)
        Me.lblChangelbl.TabIndex = 15
        Me.lblChangelbl.Text = "Change"
        '
        'lblTwenties
        '
        Me.lblTwenties.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTwenties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTwenties.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwenties.Location = New System.Drawing.Point(115, 107)
        Me.lblTwenties.Name = "lblTwenties"
        Me.lblTwenties.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTwenties.Size = New System.Drawing.Size(54, 24)
        Me.lblTwenties.TabIndex = 16
        Me.lblTwenties.Tag = "20"
        Me.lblTwenties.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTwentieslbl
        '
        Me.lblTwentieslbl.AutoSize = True
        Me.lblTwentieslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwentieslbl.Location = New System.Drawing.Point(98, 83)
        Me.lblTwentieslbl.Name = "lblTwentieslbl"
        Me.lblTwentieslbl.Size = New System.Drawing.Size(86, 24)
        Me.lblTwentieslbl.TabIndex = 17
        Me.lblTwentieslbl.Text = "Twenties"
        '
        'lblTenslbl
        '
        Me.lblTenslbl.AutoSize = True
        Me.lblTenslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTenslbl.Location = New System.Drawing.Point(198, 83)
        Me.lblTenslbl.Name = "lblTenslbl"
        Me.lblTenslbl.Size = New System.Drawing.Size(53, 24)
        Me.lblTenslbl.TabIndex = 18
        Me.lblTenslbl.Text = "Tens"
        '
        'lblTens
        '
        Me.lblTens.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTens.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTens.Location = New System.Drawing.Point(197, 107)
        Me.lblTens.Name = "lblTens"
        Me.lblTens.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTens.Size = New System.Drawing.Size(54, 24)
        Me.lblTens.TabIndex = 19
        Me.lblTens.Tag = "10"
        Me.lblTens.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblFiveslbl
        '
        Me.lblFiveslbl.AutoSize = True
        Me.lblFiveslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiveslbl.Location = New System.Drawing.Point(276, 83)
        Me.lblFiveslbl.Name = "lblFiveslbl"
        Me.lblFiveslbl.Size = New System.Drawing.Size(55, 24)
        Me.lblFiveslbl.TabIndex = 20
        Me.lblFiveslbl.Text = "Fives"
        '
        'lblFives
        '
        Me.lblFives.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFives.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFives.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFives.Location = New System.Drawing.Point(277, 107)
        Me.lblFives.Name = "lblFives"
        Me.lblFives.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFives.Size = New System.Drawing.Size(54, 24)
        Me.lblFives.TabIndex = 21
        Me.lblFives.Tag = "5"
        Me.lblFives.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOneslbl
        '
        Me.lblOneslbl.AutoSize = True
        Me.lblOneslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOneslbl.Location = New System.Drawing.Point(348, 83)
        Me.lblOneslbl.Name = "lblOneslbl"
        Me.lblOneslbl.Size = New System.Drawing.Size(56, 24)
        Me.lblOneslbl.TabIndex = 22
        Me.lblOneslbl.Text = "Ones"
        '
        'lblOnes
        '
        Me.lblOnes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOnes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOnes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnes.Location = New System.Drawing.Point(350, 107)
        Me.lblOnes.Name = "lblOnes"
        Me.lblOnes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOnes.Size = New System.Drawing.Size(54, 24)
        Me.lblOnes.TabIndex = 23
        Me.lblOnes.Tag = "1"
        Me.lblOnes.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblBills
        '
        Me.lblBills.AutoSize = True
        Me.lblBills.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBills.Location = New System.Drawing.Point(34, 108)
        Me.lblBills.Name = "lblBills"
        Me.lblBills.Size = New System.Drawing.Size(43, 24)
        Me.lblBills.TabIndex = 24
        Me.lblBills.Text = "Bills"
        '
        'lblCoins
        '
        Me.lblCoins.AutoSize = True
        Me.lblCoins.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoins.Location = New System.Drawing.Point(34, 163)
        Me.lblCoins.Name = "lblCoins"
        Me.lblCoins.Size = New System.Drawing.Size(58, 24)
        Me.lblCoins.TabIndex = 25
        Me.lblCoins.Text = "Coins"
        '
        'lblPennies
        '
        Me.lblPennies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPennies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPennies.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPennies.Location = New System.Drawing.Point(350, 162)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPennies.Size = New System.Drawing.Size(54, 24)
        Me.lblPennies.TabIndex = 29
        Me.lblPennies.Tag = ".01"
        Me.lblPennies.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNickels
        '
        Me.lblNickels.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNickels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNickels.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickels.Location = New System.Drawing.Point(277, 162)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblNickels.Size = New System.Drawing.Size(54, 24)
        Me.lblNickels.TabIndex = 28
        Me.lblNickels.Tag = ".05"
        Me.lblNickels.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblDimes
        '
        Me.lblDimes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDimes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimes.Location = New System.Drawing.Point(197, 162)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDimes.Size = New System.Drawing.Size(54, 24)
        Me.lblDimes.TabIndex = 27
        Me.lblDimes.Tag = ".1"
        Me.lblDimes.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblQuarters
        '
        Me.lblQuarters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuarters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblQuarters.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarters.Location = New System.Drawing.Point(115, 162)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblQuarters.Size = New System.Drawing.Size(54, 24)
        Me.lblQuarters.TabIndex = 26
        Me.lblQuarters.Tag = ".25"
        Me.lblQuarters.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblQuarterslbl
        '
        Me.lblQuarterslbl.AutoSize = True
        Me.lblQuarterslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarterslbl.Location = New System.Drawing.Point(100, 138)
        Me.lblQuarterslbl.Name = "lblQuarterslbl"
        Me.lblQuarterslbl.Size = New System.Drawing.Size(82, 24)
        Me.lblQuarterslbl.TabIndex = 30
        Me.lblQuarterslbl.Text = "Quarters"
        '
        'lblDimeslbl
        '
        Me.lblDimeslbl.AutoSize = True
        Me.lblDimeslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimeslbl.Location = New System.Drawing.Point(193, 138)
        Me.lblDimeslbl.Name = "lblDimeslbl"
        Me.lblDimeslbl.Size = New System.Drawing.Size(63, 24)
        Me.lblDimeslbl.TabIndex = 31
        Me.lblDimeslbl.Text = "Dimes"
        '
        'lblNickelslbl
        '
        Me.lblNickelslbl.AutoSize = True
        Me.lblNickelslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickelslbl.Location = New System.Drawing.Point(268, 138)
        Me.lblNickelslbl.Name = "lblNickelslbl"
        Me.lblNickelslbl.Size = New System.Drawing.Size(71, 24)
        Me.lblNickelslbl.TabIndex = 32
        Me.lblNickelslbl.Text = "Nickels"
        '
        'lblPennieslbl
        '
        Me.lblPennieslbl.AutoSize = True
        Me.lblPennieslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPennieslbl.Location = New System.Drawing.Point(337, 138)
        Me.lblPennieslbl.Name = "lblPennieslbl"
        Me.lblPennieslbl.Size = New System.Drawing.Size(79, 24)
        Me.lblPennieslbl.TabIndex = 33
        Me.lblPennieslbl.Text = "Pennies"
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculate.Location = New System.Drawing.Point(47, 202)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(100, 36)
        Me.cmdCalculate.TabIndex = 2
        Me.cmdCalculate.Text = "Calcualte"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(181, 202)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(100, 36)
        Me.cmdClear.TabIndex = 3
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(316, 202)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(100, 36)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.vb2_change.My.Resources.Resources.logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(450, 261)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.lblPennieslbl)
        Me.Controls.Add(Me.lblNickelslbl)
        Me.Controls.Add(Me.lblDimeslbl)
        Me.Controls.Add(Me.lblQuarterslbl)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblCoins)
        Me.Controls.Add(Me.lblBills)
        Me.Controls.Add(Me.lblOnes)
        Me.Controls.Add(Me.lblOneslbl)
        Me.Controls.Add(Me.lblFives)
        Me.Controls.Add(Me.lblFiveslbl)
        Me.Controls.Add(Me.lblTens)
        Me.Controls.Add(Me.lblTenslbl)
        Me.Controls.Add(Me.lblTwentieslbl)
        Me.Controls.Add(Me.lblTwenties)
        Me.Controls.Add(Me.lblChangelbl)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblEquals)
        Me.Controls.Add(Me.lblDSTotal)
        Me.Controls.Add(Me.lblDSCash)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtCash)
        Me.DoubleBuffered = True
        Me.Name = "frmChange"
        Me.Text = "Cange Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCash As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblDSCash As Label
    Friend WithEvents lblDSTotal As Label
    Friend WithEvents lblEquals As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents lblCash As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblChangelbl As Label
    Friend WithEvents lblTwenties As Label
    Friend WithEvents lblTwentieslbl As Label
    Friend WithEvents lblTenslbl As Label
    Friend WithEvents lblTens As Label
    Friend WithEvents lblFiveslbl As Label
    Friend WithEvents lblFives As Label
    Friend WithEvents lblOneslbl As Label
    Friend WithEvents lblOnes As Label
    Friend WithEvents lblBills As Label
    Friend WithEvents lblCoins As Label
    Friend WithEvents lblPennies As Label
    Friend WithEvents lblNickels As Label
    Friend WithEvents lblDimes As Label
    Friend WithEvents lblQuarters As Label
    Friend WithEvents lblQuarterslbl As Label
    Friend WithEvents lblDimeslbl As Label
    Friend WithEvents lblNickelslbl As Label
    Friend WithEvents lblPennieslbl As Label
    Friend WithEvents cmdCalculate As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdExit As Button
End Class
