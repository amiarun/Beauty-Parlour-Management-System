<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_login
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Lbl_so = New System.Windows.Forms.Label
        Me.Lbl_smco = New System.Windows.Forms.Label
        Me.Btn_cancel = New System.Windows.Forms.Button
        Me.Btn_login = New System.Windows.Forms.Button
        Me.Txt_pass = New System.Windows.Forms.TextBox
        Me.Txt_id = New System.Windows.Forms.TextBox
        Me.Lbl_pass = New System.Windows.Forms.Label
        Me.Lbl_login = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Lbl_so)
        Me.GroupBox1.Controls.Add(Me.Lbl_smco)
        Me.GroupBox1.Controls.Add(Me.Btn_cancel)
        Me.GroupBox1.Controls.Add(Me.Btn_login)
        Me.GroupBox1.Controls.Add(Me.Txt_pass)
        Me.GroupBox1.Controls.Add(Me.Txt_id)
        Me.GroupBox1.Controls.Add(Me.Lbl_pass)
        Me.GroupBox1.Controls.Add(Me.Lbl_login)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(27, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 291)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Lbl_so
        '
        Me.Lbl_so.AutoSize = True
        Me.Lbl_so.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_so.Location = New System.Drawing.Point(183, 41)
        Me.Lbl_so.Name = "Lbl_so"
        Me.Lbl_so.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_so.TabIndex = 62
        Me.Lbl_so.Text = ":"
        '
        'Lbl_smco
        '
        Me.Lbl_smco.AutoSize = True
        Me.Lbl_smco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_smco.Location = New System.Drawing.Point(183, 119)
        Me.Lbl_smco.Name = "Lbl_smco"
        Me.Lbl_smco.Size = New System.Drawing.Size(10, 13)
        Me.Lbl_smco.TabIndex = 61
        Me.Lbl_smco.Text = ":"
        '
        'Btn_cancel
        '
        Me.Btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Btn_cancel.Location = New System.Drawing.Point(302, 205)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(121, 47)
        Me.Btn_cancel.TabIndex = 5
        Me.Btn_cancel.Text = "CANCEL"
        Me.Btn_cancel.UseVisualStyleBackColor = True
        '
        'Btn_login
        '
        Me.Btn_login.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_login.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Btn_login.Location = New System.Drawing.Point(126, 205)
        Me.Btn_login.Name = "Btn_login"
        Me.Btn_login.Size = New System.Drawing.Size(121, 47)
        Me.Btn_login.TabIndex = 4
        Me.Btn_login.Text = "LOGIN"
        Me.Btn_login.UseVisualStyleBackColor = True
        '
        'Txt_pass
        '
        Me.Txt_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_pass.Location = New System.Drawing.Point(235, 119)
        Me.Txt_pass.Name = "Txt_pass"
        Me.Txt_pass.Size = New System.Drawing.Size(161, 20)
        Me.Txt_pass.TabIndex = 3
        '
        'Txt_id
        '
        Me.Txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_id.Location = New System.Drawing.Point(235, 41)
        Me.Txt_id.Name = "Txt_id"
        Me.Txt_id.Size = New System.Drawing.Size(161, 20)
        Me.Txt_id.TabIndex = 2
        '
        'Lbl_pass
        '
        Me.Lbl_pass.AutoSize = True
        Me.Lbl_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_pass.Location = New System.Drawing.Point(90, 124)
        Me.Lbl_pass.Name = "Lbl_pass"
        Me.Lbl_pass.Size = New System.Drawing.Size(70, 13)
        Me.Lbl_pass.TabIndex = 1
        Me.Lbl_pass.Text = "PASSWORD"
        '
        'Lbl_login
        '
        Me.Lbl_login.AutoSize = True
        Me.Lbl_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_login.Location = New System.Drawing.Point(90, 46)
        Me.Lbl_login.Name = "Lbl_login"
        Me.Lbl_login.Size = New System.Drawing.Size(51, 13)
        Me.Lbl_login.TabIndex = 0
        Me.Lbl_login.Text = "USER ID"
        '
        'Frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 343)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents Txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_pass As System.Windows.Forms.Label
    Friend WithEvents Lbl_login As System.Windows.Forms.Label
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Btn_login As System.Windows.Forms.Button
    Friend WithEvents Lbl_so As System.Windows.Forms.Label
    Friend WithEvents Lbl_smco As System.Windows.Forms.Label
End Class
