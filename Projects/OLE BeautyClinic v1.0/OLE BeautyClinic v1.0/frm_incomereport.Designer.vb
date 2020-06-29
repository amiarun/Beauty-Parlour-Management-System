<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_incomereport
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
        Me.Cmb_sby = New System.Windows.Forms.ComboBox
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.Lbl_sby = New System.Windows.Forms.Label
        Me.Txt_sdata = New System.Windows.Forms.TextBox
        Me.dgv_incomerep = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Btn_clo = New System.Windows.Forms.Button
        Me.Btn_refres = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgv_incomerep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_go
        '
        Me.btn_go.BackColor = System.Drawing.Color.Transparent
        Me.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_go.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_go.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_go.Location = New System.Drawing.Point(474, 126)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(65, 33)
        Me.btn_go.TabIndex = 156
        Me.btn_go.Text = "GO"
        Me.btn_go.UseVisualStyleBackColor = False
        '
        'Cmb_sby
        '
        Me.Cmb_sby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cmb_sby.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_sby.ForeColor = System.Drawing.Color.Black
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"id", "particular", "amount", "date"})
        Me.Cmb_sby.Location = New System.Drawing.Point(223, 160)
        Me.Cmb_sby.Name = "Cmb_sby"
        Me.Cmb_sby.Size = New System.Drawing.Size(217, 23)
        Me.Cmb_sby.TabIndex = 153
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sdata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_sdata.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sdata.ForeColor = System.Drawing.Color.Black
        Me.Lbl_sdata.Location = New System.Drawing.Point(109, 167)
        Me.Lbl_sdata.Name = "Lbl_sdata"
        Me.Lbl_sdata.Size = New System.Drawing.Size(88, 17)
        Me.Lbl_sdata.TabIndex = 154
        Me.Lbl_sdata.Text = "Search Data"
        '
        'Lbl_sby
        '
        Me.Lbl_sby.AutoSize = True
        Me.Lbl_sby.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sby.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_sby.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sby.ForeColor = System.Drawing.Color.Black
        Me.Lbl_sby.Location = New System.Drawing.Point(109, 110)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(68, 17)
        Me.Lbl_sby.TabIndex = 152
        Me.Lbl_sby.Text = "Search By"
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sdata.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sdata.ForeColor = System.Drawing.Color.Black
        Me.Txt_sdata.Location = New System.Drawing.Point(223, 104)
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(218, 22)
        Me.Txt_sdata.TabIndex = 155
        '
        'dgv_incomerep
        '
        Me.dgv_incomerep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_incomerep.Location = New System.Drawing.Point(56, 205)
        Me.dgv_incomerep.Name = "dgv_incomerep"
        Me.dgv_incomerep.Size = New System.Drawing.Size(499, 262)
        Me.dgv_incomerep.TabIndex = 157
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(253, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 29)
        Me.Button1.TabIndex = 160
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn_clo
        '
        Me.Btn_clo.BackColor = System.Drawing.Color.Transparent
        Me.Btn_clo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_clo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_clo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_clo.Location = New System.Drawing.Point(418, 488)
        Me.Btn_clo.Name = "Btn_clo"
        Me.Btn_clo.Size = New System.Drawing.Size(100, 30)
        Me.Btn_clo.TabIndex = 159
        Me.Btn_clo.Text = "Close"
        Me.Btn_clo.UseVisualStyleBackColor = False
        '
        'Btn_refres
        '
        Me.Btn_refres.BackColor = System.Drawing.Color.Transparent
        Me.Btn_refres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_refres.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_refres.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_refres.Location = New System.Drawing.Point(76, 487)
        Me.Btn_refres.Name = "Btn_refres"
        Me.Btn_refres.Size = New System.Drawing.Size(100, 30)
        Me.Btn_refres.TabIndex = 158
        Me.Btn_refres.Text = "Refresh"
        Me.Btn_refres.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(188, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 57)
        Me.Label1.TabIndex = 161
        Me.Label1.Text = "Income Report"
        '
        'frm_incomereport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.repwall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(650, 557)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_clo)
        Me.Controls.Add(Me.Btn_refres)
        Me.Controls.Add(Me.dgv_incomerep)
        Me.Controls.Add(Me.btn_go)
        Me.Controls.Add(Me.Cmb_sby)
        Me.Controls.Add(Me.Lbl_sdata)
        Me.Controls.Add(Me.Lbl_sby)
        Me.Controls.Add(Me.Txt_sdata)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_incomereport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgv_incomerep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents dgv_incomerep As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Btn_clo As System.Windows.Forms.Button
    Friend WithEvents Btn_refres As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
