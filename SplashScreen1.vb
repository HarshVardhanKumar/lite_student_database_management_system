Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value >= 40 Then
            Label3.Text = "Connecting to database ...."
        End If

        If ProgressBar1.Value >= 60 Then
            Label3.Text = "Loading Modules ...."
        End If
        ProgressBar1.Refresh()
    End Sub

End Class
