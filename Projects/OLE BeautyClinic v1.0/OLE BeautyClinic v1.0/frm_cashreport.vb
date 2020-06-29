Imports System.Data.SqlClient
Public Class frm_cashreport
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Btn_clo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frm_cashreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        command = New SqlCommand("select * from  Tbl_cashregistration", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        Dgv_cashreport.DataSource = ds.Tables(0)
        Dgv_cashreport.Refresh()
    End Sub

    Private Sub Btn_refres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cashrep As New frm_cashreport
        Me.Hide()
        cashrep.Show()
    End Sub

    Private Sub Dgv_cashreport_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cashprint As New frm_cashprint
        cashprint.Show()
    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        Me.Close()

    End Sub
End Class