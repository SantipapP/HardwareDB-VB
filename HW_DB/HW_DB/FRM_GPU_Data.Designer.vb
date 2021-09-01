<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_GPU_Data
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btSearch = New System.Windows.Forms.Button()
        Me.btcpu = New System.Windows.Forms.Button()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.btadd = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.gridgpu = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridgpu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.txtBrand)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtModel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(885, 76)
        Me.Panel1.TabIndex = 0
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(742, 50)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(134, 20)
        Me.txtSearch.TabIndex = 24
        '
        'txtBrand
        '
        Me.txtBrand.Location = New System.Drawing.Point(498, 50)
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.ReadOnly = True
        Me.txtBrand.Size = New System.Drawing.Size(172, 20)
        Me.txtBrand.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(676, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "ค้นหายี่ห้อ :"
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(157, 50)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(261, 20)
        Me.txtModel.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(81, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ข้อมูล Model :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(424, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ข้อมูล ผู้ผลิต :"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 76)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(79, 320)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(758, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(127, 320)
        Me.Panel2.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btSearch)
        Me.GroupBox1.Controls.Add(Me.btcpu)
        Me.GroupBox1.Controls.Add(Me.btdelete)
        Me.GroupBox1.Controls.Add(Me.btadd)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(97, 146)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "แผงควบคุม"
        '
        'btSearch
        '
        Me.btSearch.Location = New System.Drawing.Point(10, 106)
        Me.btSearch.Name = "btSearch"
        Me.btSearch.Size = New System.Drawing.Size(75, 23)
        Me.btSearch.TabIndex = 7
        Me.btSearch.Text = "ค้นหา"
        Me.btSearch.UseVisualStyleBackColor = True
        '
        'btcpu
        '
        Me.btcpu.Location = New System.Drawing.Point(10, 19)
        Me.btcpu.Name = "btcpu"
        Me.btcpu.Size = New System.Drawing.Size(75, 23)
        Me.btcpu.TabIndex = 4
        Me.btcpu.Text = "เรียกข้อมูล"
        Me.btcpu.UseVisualStyleBackColor = True
        '
        'btdelete
        '
        Me.btdelete.Location = New System.Drawing.Point(10, 77)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(75, 23)
        Me.btdelete.TabIndex = 6
        Me.btdelete.Text = "ลบข้อมูล"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'btadd
        '
        Me.btadd.Location = New System.Drawing.Point(10, 48)
        Me.btadd.Name = "btadd"
        Me.btadd.Size = New System.Drawing.Size(75, 23)
        Me.btadd.TabIndex = 5
        Me.btadd.Text = "เพิ่มข้อมูล"
        Me.btadd.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 396)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(885, 54)
        Me.Panel3.TabIndex = 3
        '
        'gridgpu
        '
        Me.gridgpu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridgpu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridgpu.Location = New System.Drawing.Point(79, 76)
        Me.gridgpu.Name = "gridgpu"
        Me.gridgpu.Size = New System.Drawing.Size(679, 320)
        Me.gridgpu.TabIndex = 4
        '
        'FRM_GPU_Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(885, 450)
        Me.Controls.Add(Me.gridgpu)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FRM_GPU_Data"
        Me.Text = "ข้อมูลการ์ดจอ"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridgpu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents gridgpu As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btSearch As Button
    Friend WithEvents btcpu As Button
    Friend WithEvents btdelete As Button
    Friend WithEvents btadd As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtModel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
