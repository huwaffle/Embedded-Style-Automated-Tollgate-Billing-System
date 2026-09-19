<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class class1toll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(class1toll))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboc1ent = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboc1ext = New System.Windows.Forms.ComboBox()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btnproceedpayment = New System.Windows.Forms.Button()
        Me.dgvclass1 = New System.Windows.Forms.DataGridView()
        Me.lblWelcomeTo = New System.Windows.Forms.Label()
        CType(Me.dgvclass1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 305)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Entry"
        '
        'cboc1ent
        '
        Me.cboc1ent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboc1ent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboc1ent.FormattingEnabled = True
        Me.cboc1ent.Location = New System.Drawing.Point(267, 351)
        Me.cboc1ent.Margin = New System.Windows.Forms.Padding(4)
        Me.cboc1ent.Name = "cboc1ent"
        Me.cboc1ent.Size = New System.Drawing.Size(223, 24)
        Me.cboc1ent.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(585, 305)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 44)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Exit"
        '
        'cboc1ext
        '
        Me.cboc1ext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboc1ext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboc1ext.FormattingEnabled = True
        Me.cboc1ext.Location = New System.Drawing.Point(556, 351)
        Me.cboc1ext.Margin = New System.Windows.Forms.Padding(4)
        Me.cboc1ext.Name = "cboc1ext"
        Me.cboc1ext.Size = New System.Drawing.Size(223, 24)
        Me.cboc1ext.TabIndex = 4
        '
        'btncalculate
        '
        Me.btncalculate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncalculate.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculate.Location = New System.Drawing.Point(231, 449)
        Me.btncalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(193, 72)
        Me.btncalculate.TabIndex = 5
        Me.btncalculate.Text = "Calculate Price"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'btnreturn
        '
        Me.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnreturn.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.Location = New System.Drawing.Point(633, 449)
        Me.btnreturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(193, 72)
        Me.btnreturn.TabIndex = 6
        Me.btnreturn.Text = "Return"
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(354, 398)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 47)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "The total price is: "
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(658, 398)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(115, 47)
        Me.lbltotal.TabIndex = 8
        Me.lbltotal.Text = "99999"
        '
        'btnproceedpayment
        '
        Me.btnproceedpayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnproceedpayment.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproceedpayment.Location = New System.Drawing.Point(432, 449)
        Me.btnproceedpayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnproceedpayment.Name = "btnproceedpayment"
        Me.btnproceedpayment.Size = New System.Drawing.Size(193, 72)
        Me.btnproceedpayment.TabIndex = 9
        Me.btnproceedpayment.Text = "Proceed to Payment"
        Me.btnproceedpayment.UseVisualStyleBackColor = True
        '
        'dgvclass1
        '
        Me.dgvclass1.AllowUserToAddRows = False
        Me.dgvclass1.AllowUserToDeleteRows = False
        Me.dgvclass1.AllowUserToResizeColumns = False
        Me.dgvclass1.AllowUserToResizeRows = False
        Me.dgvclass1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvclass1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclass1.Location = New System.Drawing.Point(12, 12)
        Me.dgvclass1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvclass1.Name = "dgvclass1"
        Me.dgvclass1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvclass1.RowTemplate.Height = 24
        Me.dgvclass1.Size = New System.Drawing.Size(1043, 238)
        Me.dgvclass1.TabIndex = 10
        '
        'lblWelcomeTo
        '
        Me.lblWelcomeTo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcomeTo.AutoSize = True
        Me.lblWelcomeTo.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeTo.Location = New System.Drawing.Point(12, 252)
        Me.lblWelcomeTo.Name = "lblWelcomeTo"
        Me.lblWelcomeTo.Size = New System.Drawing.Size(186, 44)
        Me.lblWelcomeTo.TabIndex = 11
        Me.lblWelcomeTo.Text = "WELCOME!"
        '
        'class1toll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.lblWelcomeTo)
        Me.Controls.Add(Me.dgvclass1)
        Me.Controls.Add(Me.btnproceedpayment)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.cboc1ext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboc1ent)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "class1toll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class 1: Toll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvclass1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cboc1ent As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboc1ext As ComboBox
    Friend WithEvents btncalculate As Button
    Friend WithEvents btnreturn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents btnproceedpayment As Button
    Friend WithEvents dgvclass1 As DataGridView
    Friend WithEvents lblWelcomeTo As Label
End Class
