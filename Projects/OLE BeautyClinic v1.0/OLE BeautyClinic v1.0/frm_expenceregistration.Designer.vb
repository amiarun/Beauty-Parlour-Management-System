<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_expenceregistration
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
        Me.btn_go = New System.Windows.Forms.Button
        Me.Txt_data = New System.Windows.Forms.TextBox
        Me.Lbl_data = New System.Windows.Forms.Label
        Me.Cmb_searchby = New System.Windows.Forms.ComboBox
        Me.Lbl_searb = New System.Windows.Forms.Label
        Me.txt_amount = New System.Windows.Forms.TextBox
        Me.txt_particular = New System.Windows.Forms.TextBox
        Me.Lbl_regno = New System.Windows.Forms.Label
        Me.Lbl_name = New System.Windows.Forms.Label
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.Lbl_id = New System.Windows.Forms.Label
        Me.dtp_date = New System.Windows.Forms.DateTimePicker
        Me.Lbl_dob = New System.Windows.Forms.Label
        Me.btn_save = New System.Windows.Forms.Button
        Me.Btn_search = New System.Windows.Forms.Button
        Me.Btn_close = New System.Windows.Forms.Button
        Me.Btn_refresh = New System.Windows.Forms.Button
        Me.dgv_expence = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        CType(Me.dgv_expence, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_go
        '
        Me.btn_go.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_go.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_go.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_go.ForeColor = System.Drawing.Color.White
        Me.btn_go.Location = New System.Drawing.Point(938, 162)
        Me.btn_go.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(72, 33)
        Me.btn_go.TabIndex = 153
        Me.btn_go.Text = "GO"
        Me.btn_go.UseVisualStyleBackColor = False
        '
        'Txt_data
        '
        Me.Txt_data.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_data.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_data.ForeColor = System.Drawing.Color.Black
        Me.Txt_data.Location = New System.Drawing.Point(715, 187)
        Me.Txt_data.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_data.Name = "Txt_data"
        Me.Txt_data.Size = New System.Drawing.Size(201, 22)
        Me.Txt_data.TabIndex = 152
        '
        'Lbl_data
        '
        Me.Lbl_data.AutoSize = True
        Me.Lbl_data.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_data.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_data.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_data.Location = New System.Drawing.Point(544, 192)
        Me.Lbl_data.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_data.Name = "Lbl_data"
        Me.Lbl_data.Size = New System.Drawing.Size(88, 17)
        Me.Lbl_data.TabIndex = 151
        Me.Lbl_data.Text = "Search Data"
        '
        'Cmb_searchby
        '
        Me.Cmb_searchby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cmb_searchby.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_searchby.ForeColor = System.Drawing.Color.Black
        Me.Cmb_searchby.FormattingEnabled = True
        Me.Cmb_searchby.Items.AddRange(New Object() {"id", "particular", "amount", "date"})
        Me.Cmb_searchby.Location = New System.Drawing.Point(715, 144)
        Me.Cmb_searchby.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmb_searchby.Name = "Cmb_searchby"
        Me.Cmb_searchby.Size = New System.Drawing.Size(201, 23)
        Me.Cmb_searchby.TabIndex = 150
        '
        'Lbl_searb
        '
        Me.Lbl_searb.AutoSize = True
        Me.Lbl_searb.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_searb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_searb.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_searb.Location = New System.Drawing.Point(544, 145)
        Me.Lbl_searb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_searb.Name = "Lbl_searb"
        Me.Lbl_searb.Size = New System.Drawing.Size(68, 17)
        Me.Lbl_searb.TabIndex = 149
        Me.Lbl_searb.Text = "Search By"
        '
        'txt_amount
        '
        Me.txt_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_amount.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount.ForeColor = System.Drawing.Color.Black
        Me.txt_amount.Location = New System.Drawing.Point(203, 300)
        Me.txt_amount.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(249, 22)
        Me.txt_amount.TabIndex = 182
        '
        'txt_particular
        '
        Me.txt_particular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_particular.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_particular.ForeColor = System.Drawing.Color.Black
        Me.txt_particular.Location = New System.Drawing.Point(202, 248)
        Me.txt_particular.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_particular.Name = "txt_particular"
        Me.txt_particular.Size = New System.Drawing.Size(249, 22)
        Me.txt_particular.TabIndex = 181
        '
        'Lbl_regno
        '
        Me.Lbl_regno.AutoSize = True
        Me.Lbl_regno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_regno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_regno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_regno.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_regno.Location = New System.Drawing.Point(56, 253)
        Me.Lbl_regno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_regno.Name = "Lbl_regno"
        Me.Lbl_regno.Size = New System.Drawing.Size(69, 17)
        Me.Lbl_regno.TabIndex = 185
        Me.Lbl_regno.Text = "Particular"
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_name.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_name.Location = New System.Drawing.Point(56, 305)
        Me.Lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(60, 17)
        Me.Lbl_name.TabIndex = 186
        Me.Lbl_name.Text = "Amount"
        '
        'txt_id
        '
        Me.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.Black
        Me.txt_id.Location = New System.Drawing.Point(203, 196)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(249, 22)
        Me.txt_id.TabIndex = 183
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id.ForeColor = System.Drawing.Color.White
        Me.Lbl_id.Location = New System.Drawing.Point(56, 198)
        Me.Lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(21, 17)
        Me.Lbl_id.TabIndex = 184
        Me.Lbl_id.Text = "ID"
        '
        'dtp_date
        '
        Me.dtp_date.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dtp_date.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date.Location = New System.Drawing.Point(203, 352)
        Me.dtp_date.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(249, 22)
        Me.dtp_date.TabIndex = 180
        '
        'Lbl_dob
        '
        Me.Lbl_dob.AutoSize = True
        Me.Lbl_dob.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_dob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_dob.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dob.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_dob.Location = New System.Drawing.Point(56, 357)
        Me.Lbl_dob.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_dob.Name = "Lbl_dob"
        Me.Lbl_dob.Size = New System.Drawing.Size(40, 17)
        Me.Lbl_dob.TabIndex = 187
        Me.Lbl_dob.Text = "Date"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(84, 511)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(112, 35)
        Me.btn_save.TabIndex = 193
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Btn_search
        '
        Me.Btn_search.BackColor = System.Drawing.Color.Transparent
        Me.Btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_search.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_search.ForeColor = System.Drawing.Color.White
        Me.Btn_search.Location = New System.Drawing.Point(213, 511)
        Me.Btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(112, 35)
        Me.Btn_search.TabIndex = 192
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = False
        '
        'Btn_close
        '
        Me.Btn_close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_close.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.White
        Me.Btn_close.Location = New System.Drawing.Point(715, 511)
        Me.Btn_close.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(112, 31)
        Me.Btn_close.TabIndex = 195
        Me.Btn_close.Text = "Close"
        Me.Btn_close.UseVisualStyleBackColor = False
        '
        'Btn_refresh
        '
        Me.Btn_refresh.BackColor = System.Drawing.Color.Transparent
        Me.Btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_refresh.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_refresh.ForeColor = System.Drawing.Color.White
        Me.Btn_refresh.Location = New System.Drawing.Point(339, 511)
        Me.Btn_refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_refresh.Name = "Btn_refresh"
        Me.Btn_refresh.Size = New System.Drawing.Size(112, 35)
        Me.Btn_refresh.TabIndex = 194
        Me.Btn_refresh.Text = "Refresh"
        Me.Btn_refresh.UseVisualStyleBackColor = False
        '
        'dgv_expence
        '
        Me.dgv_expence.BackgroundColor = System.Drawing.Color.White
        Me.dgv_expence.Location = New System.Drawing.Point(537, 239)
        Me.dgv_expence.Name = "dgv_expence"
        Me.dgv_expence.Size = New System.Drawing.Size(474, 179)
        Me.dgv_expence.TabIndex = 196
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(429, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 57)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "Expence"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(473, 509)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(101, 36)
        Me.btn_update.TabIndex = 198
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(588, 507)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(99, 37)
        Me.btn_delete.TabIndex = 199
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'frm_expenceregistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.regwall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1050, 586)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_expence)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.Btn_refresh)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.txt_particular)
        Me.Controls.Add(Me.Lbl_regno)
        Me.Controls.Add(Me.Lbl_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Lbl_id)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.Lbl_dob)
        Me.Controls.Add(Me.btn_go)
        Me.Controls.Add(Me.Txt_data)
        Me.Controls.Add(Me.Lbl_data)
        Me.Controls.Add(Me.Cmb_searchby)
        Me.Controls.Add(Me.Lbl_searb)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_expenceregistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expence Registration"
        CType(Me.dgv_expence, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents Txt_data As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_data As System.Windows.Forms.Label
    Friend WithEvents Cmb_searchby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_searb As System.Windows.Forms.Label
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents txt_particular As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_regno As System.Windows.Forms.Label
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_id As System.Windows.Forms.Label
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_dob As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Btn_search As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents Btn_refresh As System.Windows.Forms.Button
    Friend WithEvents dgv_expence As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
End Class
