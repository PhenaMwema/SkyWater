Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.Form
Imports System.Security.Cryptography
Imports System.Text
Public Class frmUsers

    Public flag As String = "NO"
    Dim objCommon As New clsCommonMethods
    Dim objUsers As New clsManageUsers

    Private Sub frmusers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '  objCommon.SetCurrentFormMode = "examination"
        objUsers.FormSkipRulesController(Me, objCommon.SetCurrentFormMode)
        loadCombo(Me.grp, "SELECT [group],groupID FROM [elab].[settings].[groups] WHERE status='NO'", "group", "groupID")
        lstSystemusers(lst_users, "SELECT * FROM [elab].[settings].[users]")






    End Sub


    Private Sub GetRights()
        If Chk_Receive.CheckState = CheckState.Checked Then
            Receive = "YES"
        Else
            Receive = "NO"
        End If
        If chk_Wresults.CheckState = CheckState.Checked Then
            Results = "YES"
        Else
            Results = "NO"
        End If

        If Chk_print.CheckState = CheckState.Checked Then
            Printing = "YES"
        Else
            Printing = "NO"
        End If
        If Chk_QC.CheckState = CheckState.Checked Then
            QC = "YES"
        Else
            QC = "NO"
        End If


        EnterResults = "NO"


        If Chk_GenerateReportd.CheckState = CheckState.Checked Then
            Reports = "YES"
        Else
            Reports = "NO"
        End If

        If Chk_Epi.CheckState = CheckState.Checked Then
            epi = "YES"
        Else
            epi = "NO"
        End If

        If Chk_download.CheckState = CheckState.Checked Then
            Download = "YES"
        Else
            Download = "NO"
        End If


        If Chk_import.CheckState = CheckState.Checked Then
            Import = "YES"
        Else
            Import = "NO"
        End If


        If Chk_search.CheckState = CheckState.Checked Then
            Search = "YES"
        Else
            Search = "NO"
        End If

        If Chk_ManageUsers.CheckState = CheckState.Checked Then
            ManageUsers = "YES"
        Else
            ManageUsers = "NO"
        End If

        If Chk_ManageFreezer.CheckState = CheckState.Checked Then
            ManageFreezer = "YES"
        Else
            ManageFreezer = "NO"
        End If

        If Chk_ViewSamplesOnly.CheckState = CheckState.Checked Then
            ViewsampleONLY = "YES"
        Else
            ViewsampleONLY = "NO"
        End If

        If Chk_ViewResultsONLY.CheckState = CheckState.Checked Then
            viewResultsONLY = "YES"
        Else
            viewResultsONLY = "NO"
        End If
        If Chk_ViewAUDITTRAIL.CheckState = CheckState.Checked Then
            ViewAuditTrail = "YES"
        Else
            ViewAuditTrail = "NO"
        End If

        'If chk_ViewInventory.CheckState = CheckState.Checked Then
        '    ViewInventory = "YES"
        'Else
        '    ViewInventory = "NO"
        'End If

        'If chk_ManageInventory.CheckState = CheckState.Checked Then
        '    manageinventory = "YES"
        'Else
        '    manageinventory = "NO"
        'End If







    End Sub


    Public Sub RightsLoad()
        If Receive = "YES" Then
            Chk_Receive.Checked = True
        Else
            Chk_Receive.CheckState = CheckState.Unchecked
        End If


        If Results = "YES" Then
            chk_Wresults.Checked = True
        Else
            chk_Wresults.CheckState = CheckState.Unchecked
        End If


        If Printing = "YES" Then
            Chk_print.Checked = True
        Else
            Chk_print.CheckState = CheckState.Unchecked
        End If



        If QC = "YES" Then
            Chk_QC.Checked = True
        Else
            Chk_QC.CheckState = CheckState.Unchecked
        End If


        EnterResults = "NO"


        If Reports = "YES" Then
            Chk_GenerateReportd.Checked = True
        Else
            Chk_GenerateReportd.CheckState = CheckState.Unchecked
        End If

        If epi = "YES" Then
            Chk_Epi.Checked = True
        Else
            Chk_Epi.CheckState = CheckState.Unchecked
        End If

        If Download = "YES" Then
            Chk_download.Checked = True
        Else
            Chk_download.CheckState = CheckState.Unchecked
        End If


        If Import = "YES" Then
            Chk_import.Checked = True
        Else
            Chk_import.CheckState = CheckState.Unchecked
        End If


        If Search = "YES" Then
            Chk_search.Checked = True
        Else
            Chk_search.CheckState = CheckState.Unchecked
        End If

        If ManageUsers = "YES" Then
            Chk_ManageUsers.Checked = True
        Else
            Chk_ManageUsers.CheckState = CheckState.Unchecked
        End If

        If ManageFreezer = "YES" Then
            Chk_ManageFreezer.Checked = True
        Else
            Chk_ManageFreezer.CheckState = CheckState.Unchecked
        End If


        If ViewsampleONLY = "YES" Then
            Chk_ViewSamplesOnly.Checked = True
        Else
            Chk_ViewSamplesOnly.CheckState = CheckState.Unchecked
        End If

        If viewResultsONLY = "YES" Then
            Chk_ViewResultsONLY.Checked = True
        Else
            Chk_ViewResultsONLY.CheckState = CheckState.Unchecked
        End If

        If ViewAuditTrail = "YES" Then
            Chk_ViewAUDITTRAIL.Checked = True
        Else
            Chk_ViewAUDITTRAIL.CheckState = CheckState.Unchecked
        End If

        'If ViewInventory = "YES" Then
        '    chk_ViewInventory.checked = true
        'Else
        '    chk_ViewInventory.CheckState = CheckState.Unchecked
        'End If

        'If ManageInventory = "YES" Then
        '    chk_ManageInventory.checked = true
        'Else
        '    chk_ManageInventory.CheckState = CheckState.Unchecked
        'End If

    End Sub



    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdsave.Click
        'perform validation
        Dim validate_ok As Boolean = validate_users()
        If validate_ok Then
            Exit Sub
        End If
        GetRights()
        Select Case objCommon.SetCurrentFormMode
            Case "Add"
                objUsers.AddNewRecord(Me)
                lstSystemusers(lst_users, "SELECT * FROM [elab].[settings].[users]")

            Case "Edit"

                objUsers.EditOldRecord(Me, Val(lst_users.SelectedItems.Item(0).Text))
                lstSystemusers(lst_users, "SELECT * FROM [elab].[settings].[users]")

                cmdsave.Enabled = False
                GroupBox1.Enabled = False
        End Select
    End Sub

    Private Sub cmdedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdedit.Click
        objCommon.SetCurrentFormMode = "Edit"
        objUsers.FormSkipRulesController(Me, objCommon.SetCurrentFormMode)

        cmdsave.Enabled = True
        grp_Roles.Enabled = True
        cmdsave.Text = "Update Record"
        '  GroupBox1.Enabled = False

        fname.BackColor = Color.Pink
        grp.BackColor = Color.Pink
        onames.BackColor = Color.Pink
        initials.BackColor = Color.Pink
        email.BackColor = Color.Pink
        usrnm.BackColor = Color.Pink
        pwd.BackColor = Color.Pink
        cpwd.BackColor = Color.Pink





    End Sub
    Private Sub cmdaddnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdaddnew.Click

        objCommon.SetCurrentFormMode = "Add"
        objUsers.FormSkipRulesController(Me, objCommon.SetCurrentFormMode)
        Me.grp.DataSource = Nothing
        ResetControls(GroupBox1)
        Me.grp.DataSource = Nothing

        cmdsave.Enabled = True
        cmdsave.Text = "Save User"
        GroupBox1.Enabled = True

       
        loadCombo(Me.grp, "SELECT [group],groupID FROM settings.groups WHERE status='NO'", "group", "groupID")

        fname.BackColor = Color.White
        grp.BackColor = Color.White
        onames.BackColor = Color.White
        initials.BackColor = Color.White
        email.BackColor = Color.White
        usrnm.BackColor = Color.White
        pwd.BackColor = Color.White
        cpwd.BackColor = Color.White





    End Sub

    Private Sub dtgusers_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        msgError("cell content")
    End Sub

    Private Sub cmdclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case MsgBox("Are you sure you want to close this window ?", MsgBoxStyle.YesNo, "Patient care System | IEIP")

            Case MsgBoxResult.Yes
                Me.Close()
            Case MsgBoxResult.No
                Exit Sub
        End Select
    End Sub
    Public Sub lst_view_users()

        Windows.Forms.Cursor.Current = Cursors.WaitCursor
        Try
            openConn() 'open db conn

            Dim mm_sql As String = "SELECT isnull(userID,0)userID,
isnull(groupID,0)groupID,
isnull(fname,'NO')fname,
isnull(onames,'NO')onames,
isnull(code,'NO')code,
isnull(username,'NO')username,
isnull([password],'NO')[password],
isnull(logged,'NO')logged,
isnull(email,'NO')email,
isnull(destination,'NO')destination,
isnull(date,'1900-01-01')date,
isnull(status,'NO')status,
isnull(officer,'NO')officer,
isnull(DATEE,'1900-01-01')DATEE,
isnull(Receive,'NO')Receive,
isnull(Results,'NO')Results,
isnull(Printing,'NO')Printing,
isnull(QC,'NO')QC,
isnull(EnterResults,'NO')EnterResults,
isnull(epi,'NO')epi,
isnull(reports,'NO')reports,
isnull(Download,'NO')Download,
isnull(Import,'NO')Import,
isnull(Search,'NO')Search,
isnull(ManageUsers,'NO')ManageUsers,
isnull(ManageFreezer,'NO')ManageFreezer,
isnull(userstatus,'NO')userstatus,
isnull(LastLogin,'1900-01-01')LastLogin,
isnull(ViewsampleONLY,'NO')ViewsampleONLY,
isnull(viewResultsONLY,'NO')viewResultsONLY,
isnull(ViewAuditTrail,'NO')ViewAuditTrail
  FROM [eLab].[settings].[users] WHERE userID=" & Val(Me.lst_users.SelectedItems.Item(0).Text)
            Dim mm_cmd As New SqlCommand(mm_sql, Qconn)
            Dim mm_dr As SqlDataReader = mm_cmd.ExecuteReader

            If mm_dr.HasRows Then
                While mm_dr.Read
                    fname.Text = mm_dr.Item("fname")
                    onames.Text = mm_dr.Item("onames")
                    initials.Text = mm_dr.Item("code")
                    usrnm.Text = mm_dr("username")
                    email.Text = mm_dr("email")

                    Receive = mm_dr.Item("Receive")
                    Results = mm_dr.Item("Results")
                    Printing = mm_dr.Item("Printing")
                    QC = mm_dr.Item("QC")
                    EnterResults = mm_dr.Item("EnterResults")
                    epi = mm_dr.Item("epi")
                    Reports = mm_dr.Item("reports")
                    Download = mm_dr.Item("Download")
                    Import = mm_dr.Item("Import")
                    Search = mm_dr.Item("Search")
                    ManageUsers = mm_dr.Item("ManageUsers")
                    ManageFreezer = mm_dr.Item("ManageFreezer")
                    userstatus = mm_dr.Item("userstatus")
                    LastLogin = mm_dr.Item("LastLogin")
                    ViewsampleONLY = mm_dr.Item("ViewsampleONLY")
                    viewResultsONLY = mm_dr.Item("viewResultsONLY")
                    ViewAuditTrail = mm_dr.Item("ViewAuditTrail")


                    Receive2 = mm_dr.Item("Receive")
                    Results2 = mm_dr.Item("Results")
                    Printing2 = mm_dr.Item("Printing")
                    QC2 = mm_dr.Item("QC")
                    EnterResults2 = mm_dr.Item("EnterResults")
                    epi2 = mm_dr.Item("epi")
                    Reports2 = mm_dr.Item("reports")
                    Download2 = mm_dr.Item("Download")
                    Import2 = mm_dr.Item("Import")
                    Search2 = mm_dr.Item("Search")
                    ManageUsers2 = mm_dr.Item("ManageUsers")
                    ManageFreezer2 = mm_dr.Item("ManageFreezer")
                    userstatus2 = mm_dr.Item("userstatus")
                    LastLogin2 = mm_dr.Item("LastLogin")
                    ViewsampleONLY2 = mm_dr.Item("ViewsampleONLY")
                    viewResultsONLY2 = mm_dr.Item("viewResultsONLY")
                    ViewAuditTrail2 = mm_dr.Item("ViewAuditTrail")


                    'ManageInventory = mm_dr.Item("ManageInventory")
                    'ViewInventory = mm_dr.Item("ViewInventory")

                End While
            Else
                msgWarn("No records available for fetching!")
            End If

        Catch ex As Exception
            msgError("error in executing user retrieval function " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub
    Public Function validate_users()

        Dim valid As Boolean = False
        Dim ctrl As Control
        For Each ctrl In Me.GroupBox1.Controls
            If (TypeOf ctrl Is TextBox) Then
                If (ctrl.Name = "txt_email") Then
                Else
                    If ctrl.Text = "" Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True

                        Exit For
                    End If
                End If
            End If
        Next

        If valid = False Then
            If pwd.Text.Trim <> cpwd.Text.Trim Then
                msgError("The two passwords do not match,please retry!")
                cpwd.Text = ""
                cpwd.Focus()
                valid = True
            End If
        End If
        Return valid
    End Function
    Public Sub lstSystemusers(ByVal lstview As ListView, ByVal query As String)


        Try

            lst_users.Clear()

            'Set up UpdateRowSource the listview
            lst_users.Columns.Add("user ID", 50, HorizontalAlignment.Left)
            lst_users.Columns.Add("First name", 100, HorizontalAlignment.Left)
            lst_users.Columns.Add("Other names", 150, HorizontalAlignment.Left)
            lst_users.Columns.Add("Code name", 70, HorizontalAlignment.Left)
            lst_users.Columns.Add("username", 80, HorizontalAlignment.Left)
            lst_users.Columns.Add("email", 160, HorizontalAlignment.Left)
            lst_users.Columns.Add("Status", 50, HorizontalAlignment.Left)

            'open DB conn
            openConn()

            Dim DA As New SqlDataAdapter(query, Qconn)
            Dim DS As New DataSet()
            Dim DT As New DataTable("summary")

            'fill the datatable
            DT.Clear()
            DA.Fill(DT)

            'check if there are rows fetched
            If DT.Rows.Count > 0 Then
                Rec_Found = True
                lstview.Items.Clear()
                Dim dr As DataRow
                Me.lblcount.Text = DT.Rows.Count

                For Each dr In DT.Rows
                    Dim lv As New ListViewItem
                    lv = lstview.Items.Add(dr("userID"))
                    lv.SubItems.Add(dr("fname").ToString)
                    lv.SubItems.Add(dr("onames").ToString)
                    lv.SubItems.Add(dr("code").ToString)
                    lv.SubItems.Add(dr("username").ToString)
                    lv.SubItems.Add(dr("email").ToString)
                    lv.SubItems.Add(dr("status").ToString)
                Next
            Else
                Rec_Found = False
                msgSuccess("No records avaialble to display!")
            End If
        Catch ex As Exception
            msgError("error in retrieving system users" + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub

    Private Sub lst_users_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst_users.Click

        lst_view_users()
        RightsLoad()

        If Not usrnm.Text.Trim = "" Then
            cmdedit.Enabled = True

        Else
            cmdedit.Enabled = False
        End If

        '   End If
    End Sub

    Private Sub lst_users_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_users.SelectedIndexChanged

    End Sub

    Private Sub Chk_Receive_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_Receive.CheckedChanged

    End Sub
End Class