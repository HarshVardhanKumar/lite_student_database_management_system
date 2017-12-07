Imports System.Data.SqlClient

Public Class Form1

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles TextBox1.MouseClick
        TextBox1.Text = ""
    End Sub
    Private Sub TextBox2_MouseEnter(sender As Object, e As EventArgs) Handles TextBox2.MouseClick
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"c
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave
        If (TextBox1.Text = "") Then
            TextBox1.Text = "Enter your username"
        End If
    End Sub

    Private Sub TextBox2_MouseLeave(sender As Object, e As EventArgs) Handles TextBox2.MouseLeave
        If (TextBox2.Text = "") Then
            Dim x As Char = Chr(0)
            TextBox2.PasswordChar = x
            TextBox2.Text = "Enter password"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'verify authentication 
        TextBox3.Clear()
        Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
        Dim connection As New SqlConnection(connectionstring)

        connection.Open()
        Dim command As New SqlCommand("Select * from login_user where username = '" + TextBox1.Text + "'", connection)
        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim dt As New DataTable
        dt.Load(reader)

        If dt.Rows.Count <= 0 Then
            ' user not found
            TextBox3.Text = "User Not found !!"
            Exit Sub
        End If

        Dim row As DataRow
        For Each row In dt.Rows
            If row.Item("password") = TextBox2.Text Then
                ' login done 
                My.Forms.homepage.Show()
                Me.Hide()
            Else textbox3.text = "Invalid Credentials !! "
            End If
        Next

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '''''''''''''''' initializing the courses in the combo box'''''''''''''''

        Dim connectionstring = "Data Source=PC;Initial Catalog=master;Integrated Security=True"
        Dim connection As New SqlConnection(connectionstring)

        connection.Open()
        Dim command As New SqlCommand("Select * from course_detail", connection)
        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim dt As New DataTable
        dt.Load(reader)

        Dim addprofile = My.Forms.addstudentprofile
        Dim createprofile = My.Forms.editstudentprofile

        Dim row As DataRow
        For Each row In dt.Rows
            If row.Item("semester") = 12 Then

                addprofile.ComboBox3.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox4.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox5.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox6.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox7.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox8.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox9.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox10.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox11.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox12.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

                createprofile.ComboBox3.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox4.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox5.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox6.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox7.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox8.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox9.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox10.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox11.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox12.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))



                addprofile.ComboBox13.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox14.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox15.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox16.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox17.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox18.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox19.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox20.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox1.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox2.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

                createprofile.ComboBox13.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox14.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox15.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox16.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox17.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox18.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox19.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox20.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox1.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox2.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

            ElseIf row.Item("semester") = 3 Then

                addprofile.ComboBox30.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox29.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox28.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox27.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox26.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox25.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox24.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox23.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox21.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox22.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

                createprofile.ComboBox30.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox29.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox28.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox27.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox26.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox25.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox24.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox23.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox21.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox22.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

            ElseIf row.Item("semester") = 4 Then

                addprofile.ComboBox40.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox39.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox38.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox37.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox36.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox35.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox34.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox33.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox31.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox32.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

                createprofile.ComboBox40.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox39.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox38.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox37.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox36.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox35.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox34.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox33.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox31.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox32.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

            ElseIf row.Item("semester") = 5 Then

                addprofile.S5_1.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s_5_9.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s5_3.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s5_2.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s5_4.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s5_5.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s5_6.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s5_7.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s5_8.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s_5_10.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

                createprofile.S5_1.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s_5_9.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s5_3.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s5_2.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s5_4.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s5_5.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s5_6.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s5_7.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s5_8.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s_5_10.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

            ElseIf row.Item("semester") = 6 Then

                addprofile.s_6_1.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s_6_9.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s_6_3.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s_6_2.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s_6_4.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s_6_6.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s_6_5.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s_6_7.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s_6_8.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.s_6_10.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

                createprofile.s_6_1.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s_6_9.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s_6_3.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s_6_2.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s_6_4.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s_6_6.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s_6_5.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s_6_7.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s_6_8.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.s_6_10.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

            ElseIf row.Item("semester") = 7 Then

                addprofile.ComboBox70.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox69.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox68.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox67.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox66.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox65.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox64.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox63.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox61.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox62.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

                createprofile.ComboBox70.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox69.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox68.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox67.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox66.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox65.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox64.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox63.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox61.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox62.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

            ElseIf row.Item("semester") = 8 Then

                addprofile.ComboBox80.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox79.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox78.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox77.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox76.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox75.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox74.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox73.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox71.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox72.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

                createprofile.ComboBox80.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox79.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox78.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox77.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox76.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox75.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox74.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox73.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox71.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox72.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

            ElseIf row.Item("semester") = 78 Then

                addprofile.ComboBox70.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox69.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox68.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox67.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox66.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox65.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox64.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox63.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox61.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox62.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

                createprofile.ComboBox70.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox69.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox68.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox67.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox66.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox65.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox64.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox63.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox61.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox62.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))


                addprofile.ComboBox80.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox79.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox78.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox77.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox76.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox75.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox74.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox73.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox71.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                addprofile.ComboBox72.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

                createprofile.ComboBox80.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox79.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox78.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox77.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox76.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox75.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox74.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox73.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox71.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))
                createprofile.ComboBox72.Items.Add(row.Item("course_id") + "    " + row.Item("course_name"))

            End If
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


    End Sub
End Class
