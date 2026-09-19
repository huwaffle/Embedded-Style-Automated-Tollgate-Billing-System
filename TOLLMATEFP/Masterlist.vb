Imports System.Data.OleDb
Public Class masterlistform
    Dim con As OleDbConnection
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable

    ' Called when the form loads
    Private Sub masterlistform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add tollgate names
        cboMLselecttoll.Items.AddRange(New String() {"CALAX", "CAVITEX", "NAIAX", "Nlex_Connector",
                                                     "Nlex_Harbor_Link", "NLEX_Sctex", "Skyway_Stage_3",
                                                     "SLEX_SKYWAY_MCX", "STAR", "TPLEX"})

        ' Add class options
        cboMLselectclass.Items.AddRange(New String() {"Class 1", "Class 2", "Class 3"})
    End Sub
    Private Sub btnLoadMastersList_Click(sender As Object, e As EventArgs) Handles btnLoadMastersList.Click
        If cboMLselecttoll.SelectedIndex = -1 Or cboMLselectclass.SelectedIndex = -1 Then
            MessageBox.Show("Please select both a tollgate and a class.")
            Return
        End If

        ' Get values from combo boxes
        Dim selectedTollgate As String = cboMLselecttoll.SelectedItem.ToString()
        Dim selectedClass As String = cboMLselectclass.SelectedItem.ToString()

        ' Determine which database to use
        Dim dbFile As String = ""
        Select Case selectedClass
            Case "Class 1"
                dbFile = "TOLLMATEc1.accdb"
            Case "Class 2"
                dbFile = "TOLLMATEc2.accdb"
            Case "Class 3"
                dbFile = "TOLLMATEc3.accdb"
        End Select

        ' Build full path and connection string
        Dim dbPath As String = System.IO.Path.Combine(Application.StartupPath, dbFile)
        Dim conStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath

        Try
            con = New OleDbConnection(conStr)
            Dim query As String = "SELECT * FROM [" & selectedTollgate & "]"
            adapter = New OleDbDataAdapter(query, con)
            dt = New DataTable()

            con.Open()
            adapter.Fill(dt)
            con.Close()

            ' Load to DataGridView (on same form)
            dgvMastersList.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        Me.Close()
    End Sub

End Class