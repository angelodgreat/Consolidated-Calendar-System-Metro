Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Imports MetroFramework
Public Class FrmAccounts


    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles tb_searchaccount.TextChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim query As String
            query = "SELECT * from saoinfo.saouserinfo where id='" & tb_searchaccount.Text & "'"
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader
            While reader.Read

                tb_id.Text = reader.GetString("id")
                tb_id.Enabled = False
                mcb_school.Text = reader.GetString("college")
                tb_fname.Text = reader.GetString("FName")
                tb_mname.Text = reader.GetString("MName")
                tb_lname.Text = reader.GetString("LName")
                tb_uname.Text = reader.GetString("UName")
                tb_uname.Enabled = False
                mcb_usertype.Text = reader.GetString("usertype")

            End While

            MysqlConn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub lb_accounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_accounts.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim query As String
            query = "SELECT * from saoinfo.saouserinfo where id='" & lb_accounts.Text & "'"
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader
            While reader.Read

                tb_id.Text = reader.GetString("id")
                tb_id.Enabled = False
                mcb_school.Text = reader.GetString("college")
                tb_fname.Text = reader.GetString("FName")
                tb_mname.Text = reader.GetString("MName")
                tb_lname.Text = reader.GetString("LName")
                tb_uname.Text = reader.GetString("UName")
                tb_uname.Enabled = False
                mcb_usertype.Text = reader.GetString("usertype")

            End While

            MysqlConn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub FrmAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim query As String
            query = "SELECT * from saoinfo.saouserinfo "
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader
            While reader.Read
                Dim sID = reader.GetString("id")
                lb_accounts.Items.Add(sID)
            End While

            MysqlConn.Close()


        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub ml_save_Click(sender As Object, e As EventArgs) Handles ml_save.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader


        Try
            MysqlConn.Open()
            Dim query As String
            query = "Select * from saoinfo.saouserinfo where id='" & tb_id.Text & "' or UName='" & tb_uname.Text & "' "
            Command = New MySqlCommand(query, MysqlConn)
            reader = Command.ExecuteReader
            Dim count As Integer

            count = 0
            While reader.Read
                count += 1
            End While

            If count = 1 Then
                MsgBox("The account " & tb_id.Text & " already exist! ", MsgBoxStyle.Critical, "Account Existing")

                MsgBox("The username " & tb_uname.Text & " already exist! ", MsgBoxStyle.Critical, "Username Existing")
            Else
                If ((tb_id.Text = "") Or (mcb_school.Text = "-") Or (tb_fname.Text = "") Or (tb_lname.Text = "") Or (tb_uname.Text = "") Or (tb_password.Text = "") Or (tb_retypepass.Text = "") Or (mcb_usertype.Text = "-")) Then
                    MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)



                Else
                    MysqlConn.Close()

                    MysqlConn.Open()
                    query = "insert into saoinfo.saouserinfo (id,college,FName,MName,LName,UName,Password,usertype) values ('" & tb_id.Text & "','" & mcb_school.Text & "','" & tb_fname.Text & "','" & tb_mname.Text & "','" & tb_lname.Text & "','" & tb_uname.Text & "','" & tb_retypepass.Text & "','" & mcb_usertype.Text & "')"
                    Command = New MySqlCommand(query, MysqlConn)
                    Dim tempuser As String

                    If tb_password.Text <> tb_retypepass.Text Then
                        MetroMessageBox.Show(Me, "Password does not match", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Else
                        reader = Command.ExecuteReader

                        tempuser = lb_accounts.Text
                        lb_accounts.Items.Add(tempuser)

                        MetroMessageBox.Show(Me, "Account Registered", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        MysqlConn.Close()

                    End If
                End If
            End If


        Catch ex As MySqlException


            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub ml_clear_Click(sender As Object, e As EventArgs) Handles ml_clear.Click
        mcb_school.Text = "-"
        mcb_usertype.Text = "-"
        tb_id.Text = ""
        tb_fname.Text = ""
        tb_mname.Text = ""
        tb_lname.Text = ""
        tb_uname.Text = ""
        tb_password.Text = ""
        tb_retypepass.Text = ""
    End Sub

    Private Sub ml_delete_Click(sender As Object, e As EventArgs) Handles ml_delete.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring



        Dim a As Integer


        If tb_id.Text = "" Then
            MetroMessageBox.Show(Me, "No Selected User", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Else
            a = MetroMessageBox.Show(Me, "Are you sure you want to delete this account?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If a = vbYes Then
                Command = New MySqlCommand
                Dim reader As MySqlDataReader
                Dim tempusername As String

                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "Delete from saoinfo.saouserinfo where id='" & tb_id.Text & "'"
                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader
                    tempusername = lb_accounts.Text
                    lb_accounts.Items.Remove(tempusername)

                    mcb_school.Text = "-"
                    mcb_usertype.Text = "-"
                    tb_id.Text = ""
                    tb_fname.Text = ""
                    tb_mname.Text = ""
                    tb_lname.Text = ""
                    tb_uname.Text = ""
                    tb_password.Text = ""
                    tb_retypepass.Text = ""
                    MetroMessageBox.Show(Me, "Account Deleted", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Information)




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

    Private Sub ml_update_Click(sender As Object, e As EventArgs) Handles ml_update.Click
        'UPDATING ACCOUNTS IN REGISTER FORM
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader
        Dim a As Integer

        If tb_id.Text = "" And tb_uname.Text = "" Then
            MetroMessageBox.Show(Me, "No selected user/ Please input an ID", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            a = MetroMessageBox.Show(Me, "Are you sure you want to update this account?", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If a = vbYes Then
                Try
                    MysqlConn.Open()
                    Dim query As String
                    query = "Select * from saoinfo.saouserinfo where id='" & tb_id.Text & "' or UName='" & tb_uname.Text & "' "
                    Command = New MySqlCommand(query, MysqlConn)
                    reader = Command.ExecuteReader
                    Dim count As Integer

                    count = 0
                    While reader.Read
                        count += 1
                    End While

                    If count = 1 Then

                        If ((tb_id.Text = "") Or (mcb_school.Text = "-") Or (tb_fname.Text = "") Or (tb_lname.Text = "") Or (tb_uname.Text = "") Or (tb_password.Text = "") Or (tb_retypepass.Text = "") Or (mcb_usertype.Text = "-")) Then
                            MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)



                        Else
                            MysqlConn.Close()

                            MysqlConn.Open()

                            query = "update saoinfo.saouserinfo Set id='" & tb_id.Text & "',college='" & mcb_school.Text & "',FName='" & tb_fname.Text & "',MName='" & tb_mname.Text & "',LName='" & tb_lname.Text & "',UName='" & tb_uname.Text & "',
                    Password='" & tb_retypepass.Text & "', usertype='" & mcb_usertype.Text & "'
                    where id= '" & tb_id.Text & "' "
                            Command = New MySqlCommand(query, MysqlConn)


                            If tb_password.Text <> tb_retypepass.Text Then
                                MetroMessageBox.Show(Me, "Password does not match", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                            Else
                                reader = Command.ExecuteReader
                                MetroMessageBox.Show(Me, "Account Updated", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                MysqlConn.Close()
                            End If

                        End If
                    End If


                Catch ex As MySqlException
                    MessageBox.Show(ex.Message)

                Finally
                    MysqlConn.Dispose()

                End Try

            Else


            End If
        End If
    End Sub

    Private Sub ml_exit_Click(sender As Object, e As EventArgs) Handles ml_exit.Click
        Me.Hide()
    End Sub

    Private Sub ml_minimize_Click(sender As Object, e As EventArgs) Handles ml_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class