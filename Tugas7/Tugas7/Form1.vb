Option Strict On

Imports System.IO

Public Class Form1
    Private listKodeBukuDipinjam As New List(Of String)
    Private jumlahPeminjaman As Integer = 0

    Private Function ValidasiInput() As Boolean
        errPinjam.Clear()
        Dim isValid As Boolean = True

        Dim kodeBuku As String = txtKodeBuku.Text.ToUpper().Trim()
        If Not ModuleValidasi.KodeBukuValid(kodeBuku) Then
            errPinjam.SetError(txtKodeBuku, "Format: BK diikuti 4 digit (contoh: BK0012)")
            isValid = False
        End If

        If isValid AndAlso listKodeBukuDipinjam.Contains(kodeBuku) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
            isValid = False
        End If

        If txtJudul.Text.Trim() = "" Then
            errPinjam.SetError(txtJudul, "Judul buku harus diisi.")
            isValid = False
        End If

        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori, "Kategori harus dipilih.")
            isValid = False
        End If

        Dim namaPeminjam As String = txtNamaPeminjam.Text.Trim()
        If namaPeminjam.Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam, "Nama peminjam minimal 3 karakter.")
            isValid = False
        End If

        Dim lamaPinjam As Integer
        If Not Integer.TryParse(txtLamaPinjam.Text, lamaPinjam) OrElse lamaPinjam < 1 OrElse lamaPinjam > 14 Then
            errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus bilangan 1-14 hari.")
            isValid = False
        End If

        Return isValid
    End Function

    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If ValidasiInput() Then
            Dim kodeBuku As String = txtKodeBuku.Text.ToUpper().Trim()
            Dim judul As String = txtJudul.Text.Trim()
            Dim kategori As String = cboKategori.SelectedItem.ToString()
            Dim namaPeminjam As String = txtNamaPeminjam.Text.Trim()
            Dim lamaPinjam As Integer = Integer.Parse(txtLamaPinjam.Text)

            Dim tanggalKembali As Date = Date.Today.AddDays(lamaPinjam)
            Dim tanggalKembaliStr As String = tanggalKembali.ToString("dd/MM/yyyy")

            Dim entry As String = String.Format("{0} | {1} | {2} | {3} | {4} hari | kembali {5}",
                                                  kodeBuku, judul, kategori, namaPeminjam, lamaPinjam, tanggalKembaliStr)

            lstPeminjaman.Items.Add(entry)
            listKodeBukuDipinjam.Add(kodeBuku)
            jumlahPeminjaman += 1
            lblStatus.Text = String.Format("Jumlah peminjaman: {0}", jumlahPeminjaman)

            BersihkanForm()
        End If
    End Sub

    Private Sub BersihkanForm()
        txtKodeBuku.Text = ""
        txtJudul.Text = ""
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Text = ""
        txtLamaPinjam.Text = ""
        errPinjam.Clear()
        txtKodeBuku.Focus()
    End Sub

    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
    End Sub

    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        If lstPeminjaman.Items.Count = 0 Then
            MsgBox("Daftar peminjaman masih kosong. Tidak ada data untuk diekspor.", MsgBoxStyle.Information, "Ekspor Gagal")
            Return
        End If

        Dim filePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "peminjaman.csv")
        Dim sw As StreamWriter = Nothing

        Try
            sw = New StreamWriter(filePath, False, System.Text.Encoding.UTF8)

            sw.WriteLine("Kode Buku;Judul;Kategori;Nama Peminjam;Lama Pinjam;Tanggal Kembali")

            For Each item As String In lstPeminjaman.Items
                Dim parts() As String = item.Split("|"c)
                If parts.Length = 6 Then
                    Dim kodeBuku As String = parts(0).Trim()
                    Dim judul As String = parts(1).Trim()
                    Dim kategori As String = parts(2).Trim()
                    Dim namaPeminjam As String = parts(3).Trim()
                    Dim lamaPinjam As String = parts(4).Trim()
                    Dim tanggalKembaliFull As String = parts(5).Trim()
                    Dim tanggalKembali As String = tanggalKembaliFull.Replace("kembali ", "").Trim()

                    sw.WriteLine(String.Format("{0};{1};{2};{3};{4};{5}",
                                                kodeBuku, judul, kategori, namaPeminjam, lamaPinjam, tanggalKembali))
                End If
            Next

            MsgBox("File berhasil disimpan ke: " & filePath, MsgBoxStyle.Information, "Ekspor Berhasil")

        Catch ex As IOException
            MsgBox("Gagal menyimpan file. File mungkin sedang dibuka di aplikasi lain. Silakan tutup file terlebih dahulu dan coba lagi.",
                   MsgBoxStyle.Exclamation, "Error: File Sedang Digunakan")

        Catch ex As UnauthorizedAccessException
            MsgBox("Gagal menyimpan file. Anda tidak memiliki izin untuk menulis ke lokasi Documents. Silakan periksa izin akses folder Anda.",
                   MsgBoxStyle.Exclamation, "Error: Akses Ditolak")

        Finally
            If sw IsNot Nothing Then
                sw.Close()
                sw.Dispose()
            End If
        End Try
    End Sub

    Private Sub txtKodeBuku_Validating(sender As Object, e As ComponentModel.CancelEventArgs) Handles txtKodeBuku.Validating
        Dim kodeBuku As String = txtKodeBuku.Text.ToUpper().Trim()

        If kodeBuku <> "" Then
            If Not ModuleValidasi.KodeBukuValid(kodeBuku) Then
                errPinjam.SetError(txtKodeBuku, "Format: BK diikuti 4 digit (contoh: BK0012)")
            Else
                errPinjam.SetError(txtKodeBuku, "")
            End If
        Else
            errPinjam.SetError(txtKodeBuku, "")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblNamaPeminjam_Click(sender As Object, e As EventArgs) Handles lblNamaPeminjam.Click

    End Sub
End Class
