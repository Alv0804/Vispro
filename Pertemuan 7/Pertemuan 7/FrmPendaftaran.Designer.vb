<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPendaftaran
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
        components = New ComponentModel.Container()
        lblJudul = New Label()
        lblNim = New Label()
        txtNim = New TextBox()
        lblNama = New Label()
        lblJurusan = New Label()
        txtNama = New TextBox()
        cboJurusan = New ComboBox()
        txtAngkatan = New TextBox()
        lblAngkatan = New Label()
        txtIpk = New TextBox()
        lblIpk = New Label()
        btnSimpan = New Button()
        btnBersihkan = New Button()
        lblDaftar = New Label()
        lblStatus = New Label()
        btnEkspor = New Button()
        lstMahasiswa = New ListBox()
        errInput = New ErrorProvider(components)
        CType(errInput, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.Location = New Point(12, 9)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(329, 38)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Pendaftaran Mahasiswa"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(22, 68)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(46, 25)
        lblNim.TabIndex = 1
        lblNim.Text = "NIM"
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(120, 68)
        txtNim.MaxLength = 9
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(230, 31)
        txtNim.TabIndex = 2
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(22, 122)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(59, 25)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(22, 172)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(71, 25)
        lblJurusan.TabIndex = 4
        lblJurusan.Text = "Jurusan"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(120, 119)
        txtNama.MaxLength = 100
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(230, 31)
        txtNama.TabIndex = 5
        ' 
        ' cboJurusan
        ' 
        cboJurusan.DropDownStyle = ComboBoxStyle.DropDownList
        cboJurusan.FormattingEnabled = True
        cboJurusan.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi", "Manajemen Informatika", "Teknik Komputer"})
        cboJurusan.Location = New Point(120, 167)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New Size(230, 33)
        cboJurusan.TabIndex = 6
        ' 
        ' txtAngkatan
        ' 
        txtAngkatan.Location = New Point(120, 215)
        txtAngkatan.MaxLength = 4
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(230, 31)
        txtAngkatan.TabIndex = 8
        ' 
        ' lblAngkatan
        ' 
        lblAngkatan.AutoSize = True
        lblAngkatan.Location = New Point(22, 218)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New Size(88, 25)
        lblAngkatan.TabIndex = 7
        lblAngkatan.Text = "Angkatan"
        ' 
        ' txtIpk
        ' 
        txtIpk.Location = New Point(120, 263)
        txtIpk.MaxLength = 4
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(230, 31)
        txtIpk.TabIndex = 10
        ' 
        ' lblIpk
        ' 
        lblIpk.AutoSize = True
        lblIpk.Location = New Point(22, 266)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New Size(37, 25)
        lblIpk.TabIndex = 9
        lblIpk.Text = "IPK"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(120, 314)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(238, 314)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(112, 34)
        btnBersihkan.TabIndex = 12
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Location = New Point(423, 47)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(133, 25)
        lblDaftar.TabIndex = 13
        lblDaftar.Text = "Data tersimpan"
        ' 
        ' lblStatus
        ' 
        lblStatus.Location = New Point(22, 380)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(713, 25)
        lblStatus.TabIndex = 14
        lblStatus.Text = "Siap."
        ' 
        ' btnEkspor
        ' 
        btnEkspor.CausesValidation = False
        btnEkspor.Location = New Point(423, 343)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(112, 34)
        btnEkspor.TabIndex = 15
        btnEkspor.Text = "Ekspor ke CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' lstMahasiswa
        ' 
        lstMahasiswa.FormattingEnabled = True
        lstMahasiswa.HorizontalScrollbar = True
        lstMahasiswa.IntegralHeight = False
        lstMahasiswa.Location = New Point(423, 75)
        lstMahasiswa.Name = "lstMahasiswa"
        lstMahasiswa.Size = New Size(312, 262)
        lstMahasiswa.TabIndex = 16
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' FrmPendaftaran
        ' 
        AcceptButton = btnSimpan
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(758, 414)
        Controls.Add(lstMahasiswa)
        Controls.Add(btnEkspor)
        Controls.Add(lblStatus)
        Controls.Add(lblDaftar)
        Controls.Add(btnBersihkan)
        Controls.Add(btnSimpan)
        Controls.Add(txtIpk)
        Controls.Add(lblIpk)
        Controls.Add(txtAngkatan)
        Controls.Add(lblAngkatan)
        Controls.Add(cboJurusan)
        Controls.Add(txtNama)
        Controls.Add(lblJurusan)
        Controls.Add(lblNama)
        Controls.Add(txtNim)
        Controls.Add(lblNim)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmPendaftaran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pendaftaran Mahasiswa"
        CType(errInput, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cboJurusan As ComboBox
    Friend WithEvents txtAngkatan As TextBox
    Friend WithEvents lblAngkatan As Label
    Friend WithEvents txtIpk As TextBox
    Friend WithEvents lblIpk As Label
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lblDaftar As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnEkspor As Button
    Friend WithEvents lstMahasiswa As ListBox
    Friend WithEvents errInput As ErrorProvider
End Class
