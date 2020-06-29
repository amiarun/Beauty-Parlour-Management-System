Imports System.Data.SqlClient

Public Class frm_productreport
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Btn_clo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub frm_productreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub Btn_refres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim prodrep As New frm_productreport
        Me.Hide()
        prodrep.Show()
    End Sub

    Private Sub Dgv_product_report_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        command = New SqlCommand("select*from Tbl_productregisteration ", connection)
        da = New SqlDataAdapter
        da.SelectCommand = command
        ds = New DataSet
        da.Fill(ds)
        Dgv_product_report.DataSource = ds.Tables(0)
        Dgv_product_report.Refresh()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim prodprint As New frm_productprint
        prodprint.Show()
    End Sub
End Class