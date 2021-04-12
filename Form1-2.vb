Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim r As New System.Random

        Dim a As Integer = r.Next(1, 4)

        TabControl1.SelectedTab = TabControl1.TabPages(a)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As New System.Random
        Dim a As Integer = r.Next(1, 4)

        TabControl1.SelectedTab = TabControl1.TabPages(1 + a)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim r As New System.Random
        Dim a As Integer = r.Next(1, 4)

        TabControl1.SelectedTab = TabControl1.TabPages(2 + a)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedTab = TabControl1.TabPages(0)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim r As New System.Random
        Dim a As Integer = r.Next(1, 4)

        TabControl1.SelectedTab = TabControl1.TabPages(4 + a)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim r As New System.Random
        Dim a As Integer = r.Next(1, 4)

        TabControl1.SelectedTab = TabControl1.TabPages(5 + a)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim r As New System.Random
        Dim a As Integer = r.Next(1, 4)

        TabControl1.SelectedTab = TabControl1.TabPages(6 + a)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim r As New System.Random
        Dim a As Integer = r.Next(1, 4)

        If a = 1 Then
            TabControl1.SelectedTab = TabControl1.TabPages(8)
        Else
            TabControl1.SelectedTab = TabControl1.TabPages(9)
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim r As New System.Random
        Dim a As Integer = r.Next(1, 4)

        TabControl1.SelectedTab = TabControl1.TabPages(8 - a)

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TabControl1.SelectedTab = TabControl1.TabPages(0)
    End Sub
End Class
