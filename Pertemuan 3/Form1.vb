Public Class Form1
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim nilaiUjian As Integer

        If Not Integer.TryParse(txtNilai.Text, nilaiUjian) Then
            MessageBox.Show("Masukkan nilai ujian yang valid.")
            txtNilai.Focus()
            Return
        End If

        If nilaiUjian < 0 OrElse nilaiUjian > 100 Then
            MessageBox.Show("Masukan nilai 0-100")
            txtNilai.Focus()
            Return
        End If

        If nilaiUjian <= 50 Then
            pctImage.Image = Image.FromFile("Assets\1.png")
        ElseIf nilaiUjian <= 80 Then
            pctImage.Image = Image.FromFile("Assets\2.png")
        Else
            pctImage.Image = Image.FromFile("Assets\3.png")
        End If
    End Sub

    Private Sub txtNilai_TextChanged(sender As Object, e As EventArgs) Handles txtNilai.TextChanged

    End Sub

    Private Sub txtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNilai.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub pctImage_Click(sender As Object, e As EventArgs) Handles pctImage.Click

    End Sub
End Class
