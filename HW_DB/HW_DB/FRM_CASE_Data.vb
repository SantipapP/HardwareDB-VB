Imports System.Data.OleDb 'เพิ่มไลบารี่สำหรับฐานข้อมูล
Imports System.Data 'เพิ่มไลบารี่สำหรับจัดการฐานข้อมูล
Public Class FRM_CASE_Data
    Dim da As OleDbDataAdapter 'สร้างตัวแปรสำหรับควบคุมคำสั่ง sql
    Dim dt As DataTable 'สร้างตัวแปรสำหรับเก็บข้อมูลในตาราง
    Dim ds As DataSet 'สร้างตัวแปรสำหรับเก็บเช็ตในตาราง
    Private _sql As String 'ประกาศตัวแปรสำหรับเก็บค่า sql จากภายนอก
    Private Sub FRM_CASE_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Search() 'เรียกใช้ฟังก์ชั่นเมื่อหน้าต่างถูกเปิดขึ้นมา
    End Sub
    Private Sub Search() 'สร้างฟังก์ชั่นสำหรับเรียกข้อมูล
        gridcase.DataSource = _QueryAsDataTable(_sql) 'ให้วัตถุแสดงข้อมูลในตารางฐานข้อมูลโดยการเรียกใช้ฟังก์ชั่นพร้อมใส่พารามิเตอร์ที่ได้รับค่ามาแล้ว
    End Sub

    Public Sub Show_DATA(ByVal sql As String) 'สร้างฟังก์ชั่นสำหรับเรียกข้อมูล
        _sql = sql 'กำหนดให้ตัวแปรที่สร้างขึ้นมามีค่าเท่ากับ sql ที่ได้รับจากภายนอก
        Show() 'แสดงข้อมูล

    End Sub

    Private Sub btcpu_Click(sender As Object, e As EventArgs) Handles btcpu.Click
        Search() 'เรียกใช้ฟังก์ชั่นสำหรับเรียกข้อมูลมาแสดงเมื่อกดปุ่ม
    End Sub

    Private Sub btadd_Click(sender As Object, e As EventArgs) Handles btadd.Click
        FRM_CASE_Insert.ShowDialog() 'แสดงหน้าต่างสำหรับเพิ่มข้อมูลใหม่เมื่อกดปุ่ม
    End Sub

    Private Sub btdelete_Click(sender As Object, e As EventArgs) Handles btdelete.Click
        If _Confirm("ต้องการลบหรือไม่") Then 'แสดงข้อความยืนยันพร้อมกำหนดคำในพารามิเตอร์
            Dim sql As String = "DELETE FROM [tbl_case] WHERE CASE_Model = '" & txtModel.Text & "'" 'ประกาศตัวแปรสำหรับก็บคำสั่งลบข้อมูลในตารางฐานข้อมูล
            _Delete(sql) 'เรียกใช้ฟังก์ชั่นลบข้อมูลโดยกำหนดตัวแปรที่เก็บคำสั่งในพารามิเตอร์
            _Success("ลบข้อมูลเรียบร้อย") 'เรียกใช้ฟังก์ชั่นแสดงกล่องข้อความพร้อมกำหนดคำในพารามิเตอร์
            Search() 'เรียกใช้ฟังก์ชั่นแสดงข้อมูล
        End If

    End Sub

    Private Sub gridcase_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridcase.CellMouseUp
        txtModel.Text = gridcase.Rows.Item(e.RowIndex).Cells(1).Value.ToString 'กำหนดให้กล่องข้อความแสดงค่าในตารางฐานข้อมูลเมื่อคลิกในตาราง
        txtBrand.Text = gridcase.Rows.Item(e.RowIndex).Cells(2).Value.ToString 'กำหนดให้กล่องข้อความแสดงค่าในตารางฐานข้อมูลเมื่อคลิกในตาราง
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btSearch.Click

        dt = New DataTable 'กำหนดคุณสมบัติให้ตัวแปร
        ds = New DataSet 'กำหนดคุณสมบัติให้ตัวแปร
        ds.Tables.Add(dt) 'เก็บข้อมูลตารางที่ได้รับไว้ในตัวแปร
        da = New OleDbDataAdapter($"SELECT * FROM tbl_case WHERE CASE_Brand = '" & txtSearch.Text & "'", cn) 'ให้ตัวแปรเก็บคำสั่ง sql สำหรับค้นหาข้อมูล
        da.Fill(dt) 'นำตัวแปรที่เก็บคำสั่งใปใช้กับตัวแปรที่เก็บตารางฐานข้อมูล
        gridcase.DataSource = dt.DefaultView 'ให้วัตถุแสดงข้อมูลที่อยู่ในตารางที่ผ่านการกรองมาแล้ว

    End Sub
End Class