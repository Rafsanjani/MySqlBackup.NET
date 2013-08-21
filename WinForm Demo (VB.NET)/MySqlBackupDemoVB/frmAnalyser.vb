Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class frmAnalyser

    Private totalSection As Integer = 0
    Private [error] As Integer = 0
    Private sb As StringBuilder
    Private bw As New BackgroundWorker()
    Private connection As String = ""

    Public Sub New(ByVal constr As String)
        connection = constr
        InitializeComponent()
        webBrowser1.DocumentText = "<h1>Database is being analysed...<br />Please wait...</h1>"
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
        bw.RunWorkerAsync()
    End Sub

    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        webBrowser1.DocumentText = sb.ToString()
    End Sub

    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        sb = New StringBuilder()
        sb.Append("<html><head><style>h1 { line-height:160%; font-size: 20pt; } h2 { line-height:160%; font-size: 14pt; } body { font-family: Segoe UI; color: #5C5C5C; line-height: 150%; } table { border: 1px solid #5C5C5C; border-collapse: collapse; } td { font-size: 10pt; padding: 4px; border: 1px solid #5C5C5C; } .code { font-family: Courier New; font-size: 10pt; line-height:110%; } </style></head>")
        sb.Append("<body>")

        Dim dt As New DataTable()
        Dim user As String = ""
        Dim database As String = ""
        Using conn As New MySqlConnection(connection)
            Dim cmd As New MySqlCommand()
            conn.Open()

            Dim da As New MySqlDataAdapter()
            da.SelectCommand = New MySqlCommand()
            da.SelectCommand.Connection = conn

            Try
                ' Database
                totalSection += 1
                sb.Append("<h1>Database Analyse Report</h1><hr />")
                da.SelectCommand.CommandText = "select database();"
                database = da.SelectCommand.ExecuteScalar() & ""
                sb.Append("<h2>" & database & "</h2>")
                da.SelectCommand.CommandText = "show create database `" & database & "`;"
                dt = New DataTable()
                da.Fill(dt)
                sb.Append("<p><span class=""code"">" & dt.Rows(0)(1) & "</span></p>")
            Catch ex As Exception
                RecordError(ex)
            End Try

            Try
                ' User
                totalSection += 1
                sb.Append("<h1>User</h1>")
                da.SelectCommand.CommandText = "select current_user;"
                user = ((da.SelectCommand.ExecuteScalar() & "").Split("@"c))(0)
                sb.Append("<h2>" & user & "</h2>")
            Catch ex As Exception
                RecordError(ex)
            End Try

            Try
                ' Global Privileges
                totalSection += 1
                sb.Append("<h2>Global Privileges</h2>")
                da.SelectCommand.CommandText = "SELECT  mu.host `Host`,  mu.user `User`,  REPLACE(RTRIM(CONCAT(  IF(mu.Select_priv = 'Y', 'Select ', ''),  IF(mu.Insert_priv = 'Y', 'Insert ', ''),  IF(mu.Update_priv = 'Y', 'Update ', ''),  IF(mu.Delete_priv = 'Y', 'Delete ', ''),  IF(mu.Create_priv = 'Y', 'Create ', ''),  IF(mu.Drop_priv = 'Y', 'Drop ', ''),  IF(mu.Reload_priv = 'Y', 'Reload ', ''),  IF(mu.Shutdown_priv = 'Y', 'Shutdown ', ''),  IF(mu.Process_priv = 'Y', 'Process ', ''),  IF(mu.File_priv = 'Y', 'File ', ''),  IF(mu.Grant_priv = 'Y', 'Grant ', ''),  IF(mu.References_priv = 'Y', 'References ', ''),  IF(mu.Index_priv = 'Y', 'Index ', ''),  IF(mu.Alter_priv = 'Y', 'Alter ', ''),  IF(mu.Show_db_priv = 'Y', 'Show_db ', ''),  IF(mu.Super_priv = 'Y', 'Super ', ''),  IF(mu.Create_tmp_table_priv = 'Y', 'Create_tmp_table ', ''),  IF(mu.Lock_tables_priv = 'Y', 'Lock_tables ', ''),  IF(mu.Execute_priv = 'Y', 'Execute ', ''),  IF(mu.Repl_slave_priv = 'Y', 'Repl_slave ', ''),  IF(mu.Repl_client_priv = 'Y', 'Repl_client ', ''),  IF(mu.Create_view_priv = 'Y', 'Create_view ', ''),  IF(mu.Show_view_priv = 'Y', 'Show_view ', ''),  IF(mu.Create_routine_priv = 'Y', 'Create_routine ', ''),  IF(mu.Alter_routine_priv = 'Y', 'Alter_routine ', ''),  IF(mu.Create_user_priv = 'Y', 'Create_user ', ''),  IF(mu.Event_priv = 'Y', 'Event ', ''),  IF(mu.Trigger_priv = 'Y', 'Trigger ', '')  )), ' ', ', ') AS `Privileges` FROM  mysql.user mu where mu.User = '" & user & "' ORDER BY  mu.Host,  mu.User;"
                dt = New DataTable()
                da.Fill(dt)
                sb.Append(GetTableHtml(dt))
            Catch ex As Exception
                RecordError(ex)
            End Try

            Try
                totalSection += 1
                ' Database Privileges
                sb.Append("<h2>Database Privileges</h2>")
                da.SelectCommand.CommandText = "SELECT  md.host `Host`,  md.user `User`,  md.db `Database`,  REPLACE(RTRIM(CONCAT(  IF(md.Select_priv = 'Y', 'Select ', ''),  IF(md.Insert_priv = 'Y', 'Insert ', ''),  IF(md.Update_priv = 'Y', 'Update ', ''),  IF(md.Delete_priv = 'Y', 'Delete ', ''),  IF(md.Create_priv = 'Y', 'Create ', ''),  IF(md.Drop_priv = 'Y', 'Drop ', ''),  IF(md.Grant_priv = 'Y', 'Grant ', ''),  IF(md.References_priv = 'Y', 'References ', ''),  IF(md.Index_priv = 'Y', 'Index ', ''),  IF(md.Alter_priv = 'Y', 'Alter ', ''),  IF(md.Create_tmp_table_priv = 'Y', 'Create_tmp_table ', ''),  IF(md.Lock_tables_priv = 'Y', 'Lock_tables ', ''),  IF(md.Create_view_priv = 'Y', 'Create_view ', ''),  IF(md.Show_view_priv = 'Y', 'Show_view ', ''),  IF(md.Create_routine_priv = 'Y', 'Create_routine ', ''),  IF(md.Alter_routine_priv = 'Y', 'Alter_routine ', ''),  IF(md.Execute_priv = 'Y', 'Execute ', ''),  IF(md.Event_priv = 'Y', 'Event ', ''),  IF(md.Trigger_priv = 'Y', 'Trigger ', '')  )), ' ', ', ') AS `Privileges` FROM  mysql.db md where md.Db = '" & database & "' ORDER BY  md.Host,  md.User,  md.Db;"
                dt = New DataTable()
                da.Fill(dt)
                sb.Append(GetTableHtml(dt))
            Catch ex As Exception
                RecordError(ex)
            End Try

            Try
                totalSection += 1
                ' Privileges of View
                sb.Append("<h2>Privileges of View</h2>")
                da.SelectCommand.CommandText = "SELECT  mv.host `Host`,  mv.user `User`,  CONCAT(mv.Db, '.', mv.Table_name) `Views`,  REPLACE(mv.Table_priv, ',', ', ') AS `Privileges` FROM  mysql.tables_priv mv WHERE mv.Db = '" & database & "' and mv.Table_name IN  (SELECT  DISTINCT    v.table_name `views`  FROM    information_schema.views AS v  ) ORDER BY  mv.Host,  mv.User,  mv.Db,  mv.Table_name;"
                dt = New DataTable()
                da.Fill(dt)
                sb.Append(GetTableHtml(dt))
            Catch ex As Exception
                RecordError(ex)
            End Try

            ' Privileges of Procedure
            Try
                totalSection += 1
                sb.Append("<h2>Privileges of Procedure</h2>")
                da.SelectCommand.CommandText = "SELECT  mp.host `Host`,  mp.user `User`,  CONCAT(mp.Db, '.', mp.Routine_name) `Procedures`,  REPLACE(mp.Proc_priv, ',', ', ') AS `Privileges` FROM  mysql.procs_priv mp WHERE mp.Db = '" & database & "' and mp.Routine_type = 'PROCEDURE' ORDER BY  mp.Host,  mp.User,  mp.Db,  mp.Routine_name;"
                dt = New DataTable()
                da.Fill(dt)
                sb.Append(GetTableHtml(dt))
            Catch ex As Exception
                RecordError(ex)
            End Try

            ' Privileges of Function
            Try
                totalSection += 1
                sb.Append("<h2>Privileges of Function</h2>")
                da.SelectCommand.CommandText = "SELECT  mf.host `Host`,  mf.user `User`,  CONCAT(mf.Db, '.', mf.Routine_name) `Procedures`,  REPLACE(mf.Proc_priv, ',', ', ') AS `Privileges` FROM  mysql.procs_priv mf WHERE mf.Db = '" & database & "' and mf.Routine_type = 'FUNCTION' ORDER BY  mf.Host,  mf.User,  mf.Db,  mf.Routine_name;"
                dt = New DataTable()
                da.Fill(dt)
                sb.Append(GetTableHtml(dt))
            Catch ex As Exception
                RecordError(ex)
            End Try

            Try
                totalSection += 1
                ' Get Variables
                da.SelectCommand.CommandText = "show variables;"
                dt = New DataTable()
                da.Fill(dt)
                sb.Append("<h1>Show Variables</h1>")
                sb.Append(GetTableHtml(dt))
            Catch ex As Exception
                RecordError(ex)
            End Try

            Try
                totalSection += 1
                ' Get Tables
                da.SelectCommand.CommandText = "show table status;"
                dt = New DataTable()
                da.Fill(dt)
                sb.Append("<h1>Show Table Status</h1>")
                sb.Append("<p>Note: ""Total Rows"" shown in this table is not accurate.</p>")
                sb.Append(GetTableHtml(dt))
            Catch ex As Exception
                RecordError(ex)
            End Try

            Dim dt2 As New DataTable()

            Try
                totalSection += 1
                ' Show Create Tables
                sb.Append("<h1>Create Table</h1>")
                For Each drDT As DataRow In dt.Rows
                    da.SelectCommand.CommandText = "show create table `" & drDT(0) & "`;"
                    dt2 = New DataTable()
                    da.Fill(dt2)
                    sb.Append("<h2>" & drDT(0) & "</h2>")
                    sb.Append("<span class=""code"">")
                    sb.Append(GetHtmlString(dt2.Rows(0)(1) & ""))
                    sb.Append("</span>")
                Next
            Catch ex As Exception
                RecordError(ex)
            End Try

            Try
                totalSection += 1
                ' Table Collation

                sb.Append("<h1>Show Full Columns</h1>")
                For Each drDT As DataRow In dt.Rows
                    da.SelectCommand.CommandText = "show full columns from `" & drDT(0) & "`;"
                    dt2 = New DataTable()
                    da.Fill(dt2)
                    sb.Append("<h2>" & drDT(0) & "</h2>")
                    sb.Append(GetTableHtml(dt2))
                Next
            Catch ex As Exception
                RecordError(ex)
            End Try

            ' Procedure
            Try
                totalSection += 1
                sb.Append("<h1>Show Procedure Status</h1>")
                da.SelectCommand.CommandText = "show procedure status where Db = '" & database & "';"
                dt = New DataTable()
                da.Fill(dt)
                sb.Append(GetTableHtml(dt))
                For Each dr As DataRow In dt.Rows
                    da.SelectCommand.CommandText = "show create procedure `" & dr("Name") & "`;"
                    dt2 = New DataTable()
                    da.Fill(dt2)
                    sb.Append("<p><strong>" & da.SelectCommand.CommandText & "</strong></p>")
                    sb.Append(GetTableHtml(dt2))
                Next
            Catch ex As Exception
                RecordError(ex)
            End Try

            ' Function
            Try
                totalSection += 1
                sb.Append("<h1>Show Function Status</h1>")
                da.SelectCommand.CommandText = "show function status where Db = '" & database & "';"
                dt = New DataTable()
                da.Fill(dt)
                sb.Append(GetTableHtml(dt))
                For Each dr As DataRow In dt.Rows
                    da.SelectCommand.CommandText = "show create function `" & dr("Name") & "`;"
                    dt2 = New DataTable()
                    da.Fill(dt2)
                    sb.Append("<p><strong>" & da.SelectCommand.CommandText & "</strong></p>")
                    sb.Append(GetTableHtml(dt2))
                Next
            Catch ex As Exception
                RecordError(ex)
            End Try

            ' Triggers
            Try
                totalSection += 1
                sb.Append("<h1>Show  Triggers</h1>")
                da.SelectCommand.CommandText = "show triggers;"
                dt = New DataTable()
                da.Fill(dt)
                sb.Append(GetTableHtml(dt))
            Catch ex As Exception
                RecordError(ex)
            End Try

            ' Events
            Try
                totalSection += 1
                sb.Append("<h1>Show Events</h1>")
                da.SelectCommand.CommandText = "show events;"
                dt = New DataTable()
                da.Fill(dt)
                sb.Append(GetTableHtml(dt))
                For Each dr As DataRow In dt.Rows
                    da.SelectCommand.CommandText = "show create event `" & dr("Name") & "`;"
                    dt2 = New DataTable()
                    da.Fill(dt2)
                    sb.Append("<p><strong>" & da.SelectCommand.CommandText & "</strong></p>")
                    sb.Append(GetTableHtml(dt2))
                Next
            Catch ex As Exception
                RecordError(ex)
            End Try

            conn.Close()
        End Using

        sb.Append("<br /><br /><hr /><h1>Conclusion of Analysis for Database Backup/Restore Task</h1>")
        sb.Append("<p>Test Result: " & (totalSection - [error]) & " out of " & totalSection & " tests have passed.</p>")
        If [error] = 0 Then
            sb.Append("<p><strong>A full database backup can be executed.</strong></p>")
        Else
            sb.Append("<p><strong>Full backup might not successfully due to user privilege limitations.</strong></p>")
        End If

        sb.Append("</body>")
        sb.Append("</html>")

    End Sub

    Private Function GetTableHtml(ByVal dt As DataTable) As String

        Dim sb2 As New StringBuilder()

        sb2.Append("<table>")

        sb2.Append("<tr>")
        For Each dc As DataColumn In dt.Columns
            sb2.Append("<td>")
            sb2.Append(GetHtmlString(dc.ColumnName))
            sb2.Append("</td>")
        Next
        sb2.Append("</tr>")
        For Each dr As DataRow In dt.Rows
            sb2.Append("<tr>")
            For Each dc As DataColumn In dt.Columns
                sb2.Append("<td>")
                sb2.Append(GetHtmlString((dr(dc.ColumnName) & "")))
                sb2.Append("</td>")
            Next
            sb2.Append("</tr>")
        Next
        sb2.Append("</table>")

        Return sb2.ToString()

    End Function

    Private Function GetHtmlString(ByVal input As String) As String
        input = input.Replace(vbCr & vbLf, "^^^|||").Replace(vbLf, "^^^|||").Replace(vbCr, "^^^|||")
        Dim sb As New System.Text.StringBuilder()
        For Each c As Char In input
            Select Case c
                Case "&"c
                    sb.AppendFormat("&amp;")
                    Exit Select
                Case """"c
                    sb.AppendFormat("&quot;")
                    Exit Select
                Case "'"c
                    sb.AppendFormat("&#39;")
                    Exit Select
                Case "<"c
                    sb.AppendFormat("&lt;")
                    Exit Select
                Case ">"c
                    sb.AppendFormat("&gt;")
                    Exit Select
                Case Else
                    sb.Append(c)
                    Exit Select
            End Select
        Next
        Return sb.ToString().Replace("^^^|||", "<br />")
    End Function

    Private Sub btExport_Click(ByVal sender As Object, ByVal e As EventArgs)

        Using sf As New SaveFileDialog()
            sf.Filter = "HTML|*.html"
            sf.FileName = "Report.html"
            If sf.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                System.IO.File.WriteAllText(sf.FileName, webBrowser1.DocumentText, Encoding.UTF8)
                MessageBox.Show("Report exported successfully at:" & vbLf & sf.FileName)
            End If
        End Using

    End Sub

    Private Sub RecordError(ByVal ex As Exception)
        [error] += 1
        sb.Append("<p>" & GetHtmlString(ex.Message) & "</p>")
    End Sub

End Class