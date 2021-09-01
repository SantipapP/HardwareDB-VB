<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btlogin = New System.Windows.Forms.Button()
        Me.btexit = New System.Windows.Forms.Button()
        Me.chkshowhide = New System.Windows.Forms.CheckBox()
        Me.chkremember = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbclock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmclock = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(120, 136)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(182, 20)
        Me.txtusername.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(120, 162)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(182, 20)
        Me.txtpassword.TabIndex = 4
        '
        'btlogin
        '
        Me.btlogin.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btlogin.Location = New System.Drawing.Point(68, 259)
        Me.btlogin.Name = "btlogin"
        Me.btlogin.Size = New System.Drawing.Size(75, 23)
        Me.btlogin.TabIndex = 5
        Me.btlogin.Text = "Login"
        Me.btlogin.UseVisualStyleBackColor = False
        '
        'btexit
        '
        Me.btexit.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btexit.Location = New System.Drawing.Point(174, 259)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(75, 23)
        Me.btexit.TabIndex = 6
        Me.btexit.Text = "Exit"
        Me.btexit.UseVisualStyleBackColor = False
        '
        'chkshowhide
        '
        Me.chkshowhide.AutoSize = True
        Me.chkshowhide.Location = New System.Drawing.Point(120, 204)
        Me.chkshowhide.Name = "chkshowhide"
        Me.chkshowhide.Size = New System.Drawing.Size(129, 17)
        Me.chkshowhide.TabIndex = 7
        Me.chkshowhide.Text = "Show/Hide Password"
        Me.chkshowhide.UseVisualStyleBackColor = True
        '
        'chkremember
        '
        Me.chkremember.AutoSize = True
        Me.chkremember.Location = New System.Drawing.Point(120, 227)
        Me.chkremember.Name = "chkremember"
        Me.chkremember.Size = New System.Drawing.Size(128, 17)
        Me.chkremember.TabIndex = 8
        Me.chkremember.Text = "Remember Username"
        Me.chkremember.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbclock, Me.ToolStripStatusLabel2, Me.status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 306)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(326, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(59, 17)
        Me.ToolStripStatusLabel1.Text = "เวลาปัจจุบัน"
        '
        'lbclock
        '
        Me.lbclock.Name = "lbclock"
        Me.lbclock.Size = New System.Drawing.Size(13, 17)
        Me.lbclock.Text = ".."
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(45, 17)
        Me.ToolStripStatusLabel2.Text = "Status :"
        '
        'tmclock
        '
        Me.tmclock.Enabled = True
        Me.tmclock.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'status
        '
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(16, 17)
        Me.status.Text = "..."
        '
        'FRM_Login
        '
        Me.AcceptButton = Me.btlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(326, 328)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.chkremember)
        Me.Controls.Add(Me.chkshowhide)
        Me.Controls.Add(Me.btexit)
        Me.Controls.Add(Me.btlogin)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "โปรแกรมฐานข้อมูลฮาร์ดแวร์"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents btlogin As Button
    Friend WithEvents btexit As Button
    Friend WithEvents chkshowhide As CheckBox
    Friend WithEvents chkremember As CheckBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lbclock As ToolStripStatusLabel
    Friend WithEvents tmclock As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents status As ToolStripStatusLabel
End Class
