Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Check(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Check(1)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Check(2)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Check(3)
    End Sub
    Private Sub Check(con As Integer)
        If TextBox1.TextLength = 0 Then
            MessageBox.Show("กรุณาใส่ข้อมูล")
        End If
        Dim num() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim ThNum() As String = {"๐", "๑", "๒", "๓", "๔", "๕", "๖", "๗", "๘", "๙"}
        Dim ThWord() As String = {"ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า"}
        Dim EnWord() As String = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"}
        Dim JPWord() As String = {"ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า"}
        Dim text As String = TextBox1.Text
        Dim textout As String = ""

        For i = 0 To (text.Length - 1)
            For Each n In num
                If n = text(i) Then
                    If con = 0 Then
                        textout &= $"{ThNum(n)} "
                        Exit For
                    ElseIf con = 1 Then
                        textout &= $"{ThWord(n)} "
                        Exit For
                    ElseIf con = 2 Then
                        textout &= $"{EnWord(n)} "
                        Exit For
                    ElseIf con = 3 Then
                        textout &= $"{JPWord(n)} "
                        Exit For
                    End If

                End If
            Next
        Next
        TextBox2.Text = textout
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength = 0 Then
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        Else
            Button1.Enabled = True
            Button2.Enabled = True
            Button3.Enabled = True
            Button4.Enabled = True
        End If
    End Sub
End Class
