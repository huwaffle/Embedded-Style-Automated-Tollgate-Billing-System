<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class class3toll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(class3toll))
        Me.lblWelcomeTo = New System.Windows.Forms.Label()
        Me.dgvclass3 = New System.Windows.Forms.DataGridView()
        Me.btnproceedpayment = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.cboc3ext = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboc3ent = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvclass3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcomeTo
        '
        Me.lblWelcomeTo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcomeTo.AutoSize = True
        Me.lblWelcomeTo.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeTo.Location = New System.Drawing.Point(8, 246)
        Me.lblWelcomeTo.Name = "lblWelcomeTo"
        Me.lblWelcomeTo.Size = New System.Drawing.Size(186, 44)
        Me.lblWelcomeTo.TabIndex = 33
        Me.lblWelcomeTo.Text = "WELCOME!"
        '
        'dgvclass3
        '
        Me.dgvclass3.AllowUserToAddRows = False
        Me.dgvclass3.AllowUserToDeleteRows = False
        Me.dgvclass3.AllowUserToResizeColumns = False
        Me.dgvclass3.AllowUserToResizeRows = False
        Me.dgvclass3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvclass3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclass3.Location = New System.Drawing.Point(12, 4)
        Me.dgvclass3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvclass3.Name = "dgvclass3"
        Me.dgvclass3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvclass3.RowTemplate.Height = 24
        Me.dgvclass3.Size = New System.Drawing.Size(1043, 238)
        Me.dgvclass3.TabIndex = 32
        '
        'btnproceedpayment
        '
        Me.btnproceedpayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnproceedpayment.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproceedpayment.Location = New System.Drawing.Point(423, 469)
        Me.btnproceedpayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnproceedpayment.Name = "btnproceedpayment"
        Me.btnproceedpayment.Size = New System.Drawing.Size(223, 53)
        Me.btnproceedpayment.TabIndex = 31
        Me.btnproceedpayment.Text = "Proceed to Payment"
        Me.btnproceedpayment.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(619, 407)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(110, 44)
        Me.lbltotal.TabIndex = 30
        Me.lbltotal.Text = "99999"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 407)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 44)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "The total price is: "
        '
        'btnreturn
        '
        Me.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnreturn.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.Location = New System.Drawing.Point(654, 469)
        Me.btnreturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(199, 53)
        Me.btnreturn.TabIndex = 28
        Me.btnreturn.Text = "Return"
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'btncalculate
        '
        Me.btncalculate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncalculate.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculate.Location = New System.Drawing.Point(203, 469)
        Me.btncalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(212, 49)
        Me.btncalculate.TabIndex = 27
        Me.btncalculate.Text = "Calculate Price"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'cboc3ext
        '
        Me.cboc3ext.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboc3ext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboc3ext.FormattingEnabled = True
        Me.cboc3ext.Location = New System.Drawing.Point(569, 341)
        Me.cboc3ext.Margin = New System.Windows.Forms.Padding(4)
        Me.cboc3ext.Name = "cboc3ext"
        Me.cboc3ext.Size = New System.Drawing.Size(223, 24)
        Me.cboc3ext.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(600, 298)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 44)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Select Exit"
        '
        'cboc3ent
        '
        Me.cboc3ent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboc3ent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboc3ent.FormattingEnabled = True
        Me.cboc3ent.Location = New System.Drawing.Point(267, 341)
        Me.cboc3ent.Margin = New System.Windows.Forms.Padding(4)
        Me.cboc3ent.Name = "cboc3ent"
        Me.cboc3ent.Size = New System.Drawing.Size(223, 24)
        Me.cboc3ent.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 298)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 44)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Select Entry"
        '
        'class3toll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.lblWelcomeTo)
        Me.Controls.Add(Me.dgvclass3)
        Me.Controls.Add(Me.btnproceedpayment)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.cboc3ext)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboc3ent)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "class3toll"
        Me.Text = "Class 3: Toll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvclass3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcomeTo As Label
    Friend WithEvents dgvclass3 As DataGridView
    Friend WithEvents btnproceedpayment As Button
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnreturn As Button
    Friend WithEvents btncalculate As Button
    Friend WithEvents cboc3ext As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboc3ent As ComboBox
    Friend WithEvents Label1 As Label
End Class
