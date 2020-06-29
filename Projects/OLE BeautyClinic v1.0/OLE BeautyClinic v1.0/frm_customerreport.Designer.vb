<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_customerreport
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
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RegistrationnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HousenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PlaceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PincodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DistrictDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PhonenoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RECYCLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btn_go = New System.Windows.Forms.Button
        Me.Cmb_sby = New System.Windows.Forms.ComboBox
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.Lbl_sby = New System.Windows.Forms.Label
        Me.Txt_sdata = New System.Windows.Forms.TextBox
        Me.dgv_custreport = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.Btn_clo = New System.Windows.Forms.Button
        Me.Btn_refres = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgv_custreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'RegistrationnoDataGridViewTextBoxColumn
        '
        Me.RegistrationnoDataGridViewTextBoxColumn.Name = "RegistrationnoDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'HousenameDataGridViewTextBoxColumn
        '
        Me.HousenameDataGridViewTextBoxColumn.Name = "HousenameDataGridViewTextBoxColumn"
        '
        'PlaceDataGridViewTextBoxColumn
        '
        Me.PlaceDataGridViewTextBoxColumn.Name = "PlaceDataGridViewTextBoxColumn"
        '
        'PincodeDataGridViewTextBoxColumn
        '
        Me.PincodeDataGridViewTextBoxColumn.Name = "PincodeDataGridViewTextBoxColumn"
        '
        'PostDataGridViewTextBoxColumn
        '
        Me.PostDataGridViewTextBoxColumn.Name = "PostDataGridViewTextBoxColumn"
        '
        'DistrictDataGridViewTextBoxColumn
        '
        Me.DistrictDataGridViewTextBoxColumn.Name = "DistrictDataGridViewTextBoxColumn"
        '
        'PhonenoDataGridViewTextBoxColumn
        '
        Me.PhonenoDataGridViewTextBoxColumn.Name = "PhonenoDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'RECYCLEDataGridViewTextBoxColumn
        '
        Me.RECYCLEDataGridViewTextBoxColumn.Name = "RECYCLEDataGridViewTextBoxColumn"
        '
        'btn_go
        '
        Me.btn_go.BackColor = System.Drawing.Color.Transparent
        Me.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_go.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_go.ForeColor = System.Drawing.Color.Black
        Me.btn_go.Location = New System.Drawing.Point(420, 162)
        Me.btn_go.Name = "btn_go"
        Me.btn_go.Size = New System.Drawing.Size(66, 38)
        Me.btn_go.TabIndex = 78
        Me.btn_go.Text = "GO"
        Me.btn_go.UseVisualStyleBackColor = False
        '
        'Cmb_sby
        '
        Me.Cmb_sby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cmb_sby.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_sby.ForeColor = System.Drawing.Color.Black
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"id", "register no", "name", "dob", "house name", "place", "post", "pincode", "district", "phone no", "category"})
        Me.Cmb_sby.Location = New System.Drawing.Point(172, 146)
        Me.Cmb_sby.Name = "Cmb_sby"
        Me.Cmb_sby.Size = New System.Drawing.Size(217, 23)
        Me.Cmb_sby.TabIndex = 73
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sdata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_sdata.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sdata.ForeColor = System.Drawing.Color.Black
        Me.Lbl_sdata.Location = New System.Drawing.Point(61, 203)
        Me.Lbl_sdata.Name = "Lbl_sdata"
        Me.Lbl_sdata.Size = New System.Drawing.Size(88, 17)
        Me.Lbl_sdata.TabIndex = 74
        Me.Lbl_sdata.Text = "Search Data"
        '
        'Lbl_sby
        '
        Me.Lbl_sby.AutoSize = True
        Me.Lbl_sby.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sby.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_sby.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sby.ForeColor = System.Drawing.Color.Black
        Me.Lbl_sby.Location = New System.Drawing.Point(61, 146)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(68, 17)
        Me.Lbl_sby.TabIndex = 72
        Me.Lbl_sby.Text = "Search By"
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sdata.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sdata.ForeColor = System.Drawing.Color.Black
        Me.Txt_sdata.Location = New System.Drawing.Point(172, 203)
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(218, 22)
        Me.Txt_sdata.TabIndex = 75
        '
        'dgv_custreport
        '
        Me.dgv_custreport.Location = New System.Drawing.Point(45, 247)
        Me.dgv_custreport.Name = "dgv_custreport"
        Me.dgv_custreport.Size = New System.Drawing.Size(516, 207)
        Me.dgv_custreport.TabIndex = 79
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(228, 477)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 33)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn_clo
        '
        Me.Btn_clo.BackColor = System.Drawing.Color.Transparent
        Me.Btn_clo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_clo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_clo.ForeColor = System.Drawing.Color.Black
        Me.Btn_clo.Location = New System.Drawing.Point(403, 477)
        Me.Btn_clo.Name = "Btn_clo"
        Me.Btn_clo.Size = New System.Drawing.Size(104, 33)
        Me.Btn_clo.TabIndex = 81
        Me.Btn_clo.Text = "Close"
        Me.Btn_clo.UseVisualStyleBackColor = False
        '
        'Btn_refres
        '
        Me.Btn_refres.BackColor = System.Drawing.Color.Transparent
        Me.Btn_refres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_refres.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_refres.ForeColor = System.Drawing.Color.Black
        Me.Btn_refres.Location = New System.Drawing.Point(83, 477)
        Me.Btn_refres.Name = "Btn_refres"
        Me.Btn_refres.Size = New System.Drawing.Size(90, 33)
        Me.Btn_refres.TabIndex = 80
        Me.Btn_refres.Text = "Refresh"
        Me.Btn_refres.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(218, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 57)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Customer Report"
        '
        'frm_customerreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.repwall
        Me.ClientSize = New System.Drawing.Size(622, 556)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_clo)
        Me.Controls.Add(Me.Btn_refres)
        Me.Controls.Add(Me.dgv_custreport)
        Me.Controls.Add(Me.btn_go)
        Me.Controls.Add(Me.Cmb_sby)
        Me.Controls.Add(Me.Lbl_sdata)
        Me.Controls.Add(Me.Lbl_sby)
        Me.Controls.Add(Me.Txt_sdata)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_customerreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cutomer Report"
        CType(Me.dgv_custreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


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
    Friend WithEvents btn_go As System.Windows.Forms.Button
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents dgv_custreport As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Btn_clo As System.Windows.Forms.Button
    Friend WithEvents Btn_refres As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
