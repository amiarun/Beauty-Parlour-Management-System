Imports System.Data.SqlClient
Public Class frm_studentreport
    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand
    Private a As Integer
    Private Sub Btn_clo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub frm_studentreport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub

    Private Sub Btn_refres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim studrep As New frm_staffreport
        Me.Hide()
        studrep.Show()
    End Sub

    Private Sub Dgv_student_report_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim studentprint As New frm_studentprint
        studentprint.Show()

    End Sub
End Class