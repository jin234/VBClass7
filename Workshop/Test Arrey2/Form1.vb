Public Class Form1




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.TextLength = 0 Then
            MessageBox.Show("กรุณาใส่ข้อมูล")
        End If
        Dim vowel As String = ""
        Dim alphabet As String = ""
        Dim Vowellist() As String = {"a", "e", "i", "o", "u"}
        Dim text As String = TextBox1.Text.ToLower
        Dim Ftext As String = TextBox1.Text

        For i = 0 To (text.Length - 1)
            Dim check As Boolean = True
            For Each item In Vowellist
                If text(i) = item Then
                    vowel &= $"{Ftext(i)} "
                    check = False
                    Exit For
                End If
            Next
            If check = True Then
                alphabet &= $"{Ftext(i)} "
            End If
        Next
        TextBox2.text = vowel
        TextBox3.Text = alphabet

    End Sub


End Class
