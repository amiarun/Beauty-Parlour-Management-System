<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_servicepackage
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
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_refresh = New System.Windows.Forms.Button
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.txt_amount = New System.Windows.Forms.TextBox
        Me.txt_item = New System.Windows.Forms.TextBox
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.Lbl_pincode = New System.Windows.Forms.Label
        Me.Lbl_post = New System.Windows.Forms.Label
        Me.Lbl_place = New System.Windows.Forms.Label
        Me.Lbl_hname = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.Txt_data = New System.Windows.Forms.TextBox
        Me.Lbl_data = New System.Windows.Forms.Label
        Me.Cmb_searchby = New System.Windows.Forms.ComboBox
        Me.Lbl_searb = New System.Windows.Forms.Label
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.dgv_servivereg = New System.Windows.Forms.DataGridView
        Me.btn_search = New System.Windows.Forms.Button
        CType(Me.dgv_servivereg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Transparent
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(98, 491)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(89, 39)
        Me.btn_save.TabIndex = 92
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
        Me.btn_close.Location = New System.Drawing.Point(718, 491)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(89, 39)
        Me.btn_close.TabIndex = 93
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
        Me.btn_refresh.Location = New System.Drawing.Point(222, 491)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(89, 39)
        Me.btn_refresh.TabIndex = 91
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'txt_id
        '
        Me.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.Black
        Me.txt_id.Location = New System.Drawing.Point(160, 107)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(181, 21)
        Me.txt_id.TabIndex = 106
        '
        'txt_amount
        '
        Me.txt_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_amount.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount.ForeColor = System.Drawing.Color.Black
        Me.txt_amount.Location = New System.Drawing.Point(160, 245)
        Me.txt_amount.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(181, 21)
        Me.txt_amount.TabIndex = 101
        '
        'txt_item
        '
        Me.txt_item.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_item.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_item.ForeColor = System.Drawing.Color.Black
        Me.txt_item.Location = New System.Drawing.Point(160, 199)
        Me.txt_item.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_item.Name = "txt_item"
        Me.txt_item.Size = New System.Drawing.Size(181, 21)
        Me.txt_item.TabIndex = 100
        '
        'txt_name
        '
        Me.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_name.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.Color.Black
        Me.txt_name.Location = New System.Drawing.Point(160, 148)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(181, 21)
        Me.txt_name.TabIndex = 99
        '
        'Lbl_pincode
        '
        Me.Lbl_pincode.AutoSize = True
        Me.Lbl_pincode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_pincode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_pincode.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_pincode.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_pincode.Location = New System.Drawing.Point(22, 245)
        Me.Lbl_pincode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_pincode.Name = "Lbl_pincode"
        Me.Lbl_pincode.Size = New System.Drawing.Size(75, 21)
        Me.Lbl_pincode.TabIndex = 98
        Me.Lbl_pincode.Text = "Amount"
        '
        'Lbl_post
        '
        Me.Lbl_post.AutoSize = True
        Me.Lbl_post.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_post.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_post.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_post.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_post.Location = New System.Drawing.Point(26, 199)
        Me.Lbl_post.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_post.Name = "Lbl_post"
        Me.Lbl_post.Size = New System.Drawing.Size(47, 21)
        Me.Lbl_post.TabIndex = 97
        Me.Lbl_post.Text = "Item"
        '
        'Lbl_place
        '
        Me.Lbl_place.AutoSize = True
        Me.Lbl_place.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_place.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_place.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_place.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_place.Location = New System.Drawing.Point(22, 146)
        Me.Lbl_place.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_place.Name = "Lbl_place"
        Me.Lbl_place.Size = New System.Drawing.Size(58, 21)
        Me.Lbl_place.TabIndex = 96
        Me.Lbl_place.Text = "Name"
        '
        'Lbl_hname
        '
        Me.Lbl_hname.AutoSize = True
        Me.Lbl_hname.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_hname.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_hname.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_hname.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_hname.Location = New System.Drawing.Point(22, 105)
        Me.Lbl_hname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_hname.Name = "Lbl_hname"
        Me.Lbl_hname.Size = New System.Drawing.Size(27, 21)
        Me.Lbl_hname.TabIndex = 95
        Me.Lbl_hname.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(559, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 21)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(559, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 21)
        Me.Label1.TabIndex = 126
        Me.Label1.Text = ":"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(803, 105)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 43)
        Me.Button4.TabIndex = 124
        Me.Button4.Text = "GO"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Txt_data
        '
        Me.Txt_data.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_data.ForeColor = System.Drawing.Color.Black
        Me.Txt_data.Location = New System.Drawing.Point(610, 149)
        Me.Txt_data.Margin = New System.Windows.Forms.Padding(2)
        Me.Txt_data.Multiline = True
        Me.Txt_data.Name = "Txt_data"
        Me.Txt_data.Size = New System.Drawing.Size(173, 29)
        Me.Txt_data.TabIndex = 123
        '
        'Lbl_data
        '
        Me.Lbl_data.AutoSize = True
        Me.Lbl_data.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_data.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_data.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_data.Location = New System.Drawing.Point(418, 157)
        Me.Lbl_data.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_data.Name = "Lbl_data"
        Me.Lbl_data.Size = New System.Drawing.Size(109, 21)
        Me.Lbl_data.TabIndex = 122
        Me.Lbl_data.Text = "Search Data"
        '
        'Cmb_searchby
        '
        Me.Cmb_searchby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cmb_searchby.ForeColor = System.Drawing.Color.Black
        Me.Cmb_searchby.FormattingEnabled = True
        Me.Cmb_searchby.Items.AddRange(New Object() {"id ", "name", "item", "amount"})
        Me.Cmb_searchby.Location = New System.Drawing.Point(610, 102)
        Me.Cmb_searchby.Margin = New System.Windows.Forms.Padding(2)
        Me.Cmb_searchby.Name = "Cmb_searchby"
        Me.Cmb_searchby.Size = New System.Drawing.Size(173, 21)
        Me.Cmb_searchby.TabIndex = 121
        '
        'Lbl_searb
        '
        Me.Lbl_searb.AutoSize = True
        Me.Lbl_searb.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_searb.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_searb.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_searb.Location = New System.Drawing.Point(418, 102)
        Me.Lbl_searb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_searb.Name = "Lbl_searb"
        Me.Lbl_searb.Size = New System.Drawing.Size(85, 21)
        Me.Lbl_searb.TabIndex = 120
        Me.Lbl_searb.Text = "Search By"
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Transparent
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.White
        Me.btn_update.Location = New System.Drawing.Point(346, 491)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(89, 39)
        Me.btn_update.TabIndex = 91
        Me.btn_update.Text = "update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(470, 491)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(89, 39)
        Me.btn_delete.TabIndex = 90
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'dgv_servivereg
        '
        Me.dgv_servivereg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_servivereg.Location = New System.Drawing.Point(422, 199)
        Me.dgv_servivereg.Name = "dgv_servivereg"
        Me.dgv_servivereg.Size = New System.Drawing.Size(448, 251)
        Me.dgv_servivereg.TabIndex = 127
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.Transparent
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.White
        Me.btn_search.Location = New System.Drawing.Point(594, 491)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(89, 39)
        Me.btn_search.TabIndex = 128
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'frm_servicepackage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.regwall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(896, 557)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.dgv_servivereg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Txt_data)
        Me.Controls.Add(Me.Lbl_data)
        Me.Controls.Add(Me.Cmb_searchby)
        Me.Controls.Add(Me.Lbl_searb)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.txt_item)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Lbl_pincode)
        Me.Controls.Add(Me.Lbl_post)
        Me.Controls.Add(Me.Lbl_place)
        Me.Controls.Add(Me.Lbl_hname)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_refresh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_servicepackage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service Package"
        CType(Me.dgv_servivereg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_amount As System.Windows.Forms.TextBox
    Friend WithEvents txt_item As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_pincode As System.Windows.Forms.Label
    Friend WithEvents Lbl_post As System.Windows.Forms.Label
    Friend WithEvents Lbl_place As System.Windows.Forms.Label
    Friend WithEvents Lbl_hname As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Txt_data As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_data As System.Windows.Forms.Label
    Friend WithEvents Cmb_searchby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_searb As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents dgv_servivereg As System.Windows.Forms.DataGridView
    Friend WithEvents btn_search As System.Windows.Forms.Button
End Class
