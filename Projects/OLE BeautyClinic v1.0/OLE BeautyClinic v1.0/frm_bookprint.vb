Public Class frm_bookprint

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frm_bookprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = "C:\Users\Malu\Documents\Visual Studio 2008\Projects\OLE BeautyClinic v1.0\OLE BeautyClinic v1.0\CrystalReport2.rpt"
        CrystalReportViewer1.Show()
    End Sub

    Private Sub CrystalReportViewer1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class