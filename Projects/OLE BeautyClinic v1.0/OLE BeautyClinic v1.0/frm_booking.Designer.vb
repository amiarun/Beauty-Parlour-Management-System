<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_booking
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
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RegisternoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PincodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CategoriesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RecycleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_save = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Btn_search = New System.Windows.Forms.Button
        Me.Btn_refresh = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.dtp_date = New System.Windows.Forms.DateTimePicker
        Me.Cbo_ctry = New System.Windows.Forms.ComboBox
        Me.Lbl_cate = New System.Windows.Forms.Label
        Me.Txt_pin = New System.Windows.Forms.TextBox
        Me.Lbl_pin = New System.Windows.Forms.Label
        Me.Txt_place = New System.Windows.Forms.TextBox
        Me.Lbl_place = New System.Windows.Forms.Label
        Me.Lbl_site = New System.Windows.Forms.Label
        Me.Lbl_date = New System.Windows.Forms.Label
        Me.Txt_time = New System.Windows.Forms.TextBox
        Me.Lbl_time = New System.Windows.Forms.Label
        Me.Txt_name = New System.Windows.Forms.TextBox
        Me.Lbl_name = New System.Windows.Forms.Label
        Me.Txt_rgno = New System.Windows.Forms.TextBox
        Me.Lbl_rgno = New System.Windows.Forms.Label
        Me.Txt_id = New System.Windows.Forms.TextBox
        Me.Lbl_id = New System.Windows.Forms.Label
        Me.Btn_go = New System.Windows.Forms.Button
        Me.Txt_sdata = New System.Windows.Forms.TextBox
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.Cbo_sby = New System.Windows.Forms.ComboBox
        Me.Lbl_sby = New System.Windows.Forms.Label
        Me.Dgv_booking = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbo_site = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.Dgv_booking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'RegisternoDataGridViewTextBoxColumn
        '
        Me.RegisternoDataGridViewTextBoxColumn.DataPropertyName = "Registerno"
        Me.RegisternoDataGridViewTextBoxColumn.HeaderText = "Registerno"
        Me.RegisternoDataGridViewTextBoxColumn.Name = "RegisternoDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'TimeDataGridViewTextBoxColumn
        '
        Me.TimeDataGridViewTextBoxColumn.DataPropertyName = "Time"
        Me.TimeDataGridViewTextBoxColumn.HeaderText = "Time"
        Me.TimeDataGridViewTextBoxColumn.Name = "TimeDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'SiteDataGridViewTextBoxColumn
        '
        Me.SiteDataGridViewTextBoxColumn.DataPropertyName = "Site"
        Me.SiteDataGridViewTextBoxColumn.HeaderText = "Site"
        Me.SiteDataGridViewTextBoxColumn.Name = "SiteDataGridViewTextBoxColumn"
        '
        'PlaceDataGridViewTextBoxColumn
        '
        Me.PlaceDataGridViewTextBoxColumn.DataPropertyName = "Place"
        Me.PlaceDataGridViewTextBoxColumn.HeaderText = "Place"
        Me.PlaceDataGridViewTextBoxColumn.Name = "PlaceDataGridViewTextBoxColumn"
        '
        'PincodeDataGridViewTextBoxColumn
        '
        Me.PincodeDataGridViewTextBoxColumn.DataPropertyName = "Pincode"
        Me.PincodeDataGridViewTextBoxColumn.HeaderText = "Pincode"
        Me.PincodeDataGridViewTextBoxColumn.Name = "PincodeDataGridViewTextBoxColumn"
        '
        'CategoriesDataGridViewTextBoxColumn
        '
        Me.CategoriesDataGridViewTextBoxColumn.DataPropertyName = "Categories"
        Me.CategoriesDataGridViewTextBoxColumn.HeaderText = "Categories"
        Me.CategoriesDataGridViewTextBoxColumn.Name = "CategoriesDataGridViewTextBoxColumn"
        '
        'RecycleDataGridViewTextBoxColumn
        '
        Me.RecycleDataGridViewTextBoxColumn.DataPropertyName = "Recycle"
        Me.RecycleDataGridViewTextBoxColumn.HeaderText = "Recycle"
        Me.RecycleDataGridViewTextBoxColumn.Name = "RecycleDataGridViewTextBoxColumn"
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(368, 379)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(98, 33)
        Me.btn_save.TabIndex = 106
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(368, 431)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 33)
        Me.Button1.TabIndex = 104
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn_search
        '
        Me.Btn_search.BackColor = System.Drawing.Color.Transparent
        Me.Btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_search.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_search.ForeColor = System.Drawing.Color.White
        Me.Btn_search.Location = New System.Drawing.Point(368, 267)
        Me.Btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(98, 33)
        Me.Btn_search.TabIndex = 105
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
        Me.Btn_refresh.Location = New System.Drawing.Point(368, 323)
        Me.Btn_refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_refresh.Name = "Btn_refresh"
        Me.Btn_refresh.Size = New System.Drawing.Size(98, 33)
        Me.Btn_refresh.TabIndex = 102
        Me.Btn_refresh.Text = "Refresh"
        Me.Btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(518, 546)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(98, 33)
        Me.btn_update.TabIndex = 107
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'dtp_date
        '
        Me.dtp_date.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_date.Location = New System.Drawing.Point(144, 329)
        Me.dtp_date.Name = "dtp_date"
        Me.dtp_date.Size = New System.Drawing.Size(190, 22)
        Me.dtp_date.TabIndex = 109
        '
        'Cbo_ctry
        '
        Me.Cbo_ctry.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_ctry.FormattingEnabled = True
        Me.Cbo_ctry.Location = New System.Drawing.Point(144, 522)
        Me.Cbo_ctry.Name = "Cbo_ctry"
        Me.Cbo_ctry.Size = New System.Drawing.Size(188, 23)
        Me.Cbo_ctry.TabIndex = 126
        '
        'Lbl_cate
        '
        Me.Lbl_cate.AutoSize = True
        Me.Lbl_cate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_cate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_cate.ForeColor = System.Drawing.Color.White
        Me.Lbl_cate.Location = New System.Drawing.Point(30, 529)
        Me.Lbl_cate.Name = "Lbl_cate"
        Me.Lbl_cate.Size = New System.Drawing.Size(69, 17)
        Me.Lbl_cate.TabIndex = 125
        Me.Lbl_cate.Text = "Category"
        '
        'Txt_pin
        '
        Me.Txt_pin.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pin.Location = New System.Drawing.Point(144, 478)
        Me.Txt_pin.Name = "Txt_pin"
        Me.Txt_pin.Size = New System.Drawing.Size(190, 22)
        Me.Txt_pin.TabIndex = 124
        '
        'Lbl_pin
        '
        Me.Lbl_pin.AutoSize = True
        Me.Lbl_pin.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_pin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_pin.ForeColor = System.Drawing.Color.White
        Me.Lbl_pin.Location = New System.Drawing.Point(30, 480)
        Me.Lbl_pin.Name = "Lbl_pin"
        Me.Lbl_pin.Size = New System.Drawing.Size(61, 17)
        Me.Lbl_pin.TabIndex = 123
        Me.Lbl_pin.Text = "Pincode"
        '
        'Txt_place
        '
        Me.Txt_place.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_place.Location = New System.Drawing.Point(144, 429)
        Me.Txt_place.Name = "Txt_place"
        Me.Txt_place.Size = New System.Drawing.Size(190, 22)
        Me.Txt_place.TabIndex = 122
        '
        'Lbl_place
        '
        Me.Lbl_place.AutoSize = True
        Me.Lbl_place.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_place.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_place.ForeColor = System.Drawing.Color.White
        Me.Lbl_place.Location = New System.Drawing.Point(30, 431)
        Me.Lbl_place.Name = "Lbl_place"
        Me.Lbl_place.Size = New System.Drawing.Size(44, 17)
        Me.Lbl_place.TabIndex = 121
        Me.Lbl_place.Text = "Place"
        '
        'Lbl_site
        '
        Me.Lbl_site.AutoSize = True
        Me.Lbl_site.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_site.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_site.ForeColor = System.Drawing.Color.White
        Me.Lbl_site.Location = New System.Drawing.Point(30, 382)
        Me.Lbl_site.Name = "Lbl_site"
        Me.Lbl_site.Size = New System.Drawing.Size(30, 17)
        Me.Lbl_site.TabIndex = 118
        Me.Lbl_site.Text = "Site"
        '
        'Lbl_date
        '
        Me.Lbl_date.AutoSize = True
        Me.Lbl_date.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_date.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_date.ForeColor = System.Drawing.Color.White
        Me.Lbl_date.Location = New System.Drawing.Point(30, 333)
        Me.Lbl_date.Name = "Lbl_date"
        Me.Lbl_date.Size = New System.Drawing.Size(40, 17)
        Me.Lbl_date.TabIndex = 117
        Me.Lbl_date.Text = "Date"
        '
        'Txt_time
        '
        Me.Txt_time.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_time.Location = New System.Drawing.Point(144, 281)
        Me.Txt_time.Name = "Txt_time"
        Me.Txt_time.Size = New System.Drawing.Size(190, 22)
        Me.Txt_time.TabIndex = 116
        '
        'Lbl_time
        '
        Me.Lbl_time.AutoSize = True
        Me.Lbl_time.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_time.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_time.ForeColor = System.Drawing.Color.White
        Me.Lbl_time.Location = New System.Drawing.Point(30, 284)
        Me.Lbl_time.Name = "Lbl_time"
        Me.Lbl_time.Size = New System.Drawing.Size(37, 17)
        Me.Lbl_time.TabIndex = 115
        Me.Lbl_time.Text = "Time"
        '
        'Txt_name
        '
        Me.Txt_name.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_name.Location = New System.Drawing.Point(144, 230)
        Me.Txt_name.Name = "Txt_name"
        Me.Txt_name.Size = New System.Drawing.Size(190, 22)
        Me.Txt_name.TabIndex = 114
        '
        'Lbl_name
        '
        Me.Lbl_name.AutoSize = True
        Me.Lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_name.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_name.ForeColor = System.Drawing.Color.White
        Me.Lbl_name.Location = New System.Drawing.Point(30, 235)
        Me.Lbl_name.Name = "Lbl_name"
        Me.Lbl_name.Size = New System.Drawing.Size(48, 17)
        Me.Lbl_name.TabIndex = 113
        Me.Lbl_name.Text = "Name"
        '
        'Txt_rgno
        '
        Me.Txt_rgno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_rgno.Location = New System.Drawing.Point(144, 183)
        Me.Txt_rgno.Name = "Txt_rgno"
        Me.Txt_rgno.Size = New System.Drawing.Size(190, 22)
        Me.Txt_rgno.TabIndex = 112
        '
        'Lbl_rgno
        '
        Me.Lbl_rgno.AutoSize = True
        Me.Lbl_rgno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_rgno.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_rgno.ForeColor = System.Drawing.Color.White
        Me.Lbl_rgno.Location = New System.Drawing.Point(30, 186)
        Me.Lbl_rgno.Name = "Lbl_rgno"
        Me.Lbl_rgno.Size = New System.Drawing.Size(79, 17)
        Me.Lbl_rgno.TabIndex = 111
        Me.Lbl_rgno.Text = "Register no"
        '
        'Txt_id
        '
        Me.Txt_id.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_id.Location = New System.Drawing.Point(144, 135)
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(190, 22)
        Me.Txt_id.TabIndex = 110
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_id.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id.ForeColor = System.Drawing.Color.White
        Me.Lbl_id.Location = New System.Drawing.Point(30, 137)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(21, 17)
        Me.Lbl_id.TabIndex = 108
        Me.Lbl_id.Text = "ID"
        '
        'Btn_go
        '
        Me.Btn_go.BackColor = System.Drawing.Color.Transparent
        Me.Btn_go.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_go.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_go.ForeColor = System.Drawing.Color.White
        Me.Btn_go.Location = New System.Drawing.Point(828, 143)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(72, 35)
        Me.Btn_go.TabIndex = 142
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = False
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sdata.ForeColor = System.Drawing.Color.Black
        Me.Txt_sdata.Location = New System.Drawing.Point(655, 186)
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(153, 21)
        Me.Txt_sdata.TabIndex = 140
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sdata.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sdata.ForeColor = System.Drawing.Color.White
        Me.Lbl_sdata.Location = New System.Drawing.Point(534, 187)
        Me.Lbl_sdata.Name = "Lbl_sdata"
        Me.Lbl_sdata.Size = New System.Drawing.Size(87, 17)
        Me.Lbl_sdata.TabIndex = 139
        Me.Lbl_sdata.Text = "Search data"
        '
        'Cbo_sby
        '
        Me.Cbo_sby.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_sby.ForeColor = System.Drawing.Color.Black
        Me.Cbo_sby.FormattingEnabled = True
        Me.Cbo_sby.Location = New System.Drawing.Point(655, 126)
        Me.Cbo_sby.Name = "Cbo_sby"
        Me.Cbo_sby.Size = New System.Drawing.Size(153, 24)
        Me.Cbo_sby.TabIndex = 137
        '
        'Lbl_sby
        '
        Me.Lbl_sby.AutoSize = True
        Me.Lbl_sby.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sby.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sby.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Lbl_sby.Location = New System.Drawing.Point(534, 129)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(68, 17)
        Me.Lbl_sby.TabIndex = 136
        Me.Lbl_sby.Text = "Search By"
        '
        'Dgv_booking
        '
        Me.Dgv_booking.Location = New System.Drawing.Point(482, 227)
        Me.Dgv_booking.Name = "Dgv_booking"
        Me.Dgv_booking.Size = New System.Drawing.Size(418, 303)
        Me.Dgv_booking.TabIndex = 143
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(279, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 57)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Booking Registration"
        '
        'cbo_site
        '
        Me.cbo_site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_site.FormattingEnabled = True
        Me.cbo_site.Items.AddRange(New Object() {"Indoor", "Outdoor"})
        Me.cbo_site.Location = New System.Drawing.Point(144, 376)
        Me.cbo_site.Name = "cbo_site"
        Me.cbo_site.Size = New System.Drawing.Size(187, 21)
        Me.cbo_site.TabIndex = 145
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(651, 547)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(101, 32)
        Me.Button3.TabIndex = 146
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frm_booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.regwall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(912, 612)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cbo_site)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dgv_booking)
        Me.Controls.Add(Me.Btn_go)
        Me.Controls.Add(Me.Txt_sdata)
        Me.Controls.Add(Me.Lbl_sdata)
        Me.Controls.Add(Me.Cbo_sby)
        Me.Controls.Add(Me.Lbl_sby)
        Me.Controls.Add(Me.dtp_date)
        Me.Controls.Add(Me.Cbo_ctry)
        Me.Controls.Add(Me.Lbl_cate)
        Me.Controls.Add(Me.Txt_pin)
        Me.Controls.Add(Me.Lbl_pin)
        Me.Controls.Add(Me.Txt_place)
        Me.Controls.Add(Me.Lbl_place)
        Me.Controls.Add(Me.Lbl_site)
        Me.Controls.Add(Me.Lbl_date)
        Me.Controls.Add(Me.Txt_time)
        Me.Controls.Add(Me.Lbl_time)
        Me.Controls.Add(Me.Txt_name)
        Me.Controls.Add(Me.Lbl_name)
        Me.Controls.Add(Me.Txt_rgno)
        Me.Controls.Add(Me.Lbl_rgno)
        Me.Controls.Add(Me.Txt_id)
        Me.Controls.Add(Me.Lbl_id)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.Btn_refresh)
        Me.Name = "frm_booking"
        Me.Text = "frm_booking"
        CType(Me.Dgv_booking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegisternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PlaceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PincodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecycleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Btn_search As System.Windows.Forms.Button
    Friend WithEvents Btn_refresh As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents dtp_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cbo_ctry As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_cate As System.Windows.Forms.Label
    Friend WithEvents Txt_pin As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_pin As System.Windows.Forms.Label
    Friend WithEvents Txt_place As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_place As System.Windows.Forms.Label
    Friend WithEvents Lbl_site As System.Windows.Forms.Label
    Friend WithEvents Lbl_date As System.Windows.Forms.Label
    Friend WithEvents Txt_time As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_time As System.Windows.Forms.Label
    Friend WithEvents Txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_name As System.Windows.Forms.Label
    Friend WithEvents Txt_rgno As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_rgno As System.Windows.Forms.Label
    Friend WithEvents Txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_id As System.Windows.Forms.Label
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Cbo_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents Dgv_booking As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbo_site As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
