<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class findForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(findForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.findbydepartment = New System.Windows.Forms.ComboBox()
        Me.findbysession = New System.Windows.Forms.ComboBox()
        Me.findbysemester = New System.Windows.Forms.ComboBox()
        Me.findbystate = New System.Windows.Forms.ComboBox()
        Me.findbycategory = New System.Windows.Forms.ComboBox()
        Me.findbylastname = New System.Windows.Forms.TextBox()
        Me.findbyfirstname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.findbyemailid = New System.Windows.Forms.TextBox()
        Me.findbymobilenumber = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.findusingroll_numbers = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.findbybackbutton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.findbyresetbutton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.findbyfindbutton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(236, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Find by"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.findbydepartment)
        Me.GroupBox1.Controls.Add(Me.findbysession)
        Me.GroupBox1.Controls.Add(Me.findbysemester)
        Me.GroupBox1.Controls.Add(Me.findbystate)
        Me.GroupBox1.Controls.Add(Me.findbycategory)
        Me.GroupBox1.Controls.Add(Me.findbylastname)
        Me.GroupBox1.Controls.Add(Me.findbyfirstname)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(242, 240)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(356, 302)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'findbydepartment
        '
        Me.findbydepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.findbydepartment.Font = New System.Drawing.Font("Century Gothic", 7.0!)
        Me.findbydepartment.FormattingEnabled = True
        Me.findbydepartment.Items.AddRange(New Object() {"CHEM ENGG", "CIVIL ENGG", "CSE", "IPE", "IT", "ECE", "MECH ENGG"})
        Me.findbydepartment.Location = New System.Drawing.Point(162, 192)
        Me.findbydepartment.Name = "findbydepartment"
        Me.findbydepartment.Size = New System.Drawing.Size(162, 21)
        Me.findbydepartment.TabIndex = 17
        '
        'findbysession
        '
        Me.findbysession.FormattingEnabled = True
        Me.findbysession.Items.AddRange(New Object() {"2012-2016", "2013-2017", "2014-2018", "2015-2019", "2016-2020", "2017-2021", "2018-2022", "2019-2023"})
        Me.findbysession.Location = New System.Drawing.Point(162, 155)
        Me.findbysession.Name = "findbysession"
        Me.findbysession.Size = New System.Drawing.Size(162, 29)
        Me.findbysession.TabIndex = 16
        '
        'findbysemester
        '
        Me.findbysemester.FormattingEnabled = True
        Me.findbysemester.Items.AddRange(New Object() {"I", "II", "III", "IV", "V", "VI", "VII", "VIII"})
        Me.findbysemester.Location = New System.Drawing.Point(162, 120)
        Me.findbysemester.Name = "findbysemester"
        Me.findbysemester.Size = New System.Drawing.Size(162, 29)
        Me.findbysemester.TabIndex = 15
        '
        'findbystate
        '
        Me.findbystate.FormattingEnabled = True
        Me.findbystate.Items.AddRange(New Object() {"Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Delhi", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jammu & Kashmir", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Orissa", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal", "Andaman & Nicobar Islands", "Dadra and Nagar Haveli", "Daman and Diu", "Lakshadweep", "Puducherry"})
        Me.findbystate.Location = New System.Drawing.Point(162, 261)
        Me.findbystate.Name = "findbystate"
        Me.findbystate.Size = New System.Drawing.Size(162, 29)
        Me.findbystate.TabIndex = 14
        '
        'findbycategory
        '
        Me.findbycategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.findbycategory.FormattingEnabled = True
        Me.findbycategory.Items.AddRange(New Object() {"GENERAL", "OBC", "ST", "SC", "GENERAL-PWD", "OBC-PWD", "ST-PWD", "SC-PWD"})
        Me.findbycategory.Location = New System.Drawing.Point(162, 223)
        Me.findbycategory.Name = "findbycategory"
        Me.findbycategory.Size = New System.Drawing.Size(162, 29)
        Me.findbycategory.TabIndex = 13
        '
        'findbylastname
        '
        Me.findbylastname.Location = New System.Drawing.Point(162, 89)
        Me.findbylastname.Name = "findbylastname"
        Me.findbylastname.Size = New System.Drawing.Size(162, 27)
        Me.findbylastname.TabIndex = 9
        '
        'findbyfirstname
        '
        Me.findbyfirstname.Location = New System.Drawing.Point(162, 56)
        Me.findbyfirstname.Name = "findbyfirstname"
        Me.findbyfirstname.Size = New System.Drawing.Size(162, 27)
        Me.findbyfirstname.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(7, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 25)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "State"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 25)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Category"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(7, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Department"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Session"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Semester"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Last name"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "First name"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.findbyemailid)
        Me.GroupBox3.Controls.Add(Me.findbymobilenumber)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Location = New System.Drawing.Point(621, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 302)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contact Details"
        '
        'findbyemailid
        '
        Me.findbyemailid.Location = New System.Drawing.Point(160, 93)
        Me.findbyemailid.Name = "findbyemailid"
        Me.findbyemailid.Size = New System.Drawing.Size(162, 27)
        Me.findbyemailid.TabIndex = 10
        '
        'findbymobilenumber
        '
        Me.findbymobilenumber.Location = New System.Drawing.Point(160, 59)
        Me.findbymobilenumber.Name = "findbymobilenumber"
        Me.findbymobilenumber.Size = New System.Drawing.Size(162, 27)
        Me.findbymobilenumber.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(28, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 25)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Email-ID"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(28, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 25)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Mobile no"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BunifuImageButton1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1077, 39)
        Me.Panel1.TabIndex = 6
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.WindowsApp.My.Resources.Resources.Close_128
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(1051, 9)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 0
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 20
        '
        'findusingroll_numbers
        '
        Me.findusingroll_numbers.BorderColorFocused = System.Drawing.Color.DodgerBlue
        Me.findusingroll_numbers.BorderColorIdle = System.Drawing.Color.White
        Me.findusingroll_numbers.BorderColorMouseHover = System.Drawing.Color.DodgerBlue
        Me.findusingroll_numbers.BorderThickness = 3
        Me.findusingroll_numbers.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.findusingroll_numbers.Font = New System.Drawing.Font("Century Gothic", 10.75!)
        Me.findusingroll_numbers.ForeColor = System.Drawing.Color.White
        Me.findusingroll_numbers.isPassword = False
        Me.findusingroll_numbers.Location = New System.Drawing.Point(242, 117)
        Me.findusingroll_numbers.Margin = New System.Windows.Forms.Padding(5)
        Me.findusingroll_numbers.Name = "findusingroll_numbers"
        Me.findusingroll_numbers.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.findusingroll_numbers.Size = New System.Drawing.Size(735, 54)
        Me.findusingroll_numbers.TabIndex = 9
        Me.findusingroll_numbers.Text = "Examination Roll No. (Enter multiple values separated by a semi-colon to search f" &
    "or multiple students)"
        Me.findusingroll_numbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(585, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "OR"
        '
        'findbybackbutton
        '
        Me.findbybackbutton.Activecolor = System.Drawing.SystemColors.Highlight
        Me.findbybackbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.findbybackbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.findbybackbutton.BorderRadius = 0
        Me.findbybackbutton.ButtonText = "Back"
        Me.findbybackbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.findbybackbutton.DisabledColor = System.Drawing.Color.Gray
        Me.findbybackbutton.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.findbybackbutton.Iconcolor = System.Drawing.Color.Transparent
        Me.findbybackbutton.Iconimage = CType(resources.GetObject("findbybackbutton.Iconimage"), System.Drawing.Image)
        Me.findbybackbutton.Iconimage_right = Nothing
        Me.findbybackbutton.Iconimage_right_Selected = Nothing
        Me.findbybackbutton.Iconimage_Selected = Nothing
        Me.findbybackbutton.IconMarginLeft = 0
        Me.findbybackbutton.IconMarginRight = 0
        Me.findbybackbutton.IconRightVisible = True
        Me.findbybackbutton.IconRightZoom = 0R
        Me.findbybackbutton.IconVisible = True
        Me.findbybackbutton.IconZoom = 40.0R
        Me.findbybackbutton.IsTab = False
        Me.findbybackbutton.Location = New System.Drawing.Point(818, 49)
        Me.findbybackbutton.Margin = New System.Windows.Forms.Padding(7)
        Me.findbybackbutton.Name = "findbybackbutton"
        Me.findbybackbutton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.findbybackbutton.OnHovercolor = System.Drawing.SystemColors.HotTrack
        Me.findbybackbutton.OnHoverTextColor = System.Drawing.Color.White
        Me.findbybackbutton.selected = False
        Me.findbybackbutton.Size = New System.Drawing.Size(159, 38)
        Me.findbybackbutton.TabIndex = 7
        Me.findbybackbutton.Text = "Back"
        Me.findbybackbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.findbybackbutton.Textcolor = System.Drawing.Color.White
        Me.findbybackbutton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'findbyresetbutton
        '
        Me.findbyresetbutton.Activecolor = System.Drawing.SystemColors.Highlight
        Me.findbyresetbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.findbyresetbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.findbyresetbutton.BorderRadius = 0
        Me.findbyresetbutton.ButtonText = "Reset"
        Me.findbyresetbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.findbyresetbutton.DisabledColor = System.Drawing.Color.Gray
        Me.findbyresetbutton.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.findbyresetbutton.Iconcolor = System.Drawing.Color.Transparent
        Me.findbyresetbutton.Iconimage = CType(resources.GetObject("findbyresetbutton.Iconimage"), System.Drawing.Image)
        Me.findbyresetbutton.Iconimage_right = Nothing
        Me.findbyresetbutton.Iconimage_right_Selected = Nothing
        Me.findbyresetbutton.Iconimage_Selected = Nothing
        Me.findbyresetbutton.IconMarginLeft = 0
        Me.findbyresetbutton.IconMarginRight = 0
        Me.findbyresetbutton.IconRightVisible = True
        Me.findbyresetbutton.IconRightZoom = 0R
        Me.findbyresetbutton.IconVisible = True
        Me.findbyresetbutton.IconZoom = 40.0R
        Me.findbyresetbutton.IsTab = False
        Me.findbyresetbutton.Location = New System.Drawing.Point(743, 573)
        Me.findbyresetbutton.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.findbyresetbutton.Name = "findbyresetbutton"
        Me.findbyresetbutton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.findbyresetbutton.OnHovercolor = System.Drawing.SystemColors.HotTrack
        Me.findbyresetbutton.OnHoverTextColor = System.Drawing.Color.White
        Me.findbyresetbutton.selected = False
        Me.findbyresetbutton.Size = New System.Drawing.Size(159, 38)
        Me.findbyresetbutton.TabIndex = 5
        Me.findbyresetbutton.Text = "Reset"
        Me.findbyresetbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.findbyresetbutton.Textcolor = System.Drawing.Color.White
        Me.findbyresetbutton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'findbyfindbutton
        '
        Me.findbyfindbutton.Activecolor = System.Drawing.SystemColors.Highlight
        Me.findbyfindbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.findbyfindbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.findbyfindbutton.BorderRadius = 0
        Me.findbyfindbutton.ButtonText = "Find"
        Me.findbyfindbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.findbyfindbutton.DisabledColor = System.Drawing.Color.Gray
        Me.findbyfindbutton.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.findbyfindbutton.Iconcolor = System.Drawing.Color.Transparent
        Me.findbyfindbutton.Iconimage = CType(resources.GetObject("findbyfindbutton.Iconimage"), System.Drawing.Image)
        Me.findbyfindbutton.Iconimage_right = Nothing
        Me.findbyfindbutton.Iconimage_right_Selected = Nothing
        Me.findbyfindbutton.Iconimage_Selected = Nothing
        Me.findbyfindbutton.IconMarginLeft = 0
        Me.findbyfindbutton.IconMarginRight = 0
        Me.findbyfindbutton.IconRightVisible = True
        Me.findbyfindbutton.IconRightZoom = 0R
        Me.findbyfindbutton.IconVisible = True
        Me.findbyfindbutton.IconZoom = 40.0R
        Me.findbyfindbutton.IsTab = False
        Me.findbyfindbutton.Location = New System.Drawing.Point(361, 573)
        Me.findbyfindbutton.Margin = New System.Windows.Forms.Padding(4)
        Me.findbyfindbutton.Name = "findbyfindbutton"
        Me.findbyfindbutton.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.findbyfindbutton.OnHovercolor = System.Drawing.SystemColors.HotTrack
        Me.findbyfindbutton.OnHoverTextColor = System.Drawing.Color.White
        Me.findbyfindbutton.selected = False
        Me.findbyfindbutton.Size = New System.Drawing.Size(160, 38)
        Me.findbyfindbutton.TabIndex = 4
        Me.findbyfindbutton.Text = "Find"
        Me.findbyfindbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.findbyfindbutton.Textcolor = System.Drawing.Color.White
        Me.findbyfindbutton.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'findForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1077, 641)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.findusingroll_numbers)
        Me.Controls.Add(Me.findbybackbutton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.findbyresetbutton)
        Me.Controls.Add(Me.findbyfindbutton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "findForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "findForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents findbystate As System.Windows.Forms.ComboBox
    Friend WithEvents findbycategory As System.Windows.Forms.ComboBox
    Friend WithEvents findbylastname As System.Windows.Forms.TextBox
    Friend WithEvents findbyfirstname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents findbysemester As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents findbyemailid As System.Windows.Forms.TextBox
    Friend WithEvents findbymobilenumber As System.Windows.Forms.TextBox
    Friend WithEvents findbyfindbutton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents findbyresetbutton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents findbysession As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents findbydepartment As System.Windows.Forms.ComboBox
    Friend WithEvents findbybackbutton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents findusingroll_numbers As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As Label
End Class
