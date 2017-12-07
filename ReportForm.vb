Imports System.Data.SqlClient

Public Class ReportForm
    Private enrollmenttext As String

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'enrollmenttext = Me.findusingroll_numbers.Text
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles findbyresetbutton.Click
        'Me.findbyemailid.Clear()
        Me.findbydepartment.SelectedIndex = -1
        'Me.findbycgpacomparision.SelectedIndex = -1
        'Me.findbycgpavalue.SelectedIndex = -1
        Me.findbycategory.SelectedIndex = -1
        'Me.findbyattendancecomparision.SelectedIndex = -1
        'Me.findbyattendancevalue.SelectedIndex = -1
        Me.findbyfirstname.Clear()
        Me.findbylastname.Clear()
        'Me.findbymobilenumber.Clear()
        Me.findbysemester.SelectedIndex = -1
        Me.findbysession.SelectedIndex = -1
        Me.findbystate.SelectedIndex = -1
        'Me.findusingroll_numbers.Text = ""
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles findbybackbutton.Click
        Me.Hide()
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub


    Private Sub findbyfindbutton_Click(sender As Object, e As EventArgs) Handles findbyfindbutton.Click
        Dim searchstringrollnumber As String = "("

        searchstringrollnumber = searchstringrollnumber.Substring(0, searchstringrollnumber.Length - 1) + ")"

        Dim searchstringsbd As String = ""

        If findbyfirstname.Text <> "" Then
            searchstringsbd += "first_name = '" + findbyfirstname.Text + "' and "
        End If
        If findbylastname.Text <> "" Then
            searchstringsbd += "last_name = '" + findbylastname.Text + "' and "
        End If

        If findbysemester.SelectedIndex <> -1 Then
            searchstringsbd += "current_semester = '" + findbysemester.SelectedItem.ToString + "' and "
        End If
        If findbysession.SelectedIndex <> -1 Then
            searchstringsbd += "session = '" + findbysession.SelectedItem.ToString + "' and "
        End If
        If findbydepartment.SelectedIndex <> -1 Then
            searchstringsbd += "dept_name = '" + findbydepartment.SelectedItem.ToString + "' and "
        End If
        If findbycategory.SelectedIndex <> -1 Then
            searchstringsbd += "category = '" + findbycategory.SelectedItem.ToString + "' and "
        End If

        If findbystate.SelectedIndex <> -1 Then
            'queystring2 += " union " + querystring3
            searchstringsbd += "address_permanent.state = '" + findbystate.SelectedItem.ToString + "' and "

        End If

        If searchstringsbd.Length > 4 Then
            searchstringsbd = searchstringsbd.Substring(0, searchstringsbd.Length - 4)
        End If

        Dim queystring2 As String = "SELECT enroll_id, first_name, middle_name, dept_name, last_name, date_of_birth, student_basic_details.examination_roll_number, phone_number, fathers_name, email_id  FROM (student_basic_details join address_permanent ON ADDRESS_PERMANENT.EXAMINATION_ROLL_NUMBER = STUDENT_BASIC_DETAILS.EXAMINATION_ROLL_NUMBER) WHERE " + searchstringsbd + ""
        'Dim queystring2 As String = "select enroll_id, first_name, middle_name, dept_name, last_name, date_of_birth, examination_roll_number, phone_number, fathers_name from student_basic_details where " + searchstringsbd

        'Dim queystring1 As String = "select enroll_id, first_name, middle_name, dept_name, last_name, date_of_birth, examination_roll_number, phone_number, fathers_name, email_id from student_basic_details where examination_roll_number in " + searchstringrollnumber
        Dim finalsearch As String = queystring2

        Try
            Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
            Dim connection As New SqlConnection(connectionstring)

            connection.Open()
            Try
                Dim cmd As New SqlCommand(finalsearch, connection)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                Dim dt As New DataTable
                dt.Load(reader)

                Dim row As DataRow
                If dt.Rows.Count > 0 Then
                    For Each row In dt.Rows
                        My.Forms.ResultsList.DataGridView1.Rows.Add(row.Item("enroll_id"), row.Item("first_name"), row.Item("middle_name"), row.Item("last_name"), row.Item("Fathers_Name"), row.Item("date_of_birth").tolongdatestring(), row.Item("dept_name"), row.Item("examination_roll_number"), row.Item("phone_number"), row.Item("email_id"))
                    Next
                    My.Forms.ResultsList.ShowDialog()
                Else MessageBox.Show("No such profile found", "Find Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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

    End Sub

    Private Sub findusingenrollment_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub findbylastname_TextChanged(sender As Object, e As EventArgs) Handles findbylastname.TextChanged

    End Sub

    Private Sub findbysemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles findbysemester.SelectedIndexChanged

    End Sub

    Private Sub findbydepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles findbydepartment.SelectedIndexChanged

    End Sub

    Private Sub findbycategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles findbycategory.SelectedIndexChanged

    End Sub
End Class
