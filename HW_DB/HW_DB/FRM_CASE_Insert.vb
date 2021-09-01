Public Class FRM_CASE_Insert
    Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click

        Dim sql As String = $"INSERT INTO [tbl_case]([CASE_Model],[CASE_Brand],[CASE_Type],[CASE_Mainboard],[CASE_Material],[CASE_PSU]) VALUES('{txtCASEMODEL.Text}','{txtCASEBrand.Text}','{txtCASEType.Text}','{txtCASEMB.Text}','{txtCASEMat.Text}','{txtCASEPSU.Text}')" 'ประกาศตัวแปรสำหรับเก็บคำสั่งเพิ่มข้อมูล
        If _InsertAdd(sql) Then 'เรียกใช้ฟังก์ชั่นเพิ่มข้อมูลโดยใส่ตัวแปรที่เก็บคำสั่งเพิ่มข้อมูลในพารามิเตอร์
            _Success("Saved") 'เรียกใช้ฟังก์ชั่นแสดงกล่องข้อความเมื่อบันทึกสำเร็จพร้อมกำหนดข้อความลงในพารามิเตอร์
        Else
            _Error("Error") 'เรียกใช้ฟังก์ชั่นแสดงกล่องข้อความเมื่อบันทึกไม่สำเร็จพร้อมกำหนดข้อความลงในพารามิเตอร์
        End If

    End Sub

    Private Sub btexit_Click(sender As Object, e As EventArgs) Handles btexit.Click
        Close() 'ปิดหน้าต่าง
    End Sub

    Private Sub FRM_CASE_Insert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class