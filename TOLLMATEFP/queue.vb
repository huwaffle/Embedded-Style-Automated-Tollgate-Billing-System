Public Class queue

    Private orderQueue As New Queue(Of Integer)()
    Private currentOrder As Integer = 0
    Private nextNumberToAssign As Integer = 1
    Private customerNumber As Integer = 0

    ' --- Verify these lines are here and are exactly like this ---
    Public Property TransactionTollFee As Decimal = 0D
    Public Property TransactionEntryPoint As String = "N/A"
    Public Property TransactionExitPoint As String = "N/A"
    Public Property TransactionVehicleType As String = "Passenger Car"

    'added on 07/28/25
    Public Property TransactionPaymentMethod As String = ""
    Public Property TransactionAmountPaid As Decimal = 0D
    Public Property TransactionChange As Decimal = 0D


    Private Sub queue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateOrdersDisplay()
        shownumber.Text = "None"
    End Sub

    Private Sub UpdateOrdersDisplay()
        lblcurrentorder.Text = If(currentOrder > 0, currentOrder.ToString(), "None")
        lblnextorder.Text = If(orderQueue.Count > 0, orderQueue.Peek().ToString(), "None")
    End Sub

    Private Sub takenumber_Click(sender As Object, e As EventArgs) Handles takenumber.Click
        customerNumber = nextNumberToAssign
        nextNumberToAssign += 1
        orderQueue.Enqueue(customerNumber)
        shownumber.Text = " " & customerNumber.ToString()
        UpdateOrdersDisplay()
    End Sub

    Private Sub btnprocessqueue_Click(sender As Object, e As EventArgs) Handles btnprocessqueue.Click
        If orderQueue.Count > 0 Then
            currentOrder = orderQueue.Dequeue()
            Dim transactionTime As String = DateTime.Now.ToString("dddd, MMMM dd, yyyy, h:mm tt")

            ' Generate formatted receipt string
            Dim receipt As String =
            " TOLLMATE" & Environment.NewLine &
            "TOLLMATE RECEIPT" & Environment.NewLine &
            "----------------------------------------" & Environment.NewLine &
            $"Date/Time: {transactionTime}" & Environment.NewLine &
            $"Receipt No.: {currentOrder}" & Environment.NewLine &
            "----------------------------------------" & Environment.NewLine &
            $"Toll Fee: ₱{TransactionTollFee:N2}" & Environment.NewLine &
            $"Amount Paid: ₱{TransactionAmountPaid:N2}" & Environment.NewLine &
            $"Change: ₱{TransactionChange:N2}" & Environment.NewLine &
            $"Payment Method: {TransactionPaymentMethod}" & Environment.NewLine &
            "----------------------------------------" & Environment.NewLine &
            "Thank you for using our toll services." & Environment.NewLine &
            "Drive Safely!" & Environment.NewLine

            MessageBox.Show(receipt, "Toll Gate Receipt")

            Me.Hide()
            Dim goodbyeform As New GoodbyeForm

            goodbyeform.TransactionTime = transactionTime
            goodbyeform.CurrentOrder = currentOrder
            goodbyeform.TransactionTollFee = TransactionTollFee
            goodbyeform.TransactionAmountPaid = TransactionAmountPaid
            goodbyeform.TransactionChange = TransactionChange
            goodbyeform.TransactionPaymentMethod = TransactionPaymentMethod
            goodbyeform.ShowDialog()

            Me.Show()
        Else
            MessageBox.Show("No more vehicles in queue.", "Queue Empty", MessageBoxButtons.OK, MessageBoxIcon.Information)
            currentOrder = 0
        End If

        UpdateOrdersDisplay()
    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        Me.Close()
    End Sub
End Class