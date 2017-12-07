Imports excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Data.SqlClient

Public Class insertmultipleprofiles
    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Me.Hide()
    End Sub

    Dim studentgeneraldetails As String = ""
    Dim studentcorrespondenceaddressdetails As String = ""
    Dim studentpermanentaddressdetails As String = ""
    Dim studentguardiandetails As String = ""

    Private Sub selectstudentGeneralInformation_Click(sender As Object, e As EventArgs) Handles selectstudentGeneralInformation.Click
        OpenFileDialog1.Title = "Student General Information File"
        OpenFileDialog1.Filter = "Excel Worksheets|*.xls;*.xlsx"
        If OpenFileDialog1.CheckFileExists Then
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                studentgeneraldetails = OpenFileDialog1.FileName
            End If
        Else
            MsgBox("The specified file does not exits. ", MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub setStudentCorrespondenceAddress_Click(sender As Object, e As EventArgs) Handles setStudentCorrespondenceAddress.Click
        OpenFileDialog1.Title = "Student General Information File"
        OpenFileDialog1.Filter = "Excel Worksheets|*.xls;*.xlsx"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            studentcorrespondenceaddressdetails = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub SetStudentPermanentAddress_Click(sender As Object, e As EventArgs) Handles SetStudentPermanentAddress.Click
        OpenFileDialog1.Title = "Student General Information File"
        OpenFileDialog1.Filter = "Excel Worksheets|*.xls;*.xlsx"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            studentpermanentaddressdetails = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub SetStudentGuardianInformation_Click(sender As Object, e As EventArgs) Handles SetStudentGuardianInformation.Click
        OpenFileDialog1.Title = "Student General Information File"
        OpenFileDialog1.Filter = "Excel Worksheets|*.xls;*.xlsx"

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            studentguardiandetails = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub createProfiles(sender As Object, e As EventArgs) Handles createProfile.Click
        ''''''''''''''''''' FOR STUDENT BASIC DETAILS '''''''''''''''''''''''''''''

        If studentgeneraldetails <> "" Then
            Dim xlApp As excel.Application
            Dim xlWorkBook As excel.Workbook
            Dim xlWorkSheet As excel.Worksheet
            Dim range As excel.Range
            Dim rCnt As Integer

            xlApp = New excel.Application
            xlWorkBook = xlApp.Workbooks.Open(studentgeneraldetails)
            xlWorkSheet = xlWorkBook.Worksheets("sheet1")

            range = xlWorkSheet.UsedRange

            Dim first_name As String = ""
            Dim middle_name As String = ""
            Dim last_name As String = ""
            Dim enrollment_id As String = ""
            Dim examination_roll_number As String = ""

            Dim dept_name As String = ""
            Dim semester As String = ""
            Dim sessin As String = ""
            Dim date_of_birth As String = ""
            Dim category As String = ""
            Dim gender As String = ""

            Dim fathersName As String = ""
            Dim mobile_number As String = ""
            Dim email_id As String = ""
            Dim aadhaarNumber As String = ""

            For rCnt = 1 To range.Rows.Count

                first_name = range.Cells(rCnt, 1).value
                middle_name = range.Cells(rCnt, 2).value
                last_name = range.Cells(rCnt, 3).value
                enrollment_id = range.Cells(rCnt, 4).value
                examination_roll_number = range.Cells(rCnt, 5).value

                dept_name = range.Cells(rCnt, 6).value
                semester = range.Cells(rCnt, 7).value
                sessin = range.Cells(rCnt, 8).value
                date_of_birth = range.Cells(rCnt, 9).value
                category = range.Cells(rCnt, 10).value
                gender = range.Cells(rCnt, 11).value

                fathersName = range.Cells(rCnt, 12).value
                mobile_number = range.Cells(rCnt, 13).value
                email_id = range.Cells(rCnt, 14).value
                aadhaarNumber = range.Cells(rCnt, 15).value

                If checkStudentGeneralDetails(rCnt, first_name, middle_name, last_name, enrollment_id, dept_name, semester, date_of_birth, category, gender, fathersName, mobile_number, email_id, aadhaarNumber) Then
                    Try
                        Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
                        Dim connection As New SqlConnection(connectionstring)

                        connection.Open()
                        Try
                            If CreateProfile.Text.Trim() = "Create Profiles" Then
                                Dim cmd As New SqlCommand("insert into student_basic_details values ('" & enrollment_id & "', '" & first_name & "', '" & middle_name & "','" & last_name & "', '" & date_of_birth & "','" & semester & "','" & examination_roll_number & "','" & category & "','" & email_id & "','" & mobile_number & "','" & dept_name & "','" & fathersName & "'," & aadhaarNumber & ", '" & sessin & "', '" & gender & "')", connection)
                                Dim dr = cmd.ExecuteNonQuery()
                                MsgBox("Profile created for row " + CStr(rCnt))
                            ElseIf CreateProfile.Text.Trim() = "Update Profiles" Then
                                Dim cmd As New SqlCommand("update student_basic_details set enroll_id = '" & enrollment_id & "', first_name =  '" & first_name & "',middle_name = '" & middle_name & "',last_name = '" & last_name & "',date_of_birth = '" & date_of_birth & "', current_semester = '" & semester & "', category ='" & category & "', email_id ='" & email_id & "', phone_number = '" & mobile_number & "', dept_name = '" & dept_name & "', fathers_name = '" & fathersName & "', aadhaar_number = " & aadhaarNumber & ", session = '" & sessin & "', gender = '" & gender & "' where examination_roll_number = '" & examination_roll_number & "'", connection)
                                Dim dr = cmd.ExecuteNonQuery()
                                MsgBox("Profile updated for row " + CStr(rCnt))
                            End If

                        Catch ex As Exception
                            MsgBox(ex.Message)

                            xlWorkBook.Close()
                            xlApp.Quit()
                            releaseObject(xlApp)
                            releaseObject(xlWorkBook)
                            releaseObject(xlWorkSheet)
                            Exit Sub
                        End Try
                        connection.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)

                        xlWorkBook.Close()
                        xlApp.Quit()
                        releaseObject(xlApp)
                        releaseObject(xlWorkBook)
                        releaseObject(xlWorkSheet)
                        Exit Sub
                    End Try

                End If
            Next

            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
        End If
        ''''''''''''''''''''FOR STUDENT CORRESPONDENCE ADDRESS ''''''''''''''''''''''''

        If studentcorrespondenceaddressdetails <> "" Then
            Dim examination_roll_number As String = ""
            Dim street_address As String = ""
            Dim city As String = ""
            Dim state As String = ""
            Dim pincode As String = ""

            Dim xlApp As excel.Application
            Dim xlWorkBook As excel.Workbook
            Dim xlWorkSheet As excel.Worksheet
            Dim range As excel.Range
            Dim rCnt As Integer

            xlApp = New excel.Application
            xlWorkBook = xlApp.Workbooks.Open(studentcorrespondenceaddressdetails)
            xlWorkSheet = xlWorkBook.Worksheets("sheet1")

            range = xlWorkSheet.UsedRange

            For rCnt = 1 To range.Rows.Count

                examination_roll_number = range.Cells(rCnt, 1).value
                street_address = range.Cells(rCnt, 2).value
                city = range.Cells(rCnt, 3).value
                state = range.Cells(rCnt, 4).value
                pincode = range.Cells(rCnt, 5).value

                If checkCorrespondenceAddressDetails(rCnt, examination_roll_number, street_address, city, state, pincode) Then
                    Try
                        Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
                        Dim connection As New SqlConnection(connectionstring)

                        connection.Open()
                        Try
                            If CreateProfile.Text.Trim() = "Create Profiles" Then
                                Dim cmd As New SqlCommand("insert into address_correspondence values ('" & examination_roll_number & "', '" & city & "', '" & state & "','" & pincode & "', '" & street_address & "')", connection)
                                Dim dr = cmd.ExecuteNonQuery()

                                MsgBox(" Correspondence address created for row " + CStr(rCnt) + "")
                            ElseIf CreateProfile.Text.Trim() = "Update Profiles" Then
                                Dim cmd As New SqlCommand("update address_correspondence values set set city = '" & city & "', state = '" & state & "',pincode = '" & pincode & "',street_address = '" & street_address & "' where student_roll_number = '" + examination_roll_number + "'", connection)
                                Dim dr = cmd.ExecuteNonQuery()

                                MsgBox(" Correspondence address Updated for row " + CStr(rCnt) + "")
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                            MsgBox(ex.ToString)
                            Exit Sub
                        End Try
                        connection.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End If
            Next

            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
        End If

        ''''''''''''''''''' FOR STUDENT PERMANENT ADDRESS '''''''''''''''''''''''
        If studentpermanentaddressdetails <> "" Then
            Dim examination_roll_number As String = ""
            Dim street_address As String = ""
            Dim city As String = ""
            Dim state As String = ""
            Dim pincode As String = ""

            Dim xlApp As excel.Application
            Dim xlWorkBook As excel.Workbook
            Dim xlWorkSheet As excel.Worksheet
            Dim range As excel.Range
            Dim rCnt As Integer

            xlApp = New excel.Application
            xlWorkBook = xlApp.Workbooks.Open(studentcorrespondenceaddressdetails)
            xlWorkSheet = xlWorkBook.Worksheets("sheet1")

            range = xlWorkSheet.UsedRange

            For rCnt = 1 To range.Rows.Count

                examination_roll_number = range.Cells(rCnt, 1).value
                street_address = range.Cells(rCnt, 2).value
                city = range.Cells(rCnt, 3).value
                state = range.Cells(rCnt, 4).value
                pincode = range.Cells(rCnt, 5).value

                If checkCorrespondenceAddressDetails(rCnt, examination_roll_number, street_address, city, state, pincode) Then
                    Try
                        Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
                        Dim connection As New SqlConnection(connectionstring)

                        connection.Open()
                        Try
                            If CreateProfile.Text.Trim() = "Create Profiles" Then
                                Dim cmd As New SqlCommand("insert into address_permanent values ('" & examination_roll_number & "', '" & city & "', '" & state & "','" & pincode & "', '" & street_address & "')", connection)
                                Dim dr = cmd.ExecuteNonQuery()

                                MsgBox(" Succeeded !! Permanent address details added for " + CStr(examination_roll_number))
                            ElseIf CreateProfile.Text.Trim() = "Update Profiles" Then
                                Dim cmd As New SqlCommand("update address_permanent set city = '" & city & "',state = '" & state & "',pincode = '" & pincode & "',street_address = '" & street_address & "' where examination_roll_number = '" + examination_roll_number + "'", connection)
                                Dim dr = cmd.ExecuteNonQuery()

                                MsgBox(" Succeeded !! Permanent address details updated for " + CStr(examination_roll_number))
                            End If

                        Catch ex As Exception
                            MsgBox(ex.Message)
                            MsgBox(ex.ToString)
                            Exit Sub
                        End Try
                        connection.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End If
            Next

            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)

        End If

        If studentguardiandetails <> "" Then
            Dim examination_roll_number As String = ""
            Dim name As String = ""
            Dim relationship As String = ""
            Dim address As String = ""
            Dim mobile_number As String = ""
            Dim email_id As String = ""

            Dim xlApp As excel.Application
            Dim xlWorkBook As excel.Workbook
            Dim xlWorkSheet As excel.Worksheet
            Dim range As excel.Range
            Dim rCnt As Integer

            xlApp = New excel.Application
            xlWorkBook = xlApp.Workbooks.Open(studentcorrespondenceaddressdetails)
            xlWorkSheet = xlWorkBook.Worksheets("sheet1")

            range = xlWorkSheet.UsedRange

            For rCnt = 1 To range.Rows.Count

                examination_roll_number = range.Cells(rCnt, 1).value
                name = range.Cells(rCnt, 2).value
                relationship = range.Cells(rCnt, 3).value
                address = range.Cells(rCnt, 4).value
                mobile_number = range.Cells(rCnt, 5).value
                email_id = range.Cells(rCnt, 6).value

                If checkGuardianDetails(rCnt, examination_roll_number, name, relationship, address, mobile_number, email_id) Then
                    Try
                        Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
                        Dim connection As New SqlConnection(connectionstring)

                        connection.Open()
                        Try
                            If CreateProfile.Text.Trim() = "Create Profiles" Then
                                Dim cmd As New SqlCommand("insert into guardian_information values ('" & examination_roll_number & "', '" & name & "', '" & relationship & "','" & address & "', '" & mobile_number & "', '" & email_id & "')", connection)
                                Dim dr = cmd.ExecuteNonQuery()

                                MsgBox(" Succeeded !! Guardian Details Added for " + CStr(examination_roll_number))

                            ElseIf CreateProfile.Text.Trim() = "Update Profiles" Then
                                Dim cmd As New SqlCommand("update guardian_information set name = '" & name & "',relationship = '" & relationship & "', address_details = '" & address & "',mobile_number = '" & mobile_number & "',email_id = '" & email_id & "' where student_roll_number = '" + examination_roll_number + "'", connection)
                                Dim dr = cmd.ExecuteNonQuery()

                                MsgBox(" Succeeded !! Guardian Details updated for " + CStr(examination_roll_number))
                            End If

                        Catch ex As Exception
                            MsgBox(ex.Message)
                            MsgBox(ex.ToString)
                            Exit Sub
                        End Try
                        connection.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End If
            Next

            xlWorkBook.Close()
            xlApp.Quit()

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
        End If

    End Sub

    Private Function checkStudentGeneralDetails(ByVal rowindex As Integer, ByVal first_name As String, ByVal middle_name As String, ByVal last_name As String, ByVal enrollment_id As String, ByVal dept_name As String, ByVal semester As String, ByVal date_of_birth As String, ByVal category As String, ByVal gender As String, ByVal fathersName As String, ByVal mobile_number As String, ByVal email_id As String, ByVal aadhaarNumber As String) As Boolean
        Return True
    End Function

    Private Function checkCorrespondenceAddressDetails(ByVal rowindex As Integer, ByVal examination_roll_number As String, ByVal street_address As String, ByVal city As String, ByVal state As String, ByVal pincode As String) As Boolean
        Return True
    End Function

    Private Function checkGuardianDetails(ByVal rowindex As Integer, ByVal examination_roll_number As String, ByVal name As String, ByVal relationship As String, ByVal address_detail As String, ByVal mobile_number As String, ByVal email_id As String) As Boolean

        Return True
    End Function

    Private Sub CreateProfile_Click(sender As Object, e As EventArgs) Handles CreateProfile.Click

    End Sub
End Class