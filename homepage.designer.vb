<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homepage
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homepage))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.header = New System.Windows.Forms.Panel()
        Me.maximize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.minimize = New Bunifu.Framework.UI.BunifuImageButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.exitbutton = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.paneltransition = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.slidemenu = New System.Windows.Forms.Panel()
        Me.editprofilebutton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.messagestudentsbutton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.reportgenerationbutton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.logoutbutton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.findprofilebutton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.createprofilebutton = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.homebuttoneditprofile = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MenuButton = New Bunifu.Framework.UI.BunifuImageButton()
        Me.rightpanel = New System.Windows.Forms.Panel()
        Me.Title = New System.Windows.Forms.Label()
        Me.BunifuTileButton7 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton6 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton5 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton4 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton3 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.UpdateProfileButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.createUserTileButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.editbuttonanimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.header.SuspendLayout()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.slidemenu.SuspendLayout()
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rightpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.header.Controls.Add(Me.maximize)
        Me.header.Controls.Add(Me.minimize)
        Me.header.Controls.Add(Me.PictureBox2)
        Me.header.Controls.Add(Me.exitbutton)
        Me.header.Controls.Add(Me.BunifuCustomLabel1)
        Me.editbuttonanimator.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1233, 42)
        Me.header.TabIndex = 5
        '
        'maximize
        '
        Me.maximize.BackColor = System.Drawing.Color.Transparent
        Me.editbuttonanimator.SetDecoration(Me.maximize, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.maximize, BunifuAnimatorNS.DecorationType.None)
        Me.maximize.Image = Global.WindowsApp.My.Resources.Resources.Screen_48
        Me.maximize.ImageActive = Nothing
        Me.maximize.Location = New System.Drawing.Point(1180, 16)
        Me.maximize.Name = "maximize"
        Me.maximize.Size = New System.Drawing.Size(37, 25)
        Me.maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.maximize.TabIndex = 4
        Me.maximize.TabStop = False
        Me.maximize.Zoom = 20
        '
        'minimize
        '
        Me.minimize.BackColor = System.Drawing.Color.Transparent
        Me.editbuttonanimator.SetDecoration(Me.minimize, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.minimize, BunifuAnimatorNS.DecorationType.None)
        Me.minimize.Image = Global.WindowsApp.My.Resources.Resources.Minus_48
        Me.minimize.ImageActive = Nothing
        Me.minimize.Location = New System.Drawing.Point(1147, 18)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(36, 26)
        Me.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.minimize.TabIndex = 3
        Me.minimize.TabStop = False
        Me.minimize.Zoom = 20
        '
        'PictureBox2
        '
        Me.paneltransition.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.editbuttonanimator.SetDecoration(Me.PictureBox2, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox2.Image = Global.WindowsApp.My.Resources.Resources.Home_48
        Me.PictureBox2.Location = New System.Drawing.Point(14, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'exitbutton
        '
        Me.exitbutton.BackColor = System.Drawing.Color.Transparent
        Me.editbuttonanimator.SetDecoration(Me.exitbutton, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.exitbutton, BunifuAnimatorNS.DecorationType.None)
        Me.exitbutton.Image = Global.WindowsApp.My.Resources.Resources.Close_128
        Me.exitbutton.ImageActive = Nothing
        Me.exitbutton.Location = New System.Drawing.Point(1217, 10)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(30, 32)
        Me.exitbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.exitbutton.TabIndex = 1
        Me.exitbutton.TabStop = False
        Me.exitbutton.Zoom = 20
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.paneltransition.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.editbuttonanimator.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(58, 11)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(719, 21)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Student Database Management System - Institute of Technology, Guru Ghasidas Unive" &
    "rsity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'paneltransition
        '
        Me.paneltransition.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.paneltransition.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 1.0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.paneltransition.DefaultAnimation = Animation2
        '
        'slidemenu
        '
        Me.slidemenu.BackColor = System.Drawing.Color.SteelBlue
        Me.slidemenu.Controls.Add(Me.editprofilebutton)
        Me.slidemenu.Controls.Add(Me.messagestudentsbutton)
        Me.slidemenu.Controls.Add(Me.reportgenerationbutton)
        Me.slidemenu.Controls.Add(Me.logoutbutton)
        Me.slidemenu.Controls.Add(Me.findprofilebutton)
        Me.slidemenu.Controls.Add(Me.createprofilebutton)
        Me.slidemenu.Controls.Add(Me.homebuttoneditprofile)
        Me.slidemenu.Controls.Add(Me.MenuButton)
        Me.editbuttonanimator.SetDecoration(Me.slidemenu, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.slidemenu, BunifuAnimatorNS.DecorationType.None)
        Me.slidemenu.ForeColor = System.Drawing.Color.Purple
        Me.slidemenu.Location = New System.Drawing.Point(0, 41)
        Me.slidemenu.Name = "slidemenu"
        Me.slidemenu.Size = New System.Drawing.Size(77, 746)
        Me.slidemenu.TabIndex = 4
        '
        'editprofilebutton
        '
        Me.editprofilebutton.Activecolor = System.Drawing.Color.DodgerBlue
        Me.editprofilebutton.BackColor = System.Drawing.Color.Transparent
        Me.editprofilebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.editprofilebutton.BorderRadius = 0
        Me.editprofilebutton.ButtonText = "     Edit Student Profiles"
        Me.editprofilebutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.editprofilebutton, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.editprofilebutton, BunifuAnimatorNS.DecorationType.None)
        Me.editprofilebutton.DisabledColor = System.Drawing.Color.Gray
        Me.editprofilebutton.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.editprofilebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.editprofilebutton.Iconcolor = System.Drawing.Color.Transparent
        Me.editprofilebutton.Iconimage = Global.WindowsApp.My.Resources.Resources.User_Modify_48
        Me.editprofilebutton.Iconimage_right = Nothing
        Me.editprofilebutton.Iconimage_right_Selected = Nothing
        Me.editprofilebutton.Iconimage_Selected = Nothing
        Me.editprofilebutton.IconMarginLeft = 0
        Me.editprofilebutton.IconMarginRight = 0
        Me.editprofilebutton.IconRightVisible = True
        Me.editprofilebutton.IconRightZoom = 0R
        Me.editprofilebutton.IconVisible = True
        Me.editprofilebutton.IconZoom = 90.0R
        Me.editprofilebutton.IsTab = False
        Me.editprofilebutton.Location = New System.Drawing.Point(9, 283)
        Me.editprofilebutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.editprofilebutton.Name = "editprofilebutton"
        Me.editprofilebutton.Normalcolor = System.Drawing.Color.Transparent
        Me.editprofilebutton.OnHovercolor = System.Drawing.Color.LightBlue
        Me.editprofilebutton.OnHoverTextColor = System.Drawing.Color.White
        Me.editprofilebutton.selected = False
        Me.editprofilebutton.Size = New System.Drawing.Size(254, 44)
        Me.editprofilebutton.TabIndex = 1
        Me.editprofilebutton.Text = "     Edit Student Profiles"
        Me.editprofilebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.editprofilebutton.Textcolor = System.Drawing.Color.White
        Me.editprofilebutton.TextFont = New System.Drawing.Font("Century Gothic", 11.75!)
        '
        'messagestudentsbutton
        '
        Me.messagestudentsbutton.Activecolor = System.Drawing.Color.DodgerBlue
        Me.messagestudentsbutton.BackColor = System.Drawing.Color.Transparent
        Me.messagestudentsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.messagestudentsbutton.BorderRadius = 0
        Me.messagestudentsbutton.ButtonText = "     Contact Students"
        Me.messagestudentsbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.messagestudentsbutton, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.messagestudentsbutton, BunifuAnimatorNS.DecorationType.None)
        Me.messagestudentsbutton.DisabledColor = System.Drawing.Color.Gray
        Me.messagestudentsbutton.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.messagestudentsbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.messagestudentsbutton.Iconcolor = System.Drawing.Color.Transparent
        Me.messagestudentsbutton.Iconimage = Global.WindowsApp.My.Resources.Resources.User_Message_48
        Me.messagestudentsbutton.Iconimage_right = Nothing
        Me.messagestudentsbutton.Iconimage_right_Selected = Nothing
        Me.messagestudentsbutton.Iconimage_Selected = Nothing
        Me.messagestudentsbutton.IconMarginLeft = 0
        Me.messagestudentsbutton.IconMarginRight = 0
        Me.messagestudentsbutton.IconRightVisible = True
        Me.messagestudentsbutton.IconRightZoom = 0R
        Me.messagestudentsbutton.IconVisible = True
        Me.messagestudentsbutton.IconZoom = 90.0R
        Me.messagestudentsbutton.IsTab = False
        Me.messagestudentsbutton.Location = New System.Drawing.Point(8, 427)
        Me.messagestudentsbutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.messagestudentsbutton.Name = "messagestudentsbutton"
        Me.messagestudentsbutton.Normalcolor = System.Drawing.Color.Transparent
        Me.messagestudentsbutton.OnHovercolor = System.Drawing.Color.LightBlue
        Me.messagestudentsbutton.OnHoverTextColor = System.Drawing.Color.White
        Me.messagestudentsbutton.selected = False
        Me.messagestudentsbutton.Size = New System.Drawing.Size(254, 44)
        Me.messagestudentsbutton.TabIndex = 1
        Me.messagestudentsbutton.Text = "     Contact Students"
        Me.messagestudentsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.messagestudentsbutton.Textcolor = System.Drawing.Color.White
        Me.messagestudentsbutton.TextFont = New System.Drawing.Font("Century Gothic", 11.75!)
        '
        'reportgenerationbutton
        '
        Me.reportgenerationbutton.Activecolor = System.Drawing.Color.DodgerBlue
        Me.reportgenerationbutton.BackColor = System.Drawing.Color.Transparent
        Me.reportgenerationbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.reportgenerationbutton.BorderRadius = 0
        Me.reportgenerationbutton.ButtonText = "     Report Generation"
        Me.reportgenerationbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.reportgenerationbutton, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.reportgenerationbutton, BunifuAnimatorNS.DecorationType.None)
        Me.reportgenerationbutton.DisabledColor = System.Drawing.Color.Gray
        Me.reportgenerationbutton.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.reportgenerationbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.reportgenerationbutton.Iconcolor = System.Drawing.Color.Transparent
        Me.reportgenerationbutton.Iconimage = Global.WindowsApp.My.Resources.Resources.Report_Editor_48
        Me.reportgenerationbutton.Iconimage_right = Nothing
        Me.reportgenerationbutton.Iconimage_right_Selected = Nothing
        Me.reportgenerationbutton.Iconimage_Selected = Nothing
        Me.reportgenerationbutton.IconMarginLeft = 0
        Me.reportgenerationbutton.IconMarginRight = 0
        Me.reportgenerationbutton.IconRightVisible = True
        Me.reportgenerationbutton.IconRightZoom = 0R
        Me.reportgenerationbutton.IconVisible = True
        Me.reportgenerationbutton.IconZoom = 90.0R
        Me.reportgenerationbutton.IsTab = False
        Me.reportgenerationbutton.Location = New System.Drawing.Point(9, 498)
        Me.reportgenerationbutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.reportgenerationbutton.Name = "reportgenerationbutton"
        Me.reportgenerationbutton.Normalcolor = System.Drawing.Color.Transparent
        Me.reportgenerationbutton.OnHovercolor = System.Drawing.Color.LightBlue
        Me.reportgenerationbutton.OnHoverTextColor = System.Drawing.Color.White
        Me.reportgenerationbutton.selected = False
        Me.reportgenerationbutton.Size = New System.Drawing.Size(254, 44)
        Me.reportgenerationbutton.TabIndex = 1
        Me.reportgenerationbutton.Text = "     Report Generation"
        Me.reportgenerationbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reportgenerationbutton.Textcolor = System.Drawing.Color.White
        Me.reportgenerationbutton.TextFont = New System.Drawing.Font("Century Gothic", 11.75!)
        '
        'logoutbutton
        '
        Me.logoutbutton.Activecolor = System.Drawing.Color.DodgerBlue
        Me.logoutbutton.BackColor = System.Drawing.Color.Transparent
        Me.logoutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.logoutbutton.BorderRadius = 0
        Me.logoutbutton.ButtonText = "     Logout"
        Me.logoutbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.logoutbutton, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.logoutbutton, BunifuAnimatorNS.DecorationType.None)
        Me.logoutbutton.DisabledColor = System.Drawing.Color.Gray
        Me.logoutbutton.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.logoutbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.logoutbutton.Iconcolor = System.Drawing.Color.Transparent
        Me.logoutbutton.Iconimage = Global.WindowsApp.My.Resources.Resources.Logout_48
        Me.logoutbutton.Iconimage_right = Nothing
        Me.logoutbutton.Iconimage_right_Selected = Nothing
        Me.logoutbutton.Iconimage_Selected = Nothing
        Me.logoutbutton.IconMarginLeft = 0
        Me.logoutbutton.IconMarginRight = 0
        Me.logoutbutton.IconRightVisible = True
        Me.logoutbutton.IconRightZoom = 0R
        Me.logoutbutton.IconVisible = True
        Me.logoutbutton.IconZoom = 90.0R
        Me.logoutbutton.IsTab = False
        Me.logoutbutton.Location = New System.Drawing.Point(9, 564)
        Me.logoutbutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.logoutbutton.Name = "logoutbutton"
        Me.logoutbutton.Normalcolor = System.Drawing.Color.Transparent
        Me.logoutbutton.OnHovercolor = System.Drawing.Color.LightBlue
        Me.logoutbutton.OnHoverTextColor = System.Drawing.Color.White
        Me.logoutbutton.selected = False
        Me.logoutbutton.Size = New System.Drawing.Size(254, 44)
        Me.logoutbutton.TabIndex = 1
        Me.logoutbutton.Text = "     Logout"
        Me.logoutbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logoutbutton.Textcolor = System.Drawing.Color.White
        Me.logoutbutton.TextFont = New System.Drawing.Font("Century Gothic", 11.75!)
        '
        'findprofilebutton
        '
        Me.findprofilebutton.Activecolor = System.Drawing.Color.DodgerBlue
        Me.findprofilebutton.BackColor = System.Drawing.Color.Transparent
        Me.findprofilebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.findprofilebutton.BorderRadius = 0
        Me.findprofilebutton.ButtonText = "     Find Profiles"
        Me.findprofilebutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.findprofilebutton, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.findprofilebutton, BunifuAnimatorNS.DecorationType.None)
        Me.findprofilebutton.DisabledColor = System.Drawing.Color.Gray
        Me.findprofilebutton.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.findprofilebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.findprofilebutton.Iconcolor = System.Drawing.Color.Transparent
        Me.findprofilebutton.Iconimage = Global.WindowsApp.My.Resources.Resources.User_Find_48
        Me.findprofilebutton.Iconimage_right = Nothing
        Me.findprofilebutton.Iconimage_right_Selected = Nothing
        Me.findprofilebutton.Iconimage_Selected = Nothing
        Me.findprofilebutton.IconMarginLeft = 0
        Me.findprofilebutton.IconMarginRight = 0
        Me.findprofilebutton.IconRightVisible = True
        Me.findprofilebutton.IconRightZoom = 0R
        Me.findprofilebutton.IconVisible = True
        Me.findprofilebutton.IconZoom = 90.0R
        Me.findprofilebutton.IsTab = False
        Me.findprofilebutton.Location = New System.Drawing.Point(9, 358)
        Me.findprofilebutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.findprofilebutton.Name = "findprofilebutton"
        Me.findprofilebutton.Normalcolor = System.Drawing.Color.Transparent
        Me.findprofilebutton.OnHovercolor = System.Drawing.Color.LightBlue
        Me.findprofilebutton.OnHoverTextColor = System.Drawing.Color.White
        Me.findprofilebutton.selected = False
        Me.findprofilebutton.Size = New System.Drawing.Size(254, 44)
        Me.findprofilebutton.TabIndex = 1
        Me.findprofilebutton.Text = "     Find Profiles"
        Me.findprofilebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.findprofilebutton.Textcolor = System.Drawing.Color.White
        Me.findprofilebutton.TextFont = New System.Drawing.Font("Century Gothic", 11.75!)
        '
        'createprofilebutton
        '
        Me.createprofilebutton.Activecolor = System.Drawing.Color.DodgerBlue
        Me.createprofilebutton.BackColor = System.Drawing.Color.Transparent
        Me.createprofilebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.createprofilebutton.BorderRadius = 0
        Me.createprofilebutton.ButtonText = "     Create Profile"
        Me.createprofilebutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.createprofilebutton, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.createprofilebutton, BunifuAnimatorNS.DecorationType.None)
        Me.createprofilebutton.DisabledColor = System.Drawing.Color.Gray
        Me.createprofilebutton.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.createprofilebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.createprofilebutton.Iconcolor = System.Drawing.Color.Transparent
        Me.createprofilebutton.Iconimage = Global.WindowsApp.My.Resources.Resources.User_Add_48
        Me.createprofilebutton.Iconimage_right = Nothing
        Me.createprofilebutton.Iconimage_right_Selected = Nothing
        Me.createprofilebutton.Iconimage_Selected = Nothing
        Me.createprofilebutton.IconMarginLeft = 0
        Me.createprofilebutton.IconMarginRight = 0
        Me.createprofilebutton.IconRightVisible = True
        Me.createprofilebutton.IconRightZoom = 0R
        Me.createprofilebutton.IconVisible = True
        Me.createprofilebutton.IconZoom = 90.0R
        Me.createprofilebutton.IsTab = False
        Me.createprofilebutton.Location = New System.Drawing.Point(8, 209)
        Me.createprofilebutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.createprofilebutton.Name = "createprofilebutton"
        Me.createprofilebutton.Normalcolor = System.Drawing.Color.Transparent
        Me.createprofilebutton.OnHovercolor = System.Drawing.Color.LightBlue
        Me.createprofilebutton.OnHoverTextColor = System.Drawing.Color.White
        Me.createprofilebutton.selected = False
        Me.createprofilebutton.Size = New System.Drawing.Size(254, 44)
        Me.createprofilebutton.TabIndex = 1
        Me.createprofilebutton.Text = "     Create Profile"
        Me.createprofilebutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.createprofilebutton.Textcolor = System.Drawing.Color.White
        Me.createprofilebutton.TextFont = New System.Drawing.Font("Century Gothic", 11.75!)
        '
        'homebuttoneditprofile
        '
        Me.homebuttoneditprofile.Activecolor = System.Drawing.Color.DodgerBlue
        Me.homebuttoneditprofile.BackColor = System.Drawing.Color.Transparent
        Me.homebuttoneditprofile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.homebuttoneditprofile.BorderRadius = 0
        Me.homebuttoneditprofile.ButtonText = "     Home"
        Me.homebuttoneditprofile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.homebuttoneditprofile, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.homebuttoneditprofile, BunifuAnimatorNS.DecorationType.None)
        Me.homebuttoneditprofile.DisabledColor = System.Drawing.Color.Gray
        Me.homebuttoneditprofile.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.homebuttoneditprofile.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.homebuttoneditprofile.Iconcolor = System.Drawing.Color.Transparent
        Me.homebuttoneditprofile.Iconimage = Global.WindowsApp.My.Resources.Resources.Home_48
        Me.homebuttoneditprofile.Iconimage_right = Nothing
        Me.homebuttoneditprofile.Iconimage_right_Selected = Nothing
        Me.homebuttoneditprofile.Iconimage_Selected = Nothing
        Me.homebuttoneditprofile.IconMarginLeft = 0
        Me.homebuttoneditprofile.IconMarginRight = 0
        Me.homebuttoneditprofile.IconRightVisible = True
        Me.homebuttoneditprofile.IconRightZoom = 0R
        Me.homebuttoneditprofile.IconVisible = True
        Me.homebuttoneditprofile.IconZoom = 90.0R
        Me.homebuttoneditprofile.IsTab = False
        Me.homebuttoneditprofile.Location = New System.Drawing.Point(9, 134)
        Me.homebuttoneditprofile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.homebuttoneditprofile.Name = "homebuttoneditprofile"
        Me.homebuttoneditprofile.Normalcolor = System.Drawing.Color.Transparent
        Me.homebuttoneditprofile.OnHovercolor = System.Drawing.Color.LightBlue
        Me.homebuttoneditprofile.OnHoverTextColor = System.Drawing.Color.White
        Me.homebuttoneditprofile.selected = False
        Me.homebuttoneditprofile.Size = New System.Drawing.Size(254, 44)
        Me.homebuttoneditprofile.TabIndex = 1
        Me.homebuttoneditprofile.Text = "     Home"
        Me.homebuttoneditprofile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.homebuttoneditprofile.Textcolor = System.Drawing.Color.White
        Me.homebuttoneditprofile.TextFont = New System.Drawing.Font("Century Gothic", 11.75!)
        '
        'MenuButton
        '
        Me.MenuButton.BackColor = System.Drawing.Color.Transparent
        Me.editbuttonanimator.SetDecoration(Me.MenuButton, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.MenuButton, BunifuAnimatorNS.DecorationType.None)
        Me.MenuButton.Image = Global.WindowsApp.My.Resources.Resources.Row_128
        Me.MenuButton.ImageActive = Nothing
        Me.MenuButton.Location = New System.Drawing.Point(3, 34)
        Me.MenuButton.Name = "MenuButton"
        Me.MenuButton.Size = New System.Drawing.Size(61, 42)
        Me.MenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.MenuButton.TabIndex = 0
        Me.MenuButton.TabStop = False
        Me.MenuButton.Zoom = 10
        '
        'rightpanel
        '
        Me.rightpanel.Controls.Add(Me.Title)
        Me.rightpanel.Controls.Add(Me.BunifuTileButton7)
        Me.rightpanel.Controls.Add(Me.BunifuTileButton6)
        Me.rightpanel.Controls.Add(Me.BunifuTileButton5)
        Me.rightpanel.Controls.Add(Me.BunifuTileButton4)
        Me.rightpanel.Controls.Add(Me.BunifuTileButton3)
        Me.rightpanel.Controls.Add(Me.UpdateProfileButton)
        Me.rightpanel.Controls.Add(Me.createUserTileButton)
        Me.editbuttonanimator.SetDecoration(Me.rightpanel, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.rightpanel, BunifuAnimatorNS.DecorationType.None)
        Me.rightpanel.Location = New System.Drawing.Point(77, 100)
        Me.rightpanel.Name = "rightpanel"
        Me.rightpanel.Size = New System.Drawing.Size(1052, 633)
        Me.rightpanel.TabIndex = 6
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.paneltransition.SetDecoration(Me.Title, BunifuAnimatorNS.DecorationType.BottomMirror)
        Me.editbuttonanimator.SetDecoration(Me.Title, BunifuAnimatorNS.DecorationType.BottomMirror)
        Me.Title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Title.Font = New System.Drawing.Font("Candara", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.Purple
        Me.Title.Location = New System.Drawing.Point(264, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(547, 39)
        Me.Title.TabIndex = 7
        Me.Title.Text = "Student Database Management System"
        '
        'BunifuTileButton7
        '
        Me.BunifuTileButton7.BackColor = System.Drawing.Color.Brown
        Me.BunifuTileButton7.color = System.Drawing.Color.Brown
        Me.BunifuTileButton7.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.BunifuTileButton7, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.BunifuTileButton7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTileButton7.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton7.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton7.Image = Global.WindowsApp.My.Resources.Resources.Logout_48
        Me.BunifuTileButton7.ImagePosition = 20
        Me.BunifuTileButton7.ImageZoom = 40
        Me.BunifuTileButton7.LabelPosition = 41
        Me.BunifuTileButton7.LabelText = "Logout"
        Me.BunifuTileButton7.Location = New System.Drawing.Point(271, 443)
        Me.BunifuTileButton7.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton7.Name = "BunifuTileButton7"
        Me.BunifuTileButton7.Size = New System.Drawing.Size(222, 129)
        Me.BunifuTileButton7.TabIndex = 6
        '
        'BunifuTileButton6
        '
        Me.BunifuTileButton6.BackColor = System.Drawing.Color.Crimson
        Me.BunifuTileButton6.color = System.Drawing.Color.Crimson
        Me.BunifuTileButton6.colorActive = System.Drawing.Color.Chocolate
        Me.BunifuTileButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.BunifuTileButton6, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.BunifuTileButton6, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTileButton6.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton6.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton6.Image = Global.WindowsApp.My.Resources.Resources.newspaper__2_
        Me.BunifuTileButton6.ImagePosition = 20
        Me.BunifuTileButton6.ImageZoom = 20
        Me.BunifuTileButton6.LabelPosition = 55
        Me.BunifuTileButton6.LabelText = "Report Generation"
        Me.BunifuTileButton6.Location = New System.Drawing.Point(532, 443)
        Me.BunifuTileButton6.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton6.Name = "BunifuTileButton6"
        Me.BunifuTileButton6.Size = New System.Drawing.Size(313, 129)
        Me.BunifuTileButton6.TabIndex = 5
        '
        'BunifuTileButton5
        '
        Me.BunifuTileButton5.BackColor = System.Drawing.Color.Gold
        Me.BunifuTileButton5.color = System.Drawing.Color.Gold
        Me.BunifuTileButton5.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.BunifuTileButton5, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.BunifuTileButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTileButton5.Font = New System.Drawing.Font("Century Gothic", 11.75!)
        Me.BunifuTileButton5.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton5.Image = Global.WindowsApp.My.Resources.Resources.send__2_
        Me.BunifuTileButton5.ImagePosition = 18
        Me.BunifuTileButton5.ImageZoom = 40
        Me.BunifuTileButton5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BunifuTileButton5.LabelPosition = 60
        Me.BunifuTileButton5.LabelText = "Contact Students"
        Me.BunifuTileButton5.Location = New System.Drawing.Point(670, 286)
        Me.BunifuTileButton5.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton5.Name = "BunifuTileButton5"
        Me.BunifuTileButton5.Size = New System.Drawing.Size(175, 129)
        Me.BunifuTileButton5.TabIndex = 4
        '
        'BunifuTileButton4
        '
        Me.BunifuTileButton4.BackColor = System.Drawing.Color.Purple
        Me.BunifuTileButton4.color = System.Drawing.Color.Purple
        Me.BunifuTileButton4.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.BunifuTileButton4, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.BunifuTileButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTileButton4.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton4.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton4.Image = Global.WindowsApp.My.Resources.Resources.User_Find_48
        Me.BunifuTileButton4.ImagePosition = 20
        Me.BunifuTileButton4.ImageZoom = 50
        Me.BunifuTileButton4.LabelPosition = 41
        Me.BunifuTileButton4.LabelText = "Find Profile"
        Me.BunifuTileButton4.Location = New System.Drawing.Point(469, 286)
        Me.BunifuTileButton4.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton4.Name = "BunifuTileButton4"
        Me.BunifuTileButton4.Size = New System.Drawing.Size(183, 129)
        Me.BunifuTileButton4.TabIndex = 3
        '
        'BunifuTileButton3
        '
        Me.BunifuTileButton3.BackColor = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton3.color = System.Drawing.Color.SeaGreen
        Me.BunifuTileButton3.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.BunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.BunifuTileButton3, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.BunifuTileButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuTileButton3.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton3.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton3.Image = Nothing
        Me.BunifuTileButton3.ImagePosition = 20
        Me.BunifuTileButton3.ImageZoom = 50
        Me.BunifuTileButton3.LabelPosition = 70
        Me.BunifuTileButton3.LabelText = "Tile 1"
        Me.BunifuTileButton3.Location = New System.Drawing.Point(654, 133)
        Me.BunifuTileButton3.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton3.Name = "BunifuTileButton3"
        Me.BunifuTileButton3.Size = New System.Drawing.Size(193, 129)
        Me.BunifuTileButton3.TabIndex = 2
        '
        'UpdateProfileButton
        '
        Me.UpdateProfileButton.BackColor = System.Drawing.Color.Green
        Me.UpdateProfileButton.color = System.Drawing.Color.Green
        Me.UpdateProfileButton.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.UpdateProfileButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.UpdateProfileButton, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.UpdateProfileButton, BunifuAnimatorNS.DecorationType.None)
        Me.UpdateProfileButton.Font = New System.Drawing.Font("Century Gothic", 12.75!)
        Me.UpdateProfileButton.ForeColor = System.Drawing.Color.White
        Me.UpdateProfileButton.Image = Global.WindowsApp.My.Resources.Resources.user__2_
        Me.UpdateProfileButton.ImagePosition = 18
        Me.UpdateProfileButton.ImageZoom = 50
        Me.UpdateProfileButton.LabelPosition = 36
        Me.UpdateProfileButton.LabelText = "Update Profile"
        Me.UpdateProfileButton.Location = New System.Drawing.Point(271, 286)
        Me.UpdateProfileButton.Margin = New System.Windows.Forms.Padding(6)
        Me.UpdateProfileButton.Name = "UpdateProfileButton"
        Me.UpdateProfileButton.Size = New System.Drawing.Size(178, 129)
        Me.UpdateProfileButton.TabIndex = 1
        '
        'createUserTileButton
        '
        Me.createUserTileButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.createUserTileButton.color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.createUserTileButton.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.createUserTileButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editbuttonanimator.SetDecoration(Me.createUserTileButton, BunifuAnimatorNS.DecorationType.None)
        Me.paneltransition.SetDecoration(Me.createUserTileButton, BunifuAnimatorNS.DecorationType.None)
        Me.createUserTileButton.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.createUserTileButton.ForeColor = System.Drawing.Color.White
        Me.createUserTileButton.Image = Global.WindowsApp.My.Resources.Resources.add_user__1_
        Me.createUserTileButton.ImagePosition = 20
        Me.createUserTileButton.ImageZoom = 30
        Me.createUserTileButton.LabelPosition = 41
        Me.createUserTileButton.LabelText = "Create Student Profile"
        Me.createUserTileButton.Location = New System.Drawing.Point(271, 133)
        Me.createUserTileButton.Margin = New System.Windows.Forms.Padding(6)
        Me.createUserTileButton.Name = "createUserTileButton"
        Me.createUserTileButton.Size = New System.Drawing.Size(346, 129)
        Me.createUserTileButton.TabIndex = 0
        '
        'editbuttonanimator
        '
        Me.editbuttonanimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.editbuttonanimator.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.editbuttonanimator.DefaultAnimation = Animation1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'homepage
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1250, 693)
        Me.Controls.Add(Me.rightpanel)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.slidemenu)
        Me.paneltransition.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.editbuttonanimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Student Profile"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.maximize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitbutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.slidemenu.ResumeLayout(False)
        CType(Me.MenuButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rightpanel.ResumeLayout(False)
        Me.rightpanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents header As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents exitbutton As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents paneltransition As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents slidemenu As Panel
    Friend WithEvents editprofilebutton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents messagestudentsbutton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents reportgenerationbutton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents logoutbutton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents findprofilebutton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents createprofilebutton As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents homebuttoneditprofile As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MenuButton As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents minimize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents maximize As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents rightpanel As Panel
    Friend WithEvents BunifuTileButton5 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton4 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton3 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents UpdateProfileButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents createUserTileButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton7 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton6 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents editbuttonanimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Title As Label
End Class
