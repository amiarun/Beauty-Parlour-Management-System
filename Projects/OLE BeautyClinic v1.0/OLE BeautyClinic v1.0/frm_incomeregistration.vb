Imports System.Data.SqlClient

Public Class frm_incomeregistration
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Close()

    End Sub

    Private Sub Btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        sq = "update Tbl_incomeregistration set recycle=0 where Id=" & Val(txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim income As New frm_incomeregistration
                Me.Hide()
                income.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub frm_incomeregistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'data grid veiw
        command = New SqlCommand("select*from Tbl_incomeregistration where Recycle=1 ", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        dgv_income.DataSource = ds.Tables(0)
        dgv_income.Refresh()
        'id
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New SqlCommand("select Id from Tbl_incomeregistration", connection)
        dr = command.ExecuteReader
        While dr.Read
            txt_id.Text = dr.Item(0) + 1
        End While
        dr.Close()

    End Sub

   

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        'try code
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        If btn_save.Text = "Save" Then
            sq = "insert into Tbl_incomeregistration(Particular,amount,Date,Recycle)values('" + txt_particular.Text + "','" + txt_amount.Text + "','" + dtp_date.Value + "',1)"
        Else
            sq = "update Tbl_incomeregistration set Particular='" & txt_particular.Text & "', amount='" & txt_amount.Text & "', Date ='" & dtp_date.Value & "' where Id=" & Val(txt_id.Text)
        End If
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully registred")
            If DialogResult.OK Then
                Dim income As New frm_incomeregistration
                Me.Hide()
                income.Show()
            End If
        Else
            MsgBox("not  registred")
        End If
        connection.Close()
        'endof try code
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim i As Integer
        i = dgv_income.CurrentRow.Index
        txt_id.Text = dgv_income.Item(0, i).Value
        txt_particular.Text = dgv_income.Item(1, i).Value
        txt_amount.Text = dgv_income.Item(2, i).Value
        dtp_date.Value = dgv_income.Item(3, i).Value
        btn_save.Text = "modify"
        btn_search.Text = "Delete"
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        btn_update_Click(sender, e)
        sq = "update Tbl_incomeregistration set recycle=0 where Id=" & Val(txt_id.Text)
        command = New SqlCommand(sq, connection)
        a = command.ExecuteNonQuery()
        If a > 0 Then
            MsgBox("successfully Deleted")
            If DialogResult.OK Then
                Dim income As New frm_incomeregistration
                Me.Hide()
                income.Show()
            End If
        Else
            MsgBox("not  Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub Btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_refresh.Click
        Dim income As New frm_incomeregistration
        Me.Hide()
        income.Show()
    End Sub
End Class