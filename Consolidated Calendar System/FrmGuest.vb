Imports MetroFramework
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Public Class FrmGuest
    Private Sub FrmGuest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()
        Timer1.Enabled = True
    End Sub

    Public Sub load_table()
        'MAIN TABLE
        'SHOWING DATA FROM THE TABLE
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource

        Try
            MysqlConn.Open()
            Dim query As String
            query = "select eventid as 'ID', date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            HGMetroGrid.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to log-out?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If a = vbYes Then
            Me.Dispose()
            FrmLogin.Show()

        Else


        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to exit?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If a = vbYes Then
            Application.ExitThread()

        Else


        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.Show()
    End Sub

    Private Sub ml_exit_Click(sender As Object, e As EventArgs) Handles ml_exit.Click
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to exit?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If a = vbYes Then
            Application.ExitThread()

        Else


        End If
    End Sub

    Private Sub ml_minimize_Click(sender As Object, e As EventArgs) Handles ml_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub filtersearch_location_TextChanged(sender As Object, e As EventArgs) Handles filtersearch_location.TextChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MysqlConn.Open()
            Dim query As String
            query = "select eventid as 'ID', date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            HGMetroGrid.DataSource = bsource
            FrmEvent.MetroGrid1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

            MysqlConn.Dispose()
        End Try



        Dim DV As New DataView(dbdataset)
        DV.RowFilter = String.Format("location Like'%{0}%'", filtersearch_location.Text)
        HGMetroGrid.DataSource = DV
    End Sub

    Private Sub ml_search_Click(sender As Object, e As EventArgs) Handles ml_search.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select eventid as 'ID', date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as'Remarks' from `saoevent" & My.Settings.schoolyear & "` where Date BETWEEN '" & Format(CDate(mdtph_filter1.Value), "yyyy-MM-dd") & "' AND '" & Format(CDate(mdtph_filter2.Value), "yyyy-MM-dd") & "'"


            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            HGMetroGrid.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub mcb_filtercollege_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mcb_filtercollege.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select * from `saoevent" & My.Settings.schoolyear & "` where school like '" & mcb_filtercollege.Text & "'"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset

            HGMetroGrid.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ml_refresh_Click(sender As Object, e As EventArgs) Handles ml_refresh.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select eventid as 'ID', date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            HGMetroGrid.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mtlb_time.Text = Date.Now.ToString("MMMM dd yyyy     hh:mm:ss tt")
        mlb_showsem.Text = My.Settings.schoolyear
    End Sub

    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click
        FrmYear.Show()
        FrmYear.mcb_year.Text = My.Settings.schoolyear
    End Sub


End Class