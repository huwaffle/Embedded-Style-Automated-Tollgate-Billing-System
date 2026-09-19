
Public Class classform

    'added on 07/28/25
    Private SelectedClass As String = ""

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        Me.Close()
    End Sub
    Private Sub btnCLS1_Click(sender As Object, e As EventArgs) Handles btnCLS1.Click
        Me.Hide()
        Dim class1select As New class1select
        class1select.ShowDialog()
        Me.Show()
    End Sub
    Private Sub btnCLS2_Click(sender As Object, e As EventArgs) Handles btnCLS2.Click
        Me.Hide()
        Dim class2select As New class2select
        class2select.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnCLS3_Click(sender As Object, e As EventArgs) Handles btnclass3.Click
        Me.Hide()
        Dim class3select As New class3select
        class3select.ShowDialog()
        Me.Show()
    End Sub
End Class