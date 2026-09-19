Imports System.IO
Imports System.Data.OleDb
Imports System.Collections.Generic ' Needed for HashSet
Imports System.Globalization ' Needed for CultureInfo

Public Class class3toll
    Public SelectedTableName As String

    ' Database path for Class 3 tables
    ' *** IMPORTANT: Ensure you have TOLLMATEc3.accdb in your project and its 'Copy to Output Directory' is set to 'Copy always' ***
    Dim dbPath As String = Path.Combine(Application.StartupPath, "TOLLMATEc3.accdb")
    Dim conStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath
    Dim con As New OleDbConnection(conStr)

    Private _mainDataTable As DataTable ' To store the data for both DGV and ComboBoxes
    Private columnIndexToPopulateCboC3Ent As Integer = -1 ' Stores the index of the column used to populate cboc3ent

    ' Define a specific CultureInfo for Philippine Pesos
    Private ReadOnly phiCulture As New CultureInfo("en-PH") ' English (Philippines) culture

    Private Sub class3toll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcomeTo.Text = "Welcome to the " & SelectedTableName.Replace("_", " ").Replace("Toll", " Toll") & "!"

        ' --- Populate DataGridView ---
        Try
            Dim query As String = "SELECT * FROM [" & SelectedTableName & "]"
            Dim cmd As New OleDbCommand(query, con)
            Dim adapter As New OleDbDataAdapter(cmd)
            _mainDataTable = New DataTable() ' Initialize the class-level DataTable

            con.Open()
            adapter.Fill(_mainDataTable)
            con.Close()

            dgvclass3.DataSource = _mainDataTable ' Bind to the class-level DataTable
        Catch ex As Exception
            MessageBox.Show("Error loading data for " & SelectedTableName & ":" & vbCrLf & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then ' Corrected typo from ConnectionConnectionState
                con.Close()
            End If
        End Try

        ' --- Populate cboc3ent ComboBox (Entry Points) ---
        LoadCboC3EntData()

        ' --- Initialize cboc3ext ComboBox (Exit Points, populated on cboc3ent selection) ---
        cboc3ext.DataSource = Nothing
        cboc3ext.Items.Clear()

        ' Initialize lbltotal to show a default or empty value
        lbltotal.Text = ""
    End Sub

    ' Subroutine to load data into cboc3ent (Entry Stations)
    Private Sub LoadCboC3EntData()
        cboc3ent.DataSource = Nothing
        cboc3ent.Items.Clear()
        columnIndexToPopulateCboC3Ent = -1 ' Reset the column index

        If _mainDataTable Is Nothing OrElse _mainDataTable.Rows.Count = 0 Then
            Return ' No data available
        End If

        ' All tables are expected to consistently use "ENTRY_EXIT" as the entry column
        Dim entryColumnName As String = "ENTRY_EXIT"

        If _mainDataTable.Columns.Contains(entryColumnName) Then
            columnIndexToPopulateCboC3Ent = _mainDataTable.Columns(entryColumnName).Ordinal
        Else
            MessageBox.Show("Error: The expected entry column '" & entryColumnName & "' was not found in table: " & SelectedTableName & ". Please verify your database schema for TOLLMATEc3.accdb.", "Data Column Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit if the critical column isn't found
        End If

        If columnIndexToPopulateCboC3Ent <> -1 Then
            Dim uniqueEntries As New HashSet(Of String)()
            For Each row As DataRow In _mainDataTable.Rows
                Dim cellValue As Object = row(columnIndexToPopulateCboC3Ent)
                If Not IsDBNull(cellValue) AndAlso Not String.IsNullOrEmpty(cellValue.ToString().Trim()) Then
                    uniqueEntries.Add(cellValue.ToString())
                End If
            Next

            For Each entry As String In uniqueEntries
                cboc3ent.Items.Add(entry)
            Next
            If cboc3ent.Items.Count > 0 Then
                cboc3ent.SelectedIndex = 0
            End If
        End If
    End Sub

    ' Identify Exit/Toll Columns
    Private Function IsExitOrTollColumn(columnName As String) As Boolean
        ' Exclude the ID column (if present) and the dynamically identified entry column.
        ' Assuming "ID" is always the first column and not a toll/exit.
        Dim entryColumnName As String = "ENTRY_EXIT" ' Consistent with the new database schema

        Return Not columnName.Equals("ID", StringComparison.OrdinalIgnoreCase) And Not columnName.Equals(entryColumnName, StringComparison.OrdinalIgnoreCase)
    End Function

    ' Subroutine to load data into cboc3ext (Exit Points and their Tolls)
    Private Sub LoadCboC3ExtData(selectedDataRow As DataRow)
        cboc3ext.DataSource = Nothing
        cboc3ext.Items.Clear()
        lbltotal.Text = "" ' Clear total when exit options are reloaded

        If selectedDataRow Is Nothing Then
            Return
        End If

        Dim exitOptions As New List(Of ExitPointDisplayItem)()

        For Each column As DataColumn In _mainDataTable.Columns
            If IsExitOrTollColumn(column.ColumnName) Then
                Dim cellValue As Object = selectedDataRow(column)

                If Not IsDBNull(cellValue) AndAlso Not String.IsNullOrEmpty(cellValue.ToString().Trim()) Then
                    Dim displayName As String = column.ColumnName.Replace("_", " ")
                    Dim priceValue As Decimal = 0D

                    If IsNumericType(column.DataType) Then
                        Try
                            priceValue = CDec(cellValue)
                        Catch
                            ' Handle conversion error if needed, price will remain 0D
                        End Try
                    End If
                    If priceValue >= 0 Then
                        exitOptions.Add(New ExitPointDisplayItem(displayName, priceValue))
                    End If
                End If
            End If
        Next

        cboc3ext.DataSource = exitOptions
        cboc3ext.DisplayMember = "DisplayName"
        cboc3ext.ValueMember = "Price"

        If cboc3ext.Items.Count > 0 Then
            cboc3ext.SelectedIndex = 0
        End If
    End Sub

    ' Helper to check if a data type is numeric
    Private Function IsNumericType(dataType As Type) As Boolean
        Return dataType Is GetType(Integer) OrElse
               dataType Is GetType(Decimal) OrElse
               dataType Is GetType(Double) OrElse
               dataType Is GetType(Single) OrElse
               dataType Is GetType(Short) OrElse
               dataType Is GetType(Long)
    End Function

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        Me.Close()
    End Sub

    Private Sub cboc3ent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboc3ent.SelectedIndexChanged
        If cboc3ent.SelectedItem IsNot Nothing AndAlso _mainDataTable IsNot Nothing AndAlso columnIndexToPopulateCboC3Ent <> -1 Then
            Dim selectedValueFromCboC3Ent As String = cboc3ent.SelectedItem.ToString()
            Dim selectedRow As DataRow = Nothing

            For Each row As DataRow In _mainDataTable.Rows
                If Not IsDBNull(row(columnIndexToPopulateCboC3Ent)) AndAlso row(columnIndexToPopulateCboC3Ent).ToString().Equals(selectedValueFromCboC3Ent, StringComparison.OrdinalIgnoreCase) Then
                    selectedRow = row
                    Exit For
                End If
            Next

            If selectedRow IsNot Nothing Then
                LoadCboC3ExtData(selectedRow)
            Else
                cboc3ext.DataSource = Nothing
                cboc3ext.Items.Clear()
                lbltotal.Text = ""
            End If
        Else
            cboc3ext.DataSource = Nothing
            cboc3ext.Items.Clear()
            lbltotal.Text = ""
        End If
    End Sub

    Private Sub cboc3ext_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboc3ext.SelectedIndexChanged
        lbltotal.Text = ""
    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        If cboc3ext.SelectedItem IsNot Nothing Then
            Dim selectedExitItem As ExitPointDisplayItem = TryCast(cboc3ext.SelectedItem, ExitPointDisplayItem)

            If selectedExitItem IsNot Nothing Then
                lbltotal.Text = selectedExitItem.Price.ToString("C2", phiCulture)
            Else
                lbltotal.Text = "N/A"
            End If
        Else
            lbltotal.Text = "Select an Exit Point"
        End If
    End Sub

    Private Sub lbltotal_Click(sender As Object, e As EventArgs) Handles lbltotal.Click
        ' No code needed here unless you want clicking the label to do something.
    End Sub

    Private Sub btnproceedpayment_Click(sender As Object, e As EventArgs) Handles btnproceedpayment.Click
        If String.IsNullOrWhiteSpace(lbltotal.Text) Then
            MessageBox.Show("Please calculate the price before proceeding.", "Missing Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim totalPrice As Decimal

        ' Try to parse the text from lbltotal (remove currency symbol)
        If Decimal.TryParse(lbltotal.Text.Replace("₱", "").Replace("PHP", "").Trim(), totalPrice) Then
            Me.Hide()
            Dim paymentForm As New payment()
            paymentForm.TotalAmountDue = totalPrice
            paymentForm.ShowDialog()
            Me.Show()
        Else
            MessageBox.Show("Invalid total amount. Please try calculating again.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Me.Hide()
        Dim payment As New payment
        payment.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Dgvclass3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclass3.CellContentClick
        ' You generally don't need code here unless you want specific actions when a cell is clicked.
    End Sub

End Class

' IMPORTANT: This class MUST be outside the 'class3toll' class.
' Define a simple class to hold both the display name and the actual price
