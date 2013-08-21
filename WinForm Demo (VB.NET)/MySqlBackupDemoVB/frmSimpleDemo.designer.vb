<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimpleDemo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.txtConstr = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btBackup = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lb_Progress = New System.Windows.Forms.Label
        Me.btRestore = New System.Windows.Forms.Button
        Me.btCancel = New System.Windows.Forms.Button
        Me.RefreshTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtConstr
        '
        Me.txtConstr.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConstr.Location = New System.Drawing.Point(14, 33)
        Me.txtConstr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtConstr.Name = "txtConstr"
        Me.txtConstr.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtConstr.Size = New System.Drawing.Size(550, 22)
        Me.txtConstr.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MySQL Connection String"
        '
        'btBackup
        '
        Me.btBackup.Location = New System.Drawing.Point(14, 66)
        Me.btBackup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btBackup.Name = "btBackup"
        Me.btBackup.Size = New System.Drawing.Size(87, 30)
        Me.btBackup.TabIndex = 2
        Me.btBackup.Text = "Backup"
        Me.btBackup.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(14, 132)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(550, 27)
        Me.ProgressBar1.TabIndex = 3
        '
        'lb_Progress
        '
        Me.lb_Progress.AutoSize = True
        Me.lb_Progress.Location = New System.Drawing.Point(14, 111)
        Me.lb_Progress.Name = "lb_Progress"
        Me.lb_Progress.Size = New System.Drawing.Size(66, 16)
        Me.lb_Progress.TabIndex = 4
        Me.lb_Progress.Text = "Progress:"
        '
        'btRestore
        '
        Me.btRestore.Location = New System.Drawing.Point(108, 66)
        Me.btRestore.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btRestore.Name = "btRestore"
        Me.btRestore.Size = New System.Drawing.Size(87, 30)
        Me.btRestore.TabIndex = 5
        Me.btRestore.Text = "Restore"
        Me.btRestore.UseVisualStyleBackColor = True
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(201, 66)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(87, 30)
        Me.btCancel.TabIndex = 6
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = True
        '
        'RefreshTimer
        '
        Me.RefreshTimer.Interval = 10
        '
        'frmSimpleDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 179)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btRestore)
        Me.Controls.Add(Me.lb_Progress)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btBackup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtConstr)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSimpleDemo"
        Me.Text = "MySqlBackup.NET - Simple Example in VB.NET"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtConstr As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btBackup As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lb_Progress As System.Windows.Forms.Label
    Friend WithEvents btRestore As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents RefreshTimer As System.Windows.Forms.Timer

End Class
