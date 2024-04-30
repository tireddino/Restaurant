Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CHECKOUT

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form11.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Your order have been received by Rise n' Dine" & vbCrLf & vbTab & "Please wait till we make your order", MsgBoxStyle.Information, Title:="ORDER RECEIVED")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim value As Double
        value = TextBox1.Text
        TextBox1.Text = value.ToString("C")
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim value As Double
        value = TextBox3.Text
        TextBox3.Text = value.ToString("C")
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim VALUE1, VALUE2 As Double
        VALUE1 = TextBox1.Text
        VALUE2 = TextBox2.Text
        TextBox3.Text = VALUE2 - VALUE1

        If VALUE2 < VALUE1 Then
            MsgBox("Payment Insufficient" & vbCrLf & "Please Input Sufficient Amount of Payment", MsgBoxStyle.Critical, Title:="Payment Error")
        Else
            Button2.Show()
            TextBox3.Show()
        End If
    End Sub
End Class