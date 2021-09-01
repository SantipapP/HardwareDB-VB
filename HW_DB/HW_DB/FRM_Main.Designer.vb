<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MAIN
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btlogout = New System.Windows.Forms.Button()
        Me.btstorage = New System.Windows.Forms.Button()
        Me.btpsu = New System.Windows.Forms.Button()
        Me.btcase = New System.Windows.Forms.Button()
        Me.btram = New System.Windows.Forms.Button()
        Me.btgpu = New System.Windows.Forms.Button()
        Me.btmb = New System.Windows.Forms.Button()
        Me.btcpu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btadduser = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btlogout)
        Me.GroupBox1.Controls.Add(Me.btstorage)
        Me.GroupBox1.Controls.Add(Me.btpsu)
        Me.GroupBox1.Controls.Add(Me.btcase)
        Me.GroupBox1.Controls.Add(Me.btram)
        Me.GroupBox1.Controls.Add(Me.btgpu)
        Me.GroupBox1.Controls.Add(Me.btmb)
        Me.GroupBox1.Controls.Add(Me.btcpu)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 301)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายการอุปกรณ์"
        '
        'btlogout
        '
        Me.btlogout.Location = New System.Drawing.Point(175, 224)
        Me.btlogout.Name = "btlogout"
        Me.btlogout.Size = New System.Drawing.Size(148, 59)
        Me.btlogout.TabIndex = 7
        Me.btlogout.Text = "ออกจากระบบ"
        Me.btlogout.UseVisualStyleBackColor = True
        '
        'btstorage
        '
        Me.btstorage.Location = New System.Drawing.Point(21, 224)
        Me.btstorage.Name = "btstorage"
        Me.btstorage.Size = New System.Drawing.Size(148, 59)
        Me.btstorage.TabIndex = 6
        Me.btstorage.Text = "Storage"
        Me.btstorage.UseVisualStyleBackColor = True
        '
        'btpsu
        '
        Me.btpsu.Location = New System.Drawing.Point(175, 159)
        Me.btpsu.Name = "btpsu"
        Me.btpsu.Size = New System.Drawing.Size(148, 59)
        Me.btpsu.TabIndex = 5
        Me.btpsu.Text = "PowerSupply"
        Me.btpsu.UseVisualStyleBackColor = True
        '
        'btcase
        '
        Me.btcase.Location = New System.Drawing.Point(175, 94)
        Me.btcase.Name = "btcase"
        Me.btcase.Size = New System.Drawing.Size(148, 59)
        Me.btcase.TabIndex = 4
        Me.btcase.Text = "CASE"
        Me.btcase.UseVisualStyleBackColor = True
        '
        'btram
        '
        Me.btram.Location = New System.Drawing.Point(175, 29)
        Me.btram.Name = "btram"
        Me.btram.Size = New System.Drawing.Size(148, 59)
        Me.btram.TabIndex = 3
        Me.btram.Text = "RAM"
        Me.btram.UseVisualStyleBackColor = True
        '
        'btgpu
        '
        Me.btgpu.Location = New System.Drawing.Point(21, 159)
        Me.btgpu.Name = "btgpu"
        Me.btgpu.Size = New System.Drawing.Size(148, 59)
        Me.btgpu.TabIndex = 2
        Me.btgpu.Text = "Graphic Cards"
        Me.btgpu.UseVisualStyleBackColor = True
        '
        'btmb
        '
        Me.btmb.Location = New System.Drawing.Point(21, 94)
        Me.btmb.Name = "btmb"
        Me.btmb.Size = New System.Drawing.Size(148, 59)
        Me.btmb.TabIndex = 1
        Me.btmb.Text = "Mainbroad"
        Me.btmb.UseVisualStyleBackColor = True
        '
        'btcpu
        '
        Me.btcpu.Location = New System.Drawing.Point(21, 29)
        Me.btcpu.Name = "btcpu"
        Me.btcpu.Size = New System.Drawing.Size(148, 59)
        Me.btcpu.TabIndex = 0
        Me.btcpu.Text = "CPU"
        Me.btcpu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ผู้ใช้งาน : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "..."
        '
        'btadduser
        '
        Me.btadduser.Location = New System.Drawing.Point(280, 12)
        Me.btadduser.Name = "btadduser"
        Me.btadduser.Size = New System.Drawing.Size(75, 23)
        Me.btadduser.TabIndex = 3
        Me.btadduser.Text = "เพิ่มผู้ใช้"
        Me.btadduser.UseVisualStyleBackColor = True
        Me.btadduser.Visible = False
        '
        'FRM_MAIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(371, 354)
        Me.Controls.Add(Me.btadduser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FRM_MAIN"
        Me.Text = "เมนูหลัก"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btpsu As Button
    Friend WithEvents btcase As Button
    Friend WithEvents btram As Button
    Friend WithEvents btgpu As Button
    Friend WithEvents btmb As Button
    Friend WithEvents btcpu As Button
    Friend WithEvents btstorage As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btlogout As Button
    Friend WithEvents btadduser As Button
End Class
