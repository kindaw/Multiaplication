Imports System.Net

Public Class Form1

    Private Sub btb_cal_Click(sender As Object, e As EventArgs) Handles btb_cal.Click
        Dim setter, multi, resalt, start, endpoint As Integer
        Dim msmulti As String
        msmulti = String.Empty
        setter = Val(txt_setter.Text)
        start = Val(txt_start.Text)
        endpoint = Val(txt_endpoint.Text)
        For multi = start To endpoint Step 1
            resalt = setter * multi
            Console.WriteLine(setter & "X" & multi & "=" & resalt)
            msmulti &= (setter & "X" & multi & "=" & resalt & vbNewLine)
        Next
        MessageBox.Show(msmulti)
    End Sub
End Class
