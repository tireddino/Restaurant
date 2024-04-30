Public Class Form9
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        CONFIRMATION.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Form11.TextBox21.Show()
            Form11.Button27.Show()
            Form11.Button31.Show()
            Form11.TextBox28.Show()
            Form11.TextBox64.Show()

        End If
        If CheckBox1.Checked Then
            Form11.TextBox28.Text = 124
        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Form11.TextBox25.Show()
            Form11.Button28.Show()
            Form11.Button32.Show()
            Form11.TextBox29.Show()
            Form11.TextBox65.Show()

            If CheckBox2.Checked Then
                Form11.TextBox29.Text = 140
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Form11.TextBox26.Show()
            Form11.Button29.Show()
            Form11.Button33.Show()
            Form11.TextBox30.Show()
            Form11.TextBox66.Show()

            If CheckBox3.Checked Then
                Form11.TextBox30.Text = 101
            End If
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Form11.TextBox27.Show()
            Form11.Button30.Show()
            Form11.Button34.Show()
            Form11.TextBox31.Show()
            Form11.TextBox67.Show()

            If CheckBox4.Checked Then
                Form11.TextBox31.Text = 135
            End If
        End If
    End Sub
End Class