<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payment))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPaymentMethods = New System.Windows.Forms.ComboBox()
        Me.btnpay = New System.Windows.Forms.Button()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.txtInputAmount = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(510, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How would you like to pay?"
        '
        'cboPaymentMethods
        '
        Me.cboPaymentMethods.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboPaymentMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaymentMethods.FormattingEnabled = True
        Me.cboPaymentMethods.Items.AddRange(New Object() {"Cash", "Card", "eWallet", "RFID"})
        Me.cboPaymentMethods.Location = New System.Drawing.Point(22, 66)
        Me.cboPaymentMethods.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPaymentMethods.Name = "cboPaymentMethods"
        Me.cboPaymentMethods.Size = New System.Drawing.Size(257, 24)
        Me.cboPaymentMethods.TabIndex = 1
        '
        'btnpay
        '
        Me.btnpay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnpay.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpay.Location = New System.Drawing.Point(22, 255)
        Me.btnpay.Margin = New System.Windows.Forms.Padding(4)
        Me.btnpay.Name = "btnpay"
        Me.btnpay.Size = New System.Drawing.Size(193, 62)
        Me.btnpay.TabIndex = 2
        Me.btnpay.Text = "Pay and Proceed To Queue"
        Me.btnpay.UseVisualStyleBackColor = True
        '
        'btnreturn
        '
        Me.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnreturn.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.Location = New System.Drawing.Point(223, 255)
        Me.btnreturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(193, 62)
        Me.btnreturn.TabIndex = 4
        Me.btnreturn.Text = "Return"
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'txtInputAmount
        '
        Me.txtInputAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtInputAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInputAmount.Location = New System.Drawing.Point(191, 127)
        Me.txtInputAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtInputAmount.Name = "txtInputAmount"
        Me.txtInputAmount.Size = New System.Drawing.Size(147, 30)
        Me.txtInputAmount.TabIndex = 5
        '
        'lblChange
        '
        Me.lblChange.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(16, 180)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(103, 31)
        Me.lblChange.TabIndex = 6
        Me.lblChange.Text = "Balance:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Input Amount:"
        '
        'payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 407)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.txtInputAmount)
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.btnpay)
        Me.Controls.Add(Me.cboPaymentMethods)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboPaymentMethods As ComboBox
    Friend WithEvents btnpay As Button
    Friend WithEvents btnreturn As Button
    Friend WithEvents txtInputAmount As TextBox
    Friend WithEvents lblChange As Label
    Friend WithEvents Label2 As Label
End Class
