<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalyser
    Inherits System.Windows.Forms.Form

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.btExport = New System.Windows.Forms.Button
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser
        Me.panel1 = New System.Windows.Forms.Panel
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btExport
        '
        Me.btExport.Location = New System.Drawing.Point(6, 5)
        Me.btExport.Name = "btExport"
        Me.btExport.Size = New System.Drawing.Size(219, 26)
        Me.btExport.TabIndex = 0
        Me.btExport.Text = "Export Report and Save as HTML File"
        Me.btExport.UseVisualStyleBackColor = True
        '
        'webBrowser1
        '
        Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser1.Location = New System.Drawing.Point(0, 36)
        Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(934, 576)
        Me.webBrowser1.TabIndex = 1
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.btExport)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(934, 36)
        Me.panel1.TabIndex = 2
        '
        'frmAnalyser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 612)
        Me.Controls.Add(Me.webBrowser1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "frmAnalyser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySQL Database Analyser"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents btExport As System.Windows.Forms.Button
    Private WithEvents webBrowser1 As System.Windows.Forms.WebBrowser
    Private panel1 As System.Windows.Forms.Panel

End Class
