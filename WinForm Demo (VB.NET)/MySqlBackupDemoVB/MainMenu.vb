Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class MainMenu

    Public Sub New()

        InitializeComponent()

        lbVersion.Text = "WinForm Demo 3.3" & vbCr & vbLf & "MySqlBackup.NET " + MySqlBackup.Version

        GetParam()

    End Sub

#Region "Remember Connection String"

    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Not checkBox1.Checked Then
            Try
                System.IO.File.Delete(Environment.GetFolderPath( _
                    Environment.SpecialFolder.ApplicationData) + "\constr.txt")
            Catch
            End Try
        End If
    End Sub

    Private Sub RememberConnectionString()
        If checkBox1.Checked Then
            System.IO.File.WriteAllText(Environment.GetFolderPath( _
                Environment.SpecialFolder.ApplicationData) + "\constr.txt", textBox1.Text)
        End If
    End Sub

    Private Sub GetParam()
        If System.IO.File.Exists(Environment.GetFolderPath( _
            Environment.SpecialFolder.ApplicationData) + "\constr.txt") Then
            textBox1.Text = System.IO.File.ReadAllText( _
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\constr.txt")
            checkBox1.Checked = True
        End If
    End Sub

#End Region

    Private Function TestConnection() As Boolean
        Try
            Dim conn As New MySqlConnection(textBox1.Text)
            conn.Open()
            conn.Close()
            RememberConnectionString()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return False
        End Try
    End Function

    Private Sub btMainDemo_click(ByVal sender As Object, ByVal e As EventArgs) Handles btMainDemo.Click
        If TestConnection() Then
            Dim f As New frmMainDemo(textBox1.Text)
            f.Show()
        End If
    End Sub

    Private Sub btSimpleDemo_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btSimpleDemo.Click

        If TestConnection() Then
            Dim f As New frmSimpleDemo(textBox1.Text)
            f.Show()
        End If

    End Sub

    Private Sub btTestTable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btTestTable.Click
        If TestConnection() Then
            Dim f As New frmSampleData(textBox1.Text)
            f.Show()
        End If
    End Sub

    Private Sub cmdBLOB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdBLOB.Click
        If TestConnection() Then
            Dim f As New frmBLOB(textBox1.Text)
            f.Show()
        End If
    End Sub

    Private Sub cmdEncryptionDemo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdEncryptionDemo.Click
        If TestConnection() Then
            Dim f As New frmEncrypt()
            f.Show()
        End If
    End Sub

    Private Sub btCharSet_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btCharSet.Click
        If TestConnection() Then
            Dim f As New frmCharSet(textBox1.Text)
            f.Show()
        End If
    End Sub

    Private Sub btInserBLOB_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btInserBLOB.Click
        If TestConnection() Then
            Dim f As New frmInsertBlob(textBox1.Text)
            f.Show()
        End If
    End Sub

    Private Sub btSqlExecute_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btSqlExecute.Click
        If TestConnection() Then
            Dim f As New frmCustomSql(textBox1.Text)
            f.Show()
        End If
    End Sub

    Private Sub btAnalyser_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btAnalyser.Click
        If TestConnection() Then
            Dim f As New frmAnalyser(textBox1.Text)
            f.Show()
        End If
    End Sub

End Class