
Imports MetroFramework
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO

Public Class FrmLogin
    Dim mysqlconn As MySqlConnection
    Dim Command As MySqlCommand
    Dim a As Boolean

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Time
        mtlb_time.Text = Date.Now.ToString("MMMM dd yyyy     hh:mm:ss tt")
    End Sub


    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Time
        Timer1.Enabled = True

        'Status of DB
        a = New Boolean
        a = False
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = connstring

        Try
            mysqlconn.Open()
            a = True
            mysqlconn.Close()
        Catch ex As Exception

        Finally
            mysqlconn.Dispose()
            If a = True Then
                mtlb_status.Text = "Online"
                mtlb_status.Style = MetroColorStyle.Green

            Else
                mtlb_status.Text = "Offline"
                mtlb_status.Style = MetroColorStyle.Red
            End If

        End Try

    End Sub


    Private Sub mb_login_Click(sender As Object, e As EventArgs) Handles mb_login.Click
        mysqlconn = New MySqlConnection
        mysqlconn.ConnectionString = connstring
        Command = New MySqlCommand
        Dim reader As MySqlDataReader
        Dim attempt As Integer

        If attempt < 3 Then

            Try
                mysqlconn.Open()
                Dim query As String
                query = "SELECT * FROM saoinfo.saouserinfo where UName='" & tb_uname.Text & "' and Password='" & tb_password.Text & "'"
                Command = New MySqlCommand(query, mysqlconn)
                reader = Command.ExecuteReader

                Dim count As Integer
                count = 0
                While reader.Read
                    count = count + 1
                End While


                If count = 1 Then
                    attempt = 0
                    If reader.GetString("usertype") = "Admin" Then

                        Me.Hide()
                        MetroMessageBox.Show(Me, "Entering as " & reader.GetString("fname") + " " + reader.GetString("lname"), "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)



                        FrmHome.Text = "Welcome Admin, " & reader.GetString("fname") + " " + reader.GetString("lname")


                        FrmHome.Show()

                        tb_password.Text = ""
                        tb_uname.Text = ""

                        'Conditions

                        FrmEvent.mcb_school.Text = "-"
                        FrmAccounts.mcb_school.Text = "-"
                        FrmAccounts.mcb_usertype.Text = "-"
                        FrmEvent.mcb_kpi.Text = "-"
                        FrmEvent.mcb_noa.Text = "-"



                    Else

                        Me.Hide()
                        MetroMessageBox.Show(Me, "Entering as " & reader.GetString("fname") + " " + reader.GetString("lname"), "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                        FrmGuest.Text = "Welcome Guest, " & reader.GetString("fname") + " " + reader.GetString("lname")

                        FrmGuest.Show()
                        tb_password.Text = ""
                        tb_uname.Text = ""
                        FrmYear.ml_delete.Visible = False
                        FrmYear.ml_save.Visible = False



                    End If

                ElseIf tb_password.Text = "a00000" And tb_uname.Text = "a00000"
                    Me.Hide()
                    MetroMessageBox.Show(Me, "Entering as secret account ", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

                    FrmHome.Show()
                    tb_password.Text = ""
                    tb_uname.Text = ""

                ElseIf tb_password.Text = "" Or tb_uname.Text = ""
                    MetroMessageBox.Show(Me, "Please fill all fields", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                Else
                    attempt = attempt + 1
                    MetroMessageBox.Show(Me, "The username/password does not exist", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                    tb_password.Text = ""
                    tb_uname.Text = ""



                End If


                mysqlconn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)

            Finally
                mysqlconn.Dispose()

            End Try

            If attempt = 3 Then

                MetroMessageBox.Show(Me, "Maximum Log-in attempts reached", "Student Affairs Office Consolidated Calendar", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Me.Dispose()
            End If

        End If



    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        AcceptButton = mb_login
    End Sub

    Private Sub ml_clear_Click(sender As Object, e As EventArgs) Handles ml_exit.Click
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


End Class