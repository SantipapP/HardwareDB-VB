Imports System.Data.OleDb
Imports System.Data
Public Class FRM_CPU_Data
    Dim da As OleDbDataAdapter 'สร้างตัวแปรสำหรับควบคุมคำสั่ง sql
    Dim dt As DataTable 'สร้างตัวแปรสำหรับเก็บข้อมูลในตาราง
    Dim ds As DataSet 'สร้างตัวแปรสำหรับเก็บเช็ตในตาราง
    Private _sql As String 'ประกาศตัวแปรสำหรับเก็บค่า sql จากภายนอก


    Public Sub Show_DATA(ByVal sql As String) 'สร้างฟังก์ชั่นสำหรับเรียกข้อมูล
        _sql = sql 'กำหนดให้ตัวแปรที่สร้างขึ้นมามีค่าเท่ากับ sql ที่ได้รับจากภายนอก
        Show() 'แสดงข้อมูล

    End Sub

    Private Sub Search() 'สร้างฟังก์ชั่นสำหรับเรียกข้อมูล
        gridcpu.DataSource = _QueryAsDataTable(_sql) 'ให้วัตถุแสดงข้อมูลในตารางฐานข้อมูลโดยการเรียกใช้ฟังก์ชั่นพร้อมใส่พารามิเตอร์ที่ได้รับค่ามาแล้ว
    End Sub

    Private Sub FRM_CPU_Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Search() 'เรียกใช้ฟังก์ชั่นเมื่อหน้าต่างถูกเปิดขึ้นมา
    End Sub


    Private Sub btdelete_Click_1(sender As Object, e As EventArgs) Handles btdelete.Click
        If _Confirm("ต้องการลบหรือไม่") Then 'แสดงข้อความยืนยันพร้อมกำหนดคำในพารามิเตอร์
            Dim sql As String = "DELETE FROM [tbl_cpu] WHERE CPU_Model = '" & txtModel.Text & "'" 'ประกาศตัวแปรสำหรับก็บคำสั่งลบข้อมูลในตารางฐานข้อมูล

            _Delete(sql) 'เรียกใช้ฟังก์ชั่นลบข้อมูลโดยกำหนดตัวแปรที่เก็บคำสั่งในพารามิเตอร์
            _Success("ลบข้อมูลเรียบร้อย") 'เรียกใช้ฟังก์ชั่นแสดงกล่องข้อความพร้อมกำหนดคำในพารามิเตอร์
            Search() 'เรียกใช้ฟังก์ชั่นแสดงข้อมูล
        End If
    End Sub

    Private Sub gridcpu_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridcpu.CellMouseUp
        txtModel.Text = gridcpu.Rows.Item(e.RowIndex).Cells(1).Value.ToString 'กำหนดให้กล่องข้อความแสดงค่าในตารางฐานข้อมูลเมื่อคลิกในตาราง
        txtBrand.Text = gridcpu.Rows.Item(e.RowIndex).Cells(2).Value.ToString 'กำหนดให้กล่องข้อความแสดงค่าในตารางฐานข้อมูลเมื่อคลิกในตาราง
    End Sub

    Private Sub btSearch_Click(sender As Object, e As EventArgs) Handles btSearch.Click
        dt = New DataTable 'กำหนดคุณสมบัติให้ตัวแปร
        ds = New DataSet 'กำหนดคุณสมบัติให้ตัวแปร
        ds.Tables.Add(dt) 'เก็บข้อมูลตารางที่ได้รับไว้ในตัวแปร
        da = New OleDbDataAdapter($"SELECT * FROM tbl_cpu WHERE CPU_Brand = '" & txtSearch.Text & "'", cn) 'ให้ตัวแปรเก็บคำสั่ง sql สำหรับค้นหาข้อมูล
        da.Fill(dt) 'นำตัวแปรที่เก็บคำสั่งใปใช้กับตัวแปรที่เก็บตารางฐานข้อมูล
        gridcpu.DataSource = dt.DefaultView 'ให้วัตถุแสดงข้อมูลที่อยู่ในตารางที่ผ่านการกรองมาแล้ว
    End Sub

    Private Sub btcpu_Click_1(sender As Object, e As EventArgs) Handles btcpu.Click
        Search() 'เรียกใช้ฟังก์ชั่นสำหรับเรียกข้อมูลมาแสดงเมื่อกดปุ่ม
    End Sub

    Private Sub btadd_Click(sender As Object, e As EventArgs) Handles btadd.Click
        FRM_CPU_Insert.ShowDialog() 'แสดงหน้าต่างสำหรับเพิ่มข้อมูลใหม่เมื่อกดปุ่ม
    End Sub
End Class