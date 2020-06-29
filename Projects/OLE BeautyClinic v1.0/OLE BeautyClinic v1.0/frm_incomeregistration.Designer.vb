<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_incomeregistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_incomeregistration))
        Me.btn_save = New System.Windows.Forms.Button
        Me.Btn_close = New System.Windows.Forms.Button
        Me.Btn_refresh = New System.Windows.Forms.Button
        Me.btn_search = New System.Windows.Forms.Button
        Me.txt_amount = New System.Windows.Forms.TextBox
        Me.txt_particular = New System.Windows.Forms.TextBox
        Me.Lbl_regno = New System.Windows.Forms.Label
        Me.Lbl_name = New System.Windows.Forms.Label
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.Lbl_id = New System.Windows.Forms.Label
        Me.dtp_date = New System.Windows.Forms.DateTimePicker
        Me.Lbl_dob = New System.Windows.Forms.Label
        Me.btn_go = New System.Windows.Forms.Button
        Me.Txt_data = New System.Windows.Forms.TextBox
        Me.Lbl_data = New System.Windows.Forms.Label
        Me.Cmb_searchby = New System.Windows.Forms.ComboBox
        Me.Lbl_searb = New System.Windows.Forms.Label
        Me.dgv_income = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        CType(Me.dgv_income, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(115, 482)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 30)
        Me.btn_save.TabIndex = 154
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Btn_close
        '
        Me.Btn_close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_close.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.White
        Me.Btn_close.Location = New System.Drawing.Point(680, 482)
        Me.Btn_close.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(96, 30)
        Me.Btn_close.TabIndex = 153
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
        Me.Btn_refresh.Location = New System.Drawing.Point(569, 482)
        Me.Btn_refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_refresh.Name = "Btn_refresh"
        Me.Btn_refresh.Size = New System.Drawing.Size(96, 30)
        Me.Btn_refresh.TabIndex = 152
        Me.Btn_refresh.Text = "Refresh"
        Me.Btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Location = New System.Drawing.Point(230, 482)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(96, 30)
        Me.btn_search.TabIndex = 151
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txt_amount
        '
        Me.txt_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_amount.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount.ForeColor = System.Drawing.Color.Black
        Me.txt_amount.Location = New System.Drawing.Point(175, 227)
        Me.txt_amount.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(181, 22)
        Me.txt_amount.TabIndex = 157
        '
        'txt_particular
        '
        Me.txt_particular.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_particular.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_particular.ForeColor = System.Drawing.Color.Black
        Me.txt_particular.Location = New System.Drawing.Point(174, 182)
        Me.txt_particular.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_particular.Name = "txt_particular"
        Me.txt_particular.Size = New System.Drawing.Size(181, 22)
        Me.txt_particular.TabIndex = 156
        '
        'Lbl_regno
        '
        Me.Lbl_regno.AutoSize = True
        Me.Lbl_regno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_regno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_regno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_regno.ForeColor = System.Drawing.Color.White
        Me.Lbl_regno.Location = New System.Drawing.Point(48, 186)
        Me.Lbl_regno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_regno.Name = "Lbl_regno"
        Me.Lbl_regno.Size = New System.Drawing.Size(69, 17)
        Me.Lbl_regno.TabIndex = 160
        Me.Lbl_regno.Text = "Particular"
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_name.ForeColor = System.Drawing.Color.White
        Me.Lbl_name.Location = New System.Drawing.Point(48, 231)
        Me.Lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(60, 17)
        Me.Lbl_name.TabIndex = 161
        Me.Lbl_name.Text = "Amount"
        '
        'txt_id
        '
        Me.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.Black
        Me.txt_id.Location = New System.Drawing.Point(175, 137)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(181, 22)
        Me.txt_id.TabIndex = 158
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id.ForeColor = System.Drawing.Color.White
        Me.Lbl_id.Location = New System.Drawing.Point(48, 139)
        Me.Lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(21, 17)
        Me.Lbl_id.TabIndex = 159
        Me.Lbl_id.Text = "ID"
        '
        'dtp_date
        '
        Me.dtp_date.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.dtp_date.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date.Location = New System.Drawing.Point(175, 272)
        Me.dtp_date.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(181, 22)
        Me.dtp_date.TabIndex = 155
        '
        'Lbl_dob
        '
        Me.Lbl_dob.AutoSize = True
        Me.Lbl_dob.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_dob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_dob.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dob.ForeColor = System.Drawing.Color.White
        Me.Lbl_dob.Location = New System.Drawing.Point(48, 273)
        Me.Lbl_dob.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_dob.Name = "Lbl_dob"
        Me.Lbl_dob.Size = New System.Drawing.Size(40, 17)
        Me.Lbl_dob.TabIndex = 162
        Me.Lbl_dob.Text = "Date"
        '
        'btn_go
        '
        Me.btn_go.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_go.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_go.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_go.ForeColor = System.Drawing.Color.White
        Me.btn_go.Location = New System.Drawing.Point(770, 148)
        Me.btn_go.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(67, 43)
        Me.btn_go.TabIndex = 171
        Me.btn_go.Text = "GO"
        Me.btn_go.UseVisualStyleBackColor = False
        '
        'Txt_data
        '
        Me.Txt_data.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_data.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_data.ForeColor = System.Drawing.Color.Black
        Me.Txt_data.Location = New System.Drawing.Point(569, 177)
        Me.Txt_data.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_data.Name = "Txt_data"
        Me.Txt_data.Size = New System.Drawing.Size(173, 22)
        Me.Txt_data.TabIndex = 170
        '
        'Lbl_data
        '
        Me.Lbl_data.AutoSize = True
        Me.Lbl_data.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_data.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_data.ForeColor = System.Drawing.Color.White
        Me.Lbl_data.Location = New System.Drawing.Point(454, 181)
        Me.Lbl_data.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_data.Name = "Lbl_data"
        Me.Lbl_data.Size = New System.Drawing.Size(88, 17)
        Me.Lbl_data.TabIndex = 169
        Me.Lbl_data.Text = "Search Data"
        '
        'Cmb_searchby
        '
        Me.Cmb_searchby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cmb_searchby.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_searchby.ForeColor = System.Drawing.Color.Black
        Me.Cmb_searchby.FormattingEnabled = True
        Me.Cmb_searchby.Items.AddRange(New Object() {"id", "particular", "amount", "date"})
        Me.Cmb_searchby.Location = New System.Drawing.Point(569, 130)
        Me.Cmb_searchby.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmb_searchby.Name = "Cmb_searchby"
        Me.Cmb_searchby.Size = New System.Drawing.Size(173, 23)
        Me.Cmb_searchby.TabIndex = 168
        '
        'Lbl_searb
        '
        Me.Lbl_searb.AutoSize = True
        Me.Lbl_searb.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_searb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_searb.ForeColor = System.Drawing.Color.White
        Me.Lbl_searb.Location = New System.Drawing.Point(454, 145)
        Me.Lbl_searb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_searb.Name = "Lbl_searb"
        Me.Lbl_searb.Size = New System.Drawing.Size(68, 17)
        Me.Lbl_searb.TabIndex = 167
        Me.Lbl_searb.Text = "Search By"
        '
        'dgv_income
        '
        Me.dgv_income.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_income.Location = New System.Drawing.Point(437, 227)
        Me.dgv_income.Name = "dgv_income"
        Me.dgv_income.Size = New System.Drawing.Size(435, 215)
        Me.dgv_income.TabIndex = 174
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(334, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 57)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Income "
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(457, 482)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(96, 30)
        Me.btn_delete.TabIndex = 176
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(339, 485)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(98, 27)
        Me.btn_update.TabIndex = 177
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'frm_incomeregistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(905, 547)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_income)
        Me.Controls.Add(Me.btn_go)
        Me.Controls.Add(Me.Txt_data)
        Me.Controls.Add(Me.Lbl_data)
        Me.Controls.Add(Me.Cmb_searchby)
        Me.Controls.Add(Me.Lbl_searb)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.txt_particular)
        Me.Controls.Add(Me.Lbl_regno)
        Me.Controls.Add(Me.Lbl_name)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Lbl_id)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.Lbl_dob)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.Btn_refresh)
        Me.Controls.Add(Me.btn_search)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_incomeregistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Income Registration"
        CType(Me.dgv_income, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents Btn_refresh As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents txt_particular As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_regno As System.Windows.Forms.Label
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_id As System.Windows.Forms.Label
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_dob As System.Windows.Forms.Label
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents Txt_data As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_data As System.Windows.Forms.Label
    Friend WithEvents Cmb_searchby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_searb As System.Windows.Forms.Label
    Friend WithEvents dgv_income As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
End Class
