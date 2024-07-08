Public Class FormHasil
    Private _username As String
    Private _location As String
    Private _gate As String

    ' Konstruktor menerima informasi username, lokasi, dan gerbang dari FormGate
    Public Sub New(username As String, location As String, gate As String)
        InitializeComponent()
        _username = username
        _location = location
        _gate = gate

        ' Menampilkan informasi di label-label
        LabelUser.Text = _username
        LabelLokasi.Text = _location
        LabelGate.Text = _gate
    End Sub
End Class