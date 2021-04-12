Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim q1 As Integer = Me.TextBox1.Text

        If q1 = 1 Then
            Dim cg As Graphics = Me.PictureBox1.CreateGraphics
            Dim jpg1 As Image = Image.FromFile("こどもの国線.jpg")

            cg.DrawImage(jpg1, 0, 0, jpg1.Width, jpg1.Height)

            Me.TextBox5.Text = "片道７分全３駅！　東急こどもの国線"


        Else
            Me.TextBox4.Text = "Q2 観光地をめぐるのは好きだ"

        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim q2 As Integer = Me.TextBox2.Text

        If q2 = 1 Then
            Dim cg As Graphics = Me.PictureBox1.CreateGraphics
            Dim jpg2 As Image = Image.FromFile("江ノ島電鉄.jpg")
            cg.DrawImage(jpg2, 0, -50, jpg2.Width, jpg2.Height)
            Me.TextBox5.Text = "映画やアニメの聖地　江ノ島電鉄"

        Else
            Me.TextBox4.Text = "Q3 ゆるキャラが好きである"

        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim q3 As Integer = Me.TextBox3.Text

        If q3 = 1 Then
            Dim cg As Graphics = Me.PictureBox1.CreateGraphics
            Dim jpg3 As Image = Image.FromFile("相鉄いずみ野線.jpg")
            cg.DrawImage(jpg3, 0, 0, jpg3.Width, jpg3.Height)
            Me.TextBox5.Text = "かわいい猫のゆるキャラがいる　相鉄いずみ野線"


        Else
            Me.TextBox4.Text = ""
            Dim cg As Graphics = Me.PictureBox1.CreateGraphics
            Dim jpg4 As Image = Image.FromFile("小田急多摩線.jpg")
            cg.DrawImage(jpg4, 0, -140, jpg4.Width, jpg4.Height)
            Me.TextBox5.Text = "のんびりしたいそこのあなたに　小田急多摩線"

        End If
    End Sub
End Class
