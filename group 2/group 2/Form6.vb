Imports Microsoft.Win32

Public Class Form6



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Form11.TextBox13.Show()
            Form11.Button43.Show()
            Form11.Button47.Show()
            Form11.TextBox51.Show()
            Form11.TextBox72.Show()

            If CheckBox1.Checked Then
                Form11.TextBox51.Text = 79
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Form11.TextBox14.Show()
            Form11.Button44.Show()
            Form11.Button48.Show()
            Form11.TextBox52.Show()
            Form11.TextBox73.Show()

            If CheckBox2.Checked Then
                Form11.TextBox52.Text = 105
            End If
        End If

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Form11.TextBox15.Show()
            Form11.Button45.Show()
            Form11.Button49.Show()
            Form11.TextBox53.Show()
            Form11.TextBox74.Show()

            If CheckBox3.Checked Then
                Form11.TextBox53.Text = 95
            End If
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Form11.TextBox16.Show()
            Form11.Button46.Show()
            Form11.Button50.Show()
            Form11.TextBox54.Show()
            Form11.TextBox75.Show()

            If CheckBox4.Checked Then
                Form11.TextBox54.Text = 88
            End If
        End If

    End Sub
End Class