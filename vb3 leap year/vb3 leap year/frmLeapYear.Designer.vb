<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeapYear
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
        Me.lstDetectedYears = New System.Windows.Forms.ListBox()
        Me.nudStart = New System.Windows.Forms.NumericUpDown()
        Me.nudEnd = New System.Windows.Forms.NumericUpDown()
        Me.grpStart = New System.Windows.Forms.GroupBox()
        Me.optStartCE = New System.Windows.Forms.RadioButton()
        Me.optStartBCE = New System.Windows.Forms.RadioButton()
        Me.grpEnd = New System.Windows.Forms.GroupBox()
        Me.optEndBCE = New System.Windows.Forms.RadioButton()
        Me.optEndCE = New System.Windows.Forms.RadioButton()
        Me.chkIncludeStart = New System.Windows.Forms.CheckBox()
        Me.chkIncludeEnd = New System.Windows.Forms.CheckBox()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblYearsCounted = New System.Windows.Forms.Label()
        Me.grpLooping = New System.Windows.Forms.GroupBox()
        Me.optWhile = New System.Windows.Forms.RadioButton()
        Me.optFor = New System.Windows.Forms.RadioButton()
        Me.optDoWhilePre = New System.Windows.Forms.RadioButton()
        Me.optDoUntilPre = New System.Windows.Forms.RadioButton()
        Me.optDoWhilePost = New System.Windows.Forms.RadioButton()
        Me.optDoUntilPost = New System.Windows.Forms.RadioButton()
        Me.lblChecksum = New System.Windows.Forms.Label()
        Me.lblYearsFound = New System.Windows.Forms.Label()
        Me.lblYearsCountedLabel = New System.Windows.Forms.Label()
        Me.lblChecksumLabel = New System.Windows.Forms.Label()
        Me.lblYearsFoundLabel = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblEnd = New System.Windows.Forms.Label()
        CType(Me.nudStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpStart.SuspendLayout()
        Me.grpEnd.SuspendLayout()
        Me.grpLooping.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstDetectedYears
        '
        Me.lstDetectedYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDetectedYears.FormattingEnabled = True
        Me.lstDetectedYears.ItemHeight = 20
        Me.lstDetectedYears.Location = New System.Drawing.Point(282, 155)
        Me.lstDetectedYears.Name = "lstDetectedYears"
        Me.lstDetectedYears.ScrollAlwaysVisible = True
        Me.lstDetectedYears.Size = New System.Drawing.Size(150, 144)
        Me.lstDetectedYears.TabIndex = 30
        Me.lstDetectedYears.TabStop = False
        '
        'nudStart
        '
        Me.nudStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudStart.Location = New System.Drawing.Point(56, 59)
        Me.nudStart.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudStart.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStart.Name = "nudStart"
        Me.nudStart.Size = New System.Drawing.Size(94, 29)
        Me.nudStart.TabIndex = 0
        Me.nudStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudStart.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'nudEnd
        '
        Me.nudEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudEnd.Location = New System.Drawing.Point(287, 59)
        Me.nudEnd.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudEnd.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudEnd.Name = "nudEnd"
        Me.nudEnd.Size = New System.Drawing.Size(90, 29)
        Me.nudEnd.TabIndex = 1
        Me.nudEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudEnd.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'grpStart
        '
        Me.grpStart.Controls.Add(Me.optStartBCE)
        Me.grpStart.Controls.Add(Me.optStartCE)
        Me.grpStart.Location = New System.Drawing.Point(156, 56)
        Me.grpStart.Name = "grpStart"
        Me.grpStart.Size = New System.Drawing.Size(51, 46)
        Me.grpStart.TabIndex = 90
        Me.grpStart.TabStop = False
        '
        'optStartCE
        '
        Me.optStartCE.AutoSize = True
        Me.optStartCE.Checked = True
        Me.optStartCE.Location = New System.Drawing.Point(1, 3)
        Me.optStartCE.Name = "optStartCE"
        Me.optStartCE.Size = New System.Drawing.Size(39, 17)
        Me.optStartCE.TabIndex = 0
        Me.optStartCE.Text = "CE"
        Me.optStartCE.UseVisualStyleBackColor = True
        '
        'optStartBCE
        '
        Me.optStartBCE.AutoSize = True
        Me.optStartBCE.Location = New System.Drawing.Point(1, 27)
        Me.optStartBCE.Name = "optStartBCE"
        Me.optStartBCE.Size = New System.Drawing.Size(46, 17)
        Me.optStartBCE.TabIndex = 1
        Me.optStartBCE.Text = "BCE"
        Me.optStartBCE.UseVisualStyleBackColor = True
        '
        'grpEnd
        '
        Me.grpEnd.Controls.Add(Me.optEndBCE)
        Me.grpEnd.Controls.Add(Me.optEndCE)
        Me.grpEnd.Location = New System.Drawing.Point(383, 59)
        Me.grpEnd.Name = "grpEnd"
        Me.grpEnd.Size = New System.Drawing.Size(51, 46)
        Me.grpEnd.TabIndex = 91
        Me.grpEnd.TabStop = False
        '
        'optEndBCE
        '
        Me.optEndBCE.AutoSize = True
        Me.optEndBCE.Location = New System.Drawing.Point(1, 27)
        Me.optEndBCE.Name = "optEndBCE"
        Me.optEndBCE.Size = New System.Drawing.Size(46, 17)
        Me.optEndBCE.TabIndex = 1
        Me.optEndBCE.Text = "BCE"
        Me.optEndBCE.UseVisualStyleBackColor = True
        '
        'optEndCE
        '
        Me.optEndCE.AutoSize = True
        Me.optEndCE.Checked = True
        Me.optEndCE.Location = New System.Drawing.Point(1, 3)
        Me.optEndCE.Name = "optEndCE"
        Me.optEndCE.Size = New System.Drawing.Size(39, 17)
        Me.optEndCE.TabIndex = 0
        Me.optEndCE.Text = "CE"
        Me.optEndCE.UseVisualStyleBackColor = True
        '
        'chkIncludeStart
        '
        Me.chkIncludeStart.AutoSize = True
        Me.chkIncludeStart.Checked = True
        Me.chkIncludeStart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeStart.Location = New System.Drawing.Point(56, 36)
        Me.chkIncludeStart.Name = "chkIncludeStart"
        Me.chkIncludeStart.Size = New System.Drawing.Size(127, 17)
        Me.chkIncludeStart.TabIndex = 34
        Me.chkIncludeStart.TabStop = False
        Me.chkIncludeStart.Text = "Include in Calculation"
        Me.chkIncludeStart.UseVisualStyleBackColor = True
        '
        'chkIncludeEnd
        '
        Me.chkIncludeEnd.AutoSize = True
        Me.chkIncludeEnd.Checked = True
        Me.chkIncludeEnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeEnd.Location = New System.Drawing.Point(287, 36)
        Me.chkIncludeEnd.Name = "chkIncludeEnd"
        Me.chkIncludeEnd.Size = New System.Drawing.Size(127, 17)
        Me.chkIncludeEnd.TabIndex = 35
        Me.chkIncludeEnd.TabStop = False
        Me.chkIncludeEnd.Text = "Include in Calculation"
        Me.chkIncludeEnd.UseVisualStyleBackColor = True
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculate.Location = New System.Drawing.Point(57, 305)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(109, 42)
        Me.cmdCalculate.TabIndex = 2
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(172, 305)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(109, 42)
        Me.cmdClear.TabIndex = 3
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(287, 305)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(109, 42)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblYearsCounted
        '
        Me.lblYearsCounted.AutoSize = True
        Me.lblYearsCounted.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearsCounted.Location = New System.Drawing.Point(209, 223)
        Me.lblYearsCounted.Name = "lblYearsCounted"
        Me.lblYearsCounted.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblYearsCounted.Size = New System.Drawing.Size(20, 24)
        Me.lblYearsCounted.TabIndex = 39
        Me.lblYearsCounted.Text = "0"
        '
        'grpLooping
        '
        Me.grpLooping.Controls.Add(Me.optDoUntilPost)
        Me.grpLooping.Controls.Add(Me.optDoWhilePost)
        Me.grpLooping.Controls.Add(Me.optDoUntilPre)
        Me.grpLooping.Controls.Add(Me.optDoWhilePre)
        Me.grpLooping.Controls.Add(Me.optFor)
        Me.grpLooping.Controls.Add(Me.optWhile)
        Me.grpLooping.Location = New System.Drawing.Point(30, 116)
        Me.grpLooping.Name = "grpLooping"
        Me.grpLooping.Size = New System.Drawing.Size(246, 92)
        Me.grpLooping.TabIndex = 92
        Me.grpLooping.TabStop = False
        Me.grpLooping.Text = "Looping Calculation"
        '
        'optWhile
        '
        Me.optWhile.AutoSize = True
        Me.optWhile.Location = New System.Drawing.Point(0, 20)
        Me.optWhile.Name = "optWhile"
        Me.optWhile.Size = New System.Drawing.Size(52, 17)
        Me.optWhile.TabIndex = 0
        Me.optWhile.Text = "While"
        Me.optWhile.UseVisualStyleBackColor = True
        '
        'optFor
        '
        Me.optFor.AutoSize = True
        Me.optFor.Checked = True
        Me.optFor.Location = New System.Drawing.Point(121, 20)
        Me.optFor.Name = "optFor"
        Me.optFor.Size = New System.Drawing.Size(73, 17)
        Me.optFor.TabIndex = 1
        Me.optFor.Text = "For / Next"
        Me.optFor.UseVisualStyleBackColor = True
        '
        'optDoWhilePre
        '
        Me.optDoWhilePre.AutoSize = True
        Me.optDoWhilePre.Location = New System.Drawing.Point(0, 43)
        Me.optDoWhilePre.Name = "optDoWhilePre"
        Me.optDoWhilePre.Size = New System.Drawing.Size(115, 17)
        Me.optDoWhilePre.TabIndex = 2
        Me.optDoWhilePre.Text = "Do While (PreTest)"
        Me.optDoWhilePre.UseVisualStyleBackColor = True
        '
        'optDoUntilPre
        '
        Me.optDoUntilPre.AutoSize = True
        Me.optDoUntilPre.Location = New System.Drawing.Point(121, 43)
        Me.optDoUntilPre.Name = "optDoUntilPre"
        Me.optDoUntilPre.Size = New System.Drawing.Size(109, 17)
        Me.optDoUntilPre.TabIndex = 3
        Me.optDoUntilPre.Text = "Do Until (PreTest)"
        Me.optDoUntilPre.UseVisualStyleBackColor = True
        '
        'optDoWhilePost
        '
        Me.optDoWhilePost.AutoSize = True
        Me.optDoWhilePost.Location = New System.Drawing.Point(0, 66)
        Me.optDoWhilePost.Name = "optDoWhilePost"
        Me.optDoWhilePost.Size = New System.Drawing.Size(120, 17)
        Me.optDoWhilePost.TabIndex = 4
        Me.optDoWhilePost.Text = "Do While (PostTest)"
        Me.optDoWhilePost.UseVisualStyleBackColor = True
        '
        'optDoUntilPost
        '
        Me.optDoUntilPost.AutoSize = True
        Me.optDoUntilPost.Location = New System.Drawing.Point(121, 66)
        Me.optDoUntilPost.Name = "optDoUntilPost"
        Me.optDoUntilPost.Size = New System.Drawing.Size(114, 17)
        Me.optDoUntilPost.TabIndex = 5
        Me.optDoUntilPost.Text = "Do Until (PostTest)"
        Me.optDoUntilPost.UseVisualStyleBackColor = True
        '
        'lblChecksum
        '
        Me.lblChecksum.AutoSize = True
        Me.lblChecksum.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChecksum.Location = New System.Drawing.Point(209, 270)
        Me.lblChecksum.Name = "lblChecksum"
        Me.lblChecksum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChecksum.Size = New System.Drawing.Size(20, 24)
        Me.lblChecksum.TabIndex = 41
        Me.lblChecksum.Text = "0"
        '
        'lblYearsFound
        '
        Me.lblYearsFound.AutoSize = True
        Me.lblYearsFound.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearsFound.Location = New System.Drawing.Point(413, 116)
        Me.lblYearsFound.Name = "lblYearsFound"
        Me.lblYearsFound.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblYearsFound.Size = New System.Drawing.Size(20, 24)
        Me.lblYearsFound.TabIndex = 42
        Me.lblYearsFound.Text = "0"
        '
        'lblYearsCountedLabel
        '
        Me.lblYearsCountedLabel.AutoSize = True
        Me.lblYearsCountedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearsCountedLabel.Location = New System.Drawing.Point(63, 223)
        Me.lblYearsCountedLabel.Name = "lblYearsCountedLabel"
        Me.lblYearsCountedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblYearsCountedLabel.Size = New System.Drawing.Size(140, 24)
        Me.lblYearsCountedLabel.TabIndex = 43
        Me.lblYearsCountedLabel.Text = "Years Counted:"
        '
        'lblChecksumLabel
        '
        Me.lblChecksumLabel.AutoSize = True
        Me.lblChecksumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChecksumLabel.Location = New System.Drawing.Point(98, 270)
        Me.lblChecksumLabel.Name = "lblChecksumLabel"
        Me.lblChecksumLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblChecksumLabel.Size = New System.Drawing.Size(105, 24)
        Me.lblChecksumLabel.TabIndex = 44
        Me.lblChecksumLabel.Text = "Checksum:"
        '
        'lblYearsFoundLabel
        '
        Me.lblYearsFoundLabel.AutoSize = True
        Me.lblYearsFoundLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearsFoundLabel.Location = New System.Drawing.Point(283, 116)
        Me.lblYearsFoundLabel.Name = "lblYearsFoundLabel"
        Me.lblYearsFoundLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblYearsFoundLabel.Size = New System.Drawing.Size(124, 24)
        Me.lblYearsFoundLabel.TabIndex = 45
        Me.lblYearsFoundLabel.Text = "Years Found:"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(71, 9)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblStart.Size = New System.Drawing.Size(121, 24)
        Me.lblStart.TabIndex = 46
        Me.lblStart.Text = "Starting Year:"
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.Location = New System.Drawing.Point(294, 9)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEnd.Size = New System.Drawing.Size(120, 24)
        Me.lblEnd.TabIndex = 47
        Me.lblEnd.Text = "Ending Year:"
        '
        'frmLeapYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 359)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblYearsFoundLabel)
        Me.Controls.Add(Me.lblChecksumLabel)
        Me.Controls.Add(Me.lblYearsCountedLabel)
        Me.Controls.Add(Me.lblYearsFound)
        Me.Controls.Add(Me.lblChecksum)
        Me.Controls.Add(Me.grpLooping)
        Me.Controls.Add(Me.lblYearsCounted)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.chkIncludeEnd)
        Me.Controls.Add(Me.chkIncludeStart)
        Me.Controls.Add(Me.grpEnd)
        Me.Controls.Add(Me.grpStart)
        Me.Controls.Add(Me.nudEnd)
        Me.Controls.Add(Me.nudStart)
        Me.Controls.Add(Me.lstDetectedYears)
        Me.Name = "frmLeapYear"
        Me.Text = "Leap Year Calculator"
        CType(Me.nudStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpStart.ResumeLayout(False)
        Me.grpStart.PerformLayout()
        Me.grpEnd.ResumeLayout(False)
        Me.grpEnd.PerformLayout()
        Me.grpLooping.ResumeLayout(False)
        Me.grpLooping.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDetectedYears As ListBox
    Friend WithEvents nudStart As NumericUpDown
    Friend WithEvents nudEnd As NumericUpDown
    Friend WithEvents grpStart As GroupBox
    Friend WithEvents optStartBCE As RadioButton
    Friend WithEvents optStartCE As RadioButton
    Friend WithEvents grpEnd As GroupBox
    Friend WithEvents optEndBCE As RadioButton
    Friend WithEvents optEndCE As RadioButton
    Friend WithEvents chkIncludeStart As CheckBox
    Friend WithEvents chkIncludeEnd As CheckBox
    Friend WithEvents cmdCalculate As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents lblYearsCounted As Label
    Friend WithEvents grpLooping As GroupBox
    Friend WithEvents optDoUntilPost As RadioButton
    Friend WithEvents optDoWhilePost As RadioButton
    Friend WithEvents optDoUntilPre As RadioButton
    Friend WithEvents optDoWhilePre As RadioButton
    Friend WithEvents optFor As RadioButton
    Friend WithEvents optWhile As RadioButton
    Friend WithEvents lblChecksum As Label
    Friend WithEvents lblYearsFound As Label
    Friend WithEvents lblYearsCountedLabel As Label
    Friend WithEvents lblChecksumLabel As Label
    Friend WithEvents lblYearsFoundLabel As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents lblEnd As Label
End Class
