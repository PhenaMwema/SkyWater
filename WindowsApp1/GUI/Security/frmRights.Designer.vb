<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRights
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
        Me.cbomod = New System.Windows.Forms.ComboBox()
        Me.grp = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.statusA = New System.Windows.Forms.CheckBox()
        Me.status = New System.Windows.Forms.CheckBox()
        Me.statusD = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmddelete = New System.Windows.Forms.Button()
        Me.dtgrights = New System.Windows.Forms.DataGridView()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dtgrights, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.cbomod)
        Me.GroupBox1.Controls.Add(Me.grp)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(864, 97)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "system rights assignment"
        '
        'cbomod
        '
        Me.cbomod.FormattingEnabled = True
        Me.cbomod.Location = New System.Drawing.Point(423, 21)
        Me.cbomod.Margin = New System.Windows.Forms.Padding(4)
        Me.cbomod.Name = "cbomod"
        Me.cbomod.Size = New System.Drawing.Size(197, 21)
        Me.cbomod.TabIndex = 16
        '
        'grp
        '
        Me.grp.FormattingEnabled = True
        Me.grp.Location = New System.Drawing.Point(120, 21)
        Me.grp.Margin = New System.Windows.Forms.Padding(4)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(197, 21)
        Me.grp.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(651, 25)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(202, 59)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "module accessibility"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.statusA)
        Me.GroupBox5.Controls.Add(Me.status)
        Me.GroupBox5.Controls.Add(Me.statusD)
        Me.GroupBox5.Location = New System.Drawing.Point(120, 50)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(507, 37)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        '
        'statusA
        '
        Me.statusA.AutoSize = True
        Me.statusA.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusA.ForeColor = System.Drawing.Color.Red
        Me.statusA.Location = New System.Drawing.Point(8, 12)
        Me.statusA.Margin = New System.Windows.Forms.Padding(4)
        Me.statusA.Name = "statusA"
        Me.statusA.Size = New System.Drawing.Size(68, 22)
        Me.statusA.TabIndex = 14
        Me.statusA.Text = "ACCESS"
        Me.statusA.UseVisualStyleBackColor = True
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.ForeColor = System.Drawing.Color.Red
        Me.status.Location = New System.Drawing.Point(315, 12)
        Me.status.Margin = New System.Windows.Forms.Padding(4)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(123, 22)
        Me.status.TabIndex = 16
        Me.status.Text = "ACTIVATE RIGHTS"
        Me.status.UseVisualStyleBackColor = True
        '
        'statusD
        '
        Me.statusD.AutoSize = True
        Me.statusD.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusD.ForeColor = System.Drawing.Color.Red
        Me.statusD.Location = New System.Drawing.Point(149, 12)
        Me.statusD.Margin = New System.Windows.Forms.Padding(4)
        Me.statusD.Name = "statusD"
        Me.statusD.Size = New System.Drawing.Size(94, 22)
        Me.statusD.TabIndex = 15
        Me.statusD.Text = "DE - ACCESS"
        Me.statusD.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(361, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Module :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Group  Name :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 468)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(853, 97)
        Me.GroupBox3.TabIndex = 111
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "databse  operations"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdsave)
        Me.GroupBox4.Controls.Add(Me.cmddelete)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 17)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(316, 69)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdsave.Location = New System.Drawing.Point(8, 16)
        Me.cmdsave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(145, 44)
        Me.cmdsave.TabIndex = 16
        Me.cmdsave.Text = "&Assign right"
        Me.cmdsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmddelete
        '
        Me.cmddelete.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmddelete.Location = New System.Drawing.Point(161, 16)
        Me.cmddelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(145, 44)
        Me.cmddelete.TabIndex = 18
        Me.cmddelete.Text = "&Delete right"
        Me.cmddelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'dtgrights
        '
        Me.dtgrights.BackgroundColor = System.Drawing.Color.White
        Me.dtgrights.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgrights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgrights.Location = New System.Drawing.Point(20, 441)
        Me.dtgrights.Margin = New System.Windows.Forms.Padding(4)
        Me.dtgrights.Name = "dtgrights"
        Me.dtgrights.Size = New System.Drawing.Size(853, 19)
        Me.dtgrights.TabIndex = 110
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Receive", "EnterResults", "Print Results", "QC Results", "DeleteOwn", "DeleteOther", "Download", "Search", "ImportData", "ArchiveMaster", "EpiLab", "Accounts Creator"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(20, 117)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(853, 199)
        Me.CheckedListBox1.TabIndex = 114
        '
        'frmRights
        '
        Me.ClientSize = New System.Drawing.Size(889, 578)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtgrights)
        Me.Name = "frmRights"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dtgrights, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbomod As System.Windows.Forms.ComboBox
    Friend WithEvents grp As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents statusA As System.Windows.Forms.CheckBox
    Friend WithEvents status As System.Windows.Forms.CheckBox
    Friend WithEvents statusD As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents dtgrights As System.Windows.Forms.DataGridView
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
