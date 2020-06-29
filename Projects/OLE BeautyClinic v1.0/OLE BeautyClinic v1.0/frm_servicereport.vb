Imports System.Data.SqlClient
Public Class frm_servicereport
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Btn_clo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub frm_servicereport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub Btn_refres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim servirep As New frm_servicereport
        Me.Hide()
        servirep.Show()
    End Sub

    Private Sub Dgv_service_Report_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        command = New SqlCommand("select*from Tbl_serviceregistration ", connection)
        da = New SqlDataAdapter
        da.SelectCommand = command
        ds = New DataSet
        da.Fill(ds)
        Dgv_service_Report.DataSource = ds.Tables(0)
        Dgv_service_Report.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim serviceprint As New frm_serviceprint
        serviceprint.Show()
    End Sub
End Class