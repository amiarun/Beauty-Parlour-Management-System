Imports System.Data.SqlClient
Public Class frm_staffreport
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Btn_clo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub frm_staffreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

    End Sub

    Private Sub Btn_refres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim staffrep As New frm_staffreport
        Me.Hide()
        staffrep.Show()
    End Sub

    Private Sub Dgv_staff_report_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        command = New SqlCommand("select*from Tbl_staffregistration ", connection)
        da = New SqlDataAdapter
        da.SelectCommand = command
        ds = New DataSet
        da.Fill(ds)
        Dgv_staff_report.DataSource = ds.Tables(0)
        Dgv_staff_report.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim staffprint As New frm_staffprint
        staffprint.Show()
    End Sub
End Class
