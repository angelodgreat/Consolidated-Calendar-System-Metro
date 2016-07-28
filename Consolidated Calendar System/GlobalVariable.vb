Imports MySql.Data.MySqlClient
Module GlobalVariableodule

    Public MysqlConn As MySqlConnection
    Public connstring As String = "server=localhost;userid=root;password=root;database=saoinfo"
    Public query As String

    Public Command As MySqlCommand
    Public dbdataset As New DataTable
    Public reader As MySqlDataReader


End Module
