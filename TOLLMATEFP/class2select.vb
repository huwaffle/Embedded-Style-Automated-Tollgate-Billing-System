Imports System.IO
Imports System.Data.OleDb
Public Class class2select
    Dim dbPath As String = Path.Combine(Application.StartupPath, "TOLLMATEc2.accdb")
    Dim conStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath
    Dim con As New OleDbConnection(conStr)
    Private Sub class2select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add tollgate table names to ComboBox
        cboSelectToll2.Items.Add("CALAX")
        cboSelectToll2.Items.Add("CAVITEX")
        cboSelectToll2.Items.Add("NAIAX")
        cboSelectToll2.Items.Add("Nlex_Connector")
        cboSelectToll2.Items.Add("Nlex_Harbor_Link")
        cboSelectToll2.Items.Add("NLEX_Sctex")
        cboSelectToll2.Items.Add("Skyway_Stage_3")
        cboSelectToll2.Items.Add("SLEX_SKYWAY_MCX")
        cboSelectToll2.Items.Add("STAR")
        cboSelectToll2.Items.Add("TPLEX")
        cboSelectToll2.SelectedIndex = 0 ' Optional: auto-select first item
    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        Me.Close()
    End Sub

    Private Sub btnloadtoll_Click(sender As Object, e As EventArgs) Handles btnloadtoll.Click
        If cboSelectToll2.SelectedIndex <> -1 Then
            Dim selectedTable As String = cboSelectToll2.SelectedItem.ToString()

            ' Open the new form and pass the selected table name
            Me.Hide()
            Dim tollForm As New class2toll()
            tollForm.SelectedTableName = selectedTable
            tollForm.ShowDialog()
            Me.Show()
        Else
            MessageBox.Show("Please select a tollgate first.")
        End If
    End Sub
End Class