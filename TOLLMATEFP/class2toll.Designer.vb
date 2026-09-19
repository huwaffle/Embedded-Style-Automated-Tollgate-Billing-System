<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class class2toll
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(class2toll))
        Me.lblWelcomeTo = New System.Windows.Forms.Label()
        Me.dgvclass2 = New System.Windows.Forms.DataGridView()
        Me.btnproceedpayment = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvclass2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblWelcomeTo
        '
        Me.lblWelcomeTo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblWelcomeTo.AutoSize = True
        Me.lblWelcomeTo.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeTo.Location = New System.Drawing.Point(12, 241)
        Me.lblWelcomeTo.Name = "lblWelcomeTo"
        Me.lblWelcomeTo.Size = New System.Drawing.Size(186, 44)
        Me.lblWelcomeTo.TabIndex = 22
        Me.lblWelcomeTo.Text = "WELCOME!"
        '
        'dgvclass2
        '
        Me.dgvclass2.AllowUserToAddRows = False
        Me.dgvclass2.AllowUserToDeleteRows = False
        Me.dgvclass2.AllowUserToResizeColumns = False
        Me.dgvclass2.AllowUserToResizeRows = False
        Me.dgvclass2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvclass2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvclass2.Location = New System.Drawing.Point(12, 6)
        Me.dgvclass2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvclass2.Name = "dgvclass2"
        Me.dgvclass2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvclass2.RowTemplate.Height = 24
        Me.dgvclass2.Size = New System.Drawing.Size(1043, 233)
        Me.dgvclass2.TabIndex = 21
        '
        'btnproceedpayment
        '
        Me.btnproceedpayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnproceedpayment.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproceedpayment.Location = New System.Drawing.Point(432, 458)
        Me.btnproceedpayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnproceedpayment.Name = "btnproceedpayment"
        Me.btnproceedpayment.Size = New System.Drawing.Size(203, 58)
        Me.btnproceedpayment.TabIndex = 20
        Me.btnproceedpayment.Text = "Proceed to Payment"
        Me.btnproceedpayment.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(642, 398)
        Me.lbltotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(110, 44)
        Me.lbltotal.TabIndex = 19
        Me.lbltotal.Text = "99999"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(359, 398)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 44)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "The total price is: "
        '
        'btnreturn
        '
        Me.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnreturn.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.Location = New System.Drawing.Point(643, 458)
        Me.btnreturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(204, 58)
        Me.btnreturn.TabIndex = 17
        Me.btnreturn.Text = "Return"
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'btncalculate
        '
        Me.btncalculate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncalculate.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalculate.Location = New System.Drawing.Point(227, 458)
        Me.btncalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(197, 58)
        Me.btncalculate.TabIndex = 16
        Me.btncalculate.Text = "Calculate Price"
        Me.btncalculate.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(553, 338)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(223, 24)
        Me.ComboBox2.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(578, 293)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 44)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Select Exit"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(284, 338)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(223, 24)
        Me.ComboBox1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 293)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 44)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Select Entry"
        '
        'class2toll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.lblWelcomeTo)
        Me.Controls.Add(Me.dgvclass2)
        Me.Controls.Add(Me.btnproceedpayment)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "class2toll"
        Me.Text = "Class 2: Toll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvclass2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcomeTo As Label
    Friend WithEvents dgvclass2 As DataGridView
    Friend WithEvents btnproceedpayment As Button
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnreturn As Button
    Friend WithEvents btncalculate As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
