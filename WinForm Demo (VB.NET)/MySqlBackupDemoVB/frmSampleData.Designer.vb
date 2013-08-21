<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleData
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
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.nmTableNo = New System.Windows.Forms.NumericUpDown
        Me.label2 = New System.Windows.Forms.Label
        Me.txtPrefix = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.btInsert = New System.Windows.Forms.Button
        Me.label4 = New System.Windows.Forms.Label
        Me.nmRowsNumber = New System.Windows.Forms.NumericUpDown
        Me.btView = New System.Windows.Forms.Button
        Me.textBox3 = New System.Windows.Forms.TextBox
        Me.label5 = New System.Windows.Forms.Label
        Me.progressBar1 = New System.Windows.Forms.ProgressBar
        Me.lbProgress = New System.Windows.Forms.Label
        Me.btCancel = New System.Windows.Forms.Button
        Me.label6 = New System.Windows.Forms.Label
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.rbfix = New System.Windows.Forms.RadioButton
        Me.btRoutine = New System.Windows.Forms.Button
        CType(Me.nmTableNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmRowsNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox1.Location = New System.Drawing.Point(88, 81)
        Me.textBox1.Multiline = True
        Me.textBox1.Name = "textBox1"
        Me.textBox1.ReadOnly = True
        Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox1.Size = New System.Drawing.Size(413, 232)
        Me.textBox1.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(137, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(179, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Number of Test Table to be created:"
        '
        'nmTableNo
        '
        Me.nmTableNo.Location = New System.Drawing.Point(322, 11)
        Me.nmTableNo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmTableNo.Name = "nmTableNo"
        Me.nmTableNo.Size = New System.Drawing.Size(45, 20)
        Me.nmTableNo.TabIndex = 3
        Me.nmTableNo.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(138, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(97, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Prefix Table Name:"
        '
        'txtPrefix
        '
        Me.txtPrefix.Location = New System.Drawing.Point(241, 37)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(59, 20)
        Me.txtPrefix.TabIndex = 5
        Me.txtPrefix.Text = "testtable"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(307, 40)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(35, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "label3"
        '
        'btInsert
        '
        Me.btInsert.Location = New System.Drawing.Point(12, 345)
        Me.btInsert.Name = "btInsert"
        Me.btInsert.Size = New System.Drawing.Size(202, 23)
        Me.btInsert.TabIndex = 7
        Me.btInsert.Text = "Insert Sample Data Into Test Table"
        Me.btInsert.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(220, 350)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(235, 13)
        Me.label4.TabIndex = 8
        Me.label4.Text = "Number of Rows to be Inserted into Each Table:"
        '
        'nmRowsNumber
        '
        Me.nmRowsNumber.Location = New System.Drawing.Point(461, 348)
        Me.nmRowsNumber.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nmRowsNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmRowsNumber.Name = "nmRowsNumber"
        Me.nmRowsNumber.Size = New System.Drawing.Size(116, 20)
        Me.nmRowsNumber.TabIndex = 9
        Me.nmRowsNumber.Value = New Decimal(New Integer() {10000, 0, 0, 0})
        '
        'btView
        '
        Me.btView.Location = New System.Drawing.Point(12, 414)
        Me.btView.Name = "btView"
        Me.btView.Size = New System.Drawing.Size(167, 23)
        Me.btView.TabIndex = 10
        Me.btView.Text = "View Random Sample Data:"
        Me.btView.UseVisualStyleBackColor = True
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.textBox3.Location = New System.Drawing.Point(12, 450)
        Me.textBox3.Multiline = True
        Me.textBox3.Name = "textBox3"
        Me.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBox3.Size = New System.Drawing.Size(565, 150)
        Me.textBox3.TabIndex = 11
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(86, 65)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(117, 13)
        Me.label5.TabIndex = 12
        Me.label5.Text = "CREATE TABLE `XXX`"
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(12, 374)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(202, 23)
        Me.progressBar1.TabIndex = 13
        '
        'lbProgress
        '
        Me.lbProgress.AutoSize = True
        Me.lbProgress.Location = New System.Drawing.Point(220, 380)
        Me.lbProgress.Name = "lbProgress"
        Me.lbProgress.Size = New System.Drawing.Size(0, 13)
        Me.lbProgress.TabIndex = 14
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(461, 374)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(116, 23)
        Me.btCancel.TabIndex = 15
        Me.btCancel.Text = "Cancel Insert"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(12, 330)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(233, 13)
        Me.label6.TabIndex = 16
        Me.label6.Text = "(Table will be created automatically if not exists.)"
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Location = New System.Drawing.Point(323, 328)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(91, 17)
        Me.radioButton1.TabIndex = 17
        Me.radioButton1.Text = "Random Data"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'rbfix
        '
        Me.rbfix.AutoSize = True
        Me.rbfix.Checked = True
        Me.rbfix.Location = New System.Drawing.Point(253, 328)
        Me.rbfix.Name = "rbfix"
        Me.rbfix.Size = New System.Drawing.Size(64, 17)
        Me.rbfix.TabIndex = 18
        Me.rbfix.TabStop = True
        Me.rbfix.Text = "Fix Data"
        Me.rbfix.UseVisualStyleBackColor = True
        '
        'btRoutine
        '
        Me.btRoutine.Location = New System.Drawing.Point(371, 403)
        Me.btRoutine.Name = "btRoutine"
        Me.btRoutine.Size = New System.Drawing.Size(206, 41)
        Me.btRoutine.TabIndex = 19
        Me.btRoutine.Text = "Insert Sample Procedure, Function, Event, Trigger, View"
        Me.btRoutine.UseVisualStyleBackColor = True
        '
        'frmSampleData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 612)
        Me.Controls.Add(Me.btRoutine)
        Me.Controls.Add(Me.rbfix)
        Me.Controls.Add(Me.radioButton1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.lbProgress)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.btView)
        Me.Controls.Add(Me.nmRowsNumber)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.btInsert)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.nmTableNo)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "frmSampleData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sample Data Generator"
        CType(Me.nmTableNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmRowsNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private textBox1 As System.Windows.Forms.TextBox
    Private label1 As System.Windows.Forms.Label
    Private nmTableNo As System.Windows.Forms.NumericUpDown
    Private label2 As System.Windows.Forms.Label
    Private WithEvents txtPrefix As System.Windows.Forms.TextBox
    Private label3 As System.Windows.Forms.Label
    Private WithEvents btInsert As System.Windows.Forms.Button
    Private label4 As System.Windows.Forms.Label
    Private nmRowsNumber As System.Windows.Forms.NumericUpDown
    Private WithEvents btView As System.Windows.Forms.Button
    Private textBox3 As System.Windows.Forms.TextBox
    Private label5 As System.Windows.Forms.Label
    Private progressBar1 As System.Windows.Forms.ProgressBar
    Private lbProgress As System.Windows.Forms.Label
    Private WithEvents btCancel As System.Windows.Forms.Button
    Private label6 As System.Windows.Forms.Label
    Private radioButton1 As System.Windows.Forms.RadioButton
    Private rbfix As System.Windows.Forms.RadioButton
    Private WithEvents btRoutine As System.Windows.Forms.Button

End Class
