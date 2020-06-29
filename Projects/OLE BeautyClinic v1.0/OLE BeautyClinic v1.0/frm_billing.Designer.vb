<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_billing
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
        Me.cmb_item = New System.Windows.Forms.ComboBox
        Me.txt_discount = New System.Windows.Forms.TextBox
        Me.Lbl_grd = New System.Windows.Forms.Label
        Me.Lbl_phno = New System.Windows.Forms.Label
        Me.Lbl_dis = New System.Windows.Forms.Label
        Me.Lbl_trate = New System.Windows.Forms.Label
        Me.Lbl_rgno = New System.Windows.Forms.Label
        Me.Lbl_stfid = New System.Windows.Forms.Label
        Me.txt_phone = New System.Windows.Forms.TextBox
        Me.Txt_id = New System.Windows.Forms.TextBox
        Me.txt_total = New System.Windows.Forms.TextBox
        Me.Txt_registerno = New System.Windows.Forms.TextBox
        Me.Btn_go = New System.Windows.Forms.Button
        Me.txt_searchdata = New System.Windows.Forms.TextBox
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.cbo_sby = New System.Windows.Forms.ComboBox
        Me.Lbl_sby = New System.Windows.Forms.Label
        Me.Btn_close = New System.Windows.Forms.Button
        Me.Btn_search = New System.Windows.Forms.Button
        Me.Btn_refresh = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.lbl_billingreg = New System.Windows.Forms.Label
        Me.Dgv_bill = New System.Windows.Forms.DataGridView
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        CType(Me.Dgv_bill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_item
        '
        Me.cmb_item.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_item.FormattingEnabled = True
        Me.cmb_item.Items.AddRange(New Object() {"haircut ", "Threading", "spa", "smoothning", "pedicure ", "manicure", "facial", "bleach", "ear peirsing", "waxing"})
        Me.cmb_item.Location = New System.Drawing.Point(178, 232)
        Me.cmb_item.Name = "cmb_item"
        Me.cmb_item.Size = New System.Drawing.Size(202, 23)
        Me.cmb_item.TabIndex = 118
        '
        'txt_discount
        '
        Me.txt_discount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_discount.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_discount.ForeColor = System.Drawing.Color.Black
        Me.txt_discount.Location = New System.Drawing.Point(178, 351)
        Me.txt_discount.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_discount.Multiline = True
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Size = New System.Drawing.Size(202, 20)
        Me.txt_discount.TabIndex = 117
        '
        'Lbl_grd
        '
        Me.Lbl_grd.AutoSize = True
        Me.Lbl_grd.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_grd.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_grd.ForeColor = System.Drawing.Color.White
        Me.Lbl_grd.Location = New System.Drawing.Point(38, 233)
        Me.Lbl_grd.Name = "Lbl_grd"
        Me.Lbl_grd.Size = New System.Drawing.Size(83, 20)
        Me.Lbl_grd.TabIndex = 110
        Me.Lbl_grd.Text = "Grid Items"
        '
        'Lbl_phno
        '
        Me.Lbl_phno.AutoSize = True
        Me.Lbl_phno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_phno.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_phno.ForeColor = System.Drawing.Color.White
        Me.Lbl_phno.Location = New System.Drawing.Point(38, 407)
        Me.Lbl_phno.Name = "Lbl_phno"
        Me.Lbl_phno.Size = New System.Drawing.Size(81, 20)
        Me.Lbl_phno.TabIndex = 109
        Me.Lbl_phno.Text = "Phone No"
        '
        'Lbl_dis
        '
        Me.Lbl_dis.AutoSize = True
        Me.Lbl_dis.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_dis.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dis.ForeColor = System.Drawing.Color.White
        Me.Lbl_dis.Location = New System.Drawing.Point(38, 349)
        Me.Lbl_dis.Name = "Lbl_dis"
        Me.Lbl_dis.Size = New System.Drawing.Size(72, 20)
        Me.Lbl_dis.TabIndex = 108
        Me.Lbl_dis.Text = "Discount"
        '
        'Lbl_trate
        '
        Me.Lbl_trate.AutoSize = True
        Me.Lbl_trate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_trate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_trate.ForeColor = System.Drawing.Color.White
        Me.Lbl_trate.Location = New System.Drawing.Point(38, 291)
        Me.Lbl_trate.Name = "Lbl_trate"
        Me.Lbl_trate.Size = New System.Drawing.Size(80, 20)
        Me.Lbl_trate.TabIndex = 107
        Me.Lbl_trate.Text = "Total Rate"
        '
        'Lbl_rgno
        '
        Me.Lbl_rgno.AutoSize = True
        Me.Lbl_rgno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_rgno.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rgno.ForeColor = System.Drawing.Color.White
        Me.Lbl_rgno.Location = New System.Drawing.Point(38, 175)
        Me.Lbl_rgno.Name = "Lbl_rgno"
        Me.Lbl_rgno.Size = New System.Drawing.Size(92, 20)
        Me.Lbl_rgno.TabIndex = 106
        Me.Lbl_rgno.Text = "Register No"
        '
        'Lbl_stfid
        '
        Me.Lbl_stfid.AutoSize = True
        Me.Lbl_stfid.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_stfid.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_stfid.ForeColor = System.Drawing.Color.White
        Me.Lbl_stfid.Location = New System.Drawing.Point(38, 117)
        Me.Lbl_stfid.Name = "Lbl_stfid"
        Me.Lbl_stfid.Size = New System.Drawing.Size(61, 20)
        Me.Lbl_stfid.TabIndex = 105
        Me.Lbl_stfid.Text = "Staff ID"
        '
        'txt_phone
        '
        Me.txt_phone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_phone.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.ForeColor = System.Drawing.Color.Black
        Me.txt_phone.Location = New System.Drawing.Point(178, 408)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_phone.Multiline = True
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(202, 20)
        Me.txt_phone.TabIndex = 104
        '
        'Txt_id
        '
        Me.Txt_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_id.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_id.ForeColor = System.Drawing.Color.Black
        Me.Txt_id.Location = New System.Drawing.Point(178, 118)
        Me.Txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_id.Multiline = True
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(202, 20)
        Me.Txt_id.TabIndex = 101
        '
        'txt_total
        '
        Me.txt_total.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_total.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.ForeColor = System.Drawing.Color.Black
        Me.txt_total.Location = New System.Drawing.Point(178, 294)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total.Multiline = True
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(202, 20)
        Me.txt_total.TabIndex = 103
        '
        'Txt_registerno
        '
        Me.Txt_registerno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_registerno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_registerno.ForeColor = System.Drawing.Color.Black
        Me.Txt_registerno.Location = New System.Drawing.Point(178, 175)
        Me.Txt_registerno.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_registerno.Multiline = True
        Me.Txt_registerno.Name = "Txt_registerno"
        Me.Txt_registerno.Size = New System.Drawing.Size(202, 20)
        Me.Txt_registerno.TabIndex = 102
        '
        'Btn_go
        '
        Me.Btn_go.BackColor = System.Drawing.Color.Transparent
        Me.Btn_go.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_go.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_go.ForeColor = System.Drawing.Color.Transparent
        Me.Btn_go.Location = New System.Drawing.Point(867, 136)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(58, 43)
        Me.Btn_go.TabIndex = 125
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = False
        '
        'txt_searchdata
        '
        Me.txt_searchdata.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_searchdata.ForeColor = System.Drawing.Color.Black
        Me.txt_searchdata.Location = New System.Drawing.Point(674, 184)
        Me.txt_searchdata.Name = "txt_searchdata"
        Me.txt_searchdata.Size = New System.Drawing.Size(153, 23)
        Me.txt_searchdata.TabIndex = 123
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sdata.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sdata.ForeColor = System.Drawing.Color.White
        Me.Lbl_sdata.Location = New System.Drawing.Point(550, 185)
        Me.Lbl_sdata.Name = "Lbl_sdata"
        Me.Lbl_sdata.Size = New System.Drawing.Size(99, 20)
        Me.Lbl_sdata.TabIndex = 122
        Me.Lbl_sdata.Text = "Search data"
        '
        'cbo_sby
        '
        Me.cbo_sby.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_sby.ForeColor = System.Drawing.Color.Black
        Me.cbo_sby.FormattingEnabled = True
        Me.cbo_sby.Items.AddRange(New Object() {"Staff ID", "Register No", "Grid Items", "Total Rate", "Discount", "Phone No"})
        Me.cbo_sby.Location = New System.Drawing.Point(674, 124)
        Me.cbo_sby.Name = "cbo_sby"
        Me.cbo_sby.Size = New System.Drawing.Size(153, 25)
        Me.cbo_sby.TabIndex = 120
        '
        'Lbl_sby
        '
        Me.Lbl_sby.AutoSize = True
        Me.Lbl_sby.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sby.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sby.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbl_sby.Location = New System.Drawing.Point(552, 127)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(81, 20)
        Me.Lbl_sby.TabIndex = 119
        Me.Lbl_sby.Text = "Search By"
        '
        'Btn_close
        '
        Me.Btn_close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_close.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.White
        Me.Btn_close.Location = New System.Drawing.Point(701, 486)
        Me.Btn_close.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(98, 44)
        Me.Btn_close.TabIndex = 127
        Me.Btn_close.Text = "Close"
        Me.Btn_close.UseVisualStyleBackColor = False
        '
        'Btn_search
        '
        Me.Btn_search.BackColor = System.Drawing.Color.Transparent
        Me.Btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_search.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_search.ForeColor = System.Drawing.Color.White
        Me.Btn_search.Location = New System.Drawing.Point(406, 250)
        Me.Btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(98, 44)
        Me.Btn_search.TabIndex = 128
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = False
        '
        'Btn_refresh
        '
        Me.Btn_refresh.BackColor = System.Drawing.Color.Transparent
        Me.Btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_refresh.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_refresh.ForeColor = System.Drawing.Color.White
        Me.Btn_refresh.Location = New System.Drawing.Point(406, 326)
        Me.Btn_refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_refresh.Name = "Btn_refresh"
        Me.Btn_refresh.Size = New System.Drawing.Size(98, 44)
        Me.Btn_refresh.TabIndex = 126
        Me.Btn_refresh.Text = "Refresh"
        Me.Btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(556, 486)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(98, 44)
        Me.btn_update.TabIndex = 131
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'lbl_billingreg
        '
        Me.lbl_billingreg.AutoSize = True
        Me.lbl_billingreg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_billingreg.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_billingreg.ForeColor = System.Drawing.Color.White
        Me.lbl_billingreg.Location = New System.Drawing.Point(376, 26)
        Me.lbl_billingreg.Name = "lbl_billingreg"
        Me.lbl_billingreg.Size = New System.Drawing.Size(143, 57)
        Me.lbl_billingreg.TabIndex = 132
        Me.lbl_billingreg.Text = "Billing"
        '
        'Dgv_bill
        '
        Me.Dgv_bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_bill.Location = New System.Drawing.Point(532, 222)
        Me.Dgv_bill.Name = "Dgv_bill"
        Me.Dgv_bill.Size = New System.Drawing.Size(420, 217)
        Me.Dgv_bill.TabIndex = 133
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(406, 183)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(98, 44)
        Me.btn_save.TabIndex = 134
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(830, 486)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(95, 43)
        Me.btn_delete.TabIndex = 135
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'frm_billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.regwall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(964, 560)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Dgv_bill)
        Me.Controls.Add(Me.lbl_billingreg)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.Btn_refresh)
        Me.Controls.Add(Me.Btn_go)
        Me.Controls.Add(Me.txt_searchdata)
        Me.Controls.Add(Me.Lbl_sdata)
        Me.Controls.Add(Me.cbo_sby)
        Me.Controls.Add(Me.Lbl_sby)
        Me.Controls.Add(Me.cmb_item)
        Me.Controls.Add(Me.txt_discount)
        Me.Controls.Add(Me.Lbl_stfid)
        Me.Controls.Add(Me.Txt_registerno)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Txt_id)
        Me.Controls.Add(Me.Lbl_grd)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.Lbl_phno)
        Me.Controls.Add(Me.Lbl_rgno)
        Me.Controls.Add(Me.Lbl_dis)
        Me.Controls.Add(Me.Lbl_trate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_billing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Registration"
        CType(Me.Dgv_bill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_item As System.Windows.Forms.ComboBox
    Friend WithEvents txt_discount As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_grd As System.Windows.Forms.Label
    Friend WithEvents Lbl_phno As System.Windows.Forms.Label
    Friend WithEvents Lbl_dis As System.Windows.Forms.Label
    Friend WithEvents Lbl_trate As System.Windows.Forms.Label
    Friend WithEvents Lbl_rgno As System.Windows.Forms.Label
    Friend WithEvents Lbl_stfid As System.Windows.Forms.Label
    Friend WithEvents txt_phone As System.Windows.Forms.TextBox
    Friend WithEvents Txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Txt_registerno As System.Windows.Forms.TextBox
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents txt_searchdata As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents cbo_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents Btn_search As System.Windows.Forms.Button
    Friend WithEvents Btn_refresh As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents lbl_billingreg As System.Windows.Forms.Label
    Friend WithEvents Dgv_bill As System.Windows.Forms.DataGridView
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
End Class
