Public Class FRM_PSU_Insert
    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click

        Dim sql As String = $"INSERT INTO [tbl_psu]([PSU_Model],[PSU_Series],[PSU_Brand],[PSU_Power],[PSU_FanSize],[PSU_MB],[PSU_CPU],[PSU_PCI],[PSU_Sata],[PSU_Molex],[PSU_ISO],[PSU_Input]) VALUES('{txtPSUMODEL.Text}','{txtPSUSeries.Text}','{txtPSUBrand.Text}','{txtPSUWatt.Text}','{txtPSUFan.Text}','{txtPSUMB.Text}','{txtPSUCPU.Text}','{txtPSUPCI.Text}','{txtPSUSATA.Text}','{txtPSUMolex.Text}','{txtPSUISO.Text}','{txtPSUInput.Text}')" 'ประกาศตัวแปรสำหรับเก็บคำสั่งเพิ่มข้อมูล
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