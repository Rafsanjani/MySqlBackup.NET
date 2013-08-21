<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.cmdBLOB = New System.Windows.Forms.Button
        Me.label1 = New System.Windows.Forms.Label
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.cmdEncryptionDemo = New System.Windows.Forms.Button
        Me.lbVersion = New System.Windows.Forms.Label
        Me.btMainDemo = New System.Windows.Forms.Button
        Me.btTestTable = New System.Windows.Forms.Button
        Me.label3 = New System.Windows.Forms.Label
        Me.btCharSet = New System.Windows.Forms.Button
        Me.btInserBLOB = New System.Windows.Forms.Button
        Me.btSqlExecute = New System.Windows.Forms.Button
        Me.btAnalyser = New System.Windows.Forms.Button
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.btSimpleDemo = New System.Windows.Forms.Button
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBLOB
        '
        Me.cmdBLOB.Location = New System.Drawing.Point(220, 151)
        Me.cmdBLOB.Name = "cmdBLOB"
        Me.cmdBLOB.Size = New System.Drawing.Size(194, 23)
        Me.cmdBLOB.TabIndex = 2
        Me.cmdBLOB.Text = "BLOB Data Export Demo"
        Me.cmdBLOB.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(132, 13)
        Me.label1.TabIndex = 3
        Me.label1.Text = "MySQL Connection String:"
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(15, 25)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(622, 20)
        Me.textBox1.TabIndex = 5
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(15, 51)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(296, 17)
        Me.checkBox1.TabIndex = 6
        Me.checkBox1.Text = "Remember, so that I won't have to type it again next time."
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'cmdEncryptionDemo
        '
        Me.cmdEncryptionDemo.Location = New System.Drawing.Point(220, 180)
        Me.cmdEncryptionDemo.Name = "cmdEncryptionDemo"
        Me.cmdEncryptionDemo.Size = New System.Drawing.Size(194, 23)
        Me.cmdEncryptionDemo.TabIndex = 3
        Me.cmdEncryptionDemo.Text = "SQL Dump File Encryption Demo"
        Me.cmdEncryptionDemo.UseVisualStyleBackColor = True
        '
        'lbVersion
        '
        Me.lbVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Location = New System.Drawing.Point(249, 406)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(61, 13)
        Me.lbVersion.TabIndex = 8
        Me.lbVersion.Text = "version info"
        Me.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btMainDemo
        '
        Me.btMainDemo.Location = New System.Drawing.Point(220, 93)
        Me.btMainDemo.Name = "btMainDemo"
        Me.btMainDemo.Size = New System.Drawing.Size(194, 23)
        Me.btMainDemo.TabIndex = 1
        Me.btMainDemo.Text = "Main Demo"
        Me.btMainDemo.UseVisualStyleBackColor = True
        '
        'btTestTable
        '
        Me.btTestTable.Location = New System.Drawing.Point(18, 28)
        Me.btTestTable.Name = "btTestTable"
        Me.btTestTable.Size = New System.Drawing.Size(194, 23)
        Me.btTestTable.TabIndex = 4
        Me.btTestTable.Text = "Sample Data Generator"
        Me.btTestTable.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(162, 229)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(334, 26)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Below are some of the Tools that help to Develop MySqlBackup.NET" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(not part of My" & _
            "SqlBackup.NET)"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btCharSet
        '
        Me.btCharSet.Location = New System.Drawing.Point(18, 57)
        Me.btCharSet.Name = "btCharSet"
        Me.btCharSet.Size = New System.Drawing.Size(194, 23)
        Me.btCharSet.TabIndex = 10
        Me.btCharSet.Text = "Environment Character Set"
        Me.btCharSet.UseVisualStyleBackColor = True
        '
        'btInserBLOB
        '
        Me.btInserBLOB.Location = New System.Drawing.Point(242, 57)
        Me.btInserBLOB.Name = "btInserBLOB"
        Me.btInserBLOB.Size = New System.Drawing.Size(194, 23)
        Me.btInserBLOB.TabIndex = 11
        Me.btInserBLOB.Text = "Insert File as BLOB into Database"
        Me.btInserBLOB.UseVisualStyleBackColor = True
        '
        'btSqlExecute
        '
        Me.btSqlExecute.Location = New System.Drawing.Point(242, 28)
        Me.btSqlExecute.Name = "btSqlExecute"
        Me.btSqlExecute.Size = New System.Drawing.Size(194, 23)
        Me.btSqlExecute.TabIndex = 12
        Me.btSqlExecute.Text = "SQL Statements Execution"
        Me.btSqlExecute.UseVisualStyleBackColor = True
        '
        'btAnalyser
        '
        Me.btAnalyser.Location = New System.Drawing.Point(132, 100)
        Me.btAnalyser.Name = "btAnalyser"
        Me.btAnalyser.Size = New System.Drawing.Size(194, 23)
        Me.btAnalyser.TabIndex = 14
        Me.btAnalyser.Text = "Database Analyser"
        Me.btAnalyser.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.btTestTable)
        Me.groupBox1.Controls.Add(Me.btAnalyser)
        Me.groupBox1.Controls.Add(Me.btCharSet)
        Me.groupBox1.Controls.Add(Me.btSqlExecute)
        Me.groupBox1.Controls.Add(Me.btInserBLOB)
        Me.groupBox1.Location = New System.Drawing.Point(96, 258)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(453, 134)
        Me.groupBox1.TabIndex = 15
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Tools"
        '
        'btSimpleDemo
        '
        Me.btSimpleDemo.Location = New System.Drawing.Point(220, 122)
        Me.btSimpleDemo.Name = "btSimpleDemo"
        Me.btSimpleDemo.Size = New System.Drawing.Size(194, 23)
        Me.btSimpleDemo.TabIndex = 16
        Me.btSimpleDemo.Text = "Simple Demo"
        Me.btSimpleDemo.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 438)
        Me.Controls.Add(Me.btSimpleDemo)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.btMainDemo)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.cmdEncryptionDemo)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cmdBLOB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySqlBackup.NET WinForm Demo 3.3 & Diagnosis Tools"
        Me.groupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private WithEvents cmdBLOB As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private textBox1 As System.Windows.Forms.TextBox
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents cmdEncryptionDemo As System.Windows.Forms.Button
    Private lbVersion As System.Windows.Forms.Label
    Private WithEvents btMainDemo As System.Windows.Forms.Button
    Private WithEvents btTestTable As System.Windows.Forms.Button
    Private label3 As System.Windows.Forms.Label
    Private WithEvents btCharSet As System.Windows.Forms.Button
    Private WithEvents btInserBLOB As System.Windows.Forms.Button
    Private WithEvents btSqlExecute As System.Windows.Forms.Button
    Private WithEvents btAnalyser As System.Windows.Forms.Button
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btSimpleDemo As System.Windows.Forms.Button

End Class
