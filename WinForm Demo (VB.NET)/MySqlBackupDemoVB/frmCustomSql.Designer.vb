<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomSql
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btExecute1 = New System.Windows.Forms.Button
        Me.btExecute2 = New System.Windows.Forms.Button
        Me.btExecute3 = New System.Windows.Forms.Button
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.txt3 = New System.Windows.Forms.TextBox
        Me.dataGridView1 = New System.Windows.Forms.DataGridView
        Me.panel1 = New System.Windows.Forms.Panel
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.textBox1 = New System.Windows.Forms.TextBox
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btExecute1
        '
        Me.btExecute1.Location = New System.Drawing.Point(12, 45)
        Me.btExecute1.Name = "btExecute1"
        Me.btExecute1.Size = New System.Drawing.Size(64, 27)
        Me.btExecute1.TabIndex = 1
        Me.btExecute1.TabStop = False
        Me.btExecute1.Text = "Execute"
        Me.btExecute1.UseVisualStyleBackColor = True
        '
        'btExecute2
        '
        Me.btExecute2.Location = New System.Drawing.Point(12, 78)
        Me.btExecute2.Name = "btExecute2"
        Me.btExecute2.Size = New System.Drawing.Size(64, 27)
        Me.btExecute2.TabIndex = 3
        Me.btExecute2.TabStop = False
        Me.btExecute2.Text = "Execute"
        Me.btExecute2.UseVisualStyleBackColor = True
        '
        'btExecute3
        '
        Me.btExecute3.Location = New System.Drawing.Point(12, 111)
        Me.btExecute3.Name = "btExecute3"
        Me.btExecute3.Size = New System.Drawing.Size(64, 27)
        Me.btExecute3.TabIndex = 5
        Me.btExecute3.TabStop = False
        Me.btExecute3.Text = "Execute"
        Me.btExecute3.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(82, 45)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(840, 24)
        Me.txt1.TabIndex = 1
        '
        'txt2
        '
        Me.txt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(82, 78)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(840, 24)
        Me.txt2.TabIndex = 2
        '
        'txt3
        '
        Me.txt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3.Location = New System.Drawing.Point(82, 111)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(840, 24)
        Me.txt3.TabIndex = 3
        '
        'dataGridView1
        '
        Me.dataGridView1.AllowUserToAddRows = False
        Me.dataGridView1.AllowUserToDeleteRows = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGridView1.Location = New System.Drawing.Point(0, 148)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.RowHeadersVisible = False
        Me.dataGridView1.Size = New System.Drawing.Size(934, 464)
        Me.dataGridView1.TabIndex = 9
        Me.dataGridView1.TabStop = False
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.textBox1)
        Me.panel1.Controls.Add(Me.btExecute1)
        Me.panel1.Controls.Add(Me.txt3)
        Me.panel1.Controls.Add(Me.txt2)
        Me.panel1.Controls.Add(Me.btExecute2)
        Me.panel1.Controls.Add(Me.txt1)
        Me.panel1.Controls.Add(Me.btExecute3)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(934, 148)
        Me.panel1.TabIndex = 10
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(774, 25)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(152, 16)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Press [Enter] to execute."
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(12, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(178, 16)
        Me.label1.TabIndex = 10
        Me.label1.Text = "SQL Query that return results:"
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(198, 10)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(449, 24)
        Me.textBox1.TabIndex = 9
        Me.textBox1.TabStop = False
        Me.textBox1.Text = "SELECT, SHOW"
        '
        'frmCustomSql
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 612)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "frmCustomSql"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQL Execution Panel"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WithEvents btExecute1 As System.Windows.Forms.Button
    Private WithEvents btExecute2 As System.Windows.Forms.Button
    Private WithEvents btExecute3 As System.Windows.Forms.Button
    Private WithEvents txt1 As System.Windows.Forms.TextBox
    Private WithEvents txt2 As System.Windows.Forms.TextBox
    Private WithEvents txt3 As System.Windows.Forms.TextBox
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private panel1 As System.Windows.Forms.Panel
    Private label1 As System.Windows.Forms.Label
    Private textBox1 As System.Windows.Forms.TextBox
    Private label2 As System.Windows.Forms.Label

End Class
