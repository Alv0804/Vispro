<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblJudulForm = New Label()
        txtKodeBuku = New TextBox()
        txtJudul = New TextBox()
        cboKategori = New ComboBox()
        txtNamaPeminjam = New TextBox()
        txtLamaPinjam = New TextBox()
        btnPinjam = New Button()
        btnBersihkan = New Button()
        lstPeminjaman = New ListBox()
        btnEkspor = New Button()
        lblBuku = New Label()
        errPinjam = New ErrorProvider(components)
        lblJudul = New Label()
        lblKategori = New Label()
        lblNamaPeminjam = New Label()
        lblLamaPinjam = New Label()
        lblStatus = New Label()
        CType(errPinjam, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudulForm
        ' 
        lblJudulForm.AutoSize = True
        lblJudulForm.Location = New Point(30, 9)
        lblJudulForm.Name = "lblJudulForm"
        lblJudulForm.Size = New Size(152, 25)
        lblJudulForm.TabIndex = 0
        lblJudulForm.Text = "Peminjaman Buku"
        ' 
        ' txtKodeBuku
        ' 
        txtKodeBuku.Location = New Point(35, 64)
        txtKodeBuku.Name = "txtKodeBuku"
        txtKodeBuku.Size = New Size(300, 31)
        txtKodeBuku.TabIndex = 1
        ' 
        ' txtJudul
        ' 
        txtJudul.Location = New Point(34, 126)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(300, 31)
        txtJudul.TabIndex = 2
        ' 
        ' cboKategori
        ' 
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        cboKategori.Location = New Point(36, 184)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(299, 33)
        cboKategori.TabIndex = 3
        ' 
        ' txtNamaPeminjam
        ' 
        txtNamaPeminjam.Location = New Point(36, 248)
        txtNamaPeminjam.Name = "txtNamaPeminjam"
        txtNamaPeminjam.Size = New Size(300, 31)
        txtNamaPeminjam.TabIndex = 4
        ' 
        ' txtLamaPinjam
        ' 
        txtLamaPinjam.Location = New Point(36, 308)
        txtLamaPinjam.Name = "txtLamaPinjam"
        txtLamaPinjam.Size = New Size(300, 31)
        txtLamaPinjam.TabIndex = 5
        ' 
        ' btnPinjam
        ' 
        btnPinjam.Location = New Point(39, 362)
        btnPinjam.Name = "btnPinjam"
        btnPinjam.Size = New Size(233, 34)
        btnPinjam.TabIndex = 6
        btnPinjam.Text = "Mencatat peminjaman"
        btnPinjam.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Location = New Point(300, 362)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(254, 34)
        btnBersihkan.TabIndex = 7
        btnBersihkan.Text = "Mengosongkan form"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lstPeminjaman
        ' 
        lstPeminjaman.FormattingEnabled = True
        lstPeminjaman.Location = New Point(369, 19)
        lstPeminjaman.Name = "lstPeminjaman"
        lstPeminjaman.Size = New Size(419, 329)
        lstPeminjaman.TabIndex = 8
        ' 
        ' btnEkspor
        ' 
        btnEkspor.Location = New Point(582, 362)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(112, 34)
        btnEkspor.TabIndex = 9
        btnEkspor.Text = "Ekspor"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' lblBuku
        ' 
        lblBuku.AutoSize = True
        lblBuku.Location = New Point(36, 36)
        lblBuku.Name = "lblBuku"
        lblBuku.Size = New Size(98, 25)
        lblBuku.TabIndex = 10
        lblBuku.Text = "Kode buku"
        ' 
        ' errPinjam
        ' 
        errPinjam.ContainerControl = Me
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Location = New Point(35, 98)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(98, 25)
        lblJudul.TabIndex = 11
        lblJudul.Text = "Judul buku"
        ' 
        ' lblKategori
        ' 
        lblKategori.AutoSize = True
        lblKategori.Location = New Point(35, 156)
        lblKategori.Name = "lblKategori"
        lblKategori.Size = New Size(78, 25)
        lblKategori.TabIndex = 12
        lblKategori.Text = "Kategori"
        ' 
        ' lblNamaPeminjam
        ' 
        lblNamaPeminjam.AutoSize = True
        lblNamaPeminjam.Location = New Point(35, 220)
        lblNamaPeminjam.Name = "lblNamaPeminjam"
        lblNamaPeminjam.Size = New Size(141, 25)
        lblNamaPeminjam.TabIndex = 13
        lblNamaPeminjam.Text = "Nama Peminjam"
        ' 
        ' lblLamaPinjam
        ' 
        lblLamaPinjam.AutoSize = True
        lblLamaPinjam.Location = New Point(39, 282)
        lblLamaPinjam.Name = "lblLamaPinjam"
        lblLamaPinjam.Size = New Size(112, 25)
        lblLamaPinjam.TabIndex = 14
        lblLamaPinjam.Text = "Lama Pinjam"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(30, 399)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(256, 25)
        lblStatus.TabIndex = 15
        lblStatus.Text = "Status dan jumlah peminjaman"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        ClientSize = New Size(800, 450)
        Controls.Add(lblStatus)
        Controls.Add(lblLamaPinjam)
        Controls.Add(lblNamaPeminjam)
        Controls.Add(lblKategori)
        Controls.Add(lblJudul)
        Controls.Add(lblBuku)
        Controls.Add(btnEkspor)
        Controls.Add(lstPeminjaman)
        Controls.Add(btnBersihkan)
        Controls.Add(btnPinjam)
        Controls.Add(txtLamaPinjam)
        Controls.Add(txtNamaPeminjam)
        Controls.Add(cboKategori)
        Controls.Add(txtJudul)
        Controls.Add(txtKodeBuku)
        Controls.Add(lblJudulForm)
        Name = "Form1"
        Text = "Peminjaman Buku"
        CType(errPinjam, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudulForm As Label
    Friend WithEvents txtKodeBuku As TextBox
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents txtNamaPeminjam As TextBox
    Friend WithEvents txtLamaPinjam As TextBox
    Friend WithEvents btnPinjam As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lstPeminjaman As ListBox
    Friend WithEvents btnEkspor As Button
    Friend WithEvents lblBuku As Label
    Friend WithEvents errPinjam As ErrorProvider
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblLamaPinjam As Label
    Friend WithEvents lblNamaPeminjam As Label
    Friend WithEvents lblKategori As Label
    Friend WithEvents lblJudul As Label

End Class
