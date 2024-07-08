Public Class Form1
    ' Ketika tombol Enter ditekan pada TextBox User
    Private Sub TextUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextUser.KeyPress
        If e.KeyChar = Chr(13) Then
            TextPassword.Focus()  ' Alihkan fokus ke TextBox Password
            e.Handled = True
        End If
    End Sub

    ' Tombol Login ditekan
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        PerformLogin()  ' Panggil fungsi untuk melakukan login
    End Sub

    ' Ketika tombol Enter ditekan pada TextBox Password
    Private Sub TextPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            PerformLogin()  ' Panggil fungsi untuk melakukan login
        End If
    End Sub

    ' Fungsi untuk melakukan login
    Private Sub PerformLogin()
        Dim username As String = TextUser.Text.ToLower()
        Dim password As String = TextPassword.Text

        If CheckCredentials(username, password) Then
            ' Tampilkan pesan login berhasil
            MessageBox.Show("Login Berhasil.", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Buka FormLokasi dengan informasi username
            Dim formLokasi As New FormLokasi(username)
            formLokasi.Show()
            Me.Hide()
        Else
            ' Tampilkan pesan kesalahan jika login gagal
            MessageBox.Show("Login Gagal. Username atau Password salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextUser.Text = ""
            TextPassword.Text = ""
        End If
    End Sub

    ' Fungsi untuk memeriksa kredensial pengguna
    Private Function CheckCredentials(username As String, password As String) As Boolean
        Select Case username
            Case "admin"
                Return password = "12345"
            Case "petugas1"
                Return password = "udin02"
            Case "management"
                Return password = "management01"
            Case Else
                Return False
        End Select
    End Function
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextPassword.PasswordChar = "*"
    End Sub
End Class