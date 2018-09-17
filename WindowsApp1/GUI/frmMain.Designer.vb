<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mmenu_Menu = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Baseline = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Biweekly = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_BiweekIndividuals = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Search = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mmenu_Menu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mmenu_Menu
        '
        Me.mmenu_Menu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_Baseline, Me.menu_Biweekly, Me.menu_BiweekIndividuals, Me.menu_Search, Me.menu_Exit})
        Me.mmenu_Menu.Name = "mmenu_Menu"
        Me.mmenu_Menu.Size = New System.Drawing.Size(50, 20)
        Me.mmenu_Menu.Text = "&Menu"
        '
        'menu_Baseline
        '
        Me.menu_Baseline.Name = "menu_Baseline"
        Me.menu_Baseline.Size = New System.Drawing.Size(180, 22)
        Me.menu_Baseline.Text = "&Baseline"
        '
        'menu_Biweekly
        '
        Me.menu_Biweekly.Name = "menu_Biweekly"
        Me.menu_Biweekly.Size = New System.Drawing.Size(180, 22)
        Me.menu_Biweekly.Text = "&Biweekly"
        '
        'menu_BiweekIndividuals
        '
        Me.menu_BiweekIndividuals.Name = "menu_BiweekIndividuals"
        Me.menu_BiweekIndividuals.Size = New System.Drawing.Size(180, 22)
        Me.menu_BiweekIndividuals.Text = "&Biweekly Individuals"
        '
        'menu_Search
        '
        Me.menu_Search.Name = "menu_Search"
        Me.menu_Search.Size = New System.Drawing.Size(180, 22)
        Me.menu_Search.Text = "&Search"
        '
        'menu_Exit
        '
        Me.menu_Exit.Name = "menu_Exit"
        Me.menu_Exit.Size = New System.Drawing.Size(180, 22)
        Me.menu_Exit.Text = "&Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 295)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mmenu_Menu As ToolStripMenuItem
    Friend WithEvents menu_Baseline As ToolStripMenuItem
    Friend WithEvents menu_Biweekly As ToolStripMenuItem
    Friend WithEvents menu_BiweekIndividuals As ToolStripMenuItem
    Friend WithEvents menu_Search As ToolStripMenuItem
    Friend WithEvents menu_Exit As ToolStripMenuItem

    Private Sub MainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mmenu_Menu.Click

    End Sub

    Private Sub menu_Baseline_Click(sender As Object, e As EventArgs) Handles menu_Baseline.Click
        Dim frm As New frmBaseline()

        frm.MdiParent = Me

        frm.Show()
    End Sub

    Private Sub menu_Biweekly_Click(sender As Object, e As EventArgs) Handles menu_Biweekly.Click
        Dim frm As New frmBiweeklyHH()

        frm.MdiParent = Me

        frm.Show()
    End Sub

    Private Sub menu_BiweekIndividuals_Click(sender As Object, e As EventArgs) Handles menu_BiweekIndividuals.Click
        Dim frm As New frmBiweeklyIndividuals()

        frm.MdiParent = Me

        frm.Show()
    End Sub

    Private Sub menu_Search_Click(sender As Object, e As EventArgs) Handles menu_Search.Click
        Dim frm As New frmSearchUtility()

        frm.MdiParent = Me

        frm.Show()
    End Sub

    Private Sub menu_Exit_Click(sender As Object, e As EventArgs) Handles menu_Exit.Click
        If MdiChildren.Length = 0 Then
            Me.Close()
        Else
            Dim result = MessageBox.Show("Are you sure?",
             "Exit Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
End Class
