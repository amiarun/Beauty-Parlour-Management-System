Imports System.Data.SqlClient

Public Class frm_servicepackage
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub frm_servicepackage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ID AUTOMATIC READ
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New SqlCommand("select id from Tbl_serviceregistration  where Recycle=1", connection)
        dr = command.ExecuteReader
        While dr.Read
            txt_id.Text = dr.Item(0)
        End While
        dr.Close()
        'DATA GRID VIEW
        command = New SqlCommand("select * from Tbl_serviceregistration", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        dgv_servivereg.DataSource = ds.Tables(0)
        dgv_servivereg.Refresh()

    End Sub

    Private Sub Lbl_hname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        btn_update_Click(sender, e)
        sq = "update Tbl_serviceregistration   set recycle=0 where Id=" & Val(txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim servicereg As New frm_servicepackage
                Me.Hide()
                servicereg.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub


    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If btn_save.Text = "Save" Then
            sq = "insert into Tbl_serviceregistration(Name,Item,Amount,Recycle)values('" + txt_name.Text + "','" + txt_item.Text + "','" + txt_amount.Text + "',1)"
        Else
            sq = "update Tbl_serviceregistration set Name='" & txt_name.Text & "', Item='" & txt_item.Text & "', Amount ='" & txt_amount.Text & "' where Id=" & Val(txt_id.Text)
        End If
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully registred")
            If DialogResult.OK Then
                Dim servicereg As New frm_servicepackage
                Me.Hide()
                servicereg.Show()
            End If
        Else
            MsgBox("not  registred")
        End If
        connection.Close()
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        Dim servicereg As New frm_servicepackage
        Me.Hide()
        servicereg.Show()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim i As Integer
        i = dgv_servivereg.CurrentRow.Index
        txt_id.Text = dgv_servivereg.Item(0, i).Value
        txt_name.Text = dgv_servivereg.Item(1, i).Value
        txt_item.Text = dgv_servivereg.Item(2, i).Value
        txt_amount.Text = dgv_servivereg.Item(3, i).Value
        btn_save.Text = "modify"
        btn_search.Text = "Delete"
    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        sq = "update Tbl_serviceregistration   set recycle=0 where Id=" & Val(txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim servicereg As New frm_servicepackage
                Me.Hide()
                servicereg.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub
End Class