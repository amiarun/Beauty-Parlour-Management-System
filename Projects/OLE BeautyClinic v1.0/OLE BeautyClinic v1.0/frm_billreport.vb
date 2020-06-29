Imports System.Data.SqlClient
Public Class frm_billreport
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Btn_clo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub frm_billreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        command = New SqlCommand("select*from Tbl_billingregistration  ", connection)
        da = New SqlDataAdapter
        da.SelectCommand = command
        ds = New DataSet
        da.Fill(ds)
        dgv_billrep.DataSource = ds.Tables(0)
        dgv_billrep.Refresh()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim billprints As New frm_bill_print
        billprints.ShowDialog()
    End Sub
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

    End Sub

    Private Sub Btn_refres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_refres.Click
        Dim bill As New frm_billreport
        Me.Hide()
        bill.Show()
    End Sub
End Class