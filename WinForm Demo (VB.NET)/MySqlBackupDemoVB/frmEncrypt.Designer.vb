<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncrypt
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
        Me.txtSourceFile = New System.Windows.Forms.TextBox
        Me.cmdChooseFile = New System.Windows.Forms.Button
        Me.cmdNewFile = New System.Windows.Forms.Button
        Me.txtDestinationFile = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.cmdEncrypt = New System.Windows.Forms.Button
        Me.cmdDecrypt = New System.Windows.Forms.Button
        Me.txtKey = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(104, 28)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(63, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Source File:"
        '
        'txtSourceFile
        '
        Me.txtSourceFile.Location = New System.Drawing.Point(107, 44)
        Me.txtSourceFile.Name = "txtSourceFile"
        Me.txtSourceFile.Size = New System.Drawing.Size(487, 20)
        Me.txtSourceFile.TabIndex = 1
        '
        'cmdChooseFile
        '
        Me.cmdChooseFile.Location = New System.Drawing.Point(20, 42)
        Me.cmdChooseFile.Name = "cmdChooseFile"
        Me.cmdChooseFile.Size = New System.Drawing.Size(75, 23)
        Me.cmdChooseFile.TabIndex = 2
        Me.cmdChooseFile.Text = "Choose File"
        Me.cmdChooseFile.UseVisualStyleBackColor = True
        '
        'cmdNewFile
        '
        Me.cmdNewFile.Location = New System.Drawing.Point(20, 102)
        Me.cmdNewFile.Name = "cmdNewFile"
        Me.cmdNewFile.Size = New System.Drawing.Size(75, 23)
        Me.cmdNewFile.TabIndex = 3
        Me.cmdNewFile.Text = "New File"
        Me.cmdNewFile.UseVisualStyleBackColor = True
        '
        'txtDestinationFile
        '
        Me.txtDestinationFile.Location = New System.Drawing.Point(107, 104)
        Me.txtDestinationFile.Name = "txtDestinationFile"
        Me.txtDestinationFile.Size = New System.Drawing.Size(487, 20)
        Me.txtDestinationFile.TabIndex = 5
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(104, 88)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(82, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Destination File:"
        '
        'cmdEncrypt
        '
        Me.cmdEncrypt.Location = New System.Drawing.Point(217, 210)
        Me.cmdEncrypt.Name = "cmdEncrypt"
        Me.cmdEncrypt.Size = New System.Drawing.Size(93, 27)
        Me.cmdEncrypt.TabIndex = 6
        Me.cmdEncrypt.Text = "Encrypt File"
        Me.cmdEncrypt.UseVisualStyleBackColor = True
        '
        'cmdDecrypt
        '
        Me.cmdDecrypt.Location = New System.Drawing.Point(330, 210)
        Me.cmdDecrypt.Name = "cmdDecrypt"
        Me.cmdDecrypt.Size = New System.Drawing.Size(93, 27)
        Me.cmdDecrypt.TabIndex = 7
        Me.cmdDecrypt.Text = "Decrypt File"
        Me.cmdDecrypt.UseVisualStyleBackColor = True
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(213, 163)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(218, 20)
        Me.txtKey.TabIndex = 9
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(179, 166)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(28, 13)
        Me.label3.TabIndex = 8
        Me.label3.Text = "Key:"
        '
        'frmEncrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 263)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.cmdDecrypt)
        Me.Controls.Add(Me.cmdEncrypt)
        Me.Controls.Add(Me.txtDestinationFile)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cmdNewFile)
        Me.Controls.Add(Me.cmdChooseFile)
        Me.Controls.Add(Me.txtSourceFile)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmEncrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQL Dump File Encryption Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private label1 As System.Windows.Forms.Label
    Private txtSourceFile As System.Windows.Forms.TextBox
    Private WithEvents cmdChooseFile As System.Windows.Forms.Button
    Private WithEvents cmdNewFile As System.Windows.Forms.Button
    Private txtDestinationFile As System.Windows.Forms.TextBox
    Private label2 As System.Windows.Forms.Label
    Private WithEvents cmdEncrypt As System.Windows.Forms.Button
    Private WithEvents cmdDecrypt As System.Windows.Forms.Button
    Private txtKey As System.Windows.Forms.TextBox
    Private label3 As System.Windows.Forms.Label

End Class
