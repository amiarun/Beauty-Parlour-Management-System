Public Class MDI_olebeautyclinic

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Dim cust As New Frm_custreg
    Private Sub CustomerRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerRegistrationToolStripMenuItem.Click
        cust.ShowDialog()

    End Sub
    Dim staf As New Frm_stf
    Private Sub StaffRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffRegistrationToolStripMenuItem.Click
        staf.ShowDialog()

    End Sub
    Dim serv As New Frm_sregis
    Private Sub ServiceRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceRegistrationToolStripMenuItem.Click
        serv.ShowDialog()

    End Sub
    Dim prod As New Frm_proreg
    Private Sub ProductRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductRegistrationToolStripMenuItem.Click
        prod.ShowDialog()

    End Sub
    Dim stud As New Frm_studreg
    Private Sub StudentRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentRegistrationToolStripMenuItem.Click
        stud.ShowDialog()

    End Sub
    Dim book As New Frm_bkg
    Private Sub BookingFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingFormToolStripMenuItem.Click
        book.ShowDialog()

    End Sub
    Dim bill As New Frm_bilreg
    Private Sub BillingFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingFormToolStripMenuItem.Click
        bill.ShowDialog()

    End Sub
    Dim crep As New Frm_customer
    Private Sub CustomerReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerReportToolStripMenuItem.Click
        crep.ShowDialog()

    End Sub
    Dim staff As New Frm_stfreport
    Private Sub StaffReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StaffReportToolStripMenuItem.Click
        staff.ShowDialog()

    End Sub
    Dim ser As New Frm_serrep
    Private Sub ServiceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceReportToolStripMenuItem.Click
        ser.ShowDialog()


    End Sub
    Dim pro As New Frm_prorep
    Private Sub ProductReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductReportToolStripMenuItem.Click
        pro.ShowDialog()

    End Sub
    Dim boo As New Frm_booking
    Private Sub BookingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookingReportToolStripMenuItem.Click
        boo.ShowDialog()

    End Sub
    Dim billi As New Frm_bill
    Private Sub BillingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingReportToolStripMenuItem.Click
        billi.ShowDialog()

    End Sub
    Dim stu As New Frm_sreport
    Private Sub StudentReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentReportToolStripMenuItem.Click
        stu.ShowDialog()

    End Sub
    Dim log As New Frm_login
    Private Sub LoginFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginFormToolStripMenuItem.Click
        log.ShowDialog()

    End Sub
    Dim user As New Frm_user
    Private Sub UserSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserSettingsToolStripMenuItem.Click
        user.ShowDialog()

    End Sub
    Dim inco As New Frm_increg
    Private Sub IncomeRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncomeRegistrationToolStripMenuItem.Click
        inco.ShowDialog()

    End Sub
    Dim exp As New Frm_expreg
    Private Sub ExpenceRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpenceRegistrationToolStripMenuItem.Click
        exp.ShowDialog()

    End Sub
    Dim cas As New Frm_cashbook
    Private Sub CashBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashBookToolStripMenuItem.Click
        cas.ShowDialog()

    End Sub
    Dim income As New Frm_incomrep

    Private Sub IncomereportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncomereportToolStripMenuItem.Click
        income.ShowDialog()

    End Sub
    Dim expen As New Frm_exprep
    Private Sub ExpenceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpenceReportToolStripMenuItem.Click
        expen.ShowDialog()

    End Sub
    Dim cs As New Frm_cashrep
    Private Sub CashReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CashReportToolStripMenuItem.Click
        cs.ShowDialog()

    End Sub
End Class