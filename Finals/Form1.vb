Public Class frmCalculate

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

        Dim decFirstNine As Decimal
        Dim decSecondNine As Decimal
        Dim decFinalPercent As Decimal
        Dim decGradeDesired As Decimal
        Dim decGradeNeeded As Decimal

        decFirstNine = txtNineWeeks1.Text
        decSecondNine = txtSecondNine.Text
        decFinalPercent = txtFinal.Text
        decGradeDesired = txtGradeWanted.Text

        decFirstNine = decFirstNine / 100
        decSecondNine = decSecondNine / 100
        decFinalPercent = decFinalPercent / 100
        decGradeDesired = decGradeDesired / 100

        decGradeNeeded = (decGradeDesired - (decFirstNine * 0.4 + decSecondNine * 0.4)) / decFinalPercent
        decGradeNeeded = decGradeNeeded * 100

        lblGradeNeeded.Visible = True
        lblGradeNeeded.Text = "You need a " & decGradeNeeded & "% on the final for a " & decGradeDesired * 100 & "% in the class."

    End Sub

    Private Sub btnQuit_Click(sender As System.Object, e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub

    Private Sub btnReset_Click(sender As System.Object, e As System.EventArgs) Handles btnReset.Click
        txtNineWeeks1.Text = ""
        txtSecondNine.Text = ""
        txtFinal.Text = "20"
        txtGradeWanted.Text = ""
        txtNineWeeks1.Focus()
        lblGradeNeeded.Visible = False
    End Sub
End Class
