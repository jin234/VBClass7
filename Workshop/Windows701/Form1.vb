Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer = (TextBox1.Text + 5) Mod 12
        Dim Zodiac() As String = {"ชวด", "ฉลู", "ขาล", "เถาะ", "มะโรง", "มะเส็ง", "มะเมีย", "มะแม", "วอก", "ระกา", "จอ", "กุน"}
        MessageBox.Show("ปีนี้ปี : " & TextBox1.Text & " ตรงกับปี " & Zodiac(num))
        TextBox1.Clear()
    End Sub


End Class
