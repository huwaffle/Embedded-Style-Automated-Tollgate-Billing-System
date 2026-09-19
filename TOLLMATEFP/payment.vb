Public Class payment
    'added on 07/28/25
    Public Property TotalAmountDue As Decimal = 0.00
    Public Property PaidAmount As Decimal = 0D
    Public Property ChangeAmount As Decimal = 0D
    Public Property SelectedPaymentMethod As String = ""
    Public Property SelectedVehicleClass As String = "" ' Set this based on class button (1, 2, or 3)


    ' *** ADDED PUBLIC PROPERTIES (from your original code snippet) ***
    Public Property SelectedTollEntry As String
    Public Property SelectedExitColumnName As String
    Public Property SelectedExitValue As String

    ' ************************************

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtInputAmount.Clear()
        txtInputAmount.Focus()

        lblChange.Text = $"Balance Due: PHP {TotalAmountDue:N2}"

        If cboPaymentMethods.Items.Count = 0 Then
            cboPaymentMethods.Items.Add("Cash")
            cboPaymentMethods.Items.Add("Card")
        End If
        cboPaymentMethods.SelectedIndex = -1

        ' You can now access the passed data here, for example:
        ' Console.WriteLine("Entry: " & SelectedTollEntry)
        ' Console.WriteLine("Exit Column: " & SelectedExitColumnName)
        ' Console.WriteLine("Exit Value: " & SelectedExitValue)
    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        ' Validation 1: Check payment method
        If cboPaymentMethods.SelectedIndex = -1 Then
            MessageBox.Show("Please select a payment method.", "Missing Payment Method", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboPaymentMethods.Focus()
            Return
        End If

        ' Validation 2: Check amount entered
        If String.IsNullOrWhiteSpace(txtInputAmount.Text) Then
            MessageBox.Show("Please enter the amount tendered.", "Missing Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtInputAmount.Focus()
            Return
        End If

        ' Validation 3: Check numeric and sufficient
        Dim tendered As Decimal
        If Not Decimal.TryParse(txtInputAmount.Text, tendered) Then
            MessageBox.Show("Invalid amount. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtInputAmount.Focus()
            Return
        End If

        If tendered < TotalAmountDue Then
            MessageBox.Show($"Insufficient amount. Total due is PHP {TotalAmountDue:N2}.", "Underpayment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtInputAmount.Focus()
            Return
        End If

        'added on 07/28/25
        ' Save transaction info
        PaidAmount = tendered
        ChangeAmount = tendered - TotalAmountDue
        SelectedPaymentMethod = cboPaymentMethods.SelectedItem.ToString()

        'added on 07/28/25
        ' All good, proceed to next
        Me.Hide()
        Dim queueForm As New queue()
        queueForm.TransactionTollFee = TotalAmountDue
        queueForm.TransactionEntryPoint = SelectedTollEntry
        queueForm.TransactionExitPoint = SelectedExitValue
        queueForm.TransactionVehicleType = SelectedVehicleClass
        queueForm.TransactionPaymentMethod = SelectedPaymentMethod
        queueForm.TransactionAmountPaid = PaidAmount
        queueForm.TransactionChange = ChangeAmount
        queueForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        Me.Close()
    End Sub

End Class
