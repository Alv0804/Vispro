Public Class FrmLogin
    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.Text = "Manager" Then
            picImage.Image = Image.FromFile("Assets\maneger.jpg")
        ElseIf cmbRole.Text = "Staff" Then
            picImage.Image = Image.FromFile("Assets\staff.jpg")
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim role As String = cmbRole.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNIM.Text.Trim()

        If String.Equals(role, "Staff", StringComparison.OrdinalIgnoreCase) AndAlso
           String.Equals(nama, "staff", StringComparison.OrdinalIgnoreCase) AndAlso
           nim = "241712000" Then

            MessageBox.Show("Login berhasil")
            txtNama.Clear()
            txtNIM.Clear()
            Me.Hide()
            FrmPajak.Show()

        ElseIf String.Equals(role, "Manager", StringComparison.OrdinalIgnoreCase) AndAlso
               String.Equals(nama, "alvin", StringComparison.OrdinalIgnoreCase) AndAlso
               nim = "241712075" Then

            MessageBox.Show("Login berhasil")
            txtNama.Clear()
            txtNIM.Clear()
            Me.Hide()
            FrmPajak.Show()

        Else
            MessageBox.Show("Wrong credentials. Role='" & role & "', Name='" & nama & "', NIM='" & nim & "'",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning)
            txtNIM.Focus()
        End If
    End Sub

    Private Sub lblNim_Click(sender As Object, e As EventArgs) Handles lblNIM.Click

    End Sub
End Class