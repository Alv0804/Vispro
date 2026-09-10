<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        picImage = New PictureBox()
        cmbRole = New ComboBox()
        lblRole = New Label()
        lblName = New Label()
        txtNama = New TextBox()
        lblNIM = New Label()
        txtNIM = New TextBox()
        btnLogin = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(317, 12)
        picImage.Name = "picImage"
        picImage.Size = New Size(150, 150)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Manager", "Staff"})
        cmbRole.Location = New Point(285, 200)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(204, 33)
        cmbRole.TabIndex = 1
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(285, 172)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(46, 25)
        lblRole.TabIndex = 2
        lblRole.Text = "Role"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(285, 236)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 25)
        lblName.TabIndex = 3
        lblName.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(285, 259)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(204, 31)
        txtNama.TabIndex = 4
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(285, 296)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(45, 25)
        lblNIM.TabIndex = 5
        lblNIM.Text = "Nim"
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(285, 324)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(204, 31)
        txtNIM.TabIndex = 6
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(333, 379)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(txtNIM)
        Controls.Add(lblNIM)
        Controls.Add(txtNama)
        Controls.Add(lblName)
        Controls.Add(lblRole)
        Controls.Add(cmbRole)
        Controls.Add(picImage)
        Name = "FrmLogin"
        Text = "Login"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNIM As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents btnLogin As Button

End Class
