<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculate
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblFirstNine = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNineWeeks1 = New System.Windows.Forms.TextBox()
        Me.txtSecondNine = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.txtGradeWanted = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGradeNeeded = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 227)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblFirstNine
        '
        Me.lblFirstNine.AutoSize = True
        Me.lblFirstNine.Location = New System.Drawing.Point(12, 9)
        Me.lblFirstNine.Name = "lblFirstNine"
        Me.lblFirstNine.Size = New System.Drawing.Size(116, 13)
        Me.lblFirstNine.TabIndex = 1
        Me.lblFirstNine.Text = "First nine weeks grade:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Second nine weeks grade:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Percent of the semester grade:"
        '
        'txtNineWeeks1
        '
        Me.txtNineWeeks1.Location = New System.Drawing.Point(172, 6)
        Me.txtNineWeeks1.Name = "txtNineWeeks1"
        Me.txtNineWeeks1.Size = New System.Drawing.Size(100, 20)
        Me.txtNineWeeks1.TabIndex = 0
        '
        'txtSecondNine
        '
        Me.txtSecondNine.Location = New System.Drawing.Point(172, 34)
        Me.txtSecondNine.Name = "txtSecondNine"
        Me.txtSecondNine.Size = New System.Drawing.Size(100, 20)
        Me.txtSecondNine.TabIndex = 1
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(172, 60)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(100, 20)
        Me.txtFinal.TabIndex = 2
        Me.txtFinal.Text = "20"
        '
        'txtGradeWanted
        '
        Me.txtGradeWanted.Location = New System.Drawing.Point(172, 86)
        Me.txtGradeWanted.Name = "txtGradeWanted"
        Me.txtGradeWanted.Size = New System.Drawing.Size(100, 20)
        Me.txtGradeWanted.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Semester grade desired:"
        '
        'lblGradeNeeded
        '
        Me.lblGradeNeeded.AutoSize = True
        Me.lblGradeNeeded.Location = New System.Drawing.Point(12, 161)
        Me.lblGradeNeeded.Name = "lblGradeNeeded"
        Me.lblGradeNeeded.Size = New System.Drawing.Size(39, 13)
        Me.lblGradeNeeded.TabIndex = 9
        Me.lblGradeNeeded.Text = "Label4"
        Me.lblGradeNeeded.Visible = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(105, 227)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(197, 227)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmCalculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblGradeNeeded)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGradeWanted)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.txtSecondNine)
        Me.Controls.Add(Me.txtNineWeeks1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblFirstNine)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "frmCalculate"
        Me.Text = "Semester Grade Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblFirstNine As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNineWeeks1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSecondNine As System.Windows.Forms.TextBox
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents txtGradeWanted As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblGradeNeeded As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class
