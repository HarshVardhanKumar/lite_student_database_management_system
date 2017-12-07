Imports System.Data.SqlClient
Imports System.IO
Public Class UpdateProfileOptions
    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Dim roll_number As String = ""
        roll_number = InputBox("Enter the Examination Roll Number of the student, whose profile needs to be updated.", "Examination Roll Number", "15103009")

        'Now make a connection with the database and retrieve values to initialize the edit form. Show the profile
        If roll_number <> "" Then
            Try
                Dim connectionstrin = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
                Dim connectio As New SqlConnection(connectionstrin)

                connectio.Open()
                Dim searchstring1 As String = "select enroll_id, first_name, middle_name, last_name, category, phone_number, student_basic_details.email_id, p.examination_roll_number, date_of_birth, current_semester, dept_name, fathers_name, session, c.city AS c_city, c.state AS c_state, c.pincode AS c_pincode, c.street_address AS c_street_address,p.city AS p_city, p.state AS p_state, p.pincode AS p_pincode, p.street_address AS p_street_address, guardian.name as gname, guardian.relationship as grelationship, guardian.address_details as gaddress, guardian.mobile_number as gmobile, guardian.email_id as gemail from student_basic_details, address_correspondence as c, address_permanent as p, guardian_information as guardian where student_basic_details.examination_roll_number = c.student_roll_number and student_basic_details.examination_roll_number = p.examination_roll_number AND student_basic_details.examination_roll_number = guardian.student_roll_number and student_basic_details.examination_roll_number = '" + roll_number + "'"
                Try
                    Dim cmd As New SqlCommand(searchstring1, connectio)
                    Dim reader As SqlDataReader = cmd.ExecuteReader()

                    Dim dt As New DataTable
                    dt.Load(reader)

                    Dim row As DataRow = dt.Rows.Item(0)

                    ' initialize the value in studentprofile

                    Dim profile = My.Forms.studentProfile
                    Dim editprofile = My.Forms.editstudentprofile
                    Dim controller As New controller       ' controller.vb class

                    profile.studentname.Text = row.Item("first_name") + row.Item("middle_name") + row.Item("last_name")
                    editprofile.FnameTextBox.Text = row.Item("first_name")
                    editprofile.MnameTextBox.Text = row.Item("middle_name")
                    editprofile.LNametextbox.Text = row.Item("last_name")

                    profile.fathername.Text = row.Item("fathers_name")
                    editprofile.FathersName.Text = row.Item("fathers_name")

                    profile.session.Text = row.Item("session")
                    editprofile.selectSession.Text = row.Item("session")

                    profile.semester.Text = row.Item("current_semester")
                    editprofile.SemesterBox.Text = row.Item("current_semester")

                    profile.enrollment_number.Text = row.Item("enroll_id")
                    editprofile.enrollmentTextBox.Text = row.Item("enroll_id")

                    profile.category.Text = row.Item("category")
                    editprofile.category.Text = row.Item("category")

                    profile.mobile_number.Text = row.Item("phone_number")
                    editprofile.mobileNumber.Text = row.Item("phone_number")

                    profile.email_id.Text = row.Item("email_id")
                    editprofile.Email_id.Text = row.Item("email_id")

                    profile.dob.Text = row.Item("date_of_birth").ToLongDateString()
                    editprofile.dateofbirth.Value = row.Item("date_of_birth")

                    profile.roll_number.Text = row.Item("examination_roll_number")
                    editprofile.ExaminationRollNumber.Text = row.Item("examination_roll_number")

                    profile.correspondenceaddress.Text = " Street Address : " + row.Item("c_street_address") + " , City : " + row.Item("c_city") + " , State : " + row.Item("c_state") + " , Pincode : " + row.Item("c_pincode")
                    editprofile.c_addressline1.Text = row.Item("c_street_address")
                    editprofile.c_city.Text = row.Item("c_city")
                    editprofile.c_state.Text = row.Item("c_state")
                    editprofile.c_pincode.Text = row.Item("c_pincode")

                    profile.permanentaddress.Text = " Street Address : " + row.Item("p_street_address") + " , City : " + row.Item("p_city") + " , State : " + row.Item("p_state") + " , Pincode : " + row.Item("p_pincode")
                    editprofile.p_addressline1.Text = row.Item("p_street_address")
                    editprofile.p_city.Text = row.Item("p_city")
                    editprofile.p_state.Text = row.Item("p_state")
                    editprofile.p_pincode.Text = row.Item("p_pincode")

                    profile.department.Text = row.Item("dept_name")
                    editprofile.departmentBox.Text = row.Item("dept_name")

                    editprofile.guardianname.Text = row.Item("gname")
                    editprofile.guardianrelationship.Text = row.Item("grelationship")
                    editprofile.guardianemail.Text = row.Item("gemail")
                    editprofile.guardianaddress.Text = row.Item("gaddress")

                    Dim cmd2 = New SqlCommand("select Profile_picture from TableProfilePicture where examination_roll_number ='" &
             roll_number & "'", connectio)
                    Try
                        Dim imageData As Byte() = DirectCast(cmd2.ExecuteScalar(), Byte())
                        If Not imageData Is Nothing Then
                            Using ms As New MemoryStream(imageData, 0, imageData.Length)
                                ms.Write(imageData, 0, imageData.Length)
                                editprofile.PictureBox1.Image = Image.FromStream(ms, True)
                                profile.PictureProfileView.Image = Image.FromStream(ms, True)
                            End Using
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        MsgBox(ex.ToString)
                    End Try

                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox(ex.ToString)
                    Exit Sub
                End Try
                connectio.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            ''''''''''''''' for the first semester '''''''''''''''''''''''''''
            Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
            Dim connection As New SqlConnection(connectionstring)

            connection.Open()
            Dim selected_roll_number = roll_number
            Dim searchstrings = "select course_id, internal_marks, external_marks, grade from student_subject_marks where roll_number = '" + selected_roll_number + "' and semester = '1'"

            Try
                Dim cmd As New SqlCommand(searchstrings, connection)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim dt As New DataTable
                dt.Load(reader)

                Dim editprofile = My.Forms.editstudentprofile

                Dim count = dt.Rows.Count
                Dim row As DataRow
                If count > 0 Then
                    'Dim search As String = "select course_name from course_details where course_id = '" + +"'"
                    row = dt.Rows.Item(0)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then
                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox3.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))
                        My.Forms.editstudentprofile.TextBox94.Text = CStr(row.Item(1))
                        My.Forms.editstudentprofile.TextBox65.Text = CStr(row.Item(2))
                        My.Forms.editstudentprofile.TextBox66.Text = CStr(row.Item(3))

                        'MsgBox(row.Item(0) + " " + CStr(row.Item(1)) + " " + CStr(row.Item(2)) + " " + CStr(row.Item(3)))
                    End If
                End If

                If count > 1 Then
                    row = dt.Rows.Item(1)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then
                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox5.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))
                        editprofile.TextBox93.Text = row.Item(1)
                        editprofile.TextBox67.Text = row.Item(2)
                        editprofile.TextBox68.Text = row.Item(3)
                    End If
                End If

                If count > 2 Then
                    row = dt.Rows.Item(2)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox4.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))


                        'editprofile.ComboBox4.Text = row.Item(0)
                        editprofile.TextBox92.Text = row.Item(1)
                        editprofile.TextBox69.Text = row.Item(2)
                        editprofile.TextBox70.Text = row.Item(3)
                    End If
                End If

                If count > 3 Then
                    row = dt.Rows.Item(3)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox6.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox6.Text = row.Item(0)
                        editprofile.TextBox91.Text = row.Item(1)
                        editprofile.TextBox71.Text = row.Item(2)
                        editprofile.TextBox72.Text = row.Item(3)
                    End If
                End If

                If count > 4 Then
                    row = dt.Rows.Item(4)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox7.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox7.Text = row.Item(0)
                        editprofile.TextBox90.Text = row.Item(1)
                        editprofile.TextBox73.Text = row.Item(2)
                        editprofile.TextBox74.Text = row.Item(3)
                    End If
                End If

                If count > 5 Then
                    row = dt.Rows.Item(5)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox8.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox8.Text = row.Item(0)
                        editprofile.TextBox89.Text = row.Item(1)
                        editprofile.TextBox75.Text = row.Item(2)
                        editprofile.TextBox76.Text = row.Item(3)
                    End If
                End If

                If count > 6 Then
                    row = dt.Rows.Item(6)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox9.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox9.Text = row.Item(0)
                        editprofile.TextBox88.Text = row.Item(1)
                        editprofile.TextBox77.Text = row.Item(2)
                        editprofile.TextBox78.Text = row.Item(3)
                    End If
                End If

                If count > 7 Then
                    row = dt.Rows.Item(7)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox10.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox10.Text = row.Item(0)
                        editprofile.TextBox87.Text = row.Item(1)
                        editprofile.TextBox79.Text = row.Item(2)
                        editprofile.TextBox80.Text = row.Item(3)
                    End If
                End If

                If count > 8 Then
                    row = dt.Rows.Item(8)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox11.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox11.Text = row.Item(0)
                        editprofile.TextBox86.Text = row.Item(1)
                        editprofile.TextBox81.Text = row.Item(2)
                        editprofile.TextBox82.Text = row.Item(3)
                    End If
                End If

                If count >= 9 Then
                    row = dt.Rows.Item(9)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox12.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox12.Text = row.Item(0)
                        editprofile.TextBox85.Text = row.Item(1)
                        editprofile.TextBox83.Text = row.Item(2)
                        editprofile.TextBox84.Text = row.Item(3)
                    End If
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            ''''''''''''''' for the second semestr ''''''''''''''''''''''''''
            Dim searchstring = "select course_id, internal_marks, external_marks, grade from student_subject_marks where roll_number = '" + selected_roll_number + "' and semester = '2'"

            Try
                Dim cmd As New SqlCommand(searchstring, connection)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim dt As New DataTable
                dt.Load(reader)

                Dim editprofile = My.Forms.editstudentprofile

                Dim count = dt.Rows.Count
                Dim row As DataRow
                If count > 0 Then
                    'Dim search As String = "select course_name from course_details where course_id = '" + +"'"
                    row = dt.Rows.Item(0)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then
                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox20.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))
                        My.Forms.editstudentprofile.TextBox35.Text = CStr(row.Item(1))
                        My.Forms.editstudentprofile.TextBox34.Text = CStr(row.Item(2))
                        My.Forms.editstudentprofile.TextBox33.Text = CStr(row.Item(3))

                        'MsgBox(row.Item(0) + " " + CStr(row.Item(1)) + " " + CStr(row.Item(2)) + " " + CStr(row.Item(3)))
                    End If
                End If

                If count > 1 Then
                    row = dt.Rows.Item(1)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then
                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox19.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))
                        editprofile.TextBox32.Text = row.Item(1)
                        editprofile.TextBox31.Text = row.Item(2)
                        editprofile.TextBox30.Text = row.Item(3)
                    End If
                End If

                If count > 2 Then
                    row = dt.Rows.Item(2)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox18.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))


                        'editprofile.ComboBox4.Text = row.Item(0)
                        editprofile.TextBox29.Text = row.Item(1)
                        editprofile.TextBox28.Text = row.Item(2)
                        editprofile.TextBox27.Text = row.Item(3)
                    End If
                End If

                If count > 3 Then
                    row = dt.Rows.Item(3)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox17.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox6.Text = row.Item(0)
                        editprofile.TextBox26.Text = row.Item(1)
                        editprofile.TextBox25.Text = row.Item(2)
                        editprofile.TextBox24.Text = row.Item(3)
                    End If
                End If

                If count > 4 Then
                    row = dt.Rows.Item(4)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox16.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox7.Text = row.Item(0)
                        editprofile.TextBox23.Text = row.Item(1)
                        editprofile.TextBox22.Text = row.Item(2)
                        editprofile.TextBox21.Text = row.Item(3)
                    End If
                End If

                If count > 5 Then
                    row = dt.Rows.Item(5)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox15.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox8.Text = row.Item(0)
                        editprofile.TextBox20.Text = row.Item(1)
                        editprofile.TextBox19.Text = row.Item(2)
                        editprofile.TextBox18.Text = row.Item(3)
                    End If
                End If

                If count > 6 Then
                    row = dt.Rows.Item(6)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox14.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox9.Text = row.Item(0)
                        editprofile.TextBox17.Text = row.Item(1)
                        editprofile.TextBox16.Text = row.Item(2)
                        editprofile.TextBox15.Text = row.Item(3)
                    End If
                End If

                If count > 7 Then
                    row = dt.Rows.Item(7)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox13.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox10.Text = row.Item(0)
                        editprofile.TextBox14.Text = row.Item(1)
                        editprofile.TextBox13.Text = row.Item(2)
                        editprofile.TextBox12.Text = row.Item(3)
                    End If
                End If

                If count > 8 Then
                    row = dt.Rows.Item(8)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox2.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox11.Text = row.Item(0)
                        editprofile.TextBox7.Text = row.Item(1)
                        editprofile.TextBox6.Text = row.Item(2)
                        editprofile.TextBox5.Text = row.Item(3)
                    End If
                End If

                If count >= 9 Then
                    row = dt.Rows.Item(9)
                    If row.Item(0) <> "" And row.Item(1) <> 0 And row.Item(2) <> 0 And row.Item(3) <> "" Then

                        Dim searchcourse_name As String = "select course_name from course_detail where course_id = '" & CStr(row.Item(0)) & "'"
                        Dim cmd2 As New SqlCommand(searchcourse_name, connection)
                        Dim readercourse = cmd2.ExecuteReader()
                        Dim dt2 As New DataTable
                        dt2.Load(readercourse)

                        My.Forms.editstudentprofile.ComboBox1.SelectedItem = CStr(row.Item(0)) + "    " + CStr(dt2.Rows.Item(0).Item("course_name"))

                        'editprofile.ComboBox12.Text = row.Item(0)
                        editprofile.TextBox4.Text = row.Item(1)
                        editprofile.TextBox3.Text = row.Item(2)
                        editprofile.TextBox1.Text = row.Item(3)
                    End If
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            My.Forms.editstudentprofile.ShowDialog()
        End If

        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    ' used to set the caller form for this form'
    Private caller As Form
    Public Sub setCaller(ByRef callerF As Form)
        caller = callerF
    End Sub

    Private Sub BunifuTileButton2_Click(sender As Object, e As EventArgs) Handles BunifuTileButton2.Click
        My.Forms.insertmultipleprofiles.CreateProfile.Text = "Update Profiles"
        My.Forms.insertmultipleprofiles.ShowDialog()
        Me.Hide()
    End Sub
End Class
