Imports System.Runtime.CompilerServices

Module code
    <Extension()> Public Function _IsEmpty(ByVal txt As TextBox) As Boolean 'สร้างฟังกชั่นสำหรับตรวจสอบค่าว่าในtextbox
        Return String.IsNullOrWhiteSpace(txt.Text) 'ส่งคำสั่งเช็คค่่าค่าว่างกลับไป
    End Function

    <Extension()> Public Function _isEmpty(ByVal str As String) As Boolean 'สร้างฟังกชั่นสำหรับตรวจสอบค่าว่าในtextbox
        Return String.IsNullOrWhiteSpace(str) 'ส่งคำสั่งเช็คค่่าค่าว่างกลับไป
    End Function

    Public Function _Confirm(msg As String) As Boolean 'สร้างฟังก์ชั่นสำหรับกล่องข้อความยืนยัน
        Return MessageBox.Show(msg, "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes 'ส่งค่าโครงสร้างของกล่องข้อความกลับไป
    End Function

    Public Sub _Error(msg As String) 'สร้างฟังก์ชั่นสำหรับกล่องข้อความผิดพลาด
        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) 'ส่งค่าโครงสร้างของกล่องข้อความกลับไป
    End Sub

    Public Sub _Success(msg As String) 'สร้างฟังก์ชั่นสำหรับกล่องข้อความสำเร็จ
        MessageBox.Show(msg, "Seccess", MessageBoxButtons.OK, MessageBoxIcon.Information) 'ส่งค่าโครงสร้างของกล่องข้อความกลับไป

    End Sub
End Module
