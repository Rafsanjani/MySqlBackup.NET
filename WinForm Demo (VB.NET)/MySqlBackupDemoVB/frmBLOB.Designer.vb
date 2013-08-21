<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBLOB
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
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.cmdFolder = New System.Windows.Forms.Button
        Me.label8 = New System.Windows.Forms.Label
        Me.txtFolder = New System.Windows.Forms.TextBox
        Me.cmdExport = New System.Windows.Forms.Button
        Me.cbFileName = New System.Windows.Forms.ComboBox
        Me.cbFileSize = New System.Windows.Forms.ComboBox
        Me.cbBLOB = New System.Windows.Forms.ComboBox
        Me.cbTable = New System.Windows.Forms.ComboBox
        Me.label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(96, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(78, 15)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Select Table:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(51, 88)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(122, 15)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Column (File Name):"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(62, 118)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(111, 15)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Column (File Size):"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(76, 147)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(97, 15)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Column (BLOB):"
        '
        'cmdFolder
        '
        Me.cmdFolder.Image = Global.MySqlBackupDemoVB.My.Resources.Resources.folder_open_sharp_thick
        Me.cmdFolder.Location = New System.Drawing.Point(290, 184)
        Me.cmdFolder.Name = "cmdFolder"
        Me.cmdFolder.Size = New System.Drawing.Size(51, 25)
        Me.cmdFolder.TabIndex = 37
        Me.cmdFolder.UseVisualStyleBackColor = True
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(64, 189)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(220, 15)
        Me.label8.TabIndex = 36
        Me.label8.Text = "Select a folder that the files will save to:"
        '
        'txtFolder
        '
        Me.txtFolder.Location = New System.Drawing.Point(67, 215)
        Me.txtFolder.Name = "txtFolder"
        Me.txtFolder.Size = New System.Drawing.Size(379, 21)
        Me.txtFolder.TabIndex = 35
        '
        'cmdExport
        '
        Me.cmdExport.Location = New System.Drawing.Point(190, 254)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(139, 23)
        Me.cmdExport.TabIndex = 38
        Me.cmdExport.Text = "Start Export"
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cbFileName
        '
        Me.cbFileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFileName.FormattingEnabled = True
        Me.cbFileName.Location = New System.Drawing.Point(179, 85)
        Me.cbFileName.Name = "cbFileName"
        Me.cbFileName.Size = New System.Drawing.Size(196, 23)
        Me.cbFileName.TabIndex = 2
        '
        'cbFileSize
        '
        Me.cbFileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFileSize.FormattingEnabled = True
        Me.cbFileSize.Location = New System.Drawing.Point(179, 115)
        Me.cbFileSize.Name = "cbFileSize"
        Me.cbFileSize.Size = New System.Drawing.Size(196, 23)
        Me.cbFileSize.TabIndex = 3
        '
        'cbBLOB
        '
        Me.cbBLOB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBLOB.FormattingEnabled = True
        Me.cbBLOB.Location = New System.Drawing.Point(179, 144)
        Me.cbBLOB.Name = "cbBLOB"
        Me.cbBLOB.Size = New System.Drawing.Size(196, 23)
        Me.cbBLOB.TabIndex = 4
        '
        'cbTable
        '
        Me.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTable.FormattingEnabled = True
        Me.cbTable.Location = New System.Drawing.Point(179, 22)
        Me.cbTable.Name = "cbTable"
        Me.cbTable.Size = New System.Drawing.Size(196, 23)
        Me.cbTable.TabIndex = 1
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(176, 48)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(184, 15)
        Me.label5.TabIndex = 39
        Me.label5.Text = "This table has no BLOB column."
        Me.label5.Visible = False
        '
        'frmBLOB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 311)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.cbTable)
        Me.Controls.Add(Me.cbBLOB)
        Me.Controls.Add(Me.cbFileSize)
        Me.Controls.Add(Me.cbFileName)
        Me.Controls.Add(Me.cmdExport)
        Me.Controls.Add(Me.cmdFolder)
        Me.Controls.Add(Me.label8)
        Me.Controls.Add(Me.txtFolder)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmBLOB"
        Me.Text = "BLOB data Export Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private WithEvents cmdFolder As System.Windows.Forms.Button
    Private label8 As System.Windows.Forms.Label
    Private txtFolder As System.Windows.Forms.TextBox
    Private WithEvents cmdExport As System.Windows.Forms.Button
    Private cbFileName As System.Windows.Forms.ComboBox
    Private cbFileSize As System.Windows.Forms.ComboBox
    Private cbBLOB As System.Windows.Forms.ComboBox
    Private WithEvents cbTable As System.Windows.Forms.ComboBox
    Private label5 As System.Windows.Forms.Label

End Class
