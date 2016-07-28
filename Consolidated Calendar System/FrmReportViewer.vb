Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports MetroFramework

Public Class FrmReportViewer
    Private Sub FrmReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        printreport()

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub printreport()
        Dim SDA As New MySqlDataAdapter
        Dim ds As New DataSet1

        SDA.SelectCommand = New MySqlCommand("Select date_format(date, '%W, %M %d %Y ')as 'Date',Location, TimeFrom ,TimeTo , Events,School,kpi,noa,remarks from `saoevent" & My.Settings.schoolyear & "`", MysqlConn)
        SDA.Fill(ds.Tables(0))

        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub mcb_filtercollege_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcb_filtercollege.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim ds As New DataSet1

        Dim Query As String
        Query = "select * from `saoevent" & My.Settings.schoolyear & "` where school like '" & mcb_filtercollege.Text & "'"
        Command = New MySqlCommand(Query, MysqlConn)
        SDA.SelectCommand = Command
        SDA.Fill(ds.Tables(0))
        'bSource.DataSource = ds
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ml_search_Click(sender As Object, e As EventArgs) Handles ml_search.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim ds As New DataSet1

        Dim Query As String
        Query = "select * from `saoevent" & My.Settings.schoolyear & "` where Date BETWEEN '" & Format(CDate(mdtp_filter1.Value), "yyyy-MM-dd") & "' AND '" & Format(CDate(mdtp_filter2.Value), "yyyy-MM-dd") & "'"


        Command = New MySqlCommand(Query, MysqlConn)



        SDA.SelectCommand = Command
        SDA.Fill(ds.Tables(0))
        'bSource.DataSource = ds
        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ml_exit_Click(sender As Object, e As EventArgs) Handles ml_exit.Click
        Me.Hide()
    End Sub

    Private Sub ml_minimize_Click(sender As Object, e As EventArgs) Handles ml_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub mb_refresh_Click(sender As Object, e As EventArgs) Handles mb_refresh.Click
        Dim SDA As New MySqlDataAdapter
        Dim ds As New DataSet1

        SDA.SelectCommand = New MySqlCommand("Select date_format(date, '%W, %M %d %Y ')as 'Date',Location, TimeFrom ,TimeTo , Events,School,kpi,noa,remarks from `saoevent" & My.Settings.schoolyear & "`", MysqlConn)
        SDA.Fill(ds.Tables(0))

        ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local
        ReportViewer1.LocalReport.ReportPath = System.Environment.CurrentDirectory & "\Report1.rdlc"
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", ds.Tables(0)))
        ReportViewer1.DocumentMapCollapsed = True
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class