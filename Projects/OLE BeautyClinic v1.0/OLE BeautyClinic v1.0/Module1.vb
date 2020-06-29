Imports System.Data.SqlClient
Module Module1
    'variables in settings
    Public custregset, staffregset, studentregset, productregset, serviceregset, billregset, bookingregset, incomeregset, expenseregset, cashregset, custrepset, staffrepset, studentrepset, productrepset, servicerepset, billrepset, bookingrepset, incomerepset, expenserepset, cashrepset, settingset As Integer

    Public sq As String

    'getting username
    Public uname As String
    Public home As New frm_home
    Public login As New frm_login
    Public studreport As New frm_studentreport
    Public stud As New frm_studentregistration
    Public staffreport As New frm_staffreport
    Public staff As New frm_staffregistration
    Public setting As New frm_settings
    Public servreport As New frm_servicereport
    Public servpackage As New frm_servicepackage
    Public prodreport As New frm_productreport
    Public product As New frm_productregistration
    Public incomereport As New frm_incomereport
    Public income As New frm_incomeregistration
    Public exprep As New frm_expencereport
    Public expence As New frm_expenceregistration
    Public custrep As New frm_customerreport
    Public custcat As New frm_customer_Registration
    Public customer As New frm_customer_Registration
    Public cashreport As New frm_cashreport
    Public cash As New frm_cashbook
    Public bookingreport As New frm_bookingreport
    Public booking As New frm_booking
    Public billreport As New frm_billreport
    Public bill As New frm_billing

    'connection
    Public connection As New SqlConnection("Server=MALUTY\SQLEXPRESS;Database=beauty parlour;Integrated Security=true")
    Public command As New SqlCommand

    'data grid view
    Public da As New SqlDataAdapter
    Public ds As DataSet
    Public dr As SqlDataReader
    Public Sub validateMe(ByVal frm As Form)
        Dim ctl As Control
        For Each ctl In frm.Controls
            If TypeOf ctl Is GroupBox Then
                Dim ctl1 As Control
                For Each ctl1 In ctl.Controls
                    If TypeOf ctl1 Is TextBox Then
                        If ctl1.Text = "" Then
                            Dim epr As New ErrorProvider
                            epr.SetError(ctl1, "error")
                        End If
                    End If
                Next
            End If
        Next
    End Sub
End Module
