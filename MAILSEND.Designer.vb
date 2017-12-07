<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAILSEND
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox9 = New System.Windows.Forms.RichTextBox()
        Me.mailsubject = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ccmailaddress = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox4 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox7 = New System.Windows.Forms.RichTextBox()
        Me.tomailaddress = New System.Windows.Forms.RichTextBox()
        Me.mailmessage = New System.Windows.Forms.RichTextBox()
        Me.sendmailbutton = New System.Windows.Forms.Button()
        Me.backbutton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.RichTextBox9)
        Me.GroupBox1.Controls.Add(Me.mailsubject)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ccmailaddress)
        Me.GroupBox1.Controls.Add(Me.RichTextBox4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.RichTextBox7)
        Me.GroupBox1.Controls.Add(Me.tomailaddress)
        Me.GroupBox1.Controls.Add(Me.mailmessage)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Location = New System.Drawing.Point(29, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 366)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compose "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gray
        Me.Label4.Location = New System.Drawing.Point(9, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Subject"
        '
        'RichTextBox9
        '
        Me.RichTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox9.Location = New System.Drawing.Point(-1, 112)
        Me.RichTextBox9.Name = "RichTextBox9"
        Me.RichTextBox9.Size = New System.Drawing.Size(71, 31)
        Me.RichTextBox9.TabIndex = 18
        Me.RichTextBox9.Text = ""
        '
        'mailsubject
        '
        Me.mailsubject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mailsubject.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mailsubject.Location = New System.Drawing.Point(71, 112)
        Me.mailsubject.Name = "mailsubject"
        Me.mailsubject.Size = New System.Drawing.Size(503, 31)
        Me.mailsubject.TabIndex = 17
        Me.mailsubject.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(19, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Cc"
        '
        'ccmailaddress
        '
        Me.ccmailaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ccmailaddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccmailaddress.Location = New System.Drawing.Point(72, 78)
        Me.ccmailaddress.Name = "ccmailaddress"
        Me.ccmailaddress.Size = New System.Drawing.Size(503, 31)
        Me.ccmailaddress.TabIndex = 15
        Me.ccmailaddress.Text = ""
        '
        'RichTextBox4
        '
        Me.RichTextBox4.BackColor = System.Drawing.Color.White
        Me.RichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox4.Location = New System.Drawing.Point(0, 78)
        Me.RichTextBox4.Name = "RichTextBox4"
        Me.RichTextBox4.Size = New System.Drawing.Size(71, 31)
        Me.RichTextBox4.TabIndex = 14
        Me.RichTextBox4.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(20, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "To"
        '
        'RichTextBox7
        '
        Me.RichTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox7.Location = New System.Drawing.Point(0, 43)
        Me.RichTextBox7.Name = "RichTextBox7"
        Me.RichTextBox7.Size = New System.Drawing.Size(71, 32)
        Me.RichTextBox7.TabIndex = 13
        Me.RichTextBox7.Text = ""
        '
        'tomailaddress
        '
        Me.tomailaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tomailaddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tomailaddress.Location = New System.Drawing.Point(72, 43)
        Me.tomailaddress.Name = "tomailaddress"
        Me.tomailaddress.Size = New System.Drawing.Size(503, 32)
        Me.tomailaddress.TabIndex = 5
        Me.tomailaddress.Text = ""
        '
        'mailmessage
        '
        Me.mailmessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mailmessage.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mailmessage.Location = New System.Drawing.Point(0, 148)
        Me.mailmessage.Name = "mailmessage"
        Me.mailmessage.Size = New System.Drawing.Size(575, 218)
        Me.mailmessage.TabIndex = 0
        Me.mailmessage.Text = ""
        '
        'sendmailbutton
        '
        Me.sendmailbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sendmailbutton.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendmailbutton.ForeColor = System.Drawing.Color.White
        Me.sendmailbutton.Location = New System.Drawing.Point(511, 434)
        Me.sendmailbutton.Name = "sendmailbutton"
        Me.sendmailbutton.Size = New System.Drawing.Size(93, 37)
        Me.sendmailbutton.TabIndex = 3
        Me.sendmailbutton.Text = "SEND"
        Me.sendmailbutton.UseVisualStyleBackColor = True
        '
        'backbutton
        '
        Me.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backbutton.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbutton.ForeColor = System.Drawing.Color.White
        Me.backbutton.Location = New System.Drawing.Point(389, 434)
        Me.backbutton.Name = "backbutton"
        Me.backbutton.Size = New System.Drawing.Size(93, 37)
        Me.backbutton.TabIndex = 3
        Me.backbutton.Text = "BACK"
        Me.backbutton.UseVisualStyleBackColor = True
        '
        'MAILSEND
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tomato
        Me.ClientSize = New System.Drawing.Size(643, 497)
        Me.Controls.Add(Me.backbutton)
        Me.Controls.Add(Me.sendmailbutton)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MAILSEND"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Send_Mail"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents mailmessage As RichTextBox
    Friend WithEvents sendmailbutton As Button
    Friend WithEvents tomailaddress As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox9 As RichTextBox
    Friend WithEvents mailsubject As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ccmailaddress As RichTextBox
    Friend WithEvents RichTextBox4 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox7 As RichTextBox
    Friend WithEvents backbutton As Button
End Class
