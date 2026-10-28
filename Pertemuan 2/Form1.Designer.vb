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
        lblNama = New Label()
        txtNama = New TextBox()
        lblNim = New Label()
        txtNim = New TextBox()
        lblKom = New Label()
        txtKom = New TextBox()
        btnTampilkan = New Button()
        txtHapus = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(38, 30)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(68, 25)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(108, 27)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(190, 31)
        txtNama.TabIndex = 1
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(38, 74)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(69, 25)
        lblNim.TabIndex = 2
        lblNim.Text = "Nim    :"
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(108, 71)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(190, 31)
        txtNim.TabIndex = 3
        ' 
        ' lblKom
        ' 
        lblKom.AutoSize = True
        lblKom.Location = New Point(38, 120)
        lblKom.Name = "lblKom"
        lblKom.Size = New Size(58, 25)
        lblKom.TabIndex = 4
        lblKom.Text = "Kom :"
        ' 
        ' txtKom
        ' 
        txtKom.Location = New Point(108, 117)
        txtKom.Name = "txtKom"
        txtKom.Size = New Size(190, 31)
        txtKom.TabIndex = 5
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.Location = New Point(38, 166)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(112, 34)
        btnTampilkan.TabIndex = 6
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' txtHapus
        ' 
        txtHapus.Location = New Point(172, 166)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(112, 34)
        txtHapus.TabIndex = 7
        txtHapus.Text = "Hapus"
        txtHapus.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(108, 220)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 34)
        btnKeluar.TabIndex = 8
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(txtHapus)
        Controls.Add(btnTampilkan)
        Controls.Add(txtKom)
        Controls.Add(lblKom)
        Controls.Add(txtNim)
        Controls.Add(lblNim)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Name = "Form1"
        Text = "Profil Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNim As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblKom As Label
    Friend WithEvents txtKom As TextBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents txtHapus As Button
    Friend WithEvents btnKeluar As Button

End Class
