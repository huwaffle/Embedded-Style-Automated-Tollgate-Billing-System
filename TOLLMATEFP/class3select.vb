Imports System.IO
Imports System.Data.OleDb
Public Class class3select
    Dim dbPath As String = Path.Combine(Application.StartupPath, "TOLLMATEc2.accdb")
    Dim conStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath
    Dim con As New OleDbConnection(conStr)
    Private Sub class3select_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add tollgate table names to ComboBox
        cboSelectToll3.Items.Add("CALAX")
        cboSelectToll3.Items.Add("CAVITEX")
        cboSelectToll3.Items.Add("NAIAX")
        cboSelectToll3.Items.Add("Nlex_Connector")
        cboSelectToll3.Items.Add("Nlex_Harbor_Link")
        cboSelectToll3.Items.Add("NLEX_Sctex")
        cboSelectToll3.Items.Add("Skyway_Stage_3")
        cboSelectToll3.Items.Add("SLEX_SKYWAY_MCX")
        cboSelectToll3.Items.Add("STAR")
        cboSelectToll3.Items.Add("TPLEX")
        cboSelectToll3.SelectedIndex = 0 ' Optional: auto-select first item
    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        Me.Close()
    End Sub

    Private Sub btnloadtoll3_Click(sender As Object, e As EventArgs) Handles btnloadtoll3.Click
        If cboSelectToll3.SelectedIndex <> -1 Then
            Dim selectedTable As String = cboSelectToll3.SelectedItem.ToString()

            ' Open the new form and pass the selected table name
            Me.Hide()
            Dim tollForm As New class3toll()
            tollForm.SelectedTableName = selectedTable
            tollForm.ShowDialog()
            Me.Show()
        Else
            MessageBox.Show("Please select a tollgate first.")
        End If
    End Sub
End Class