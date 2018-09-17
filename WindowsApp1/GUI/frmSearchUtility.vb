Public Class frmSearchUtility


    Private Sub frmSeachUtility_Load(sender As Object, e As EventArgs) Handles Me.Load

        'DataGridView3.RowHeadersVisible = False
        Dim sql As String = "select villcode, villname from DSSHRS.[DSS].[villages] where villcode <=10"
        FillMyGrid(DataGridView1, sql)

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click

        varVilcode = DataGridView1.CurrentRow.Cells("Villcode").Value 'reads vilcode
        Dim sqlqry As String = "SELECT distinct b.socialgpid[HHID], e.adminid, f.fname,f.jname, f.lname
  From [DSSHRS].[DSS].[location] a
  Left outer join [DSSHRS].[DSS].[socialgroup] b on locationid = b.location
  Left outer join [DSSHRS].[DSS].[compounds] c on a.compoundID = c.compoundid
  Left outer join [DSSHRS].[DSS].[villages] d on c.villcode = d.villcode
  Left outer join [DSSHRS].DSS.SocialGroupadmin e on b.socialgpid = e.socialgpid
  Left outer join [DSSHRS].DSS.individual f on e.adminid = f.individid
  where b.socialgpid Is Not null and c.villcode = '" & varVilcode & "' 
  order by b.socialgpid"


        FillMyGrid(DataGridView2, sqlqry)
    End Sub

    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        varDOB = Nothing
        varDssid = ""
        varFname = " "
        varMname = " "
        varLname = ""
        vargender = ""

        varHHID = DataGridView2.CurrentRow.Cells("HHID").Value.ToString
        'Dim pass = DataGridView2.CurrentRow.Cells("HHID").Value.ToString
        If varState = "Baseline" Then
            Dim frm As New frmBaseline()
            frm.MdiParent = MdiParent
            frm.Show()

            'frm.Dispose()
        ElseIf varState = "Biweekly" Then
            Dim frm As New frmBiweeklyHH()
            frm.MdiParent = MdiParent
            frm.Show()
        ElseIf varState = "BiweeklyIndividuals" Then
            Dim frm As New frmBiweeklyIndividuals()
            frm.MdiParent = MdiParent
            frm.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        varSearch = txtSearch.Text
        Dim sqlqry As String = "SELECT distinct b.socialgpid[HHID], e.adminid, f.fname,f.jname, f.lname
  From [DSSHRS].[DSS].[location] a
  Left outer join [DSSHRS].[DSS].[socialgroup] b on locationid = b.location
  Left outer join [DSSHRS].[DSS].[compounds] c on a.compoundID = c.compoundid
  Left outer join [DSSHRS].[DSS].[villages] d on c.villcode = d.villcode
  Left outer join [DSSHRS].DSS.SocialGroupadmin e on b.socialgpid = e.socialgpid
  Left outer join [DSSHRS].DSS.individual f on e.adminid = f.individid
  where b.socialgpid Is Not null and b.socialgpid = '" & varSearch & "' 
  order by b.socialgpid"

        FillMyGrid(DataGridView2, sqlqry)
    End Sub
End Class