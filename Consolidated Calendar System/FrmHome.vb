Imports MetroFramework
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Public Class FrmHome

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click

        FrmEvent.Show()

        Try
            MysqlConn.Open()

            query = "Select MAX(eventid) from `saoevent" & My.Settings.schoolyear & "`"
            Dim reader As MySqlDataReader
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader

            If reader.Read = True Then
                FrmEvent.tb_eventid.Text = reader.Item(0) + 1

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        FrmAccounts.Show()

    End Sub

    Private Sub MetroTile4_Click_1(sender As Object, e As EventArgs) Handles MetroTile4.Click
        FrmNotes.Show()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try
            MysqlConn.Open()

            query = "Select MAX(saonotenumber) from saoreminder"
            Dim reader As MySqlDataReader
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader

            If reader.Read = True Then
                FrmNotes.tb_nn.Text = reader.Item(0) + 1

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click
        FrmYear.Show()
        FrmYear.mcb_year.Text = My.Settings.schoolyear
    End Sub

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        load_table()
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
            query = "select eventid as 'ID', date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as 'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            HomeMetroGrid1.DataSource = bsource
            FrmEvent.MetroGrid1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally

            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub MetroTabPage2_Enter(sender As Object, e As EventArgs) Handles MetroTabPage2.Enter
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MysqlConn.Open()
            Dim query As String
            query = "select saonotenumber as 'Note#' , saoreminderdate as 'Date', saonote as 'Note' from saoinfo.saoreminder"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            MetroNoteGrid.DataSource = bsource
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mtlb_time.Text = Date.Now.ToString("MMMM dd yyyy     hh:mm:ss tt")
        mlb_showsem.Text = My.Settings.schoolyear
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


    Private Sub ml_search_Click(sender As Object, e As EventArgs) Handles ml_search.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Try
            MysqlConn.Open()
            Dim query As String
            query = "select eventid as 'ID', date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as 'Remarks' from `saoevent" & My.Settings.schoolyear & "` where Date BETWEEN '" & Format(CDate(mdtph_filter1.Value), "yyyy-MM-dd") & "' AND '" & Format(CDate(mdtph_filter2.Value), "yyyy-MM-dd") & "'"


            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            HomeMetroGrid1.DataSource = bsource
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
            query = "select eventid as 'ID', date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as 'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            HomeMetroGrid1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        FrmReportViewer.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.Show()
    End Sub

    Private Sub HomeMetroGrid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles HomeMetroGrid1.CellDoubleClick
        Dim a As Integer


        a = MetroMessageBox.Show(Me, "Are you sure you want to update this selected date?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = vbYes Then
            FrmEvent.Show()

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = FrmEvent.MetroGrid1.Rows(e.RowIndex)

                FrmEvent.tb_eventid.Text = row.Cells("ID").Value.ToString
                FrmEvent.time_picker_from.Text = row.Cells("From").Value.ToString
                FrmEvent.time_picker_to.Text = row.Cells("To").Value.ToString
                FrmEvent.mdtp_datepicker.Text = row.Cells("Date").Value.ToString
                FrmEvent.mcb_location.Text = row.Cells("Location").Value.ToString
                FrmEvent.rtb_event.Text = row.Cells("Events").Value.ToString
                FrmEvent.mcb_school.Text = row.Cells("School/Organization").Value.ToString
                FrmEvent.mcb_kpi.Text = row.Cells("KPI").Value.ToString
                FrmEvent.mcb_noa.Text = row.Cells("Nature of Activity").Value.ToString
                FrmEvent.cb_remarks.text = row.Cells("Remarks").Value.ToString




            End If

        End If


    End Sub

    Private Sub MetroNoteGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroNoteGrid.CellDoubleClick
        Dim a As Integer

        a = MetroMessageBox.Show(Me, "Are you sure you want to update this selected note?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = vbYes Then
            FrmNotes.Show()

            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = MetroNoteGrid.Rows(e.RowIndex)


                FrmNotes.tb_nn.Text = row.Cells("Note#").Value.ToString
                FrmNotes.mdt_ndtp.Text = row.Cells("Date").Value.ToString
                FrmNotes.rtb_n.Text = row.Cells("Note").Value.ToString





            End If

        End If
    End Sub

    Private Sub mcb_filtercollege_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles mcb_filtercollege.SelectedIndexChanged
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

            HomeMetroGrid1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub filtersearch_location_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filtersearch_location.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MysqlConn.Open()
            Dim query As String
            query = "select eventid as 'ID', date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as 'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            HomeMetroGrid1.DataSource = bsource
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
        HomeMetroGrid1.DataSource = DV
    End Sub

    Private Sub mcb_filtercollege_TextChanged(sender As Object, e As EventArgs) Handles mcb_filtercollege.TextChanged
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

            HomeMetroGrid1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
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
            query = "select eventid as 'ID', date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as 'School/Organization',kpi as'KPI',noa as'Nature of Activity',remarks as 'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            HomeMetroGrid1.DataSource = bsource
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
        HomeMetroGrid1.DataSource = DV
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        Dim file As String
        sfd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        sfd.FileName = "Database Backup " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
        If sfd.ShowDialog = DialogResult.OK Then
            file = sfd.FileName
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 5.7\bin"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysqldump -u root --password=root -h AngeloUmaliPC ""saoinfo"" > """ + file + """ ")
            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()
            MsgBox("Backup Created Successfully!", MsgBoxStyle.Information, "Backup")

        End If
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        Dim file As String
        opd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        If opd.ShowDialog = DialogResult.OK Then
            file = opd.FileName
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 5.7\bin"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysql -u root --password=root -h AngeloUmaliPC ""saoinfo"" < """ + file + """ ")
            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()
            MsgBox("Database Restoration Successfully!", MsgBoxStyle.Information, "Restore")
        End If
    End Sub
End Class