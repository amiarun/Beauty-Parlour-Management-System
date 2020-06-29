<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customer_Registration
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
        Me.Cbo_category = New System.Windows.Forms.ComboBox
        Me.dtp_dob = New System.Windows.Forms.DateTimePicker
        Me.Txt_pincode = New System.Windows.Forms.TextBox
        Me.Txt_post = New System.Windows.Forms.TextBox
        Me.Txt_place = New System.Windows.Forms.TextBox
        Me.Lbl_cate = New System.Windows.Forms.Label
        Me.Lbl_phno = New System.Windows.Forms.Label
        Me.Lbl_dist = New System.Windows.Forms.Label
        Me.Lbl_pincode = New System.Windows.Forms.Label
        Me.Lbl_post = New System.Windows.Forms.Label
        Me.Lbl_place = New System.Windows.Forms.Label
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
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_refresh = New System.Windows.Forms.Button
        Me.btn_search = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.txt_hname = New System.Windows.Forms.TextBox
        Me.txt_phno = New System.Windows.Forms.TextBox
        Me.txt_regno = New System.Windows.Forms.TextBox
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.Dgv_customerregistration = New System.Windows.Forms.DataGridView
        Me.lbl_customerreg = New System.Windows.Forms.Label
        Me.cbo_district = New System.Windows.Forms.ComboBox
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        CType(Me.Dgv_customerregistration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cbo_category
        '
        Me.Cbo_category.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cbo_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_category.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_category.ForeColor = System.Drawing.Color.Black
        Me.Cbo_category.FormattingEnabled = True
        Me.Cbo_category.Location = New System.Drawing.Point(195, 501)
        Me.Cbo_category.Margin = New System.Windows.Forms.Padding(2)
        Me.Cbo_category.Name = "Cbo_category"
        Me.Cbo_category.Size = New System.Drawing.Size(208, 23)
        Me.Cbo_category.TabIndex = 57
        '
        'dtp_dob
        '
        Me.dtp_dob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtp_dob.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_dob.Location = New System.Drawing.Point(195, 247)
        Me.dtp_dob.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_dob.Name = "dtp_dob"
        Me.dtp_dob.Size = New System.Drawing.Size(208, 22)
        Me.dtp_dob.TabIndex = 56
        '
        'Txt_pincode
        '
        Me.Txt_pincode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_pincode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pincode.ForeColor = System.Drawing.Color.Black
        Me.Txt_pincode.Location = New System.Drawing.Point(195, 392)
        Me.Txt_pincode.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_pincode.Multiline = True
        Me.Txt_pincode.Name = "Txt_pincode"
        Me.Txt_pincode.Size = New System.Drawing.Size(208, 20)
        Me.Txt_pincode.TabIndex = 54
        '
        'Txt_post
        '
        Me.Txt_post.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_post.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_post.ForeColor = System.Drawing.Color.Black
        Me.Txt_post.Location = New System.Drawing.Point(194, 356)
        Me.Txt_post.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_post.Multiline = True
        Me.Txt_post.Name = "Txt_post"
        Me.Txt_post.Size = New System.Drawing.Size(208, 20)
        Me.Txt_post.TabIndex = 53
        '
        'Txt_place
        '
        Me.Txt_place.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_place.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_place.ForeColor = System.Drawing.Color.Black
        Me.Txt_place.Location = New System.Drawing.Point(195, 320)
        Me.Txt_place.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_place.Multiline = True
        Me.Txt_place.Name = "Txt_place"
        Me.Txt_place.Size = New System.Drawing.Size(208, 20)
        Me.Txt_place.TabIndex = 52
        '
        'Lbl_cate
        '
        Me.Lbl_cate.AutoSize = True
        Me.Lbl_cate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_cate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_cate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_cate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_cate.Location = New System.Drawing.Point(30, 500)
        Me.Lbl_cate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_cate.Name = "Lbl_cate"
        Me.Lbl_cate.Size = New System.Drawing.Size(79, 20)
        Me.Lbl_cate.TabIndex = 46
        Me.Lbl_cate.Text = "Category"
        '
        'Lbl_phno
        '
        Me.Lbl_phno.AutoSize = True
        Me.Lbl_phno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_phno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_phno.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_phno.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_phno.Location = New System.Drawing.Point(30, 464)
        Me.Lbl_phno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_phno.Name = "Lbl_phno"
        Me.Lbl_phno.Size = New System.Drawing.Size(79, 20)
        Me.Lbl_phno.TabIndex = 45
        Me.Lbl_phno.Text = "Phone no" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lbl_dist
        '
        Me.Lbl_dist.AutoSize = True
        Me.Lbl_dist.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_dist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_dist.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dist.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_dist.Location = New System.Drawing.Point(30, 428)
        Me.Lbl_dist.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_dist.Name = "Lbl_dist"
        Me.Lbl_dist.Size = New System.Drawing.Size(57, 20)
        Me.Lbl_dist.TabIndex = 44
        Me.Lbl_dist.Text = "District"
        '
        'Lbl_pincode
        '
        Me.Lbl_pincode.AutoSize = True
        Me.Lbl_pincode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_pincode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_pincode.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_pincode.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_pincode.Location = New System.Drawing.Point(30, 392)
        Me.Lbl_pincode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_pincode.Name = "Lbl_pincode"
        Me.Lbl_pincode.Size = New System.Drawing.Size(70, 20)
        Me.Lbl_pincode.TabIndex = 43
        Me.Lbl_pincode.Text = "Pincode"
        '
        'Lbl_post
        '
        Me.Lbl_post.AutoSize = True
        Me.Lbl_post.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_post.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_post.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_post.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_post.Location = New System.Drawing.Point(30, 356)
        Me.Lbl_post.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_post.Name = "Lbl_post"
        Me.Lbl_post.Size = New System.Drawing.Size(39, 20)
        Me.Lbl_post.TabIndex = 42
        Me.Lbl_post.Text = "Post"
        '
        'Lbl_place
        '
        Me.Lbl_place.AutoSize = True
        Me.Lbl_place.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_place.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_place.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_place.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_place.Location = New System.Drawing.Point(30, 320)
        Me.Lbl_place.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_place.Name = "Lbl_place"
        Me.Lbl_place.Size = New System.Drawing.Size(51, 20)
        Me.Lbl_place.TabIndex = 41
        Me.Lbl_place.Text = "Place"
        '
        'Lbl_hname
        '
        Me.Lbl_hname.AutoSize = True
        Me.Lbl_hname.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_hname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_hname.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_hname.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_hname.Location = New System.Drawing.Point(30, 284)
        Me.Lbl_hname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_hname.Name = "Lbl_hname"
        Me.Lbl_hname.Size = New System.Drawing.Size(100, 20)
        Me.Lbl_hname.TabIndex = 40
        Me.Lbl_hname.Text = "House name"
        '
        'Lbl_dob
        '
        Me.Lbl_dob.AutoSize = True
        Me.Lbl_dob.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_dob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_dob.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dob.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_dob.Location = New System.Drawing.Point(30, 248)
        Me.Lbl_dob.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_dob.Name = "Lbl_dob"
        Me.Lbl_dob.Size = New System.Drawing.Size(42, 20)
        Me.Lbl_dob.TabIndex = 39
        Me.Lbl_dob.Text = "DOB"
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_name.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_name.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_name.Location = New System.Drawing.Point(30, 212)
        Me.Lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(53, 20)
        Me.Lbl_name.TabIndex = 38
        Me.Lbl_name.Text = "Name"
        '
        'Lbl_regno
        '
        Me.Lbl_regno.AutoSize = True
        Me.Lbl_regno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_regno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_regno.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_regno.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_regno.Location = New System.Drawing.Point(30, 176)
        Me.Lbl_regno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_regno.Name = "Lbl_regno"
        Me.Lbl_regno.Size = New System.Drawing.Size(90, 20)
        Me.Lbl_regno.TabIndex = 37
        Me.Lbl_regno.Text = "Register no"
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_id.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id.ForeColor = System.Drawing.Color.White
        Me.Lbl_id.Location = New System.Drawing.Point(30, 140)
        Me.Lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(25, 20)
        Me.Lbl_id.TabIndex = 36
        Me.Lbl_id.Text = "ID"
        '
        'Btn_go
        '
        Me.Btn_go.BackColor = System.Drawing.Color.Transparent
        Me.Btn_go.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_go.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_go.ForeColor = System.Drawing.Color.White
        Me.Btn_go.Location = New System.Drawing.Point(855, 161)
        Me.Btn_go.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(82, 32)
        Me.Btn_go.TabIndex = 73
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = False
        '
        'Txt_data
        '
        Me.Txt_data.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_data.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_data.ForeColor = System.Drawing.Color.Black
        Me.Txt_data.Location = New System.Drawing.Point(666, 186)
        Me.Txt_data.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_data.Multiline = True
        Me.Txt_data.Name = "Txt_data"
        Me.Txt_data.Size = New System.Drawing.Size(171, 20)
        Me.Txt_data.TabIndex = 72
        '
        'Lbl_data
        '
        Me.Lbl_data.AutoSize = True
        Me.Lbl_data.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_data.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_data.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_data.Location = New System.Drawing.Point(548, 187)
        Me.Lbl_data.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_data.Name = "Lbl_data"
        Me.Lbl_data.Size = New System.Drawing.Size(100, 20)
        Me.Lbl_data.TabIndex = 71
        Me.Lbl_data.Text = "Search Data"
        '
        'Cmb_searchby
        '
        Me.Cmb_searchby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cmb_searchby.ForeColor = System.Drawing.Color.Black
        Me.Cmb_searchby.FormattingEnabled = True
        Me.Cmb_searchby.Items.AddRange(New Object() {"id", "register no", "name", "dob", "house name", "place", "post", "pincode", "district", "phone no", "category"})
        Me.Cmb_searchby.Location = New System.Drawing.Point(666, 147)
        Me.Cmb_searchby.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmb_searchby.Name = "Cmb_searchby"
        Me.Cmb_searchby.Size = New System.Drawing.Size(171, 21)
        Me.Cmb_searchby.TabIndex = 70
        '
        'Lbl_searb
        '
        Me.Lbl_searb.AutoSize = True
        Me.Lbl_searb.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_searb.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_searb.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_searb.Location = New System.Drawing.Point(548, 145)
        Me.Lbl_searb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_searb.Name = "Lbl_searb"
        Me.Lbl_searb.Size = New System.Drawing.Size(81, 20)
        Me.Lbl_searb.TabIndex = 69
        Me.Lbl_searb.Text = "Search By"
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.Location = New System.Drawing.Point(431, 410)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(79, 30)
        Me.btn_close.TabIndex = 77
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.Transparent
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.Location = New System.Drawing.Point(431, 284)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(79, 30)
        Me.btn_refresh.TabIndex = 76
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Location = New System.Drawing.Point(431, 347)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(79, 30)
        Me.btn_search.TabIndex = 75
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(431, 221)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(79, 30)
        Me.btn_save.TabIndex = 79
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'txt_hname
        '
        Me.txt_hname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_hname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hname.ForeColor = System.Drawing.Color.Black
        Me.txt_hname.Location = New System.Drawing.Point(195, 284)
        Me.txt_hname.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_hname.Multiline = True
        Me.txt_hname.Name = "txt_hname"
        Me.txt_hname.Size = New System.Drawing.Size(208, 20)
        Me.txt_hname.TabIndex = 80
        '
        'txt_phno
        '
        Me.txt_phno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_phno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phno.ForeColor = System.Drawing.Color.Black
        Me.txt_phno.Location = New System.Drawing.Point(195, 464)
        Me.txt_phno.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_phno.Multiline = True
        Me.txt_phno.Name = "txt_phno"
        Me.txt_phno.Size = New System.Drawing.Size(208, 20)
        Me.txt_phno.TabIndex = 82
        '
        'txt_regno
        '
        Me.txt_regno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_regno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_regno.ForeColor = System.Drawing.Color.Black
        Me.txt_regno.Location = New System.Drawing.Point(194, 178)
        Me.txt_regno.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_regno.Multiline = True
        Me.txt_regno.Name = "txt_regno"
        Me.txt_regno.Size = New System.Drawing.Size(208, 20)
        Me.txt_regno.TabIndex = 83
        '
        'txt_name
        '
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.Black
        Me.txt_name.Location = New System.Drawing.Point(195, 214)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(208, 20)
        Me.txt_name.TabIndex = 84
        '
        'txt_id
        '
        Me.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.Black
        Me.txt_id.Location = New System.Drawing.Point(195, 142)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Multiline = True
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(208, 20)
        Me.txt_id.TabIndex = 85
        '
        'Dgv_customerregistration
        '
        Me.Dgv_customerregistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_customerregistration.Location = New System.Drawing.Point(551, 235)
        Me.Dgv_customerregistration.Name = "Dgv_customerregistration"
        Me.Dgv_customerregistration.Size = New System.Drawing.Size(384, 268)
        Me.Dgv_customerregistration.TabIndex = 86
        '
        'lbl_customerreg
        '
        Me.lbl_customerreg.AutoSize = True
        Me.lbl_customerreg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_customerreg.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_customerreg.ForeColor = System.Drawing.Color.White
        Me.lbl_customerreg.Location = New System.Drawing.Point(326, 26)
        Me.lbl_customerreg.Name = "lbl_customerreg"
        Me.lbl_customerreg.Size = New System.Drawing.Size(270, 39)
        Me.lbl_customerreg.TabIndex = 87
        Me.lbl_customerreg.Text = "Customer Registration"
        '
        'cbo_district
        '
        Me.cbo_district.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cbo_district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_district.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_district.ForeColor = System.Drawing.Color.Black
        Me.cbo_district.FormattingEnabled = True
        Me.cbo_district.Items.AddRange(New Object() {"Kasaragod", "Kannur", "Wayanad", "Kozikode", "Malappuram", "Palakkad", "Thrissur", "Ernamkulam", "Idukki", "Kottayam", "Alappuzha", "Pathanamthitta", "Kollam", "Thiruvananthapuram"})
        Me.cbo_district.Location = New System.Drawing.Point(195, 425)
        Me.cbo_district.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_district.Name = "cbo_district"
        Me.cbo_district.Size = New System.Drawing.Size(208, 23)
        Me.cbo_district.TabIndex = 88
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(614, 522)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(87, 34)
        Me.btn_update.TabIndex = 89
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
        Me.btn_delete.Location = New System.Drawing.Point(745, 522)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(110, 33)
        Me.btn_delete.TabIndex = 90
        Me.btn_delete.Text = "Delete" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'frm_customer_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.regwall
        Me.ClientSize = New System.Drawing.Size(947, 573)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.cbo_district)
        Me.Controls.Add(Me.lbl_customerreg)
        Me.Controls.Add(Me.Dgv_customerregistration)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_regno)
        Me.Controls.Add(Me.txt_phno)
        Me.Controls.Add(Me.txt_hname)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.Btn_go)
        Me.Controls.Add(Me.Txt_data)
        Me.Controls.Add(Me.Lbl_data)
        Me.Controls.Add(Me.Cmb_searchby)
        Me.Controls.Add(Me.Lbl_searb)
        Me.Controls.Add(Me.Cbo_category)
        Me.Controls.Add(Me.dtp_dob)
        Me.Controls.Add(Me.Txt_pincode)
        Me.Controls.Add(Me.Txt_post)
        Me.Controls.Add(Me.Txt_place)
        Me.Controls.Add(Me.Lbl_cate)
        Me.Controls.Add(Me.Lbl_phno)
        Me.Controls.Add(Me.Lbl_dist)
        Me.Controls.Add(Me.Lbl_pincode)
        Me.Controls.Add(Me.Lbl_post)
        Me.Controls.Add(Me.Lbl_place)
        Me.Controls.Add(Me.Lbl_hname)
        Me.Controls.Add(Me.Lbl_dob)
        Me.Controls.Add(Me.Lbl_name)
        Me.Controls.Add(Me.Lbl_regno)
        Me.Controls.Add(Me.Lbl_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_customer_Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "customer_Registration"
        CType(Me.Dgv_customerregistration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbo_category As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txt_pincode As System.Windows.Forms.TextBox
    Friend WithEvents Txt_post As System.Windows.Forms.TextBox
    Friend WithEvents Txt_place As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_cate As System.Windows.Forms.Label
    Friend WithEvents Lbl_phno As System.Windows.Forms.Label
    Friend WithEvents Lbl_dist As System.Windows.Forms.Label
    Friend WithEvents Lbl_pincode As System.Windows.Forms.Label
    Friend WithEvents Lbl_post As System.Windows.Forms.Label
    Friend WithEvents Lbl_place As System.Windows.Forms.Label
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
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_hname As System.Windows.Forms.TextBox
    Friend WithEvents txt_phno As System.Windows.Forms.TextBox
    Friend WithEvents txt_regno As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox


    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistrationnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HousenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlaceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PincodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DistrictDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhonenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECYCLEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dgv_customerregistration As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_customerreg As System.Windows.Forms.Label
    Friend WithEvents cbo_district As System.Windows.Forms.ComboBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
End Class
