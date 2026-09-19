<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class queue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(queue))
        Me.btnprocessqueue = New System.Windows.Forms.Button()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblnextorder = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.shownumber = New System.Windows.Forms.Label()
        Me.takenumber = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblcurrentorder = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnprocessqueue
        '
        Me.btnprocessqueue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnprocessqueue.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprocessqueue.Location = New System.Drawing.Point(388, 310)
        Me.btnprocessqueue.Margin = New System.Windows.Forms.Padding(4)
        Me.btnprocessqueue.Name = "btnprocessqueue"
        Me.btnprocessqueue.Size = New System.Drawing.Size(301, 69)
        Me.btnprocessqueue.TabIndex = 2
        Me.btnprocessqueue.Text = "Process Queue"
        Me.btnprocessqueue.UseVisualStyleBackColor = True
        '
        'btnreturn
        '
        Me.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnreturn.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.Location = New System.Drawing.Point(388, 398)
        Me.btnreturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(301, 69)
        Me.btnreturn.TabIndex = 3
        Me.btnreturn.Text = "Return"
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 268)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Wait for your number to appear"
        '
        'lblnextorder
        '
        Me.lblnextorder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblnextorder.AutoSize = True
        Me.lblnextorder.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnextorder.Location = New System.Drawing.Point(894, 238)
        Me.lblnextorder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnextorder.Name = "lblnextorder"
        Me.lblnextorder.Size = New System.Drawing.Size(94, 75)
        Me.lblnextorder.TabIndex = 5
        Me.lblnextorder.Text = "69"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(875, 196)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 44)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Waiting:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 238)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(253, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Watch here for your number"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(221, 44)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Your Number:"
        '
        'shownumber
        '
        Me.shownumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.shownumber.AutoSize = True
        Me.shownumber.Font = New System.Drawing.Font("Montserrat", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shownumber.Location = New System.Drawing.Point(86, 268)
        Me.shownumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.shownumber.Name = "shownumber"
        Me.shownumber.Size = New System.Drawing.Size(94, 75)
        Me.shownumber.TabIndex = 11
        Me.shownumber.Text = "69"
        '
        'takenumber
        '
        Me.takenumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.takenumber.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.takenumber.Location = New System.Drawing.Point(51, 345)
        Me.takenumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.takenumber.Name = "takenumber"
        Me.takenumber.Size = New System.Drawing.Size(164, 70)
        Me.takenumber.TabIndex = 12
        Me.takenumber.Text = "Take Number:"
        Me.takenumber.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(250, -131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(572, 558)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(171, 62)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 36)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Current:"
        Me.Label3.Visible = False
        '
        'lblcurrentorder
        '
        Me.lblcurrentorder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblcurrentorder.AutoSize = True
        Me.lblcurrentorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcurrentorder.Location = New System.Drawing.Point(168, 98)
        Me.lblcurrentorder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcurrentorder.Name = "lblcurrentorder"
        Me.lblcurrentorder.Size = New System.Drawing.Size(77, 54)
        Me.lblcurrentorder.TabIndex = 1
        Me.lblcurrentorder.Text = "69"
        Me.lblcurrentorder.Visible = False
        '
        'queue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.takenumber)
        Me.Controls.Add(Me.shownumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblnextorder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.btnprocessqueue)
        Me.Controls.Add(Me.lblcurrentorder)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "queue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TOLLMATE: QUEUE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnprocessqueue As Button
    Friend WithEvents btnreturn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblnextorder As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents shownumber As Label
    Friend WithEvents takenumber As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcurrentorder As Label
End Class
