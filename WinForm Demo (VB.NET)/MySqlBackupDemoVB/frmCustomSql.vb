Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class frmCustomSql

    Private constr As String = ""

    Public Sub New(ByVal connectionString As String)
        constr = connectionString
        InitializeComponent()
    End Sub

    Private Sub btExecute1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btExecute1.Click
        Dim a As String = txt1.Text.ToLower()
        For Each s As String In GetReturnResultQueryStatement()
            If a.StartsWith(s) Then
                DoSelect(txt1.Text)
                Return
            End If
        Next
        Execute(txt1.Text)
    End Sub

    Private Sub btExecute2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btExecute2.Click
        Dim a As String = txt2.Text.ToLower()
        For Each s As String In GetReturnResultQueryStatement()
            If a.StartsWith(s) Then
                DoSelect(txt2.Text)
                Return
            End If
        Next
        Execute(txt2.Text)
    End Sub

    Private Sub btExecute3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btExecute3.Click
        Dim a As String = txt3.Text.ToLower()
        For Each s As String In GetReturnResultQueryStatement()
            If a.StartsWith(s) Then
                DoSelect(txt3.Text)
                Return
            End If
        Next
        Execute(txt3.Text)
    End Sub

    Private Sub Execute(ByVal input As String)
        Try
            Dim i As Integer = 0
            Using conn As New MySqlConnection(constr)
                Dim cmd As New MySqlCommand()
                cmd.Connection = conn
                conn.Open()

                cmd.CommandText = input
                i = cmd.ExecuteNonQuery()

                conn.Close()
            End Using

            Dim dt As New DataTable()
            dt.Columns.Add("Rows affected")
            Dim s As String = ""
            If i > 1 Then
                s = "s"
            End If
            dt.Rows.Add(i & " row" & s & " affected by the last command. No resultset returned.")
            dataGridView1.DataSource = Nothing
            dataGridView1.DataSource = dt
            AutoResize()
        Catch ex As Exception
            ShowException(ex)
        End Try
    End Sub

    Private Sub DoSelect(ByVal input As String)

        Dim dt As New DataTable()

        Try
            Using conn As New MySqlConnection(constr)
                Dim cmd As New MySqlCommand()
                cmd.Connection = conn
                conn.Open()

                cmd.CommandText = input

                Dim da As New MySqlDataAdapter(cmd)

                da.Fill(dt)

                conn.Close()
            End Using

            Dim dt2 As New DataTable()
            For Each dc As DataColumn In dt.Columns
                dt2.Columns.Add(dc.ColumnName)
            Next
            Dim c As Integer = -1
            For Each dr As DataRow In dt.Rows
                c += 1
                dt2.Rows.Add()
                For Each dc As DataColumn In dt.Columns
                    Dim data As String = ""
                    If dr(dc.ColumnName).[GetType]() Is GetType(System.DateTime) Then
                        data = DirectCast(dr(dc.ColumnName), DateTime).ToString("yyyy-MM-dd HH:mm:ss")
                    ElseIf dr(dc.ColumnName).[GetType]() Is GetType(MySql.Data.Types.MySqlDateTime) Then
                        data = DirectCast(dr(dc.ColumnName), MySql.Data.Types.MySqlDateTime).Value.ToString("yyyy-MM-dd HH:mm:ss")
                    ElseIf dr(dc.ColumnName).[GetType]() Is GetType(Byte()) Then
                        data = "System.Byte[" & DirectCast(dr(dc.ColumnName), Byte()).Length & "]"
                    Else
                        data = dr(dc.ColumnName) & ""
                    End If
                    dt2.Rows(c)(dc.ColumnName) = data
                Next
            Next

            dataGridView1.DataSource = Nothing
            dataGridView1.DataSource = dt2

            AutoResize()
        Catch ex As Exception
            ShowException(ex)
        End Try

    End Sub

    Private Function GetReturnResultQueryStatement() As String()
        Dim sa As String() = textBox1.Text.Split(New Char() {","c}, StringSplitOptions.RemoveEmptyEntries)
        For i As Integer = 0 To sa.Length - 1
            sa(i) = sa(i).ToLower().Trim()
        Next
        Return sa
    End Function

    Private Sub ShowException(ByVal ex As Exception)
        Dim dt As New DataTable()
        dt.Columns.Add("Error")
        dt.Rows.Add(ex.Message)
        dataGridView1.DataSource = Nothing
        dataGridView1.DataSource = dt
        AutoResize()
    End Sub

    Private Sub AutoResize()
        For Each dc As DataGridViewColumn In dataGridView1.Columns
            dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
    End Sub

    Private Sub txt3_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) _
        Handles txt1.KeyPress, txt2.KeyPress, txt3.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
            Dim a As String = DirectCast(sender, TextBox).Text.ToLower()
            For Each s As String In GetReturnResultQueryStatement()
                If a.StartsWith(s) Then
                    DoSelect(DirectCast(sender, TextBox).Text)
                    e.Handled = True
                    Return
                End If
            Next
            Execute(DirectCast(sender, TextBox).Text)
            e.Handled = True
        End If
    End Sub

End Class