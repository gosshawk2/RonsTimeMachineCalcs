Public Class Form_Main
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub CalculateNeutronSpinDirectionRateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateNeutronSpinDirectionRateToolStripMenuItem.Click
        Dim App As New FrmCalculate

        Cursor = Cursors.WaitCursor
        App.PopulateForm()
        App.Show()
        Cursor = Cursors.Default
    End Sub
End Class