Imports System.Data.SqlClient
Public Class frm_billing
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Dim sq As String

    Private Sub frm_billing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'data grid veiw
        command = New SqlCommand("select*from Tbl_billingregistration where Recycle=1", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        Dgv_bill.DataSource = ds.Tables(0)
        Dgv_bill.Refresh()
        'id
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New SqlCommand("select Id from Tbl_billingregistration", connection)
        dr = command.ExecuteReader
        While dr.Read
            Txt_id.Text = dr.Item(0) + 1
        End While
        dr.Close()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim i As Integer
        i = Dgv_bill.CurrentRow.Index
        Txt_id.Text = Dgv_bill.Item(0, i).Value
        Txt_registerno.Text = Dgv_bill.Item(1, i).Value
        cmb_item.Text = Dgv_bill.Item(2, i).Value
        txt_total.Text = Dgv_bill.Item(3, i).Value
        txt_discount.Text = Dgv_bill.Item(4, i).Value
        txt_phone.Text = Dgv_bill.Item(5, i).Value
        btn_save.Text = "modify"
        Btn_search.Text = "Delete"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If btn_save.Text = "Save" Then
            sq = "insert into Tbl_billingregistration(Registerno,Items,Totalrate,Discount,Phoneno,Recycle)values('" + Txt_registerno.Text + "','" + cmb_item.Text + "','" + txt_total.Text + "','" + txt_discount.Text + "','" + txt_phone.Text + "',1)"
        Else
            sq = "update Tbl_billingregistration set Registerno='" & Txt_registerno.Text & "',Items='" & cmb_item.Text & "', Totalrate='" & txt_total.Text & "', Discount='" & txt_discount.Text & "',Phoneno='" & txt_phone.Text & "' where Id=" & Val(Txt_id.Text)
        End If
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully registred")
            If DialogResult.OK Then
                Dim bill As New frm_billing
                Me.Hide()
                bill.Show()
            End If
        Else
            MsgBox("not  registred")
        End If
        connection.Close()
    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click

    End Sub

    Private Sub Btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_search.Click
        sq = "update Tbl_billingregistration set recycle=0 where Id=" & Val(Txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim bill As New frm_billing
                Me.Hide()
                bill.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub Btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_refresh.Click
        Dim bill As New frm_billing
        Me.Hide()
        bill.Show()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        btn_update_Click(sender, e)
        sq = "update Tbl_billingregistration set recycle=0 where Id=" & Val(Txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim bill As New frm_billing
                Me.Hide()
                bill.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
    End Sub

    Private Sub Btn_go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_go.Click
        If cbo_sby.Text = "Staff ID " Then
            command = New SqlCommand("select*from Tbl_billingregistration where Id like '" & txt_searchdata.Text & "%'", connection)
            da = New SqlDataAdapter(command)
            ds = New DataSet
            da.Fill(ds)
            Dgv_bill.DataSource = ds.Tables(0)
            Dgv_bill.Refresh()
        ElseIf cbo_sby.Text = "Register No" Then
            command = New SqlCommand("select*from Tbl_billingregistration where Registerno like '" & txt_searchdata.Text & "%'", connection)
            da = New SqlDataAdapter(command)
            ds = New DataSet
            da.Fill(ds)
            Dgv_bill.DataSource = ds.Tables(0)
            Dgv_bill.Refresh()
        End If

    End Sub
End Class