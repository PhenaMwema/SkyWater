Imports System.Data.SqlClient
Public Class frmBaseline
    Dim db As New sky
    Dim objCommon As New clsCommonMethods
    Dim data As New DataTable

    'Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

    '    objCommon.GetMyFormValidStatus = objCommon.validateControlsOnTabPage(TabPage1)

    '    Select Case objCommon.GetMyFormValidStatus
    '        Case "invalid"
    '            Return
    '            Exit Sub
    '    End Select

    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim frm As frmHouseholdIndividuals()

        varState = "Baseline"
        Dim frm As New frmHouseholdIndividuals()
        Me.Close()
        frmHouseholdIndividuals.Show()

    End Sub

    Private Sub frmBaseline_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpDOB.Format = DateTimePickerFormat.Custom
        dtpDOB.CustomFormat = "yyyy-MM-dd"
        Dim dt As Date = varDOB

        txtDssid.Text = varDssid
        txtName.Text = varFname + " " + varMname + " " + varLname
        dtpDOB.Text = dt
        cbSex.Text = vargender
        'cbRel.Text = varRelationship
        'txtRel.Text = varRelationship
        'cbEdu.Text = varEducation
        'txtEdu.Text = varEducation
        'cbEdu.Text = varOccupation
        'txtEdu.Text = varOccupation
        'cbBfeed.Text = varBreastfeed
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As EventArgs) Handles MyBase.Load

        data.Columns.Add("Dssid")
        data.Columns.Add("Name")
        data.Columns.Add("DOB")
        data.Columns.Add("Sex")
        data.Columns.Add("Relationship")
        data.Columns.Add("Education")
        data.Columns.Add("Occupation")
        data.Columns.Add("Breastfeed")
        DataGridView1.DataSource = data
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cbEdu.Text = "" Or cbRel.Text = "" Or cbOccupation.Text = "" Or cbBfeed.Text = "" Then
            Dim result As Integer = MessageBox.Show("Please fill in the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If result = DialogResult.OK Then
                Return
            Else
                cbEdu.Text = cbEdu.Text
                cbOccupation.Text = cbOccupation.Text
                cbRel.Text = cbRel.Text
            End If
        End If

        If cbRel.Text = "Other, Specify:" Then
            If txtRel.Enabled = True And txtRel.Text = " " Then
                Dim result As Integer = MessageBox.Show("Please fill in the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    Return
                End If
            Else cbRel.Text = txtRel.Text
            End If
        End If

        If cbEdu.Text = "Other, Specify:" Then
            If txtEdu.Enabled = True And txtEdu.Text = " " Then
                Dim result As Integer = MessageBox.Show("Please fill in the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    Return
                End If
            Else cbEdu.Text = txtEdu.Text
            End If
        End If

        If cbOccupation.Text = "Other, Specify:" Then
            If txtOccupation.Enabled = True And txtOccupation.Text = " " Then
                Dim result As Integer = MessageBox.Show("Please fill in the required fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                If result = DialogResult.OK Then
                    Return
                End If
            Else cbOccupation.Text = txtOccupation.Text
            End If
        End If

        ''instert data into gridview by column
        'data.Rows.Add(txtDssid.Text, txtName.Text, dtpDOB.Text, cbSex.Text, cbRel.Text, cbEdu.Text, cbOccupation.Text, cbBfeed.Text)
        'DataGridView1.DataSource = data

        fillvalues()

        Try
            db.manage_indBaseline(varVID, varHHID, varDssid, varName, varDOB, vargender, varRelationship, varEducation, varOccupation, varBreastfeed, varVisitcode, varOfficer, 1)

            MessageBox.Show("Added.")
        Catch ex As Exception
            msgError(ex.Message)

        Finally
            db.SubmitChanges()
            closeConn()
        End Try

        cbBfeed.Text = ""
        cbEdu.Text = ""
        cbOccupation.Text = ""
        cbRel.Text = ""
        txtEdu.Text = ""
        txtOccupation.Text = ""
        txtRel.Text = ""
        txtDssid.Text = ""
        txtName.Text = ""
        dtpDOB.ResetText()
        cbSex.Text = ""

        Dim sqlqry As String = "select vid,dss_id,full_names,dob,sex,relhh,education,occupation,breastfeeding,visitcode,officer, Rec_date  from [SkyWater].[dbo].[IND_Baseline]
  where hhid = '" & varHHID & "'"
        FillMyGrid(DataGridView1, sqlqry)

        'End Using
    End Sub

    Private Sub cbRel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRel.SelectedIndexChanged
        If cbRel.Text = "Other, Specify:" Then
            txtRel.Enabled = True
        Else
            txtRel.Enabled = False
            txtRel.Text = ""
        End If
    End Sub

    Private Sub cbEdu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEdu.SelectedIndexChanged
        If cbEdu.Text = "Other, Specify:" Then
            txtEdu.Enabled = True
        Else
            txtEdu.Enabled = False
            txtEdu.Text = ""
        End If
    End Sub

    Private Sub cbOccupation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOccupation.SelectedIndexChanged
        If cbOccupation.Text = "Other, Specify:" Then
            txtOccupation.Enabled = True
        Else
            txtOccupation.Enabled = False
            txtOccupation.Text = ""
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            DataGridView1.Rows.Remove(row)
        Next
    End Sub

    Private Sub fillvalues()

        varIndividId = txtDssid.Text

        varName = txtName.Text

        varDOB = dtpDOB.Value

        vargender = cbSex.Text

        If cbRel.Text = "Other, Specify:" And
                txtRel.Enabled = True Then
            varRelationship = txtRel.Text
        Else
            varRelationship = cbRel.Text

        End If

        If cbEdu.Text = "Other, Specify:" And
                txtEdu.Enabled = True Then
            varEducation = txtEdu.Text
        Else
            varEducation = cbEdu.Text

        End If

        If cbOccupation.Text = "Other, Specify:" And
                txtOccupation.Enabled = True Then
            varOccupation = txtOccupation.Text
        Else
            varOccupation = cbOccupation.Text
        End If
        varBreastfeed = cbBfeed.Text
        varSchchild = numSchchild.Value

        varSleeproom = numSleeproom.Value
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        fillvalues()
        Dim varVisitno As String = GetNextID()
        If varVisitno Is Nothing Then
            varVisitno = "1"
        Else
            varVisitno = GetNextID()
        End If

        'varHHH = ""
        varHHH = GetHeadName()
        If varHHH Is Nothing Then
            varHHH = ""
        Else
            varHHH = GetHeadName()
        End If
        Try

            If MessageBox.Show("Save and close form?", "Save form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                db.HHBaseline(varVID, varHHID, varHHH, varVisitno, varSchchild, varSleeproom, varrec_date, varOfficer, 1)

                Me.Close()
                ' System.Console.WriteLine("OK Clicked")
            Else
                'System.Console.WriteLine("Cancel Clicked")
                Return
            End If

            'MessageBox.Show("Form Saved")
            'Me.Close()
        Catch ex As Exception
            msgError(ex.Message)
        End Try
    End Sub


End Class
