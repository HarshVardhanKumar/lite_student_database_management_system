Imports System.Data.SqlClient
Public Class controller

    ' this class acts as a global class for the whole application. It can be used to set the "global" variables for normal program logic.

    ' this function is called whenever the user presses the exit button on the top of the title bar'
    Public Sub endAll()
        My.Forms.homepage.Close()
        My.Forms.addstudentprofile.Close()
        My.Forms.Form1.Close()
        My.Forms.AddProfileOptions.Close()
        My.Forms.findForm.Close()
        My.Forms.UpdateProfileOptions.Close()
        My.Forms.editstudentprofile.Close()
    End Sub

    Public Sub initializeEditProfile(ByVal rollnumber As String)


        Try
            Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
            Dim connection As New SqlConnection(connectionstring)

            connection.Open()
            Try
                Dim cmd As New SqlCommand("select * from student_basic_details where examination_roll_number = '" + rollnumber + "';", connection)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim dt As New DataTable
                dt.Load(reader)

                Dim row As DataRow = dt.Rows.Item(0)

                Dim profile = My.Forms.editstudentprofile

                profile.FnameTextBox.Text = row.Item("first_name")
                profile.MnameTextBox.Text = row.Item("middle_name")
                profile.LNametextbox.Text = row.Item("last_name")
                profile.dateofbirth.Value = row.Item("date_of_birth")
                profile.gender.Text = row.Item("gender")

                profile.enrollmentTextBox.Text = row.Item("enroll_id")
                profile.departmentBox.SelectedItem = row.Item("dept_name")
                profile.SemesterBox.SelectedItem = row.Item("current_semester")
                profile.ExaminationRollNumber.Text = row.Item("examination_roll_number")
                profile.FathersName.Text = row.Item("fathers_name")

                profile.category.SelectedItem = row.Item("category")
                profile.selectSession.Text = row.Item("session")
                profile.mobileNumber.Text = row.Item("phone_number")
                profile.Email_id.Text = row.Item("email_id")
                profile.aadhaarCard.Text = row.Item("aadhaar_number")

                cmd.CommandText = "select * from address_correspondence where student_roll_number = '" + rollnumber + "'"
                Dim dt2 = New DataTable
                dt2.Load(cmd.ExecuteReader())
                Dim row2 = dt2.Rows.Item(0)

                profile.c_addressline1.Text = row.Item("street_address")
                profile.c_city.Text = row.Item("city")
                profile.c_state.Text = row.Item("state")
                profile.c_pincode.Text = row.Item("pincode")


                cmd.CommandText = "select * from address_permanent where examination_roll_number = '" + rollnumber + "'"
                Dim dt3 = New DataTable
                dt3.Load(cmd.ExecuteReader())
                Dim row3 = dt3.Rows.Item(0)

                profile.p_addressline1.Text = row.Item("street_address")
                profile.p_city.Text = row.Item("city")
                profile.p_state.Text = row.Item("state")
                profile.p_pincode.Text = row.Item("pincode")


                cmd.CommandText = "select * from guardian_information where student_roll_number = '" + rollnumber + "'"
                Dim dt4 = New DataTable
                dt4.Load(cmd.ExecuteReader())
                Dim row4 = dt4.Rows.Item(0)

                profile.guardianname.Text = row.Item("name")
                profile.guardianrelationship.Text = row.Item("relationship")
                profile.guardianaddress.Text = row.Item("address_details")
                profile.guardianmobilenumber.Text = row.Item("mobile_number")
                profile.guardianemail.Text = row.Item("email_id")


            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox(ex.ToString)
                Exit Sub
            End Try
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Function updateStudentProfile(ByVal rollnumber As String, ByVal enroll_id As String, ByVal first_name As String, ByVal middlename As String, ByVal last_name As String, ByVal dob As String, ByVal semester As String, ByVal category As String, ByVal emailid As String, ByVal mobilenumber As String, ByVal department As String, ByVal fathersname As String, ByVal aadhaarno As String, ByVal session As String, ByVal gender As String, ByVal guardianname As String, ByVal relationship As String, ByVal guardianaddress As String, ByVal guardianmobile As String, ByVal guardianemail As String, ByVal c_city As String, ByVal c_state As String, ByVal c_pincode As String, ByVal c_addline1 As String, ByVal p_city As String, ByVal p_state As String, ByVal p_pincode As String, ByVal p_addline1 As String) As Boolean

        If first_name = "" Then
            MsgBox("First Name cannot be empty")
            Return False
        End If

        If middlename = "" Then
            middlename = "  "
        End If

        If last_name = "" Then
            MsgBox("Last name cannot be empty")
            Return False
        End If

        If department = "" Then
            MsgBox("Department cannot be empty")
            Return False
        End If

        If semester = "" Then
            MsgBox("Semester cannot be empty")
            Return False
        End If

        If emailid = "" Then
            MsgBox("Email_id cannot be empty")
            Return False
        End If

        If fathersname = "" Then
            MsgBox("Father name cannot be empty")
            Return False
        End If

        Try
            Dim number As ULong = CULng(mobilenumber)
            'MsgBox("mobile number is " + number)
            If mobilenumber.Length <> 10 Then
                MsgBox("The mobile number must be of 10 digits")
                Return False
            End If
        Catch ex As Exception
            MsgBox("The Mobile Number must be a number of 10 digits")
            Return False
        End Try

        If category = "" Then
            MsgBox("Category cannot be empty")
            Return False
        End If

        Dim aadhaarnumber As ULong = 0
        If aadhaarno.Length > 0 Then
            Try
                Dim number As ULong = CULng(aadhaarno)
                'MsgBox("aadhaar number is " + number)
                If aadhaarno.Length <> 12 Then
                    MsgBox("Aadhaar Number must be a number of 12 digits")
                    Return False
                End If
            Catch ex As Exception
                MsgBox("Aadhaar Number must be a number of 12 digits")
                Return False
            End Try
        Else aadhaarno = "null"
        End If

        If guardianname = "" Then
            MsgBox("Guardian Name cannot be empty")
            Return False
        End If

        If relationship = "" Then
            MsgBox("Relationship cannot be empty")
            Return False
        End If

        Try
            Dim number As ULong = CULng(guardianmobile)
            'MsgBox("mobile number is " + number)
            If guardianmobile.Length <> 10 Then
                MsgBox("The guardian mobile number must be of 10 digits")
                Return False
            End If
        Catch ex As Exception
            MsgBox("The guardian Mobile Number must be a number of 10 digits")
            Return False
        End Try

        If c_city = "" Then
            MsgBox("Correspondence City cannot be null ")
            Return False
        End If

        If c_state = "" Then
            MsgBox("Correspondence State cannot be null")
            Return False
        End If

        Try
            If c_pincode.Length <> 6 Then
                MessageBox.Show("Enter a valid pincode")
                Return False
            End If
            Dim mb As ULong = CULng(c_pincode)
        Catch ex As Exception
            MessageBox.Show("Please enter a valid pincode")
            Return False
        End Try

        If p_city = "" Then
            MsgBox("Permanent City Detail cannot be empty")
            Return False
        End If

        If p_state = "" Then
            MsgBox("Permanent State Detail cannot be empty")
            Return False
        End If

        Try
            If p_pincode.Length <> 6 Then
                MessageBox.Show("Enter a valid pincode")
                Return False
            End If
            Dim mb As UInteger = CInt(p_pincode)
        Catch ex As Exception
            MessageBox.Show("Please enter a valid pincode")
            Return False
        End Try

        ''''''''''''''''''''''''''''''''' UPDATING THE PROFILE '''''''''''''''''''''''''''
        Try
            Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
            Dim connection As New SqlConnection(connectionstring)

            connection.Open()
            Try
                Dim cmd As New SqlCommand("update student_basic_details set first_name = '" + first_name + "', middle_name = '" + middlename + "', last_name = '" + last_name + "', date_of_birth = '" + dob + "', current_semester = '" + semester + "', category = '" + category + "', email_id = '" + emailid + "', phone_number = '" + mobilenumber + "', dept_name = '" + department + "', fathers_name = '" + fathersname + "', aadhaar_number = " + aadhaarno + ", session = '" + session + "', gender = '" + gender + "' where examination_roll_number = '" + rollnumber + "'; update guardian_information set name = '" + guardianname + "', relationship = '" + relationship + "', address_details = '" + guardianaddress + "', mobile_number = '" + guardianmobile + "', email_id = '" + guardianmobile + "'; update address_correspondence set city = '" + c_city + "', state = '" + c_state + "', pincode = '" + c_pincode + "', street_address = '" + c_addline1 + "' where student_roll_number = '" + rollnumber + "'; update address_permanent set city = '" + p_city + "', state = '" + p_state + "', pincode = '" + p_pincode + "', street_address = '" + p_addline1 + "' where examination_roll_number = '" + rollnumber + "'", connection)

                Dim dr = cmd.ExecuteNonQuery()
                MsgBox("Profile Updated ")
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox(ex.ToString)
                Return False
            End Try
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return True
    End Function

End Class
