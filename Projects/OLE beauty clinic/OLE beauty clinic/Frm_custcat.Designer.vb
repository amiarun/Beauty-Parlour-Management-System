<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cust
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Btn_close = New System.Windows.Forms.Button
        Me.Btn_refresh = New System.Windows.Forms.Button
        Me.Btn_search = New System.Windows.Forms.Button
        Me.Btn_save = New System.Windows.Forms.Button
        Me.Lbl_searb = New System.Windows.Forms.Label
        Me.Cmb_searchby = New System.Windows.Forms.ComboBox
        Me.Lbl_data = New System.Windows.Forms.Label
        Me.Txt_data = New System.Windows.Forms.TextBox
        Me.Btn_go = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Lbl_se = New System.Windows.Forms.Label
        Me.Lbl_s = New System.Windows.Forms.Label
        Me.Lbl_semi = New System.Windows.Forms.Label
        Me.Txt_remarks = New System.Windows.Forms.TextBox
        Me.Txt_id = New System.Windows.Forms.TextBox
        Me.Lbl_remarks = New System.Windows.Forms.Label
        Me.Lbl_category = New System.Windows.Forms.Label
        Me.Lbl_id = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmb_sby = New System.Windows.Forms.ComboBox
        Me.Txt_da = New System.Windows.Forms.TextBox
        Me.Btn_g = New System.Windows.Forms.Button
        Me.Lbl_da = New System.Windows.Forms.Label
        Me.Lbl_searchby = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Dvg_data = New System.Windows.Forms.DataGridView
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Btn_cl = New System.Windows.Forms.Button
        Me.Btn_re = New System.Windows.Forms.Button
        Me.Btn_se = New System.Windows.Forms.Button
        Me.Btn_s = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Dvg_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(6, 28)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1572, 300)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 892)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Size = New System.Drawing.Size(1584, 334)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_close)
        Me.GroupBox4.Controls.Add(Me.Btn_refresh)
        Me.GroupBox4.Controls.Add(Me.Btn_search)
        Me.GroupBox4.Controls.Add(Me.Btn_save)
        Me.GroupBox4.Location = New System.Drawing.Point(32, 1255)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox4.Size = New System.Drawing.Size(1576, 105)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        '
        'Btn_close
        '
        Me.Btn_close.Location = New System.Drawing.Point(1152, 18)
        Me.Btn_close.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(230, 68)
        Me.Btn_close.TabIndex = 3
        Me.Btn_close.Text = "Close"
        Me.Btn_close.UseVisualStyleBackColor = True
        '
        'Btn_refresh
        '
        Me.Btn_refresh.Location = New System.Drawing.Point(736, 26)
        Me.Btn_refresh.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn_refresh.Name = "Btn_refresh"
        Me.Btn_refresh.Size = New System.Drawing.Size(230, 68)
        Me.Btn_refresh.TabIndex = 2
        Me.Btn_refresh.Text = "Refresh"
        Me.Btn_refresh.UseVisualStyleBackColor = True
        '
        'Btn_search
        '
        Me.Btn_search.Location = New System.Drawing.Point(376, 26)
        Me.Btn_search.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(230, 68)
        Me.Btn_search.TabIndex = 1
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = True
        '
        'Btn_save
        '
        Me.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_save.Location = New System.Drawing.Point(26, 26)
        Me.Btn_save.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(230, 68)
        Me.Btn_save.TabIndex = 0
        Me.Btn_save.Text = "Save"
        Me.Btn_save.UseVisualStyleBackColor = True
        '
        'Lbl_searb
        '
        Me.Lbl_searb.AutoSize = True
        Me.Lbl_searb.Location = New System.Drawing.Point(14, 33)
        Me.Lbl_searb.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_searb.Name = "Lbl_searb"
        Me.Lbl_searb.Size = New System.Drawing.Size(105, 24)
        Me.Lbl_searb.TabIndex = 0
        Me.Lbl_searb.Text = "Search By"
        '
        'Cmb_searchby
        '
        Me.Cmb_searchby.FormattingEnabled = True
        Me.Cmb_searchby.Items.AddRange(New Object() {"id", "regno", "name", "dob", "district", "place"})
        Me.Cmb_searchby.Location = New System.Drawing.Point(234, 18)
        Me.Cmb_searchby.Margin = New System.Windows.Forms.Padding(6)
        Me.Cmb_searchby.Name = "Cmb_searchby"
        Me.Cmb_searchby.Size = New System.Drawing.Size(238, 32)
        Me.Cmb_searchby.TabIndex = 2
        '
        'Lbl_data
        '
        Me.Lbl_data.AutoSize = True
        Me.Lbl_data.Location = New System.Drawing.Point(614, 33)
        Me.Lbl_data.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Lbl_data.Name = "Lbl_data"
        Me.Lbl_data.Size = New System.Drawing.Size(123, 24)
        Me.Lbl_data.TabIndex = 3
        Me.Lbl_data.Text = "Search Data"
        '
        'Txt_data
        '
        Me.Txt_data.Location = New System.Drawing.Point(872, 26)
        Me.Txt_data.Margin = New System.Windows.Forms.Padding(6)
        Me.Txt_data.Name = "Txt_data"
        Me.Txt_data.Size = New System.Drawing.Size(308, 29)
        Me.Txt_data.TabIndex = 4
        '
        'Btn_go
        '
        Me.Btn_go.Location = New System.Drawing.Point(1336, 30)
        Me.Btn_go.Margin = New System.Windows.Forms.Padding(6)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(132, 48)
        Me.Btn_go.TabIndex = 5
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_go)
        Me.GroupBox2.Controls.Add(Me.Txt_data)
        Me.GroupBox2.Controls.Add(Me.Lbl_data)
        Me.GroupBox2.Controls.Add(Me.Cmb_searchby)
        Me.GroupBox2.Controls.Add(Me.Lbl_searb)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 799)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(1590, 79)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Lbl_se)
        Me.GroupBox1.Controls.Add(Me.Lbl_s)
        Me.GroupBox1.Controls.Add(Me.Lbl_semi)
        Me.GroupBox1.Controls.Add(Me.Txt_remarks)
        Me.GroupBox1.Controls.Add(Me.Txt_id)
        Me.GroupBox1.Controls.Add(Me.Lbl_remarks)
        Me.GroupBox1.Controls.Add(Me.Lbl_category)
        Me.GroupBox1.Controls.Add(Me.Lbl_id)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 162)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(173, 72)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 21)
        Me.ComboBox1.TabIndex = 31
        '
        'Lbl_se
        '
        Me.Lbl_se.AutoSize = True
        Me.Lbl_se.Location = New System.Drawing.Point(135, 126)
        Me.Lbl_se.Name = "Lbl_se"
        Me.Lbl_se.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_se.TabIndex = 30
        Me.Lbl_se.Text = ":"
        '
        'Lbl_s
        '
        Me.Lbl_s.AutoSize = True
        Me.Lbl_s.Location = New System.Drawing.Point(135, 78)
        Me.Lbl_s.Name = "Lbl_s"
        Me.Lbl_s.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_s.TabIndex = 29
        Me.Lbl_s.Text = ":"
        '
        'Lbl_semi
        '
        Me.Lbl_semi.AutoSize = True
        Me.Lbl_semi.Location = New System.Drawing.Point(135, 28)
        Me.Lbl_semi.Name = "Lbl_semi"
        Me.Lbl_semi.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_semi.TabIndex = 28
        Me.Lbl_semi.Text = ":"
        '
        'Txt_remarks
        '
        Me.Txt_remarks.Location = New System.Drawing.Point(170, 121)
        Me.Txt_remarks.Name = "Txt_remarks"
        Me.Txt_remarks.Size = New System.Drawing.Size(190, 20)
        Me.Txt_remarks.TabIndex = 14
        '
        'Txt_id
        '
        Me.Txt_id.Location = New System.Drawing.Point(170, 28)
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(190, 20)
        Me.Txt_id.TabIndex = 12
        '
        'Lbl_remarks
        '
        Me.Lbl_remarks.AutoSize = True
        Me.Lbl_remarks.Location = New System.Drawing.Point(34, 126)
        Me.Lbl_remarks.Name = "Lbl_remarks"
        Me.Lbl_remarks.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_remarks.TabIndex = 11
        Me.Lbl_remarks.Text = "Remarks"
        '
        'Lbl_category
        '
        Me.Lbl_category.AutoSize = True
        Me.Lbl_category.Location = New System.Drawing.Point(34, 75)
        Me.Lbl_category.Name = "Lbl_category"
        Me.Lbl_category.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_category.TabIndex = 10
        Me.Lbl_category.Text = "Category"
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.Location = New System.Drawing.Point(34, 28)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.Lbl_id.TabIndex = 9
        Me.Lbl_id.Text = "ID"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.cmb_sby)
        Me.GroupBox5.Controls.Add(Me.Txt_da)
        Me.GroupBox5.Controls.Add(Me.Btn_g)
        Me.GroupBox5.Controls.Add(Me.Lbl_da)
        Me.GroupBox5.Controls.Add(Me.Lbl_searchby)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(7, 190)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(637, 77)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(339, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = ":"
        '
        'cmb_sby
        '
        Me.cmb_sby.FormattingEnabled = True
        Me.cmb_sby.Items.AddRange(New Object() {"id", "category"})
        Me.cmb_sby.Location = New System.Drawing.Point(89, 34)
        Me.cmb_sby.Name = "cmb_sby"
        Me.cmb_sby.Size = New System.Drawing.Size(154, 21)
        Me.cmb_sby.TabIndex = 5
        '
        'Txt_da
        '
        Me.Txt_da.Location = New System.Drawing.Point(355, 38)
        Me.Txt_da.Name = "Txt_da"
        Me.Txt_da.Size = New System.Drawing.Size(178, 20)
        Me.Txt_da.TabIndex = 4
        '
        'Btn_g
        '
        Me.Btn_g.Location = New System.Drawing.Point(551, 19)
        Me.Btn_g.Name = "Btn_g"
        Me.Btn_g.Size = New System.Drawing.Size(58, 52)
        Me.Btn_g.TabIndex = 2
        Me.Btn_g.Text = "Go"
        Me.Btn_g.UseVisualStyleBackColor = True
        '
        'Lbl_da
        '
        Me.Lbl_da.AutoSize = True
        Me.Lbl_da.Location = New System.Drawing.Point(267, 42)
        Me.Lbl_da.Name = "Lbl_da"
        Me.Lbl_da.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_da.TabIndex = 1
        Me.Lbl_da.Text = "Search data"
        '
        'Lbl_searchby
        '
        Me.Lbl_searchby.AutoSize = True
        Me.Lbl_searchby.Location = New System.Drawing.Point(3, 37)
        Me.Lbl_searchby.Name = "Lbl_searchby"
        Me.Lbl_searchby.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_searchby.TabIndex = 0
        Me.Lbl_searchby.Text = "Search By"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Dvg_data)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 273)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(635, 248)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        '
        'Dvg_data
        '
        Me.Dvg_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dvg_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dvg_data.Location = New System.Drawing.Point(3, 25)
        Me.Dvg_data.Name = "Dvg_data"
        Me.Dvg_data.Size = New System.Drawing.Size(629, 220)
        Me.Dvg_data.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Btn_cl)
        Me.GroupBox7.Controls.Add(Me.Btn_re)
        Me.GroupBox7.Controls.Add(Me.Btn_se)
        Me.GroupBox7.Controls.Add(Me.Btn_s)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(16, 529)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(597, 64)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        '
        'Btn_cl
        '
        Me.Btn_cl.Location = New System.Drawing.Point(458, 12)
        Me.Btn_cl.Name = "Btn_cl"
        Me.Btn_cl.Size = New System.Drawing.Size(63, 43)
        Me.Btn_cl.TabIndex = 3
        Me.Btn_cl.Text = "close"
        Me.Btn_cl.UseVisualStyleBackColor = True
        '
        'Btn_re
        '
        Me.Btn_re.Location = New System.Drawing.Point(313, 15)
        Me.Btn_re.Name = "Btn_re"
        Me.Btn_re.Size = New System.Drawing.Size(69, 43)
        Me.Btn_re.TabIndex = 2
        Me.Btn_re.Text = "Refresh"
        Me.Btn_re.UseVisualStyleBackColor = True
        '
        'Btn_se
        '
        Me.Btn_se.Location = New System.Drawing.Point(153, 12)
        Me.Btn_se.Name = "Btn_se"
        Me.Btn_se.Size = New System.Drawing.Size(78, 43)
        Me.Btn_se.TabIndex = 1
        Me.Btn_se.Text = "Search"
        Me.Btn_se.UseVisualStyleBackColor = True
        '
        'Btn_s
        '
        Me.Btn_s.Location = New System.Drawing.Point(20, 12)
        Me.Btn_s.Name = "Btn_s"
        Me.Btn_s.Size = New System.Drawing.Size(71, 48)
        Me.Btn_s.TabIndex = 0
        Me.Btn_s.Text = "save"
        Me.Btn_s.UseVisualStyleBackColor = True
        '
        'Frm_cust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 610)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Frm_cust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "customer category form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.Dvg_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents Btn_refresh As System.Windows.Forms.Button
    Friend WithEvents Btn_search As System.Windows.Forms.Button
    Friend WithEvents Btn_save As System.Windows.Forms.Button
    Friend WithEvents Lbl_searb As System.Windows.Forms.Label
    Friend WithEvents Cmb_searchby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_data As System.Windows.Forms.Label
    Friend WithEvents Txt_data As System.Windows.Forms.TextBox
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_remarks As System.Windows.Forms.Label
    Friend WithEvents Lbl_category As System.Windows.Forms.Label
    Friend WithEvents Lbl_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_da As System.Windows.Forms.TextBox
    Friend WithEvents Btn_g As System.Windows.Forms.Button
    Friend WithEvents Lbl_da As System.Windows.Forms.Label
    Friend WithEvents Lbl_searchby As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Dvg_data As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_cl As System.Windows.Forms.Button
    Friend WithEvents Btn_re As System.Windows.Forms.Button
    Friend WithEvents Btn_se As System.Windows.Forms.Button
    Friend WithEvents Btn_s As System.Windows.Forms.Button
    Friend WithEvents Txt_remarks As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_se As System.Windows.Forms.Label
    Friend WithEvents Lbl_s As System.Windows.Forms.Label
    Friend WithEvents Lbl_semi As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
