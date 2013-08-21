Imports MySql.Data.MySqlClient
Public Class frmEncrypt

    Private mb As MySqlBackup

    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub frmEncrypt_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        mb = New MySqlBackup()
    End Sub


    Private Sub cmdNewFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdNewFile.Click

        Using sf As New SaveFileDialog()

            sf.FileName = "New Backup " & DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") & ".sql"
            If sf.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Exit Sub

            txtDestinationFile.Text = sf.FileName

        End Using

    End Sub

    Private Sub cmdChooseFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdChooseFile.Click

        Using ofd As New OpenFileDialog()

            ofd.Multiselect = False
            If ofd.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Exit Sub

            txtSourceFile.Text = ofd.FileName

        End Using

    End Sub

    Private Sub cmdDecrypt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdDecrypt.Click

        Try

            If Not VariableCheck() Then Exit Sub

            mb.DecryptSqlDumpFile(txtSourceFile.Text, txtDestinationFile.Text, txtKey.Text)

            MessageBox.Show("Done")

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub cmdEncrypt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdEncrypt.Click

        Try

            If Not VariableCheck() Then Exit Sub

            mb.EncryptSqlDumpFile(txtSourceFile.Text, txtDestinationFile.Text, txtKey.Text)
            MessageBox.Show("Done")

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub


    Private Function VariableCheck() As Boolean
        If String.IsNullOrEmpty(txtDestinationFile.Text.Trim) Then
            MessageBox.Show("Destination File is not specified.")
            Return False
        End If
        If String.IsNullOrEmpty(txtSourceFile.Text.Trim) Then
            MessageBox.Show("Source File is not specified.")
            Return False
        End If
        If String.IsNullOrEmpty(txtKey.Text.Trim) Then
            MessageBox.Show("Key is not specified.")
            Return False
        End If
        Return True
    End Function

End Class