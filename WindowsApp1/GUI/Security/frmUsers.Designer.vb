<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Me.lblcount = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lst_users = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grp = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cpwd = New System.Windows.Forms.TextBox()
        Me.pwd = New System.Windows.Forms.TextBox()
        Me.usrnm = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.initials = New System.Windows.Forms.TextBox()
        Me.onames = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.cmdedit = New System.Windows.Forms.Button()
        Me.cmdaddnew = New System.Windows.Forms.Button()
        Me.chk_Wresults = New System.Windows.Forms.CheckBox()
        Me.Chk_QC = New System.Windows.Forms.CheckBox()
        Me.Chk_search = New System.Windows.Forms.CheckBox()
        Me.Chk_download = New System.Windows.Forms.CheckBox()
        Me.Chk_print = New System.Windows.Forms.CheckBox()
        Me.Chk_Epi = New System.Windows.Forms.CheckBox()
        Me.Chk_import = New System.Windows.Forms.CheckBox()
        Me.Chk_ManageFreezer = New System.Windows.Forms.CheckBox()
        Me.Chk_Receive = New System.Windows.Forms.CheckBox()
        Me.grp_Roles = New System.Windows.Forms.GroupBox()
        Me.Chk_ViewAUDITTRAIL = New System.Windows.Forms.CheckBox()
        Me.Chk_GenerateReportd = New System.Windows.Forms.CheckBox()
        Me.Chk_ViewResultsONLY = New System.Windows.Forms.CheckBox()
        Me.Chk_ViewSamplesOnly = New System.Windows.Forms.CheckBox()
        Me.Chk_ManageUsers = New System.Windows.Forms.CheckBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp_Roles.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblcount
        '
        Me.lblcount.AutoSize = True
        Me.lblcount.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcount.Location = New System.Drawing.Point(132, 421)
        Me.lblcount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblcount.Name = "lblcount"
        Me.lblcount.Size = New System.Drawing.Size(14, 16)
        Me.lblcount.TabIndex = 117
        Me.lblcount.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(10, 421)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 16)
        Me.Label17.TabIndex = 116
        Me.Label17.Text = "Record count :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 426)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(50, 11)
        Me.GroupBox4.TabIndex = 115
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "data legend"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(664, 20)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Administer system"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(355, 20)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(129, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "supervises field activivties"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(44, 20)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "conducts data collection"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(601, 20)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "ADMIN :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(251, 20)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "SUPERVISOR :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 21)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "CI :"
        '
        'lst_users
        '
        Me.lst_users.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lst_users.FullRowSelect = True
        Me.lst_users.GridLines = True
        Me.lst_users.Location = New System.Drawing.Point(7, 126)
        Me.lst_users.Margin = New System.Windows.Forms.Padding(4)
        Me.lst_users.Name = "lst_users"
        Me.lst_users.Size = New System.Drawing.Size(595, 275)
        Me.lst_users.TabIndex = 114
        Me.lst_users.UseCompatibleStateImageBehavior = False
        Me.lst_users.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grp)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cpwd)
        Me.GroupBox1.Controls.Add(Me.pwd)
        Me.GroupBox1.Controls.Add(Me.usrnm)
        Me.GroupBox1.Controls.Add(Me.email)
        Me.GroupBox1.Controls.Add(Me.initials)
        Me.GroupBox1.Controls.Add(Me.onames)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.fname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(595, 115)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        '
        'grp
        '
        Me.grp.FormattingEnabled = True
        Me.grp.Location = New System.Drawing.Point(93, 16)
        Me.grp.Margin = New System.Windows.Forms.Padding(4)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(183, 21)
        Me.grp.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 18)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "group ID :"
        '
        'cpwd
        '
        Me.cpwd.Location = New System.Drawing.Point(379, 85)
        Me.cpwd.Margin = New System.Windows.Forms.Padding(4)
        Me.cpwd.Name = "cpwd"
        Me.cpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cpwd.Size = New System.Drawing.Size(205, 20)
        Me.cpwd.TabIndex = 14
        '
        'pwd
        '
        Me.pwd.Location = New System.Drawing.Point(379, 61)
        Me.pwd.Margin = New System.Windows.Forms.Padding(4)
        Me.pwd.Name = "pwd"
        Me.pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pwd.Size = New System.Drawing.Size(205, 20)
        Me.pwd.TabIndex = 13
        '
        'usrnm
        '
        Me.usrnm.Location = New System.Drawing.Point(379, 37)
        Me.usrnm.Margin = New System.Windows.Forms.Padding(4)
        Me.usrnm.Name = "usrnm"
        Me.usrnm.Size = New System.Drawing.Size(205, 20)
        Me.usrnm.TabIndex = 12
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(379, 13)
        Me.email.Margin = New System.Windows.Forms.Padding(4)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(205, 20)
        Me.email.TabIndex = 11
        '
        'initials
        '
        Me.initials.Location = New System.Drawing.Point(93, 88)
        Me.initials.Margin = New System.Windows.Forms.Padding(4)
        Me.initials.Name = "initials"
        Me.initials.Size = New System.Drawing.Size(87, 20)
        Me.initials.TabIndex = 10
        '
        'onames
        '
        Me.onames.Location = New System.Drawing.Point(93, 64)
        Me.onames.Margin = New System.Windows.Forms.Padding(4)
        Me.onames.Name = "onames"
        Me.onames.Size = New System.Drawing.Size(183, 20)
        Me.onames.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(285, 88)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "confirm password :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(285, 64)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(286, 39)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "email address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 93)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User Initials :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Other name :"
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(93, 40)
        Me.fname.Margin = New System.Windows.Forms.Padding(4)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(183, 20)
        Me.fname.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First name :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdsave)
        Me.GroupBox3.Controls.Add(Me.cmddelete)
        Me.GroupBox3.Controls.Add(Me.cmdedit)
        Me.GroupBox3.Controls.Add(Me.cmdaddnew)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 452)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(895, 54)
        Me.GroupBox3.TabIndex = 112
        Me.GroupBox3.TabStop = False
        '
        'cmdsave
        '
        Me.cmdsave.Enabled = False
        Me.cmdsave.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdsave.Location = New System.Drawing.Point(687, 22)
        Me.cmdsave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(95, 26)
        Me.cmdsave.TabIndex = 16
        Me.cmdsave.Text = "&Save  user"
        Me.cmdsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmddelete
        '
        Me.cmddelete.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmddelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmddelete.Location = New System.Drawing.Point(787, 22)
        Me.cmddelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(105, 26)
        Me.cmddelete.TabIndex = 18
        Me.cmddelete.Text = "&Delete user"
        Me.cmddelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'cmdedit
        '
        Me.cmdedit.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdedit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdedit.Location = New System.Drawing.Point(95, 22)
        Me.cmdedit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdedit.Name = "cmdedit"
        Me.cmdedit.Size = New System.Drawing.Size(89, 26)
        Me.cmdedit.TabIndex = 17
        Me.cmdedit.Text = "&Edit Record"
        Me.cmdedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdedit.UseVisualStyleBackColor = True
        '
        'cmdaddnew
        '
        Me.cmdaddnew.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdaddnew.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdaddnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdaddnew.Location = New System.Drawing.Point(8, 22)
        Me.cmdaddnew.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdaddnew.Name = "cmdaddnew"
        Me.cmdaddnew.Size = New System.Drawing.Size(84, 26)
        Me.cmdaddnew.TabIndex = 20
        Me.cmdaddnew.Text = "&New Record"
        Me.cmdaddnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdaddnew.UseVisualStyleBackColor = True
        '
        'chk_Wresults
        '
        Me.chk_Wresults.BackColor = System.Drawing.Color.Transparent
        Me.chk_Wresults.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Wresults.Location = New System.Drawing.Point(8, 34)
        Me.chk_Wresults.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_Wresults.Name = "chk_Wresults"
        Me.chk_Wresults.Size = New System.Drawing.Size(112, 21)
        Me.chk_Wresults.TabIndex = 119
        Me.chk_Wresults.Text = "Results Entries"
        Me.chk_Wresults.UseVisualStyleBackColor = False
        '
        'Chk_QC
        '
        Me.Chk_QC.BackColor = System.Drawing.Color.Transparent
        Me.Chk_QC.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_QC.Location = New System.Drawing.Point(8, 51)
        Me.Chk_QC.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_QC.Name = "Chk_QC"
        Me.Chk_QC.Size = New System.Drawing.Size(146, 17)
        Me.Chk_QC.TabIndex = 119
        Me.Chk_QC.Text = "Results QC"
        Me.Chk_QC.UseVisualStyleBackColor = False
        '
        'Chk_search
        '
        Me.Chk_search.BackColor = System.Drawing.Color.Transparent
        Me.Chk_search.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_search.Location = New System.Drawing.Point(8, 100)
        Me.Chk_search.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_search.Name = "Chk_search"
        Me.Chk_search.Size = New System.Drawing.Size(81, 17)
        Me.Chk_search.TabIndex = 120
        Me.Chk_search.Text = "Search"
        Me.Chk_search.UseVisualStyleBackColor = False
        '
        'Chk_download
        '
        Me.Chk_download.BackColor = System.Drawing.Color.Transparent
        Me.Chk_download.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_download.Location = New System.Drawing.Point(8, 84)
        Me.Chk_download.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_download.Name = "Chk_download"
        Me.Chk_download.Size = New System.Drawing.Size(128, 18)
        Me.Chk_download.TabIndex = 121
        Me.Chk_download.Text = "Download Bulk"
        Me.Chk_download.UseVisualStyleBackColor = False
        '
        'Chk_print
        '
        Me.Chk_print.BackColor = System.Drawing.Color.Transparent
        Me.Chk_print.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_print.Location = New System.Drawing.Point(8, 69)
        Me.Chk_print.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_print.Name = "Chk_print"
        Me.Chk_print.Size = New System.Drawing.Size(128, 17)
        Me.Chk_print.TabIndex = 122
        Me.Chk_print.Text = "Results Printing"
        Me.Chk_print.UseVisualStyleBackColor = False
        '
        'Chk_Epi
        '
        Me.Chk_Epi.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Epi.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Epi.Location = New System.Drawing.Point(8, 132)
        Me.Chk_Epi.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_Epi.Name = "Chk_Epi"
        Me.Chk_Epi.Size = New System.Drawing.Size(146, 17)
        Me.Chk_Epi.TabIndex = 123
        Me.Chk_Epi.Text = "EPI-Lab Comparison"
        Me.Chk_Epi.UseVisualStyleBackColor = False
        '
        'Chk_import
        '
        Me.Chk_import.BackColor = System.Drawing.Color.Transparent
        Me.Chk_import.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_import.Location = New System.Drawing.Point(8, 115)
        Me.Chk_import.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_import.Name = "Chk_import"
        Me.Chk_import.Size = New System.Drawing.Size(112, 19)
        Me.Chk_import.TabIndex = 124
        Me.Chk_import.Text = "Import Data"
        Me.Chk_import.UseVisualStyleBackColor = False
        '
        'Chk_ManageFreezer
        '
        Me.Chk_ManageFreezer.BackColor = System.Drawing.Color.Transparent
        Me.Chk_ManageFreezer.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_ManageFreezer.Location = New System.Drawing.Point(8, 147)
        Me.Chk_ManageFreezer.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_ManageFreezer.Name = "Chk_ManageFreezer"
        Me.Chk_ManageFreezer.Size = New System.Drawing.Size(146, 19)
        Me.Chk_ManageFreezer.TabIndex = 126
        Me.Chk_ManageFreezer.Text = "Manage Freezer"
        Me.Chk_ManageFreezer.UseVisualStyleBackColor = False
        '
        'Chk_Receive
        '
        Me.Chk_Receive.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Receive.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Receive.Location = New System.Drawing.Point(8, 14)
        Me.Chk_Receive.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_Receive.Name = "Chk_Receive"
        Me.Chk_Receive.Size = New System.Drawing.Size(146, 24)
        Me.Chk_Receive.TabIndex = 119
        Me.Chk_Receive.Text = "Receive/Aliquot"
        Me.Chk_Receive.UseVisualStyleBackColor = False
        '
        'grp_Roles
        '
        Me.grp_Roles.BackColor = System.Drawing.Color.Transparent
        Me.grp_Roles.Controls.Add(Me.Chk_ViewAUDITTRAIL)
        Me.grp_Roles.Controls.Add(Me.Chk_GenerateReportd)
        Me.grp_Roles.Controls.Add(Me.Chk_ViewResultsONLY)
        Me.grp_Roles.Controls.Add(Me.Chk_ViewSamplesOnly)
        Me.grp_Roles.Controls.Add(Me.Chk_ManageUsers)
        Me.grp_Roles.Controls.Add(Me.Chk_ManageFreezer)
        Me.grp_Roles.Controls.Add(Me.Chk_Epi)
        Me.grp_Roles.Controls.Add(Me.Chk_import)
        Me.grp_Roles.Controls.Add(Me.Chk_search)
        Me.grp_Roles.Controls.Add(Me.Chk_download)
        Me.grp_Roles.Controls.Add(Me.Chk_print)
        Me.grp_Roles.Controls.Add(Me.Chk_QC)
        Me.grp_Roles.Controls.Add(Me.chk_Wresults)
        Me.grp_Roles.Controls.Add(Me.Chk_Receive)
        Me.grp_Roles.Location = New System.Drawing.Point(631, 126)
        Me.grp_Roles.Name = "grp_Roles"
        Me.grp_Roles.Size = New System.Drawing.Size(156, 275)
        Me.grp_Roles.TabIndex = 128
        Me.grp_Roles.TabStop = False
        Me.grp_Roles.Text = "Select Rights"
        Me.grp_Roles.Visible = False
        '
        'Chk_ViewAUDITTRAIL
        '
        Me.Chk_ViewAUDITTRAIL.BackColor = System.Drawing.Color.Transparent
        Me.Chk_ViewAUDITTRAIL.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_ViewAUDITTRAIL.Location = New System.Drawing.Point(8, 234)
        Me.Chk_ViewAUDITTRAIL.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_ViewAUDITTRAIL.Name = "Chk_ViewAUDITTRAIL"
        Me.Chk_ViewAUDITTRAIL.Size = New System.Drawing.Size(146, 20)
        Me.Chk_ViewAUDITTRAIL.TabIndex = 126
        Me.Chk_ViewAUDITTRAIL.Text = "View Audit Trail"
        Me.Chk_ViewAUDITTRAIL.UseVisualStyleBackColor = False
        '
        'Chk_GenerateReportd
        '
        Me.Chk_GenerateReportd.BackColor = System.Drawing.Color.Transparent
        Me.Chk_GenerateReportd.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_GenerateReportd.Location = New System.Drawing.Point(8, 217)
        Me.Chk_GenerateReportd.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_GenerateReportd.Name = "Chk_GenerateReportd"
        Me.Chk_GenerateReportd.Size = New System.Drawing.Size(146, 20)
        Me.Chk_GenerateReportd.TabIndex = 126
        Me.Chk_GenerateReportd.Text = "Generate Reports"
        Me.Chk_GenerateReportd.UseVisualStyleBackColor = False
        '
        'Chk_ViewResultsONLY
        '
        Me.Chk_ViewResultsONLY.BackColor = System.Drawing.Color.Transparent
        Me.Chk_ViewResultsONLY.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_ViewResultsONLY.Location = New System.Drawing.Point(8, 200)
        Me.Chk_ViewResultsONLY.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_ViewResultsONLY.Name = "Chk_ViewResultsONLY"
        Me.Chk_ViewResultsONLY.Size = New System.Drawing.Size(146, 15)
        Me.Chk_ViewResultsONLY.TabIndex = 126
        Me.Chk_ViewResultsONLY.Text = "View Results ONLY"
        Me.Chk_ViewResultsONLY.UseVisualStyleBackColor = False
        '
        'Chk_ViewSamplesOnly
        '
        Me.Chk_ViewSamplesOnly.BackColor = System.Drawing.Color.Transparent
        Me.Chk_ViewSamplesOnly.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_ViewSamplesOnly.Location = New System.Drawing.Point(8, 183)
        Me.Chk_ViewSamplesOnly.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_ViewSamplesOnly.Name = "Chk_ViewSamplesOnly"
        Me.Chk_ViewSamplesOnly.Size = New System.Drawing.Size(146, 15)
        Me.Chk_ViewSamplesOnly.TabIndex = 126
        Me.Chk_ViewSamplesOnly.Text = "View Samples ONLY"
        Me.Chk_ViewSamplesOnly.UseVisualStyleBackColor = False
        '
        'Chk_ManageUsers
        '
        Me.Chk_ManageUsers.BackColor = System.Drawing.Color.Transparent
        Me.Chk_ManageUsers.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_ManageUsers.Location = New System.Drawing.Point(8, 166)
        Me.Chk_ManageUsers.Margin = New System.Windows.Forms.Padding(1)
        Me.Chk_ManageUsers.Name = "Chk_ManageUsers"
        Me.Chk_ManageUsers.Size = New System.Drawing.Size(146, 15)
        Me.Chk_ManageUsers.TabIndex = 126
        Me.Chk_ManageUsers.Text = "Manage Users"
        Me.Chk_ManageUsers.UseVisualStyleBackColor = False
        '
        'frmUsers
        '
        Me.ClientSize = New System.Drawing.Size(911, 512)
        Me.Controls.Add(Me.grp_Roles)
        Me.Controls.Add(Me.lblcount)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.lst_users)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "frmUsers"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.grp_Roles.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcount As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lst_users As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grp As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cpwd As System.Windows.Forms.TextBox
    Friend WithEvents pwd As System.Windows.Forms.TextBox
    Friend WithEvents usrnm As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents initials As System.Windows.Forms.TextBox
    Friend WithEvents onames As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdedit As System.Windows.Forms.Button
    Friend WithEvents cmdaddnew As System.Windows.Forms.Button
    Friend WithEvents chk_Wresults As CheckBox
    Friend WithEvents Chk_QC As CheckBox
    Friend WithEvents Chk_search As CheckBox
    Friend WithEvents Chk_download As CheckBox
    Friend WithEvents Chk_print As CheckBox
    Friend WithEvents Chk_Epi As CheckBox
    Friend WithEvents Chk_import As CheckBox
    Friend WithEvents Chk_ManageFreezer As CheckBox
    Friend WithEvents Chk_Receive As CheckBox
    Friend WithEvents grp_Roles As GroupBox
    Friend WithEvents Chk_ManageUsers As CheckBox
    Friend WithEvents Chk_GenerateReportd As CheckBox
    Friend WithEvents Chk_ViewResultsONLY As CheckBox
    Friend WithEvents Chk_ViewSamplesOnly As CheckBox
    Friend WithEvents Chk_ViewAUDITTRAIL As CheckBox
End Class
