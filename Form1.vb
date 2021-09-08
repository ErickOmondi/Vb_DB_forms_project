Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32



Public Class Form1

    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim sqlDta As New MySqlDataAdapter

    Dim server As String = "localhost"
    Dim userName As String = "root"
    Dim password As String = "omollo@3915"
    Dim database As String = "MariaDB"
    Dim sslMode As String = "none"
    Dim SqlQuery As String

    Private bitmap As Bitmap

    Private Function updateTable()
        sqlConn.ConnectionString = String.Format("Server=" + server + ";" + "database=" + database + ";" + "UID=" + userName + ";" + "password=" + password + ";" + "SslMode=" + sslMode)
        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "select * from MariaDB.student"

        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()

        DataGridView1.DataSource = sqlDt

    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAddNewData.Click
        sqlConn.ConnectionString = "Server=" + server + ";" + "database=" + database + ";" + "UID=" + userName + ";" + "password=" + password + ";" + "persistsecurityinfo=True" + ";" + "SslMode=" + sslMode

        Try
            sqlConn.Open()
            SqlQuery = "insert into MariaDB.student(Firstname, Surname, Address, PostCode, Telephone) 
                        values('" & txtFirstName.Text & "','" & txtSurname.Text & "','" & txtAddress.Text &
                        "','" & txtPostCode.Text & "','" & txtTelephone.Text & "')"


            sqlCmd = New MySqlCommand(SqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlConn.Close()
            updateTable()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mysql Connector", MessageBoxButtons.OK,
                                MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("confirm if you want to exit", "Mysql Connector", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()

        End If

    End Sub

    Private Sub BtnResetData_Click(sender As Object, e As EventArgs) Handles BtnResetData.Click
        Try
            For Each txt In Panel4.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If

            Next
            textSearch.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub BtnUpdateData_Click(sender As Object, e As EventArgs) Handles BtnUpdateData.Click

        sqlConn.ConnectionString = "Server=" + server + ";" + "database=" + database + ";" + "UID=" + userName + ";" + "password=" +
            password + ";" + "persistsecurityinfo=True" + ";" + "SslMode=" + sslMode

        sqlConn.Open()
        sqlCmd.Connection = sqlConn

        With sqlCmd
            .CommandText = "UPDATE MariaDB.Student set Firstname=@Firstname, Surname=@Surname, Address=@Address, PostCode=@PostCode,
                            Telephone=@Telephone where studentid = @studentid"
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@Firstname", txtFirstName.Text)
            .Parameters.AddWithValue("@Surname", txtSurname.Text)
            .Parameters.AddWithValue("@Address", txtAddress.Text)
            .Parameters.AddWithValue("@PostCode", txtPostCode.Text)
            .Parameters.AddWithValue("@Telephone", txtTelephone.Text)
            .Parameters.AddWithValue("StudentID", txtStudentID.Text)

        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            txtStudentID.Text = DataGridView1.SelectedRows(0).Cells(0).Value.ToString()
            txtFirstName.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString()
            txtSurname.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString()
            txtAddress.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString()
            txtPostCode.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString()
            txtTelephone.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub BtnDeleteData_Click(sender As Object, e As EventArgs) Handles BtnDeleteData.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows

            DataGridView1.Rows.Remove(row)

        Next
        updateTable()
    End Sub

    Private Sub BtnPrintData_Click(sender As Object, e As EventArgs) Handles BtnPrintData.Click
        Dim height As Integer
        height = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = height
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recP As RectangleF = e.PageSettings.PrintableArea

        If Me.DataGridView1.Height = recP.Height > 0 Then e.HasMorePages = True

    End Sub

    Private Sub textSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textSearch.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                Dim dv As DataView
                dv = sqlDt.DefaultView
                dv.RowFilter = String.Format("Firstname like '%{0}%'", textSearch.Text)
                DataGridView1.DataSource = dv.ToTable()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class
