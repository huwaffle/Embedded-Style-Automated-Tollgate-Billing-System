Imports System.IO
Imports System.Data.OleDb
Imports System.Collections.Generic ' Needed for HashSet
Imports System.Globalization ' Needed for CultureInfo
Public Class class1toll
    Public SelectedTableName As String

    ' Database path for Class 1 tables
    Dim dbPath As String = Path.Combine(Application.StartupPath, "TOLLMATEc1.accdb")
    Dim conStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath
    Dim con As New OleDbConnection(conStr) ' This connection is primarily for dgvclass1

    Private _mainDataTable As DataTable ' To store the data for both DGV and ComboBoxes
    Private columnIndexToPopulateCboC1Ent As Integer = -1 ' Stores the index of the column used to populate cboc1ent

    ' Define a specific CultureInfo for Philippine Pesos
    Private ReadOnly phiCulture As New CultureInfo("en-PH") ' English (Philippines) culture

    Private Sub class1toll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            dgvclass1.DataSource = _mainDataTable ' Bind to the class-level DataTable
        Catch ex As Exception
            MessageBox.Show("Error loading data for " & SelectedTableName & ":" & vbCrLf & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        ' --- Populate cboc1ent ComboBox (Entry Points) ---
        LoadCboC1EntData()

        ' --- Initialize cboc1ext ComboBox (Exit Points, populated on cboc1ent selection) ---
        cboc1ext.DataSource = Nothing
        cboc1ext.Items.Clear()

        ' Initialize lbltotal to show a default or empty value
        lbltotal.Text = ""
    End Sub

    ' Subroutine to load data into cboc1ent (Entry Stations)
    Private Sub LoadCboC1EntData()
        cboc1ent.DataSource = Nothing
        cboc1ent.Items.Clear()
        columnIndexToPopulateCboC1Ent = -1 ' Reset the column index

        If _mainDataTable Is Nothing OrElse _mainDataTable.Rows.Count = 0 Then
            Return ' No data available
        End If

        ' Since all tables now consistently use "ENTRY_EXIT" as the entry column
        Dim entryColumnName As String = "ENTRY_EXIT"

        If _mainDataTable.Columns.Contains(entryColumnName) Then
            columnIndexToPopulateCboC1Ent = _mainDataTable.Columns(entryColumnName).Ordinal
        Else
            MessageBox.Show("Error: The expected entry column '" & entryColumnName & "' was not found in table: " & SelectedTableName & ". Please verify your database schema.", "Data Column Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Exit if the critical column isn't found
        End If

        If columnIndexToPopulateCboC1Ent <> -1 Then
            Dim uniqueEntries As New HashSet(Of String)()
            For Each row As DataRow In _mainDataTable.Rows
                Dim cellValue As Object = row(columnIndexToPopulateCboC1Ent)
                If Not IsDBNull(cellValue) AndAlso Not String.IsNullOrEmpty(cellValue.ToString().Trim()) Then
                    uniqueEntries.Add(cellValue.ToString())
                End If
            Next

            For Each entry As String In uniqueEntries
                cboc1ent.Items.Add(entry)
            Next
            If cboc1ent.Items.Count > 0 Then
                cboc1ent.SelectedIndex = 0
            End If
        End If
    End Sub

    ' Identify Exit/Toll Columns
    Private Function IsExitOrTollColumn(columnName As String) As Boolean
        ' Exclude the ID column (if present) and the dynamically identified entry column.
        ' Assuming "ID" is always the first column and not a toll/exit.
        Dim entryColumnName As String = "ENTRY_EXIT" ' Consistent with the new database schema

        Return Not columnName.Equals("ID", StringComparison.OrdinalIgnoreCase) AndAlso
               Not columnName.Equals(entryColumnName, StringComparison.OrdinalIgnoreCase)
    End Function

    ' Subroutine to load data into cboc1ext (Exit Points and their Tolls)
    Private Sub LoadCboC1ExtData(selectedDataRow As DataRow)
        cboc1ext.DataSource = Nothing
        cboc1ext.Items.Clear()
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

        cboc1ext.DataSource = exitOptions
        cboc1ext.DisplayMember = "DisplayName"
        cboc1ext.ValueMember = "Price"

        If cboc1ext.Items.Count > 0 Then
            cboc1ext.SelectedIndex = 0
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

    Private Sub cboc1ent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboc1ent.SelectedIndexChanged
        If cboc1ent.SelectedItem IsNot Nothing AndAlso _mainDataTable IsNot Nothing AndAlso columnIndexToPopulateCboC1Ent <> -1 Then
            Dim selectedValueFromCboC1Ent As String = cboc1ent.SelectedItem.ToString()
            Dim selectedRow As DataRow = Nothing

            For Each row As DataRow In _mainDataTable.Rows
                If Not IsDBNull(row(columnIndexToPopulateCboC1Ent)) AndAlso row(columnIndexToPopulateCboC1Ent).ToString().Equals(selectedValueFromCboC1Ent, StringComparison.OrdinalIgnoreCase) Then
                    selectedRow = row
                    Exit For
                End If
            Next

            If selectedRow IsNot Nothing Then
                LoadCboC1ExtData(selectedRow)
            Else
                cboc1ext.DataSource = Nothing
                cboc1ext.Items.Clear()
                lbltotal.Text = ""
            End If
        Else
            cboc1ext.DataSource = Nothing
            cboc1ext.Items.Clear()
            lbltotal.Text = ""
        End If
    End Sub

    Private Sub cboc1ext_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboc1ext.SelectedIndexChanged
        lbltotal.Text = ""
    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        If cboc1ext.SelectedItem IsNot Nothing Then
            Dim selectedExitItem As ExitPointDisplayItem = TryCast(cboc1ext.SelectedItem, ExitPointDisplayItem)

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
End Class

' IMPORTANT: This class MUST be outside the 'class1toll' class.
' Define a simple class to hold both the display name and the actual price
