Public Class FrmTestFunctions
    Dim myCalcs As New ClsMyMathFunctions
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnRootTestCalculate_Click(sender As Object, e As EventArgs) Handles BtnRootTestCalculate.Click
        'Calculate Root Function:
        Dim Number As Double = 0
        Dim Indicie As Integer = 0
        Dim Answer As Double = 0

        If TxtRootNumberEntry.Text <> "" Then
            If IsNumeric(TxtRootNumberEntry.Text) Then
                Number = CDbl(TxtRootNumberEntry.Text)
            Else
                MsgBox("Root Number must be numeric")
                Exit Sub
            End If
        Else
            MsgBox("Please enter a number")
            Exit Sub
        End If

        If TxtRootIndicie.Text <> "" Then
            If IsNumeric(TxtRootIndicie.Text) Then
                Indicie = CInt(TxtRootIndicie.Text)
            Else
                MsgBox("Please enter a numeric integer")
                Exit Sub
            End If
        Else
            MsgBox("Please enter a numeric value")
            Exit Sub
        End If
        Answer = myCalcs.RootCalc(Number, Indicie)
        TxtRootAnswer.Text = CStr(Answer)

    End Sub
End Class
