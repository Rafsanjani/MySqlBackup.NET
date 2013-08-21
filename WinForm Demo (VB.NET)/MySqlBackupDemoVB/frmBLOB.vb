Imports MySql.Data.MySqlClient
Public Class frmBLOB

    Private constr As String = ""

    Public Sub New(ByVal connectionstring As String)

        InitializeComponent()

        constr = connectionstring

        Using conn As New MySqlConnection(constr)
            conn.Open()
            Dim dt As New DataTable()
            Dim sql As String = "show tables;"
            Dim da As New MySqlDataAdapter(sql, conn)
            da.Fill(dt)
            For Each dr As DataRow In dt.Rows
                cbTable.Items.Add(dr(0) + "")
            Next
            conn.Close()
        End Using

        cbTable.SelectedIndex = -1
        AddHandler cbTable.SelectedIndexChanged, AddressOf cbTable_SelectedIndexChanged

    End Sub

    Private Sub cbTable_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

        Using conn As New MySqlConnection(constr)
            conn.Open()
            Dim dt As New DataTable()
            Dim sql As String = "show columns from `" + cbTable.Text + "`;"
            Dim da As New MySqlDataAdapter(sql, conn)
            da.Fill(dt)
            cbBLOB.Items.Clear()
            cbFileName.Items.Clear()
            cbFileSize.Items.Clear()
            Dim hasBLOB As Boolean = False
            For Each dr As DataRow In dt.Rows
                Dim colname As String = dr("Field") + ""
                Dim coltype As String = dr("Type") + ""
                If coltype.ToLower().Contains("blob") Then
                    cbBLOB.Items.Add(colname)
                    hasBLOB = True
                Else
                    cbFileName.Items.Add(colname)
                    cbFileSize.Items.Add(colname)
                End If
            Next
            conn.Close()
            If hasBLOB Then
                label5.Visible = False
            Else
                label5.Visible = True
            End If
        End Using

        Try
            cbBLOB.SelectedIndex = 0
            cbFileName.SelectedIndex = 0
            cbFileSize.SelectedIndex = 1
        Catch
        End Try

    End Sub

    Private Sub cmdExport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdExport.Click
        Try
            Dim mb As New MySql.Data.MySqlClient.MySqlBackup(constr)
            mb.ExportBlobAsFile(txtFolder.Text, cbTable.Text, cbBLOB.Text, cbFileName.Text, cbFileSize.Text)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return
        End Try
        MessageBox.Show("Files have exported successfully and saved to" _
            & vbCr & vbLf & vbCr & vbLf & txtFolder.Text)
    End Sub

    Private Sub cmdFolder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdFolder.Click
        Using f As New FolderBrowserDialog()
            f.ShowNewFolderButton = True
            If f.ShowDialog() = System.Windows.Forms.DialogResult.OK Then _
                txtFolder.Text = f.SelectedPath
        End Using
    End Sub

End Class