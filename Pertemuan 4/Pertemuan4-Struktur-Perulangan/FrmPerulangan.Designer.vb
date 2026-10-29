<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPerulangan
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
        lblNilaiAwal = New Label()
        lblNilaiAkhir = New Label()
        txtNilaiAwal = New TextBox()
        txtNilaiAkhir = New TextBox()
        lstHasil = New ListBox()
        btnInput = New Button()
        SuspendLayout()
        ' 
        ' lblNilaiAwal
        ' 
        lblNilaiAwal.AutoSize = True
        lblNilaiAwal.Location = New Point(294, 110)
        lblNilaiAwal.Margin = New Padding(4, 0, 4, 0)
        lblNilaiAwal.Name = "lblNilaiAwal"
        lblNilaiAwal.Size = New Size(98, 25)
        lblNilaiAwal.TabIndex = 0
        lblNilaiAwal.Text = "Nilai Awal :"
        ' 
        ' lblNilaiAkhir
        ' 
        lblNilaiAkhir.AutoSize = True
        lblNilaiAkhir.Location = New Point(292, 161)
        lblNilaiAkhir.Margin = New Padding(4, 0, 4, 0)
        lblNilaiAkhir.Name = "lblNilaiAkhir"
        lblNilaiAkhir.Size = New Size(101, 25)
        lblNilaiAkhir.TabIndex = 1
        lblNilaiAkhir.Text = "Nilai Akhir :"
        ' 
        ' txtNilaiAwal
        ' 
        txtNilaiAwal.Location = New Point(418, 106)
        txtNilaiAwal.Margin = New Padding(4, 4, 4, 4)
        txtNilaiAwal.Name = "txtNilaiAwal"
        txtNilaiAwal.Size = New Size(155, 31)
        txtNilaiAwal.TabIndex = 2
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.Location = New Point(418, 157)
        txtNilaiAkhir.Margin = New Padding(4, 4, 4, 4)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.Size = New Size(155, 31)
        txtNilaiAkhir.TabIndex = 3
        ' 
        ' lstHasil
        ' 
        lstHasil.FormattingEnabled = True
        lstHasil.Location = New Point(382, 262)
        lstHasil.Margin = New Padding(4, 4, 4, 4)
        lstHasil.Name = "lstHasil"
        lstHasil.Size = New Size(213, 154)
        lstHasil.TabIndex = 4
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(433, 219)
        btnInput.Margin = New Padding(4, 4, 4, 4)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(118, 36)
        btnInput.TabIndex = 5
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' FrmPerulangan
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 562)
        Controls.Add(btnInput)
        Controls.Add(lstHasil)
        Controls.Add(txtNilaiAkhir)
        Controls.Add(txtNilaiAwal)
        Controls.Add(lblNilaiAkhir)
        Controls.Add(lblNilaiAwal)
        Margin = New Padding(4, 4, 4, 4)
        Name = "FrmPerulangan"
        Text = "Perulangan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNilaiAwal As Label
    Friend WithEvents lblNilaiAkhir As Label
    Friend WithEvents txtNilaiAwal As TextBox
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents lstHasil As ListBox
    Friend WithEvents btnInput As Button

End Class
