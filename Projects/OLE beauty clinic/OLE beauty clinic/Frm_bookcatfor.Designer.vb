<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_bcreg
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
        Me.Cmb_sby = New System.Windows.Forms.ComboBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Btn_close = New System.Windows.Forms.Button
        Me.Btn_rfresh = New System.Windows.Forms.Button
        Me.btn_search = New System.Windows.Forms.Button
        Me.Btn_save = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Btn_go = New System.Windows.Forms.Button
        Me.Lbl_rat = New System.Windows.Forms.GroupBox
        Me.Lbl_mi = New System.Windows.Forms.Label
        Me.Lbl_s = New System.Windows.Forms.Label
        Me.Lbl_semi = New System.Windows.Forms.Label
        Me.Txt_type = New System.Windows.Forms.TextBox
        Me.Lbl_type = New System.Windows.Forms.Label
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.Lbl_rate = New System.Windows.Forms.Label
        Me.Txt_id = New System.Windows.Forms.TextBox
        Me.Lbl_id = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Lbl_sco = New System.Windows.Forms.Label
        Me.Lbl_sn = New System.Windows.Forms.Label
        Me.Txt_sdata = New System.Windows.Forms.TextBox
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.Lbl_sby = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Lbl_rat.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmb_sby
        '
        Me.Cmb_sby.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"id", "registration no", "rate", "category", "company name", "code"})
        Me.Cmb_sby.Location = New System.Drawing.Point(132, 29)
        Me.Cmb_sby.Name = "Cmb_sby"
        Me.Cmb_sby.Size = New System.Drawing.Size(142, 26)
        Me.Cmb_sby.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(788, 281)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_close)
        Me.GroupBox4.Controls.Add(Me.Btn_rfresh)
        Me.GroupBox4.Controls.Add(Me.btn_search)
        Me.GroupBox4.Controls.Add(Me.Btn_save)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 606)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(792, 131)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        '
        'Btn_close
        '
        Me.Btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.Location = New System.Drawing.Point(609, 22)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(110, 32)
        Me.Btn_close.TabIndex = 11
        Me.Btn_close.Text = "Close"
        Me.Btn_close.UseVisualStyleBackColor = True
        '
        'Btn_rfresh
        '
        Me.Btn_rfresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_rfresh.Location = New System.Drawing.Point(420, 22)
        Me.Btn_rfresh.Name = "Btn_rfresh"
        Me.Btn_rfresh.Size = New System.Drawing.Size(110, 32)
        Me.Btn_rfresh.TabIndex = 10
        Me.Btn_rfresh.Text = "Refresh"
        Me.Btn_rfresh.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(255, 22)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(110, 32)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Btn_save
        '
        Me.Btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_save.Location = New System.Drawing.Point(74, 22)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(110, 32)
        Me.Btn_save.TabIndex = 8
        Me.Btn_save.Text = "Save"
        Me.Btn_save.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 300)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(794, 300)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        '
        'Btn_go
        '
        Me.Btn_go.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_go.Location = New System.Drawing.Point(700, 14)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(59, 39)
        Me.Btn_go.TabIndex = 14
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = True
        '
        'Lbl_rat
        '
        Me.Lbl_rat.Controls.Add(Me.Lbl_mi)
        Me.Lbl_rat.Controls.Add(Me.Lbl_s)
        Me.Lbl_rat.Controls.Add(Me.Lbl_semi)
        Me.Lbl_rat.Controls.Add(Me.Txt_type)
        Me.Lbl_rat.Controls.Add(Me.Lbl_type)
        Me.Lbl_rat.Controls.Add(Me.Txt_name)
        Me.Lbl_rat.Controls.Add(Me.Lbl_rate)
        Me.Lbl_rat.Controls.Add(Me.Txt_id)
        Me.Lbl_rat.Controls.Add(Me.Lbl_id)
        Me.Lbl_rat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rat.Location = New System.Drawing.Point(8, 12)
        Me.Lbl_rat.Name = "Lbl_rat"
        Me.Lbl_rat.Size = New System.Drawing.Size(774, 212)
        Me.Lbl_rat.TabIndex = 4
        Me.Lbl_rat.TabStop = False
        '
        'Lbl_mi
        '
        Me.Lbl_mi.AutoSize = True
        Me.Lbl_mi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_mi.Location = New System.Drawing.Point(118, 29)
        Me.Lbl_mi.Name = "Lbl_mi"
        Me.Lbl_mi.Size = New System.Drawing.Size(19, 25)
        Me.Lbl_mi.TabIndex = 49
        Me.Lbl_mi.Text = ":"
        '
        'Lbl_s
        '
        Me.Lbl_s.AutoSize = True
        Me.Lbl_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_s.Location = New System.Drawing.Point(118, 178)
        Me.Lbl_s.Name = "Lbl_s"
        Me.Lbl_s.Size = New System.Drawing.Size(19, 25)
        Me.Lbl_s.TabIndex = 48
        Me.Lbl_s.Text = ":"
        '
        'Lbl_semi
        '
        Me.Lbl_semi.AutoSize = True
        Me.Lbl_semi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_semi.Location = New System.Drawing.Point(118, 103)
        Me.Lbl_semi.Name = "Lbl_semi"
        Me.Lbl_semi.Size = New System.Drawing.Size(19, 25)
        Me.Lbl_semi.TabIndex = 47
        Me.Lbl_semi.Text = ":"
        '
        'Txt_type
        '
        Me.Txt_type.Location = New System.Drawing.Point(159, 99)
        Me.Txt_type.Name = "Txt_type"
        Me.Txt_type.Size = New System.Drawing.Size(154, 20)
        Me.Txt_type.TabIndex = 5
        '
        'Lbl_type
        '
        Me.Lbl_type.AutoSize = True
        Me.Lbl_type.Location = New System.Drawing.Point(17, 99)
        Me.Lbl_type.Name = "Lbl_type"
        Me.Lbl_type.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_type.TabIndex = 4
        Me.Lbl_type.Text = "Type"
        '
        'Txt_name
        '
        Me.Txt_name.Location = New System.Drawing.Point(159, 176)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(154, 20)
        Me.Txt_name.TabIndex = 3
        '
        'Lbl_rate
        '
        Me.Lbl_rate.AutoSize = True
        Me.Lbl_rate.Location = New System.Drawing.Point(17, 179)
        Me.Lbl_rate.Name = "Lbl_rate"
        Me.Lbl_rate.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_rate.TabIndex = 2
        Me.Lbl_rate.Text = "Rate"
        '
        'Txt_id
        '
        Me.Txt_id.Location = New System.Drawing.Point(159, 27)
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(154, 20)
        Me.Txt_id.TabIndex = 1
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.Location = New System.Drawing.Point(17, 26)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.Lbl_id.TabIndex = 0
        Me.Lbl_id.Text = "ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_sco)
        Me.GroupBox2.Controls.Add(Me.Lbl_sn)
        Me.GroupBox2.Controls.Add(Me.Btn_go)
        Me.GroupBox2.Controls.Add(Me.Cmb_sby)
        Me.GroupBox2.Controls.Add(Me.Txt_sdata)
        Me.GroupBox2.Controls.Add(Me.Lbl_sdata)
        Me.GroupBox2.Controls.Add(Me.Lbl_sby)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 64)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'Lbl_sco
        '
        Me.Lbl_sco.AutoSize = True
        Me.Lbl_sco.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sco.Location = New System.Drawing.Point(112, 31)
        Me.Lbl_sco.Name = "Lbl_sco"
        Me.Lbl_sco.Size = New System.Drawing.Size(16, 24)
        Me.Lbl_sco.TabIndex = 47
        Me.Lbl_sco.Text = ":"
        '
        'Lbl_sn
        '
        Me.Lbl_sn.AutoSize = True
        Me.Lbl_sn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sn.Location = New System.Drawing.Point(483, 27)
        Me.Lbl_sn.Name = "Lbl_sn"
        Me.Lbl_sn.Size = New System.Drawing.Size(16, 24)
        Me.Lbl_sn.TabIndex = 46
        Me.Lbl_sn.Text = ":"
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sdata.Location = New System.Drawing.Point(503, 27)
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(153, 24)
        Me.Txt_sdata.TabIndex = 12
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sdata.Location = New System.Drawing.Point(379, 32)
        Me.Lbl_sdata.Name = "Lbl_sdata"
        Me.Lbl_sdata.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_sdata.TabIndex = 11
        Me.Lbl_sdata.Text = "Search data"
        '
        'Lbl_sby
        '
        Me.Lbl_sby.AutoSize = True
        Me.Lbl_sby.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sby.Location = New System.Drawing.Point(14, 31)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_sby.TabIndex = 10
        Me.Lbl_sby.Text = "Search By"
        '
        'Frm_bcreg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 745)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Lbl_rat)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_bcreg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking category registration"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Lbl_rat.ResumeLayout(False)
        Me.Lbl_rat.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents Btn_rfresh As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents Btn_save As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents Lbl_rat As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_type As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_type As System.Windows.Forms.Label
    Friend WithEvents Txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_rate As System.Windows.Forms.Label
    Friend WithEvents Txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents Lbl_mi As System.Windows.Forms.Label
    Friend WithEvents Lbl_s As System.Windows.Forms.Label
    Friend WithEvents Lbl_semi As System.Windows.Forms.Label
    Friend WithEvents Lbl_sco As System.Windows.Forms.Label
    Friend WithEvents Lbl_sn As System.Windows.Forms.Label
End Class
