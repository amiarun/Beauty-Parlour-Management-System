Imports System.Data.SqlClient
Public Class frm_booking
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frm_booking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ID AUTOMATIC READ
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New SqlCommand("select Id from Tbl_bookingform", connection)
        dr = command.ExecuteReader
        While dr.Read
            Txt_id.Text = dr.Item(0) + 1
        End While
        dr.Close()

        'DATA GRID VIEW
        command = New SqlCommand("select * from Tbl_bookingform where Recycle!=0", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        Dgv_booking.DataSource = ds.Tables(0)
        Dgv_booking.Refresh()

        'combo add

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New SqlCommand("select Item from Tbl_serviceregistration", connection)
        dr = command.ExecuteReader
        While dr.Read
            Cbo_ctry.Items.Add(dr.Item(0))

        End While
        dr.Close()

        'search by
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New SqlCommand("select COLUMN_name from INFORMATION_SCHEMA.COLUMNS where table_name ='Tbl_bookingform'", connection)
        dr = command.ExecuteReader
        While dr.Read
            Cbo_sby.Items.Add(dr.Item(0))
        End While
        dr.Close()
        command = New SqlCommand("select*from Tbl_bookingform where '" & Cbo_sby.Text & "' like '" & Txt_sdata.Text & "%'", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        Dgv_booking.DataSource = ds.Tables(0)
        Dgv_booking.Refresh()
    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Dgv_booking_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub btn_save_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If btn_save.Text = "Save" Then
            sq = "insert into Tbl_bookingform(Registerno,Name,Time,Date,Site,Place,Pincode,Categories,Recycle)values('" & Txt_rgno.Text & "','" & Txt_name.Text & "','" & Txt_time.Text & "','" & dtp_date.Value & "','" & cbo_site.Text & "','" & Txt_place.Text & "','" & Txt_pin.Text & "','" & Cbo_ctry.Text & "',1)"
        Else
            sq = "update Tbl_bookingform set Registerno='" & Txt_rgno.Text & "',Name='" & Txt_name.Text & "', Time='" & Txt_time.Text & "', Date='" & dtp_date.Value & "',Site='" & cbo_site.Text & "',Place='" & Txt_place.Text & "',Pincode='" & Txt_pin.Text & "',Categories='" & Cbo_ctry.Text & "' where Id=" & Val(Txt_id.Text)
        End If
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully registred")
            If DialogResult.OK Then
                Dim book As New frm_booking
                Me.Hide()
                book.Show()
            End If
        Else
            MsgBox("not  registred")
        End If
        connection.Close()
    End Sub

    Private Sub Cmb_ctry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Dgv_booking_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_booking.CellContentClick

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim i As Integer
        i = Dgv_booking.CurrentRow.Index
        Txt_id.Text = Dgv_booking.Item(0, i).Value
        Txt_rgno.Text = Dgv_booking.Item(1, i).Value
        Txt_name.Text = Dgv_booking.Item(2, i).Value
        Txt_time.Text = Dgv_booking.Item(3, i).Value
        dtp_date.Value = Dgv_booking.Item(4, i).Value
        cbo_site.Text = Dgv_booking.Item(5, i).Value
        Txt_place.Text = Dgv_booking.Item(6, i).Value
        Txt_pin.Text = Dgv_booking.Item(7, i).Value
        Cbo_ctry.Text = Dgv_booking.Item(8, i).Value
        btn_save.Text = "modify"
        Btn_search.Text = "Delete"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()


    End Sub

    Private Sub Btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_search.Click
        sq = "update Tbl_bookingform set  Recycle=0 where Id=" & Val(Txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim book As New frm_booking
                Me.Hide()
                book.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        btn_update_Click(sender, e)
        sq = "update Tbl_bookingform set  Recycle=0 where Id=" & Val(Txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim book As New frm_booking
                Me.Hide()
                book.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub Btn_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_go.Click
        If Txt_sdata.Text = " " Or Cbo_sby.Text = "" Then
            MsgBox("please fill")
        Else
            command = New SqlCommand("select*from Tbl_bookingform where '" & Cbo_sby.Text & "' like '" & Txt_sdata.Text & "%' AND Recycle=1", connection)
            da = New SqlDataAdapter(command)
            ds = New DataSet
            da.Fill(ds)
            Dgv_booking.DataSource = ds.Tables(0)
            Dgv_booking.Refresh()
        End If
       
    End Sub

    Private Sub Btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_refresh.Click
        Dim book As New frm_booking
        Me.Hide()
        book.Show()
    End Sub
End Class