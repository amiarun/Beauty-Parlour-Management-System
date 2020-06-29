Imports System.Data.SqlClient

Public Class frm_incomereport
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Btn_clo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Btn_refres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim increp As New frm_incomereport
        Me.Hide()
        increp.Show()
    End Sub

    Private Sub frm_incomereport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'data grid veiw
        command = New SqlCommand("select*from Tbl_incomeregistration ", connection)
        da = New SqlDataAdapter(command)
        ds = New DataSet
        da.Fill(ds)
        dgv_incomerep.DataSource = ds.Tables(0)
        dgv_incomerep.Refresh()

    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim incomeprint As New frm_incomeprint
        incomeprint.Show()
    End Sub
End Class