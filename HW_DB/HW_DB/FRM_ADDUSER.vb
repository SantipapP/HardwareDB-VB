Public Class FRM_ADDUSER
    Private Sub btexit_Click(sender As Object, e As EventArgs) Handles btexit.Click
        Close() 'คำสั่งปิดหน้าต่าง
    End Sub

    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
        If txtUsername.Text = "" Then 'ตรวจสอบว่า textbox username ว่างหรือไม่
            MessageBox.Show("กรุณาใส่รหัสอุปกรณ์") 'แสดงกล่องข้อความเตือน
        Else
            Dim sql As String = $"INSERT INTO [tbl_admin]([username],[password],[fullname]) VALUES('{txtUsername.Text}','{txtPassword.Text}','{txtName.Text}')" 'คำสั่ง sql สำหรับเพิ่มข้อมูลลงตาราง
            If _InsertAdd(sql) Then 'เรียกใช้ฟังก์ชั่นกำหนดค่าพารามิเตอร์จาก sql
                _Success("Saved") 'เรียกใช้ฟังก์ชั่นแสดงกล่องข้อความเมื่อบันทึกสำเร็จ
            Else
                _Error("Error") 'เรียกใช้ฟังก์ชั่นแสดงกล่องข้อความเมื่อบันทึกไม่สำเร็จ
            End If
        End If
    End Sub
End Class