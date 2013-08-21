<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertBlob
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
        Me.btFile = New System.Windows.Forms.Button
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.cbTable = New System.Windows.Forms.ComboBox
        Me.label2 = New System.Windows.Forms.Label
        Me.cbColBLOB = New System.Windows.Forms.ComboBox
        Me.label3 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.btInsert = New System.Windows.Forms.Button
        Me.label4 = New System.Windows.Forms.Label
        Me.cbColFileName = New System.Windows.Forms.ComboBox
        Me.cbColFileSize = New System.Windows.Forms.ComboBox
        Me.label5 = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btFile
        '
        Me.btFile.Location = New System.Drawing.Point(12, 12)
        Me.btFile.Name = "btFile"
        Me.btFile.Size = New System.Drawing.Size(75, 23)
        Me.btFile.TabIndex = 0
        Me.btFile.Text = "Select a File"
        Me.btFile.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(93, 14)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(400, 20)
        Me.txtFile.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(93, 57)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Select a Table:"
        '
        'cbTable
        '
        Me.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTable.FormattingEnabled = True
        Me.cbTable.Location = New System.Drawing.Point(178, 54)
        Me.cbTable.Name = "cbTable"
        Me.cbTable.Size = New System.Drawing.Size(280, 21)
        Me.cbTable.TabIndex = 3
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(46, 84)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(126, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Select the BLOB column:"
        '
        'cbColBLOB
        '
        Me.cbColBLOB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColBLOB.FormattingEnabled = True
        Me.cbColBLOB.Location = New System.Drawing.Point(178, 81)
        Me.cbColBLOB.Name = "cbColBLOB"
        Me.cbColBLOB.Size = New System.Drawing.Size(280, 21)
        Me.cbColBLOB.TabIndex = 5
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(165, 200)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(73, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "No. of Inserts:"
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(244, 198)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(98, 20)
        Me.numericUpDown1.TabIndex = 7
        Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btInsert
        '
        Me.btInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInsert.Location = New System.Drawing.Point(191, 258)
        Me.btInsert.Name = "btInsert"
        Me.btInsert.Size = New System.Drawing.Size(132, 31)
        Me.btInsert.TabIndex = 8
        Me.btInsert.Text = "Insert"
        Me.btInsert.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(26, 111)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(146, 13)
        Me.label4.TabIndex = 9
        Me.label4.Text = "Select the File Name Column:"
        '
        'cbColFileName
        '
        Me.cbColFileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColFileName.FormattingEnabled = True
        Me.cbColFileName.Location = New System.Drawing.Point(178, 108)
        Me.cbColFileName.Name = "cbColFileName"
        Me.cbColFileName.Size = New System.Drawing.Size(280, 21)
        Me.cbColFileName.TabIndex = 10
        '
        'cbColFileSize
        '
        Me.cbColFileSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbColFileSize.FormattingEnabled = True
        Me.cbColFileSize.Location = New System.Drawing.Point(178, 135)
        Me.cbColFileSize.Name = "cbColFileSize"
        Me.cbColFileSize.Size = New System.Drawing.Size(280, 21)
        Me.cbColFileSize.TabIndex = 11
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(34, 138)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(138, 13)
        Me.label5.TabIndex = 12
        Me.label5.Text = "Select the File Size Column:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(173, 221)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(169, 13)
        Me.label6.TabIndex = 13
        Me.label6.Text = "Filename will be auto-incremented."
        '
        'frmInsertBlob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 310)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.cbColFileSize)
        Me.Controls.Add(Me.cbColFileName)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.btInsert)
        Me.Controls.Add(Me.numericUpDown1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.cbColBLOB)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cbTable)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.btFile)
        Me.Name = "frmInsertBlob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert File as BLOB into Database"
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents btFile As System.Windows.Forms.Button
    Private txtFile As System.Windows.Forms.TextBox
    Private label1 As System.Windows.Forms.Label
    Private WithEvents cbTable As System.Windows.Forms.ComboBox
    Private label2 As System.Windows.Forms.Label
    Private cbColBLOB As System.Windows.Forms.ComboBox
    Private label3 As System.Windows.Forms.Label
    Private numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents btInsert As System.Windows.Forms.Button
    Private label4 As System.Windows.Forms.Label
    Private cbColFileName As System.Windows.Forms.ComboBox
    Private cbColFileSize As System.Windows.Forms.ComboBox
    Private label5 As System.Windows.Forms.Label
    Private label6 As System.Windows.Forms.Label

End Class
