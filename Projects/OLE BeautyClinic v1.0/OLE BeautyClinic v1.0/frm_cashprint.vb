Public Class frm_cashprint

    Private Sub frm_cashprint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ReportSource = ".rptC:\Users\Malu\Documents\Visual Studio 2008\Projects\OLE BeautyClinic v1.0\OLE BeautyClinic v1.0\CrystalReport3.rpt"
        CrystalReportViewer1.Show()
    End Sub
End Class