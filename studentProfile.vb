Public Class studentProfile

    Private Sub contactbutton_Click(sender As Object, e As EventArgs) Handles contactbutton.Click
        My.Forms.MAILSEND.tomailaddress.Text = Me.email_id.Text
        My.Forms.MAILSEND.ShowDialog()
    End Sub

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        PictureProfileView.Image = My.Resources.user__people__profile__human__account__avatar_png_icon
        Me.Hide()
    End Sub

    Private Sub editbutton_Click(sender As Object, e As EventArgs) Handles editbutton.Click
        Dim controller As New controller
        'controller.initializeEditProfile(Me.roll_number.Text)
        Me.PictureProfileView.Image = My.Resources.user__people__profile__human__account__avatar_png_icon
        My.Forms.editstudentprofile.ShowDialog()

        Dim profilepic As Image = PictureProfileView.Image
    End Sub

    Private Sub PictureProfileView_Click(sender As Object, e As EventArgs) Handles PictureProfileView.Click
        Dim profilepic As Image = Me.PictureProfileView.Image
        PictureBox1.Image = profilepic
    End Sub
End Class
