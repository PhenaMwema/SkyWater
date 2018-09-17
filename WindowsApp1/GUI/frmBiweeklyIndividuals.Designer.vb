<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBiweeklyIndividuals
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cb_otherSymptom = New System.Windows.Forms.ComboBox()
        Me.cb_looseStool = New System.Windows.Forms.ComboBox()
        Me.cb_illDuration = New System.Windows.Forms.ComboBox()
        Me.cb_sick = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb_seekTreatment = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTreatsought = New System.Windows.Forms.TextBox()
        Me.txtTreatplace = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtComplaints = New System.Windows.Forms.TextBox()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button2.Location = New System.Drawing.Point(734, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 262)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(696, 207)
        Me.DataGridView1.TabIndex = 59
        '
        'cb_otherSymptom
        '
        Me.cb_otherSymptom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_otherSymptom.FormattingEnabled = True
        Me.cb_otherSymptom.Items.AddRange(New Object() {"Yes", "No"})
        Me.cb_otherSymptom.Location = New System.Drawing.Point(247, 122)
        Me.cb_otherSymptom.Name = "cb_otherSymptom"
        Me.cb_otherSymptom.Size = New System.Drawing.Size(137, 25)
        Me.cb_otherSymptom.TabIndex = 58
        '
        'cb_looseStool
        '
        Me.cb_looseStool.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_looseStool.FormattingEnabled = True
        Me.cb_looseStool.Items.AddRange(New Object() {"Yes", "No"})
        Me.cb_looseStool.Location = New System.Drawing.Point(396, 92)
        Me.cb_looseStool.Name = "cb_looseStool"
        Me.cb_looseStool.Size = New System.Drawing.Size(128, 25)
        Me.cb_looseStool.TabIndex = 57
        '
        'cb_illDuration
        '
        Me.cb_illDuration.Enabled = False
        Me.cb_illDuration.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_illDuration.FormattingEnabled = True
        Me.cb_illDuration.Items.AddRange(New Object() {"No formal schooling", "In nursey shool", "Some primary but did not complete", "Completed primary", "In primary school", "In secondary school", "Some secondary but did not complete", "Completed secondary", "In college", "Post-secondary", "Do not know"})
        Me.cb_illDuration.Location = New System.Drawing.Point(544, 59)
        Me.cb_illDuration.Name = "cb_illDuration"
        Me.cb_illDuration.Size = New System.Drawing.Size(265, 25)
        Me.cb_illDuration.TabIndex = 56
        '
        'cb_sick
        '
        Me.cb_sick.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_sick.FormattingEnabled = True
        Me.cb_sick.Items.AddRange(New Object() {"Yes", "No"})
        Me.cb_sick.Location = New System.Drawing.Point(294, 58)
        Me.cb_sick.Name = "cb_sick"
        Me.cb_sick.Size = New System.Drawing.Size(103, 25)
        Me.cb_sick.TabIndex = 55
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(214, 17)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Did you have any other Symptoms?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(357, 17)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Did you have 3 or more loose stools in the past two weeks?"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(403, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 17)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Duration of the illness"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(255, 17)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Have you been sick in the past two weeks?"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(764, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 22)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 22)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "12. Illness Assesment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 17)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Did you seek any treatment?"
        '
        'cb_seekTreatment
        '
        Me.cb_seekTreatment.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_seekTreatment.FormattingEnabled = True
        Me.cb_seekTreatment.Items.AddRange(New Object() {"Yes", "No"})
        Me.cb_seekTreatment.Location = New System.Drawing.Point(247, 153)
        Me.cb_seekTreatment.Name = "cb_seekTreatment"
        Me.cb_seekTreatment.Size = New System.Drawing.Size(137, 25)
        Me.cb_seekTreatment.TabIndex = 58
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(734, 325)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 72
        Me.Button3.Text = "Edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label20.Location = New System.Drawing.Point(403, 153)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 17)
        Me.Label20.TabIndex = 73
        Me.Label20.Text = "Where?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(35, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Treatment sought"
        '
        'txtTreatsought
        '
        Me.txtTreatsought.Enabled = False
        Me.txtTreatsought.Location = New System.Drawing.Point(151, 190)
        Me.txtTreatsought.Multiline = True
        Me.txtTreatsought.Name = "txtTreatsought"
        Me.txtTreatsought.Size = New System.Drawing.Size(658, 25)
        Me.txtTreatsought.TabIndex = 76
        '
        'txtTreatplace
        '
        Me.txtTreatplace.Enabled = False
        Me.txtTreatplace.Location = New System.Drawing.Point(461, 153)
        Me.txtTreatplace.Multiline = True
        Me.txtTreatplace.Name = "txtTreatplace"
        Me.txtTreatplace.Size = New System.Drawing.Size(348, 25)
        Me.txtTreatplace.TabIndex = 77
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.Label10.Location = New System.Drawing.Point(35, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 17)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Other complaints"
        '
        'txtComplaints
        '
        Me.txtComplaints.Location = New System.Drawing.Point(151, 220)
        Me.txtComplaints.Multiline = True
        Me.txtComplaints.Name = "txtComplaints"
        Me.txtComplaints.Size = New System.Drawing.Size(658, 25)
        Me.txtComplaints.TabIndex = 79
        '
        'txtDetails
        '
        Me.txtDetails.Enabled = False
        Me.txtDetails.Location = New System.Drawing.Point(38, 24)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(720, 25)
        Me.txtDetails.TabIndex = 80
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(734, 372)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 81
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(734, 424)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 82
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'frmBiweeklyIndividuals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 491)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtDetails)
        Me.Controls.Add(Me.txtComplaints)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtTreatplace)
        Me.Controls.Add(Me.txtTreatsought)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cb_seekTreatment)
        Me.Controls.Add(Me.cb_otherSymptom)
        Me.Controls.Add(Me.cb_looseStool)
        Me.Controls.Add(Me.cb_illDuration)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cb_sick)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBiweeklyIndividuals"
        Me.Text = "frmBiweeklyIndividuals"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cb_otherSymptom As ComboBox
    Friend WithEvents cb_looseStool As ComboBox
    Friend WithEvents cb_illDuration As ComboBox
    Friend WithEvents cb_sick As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb_seekTreatment As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTreatsought As TextBox
    Friend WithEvents txtTreatplace As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtComplaints As TextBox
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDel As Button
End Class
