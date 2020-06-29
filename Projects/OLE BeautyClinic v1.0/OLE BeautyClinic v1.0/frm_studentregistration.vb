Imports System.Data.SqlClient
Public Class frm_studentregistration
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        sq = "update Tbl_studentregistration set  recycle=0 where Id=" & Val(Txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim stud As New frm_studentregistration
                Me.Hide()
                stud.Show()

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
            sq = "insert into Tbl_studentregistration(Registrationno,Course,Fees,Duration,Timming,Startingdate,Name,Place,Post,Pincode,District,Phoneno,Dob,Officename,Guardianname,Relation,Guardianno,Recycle)values('" + Txt_rgno.Text + "','" + Txt_name.Text + "','" + Dtp_date.Value + "','" + Txt_place.Text + "','" + Txt_post.Text + "','" + Txt_pin.Text + "','" + Txt_phno.Text + "','" + Txt_timming.Text + "','" & Txt_dur.Text & "','" & Txt_fee.Text & "','" & Txt_course.Text & "','" & cbo_district.Text & "','" & Dtp_dob.Value & "','" & Txt_oname.Text & "','" & Txt_relation.Text & "',1)"
        Else
            sq = "update Tbl_studentregistration set Registrationno='" & Txt_rgno.Text & "',Course='" & Txt_course.Text & "',Fees='" & Txt_fee.Text & "',Duration='" & Txt_dur.Text & "',Timming='" & Txt_timming.Text & "',Startingdate='" & Dtp_date.Value & "',Name='" & Txt_name.Text & "',Place='" & Txt_place.Text & "',Post='" & Txt_post.Text & "',Pincode='" & Txt_pin.Text & "',District='" & cbo_district.Text & "',Phoneno='" & Txt_phno.Text & "',Dob='" & Dtp_dob.Value & "',Officename='" & Txt_oname.Text & "',Guardianname='" & Txt_gname.Text & "',Relation='" & Txt_relation.Text & "',Guardianno='" & txt_gphno.Text & "' where Id=" & Val(Txt_id.Text)
        End If
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully registred")
            If DialogResult.OK Then
                Dim stud As New frm_studentregistration
                Me.Hide()
                stud.Show()

            End If
        Else
            MsgBox("not  registred")
        End If
        connection.Close()
    End Sub

    Private Sub frm_studentregistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ID AUTOMATIC READ
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New SqlCommand("select id from Tbl_studentregistration", connection)
        dr = command.ExecuteReader
        While dr.Read
            Txt_id.Text = dr.Item(0)
        End While
        dr.Close()
        'DATA GRID VIEW
        command = New SqlCommand("select * from Tbl_studentregistration  where Recycle=1", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        Dgv_student_registration.DataSource = ds.Tables(0)
        Dgv_student_registration.Refresh()

    End Sub

    Private Sub Btn_browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_browse.Click

    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        Dim stud As New frm_studentregistration
        Me.Hide()
        stud.Show()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        btn_update_Click(sender, e)
        sq = "update Tbl_studentregistration set  recycle=0 where Id=" & Val(Txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim stud As New frm_studentregistration
                Me.Hide()
                stud.Show()

            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim i As Integer
        i = Dgv_student_registration.CurrentRow.Index
        Txt_id.Text = Dgv_student_registration.Item(0, i).Value
        Txt_course.Text = Dgv_student_registration.Item(1, i).Value
        Txt_dur.Text = Dgv_student_registration.Item(2, i).Value
        Txt_fee.Text = Dgv_student_registration.Item(3, i).Value
        Txt_gname.Text = Dgv_student_registration.Item(4, i).Value
        txt_gphno.Text = Dgv_student_registration.Item(5, i).Value
        Txt_name.Text = Dgv_student_registration.Item(6, i).Value
        Txt_oname.Text = Dgv_student_registration.Item(7, i).Value
        Txt_phno.Text = Dgv_student_registration.Item(8, i).Value
        Txt_pin.Text = Dgv_student_registration.Item(9, i).Value
        Txt_place.Text = Dgv_student_registration.Item(10, i).Value
        Txt_post.Text = Dgv_student_registration.Item(11, i).Value
        Txt_relation.Text = Dgv_student_registration.Item(12, i).Value
        Txt_rgno.Text = Dgv_student_registration.Item(13, i).Value
        Txt_timming.Text = Dgv_student_registration.Item(14, i).Value
        Dtp_date.Value = Dgv_student_registration.Item(15, i).Value
        Dtp_dob.Value = Dgv_student_registration.Item(16, i).Value
        cbo_district.Text = Dgv_student_registration.Item(17, i).Value
        btn_save.Text = "modify"
        btn_search.Text = "Delete"
    End Sub
End Class