Imports System.Data.SqlClient

Public Class frmlogin
    Dim sysuser As String = ""
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        If Cuser <> "" Then
            Select Case (MsgBox("Are you sure you want to exit the system?", MsgBoxStyle.YesNo, "LabMaster"))
                Case MsgBoxResult.Yes
                    userLogout()
                    'set the logged variable to 0 to allow for login
                    'Application.Exit()
                Case MsgBoxResult.No
                    msgSuccess("System exit cancelled by the user")
                    Me.Show()
                    '   Exit Sub
            End Select
        Else
            Application.Exit()
        End If
    End Sub


    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click

        sysuser = Me.txtuser.Text

        If ComboBox1.Text = "" Then
            msgError("The location for this computer is yet to be determined. Please contact Lab data manager or programmer for action")
            Exit Sub
        End If

        If Me.txtuser.Text = "" Or Me.txtpwd.Text = "" Then
            msgError("PLEASE CHECK YOUR USERNAME AND / PASSWORD")
            Exit Sub
        End If

        ' call the user authentication module

        Try
            Auth_User_login(Me.txtuser.Text.ToLower, encrypt(Me.txtpwd.Text), Qconn)
            ' GetUserRights()
        Catch ex As Exception
            msgError(ex.Message)
        End Try

        'Auth_User_login(Me.txtuser.Text.ToLower, "GaKFQUS2Oo92F6byJQGbEg==", Qconn)


    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If System.IO.File.Exists("C:\LIMSConfiguration1\configure.txt") Then
            Dim fileReader As System.IO.StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader("C:\LIMSConfiguration1\configure.txt")
            ' Location = fileReader.ReadLine()

            fileReader.Close()

            If My.Application.IsNetworkDeployed Then
                ver = My.Application.Deployment.CurrentVersion.ToString
            Else
                ver = My.Application.Info.Version.ToString
            End If

            Me.Label1.Text = "Version:" & ver
            ' ComboBox1.Text = sampleGroup
            getconnection()
            Button1.Visible = True
            'Else
            '    MsgBox("Please click the red button on the login form" & vbNewLine & " to configure location of this computer")
            '    Button1.Visible = True
        End If

    End Sub



    Private Sub ConfigMenu(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        'Select Case e.KeyData
        '    Case (Keys.Control + Keys.Shift + Keys.F12)
        '        MsgBox("Control + Shift + F12")
        '    Case (Keys.Escape)
        '        Me.Close()
        'End Select
        '' or
        If (e.KeyCode = Keys.Control AndAlso e.Modifiers = (Keys.End Or Keys.Home)) And (txtuser.Focus = True Or txtpwd.Focus = True) Then

            'frmConfiguration.Show()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        '' or

        'Select Case e.KeyCode
        '    Case (e.Control And e.Alt)

        '    Case (Keys.Escape)
        '        Me.Close()
        'End Select


    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' frmConfiguration.Show()
        Me.Hide()
    End Sub


    Private Sub txtuser_TextChanged(sender As Object, e As EventArgs) Handles txtuser.TextChanged
        'If txtuser.Text = "#configuration" Then
        '    Button1.Visible = True
        'Else
        '    Button1.Visible = False
        'End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class