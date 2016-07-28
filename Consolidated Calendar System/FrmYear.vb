Imports MetroFramework
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Public Class FrmYear


    Private Sub ml_save_Click(sender As Object, e As EventArgs) Handles ml_save.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim tablename As String = mcb_year.Text

        Command = New MySqlCommand
        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()
            query = "CREATE TABLE `saoevent" & tablename & "` LIKE saoevent"
            ' for copying all
            ' query = "CREATE TABLE `saoevent" & tablename & "` LIKE saoevent; INSERT into `saoevent" & tablename & "` SELECT * FROM saoevent;"
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader

            MetroMessageBox.Show(Me, "School Year succesfully created", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub ml_delete_Click(sender As Object, e As EventArgs) Handles ml_delete.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim bsource As New BindingSource
        Dim tablename As String = mcb_year.Text


        Dim a As Integer
        a = MetroMessageBox.Show(Me, "Are you sure you want to delete this record of the year?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If a = vbYes Then
            Command = New MySqlCommand
            Dim reader As MySqlDataReader

            Try
                MysqlConn.Open()
                query = "Drop table `saoevent" & mcb_year.Text & "`"

                Command = New MySqlCommand(query, MysqlConn)
                reader = Command.ExecuteReader

                MetroMessageBox.Show(Me, "School Year successfully deleted", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                MysqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()

            End Try
        Else


        End If
    End Sub


    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        My.Settings.schoolyear = mcb_year.Text
        MetroMessageBox.Show(Me, "School Year successfully loaded", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        'SHOWING DATA FROM THE TABLE
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
            FrmHome.HomeMetroGrid1.DataSource = bsource
            FrmEvent.MetroGrid1.DataSource = bsource
            FrmGuest.HGMetroGrid.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ml_exit_Click(sender As Object, e As EventArgs) Handles ml_exit.Click
        Me.Hide()
    End Sub

    Private Sub ml_minimize_Click(sender As Object, e As EventArgs) Handles ml_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        mcb_year.Text = My.Settings.schoolyear
    End Sub
End Class