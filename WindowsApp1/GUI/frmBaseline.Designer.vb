<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseline
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.numSleeproom = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.numSchchild = New System.Windows.Forms.NumericUpDown()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.txtEdu = New System.Windows.Forms.TextBox()
        Me.txtRel = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cbBfeed = New System.Windows.Forms.ComboBox()
        Me.cbOccupation = New System.Windows.Forms.ComboBox()
        Me.cbEdu = New System.Windows.Forms.ComboBox()
        Me.cbRel = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbSex = New System.Windows.Forms.ComboBox()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDssid = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numSleeproom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSchchild, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(2, -3)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(815, 493)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btn_save)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtOccupation)
        Me.TabPage1.Controls.Add(Me.txtEdu)
        Me.TabPage1.Controls.Add(Me.txtRel)
        Me.TabPage1.Controls.Add(Me.btnRemove)
        Me.TabPage1.Controls.Add(Me.btnAdd)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.cbBfeed)
        Me.TabPage1.Controls.Add(Me.cbOccupation)
        Me.TabPage1.Controls.Add(Me.cbEdu)
        Me.TabPage1.Controls.Add(Me.cbRel)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cbSex)
        Me.TabPage1.Controls.Add(Me.dtpDOB)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.txtDssid)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(788, 485)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.numSleeproom)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.numSchchild)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 394)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 73)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(299, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "3. How many rooms in your household are used for sleeping?  "
        '
        'numSleeproom
        '
        Me.numSleeproom.Location = New System.Drawing.Point(393, 45)
        Me.numSleeproom.Name = "numSleeproom"
        Me.numSleeproom.Size = New System.Drawing.Size(120, 20)
        Me.numSleeproom.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(362, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "2. How many children are school-going and regularly live in the household? "
        '
        'numSchchild
        '
        Me.numSchchild.Location = New System.Drawing.Point(393, 14)
        Me.numSchchild.Name = "numSchchild"
        Me.numSchchild.Size = New System.Drawing.Size(120, 20)
        Me.numSchchild.TabIndex = 40
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(678, 436)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 23)
        Me.btn_save.TabIndex = 38
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label10.Location = New System.Drawing.Point(11, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(756, 23)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Label10"
        '
        'txtOccupation
        '
        Me.txtOccupation.Enabled = False
        Me.txtOccupation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupation.Location = New System.Drawing.Point(482, 149)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(249, 22)
        Me.txtOccupation.TabIndex = 36
        '
        'txtEdu
        '
        Me.txtEdu.Enabled = False
        Me.txtEdu.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdu.Location = New System.Drawing.Point(482, 123)
        Me.txtEdu.Name = "txtEdu"
        Me.txtEdu.Size = New System.Drawing.Size(249, 22)
        Me.txtEdu.TabIndex = 35
        '
        'txtRel
        '
        Me.txtRel.Enabled = False
        Me.txtRel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRel.Location = New System.Drawing.Point(482, 93)
        Me.txtRel.Name = "txtRel"
        Me.txtRel.Size = New System.Drawing.Size(249, 22)
        Me.txtRel.TabIndex = 34
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(610, 176)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(120, 23)
        Me.btnRemove.TabIndex = 33
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(482, 176)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(122, 23)
        Me.btnAdd.TabIndex = 33
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 206)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(767, 182)
        Me.DataGridView1.TabIndex = 32
        '
        'cbBfeed
        '
        Me.cbBfeed.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBfeed.FormattingEnabled = True
        Me.cbBfeed.Items.AddRange(New Object() {"Exclusive", "Non-exclusive", "Not breastfeeding", "Do not know"})
        Me.cbBfeed.Location = New System.Drawing.Point(166, 178)
        Me.cbBfeed.Name = "cbBfeed"
        Me.cbBfeed.Size = New System.Drawing.Size(310, 21)
        Me.cbBfeed.TabIndex = 31
        '
        'cbOccupation
        '
        Me.cbOccupation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOccupation.FormattingEnabled = True
        Me.cbOccupation.Items.AddRange(New Object() {"Teacher", "Mason", "Carpenter", "Welder", "Self-employed", "Unemployed", "Other, Specify:"})
        Me.cbOccupation.Location = New System.Drawing.Point(166, 151)
        Me.cbOccupation.Name = "cbOccupation"
        Me.cbOccupation.Size = New System.Drawing.Size(310, 21)
        Me.cbOccupation.TabIndex = 30
        '
        'cbEdu
        '
        Me.cbEdu.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEdu.FormattingEnabled = True
        Me.cbEdu.Items.AddRange(New Object() {"No formal schooling", "In nursey shool", "Some primary but did not complete", "Completed primary", "In primary school", "In secondary school", "Some secondary but did not complete", "Completed secondary", "In college", "Post-secondary", "Do not know", "Other, Specify:"})
        Me.cbEdu.Location = New System.Drawing.Point(166, 123)
        Me.cbEdu.Name = "cbEdu"
        Me.cbEdu.Size = New System.Drawing.Size(310, 21)
        Me.cbEdu.TabIndex = 29
        '
        'cbRel
        '
        Me.cbRel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRel.FormattingEnabled = True
        Me.cbRel.Items.AddRange(New Object() {"Self (HH head)", "Mother", "Father", "Sister", "Brother", "Daughter", "Son", "Granddaughter", "Grandson", "Aunt", "Uncle", "Other, Specify:"})
        Me.cbRel.Location = New System.Drawing.Point(166, 93)
        Me.cbRel.Name = "cbRel"
        Me.cbRel.Size = New System.Drawing.Size(310, 21)
        Me.cbRel.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Breastfeeding;"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Current Occupation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Highest Education Level"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Relationship to the HH Head"
        '
        'cbSex
        '
        Me.cbSex.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSex.FormattingEnabled = True
        Me.cbSex.Items.AddRange(New Object() {"M", "F"})
        Me.cbSex.Location = New System.Drawing.Point(664, 65)
        Me.cbSex.Name = "cbSex"
        Me.cbSex.Size = New System.Drawing.Size(66, 21)
        Me.cbSex.TabIndex = 23
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "yyyy-MM-dd"
        Me.dtpDOB.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(507, 65)
        Me.dtpDOB.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtpDOB.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(110, 22)
        Me.dtpDOB.TabIndex = 22
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(228, 65)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(237, 22)
        Me.txtName.TabIndex = 21
        '
        'txtDssid
        '
        Me.txtDssid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDssid.Location = New System.Drawing.Point(55, 65)
        Me.txtDssid.Name = "txtDssid"
        Me.txtDssid.Size = New System.Drawing.Size(100, 22)
        Me.txtDssid.TabIndex = 20
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(689, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 25)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(633, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "SEX"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(471, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "DOB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(163, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Full Names"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "DSS ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(675, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "1." & Global.Microsoft.VisualBasic.ChrW(9) & "Please list all household members, not including the household head, in the ta" &
    "ble and their relationship to the household head"
        '
        'frmBaseline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 491)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmBaseline"
        Me.Text = "Baseline - HouseHold"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numSleeproom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSchchild, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents numSleeproom As NumericUpDown
    Friend WithEvents numSchchild As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOccupation As TextBox
    Friend WithEvents txtEdu As TextBox
    Friend WithEvents txtRel As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cbBfeed As ComboBox
    Friend WithEvents cbOccupation As ComboBox
    Friend WithEvents cbEdu As ComboBox
    Friend WithEvents cbRel As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtDssid As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
