Public Class homepage

    Public Sub homepage_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


    ''' <summary>
    ''' ''''' called when the slider menu is pressed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        If (slidemenu.Width = 258) Then
            'minimize the panel using transition'
            'set panelwidth = 73 button location = 3 34'
            'set rightpanel location = 77 44   size = 1226 633'
            slidemenu.Visible = False
            slidemenu.Width = 73
            MenuButton.Location = New Point(3, 34)
            rightpanel.Location = New Point(77, 100)
            rightpanel.Width = 1052
            rightpanel.Height = 633

            paneltransition.ShowSync(slidemenu)
        Else
            'maximize the panel'
            slidemenu.Visible = False
            slidemenu.Width = 258
            MenuButton.Location = New Point(188, 34)
            rightpanel.Location = New Point(258, 100)
            rightpanel.Width = 1052
            rightpanel.Height = 633

            paneltransition.ShowSync(slidemenu)
        End If

    End Sub


    ''' <summary>
    ''' ''called when the create profile button is pressed in slide menu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub createprofilebutton_Click(sender As Object, e As EventArgs) Handles createprofilebutton.Click
        'close this and go to the create profile form
        My.Forms.AddProfileOptions.ShowDialog()
    End Sub


    Private Sub findprofilebutton_Click(sender As Object, e As EventArgs) Handles findprofilebutton.Click
        'go to find profile form and close this
        My.Forms.findForm.ShowDialog()
    End Sub

    Private Sub messagestudentsbutton_Click(sender As Object, e As EventArgs) Handles messagestudentsbutton.Click
        'go to groupby page and then to the mail page and close this
        My.Forms.MAILSEND.ShowDialog()
    End Sub

    Private Sub reportgenerationbutton_Click(sender As Object, e As EventArgs) Handles reportgenerationbutton.Click
        'go to report generation page and close this
    End Sub

    Private Sub logoutbutton_Click(sender As Object, e As EventArgs) Handles logoutbutton.Click
        'close this and go to the login page
        My.Forms.Form1.Show()
        Me.Hide()
    End Sub

    Private Sub savebuttoncreateprofile_Click(sender As Object, e As EventArgs)
        'connect to database
    End Sub

    Private Sub resetbuttoncreateprofile_Click(sender As Object, e As EventArgs)
        'clear all the values in the form
    End Sub

    Private Sub closebuttoncreateprofile_Click(sender As Object, e As EventArgs)
        'go back to the previous form
    End Sub

    Private Sub homebuttoneditprofile_Click(sender As Object, e As EventArgs) Handles homebuttoneditprofile.Click
        'go to the home button
    End Sub

    Private Sub minimize_Click(sender As Object, e As EventArgs) Handles minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub maximize_Click(sender As Object, e As EventArgs) Handles maximize.Click
        'experimenting

        If (Me.WindowState = FormWindowState.Maximized) Then
            Me.WindowState = FormWindowState.Normal
        Else Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Dim controller As New controller
        controller.endAll()
    End Sub

    Private Sub editprofilebutton_Click(sender As Object, e As EventArgs) Handles editprofilebutton.Click
        My.Forms.UpdateProfileOptions.ShowDialog()
    End Sub

    Private Sub BunifuTileButton5_Click(sender As Object, e As EventArgs) Handles BunifuTileButton5.Click
        My.Forms.MAILSEND.ShowDialog()
    End Sub

    Private Sub createUserTileButton_Click(sender As Object, e As EventArgs) Handles createUserTileButton.Click
        My.Forms.AddProfileOptions.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuTileButton3.LabelText = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles UpdateProfileButton.Click
        My.Forms.UpdateProfileOptions.ShowDialog()
    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles BunifuTileButton4.Click
        ' calls the findForm' 
        My.Forms.findForm.ShowDialog()
    End Sub

    Private Sub BunifuTileButton7_Click(sender As Object, e As EventArgs) Handles BunifuTileButton7.Click
        My.Forms.Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuTileButton6_Click(sender As Object, e As EventArgs) Handles BunifuTileButton6.Click
        My.Forms.ReportForm.ShowDialog()
    End Sub

    Private Sub BunifuTileButton3_Click(sender As Object, e As EventArgs) Handles BunifuTileButton3.Click

    End Sub
End Class
