Public Class MainMDI
    Private Sub menu_Baseline_Click(sender As Object, e As EventArgs) Handles menu_Baseline.Click
        varState = "Baseline"
        Dim frm As New frmSearchUtility()
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub menu_BiweeklyHH_Click(sender As Object, e As EventArgs) Handles menu_BiweeklyHH.Click
        varState = "Biweekly"
        Dim frm As New frmSearchUtility()
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub menu_BiweekInd_Click(sender As Object, e As EventArgs) Handles menu_BiweekInd.Click
        varState = "BiweeklyIndividuals"
        Dim frm As New frmSearchUtility()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub menu_Search_Click(sender As Object, e As EventArgs) Handles menu_Search.Click
        Dim frm As New frmSearchUtility()
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles menu_Exit.Click
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

    Private Sub MainMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class