﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSanPham
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
        Me.btnĐóng = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTrangThai = New System.Windows.Forms.TextBox()
        Me.txtNgayDang = New System.Windows.Forms.TextBox()
        Me.txtNoiDung = New System.Windows.Forms.TextBox()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaLSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnĐóng
        '
        Me.btnĐóng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnĐóng.Location = New System.Drawing.Point(384, 134)
        Me.btnĐóng.Name = "btnĐóng"
        Me.btnĐóng.Size = New System.Drawing.Size(75, 29)
        Me.btnĐóng.TabIndex = 58
        Me.btnĐóng.Text = "Đóng"
        Me.btnĐóng.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(157, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 25)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Quản Lý Sản Phẩm"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 182)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(528, 183)
        Me.DataGridView1.TabIndex = 57
        '
        'btnLuu
        '
        Me.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLuu.Location = New System.Drawing.Point(465, 93)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(75, 28)
        Me.btnLuu.TabIndex = 56
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnXoa.Location = New System.Drawing.Point(465, 54)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 33)
        Me.btnXoa.TabIndex = 54
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSua.Location = New System.Drawing.Point(384, 93)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 28)
        Me.btnSua.TabIndex = 55
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnThem.Location = New System.Drawing.Point(384, 54)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 32)
        Me.btnThem.TabIndex = 53
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(189, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Trạng Thái:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Ngày Đăng:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Tên SP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Nội Dung:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Mã LSP:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Mã SP:"
        '
        'txtTrangThai
        '
        Me.txtTrangThai.Location = New System.Drawing.Point(257, 99)
        Me.txtTrangThai.Name = "txtTrangThai"
        Me.txtTrangThai.Size = New System.Drawing.Size(100, 20)
        Me.txtTrangThai.TabIndex = 50
        '
        'txtNgayDang
        '
        Me.txtNgayDang.Location = New System.Drawing.Point(257, 62)
        Me.txtNgayDang.Name = "txtNgayDang"
        Me.txtNgayDang.Size = New System.Drawing.Size(100, 20)
        Me.txtNgayDang.TabIndex = 51
        '
        'txtNoiDung
        '
        Me.txtNoiDung.Location = New System.Drawing.Point(257, 131)
        Me.txtNoiDung.Name = "txtNoiDung"
        Me.txtNoiDung.Size = New System.Drawing.Size(100, 20)
        Me.txtNoiDung.TabIndex = 49
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(65, 92)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(100, 20)
        Me.txtTenSP.TabIndex = 48
        '
        'txtMaLSP
        '
        Me.txtMaLSP.Location = New System.Drawing.Point(65, 131)
        Me.txtMaLSP.Name = "txtMaLSP"
        Me.txtMaLSP.Size = New System.Drawing.Size(100, 20)
        Me.txtMaLSP.TabIndex = 41
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(65, 59)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(100, 20)
        Me.txtMaSP.TabIndex = 40
        '
        'FrmSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 377)
        Me.Controls.Add(Me.btnĐóng)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTrangThai)
        Me.Controls.Add(Me.txtNgayDang)
        Me.Controls.Add(Me.txtNoiDung)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.txtMaLSP)
        Me.Controls.Add(Me.txtMaSP)
        Me.Name = "FrmSanPham"
        Me.Text = "Bảng Sản Phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnĐóng As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnLuu As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTrangThai As System.Windows.Forms.TextBox
    Friend WithEvents txtNgayDang As System.Windows.Forms.TextBox
    Friend WithEvents txtNoiDung As System.Windows.Forms.TextBox
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaLSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox

End Class
