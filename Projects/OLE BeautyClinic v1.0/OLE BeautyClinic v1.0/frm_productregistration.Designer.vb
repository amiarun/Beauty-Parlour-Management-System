<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productregistration
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
        Me.btn_save = New System.Windows.Forms.Button
        Me.Btn_close = New System.Windows.Forms.Button
        Me.Btn_refresh = New System.Windows.Forms.Button
        Me.Btn_search = New System.Windows.Forms.Button
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.txt_itemname = New System.Windows.Forms.TextBox
        Me.txt_registerno = New System.Windows.Forms.TextBox
        Me.txt_code = New System.Windows.Forms.TextBox
        Me.txt_company = New System.Windows.Forms.TextBox
        Me.txt_rate = New System.Windows.Forms.TextBox
        Me.cbo_category = New System.Windows.Forms.ComboBox
        Me.dtp_expiery = New System.Windows.Forms.DateTimePicker
        Me.txt_sales = New System.Windows.Forms.TextBox
        Me.txt_mrp = New System.Windows.Forms.TextBox
        Me.Lbl_cate = New System.Windows.Forms.Label
        Me.Lbl_phno = New System.Windows.Forms.Label
        Me.Lbl_dist = New System.Windows.Forms.Label
        Me.Lbl_pincode = New System.Windows.Forms.Label
        Me.Lbl_post = New System.Windows.Forms.Label
        Me.Lbl_hname = New System.Windows.Forms.Label
        Me.Lbl_dob = New System.Windows.Forms.Label
        Me.Lbl_name = New System.Windows.Forms.Label
        Me.Lbl_regno = New System.Windows.Forms.Label
        Me.Lbl_id = New System.Windows.Forms.Label
        Me.Btn_go = New System.Windows.Forms.Button
        Me.Txt_data = New System.Windows.Forms.TextBox
        Me.Lbl_data = New System.Windows.Forms.Label
        Me.Cmb_searchby = New System.Windows.Forms.ComboBox
        Me.Lbl_searb = New System.Windows.Forms.Label
        Me.btn_update = New System.Windows.Forms.Button
        Me.dgv_productreg = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_delete = New System.Windows.Forms.Button
        CType(Me.dgv_productreg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(422, 261)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(112, 35)
        Me.btn_save.TabIndex = 83
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
        Me.Btn_close.Location = New System.Drawing.Point(422, 435)
        Me.Btn_close.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(112, 35)
        Me.Btn_close.TabIndex = 82
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
        Me.Btn_refresh.Location = New System.Drawing.Point(422, 323)
        Me.Btn_refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_refresh.Name = "Btn_refresh"
        Me.Btn_refresh.Size = New System.Drawing.Size(112, 35)
        Me.Btn_refresh.TabIndex = 81
        Me.Btn_refresh.Text = "Refresh"
        Me.Btn_refresh.UseVisualStyleBackColor = False
        '
        'Btn_search
        '
        Me.Btn_search.BackColor = System.Drawing.Color.Transparent
        Me.Btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_search.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_search.ForeColor = System.Drawing.Color.White
        Me.Btn_search.Location = New System.Drawing.Point(422, 385)
        Me.Btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(112, 35)
        Me.Btn_search.TabIndex = 80
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = False
        '
        'txt_id
        '
        Me.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.Black
        Me.txt_id.Location = New System.Drawing.Point(190, 128)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(210, 22)
        Me.txt_id.TabIndex = 148
        '
        'txt_itemname
        '
        Me.txt_itemname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_itemname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemname.ForeColor = System.Drawing.Color.Black
        Me.txt_itemname.Location = New System.Drawing.Point(190, 233)
        Me.txt_itemname.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_itemname.Name = "txt_itemname"
        Me.txt_itemname.Size = New System.Drawing.Size(210, 22)
        Me.txt_itemname.TabIndex = 147
        '
        'txt_registerno
        '
        Me.txt_registerno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_registerno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_registerno.ForeColor = System.Drawing.Color.Black
        Me.txt_registerno.Location = New System.Drawing.Point(190, 183)
        Me.txt_registerno.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_registerno.Name = "txt_registerno"
        Me.txt_registerno.Size = New System.Drawing.Size(210, 22)
        Me.txt_registerno.TabIndex = 146
        '
        'txt_code
        '
        Me.txt_code.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_code.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.ForeColor = System.Drawing.Color.Black
        Me.txt_code.Location = New System.Drawing.Point(190, 600)
        Me.txt_code.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(210, 22)
        Me.txt_code.TabIndex = 145
        '
        'txt_company
        '
        Me.txt_company.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_company.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_company.ForeColor = System.Drawing.Color.Black
        Me.txt_company.Location = New System.Drawing.Point(190, 548)
        Me.txt_company.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_company.Name = "txt_company"
        Me.txt_company.Size = New System.Drawing.Size(210, 22)
        Me.txt_company.TabIndex = 144
        '
        'txt_rate
        '
        Me.txt_rate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_rate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rate.ForeColor = System.Drawing.Color.Black
        Me.txt_rate.Location = New System.Drawing.Point(190, 332)
        Me.txt_rate.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_rate.Name = "txt_rate"
        Me.txt_rate.Size = New System.Drawing.Size(210, 22)
        Me.txt_rate.TabIndex = 143
        '
        'cbo_category
        '
        Me.cbo_category.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cbo_category.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_category.ForeColor = System.Drawing.Color.Black
        Me.cbo_category.FormattingEnabled = True
        Me.cbo_category.Location = New System.Drawing.Point(190, 383)
        Me.cbo_category.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_category.Name = "cbo_category"
        Me.cbo_category.Size = New System.Drawing.Size(210, 23)
        Me.cbo_category.TabIndex = 132
        '
        'dtp_expiery
        '
        Me.dtp_expiery.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtp_expiery.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_expiery.Location = New System.Drawing.Point(190, 284)
        Me.dtp_expiery.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_expiery.Name = "dtp_expiery"
        Me.dtp_expiery.Size = New System.Drawing.Size(210, 22)
        Me.dtp_expiery.TabIndex = 131
        '
        'txt_sales
        '
        Me.txt_sales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_sales.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sales.ForeColor = System.Drawing.Color.Black
        Me.txt_sales.Location = New System.Drawing.Point(190, 495)
        Me.txt_sales.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_sales.Name = "txt_sales"
        Me.txt_sales.Size = New System.Drawing.Size(210, 22)
        Me.txt_sales.TabIndex = 130
        '
        'txt_mrp
        '
        Me.txt_mrp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_mrp.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mrp.ForeColor = System.Drawing.Color.Black
        Me.txt_mrp.Location = New System.Drawing.Point(190, 434)
        Me.txt_mrp.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mrp.Name = "txt_mrp"
        Me.txt_mrp.Size = New System.Drawing.Size(210, 22)
        Me.txt_mrp.TabIndex = 129
        '
        'Lbl_cate
        '
        Me.Lbl_cate.AutoSize = True
        Me.Lbl_cate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_cate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_cate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_cate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_cate.Location = New System.Drawing.Point(21, 387)
        Me.Lbl_cate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_cate.Name = "Lbl_cate"
        Me.Lbl_cate.Size = New System.Drawing.Size(69, 17)
        Me.Lbl_cate.TabIndex = 128
        Me.Lbl_cate.Text = "Category"
        '
        'Lbl_phno
        '
        Me.Lbl_phno.AutoSize = True
        Me.Lbl_phno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_phno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_phno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_phno.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_phno.Location = New System.Drawing.Point(21, 597)
        Me.Lbl_phno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_phno.Name = "Lbl_phno"
        Me.Lbl_phno.Size = New System.Drawing.Size(45, 17)
        Me.Lbl_phno.TabIndex = 127
        Me.Lbl_phno.Text = "Code"
        '
        'Lbl_dist
        '
        Me.Lbl_dist.AutoSize = True
        Me.Lbl_dist.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_dist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_dist.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dist.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_dist.Location = New System.Drawing.Point(21, 553)
        Me.Lbl_dist.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_dist.Name = "Lbl_dist"
        Me.Lbl_dist.Size = New System.Drawing.Size(117, 17)
        Me.Lbl_dist.TabIndex = 126
        Me.Lbl_dist.Text = "Company Name"
        '
        'Lbl_pincode
        '
        Me.Lbl_pincode.AutoSize = True
        Me.Lbl_pincode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_pincode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_pincode.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_pincode.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_pincode.Location = New System.Drawing.Point(21, 501)
        Me.Lbl_pincode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_pincode.Name = "Lbl_pincode"
        Me.Lbl_pincode.Size = New System.Drawing.Size(73, 17)
        Me.Lbl_pincode.TabIndex = 125
        Me.Lbl_pincode.Text = "Sales Rate"
        '
        'Lbl_post
        '
        Me.Lbl_post.AutoSize = True
        Me.Lbl_post.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_post.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_post.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_post.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_post.Location = New System.Drawing.Point(21, 448)
        Me.Lbl_post.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_post.Name = "Lbl_post"
        Me.Lbl_post.Size = New System.Drawing.Size(35, 17)
        Me.Lbl_post.TabIndex = 124
        Me.Lbl_post.Text = "MRP"
        '
        'Lbl_hname
        '
        Me.Lbl_hname.AutoSize = True
        Me.Lbl_hname.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_hname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_hname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_hname.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_hname.Location = New System.Drawing.Point(21, 339)
        Me.Lbl_hname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_hname.Name = "Lbl_hname"
        Me.Lbl_hname.Size = New System.Drawing.Size(38, 17)
        Me.Lbl_hname.TabIndex = 123
        Me.Lbl_hname.Text = "Rate"
        '
        'Lbl_dob
        '
        Me.Lbl_dob.AutoSize = True
        Me.Lbl_dob.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_dob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_dob.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dob.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_dob.Location = New System.Drawing.Point(21, 285)
        Me.Lbl_dob.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_dob.Name = "Lbl_dob"
        Me.Lbl_dob.Size = New System.Drawing.Size(87, 17)
        Me.Lbl_dob.TabIndex = 122
        Me.Lbl_dob.Text = "Expiery Date"
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_name.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_name.Location = New System.Drawing.Point(21, 237)
        Me.Lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(81, 17)
        Me.Lbl_name.TabIndex = 121
        Me.Lbl_name.Text = "Item Name"
        '
        'Lbl_regno
        '
        Me.Lbl_regno.AutoSize = True
        Me.Lbl_regno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_regno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_regno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_regno.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_regno.Location = New System.Drawing.Point(21, 185)
        Me.Lbl_regno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_regno.Name = "Lbl_regno"
        Me.Lbl_regno.Size = New System.Drawing.Size(79, 17)
        Me.Lbl_regno.TabIndex = 120
        Me.Lbl_regno.Text = "Register no"
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id.ForeColor = System.Drawing.Color.White
        Me.Lbl_id.Location = New System.Drawing.Point(21, 129)
        Me.Lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(21, 17)
        Me.Lbl_id.TabIndex = 119
        Me.Lbl_id.Text = "ID"
        '
        'Btn_go
        '
        Me.Btn_go.BackColor = System.Drawing.Color.Transparent
        Me.Btn_go.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_go.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_go.ForeColor = System.Drawing.Color.White
        Me.Btn_go.Location = New System.Drawing.Point(913, 129)
        Me.Btn_go.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(79, 47)
        Me.Btn_go.TabIndex = 153
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = False
        '
        'Txt_data
        '
        Me.Txt_data.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_data.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_data.ForeColor = System.Drawing.Color.Black
        Me.Txt_data.Location = New System.Drawing.Point(706, 162)
        Me.Txt_data.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_data.Multiline = True
        Me.Txt_data.Name = "Txt_data"
        Me.Txt_data.Size = New System.Drawing.Size(187, 33)
        Me.Txt_data.TabIndex = 152
        '
        'Lbl_data
        '
        Me.Lbl_data.AutoSize = True
        Me.Lbl_data.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_data.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_data.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_data.Location = New System.Drawing.Point(586, 172)
        Me.Lbl_data.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_data.Name = "Lbl_data"
        Me.Lbl_data.Size = New System.Drawing.Size(100, 20)
        Me.Lbl_data.TabIndex = 151
        Me.Lbl_data.Text = "Search Data"
        '
        'Cmb_searchby
        '
        Me.Cmb_searchby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cmb_searchby.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_searchby.ForeColor = System.Drawing.Color.Black
        Me.Cmb_searchby.FormattingEnabled = True
        Me.Cmb_searchby.Items.AddRange(New Object() {"id", "register no", "item name", "expiery date", "rate", "category", "mrp", "sales rate", "company name", "code"})
        Me.Cmb_searchby.Location = New System.Drawing.Point(706, 119)
        Me.Cmb_searchby.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmb_searchby.Name = "Cmb_searchby"
        Me.Cmb_searchby.Size = New System.Drawing.Size(187, 23)
        Me.Cmb_searchby.TabIndex = 150
        '
        'Lbl_searb
        '
        Me.Lbl_searb.AutoSize = True
        Me.Lbl_searb.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_searb.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_searb.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_searb.Location = New System.Drawing.Point(587, 127)
        Me.Lbl_searb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_searb.Name = "Lbl_searb"
        Me.Lbl_searb.Size = New System.Drawing.Size(81, 20)
        Me.Lbl_searb.TabIndex = 149
        Me.Lbl_searb.Text = "Search By"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(632, 565)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(112, 35)
        Me.btn_update.TabIndex = 80
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'dgv_productreg
        '
        Me.dgv_productreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_productreg.Location = New System.Drawing.Point(572, 217)
        Me.dgv_productreg.Name = "dgv_productreg"
        Me.dgv_productreg.Size = New System.Drawing.Size(460, 321)
        Me.dgv_productreg.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(287, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 57)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "Product Registration"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(783, 565)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(112, 35)
        Me.btn_delete.TabIndex = 156
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'frm_productregistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.regwall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1045, 643)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_productreg)
        Me.Controls.Add(Me.Btn_go)
        Me.Controls.Add(Me.Txt_data)
        Me.Controls.Add(Me.Lbl_data)
        Me.Controls.Add(Me.Cmb_searchby)
        Me.Controls.Add(Me.Lbl_searb)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_itemname)
        Me.Controls.Add(Me.txt_registerno)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.txt_company)
        Me.Controls.Add(Me.txt_rate)
        Me.Controls.Add(Me.cbo_category)
        Me.Controls.Add(Me.dtp_expiery)
        Me.Controls.Add(Me.txt_sales)
        Me.Controls.Add(Me.txt_mrp)
        Me.Controls.Add(Me.Lbl_cate)
        Me.Controls.Add(Me.Lbl_phno)
        Me.Controls.Add(Me.Lbl_dist)
        Me.Controls.Add(Me.Lbl_pincode)
        Me.Controls.Add(Me.Lbl_post)
        Me.Controls.Add(Me.Lbl_hname)
        Me.Controls.Add(Me.Lbl_dob)
        Me.Controls.Add(Me.Lbl_name)
        Me.Controls.Add(Me.Lbl_regno)
        Me.Controls.Add(Me.Lbl_id)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.Btn_refresh)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Btn_search)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_productregistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Registartion"
        CType(Me.dgv_productreg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dgv_product_registration As System.Windows.Forms.DataGridView
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents Btn_refresh As System.Windows.Forms.Button
    Friend WithEvents Btn_search As System.Windows.Forms.Button
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_itemname As System.Windows.Forms.TextBox
    Friend WithEvents txt_registerno As System.Windows.Forms.TextBox
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents txt_company As System.Windows.Forms.TextBox
    Friend WithEvents txt_rate As System.Windows.Forms.TextBox
    Friend WithEvents cbo_category As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_expiery As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_sales As System.Windows.Forms.TextBox
    Friend WithEvents txt_mrp As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_cate As System.Windows.Forms.Label
    Friend WithEvents Lbl_phno As System.Windows.Forms.Label
    Friend WithEvents Lbl_dist As System.Windows.Forms.Label
    Friend WithEvents Lbl_pincode As System.Windows.Forms.Label
    Friend WithEvents Lbl_post As System.Windows.Forms.Label
    Friend WithEvents Lbl_hname As System.Windows.Forms.Label
    Friend WithEvents Lbl_dob As System.Windows.Forms.Label
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents Lbl_regno As System.Windows.Forms.Label
    Friend WithEvents Lbl_id As System.Windows.Forms.Label
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents Txt_data As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_data As System.Windows.Forms.Label
    Friend WithEvents Cmb_searchby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_searb As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents dgv_productreg As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    
End Class
