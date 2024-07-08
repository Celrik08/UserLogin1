Public Class FormGate
    Private _username As String
    Private _location As String

    ' Konstruktor menerima informasi username dan lokasi dari FormLokasi
    Public Sub New(username As String, location As String)
        InitializeComponent()
        _username = username
        _location = location
    End Sub

    ' Pilihan gerbang berubah pada ComboBox
    Private Sub ComboGate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboGate.SelectedIndexChanged
        Dim selectedGate As String = ComboGate.SelectedItem.ToString()
        ' Buka FormHasil dengan informasi username, lokasi, dan gerbang
        Dim formHasil As New FormHasil(_username, _location, selectedGate)
        formHasil.Show()
        Me.Hide()
    End Sub
End Class