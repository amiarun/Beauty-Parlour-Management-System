﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_pcate
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
        Me.Lbl_s = New System.Windows.Forms.Label
        Me.Txt_type = New System.Windows.Forms.TextBox
        Me.Lbl_semi = New System.Windows.Forms.Label
        Me.Lbl_type = New System.Windows.Forms.Label
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.Lbl_name = New System.Windows.Forms.Label
        Me.Txt_id = New System.Windows.Forms.TextBox
        Me.Lbl_id = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Lbl_colom = New System.Windows.Forms.Label
        Me.Lbl_se = New System.Windows.Forms.Label
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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lbl_mi)
        Me.GroupBox1.Controls.Add(Me.Lbl_s)
        Me.GroupBox1.Controls.Add(Me.Txt_type)
        Me.GroupBox1.Controls.Add(Me.Lbl_semi)
        Me.GroupBox1.Controls.Add(Me.Lbl_type)
        Me.GroupBox1.Controls.Add(Me.Txt_name)
        Me.GroupBox1.Controls.Add(Me.Lbl_name)
        Me.GroupBox1.Controls.Add(Me.Txt_id)
        Me.GroupBox1.Controls.Add(Me.Lbl_id)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 166)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Lbl_mi
        '
        Me.Lbl_mi.AutoSize = True
        Me.Lbl_mi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_mi.Location = New System.Drawing.Point(76, 27)
        Me.Lbl_mi.Name = "Lbl_mi"
        Me.Lbl_mi.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_mi.TabIndex = 38
        Me.Lbl_mi.Text = ":"
        '
        'Lbl_s
        '
        Me.Lbl_s.AutoSize = True
        Me.Lbl_s.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_s.Location = New System.Drawing.Point(76, 118)
        Me.Lbl_s.Name = "Lbl_s"
        Me.Lbl_s.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_s.TabIndex = 37
        Me.Lbl_s.Text = ":"
        '
        'Txt_type
        '
        Me.Txt_type.Location = New System.Drawing.Point(130, 115)
        Me.Txt_type.Name = "Txt_type"
        Me.Txt_type.Size = New System.Drawing.Size(154, 20)
        Me.Txt_type.TabIndex = 5
        '
        'Lbl_semi
        '
        Me.Lbl_semi.AutoSize = True
        Me.Lbl_semi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_semi.Location = New System.Drawing.Point(76, 72)
        Me.Lbl_semi.Name = "Lbl_semi"
        Me.Lbl_semi.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_semi.TabIndex = 36
        Me.Lbl_semi.Text = ":"
        '
        'Lbl_type
        '
        Me.Lbl_type.AutoSize = True
        Me.Lbl_type.Location = New System.Drawing.Point(17, 118)
        Me.Lbl_type.Name = "Lbl_type"
        Me.Lbl_type.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_type.TabIndex = 4
        Me.Lbl_type.Text = "Type"
        '
        'Txt_name
        '
        Me.Txt_name.Location = New System.Drawing.Point(130, 69)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(154, 20)
        Me.Txt_name.TabIndex = 3
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.Location = New System.Drawing.Point(17, 72)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_name.TabIndex = 2
        Me.Lbl_name.Text = "Name"
        '
        'Txt_id
        '
        Me.Txt_id.Location = New System.Drawing.Point(130, 24)
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(154, 20)
        Me.Txt_id.TabIndex = 1
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.Location = New System.Drawing.Point(17, 27)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.Lbl_id.TabIndex = 0
        Me.Lbl_id.Text = "ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_colom)
        Me.GroupBox2.Controls.Add(Me.Lbl_se)
        Me.GroupBox2.Controls.Add(Me.Btn_go)
        Me.GroupBox2.Controls.Add(Me.Cmb_sby)
        Me.GroupBox2.Controls.Add(Me.Txt_sdata)
        Me.GroupBox2.Controls.Add(Me.Lbl_sdata)
        Me.GroupBox2.Controls.Add(Me.Lbl_sby)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(624, 54)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Lbl_colom
        '
        Me.Lbl_colom.AutoSize = True
        Me.Lbl_colom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_colom.Location = New System.Drawing.Point(338, 23)
        Me.Lbl_colom.Name = "Lbl_colom"
        Me.Lbl_colom.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_colom.TabIndex = 41
        Me.Lbl_colom.Text = ":"
        '
        'Lbl_se
        '
        Me.Lbl_se.AutoSize = True
        Me.Lbl_se.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_se.Location = New System.Drawing.Point(76, 23)
        Me.Lbl_se.Name = "Lbl_se"
        Me.Lbl_se.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_se.TabIndex = 40
        Me.Lbl_se.Text = ":"
        '
        'Btn_go
        '
        Me.Btn_go.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_go.Location = New System.Drawing.Point(530, 14)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(60, 30)
        Me.Btn_go.TabIndex = 14
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = True
        '
        'Cmb_sby
        '
        Me.Cmb_sby.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"Id", "name", "type"})
        Me.Cmb_sby.Location = New System.Drawing.Point(92, 16)
        Me.Cmb_sby.Name = "Cmb_sby"
        Me.Cmb_sby.Size = New System.Drawing.Size(142, 26)
        Me.Cmb_sby.TabIndex = 13
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sdata.Location = New System.Drawing.Point(354, 20)
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(153, 24)
        Me.Txt_sdata.TabIndex = 12
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sdata.Location = New System.Drawing.Point(258, 23)
        Me.Lbl_sdata.Name = "Lbl_sdata"
        Me.Lbl_sdata.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_sdata.TabIndex = 11
        Me.Lbl_sdata.Text = "Search data"
        '
        'Lbl_sby
        '
        Me.Lbl_sby.AutoSize = True
        Me.Lbl_sby.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sby.Location = New System.Drawing.Point(9, 23)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_sby.TabIndex = 10
        Me.Lbl_sby.Text = "Search By"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 249)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(662, 289)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(656, 270)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_close)
        Me.GroupBox4.Controls.Add(Me.Btn_rfresh)
        Me.GroupBox4.Controls.Add(Me.btn_search)
        Me.GroupBox4.Controls.Add(Me.Btn_save)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 544)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(647, 54)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Btn_close
        '
        Me.Btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.Location = New System.Drawing.Point(510, 11)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(88, 33)
        Me.Btn_close.TabIndex = 11
        Me.Btn_close.Text = "Close"
        Me.Btn_close.UseVisualStyleBackColor = True
        '
        'Btn_rfresh
        '
        Me.Btn_rfresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_rfresh.Location = New System.Drawing.Point(338, 9)
        Me.Btn_rfresh.Name = "Btn_rfresh"
        Me.Btn_rfresh.Size = New System.Drawing.Size(103, 35)
        Me.Btn_rfresh.TabIndex = 10
        Me.Btn_rfresh.Text = "Refresh"
        Me.Btn_rfresh.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(198, 9)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(99, 32)
        Me.btn_search.TabIndex = 9
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Btn_save
        '
        Me.Btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_save.Location = New System.Drawing.Point(40, 9)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(95, 32)
        Me.Btn_save.TabIndex = 8
        Me.Btn_save.Text = "Save"
        Me.Btn_save.UseVisualStyleBackColor = True
        '
        'Frm_pcate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 610)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_pcate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product category registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_type As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_type As System.Windows.Forms.Label
    Friend WithEvents Txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents Txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_id As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents Btn_rfresh As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents Btn_save As System.Windows.Forms.Button
    Friend WithEvents Lbl_mi As System.Windows.Forms.Label
    Friend WithEvents Lbl_s As System.Windows.Forms.Label
    Friend WithEvents Lbl_semi As System.Windows.Forms.Label
    Friend WithEvents Lbl_colom As System.Windows.Forms.Label
    Friend WithEvents Lbl_se As System.Windows.Forms.Label
End Class
