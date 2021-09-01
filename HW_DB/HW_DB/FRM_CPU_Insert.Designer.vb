<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CPU_Insert
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
        Me.btsave = New System.Windows.Forms.Button()
        Me.btexit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCPUMODEL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCPUBrand = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCPUSocket = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCPUCore = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCPUThread = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCPUFrequency = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCPUTurbo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(59, 210)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(75, 23)
        Me.btsave.TabIndex = 0
        Me.btsave.Text = "Save"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'btexit
        '
        Me.btexit.Location = New System.Drawing.Point(172, 210)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(75, 23)
        Me.btexit.TabIndex = 1
        Me.btexit.Text = "Exit"
        Me.btexit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "เลขรุ่น"
        '
        'txtCPUMODEL
        '
        Me.txtCPUMODEL.Location = New System.Drawing.Point(96, 16)
        Me.txtCPUMODEL.Name = "txtCPUMODEL"
        Me.txtCPUMODEL.Size = New System.Drawing.Size(151, 20)
        Me.txtCPUMODEL.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ผู้ผลิต"
        '
        'txtCPUBrand
        '
        Me.txtCPUBrand.Location = New System.Drawing.Point(96, 42)
        Me.txtCPUBrand.Name = "txtCPUBrand"
        Me.txtCPUBrand.Size = New System.Drawing.Size(151, 20)
        Me.txtCPUBrand.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Socket"
        '
        'txtCPUSocket
        '
        Me.txtCPUSocket.Location = New System.Drawing.Point(96, 68)
        Me.txtCPUSocket.Name = "txtCPUSocket"
        Me.txtCPUSocket.Size = New System.Drawing.Size(151, 20)
        Me.txtCPUSocket.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Core"
        '
        'txtCPUCore
        '
        Me.txtCPUCore.Location = New System.Drawing.Point(96, 94)
        Me.txtCPUCore.Name = "txtCPUCore"
        Me.txtCPUCore.Size = New System.Drawing.Size(151, 20)
        Me.txtCPUCore.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "thread"
        '
        'txtCPUThread
        '
        Me.txtCPUThread.Location = New System.Drawing.Point(96, 120)
        Me.txtCPUThread.Name = "txtCPUThread"
        Me.txtCPUThread.Size = New System.Drawing.Size(151, 20)
        Me.txtCPUThread.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Frequency"
        '
        'txtCPUFrequency
        '
        Me.txtCPUFrequency.Location = New System.Drawing.Point(96, 146)
        Me.txtCPUFrequency.Name = "txtCPUFrequency"
        Me.txtCPUFrequency.Size = New System.Drawing.Size(151, 20)
        Me.txtCPUFrequency.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Turbo"
        '
        'txtCPUTurbo
        '
        Me.txtCPUTurbo.Location = New System.Drawing.Point(96, 172)
        Me.txtCPUTurbo.Name = "txtCPUTurbo"
        Me.txtCPUTurbo.Size = New System.Drawing.Size(151, 20)
        Me.txtCPUTurbo.TabIndex = 16
        '
        'FRM_CPU_Insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(283, 256)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCPUTurbo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCPUFrequency)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCPUThread)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCPUCore)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCPUSocket)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCPUBrand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCPUMODEL)
        Me.Controls.Add(Me.btexit)
        Me.Controls.Add(Me.btsave)
        Me.Name = "FRM_CPU_Insert"
        Me.Text = "เพิ่มข้อมูล CPU"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btsave As Button
    Friend WithEvents btexit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCPUMODEL As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCPUBrand As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCPUSocket As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCPUCore As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCPUThread As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCPUFrequency As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCPUTurbo As TextBox
End Class
