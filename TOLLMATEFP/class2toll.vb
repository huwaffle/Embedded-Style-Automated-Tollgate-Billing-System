Imports System.IO
Imports System.Data.OleDb
Imports System.Collections.Generic ' Needed for HashSet
Imports System.Globalization ' Needed for CultureInfo

Public Class class2toll

    Public SelectedTableName As String

    ' Database path for Class 2 tables. Assumes TOLLMATEc2.accdb is in your application's folder.
    Dim dbPath As String = Path.Combine(Application.StartupPath, "TOLLMATEc2.accdb")
    Dim conStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dbPath
    Dim con As New OleDbConnection(conStr)

    Private _mainDataTable As DataTable ' To store the data for both DGV and ComboBoxes
    Private columnIndexToPopulateCboEnt As Integer = -1 ' Stores the index of the column used to populate ComboBox1

    ' Define a specific CultureInfo for Philippine Pesos
    Private ReadOnly phiCulture As New CultureInfo("en-PH") ' English (Philippines) culture

    Private Sub class2toll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            dgvclass2.DataSource = _mainDataTable ' Bind to the class-level DataTable
        Catch ex As Exception
            MessageBox.Show("Error loading data for " & SelectedTableName & ":" & vbCrLf & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        ' --- Populate ComboBox1 (Entry Points) ---
        LoadCboEntryData()

        ' --- Initialize ComboBox2 (Exit Points, populated on ComboBox1 selection) ---
        ComboBox2.DataSource = Nothing
        ComboBox2.Items.Clear()

        ' Initialize lbltotal to show a default or empty value
        lbltotal.Text = ""
    End Sub

    ' Subroutine to load data into ComboBox1 (Entry Stations)
    Private Sub LoadCboEntryData()
        ComboBox1.DataSource = Nothing
        ComboBox1.Items.Clear()
        columnIndexToPopulateCboEnt = -1 ' Reset the column index

        If _mainDataTable Is Nothing OrElse _mainDataTable.Rows.Count = 0 Then
            Return ' No data available
        End If

        ' Determine the entry column name based on the universal "ENTRY_EXIT" confirmation.
        Dim entryColumnName As String = "ENTRY_EXIT"

        If _mainDataTable.Columns.Contains(entryColumnName) Then
            columnIndexToPopulateCboEnt = _mainDataTable.Columns(entryColumnName).Ordinal
        Else
            ' Fallback if "ENTRY_EXIT" is not found (shouldn't happen if structure is consistent)
            For i As Integer = 0 To _mainDataTable.Columns.Count - 1
                If _mainDataTable.Columns(i).DataType Is GetType(String) Then
                    columnIndexToPopulateCboEnt = i
                    entryColumnName = _mainDataTable.Columns(i).ColumnName
                    Exit For
                End If
            Next
        End If

        If columnIndexToPopulateCboEnt <> -1 Then
            Dim uniqueEntries As New HashSet(Of String)()
            For Each row As DataRow In _mainDataTable.Rows
                Dim cellValue As Object = row(columnIndexToPopulateCboEnt)
                If Not IsDBNull(cellValue) AndAlso Not String.IsNullOrEmpty(cellValue.ToString().Trim()) Then
                    uniqueEntries.Add(cellValue.ToString())
                End If
            Next

            For Each entry As String In uniqueEntries
                ComboBox1.Items.Add(entry)
            Next

            If ComboBox1.Items.Count > 0 Then
                ComboBox1.SelectedIndex = 0
            End If
        Else
            MessageBox.Show("Could not find a suitable column for Entry Points for table: " & SelectedTableName & ". Please ensure a column like 'ENTRY_EXIT' exists and contains text.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Identify Exit/Toll Columns
    Private Function IsExitOrTollColumn(columnName As String) As Boolean
        Return Not columnName.Equals("ID", StringComparison.OrdinalIgnoreCase) AndAlso
               Not columnName.Equals("ENTRY_EXIT", StringComparison.OrdinalIgnoreCase)
    End Function

    ' Subroutine to load data into ComboBox2 (Exit Points and their Tolls)
    Private Sub LoadCboExitData(selectedDataRow As DataRow)
        ComboBox2.DataSource = Nothing
        ComboBox2.Items.Clear()
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

        ComboBox2.DataSource = exitOptions
        ComboBox2.DisplayMember = "DisplayName"
        ComboBox2.ValueMember = "Price"

        If ComboBox2.Items.Count > 0 Then
            ComboBox2.SelectedIndex = 0
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing AndAlso _mainDataTable IsNot Nothing AndAlso columnIndexToPopulateCboEnt <> -1 Then
            Dim selectedValueFromCboEnt As String = ComboBox1.SelectedItem.ToString()
            Dim selectedRow As DataRow = Nothing

            For Each row As DataRow In _mainDataTable.Rows
                If Not IsDBNull(row(columnIndexToPopulateCboEnt)) AndAlso row(columnIndexToPopulateCboEnt).ToString().Equals(selectedValueFromCboEnt, StringComparison.OrdinalIgnoreCase) Then
                    selectedRow = row
                    Exit For
                End If
            Next

            If selectedRow IsNot Nothing Then
                LoadCboExitData(selectedRow)
            Else
                ComboBox2.DataSource = Nothing
                ComboBox2.Items.Clear()
                lbltotal.Text = ""
            End If
        Else
            ComboBox2.DataSource = Nothing
            ComboBox2.Items.Clear()
            lbltotal.Text = ""
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        lbltotal.Text = ""
    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        If ComboBox2.SelectedItem IsNot Nothing Then
            Dim selectedExitItem As ExitPointDisplayItem = TryCast(ComboBox2.SelectedItem, ExitPointDisplayItem)

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

    Private Sub dgvclass2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvclass2.CellContentClick
        ' No code needed here unless you want clicking a cell to do something.
    End Sub
End Class

' IMPORTANT: This class MUST be outside the 'class2toll' class to avoid compilation errors (BC30521).
' Define a simple class to hold both the display name and the actual price
Public Class ExitPointDisplayItem
    Public Property DisplayName As String
    Public Property Price As Decimal

    Public Sub New(name As String, priceVal As Decimal)
        DisplayName = name
        Price = priceVal
    End Sub

    Public Overrides Function ToString() As String
        Return DisplayName
    End Function
End Class