Imports System.Data.SqlClient
Public Class frm_home

    Private connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Private command As New SqlCommand

    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Dim log As New frm_login
        log.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_customerreg.Click
        Dim cust As New frm_customer_Registration
        cust.Show()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_settings.Click
        Dim setting As New frm_settings
        setting.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bookingreg.Click
        Dim book As New frm_booking
        book.Show()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_billingreg.Click
        Dim bill As New frm_billing
        bill.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_staffreg.Click
        Dim staff As New frm_staffregistration
        staff.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_servicereg.Click
        Dim service As New frm_servicepackage
        service.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_productreg.Click
        Dim product As New frm_productregistration
        product.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_studentreg.Click
        Dim student As New frm_studentregistration
        student.Show()


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_incomereg.Click
        Dim income As New frm_incomeregistration
        income.Show()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_expencereg.Click
        Dim expence As New frm_expenceregistration
        expence.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cashreg.Click
        Dim cash As New frm_cashbook
        cash.Show()

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_customerrep.Click
        Dim custrep As New frm_customerreport
        custrep.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_staffrep.Click
        Dim staffrep As New frm_staffreport
        staffrep.Show()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_servicerep.Click
        Dim servicrep As New frm_servicereport
        servicrep.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_productrep.Click
        Dim prodrep As New frm_productreport
        prodrep.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_studentrep.Click
        Dim studrep As New frm_studentreport
        studrep.Show()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bookingrep.Click
        Dim bookrep As New frm_bookingreport
        bookrep.Show()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_billrep.Click
        Dim billrep As New frm_billreport
        billrep.Show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_incomerep.Click
        Dim incomerep As New frm_incomereport
        incomerep.Show()

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_expencerep.Click
        Dim exprep As New frm_expencereport
        exprep.Show()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cashrep.Click
        Dim cashrep As New frm_cashreport
        cashrep.Show()

    End Sub

    Private Sub frm_home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
        command = New sqlcommand("select *from Tbl_user where userid='" & uname & "'", connection)
        dr = command.ExecuteReader
        While dr.Read
            btn_customerreg.Enabled = dr.Item("custregset")
            btn_staffreg.Enabled = dr.Item("staffregset")
            btn_studentreg.Enabled = dr.Item("studentregset")
            btn_productreg.Enabled = dr.Item("productregset")
            btn_servicereg.Enabled = dr.Item("serviceregset")
            btn_bookingreg.Enabled = dr.Item("bookingregset")
            btn_billingreg.Enabled = dr.Item("billregset")
            btn_incomereg.Enabled = dr.Item("incomeregset")
            btn_expencereg.Enabled = dr.Item("expenseregset")
            btn_cashreg.Enabled = dr.Item("cashregset")
            btn_customerrep.Enabled = dr.Item("customerrepset")
            btn_staffrep.Enabled = dr.Item("staffrepset")
            btn_studentrep.Enabled = dr.Item("studentrepset")
            btn_productrep.Enabled = dr.Item("productrepset")
            btn_servicerep.Enabled = dr.Item("servicerepset")
            btn_bookingrep.Enabled = dr.Item("bookingrepset")
            btn_billrep.Enabled = dr.Item("billingrepset")
            btn_incomerep.Enabled = dr.Item("incomerepset")
            btn_expencerep.Enabled = dr.Item("expenserepset")
            btn_cashrep.Enabled = dr.Item("cashrepset")
            btn_settings.Enabled = dr.Item("settingset")
        End While
        dr.Close()

    End Sub
End Class
