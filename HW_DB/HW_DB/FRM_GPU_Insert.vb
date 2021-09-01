Public Class FRM_GPU_Insert
    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click


        Dim sql As String = $"INSERT INTO [tbl_gpu]([GPU_Model],[GPU_Brand],[GPU_GSpeed],[GPU_RAM],[GPU_RamType],[GPU_VGA],[GPU_DVI],[GPU_HDMI],[GPU_Display]) VALUES('{txtGPUMODEL.Text}','{txtGPUBrand.Text}','{txtGPUSpeed.Text}','{txtGPURam.Text}','{txtGPURType.Text}','{txtGPUVGA.Text}','{txtGPUDVI.Text}','{txtGPUHDMI.Text}','{txtGPUDisplay.Text}')" 'ประกาศตัวแปรสำหรับเก็บคำสั่งเพิ่มข้อมูล
        If _InsertAdd(sql) Then 'เรียกใช้ฟังก์ชั่นเพิ่มข้อมูลโดยใส่ตัวแปรที่เก็บคำสั่งเพิ่มข้อมูลในพารามิเตอร์
            _Success("Saved") 'เรียกใช้ฟังก์ชั่นแสดงกล่องข้อความเมื่อบันทึกสำเร็จพร้อมกำหนดข้อความลงในพารามิเตอร์
        Else
            _Error("Error") 'เรียกใช้ฟังก์ชั่นแสดงกล่องข้อความเมื่อบันทึกไม่สำเร็จพร้อมกำหนดข้อความลงในพารามิเตอร์
        End If

    End Sub

    Private Sub btexit_Click(sender As Object, e As EventArgs) Handles btexit.Click
        Close() 'ปิดหน้าต่าง
    End Sub

End Class