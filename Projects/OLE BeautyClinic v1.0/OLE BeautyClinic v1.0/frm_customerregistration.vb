Imports System.Data.SqlClient

Public Class frm_customer_Registration
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Txt_phno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        'SAVE
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If btn_save.Text = "Save" Then
            sq = "insert into tbl_customerregistration(Registrationno,name,DOB,housename,place,post,pincode,district,phoneno,category,Recycle)values('" + txt_regno.Text + "','" + txt_name.Text + "','" + dtp_dob.Value + "','" + txt_hname.Text + "','" + Txt_place.Text + "','" + Txt_post.Text + "','" + Txt_pincode.Text + "','" + cbo_district.Text + "','" + txt_phno.Text + "','" + Cbo_category.Text + "',1)"
        Else
            sq = "update tbl_customerregistration set Registrationno='" & txt_regno.Text & "',name='" & txt_name.Text & "', DOB='" & dtp_dob.Value & "', housename='" & txt_hname.Text & "',place='" & Txt_place.Text & "',post='" & Txt_post.Text & "',pincode='" & Txt_pincode.Text & "',district='" & cbo_district.Text & "',phoneno='" & txt_phno.Text & "',category='" & Cbo_category.Text & "' where Id=" & Val(txt_id.Text)
        End If
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully registred")
            If DialogResult.OK Then
                Dim cust As New frm_customer_Registration
                Me.Hide()
                cust.Show()
            End If
        Else
            MsgBox("not  registred")
        End If
        connection.Close()

       

    End Sub

    Private Sub Btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        sq = "update tbl_customerregistration set recycle=0 where Id=" & Val(txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim cust As New frm_customer_Registration
                Me.Hide()
                cust.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub Btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        Dim cust As New frm_customer_Registration
        Me.Hide()
        cust.Show()
    End Sub

    Private Sub Lbl_searb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_searb.Click

    End Sub

    Private Sub Lbl_place_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_place.Click

    End Sub

    Private Sub Lbl_dob_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_dob.Click

    End Sub

    Private Sub Lbl_name_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lbl_name.Click

    End Sub

    Private Sub Dgv_customerregistration_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub frm_customer_Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ID AUTOMATIC READ
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New SqlCommand("select ID from tbl_customerregistration ", connection)
        dr = command.ExecuteReader
        While dr.Read
            txt_id.Text = dr.Item(0) + 1
        End While
        dr.Close()

        'DATA GRID VIEW
        command = New SqlCommand("select * from tbl_customerregistration where Recycle=1", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        Dgv_customerregistration.DataSource = ds.Tables(0)
        Dgv_customerregistration.Refresh()

        'combo add

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New SqlCommand("select Item from Tbl_serviceregistration", connection)
        dr = command.ExecuteReader
        While dr.Read
            Cbo_category.Items.Add(dr.Item(0))

        End While
        dr.Close()

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim i As Integer
        i = Dgv_customerregistration.CurrentRow.Index
        txt_id.Text = Dgv_customerregistration.Item(0, i).Value
        txt_regno.Text = Dgv_customerregistration.Item(1, i).Value
        txt_name.Text = Dgv_customerregistration.Item(2, i).Value
        dtp_dob.Value = Dgv_customerregistration.Item(3, i).Value
        txt_hname.Text = Dgv_customerregistration.Item(4, i).Value
        Txt_place.Text = Dgv_customerregistration.Item(5, i).Value
        Txt_post.Text = Dgv_customerregistration.Item(6, i).Value
        Txt_pincode.Text = Dgv_customerregistration.Item(7, i).Value
        cbo_district.Text = Dgv_customerregistration.Item(8, i).Value
        txt_phno.Text = Dgv_customerregistration.Item(9, i).Value
        Cbo_category.Text = Dgv_customerregistration.Item(10, i).Value
        btn_save.Text = "modify"
        btn_search.Text = "Delete"
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        btn_update_Click(sender, e)
        sq = "update tbl_customerregistration set recycle=0 where Id=" & Val(txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim cust As New frm_customer_Registration
                Me.Hide()
                cust.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Cbo_category_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_category.SelectedIndexChanged

    End Sub
End Class