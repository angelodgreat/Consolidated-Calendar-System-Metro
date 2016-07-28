Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports MetroFramework

Public Class FrmEvent

    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.MetroGrid1.Rows(e.RowIndex)

            tb_eventid.Text = row.Cells("ID").Value.ToString
            time_picker_from.Text = row.Cells("From").Value.ToString
            time_picker_to.Text = row.Cells("To").Value.ToString
            mdtp_datepicker.Text = row.Cells("Date").Value.ToString
            mcb_location.Text = row.Cells("Location").Value.ToString
            rtb_event.Text = row.Cells("Events").Value.ToString
            mcb_school.Text = row.Cells("School/Organization").Value.ToString
            mcb_kpi.Text = row.Cells("KPI").Value.ToString
            mcb_noa.Text = row.Cells("Nature of Activity").Value.ToString
            cb_remarks.Text = row.Cells("Remarks").Value.ToString



            ' tb_input_event.Enabled = False

        End If
    End Sub

    Private Sub ml_save_Click(sender As Object, e As EventArgs) Handles ml_save.Click
        'ADDING EVENTS IN CALENDAR EVENT
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MysqlConn.Open()
            Dim query As String

            ' Original code for detecting time conflict
            ' query = "Select * from saoinfo.saoevent where  TimeFrom='" & Format(CDate(time_picker_from.Value), "hh:mm") & "' and TimeTo ='" & Format(CDate(time_picker_to.Value), "hh:mm") & "'and location='" & tb_location.Text & "'and date='" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & "' "
            ' Modified code for detecting time conflict

            'TO BE EDITTED BECAUSE OF LOCATION PROBLEM

            'query = "select * from saoinfo.saoevent where  ('" & Format(CDate(time_picker_from.Value), "hh:mm") & " " & tb_location.Text & "' BETWEEN concat(' ',timefrom,location) AND concat(' ',timeto,location)) OR (' " & Format(CDate(time_picker_to.Value), "hh:mm") & " " & tb_location.Text & "' BETWEEN concat(' ',timefrom,location) AND concat(' ',timeto,location)) and date='" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & "' "
            query = "select * from `saoevent" & My.Settings.schoolyear & "` where (location = '" & mcb_location.Text & "') AND (('" & Format(CDate(mdtp_datepicker.Value), "yyyy-MM-dd") & " " & Format(CDate(time_picker_from.Value), "hh:mm:00") & "' BETWEEN concat(date,' ',timefrom) AND concat(date,' ',timeto)) OR
            ('" & Format(CDate(mdtp_datepicker.Value), "yyyy-MM-dd") & " " & Format(CDate(time_picker_to.Value), "hh:mm:00") & "' BETWEEN concat(date,' ',timefrom) AND concat(date,' ',timeto)))"


            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader
            Dim count As Integer

            count = 0
            While reader.Read
                count += 1

            End While

            If count = 1 Then
                MsgBox("The time " & Format(CDate(time_picker_from.Value), "hh:mm") & " is already occupied.", MsgBoxStyle.Critical, "Time Occupied")
                MsgBox("The location " & mcb_location.Text & " is already occupied.", MsgBoxStyle.Critical, "Location is occupied")
            Else
                If mcb_location.Text = "" Or rtb_event.Text = "" Or tb_eventid.Text = "" Or mcb_school.Text = "-" Or mcb_kpi.Text = "-" Or mcb_noa.Text = "-" Then

                    MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    MysqlConn.Close()

                    MysqlConn.Open()

                    query = "insert into `saoevent" & My.Settings.schoolyear & "` (Date,location,events,TimeFrom,TimeTo,eventid,school,kpi,noa,remarks) values ('" & Format(CDate(mdtp_datepicker.Value), "yyyy-MM-dd") & "','" & mcb_location.Text & "','" & rtb_event.Text & "','" & Format(CDate(time_picker_from.Value), "hh:mm ") & "','" & Format(CDate(time_picker_to.Value), "hh:mm") & "','" & tb_eventid.Text & "','" & mcb_school.Text & "','" & mcb_kpi.Text & "','" & mcb_noa.Text & "','" & cb_remarks.Text & "')"
                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader

                    MetroMessageBox.Show(Me, "Event Submitted", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    MysqlConn.Close()

                End If


            End If



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try

        Try
            MysqlConn.Open()
            Dim query As String
            query = "select eventid as 'ID' ,date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as'School/Organization',kpi as'KPI',noa as 'Nature of Activity',remarks as 'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            FrmHome.HomeMetroGrid1.DataSource = bsource
            MetroGrid1.DataSource = bsource
            SDA.Update(dbdataset)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Try
            MysqlConn.Open()

            query = "Select MAX(eventid) from `saoevent" & My.Settings.schoolyear & "`"
            Dim reader As MySqlDataReader
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader

            If reader.Read = True Then
                tb_eventid.Text = reader.Item(0) + 1

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub ml_update_Click(sender As Object, e As EventArgs) Handles ml_update.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim a As Integer

        If tb_eventid.Text = "" Or mcb_location.Text = "" Or rtb_event.Text = "" Or mcb_kpi.Text = "-" Or mcb_noa.Text = "-" Or mcb_school.Text = "-" Then

            MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Else
            a = MetroMessageBox.Show(Me, "Are you sure you want to update this event?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If a = vbYes Then
                Dim reader As MySqlDataReader
                Dim SDA As New MySqlDataAdapter
                Dim dbdataset As New DataTable
                Dim bsource As New BindingSource

                Try
                    MysqlConn.Open()
                    Dim query As String

                    'query = "select * from saoinfo.saoevent where  ('" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & "  " & Format(CDate(time_picker_from.Value), "hh:mm") & "' BETWEEN concat(date,' ',timefrom) AND concat(date,' ',timeto)) OR ('" & Format(CDate(event_datetimepicker.Value), "yyyy-MM-dd") & " " & Format(CDate(time_picker_to.Value), "hh:mm") & "' BETWEEN concat(date,' ',timefrom) AND concat(date,' ',timeto))"

                    query = "select * from `saoevent" & My.Settings.schoolyear & "` where (location = '" & mcb_location.Text & "') AND (('" & Format(CDate(mdtp_datepicker.Value), "yyyy-MM-dd") & " " & Format(CDate(time_picker_from.Value), "hh:mm:00") & "' BETWEEN concat(date,' ',timefrom) AND concat(date,' ',timeto)) OR
                  ('" & Format(CDate(mdtp_datepicker.Value), "yyyy-MM-dd") & " " & Format(CDate(time_picker_to.Value), "hh:mm:00") & "' BETWEEN concat(date,' ',timefrom) AND concat(date,' ',timeto)))"

                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader
                    Dim count As Integer

                    count = 0
                    While reader.Read
                        count += 1

                    End While

                    If count = 1 Then

                        MsgBox("The time " & Format(CDate(time_picker_from.Value), "hh:mm tt") & " is already occupied", MsgBoxStyle.Critical, "Time Occupied")
                        MsgBox("The location " & mcb_location.Text & " is already occupied", MsgBoxStyle.Critical, "Location is occupied")
                    Else
                        If mcb_location.Text = "" Or rtb_event.Text = "" Or tb_eventid.Text = "" Or mcb_school.Text = "-" Or mcb_kpi.Text = "-" Or mcb_noa.Text = "-" Then
                            MetroMessageBox.Show(Me, "Please fill all fields.", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        Else
                            MysqlConn.Close()

                            MysqlConn.Open()

                            query = "update `saoevent" & My.Settings.schoolyear & "` set date='" & Format(CDate(mdtp_datepicker.Value), "yyyy-MM-dd") & "',location='" & mcb_location.Text & "',TimeFrom='" & Format(CDate(time_picker_from.Value), "hh:mm") & "',TimeTo='" & Format(CDate(time_picker_to.Value), "hh:mm") & "',Events='" & rtb_event.Text & "' ,eventid='" & tb_eventid.Text & "' ,school= '" & mcb_school.Text & "',
                            kpi='" & mcb_kpi.Text & "',noa='" & mcb_noa.Text & "', remarks='" & cb_remarks.Text & "'  where eventid='" & tb_eventid.Text & "'"

                            Command = New MySqlCommand(query, MysqlConn)
                            reader = Command.ExecuteReader
                            MetroMessageBox.Show(Me, "Event Updated", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                            MysqlConn.Close()

                        End If


                    End If



                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)

                Finally
                    MysqlConn.Dispose()

                End Try

                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "select eventid as 'ID' ,date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as'School/Organization',kpi as'KPI',noa as 'Nature of Activity',remarks as 'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
                    Command = New MySqlCommand(query, MysqlConn)
                    SDA.SelectCommand = Command
                    SDA.Fill(dbdataset)
                    bsource.DataSource = dbdataset
                    MetroGrid1.DataSource = bsource
                    FrmHome.HomeMetroGrid1.DataSource = bsource
                    SDA.Update(dbdataset)

                    MysqlConn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try
            Else


            End If


        End If
    End Sub

    Private Sub ml_delete_Click(sender As Object, e As EventArgs) Handles ml_delete.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim a As Integer



        If tb_eventid.Text = "" Then
            MetroMessageBox.Show(Me, "No selected date", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Else
            a = MetroMessageBox.Show(Me, "Are you sure you want to delete this event?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If a = vbYes Then




                Dim reader As MySqlDataReader
                Dim SDA As New MySqlDataAdapter
                Dim dbdataset As New DataTable
                Dim bsource As New BindingSource

                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "Delete from `saoevent" & My.Settings.schoolyear & "` where eventid='" & tb_eventid.Text & "'"
                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader

                    mdtp_datepicker.Text = ""
                    mcb_location.Text = ""
                    rtb_event.Text = ""
                    mcb_school.Text = "-"
                    mcb_kpi.Text = "-"
                    mcb_noa.Text = "-"
                    cb_remarks.Text = ""

                    MetroMessageBox.Show(Me, "Event Deleted", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    MysqlConn.Close()


                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)

                Finally
                    MysqlConn.Dispose()

                End Try

                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "select eventid as 'ID' ,date as 'Date',TimeFrom as'From' ,TimeTo as 'To' , location as 'Location' , events as 'Events',school as'School/Organization',kpi as 'KPI',noa as 'Nature of Activity',remarks as 'Remarks' from `saoevent" & My.Settings.schoolyear & "` order by eventid desc"
                    Command = New MySqlCommand(query, MysqlConn)
                    SDA.SelectCommand = Command
                    SDA.Fill(dbdataset)
                    bsource.DataSource = dbdataset
                    MetroGrid1.DataSource = bsource
                    FrmHome.HomeMetroGrid1.DataSource = bsource
                    SDA.Update(dbdataset)

                    MysqlConn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try

            Else


            End If
        End If
    End Sub

    Private Sub ml_clear_Click(sender As Object, e As EventArgs) Handles ml_clear.Click
        mdtp_datepicker.Text = ""
        mcb_location.Text = ""
        rtb_event.Text = ""
        mcb_school.Text = "-"
        mcb_kpi.Text = "-"
        mcb_noa.Text = "-"
        cb_remarks.Text = ""
    End Sub

    Private Sub ml_print_Click(sender As Object, e As EventArgs) Handles ml_print.Click
        FrmReportViewer.Show()
    End Sub

    Private Sub ml_exit_Click(sender As Object, e As EventArgs) Handles ml_exit.Click
        Me.Hide()

    End Sub

    Private Sub ml_minimize_Click(sender As Object, e As EventArgs) Handles ml_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class