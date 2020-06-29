<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_prorep
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
        Me.Lbl_e = New System.Windows.Forms.Label
        Me.Btn_refres = New System.Windows.Forms.Button
        Me.Btn_go = New System.Windows.Forms.Button
        Me.Lbl_sby = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Btn_clo = New System.Windows.Forms.Button
        Me.Cmb_sby = New System.Windows.Forms.ComboBox
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Dgv_data = New System.Windows.Forms.DataGridView
        Me.Txt_sdata = New System.Windows.Forms.TextBox
        Me.Lbl_i = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_e
        '
        Me.Lbl_e.AutoSize = True
        Me.Lbl_e.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_e.Location = New System.Drawing.Point(156, 29)
        Me.Lbl_e.Name = "Lbl_e"
        Me.Lbl_e.Size = New System.Drawing.Size(16, 24)
        Me.Lbl_e.TabIndex = 60
        Me.Lbl_e.Text = ":"
        '
        'Btn_refres
        '
        Me.Btn_refres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_refres.Location = New System.Drawing.Point(101, 9)
        Me.Btn_refres.Name = "Btn_refres"
        Me.Btn_refres.Size = New System.Drawing.Size(134, 36)
        Me.Btn_refres.TabIndex = 0
        Me.Btn_refres.Text = "Refresh"
        Me.Btn_refres.UseVisualStyleBackColor = True
        '
        'Btn_go
        '
        Me.Btn_go.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_go.Location = New System.Drawing.Point(518, 45)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(62, 45)
        Me.Btn_go.TabIndex = 4
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = True
        '
        'Lbl_sby
        '
        Me.Lbl_sby.AutoSize = True
        Me.Lbl_sby.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sby.Location = New System.Drawing.Point(33, 32)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_sby.TabIndex = 0
        Me.Lbl_sby.Text = "Search By"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_clo)
        Me.GroupBox3.Controls.Add(Me.Btn_refres)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 541)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(649, 58)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'Btn_clo
        '
        Me.Btn_clo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_clo.Location = New System.Drawing.Point(405, 13)
        Me.Btn_clo.Name = "Btn_clo"
        Me.Btn_clo.Size = New System.Drawing.Size(134, 36)
        Me.Btn_clo.TabIndex = 1
        Me.Btn_clo.Text = "Close"
        Me.Btn_clo.UseVisualStyleBackColor = True
        '
        'Cmb_sby
        '
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"Id", "register no", "company name", "rate", "expiery rate"})
        Me.Cmb_sby.Location = New System.Drawing.Point(185, 29)
        Me.Cmb_sby.Name = "Cmb_sby"
        Me.Cmb_sby.Size = New System.Drawing.Size(217, 21)
        Me.Cmb_sby.TabIndex = 1
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sdata.Location = New System.Drawing.Point(33, 77)
        Me.Lbl_sdata.Name = "Lbl_sdata"
        Me.Lbl_sdata.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_sdata.TabIndex = 2
        Me.Lbl_sdata.Text = "Search Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dgv_data)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(655, 376)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'Dgv_data
        '
        Me.Dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_data.Location = New System.Drawing.Point(3, 16)
        Me.Dgv_data.Name = "Dgv_data"
        Me.Dgv_data.Size = New System.Drawing.Size(649, 357)
        Me.Dgv_data.TabIndex = 0
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Location = New System.Drawing.Point(185, 82)
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(218, 20)
        Me.Txt_sdata.TabIndex = 3
        '
        'Lbl_i
        '
        Me.Lbl_i.AutoSize = True
        Me.Lbl_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_i.Location = New System.Drawing.Point(156, 77)
        Me.Lbl_i.Name = "Lbl_i"
        Me.Lbl_i.Size = New System.Drawing.Size(16, 24)
        Me.Lbl_i.TabIndex = 59
        Me.Lbl_i.Text = ":"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lbl_e)
        Me.GroupBox1.Controls.Add(Me.Lbl_i)
        Me.GroupBox1.Controls.Add(Me.Btn_go)
        Me.GroupBox1.Controls.Add(Me.Txt_sdata)
        Me.GroupBox1.Controls.Add(Me.Lbl_sdata)
        Me.GroupBox1.Controls.Add(Me.Cmb_sby)
        Me.GroupBox1.Controls.Add(Me.Lbl_sby)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 142)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Frm_prorep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 610)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_prorep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Report"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.Dgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Lbl_e As System.Windows.Forms.Label
    Friend WithEvents Btn_refres As System.Windows.Forms.Button
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_clo As System.Windows.Forms.Button
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Dgv_data As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_i As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
