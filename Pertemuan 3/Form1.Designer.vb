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
        txtNilai = New TextBox()
        btnInput = New Button()
        pctImage = New PictureBox()
        CType(pctImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNilai
        ' 
        txtNilai.Location = New Point(304, 189)
        txtNilai.Name = "txtNilai"
        txtNilai.Size = New Size(150, 31)
        txtNilai.TabIndex = 0
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(326, 240)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(112, 32)
        btnInput.TabIndex = 1
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' pctImage
        ' 
        pctImage.Location = New Point(326, 66)
        pctImage.Name = "pctImage"
        pctImage.Size = New Size(100, 100)
        pctImage.SizeMode = PictureBoxSizeMode.Zoom
        pctImage.TabIndex = 2
        pctImage.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pctImage)
        Controls.Add(btnInput)
        Controls.Add(txtNilai)
        Name = "Form1"
        Text = "Form1"
        CType(pctImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNilai As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents pctImage As PictureBox

End Class
