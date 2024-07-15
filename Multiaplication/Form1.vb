Public Class Form1
    Dim setter, multi, resalt As Integer
    Dim msmulti As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For multi = 1 To 12
            setter = 15
            resalt = setter * multi
            msmulti &= (setter & "X" & multi & "=" & resalt & vbNewLine)
        Next
        MessageBox.Show(msmulti)
    End Sub
End Class
