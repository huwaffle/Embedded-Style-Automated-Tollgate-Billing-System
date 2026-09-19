<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class class1select
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(class1select))
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.cboSelectToll = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnloadtoll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnreturn
        '
        Me.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnreturn.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.Location = New System.Drawing.Point(518, 77)
        Me.btnreturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(162, 69)
        Me.btnreturn.TabIndex = 0
        Me.btnreturn.Text = "Return"
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'cboSelectToll
        '
        Me.cboSelectToll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboSelectToll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectToll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectToll.FormattingEnabled = True
        Me.cboSelectToll.Location = New System.Drawing.Point(68, 110)
        Me.cboSelectToll.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSelectToll.Name = "cboSelectToll"
        Me.cboSelectToll.Size = New System.Drawing.Size(261, 33)
        Me.cboSelectToll.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please select your toll:"
        '
        'btnloadtoll
        '
        Me.btnloadtoll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnloadtoll.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloadtoll.Location = New System.Drawing.Point(337, 77)
        Me.btnloadtoll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnloadtoll.Name = "btnloadtoll"
        Me.btnloadtoll.Size = New System.Drawing.Size(162, 69)
        Me.btnloadtoll.TabIndex = 3
        Me.btnloadtoll.Text = "Load Toll"
        Me.btnloadtoll.UseVisualStyleBackColor = True
        '
        'class1select
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 236)
        Me.Controls.Add(Me.btnloadtoll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSelectToll)
        Me.Controls.Add(Me.btnreturn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "class1select"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Class 1: Selection"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnreturn As Button
    Friend WithEvents cboSelectToll As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnloadtoll As Button
End Class
