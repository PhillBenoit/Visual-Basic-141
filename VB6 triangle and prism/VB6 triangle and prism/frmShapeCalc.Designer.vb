<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShapeCalc
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
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.grpShape = New System.Windows.Forms.GroupBox()
        Me.optPrism = New System.Windows.Forms.RadioButton()
        Me.optTriangle = New System.Windows.Forms.RadioButton()
        Me.nudSide1 = New System.Windows.Forms.NumericUpDown()
        Me.lblSide1 = New System.Windows.Forms.Label()
        Me.lblSide2 = New System.Windows.Forms.Label()
        Me.nudSide2 = New System.Windows.Forms.NumericUpDown()
        Me.lblSide3 = New System.Windows.Forms.Label()
        Me.nudSide3 = New System.Windows.Forms.NumericUpDown()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.nudLength = New System.Windows.Forms.NumericUpDown()
        Me.lblResult1lbl = New System.Windows.Forms.Label()
        Me.lblResult2lbl = New System.Windows.Forms.Label()
        Me.lblResult1 = New System.Windows.Forms.Label()
        Me.lblResult2 = New System.Windows.Forms.Label()
        Me.grpShape.SuspendLayout()
        CType(Me.nudSide1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSide2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSide3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Location = New System.Drawing.Point(183, 206)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(86, 43)
        Me.cmdReset.TabIndex = 0
        Me.cmdReset.Text = "&Reset"
        Me.cmdReset.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(275, 206)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(86, 43)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'grpShape
        '
        Me.grpShape.Controls.Add(Me.optPrism)
        Me.grpShape.Controls.Add(Me.optTriangle)
        Me.grpShape.Location = New System.Drawing.Point(12, 158)
        Me.grpShape.Name = "grpShape"
        Me.grpShape.Size = New System.Drawing.Size(165, 91)
        Me.grpShape.TabIndex = 2
        Me.grpShape.TabStop = False
        Me.grpShape.Text = "Shapes"
        '
        'optPrism
        '
        Me.optPrism.AutoSize = True
        Me.optPrism.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optPrism.Location = New System.Drawing.Point(7, 54)
        Me.optPrism.Name = "optPrism"
        Me.optPrism.Size = New System.Drawing.Size(75, 28)
        Me.optPrism.TabIndex = 1
        Me.optPrism.Text = "&Prism"
        Me.optPrism.UseVisualStyleBackColor = True
        '
        'optTriangle
        '
        Me.optTriangle.AutoSize = True
        Me.optTriangle.Checked = True
        Me.optTriangle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTriangle.Location = New System.Drawing.Point(7, 20)
        Me.optTriangle.Name = "optTriangle"
        Me.optTriangle.Size = New System.Drawing.Size(97, 28)
        Me.optTriangle.TabIndex = 0
        Me.optTriangle.TabStop = True
        Me.optTriangle.Text = "&Triangle"
        Me.optTriangle.UseVisualStyleBackColor = True
        '
        'nudSide1
        '
        Me.nudSide1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSide1.Location = New System.Drawing.Point(82, 7)
        Me.nudSide1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSide1.Name = "nudSide1"
        Me.nudSide1.Size = New System.Drawing.Size(54, 29)
        Me.nudSide1.TabIndex = 3
        Me.nudSide1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSide1.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblSide1
        '
        Me.lblSide1.AutoSize = True
        Me.lblSide1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSide1.Location = New System.Drawing.Point(8, 9)
        Me.lblSide1.Name = "lblSide1"
        Me.lblSide1.Size = New System.Drawing.Size(68, 24)
        Me.lblSide1.TabIndex = 4
        Me.lblSide1.Text = "Side 1:"
        '
        'lblSide2
        '
        Me.lblSide2.AutoSize = True
        Me.lblSide2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSide2.Location = New System.Drawing.Point(8, 44)
        Me.lblSide2.Name = "lblSide2"
        Me.lblSide2.Size = New System.Drawing.Size(68, 24)
        Me.lblSide2.TabIndex = 6
        Me.lblSide2.Text = "Side 2:"
        '
        'nudSide2
        '
        Me.nudSide2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSide2.Location = New System.Drawing.Point(82, 42)
        Me.nudSide2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSide2.Name = "nudSide2"
        Me.nudSide2.Size = New System.Drawing.Size(54, 29)
        Me.nudSide2.TabIndex = 5
        Me.nudSide2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSide2.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblSide3
        '
        Me.lblSide3.AutoSize = True
        Me.lblSide3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSide3.Location = New System.Drawing.Point(8, 79)
        Me.lblSide3.Name = "lblSide3"
        Me.lblSide3.Size = New System.Drawing.Size(68, 24)
        Me.lblSide3.TabIndex = 8
        Me.lblSide3.Text = "Side 3:"
        '
        'nudSide3
        '
        Me.nudSide3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSide3.Location = New System.Drawing.Point(82, 77)
        Me.nudSide3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudSide3.Name = "nudSide3"
        Me.nudSide3.Size = New System.Drawing.Size(54, 29)
        Me.nudSide3.TabIndex = 7
        Me.nudSide3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSide3.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(8, 114)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(73, 24)
        Me.lblLength.TabIndex = 10
        Me.lblLength.Text = "Length:"
        Me.lblLength.Visible = False
        '
        'nudLength
        '
        Me.nudLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudLength.Location = New System.Drawing.Point(82, 112)
        Me.nudLength.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLength.Name = "nudLength"
        Me.nudLength.Size = New System.Drawing.Size(54, 29)
        Me.nudLength.TabIndex = 9
        Me.nudLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudLength.Value = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nudLength.Visible = False
        '
        'lblResult1lbl
        '
        Me.lblResult1lbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblResult1lbl.AutoSize = True
        Me.lblResult1lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult1lbl.Location = New System.Drawing.Point(183, 9)
        Me.lblResult1lbl.Name = "lblResult1lbl"
        Me.lblResult1lbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblResult1lbl.Size = New System.Drawing.Size(55, 24)
        Me.lblResult1lbl.TabIndex = 11
        Me.lblResult1lbl.Text = "Area:"
        Me.lblResult1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResult2lbl
        '
        Me.lblResult2lbl.AutoSize = True
        Me.lblResult2lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult2lbl.Location = New System.Drawing.Point(183, 79)
        Me.lblResult2lbl.Name = "lblResult2lbl"
        Me.lblResult2lbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblResult2lbl.Size = New System.Drawing.Size(96, 24)
        Me.lblResult2lbl.TabIndex = 12
        Me.lblResult2lbl.Text = "Perimeter:"
        Me.lblResult2lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblResult1
        '
        Me.lblResult1.AutoSize = True
        Me.lblResult1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult1.Location = New System.Drawing.Point(219, 44)
        Me.lblResult1.Name = "lblResult1"
        Me.lblResult1.Size = New System.Drawing.Size(50, 24)
        Me.lblResult1.TabIndex = 13
        Me.lblResult1.Text = "9999"
        '
        'lblResult2
        '
        Me.lblResult2.AutoSize = True
        Me.lblResult2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult2.Location = New System.Drawing.Point(219, 114)
        Me.lblResult2.Name = "lblResult2"
        Me.lblResult2.Size = New System.Drawing.Size(50, 24)
        Me.lblResult2.TabIndex = 14
        Me.lblResult2.Text = "9999"
        '
        'frmShapeCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 261)
        Me.Controls.Add(Me.lblResult2)
        Me.Controls.Add(Me.lblResult1)
        Me.Controls.Add(Me.lblResult2lbl)
        Me.Controls.Add(Me.lblResult1lbl)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.nudLength)
        Me.Controls.Add(Me.lblSide3)
        Me.Controls.Add(Me.nudSide3)
        Me.Controls.Add(Me.lblSide2)
        Me.Controls.Add(Me.nudSide2)
        Me.Controls.Add(Me.lblSide1)
        Me.Controls.Add(Me.nudSide1)
        Me.Controls.Add(Me.grpShape)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdReset)
        Me.Name = "frmShapeCalc"
        Me.Text = "Shape Calculator"
        Me.grpShape.ResumeLayout(False)
        Me.grpShape.PerformLayout()
        CType(Me.nudSide1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSide2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSide3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdReset As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents grpShape As GroupBox
    Friend WithEvents optPrism As RadioButton
    Friend WithEvents optTriangle As RadioButton
    Friend WithEvents nudSide1 As NumericUpDown
    Friend WithEvents lblSide1 As Label
    Friend WithEvents lblSide2 As Label
    Friend WithEvents nudSide2 As NumericUpDown
    Friend WithEvents lblSide3 As Label
    Friend WithEvents nudSide3 As NumericUpDown
    Friend WithEvents lblLength As Label
    Friend WithEvents nudLength As NumericUpDown
    Friend WithEvents lblResult1lbl As Label
    Friend WithEvents lblResult2lbl As Label
    Friend WithEvents lblResult1 As Label
    Friend WithEvents lblResult2 As Label
End Class
