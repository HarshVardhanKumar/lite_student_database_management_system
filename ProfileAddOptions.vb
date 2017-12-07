Public Class AddProfileOptions
    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        My.Forms.addstudentprofile.Show()
        Me.Close()
        My.Forms.homepage.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        My.Forms.insertmultipleprofiles.CreateProfile.Text = "Create Profiles"
        My.Forms.insertmultipleprofiles.ShowDialog()
        Me.Hide()
        'OpenFileDialog1.Title = "Create Multiple Student Profiles"
        'OpenFileDialog1.InitialDirectory = "C:"
        'OpenFileDialog1.Filter = "Excel Worksheets 2003(*.xls)|*.xls|Excel Worksheets 2007(*.xlsx)|*.xlsx"
        'If OpenFileDialog1.ShowDialog() <> System.Windows.Forms.DialogResult.Cancel Then

        'End If
    End Sub



    ' used to set the caller form for this form'
    Private caller As Form
    Public Sub setCaller(ByRef callerF As Form)
        caller = callerF
    End Sub
End Class
