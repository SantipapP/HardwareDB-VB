Public Class FRM_MAIN

    Private Sub btcpu_Click_1(sender As Object, e As EventArgs) Handles btcpu.Click
        FRM_CPU_Data.Show_DATA("SELECT * FROM tbl_cpu") 'เปิดฟอร์ม CPU พร้อมเรียกใช้ฟังก์ชั่นโดยกำหนดพารามิเตอร์เป็นคำสั่ง sql
    End Sub

    Private Sub btmb_Click_1(sender As Object, e As EventArgs) Handles btmb.Click
        FRM_MB_Data.Show_DATA("SELECT * FROM tbl_mainboard") 'เปิดฟอร์ม Mainboard พร้อมเรียกใช้ฟังก์ชั่นโดยกำหนดพารามิเตอร์เป็นคำสั่ง sql
    End Sub

    Private Sub btgpu_Click_1(sender As Object, e As EventArgs) Handles btgpu.Click
        FRM_GPU_Data.Show_DATA("SELECT * FROM tbl_gpu") 'เปิดฟอร์ม Mainboard พร้อมเรียกใช้ฟังก์ชั่นโดยกำหนดพารามิเตอร์เป็นคำสั่ง sql
    End Sub

    Private Sub btram_Click(sender As Object, e As EventArgs) Handles btram.Click
        FRM_RAM_Data.Show_DATA("SELECT * FROM tbl_ram") 'เปิดฟอร์ม RAM พร้อมเรียกใช้ฟังก์ชั่นโดยกำหนดพารามิเตอร์เป็นคำสั่ง sql
    End Sub

    Private Sub btcase_Click(sender As Object, e As EventArgs) Handles btcase.Click
        FRM_CASE_Data.Show_DATA("SELECT * FROM tbl_case") 'เปิดฟอร์ม CASE พร้อมเรียกใช้ฟังก์ชั่นโดยกำหนดพารามิเตอร์เป็นคำสั่ง sql
    End Sub

    Private Sub btpsu_Click(sender As Object, e As EventArgs) Handles btpsu.Click
        FRM_PSU_Data.Show_DATA("SELECT * FROM tbl_psu") 'เปิดฟอร์ม PSU พร้อมเรียกใช้ฟังก์ชั่นโดยกำหนดพารามิเตอร์เป็นคำสั่ง sql
    End Sub

    Private Sub btstorage_Click(sender As Object, e As EventArgs) Handles btstorage.Click
        FRM_STO_Data.Show_DATA("SELECT * FROM tbl_storage") 'เปิดฟอร์ม Storage พร้อมเรียกใช้ฟังก์ชั่นโดยกำหนดพารามิเตอร์เป็นคำสั่ง sql
    End Sub

    Private Sub FRM_MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label2.Text = FRM_Login.txtusername.Text 'ให้ข้อความใน label เหมือนกับข้อความ username ในฟอร์ม Login
        If Label2.Text = "admin" Then 'ตรวจสอบข้อความของ Label ว่าเป็น admin หรือไม่
            btadduser.Visible = True 'กรณีที่เป็น admin ให้แสดงปุ่มเพิ่มผู้ใช้ขึ้นมา
        Else
            btadduser.Visible = False 'กรณีที่ไม่ใช่ admin ให้ซ่อนปุ่มเพิ่มผู้ใช้
        End If
    End Sub


    Private Sub btlogout_Click(sender As Object, e As EventArgs) Handles btlogout.Click
        If _Confirm("ต้องการออกจากระบบหรือไม่") Then 'เรียกใช้ฟังก์ชั่นแสดงกล่องข้อความยืนยันพร้อมกำหนดข้อความในพารามิเตอร์
            Close() 'ปิดฟอร์ม
            FRM_Login.Show() 'แสดงหน้าต่าง Login ขึ้นมา
        End If
    End Sub

    Private Sub btadduser_Click(sender As Object, e As EventArgs) Handles btadduser.Click
        FRM_ADDUSER.ShowDialog() 'เปิดหน้าต่างเพิ่มผู้ใช้
    End Sub
End Class