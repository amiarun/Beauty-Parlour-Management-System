﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_serrep
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Lbl_e = New System.Windows.Forms.Label
        Me.Lbl_i = New System.Windows.Forms.Label
        Me.Btn_go = New System.Windows.Forms.Button
        Me.Txt_sdata = New System.Windows.Forms.TextBox
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.Cmb_sby = New System.Windows.Forms.ComboBox
        Me.Lbl_sby = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Btn_clo = New System.Windows.Forms.Button
        Me.Btn_refres = New System.Windows.Forms.Button
        Me.Dgv_data = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.GroupBox1.Location = New System.Drawing.Point(7, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(626, 103)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Lbl_e
        '
        Me.Lbl_e.AutoSize = True
        Me.Lbl_e.Location = New System.Drawing.Point(76, 17)
        Me.Lbl_e.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_e.Name = "Lbl_e"
        Me.Lbl_e.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_e.TabIndex = 60
        Me.Lbl_e.Text = ":"
        '
        'Lbl_i
        '
        Me.Lbl_i.AutoSize = True
        Me.Lbl_i.Location = New System.Drawing.Point(76, 59)
        Me.Lbl_i.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_i.Name = "Lbl_i"
        Me.Lbl_i.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_i.TabIndex = 59
        Me.Lbl_i.Text = ":"
        '
        'Btn_go
        '
        Me.Btn_go.Location = New System.Drawing.Point(488, 42)
        Me.Btn_go.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(41, 30)
        Me.Btn_go.TabIndex = 4
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = True
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Location = New System.Drawing.Point(112, 56)
        Me.Txt_sdata.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(111, 20)
        Me.Txt_sdata.TabIndex = 3
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.Location = New System.Drawing.Point(11, 59)
        Me.Lbl_sdata.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_sdata.Name = "Lbl_sdata"
        Me.Lbl_sdata.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_sdata.TabIndex = 2
        Me.Lbl_sdata.Text = "Search data"
        '
        'Cmb_sby
        '
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"id ", "register no", "name"})
        Me.Cmb_sby.Location = New System.Drawing.Point(112, 14)
        Me.Cmb_sby.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmb_sby.Name = "Cmb_sby"
        Me.Cmb_sby.Size = New System.Drawing.Size(110, 21)
        Me.Cmb_sby.TabIndex = 1
        '
        'Lbl_sby
        '
        Me.Lbl_sby.AutoSize = True
        Me.Lbl_sby.Location = New System.Drawing.Point(11, 16)
        Me.Lbl_sby.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_sby.TabIndex = 0
        Me.Lbl_sby.Text = "Search by"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_clo)
        Me.GroupBox3.Controls.Add(Me.Btn_refres)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 534)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(656, 68)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'Btn_clo
        '
        Me.Btn_clo.Location = New System.Drawing.Point(315, 14)
        Me.Btn_clo.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_clo.Name = "Btn_clo"
        Me.Btn_clo.Size = New System.Drawing.Size(94, 45)
        Me.Btn_clo.TabIndex = 1
        Me.Btn_clo.Text = "Close"
        Me.Btn_clo.UseVisualStyleBackColor = True
        '
        'Btn_refres
        '
        Me.Btn_refres.Location = New System.Drawing.Point(147, 14)
        Me.Btn_refres.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_refres.Name = "Btn_refres"
        Me.Btn_refres.Size = New System.Drawing.Size(97, 45)
        Me.Btn_refres.TabIndex = 0
        Me.Btn_refres.Text = "Refresh"
        Me.Btn_refres.UseVisualStyleBackColor = True
        '
        'Dgv_data
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_data.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_data.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_data.Location = New System.Drawing.Point(2, 15)
        Me.Dgv_data.Margin = New System.Windows.Forms.Padding(2)
        Me.Dgv_data.Name = "Dgv_data"
        Me.Dgv_data.Size = New System.Drawing.Size(656, 393)
        Me.Dgv_data.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dgv_data)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 120)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(660, 410)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Frm_serrep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 610)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Frm_serrep"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Dgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_e As System.Windows.Forms.Label
    Friend WithEvents Lbl_i As System.Windows.Forms.Label
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_clo As System.Windows.Forms.Button
    Friend WithEvents Btn_refres As System.Windows.Forms.Button
    Friend WithEvents Dgv_data As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
