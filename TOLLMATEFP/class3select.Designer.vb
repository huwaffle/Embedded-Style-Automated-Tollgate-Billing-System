<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class class3select
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(class3select))
        Me.btnloadtoll3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSelectToll3 = New System.Windows.Forms.ComboBox()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnloadtoll3
        '
        Me.btnloadtoll3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnloadtoll3.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloadtoll3.Location = New System.Drawing.Point(345, 77)
        Me.btnloadtoll3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnloadtoll3.Name = "btnloadtoll3"
        Me.btnloadtoll3.Size = New System.Drawing.Size(150, 63)
        Me.btnloadtoll3.TabIndex = 11
        Me.btnloadtoll3.Text = "Load Toll"
        Me.btnloadtoll3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 31)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Please select your toll:"
        '
        'cboSelectToll3
        '
        Me.cboSelectToll3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboSelectToll3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectToll3.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectToll3.FormattingEnabled = True
        Me.cboSelectToll3.Location = New System.Drawing.Point(76, 112)
        Me.cboSelectToll3.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSelectToll3.Name = "cboSelectToll3"
        Me.cboSelectToll3.Size = New System.Drawing.Size(261, 25)
        Me.cboSelectToll3.TabIndex = 9
        '
        'btnreturn
        '
        Me.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnreturn.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.Location = New System.Drawing.Point(503, 77)
        Me.btnreturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(174, 63)
        Me.btnreturn.TabIndex = 8
        Me.btnreturn.Text = "Return"
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'class3select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 236)
        Me.Controls.Add(Me.btnloadtoll3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSelectToll3)
        Me.Controls.Add(Me.btnreturn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "class3select"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class 3: Select"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnloadtoll3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSelectToll3 As ComboBox
    Friend WithEvents btnreturn As Button
End Class
