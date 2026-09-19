Public Class welcomeform
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim answer As Integer
        answer = MsgBox("Do you wish to exit?", vbYesNo + vbQuestion, "Confirmation")

        If answer = vbYes Then
            Me.Close()
        Else
        End If
    End Sub

    Private Sub btncontinue_Click(sender As Object, e As EventArgs) Handles btncontinue.Click
        Me.Hide()
        Dim classform As New classform
        classform.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        Me.Hide()
        Dim aboutform As New aboutform
        aboutform.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnmasterlist_Click(sender As Object, e As EventArgs) Handles btnmasterlist.Click
        Me.Hide()
        Dim masterlistform As New masterlistform
        masterlistform.ShowDialog()
        Me.Show()
    End Sub
End Class
