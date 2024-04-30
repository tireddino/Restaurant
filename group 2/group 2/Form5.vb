Public Class Form5



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Form11.TextBox9.Show()
            Form11.Button17.Show()
            Form11.Button18.Show()
            Form11.TextBox47.Show()
            Form11.TextBox60.Show()

            If CheckBox1.Checked Then
                Form11.TextBox47.Text = 99
            End If
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Form11.TextBox10.Show()
            Form11.Button19.Show()
            Form11.Button20.Show()
            Form11.TextBox48.Show()
            Form11.TextBox61.Show()

            If CheckBox2.Checked Then
                Form11.TextBox48.Text = 111
            End If
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Form11.TextBox11.Show()
            Form11.Button21.Show()
            Form11.Button22.Show()
            Form11.TextBox49.Show()
            Form11.TextBox62.Show()

            If CheckBox3.Checked Then
                Form11.TextBox49.Text = 129
            End If
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            Form11.TextBox12.Show()
            Form11.Button25.Show()
            Form11.Button26.Show()
            Form11.TextBox50.Show()
            Form11.TextBox63.Show()

            If CheckBox4.Checked Then
                Form11.TextBox50.Text = 119
            End If
        End If
    End Sub
End Class