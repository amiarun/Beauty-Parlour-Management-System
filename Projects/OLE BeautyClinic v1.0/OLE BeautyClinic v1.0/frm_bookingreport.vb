Imports System.Data.SqlClient
Public Class frm_bookingreport
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Btn_clo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frm_bookingreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'DATA GRID VIEW
        command = New SqlCommand("select * from Tbl_bookingform ", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        dgv_bookingrep.DataSource = ds.Tables(0)
        dgv_bookingrep.Refresh()
    End Sub

    Private Sub Btn_refres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bookrep As New frm_bookingreport
        Me.Hide()
        bookrep.Show()
    End Sub

    Private Sub Btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim bookprint As New frm_bookprint
        bookprint.Show()
    End Sub

    Private Sub Btn_clo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_clo.Click
        Me.Close()
    End Sub

    Private Sub Btn_refres_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_refres.Click
        Dim bookrep As New frm_bookingreport
        Me.Hide()
        bookrep.Show()
    End Sub
End Class