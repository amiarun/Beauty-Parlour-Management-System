Imports System.Data.SqlClient

Public Class frm_customerreport
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Btn_clo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frm_customerreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        command = New SqlCommand("select*from tbl_customerregistration ", connection)
        da = New SqlDataAdapter
        da.SelectCommand = command
        ds = New DataSet
        da.Fill(ds)
        dgv_custreport.DataSource = ds.Tables(0)
        dgv_custreport.Refresh()

    End Sub

    Private Sub Btn_refres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim custrep As New frm_customerreport
        Me.Hide()
        custrep.Show()
    End Sub

    Private Sub dgv_custreport_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cusomprint As New frm_cusomerprint
        cusomprint.Show()
    End Sub
End Class