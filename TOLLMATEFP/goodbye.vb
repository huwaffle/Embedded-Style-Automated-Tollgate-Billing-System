Imports QRCoder
Imports System.Drawing

Public Class GoodbyeForm

    ' Public properties to receive data from the queue form
    Public Property TransactionTime As String
    Public Property CurrentOrder As Integer
    Public Property TransactionTollFee As Decimal
    Public Property TransactionAmountPaid As Decimal
    Public Property TransactionChange As Decimal
    Public Property TransactionPaymentMethod As String

    ' Store receipt text globally
    Private receipt As String

    Private Sub GoodbyeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Prepare receipt but do NOT generate QR here
        receipt =
            "   TOLLMATE" & Environment.NewLine &
            "TOLLMATE RECEIPT" & Environment.NewLine &
            "----------------------------------------" & Environment.NewLine &
            $"Date/Time:        {TransactionTime}" & Environment.NewLine &
            $"Receipt No.:      {CurrentOrder}" & Environment.NewLine &
            "----------------------------------------" & Environment.NewLine &
            $"Toll Fee:         ₱{TransactionTollFee:N2}" & Environment.NewLine &
            $"Amount Paid:      ₱{TransactionAmountPaid:N2}" & Environment.NewLine &
            $"Change:           ₱{TransactionChange:N2}" & Environment.NewLine &
            $"Payment Method:   {TransactionPaymentMethod}" & Environment.NewLine &
            "----------------------------------------" & Environment.NewLine &
            "Thank you for using our toll services." & Environment.NewLine &
            "Drive Safely!" & Environment.NewLine
    End Sub

    Private Sub GenerateQRCode(data As String)
        Try
            Dim generator As New QRCodeGenerator()
            Dim qrData As QRCodeData = generator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q)
            Dim qrCode As New QRCode(qrData)
            Dim bmp As Bitmap = qrCode.GetGraphic(20)
            picqr.Image = bmp
            picqr.SizeMode = PictureBoxSizeMode.Zoom
        Catch ex As Exception
            MessageBox.Show("QR generation failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btngoodbye_Click(sender As Object, e As EventArgs) Handles btngoodbye.Click
        Environment.Exit(0)
    End Sub

    Private Sub Btnqr_Click(sender As Object, e As EventArgs) Handles btnqr.Click
        ' Now generate the QR only when the button is clicked
        GenerateQRCode(receipt)
        'MessageBox.Show("QR Code generated! Scan it to view the receipt.", "QR Ready", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
