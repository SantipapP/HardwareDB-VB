<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_STO_Insert
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSTOSize = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSTOBrand = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSTOMODEL = New System.Windows.Forms.TextBox()
        Me.btexit = New System.Windows.Forms.Button()
        Me.btsave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "ขนาด"
        '
        'txtSTOSize
        '
        Me.txtSTOSize.Location = New System.Drawing.Point(81, 67)
        Me.txtSTOSize.Name = "txtSTOSize"
        Me.txtSTOSize.Size = New System.Drawing.Size(151, 20)
        Me.txtSTOSize.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "ผู้ผลิต"
        '
        'txtSTOBrand
        '
        Me.txtSTOBrand.Location = New System.Drawing.Point(81, 41)
        Me.txtSTOBrand.Name = "txtSTOBrand"
        Me.txtSTOBrand.Size = New System.Drawing.Size(151, 20)
        Me.txtSTOBrand.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "เลขรุ่น"
        '
        'txtSTOMODEL
        '
        Me.txtSTOMODEL.Location = New System.Drawing.Point(81, 15)
        Me.txtSTOMODEL.Name = "txtSTOMODEL"
        Me.txtSTOMODEL.Size = New System.Drawing.Size(151, 20)
        Me.txtSTOMODEL.TabIndex = 12
        '
        'btexit
        '
        Me.btexit.Location = New System.Drawing.Point(238, 51)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(75, 23)
        Me.btexit.TabIndex = 19
        Me.btexit.Text = "Exit"
        Me.btexit.UseVisualStyleBackColor = True
        '
        'btsave
        '
        Me.btsave.Location = New System.Drawing.Point(238, 22)
        Me.btsave.Name = "btsave"
        Me.btsave.Size = New System.Drawing.Size(75, 23)
        Me.btsave.TabIndex = 18
        Me.btsave.Text = "Save"
        Me.btsave.UseVisualStyleBackColor = True
        '
        'FRM_STO_Insert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(338, 102)
        Me.Controls.Add(Me.btexit)
        Me.Controls.Add(Me.btsave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSTOSize)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSTOBrand)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSTOMODEL)
        Me.Name = "FRM_STO_Insert"
        Me.Text = "เพิ่มข้อมูลหน่วยความจำ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents txtSTOSize As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSTOBrand As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSTOMODEL As TextBox
    Friend WithEvents btexit As Button
    Friend WithEvents btsave As Button
End Class
