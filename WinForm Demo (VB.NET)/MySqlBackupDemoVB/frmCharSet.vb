Imports MySql.Data.MySqlClient
Public Class frmCharSet

    Public Sub New(ByVal connectionString As String)

        InitializeComponent()

        Using conn As New MySqlConnection(connectionString)

            conn.Open()
            Dim sql As String = "SHOW VARIABLES LIKE 'character_set\_%';"
            Dim dt As New DataTable()
            Dim da As New MySqlDataAdapter(sql, conn)
            da.Fill(dt)
            dataGridView1.DataSource = dt

            Dim dt2 As New DataTable()
            sql = "SHOW TABLE STATUS;"
            da = New MySqlDataAdapter(sql, conn)
            da.Fill(dt2)

            Dim dt3 As New DataTable()
            dt3.Columns.Add("Table")
            dt3.Columns.Add("Collation")

            For Each dr As DataRow In dt2.Rows
                If dr("Engine") + "" <> "" Then
                    dt3.Rows.Add(dr("Name") + "", dr("Collation") + "")
                End If
            Next

            dt2.Dispose()

            dataGridView2.DataSource = dt3

            conn.Close()

        End Using

        For Each dc As DataGridViewColumn In dataGridView1.Columns
            dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next
        For Each dc As DataGridViewColumn In dataGridView2.Columns
            dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        dataGridView2.DefaultCellStyle = dataGridView1.DefaultCellStyle

    End Sub

End Class