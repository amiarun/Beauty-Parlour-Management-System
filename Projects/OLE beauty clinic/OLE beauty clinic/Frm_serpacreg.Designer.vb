<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_spakage
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Lbl_mi = New System.Windows.Forms.Label
        Me.Lbl_se = New System.Windows.Forms.Label
        Me.Lbl_s = New System.Windows.Forms.Label
        Me.Lbl_semi = New System.Windows.Forms.Label
        Me.Txt_am = New System.Windows.Forms.TextBox
        Me.Lbl_amount = New System.Windows.Forms.Label
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.Lbl_name = New System.Windows.Forms.Label
        Me.Txt_rgno = New System.Windows.Forms.TextBox
        Me.Lbl_rgno = New System.Windows.Forms.Label
        Me.Txt_id = New System.Windows.Forms.TextBox
        Me.Lbl_id = New System.Windows.Forms.Label
        Me.Btn_go = New System.Windows.Forms.Button
        Me.Dgv_data = New System.Windows.Forms.DataGridView
        Me.Btn_save = New System.Windows.Forms.Button
        Me.btn_search = New System.Windows.Forms.Button
        Me.Cmb_sby = New System.Windows.Forms.ComboBox
        Me.Txt_sdata = New System.Windows.Forms.TextBox
        Me.Btn_rfresh = New System.Windows.Forms.Button
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.Lbl_sby = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Btn_close = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Lbl_sm = New System.Windows.Forms.Label
        Me.Lbl_semicolan = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lbl_mi)
        Me.GroupBox1.Controls.Add(Me.Lbl_se)
        Me.GroupBox1.Controls.Add(Me.Lbl_s)
        Me.GroupBox1.Controls.Add(Me.Lbl_semi)
        Me.GroupBox1.Controls.Add(Me.Txt_am)
        Me.GroupBox1.Controls.Add(Me.Lbl_amount)
        Me.GroupBox1.Controls.Add(Me.Txt_name)
        Me.GroupBox1.Controls.Add(Me.Lbl_name)
        Me.GroupBox1.Controls.Add(Me.Txt_rgno)
        Me.GroupBox1.Controls.Add(Me.Lbl_rgno)
        Me.GroupBox1.Controls.Add(Me.Txt_id)
        Me.GroupBox1.Controls.Add(Me.Lbl_id)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 196)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Lbl_mi
        '
        Me.Lbl_mi.AutoSize = True
        Me.Lbl_mi.Location = New System.Drawing.Point(87, 16)
        Me.Lbl_mi.Name = "Lbl_mi"
        Me.Lbl_mi.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_mi.TabIndex = 35
        Me.Lbl_mi.Text = ":"
        '
        'Lbl_se
        '
        Me.Lbl_se.AutoSize = True
        Me.Lbl_se.Location = New System.Drawing.Point(87, 138)
        Me.Lbl_se.Name = "Lbl_se"
        Me.Lbl_se.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_se.TabIndex = 34
        Me.Lbl_se.Text = ":"
        '
        'Lbl_s
        '
        Me.Lbl_s.AutoSize = True
        Me.Lbl_s.Location = New System.Drawing.Point(87, 96)
        Me.Lbl_s.Name = "Lbl_s"
        Me.Lbl_s.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_s.TabIndex = 33
        Me.Lbl_s.Text = ":"
        '
        'Lbl_semi
        '
        Me.Lbl_semi.AutoSize = True
        Me.Lbl_semi.Location = New System.Drawing.Point(87, 57)
        Me.Lbl_semi.Name = "Lbl_semi"
        Me.Lbl_semi.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_semi.TabIndex = 32
        Me.Lbl_semi.Text = ":"
        '
        'Txt_am
        '
        Me.Txt_am.Location = New System.Drawing.Point(125, 138)
        Me.Txt_am.Multiline = True
        Me.Txt_am.Name = "Txt_am"
        Me.Txt_am.Size = New System.Drawing.Size(210, 25)
        Me.Txt_am.TabIndex = 7
        '
        'Lbl_amount
        '
        Me.Lbl_amount.AutoSize = True
        Me.Lbl_amount.Location = New System.Drawing.Point(29, 138)
        Me.Lbl_amount.Name = "Lbl_amount"
        Me.Lbl_amount.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_amount.TabIndex = 6
        Me.Lbl_amount.Text = "Amount"
        '
        'Txt_name
        '
        Me.Txt_name.Location = New System.Drawing.Point(125, 57)
        Me.Txt_name.Multiline = True
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(210, 22)
        Me.Txt_name.TabIndex = 5
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.Location = New System.Drawing.Point(29, 57)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_name.TabIndex = 4
        Me.Lbl_name.Text = "Name"
        '
        'Txt_rgno
        '
        Me.Txt_rgno.Location = New System.Drawing.Point(125, 96)
        Me.Txt_rgno.Multiline = True
        Me.Txt_rgno.Name = "Txt_rgno"
        Me.Txt_rgno.Size = New System.Drawing.Size(210, 23)
        Me.Txt_rgno.TabIndex = 3
        '
        'Lbl_rgno
        '
        Me.Lbl_rgno.AutoSize = True
        Me.Lbl_rgno.Location = New System.Drawing.Point(29, 96)
        Me.Lbl_rgno.Name = "Lbl_rgno"
        Me.Lbl_rgno.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_rgno.TabIndex = 2
        Me.Lbl_rgno.Text = "Item"
        '
        'Txt_id
        '
        Me.Txt_id.Location = New System.Drawing.Point(125, 16)
        Me.Txt_id.Multiline = True
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(210, 24)
        Me.Txt_id.TabIndex = 1
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.Location = New System.Drawing.Point(29, 16)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.Lbl_id.TabIndex = 0
        Me.Lbl_id.Text = "ID"
        '
        'Btn_go
        '
        Me.Btn_go.Location = New System.Drawing.Point(524, 9)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(59, 39)
        Me.Btn_go.TabIndex = 4
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = True
        '
        'Dgv_data
        '
        Me.Dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_data.Location = New System.Drawing.Point(3, 16)
        Me.Dgv_data.Name = "Dgv_data"
        Me.Dgv_data.Size = New System.Drawing.Size(647, 211)
        Me.Dgv_data.TabIndex = 0
        '
        'Btn_save
        '
        Me.Btn_save.Location = New System.Drawing.Point(53, 11)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(74, 58)
        Me.Btn_save.TabIndex = 0
        Me.Btn_save.Text = "Save"
        Me.Btn_save.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(158, 13)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(83, 50)
        Me.btn_search.TabIndex = 1
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Cmb_sby
        '
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"id", "item", "name"})
        Me.Cmb_sby.Location = New System.Drawing.Point(85, 19)
        Me.Cmb_sby.Name = "Cmb_sby"
        Me.Cmb_sby.Size = New System.Drawing.Size(142, 21)
        Me.Cmb_sby.TabIndex = 3
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Location = New System.Drawing.Point(344, 19)
        Me.Txt_sdata.Multiline = True
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(153, 21)
        Me.Txt_sdata.TabIndex = 2
        '
        'Btn_rfresh
        '
        Me.Btn_rfresh.Location = New System.Drawing.Point(344, 16)
        Me.Btn_rfresh.Name = "Btn_rfresh"
        Me.Btn_rfresh.Size = New System.Drawing.Size(77, 49)
        Me.Btn_rfresh.TabIndex = 2
        Me.Btn_rfresh.Text = "Refresh"
        Me.Btn_rfresh.UseVisualStyleBackColor = True
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.Location = New System.Drawing.Point(257, 22)
        Me.Lbl_sdata.Name = "Lbl_sdata"
        Me.Lbl_sdata.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_sdata.TabIndex = 1
        Me.Lbl_sdata.Text = "Search data"
        '
        'Lbl_sby
        '
        Me.Lbl_sby.AutoSize = True
        Me.Lbl_sby.Location = New System.Drawing.Point(7, 22)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_sby.TabIndex = 0
        Me.Lbl_sby.Text = "Search By"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_close)
        Me.GroupBox4.Controls.Add(Me.Btn_rfresh)
        Me.GroupBox4.Controls.Add(Me.btn_search)
        Me.GroupBox4.Controls.Add(Me.Btn_save)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 529)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(653, 69)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        '
        'Btn_close
        '
        Me.Btn_close.Location = New System.Drawing.Point(470, 13)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(73, 52)
        Me.Btn_close.TabIndex = 3
        Me.Btn_close.Text = "Close"
        Me.Btn_close.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv_data)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 293)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(653, 230)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_sm)
        Me.GroupBox2.Controls.Add(Me.Lbl_semicolan)
        Me.GroupBox2.Controls.Add(Me.Btn_go)
        Me.GroupBox2.Controls.Add(Me.Cmb_sby)
        Me.GroupBox2.Controls.Add(Me.Txt_sdata)
        Me.GroupBox2.Controls.Add(Me.Lbl_sdata)
        Me.GroupBox2.Controls.Add(Me.Lbl_sby)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 222)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(638, 60)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Lbl_sm
        '
        Me.Lbl_sm.AutoSize = True
        Me.Lbl_sm.Location = New System.Drawing.Point(328, 22)
        Me.Lbl_sm.Name = "Lbl_sm"
        Me.Lbl_sm.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_sm.TabIndex = 36
        Me.Lbl_sm.Text = ":"
        '
        'Lbl_semicolan
        '
        Me.Lbl_semicolan.AutoSize = True
        Me.Lbl_semicolan.Location = New System.Drawing.Point(69, 22)
        Me.Lbl_semicolan.Name = "Lbl_semicolan"
        Me.Lbl_semicolan.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_semicolan.TabIndex = 37
        Me.Lbl_semicolan.Text = ":"
        '
        'Frm_spakage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 610)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_spakage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "service Package Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_amount As System.Windows.Forms.Label
    Friend WithEvents Txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents Txt_rgno As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_rgno As System.Windows.Forms.Label
    Friend WithEvents Txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_id As System.Windows.Forms.Label
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents Dgv_data As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents Btn_rfresh As System.Windows.Forms.Button
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_am As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_mi As System.Windows.Forms.Label
    Friend WithEvents Lbl_se As System.Windows.Forms.Label
    Friend WithEvents Lbl_s As System.Windows.Forms.Label
    Friend WithEvents Lbl_semi As System.Windows.Forms.Label
    Friend WithEvents Lbl_sm As System.Windows.Forms.Label
    Friend WithEvents Lbl_semicolan As System.Windows.Forms.Label
End Class
