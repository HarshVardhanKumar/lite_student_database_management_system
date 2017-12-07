Imports System.Net.Mail
Imports System.Net

Public Class MAILSEND
    Private Sub MAILSEND_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveFileDialog3_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub RichTextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox5_TextChanged(sender As Object, e As EventArgs) Handles tomailaddress.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles sendmailbutton.Click
        Dim receiveremailaddress = tomailaddress.Text.Split(";")
        Dim alsoreceivemailaddress = ccmailaddress.Text
        Dim subjectofmail = mailsubject.Text
        Dim mailmessages = mailmessage.Text

        Dim mail As New MailMessage()
        mail.From = New MailAddress("itggu.cse.contact@gmail.com")
        mail.Subject = subjectofmail
        mail.Body = mailmessages + vbNewLine + "Please do not reply to this mail."
        mail.IsBodyHtml = True

        Dim receiver As String
        For Each receiver In receiveremailaddress

            Try
                mail.To.Add(receiver)

                ' Attachments
                'Console.WriteLine("Add attachment")
                'Dim attachedFile As String = "<attached file path>"
                'mail.Attachments.Add(New Attachment(attachedFile))

                ' Embedded image in the message body
                'Console.WriteLine("Embed image")
                'mail.Body += "<br/><img alt="""" src=""cid:image1"">"

                'Dim imgFile As String = "<image file path>"
                'Dim htmlView As AlternateView =
                'AlternateView.CreateAlternateViewFromString(mail.Body, Nothing,
                '                                            "text/html")
                'Dim imgLink As LinkedResource = New LinkedResource(imgFile,
                '                                                  "image/jpg")
                'imgLink.ContentId = "image1"
                'imgLink.TransferEncoding = System.Net.Mime.TransferEncoding.Base64
                ' htmlView.LinkedResources.Add(imgLink)
                'mail.AlternateViews.Add(htmlView)


                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ' Configure the SMTP client and send the email.
                ' 

                ' Configure the SMTP client
                Dim smtp As New SmtpClient()
                smtp.Port = 587
                smtp.Host = "smtp.gmail.com"
                smtp.Credentials = New NetworkCredential("itggu.cse.contact@gmail.com", "adminadmin")
                smtp.EnableSsl = True

                ' Send the email
                'MessageBox.Show("Sending email to " + receiver + "...", "Sending Mail", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Try
                    smtp.Send(mail)
                    My.Forms.MAILSEND.Cursor = Cursors.WaitCursor
                    MessageBox.Show("Mail Sent to " + receiver + "!!", "Mail Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    My.Forms.MAILSEND.Cursor = Cursors.Default
                    Me.Hide()
                Catch ex As Exception
                    MessageBox.Show("sending mail to " + receiver + " failed", "Sending Mail", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error)
                End Try
            Catch ex As Exception
                MsgBox(ex.Message, MessageBoxIcon.Error)
            End Try
        Next

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox8_TextChanged(sender As Object, e As EventArgs) Handles ccmailaddress.TextChanged

    End Sub

    Private Sub RichTextBox4_TextChanged_1(sender As Object, e As EventArgs) Handles RichTextBox4.TextChanged

    End Sub

    Private Sub RichTextBox3_TextChanged(sender As Object, e As EventArgs) Handles mailsubject.TextChanged

    End Sub

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        tomailaddress.Clear()
        ccmailaddress.Clear()
        mailsubject.Clear()
        mailmessage.Clear()
        Me.Hide()
    End Sub

    Private Sub mailmessage_TextChanged(sender As Object, e As EventArgs) Handles mailmessage.TextChanged

    End Sub
End Class
