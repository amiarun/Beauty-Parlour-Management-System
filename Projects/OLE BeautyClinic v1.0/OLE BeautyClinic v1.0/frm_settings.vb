Imports System.Data.SqlClient
Public Class frm_settings
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Close()

    End Sub

    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        'SAVE
        If connection.State = ConnectionState.Closed Then
            connection.Open()

        End If
        If Txt_password.Text = Txt_reenter.Text Then
            command = New SqlCommand("insert into Tbl_user values ('" & Txt_user.Text & "','" & Txt_password.Text & "','" & custregset & "','" & staffregset & "','" & studentregset & "','" & productregset & "','" & serviceregset & "','" & bookingregset & "','" & billregset & "','" & incomeregset & "','" & expenseregset & "','" & cashregset & "','" & custrepset & "','" & staffrepset & "','" & studentrepset & "','" & productrepset & "','" & servicerepset & "','" & bookingrepset & "','" & billrepset & "','" & incomerepset & "','" & expenserepset & "','" & cashrepset & "','" & settingset & "')", connection)
            a = command.ExecuteNonQuery
            MsgBox("registered succesfully")
        Else
            MsgBox("password doesnot match")

        End If
        connection.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_customerreg.CheckedChanged
        If chk_customerreg.Checked = True Then
            custregset = 1
        Else
            custregset = 0

        End If
    End Sub

    Private Sub chk_staffreg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_staffreg.CheckedChanged
        If chk_staffreg.Checked = True Then
            staffregset = 1
        Else
            staffregset = 0
        End If
    End Sub

    Private Sub chk_studentreg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_studentreg.CheckedChanged
        If chk_studentreg.Checked = True Then
            studentregset = 1
        Else
            studentregset = 0
        End If
    End Sub

    Private Sub chk_productreg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_productreg.CheckedChanged
        If chk_productreg.Checked = True Then
            productregset = 1
        Else
            productregset = 0
        End If
    End Sub

    Private Sub chk_servicereg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_servicereg.CheckedChanged
        If chk_servicereg.Checked = True Then
            serviceregset = 1
        Else
            serviceregset = 0
        End If
    End Sub

    Private Sub chk_bookingreg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_bookingreg.CheckedChanged
        If chk_bookingreg.Checked = True Then
            bookingregset = 1
        Else
            bookingregset = 0
        End If
    End Sub

    Private Sub chk_billreg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_billreg.CheckedChanged
        If chk_billreg.Checked = True Then
            billregset = 1
        Else
            billregset = 0
        End If
    End Sub

    Private Sub chk_incomereg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_incomereg.CheckedChanged
        If chk_incomereg.Checked = True Then
            incomeregset = 1
        Else
            incomeregset = 0
        End If
    End Sub

    Private Sub chk_expencereg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_expencereg.CheckedChanged
        If chk_expencereg.Checked = True Then
            expenseregset = 1
        Else
            expenseregset = 0
        End If
    End Sub

    Private Sub chk_cashreg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cashreg.CheckedChanged
        If chk_cashreg.Checked = True Then
            cashregset = 1
        Else
            cashregset = 0
        End If
    End Sub

    Private Sub chk_customerrep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_customerrep.CheckedChanged
        If chk_customerrep.Checked = True Then
            custrepset = 1
        Else
            cashregset = 0
        End If
    End Sub

    Private Sub chk_staffrep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_staffrep.CheckedChanged
        If chk_staffrep.Checked = True Then
            staffrepset = 1
        Else
            staffrepset = 0
        End If
    End Sub

    Private Sub chk_studentrep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_studentrep.CheckedChanged
        If chk_studentrep.Checked = True Then
            studentrepset = 1
        Else
            studentrepset = 0
        End If
    End Sub

    Private Sub chk_productrep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_productrep.CheckedChanged
        If chk_productrep.Checked = True Then
            productrepset = 1
        Else
            productrepset = 0
        End If
    End Sub

    Private Sub chk_servicerep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_servicerep.CheckedChanged
        If chk_servicerep.Checked = True Then
            servicerepset = 1
        Else
            servicerepset = 0
        End If
    End Sub

    Private Sub chk_bookingrep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_bookingrep.CheckedChanged
        If chk_bookingrep.Checked = True Then
            bookingrepset = 1
        Else
            bookingrepset = 0
        End If
    End Sub

    Private Sub chk_billrep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_billrep.CheckedChanged
        If chk_billrep.Checked = True Then
            billrepset = 1
        Else
            billrepset = 0
        End If
    End Sub

    Private Sub chk_incomerep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_incomerep.CheckedChanged
        If chk_incomerep.Checked = True Then
            incomerepset = 1
        Else
            incomerepset = 0
        End If
    End Sub

    Private Sub chk_expencerep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_expencerep.CheckedChanged
        If chk_expencerep.Checked = True Then
            expenserepset = 1
        Else
            expenserepset = 0
        End If
    End Sub

    Private Sub chk_cashrep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_cashrep.CheckedChanged
        If chk_cashrep.Checked = True Then
            cashrepset = 1
        Else
            cashrepset = 0
        End If
    End Sub

    Private Sub chk_setting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_setting.CheckedChanged
        If chk_setting.Checked = True Then
            settingset = 1
        Else
            settingset = 0
        End If
    End Sub

    Private Sub frm_settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class