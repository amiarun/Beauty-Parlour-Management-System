Imports System.Data.SqlClient
Public Class frm_cashbook
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
   

    Private Sub frm_cashbook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ID AUTOMATIC READ
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New SqlCommand("select Id from Tbl_cashregistration", connection)
        dr = command.ExecuteReader
        While dr.Read
            txt_id.Text = dr.Item(0) + 1
        End While
        dr.Close()

        'DATA GRID VIEW
        command = New SqlCommand("select * from  Tbl_cashregistration where Recycle=1", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        Dgv_cashbook.DataSource = ds.Tables(0)
        Dgv_cashbook.Refresh()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        'try code
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If btn_save.Text = "Save" Then
            sq = "insert into Tbl_cashregistration(Particular,amount,Date,Type,Recycle)values('" + txt_particular.Text + "','" + txt_amount.Text + "','" + dtp_date.Value + "','" + cbo_type.Text + "',1)"
        Else
            sq = "update Tbl_cashregistration set  Particular='" & txt_particular.Text & "', amount='" & txt_amount.Text & "' ,Date ='" & dtp_date.Value & "',Type='" & cbo_type.Text & "' where Id=" & Val(txt_id.Text)
        End If
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully registred")
            If DialogResult.OK Then
                Dim cash As New frm_cashbook
                Me.Hide()
                cash.Show()
            End If
        Else
            MsgBox("not  registred")
        End If
        connection.Close()
        'end of try code
    End Sub

    Private Sub Btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        sq = "update Tbl_cashregistration  set recycle=0 where Id=" & Val(txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim cash As New frm_cashbook
                Me.Hide()
                cash.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        Dim cash As New frm_cashbook
        Me.Hide()
        cash.Show()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim i As Integer
        i = Dgv_cashbook.CurrentRow.Index
        txt_id.Text = Dgv_cashbook.Item(0, i).Value
        txt_particular.Text = Dgv_cashbook.Item(1, i).Value
        txt_amount.Text = Dgv_cashbook.Item(2, i).Value
        dtp_date.Text = Dgv_cashbook.Item(3, i).Value
        cbo_type.Text = Dgv_cashbook.Item(4, i).Value
        btn_save.Text = "modify"
        btn_search.Text = "Delete"
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        btn_update_Click(sender, e)
        sq = "update Tbl_cashregistration  set recycle=0 where Id=" & Val(txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim cash As New frm_cashbook
                Me.Hide()
                cash.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class