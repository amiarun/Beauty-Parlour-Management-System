Imports System.Data.SqlClient
Public Class frm_login
    Dim connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Dim command As New SqlCommand("select * from Tbl_login where username=@username and password=@password", connection)

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        'command.Parameters.Add("@username", SqlDbType.VarChar).Value = txt_username.Text
        'command.Parameters.Add("@password", SqlDbType.VarChar).Value = txt_password.Text
        'Dim adapter As New SqlDataAdapter(command)
        'Dim table As New DataTable()
        'adapter.Fill(table)
        'If table.Rows.Count <= 0 Then
        '    MsgBox("username or password is invalid")
        'Else
        '    MsgBox("logged in successfully")
        '    Dim home As New frm_home
        '    Me.Hide()
        '    home.Show()
        'End If
        If connection.State = ConnectionState.Closed Then
            connection.Open()
            command = New SqlCommand("select count(*) from Tbl_user where userid='" & txt_username.Text & "' and password='" & txt_password.Text & "'", connection)
            If command.ExecuteScalar > 0 Then
                MsgBox("logged in successfully")
                uname = txt_username.Text

                Dim home As New frm_home
                Me.Hide()
                home.Show()
            Else
                MsgBox("username or password is invalid")
            End If
        End If
        connection.Close()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_username.TextChanged

    End Sub

    Private Sub TextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_username.Validating
        If txt_username.Text = "" Then
            ErrorProvider1.SetError(txt_username, "enter username")
        Else
            ErrorProvider1.SetError(txt_username, "")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_password.TextChanged

    End Sub

    Private Sub TextBox2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_password.Validating
        If txt_password.Text = "" Then
            ErrorProvider1.SetError(txt_password, "enter password")
        Else
            ErrorProvider1.SetError(txt_password, "")
        End If
    End Sub

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class