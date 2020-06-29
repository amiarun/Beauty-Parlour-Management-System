<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cashbook
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.dtp_date = New System.Windows.Forms.DateTimePicker
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.Lbl_dob = New System.Windows.Forms.Label
        Me.Lbl_name = New System.Windows.Forms.Label
        Me.txt_particular = New System.Windows.Forms.TextBox
        Me.lbl_type = New System.Windows.Forms.Label
        Me.Lbl_id = New System.Windows.Forms.Label
        Me.cbo_type = New System.Windows.Forms.ComboBox
        Me.Lbl_regno = New System.Windows.Forms.Label
        Me.txt_amount = New System.Windows.Forms.TextBox
        Me.btn_go = New System.Windows.Forms.Button
        Me.Txt_data = New System.Windows.Forms.TextBox
        Me.Lbl_data = New System.Windows.Forms.Label
        Me.Cbo_searchby = New System.Windows.Forms.ComboBox
        Me.Lbl_searb = New System.Windows.Forms.Label
        Me.Dgv_cashbook = New System.Windows.Forms.DataGridView
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_search = New System.Windows.Forms.Button
        Me.btn_refresh = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.Dgv_cashbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_date
        '
        Me.dtp_date.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtp_date.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_date.Location = New System.Drawing.Point(157, 315)
        Me.dtp_date.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(217, 22)
        Me.dtp_date.TabIndex = 131
        '
        'txt_id
        '
        Me.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.Black
        Me.txt_id.Location = New System.Drawing.Point(157, 159)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(217, 22)
        Me.txt_id.TabIndex = 134
        '
        'Lbl_dob
        '
        Me.Lbl_dob.AutoSize = True
        Me.Lbl_dob.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_dob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_dob.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dob.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_dob.Location = New System.Drawing.Point(39, 317)
        Me.Lbl_dob.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_dob.Name = "Lbl_dob"
        Me.Lbl_dob.Size = New System.Drawing.Size(40, 17)
        Me.Lbl_dob.TabIndex = 138
        Me.Lbl_dob.Text = "Date"
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_name.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_name.Location = New System.Drawing.Point(39, 265)
        Me.Lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(60, 17)
        Me.Lbl_name.TabIndex = 137
        Me.Lbl_name.Text = "Amount"
        '
        'txt_particular
        '
        Me.txt_particular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_particular.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_particular.ForeColor = System.Drawing.Color.Black
        Me.txt_particular.Location = New System.Drawing.Point(157, 211)
        Me.txt_particular.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_particular.Name = "txt_particular"
        Me.txt_particular.Size = New System.Drawing.Size(217, 22)
        Me.txt_particular.TabIndex = 132
        '
        'lbl_type
        '
        Me.lbl_type.AutoSize = True
        Me.lbl_type.BackColor = System.Drawing.Color.Transparent
        Me.lbl_type.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_type.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_type.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lbl_type.Location = New System.Drawing.Point(39, 369)
        Me.lbl_type.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_type.Name = "lbl_type"
        Me.lbl_type.Size = New System.Drawing.Size(36, 17)
        Me.lbl_type.TabIndex = 139
        Me.lbl_type.Text = "Type"
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id.ForeColor = System.Drawing.Color.White
        Me.Lbl_id.Location = New System.Drawing.Point(39, 160)
        Me.Lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(21, 17)
        Me.Lbl_id.TabIndex = 135
        Me.Lbl_id.Text = "ID"
        '
        'cbo_type
        '
        Me.cbo_type.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cbo_type.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_type.ForeColor = System.Drawing.Color.Black
        Me.cbo_type.FormattingEnabled = True
        Me.cbo_type.Location = New System.Drawing.Point(157, 367)
        Me.cbo_type.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(217, 23)
        Me.cbo_type.TabIndex = 130
        '
        'Lbl_regno
        '
        Me.Lbl_regno.AutoSize = True
        Me.Lbl_regno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_regno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_regno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_regno.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_regno.Location = New System.Drawing.Point(39, 213)
        Me.Lbl_regno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_regno.Name = "Lbl_regno"
        Me.Lbl_regno.Size = New System.Drawing.Size(69, 17)
        Me.Lbl_regno.TabIndex = 136
        Me.Lbl_regno.Text = "Particular"
        '
        'txt_amount
        '
        Me.txt_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_amount.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount.ForeColor = System.Drawing.Color.Black
        Me.txt_amount.Location = New System.Drawing.Point(157, 263)
        Me.txt_amount.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(217, 22)
        Me.txt_amount.TabIndex = 133
        '
        'btn_go
        '
        Me.btn_go.BackColor = System.Drawing.Color.Transparent
        Me.btn_go.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_go.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_go.ForeColor = System.Drawing.Color.White
        Me.btn_go.Location = New System.Drawing.Point(754, 174)
        Me.btn_go.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(67, 43)
        Me.btn_go.TabIndex = 149
        Me.btn_go.Text = "GO"
        Me.btn_go.UseVisualStyleBackColor = False
        '
        'Txt_data
        '
        Me.Txt_data.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_data.ForeColor = System.Drawing.Color.Black
        Me.Txt_data.Location = New System.Drawing.Point(568, 206)
        Me.Txt_data.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_data.Multiline = True
        Me.Txt_data.Name = "Txt_data"
        Me.Txt_data.Size = New System.Drawing.Size(173, 25)
        Me.Txt_data.TabIndex = 148
        '
        'Lbl_data
        '
        Me.Lbl_data.AutoSize = True
        Me.Lbl_data.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_data.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_data.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_data.Location = New System.Drawing.Point(437, 214)
        Me.Lbl_data.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_data.Name = "Lbl_data"
        Me.Lbl_data.Size = New System.Drawing.Size(88, 17)
        Me.Lbl_data.TabIndex = 147
        Me.Lbl_data.Text = "Search Data"
        '
        'Cbo_searchby
        '
        Me.Cbo_searchby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cbo_searchby.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_searchby.ForeColor = System.Drawing.Color.Black
        Me.Cbo_searchby.FormattingEnabled = True
        Me.Cbo_searchby.Items.AddRange(New Object() {"id", "particular", "Amount", "Date", "Type"})
        Me.Cbo_searchby.Location = New System.Drawing.Point(568, 157)
        Me.Cbo_searchby.Margin = New System.Windows.Forms.Padding(2)
        Me.Cbo_searchby.Name = "Cbo_searchby"
        Me.Cbo_searchby.Size = New System.Drawing.Size(173, 21)
        Me.Cbo_searchby.TabIndex = 146
        '
        'Lbl_searb
        '
        Me.Lbl_searb.AutoSize = True
        Me.Lbl_searb.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_searb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_searb.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_searb.Location = New System.Drawing.Point(437, 162)
        Me.Lbl_searb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_searb.Name = "Lbl_searb"
        Me.Lbl_searb.Size = New System.Drawing.Size(68, 17)
        Me.Lbl_searb.TabIndex = 145
        Me.Lbl_searb.Text = "Search By"
        '
        'Dgv_cashbook
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_cashbook.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Dgv_cashbook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_cashbook.DefaultCellStyle = DataGridViewCellStyle6
        Me.Dgv_cashbook.Location = New System.Drawing.Point(411, 249)
        Me.Dgv_cashbook.Name = "Dgv_cashbook"
        Me.Dgv_cashbook.Size = New System.Drawing.Size(434, 142)
        Me.Dgv_cashbook.TabIndex = 152
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(546, 482)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(77, 39)
        Me.btn_delete.TabIndex = 158
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(340, 482)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(77, 39)
        Me.btn_update.TabIndex = 157
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(134, 482)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(77, 39)
        Me.btn_save.TabIndex = 156
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.Location = New System.Drawing.Point(649, 482)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(77, 39)
        Me.btn_close.TabIndex = 153
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Location = New System.Drawing.Point(443, 482)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(77, 39)
        Me.btn_search.TabIndex = 154
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.Transparent
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.Location = New System.Drawing.Point(237, 482)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(77, 39)
        Me.btn_refresh.TabIndex = 155
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(330, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 57)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "Cash Book"
        '
        'frm_cashbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.regwall
        Me.ClientSize = New System.Drawing.Size(857, 546)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Dgv_cashbook)
        Me.Controls.Add(Me.btn_go)
        Me.Controls.Add(Me.Txt_data)
        Me.Controls.Add(Me.Lbl_data)
        Me.Controls.Add(Me.Cbo_searchby)
        Me.Controls.Add(Me.Lbl_searb)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.Lbl_regno)
        Me.Controls.Add(Me.cbo_type)
        Me.Controls.Add(Me.Lbl_id)
        Me.Controls.Add(Me.lbl_type)
        Me.Controls.Add(Me.txt_particular)
        Me.Controls.Add(Me.Lbl_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.Lbl_dob)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_cashbook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash book"
        CType(Me.Dgv_cashbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParticularDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_dob As System.Windows.Forms.Label
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents txt_particular As System.Windows.Forms.TextBox
    Friend WithEvents lbl_type As System.Windows.Forms.Label
    Friend WithEvents Lbl_id As System.Windows.Forms.Label
    Friend WithEvents cbo_type As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_regno As System.Windows.Forms.Label
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents Txt_data As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_data As System.Windows.Forms.Label
    Friend WithEvents Cbo_searchby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_searb As System.Windows.Forms.Label
    Friend WithEvents Dgv_cashbook As System.Windows.Forms.DataGridView
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
