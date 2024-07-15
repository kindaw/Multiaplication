Public Class Form1
    Dim setter, multi, resalt As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 12
            setter = 15
            multi = i + 5
            resalt = setter * multi
            MessageBox.Show(setter & "X" & multi & "=" & resalt)
        Next
    End Sub
End Class
