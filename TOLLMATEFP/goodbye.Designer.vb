<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GoodbyeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GoodbyeForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btngoodbye = New System.Windows.Forms.Button()
        Me.btnqr = New System.Windows.Forms.Button()
        Me.picqr = New System.Windows.Forms.PictureBox()
        CType(Me.picqr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(265, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(515, 125)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thank You!"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(371, 135)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "You may now proceed."
        '
        'btngoodbye
        '
        Me.btngoodbye.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btngoodbye.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngoodbye.Location = New System.Drawing.Point(538, 419)
        Me.btngoodbye.Margin = New System.Windows.Forms.Padding(4)
        Me.btngoodbye.Name = "btngoodbye"
        Me.btngoodbye.Size = New System.Drawing.Size(253, 89)
        Me.btngoodbye.TabIndex = 2
        Me.btngoodbye.Text = " Exit"
        Me.btngoodbye.UseVisualStyleBackColor = True
        '
        'btnqr
        '
        Me.btnqr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnqr.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnqr.Location = New System.Drawing.Point(277, 420)
        Me.btnqr.Margin = New System.Windows.Forms.Padding(4)
        Me.btnqr.Name = "btnqr"
        Me.btnqr.Size = New System.Drawing.Size(253, 89)
        Me.btnqr.TabIndex = 3
        Me.btnqr.Text = "Generate QR Code"
        Me.btnqr.UseVisualStyleBackColor = True
        '
        'picqr
        '
        Me.picqr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.picqr.Location = New System.Drawing.Point(344, 175)
        Me.picqr.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picqr.Name = "picqr"
        Me.picqr.Size = New System.Drawing.Size(359, 238)
        Me.picqr.TabIndex = 4
        Me.picqr.TabStop = False
        '
        'GoodbyeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.picqr)
        Me.Controls.Add(Me.btnqr)
        Me.Controls.Add(Me.btngoodbye)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GoodbyeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thank you for using Tollmate!"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picqr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btngoodbye As Button
    Friend WithEvents btnqr As Button
    Friend WithEvents picqr As PictureBox
End Class
