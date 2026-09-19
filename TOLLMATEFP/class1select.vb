Imports System.IO
Imports System.Data.OleDb

Public Class class1select
    ' Make sure the database is in the same folder as the EXE
    Dim dbPath As String = Path.Combine(Application.StartupPath, "TOLLMATEc1.accdb")
    Dim conStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath
    Dim con As New OleDbConnection(conStr)

    ' Use con in your functions as usual...

    Private Sub class1select_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Add tollgate table names to ComboBox
        cboSelectToll.Items.Add("CALAX")
        cboSelectToll.Items.Add("CAVITEX")
        cboSelectToll.Items.Add("NAIAX")
        cboSelectToll.Items.Add("Nlex_Connector")
        cboSelectToll.Items.Add("Nlex_Harbor_Link")
        cboSelectToll.Items.Add("NLEX_Sctex")
        cboSelectToll.Items.Add("Skyway_Stage_3")
        cboSelectToll.Items.Add("SLEX_SKYWAY_MCX")
        cboSelectToll.Items.Add("STAR")
        cboSelectToll.Items.Add("TPLEX")
        cboSelectToll.SelectedIndex = 0 ' Optional: auto-select first item
    End Sub
    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        Me.Close()
    End Sub

    Private Sub btnloadtoll_Click(sender As Object, e As EventArgs) Handles btnloadtoll.Click
        If cboSelectToll.SelectedIndex <> -1 Then
            Dim selectedTable As String = cboSelectToll.SelectedItem.ToString()

            ' Open the new form and pass the selected table name
            Me.Hide()
            Dim tollForm As New class1toll()
            tollForm.SelectedTableName = selectedTable
            tollForm.ShowDialog()
            Me.Show()
        Else
            MessageBox.Show("Please select a tollgate first.")
        End If
    End Sub
End Class