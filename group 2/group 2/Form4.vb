Public Class Form4


    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Form11.TextBox5.Show()
            Form11.Button9.Show()
            Form11.Button10.Show()
            Form11.TextBox43.Show()
            Form11.TextBox36.Show()

            If CheckBox1.Checked Then
                Form11.TextBox43.Text = 99
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Form11.TextBox6.Show()
            Form11.Button11.Show()
            Form11.Button12.Show()
            Form11.TextBox44.Show()
            Form11.TextBox37.Show()

            If CheckBox2.Checked Then
                Form11.TextBox44.Text = 55
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Form11.TextBox7.Show()
            Form11.Button14.Show()
            Form11.Button13.Show()
            Form11.TextBox45.Show()
            Form11.TextBox38.Show()

            If CheckBox3.Checked Then
                Form11.TextBox45.Text = 85
            End If
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Form11.TextBox8.Show()
            Form11.Button15.Show()
            Form11.Button16.Show()
            Form11.TextBox46.Show()
            Form11.TextBox59.Show()

            If CheckBox4.Checked Then
                Form11.TextBox46.Text = 105
            End If
        End If
    End Sub
End Class