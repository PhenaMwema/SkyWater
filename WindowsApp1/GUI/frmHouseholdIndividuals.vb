Public Class frmHouseholdIndividuals
    Dim data As New DataTable
    Private Sub Household_Individuals_Load(sender As Object, e As EventArgs) Handles Me.Load

        DataGridView1.RowHeadersVisible = False
        Dim sqlqry As String = "select a.individid, fname, jname, lname, convert(date,[dob],103)[dob],gender from dsshrs.dss.individual a
  left outer join dsshrs.dss.membership b on a.individid = b.individid
  where b.socialgpid is not null  and b.socialgpid = '" & varHHID & "'
  order by b.socialgpid"

        FillMyGrid(DataGridView1, sqlqry)
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        'Dim frm As New frmBaseline()
        'Dim frm2 As frmHouseholdIndividuals()
        'frm.MdiParent = MdiParent

        varDssid = DataGridView1.CurrentRow.Cells("individid").Value.ToString
        varFname = DataGridView1.CurrentRow.Cells("fname").Value.ToString
        varMname = DataGridView1.CurrentRow.Cells("jname").Value.ToString
        varLname = DataGridView1.CurrentRow.Cells("lname").Value.ToString

        varDOB = DataGridView1.CurrentRow.Cells("dob").Value
        vargender = DataGridView1.CurrentRow.Cells("gender").Value.ToString
        'varRelationship = DataGridView3.CurrentRow.Cells("individid").Value
        'varEducation = DataGridView3.CurrentRow.Cells("individid").Value
        'varOccupation = DataGridView3.CurrentRow.Cells("individid").Value
        'varBreastfeed = DataGridView3.CurrentRow.Cells("individid").Value
        'Me.Close()
        If varState = "Baseline" Then
            Dim openFrm = System.Windows.Forms.Application.OpenForms
            If openFrm.OfType(Of frmBaseline).Any Then
                'txtName.Text = varFname
                frmBaseline.dtpDOB.Format = DateTimePickerFormat.Custom
                frmBaseline.dtpDOB.CustomFormat = "yyyy-MM-dd"
                Dim dt As Date = varDOB

                frmBaseline.txtDssid.Text = varDssid
                frmBaseline.txtName.Text = varDssid + " " + varFname + " " + varMname + " " + varLname
                frmBaseline.dtpDOB.Text = dt
                frmBaseline.cbSex.Text = vargender
                Me.Close()
            Else
                Dim frm As New frmBaseline()
                frm.Show()
            End If
        End If
        If varState = "BiweeklyIndividuals" Then
            Dim openFrm = System.Windows.Forms.Application.OpenForms
            If openFrm.OfType(Of frmBiweeklyIndividuals).Any Then
                frmBiweeklyIndividuals.txtDetails.Text = varHHID + " " + varFname + " " + varMname + " " + varLname
                Me.Close()
            Else
                Dim frm As New frmBiweeklyIndividuals()
                frm.Show()
            End If
        End If

    End Sub

    ' Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick, DataGridView1.Click

End Class