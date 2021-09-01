Public Class FRM_RAM_Insert


    Private Sub btexit_Click(sender As Object, e As EventArgs) Handles btexit.Click
        Close() 'ปิดหน้าต่าง
    End Sub

    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click

        Dim sql As String = $"INSERT INTO [tbl_ram]([RAM_Model],[RAM_Brand],[RAM_PartNo],[RAM_Type],[RAM_Speed],[RAM_TCapacity],[RAM_CapacityPerDIMM]) VALUES('{txtRAMMODEL.Text}','{txtRAMBrand.Text}','{txtRAMPartNo.Text}','{txtRAMType.Text}','{txtRAMSpeed.Text}','{txtRAMTC.Text}','{txtRAMCPD.Text}')" 'ประกาศตัวแปรสำหรับเก็บคำสั่งเพิ่มข้อมูล
        If _InsertAdd(sql) Then 'เรียกใช้ฟังก์ชั่นเพิ่มข้อมูลโดยใส่ตัวแปรที่เก็บคำสั่งเพิ่มข้อมูลในพารามิเตอร์
            _Success("Saved") 'เรียกใช้ฟังก์ชั่นแสดงกล่องข้อความเมื่อบันทึกสำเร็จพร้อมกำหนดข้อความลงในพารามิเตอร์
        Else
            _Error("Error") 'เรียกใช้ฟังก์ชั่นแสดงกล่องข้อความเมื่อบันทึกไม่สำเร็จพร้อมกำหนดข้อความลงในพารามิเตอร์
        End If

    End Sub
End Class