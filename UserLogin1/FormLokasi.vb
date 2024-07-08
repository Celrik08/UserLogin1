Public Class FormLokasi
    Private _username As String

    ' Konstruktor menerima informasi username dari Form1
    Public Sub New(username As String)
        InitializeComponent()
        _username = username
    End Sub

    ' Pilihan lokasi berubah pada ComboBox
    Private Sub ComboMall_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboMall.SelectedIndexChanged
        Dim selectedLocation As String = ComboMall.SelectedItem.ToString()
        ' Buka FormGate dengan informasi username dan lokasi
        Dim formGate As New FormGate(_username, selectedLocation)
        formGate.Show()
        Me.Hide()
    End Sub
End Class