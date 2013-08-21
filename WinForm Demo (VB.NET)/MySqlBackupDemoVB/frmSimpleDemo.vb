Imports MySql.Data.MySqlClient
Public Class frmSimpleDemo

    Private Enum CurrentProcessType
        Export
        Import
        None
    End Enum

    Private WithEvents mb As MySqlBackup
    Private HighTimeForGuiRefresh As Boolean = True
    Private cpt As CurrentProcessType = CurrentProcessType.None


    Public Sub New()

        InitializeComponent()

    End Sub

    Public Sub New(ByVal connectionString As String)

        InitializeComponent()

        txtConstr.Text = connectionString

    End Sub


    Private Sub btBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBackup.Click

        If Not mb Is Nothing Then
            MsgBox("Error. Can't start export while another process is in progress.", _
                MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim fn As String = ""

        Using sf As New SaveFileDialog()
            sf.FileName = "test " & DateTime.Now.ToString("yyyyMMdd HHmmss") & ".sql"
            If sf.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Exit Sub
            fn = sf.FileName
        End Using

        ProgressBar1.Value = 0

        mb = New MySqlBackup()

        mb.Connection = New MySqlConnection(txtConstr.Text)
        mb.ExportInfo.FileName = fn
        mb.ExportInfo.AsynchronousMode = True

        AddHandler mb.ExportProgressChanged, AddressOf mb_ExportProgressChanged
        AddHandler mb.ExportCompleted, AddressOf mb_ExportCompleted

        cpt = CurrentProcessType.Export

        ResetButtons()

        Try
            mb.Export()
            RefreshTimer.Start()
        Catch ex As Exception
            RefreshTimer.Stop()
            MsgBox("Error occured while starting export process: " & ex.Message, _
                MsgBoxStyle.Exclamation, "")
            ClearOperationData(True)
        End Try

    End Sub

    Private Sub btRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRestore.Click

        If Not mb Is Nothing Then
            MsgBox("Error. Can't start import while another process is in progress.", _
                MsgBoxStyle.Exclamation, "")
            Exit Sub
        End If

        Dim fn As String = ""

        Using ofd As New OpenFileDialog()
            ofd.Multiselect = False
            If ofd.ShowDialog() <> System.Windows.Forms.DialogResult.OK Then Exit Sub
            fn = ofd.FileName
            If fn Is Nothing OrElse String.IsNullOrEmpty(fn.Trim) OrElse _
                Not IO.File.Exists(fn) Then Exit Sub
        End Using

        ProgressBar1.Value = 0

        mb = New MySqlBackup()

        mb.Connection = New MySqlConnection(txtConstr.Text)
        mb.ImportInfo.AsynchronousMode = True
        mb.ImportInfo.FileName = fn

        AddHandler mb.ImportProgressChanged, AddressOf mb_ImportProgressChanged
        AddHandler mb.ImportCompleted, AddressOf mb_ImportCompleted

        cpt = CurrentProcessType.Import

        ResetButtons()

        Try
            mb.Import()
            RefreshTimer.Start()
        Catch ex As Exception
            RefreshTimer.Stop()
            MsgBox("Error occured while starting import process: " & ex.Message, _
                MsgBoxStyle.Exclamation, "")
            ClearOperationData(True)
        End Try

    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click

        If mb Is Nothing OrElse cpt = CurrentProcessType.None Then Exit Sub

        RefreshTimer.Stop()
        Me.btCancel.Enabled = False

        If cpt = CurrentProcessType.Export Then
            lb_Progress.Text = "Canceling backup process..."
            mb.CancelExport()
        ElseIf cpt = CurrentProcessType.Import Then
            lb_Progress.Text = "Canceling restore process..."
            mb.CancelImport()
        End If

    End Sub


    Private Sub RefreshTimer_Tick(ByVal sender As System.Object, _
            ByVal e As System.EventArgs) Handles RefreshTimer.Tick

        RefreshTimer.Stop()
        If mb Is Nothing Then Exit Sub
        HighTimeForGuiRefresh = True
        RefreshTimer.Start()

    End Sub



    Private Sub mb_ExportCompleted(ByVal sender As Object, ByVal e As ExportCompleteArg)
        ReportExportCompleted(e)
    End Sub

    Private Delegate Sub ReportExportCompletedInvoker(ByVal e As ExportCompleteArg)
    Private Sub ReportExportCompleted(ByVal e As ExportCompleteArg)

        If Me.InvokeRequired Then
            Me.Invoke(New ReportExportCompletedInvoker(AddressOf ReportExportCompleted), New Object() {e})
            Exit Sub
        End If

        RefreshTimer.Stop()

        If e.CompletedType = ExportCompleteArg.CompleteType.Cancelled Then
            lb_Progress.Text = "Backup process was canceled."
        ElseIf e.CompletedType = ExportCompleteArg.CompleteType.Error Then
            lb_Progress.Text = "Backup process was interrupted by an exception."
        End If

        Dim errMsg As String = ""
        If e.Error IsNot Nothing Then errMsg = e.Error.ToString()
        MsgBox(("Export " & e.CompletedType.ToString() & vbCrLf & errMsg).Trim, _
            MsgBoxStyle.Information, "")

        ClearOperationData(True)

    End Sub

    Private Sub mb_ExportProgressChanged(ByVal sender As Object, ByVal e As ExportProgressArg)
        ReportExportProgress(e)
    End Sub

    Private Delegate Sub ReportExportProgressInvoker(ByVal e As ExportProgressArg)
    Private Sub ReportExportProgress(ByVal e As ExportProgressArg)

        If Not HighTimeForGuiRefresh AndAlso e.PercentageCompleted < 99 Then Exit Sub

        If Me.InvokeRequired Then
            Me.Invoke(New ReportExportProgressInvoker(AddressOf ReportExportProgress), New Object() {e})
            Exit Sub
        End If

        ProgressBar1.Value = e.PercentageCompleted
        lb_Progress.Text = "Progress " + e.PercentageCompleted.ToString() + "%"

        HighTimeForGuiRefresh = False

    End Sub



    Private Sub mb_ImportCompleted(ByVal sender As Object, ByVal e As ImportCompleteArg)
        ReportImportCompleted(e)
    End Sub

    Private Delegate Sub ReportImportCompletedInvoker(ByVal e As ImportCompleteArg)
    Private Sub ReportImportCompleted(ByVal e As ImportCompleteArg)

        If Me.InvokeRequired Then
            Me.Invoke(New ReportImportCompletedInvoker(AddressOf ReportImportCompleted), New Object() {e})
            Exit Sub
        End If

        RefreshTimer.Stop()

        If e.CompletedType = ExportCompleteArg.CompleteType.Cancelled Then
            lb_Progress.Text = "Restore process was canceled."
        ElseIf e.CompletedType = ExportCompleteArg.CompleteType.Error Then
            lb_Progress.Text = "Restore process was interrupted by an exception."
        End If

        Dim errMsg As String = ""
        If e.LastError IsNot Nothing Then errMsg = e.LastError.ToString()
        MsgBox(("Import " & e.CompletedType.ToString() & vbCrLf & errMsg).Trim, _
            MsgBoxStyle.Information, "")

        ClearOperationData(True)

    End Sub

    Private Sub mb_ImportProgressChanged(ByVal sender As Object, ByVal e As ImportProgressArg)
        ReportImportProgress(e)
    End Sub

    Private Delegate Sub ReportImportProgressInvoker(ByVal e As ImportProgressArg)
    Private Sub ReportImportProgress(ByVal e As ImportProgressArg)

        If Not HighTimeForGuiRefresh AndAlso e.PercentageCompleted < 99 Then Exit Sub

        If Me.InvokeRequired Then
            Me.Invoke(New ReportImportProgressInvoker(AddressOf ReportImportProgress), New Object() {e})
            Exit Sub
        End If

        ProgressBar1.Value = e.PercentageCompleted
        lb_Progress.Text = "Progress " + e.PercentageCompleted.ToString() + "%"

        HighTimeForGuiRefresh = False

    End Sub



    Private Sub ClearOperationData(ByVal ContinueWithResetButtons As Boolean)
        If Not mb Is Nothing Then
            If cpt = CurrentProcessType.Export Then
                RemoveHandler mb.ExportProgressChanged, AddressOf mb_ExportProgressChanged
                RemoveHandler mb.ExportCompleted, AddressOf mb_ExportCompleted
            ElseIf cpt = CurrentProcessType.Import Then
                RemoveHandler mb.ImportProgressChanged, AddressOf mb_ImportProgressChanged
                RemoveHandler mb.ImportCompleted, AddressOf mb_ImportCompleted
            End If
            mb.Dispose()
            mb = Nothing
        End If
        cpt = CurrentProcessType.None
        HighTimeForGuiRefresh = True
        If ContinueWithResetButtons Then ResetButtons()
    End Sub

    Private Sub ResetButtons()

        btBackup.Enabled = (mb Is Nothing)
        btRestore.Enabled = (mb Is Nothing)
        btCancel.Enabled = Not (mb Is Nothing)

    End Sub

End Class
