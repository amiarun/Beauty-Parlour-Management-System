﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cashbook
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
        Me.Btn_go = New System.Windows.Forms.Button
        Me.Txt_te = New System.Windows.Forms.TextBox
        Me.Lbl_s = New System.Windows.Forms.Label
        Me.Lbl_sc = New System.Windows.Forms.Label
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.Btn_re = New System.Windows.Forms.Button
        Me.Lbl_i = New System.Windows.Forms.Label
        Me.Btn_sa = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Btn_cl = New System.Windows.Forms.Button
        Me.Btn_se = New System.Windows.Forms.Button
        Me.Dgv_data = New System.Windows.Forms.DataGridView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmb_sby = New System.Windows.Forms.ComboBox
        Me.Txt_da = New System.Windows.Forms.TextBox
        Me.Txt_amo = New System.Windows.Forms.TextBox
        Me.Txt_par = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cmb_Ty = New System.Windows.Forms.ComboBox
        Me.Lbl_co = New System.Windows.Forms.Label
        Me.Lbl_ty = New System.Windows.Forms.Label
        Me.Txt_id = New System.Windows.Forms.TextBox
        Me.Lbl_semic = New System.Windows.Forms.Label
        Me.Lbl_semi = New System.Windows.Forms.Label
        Me.Lbl_sem = New System.Windows.Forms.Label
        Me.Lbl_se = New System.Windows.Forms.Label
        Me.Lbl_amo = New System.Windows.Forms.Label
        Me.Lbl_par = New System.Windows.Forms.Label
        Me.Lbl_date = New System.Windows.Forms.Label
        Me.Lbl_id = New System.Windows.Forms.Label
        Me.GroupBox4.SuspendLayout()
        CType(Me.Dgv_data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_go
        '
        Me.Btn_go.Location = New System.Drawing.Point(568, 17)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(45, 23)
        Me.Btn_go.TabIndex = 6
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = True
        '
        'Txt_te
        '
        Me.Txt_te.Location = New System.Drawing.Point(383, 15)
        Me.Txt_te.Name = "Txt_te"
        Me.Txt_te.Size = New System.Drawing.Size(122, 20)
        Me.Txt_te.TabIndex = 5
        '
        'Lbl_s
        '
        Me.Lbl_s.AutoSize = True
        Me.Lbl_s.Location = New System.Drawing.Point(72, 20)
        Me.Lbl_s.Name = "Lbl_s"
        Me.Lbl_s.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_s.TabIndex = 3
        Me.Lbl_s.Text = ":"
        '
        'Lbl_sc
        '
        Me.Lbl_sc.AutoSize = True
        Me.Lbl_sc.Location = New System.Drawing.Point(356, 18)
        Me.Lbl_sc.Name = "Lbl_sc"
        Me.Lbl_sc.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_sc.TabIndex = 2
        Me.Lbl_sc.Text = ":"
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.Location = New System.Drawing.Point(283, 18)
        Me.Lbl_sdata.Name = "Lbl_sdata"
        Me.Lbl_sdata.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_sdata.TabIndex = 1
        Me.Lbl_sdata.Text = "Search Data"
        '
        'Btn_re
        '
        Me.Btn_re.Location = New System.Drawing.Point(324, 18)
        Me.Btn_re.Name = "Btn_re"
        Me.Btn_re.Size = New System.Drawing.Size(81, 23)
        Me.Btn_re.TabIndex = 2
        Me.Btn_re.Text = "Refresh"
        Me.Btn_re.UseVisualStyleBackColor = True
        '
        'Lbl_i
        '
        Me.Lbl_i.AutoSize = True
        Me.Lbl_i.Location = New System.Drawing.Point(12, 18)
        Me.Lbl_i.Name = "Lbl_i"
        Me.Lbl_i.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_i.TabIndex = 0
        Me.Lbl_i.Text = "Search By"
        '
        'Btn_sa
        '
        Me.Btn_sa.Location = New System.Drawing.Point(17, 18)
        Me.Btn_sa.Name = "Btn_sa"
        Me.Btn_sa.Size = New System.Drawing.Size(81, 23)
        Me.Btn_sa.TabIndex = 0
        Me.Btn_sa.Text = "Save"
        Me.Btn_sa.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Btn_cl)
        Me.GroupBox4.Controls.Add(Me.Btn_re)
        Me.GroupBox4.Controls.Add(Me.Btn_se)
        Me.GroupBox4.Controls.Add(Me.Btn_sa)
        Me.GroupBox4.Location = New System.Drawing.Point(18, 539)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(628, 59)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        '
        'Btn_cl
        '
        Me.Btn_cl.Location = New System.Drawing.Point(470, 18)
        Me.Btn_cl.Name = "Btn_cl"
        Me.Btn_cl.Size = New System.Drawing.Size(81, 23)
        Me.Btn_cl.TabIndex = 3
        Me.Btn_cl.Text = "Close"
        Me.Btn_cl.UseVisualStyleBackColor = True
        '
        'Btn_se
        '
        Me.Btn_se.Location = New System.Drawing.Point(170, 19)
        Me.Btn_se.Name = "Btn_se"
        Me.Btn_se.Size = New System.Drawing.Size(81, 23)
        Me.Btn_se.TabIndex = 1
        Me.Btn_se.Text = "Search"
        Me.Btn_se.UseVisualStyleBackColor = True
        '
        'Dgv_data
        '
        Me.Dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_data.Location = New System.Drawing.Point(3, 16)
        Me.Dgv_data.Name = "Dgv_data"
        Me.Dgv_data.Size = New System.Drawing.Size(645, 223)
        Me.Dgv_data.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Dgv_data)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 291)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(651, 242)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Cmb_sby)
        Me.GroupBox2.Controls.Add(Me.Btn_go)
        Me.GroupBox2.Controls.Add(Me.Txt_te)
        Me.GroupBox2.Controls.Add(Me.Lbl_s)
        Me.GroupBox2.Controls.Add(Me.Lbl_sc)
        Me.GroupBox2.Controls.Add(Me.Lbl_sdata)
        Me.GroupBox2.Controls.Add(Me.Lbl_i)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 233)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(653, 52)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'Cmb_sby
        '
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"id", "particular", "type", "date"})
        Me.Cmb_sby.Location = New System.Drawing.Point(91, 19)
        Me.Cmb_sby.Name = "Cmb_sby"
        Me.Cmb_sby.Size = New System.Drawing.Size(137, 21)
        Me.Cmb_sby.TabIndex = 7
        '
        'Txt_da
        '
        Me.Txt_da.Location = New System.Drawing.Point(428, 19)
        Me.Txt_da.Name = "Txt_da"
        Me.Txt_da.Size = New System.Drawing.Size(90, 20)
        Me.Txt_da.TabIndex = 11
        '
        'Txt_amo
        '
        Me.Txt_amo.Location = New System.Drawing.Point(141, 122)
        Me.Txt_amo.Name = "Txt_amo"
        Me.Txt_amo.Size = New System.Drawing.Size(90, 20)
        Me.Txt_amo.TabIndex = 10
        '
        'Txt_par
        '
        Me.Txt_par.Location = New System.Drawing.Point(141, 74)
        Me.Txt_par.Name = "Txt_par"
        Me.Txt_par.Size = New System.Drawing.Size(90, 20)
        Me.Txt_par.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cmb_Ty)
        Me.GroupBox1.Controls.Add(Me.Lbl_co)
        Me.GroupBox1.Controls.Add(Me.Lbl_ty)
        Me.GroupBox1.Controls.Add(Me.Txt_da)
        Me.GroupBox1.Controls.Add(Me.Txt_amo)
        Me.GroupBox1.Controls.Add(Me.Txt_par)
        Me.GroupBox1.Controls.Add(Me.Txt_id)
        Me.GroupBox1.Controls.Add(Me.Lbl_semic)
        Me.GroupBox1.Controls.Add(Me.Lbl_semi)
        Me.GroupBox1.Controls.Add(Me.Lbl_sem)
        Me.GroupBox1.Controls.Add(Me.Lbl_se)
        Me.GroupBox1.Controls.Add(Me.Lbl_amo)
        Me.GroupBox1.Controls.Add(Me.Lbl_par)
        Me.GroupBox1.Controls.Add(Me.Lbl_date)
        Me.GroupBox1.Controls.Add(Me.Lbl_id)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 215)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'Cmb_Ty
        '
        Me.Cmb_Ty.FormattingEnabled = True
        Me.Cmb_Ty.Items.AddRange(New Object() {"Income registration", "expence registration"})
        Me.Cmb_Ty.Location = New System.Drawing.Point(143, 161)
        Me.Cmb_Ty.Name = "Cmb_Ty"
        Me.Cmb_Ty.Size = New System.Drawing.Size(87, 21)
        Me.Cmb_Ty.TabIndex = 14
        '
        'Lbl_co
        '
        Me.Lbl_co.AutoSize = True
        Me.Lbl_co.Location = New System.Drawing.Point(101, 171)
        Me.Lbl_co.Name = "Lbl_co"
        Me.Lbl_co.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_co.TabIndex = 13
        Me.Lbl_co.Text = ":"
        '
        'Lbl_ty
        '
        Me.Lbl_ty.AutoSize = True
        Me.Lbl_ty.Location = New System.Drawing.Point(36, 171)
        Me.Lbl_ty.Name = "Lbl_ty"
        Me.Lbl_ty.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_ty.TabIndex = 12
        Me.Lbl_ty.Text = "Type"
        '
        'Txt_id
        '
        Me.Txt_id.Location = New System.Drawing.Point(141, 24)
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(90, 20)
        Me.Txt_id.TabIndex = 8
        '
        'Lbl_semic
        '
        Me.Lbl_semic.AutoSize = True
        Me.Lbl_semic.Location = New System.Drawing.Point(401, 22)
        Me.Lbl_semic.Name = "Lbl_semic"
        Me.Lbl_semic.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_semic.TabIndex = 7
        Me.Lbl_semic.Text = ":"
        '
        'Lbl_semi
        '
        Me.Lbl_semi.AutoSize = True
        Me.Lbl_semi.Location = New System.Drawing.Point(101, 125)
        Me.Lbl_semi.Name = "Lbl_semi"
        Me.Lbl_semi.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_semi.TabIndex = 6
        Me.Lbl_semi.Text = ":"
        '
        'Lbl_sem
        '
        Me.Lbl_sem.AutoSize = True
        Me.Lbl_sem.Location = New System.Drawing.Point(101, 77)
        Me.Lbl_sem.Name = "Lbl_sem"
        Me.Lbl_sem.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_sem.TabIndex = 5
        Me.Lbl_sem.Text = ":"
        '
        'Lbl_se
        '
        Me.Lbl_se.AutoSize = True
        Me.Lbl_se.Location = New System.Drawing.Point(101, 30)
        Me.Lbl_se.Name = "Lbl_se"
        Me.Lbl_se.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_se.TabIndex = 4
        Me.Lbl_se.Text = ":"
        '
        'Lbl_amo
        '
        Me.Lbl_amo.AutoSize = True
        Me.Lbl_amo.Location = New System.Drawing.Point(31, 125)
        Me.Lbl_amo.Name = "Lbl_amo"
        Me.Lbl_amo.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_amo.TabIndex = 3
        Me.Lbl_amo.Text = "Amount"
        '
        'Lbl_par
        '
        Me.Lbl_par.AutoSize = True
        Me.Lbl_par.Location = New System.Drawing.Point(31, 77)
        Me.Lbl_par.Name = "Lbl_par"
        Me.Lbl_par.Size = New System.Drawing.Size(51, 13)
        Me.Lbl_par.TabIndex = 2
        Me.Lbl_par.Text = "Particular"
        '
        'Lbl_date
        '
        Me.Lbl_date.AutoSize = True
        Me.Lbl_date.Location = New System.Drawing.Point(365, 22)
        Me.Lbl_date.Name = "Lbl_date"
        Me.Lbl_date.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_date.TabIndex = 1
        Me.Lbl_date.Text = "Date"
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.Location = New System.Drawing.Point(31, 27)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.Lbl_id.TabIndex = 0
        Me.Lbl_id.Text = "ID"
        '
        'Frm_cashbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 610)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_cashbook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cash book Register"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.Dgv_data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents Txt_te As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_s As System.Windows.Forms.Label
    Friend WithEvents Lbl_sc As System.Windows.Forms.Label
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Btn_re As System.Windows.Forms.Button
    Friend WithEvents Lbl_i As System.Windows.Forms.Label
    Friend WithEvents Btn_sa As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_cl As System.Windows.Forms.Button
    Friend WithEvents Btn_se As System.Windows.Forms.Button
    Friend WithEvents Dgv_data As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_da As System.Windows.Forms.TextBox
    Friend WithEvents Txt_amo As System.Windows.Forms.TextBox
    Friend WithEvents Txt_par As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_semic As System.Windows.Forms.Label
    Friend WithEvents Lbl_semi As System.Windows.Forms.Label
    Friend WithEvents Lbl_sem As System.Windows.Forms.Label
    Friend WithEvents Lbl_se As System.Windows.Forms.Label
    Friend WithEvents Lbl_amo As System.Windows.Forms.Label
    Friend WithEvents Lbl_par As System.Windows.Forms.Label
    Friend WithEvents Lbl_date As System.Windows.Forms.Label
    Friend WithEvents Lbl_id As System.Windows.Forms.Label
    Friend WithEvents Cmb_Ty As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_co As System.Windows.Forms.Label
    Friend WithEvents Lbl_ty As System.Windows.Forms.Label
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
End Class
