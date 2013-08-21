Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class frmSampleData

    Private rd As New Random()
    Private m As New Methods()
    Private constr As String = ""

    Private [error] As Boolean = False

    Private timerStart As Timer
    Private timerStop As Timer

    Private curRow As Integer = 0
    Private curTable As Integer = 0
    Private curtablename As String = ""
    Private cancelProcess As Boolean = False
    Private bw As BackgroundWorker

    Private data As String = ""


    Public Sub New(ByVal connectionString As String)
        constr = connectionString
        InitializeComponent()
        txtPrefix.Text = ""
        txtPrefix.Text = "testtable"
    End Sub


    Private Sub txtPrefix_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
        Handles txtPrefix.TextChanged

        label3.Text = String.Format("{0}1, {0}2, {0}3...", txtPrefix.Text.Trim())
        label5.Text = "CREATE TABLE IF NOT EXISTS `" & txtPrefix.Text.Trim() & "1`"

    End Sub

    Private Sub btView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btView.Click
        textBox3.Text = NewHeader(1) & GetRandomData()
    End Sub

    Private Function GetRandomData() As String

        If rbfix.Checked Then
            If Not data Is Nothing AndAlso Not String.IsNullOrEmpty(data.Trim) Then Return data
        End If

        Dim ba As Byte() = New Byte(15) {}

        rd.NextBytes(ba)
        Dim guid As New Guid(ba)

        Dim sb As New StringBuilder()
        sb.Append("(")
        sb.Append(String.Format("'{0}',", m.RandomString(50)))
        sb.Append(String.Format("{0},", m.random.[Next](9000, 100000000)))
        sb.Append(String.Format("{0},", m.random.NextDouble()))
        sb.Append(String.Format("{0},", m.random.NextDouble()))
        sb.Append(String.Format("{0},", m.random.[Next](1, 9999)))
        sb.Append(String.Format("'{0}',", m.RandomString(50)))
        sb.Append(String.Format("'{0}',", DateTime.Now.AddDays(m.random.[Next](1, 100)).ToString("yyyy-MM-dd HH:mm:ss")))
        sb.Append(String.Format("'{0}',", DateTime.Now.AddDays(m.random.[Next](1, 100)).ToString("yyyy-MM-dd")))
        sb.Append(String.Format("'{0}',", DateTime.Now.AddDays(m.random.[Next](1, 100)).ToString("HH:mm:ss")))
        sb.Append(String.Format("{0},", m.random.[Next](1, 200)))
        sb.Append(String.Format("{0},", m.random.[Next](1, 10000) & "." & m.random.[Next](1, 99)))
        sb.Append("CURRENT_TIMESTAMP,")
        sb.Append(String.Format("'{0}',", guid.ToString()))
        sb.Append(String.Format(m.GetBLOBSqlDataStringFromBytes(guid.ToByteArray()) & ")"))

        data = sb.ToString()

        Return data

    End Function

    Private Sub btInsert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btInsert.Click

        curRow = 1
        [error] = False
        timerStart = New Timer()
        timerStart.Interval = 10
        AddHandler timerStart.Tick, AddressOf timerStart_Tick

        timerStop = New Timer()
        timerStop.Interval = 300
        AddHandler timerStop.Tick, AddressOf timerStop_Tick

        progressBar1.Maximum = CInt(nmRowsNumber.Value)

        bw = New BackgroundWorker()
        bw.WorkerSupportsCancellation = True
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
        timerStart.Start()
        cancelProcess = False
        bw.RunWorkerAsync()

    End Sub

    Private Sub timerStart_Tick(ByVal sender As Object, ByVal e As EventArgs)
        progressBar1.Value = curRow
        lbProgress.Text = curtablename & "   " & curRow & "   " & curTable & " / " & nmTableNo.Value
    End Sub

    Private Sub timerStop_Tick(ByVal sender As Object, ByVal e As EventArgs)
        timerStop.Stop()
        timerStart.Stop()
        If Not cancelProcess AndAlso Not [error] Then MessageBox.Show("done.")
    End Sub

    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        timerStop.Start()
    End Sub

    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)

        Dim datastr As String = ""

        Try

            Using conn As New MySqlConnection(constr)

                conn.Open()

                Using cmd As New MySqlCommand()

                    cmd.Connection = conn

                    For i As Integer = 0 To CInt(nmTableNo.Value) - 1

                        cmd.CommandText = "CREATE TABLE IF NOT EXISTS `" _
                            & txtPrefix.Text.Trim() & (i + 1) & "`" & textBox1.Text
                        cmd.ExecuteNonQuery()

                        curtablename = txtPrefix.Text.Trim() & (i + 1)
                        curTable = i + 1

                        Dim combineCount As Integer = 0
                        Dim sb As New StringBuilder()

                        sb.Append(NewHeader(i + 1) & GetRandomData())
                        For j As Integer = 1 To CInt(nmRowsNumber.Value) - 1

                            If cancelProcess Then
                                e.Cancel = True
                                Exit Sub
                            End If

                            curRow = j + 1
                            combineCount += 1

                            If combineCount > 500 Then
                                datastr = sb.ToString()
                                cmd.CommandText = datastr
                                cmd.ExecuteNonQuery()
                                If Not rbfix.Checked Then datastr = ""
                                combineCount = 1
                                sb = New StringBuilder()
                                sb.Append(NewHeader(i + 1) & GetRandomData())
                                Continue For
                            Else
                                If rbfix.Checked AndAlso datastr = "" Then
                                    sb.Append(",")
                                    sb.Append(GetRandomData())
                                ElseIf Not rbfix.Checked Then
                                    sb.Append(",")
                                    sb.Append(GetRandomData())
                                End If
                            End If
                            cmd.CommandText = "CREATE TABLE IF NOT EXISTS `" _
                                & txtPrefix.Text.Trim() & (i + 1) & "`" & textBox1.Text
                            cmd.ExecuteNonQuery()

                        Next

                        cmd.CommandText = sb.ToString() & ";"
                        cmd.ExecuteNonQuery()

                    Next

                End Using

                conn.Close()

            End Using

        Catch ex As Exception
            [error] = True
            timerStart.Stop()
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Function NewHeader(ByVal count As Integer) As String
        Dim a As String = "INSERT INTO `" & txtPrefix.Text.Trim() & count _
            & "`(`varchar`,`int`,`double`,`float`,`smallint`,`text`," _
            & "`datetime`,`date`,`time`,`tinyint`,`decimal`,`timestamp`,`char`,`binary`)values"
        Return a
    End Function

    Private Sub btCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btCancel.Click
        cancelProcess = True
        MessageBox.Show("Insert Process Cancelled.")
    End Sub

    Private Sub btRoutine_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btRoutine.Click

        Dim procedure As String = "DELIMITER |" & vbCr & vbLf & "CREATE PROCEDURE `B`()" _
            & vbCr & vbLf & "DETERMINISTIC" & vbCr & vbLf & "COMMENT 'A procedure'" _
            & vbCr & vbLf & "BEGIN" & vbCr & vbLf & "SELECT 'Hello World !';" & vbCr & vbLf & "END |"
        Dim [function] As String = "DELIMITER |" & vbCr & vbLf & "CREATE FUNCTION `A` ()" _
            & vbCr & vbLf & "RETURNS INT" & vbCr & vbLf & "DETERMINISTIC" & vbCr & vbLf _
            & "BEGIN" & vbCr & vbLf & "DECLARE b INT;" & vbCr & vbLf & "SET b = 1;" & vbCr _
            & vbLf & "RETURN b;" & vbCr & vbLf & "END|"
        Dim trigger As String = ""
        Dim events As String = "DELIMITER |" & vbCr & vbLf & "CREATE EVENT `C`" & vbCr _
            & vbLf & "ON SCHEDULE EVERY 1 WEEK STARTS '" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") _
            & "'" & vbCr & vbLf & "DO BEGIN" & vbCr & vbLf & "END |"
        Dim view As String = "CREATE VIEW `E` AS SELECT 'view';"

        Using conn As New MySqlConnection(constr)

            conn.Open()

            Dim ms As New MySqlScript(conn)
            Dim cmd As New MySqlCommand()
            cmd.Connection = conn

            Try
                ms.Query = [function]
                ms.Execute()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Try
                ms.Query = procedure
                ms.Execute()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Try
                ms.Query = events
                ms.Execute()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Try

                cmd.CommandText = "show tables;"
                'MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                'DataTable dt = new DataTable();
                'da.Fill(dt);
                'da = null;
                Dim table1 As String = cmd.ExecuteScalar() & ""
                'string table2 = dt.Rows[0][0] & "";
                cmd.CommandText = "show columns from `" & table1
                Dim column As String = cmd.ExecuteScalar() & ""
                trigger = "DELIMITER |" & vbCr & vbLf & "CREATE TRIGGER `D`" & vbCr _
                    & vbLf & "BEFORE INSERT ON `" & table1 & "`" & vbCr & vbLf _
                    & "FOR EACH ROW" & vbCr & vbLf & "BEGIN" & vbCr & vbLf & "Update `" _
                    & table1 & "` SET `" & column & "` = `" & column & "` WHERE 1 = 2;" _
                    & vbCr & vbLf & "END |"
                ms.Query = trigger
                ms.Execute()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            ms = Nothing

            Try
                cmd.CommandText = view
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            cmd = Nothing

            conn.Close()

        End Using

        MessageBox.Show("Routines created successfully." & vbCr & vbLf & vbCr _
            & vbLf & "Procedure:" & vbCr & vbLf & procedure & vbCr & vbLf _
            & vbCr & vbLf & "Function:" & vbCr & vbLf & [function] & vbCr _
            & vbLf & vbCr & vbLf & "Trigger:" & vbCr & vbLf & trigger & vbCr _
            & vbLf & vbCr & vbLf & "Event:" & vbCr & vbLf & events & vbCr _
            & vbLf & vbCr & vbLf & "View:" & vbCr & vbLf & view)

    End Sub

End Class