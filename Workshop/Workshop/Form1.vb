Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rand As Random = New Random
        Dim numlist As String = ""
        Dim number(9) As Integer
        For x = 0 To UBound(number)
            number(x) = rand.Next(0, 2)
            numlist &= number(x)
        Next
        TextBox1.Text = numlist


        Dim zero As Integer = 0
        Dim one As Integer = 0
        For Each num In number
            If num = 0 Then
                zero += 1
            ElseIf num = 1 Then
                one += 1
            End If
        Next
        TextBox2.Text = one
        TextBox3.Text = zero


    End Sub

End Class
