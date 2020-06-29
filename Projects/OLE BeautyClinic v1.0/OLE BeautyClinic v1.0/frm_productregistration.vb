Imports System.Data.SqlClient

Public Class frm_productregistration
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Close()

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Txt_pin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Txt_dis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cmb_category_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frm_productregistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'data grid veiw
        command = New SqlCommand("select*from Tbl_productregistration where Recycle=1", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        dgv_productreg.DataSource = ds.Tables(0)
        dgv_productreg.Refresh()
        'id
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New SqlCommand("select Id from Tbl_productregistration", connection)
        dr = command.ExecuteReader
        While dr.Read
            txt_id.Text = dr.Item(0) + 1
        End While
        dr.Close()
    End Sub

    Private Sub Dgv_product_registration_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dgv_product_registration.CellContentClick
        
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If btn_save.Text = "Save" Then
            sq = "insert into Tbl_productregistration(Registerno,Itemname,expierydate,Rate,category,MRP,salesrate,companyname,code,Recycle)values('" + txt_registerno.Text + "','" + txt_itemname.Text + "','" + dtp_expiery.Value + "','" + txt_rate.Text + "','" + cbo_category.Text + "','" + txt_mrp.Text + "','" + txt_sales.Text + "','" + txt_company.Text + "','" + txt_code.Text + "',1)"
        Else
            sq = "update Tbl_productregistration set  Registerno='" & txt_registerno.Text & "', Itemname='" & txt_itemname.Text & "' ,expierydate='" & dtp_expiery.Value & "',Rate ='" & txt_rate.Text & "',category='" & cbo_category.Text & "',MRP='" & txt_mrp.Text & "',salesrate='" & txt_sales.Text & "',companyname='" & txt_company.Text & "',code='" & txt_code.Text & "' where Id=" & Val(txt_id.Text)
        End If
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully registred")
            If DialogResult.OK Then
                Dim prod As New frm_productregistration
                Me.Hide()
                prod.Show()

            End If
        Else
            MsgBox("not  registred")
        End If
        connection.Close()
    End Sub

    Private Sub Btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_search.Click
        sq = "update Tbl_productregistration set recycle=0 where Id=" & Val(txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim prod As New frm_productregistration
                Me.Hide()
                prod.Show()

            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub Btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_refresh.Click
        Dim prod As New frm_productregistration
        Me.Hide()
        prod.Show()

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim i As Integer
        i = Dgv_product_registration.CurrentRow.Index
        txt_id.Text = Dgv_product_registration.Item(0, i).Value
        txt_registerno.Text = Dgv_product_registration.Item(7, i).Value
        txt_itemname.Text = Dgv_product_registration.Item(4, i).Value
        dtp_expiery.Value = Dgv_product_registration.Item(9, i).Value
        txt_rate.Text = Dgv_product_registration.Item(6, i).Value
        cbo_category.Text = Dgv_product_registration.Item(6, i).Value
        txt_mrp.Text = Dgv_product_registration.Item(5, i).Value
        txt_sales.Text = Dgv_product_registration.Item(8, i).Value
        txt_company.Text = Dgv_product_registration.Item(2, i).Value
        txt_code.Text = Dgv_product_registration.Item(1, i).Value
        btn_save.Text = "modify"
        Btn_search.Text = "Delete"
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        btn_update_Click(sender, e)
        sq = "update Tbl_productregistration set recycle=0 where Id=" & Val(txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim prod As New frm_productregistration
                Me.Hide()
                prod.Show()

            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub
End Class