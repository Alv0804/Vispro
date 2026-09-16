<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArray
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
        btnTampil = New Button()
        lblPanjang = New Label()
        lblLebar = New Label()
        txtPanjang = New TextBox()
        TxtLebar = New TextBox()
        lstNilai = New ListBox()
        SuspendLayout()
        ' 
        ' btnTampil
        ' 
        btnTampil.Location = New Point(313, 205)
        btnTampil.Name = "btnTampil"
        btnTampil.Size = New Size(112, 34)
        btnTampil.TabIndex = 0
        btnTampil.Text = "Tampilkan"
        btnTampil.UseVisualStyleBackColor = True
        ' 
        ' lblPanjang
        ' 
        lblPanjang.AutoSize = True
        lblPanjang.Location = New Point(294, 31)
        lblPanjang.Name = "lblPanjang"
        lblPanjang.Size = New Size(74, 25)
        lblPanjang.TabIndex = 2
        lblPanjang.Text = "Panjang"
        ' 
        ' lblLebar
        ' 
        lblLebar.AutoSize = True
        lblLebar.Location = New Point(294, 119)
        lblLebar.Name = "lblLebar"
        lblLebar.Size = New Size(55, 25)
        lblLebar.TabIndex = 3
        lblLebar.Text = "Lebar"
        ' 
        ' txtPanjang
        ' 
        txtPanjang.Location = New Point(294, 59)
        txtPanjang.Name = "txtPanjang"
        txtPanjang.Size = New Size(150, 31)
        txtPanjang.TabIndex = 4
        ' 
        ' TxtLebar
        ' 
        TxtLebar.Location = New Point(294, 147)
        TxtLebar.Name = "TxtLebar"
        TxtLebar.Size = New Size(150, 31)
        TxtLebar.TabIndex = 5
        ' 
        ' lstNilai
        ' 
        lstNilai.FormattingEnabled = True
        lstNilai.Location = New Point(281, 264)
        lstNilai.Name = "lstNilai"
        lstNilai.Size = New Size(180, 129)
        lstNilai.TabIndex = 6
        ' 
        ' FrmArray
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstNilai)
        Controls.Add(TxtLebar)
        Controls.Add(txtPanjang)
        Controls.Add(lblLebar)
        Controls.Add(lblPanjang)
        Controls.Add(btnTampil)
        Name = "FrmArray"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents lblPanjang As Label
    Friend WithEvents lblLebar As Label
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents TxtLebar As TextBox
    Friend WithEvents lstNilai As ListBox

End Class
