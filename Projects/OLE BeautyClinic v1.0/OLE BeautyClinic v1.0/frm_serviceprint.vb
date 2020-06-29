Public Class frm_serviceprint

    Private Sub frm_serviceprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = "C:\Users\Malu\Documents\Visual Studio 2008\Projects\OLE BeautyClinic v1.0\OLE BeautyClinic v1.0\CrystalReport8.rpt"
        CrystalReportViewer1.Show()
    End Sub
End Class