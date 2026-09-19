<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class class2select
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(class2select))
        Me.btnloadtoll = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSelectToll2 = New System.Windows.Forms.ComboBox()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnloadtoll
        '
        Me.btnloadtoll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnloadtoll.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloadtoll.Location = New System.Drawing.Point(341, 75)
        Me.btnloadtoll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnloadtoll.Name = "btnloadtoll"
        Me.btnloadtoll.Size = New System.Drawing.Size(158, 64)
        Me.btnloadtoll.TabIndex = 7
        Me.btnloadtoll.Text = "Load Toll"
        Me.btnloadtoll.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Please select your toll:"
        '
        'cboSelectToll2
        '
        Me.cboSelectToll2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboSelectToll2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectToll2.Font = New System.Drawing.Font("MS UI Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectToll2.FormattingEnabled = True
        Me.cboSelectToll2.Location = New System.Drawing.Point(72, 110)
        Me.cboSelectToll2.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSelectToll2.Name = "cboSelectToll2"
        Me.cboSelectToll2.Size = New System.Drawing.Size(261, 25)
        Me.cboSelectToll2.TabIndex = 5
        '
        'btnreturn
        '
        Me.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnreturn.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.Location = New System.Drawing.Point(507, 75)
        Me.btnreturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(152, 64)
        Me.btnreturn.TabIndex = 4
        Me.btnreturn.Text = "Return"
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'class2select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 236)
        Me.Controls.Add(Me.btnloadtoll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSelectToll2)
        Me.Controls.Add(Me.btnreturn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "class2select"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class 2: Selection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnloadtoll As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSelectToll2 As ComboBox
    Friend WithEvents btnreturn As Button
End Class
