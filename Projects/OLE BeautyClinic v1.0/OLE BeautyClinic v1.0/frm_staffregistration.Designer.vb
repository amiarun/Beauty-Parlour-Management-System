<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_staffregistration
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
        Me.Dgv_staffregistration = New System.Windows.Forms.DataGridView
        Me.Btn_close = New System.Windows.Forms.Button
        Me.Btn_refresh = New System.Windows.Forms.Button
        Me.Btn_search = New System.Windows.Forms.Button
        Me.Btn_go = New System.Windows.Forms.Button
        Me.Txt_data = New System.Windows.Forms.TextBox
        Me.Lbl_data = New System.Windows.Forms.Label
        Me.Cmb_searchby = New System.Windows.Forms.ComboBox
        Me.Lbl_searb = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txt_comming = New System.Windows.Forms.TextBox
        Me.txt_salary = New System.Windows.Forms.TextBox
        Me.cbo_district = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.txt_registerno = New System.Windows.Forms.TextBox
        Me.txt_going = New System.Windows.Forms.TextBox
        Me.txt_phone = New System.Windows.Forms.TextBox
        Me.txt_house = New System.Windows.Forms.TextBox
        Me.Cbo_qualification = New System.Windows.Forms.ComboBox
        Me.dtp_joine = New System.Windows.Forms.DateTimePicker
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
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        CType(Me.Dgv_staffregistration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(406, 274)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(89, 39)
        Me.btn_save.TabIndex = 89
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Dgv_staffregistration
        '
        Me.Dgv_staffregistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_staffregistration.Location = New System.Drawing.Point(512, 259)
        Me.Dgv_staffregistration.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Dgv_staffregistration.Name = "Dgv_staffregistration"
        Me.Dgv_staffregistration.Size = New System.Drawing.Size(385, 369)
        Me.Dgv_staffregistration.TabIndex = 88
        '
        'Btn_close
        '
        Me.Btn_close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_close.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.White
        Me.Btn_close.Location = New System.Drawing.Point(406, 441)
        Me.Btn_close.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(89, 39)
        Me.Btn_close.TabIndex = 87
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
        Me.Btn_refresh.Location = New System.Drawing.Point(406, 385)
        Me.Btn_refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_refresh.Name = "Btn_refresh"
        Me.Btn_refresh.Size = New System.Drawing.Size(89, 39)
        Me.Btn_refresh.TabIndex = 86
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
        Me.Btn_search.Location = New System.Drawing.Point(406, 329)
        Me.Btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(89, 39)
        Me.Btn_search.TabIndex = 85
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = False
        '
        'Btn_go
        '
        Me.Btn_go.BackColor = System.Drawing.Color.Transparent
        Me.Btn_go.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_go.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_go.ForeColor = System.Drawing.Color.White
        Me.Btn_go.Location = New System.Drawing.Point(819, 164)
        Me.Btn_go.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(78, 53)
        Me.Btn_go.TabIndex = 84
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = False
        '
        'Txt_data
        '
        Me.Txt_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_data.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_data.ForeColor = System.Drawing.Color.Black
        Me.Txt_data.Location = New System.Drawing.Point(644, 213)
        Me.Txt_data.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_data.Name = "Txt_data"
        Me.Txt_data.Size = New System.Drawing.Size(152, 22)
        Me.Txt_data.TabIndex = 83
        '
        'Lbl_data
        '
        Me.Lbl_data.AutoSize = True
        Me.Lbl_data.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_data.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_data.ForeColor = System.Drawing.Color.White
        Me.Lbl_data.Location = New System.Drawing.Point(538, 218)
        Me.Lbl_data.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_data.Name = "Lbl_data"
        Me.Lbl_data.Size = New System.Drawing.Size(88, 17)
        Me.Lbl_data.TabIndex = 82
        Me.Lbl_data.Text = "Search Data"
        '
        'Cmb_searchby
        '
        Me.Cmb_searchby.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmb_searchby.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_searchby.ForeColor = System.Drawing.Color.Black
        Me.Cmb_searchby.FormattingEnabled = True
        Me.Cmb_searchby.Items.AddRange(New Object() {"id", "regno", "name", "joinning date", "house name", "place", "post", "pincode", "district", "phone no", "qualification", "salary", "comming time", "going time"})
        Me.Cmb_searchby.Location = New System.Drawing.Point(644, 153)
        Me.Cmb_searchby.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmb_searchby.Name = "Cmb_searchby"
        Me.Cmb_searchby.Size = New System.Drawing.Size(152, 23)
        Me.Cmb_searchby.TabIndex = 81
        '
        'Lbl_searb
        '
        Me.Lbl_searb.AutoSize = True
        Me.Lbl_searb.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_searb.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_searb.ForeColor = System.Drawing.Color.White
        Me.Lbl_searb.Location = New System.Drawing.Point(538, 151)
        Me.Lbl_searb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_searb.Name = "Lbl_searb"
        Me.Lbl_searb.Size = New System.Drawing.Size(68, 17)
        Me.Lbl_searb.TabIndex = 80
        Me.Lbl_searb.Text = "Search By"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_comming
        '
        Me.txt_comming.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_comming.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_comming.Location = New System.Drawing.Point(158, 573)
        Me.txt_comming.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_comming.Name = "txt_comming"
        Me.txt_comming.Size = New System.Drawing.Size(234, 21)
        Me.txt_comming.TabIndex = 169
        '
        'txt_salary
        '
        Me.txt_salary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_salary.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_salary.Location = New System.Drawing.Point(158, 539)
        Me.txt_salary.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_salary.Name = "txt_salary"
        Me.txt_salary.Size = New System.Drawing.Size(234, 21)
        Me.txt_salary.TabIndex = 168
        '
        'cbo_district
        '
        Me.cbo_district.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbo_district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_district.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_district.FormattingEnabled = True
        Me.cbo_district.Items.AddRange(New Object() {"Kasaragod", "Kannur", "Wayanad", "Kozikode", "Malappuram", "Palakkad", "Thrissur", "Ernamkulam", "Idukki", "Kottayam", "Alappuzha", "Pathanamthitta", "Kollam", "Thiruvananthapuram"})
        Me.cbo_district.Location = New System.Drawing.Point(158, 431)
        Me.cbo_district.Margin = New System.Windows.Forms.Padding(2)
        Me.cbo_district.Name = "cbo_district"
        Me.cbo_district.Size = New System.Drawing.Size(234, 24)
        Me.cbo_district.TabIndex = 164
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label4.Location = New System.Drawing.Point(34, 611)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "Going Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Location = New System.Drawing.Point(34, 576)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 162
        Me.Label5.Text = "Comming Time"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(34, 541)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Salary"
        '
        'txt_id
        '
        Me.txt_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_id.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(159, 159)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(233, 21)
        Me.txt_id.TabIndex = 160
        '
        'txt_name
        '
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_name.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(158, 227)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(234, 21)
        Me.txt_name.TabIndex = 159
        '
        'txt_registerno
        '
        Me.txt_registerno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_registerno.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_registerno.Location = New System.Drawing.Point(159, 196)
        Me.txt_registerno.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_registerno.Name = "txt_registerno"
        Me.txt_registerno.Size = New System.Drawing.Size(233, 21)
        Me.txt_registerno.TabIndex = 158
        '
        'txt_going
        '
        Me.txt_going.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_going.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_going.Location = New System.Drawing.Point(158, 607)
        Me.txt_going.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_going.Name = "txt_going"
        Me.txt_going.Size = New System.Drawing.Size(234, 21)
        Me.txt_going.TabIndex = 157
        '
        'txt_phone
        '
        Me.txt_phone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_phone.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_phone.Location = New System.Drawing.Point(158, 468)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Size = New System.Drawing.Size(234, 21)
        Me.txt_phone.TabIndex = 156
        '
        'txt_house
        '
        Me.txt_house.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txt_house.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_house.Location = New System.Drawing.Point(158, 295)
        Me.txt_house.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_house.Name = "txt_house"
        Me.txt_house.Size = New System.Drawing.Size(234, 21)
        Me.txt_house.TabIndex = 155
        '
        'Cbo_qualification
        '
        Me.Cbo_qualification.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cbo_qualification.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_qualification.FormattingEnabled = True
        Me.Cbo_qualification.Location = New System.Drawing.Point(158, 502)
        Me.Cbo_qualification.Margin = New System.Windows.Forms.Padding(2)
        Me.Cbo_qualification.Name = "Cbo_qualification"
        Me.Cbo_qualification.Size = New System.Drawing.Size(234, 24)
        Me.Cbo_qualification.TabIndex = 143
        '
        'dtp_joine
        '
        Me.dtp_joine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtp_joine.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_joine.Location = New System.Drawing.Point(158, 261)
        Me.dtp_joine.Margin = New System.Windows.Forms.Padding(2)
        Me.dtp_joine.Name = "dtp_joine"
        Me.dtp_joine.Size = New System.Drawing.Size(234, 21)
        Me.dtp_joine.TabIndex = 142
        '
        'Txt_pincode
        '
        Me.Txt_pincode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_pincode.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pincode.Location = New System.Drawing.Point(158, 397)
        Me.Txt_pincode.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_pincode.Name = "Txt_pincode"
        Me.Txt_pincode.Size = New System.Drawing.Size(234, 21)
        Me.Txt_pincode.TabIndex = 141
        '
        'Txt_post
        '
        Me.Txt_post.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_post.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_post.Location = New System.Drawing.Point(158, 363)
        Me.Txt_post.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_post.Name = "Txt_post"
        Me.Txt_post.Size = New System.Drawing.Size(234, 21)
        Me.Txt_post.TabIndex = 140
        '
        'Txt_place
        '
        Me.Txt_place.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_place.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_place.Location = New System.Drawing.Point(158, 329)
        Me.Txt_place.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_place.Name = "Txt_place"
        Me.Txt_place.Size = New System.Drawing.Size(234, 21)
        Me.Txt_place.TabIndex = 139
        '
        'Lbl_cate
        '
        Me.Lbl_cate.AutoSize = True
        Me.Lbl_cate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_cate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_cate.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_cate.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_cate.Location = New System.Drawing.Point(34, 506)
        Me.Lbl_cate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_cate.Name = "Lbl_cate"
        Me.Lbl_cate.Size = New System.Drawing.Size(85, 17)
        Me.Lbl_cate.TabIndex = 138
        Me.Lbl_cate.Text = "Qualification"
        '
        'Lbl_phno
        '
        Me.Lbl_phno.AutoSize = True
        Me.Lbl_phno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_phno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_phno.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_phno.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_phno.Location = New System.Drawing.Point(34, 471)
        Me.Lbl_phno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_phno.Name = "Lbl_phno"
        Me.Lbl_phno.Size = New System.Drawing.Size(63, 17)
        Me.Lbl_phno.TabIndex = 137
        Me.Lbl_phno.Text = "Phone no" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lbl_dist
        '
        Me.Lbl_dist.AutoSize = True
        Me.Lbl_dist.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_dist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_dist.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dist.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_dist.Location = New System.Drawing.Point(34, 436)
        Me.Lbl_dist.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_dist.Name = "Lbl_dist"
        Me.Lbl_dist.Size = New System.Drawing.Size(50, 17)
        Me.Lbl_dist.TabIndex = 136
        Me.Lbl_dist.Text = "District"
        '
        'Lbl_pincode
        '
        Me.Lbl_pincode.AutoSize = True
        Me.Lbl_pincode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_pincode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_pincode.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_pincode.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_pincode.Location = New System.Drawing.Point(34, 401)
        Me.Lbl_pincode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_pincode.Name = "Lbl_pincode"
        Me.Lbl_pincode.Size = New System.Drawing.Size(57, 17)
        Me.Lbl_pincode.TabIndex = 135
        Me.Lbl_pincode.Text = "Pincode"
        '
        'Lbl_post
        '
        Me.Lbl_post.AutoSize = True
        Me.Lbl_post.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_post.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_post.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_post.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_post.Location = New System.Drawing.Point(34, 366)
        Me.Lbl_post.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_post.Name = "Lbl_post"
        Me.Lbl_post.Size = New System.Drawing.Size(33, 17)
        Me.Lbl_post.TabIndex = 134
        Me.Lbl_post.Text = "Post"
        '
        'Lbl_place
        '
        Me.Lbl_place.AutoSize = True
        Me.Lbl_place.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_place.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_place.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_place.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_place.Location = New System.Drawing.Point(34, 331)
        Me.Lbl_place.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_place.Name = "Lbl_place"
        Me.Lbl_place.Size = New System.Drawing.Size(42, 17)
        Me.Lbl_place.TabIndex = 133
        Me.Lbl_place.Text = "Place"
        '
        'Lbl_hname
        '
        Me.Lbl_hname.AutoSize = True
        Me.Lbl_hname.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_hname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_hname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_hname.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_hname.Location = New System.Drawing.Point(34, 296)
        Me.Lbl_hname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_hname.Name = "Lbl_hname"
        Me.Lbl_hname.Size = New System.Drawing.Size(81, 17)
        Me.Lbl_hname.TabIndex = 132
        Me.Lbl_hname.Text = "House name"
        '
        'Lbl_dob
        '
        Me.Lbl_dob.AutoSize = True
        Me.Lbl_dob.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_dob.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_dob.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dob.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_dob.Location = New System.Drawing.Point(32, 259)
        Me.Lbl_dob.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_dob.Name = "Lbl_dob"
        Me.Lbl_dob.Size = New System.Drawing.Size(90, 17)
        Me.Lbl_dob.TabIndex = 131
        Me.Lbl_dob.Text = "Joinning Date"
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_name.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_name.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_name.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_name.Location = New System.Drawing.Point(32, 227)
        Me.Lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(44, 17)
        Me.Lbl_name.TabIndex = 130
        Me.Lbl_name.Text = "Name"
        '
        'Lbl_regno
        '
        Me.Lbl_regno.AutoSize = True
        Me.Lbl_regno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_regno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_regno.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_regno.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_regno.Location = New System.Drawing.Point(32, 195)
        Me.Lbl_regno.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_regno.Name = "Lbl_regno"
        Me.Lbl_regno.Size = New System.Drawing.Size(74, 17)
        Me.Lbl_regno.TabIndex = 129
        Me.Lbl_regno.Text = "Register no"
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_id.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_id.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id.ForeColor = System.Drawing.Color.White
        Me.Lbl_id.Location = New System.Drawing.Point(32, 163)
        Me.Lbl_id.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(20, 17)
        Me.Lbl_id.TabIndex = 128
        Me.Lbl_id.Text = "ID"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(554, 656)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(89, 39)
        Me.btn_update.TabIndex = 170
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(691, 656)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(89, 39)
        Me.btn_delete.TabIndex = 171
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'frm_staffregistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.regwall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(977, 745)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txt_comming)
        Me.Controls.Add(Me.txt_salary)
        Me.Controls.Add(Me.cbo_district)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.txt_registerno)
        Me.Controls.Add(Me.txt_going)
        Me.Controls.Add(Me.txt_phone)
        Me.Controls.Add(Me.txt_house)
        Me.Controls.Add(Me.Cbo_qualification)
        Me.Controls.Add(Me.dtp_joine)
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
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Dgv_staffregistration)
        Me.Controls.Add(Me.Btn_close)
        Me.Controls.Add(Me.Btn_refresh)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.Btn_go)
        Me.Controls.Add(Me.Txt_data)
        Me.Controls.Add(Me.Lbl_data)
        Me.Controls.Add(Me.Cmb_searchby)
        Me.Controls.Add(Me.Lbl_searb)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frm_staffregistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Registration"
        CType(Me.Dgv_staffregistration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Dgv_staffregistration As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents Btn_refresh As System.Windows.Forms.Button
    Friend WithEvents Btn_search As System.Windows.Forms.Button
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents Txt_data As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_data As System.Windows.Forms.Label
    Friend WithEvents Cmb_searchby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_searb As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txt_comming As System.Windows.Forms.TextBox
    Friend WithEvents txt_salary As System.Windows.Forms.TextBox
    Friend WithEvents cbo_district As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_registerno As System.Windows.Forms.TextBox
    Friend WithEvents txt_going As System.Windows.Forms.TextBox
    Friend WithEvents txt_phone As System.Windows.Forms.TextBox
    Friend WithEvents txt_house As System.Windows.Forms.TextBox
    Friend WithEvents Cbo_qualification As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_joine As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    
End Class
