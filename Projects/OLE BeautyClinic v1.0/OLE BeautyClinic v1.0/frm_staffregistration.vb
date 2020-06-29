Imports System.Data.SqlClient
Public Class frm_staffregistration
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Close()

    End Sub

    Private Sub frm_staffregistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ID AUTOMATIC READ
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New SqlCommand("select id from Tbl_staffregistration", connection)
        dr = command.ExecuteReader
        While dr.Read
            txt_id.Text = dr.Item(0)
        End While
        dr.Close()
        'DATA GRID VIEW
        command = New SqlCommand("select * from Tbl_staffregistration  where Recycle=1", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        Dgv_staffregistration.DataSource = ds.Tables(0)
        Dgv_staffregistration.Refresh()

    End Sub

   

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If btn_save.Text = "Save" Then
            sq = "insert into Tbl_staffregistration(Registerno,name,Joinningdate,Housename,place,post,pincode,District,Phoneno,Qualification,salery,Commingtime,Goingtime,Recycle)values('" + txt_registerno.Text + "','" + txt_name.Text + "','" + dtp_joine.Value + "','" + txt_house.Text + "','" + Txt_place.Text + "','" + Txt_post.Text + "','" + Txt_pincode.Text + "','" + cbo_district.Text + "','" + txt_phone.Text + "','" + Cbo_qualification.Text + "','" + txt_salary.Text + "','" + txt_comming.Text + "','" + txt_going.Text + "',1)"
        Else
            sq = "update Tbl_staffregistration set Registerno='" & txt_registerno.Text & "', name='" & txt_name.Text & "', Housename ='" & txt_house.Text & "',place='" & Txt_place.Text & "',post='" & Txt_post.Text & "',pincode='" & Txt_pincode.Text & "',District='" & cbo_district.Text & "',Phoneno='" & txt_phone.Text & "',salery='" & txt_salary.Text & "',Joinningdate='" & dtp_joine.Value & "',Commingtime='" & txt_comming.Text & "' ,Goingtime='" & txt_going.Text & "',Qualification='" & Cbo_qualification.Text & "' where Id=" & Val(txt_id.Text)
        End If
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully registred")
            If DialogResult.OK Then
                Dim staff As New frm_staffregistration
                Me.Hide()
                staff.Show()
            End If
        Else
            MsgBox("not  registred")
        End If
        connection.Close()
    End Sub

    Private Sub Btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_refresh.Click
        Dim staff As New frm_staffregistration
        Me.Hide()
        staff.Show()
    End Sub

    Private Sub Btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_search.Click
        sq = "update Tbl_staffregistration  set recycle=0 where Id=" & Val(txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim staff As New frm_staffregistration
                Me.Hide()
                staff.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim i As Integer
        i = Dgv_staffregistration.CurrentRow.Index
        txt_id.Text = Dgv_staffregistration.Item(0, i).Value
        txt_registerno.Text = Dgv_staffregistration.Item(1, i).Value
        txt_name.Text = Dgv_staffregistration.Item(2, i).Value
        dtp_joine.Value = Dgv_staffregistration.Item(3, i).Value
        txt_house.Text = Dgv_staffregistration.Item(4, i).Value
        Txt_place.Text = Dgv_staffregistration.Item(5, i).Value
        Txt_post.Text = Dgv_staffregistration.Item(6, i).Value
        Txt_pincode.Text = Dgv_staffregistration.Item(7, i).Value
        cbo_district.Text = Dgv_staffregistration.Item(8, i).Value
        txt_phone.Text = Dgv_staffregistration.Item(9, i).Value
        Cbo_qualification.Text = Dgv_staffregistration.Item(10, i).Value
        txt_salary.Text = Dgv_staffregistration.Item(11, i).Value
        txt_comming.Text = Dgv_staffregistration.Item(12, i).Value
        txt_going.Text = Dgv_staffregistration.Item(13, i).Value
        btn_save.Text = "modify"
        Btn_search.Text = "Delete"
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        btn_update_Click(sender, e)
        sq = "update Tbl_staffregistration  set recycle=0 where Id=" & Val(txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim staff As New frm_staffregistration
                Me.Hide()
                staff.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub
End Class