<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcomeform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcomeform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncontinue = New System.Windows.Forms.Button()
        Me.btnmasterlist = New System.Windows.Forms.Button()
        Me.btnabout = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(848, 94)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME TO TOLLMATE!"
        '
        'btncontinue
        '
        Me.btncontinue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btncontinue.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncontinue.Location = New System.Drawing.Point(240, 301)
        Me.btncontinue.Margin = New System.Windows.Forms.Padding(4)
        Me.btncontinue.Name = "btncontinue"
        Me.btncontinue.Size = New System.Drawing.Size(257, 55)
        Me.btncontinue.TabIndex = 1
        Me.btncontinue.Text = "Continue"
        Me.btncontinue.UseVisualStyleBackColor = True
        '
        'btnmasterlist
        '
        Me.btnmasterlist.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnmasterlist.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmasterlist.Location = New System.Drawing.Point(543, 301)
        Me.btnmasterlist.Margin = New System.Windows.Forms.Padding(4)
        Me.btnmasterlist.Name = "btnmasterlist"
        Me.btnmasterlist.Size = New System.Drawing.Size(269, 55)
        Me.btnmasterlist.TabIndex = 2
        Me.btnmasterlist.Text = "Toll Gate Master List"
        Me.btnmasterlist.UseVisualStyleBackColor = True
        '
        'btnabout
        '
        Me.btnabout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnabout.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnabout.Location = New System.Drawing.Point(240, 406)
        Me.btnabout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnabout.Name = "btnabout"
        Me.btnabout.Size = New System.Drawing.Size(257, 55)
        Me.btnabout.TabIndex = 3
        Me.btnabout.Text = "About Tollmate"
        Me.btnabout.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnexit.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(543, 406)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(269, 55)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(240, -81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(572, 558)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'welcomeform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnabout)
        Me.Controls.Add(Me.btnmasterlist)
        Me.Controls.Add(Me.btncontinue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "welcomeform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btncontinue As Button
    Friend WithEvents btnmasterlist As Button
    Friend WithEvents btnabout As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
