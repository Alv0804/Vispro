Public Class FrmPajak
    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
    Dim pendapatan As Double
    Dim persentasePajak As Double

    If Not Double.TryParse(txtPendapatan.Text, pendapatan) Then
            MessageBox.Show("Masukkan pendapatan dalam bentuk angka yang valid.")
            txtPendapatan.Focus()
        Return
    End If

    If pendapatan <= 5000000 Then
        persentasePajak = 0
    ElseIf pendapatan <= 30000000 Then
        persentasePajak = 0.1
    ElseIf pendapatan <= 100000000 Then
        persentasePajak = 0.2
    Else
        persentasePajak = 0.3
    End If

    Dim totalPajak As Double = pendapatan * persentasePajak

    MessageBox.Show("Pajak yang harus dibayar: Rp " & FormatNumber(totalPajak, 0))
End Sub

Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
    Me.Close()
    FrmLogin.Show()
End Sub

Private Sub FrmPajak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

End Sub

Private Sub txtPendapatan_TextChanged(sender As Object, e As EventArgs) Handles txtPendapatan.TextChanged

End Sub
End Class