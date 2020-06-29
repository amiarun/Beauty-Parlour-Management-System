Public Class frm_studentprint

    Private Sub frm_studentprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = "C:\Users\Malu\Documents\Visual Studio 2008\Projects\OLE BeautyClinic v1.0\OLE BeautyClinic v1.0\CrystalReport10.rpt"
        CrystalReportViewer1.Show()

    End Sub
End Class