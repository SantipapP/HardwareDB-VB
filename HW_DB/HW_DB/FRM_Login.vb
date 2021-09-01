Public Class FRM_Login

    Private Sub chkshowhide_CheckedChanged(sender As Object, e As EventArgs) Handles chkshowhide.CheckedChanged
        txtpassword.PasswordChar = If(chkshowhide.Checked, "", "*")
    End Sub

    Private Sub btlogin_Click(sender As Object, e As EventArgs) Handles btlogin.Click

        If txtusername._IsEmpty Or txtpassword._IsEmpty Then
            _Error("กรุณากรอกข้อมูลให้ครบถ้วน")

        Else

            Dim isLoginCorrect As Boolean = Login(txtusername.Text, txtpassword.Text)
            If isLoginCorrect Then
                _Success("เข้าสู่ระบบสำเร็จ ยินดีต้อนรับคุณ : " + txtusername.Text)
                FRM_MAIN.Show()
                Me.Hide()

            Else
                _Error("กรุณาตรวจสอบ Username หรือ Password")
            End If



            If chkremember.Checked Then 'ตรวจสอบchekboxว่าถูกเลือกไหม
                My.Settings.username = txtusername.Text 'เก็บค่าที่อยู่ใน textbox Username ไว้ในการตั้งค่าของโปรแกรม
                My.Settings.Save() 'บันทึกการตั้งค่า
            End If
        End If




    End Sub

    Private Function Login(username As String, password As String) As Boolean
        Dim sql As String = $"SELECT * FROM tbl_admin WHERE Username = '{username}' AND password = '{password}'" 'ประกาศตัวแปรและเก็บค่าคำสั่ง sql
        Dim da As New OleDb.OleDbDataAdapter(sql, cn) 'ประกาศตัวแปรโดยมีพารามิเตอร์เป็นคำสั่ง sql และ ที่อยู่ของฐานข้อมูล
        Dim ds As New DataSet 'ประกาศตัวแปรสำหรับเก็บข้อมูลจากตารางฐานข้อมูล
        da.Fill(ds, "Result") 'เก็บผลลัพท์ที่ได้จากคำสั่ง sql ลงใน ds

        If ds.Tables("Result").Rows.Count > 0 Then 'ตรวจสอบว่า ds ได้มีการรับข้อมูลไหม
            Return True 'ส่งค่าคืนเป็น true

        Else
            Return False 'ส่งค่าคืนเป็น False
        End If

    End Function


    Private Sub FRM_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.username._isEmpty Then
            txtusername.Text = My.Settings.username
            chkremember.Checked = True
        End If

        Dim isConnected As Boolean = ConnectDB()
        If isConnected Then
            status.Text = "Connected"
        Else
            status.Text = "Not Connect"
            txtusername.Enabled = False
            txtpassword.Enabled = False
            btlogin.Enabled = False

        End If

    End Sub

    Private Sub chkremember_CheckedChanged(sender As Object, e As EventArgs) Handles chkremember.CheckedChanged
        If chkremember.Checked = False Then 'ตรวจสอบchekboxว่าถูกเลือกไหม
            My.Settings.username = "" 'เก็บค่าว่าง ไว้ในการตั้งค่าของโปรแกรม
            My.Settings.Save() 'บันทึกการตั้งค่า
        End If
    End Sub

    Private Sub btexit_Click(sender As Object, e As EventArgs) Handles btexit.Click
        If _Confirm("ต้องการออกจากโปรแกรมหรือไม่") Then 'เรียกใช้ฟังก์ชั่นเพื่อแสดงกล่องข้อความยืนยัน
            Close() 'ปิดฟอร์ม
            End 'จบการทำงาน

        End If
    End Sub

    Private Sub tmclock_Tick(sender As Object, e As EventArgs) Handles tmclock.Tick
        lbclock.Text = Date.Now 'เก็บค่าเวลาปัจจุบันเพื่อแสดงในหน้าฟอร์ม
    End Sub


End Class
