<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertmultipleprofiles
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(insertmultipleprofiles))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.backbutton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.First_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enroll_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Examination_roll_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Session = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateofbirth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fathers_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mobile_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.aadhaar_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.selectstudentGeneralInformation = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Street_Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.State = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pincode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.setStudentCorrespondenceAddress = New System.Windows.Forms.Button()
        Me.SetStudentPermanentAddress = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SetStudentGuardianInformation = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name_of_guardian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Relationship = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mobile_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CreateProfile = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(814, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Please Keep MS Excel files ready in the format as described below :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(257, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "1. For Student's General Details :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(335, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "2. For Student's Correspondence Address :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(291, 21)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "3. For Student's Permanent Address :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(269, 21)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "4. For Student's Guardian Details :"
        '
        'backbutton
        '
        Me.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backbutton.Location = New System.Drawing.Point(1167, 19)
        Me.backbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.backbutton.Name = "backbutton"
        Me.backbutton.Size = New System.Drawing.Size(60, 25)
        Me.backbutton.TabIndex = 5
        Me.backbutton.Text = "Back"
        Me.backbutton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.First_name, Me.M_name, Me.Last_name, Me.Enroll_id, Me.Examination_roll_number, Me.Department, Me.Semester, Me.Session, Me.dateofbirth, Me.Category, Me.Gender, Me.Fathers_Name, Me.Mobile_no, Me.Email_id, Me.aadhaar_no})
        Me.DataGridView1.Location = New System.Drawing.Point(17, 45)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Size = New System.Drawing.Size(743, 96)
        Me.DataGridView1.TabIndex = 6
        '
        'First_name
        '
        Me.First_name.HeaderText = "First Name"
        Me.First_name.Name = "First_name"
        Me.First_name.ReadOnly = True
        '
        'M_name
        '
        Me.M_name.HeaderText = "Middle name (Optional)"
        Me.M_name.Name = "M_name"
        Me.M_name.ReadOnly = True
        Me.M_name.Width = 200
        '
        'Last_name
        '
        Me.Last_name.HeaderText = "Last Name"
        Me.Last_name.Name = "Last_name"
        Me.Last_name.ReadOnly = True
        Me.Last_name.Width = 150
        '
        'Enroll_id
        '
        Me.Enroll_id.HeaderText = "Enrollment number"
        Me.Enroll_id.Name = "Enroll_id"
        Me.Enroll_id.ReadOnly = True
        Me.Enroll_id.Width = 150
        '
        'Examination_roll_number
        '
        Me.Examination_roll_number.HeaderText = "Examination Roll Number"
        Me.Examination_roll_number.Name = "Examination_roll_number"
        Me.Examination_roll_number.ReadOnly = True
        Me.Examination_roll_number.Width = 250
        '
        'Department
        '
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        Me.Department.ReadOnly = True
        Me.Department.Width = 150
        '
        'Semester
        '
        Me.Semester.HeaderText = "Semester"
        Me.Semester.Name = "Semester"
        Me.Semester.ReadOnly = True
        '
        'Session
        '
        Me.Session.HeaderText = "Session"
        Me.Session.Name = "Session"
        Me.Session.ReadOnly = True
        '
        'dateofbirth
        '
        Me.dateofbirth.HeaderText = "Date Of Birth"
        Me.dateofbirth.Name = "dateofbirth"
        Me.dateofbirth.ReadOnly = True
        Me.dateofbirth.Width = 150
        '
        'Category
        '
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'Gender
        '
        Me.Gender.HeaderText = "Gender"
        Me.Gender.Name = "Gender"
        Me.Gender.ReadOnly = True
        '
        'Fathers_Name
        '
        Me.Fathers_Name.HeaderText = "Father's Name"
        Me.Fathers_Name.Name = "Fathers_Name"
        Me.Fathers_Name.ReadOnly = True
        Me.Fathers_Name.Width = 150
        '
        'Mobile_no
        '
        Me.Mobile_no.HeaderText = "Mobile Number"
        Me.Mobile_no.Name = "Mobile_no"
        Me.Mobile_no.ReadOnly = True
        Me.Mobile_no.Width = 150
        '
        'Email_id
        '
        Me.Email_id.HeaderText = "Email id"
        Me.Email_id.Name = "Email_id"
        Me.Email_id.ReadOnly = True
        '
        'aadhaar_no
        '
        Me.aadhaar_no.HeaderText = "Aadhaar Number (Optional)"
        Me.aadhaar_no.Name = "aadhaar_no"
        Me.aadhaar_no.ReadOnly = True
        Me.aadhaar_no.Width = 250
        '
        'selectstudentGeneralInformation
        '
        Me.selectstudentGeneralInformation.BackColor = System.Drawing.Color.Green
        Me.selectstudentGeneralInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectstudentGeneralInformation.Location = New System.Drawing.Point(668, 9)
        Me.selectstudentGeneralInformation.Margin = New System.Windows.Forms.Padding(2)
        Me.selectstudentGeneralInformation.Name = "selectstudentGeneralInformation"
        Me.selectstudentGeneralInformation.Size = New System.Drawing.Size(92, 25)
        Me.selectstudentGeneralInformation.TabIndex = 7
        Me.selectstudentGeneralInformation.Text = "Select File"
        Me.selectstudentGeneralInformation.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeight = 25
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.Street_Address, Me.City, Me.State, Me.Pincode})
        Me.DataGridView2.Location = New System.Drawing.Point(13, 48)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(743, 36)
        Me.DataGridView2.TabIndex = 6
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Examination Roll Number"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 200
        '
        'Street_Address
        '
        Me.Street_Address.HeaderText = "Street Address"
        Me.Street_Address.Name = "Street_Address"
        Me.Street_Address.ReadOnly = True
        Me.Street_Address.Width = 70
        '
        'City
        '
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        Me.City.ReadOnly = True
        Me.City.Width = 70
        '
        'State
        '
        Me.State.HeaderText = "State"
        Me.State.Name = "State"
        Me.State.ReadOnly = True
        Me.State.Width = 70
        '
        'Pincode
        '
        Me.Pincode.HeaderText = "Pincode (must be of six digits)"
        Me.Pincode.Name = "Pincode"
        Me.Pincode.ReadOnly = True
        Me.Pincode.Width = 220
        '
        'setStudentCorrespondenceAddress
        '
        Me.setStudentCorrespondenceAddress.BackColor = System.Drawing.Color.Green
        Me.setStudentCorrespondenceAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.setStudentCorrespondenceAddress.Location = New System.Drawing.Point(669, 6)
        Me.setStudentCorrespondenceAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.setStudentCorrespondenceAddress.Name = "setStudentCorrespondenceAddress"
        Me.setStudentCorrespondenceAddress.Size = New System.Drawing.Size(92, 25)
        Me.setStudentCorrespondenceAddress.TabIndex = 7
        Me.setStudentCorrespondenceAddress.Text = "Select File"
        Me.setStudentCorrespondenceAddress.UseVisualStyleBackColor = False
        '
        'SetStudentPermanentAddress
        '
        Me.SetStudentPermanentAddress.BackColor = System.Drawing.Color.Green
        Me.SetStudentPermanentAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetStudentPermanentAddress.Location = New System.Drawing.Point(670, 14)
        Me.SetStudentPermanentAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.SetStudentPermanentAddress.Name = "SetStudentPermanentAddress"
        Me.SetStudentPermanentAddress.Size = New System.Drawing.Size(92, 25)
        Me.SetStudentPermanentAddress.TabIndex = 7
        Me.SetStudentPermanentAddress.Text = "Select File"
        Me.SetStudentPermanentAddress.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(33, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 21)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "(Format as Correspondence Address )"
        '
        'SetStudentGuardianInformation
        '
        Me.SetStudentGuardianInformation.BackColor = System.Drawing.Color.Green
        Me.SetStudentGuardianInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SetStudentGuardianInformation.Location = New System.Drawing.Point(665, 12)
        Me.SetStudentGuardianInformation.Margin = New System.Windows.Forms.Padding(2)
        Me.SetStudentGuardianInformation.Name = "SetStudentGuardianInformation"
        Me.SetStudentGuardianInformation.Size = New System.Drawing.Size(92, 25)
        Me.SetStudentGuardianInformation.TabIndex = 7
        Me.SetStudentGuardianInformation.Text = "Select File"
        Me.SetStudentGuardianInformation.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.ColumnHeadersHeight = 25
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Name_of_guardian, Me.Relationship, Me.Address, Me.Mobile_number, Me.email})
        Me.DataGridView3.Location = New System.Drawing.Point(14, 45)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(743, 66)
        Me.DataGridView3.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Examination Roll Number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'Name_of_guardian
        '
        Me.Name_of_guardian.HeaderText = "Name of Guardian"
        Me.Name_of_guardian.Name = "Name_of_guardian"
        Me.Name_of_guardian.ReadOnly = True
        Me.Name_of_guardian.Width = 150
        '
        'Relationship
        '
        Me.Relationship.HeaderText = "Relationship with the Student"
        Me.Relationship.Name = "Relationship"
        Me.Relationship.ReadOnly = True
        Me.Relationship.Width = 250
        '
        'Address
        '
        Me.Address.HeaderText = "Address (optional)"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 150
        '
        'Mobile_number
        '
        Me.Mobile_number.HeaderText = "Mobile Number"
        Me.Mobile_number.Name = "Mobile_number"
        Me.Mobile_number.ReadOnly = True
        Me.Mobile_number.Width = 150
        '
        'email
        '
        Me.email.HeaderText = "Email id (optional)"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Width = 150
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label7.Location = New System.Drawing.Point(94, 65)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(601, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Individual Student's Academic Details can be updated using ""Update Single Profile" &
    """ Option on the homepage."
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(859, 135)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 517)
        Me.Panel1.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Chartreuse
        Me.Label8.Location = New System.Drawing.Point(149, 7)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 18)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Reference :"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(3, 239)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(367, 273)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(4, 29)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(367, 206)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CreateProfile
        '
        Me.CreateProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CreateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateProfile.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateProfile.Location = New System.Drawing.Point(332, 665)
        Me.CreateProfile.Name = "CreateProfile"
        Me.CreateProfile.Size = New System.Drawing.Size(228, 31)
        Me.CreateProfile.TabIndex = 11
        Me.CreateProfile.Text = "Create Profiles"
        Me.CreateProfile.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.selectstudentGeneralInformation)
        Me.Panel2.Location = New System.Drawing.Point(25, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 152)
        Me.Panel2.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.DataGridView2)
        Me.Panel3.Controls.Add(Me.setStudentCorrespondenceAddress)
        Me.Panel3.Location = New System.Drawing.Point(25, 304)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(805, 100)
        Me.Panel3.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.SetStudentPermanentAddress)
        Me.Panel4.Location = New System.Drawing.Point(25, 419)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(805, 86)
        Me.Panel4.TabIndex = 14
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.DataGridView3)
        Me.Panel5.Controls.Add(Me.SetStudentGuardianInformation)
        Me.Panel5.Location = New System.Drawing.Point(25, 521)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(805, 131)
        Me.Panel5.TabIndex = 15
        '
        'insertmultipleprofiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1260, 711)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.CreateProfile)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.backbutton)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "insertmultipleprofiles"
        Me.Text = "Insert Multiple Profiles"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents backbutton As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents selectstudentGeneralInformation As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents setStudentCorrespondenceAddress As Button
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Street_Address As DataGridViewTextBoxColumn
    Friend WithEvents City As DataGridViewTextBoxColumn
    Friend WithEvents State As DataGridViewTextBoxColumn
    Friend WithEvents Pincode As DataGridViewTextBoxColumn
    Friend WithEvents SetStudentPermanentAddress As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SetStudentGuardianInformation As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Name_of_guardian As DataGridViewTextBoxColumn
    Friend WithEvents Relationship As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Mobile_number As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents First_name As DataGridViewTextBoxColumn
    Friend WithEvents M_name As DataGridViewTextBoxColumn
    Friend WithEvents Last_name As DataGridViewTextBoxColumn
    Friend WithEvents Enroll_id As DataGridViewTextBoxColumn
    Friend WithEvents Examination_roll_number As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Semester As DataGridViewTextBoxColumn
    Friend WithEvents Session As DataGridViewTextBoxColumn
    Friend WithEvents dateofbirth As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Fathers_Name As DataGridViewTextBoxColumn
    Friend WithEvents Mobile_no As DataGridViewTextBoxColumn
    Friend WithEvents Email_id As DataGridViewTextBoxColumn
    Friend WithEvents aadhaar_no As DataGridViewTextBoxColumn
    Friend WithEvents CreateProfile As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
End Class
