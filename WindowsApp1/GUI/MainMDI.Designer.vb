<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMDI
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menu_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Baseline = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_BiweeklyHH = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_BiweekInd = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Search = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Menu, Me.menu_Exit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(615, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menu_Menu
        '
        Me.menu_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Baseline, Me.menu_BiweeklyHH, Me.menu_BiweekInd, Me.menu_Search})
        Me.menu_Menu.Name = "menu_Menu"
        Me.menu_Menu.Size = New System.Drawing.Size(50, 20)
        Me.menu_Menu.Text = "&Menu"
        '
        'menu_Baseline
        '
        Me.menu_Baseline.Name = "menu_Baseline"
        Me.menu_Baseline.Size = New System.Drawing.Size(177, 22)
        Me.menu_Baseline.Text = "&Baseline"
        '
        'menu_BiweeklyHH
        '
        Me.menu_BiweeklyHH.Name = "menu_BiweeklyHH"
        Me.menu_BiweeklyHH.Size = New System.Drawing.Size(177, 22)
        Me.menu_BiweeklyHH.Text = "&BiweeklyHH"
        '
        'menu_BiweekInd
        '
        Me.menu_BiweekInd.Name = "menu_BiweekInd"
        Me.menu_BiweekInd.Size = New System.Drawing.Size(177, 22)
        Me.menu_BiweekInd.Text = "&BiweeklyIndividuals"
        '
        'menu_Search
        '
        Me.menu_Search.Name = "menu_Search"
        Me.menu_Search.Size = New System.Drawing.Size(177, 22)
        Me.menu_Search.Text = "&SearchUtility"
        Me.menu_Search.Visible = False
        '
        'menu_Exit
        '
        Me.menu_Exit.Name = "menu_Exit"
        Me.menu_Exit.Size = New System.Drawing.Size(37, 20)
        Me.menu_Exit.Text = "&Exit"
        '
        'MainMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 303)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMDI"
        Me.Text = "FormMDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents menu_Menu As ToolStripMenuItem
    Friend WithEvents menu_Baseline As ToolStripMenuItem
    Friend WithEvents menu_BiweeklyHH As ToolStripMenuItem
    Friend WithEvents menu_BiweekInd As ToolStripMenuItem
    Friend WithEvents menu_Search As ToolStripMenuItem
    Friend WithEvents menu_Exit As ToolStripMenuItem
End Class
