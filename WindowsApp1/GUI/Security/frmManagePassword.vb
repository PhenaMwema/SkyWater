Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.Form
Imports System.Security.Cryptography
Imports System.Text
Public Class frmManagePassword


    Private Sub cmdsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)  Handles Button1.Click
        Dim pwd2 As String = Me.txtpwd2.Text.Trim
        Dim pwd As String = Me.txtPWD.Text.Trim

        If pwd = "" Then
            msgError("THE PASSWORD FIELD MUST BE FILLED")
            Me.txtPWD.Focus()
            Exit Sub
        End If

        If pwd2 = "" Then
            msgError("THE PASSWORD CONFIRMATION MUST BE FILLED")
            Exit Sub
        End If

        If pwd <> pwd2 Then
            msgError("THE TWO PASSWORDS DO NOT MATCH")
            Me.txtpwd2.Text = ""
            Me.txtpwd2.Focus()
            Exit Sub
        Else
            Try
                If Qconn.State <> ConnectionState.Open Then
                    Qconn.Open()
                End If
                '  Dim sql As String = "UPDATE dbo.users SET password='" + encrypt(pwd) + "' WHERE username='" + Me.cbouser.Text + "'"
                '   Dim us As String = "sosewe"

                Dim user As String

                user = cboUser.Text.Trim



                Dim sql As String = "UPDATE [skywater].[settings].[users]  SET password='" + encrypt(pwd) + "' WHERE username='" + user + "'"
                'Dim sql As String = "UPDATE dbo.users SET password='" + encrypt("root") + "' WHERE username='sosewe'"
                Dim cmd As New SqlCommand(sql, Qconn)
                Dim r As Integer
                r = cmd.ExecuteNonQuery

                If r > 0 Then
                    msgSuccess("PASSWORD FOR " + user + " CHANGED SUCCESSFULLY")
                    Me.txtpwd.Text = ""
                    Me.txtpwd2.Text = ""

                    'If Cgrp <> "ADMIN" Then
                    '    'pcsModulle.userLogout()
                    'End If

                End If

            Catch ex As Exception
                msgError("PASSWORD CHANGE FAILED : " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub cbouser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUser.SelectedIndexChanged
        Me.txtpwd.Text = ""
        Me.txtpwd2.Text = ""
    End Sub


    ''Private Sub InitializeComponent()
    ''    Me.SuspendLayout()
    ''    '
    ''    'frmmanagepassword
    ''    '
    ''    Me.ClientSize = New System.Drawing.Size(1129, 430)
    ''    Me.Name = "frmmanagepassword"
    ''    Me.ResumeLayout(False)

    ''End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub frmManagePassword_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Me.Button2.Enabled = False
        'loadGroup(Cuser)

        If ManageUsers2 = "YES" Then
            loadCombo(Me.cboUser, "SELECT * FROM [elab].[settings].[users] order by username", "username", "username")
            cboUser.Enabled = True
        Else
            loadCombo(Me.cboUser, "SELECT * FROM [elab].[settings].[users] WHERE username='" + Cuser + "'", "username", "username")
            cboUser.Enabled = False
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
