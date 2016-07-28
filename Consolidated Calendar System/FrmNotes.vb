Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports MetroFramework

Public Class FrmNotes
    Private Sub ml_save_Click(sender As Object, e As EventArgs) Handles ml_save.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            MysqlConn.Open()
            Dim query As String
            query = "select * from saoinfo.saoreminder where saonotenumber ='" & tb_nn.Text & "' "


            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader
            Dim count As Integer

            count = 0
            While reader.Read
                count += 1

            End While

            If count = 1 Then
                MsgBox("The Note# " & tb_nn.Text & " is already in used", MsgBoxStyle.Critical, "Note# Used")

            Else
                If tb_nn.Text = "" Or rtb_n.Text = "" Or mdt_ndtp.Text = "" Then
                    MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    MysqlConn.Close()

                    MysqlConn.Open()

                    query = "insert into saoinfo.saoreminder (saonotenumber,saoreminderdate,saonote) values ('" & tb_nn.Text & "' , '" & Format(CDate(mdt_ndtp.Value), "yyyy-MM-dd") & "' ,'" & rtb_n.Text & "')"
                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader
                    MetroMessageBox.Show(Me, "Note Submitted", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
            query = "select saonotenumber as 'Note#' , saoreminderdate as 'Date', saonote as 'Note' from saoinfo.saoreminder"
            Command = New MySqlCommand(query, MysqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            FrmHome.MetroNoteGrid.DataSource = bsource
            SDA.Update(dbdataset)
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Try
            MysqlConn.Open()

            query = "Select MAX(saonotenumber) from saoreminder"
            Dim reader As MySqlDataReader
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader

            If reader.Read = True Then
                tb_nn.Text = reader.Item(0) + 1

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


        If tb_nn.Text = "" Or rtb_n.Text = "" Then
            MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            a = MetroMessageBox.Show(Me, "Are you sure you want to update this note?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If a = vbYes Then
                Dim reader As MySqlDataReader
                Dim SDA As New MySqlDataAdapter
                Dim dbdataset As New DataTable
                Dim bsource As New BindingSource

                Try
                    MysqlConn.Open()
                    Dim query As String


                    query = "select * from saoinfo.saoreminder where saonotenumber ='" & tb_nn.Text & "' "

                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader
                    Dim count As Integer

                    count = 0
                    '  While reader.Read
                    'count += 1

                    '  End While

                    If count = 1 Then
                        MsgBox("The Note# " & tb_nn.Text & " is already in used", MsgBoxStyle.Critical, "Note# Used")


                    Else
                        If tb_nn.Text = "" Or rtb_n.Text = "" Or mdt_ndtp.Text = "" Then
                            MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                        Else
                            MysqlConn.Close()

                            MysqlConn.Open()

                            query = "update saoinfo.saoreminder set saoreminderdate='" & Format(CDate(mdt_ndtp.Value), "yyyy-MM-dd") & "',saonote ='" & rtb_n.Text & "' , saonotenumber='" & tb_nn.Text & "'
            where saonotenumber='" & tb_nn.Text & "'"

                            Command = New MySqlCommand(query, MysqlConn)
                            reader = Command.ExecuteReader
                            MetroMessageBox.Show(Me, "Note Updated", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
                    query = "select saonotenumber as 'Note#' , saoreminderdate as 'Date', saonote as 'Note' from saoinfo.saoreminder"
                    Command = New MySqlCommand(query, MysqlConn)
                    SDA.SelectCommand = Command
                    SDA.Fill(dbdataset)
                    bsource.DataSource = dbdataset
                    FrmHome.MetroNoteGrid.DataSource = bsource
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

        If tb_nn.Text = "" Or rtb_n.Text = "" Then
            MetroMessageBox.Show(Me, "No selected note", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Question)


        Else


            a = MetroMessageBox.Show(Me, "Are you sure you want to delete this note?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

            If a = vbYes Then
                Dim reader As MySqlDataReader
                Dim SDA As New MySqlDataAdapter
                Dim dbdataset As New DataTable
                Dim bsource As New BindingSource

                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "Delete from saoinfo.saoreminder where saonotenumber='" & tb_nn.Text & "'"
                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader


                    rtb_n.Text = ""
                    mdt_ndtp.Text = ""
                    MetroMessageBox.Show(Me, "Note Deleted", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    MysqlConn.Close()


                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)

                Finally
                    MysqlConn.Dispose()

                End Try

                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "select saonotenumber as 'Note#' , saoreminderdate as 'Date', saonote as 'Note' from saoinfo.saoreminder"
                    Command = New MySqlCommand(query, MysqlConn)
                    SDA.SelectCommand = Command
                    SDA.Fill(dbdataset)
                    bsource.DataSource = dbdataset
                    FrmHome.MetroNoteGrid.DataSource = bsource
                    SDA.Update(dbdataset)
                    MysqlConn.Close()

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)
                Finally
                    MysqlConn.Dispose()
                End Try
            End If

        End If
    End Sub

    Private Sub ml_clear_Click(sender As Object, e As EventArgs) Handles ml_clear.Click
        rtb_n.Text = ""
        mdt_ndtp.Text = ""
    End Sub

    Private Sub ml_exit_Click(sender As Object, e As EventArgs) Handles ml_exit.Click
        Me.Hide()
    End Sub

    Private Sub ml_minimize_Click(sender As Object, e As EventArgs) Handles ml_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class