<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPostCode = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.textSearch = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnPrintData = New System.Windows.Forms.Button()
        Me.BtnDeleteData = New System.Windows.Forms.Button()
        Me.BtnResetData = New System.Windows.Forms.Button()
        Me.BtnUpdateData = New System.Windows.Forms.Button()
        Me.BtnAddNewData = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(8, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1327, 144)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(9, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1309, 126)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(122, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1002, 91)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MARIA DB CONNECTION"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(8, 164)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(947, 687)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Info
        Me.Panel4.Controls.Add(Me.DataGridView1)
        Me.Panel4.Controls.Add(Me.txtTelephone)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.txtAddress)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtPostCode)
        Me.Panel4.Controls.Add(Me.txtFirstName)
        Me.Panel4.Controls.Add(Me.txtSurname)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtStudentID)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(9, 11)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(928, 670)
        Me.Panel4.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 429)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(894, 225)
        Me.DataGridView1.TabIndex = 3
        '
        'txtTelephone
        '
        Me.txtTelephone.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.Location = New System.Drawing.Point(276, 360)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(635, 53)
        Me.txtTelephone.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(213, 36)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "TELEPHONE:"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(276, 215)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(635, 53)
        Me.txtAddress.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 36)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ADDRESS:"
        '
        'txtPostCode
        '
        Me.txtPostCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostCode.Location = New System.Drawing.Point(276, 294)
        Me.txtPostCode.Name = "txtPostCode"
        Me.txtPostCode.Size = New System.Drawing.Size(635, 53)
        Me.txtPostCode.TabIndex = 2
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(276, 90)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(635, 53)
        Me.txtFirstName.TabIndex = 2
        '
        'txtSurname
        '
        Me.txtSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSurname.Location = New System.Drawing.Point(276, 156)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(635, 53)
        Me.txtSurname.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 36)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "POST CODE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 36)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "FIRST NAME:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 36)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "SURNAME:"
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(276, 24)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.Size = New System.Drawing.Size(635, 53)
        Me.txtStudentID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "STUDENT ID:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel5.Controls.Add(Me.textSearch)
        Me.Panel5.Controls.Add(Me.TextBox2)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(961, 164)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(374, 687)
        Me.Panel5.TabIndex = 2
        '
        'textSearch
        '
        Me.textSearch.Location = New System.Drawing.Point(27, 35)
        Me.textSearch.Multiline = True
        Me.textSearch.Name = "textSearch"
        Me.textSearch.Size = New System.Drawing.Size(303, 39)
        Me.textSearch.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.textSearch, " Search")
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox2.Location = New System.Drawing.Point(5, 11)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(360, 87)
        Me.TextBox2.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Info
        Me.Panel6.Controls.Add(Me.BtnExit)
        Me.Panel6.Controls.Add(Me.BtnPrintData)
        Me.Panel6.Controls.Add(Me.BtnDeleteData)
        Me.Panel6.Controls.Add(Me.BtnResetData)
        Me.Panel6.Controls.Add(Me.BtnUpdateData)
        Me.Panel6.Controls.Add(Me.BtnAddNewData)
        Me.Panel6.Location = New System.Drawing.Point(6, 107)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(359, 574)
        Me.Panel6.TabIndex = 1
        '
        'BtnExit
        '
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Tai Le", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(21, 468)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(303, 69)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "EXIT"
        Me.ToolTip1.SetToolTip(Me.BtnExit, "Exit")
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnPrintData
        '
        Me.BtnPrintData.Font = New System.Drawing.Font("Microsoft Tai Le", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintData.Location = New System.Drawing.Point(21, 378)
        Me.BtnPrintData.Name = "BtnPrintData"
        Me.BtnPrintData.Size = New System.Drawing.Size(303, 69)
        Me.BtnPrintData.TabIndex = 0
        Me.BtnPrintData.Text = "PRINT"
        Me.ToolTip1.SetToolTip(Me.BtnPrintData, "Print")
        Me.BtnPrintData.UseVisualStyleBackColor = True
        '
        'BtnDeleteData
        '
        Me.BtnDeleteData.Font = New System.Drawing.Font("Microsoft Tai Le", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteData.Location = New System.Drawing.Point(21, 199)
        Me.BtnDeleteData.Name = "BtnDeleteData"
        Me.BtnDeleteData.Size = New System.Drawing.Size(303, 69)
        Me.BtnDeleteData.TabIndex = 0
        Me.BtnDeleteData.Text = "DELETE"
        Me.ToolTip1.SetToolTip(Me.BtnDeleteData, "Delete")
        Me.BtnDeleteData.UseVisualStyleBackColor = True
        '
        'BtnResetData
        '
        Me.BtnResetData.Font = New System.Drawing.Font("Microsoft Tai Le", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResetData.Location = New System.Drawing.Point(21, 288)
        Me.BtnResetData.Name = "BtnResetData"
        Me.BtnResetData.Size = New System.Drawing.Size(303, 69)
        Me.BtnResetData.TabIndex = 0
        Me.BtnResetData.Text = "RESET"
        Me.ToolTip1.SetToolTip(Me.BtnResetData, "Reset")
        Me.BtnResetData.UseVisualStyleBackColor = True
        '
        'BtnUpdateData
        '
        Me.BtnUpdateData.Font = New System.Drawing.Font("Microsoft Tai Le", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateData.Location = New System.Drawing.Point(21, 107)
        Me.BtnUpdateData.Name = "BtnUpdateData"
        Me.BtnUpdateData.Size = New System.Drawing.Size(303, 69)
        Me.BtnUpdateData.TabIndex = 0
        Me.BtnUpdateData.Text = "UPDATE"
        Me.ToolTip1.SetToolTip(Me.BtnUpdateData, "Update")
        Me.BtnUpdateData.UseVisualStyleBackColor = True
        '
        'BtnAddNewData
        '
        Me.BtnAddNewData.Font = New System.Drawing.Font("Microsoft Tai Le", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddNewData.Location = New System.Drawing.Point(21, 16)
        Me.BtnAddNewData.Name = "BtnAddNewData"
        Me.BtnAddNewData.Size = New System.Drawing.Size(303, 69)
        Me.BtnAddNewData.TabIndex = 0
        Me.BtnAddNewData.Text = "ADD NEW STUDENT"
        Me.ToolTip1.SetToolTip(Me.BtnAddNewData, "Add New")
        Me.BtnAddNewData.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1343, 878)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPostCode As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents textSearch As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnPrintData As Button
    Friend WithEvents BtnDeleteData As Button
    Friend WithEvents BtnResetData As Button
    Friend WithEvents BtnUpdateData As Button
    Friend WithEvents BtnAddNewData As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
