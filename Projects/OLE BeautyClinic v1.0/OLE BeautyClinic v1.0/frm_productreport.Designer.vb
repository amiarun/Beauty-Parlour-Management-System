<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_productreport
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
        Me.Button2 = New System.Windows.Forms.Button
        Me.Btn_clo = New System.Windows.Forms.Button
        Me.Btn_refres = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Cmb_sby = New System.Windows.Forms.ComboBox
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.Lbl_sby = New System.Windows.Forms.Label
        Me.Txt_sdata = New System.Windows.Forms.TextBox
        Me.Dgv_product_report = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.Dgv_product_report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(244, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 36)
        Me.Button2.TabIndex = 74
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Btn_clo
        '
        Me.Btn_clo.BackColor = System.Drawing.Color.Transparent
        Me.Btn_clo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_clo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_clo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_clo.Location = New System.Drawing.Point(459, 466)
        Me.Btn_clo.Name = "Btn_clo"
        Me.Btn_clo.Size = New System.Drawing.Size(102, 36)
        Me.Btn_clo.TabIndex = 73
        Me.Btn_clo.Text = "Close"
        Me.Btn_clo.UseVisualStyleBackColor = False
        '
        'Btn_refres
        '
        Me.Btn_refres.BackColor = System.Drawing.Color.Transparent
        Me.Btn_refres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_refres.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_refres.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_refres.Location = New System.Drawing.Point(45, 466)
        Me.Btn_refres.Name = "Btn_refres"
        Me.Btn_refres.Size = New System.Drawing.Size(102, 36)
        Me.Btn_refres.TabIndex = 72
        Me.Btn_refres.Text = "Refresh"
        Me.Btn_refres.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(510, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 36)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "GO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cmb_sby
        '
        Me.Cmb_sby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cmb_sby.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_sby.ForeColor = System.Drawing.Color.Black
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"id", "register no", "item name", "expiery date", "rate", "category", "mrp", "sales rate", "company name", "code"})
        Me.Cmb_sby.Location = New System.Drawing.Point(277, 162)
        Me.Cmb_sby.Name = "Cmb_sby"
        Me.Cmb_sby.Size = New System.Drawing.Size(217, 23)
        Me.Cmb_sby.TabIndex = 76
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sdata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_sdata.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sdata.ForeColor = System.Drawing.Color.Black
        Me.Lbl_sdata.Location = New System.Drawing.Point(104, 169)
        Me.Lbl_sdata.Name = "Lbl_sdata"
        Me.Lbl_sdata.Size = New System.Drawing.Size(109, 21)
        Me.Lbl_sdata.TabIndex = 77
        Me.Lbl_sdata.Text = "Search Data"
        '
        'Lbl_sby
        '
        Me.Lbl_sby.AutoSize = True
        Me.Lbl_sby.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sby.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_sby.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sby.ForeColor = System.Drawing.Color.Black
        Me.Lbl_sby.Location = New System.Drawing.Point(104, 112)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(85, 21)
        Me.Lbl_sby.TabIndex = 75
        Me.Lbl_sby.Text = "Search By"
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sdata.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sdata.ForeColor = System.Drawing.Color.Black
        Me.Txt_sdata.Location = New System.Drawing.Point(277, 106)
        Me.Txt_sdata.Multiline = True
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(218, 28)
        Me.Txt_sdata.TabIndex = 78
        '
        'Dgv_product_report
        '
        Me.Dgv_product_report.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_product_report.Location = New System.Drawing.Point(12, 212)
        Me.Dgv_product_report.Name = "Dgv_product_report"
        Me.Dgv_product_report.Size = New System.Drawing.Size(622, 211)
        Me.Dgv_product_report.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(197, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 57)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Product Report"
        '
        'frm_productreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.repwall
        Me.ClientSize = New System.Drawing.Size(650, 557)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Dgv_product_report)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cmb_sby)
        Me.Controls.Add(Me.Lbl_sdata)
        Me.Controls.Add(Me.Lbl_sby)
        Me.Controls.Add(Me.Txt_sdata)
        Me.Controls.Add(Me.Btn_refres)
        Me.Controls.Add(Me.Btn_clo)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_productreport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Report"
        CType(Me.Dgv_product_report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Btn_clo As System.Windows.Forms.Button
    Friend WithEvents Btn_refres As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents Dgv_product_report As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
