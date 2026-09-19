<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class masterlistform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(masterlistform))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMLselectclass = New System.Windows.Forms.ComboBox()
        Me.btnreturn = New System.Windows.Forms.Button()
        Me.btnLoadMastersList = New System.Windows.Forms.Button()
        Me.dgvMastersList = New System.Windows.Forms.DataGridView()
        Me.cboMLselecttoll = New System.Windows.Forms.ComboBox()
        CType(Me.dgvMastersList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(793, 53)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Please select your class and designated toll"
        '
        'cboMLselectclass
        '
        Me.cboMLselectclass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboMLselectclass.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMLselectclass.FormattingEnabled = True
        Me.cboMLselectclass.IntegralHeight = False
        Me.cboMLselectclass.ItemHeight = 27
        Me.cboMLselectclass.Location = New System.Drawing.Point(258, 66)
        Me.cboMLselectclass.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMLselectclass.Name = "cboMLselectclass"
        Me.cboMLselectclass.Size = New System.Drawing.Size(405, 35)
        Me.cboMLselectclass.TabIndex = 12
        Me.cboMLselectclass.Text = "Select your Class"
        '
        'btnreturn
        '
        Me.btnreturn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnreturn.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturn.Location = New System.Drawing.Point(473, 151)
        Me.btnreturn.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreturn.Name = "btnreturn"
        Me.btnreturn.Size = New System.Drawing.Size(190, 63)
        Me.btnreturn.TabIndex = 13
        Me.btnreturn.Text = "Return "
        Me.btnreturn.UseVisualStyleBackColor = True
        '
        'btnLoadMastersList
        '
        Me.btnLoadMastersList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLoadMastersList.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadMastersList.Location = New System.Drawing.Point(258, 152)
        Me.btnLoadMastersList.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLoadMastersList.Name = "btnLoadMastersList"
        Me.btnLoadMastersList.Size = New System.Drawing.Size(207, 62)
        Me.btnLoadMastersList.TabIndex = 14
        Me.btnLoadMastersList.Text = "Load Master List"
        Me.btnLoadMastersList.UseVisualStyleBackColor = True
        '
        'dgvMastersList
        '
        Me.dgvMastersList.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvMastersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMastersList.Location = New System.Drawing.Point(2, 228)
        Me.dgvMastersList.Name = "dgvMastersList"
        Me.dgvMastersList.RowHeadersWidth = 51
        Me.dgvMastersList.RowTemplate.Height = 24
        Me.dgvMastersList.Size = New System.Drawing.Size(918, 356)
        Me.dgvMastersList.TabIndex = 15
        '
        'cboMLselecttoll
        '
        Me.cboMLselecttoll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboMLselecttoll.Font = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMLselecttoll.FormattingEnabled = True
        Me.cboMLselecttoll.IntegralHeight = False
        Me.cboMLselecttoll.ItemHeight = 27
        Me.cboMLselecttoll.Location = New System.Drawing.Point(258, 109)
        Me.cboMLselecttoll.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMLselecttoll.Name = "cboMLselecttoll"
        Me.cboMLselecttoll.Size = New System.Drawing.Size(405, 35)
        Me.cboMLselecttoll.TabIndex = 16
        Me.cboMLselecttoll.Text = "Select your Toll"
        '
        'masterlistform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(922, 584)
        Me.Controls.Add(Me.cboMLselecttoll)
        Me.Controls.Add(Me.dgvMastersList)
        Me.Controls.Add(Me.btnLoadMastersList)
        Me.Controls.Add(Me.btnreturn)
        Me.Controls.Add(Me.cboMLselectclass)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "masterlistform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Masterlist"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvMastersList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents cboMLselectclass As ComboBox
    Friend WithEvents btnreturn As Button
    Friend WithEvents btnLoadMastersList As Button
    Friend WithEvents dgvMastersList As DataGridView
    Friend WithEvents cboMLselecttoll As ComboBox
End Class
