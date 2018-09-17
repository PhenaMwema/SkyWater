Imports System.Data.SqlClient
Public Class frmBiweeklyIndividuals
    Dim objCommon As New clsCommonMethods
    Dim db As New sky
    Dim data As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        varState = "BiweeklyIndividuals"
        Dim frm As New frmHouseholdIndividuals()
        Me.Close()
        frmHouseholdIndividuals.Show()


    End Sub


    Private Sub frmBiweeklyIndividuals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDetails.Text = varFname + " " + varMname + " " + varLname


    End Sub

    Private Sub DataGridView1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sqlqry As String = "select VID,DSS_ID,Names,Sick,Sick_dur,Loosestool,Othersymptoms,Seektreatment,
                                TreatmentPlace,Treatmentsought,Complaints,Officer, Rec_date  from [SkyWater].[dbo].[IND_Followup]
                                where HHID = '" & varHHID & "'"
        FillMyGrid(DataGridView1, sqlqry)
        'data.Columns.Add("Dssid")
        'data.Columns.Add("Sick")
        'data.Columns.Add("Sick Duration")
        'data.Columns.Add("Loose Stool")
        'data.Columns.Add("Other Symptom")
        'data.Columns.Add("Seek Treatment")
        'data.Columns.Add("Treat Place")
        'data.Columns.Add("Treat Sought")
        'data.Columns.Add("Complaints")
        'DataGridView1.DataSource = data
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim rowIndex = DataGridView1.CurrentRow.Index
        txtDetails.Text = DataGridView1.CurrentRow.Cells(2).Value
        cb_sick.Text = DataGridView1.CurrentRow.Cells(3).Value
        cb_illDuration.Text = DataGridView1.CurrentRow.Cells(4).Value
        cb_looseStool.Text = DataGridView1.CurrentRow.Cells(5).Value
        cb_otherSymptom.Text = DataGridView1.CurrentRow.Cells(6).Value
        cb_seekTreatment.Text = DataGridView1.CurrentRow.Cells(7).Value
        txtTreatplace.Text = DataGridView1.CurrentRow.Cells(8).Value
        txtTreatsought.Text = DataGridView1.CurrentRow.Cells(9).Value
        txtComplaints.Text = DataGridView1.CurrentRow.Cells(10).Value

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'objCommon.GetMyFormValidStatus = objCommon.validateControlsOnForml(Me)

        'Select Case objCommon.GetMyFormValidStatus
        '    Case "invalid"
        '        Exit Sub
        'End Select

        If txtDetails.Enabled = False And txtDetails.Text = "" Then
            Dim result As Integer = MessageBox.Show("Please select an individual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                Return

            End If
        End If

        If cb_sick.Text = "" Or cb_looseStool.Text = "" Or cb_otherSymptom.Text = "" Or cb_seekTreatment.Text = "" Then
            Dim result As Integer = MessageBox.Show("Please fill in the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                Return

            End If
        End If
        If cb_illDuration.Enabled = True And cb_illDuration.Text = "" Then
            Dim result As Integer = MessageBox.Show("Please fill in the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                Return
            End If
        End If

        If txtTreatplace.Enabled = True And txtTreatplace.Text = "" Then
            Dim result As Integer = MessageBox.Show("Please fill in the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                Return
            End If
        End If

        If txtTreatsought.Enabled = True And txtTreatsought.Text = "" Then
            Dim result As Integer = MessageBox.Show("Please fill in the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                Return
            End If
        End If




        fillvalues()
        Try
            db.manage_indFollowUp(varVID, varDssid, varHHID, varName, varSick, varIllduration, varLoosestool, varSeektreatmnt, varTreatplace,
                              varTreatsought, varOthersymt, varComplaints, varOfficer, 1)

            MessageBox.Show("Records inserted.")
        Catch ex As Exception
            msgError(ex.Message)

        Finally
            db.SubmitChanges()
            closeConn()
        End Try

        txtDetails.Text = ""
        cb_sick.Text = ""
        cb_illDuration.Text = ""
        cb_looseStool.Text = ""
        cb_seekTreatment.Text = ""
        txtTreatplace.Text = ""
        txtTreatsought.Text = ""
        txtComplaints.Text = ""
        cb_otherSymptom.Text = ""

        Dim sqlqry As String = "select VID,DSS_ID,Names,Sick,Sick_dur,Loosestool,Othersymptoms,Seektreatment,
                                TreatmentPlace,Treatmentsought,Complaints,Officer, Rec_date  from [SkyWater].[dbo].[IND_Followup]
                                where HHID = '" & varHHID & "'"
        FillMyGrid(DataGridView1, sqlqry)

    End Sub


    Private Sub fillvalues()
        varName = txtDetails.Text
        varSick = cb_sick.Text
        varIllduration = cb_illDuration.Text
        varLoosestool = cb_looseStool.Text
        varOthersymt = cb_otherSymptom.Text
        varSeektreatmnt = cb_seekTreatment.Text
        varTreatplace = txtTreatplace.Text
        varTreatsought = txtTreatplace.Text
        varComplaints = txtComplaints.Text
    End Sub

    Private Sub cb_seekTreatment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_seekTreatment.SelectedIndexChanged
        If cb_seekTreatment.Text = "Yes" Then
            txtTreatplace.Enabled = True
            txtTreatsought.Enabled = True
        Else
            txtTreatplace.Enabled = False
            txtTreatsought.Enabled = False
            txtTreatplace.Text = ""
            txtTreatsought.Text = ""
        End If
    End Sub

    Private Sub cb_sick_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_sick.SelectedIndexChanged
        If cb_sick.Text = "Yes" Then
            cb_illDuration.Enabled = True
        Else
            cb_illDuration.Enabled = False
            cb_illDuration.Text = ""
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        fillvalues()
        varDssid = DataGridView1.CurrentRow.Cells(1).Value
        Try
            db.manage_indFollowUp(varVID, varDssid, varHHID, varName, varSick, varIllduration, varLoosestool, varSeektreatmnt, varTreatplace,
                              varTreatsought, varOthersymt, varComplaints, varOfficer, 2)

            MessageBox.Show("Record updated.")
        Catch ex As Exception
            msgError(ex.Message)

        Finally
            db.SubmitChanges()
            closeConn()
        End Try

        txtDetails.Text = ""
        cb_sick.Text = ""
        cb_illDuration.Text = ""
        cb_looseStool.Text = ""
        cb_seekTreatment.Text = ""
        txtTreatplace.Text = ""
        txtTreatsought.Text = ""
        txtComplaints.Text = ""
        cb_otherSymptom.Text = ""

        Dim sqlqry As String = "select VID,DSS_ID,Names,Sick,Sick_dur,Loosestool,Othersymptoms,Seektreatment,
                                TreatmentPlace,Treatmentsought,Complaints,Officer, Rec_date  from [SkyWater].[dbo].[IND_Followup]
                                where HHID = '" & varHHID & "'"
        FillMyGrid(DataGridView1, sqlqry)
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        varDssid = DataGridView1.CurrentRow.Cells(1).Value
        deleteRecord(varDssid)

        'For Each row As DataGridViewRow In DataGridView1.SelectedRows
        '    DataGridView1.Rows.Remove(row)
        'Next

        Dim sqlqry As String = "select VID,DSS_ID,Names,Sick,Sick_dur,Loosestool,Othersymptoms,Seektreatment,
                                TreatmentPlace,Treatmentsought,Complaints,Officer, Rec_date  from [SkyWater].[dbo].[IND_Followup]
                                where HHID = '" & varHHID & "'"
        FillMyGrid(DataGridView1, sqlqry)
    End Sub


End Class