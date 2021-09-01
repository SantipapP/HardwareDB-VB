Public Class FRM_MB_Insert
    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click

        Dim sql As String = $"INSERT INTO [tbl_mainboard]([MB_Model],[MB_Brand],[MB_Socket],[MB_Chipset],[MB_SlotRam],[MB_RamType],[MB_SATA2],[MB_SATA3],[MB_M2SSD],[MB_USB2],[MB_USB3],[MB_FormFactor]) VALUES('{txtMBMODEL.Text}','{txtMBBrand.Text}','{txtMBSocket.Text}','{txtMBChip.Text}','{txtMBSlot.Text}','{txtMBRType.Text}','{txtSATA2.Text}','{txtSATA3.Text}','{txtM2.Text}','{txtUSB2.Text}','{txtUSB3.Text}','{txtMBSize.Text}')" 'ประกาศตัวแปรสำหรับเก็บคำสั่งเพิ่มข้อมูล
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