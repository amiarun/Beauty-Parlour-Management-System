<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_sregis
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
        Me.v = New System.Windows.Forms.GroupBox
        Me.Lbl_mi = New System.Windows.Forms.Label
        Me.Lbl_se = New System.Windows.Forms.Label
        Me.cmb_pakage = New System.Windows.Forms.ComboBox
        Me.Lbl_s = New System.Windows.Forms.Label
        Me.Lbl_semi = New System.Windows.Forms.Label
        Me.Lbl_pakag = New System.Windows.Forms.Label
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.Lbl_name = New System.Windows.Forms.Label
        Me.Txt_rgno = New System.Windows.Forms.TextBox
        Me.Lbl_rgno = New System.Windows.Forms.Label
        Me.Txt_id = New System.Windows.Forms.TextBox
        Me.Lbl_id = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Lbl_me = New System.Windows.Forms.Label
        Me.Lbl_ol = New System.Windows.Forms.Label
        Me.Btn_go = New System.Windows.Forms.Button
        Me.Cmb_sby = New System.Windows.Forms.ComboBox
        Me.Txt_sdata = New System.Windows.Forms.TextBox
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.Lbl_sby = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Btn_close = New System.Windows.Forms.Button
        Me.Btn_rfresh = New System.Windows.Forms.Button
        Me.btn_search = New System.Windows.Forms.Button
        Me.Btn_save = New System.Windows.Forms.Button
        Me.v.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'v
        '
        Me.v.Controls.Add(Me.Lbl_mi)
        Me.v.Controls.Add(Me.Lbl_se)
        Me.v.Controls.Add(Me.cmb_pakage)
        Me.v.Controls.Add(Me.Lbl_s)
        Me.v.Controls.Add(Me.Lbl_semi)
        Me.v.Controls.Add(Me.Lbl_pakag)
        Me.v.Controls.Add(Me.Txt_name)
        Me.v.Controls.Add(Me.Lbl_name)
        Me.v.Controls.Add(Me.Txt_rgno)
        Me.v.Controls.Add(Me.Lbl_rgno)
        Me.v.Controls.Add(Me.Txt_id)
        Me.v.Controls.Add(Me.Lbl_id)
        Me.v.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.v.Location = New System.Drawing.Point(12, 12)
        Me.v.Name = "v"
        Me.v.Size = New System.Drawing.Size(641, 182)
        Me.v.TabIndex = 0
        Me.v.TabStop = False
        '
        'Lbl_mi
        '
        Me.Lbl_mi.AutoSize = True
        Me.Lbl_mi.Location = New System.Drawing.Point(147, 33)
        Me.Lbl_mi.Name = "Lbl_mi"
        Me.Lbl_mi.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_mi.TabIndex = 31
        Me.Lbl_mi.Text = ":"
        '
        'Lbl_se
        '
        Me.Lbl_se.AutoSize = True
        Me.Lbl_se.Location = New System.Drawing.Point(147, 139)
        Me.Lbl_se.Name = "Lbl_se"
        Me.Lbl_se.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_se.TabIndex = 30
        Me.Lbl_se.Text = ":"
        '
        'cmb_pakage
        '
        Me.cmb_pakage.FormattingEnabled = True
        Me.cmb_pakage.Location = New System.Drawing.Point(212, 131)
        Me.cmb_pakage.Name = "cmb_pakage"
        Me.cmb_pakage.Size = New System.Drawing.Size(219, 21)
        Me.cmb_pakage.TabIndex = 7
        '
        'Lbl_s
        '
        Me.Lbl_s.AutoSize = True
        Me.Lbl_s.Location = New System.Drawing.Point(147, 102)
        Me.Lbl_s.Name = "Lbl_s"
        Me.Lbl_s.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_s.TabIndex = 29
        Me.Lbl_s.Text = ":"
        '
        'Lbl_semi
        '
        Me.Lbl_semi.AutoSize = True
        Me.Lbl_semi.Location = New System.Drawing.Point(147, 68)
        Me.Lbl_semi.Name = "Lbl_semi"
        Me.Lbl_semi.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_semi.TabIndex = 28
        Me.Lbl_semi.Text = ":"
        '
        'Lbl_pakag
        '
        Me.Lbl_pakag.AutoSize = True
        Me.Lbl_pakag.Location = New System.Drawing.Point(19, 139)
        Me.Lbl_pakag.Name = "Lbl_pakag"
        Me.Lbl_pakag.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_pakag.TabIndex = 6
        Me.Lbl_pakag.Text = "Packages"
        '
        'Txt_name
        '
        Me.Txt_name.Location = New System.Drawing.Point(212, 87)
        Me.Txt_name.Multiline = True
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(219, 28)
        Me.Txt_name.TabIndex = 5
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.Location = New System.Drawing.Point(19, 102)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_name.TabIndex = 4
        Me.Lbl_name.Text = "Name"
        '
        'Txt_rgno
        '
        Me.Txt_rgno.Location = New System.Drawing.Point(212, 53)
        Me.Txt_rgno.Multiline = True
        Me.Txt_rgno.Name = "Txt_rgno"
        Me.Txt_rgno.Size = New System.Drawing.Size(219, 28)
        Me.Txt_rgno.TabIndex = 3
        '
        'Lbl_rgno
        '
        Me.Lbl_rgno.AutoSize = True
        Me.Lbl_rgno.Location = New System.Drawing.Point(19, 68)
        Me.Lbl_rgno.Name = "Lbl_rgno"
        Me.Lbl_rgno.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_rgno.TabIndex = 2
        Me.Lbl_rgno.Text = "Registration no"
        '
        'Txt_id
        '
        Me.Txt_id.Location = New System.Drawing.Point(212, 19)
        Me.Txt_id.Multiline = True
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(219, 28)
        Me.Txt_id.TabIndex = 1
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.Location = New System.Drawing.Point(30, 30)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.Lbl_id.TabIndex = 0
        Me.Lbl_id.Text = "ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_me)
        Me.GroupBox2.Controls.Add(Me.Lbl_ol)
        Me.GroupBox2.Controls.Add(Me.Btn_go)
        Me.GroupBox2.Controls.Add(Me.Cmb_sby)
        Me.GroupBox2.Controls.Add(Me.Txt_sdata)
        Me.GroupBox2.Controls.Add(Me.Lbl_sdata)
        Me.GroupBox2.Controls.Add(Me.Lbl_sby)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 58)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Lbl_me
        '
        Me.Lbl_me.AutoSize = True
        Me.Lbl_me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_me.Location = New System.Drawing.Point(328, 17)
        Me.Lbl_me.Name = "Lbl_me"
        Me.Lbl_me.Size = New System.Drawing.Size(16, 24)
        Me.Lbl_me.TabIndex = 32
        Me.Lbl_me.Text = ":"
        '
        'Lbl_ol
        '
        Me.Lbl_ol.AutoSize = True
        Me.Lbl_ol.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ol.Location = New System.Drawing.Point(68, 17)
        Me.Lbl_ol.Name = "Lbl_ol"
        Me.Lbl_ol.Size = New System.Drawing.Size(16, 24)
        Me.Lbl_ol.TabIndex = 33
        Me.Lbl_ol.Text = ":"
        '
        'Btn_go
        '
        Me.Btn_go.Location = New System.Drawing.Point(533, 12)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(49, 38)
        Me.Btn_go.TabIndex = 4
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = True
        '
        'Cmb_sby
        '
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"id", "registration no", "name"})
        Me.Cmb_sby.Location = New System.Drawing.Point(90, 22)
        Me.Cmb_sby.Name = "Cmb_sby"
        Me.Cmb_sby.Size = New System.Drawing.Size(142, 21)
        Me.Cmb_sby.TabIndex = 3
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Location = New System.Drawing.Point(350, 19)
        Me.Txt_sdata.Multiline = True
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(153, 26)
        Me.Txt_sdata.TabIndex = 2
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
        Me.Lbl_sby.Location = New System.Drawing.Point(6, 22)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_sby.TabIndex = 0
        Me.Lbl_sby.Text = "Search By"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(653, 256)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(647, 237)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_close)
        Me.GroupBox4.Controls.Add(Me.Btn_rfresh)
        Me.GroupBox4.Controls.Add(Me.btn_search)
        Me.GroupBox4.Controls.Add(Me.Btn_save)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 532)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(641, 56)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Btn_close
        '
        Me.Btn_close.Location = New System.Drawing.Point(486, 10)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(78, 39)
        Me.Btn_close.TabIndex = 3
        Me.Btn_close.Text = "Close"
        Me.Btn_close.UseVisualStyleBackColor = True
        '
        'Btn_rfresh
        '
        Me.Btn_rfresh.Location = New System.Drawing.Point(346, 11)
        Me.Btn_rfresh.Name = "Btn_rfresh"
        Me.Btn_rfresh.Size = New System.Drawing.Size(85, 39)
        Me.Btn_rfresh.TabIndex = 2
        Me.Btn_rfresh.Text = "Refresh"
        Me.Btn_rfresh.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(212, 11)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(82, 39)
        Me.btn_search.TabIndex = 1
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Btn_save
        '
        Me.Btn_save.Location = New System.Drawing.Point(68, 11)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(89, 39)
        Me.Btn_save.TabIndex = 0
        Me.Btn_save.Text = "Save"
        Me.Btn_save.UseVisualStyleBackColor = True
        '
        'Frm_sregis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 610)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.v)
        Me.Name = "Frm_sregis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service registration"
        Me.v.ResumeLayout(False)
        Me.v.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents v As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_pakage As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_pakag As System.Windows.Forms.Label
    Friend WithEvents Txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents Txt_rgno As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_rgno As System.Windows.Forms.Label
    Friend WithEvents Txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_id As System.Windows.Forms.Label
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents Btn_rfresh As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents Btn_save As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents Lbl_mi As System.Windows.Forms.Label
    Friend WithEvents Lbl_se As System.Windows.Forms.Label
    Friend WithEvents Lbl_s As System.Windows.Forms.Label
    Friend WithEvents Lbl_semi As System.Windows.Forms.Label
    Friend WithEvents Lbl_me As System.Windows.Forms.Label
    Friend WithEvents Lbl_ol As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
