<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_billreport
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
        Me.Btn_go = New System.Windows.Forms.Button
        Me.Cmb_sby = New System.Windows.Forms.ComboBox
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.Lbl_sby = New System.Windows.Forms.Label
        Me.Txt_sdata = New System.Windows.Forms.TextBox
        Me.dgv_billrep = New System.Windows.Forms.DataGridView
        Me.btn_print = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.Btn_refres = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgv_billrep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn_go
        '
        Me.Btn_go.BackColor = System.Drawing.Color.Transparent
        Me.Btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_go.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_go.ForeColor = System.Drawing.Color.Black
        Me.Btn_go.Location = New System.Drawing.Point(457, 150)
        Me.Btn_go.Name = "Btn_go"
        Me.Btn_go.Size = New System.Drawing.Size(79, 32)
        Me.Btn_go.TabIndex = 78
        Me.Btn_go.Text = "GO"
        Me.Btn_go.UseVisualStyleBackColor = False
        '
        'Cmb_sby
        '
        Me.Cmb_sby.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmb_sby.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_sby.ForeColor = System.Drawing.Color.Black
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"id", "regno", "name", "place", "district", "salery", "qualification"})
        Me.Cmb_sby.Location = New System.Drawing.Point(215, 170)
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
        Me.Lbl_sdata.Location = New System.Drawing.Point(93, 174)
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
        Me.Lbl_sby.Location = New System.Drawing.Point(93, 134)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(68, 17)
        Me.Lbl_sby.TabIndex = 72
        Me.Lbl_sby.Text = "Search By"
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Txt_sdata.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sdata.ForeColor = System.Drawing.Color.Black
        Me.Txt_sdata.Location = New System.Drawing.Point(215, 131)
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(218, 22)
        Me.Txt_sdata.TabIndex = 75
        '
        'dgv_billrep
        '
        Me.dgv_billrep.BackgroundColor = System.Drawing.Color.White
        Me.dgv_billrep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_billrep.Location = New System.Drawing.Point(11, 230)
        Me.dgv_billrep.Name = "dgv_billrep"
        Me.dgv_billrep.Size = New System.Drawing.Size(561, 178)
        Me.dgv_billrep.TabIndex = 79
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.Transparent
        Me.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_print.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Location = New System.Drawing.Point(160, 444)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(106, 35)
        Me.btn_print.TabIndex = 84
        Me.btn_print.Text = "print"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btn_delete.Location = New System.Drawing.Point(457, 445)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(105, 36)
        Me.btn_delete.TabIndex = 83
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btn_close.Location = New System.Drawing.Point(309, 445)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(105, 36)
        Me.btn_close.TabIndex = 81
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'Btn_refres
        '
        Me.Btn_refres.BackColor = System.Drawing.Color.Transparent
        Me.Btn_refres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_refres.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_refres.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_refres.Location = New System.Drawing.Point(12, 444)
        Me.Btn_refres.Name = "Btn_refres"
        Me.Btn_refres.Size = New System.Drawing.Size(105, 36)
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
        Me.Label1.Location = New System.Drawing.Point(205, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 57)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Billing Report"
        '
        'frm_billreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.repwall
        Me.ClientSize = New System.Drawing.Size(585, 547)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Btn_refres)
        Me.Controls.Add(Me.dgv_billrep)
        Me.Controls.Add(Me.Btn_go)
        Me.Controls.Add(Me.Cmb_sby)
        Me.Controls.Add(Me.Lbl_sdata)
        Me.Controls.Add(Me.Lbl_sby)
        Me.Controls.Add(Me.Txt_sdata)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_billreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Report"
        CType(Me.dgv_billrep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegisternoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalrateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhonenoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecycleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Btn_go As System.Windows.Forms.Button
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents dgv_billrep As System.Windows.Forms.DataGridView
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Btn_refres As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
