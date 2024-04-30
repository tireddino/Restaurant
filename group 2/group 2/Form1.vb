Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ABOUTToolStripMenuItem.Click
        MsgBox("Welcome to Rise N Dine, a cozy and casual restaurant located in the heart of downtown." & vbCrLf &
               "Our menu is inspired by the diverse flavors of American cuisine, and features a wide variety of" & vbCrLf &
               "breakfast and brunch options, sandwiches, salads, and daily specials." & vbCrLf & vbCrLf &
               "Our focus is on using fresh, locally-sourced ingredients to create delicious and satisfying dishes." & vbCrLf &
               "Our menu changes seasonally to take advantage of the freshest produce and meats available." & vbCrLf & vbCrLf &
               "Our chefs have decades of experience in the culinary arts, and bring their expertise and passion to each dish they prepare." & vbCrLf &
               "Whether you're in the mood for a classic breakfast dish or something a little more adventurous," & vbCrLf &
               "you're sure to find something you love on our menu." & vbCrLf & vbCrLf &
               "We believe that dining should be a relaxed and enjoyable experience, and our friendly and attentive staff will make sure" & vbCrLf &
               "that you have a great time at our restaurant." & vbCrLf &
               "So come on in, pull up a seat, and let us take care of the rest." & vbCrLf &
               "We look forward to serving you!", MsgBoxStyle.Information, Title:="ABOUT")



    End Sub

    Private Sub WEBSITEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WEBSITEToolStripMenuItem.Click
        MsgBox("You may visit our website at" & vbCrLf & "www.risendinerestaurant.com.ph", MsgBoxStyle.Information, Title:="WEBSITE")
    End Sub

    Private Sub CONTACTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTACTToolStripMenuItem.Click
        MsgBox("FOLLOW US! AT:" & vbCrLf & vbTab &
               "FACEBOOK:" & vbTab & "RISE N DINE PHILIPPINES" & vbCrLf & vbTab &
               "INSTAGRAM:" & vbTab & "@risendineph" & vbCrLf & vbTab &
               "TWITTER:" & vbTab & "@risendineph" & vbCrLf & vbTab &
               "VIBER:" & vbTab & vbTab & "RISE N DINE VIBER COMMUNITY", MsgBoxStyle.Information, Title:="SOCIALS")
    End Sub
End Class
