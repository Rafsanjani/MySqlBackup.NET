Imports MySql.Data.MySqlClient
Public Class frmInsertBlob

    Private constr As String = ""

    Public Sub New(ByVal connectionString As String)

        constr = connectionString
        InitializeComponent()

        Dim mb As New MySqlBackup(connectionString)

        For Each s As String In mb.DatabaseInfo.TableNames
            cbTable.Items.Add(s)
        Next

        cbTable.SelectedIndex = -1
        AddHandler Me.cbTable.SelectedIndexChanged, AddressOf cbTable_SelectedIndexChanged

    End Sub


    Private Sub frmInsertBlob_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub


    Private Sub btFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btFile.Click
        Using ofd As New OpenFileDialog()
            ofd.Multiselect = False
            If ofd.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Exit Sub
            txtFile.Text = ofd.FileName
        End Using
    End Sub

    Private Sub btInsert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btInsert.Click

        If String.IsNullOrEmpty(txtFile.Text.Trim) Then
            MessageBox.Show("File is not specified.")
            Exit Sub
        ElseIf Not System.IO.File.Exists(txtFile.Text) Then
            MessageBox.Show("The specified file does not exists.")
            Exit Sub
        End If

        Dim ErrorMsg As String = ""

        Using conn As New MySqlConnection(constr)

            conn.Open()

            Dim cmd As New MySqlCommand()
            cmd.Connection = conn

            Dim md As New Methods()
            Dim ba As Byte() = System.IO.File.ReadAllBytes(txtFile.Text)

            Try
                For i As Integer = 0 To CInt(numericUpDown1.Value) - 1
                    Dim sql As String = "insert into `" & cbTable.Text & "`(`" _
                        & cbColBLOB.Text & "`, `" & cbColFileName.Text & "`,`" _
                        & cbColFileSize.Text & "`) values(" & md.GetBLOBSqlDataStringFromBytes(ba) _
                        & ",'" & System.IO.Path.GetFileNameWithoutExtension(txtFile.Text) _
                        & (i + 1) & System.IO.Path.GetExtension(txtFile.Text) & "'," & ba.Length & ");"
                    cmd.CommandText = sql
                    cmd.ExecuteNonQuery()
                Next
            Catch ex As Exception
                ErrorMsg = ex.Message
            End Try

            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Dispose()
            cmd.Dispose()
            md = Nothing

        End Using

        If String.IsNullOrEmpty(ErrorMsg.Trim) Then
            MessageBox.Show("Done.")
        Else
            MessageBox.Show("Error occured while inserting: " & ErrorMsg.Trim)
        End If

    End Sub

    Private Sub cbTable_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

        Dim hasBLOB As Boolean = False

        Using conn As New MySqlConnection(constr)

            conn.Open()

            Dim sql As String = "show columns from `" + cbTable.Text + "`;"
            Dim dt As New DataTable()
            Dim da As New MySqlDataAdapter(sql, conn)
            da.Fill(dt)

            conn.Close()

            cbColBLOB.Items.Clear()
            For Each dr As DataRow In dt.Rows
                Dim s As String = dr("Type") & ""
                If s.ToLower().Contains("blob") Then
                    hasBLOB = True
                    cbColBLOB.Items.Add(dr("Field") & "")
                Else
                    cbColFileName.Items.Add(dr("Field") & "")

                    cbColFileSize.Items.Add(dr("Field") & "")
                End If
            Next

            dt.Dispose()

            Try
                cbColBLOB.SelectedIndex = 0
                cbColFileSize.SelectedIndex = 1
                cbColFileName.SelectedIndex = 0
            Catch
            End Try

        End Using

        If Not hasBLOB Then MessageBox.Show("This table has no BLOB data type column.")

    End Sub

End Class