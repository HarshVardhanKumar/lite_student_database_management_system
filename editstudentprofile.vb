Imports System.Data.SqlClient
Imports System.IO
Public Class editstudentprofile
    Dim saved As Boolean = True 'to check if the details have been saved or not
    Dim parentCallerForm As Form
    Private Sub MenuButton_Click(sender As Object, e As EventArgs) Handles MenuButton.Click
        If (slidemenu.Width = 258) Then
            'minimize the panel using transition'
            'set panelwidth = 73 button location = 3 34'
            'set rightpanel location = 77 44   size = 1226 633'
            slidemenu.Visible = False
            slidemenu.Width = 73
            MenuButton.Location = New Point(3, 34)
            rightpanel.Location = New Point(75, 92)
            rightpanel.Width = 1052
            rightpanel.Height = 633
            TabControl1.Width = 936 'restore the size of the tab control when the slide panel is minimized
            'panel3 is kept fixed'

            paneltransition.ShowSync(slidemenu)
        Else
            'maximize the panel'
            slidemenu.Visible = False
            slidemenu.Width = 258
            MenuButton.Location = New Point(188, 34)
            rightpanel.Location = New Point(258, 44)
            rightpanel.Width = 1052
            rightpanel.Height = 633
            ' the width of the tabcontrol is minimized when the slide panel is maximized
            TabControl1.Width = 800

            paneltransition.ShowSync(slidemenu)
        End If

    End Sub

    Private Sub createprofilebutton_Click(sender As Object, e As EventArgs) Handles createprofilebutton.Click
        'close this and go to the create profile form
        My.Forms.AddProfileOptions.Show()
        My.Forms.findForm.Hide()
        My.Forms.studentProfile.Hide()
        My.Forms.ResultsList.Hide()
        Me.Hide()
    End Sub

    Private Sub findprofilebutton_Click(sender As Object, e As EventArgs) Handles findprofilebutton.Click
        'go to find profile form and close this
        My.Forms.findForm.Show()
        Me.Hide()
        My.Forms.studentProfile.Hide()
        My.Forms.ResultsList.Hide()
    End Sub

    Private Sub messagestudentsbutton_Click(sender As Object, e As EventArgs) Handles messagestudentsbutton.Click
        'go to groupby page and then to the mail page and close this
        My.Forms.MAILSEND.ShowDialog()
    End Sub

    Private Sub reportgenerationbutton_Click(sender As Object, e As EventArgs) Handles reportgenerationbutton.Click
        'go to report generation page and close this
        My.Forms.ReportForm.ShowDialog()

        My.Forms.studentProfile.Hide()
        My.Forms.ResultsList.Hide()
        Me.Hide()
    End Sub

    Private Sub logoutbutton_Click(sender As Object, e As EventArgs) Handles logoutbutton.Click
        'close this and go to the login page
        My.Forms.Form1.Show()
        Me.Hide()
        My.Forms.studentProfile.Hide()
    End Sub

    Private Sub clearAll()

    End Sub
    Private Sub savebuttoncreateprofile_Click(sender As Object, e As EventArgs) Handles savebuttoneditprofile.Click
        'connect to database

        Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
        Dim connection As New SqlConnection(connectionstring)

        connection.Open()
        Dim cmd2 = New SqlCommand("select Profile_picture from TableProfilePicture where examination_roll_number ='" &
              ExaminationRollNumber.Text & "'", connection)
        Try
            Dim imageData As Byte() = DirectCast(cmd2.ExecuteScalar(), Byte())
            If Not imageData Is Nothing Then
                Using ms As New MemoryStream(imageData, 0, imageData.Length)
                    ms.Write(imageData, 0, imageData.Length)
                    My.Forms.studentProfile.PictureProfileView.Image = Image.FromStream(ms, True)
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
        connection.Close()


    End Sub

    Private Sub resetbuttoncreateprofile_Click(sender As Object, e As EventArgs)
        'clear all the values in the form

    End Sub

    Private Sub closebuttoncreateprofile_Click(sender As Object, e As EventArgs) Handles closebuttoneditprofile.Click
        'go back to the previous form
        Dim useroption As Integer = (MessageBox.Show("Do you wish to save the changes", "Edit Student Profile", MessageBoxButtons.YesNo))
        If (useroption = 1) Then
            ' the user wishes to save the edited data. 
            saved = True
        Else
            ' the user does not wish to save the edited data
            saved = False
        End If

        Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
        Dim connection As New SqlConnection(connectionstring)

        connection.Open()
        Dim cmd2 = New SqlCommand("select Profile_picture from TableProfilePicture where examination_roll_number ='" &
              ExaminationRollNumber.Text & "'", connection)
        Try
            Dim imageData As Byte() = DirectCast(cmd2.ExecuteScalar(), Byte())
            If Not imageData Is Nothing Then
                Using ms As New MemoryStream(imageData, 0, imageData.Length)
                    ms.Write(imageData, 0, imageData.Length)
                    My.Forms.studentProfile.PictureProfileView.Image = Image.FromStream(ms, True)
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
        connection.Close()


        Me.Close()
    End Sub

    Private Sub homebuttoneditprofile_Click(sender As Object, e As EventArgs) Handles homebuttoneditprofile.Click
        'go to the home button
        My.Forms.homepage.Show()
        Me.Hide()
        My.Forms.studentProfile.Hide()
        My.Forms.ResultsList.Hide()
        My.Forms.findForm.Hide()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Select Profile Image"
        OpenFileDialog1.InitialDirectory = "C:"
        OpenFileDialog1.Filter = "Image|*.jpg;*.png;"
        If OpenFileDialog1.ShowDialog() <> System.Windows.Forms.DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub editstudentprofile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' used to set the caller form for this form'
    Private caller As Form
    Public Sub setCaller(ByRef callerF As Form)
        caller = callerF
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles guardianaddress.TextChanged

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles button.Click
        p_addressline1.Text = c_addressline1.Text
        p_city.Text = c_city.Text
        p_state.SelectedIndex = c_state.SelectedIndex
        p_pincode.Text = c_pincode.Text
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
        Dim connection As New SqlConnection(connectionstring)

        connection.Open()
        Dim cmd2 = New SqlCommand("select Profile_picture from TableProfilePicture where examination_roll_number ='" &
              ExaminationRollNumber.Text & "'", connection)
        Try
            Dim imageData As Byte() = DirectCast(cmd2.ExecuteScalar(), Byte())
            If Not imageData Is Nothing Then
                Using ms As New MemoryStream(imageData, 0, imageData.Length)
                    ms.Write(imageData, 0, imageData.Length)
                    My.Forms.studentProfile.PictureProfileView.Image = Image.FromStream(ms, True)
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.ToString)
        End Try
        connection.Close()

        My.Forms.studentProfile.Show()
        Me.Hide()
    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
            Dim connection As New SqlConnection(connectionstring)

            connection.Open()

            Dim firstsemestersub1 As String = ComboBox3.Text.Split(" ")(0)
            Dim firstsemestersub2 As String = ComboBox5.Text.Split(" ")(0)
            Dim firstsemestersub3 As String = ComboBox4.Text.Split(" ")(0)
            Dim firstsemestersub4 As String = ComboBox6.Text.Split(" ")(0)
            Dim firstsemestersub5 As String = ComboBox7.Text.Split(" ")(0)
            Dim firstsemestersub6 As String = ComboBox8.Text.Split(" ")(0)
            Dim firstsemestersub7 As String = ComboBox9.Text.Split(" ")(0)
            Dim firstsemestersub8 As String = ComboBox10.Text.Split(" ")(0)
            Dim firstsemestersub9 As String = ComboBox11.Text.Split(" ")(0)
            Dim firstsemestersub10 As String = ComboBox12.Text.Split(" ")(0)

            Dim firstsemsub1internal As Integer = 0
            Dim firstsemsub2internal As Integer = 0
            Dim firstsemsub3internal As Integer = 0
            Dim firstsemsub4internal As Integer = 0
            Dim firstsemsub5internal As Integer = 0
            Dim firstsemsub6internal As Integer = 0
            Dim firstsemsub7internal As Integer = 0
            Dim firstsemsub8internal As Integer = 0
            Dim firstsemsub9internal As Integer = 0
            Dim firstsemsub10internal As Integer = 0

            Dim firstsemsub1external As Integer = 0
            Dim firstsemsub2external As Integer = 0
            Dim firstsemsub3external As Integer = 0
            Dim firstsemsub4external As Integer = 0
            Dim firstsemsub5external As Integer = 0
            Dim firstsemsub6external As Integer = 0
            Dim firstsemsub7external As Integer = 0
            Dim firstsemsub8external As Integer = 0
            Dim firstsemsub9external As Integer = 0
            Dim firstsemsub10external As Integer = 0

            Dim firstsemsub1grade As String = ""
            Dim firstsemsub2grade As String = ""
            Dim firstsemsub3grade As String = ""
            Dim firstsemsub4grade As String = ""
            Dim firstsemsub5grade As String = ""
            Dim firstsemsub6grade As String = ""
            Dim firstsemsub7grade As String = ""
            Dim firstsemsub8grade As String = ""
            Dim firstsemsub9grade As String = ""
            Dim firstsemsub10grade As String = ""

            If TextBox94.Text <> "" Then
                Try
                    firstsemsub1internal = CInt(TextBox94.Text)
                Catch ex As Exception
                    Exit Sub
                End Try
            End If
            If TextBox93.Text <> "" Then
                Try
                    firstsemsub2internal = CInt(TextBox93.Text)
                Catch ex As Exception
                    Exit Sub
                End Try
            End If
            If TextBox92.Text <> "" Then
                Try
                    firstsemsub3internal = CInt(TextBox92.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox91.Text <> "" Then
                Try
                    firstsemsub4internal = CInt(TextBox91.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox90.Text <> "" Then
                Try
                    firstsemsub5internal = CInt(TextBox90.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox89.Text <> "" Then
                Try
                    firstsemsub6internal = CInt(TextBox89.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox88.Text <> "" Then
                Try
                    firstsemsub7internal = CInt(TextBox88.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox87.Text <> "" Then
                Try
                    firstsemsub8internal = CInt(TextBox87.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox86.Text <> "" Then
                Try
                    firstsemsub9internal = CInt(TextBox86.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox85.Text <> "" Then
                Try
                    firstsemsub10internal = CInt(TextBox85.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If



            If TextBox65.Text <> "" Then
                Try
                    firstsemsub1external = CInt(TextBox65.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox66.Text <> "" Then
                Try
                    firstsemsub1grade = (TextBox66.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox67.Text <> "" Then
                Try
                    firstsemsub2external = CInt(TextBox67.Text)
                    MsgBox(firstsemsub2internal)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox68.Text <> "" Then
                Try
                    firstsemsub2grade = (TextBox68.Text)
                    MsgBox(firstsemsub2external)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox69.Text <> "" Then
                Try
                    firstsemsub3external = CInt(TextBox69.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox70.Text <> "" Then
                Try
                    firstsemsub3grade = (TextBox70.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox71.Text <> "" Then
                Try
                    firstsemsub4external = CInt(TextBox71.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox72.Text <> "" Then
                Try
                    firstsemsub4grade = (TextBox72.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox73.Text <> "" Then
                Try
                    firstsemsub5external = CInt(TextBox73.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox74.Text <> "" Then
                Try
                    firstsemsub5grade = (TextBox74.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox75.Text <> "" Then
                Try
                    firstsemsub6external = CInt(TextBox75.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox76.Text <> "" Then
                Try
                    firstsemsub6grade = (TextBox76.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox77.Text <> "" Then
                Try
                    firstsemsub7external = CInt(TextBox77.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox78.Text <> "" Then
                Try
                    firstsemsub7grade = (TextBox78.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox79.Text <> "" Then
                Try
                    firstsemsub8external = CInt(TextBox79.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox80.Text <> "" Then
                Try
                    firstsemsub8grade = (TextBox80.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox81.Text <> "" Then
                Try
                    firstsemsub9external = CInt(TextBox81.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox82.Text <> "" Then
                Try
                    firstsemsub9grade = (TextBox82.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox83.Text <> "" Then
                Try
                    firstsemsub10external = CInt(TextBox83.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox84.Text <> "" Then
                Try
                    firstsemsub10grade = (TextBox84.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If


            If firstsemestersub1 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub1 + "' and semester = '" + CStr(1) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub1 + "', semester = '" + CStr(1) + "', internal_marks = " + CStr(firstsemsub1internal) + ", external_marks = " + CStr(firstsemsub1external) + ", grade = '" + firstsemsub1grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub1 + "'," + CStr(1) + ",'" + CStr(firstsemsub1internal) + "', '" + CStr(firstsemsub1external) + "','" + firstsemsub1grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If
                MsgBox("updated ")
            End If
            If firstsemestersub2 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub2 + "' and semester = '" + CStr(1) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub2 + "', semester = '" + CStr(1) + "', internal_marks = '" + CStr(firstsemsub2internal) + "', external_marks = '" + CStr(firstsemsub2external) + "', grade = '" + firstsemsub2grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub2 + "'," + CStr(1) + "," + CStr(firstsemsub2internal) + ", " + CStr(firstsemsub2external) + ",'" + firstsemsub2grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub3 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub3 + "' and semester = '" + CStr(1) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub3 + "', semester = '" + CStr(1) + "', internal_marks = " + CStr(firstsemsub3internal) + ", external_marks = " + CStr(firstsemsub3external) + ", grade = '" + firstsemsub3grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub3 + "'," + CStr(1) + "," + CStr(firstsemsub3internal) + ", '" + CStr(firstsemsub3external) + "','" + firstsemsub3grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub4 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub4 + "' and semester = '" + CStr(1) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub4 + "', semester = '" + CStr(1) + "', internal_marks = " + CStr(firstsemsub4internal) + ", external_marks = " + CStr(firstsemsub1external) + ", grade = '" + firstsemsub4grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub4 + "'," + CStr(1) + "," + CStr(firstsemsub4internal) + ", " + CStr(firstsemsub4external) + ",'" + firstsemsub4grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub5 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub5 + "' and semester = '" + CStr(1) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub5 + "', semester = '" + CStr(1) + "', internal_marks = " + CStr(firstsemsub5internal) + ", external_marks = " + CStr(firstsemsub5external) + ", grade = '" + firstsemsub5grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub5 + "'," + CStr(1) + "," + CStr(firstsemsub5internal) + ", " + CStr(firstsemsub5external) + ",'" + firstsemsub5grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub6 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub6 + "' and semester = '" + CStr(1) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub6 + "', semester = '" + CStr(1) + "', internal_marks = " + CStr(firstsemsub6internal) + ", external_marks = " + CStr(firstsemsub6external) + ", grade = '" + firstsemsub6grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub6 + "'," + CStr(1) + "," + CStr(firstsemsub6internal) + ", " + CStr(firstsemsub6external) + ",'" + firstsemsub6grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub7 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub7 + "' and semester = '" + CStr(1) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub7 + "', semester = '" + CStr(1) + "', internal_marks = " + CStr(firstsemsub7internal) + ", external_marks = " + CStr(firstsemsub7external) + ", grade = '" + firstsemsub7grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)

                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub7 + "'," + CStr(1) + "," + CStr(firstsemsub7internal) + ", " + CStr(firstsemsub7external) + ",'" + firstsemsub7grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)

                    End Try
                End If

            End If
            If firstsemestersub8 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub8 + "' and semester = '" + CStr(1) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub8 + "', semester = '" + CStr(1) + "', internal_marks = " + CStr(firstsemsub8internal) + ", external_marks = " + CStr(firstsemsub8external) + ", grade = '" + firstsemsub8grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)

                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub8 + "'," + CStr(1) + "," + CStr(firstsemsub8internal) + ", " + CStr(firstsemsub8external) + ",'" + firstsemsub8grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)

                    End Try
                End If

            End If
            If firstsemestersub9 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub9 + "' and semester = '" + CStr(1) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub9 + "', semester = '" + CStr(1) + "', internal_marks = " + CStr(firstsemsub9internal) + ", external_marks = " + CStr(firstsemsub9external) + ", grade = '" + firstsemsub9grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub9 + "'," + CStr(1) + "," + CStr(firstsemsub9internal) + ", " + CStr(firstsemsub9external) + ",'" + firstsemsub9grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub10 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub10 + "' and semester = '" + CStr(1) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub10 + "', semester = '" + CStr(1) + "', internal_marks = " + CStr(firstsemsub10internal) + ", external_marks = " + CStr(firstsemsub10external) + ", grade = '" + firstsemsub10grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)

                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub10 + "'," + CStr(1) + "," + CStr(firstsemsub10internal) + ", " + CStr(firstsemsub10external) + ",'" + firstsemsub10grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
            Dim connection As New SqlConnection(connectionstring)

            connection.Open()

            Dim firstsemestersub1 As String = ComboBox20.Text.Split(" ")(0)
            Dim firstsemestersub2 As String = ComboBox19.Text.Split(" ")(0)
            Dim firstsemestersub3 As String = ComboBox18.Text.Split(" ")(0)
            Dim firstsemestersub4 As String = ComboBox17.Text.Split(" ")(0)
            Dim firstsemestersub5 As String = ComboBox16.Text.Split(" ")(0)
            Dim firstsemestersub6 As String = ComboBox15.Text.Split(" ")(0)
            Dim firstsemestersub7 As String = ComboBox14.Text.Split(" ")(0)
            Dim firstsemestersub8 As String = ComboBox13.Text.Split(" ")(0)
            Dim firstsemestersub9 As String = ComboBox2.Text.Split(" ")(0)
            Dim firstsemestersub10 As String = ComboBox1.Text.Split(" ")(0)

            Dim firstsemsub1internal As Integer = 0
            Dim firstsemsub2internal As Integer = 0
            Dim firstsemsub3internal As Integer = 0
            Dim firstsemsub4internal As Integer = 0
            Dim firstsemsub5internal As Integer = 0
            Dim firstsemsub6internal As Integer = 0
            Dim firstsemsub7internal As Integer = 0
            Dim firstsemsub8internal As Integer = 0
            Dim firstsemsub9internal As Integer = 0
            Dim firstsemsub10internal As Integer = 0

            Dim firstsemsub1external As Integer = 0
            Dim firstsemsub2external As Integer = 0
            Dim firstsemsub3external As Integer = 0
            Dim firstsemsub4external As Integer = 0
            Dim firstsemsub5external As Integer = 0
            Dim firstsemsub6external As Integer = 0
            Dim firstsemsub7external As Integer = 0
            Dim firstsemsub8external As Integer = 0
            Dim firstsemsub9external As Integer = 0
            Dim firstsemsub10external As Integer = 0

            Dim firstsemsub1grade As String = ""
            Dim firstsemsub2grade As String = ""
            Dim firstsemsub3grade As String = ""
            Dim firstsemsub4grade As String = ""
            Dim firstsemsub5grade As String = ""
            Dim firstsemsub6grade As String = ""
            Dim firstsemsub7grade As String = ""
            Dim firstsemsub8grade As String = ""
            Dim firstsemsub9grade As String = ""
            Dim firstsemsub10grade As String = ""

            If TextBox35.Text <> "" Then
                Try
                    firstsemsub1internal = CInt(TextBox35.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox32.Text <> "" Then
                Try
                    firstsemsub2internal = CInt(TextBox32.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox29.Text <> "" Then
                Try
                    firstsemsub3internal = CInt(TextBox29.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox26.Text <> "" Then
                Try
                    firstsemsub4internal = CInt(TextBox26.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox23.Text <> "" Then
                Try
                    firstsemsub5internal = CInt(TextBox23.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox20.Text <> "" Then
                Try
                    firstsemsub6internal = CInt(TextBox20.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox17.Text <> "" Then
                Try
                    firstsemsub7internal = CInt(TextBox17.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox14.Text <> "" Then
                Try
                    firstsemsub8internal = CInt(TextBox14.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox7.Text <> "" Then
                Try
                    firstsemsub9internal = CInt(TextBox7.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox4.Text <> "" Then
                Try
                    firstsemsub10internal = CInt(TextBox4.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If



            If TextBox34.Text <> "" Then
                Try
                    firstsemsub1external = CInt(TextBox34.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox33.Text <> "" Then
                Try
                    firstsemsub1grade = (TextBox33.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox31.Text <> "" Then
                Try
                    firstsemsub2external = CInt(TextBox31.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox30.Text <> "" Then
                Try
                    firstsemsub2grade = (TextBox30.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox28.Text <> "" Then
                Try
                    firstsemsub3external = CInt(TextBox28.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox27.Text <> "" Then
                Try
                    firstsemsub3grade = (TextBox27.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox25.Text <> "" Then
                Try
                    firstsemsub4external = CInt(TextBox25.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox24.Text <> "" Then
                Try
                    firstsemsub4grade = (TextBox24.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox22.Text <> "" Then
                Try
                    firstsemsub5external = CInt(TextBox22.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox21.Text <> "" Then
                Try
                    firstsemsub5grade = (TextBox21.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox19.Text <> "" Then
                Try
                    firstsemsub6external = CInt(TextBox19.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox18.Text <> "" Then
                Try
                    firstsemsub6grade = (TextBox18.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox16.Text <> "" Then
                Try
                    firstsemsub7external = CInt(TextBox16.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox15.Text <> "" Then
                Try
                    firstsemsub7grade = (TextBox15.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox13.Text <> "" Then
                Try
                    firstsemsub8external = CInt(TextBox13.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox12.Text <> "" Then
                Try
                    firstsemsub8grade = (TextBox12.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox6.Text <> "" Then
                Try
                    firstsemsub9external = CInt(TextBox6.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox5.Text <> "" Then
                Try
                    firstsemsub9grade = (TextBox5.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox3.Text <> "" Then
                Try
                    firstsemsub10external = CInt(TextBox3.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox1.Text <> "" Then
                Try
                    firstsemsub10grade = (TextBox1.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If


            If firstsemestersub1 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub1 + "' and semester = '" + CStr(2) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub1 + "', semester = '" + CStr(2) + "', internal_marks = " + CStr(firstsemsub1internal) + ", external_marks = " + CStr(firstsemsub1external) + ", grade = '" + firstsemsub1grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)

                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub1 + "'," + CStr(2) + "," + CStr(firstsemsub1internal) + ", " + CStr(firstsemsub1external) + ",'" + firstsemsub1grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub2 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub2 + "' and semester = '" + CStr(2) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub2 + "', semester = '" + CStr(2) + "', internal_marks = " + CStr(firstsemsub2internal) + ", external_marks = " + CStr(firstsemsub2external) + ", grade = '" + firstsemsub2grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub2 + "'," + CStr(2) + "," + CStr(firstsemsub2internal) + ", " + CStr(firstsemsub2external) + ",'" + firstsemsub2grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub3 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub3 + "' and semester = '" + CStr(2) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub3 + "', semester = '" + CStr(2) + "', internal_marks = " + CStr(firstsemsub3internal) + ", external_marks = " + CStr(firstsemsub3external) + ", grade = '" + firstsemsub3grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub3 + "'," + CStr(2) + "," + CStr(firstsemsub3internal) + ", " + CStr(firstsemsub3external) + ",'" + firstsemsub3grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub4 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub4 + "' and semester = '" + CStr(2) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub4 + "', semester = '" + CStr(2) + "', internal_marks = " + CStr(firstsemsub4internal) + ", external_marks = " + CStr(firstsemsub1external) + ", grade = '" + firstsemsub4grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub4 + "'," + CStr(2) + "," + CStr(firstsemsub4internal) + ", " + CStr(firstsemsub4external) + ",'" + firstsemsub4grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub5 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub5 + "' and semester = '" + CStr(2) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub5 + "', semester = '" + CStr(2) + "', internal_marks = " + CStr(firstsemsub5internal) + ", external_marks = " + CStr(firstsemsub5external) + ", grade = '" + firstsemsub5grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub5 + "'," + CStr(2) + "," + CStr(firstsemsub5internal) + ", " + CStr(firstsemsub5external) + ",'" + firstsemsub5grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub6 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub6 + "' and semester = '" + CStr(2) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub6 + "', semester = '" + CStr(2) + "', internal_marks = " + CStr(firstsemsub6internal) + ", external_marks = " + CStr(firstsemsub6external) + ", grade = '" + firstsemsub6grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub6 + "'," + CStr(2) + "," + CStr(firstsemsub6internal) + ", " + CStr(firstsemsub6external) + ",'" + firstsemsub6grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub7 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub7 + "' and semester = '" + CStr(2) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub7 + "', semester = '" + CStr(2) + "', internal_marks = " + CStr(firstsemsub7internal) + ", external_marks = " + CStr(firstsemsub7external) + ", grade = '" + firstsemsub7grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub7 + "'," + CStr(2) + "," + CStr(firstsemsub7internal) + ", " + CStr(firstsemsub7external) + ",'" + firstsemsub7grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub8 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub8 + "' and semester = '" + CStr(2) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub8 + "', semester = '" + CStr(2) + "', internal_marks = " + CStr(firstsemsub8internal) + ", external_marks = " + CStr(firstsemsub8external) + ", grade = '" + firstsemsub8grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub8 + "'," + CStr(2) + "," + CStr(firstsemsub8internal) + ", " + CStr(firstsemsub8external) + ",'" + firstsemsub8grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub9 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub9 + "' and semester = '" + CStr(2) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub9 + "', semester = '" + CStr(2) + "', internal_marks = " + CStr(firstsemsub9internal) + ", external_marks = " + CStr(firstsemsub9external) + ", grade = '" + firstsemsub9grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub9 + "'," + CStr(2) + "," + CStr(firstsemsub9internal) + ", " + CStr(firstsemsub9external) + ",'" + firstsemsub9grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub10 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub10 + "' and semester = '" + CStr(2) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub10 + "', semester = '" + CStr(2) + "', internal_marks = " + CStr(firstsemsub10internal) + ", external_marks = " + CStr(firstsemsub10external) + ", grade = '" + firstsemsub10grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub10 + "'," + CStr(2) + "," + CStr(firstsemsub10internal) + ", " + CStr(firstsemsub10external) + ",'" + firstsemsub10grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
            Dim connection As New SqlConnection(connectionstring)

            connection.Open()

            Dim firstsemestersub1 As String = ComboBox30.Text.Split(" ")(0)
            Dim firstsemestersub2 As String = ComboBox29.Text.Split(" ")(0)
            Dim firstsemestersub3 As String = ComboBox28.Text.Split(" ")(0)
            Dim firstsemestersub4 As String = ComboBox27.Text.Split(" ")(0)
            Dim firstsemestersub5 As String = ComboBox26.Text.Split(" ")(0)
            Dim firstsemestersub6 As String = ComboBox25.Text.Split(" ")(0)
            Dim firstsemestersub7 As String = ComboBox24.Text.Split(" ")(0)
            Dim firstsemestersub8 As String = ComboBox23.Text.Split(" ")(0)
            Dim firstsemestersub9 As String = ComboBox22.Text.Split(" ")(0)
            Dim firstsemestersub10 As String = ComboBox21.Text.Split(" ")(0)

            Dim firstsemsub1internal As Integer = 0
            Dim firstsemsub2internal As Integer = 0
            Dim firstsemsub3internal As Integer = 0
            Dim firstsemsub4internal As Integer = 0
            Dim firstsemsub5internal As Integer = 0
            Dim firstsemsub6internal As Integer = 0
            Dim firstsemsub7internal As Integer = 0
            Dim firstsemsub8internal As Integer = 0
            Dim firstsemsub9internal As Integer = 0
            Dim firstsemsub10internal As Integer = 0

            Dim firstsemsub1external As Integer = 0
            Dim firstsemsub2external As Integer = 0
            Dim firstsemsub3external As Integer = 0
            Dim firstsemsub4external As Integer = 0
            Dim firstsemsub5external As Integer = 0
            Dim firstsemsub6external As Integer = 0
            Dim firstsemsub7external As Integer = 0
            Dim firstsemsub8external As Integer = 0
            Dim firstsemsub9external As Integer = 0
            Dim firstsemsub10external As Integer = 0

            Dim firstsemsub1grade As String = ""
            Dim firstsemsub2grade As String = ""
            Dim firstsemsub3grade As String = ""
            Dim firstsemsub4grade As String = ""
            Dim firstsemsub5grade As String = ""
            Dim firstsemsub6grade As String = ""
            Dim firstsemsub7grade As String = ""
            Dim firstsemsub8grade As String = ""
            Dim firstsemsub9grade As String = ""
            Dim firstsemsub10grade As String = ""

            If TextBox96.Text <> "" Then
                Try
                    firstsemsub1internal = CInt(TextBox96.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox63.Text <> "" Then
                Try
                    firstsemsub2internal = CInt(TextBox63.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox60.Text <> "" Then
                Try
                    firstsemsub3internal = CInt(TextBox60.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox57.Text <> "" Then
                Try
                    firstsemsub4internal = CInt(TextBox57.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox54.Text <> "" Then
                Try
                    firstsemsub5internal = CInt(TextBox54.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox51.Text <> "" Then
                Try
                    firstsemsub6internal = CInt(TextBox51.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox48.Text <> "" Then
                Try
                    firstsemsub7internal = CInt(TextBox48.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox45.Text <> "" Then
                Try
                    firstsemsub8internal = CInt(TextBox45.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox42.Text <> "" Then
                Try
                    firstsemsub9internal = CInt(TextBox42.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox39.Text <> "" Then
                Try
                    firstsemsub10internal = CInt(TextBox39.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If



            If TextBox95.Text <> "" Then
                Try
                    firstsemsub1external = CInt(TextBox95.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox64.Text <> "" Then
                Try
                    firstsemsub1grade = (TextBox64.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox62.Text <> "" Then
                Try
                    firstsemsub2external = CInt(TextBox62.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox61.Text <> "" Then
                Try
                    firstsemsub2grade = (TextBox61.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox59.Text <> "" Then
                Try
                    firstsemsub3external = CInt(TextBox59.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox58.Text <> "" Then
                Try
                    firstsemsub3grade = (TextBox58.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox56.Text <> "" Then
                Try
                    firstsemsub4external = CInt(TextBox56.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox55.Text <> "" Then
                Try
                    firstsemsub4grade = (TextBox55.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox53.Text <> "" Then
                Try
                    firstsemsub5external = CInt(TextBox53.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox52.Text <> "" Then
                Try
                    firstsemsub5grade = (TextBox52.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox50.Text <> "" Then
                Try
                    firstsemsub6external = CInt(TextBox50.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox49.Text <> "" Then
                Try
                    firstsemsub6grade = (TextBox49.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox47.Text <> "" Then
                Try
                    firstsemsub7external = CInt(TextBox47.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox46.Text <> "" Then
                Try
                    firstsemsub7grade = (TextBox46.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox44.Text <> "" Then
                Try
                    firstsemsub8external = CInt(TextBox44.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox43.Text <> "" Then
                Try
                    firstsemsub8grade = (TextBox43.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox41.Text <> "" Then
                Try
                    firstsemsub9external = CInt(TextBox41.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox40.Text <> "" Then
                Try
                    firstsemsub9grade = (TextBox40.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox38.Text <> "" Then
                Try
                    firstsemsub10external = CInt(TextBox38.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If
            If TextBox36.Text <> "" Then
                Try
                    firstsemsub10grade = (TextBox36.Text)
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Sub
                End Try
            End If


            If firstsemestersub1 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub1 + "' and semester = '" + CStr(3) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub1 + "', semester = '" + CStr(3) + "', internal_marks = " + CStr(firstsemsub1internal) + ", external_marks = " + CStr(firstsemsub1external) + ", grade = '" + firstsemsub1grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)

                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub1 + "'," + CStr(3) + "," + CStr(firstsemsub1internal) + ", " + CStr(firstsemsub1external) + ",'" + firstsemsub1grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub2 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub2 + "' and semester = '" + CStr(3) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub2 + "', semester = '" + CStr(3) + "', internal_marks = " + CStr(firstsemsub2internal) + ", external_marks = " + CStr(firstsemsub2external) + ", grade = '" + firstsemsub2grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub2 + "'," + CStr(3) + "," + CStr(firstsemsub2internal) + ", " + CStr(firstsemsub2external) + ",'" + firstsemsub2grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub3 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub3 + "' and semester = '" + CStr(3) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub3 + "', semester = '" + CStr(3) + "', internal_marks = " + CStr(firstsemsub3internal) + ", external_marks = " + CStr(firstsemsub3external) + ", grade = '" + firstsemsub3grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub3 + "'," + CStr(3) + "," + CStr(firstsemsub3internal) + ", " + CStr(firstsemsub3external) + ",'" + firstsemsub3grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub4 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub4 + "' and semester = '" + CStr(3) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub4 + "', semester = '" + CStr(3) + "', internal_marks = " + CStr(firstsemsub4internal) + ", external_marks = " + CStr(firstsemsub1external) + ", grade = '" + firstsemsub4grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub4 + "'," + CStr(3) + "," + CStr(firstsemsub4internal) + ", " + CStr(firstsemsub4external) + ",'" + firstsemsub4grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub5 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub5 + "' and semester = '" + CStr(3) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub5 + "', semester = '" + CStr(3) + "', internal_marks = " + CStr(firstsemsub5internal) + ", external_marks = " + CStr(firstsemsub5external) + ", grade = '" + firstsemsub5grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub5 + "'," + CStr(3) + "," + CStr(firstsemsub5internal) + ", " + CStr(firstsemsub5external) + ",'" + firstsemsub5grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub6 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub6 + "' and semester = '" + CStr(3) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub6 + "', semester = '" + CStr(3) + "', internal_marks = " + CStr(firstsemsub6internal) + ", external_marks = " + CStr(firstsemsub6external) + ", grade = '" + firstsemsub6grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub6 + "'," + CStr(3) + "," + CStr(firstsemsub6internal) + ", " + CStr(firstsemsub6external) + ",'" + firstsemsub6grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        ' Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub7 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub7 + "' and semester = '" + CStr(3) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub7 + "', semester = '" + CStr(3) + "', internal_marks = " + CStr(firstsemsub7internal) + ", external_marks = " + CStr(firstsemsub7external) + ", grade = '" + firstsemsub7grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub7 + "'," + CStr(3) + "," + CStr(firstsemsub7internal) + ", " + CStr(firstsemsub7external) + ",'" + firstsemsub7grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub8 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub8 + "' and semester = '" + CStr(3) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub8 + "', semester = '" + CStr(3) + "', internal_marks = " + CStr(firstsemsub8internal) + ", external_marks = " + CStr(firstsemsub8external) + ", grade = '" + firstsemsub8grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub8 + "'," + CStr(3) + "," + CStr(firstsemsub8internal) + ", " + CStr(firstsemsub8external) + ",'" + firstsemsub8grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub9 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub9 + "' and semester = '" + CStr(3) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub9 + "', semester = '" + CStr(3) + "', internal_marks = " + CStr(firstsemsub9internal) + ", external_marks = " + CStr(firstsemsub9external) + ", grade = '" + firstsemsub9grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub9 + "'," + CStr(3) + "," + CStr(firstsemsub9internal) + ", " + CStr(firstsemsub9external) + ",'" + firstsemsub9grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If
            If firstsemestersub10 <> "" Then
                Dim dt As New DataTable

                Dim cd As New SqlCommand("select * from student_subject_marks where roll_number = '" + ExaminationRollNumber.Text + "' and course_id =  '" + firstsemestersub10 + "' and semester = '" + CStr(3) + "'", connection)
                Dim drr = cd.ExecuteReader()
                'Dim dt As New DataTable
                dt.Load(drr)

                If dt.Rows.Count <> 0 Then
                    Try
                        Dim cmd As New SqlCommand("update student_subject_marks set roll_number = '" + ExaminationRollNumber.Text + "', course_id = '" + firstsemestersub10 + "', semester = '" + CStr(3) + "', internal_marks = " + CStr(firstsemsub10internal) + ", external_marks = " + CStr(firstsemsub10external) + ", grade = '" + firstsemsub10grade + "'", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                Else
                    Try
                        Dim cmd As New SqlCommand("insert into student_subject_marks values ('" + ExaminationRollNumber.Text + "','" + firstsemestersub10 + "'," + CStr(3) + "," + CStr(firstsemsub10internal) + ", " + CStr(firstsemsub10external) + ",'" + firstsemsub10grade + "')", connection)
                        Dim dr = cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        'MsgBox(ex.ToString)
                        'Exit Sub
                    End Try
                End If

            End If

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
