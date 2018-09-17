Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.Form
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net.NetworkInformation


Module SkywaterModulle
    '******************************************************************************************************************
    '************************************  my public variables  ********************************************
    '******************************************************************************************************************
    ' Dim con As String = My.MySettings.Default.DefaultConnection
    ' Public Qlocation As String = My.Computer.FileSystem.ReadAllText("C:\data\qlocation.txt")
    Public Qlocation As String = ""
    Public con As String = My.MySettings.Default.SkyWaterConnectionString


    '#If Location = "" Then
    '  Con=  "Data Source=gdd-kek1;Initial Catalog=eLab;User ID=PCSLogin;Password=P@55w0rd"
    '#End If
    ' Dim con As String = "Data Source=KISL-DSS-013714\MSSQLSERVER2012;Initial Catalog=eLab;integrated security=true"

    Public interFormID As String = Nothing
    Public interDate As Date = Nothing
    Public Cuser As String = "" '******** holdds the currently logged user
    Public Ccode As String = "" '******** holds the username code
    Public Cgrp As String = "" '******** holds the group of the currently logged user
    Public useremail As String = ""
    Public Cstatus As String = "" '******** holds users status either child or adult
    Public Records As Integer = 0
    Public Rnew As String = "" '******** keeps status of either edit or add new record
    Public pogramDirectory As String
    Public patient As String = ""
    Public C_patient As String = ""
    Public Rec_Found As Boolean = False
    Public Qconn As New SqlConnection(con)

    Public diagnosis As String = ""
    Public medication As String = ""
    Public tempID As String = "" '******** holdds the temp id of the selectd non-surve patient from the treeview
    Public c_age As String = "" '******** holdds the temp id of the selectd non-surve patient from the treeview
    Public rejectreason As String = ""
    Public mode As String = ""
    Public formmode As String = ""

    Public CRlabref As String = ""
    Public CRtestType As String = ""
    Public CRbcode As String = ""
    Public CRuid As String = ""
    Public CResRef As String = ""
    Public sQuery As String = ""
    Public searchQuery As String = ""
    'only applies to samples certification

    Public OptCode As String = ""
    Public RECDATE_edit As Date
    Public sBarcode As String = ""
    Public sDiv As String = ""
    Public sRRef As String = ""
    Public sUniqueID As String
    Public sAliquot_State As String
    Public sLocation As String
    Public sAliquot As Integer
    Public sColl_Location As String
    Public sLabref As String
    Public sSampleType As String
    Public sSTudy As String
    Public sColldate As Date
    Public sReceiveDate As Date
    Public sGroup As String
    Public resultRef As String
    Public BoxNumber As Integer?
    Public PositionRef As Double?
    Public sAliquotVol As Integer
    Public SamplePosition As Integer?
    Public Timestamps As DateTime
    Public boxfind As Integer = 0
    Public sdate As Date = Now.Date
    Public edate As Date = Now.Date
    Public bulkmode As String = ""
    Public ver As String = ""
    Public organism As String = ""
    Public gramstain As String = ""
    Public HostName As String = System.Net.Dns.GetHostName()

    Public LabRefEdit As String = ""
    Public sessPurpose As String
    Public Requestsession As String
    Public sSampleID As String = ""

    Public s_box As String = ""
    Public s_pos As String = ""
    Public spo_ref As String = ""

    Public res As String = ""
    Public cond As String = ""
    Public table As String = ""
    Public dupcheck As String
    Public TESTCHECK As String
    Public connection As String = ""
    Public iso As String = ""
    Public bulkOperation As String = ""

    'these declarations apply only results delete

    Public resofficer As String = ""
    Public delbar, delunique, deldrug As String
    Public testsp As String = ""

    '==================================
    'Users and rights management
    Public Receive As String
    Public Results As String
    Public Printing As String
    Public QC As String
    Public EnterResults As String
    Public epi As String
    Public Reports As String
    Public Download As String
    Public Import As String
    Public Search As String
    Public ManageUsers As String
    Public ManageFreezer As String
    Public userstatus As String
    Public LastLogin As String
    Public ViewsampleONLY As String
    Public viewResultsONLY As String
    Public ViewAuditTrail As String
    Public ManageInventory As String
    Public ViewInventory As String


    Public Receive2 As String
    Public Results2 As String
    Public Printing2 As String
    Public QC2 As String
    Public EnterResults2 As String
    Public epi2 As String
    Public Reports2 As String
    Public Download2 As String
    Public Import2 As String
    Public Search2 As String
    Public ManageUsers2 As String
    Public ManageFreezer2 As String
    Public userstatus2 As String
    Public LastLogin2 As String
    Public ViewsampleONLY2 As String
    Public viewResultsONLY2 As String
    Public ViewAuditTrail2 As String
    Public ManageInventory2 As String
    Public ViewInventory2 As String
    '==================================

    '===============================SkyWater public variables============================
    Public varVID As Integer
    Public varHHID As String = ""
    Public varobtain_last As String = ""
    Public varobtain_pipedhse As String = ""
    Public varobtain_pipedcmpd As String = ""
    Public varobtain_publictap As String = ""
    Public varobtain_shofco As String = ""
    Public varobtain_nonshofco As String = ""
    Public varobtain_privatewell As String = ""
    Public varobtain_bottleh2o As String = ""
    Public varobtain_bagh2o As String = ""
    Public varobtain_vendorh2o As String = ""
    Public varobtain_munictap As String = ""
    Public varobtain_unknownh2o As String = ""
    Public varobtain_otherh2o As String = ""
    Public varshofco_kiosk As String = ""
    Public varcont_see As String = ""
    Public varcont_observe As String = ""
    Public varcont_type As String = ""
    Public varcont_covered As String = ""
    Public vard_pour As String = ""
    Public vard_scoopcup As String = ""
    Public vard_scoopladle As String = ""
    Public vard_empty As String = ""
    Public varstore_dur As String = ""
    Public varh2o_treat As String = ""
    Public varmethod_treat As String = ""
    Public vartreat_othermthd As String = ""
    Public varmaterial As String = ""
    Public vartreat_otherchem As String = ""
    Public varcl_aqua As String = ""
    Public varCl_certeza As String = ""
    Public varCl_na As String = ""
    Public varCl_waterguard As String = ""
    Public varCl_watermaker As String = ""
    Public varCl_unk As String = ""
    Public varCl_other As String = ""
    Public varCl_PG As String = ""
    Public varcl_test As String = ""
    Public vartaste_notice As String = ""
    Public varbad_taste As String = ""
    Public varprevent_collection As String = ""
    Public varp_handwash As String = ""
    Public varp_pipewater As String = ""
    Public varP_nopipe_notap As String = ""
    Public varp_nopipe_tap As String = ""
    Public varp_basin As String = ""
    Public varp_soap As String = ""
    Public varp_amc As String = ""
    Public varmain_defeac As String = ""
    Public vardefeac_other As String = ""
    Public vartoilet_type As String = ""
    Public vartoilet_othertype As String = ""
    Public varslab_material As String = ""
    Public vardoor As String = ""
    Public varuse_cost As String = ""
    Public varuse_timeunit As String = ""
    Public varsharing As String = ""
    Public vartoilet_emptied As String = ""
    Public vartoilet_full As String = ""
    Public varchild_defeac As String = ""
    Public varfeac_dispose As String = ""
    Public varfeac_disposeOther As String = ""
    Public varfeac_observed As String = ""
    Public varfeac_elsewhere As String = ""
    Public varrec_date As String = ""
    Public varOfficer As String = ""

    Public varSocialgroup As String = ""
    Public varIndividId As String = ""
    Public varFname As String = ""
    Public varMname As String = ""
    Public varLname As String = ""
    Public varName As String = ""
    Public varDOB As Date
    Public vargender As String = ""
    Public varHHHID As String = ""
    Public varVilcode As Integer = 0

    Public varRelationship As String = " "
    Public varEducation As String = " "
    Public varOccupation As String = " "
    Public varBreastfeed As String = " "
    Public varDssid As String = ""
    Public varVisitcode As String = ""
    Public varState As String = ""
    Public varSchchild As String = ""
    Public varSleeproom As String = ""
    Public varHHH As String = ""

    Public varSick As String = ""
    Public varIllduration As String = ""
    Public varLoosestool As String = ""
    Public varSeektreatmnt As String = ""
    Public varTreatplace As String = ""
    Public varTreatsought As String = ""
    Public varOthersymt As String = ""
    Public varComplaints As String = ""
    Public varComments As String = ""
    Public varSearch As String = ""

    Public Function GetNextID()
        Dim myCount As Integer
        Dim myQuery As String = Nothing
        Try
            openConn()
            myQuery = "SELECT TOP 1 *
  FROM [SkyWater].[dbo].[HH_baseline] WHERE HHID='" + varHHID + "' ORDER BY VID DESC"

            Dim cmd As New SqlCommand(myQuery, Qconn)
            Dim DA As New SqlDataAdapter(cmd)
            Dim DS As New DataSet()
            Dim DT As New DataTable("maxNum")
            DT.Clear()
            DA.Fill(DT)

            If DT.Rows.Count <> 0 Then
                '  Return DT
                'myCount = DT.Rows(0).ItemArray(0)
                myCount = DT.Rows(0).Item("visitno")

            Else
                Return Nothing
                Exit Function
            End If



        Catch ex As Exception
            msgError("application error in getting  new ID" + ex.Message)
        Finally
            closeConn()
        End Try
        Return myCount + 1
    End Function

    Public Function GetHeadName()
        Dim name As String = ""
        Dim myQuery As String = Nothing
        Try
            openConn()
            myQuery = "select top 1 * from [SkyWater].[dbo].[IND_Baseline]
  where RelHH='Self (HH head)' and HHID='" + varHHID + "'"

            Dim cmd As New SqlCommand(myQuery, Qconn)
            Dim DA As New SqlDataAdapter(cmd)
            Dim DS As New DataSet()
            Dim DT As New DataTable("relationships")
            DT.Clear()
            DA.Fill(DT)

            If DT.Rows.Count <> 0 Then
                '  Return DT
                'myCount = DT.Rows(0).ItemArray(0)
                name = DT.Rows(0).Item("Full_Names")

            Else
                Return Nothing
                Exit Function
            End If



        Catch ex As Exception
            msgError("application error in getting  new ID" + ex.Message)
        Finally
            closeConn()
        End Try
        Return name
    End Function
    '==============================


    '=================== DECLARIONS FOR DATA UPLOAD ===============================
    Public SESS, tablename, defaultpath As String

    Public indexNumberOfDataTableUniqueID As String
    Public indexNumberOfTableUniqueID As Integer
    Public indexNumberOfDateRow As String

    '==============================================================================



    ' Excel connection strings
    Public Excel03ConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"
    Public Excel07ConString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES;IMEX=1'"
    Public savedFile As String = " " + "Uploaded to Server"
    Public SESSIONID As String = ""


    '*********************************************************************************************************************
    '********************************** End of public variables declaration **********************************************
    '*********************************************************************************************************************
    ' makes the loading form a child of the MDI





    Public Function getconnection()


        con = My.MySettings.Default.SkyWaterConnectionString
        'If Qlocation = "Kisumu" Then
        '    con = My.MySettings.Default.LwakConnection
        'ElseIf Qlocation = "Kibera" Then
        '    con = My.MySettings.Default.KiberaConnection
        'ElseIf Qlocation = "Local" Then
        '    con = My.MySettings.Default.DefaultConnection
        'End If
        Return con

    End Function


    Sub Main()







    End Sub






    Public Sub LoadMyForms(ByVal frm As Form)
        Dim childForm As New Form
        Dim pcs As New Form
        'make it a childform of this MDI
        childForm.MdiParent = SkyWater
        Dim m_ChildFormNumber As Integer = +1
        childForm.Text = "Window " & m_ChildFormNumber
        frm.Show()
    End Sub


    'open connection
    Public Sub openConn()
        If Qconn.State = ConnectionState.Closed Then
            Qconn.Open()
        End If
    End Sub

    'close connection
    Public Sub closeConn()
        If Qconn.State = ConnectionState.Open Then
            Qconn.Close()
        End If

    End Sub

    Public NotInheritable Class SelectedSampleType
        Private Sub New()
        End Sub
        Public Shared SampleTypeID As String
    End Class
    Public Sub FillMyGrid(ByVal gridName As DataGridView, ByVal sql As String)
        'open Connection

        openConn()
        Try
            'If gridName.Rows.OfType(Of DataGridViewRow)().Any() Then
            '    gridName.DataSource = Nothing
            'End If

            Dim grdDA As New SqlDataAdapter(sql, Qconn)
            Dim grdDT As New DataTable
            grdDA.Fill(grdDT)
            If grdDT.Rows.Count() = 0 Then
                gridName.DataSource = Nothing
            Else
                gridName.DataSource = grdDT
                gridName.Refresh()
            End If

        Catch ex As Exception
            msgError("ERROR Description: " & ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try

        With gridName
            .RowsDefaultCellStyle.BackColor = Color.Snow
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
        End With
    End Sub

    ' populate the list view grid
    Public Sub LstView(ByVal lst As ListView, ByVal Qsql As String, ByVal fld As String)

        Try
            'open DB conn
            openConn()
            Dim Qcmd As New SqlCommand(Qsql, Qconn)
            Dim Qdr As SqlDataReader = Qcmd.ExecuteReader
            lst.Clear()
            While Qdr.Read
                lst.Items.Add(Qdr.Item(fld))
            End While
            Qdr.Close()
        Catch ex As Exception
            msgError("Error: " + ex.Message)
            Exit Sub
        Finally
            closeConn()

        End Try
    End Sub
    'Getting Computer Mac Address
    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function


    'gets the list view checked item

    Public Function getItems(ByVal lst As ListView) As String
        Dim str As String = ""
        If lst.CheckedItems.Count > 0 Then
            str = "'" + lst.CheckedItems(0).Text + "'"
        End If
        Return str
    End Function
    ' hide my controls

    Public Sub hideControls(ByVal grp As GroupBox)
        Dim ctrl As Control
        If grp.Name <> "" Then
            For Each ctrl In grp.Controls
                If (TypeOf ctrl Is RichTextBox) Or (TypeOf ctrl Is TextBox) Or (TypeOf ctrl Is ComboBox) Then
                    ctrl.Enabled = False
                End If
            Next
        End If
    End Sub
    ' this is the module to load the searched individual
    Public Sub searchEngine(ByVal sql As String)

    End Sub

    ' Patient-Doctor assignment module
    Public Sub patientDoctor(ByVal sql As String)

    End Sub
    ' error messages feedback
    Public Sub msgError(ByVal msg As String)
        MsgBox(msg, MsgBoxStyle.Critical, "Lab Master")
    End Sub
    ' error messages feedback
    Public Sub msgWarn(ByVal msg As String)
        MsgBox(msg, MsgBoxStyle.Exclamation, "Lab Master")
    End Sub
    'message box success
    Public Sub msgSuccess(ByVal msg1 As String)
        MsgBox(msg1, MsgBoxStyle.Information, "Lab Master")
    End Sub
    ' message box yes no
    Public Sub msgYesNo(ByVal msg2 As String)
        MsgBox(msg2, MsgBoxStyle.OkCancel, "Lab Master")
    End Sub

    Public Sub loadCombo(ByVal cbo As ComboBox, ByVal sql As String, ByVal fldDsp As String, ByVal fldVal As String)
        Try
            'open DB Connection
            openConn()
            Dim cboDS As New DataTable
            Dim cboAD As SqlDataAdapter
            Dim cboCMD As New SqlCommand(sql, Qconn)
            cboAD = New SqlDataAdapter(sql, Qconn)
            cboAD.Fill(cboDS)
            cbo.Items.Clear()
            cbo.SelectedIndex = -1

            'cbo.Dispose()

            With cbo
                .Refresh()
                .Items.Clear()
                .DataSource = Nothing
                .Text = fldDsp
                .DataSource = (cboDS)
                .DisplayMember = fldDsp
                .ValueMember = fldVal
            End With


        Catch ex As Exception
            msgError("ERROR:Failed Loading Values  " + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub

    Public Sub loadListBox(ByVal lst As CheckedListBox, ByVal sql As String, ByVal fldDsp As String, ByVal fldVal As String)
        Try
            'open DB Connection
            openConn()
            Dim lstDS As New DataTable
            Dim lstAD As SqlDataAdapter
            Dim cboCMD As New SqlCommand(sql, Qconn)
            lstAD = New SqlDataAdapter(sql, Qconn)
            lstAD.Fill(lstDS)
            lst.Items.Clear()
            lst.SelectedIndex = -1
            With lst
                .Items.Clear()
                .DataSource = Nothing
                .Text = fldDsp
                .DataSource = lstDS
                .DisplayMember = fldDsp
                .ValueMember = fldVal
            End With
        Catch ex As Exception
            msgError("ERROR:Failed Loading Values  " + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub

    Public Sub loadComboDefault(ByVal cbo As ComboBox, ByVal sql As String, ByVal fldDsp As String, ByVal fldVal As String, ByVal dflt As String)
        Try
            'open DB connection
            openConn()
            cbo.DataSource = Nothing
            Dim cboDS As New DataTable
            Dim cboAD As SqlDataAdapter
            Dim cboCMD As New SqlCommand(sql, Qconn)
            cboAD = New SqlDataAdapter(sql, Qconn)
            cboAD.Fill(cboDS)
            cbo.Items.Clear()
            cbo.SelectedIndex = -1
            With cbo
                .Items.Clear()
                .DataSource = Nothing
                .DataSource = cboDS
                .DisplayMember = fldDsp
                .Text = "" & dflt
                .ValueMember = fldVal
            End With
        Catch ex As Exception
            msgError("ERROR:Failed Loading Values  " + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub
    ' loads the demographic information of the patients
    Public Sub loadDemograghy(ByVal dssid As String, ByVal fnm As TextBox, ByVal mnm As TextBox, ByVal lnm As TextBox, ByVal dob As TextBox, ByVal sex As TextBox, ByVal txtdssid As TextBox)
        Try
            openConn()
            Dim sql As String = "SELECT * FROM  " & tableIndividual & " WHERE  " & [INDIVIDID] & "='" & dssid & "'"

            Dim cmd As New SqlCommand(sql, Qconn)
            Dim Idr As SqlDataReader = cmd.ExecuteReader()
            While Idr.Read
                fnm.Text = Idr.Item("NAME").ToString.Trim
                mnm.Text = Idr.Item("MNAME").ToString.Trim
                lnm.Text = Idr.Item("LNAME").ToString.Trim
                dob.Text = Idr.Item("BIRTH_DATE")
                sex.Text = Idr.Item("GENDER").ToString.Trim
            End While
            Idr.Close()
        Catch ex As Exception
            msgError("FAILED LOADING PATIENT INFO :" + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub
    'read the checked values from a checkedlistbox

    Public Function getCheckedItems(ByVal chk As CheckedListBox) As String

        Dim items As String = ""
        If chk.CheckedItems.Count > 0 Then
            items = "" & chk.CheckedItems(0) & ""
            'check if the checked items are more than 1
            If chk.CheckedItems.Count > 1 Then
                For i As Integer = 1 To chk.CheckedItems.Count - 1
                    items = items & "," & chk.CheckedItems(i) & ""
                Next
            End If
        End If
        Return items
    End Function

    'get the age differences given the DOB
    Public Function getAge(ByVal dob As Date)
        Dim dDiff As Decimal
        Dim dtA As Date
        Dim ts As TimeSpan
        dtA = (dob) '(this is the date to subtract the current date from)
        ts = Now.Subtract(dtA)
        dDiff = Convert.ToDecimal(ts.TotalDays) \ 365.25
        Dim dtMonth As Integer = DateDiff(DateInterval.Month, dob, Date.Today)
        'msgError("my months are :- " & dtMonth)
        'msgError("dDiff in years:- " & dDiff & "ageMonths : - " & ageMonths)
        c_age = dDiff
        Return dDiff
    End Function

    ' encrypt users passwords on insert
    Public Function encrypt(ByVal pass As String) As String
        'Private Function GenerateHash(ByVal SourceText As String) As String
        'Create an encoding object to ensure the encoding standard for the source text
        Dim Ue As New UnicodeEncoding()
        'Retrieve a byte array based on the source text
        Dim ByteSourceText() As Byte = Ue.GetBytes(pass)
        'Instantiate an MD5 Provider object
        Dim Md5 As New MD5CryptoServiceProvider()
        'Compute the hash value from the source
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        'And convert it to String format for return
        Return Convert.ToBase64String(ByteHash)
    End Function
    'public function get group name.
    Public Function getGroup(ByVal id As Integer) As String
        Dim grp As String = ""
        Try
            'open DB connection
            openConn()
            Dim sql As String = "SELECT * FROM dbo.groups WHERE groupID='" & id & "'"
            Dim cmds As New SqlCommand(sql, Qconn)
            Dim drs As SqlDataReader = cmds.ExecuteReader()
            While drs.Read
                grp = drs.Item("group").ToString.Trim
            End While
            drs.Close()
        Catch ex As Exception
            msgError("FAILED LOADING GROUP NAMES " + ex.Message)
            'Exit Function
        Finally
            closeConn()
        End Try
        Return grp
    End Function


    ' This sub-module will check and validate the user logging in the system
    Public Sub Auth_User_login(ByVal usr As String, ByVal pwd As String, ByVal conn As SqlConnection)
        Try
            'open DB connection
            openConn()
            Dim sql As String = "Select isnull(userID,0)userID,
                    isnull(groupID, 0)groupID,
                    isnull(fname,'NO')fname,
                    isnull(onames,'NO')onames,
                    isnull(code,'NO')code,
                    isnull(username,'NO')username,
                    isnull([password],'NO')[password],
                    isnull(logged,'NO')logged,
                    isnull(email,'NO')email,
                    isnull(destination,'NO')destination,
                    isnull(Date,'1900-01-01')date,
                    isnull(status,'NO')status,
                    isnull(officer,'NO')officer
                FROM [skywater].[settings].[users] WHERE username ='" + usr + "' AND password='" + pwd + "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                Dim DBuser As String = dr.Item("username").Trim.ToString.ToLower
                Dim DBpass As String = dr.Item("password").Trim.ToString
                Dim userID As Integer = dr.Item("userID")
                Dim logd As Integer = dr.Item("logged")
                Dim mail As String = dr.Item("email")
                Cgrp = dr.Item("groupID")
                'DSS = dr.Item("code")


                If DBuser = usr And DBpass = pwd Then
                    Cuser = DBuser
                    Ccode = userID
                    useremail = mail
                    ' Cgrp = dr.Item("groupID").ToString
                    SkyWater.Show()
                    frmLogin.txtuser.Text = ""
                    frmlogin.txtpwd.Text = ""
                    frmlogin.Hide()
                End If
            End While

            If Cuser = "" Then
                msgError("Access Denied,Contact Systems Administrator")
            End If
            dr.Close()

            If Cuser <> "" Then
                Dim sqlup As String = "UPDATE [skywater].[settings].[users] SET logged='1' WHERE username='" + Cuser + "'"
                Dim cmds As New SqlCommand(sqlup, Qconn)
                Dim u_dr As SqlDataReader = cmds.ExecuteReader()
                u_dr.Close()
            End If

        Catch ex As Exception
            msgError(" user authentication failed " & ex.Message)
            frmlogin.txtpwd.Clear()
            Exit Sub
        Finally
            closeConn()
        End Try
        '  loadGroup(Cuser)

    End Sub


    Public Sub loadGroup(ByVal user As String)
        Try
            'open DB connection
            openConn()
            Dim sql As String = "SELECT * FROM [elab].[settings].[groups] WHERE groupID='" + Ccode + "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim Udr As SqlDataReader = cmd.ExecuteReader()
            While Udr.Read
                Cgrp = Udr.Item("name").ToString.Trim
            End While
            Udr.Close()
        Catch ex As Exception
            msgError("ERROR: " + ex.Message + Ccode)
            Exit Sub
        Finally

            'close connection
            closeConn()
        End Try
    End Sub


    Public Sub userLogout()
        Try
            'close connection
            openConn()
            Dim Sql = "UPDATE [elab].[settings].[users] SET logged='0' WHERE username='" + Cuser + "'"
            Dim cmd As New SqlCommand(Sql, Qconn)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            dr.Close()
            Cuser = ""
            msgSuccess("user logged out successfully on PCS!")
            SkyWater.Hide()
            frmLogin.Show()
        Catch ex As Exception
            msgError("USER LOGOUT PROCESS FAILED " + ex.Message)
            Exit Sub
        Finally
            'close connection
            closeConn()
        End Try

    End Sub

    ' Ship or destroy Aliquot
    Public Sub UpdateAliquot(status As String, id As String)

        Try
            'close connection
            openConn()

            Dim Sql = "UPDATE [eLab].[dbo].[Aliquots] SET AliquotState='" + status + "' WHERE UniqueID='" + id + "'"
            Dim cmd As New SqlCommand(Sql, Qconn)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            dr.Close()
        Catch ex As Exception
            msgError("ALIQUOT UPDATING PROCESS FAILED " + ex.Message)
        End Try
    End Sub

    Public Sub UpdateIndividual(varDssid As String)

        Try
            'close connection
            openConn()

            Dim Sql = "UPDATE [SkyWater].[dbo].[IND_Followup] WHERE dss_id = '" & varDssid & "'"
            Dim cmd As New SqlCommand(Sql, Qconn)
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            dr.Close()
        Catch ex As Exception
            msgError("Update Operation Failed" + ex.Message)
        End Try
    End Sub

    ' public sub to load for doctor

    Public Sub loadDoctor(ByVal txt As TextBox, ByVal id As String, ByVal tbnm As String)
        Try
            'open DB connection
            openConn()

            Dim sql As String = "SELECT * FROM dbo." & tbnm & " WHERE status='NO' AND dssID='" & id & "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim sqlDR As SqlDataReader = cmd.ExecuteReader()
            While sqlDR.Read
                txt.Clear()
                txt.Text = sqlDR.Item("officer").ToString.Trim
            End While
            sqlDR.Close()
        Catch ex As Exception
            msgError("FAILED LOADING DOCTOR " & ex.Message)
            Exit Sub
        Finally
            'close connection
            closeConn()
        End Try
    End Sub
    ' public sub to load for doctor

    Public Sub loadDoctorYES(ByVal txt As TextBox, ByVal id As String, ByVal tbnm As String, ByVal status As String)

        Try

            'open DB connection
            openConn()

            Dim sql As String = "SELECT * FROM dbo." & tbnm & " WHERE status='" & status & "' AND dssID='" & id & "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim sqlDR As SqlDataReader = cmd.ExecuteReader()

            While sqlDR.Read
                txt.Clear()
                txt.Text = sqlDR.Item("officer").ToString.Trim
            End While
            sqlDR.Close()

        Catch ex As Exception
            msgError("FAILED LOADING DOCTOR " & ex.Message)
            Exit Sub
        Finally

            'close DB connection
            closeConn()
        End Try
    End Sub
    Public Sub deleteRecord(varDssid)

        Select Case (MsgBox("Are you sure you want to delete this record ?", MsgBoxStyle.YesNo))
            Case MsgBoxResult.Yes
                Try
                    'open DB connection

                    openConn()

                    Dim sql As String = "delete from [SkyWater].[dbo].[IND_Followup] where dss_id = '" & varDssid & "'"
                    Dim cmd As New SqlCommand(sql, Qconn)
                    Dim r As Integer
                    r = cmd.ExecuteNonQuery
                    If r > 0 Then
                        msgSuccess("Record deleted successfully")
                    End If
                Catch ex As Exception
                    msgError("Error in deleting records " & ex.Message)
                    Exit Sub
                Finally
                    closeConn()
                End Try
            Case MsgBoxResult.No
                msgSuccess("Record operation delete aborted by user")
                Exit Sub
        End Select

    End Sub
    Public Sub uncheckList(ByVal chk As CheckedListBox)
        For i As Integer = 0 To chk.Items.Count - 1
            chk.SetItemCheckState(i, CheckState.Unchecked)
        Next i
    End Sub


    Public Sub checkList(ByVal chk As CheckedListBox)
        For i As Integer = 0 To chk.Items.Count - 1
            chk.SetItemCheckState(i, CheckState.Checked)
        Next i
    End Sub

    Public Function checkStatus(ByVal ID As String) As Integer

        Dim lock As Integer
        Try
            'open DB connection
            openConn()

            Dim sql As String = "SELECT * FROM dbo.examination WHERE dssID='" + ID + "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim cDR As SqlDataReader = cmd.ExecuteReader

            While cDR.Read
                lock = cDR.Item("lock")
            End While
            cDR.Close()

        Catch ex As Exception
            msgError("Failed reading patient lock status" + ex.Message)
            Exit Function
        Finally

            'close DB connection
            closeConn()
        End Try
        Return lock
    End Function

    Public Function Get_Birth_Date(ByVal permID As String)

        Dim dob As Date
        Try

            'open conn
            openConn()
            Dim sql As String = ""
            Select Case Qlocation
                Case "lwak"
                    sql = "SELECT BIRTH_DATE FROM " & tableIndividual & " WHERE  " & [INDIVIDID] & "='" + permID + "'"
                Case "kibera"
                    sql = "SELECT DOB FROM " & tableIndividual & " WHERE  " & [INDIVIDID] & "='" + permID + "'"
            End Select


            Dim cmd As New SqlCommand(sql, Qconn)
            Dim Ddr As SqlDataReader = cmd.ExecuteReader

            If Ddr.HasRows = True Then

                While Ddr.Read
                    Select Case Qlocation
                        Case "lwak"
                            dob = Ddr.Item("BIRTH_DATE")
                        Case "kibera"
                            dob = Ddr.Item("DOB")
                    End Select

                End While
                Ddr.Close()
            Else
                msgSuccess("Birth date records not found for the patient!")
            End If
            Ddr.Close()
        Catch ex As Exception
            msgError("system malfunction error in fetching Birth Date " & ex.Message)
            ' Exit Function
        Finally

            'close con
            closeConn()

        End Try

        Return dob

    End Function

    Public Function Get_Birth_DateKibera(ByVal permID As String)

        Dim dob As Date
        Try

            'open conn
            openConn()

            Dim sql As String = "SELECT DOB FROM " & tableIndividual & " WHERE  " & [INDIVIDID] & "='" + permID + "'"
            Dim cmd As New SqlCommand(sql, Qconn)
            Dim Ddr As SqlDataReader = cmd.ExecuteReader

            If Ddr.HasRows = True Then

                While Ddr.Read
                    dob = Ddr.Item("DOB")
                End While
                Ddr.Close()
            Else
                msgSuccess("Birth date records not found for the patient!")
            End If
            Ddr.Close()
        Catch ex As Exception
            msgError("system malfunction error in fetching Birth Date " & ex.Message)
            '   Exit Function
        Finally

            'close con
            closeConn()

        End Try

        Return dob

    End Function
    Public Sub lst_view_compounds(ByVal lstview As ListView, ByVal query As String)
        Try

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

                lstview.Items.Clear()
                Dim dr As DataRow
                'Me.lblcount.Text = DT.Rows.Count

                For Each dr In DT.Rows

                    Dim lv As New ListViewItem

                    lv = lstview.Items.Add(dr("COMPOUNDID"))
                    lv.SubItems.Add(dr("CFNAME").ToString)
                    lv.SubItems.Add(dr("CJNAME").ToString)
                    lv.SubItems.Add(dr("CLNAME").ToString)

                Next

            Else
                msgSuccess("No records avaialble!")

            End If

        Catch ex As Exception
            msgError("error in retrieving job summary " + ex.Message)
            Exit Sub
        Finally
            closeConn()
        End Try
    End Sub

    'function to comapte Current ID
    Public Function compare_ID(ByVal lst_view As ListView)

        If lst_view.SelectedItems.Item(0).Text <> Nothing Then
            Dim Curr_ID As String = lst_view.SelectedItems.Item(0).Text
            If Curr_ID <> C_patient Then
                C_patient = Curr_ID
            End If
        End If
        Return C_patient

    End Function

    Public Sub ResetControls(ByVal grpbox As GroupBox)
        Dim ctrl As Control 'declares an object of type control'
        For Each ctrl In grpbox.Controls 'loops through all the controls found'
            If (TypeOf ctrl Is ComboBox) Or (TypeOf ctrl Is TextBox) Then 'checks control type
                ctrl.Text = ""
                '.Enabled = True 'enable the control minus the group combobox
            End If
        Next
    End Sub

    Public Function validateForms(ByVal grpBox As GroupBox)

        Dim valid As Boolean = False
        Dim nud As NumericUpDown
        Dim chlstBox As CheckedListBox
        Dim cbo As ComboBox
        Dim ctrl As Control
        For Each ctrl In grpBox.Controls
            If ctrl.Enabled = True Then
                If (TypeOf ctrl Is TextBox) Then
                    If ctrl.Text = "" Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If
                If (TypeOf ctrl Is ComboBox) Then
                    cbo = ctrl
                    If cbo.Text = "" Or ctrl.Text = "NULL" Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If
                If (TypeOf ctrl Is NumericUpDown) Then
                    nud = ctrl
                    If (nud.Value = 0 Or nud.Value = Nothing) Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If
                If (TypeOf ctrl Is CheckedListBox) Then
                    chlstBox = ctrl
                    If chlstBox.CheckedItems.Count < 0 Then
                        msgError("Atleast one (1) option must be checked for " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If
            End If
        Next
        Return valid
    End Function
    Public Function validateTabOnForms(ByVal frm As Form)

        Dim valid As Boolean = False
        Dim nud As NumericUpDown
        Dim chlstBox As CheckedListBox
        Dim cbo As ComboBox
        Dim ctrl As Control

        For Each ctrl In frm.Controls
            'For Each ctrl In tbctrl.Controls
            If ctrl.Enabled = True Then

                If (TypeOf ctrl Is TextBox) Then
                    If ctrl.Text = "" Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If

                If (TypeOf ctrl Is ComboBox) Then
                    cbo = ctrl
                    If cbo.Text = "" Or ctrl.Text = "NULL" Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If

                If (TypeOf ctrl Is NumericUpDown) Then
                    nud = ctrl
                    If (nud.Value = 0 Or nud.Value = Nothing) Then
                        msgError("Please provide " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If

                If (TypeOf ctrl Is CheckedListBox) Then
                    chlstBox = ctrl
                    If chlstBox.CheckedItems.Count < 0 Then
                        msgError("Atleast one (1) option must be checked for " + ctrl.Name + " values before save")
                        ctrl.Focus()
                        valid = True
                        Exit For
                    End If
                End If
            End If
        Next
        Return valid
    End Function
    Public Function validateControlsOnTabControl(ByVal tbc As TabControl)

        Dim valid As Boolean = False
        Dim nud As NumericUpDown
        Dim chlstBox As CheckedListBox
        Dim cbo As ComboBox
        'Dim ctrl As Control
        ' Dim tab As TabPage

        For Each tab As TabPage In tbc.TabPages

            For Each ctrl As Control In tab.Controls
                If ctrl.Enabled = True Then
                    If (TypeOf ctrl Is TextBox) Then
                        If ctrl.Text = "" Then
                            msgError("Please provide " + ctrl.Name + " values before save")
                            ctrl.Focus()
                            valid = True
                            Exit For
                        End If
                    End If
                    If (TypeOf ctrl Is ComboBox) Then
                        cbo = ctrl
                        If cbo.Text = "" Or ctrl.Text = "NULL" Then
                            msgError("Please provide " + ctrl.Name + " values before save")
                            ctrl.Focus()
                            valid = True
                            Exit For
                        End If
                    End If
                    If (TypeOf ctrl Is NumericUpDown) Then
                        nud = ctrl
                        If (nud.Value = 0 Or nud.Value = Nothing) Then
                            msgError("Please provide " + ctrl.Name + " values before save")
                            ctrl.Focus()
                            valid = True
                            Exit For
                        End If
                    End If
                    If (TypeOf ctrl Is CheckedListBox) Then
                        chlstBox = ctrl
                        If chlstBox.CheckedItems.Count < 0 Then
                            msgError("Atleast one (1) option must be checked for " + ctrl.Name + " values before save")
                            ctrl.Focus()
                            valid = True
                            Exit For
                        End If
                    End If
                End If
            Next
        Next
        Return valid
    End Function


    Public Sub setPatientDetails(ByVal lstview As ListView)
        'call the patient ID compare function
        Dim id As String = compare_ID(lstview)

        'set current patient ID
        C_patient = id

        Dim DoB As Date = Get_Birth_Date(C_patient)
        Dim age = getAge(DoB)

        If age <= 5 Then
            patient = "CHILD"
        Else
            patient = "ADULT"
        End If
    End Sub

    Public Sub disableButtonsAfterSave(ByVal cmdsave As Button, ByVal cmddelete As Button)
        cmdsave.Enabled = False
        cmddelete.Enabled = False
    End Sub



    Public Function checkQueuedPatient(ByVal dssID As String)
        Dim ptStatus As Boolean = False

        Try

            'open DB conn
            openConn()

            Dim query As String = "SELECT * FROM [PCS].[settings].[queue_manager] WHERE dssID='" + dssID + "' AND disposition='NO'"
            Dim DA As New SqlDataAdapter(query, Qconn)
            Dim DS As New DataSet()

            Dim DT As New DataTable("patientQueue")

            'fill the datatable
            DT.Clear()
            DA.Fill(DT)

            'check if there are rows fetched
            If DT.Rows.Count > 0 Then
                ptStatus = True
            Else
                ptStatus = False

            End If
        Catch ex As Exception
            msgError("error in checking patient queue details " + ex.Message)
        Finally
            closeConn()
        End Try

        Return ptStatus
    End Function



    'Public Sub GetSAmpleDetails(Barcode As String, frm As frmResults)
    '    openConn()

    '    Dim sercat As String = ""
    '    Dim SQL As String = "SELECT [LabREf],[SPecimenID],[Location],[SampleType]      ,[sampleGroup]      ,[ser_Cat]      ,[receive_date]      ,[Receive_Time]      ,[coll_date]      ,[Bactec_Barcode]      ,[Weight1]      ,[Weight2]      ,[AvgWeight]      ,[Appearance]      ,[Symptoms]      ,[Accepted]      ,[Status]      ,[entry_date]      ,[Officer] from  [dbo].[specimen] where SPECIMENID = '" & frm.txtBarcode.Text.Trim & "'"

    '    Dim cmd As New SqlCommand(SQL, Qconn)
    '    Dim rDR As SqlDataReader = cmd.ExecuteReader
    '    While rDR.Read
    '        frm.txtBarcode.Text = rDR.Item("SPecimenID")
    '        frm.txtSite.Text = rDR.Item("Location")

    '        sercat = rDR.Item("ser_Cat")
    '        sLabref = rDR.Item("LabREf")
    '        sBarcode = rDR.Item("SPecimenID")
    '        If sercat.Trim = "NA" Then
    '            frm.txtSampleType.Text = rDR.Item("SampleType")
    '        Else
    '            ' frm.txtSampleType.Text = rDR.Item("SampleType") & "_" & sercat
    '            frm.txtSampleType.Text = rDR.Item("SampleType")
    '        End If

    '        frm.txtReceive_date.Text = rDR.Item("receive_date")

    '    End While

    '    closeConn()
    'End Sub

    'Public Sub GetSAmpleDetails2(Barcode As String, frm As Archives)
    '    openConn()
    '    Dim sercat As String = ""
    '    Dim SQL As String = "SELECT [LabREf],[SPecimenID],[Location],[SampleType]      ,[sampleGroup]      ,[ser_Cat]      ,[receive_date]      ,[Receive_Time]      ,[coll_date]      ,[Bactec_Barcode]      ,[Weight1]      ,[Weight2]      ,[AvgWeight]      ,[Appearance]      ,[Symptoms]      ,[Accepted]      ,[Status]      ,[entry_date]      ,[Officer] from  [dbo].[specimen] where SPECIMENID = '" & frm.txtBarcode.Text.Trim & "'"

    '    Dim cmd As New SqlCommand(SQL, Qconn)
    '    Dim rDR As SqlDataReader = cmd.ExecuteReader
    '    While rDR.Read
    '        frm.txtBarcode.Text = rDR.Item("SPecimenID")
    '        frm.txtSite.Text = rDR.Item("Location")

    '        sercat = rDR.Item("ser_Cat")
    '        sLabref = rDR.Item("LabREf")
    '        sBarcode = rDR.Item("SPecimenID")
    '        If sercat.Trim = "NA" Then
    '            frm.txtSampleType.Text = rDR.Item("SampleType")
    '        Else
    '            ' frm.txtSampleType.Text = rDR.Item("SampleType") & "_" & sercat
    '            frm.txtSampleType.Text = rDR.Item("SampleType")
    '        End If

    '        frm.txtReceive_date.Text = rDR.Item("receive_date")

    '    End While

    '    closeConn()
    'End Sub
    'Public Sub GetAliquotDetails(UniqueId As String, frm As frmBulk_Handling)
    '    openConn()

    '    Dim aliquotState As String = ""
    '    Dim SQL As String = "SELECT [LabRef],[Barcode],[UniqueID],[BOXID],[Pos_Ref],[Position],[AliquotState],[AliquotVol],[Officer],[Rec_Date],[Rec_ID] from  [dbo].[Aliquots] where UniqueID = '" & frm.TextBox1.Text.Trim & "'"

    '    Dim cmd As New SqlCommand(SQL, Qconn)
    '    Dim rDR As SqlDataReader = cmd.ExecuteReader
    '    While rDR.Read
    '        frm.TextBox1.Text = rDR.Item("UniqueID")

    '        aliquotState = rDR.Item("AliquotState")
    '        sLabref = rDR.Item("LabREf")
    '        sBarcode = rDR.Item("Barcode")
    '        sUniqueID = rDR.Item("UniqueID")
    '        sAliquot_State = rDR("AliquotState")

    '        If sAliquot_State IsNot Nothing Then
    '            If sAliquot_State = "Destroyed" Then
    '                msgWarn("The sample has been destroyed")
    '            ElseIf sAliquot_State.Contains("SHIPPED") Then
    '                msgWarn("The sample has already been shipped but not received yet")

    '            End If
    '        End If

    '    End While

    '    closeConn()
    'End Sub

    Public Sub GetAliquotDetails(UniqueId As String)
        openConn()

        Dim aliquotState As String = ""
        Dim SQL As String = "SELECT [LabRef],[Barcode],[UniqueID],[BOXID],[Pos_Ref],[Position],[AliquotState],[AliquotVol],[Officer],[Rec_Date],[Rec_ID] from  [dbo].[Aliquots] where UniqueID = '" & UniqueId & "'"

        Dim cmd As New SqlCommand(SQL, Qconn)

        Dim rDR As SqlDataReader = cmd.ExecuteReader
        While rDR.Read


            sUniqueID = rDR.Item("UniqueID")
            sLabref = rDR.Item("LabREf")
            sBarcode = rDR.Item("Barcode")
            sUniqueID = rDR.Item("UniqueID")
            sAliquot_State = rDR("AliquotState")
            If Convert.IsDBNull(rDR.Item("BOXID")) Then
                BoxNumber = Nothing
            Else
                BoxNumber = rDR.Item("BOXID")
            End If

            If Convert.IsDBNull(rDR.Item("Pos_Ref")) Then
                PositionRef = Nothing
            Else
                PositionRef = rDR.Item("Pos_Ref")
            End If
            If Convert.IsDBNull(rDR.Item("Position")) Then
                SamplePosition = Nothing
            Else
                SamplePosition = rDR.Item("Position")
            End If

            aliquotState = rDR.Item("AliquotState")
            sAliquotVol = rDR.Item("AliquotVol")


        End While

        closeConn()
    End Sub


    Public Function GetMyMAXTemp()
        Dim myCount As Integer
        Dim myQuery As String = Nothing
        Try
            openConn()
            myQuery = "SELECT Count(Barcode) from dbo.sample_results where Barcode = '" & sBarcode & "'"
            Dim DA As New SqlDataAdapter(myQuery, Qconn)
            Dim DS As New DataSet()
            Dim DT As New DataTable("maXID")
            DT.Clear()
            DA.Fill(DT)

            'If DT.Rows.Count > 0 Then
            '    myCount = DT.Rows.Count
            'End If

            If DT.Rows.Count <> 0 Then
                '  Return DT
                Return DT.Rows(0).ItemArray(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            msgError("application error in getting  new ID" + ex.Message)
        Finally
            closeConn()
        End Try
        Return myCount

    End Function

    Public Function GetMyNextID()
        Dim myCount As Integer
        Dim myQuery As String = Nothing
        Try
            openConn()
            myQuery = "SELECT Count(Barcode) from dbo.sample_results where Barcode = '" & sBarcode & "'"
            Dim DA As New SqlDataAdapter(myQuery, Qconn)
            Dim DS As New DataSet()
            Dim DT As New DataTable("maXID")
            DT.Clear()
            DA.Fill(DT)

            If DT.Rows.Count <> 0 Then
                '  Return DT
                Return DT.Rows(0).ItemArray(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            msgError("application error in getting  new ID" + ex.Message)
        Finally
            closeConn()
        End Try
        Return myCount

    End Function

    Public Function GetSamples()
        Dim myCount As Integer
        Dim myQuery As String = Nothing
        Try
            openConn()
            myQuery = "SELECT Count(Barcode) from dbo.sample_results where Barcode = '" & sBarcode & "'"
            Dim DA As New SqlDataAdapter(myQuery, Qconn)
            Dim DS As New DataSet()
            Dim DT As New DataTable("maXID")
            DT.Clear()
            DA.Fill(DT)

            If DT.Rows.Count <> 0 Then
                '  Return DT
                Return DT.Rows(0).ItemArray(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            msgError("application error in getting  new ID" + ex.Message)
        Finally
            closeConn()
        End Try
        Return myCount
    End Function


    Public Function RandomString(size As Integer, Optional validchars As String = "ABCDE") As String
        If size < 1 Or validchars.Length = 0 Then Return ""
        RandomString = ""
        Randomize()
        For i = 1 To size
            RandomString &= Mid(validchars, Int(Rnd() * validchars.Length) + 1, 1)
        Next
    End Function


    Public Sub RefreshNewID()
        If Qconn.State <> ConnectionState.Open Then
            Qconn.Open()
        End If


        Try
            Dim sql As String = "DELETE FROM settings.auto_id INSERT INTO settings.auto_id (labref) VALUES (0) "

            Dim cmd As New SqlCommand(sql, Qconn)
            Dim r As Integer = cmd.ExecuteNonQuery
        Catch ex As Exception
            msgError("Generating a new Labref : " & ex.Message)
        Finally
            Qconn.Close()
        End Try
    End Sub
    Public Sub MoveDeleted()
        If Qconn.State <> ConnectionState.Open Then
            Qconn.Open()
        End If

        Try
            Dim sql As String = "INSERT INTO [dbo].[Archivings_History]( [LabRef],[Barcode],[UniqueID],[BOXID],[Position],[Pos_Ref],[ArchiveState],[ArchiveDate],[Officer],[Rec_Date]) (SELECT * FROM [dbo].[Archivings] where uniqueid = '" & sUniqueID & "') "

            Dim cmd As New SqlCommand(sql, Qconn)
            Dim r As Integer = cmd.ExecuteNonQuery
        Catch ex As Exception
            msgError("Generating a new Labref : " & ex.Message)
        Finally
            Qconn.Close()
        End Try
    End Sub

    '  FROM [dbo].[Archivings] where uniqueid = '" & sUniqueID & "') "

    Public Sub DeleteArchiveRecord()
        If Qconn.State <> ConnectionState.Open Then
            Qconn.Open()
        End If

        Try
            Dim sql As String = "DELETE FROM [dbo].[Archivings] where uniqueid = '" & sUniqueID & "' "

            Dim cmd As New SqlCommand(sql, Qconn)
            Dim r As Integer = cmd.ExecuteNonQuery
        Catch ex As Exception
            msgError("Generating a new Labref : " & ex.Message)
        Finally
            Qconn.Close()
        End Try
    End Sub





    'Public Sub loadSubtypes(frm As frmResults)
    '    'FillMyGrid(frm.dgvSubtypes, "Select * from  Subtyping where result_Ref = '" & resultRef & "'")
    'End Sub

    ''Public Sub ClearSAMPLESControls(frm As frmSamples)
    '    frm.txtBarcode.Text = ""
    '    frm.cb_Location.SelectedIndex = -1
    '    frm.cb_SampleType.SelectedIndex = -1
    '    frm.cbSerumCat.SelectedIndex = -1
    '    frm.txtBactec.Text = ""
    '    '   frm.cb_Group.SelectedIndex = -1
    '    frm.clb_Studies.Items.Clear()
    '    frm.dtpColldate.Value = Now.Date
    '    frm.dtpReceiveDate.Value = Now.Date
    '    frm.txt_hour.Text = ""
    '    frm.rdoS_Yes.Checked = False
    '    frm.rdoS_No.Checked = False
    '    frm.rdoS_NA.Checked = False
    '    frm.lst_symptoms.ClearSelected()
    '    frm.dtpSymptomsonset.Value = Now.Date
    '    'frm.txtoutcome.Text = ""
    '    frm.nud_BWght.Value = 0
    '    frm.nud_Aweight.Value = 0
    '    frm.txt_InnWeight.Text = ""
    '    frm.cb_appearance.SelectedIndex = -1
    '    '  frm.cb_sufficient.SelectedIndex = -1
    '    frm.chk_Demo.CheckState = CheckState.Unchecked
    '    frm.cb_status.SelectedIndex = -1
    'End Sub
    Public Sub CloseAllForms()
        For Each frm As Form In SkyWater.MdiChildren
            frm.Close()
        Next
    End Sub


    Public Sub GetSelectQuery(qryName As String)
        Dim query As String = ""
        query = qryName
        openConn()
        Dim sercat As String = ""
        Dim SQL As String = "select [Query_String] from [dbo].[SQLQueries] where QueryName = '" & query & "'"

        Dim cmd As New SqlCommand(SQL, Qconn)
        Dim rDR As SqlDataReader = cmd.ExecuteReader


        While rDR.Read
            sQuery = rDR.Item("Query_String")
        End While

        closeConn()
    End Sub


    'Public Sub GetUserRights()

    '    Windows.Forms.Cursor.Current = Cursors.WaitCursor
    '    Try
    '        openConn() 'open db conn

    '        Dim mm_sql As String = "SELECT isnull(userID,0)userID,
    '                isnull(groupID,0)groupID,
    '                isnull(fname,'NO')fname,
    '                isnull(onames,'NO')onames,
    '                isnull(code,'NO')code,
    '                isnull(username,'NO')username,
    '                isnull([password],'NO')[password],
    '                isnull(logged,'NO')logged,
    '                isnull(email,'NO')email,
    '                isnull(destination,'NO')destination,
    '                isnull(date,'1900-01-01')date,
    '                isnull(status,'NO')status,
    '                isnull(officer,'NO')officer,
    '                isnull(DATEE,'1900-01-01')DATEE,
    '                isnull(Receive,'NO')Receive,
    '                isnull(Results,'NO')Results,
    '                isnull(Printing,'NO')Printing,
    '                isnull(QC,'NO')QC,
    '                isnull(EnterResults,'NO')EnterResults,
    '                isnull(epi,'NO')epi,
    '                isnull(reports,'NO')reports,
    '                isnull(Download,'NO')Download,
    '                isnull(Import,'NO')Import,
    '                isnull(Search,'NO')Search,
    '                isnull(ManageUsers,'NO')ManageUsers,
    '                isnull(ManageFreezer,'NO')ManageFreezer,
    '                isnull(userstatus,'NO')userstatus,
    '                isnull(LastLogin,'1900-01-01')LastLogin,
    '                isnull(ViewsampleONLY,'NO')ViewsampleONLY,
    '                isnull(viewResultsONLY,'NO')viewResultsONLY,
    '                isnull(ViewAuditTrail,'NO')ViewAuditTrail
    '            FROM [eLab].[settings].[users] WHERE username='" & Cuser & "'"
    '        Dim mm_cmd As New SqlCommand(mm_sql, Qconn)
    '        Dim mm_dr As SqlDataReader = mm_cmd.ExecuteReader

    '        If mm_dr.HasRows Then
    '            While mm_dr.Read

    '                Receive2 = mm_dr.Item("Receive")
    '                Results2 = mm_dr.Item("Results")
    '                Printing2 = mm_dr.Item("Printing")
    '                QC2 = mm_dr.Item("QC")
    '                EnterResults2 = mm_dr.Item("EnterResults")
    '                epi2 = mm_dr.Item("epi")
    '                Reports2 = mm_dr.Item("reports")
    '                Download2 = mm_dr.Item("Download")
    '                Import2 = mm_dr.Item("Import")
    '                Search2 = mm_dr.Item("Search")
    '                ManageUsers2 = mm_dr.Item("ManageUsers")
    '                ManageFreezer2 = mm_dr.Item("ManageFreezer")
    '                userstatus2 = mm_dr.Item("userstatus")
    '                LastLogin2 = mm_dr.Item("LastLogin")
    '                ViewsampleONLY2 = mm_dr.Item("ViewsampleONLY")
    '                viewResultsONLY2 = mm_dr.Item("viewResultsONLY")
    '                ViewAuditTrail2 = mm_dr.Item("ViewAuditTrail")


    '                'ManageInventory = mm_dr.Item("ManageInventory")
    '                'ViewInventory = mm_dr.Item("ViewInventory")

    '            End While
    '        Else
    '            msgWarn("No records available for fetching!")
    '        End If

    '    Catch ex As Exception
    '        msgError("error in executing user rights function " + ex.Message)
    '    Finally
    '        closeConn()
    '    End Try
    'End Sub


End Module
