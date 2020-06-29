<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_studentregistration
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
        Me.Dtp_dob = New System.Windows.Forms.DateTimePicker
        Me.Dtp_date = New System.Windows.Forms.DateTimePicker
        Me.Btn_browse = New System.Windows.Forms.Button
        Me.pb_stud = New System.Windows.Forms.PictureBox
        Me.Lbl_dis = New System.Windows.Forms.Label
        Me.Txt_phno = New System.Windows.Forms.TextBox
        Me.Lbl_phno = New System.Windows.Forms.Label
        Me.Lbl_dob = New System.Windows.Forms.Label
        Me.Txt_oname = New System.Windows.Forms.TextBox
        Me.Lbl_oname = New System.Windows.Forms.Label
        Me.Txt_gname = New System.Windows.Forms.TextBox
        Me.Lbl_gname = New System.Windows.Forms.Label
        Me.Txt_relation = New System.Windows.Forms.TextBox
        Me.Lbl_rela = New System.Windows.Forms.Label
        Me.txt_gphno = New System.Windows.Forms.TextBox
        Me.Lbl_gphno = New System.Windows.Forms.Label
        Me.Txt_pin = New System.Windows.Forms.TextBox
        Me.Lbl_pinc = New System.Windows.Forms.Label
        Me.Txt_post = New System.Windows.Forms.TextBox
        Me.Lbl_post = New System.Windows.Forms.Label
        Me.Txt_place = New System.Windows.Forms.TextBox
        Me.Lbl_place = New System.Windows.Forms.Label
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.Lbl_name = New System.Windows.Forms.Label
        Me.Lbl_sdate = New System.Windows.Forms.Label
        Me.Txt_timming = New System.Windows.Forms.TextBox
        Me.Lbl_tmg = New System.Windows.Forms.Label
        Me.Txt_dur = New System.Windows.Forms.TextBox
        Me.Lbl_duration = New System.Windows.Forms.Label
        Me.Txt_fee = New System.Windows.Forms.TextBox
        Me.Lbl_fees = New System.Windows.Forms.Label
        Me.Txt_course = New System.Windows.Forms.TextBox
        Me.Lbl_course = New System.Windows.Forms.Label
        Me.Txt_rgno = New System.Windows.Forms.TextBox
        Me.Lbl_rgno = New System.Windows.Forms.Label
        Me.Txt_id = New System.Windows.Forms.TextBox
        Me.Lbl_id = New System.Windows.Forms.Label
        Me.Btn_go = New System.Windows.Forms.Button
        Me.Cmb_sby = New System.Windows.Forms.ComboBox
        Me.Txt_sdata = New System.Windows.Forms.TextBox
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.Lbl_sby = New System.Windows.Forms.Label
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_refresh = New System.Windows.Forms.Button
        Me.btn_search = New System.Windows.Forms.Button
        Me.Dgv_student_registration = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.cbo_district = New System.Windows.Forms.ComboBox
        CType(Me.pb_stud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_student_registration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dtp_dob
        '
        Me.Dtp_dob.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_dob.Location = New System.Drawing.Point(160, 515)
        Me.Dtp_dob.Name = "Dtp_dob"
        Me.Dtp_dob.Size = New System.Drawing.Size(197, 23)
        Me.Dtp_dob.TabIndex = 118
        '
        'Dtp_date
        '
        Me.Dtp_date.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_date.Location = New System.Drawing.Point(160, 319)
        Me.Dtp_date.Name = "Dtp_date"
        Me.Dtp_date.Size = New System.Drawing.Size(197, 23)
        Me.Dtp_date.TabIndex = 117
        '
        'Btn_browse
        '
        Me.Btn_browse.BackColor = System.Drawing.Color.Transparent
        Me.Btn_browse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_browse.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_browse.ForeColor = System.Drawing.Color.White
        Me.Btn_browse.Location = New System.Drawing.Point(396, 299)
        Me.Btn_browse.Name = "Btn_browse"
        Me.Btn_browse.Size = New System.Drawing.Size(127, 39)
        Me.Btn_browse.TabIndex = 98
        Me.Btn_browse.Text = "Browse"
        Me.Btn_browse.UseVisualStyleBackColor = False
        '
        'pb_stud
        '
        Me.pb_stud.BackColor = System.Drawing.Color.Transparent
        Me.pb_stud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_stud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pb_stud.Location = New System.Drawing.Point(385, 158)
        Me.pb_stud.Name = "pb_stud"
        Me.pb_stud.Size = New System.Drawing.Size(151, 128)
        Me.pb_stud.TabIndex = 97
        Me.pb_stud.TabStop = False
        '
        'Lbl_dis
        '
        Me.Lbl_dis.AutoSize = True
        Me.Lbl_dis.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_dis.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dis.ForeColor = System.Drawing.Color.White
        Me.Lbl_dis.Location = New System.Drawing.Point(12, 465)
        Me.Lbl_dis.Name = "Lbl_dis"
        Me.Lbl_dis.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_dis.TabIndex = 95
        Me.Lbl_dis.Text = "District"
        '
        'Txt_phno
        '
        Me.Txt_phno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_phno.Location = New System.Drawing.Point(159, 487)
        Me.Txt_phno.Name = "Txt_phno"
        Me.Txt_phno.Size = New System.Drawing.Size(198, 23)
        Me.Txt_phno.TabIndex = 94
        '
        'Lbl_phno
        '
        Me.Lbl_phno.AutoSize = True
        Me.Lbl_phno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_phno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_phno.ForeColor = System.Drawing.Color.White
        Me.Lbl_phno.Location = New System.Drawing.Point(12, 493)
        Me.Lbl_phno.Name = "Lbl_phno"
        Me.Lbl_phno.Size = New System.Drawing.Size(71, 17)
        Me.Lbl_phno.TabIndex = 93
        Me.Lbl_phno.Text = "phone no"
        '
        'Lbl_dob
        '
        Me.Lbl_dob.AutoSize = True
        Me.Lbl_dob.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_dob.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_dob.ForeColor = System.Drawing.Color.White
        Me.Lbl_dob.Location = New System.Drawing.Point(13, 521)
        Me.Lbl_dob.Name = "Lbl_dob"
        Me.Lbl_dob.Size = New System.Drawing.Size(36, 17)
        Me.Lbl_dob.TabIndex = 92
        Me.Lbl_dob.Text = "DOB"
        '
        'Txt_oname
        '
        Me.Txt_oname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_oname.Location = New System.Drawing.Point(158, 543)
        Me.Txt_oname.Name = "Txt_oname"
        Me.Txt_oname.Size = New System.Drawing.Size(198, 23)
        Me.Txt_oname.TabIndex = 91
        '
        'Lbl_oname
        '
        Me.Lbl_oname.AutoSize = True
        Me.Lbl_oname.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_oname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_oname.ForeColor = System.Drawing.Color.White
        Me.Lbl_oname.Location = New System.Drawing.Point(11, 549)
        Me.Lbl_oname.Name = "Lbl_oname"
        Me.Lbl_oname.Size = New System.Drawing.Size(88, 17)
        Me.Lbl_oname.TabIndex = 90
        Me.Lbl_oname.Text = "Office name"
        '
        'Txt_gname
        '
        Me.Txt_gname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_gname.Location = New System.Drawing.Point(158, 571)
        Me.Txt_gname.Name = "Txt_gname"
        Me.Txt_gname.Size = New System.Drawing.Size(198, 23)
        Me.Txt_gname.TabIndex = 89
        '
        'Lbl_gname
        '
        Me.Lbl_gname.AutoSize = True
        Me.Lbl_gname.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_gname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_gname.ForeColor = System.Drawing.Color.White
        Me.Lbl_gname.Location = New System.Drawing.Point(11, 577)
        Me.Lbl_gname.Name = "Lbl_gname"
        Me.Lbl_gname.Size = New System.Drawing.Size(111, 17)
        Me.Lbl_gname.TabIndex = 88
        Me.Lbl_gname.Text = "Guardian name"
        '
        'Txt_relation
        '
        Me.Txt_relation.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_relation.Location = New System.Drawing.Point(158, 599)
        Me.Txt_relation.Name = "Txt_relation"
        Me.Txt_relation.Size = New System.Drawing.Size(198, 23)
        Me.Txt_relation.TabIndex = 87
        '
        'Lbl_rela
        '
        Me.Lbl_rela.AutoSize = True
        Me.Lbl_rela.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_rela.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rela.ForeColor = System.Drawing.Color.White
        Me.Lbl_rela.Location = New System.Drawing.Point(11, 605)
        Me.Lbl_rela.Name = "Lbl_rela"
        Me.Lbl_rela.Size = New System.Drawing.Size(61, 17)
        Me.Lbl_rela.TabIndex = 86
        Me.Lbl_rela.Text = "Relation"
        '
        'txt_gphno
        '
        Me.txt_gphno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gphno.Location = New System.Drawing.Point(158, 627)
        Me.txt_gphno.Name = "txt_gphno"
        Me.txt_gphno.Size = New System.Drawing.Size(198, 23)
        Me.txt_gphno.TabIndex = 85
        '
        'Lbl_gphno
        '
        Me.Lbl_gphno.AutoSize = True
        Me.Lbl_gphno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_gphno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_gphno.ForeColor = System.Drawing.Color.White
        Me.Lbl_gphno.Location = New System.Drawing.Point(11, 633)
        Me.Lbl_gphno.Name = "Lbl_gphno"
        Me.Lbl_gphno.Size = New System.Drawing.Size(136, 17)
        Me.Lbl_gphno.TabIndex = 84
        Me.Lbl_gphno.Text = "Guardian phone no"
        '
        'Txt_pin
        '
        Me.Txt_pin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pin.Location = New System.Drawing.Point(159, 431)
        Me.Txt_pin.Name = "Txt_pin"
        Me.Txt_pin.Size = New System.Drawing.Size(198, 23)
        Me.Txt_pin.TabIndex = 83
        '
        'Lbl_pinc
        '
        Me.Lbl_pinc.AutoSize = True
        Me.Lbl_pinc.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_pinc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_pinc.ForeColor = System.Drawing.Color.White
        Me.Lbl_pinc.Location = New System.Drawing.Point(12, 437)
        Me.Lbl_pinc.Name = "Lbl_pinc"
        Me.Lbl_pinc.Size = New System.Drawing.Size(61, 17)
        Me.Lbl_pinc.TabIndex = 82
        Me.Lbl_pinc.Text = "Pincode"
        '
        'Txt_post
        '
        Me.Txt_post.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_post.Location = New System.Drawing.Point(159, 403)
        Me.Txt_post.Name = "Txt_post"
        Me.Txt_post.Size = New System.Drawing.Size(198, 23)
        Me.Txt_post.TabIndex = 81
        '
        'Lbl_post
        '
        Me.Lbl_post.AutoSize = True
        Me.Lbl_post.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_post.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_post.ForeColor = System.Drawing.Color.White
        Me.Lbl_post.Location = New System.Drawing.Point(12, 409)
        Me.Lbl_post.Name = "Lbl_post"
        Me.Lbl_post.Size = New System.Drawing.Size(35, 17)
        Me.Lbl_post.TabIndex = 80
        Me.Lbl_post.Text = "Post"
        '
        'Txt_place
        '
        Me.Txt_place.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_place.Location = New System.Drawing.Point(159, 375)
        Me.Txt_place.Name = "Txt_place"
        Me.Txt_place.Size = New System.Drawing.Size(198, 23)
        Me.Txt_place.TabIndex = 79
        '
        'Lbl_place
        '
        Me.Lbl_place.AutoSize = True
        Me.Lbl_place.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_place.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_place.ForeColor = System.Drawing.Color.White
        Me.Lbl_place.Location = New System.Drawing.Point(12, 381)
        Me.Lbl_place.Name = "Lbl_place"
        Me.Lbl_place.Size = New System.Drawing.Size(44, 17)
        Me.Lbl_place.TabIndex = 78
        Me.Lbl_place.Text = "Place"
        '
        'Txt_name
        '
        Me.Txt_name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_name.Location = New System.Drawing.Point(159, 347)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(198, 23)
        Me.Txt_name.TabIndex = 77
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_name.ForeColor = System.Drawing.Color.White
        Me.Lbl_name.Location = New System.Drawing.Point(12, 353)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(48, 17)
        Me.Lbl_name.TabIndex = 76
        Me.Lbl_name.Text = "Name"
        '
        'Lbl_sdate
        '
        Me.Lbl_sdate.AutoSize = True
        Me.Lbl_sdate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sdate.ForeColor = System.Drawing.Color.White
        Me.Lbl_sdate.Location = New System.Drawing.Point(12, 325)
        Me.Lbl_sdate.Name = "Lbl_sdate"
        Me.Lbl_sdate.Size = New System.Drawing.Size(92, 17)
        Me.Lbl_sdate.TabIndex = 75
        Me.Lbl_sdate.Text = "Starting date"
        '
        'Txt_timming
        '
        Me.Txt_timming.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_timming.Location = New System.Drawing.Point(159, 291)
        Me.Txt_timming.Name = "Txt_timming"
        Me.Txt_timming.Size = New System.Drawing.Size(198, 23)
        Me.Txt_timming.TabIndex = 74
        '
        'Lbl_tmg
        '
        Me.Lbl_tmg.AutoSize = True
        Me.Lbl_tmg.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_tmg.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_tmg.ForeColor = System.Drawing.Color.White
        Me.Lbl_tmg.Location = New System.Drawing.Point(12, 297)
        Me.Lbl_tmg.Name = "Lbl_tmg"
        Me.Lbl_tmg.Size = New System.Drawing.Size(62, 17)
        Me.Lbl_tmg.TabIndex = 73
        Me.Lbl_tmg.Text = "Timming"
        '
        'Txt_dur
        '
        Me.Txt_dur.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_dur.Location = New System.Drawing.Point(159, 263)
        Me.Txt_dur.Name = "Txt_dur"
        Me.Txt_dur.Size = New System.Drawing.Size(198, 23)
        Me.Txt_dur.TabIndex = 72
        '
        'Lbl_duration
        '
        Me.Lbl_duration.AutoSize = True
        Me.Lbl_duration.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_duration.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_duration.ForeColor = System.Drawing.Color.White
        Me.Lbl_duration.Location = New System.Drawing.Point(12, 269)
        Me.Lbl_duration.Name = "Lbl_duration"
        Me.Lbl_duration.Size = New System.Drawing.Size(64, 17)
        Me.Lbl_duration.TabIndex = 71
        Me.Lbl_duration.Text = "Duration"
        '
        'Txt_fee
        '
        Me.Txt_fee.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_fee.Location = New System.Drawing.Point(159, 235)
        Me.Txt_fee.Name = "Txt_fee"
        Me.Txt_fee.Size = New System.Drawing.Size(198, 23)
        Me.Txt_fee.TabIndex = 70
        '
        'Lbl_fees
        '
        Me.Lbl_fees.AutoSize = True
        Me.Lbl_fees.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_fees.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_fees.ForeColor = System.Drawing.Color.White
        Me.Lbl_fees.Location = New System.Drawing.Point(12, 241)
        Me.Lbl_fees.Name = "Lbl_fees"
        Me.Lbl_fees.Size = New System.Drawing.Size(35, 17)
        Me.Lbl_fees.TabIndex = 69
        Me.Lbl_fees.Text = "Fees"
        '
        'Txt_course
        '
        Me.Txt_course.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_course.Location = New System.Drawing.Point(159, 207)
        Me.Txt_course.Name = "Txt_course"
        Me.Txt_course.Size = New System.Drawing.Size(198, 23)
        Me.Txt_course.TabIndex = 68
        '
        'Lbl_course
        '
        Me.Lbl_course.AutoSize = True
        Me.Lbl_course.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_course.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_course.ForeColor = System.Drawing.Color.White
        Me.Lbl_course.Location = New System.Drawing.Point(12, 213)
        Me.Lbl_course.Name = "Lbl_course"
        Me.Lbl_course.Size = New System.Drawing.Size(53, 17)
        Me.Lbl_course.TabIndex = 67
        Me.Lbl_course.Text = "Course"
        '
        'Txt_rgno
        '
        Me.Txt_rgno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rgno.Location = New System.Drawing.Point(159, 179)
        Me.Txt_rgno.Name = "Txt_rgno"
        Me.Txt_rgno.Size = New System.Drawing.Size(198, 23)
        Me.Txt_rgno.TabIndex = 66
        '
        'Lbl_rgno
        '
        Me.Lbl_rgno.AutoSize = True
        Me.Lbl_rgno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_rgno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rgno.ForeColor = System.Drawing.Color.White
        Me.Lbl_rgno.Location = New System.Drawing.Point(12, 185)
        Me.Lbl_rgno.Name = "Lbl_rgno"
        Me.Lbl_rgno.Size = New System.Drawing.Size(105, 17)
        Me.Lbl_rgno.TabIndex = 65
        Me.Lbl_rgno.Text = "Registration no"
        '
        'Txt_id
        '
        Me.Txt_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_id.Location = New System.Drawing.Point(159, 151)
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(198, 23)
        Me.Txt_id.TabIndex = 64
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id.ForeColor = System.Drawing.Color.White
        Me.Lbl_id.Location = New System.Drawing.Point(12, 157)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(21, 17)
        Me.Lbl_id.TabIndex = 63
        Me.Lbl_id.Text = "ID"
        '
        'Btn_go
        '
        Me.Btn_go.BackColor = System.Drawing.Color.Transparent
        Me.Btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_go.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_go.ForeColor = System.Drawing.Color.White
        Me.Btn_go.Location = New System.Drawing.Point(820, 152)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(61, 39)
        Me.Btn_go.TabIndex = 50
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = False
        '
        'Cmb_sby
        '
        Me.Cmb_sby.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"id", "registeration no", "course", "fees", "Duration", "Timming", "starting date", "name", "place", "post", "pincode", "district", "phone no", "dob", "office name", "guardian name", "relation", "guardian phone no"})
        Me.Cmb_sby.Location = New System.Drawing.Point(672, 149)
        Me.Cmb_sby.Name = "Cmb_sby"
        Me.Cmb_sby.Size = New System.Drawing.Size(142, 25)
        Me.Cmb_sby.TabIndex = 49
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sdata.Location = New System.Drawing.Point(672, 198)
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(142, 23)
        Me.Txt_sdata.TabIndex = 48
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sdata.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sdata.ForeColor = System.Drawing.Color.White
        Me.Lbl_sdata.Location = New System.Drawing.Point(567, 202)
        Me.Lbl_sdata.Name = "Lbl_sdata"
        Me.Lbl_sdata.Size = New System.Drawing.Size(87, 17)
        Me.Lbl_sdata.TabIndex = 47
        Me.Lbl_sdata.Text = "Search data"
        '
        'Lbl_sby
        '
        Me.Lbl_sby.AutoSize = True
        Me.Lbl_sby.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sby.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sby.ForeColor = System.Drawing.Color.White
        Me.Lbl_sby.Location = New System.Drawing.Point(568, 152)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(68, 17)
        Me.Lbl_sby.TabIndex = 46
        Me.Lbl_sby.Text = "Search By"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(92, 709)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(96, 30)
        Me.btn_save.TabIndex = 93
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.Location = New System.Drawing.Point(452, 709)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(96, 30)
        Me.btn_close.TabIndex = 92
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.Transparent
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.Location = New System.Drawing.Point(332, 709)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(96, 30)
        Me.btn_refresh.TabIndex = 91
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Location = New System.Drawing.Point(212, 709)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(96, 30)
        Me.btn_search.TabIndex = 90
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'Dgv_student_registration
        '
        Me.Dgv_student_registration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_student_registration.Location = New System.Drawing.Point(556, 241)
        Me.Dgv_student_registration.Name = "Dgv_student_registration"
        Me.Dgv_student_registration.Size = New System.Drawing.Size(331, 443)
        Me.Dgv_student_registration.TabIndex = 122
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(572, 709)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 29)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(691, 709)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(94, 28)
        Me.btn_update.TabIndex = 124
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'cbo_district
        '
        Me.cbo_district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_district.FormattingEnabled = True
        Me.cbo_district.Items.AddRange(New Object() {"Kasaragod", "Kannur", "Wayanad", "Kozikode", "Malappuram", "Palakkad", "Thrissur", "Ernamkulam", "Idukki", "Kottayam", "Alappuzha", "Pathanamthitta", "Kollam", "Thiruvananthapuram"})
        Me.cbo_district.Location = New System.Drawing.Point(159, 460)
        Me.cbo_district.Name = "cbo_district"
        Me.cbo_district.Size = New System.Drawing.Size(198, 21)
        Me.cbo_district.TabIndex = 125
        '
        'frm_studentregistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.regwall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(906, 766)
        Me.Controls.Add(Me.cbo_district)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.Dgv_student_registration)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.Btn_go)
        Me.Controls.Add(Me.Txt_sdata)
        Me.Controls.Add(Me.Lbl_sdata)
        Me.Controls.Add(Me.Cmb_sby)
        Me.Controls.Add(Me.Dtp_dob)
        Me.Controls.Add(Me.Dtp_date)
        Me.Controls.Add(Me.Lbl_sby)
        Me.Controls.Add(Me.Btn_browse)
        Me.Controls.Add(Me.pb_stud)
        Me.Controls.Add(Me.Lbl_dis)
        Me.Controls.Add(Me.Txt_phno)
        Me.Controls.Add(Me.Lbl_phno)
        Me.Controls.Add(Me.Lbl_dob)
        Me.Controls.Add(Me.Txt_oname)
        Me.Controls.Add(Me.Lbl_oname)
        Me.Controls.Add(Me.Txt_gname)
        Me.Controls.Add(Me.Lbl_gname)
        Me.Controls.Add(Me.Txt_relation)
        Me.Controls.Add(Me.Lbl_rela)
        Me.Controls.Add(Me.txt_gphno)
        Me.Controls.Add(Me.Lbl_gphno)
        Me.Controls.Add(Me.Txt_pin)
        Me.Controls.Add(Me.Lbl_pinc)
        Me.Controls.Add(Me.Txt_post)
        Me.Controls.Add(Me.Lbl_post)
        Me.Controls.Add(Me.Txt_place)
        Me.Controls.Add(Me.Lbl_place)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Lbl_name)
        Me.Controls.Add(Me.Lbl_sdate)
        Me.Controls.Add(Me.Txt_timming)
        Me.Controls.Add(Me.Lbl_tmg)
        Me.Controls.Add(Me.Txt_dur)
        Me.Controls.Add(Me.Lbl_duration)
        Me.Controls.Add(Me.Txt_fee)
        Me.Controls.Add(Me.Lbl_fees)
        Me.Controls.Add(Me.Txt_course)
        Me.Controls.Add(Me.Lbl_course)
        Me.Controls.Add(Me.Txt_rgno)
        Me.Controls.Add(Me.Lbl_rgno)
        Me.Controls.Add(Me.Txt_id)
        Me.Controls.Add(Me.Lbl_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_studentregistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Registration"
        CType(Me.pb_stud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_student_registration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dtp_dob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Btn_browse As System.Windows.Forms.Button
    Friend WithEvents pb_stud As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_dis As System.Windows.Forms.Label
    Friend WithEvents Txt_phno As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_phno As System.Windows.Forms.Label
    Friend WithEvents Lbl_dob As System.Windows.Forms.Label
    Friend WithEvents Txt_oname As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_oname As System.Windows.Forms.Label
    Friend WithEvents Txt_gname As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_gname As System.Windows.Forms.Label
    Friend WithEvents Txt_relation As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_rela As System.Windows.Forms.Label
    Friend WithEvents txt_gphno As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_gphno As System.Windows.Forms.Label
    Friend WithEvents Txt_pin As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_pinc As System.Windows.Forms.Label
    Friend WithEvents Txt_post As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_post As System.Windows.Forms.Label
    Friend WithEvents Txt_place As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_place As System.Windows.Forms.Label
    Friend WithEvents Txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents Lbl_sdate As System.Windows.Forms.Label
    Friend WithEvents Txt_timming As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_tmg As System.Windows.Forms.Label
    Friend WithEvents Txt_dur As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_duration As System.Windows.Forms.Label
    Friend WithEvents Txt_fee As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_fees As System.Windows.Forms.Label
    Friend WithEvents Txt_course As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_course As System.Windows.Forms.Label
    Friend WithEvents Txt_rgno As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_rgno As System.Windows.Forms.Label
    Friend WithEvents Txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_id As System.Windows.Forms.Label
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button


    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistrationnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FeesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DurationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimmingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StartingdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlaceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PincodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DistrictDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhonenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OfficenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuardiannameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RelationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuardiannoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecycleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dgv_student_registration As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents cbo_district As System.Windows.Forms.ComboBox
End Class
