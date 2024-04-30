Public Class Form7
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Form11.TextBox17.Show()
            Form11.Button35.Show()
            Form11.Button36.Show()
            Form11.TextBox55.Show()
            Form11.TextBox68.Show()

        End If
        If CheckBox1.Checked Then
            Form11.TextBox55.Text = 79
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Form11.TextBox18.Show()
            Form11.Button37.Show()
            Form11.Button38.Show()
            Form11.TextBox56.Show()
            Form11.TextBox69.Show()

            If CheckBox2.Checked Then
                Form11.TextBox56.Text = 99
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Form11.TextBox19.Show()
            Form11.Button39.Show()
            Form11.Button40.Show()
            Form11.TextBox57.Show()
            Form11.TextBox70.Show()

            If CheckBox3.Checked Then
                Form11.TextBox57.Text = 84
            End If
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Form11.TextBox20.Show()
            Form11.Button41.Show()
            Form11.Button42.Show()
            Form11.TextBox58.Show()
            Form11.TextBox71.Show()

            If CheckBox4.Checked Then
                Form11.TextBox58.Text = 95
            End If
        End If
    End Sub
End Class