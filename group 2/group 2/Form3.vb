Public Class Form3


    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            Form11.TextBox1.Show()
            Form11.Button3.Show()
            Form11.Button4.Show()
            Form11.TextBox22.Show()
            Form11.TextBox39.Show()

            If CheckBox1.Checked Then
                Form11.TextBox39.Text = 99

            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Form11.TextBox2.Show()
            Form11.Button5.Show()
            Form11.Button6.Show()
            Form11.TextBox23.Show()
            Form11.TextBox40.Show()

            If CheckBox2.Checked Then
                Form11.TextBox23.Text = 119
            End If
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Form11.TextBox3.Show()
            Form11.Button7.Show()
            Form11.Button8.Show()
            Form11.TextBox41.Show()
            Form11.TextBox24.Show()

            If CheckBox1.Checked Then
                Form11.TextBox41.Text = 135
            End If
        End If

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Form11.TextBox4.Show()
            Form11.Button23.Show()
            Form11.Button24.Show()
            Form11.TextBox42.Show()
            Form11.TextBox35.Show()

            If CheckBox4.Checked Then
                Form11.TextBox42.Text = 129
            End If
        End If

    End Sub
End Class