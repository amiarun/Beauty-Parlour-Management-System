<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_servicereport
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Cmb_sby = New System.Windows.Forms.ComboBox
        Me.Lbl_sdata = New System.Windows.Forms.Label
        Me.Lbl_sby = New System.Windows.Forms.Label
        Me.Txt_sdata = New System.Windows.Forms.TextBox
        Me.Dgv_service_Report = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.Btn_clo = New System.Windows.Forms.Button
        Me.Btn_refres = New System.Windows.Forms.Button
        CType(Me.Dgv_service_Report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(474, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 38)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "GO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cmb_sby
        '
        Me.Cmb_sby.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Cmb_sby.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_sby.ForeColor = System.Drawing.Color.Black
        Me.Cmb_sby.FormattingEnabled = True
        Me.Cmb_sby.Items.AddRange(New Object() {"id", "registeration no", "name", "package"})
        Me.Cmb_sby.Location = New System.Drawing.Point(230, 163)
        Me.Cmb_sby.Name = "Cmb_sby"
        Me.Cmb_sby.Size = New System.Drawing.Size(217, 24)
        Me.Cmb_sby.TabIndex = 73
        '
        'Lbl_sdata
        '
        Me.Lbl_sdata.AutoSize = True
        Me.Lbl_sdata.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_sdata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_sdata.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_sdata.ForeColor = System.Drawing.Color.Black
        Me.Lbl_sdata.Location = New System.Drawing.Point(106, 165)
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
        Me.Lbl_sby.Location = New System.Drawing.Point(106, 128)
        Me.Lbl_sby.Name = "Lbl_sby"
        Me.Lbl_sby.Size = New System.Drawing.Size(68, 17)
        Me.Lbl_sby.TabIndex = 72
        Me.Lbl_sby.Text = "Search By"
        '
        'Txt_sdata
        '
        Me.Txt_sdata.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Txt_sdata.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_sdata.ForeColor = System.Drawing.Color.Black
        Me.Txt_sdata.Location = New System.Drawing.Point(230, 126)
        Me.Txt_sdata.Name = "Txt_sdata"
        Me.Txt_sdata.Size = New System.Drawing.Size(218, 21)
        Me.Txt_sdata.TabIndex = 75
        '
        'Dgv_service_Report
        '
        Me.Dgv_service_Report.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_service_Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv_service_Report.Location = New System.Drawing.Point(60, 207)
        Me.Dgv_service_Report.Name = "Dgv_service_Report"
        Me.Dgv_service_Report.Size = New System.Drawing.Size(502, 239)
        Me.Dgv_service_Report.TabIndex = 79
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(252, 462)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 36)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Btn_clo
        '
        Me.Btn_clo.BackColor = System.Drawing.Color.Transparent
        Me.Btn_clo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_clo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_clo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_clo.Location = New System.Drawing.Point(366, 462)
        Me.Btn_clo.Name = "Btn_clo"
        Me.Btn_clo.Size = New System.Drawing.Size(88, 36)
        Me.Btn_clo.TabIndex = 81
        Me.Btn_clo.Text = "Close"
        Me.Btn_clo.UseVisualStyleBackColor = False
        '
        'Btn_refres
        '
        Me.Btn_refres.BackColor = System.Drawing.Color.Transparent
        Me.Btn_refres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_refres.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_refres.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Btn_refres.Location = New System.Drawing.Point(136, 462)
        Me.Btn_refres.Name = "Btn_refres"
        Me.Btn_refres.Size = New System.Drawing.Size(88, 36)
        Me.Btn_refres.TabIndex = 80
        Me.Btn_refres.Text = "Refresh"
        Me.Btn_refres.UseVisualStyleBackColor = False
        '
        'frm_servicereport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.OLE_BeautyClinic_v1._0.My.Resources.Resources.repwall
        Me.ClientSize = New System.Drawing.Size(650, 557)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btn_clo)
        Me.Controls.Add(Me.Btn_refres)
        Me.Controls.Add(Me.Dgv_service_Report)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cmb_sby)
        Me.Controls.Add(Me.Lbl_sdata)
        Me.Controls.Add(Me.Txt_sdata)
        Me.Controls.Add(Me.Lbl_sby)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_servicereport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Service Report"
        CType(Me.Dgv_service_Report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Cmb_sby As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_sdata As System.Windows.Forms.Label
    Friend WithEvents Lbl_sby As System.Windows.Forms.Label
    Friend WithEvents Txt_sdata As System.Windows.Forms.TextBox
    Friend WithEvents Dgv_service_Report As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Btn_clo As System.Windows.Forms.Button
    Friend WithEvents Btn_refres As System.Windows.Forms.Button
End Class
