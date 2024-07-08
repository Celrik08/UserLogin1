<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        LabelUser = New Label()
        Label3 = New Label()
        LabelLokasi = New Label()
        Label5 = New Label()
        LabelGate = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 19)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 20)
        Label1.TabIndex = 0
        Label1.Text = "Selamat Datang"
        ' 
        ' LabelUser
        ' 
        LabelUser.AutoSize = True
        LabelUser.Location = New Point(143, 19)
        LabelUser.Margin = New Padding(4, 0, 4, 0)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(99, 20)
        LabelUser.TabIndex = 1
        LabelUser.Text = "__________"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 63)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 20)
        Label3.TabIndex = 2
        Label3.Text = "anda berada di lokasi"
        ' 
        ' LabelLokasi
        ' 
        LabelLokasi.AutoSize = True
        LabelLokasi.Location = New Point(181, 63)
        LabelLokasi.Margin = New Padding(4, 0, 4, 0)
        LabelLokasi.Name = "LabelLokasi"
        LabelLokasi.Size = New Size(99, 20)
        LabelLokasi.TabIndex = 3
        LabelLokasi.Text = "__________"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 107)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 20)
        Label5.TabIndex = 4
        Label5.Text = "anda di tugaskan di"
        ' 
        ' LabelGate
        ' 
        LabelGate.AutoSize = True
        LabelGate.Location = New Point(168, 107)
        LabelGate.Margin = New Padding(4, 0, 4, 0)
        LabelGate.Name = "LabelGate"
        LabelGate.Size = New Size(99, 20)
        LabelGate.TabIndex = 5
        LabelGate.Text = "__________"
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(353, 173)
        Controls.Add(LabelGate)
        Controls.Add(Label5)
        Controls.Add(LabelLokasi)
        Controls.Add(Label3)
        Controls.Add(LabelUser)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormHasil"
        Text = "FormHasil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelLokasi As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelGate As Label
End Class
