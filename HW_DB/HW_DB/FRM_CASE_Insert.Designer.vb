<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CASE_Insert
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCASEPSU = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCASEMat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCASEMB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCASEType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCASEBrand = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCASEMODEL = New System.Windows.Forms.TextBox()
        Me.btexit = New System.Windows.Forms.Button()
        Me.btsave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 153)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "แหล่งจ่ายไฟ"
        '
        'txtCASEPSU
        '
        Me.txtCASEPSU.Location = New System.Drawing.Point(83, 150)
        Me.txtCASEPSU.Name = "txtCASEPSU"
        Me.txtCASEPSU.Size = New System.Drawing.Size(151, 20)
        Me.txtCASEPSU.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "วัสดุ"
        '
        'txtCASEMat
        '
        Me.txtCASEMat.Location = New System.Drawing.Point(83, 124)
        Me.txtCASEMat.Name = "txtCASEMat"
        Me.txtCASEMat.Size = New System.Drawing.Size(151, 20)
        Me.txtCASEMat.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "รองรับบอร์ด"
        '
        'txtCASEMB
        '
        Me.txtCASEMB.Location = New System.Drawing.Point(83, 98)
        Me.txtCASEMB.Name = "txtCASEMB"
        Me.txtCASEMB.Size = New System.Drawing.Size(151, 20)
        Me.txtCASEMB.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "ประเภท"
        '
        'txtCASEType
        '
        Me.txtCASEType.Location = New System.Drawing.Point(83, 72)
        Me.txtCASEType.Name = "txtCASEType"
        Me.txtCASEType.Size = New System.Drawing.Size(151, 20)
        Me.txtCASEType.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "ผู้ผลิต"
        '
        'txtCASEBrand
        '
        Me.txtCASEBrand.Location = New System.Drawing.Point(83, 46)
        Me.txtCASEBrand.Name = "txtCASEBrand"
        Me.txtCASEBrand.Size = New System.Drawing.Size(151, 20)
        Me.txtCASEBrand.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "เลขรุ่น"
        '
        'txtCASEMODEL
        '
        Me.txtCASEMODEL.Location = New System.Drawing.Point(83, 20)
        Me.txtCASEMODEL.Name = "txtCASEMODEL"
        Me.txtCASEMODEL.Size = New System.Drawing.Size(151, 20)
        Me.txtCASEMODEL.TabIndex = 22
        '
        'btexit
        '
        Me.btexit.Location = New System.Drawing.Point(159, 189)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(75, 23)
        Me.btexit.TabIndex = 19
        Me.btexit.Text = "Exit"
        Me.btexit.UseVisualStyleBackColor = True
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(46, 189)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(75, 23)
        Me.btsave.TabIndex = 18
        Me.btsave.Text = "Save"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'FRM_CASE_Insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(262, 237)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCASEPSU)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCASEMat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCASEMB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCASEType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCASEBrand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCASEMODEL)
        Me.Controls.Add(Me.btexit)
        Me.Controls.Add(Me.btsave)
        Me.Name = "FRM_CASE_Insert"
        Me.Text = "เพิ่มข้อมูลเคสคอมพิวเตอร์"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents txtCASEPSU As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCASEMat As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCASEMB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCASEType As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCASEBrand As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCASEMODEL As TextBox
    Friend WithEvents btexit As Button
    Friend WithEvents btsave As Button
End Class
