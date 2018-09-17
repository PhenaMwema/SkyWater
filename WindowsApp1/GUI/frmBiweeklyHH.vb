Public Class frmBiweeklyHH

    Dim objCommon As New clsCommonMethods
    Dim db As New sky


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        objCommon.GetMyFormValidStatus = objCommon.validateControlsOnTabPage(TabPage1)

        Select Case objCommon.GetMyFormValidStatus
            Case "invalid"
                Exit Sub
        End Select

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage2)

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        objCommon.GetMyFormValidStatus = objCommon.validateControlsOnTabPage(TabPage2)

        Select Case objCommon.GetMyFormValidStatus
            Case "invalid"
                Exit Sub
        End Select

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage3)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        objCommon.GetMyFormValidStatus = objCommon.validateControlsOnTabPage(TabPage4)

        Select Case objCommon.GetMyFormValidStatus
            Case "invalid"
                Exit Sub
        End Select
        fillvalues()
        Try

            If MessageBox.Show("Save and close form?", "Save form", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
           MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                db.HHFollowup(varVID, varHHID, varobtain_last, varobtain_pipedhse, varobtain_pipedcmpd, varobtain_publictap, varobtain_shofco, varobtain_nonshofco,
                          varobtain_privatewell, varobtain_bottleh2o, varobtain_bagh2o, varobtain_vendorh2o, varobtain_munictap, varobtain_unknownh2o,
                          varobtain_otherh2o, varshofco_kiosk, varcont_see, varcont_observe, varcont_type, varcont_covered, vard_pour, vard_scoopcup,
                          vard_scoopladle, vard_empty, varstore_dur, varh2o_treat, varmethod_treat, vartreat_otherchem, vartreat_othermthd, varmaterial, varcl_aqua,
                          varCl_certeza, varCl_na, varCl_waterguard, varCl_watermaker, varCl_unk, varCl_other, varCl_PG, varcl_test, vartaste_notice, varbad_taste,
                          varprevent_collection, varp_handwash, varp_pipewater, varP_nopipe_notap, varp_nopipe_tap, varp_basin, varp_soap, varp_amc, varmain_defeac, vardefeac_other, vartoilet_type,
                          vartoilet_othertype, varslab_material, vardoor, varuse_cost, varuse_timeunit, varsharing, vartoilet_emptied, vartoilet_full,
                          varchild_defeac, varfeac_dispose, varfeac_disposeOther, varfeac_observed, varfeac_elsewhere, varComments, varrec_date, varOfficer, 1)
                msgSuccess("Saved Successfully")
                Me.Close()
            Else
                Return
            End If
        Catch ex As Exception

            msgError(ex.Message)
            Exit Sub
        End Try

        'db.HH_Followups(1, 3,)



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        objCommon.GetMyFormValidStatus = objCommon.validateControlsOnTabPage(TabPage3)

        Select Case objCommon.GetMyFormValidStatus
            Case "invalid"
                Exit Sub
        End Select

        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage4)

    End Sub

    Private Sub frmBiweeklyHH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(TabPage1)
    End Sub

    Private Sub cbcont_see_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcont_see.SelectedIndexChanged
        If cbcont_see.SelectedIndex = 0 Then
            cbcont_observe.Enabled = True
            cbcont_type.Enabled = True
            cbcont_covered.Enabled = True
            'txtcont_other.Enabled = True
            chk_pour.Enabled = True
            chkscoop_laddle.Enabled = True
            chk_empty.Enabled = True
            chk_scoopcup.Enabled = True
            varcont_see = "Yes"
        Else
            cbcont_observe.Enabled = False
            cbcont_type.Enabled = False
            cbcont_covered.Enabled = False
            txtcont_other.Enabled = False
            chk_pour.Enabled = False
            chkscoop_laddle.Enabled = False
            chk_empty.Enabled = False
            chk_scoopcup.Enabled = False
            varcont_see = "No"
        End If
    End Sub




    Private Sub cb_methdobsrv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_methdobsrv.SelectedIndexChanged

        varmaterial = cb_methdobsrv.Text 'material observed cb
        If cb_methdobsrv.Text.Trim = "No" And cb_methodtreat.Text.Trim = "Chlorine" Then
            chk_aquatabs.Enabled = False
            chk_certeza.Enabled = False
            chk_na.Enabled = False
            chk_waterguard.Enabled = False
            chk_watermaker.Enabled = False
            chk_unknown.Enabled = True
            chk_PGpurifier.Enabled = False
            chk_aquaguard.Enabled = False
            chk_chlother.Enabled = False
        Else
            chk_aquatabs.Enabled = False
            chk_certeza.Enabled = False
            chk_na.Enabled = False
            chk_waterguard.Enabled = False
            chk_watermaker.Enabled = False
            chk_unknown.Enabled = False
            chk_PGpurifier.Enabled = False
            chk_aquaguard.Enabled = False
            chk_chlother.Enabled = False
        End If

        If cb_methdobsrv.Text = "Yes" And cb_methodtreat.Text.Trim = "Chlorine" Then
            chk_aquatabs.Enabled = True
            chk_certeza.Enabled = True
            chk_na.Enabled = True
            chk_waterguard.Enabled = True
            chk_watermaker.Enabled = True
            chk_unknown.Enabled = False
            chk_PGpurifier.Enabled = True
            chk_aquaguard.Enabled = True
            chk_chlother.Enabled = True
        Else
            chk_aquatabs.Enabled = False
            chk_certeza.Enabled = False
            chk_na.Enabled = False
            chk_waterguard.Enabled = False
            chk_watermaker.Enabled = False
            chk_unknown.Enabled = False
            chk_PGpurifier.Enabled = False
            chk_aquaguard.Enabled = False
            chk_chlother.Enabled = False
        End If
    End Sub


    Private Sub cb_handwash_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_handwash.SelectedIndexChanged


        If Me.cb_handwash.Text = "Another place" Then
            Me.chk_pipewater.Enabled = False
            Me.chk_nopipe_notap.Enabled = False
            Me.chk_nopipe_tap.Enabled = False
            Me.chk_basin.Enabled = False
            Me.chk_soap.Enabled = False
            Me.chk_amc.Enabled = False
        Else
            Me.chk_pipewater.Enabled = True
            Me.chk_nopipe_notap.Enabled = True
            Me.chk_nopipe_tap.Enabled = True
            Me.chk_basin.Enabled = True
            Me.chk_soap.Enabled = True
            Me.chk_amc.Enabled = True

        End If
    End Sub

    Private Sub fillvalues()
        If radio_pipedhse.Checked = True Then
            varobtain_pipedhse = "Yes"
        Else
            varobtain_pipedhse = "No"
        End If
        If radio_pipedcmpd.Checked = True Then
            varobtain_pipedcmpd = "Yes"
        Else
            varobtain_pipedcmpd = "No"
        End If

        If radio_publictap.Checked = True Then
            varobtain_publictap = "Yes"
        Else
            varobtain_publictap = "No"
        End If
        If radio_shofco.Checked = True Then
            txt_shofco.Enabled = True 'And
            varobtain_shofco = "Yes"
        Else
            varobtain_shofco = "No"
            txt_shofco.Enabled = False
            txt_shofco.Text = ""
        End If
        If radio_nonshofco.Checked = True Then
            varobtain_nonshofco = "Yes"
        Else
            varobtain_nonshofco = "No"
        End If
        If radio_privatewell.Checked = True Then
            varobtain_privatewell = "Yes"
        Else
            varobtain_privatewell = "No"
        End If

        If radio_bottleh2o.Checked = True Then
            varobtain_bottleh2o = "Yes"
        Else
            varobtain_bottleh2o = "No"
        End If
        If radio_bagh2o.Checked = True Then
            varobtain_bagh2o = "Yes"
        Else
            varobtain_bagh2o = "No"
        End If
        If radio_vendorh2o.Checked = True Then
            varobtain_vendorh2o = "Yes"
        Else
            varobtain_vendorh2o = "No"
        End If
        If radio_munictap.Checked = True Then
            varobtain_munictap = "Yes"
        Else
            varobtain_munictap = "No"
        End If
        If radio_unknownh2o.Checked = True Then
            varobtain_unknownh2o = "Yes"
        Else
            varobtain_unknownh2o = "No"
        End If
        If radio_otherh2o.Checked = True And
            txt_otherh2o.Enabled = True Then
            varobtain_otherh2o = txt_otherh2o.Text
        Else
            varobtain_otherh2o = "No"
            txt_otherh2o.Enabled = False
            txt_otherh2o.Text = ""
        End If

        If cbh2o_obtain.Text = "Other, specify:" And
            txth2o_obtain.Enabled = True Then
            varobtain_last = txth2o_obtain.Text
        Else
            varobtain_last = cbh2o_obtain.Text
        End If


        If txt_shofco.Enabled = True Then
            varshofco_kiosk = txt_shofco.Text
        Else
            varshofco_kiosk = ""
        End If

        If cbcont_observe.Enabled = True Then
            varcont_observe = cbcont_observe.Text
        Else
            varcont_observe = "No"
        End If

        If cbcont_type.Enabled = True And
            cbcont_type.Text = "Other, specify:" Then
            txtcont_other.Enabled = True
            varcont_type = txtcont_other.Text
        Else
            varcont_type = cbcont_type.Text
            txtcont_other.Enabled = False
            txtcont_other.Text = ""
        End If

        If cbcont_covered.Enabled = True Then
            varcont_covered = cbcont_covered.Text
        Else
            varcont_covered = "No"
        End If

        If chk_scoopcup.Enabled = True And
            chk_scoopcup.Checked = True Then
            vard_scoopcup = "Yes"
        Else
            vard_scoopcup = "No"
        End If

        If chk_empty.Enabled = True And
            chk_empty.Checked = True Then
            vard_empty = "Yes"
        Else
            vard_empty = "No"
        End If

        If chk_pour.Enabled = True And
            chk_pour.Checked = True Then
            vard_pour = "Yes"
        Else
            vard_pour = "No"
        End If

        If chkscoop_laddle.Enabled = True And
            chkscoop_laddle.Checked = True Then
            vard_scoopladle = "Yes"
        Else
            vard_scoopladle = "No"
        End If

        If txt_otherh2o.Enabled = True Then
            If radio_otherh2o.Checked = True Then
                varobtain_otherh2o = txt_otherh2o.Text
            Else
                varobtain_otherh2o = "No"
            End If
        End If

        If cbcont_type.Text = "Other, specify:" Then
            txtcont_other.Enabled = True
        Else
            txtcont_other.Enabled = False
        End If
        '---------------page 2------------

        If cb_methodtreat.Text = "Other method, Specify:" Then
            varmethod_treat = "Other method, Specify:"
            vartreat_othermthd = txt_othermethod.Text
        Else
            varmethod_treat = cb_methodtreat.Text
        End If

        If cb_methodtreat.Text = "Other chemical, Specify" Then
            varmethod_treat = "Other chemical, Specify"
            vartreat_otherchem = txt_othermethod.Text
        Else
            varmethod_treat = cb_methodtreat.Text
        End If


        If chk_watermaker.Checked = True Then
            varCl_watermaker = "Yes"
        Else
            varCl_watermaker = "No"
        End If

        If chk_aquatabs.Checked = True Then
            varcl_aqua = "Yes"
        Else
            varcl_aqua = "No"
        End If

        If chk_chlother.Enabled = True And
                chk_chlother.Checked = True Then
            varCl_other = txt_chlother.Text
        Else
            varCl_other = "No"
            txt_chlother.Enabled = False
            txt_chlother.Text = ""
        End If

        If chk_certeza.Checked = True Then
            varCl_certeza = "Yes"
        Else
            varCl_certeza = "No"
        End If

        If chk_na.Checked = True Then
            varCl_na = "Yes"
        Else
            varCl_na = "No"
        End If

        If chk_waterguard.Checked = True Then
            varCl_waterguard = "Yes"
        Else
            varCl_waterguard = "No"
        End If

        If chk_unknown.Checked = True Then
            varCl_unk = "Yes"
        Else
            varCl_unk = "No"
        End If

        If chk_PGpurifier.Checked = True Then
            varCl_PG = "Yes"
        Else
            varCl_PG = "No"
        End If



        '----------page 3----------------

        varp_handwash = cb_handwash.Text

        If chk_pipewater.Checked = True Then
            varp_pipewater = "Yes"
        Else
            varp_pipewater = "No"
        End If

        If chk_nopipe_notap.Checked = True Then
            varP_nopipe_notap = "Yes"
        Else
            varP_nopipe_notap = "No"
        End If

        If chk_basin.Checked = True Then
            varp_basin = "Yes"
        Else
            varp_basin = "No"
        End If

        If chk_soap.Checked = True Then
            varp_soap = "Yes"
        Else
            varp_soap = "No"
        End If

        If chk_nopipe_tap.Checked = True Then
            varp_nopipe_tap = "Yes"
        Else
            varp_nopipe_tap = "No"
        End If

        If chk_amc.Checked = True Then
            varp_amc = "Yes"
        Else
            varp_amc = "No"
        End If

        If txt_toiletother.Enabled = True Then
            vartoilet_type = combo_toilettype.Text
            vartoilet_othertype = txt_toiletother.Text
        Else
            txt_toiletother.Enabled = False
            txt_toiletother.Text = ""
            vartoilet_type = combo_toilettype.Text
        End If

        '-------------page 3-----------------

        If combo_slab.Text = "Other/specify:" And
            txt_slabother.Enabled = True Then
            varslab_material = txt_slabother.Text
        Else
            txt_slabother.Enabled = False
            txt_slabother.Text = ""
            varslab_material = combo_slab.Text
        End If

        If num_toiletcost.Enabled = True Then
            varuse_cost = num_toiletcost.Value
            'Else
            '    varuse_cost = "0"
        End If

        '---------------------page 4-----------------

        If combo_childdefeac.Text = "Other, specify:" And
            txt_child_defeacother.Enabled = True Then
            varchild_defeac = txt_child_defeacother.Text
        Else
            txt_child_defeacother.Enabled = False
            txt_child_defeacother.Text = ""
            varchild_defeac = combo_childdefeac.Text
        End If

        If combo_feacdispose.Text = "Other, specify:" And
            txt_feacdisposeother.Enabled = True Then
            varfeac_dispose = combo_feacdispose.Text
            varfeac_disposeOther = txt_feacdisposeother.Text.Trim

        Else
            txt_feacdisposeother.Enabled = False
            txt_feacdisposeother.Text = ""
            varfeac_dispose = combo_feacdispose.Text
        End If

        If cb_feacobsrv.Text = "Others, specify:" And
            txt_feacobsrv.Enabled = True Then
            varfeac_observed = txt_feacobsrv.Text
        Else
            varfeac_observed = cb_feacobsrv.Text
        End If

        If cb_feacobsrvelse.Text = "Others, specify:" And
            txt_feacobsrvelse.Enabled = True Then
            varfeac_elsewhere = txt_feacobsrvelse.Text
        Else
            txt_feacobsrvelse.Enabled = False
            varfeac_elsewhere = cb_feacobsrvelse.Text
        End If

        varComments = txtComments.Text
    End Sub


    Private Sub cb_maindefeac_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_maindefeac.SelectedIndexChanged
        If cb_maindefeac.Text = "Other, specify:" Then
            txt_otherdefeac.Enabled = True
            varmain_defeac = cb_maindefeac.Text
            vardefeac_other = txt_otherdefeac.Text
        Else
            txt_otherdefeac.Enabled = False
            txt_otherdefeac.Text = ""
            varmain_defeac = cb_maindefeac.Text
        End If

        If cb_maindefeac.Text = "Onsite/household toilet (in-compound)" Or cb_maindefeac.Text = "Public toilet" Then
            combo_toilettype.Enabled = True
        Else
            combo_toilettype.Enabled = False
            combo_toilettype.Text = ""
        End If
        If cb_maindefeac.Text = "Public toilet" Then
            num_toiletcost.Enabled = True
            combo_unittime.Enabled = True
        Else
            num_toiletcost.Enabled = False
            combo_unittime.Enabled = False
        End If

        If cb_maindefeac.Text = "No toilet" Then
            num_toiletcost.Enabled = False
            combo_unittime.Enabled = False
            combo_slab.Enabled = False
            combo_toiletemptied.Enabled = False
            combo_toiletshare.Enabled = False
            combo_toiletfull.Enabled = False
        End If

    End Sub

    Private Sub combo_toilettype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_toilettype.SelectedIndexChanged
        If combo_toilettype.Enabled = True And
            combo_toilettype.Text = "Other, specify:" Then
            txt_toiletother.Enabled = True
        Else
            txt_toiletother.Enabled = False
            txt_toiletother.Text = ""
        End If
    End Sub

    Private Sub combo_slab_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_slab.SelectedIndexChanged
        If combo_slab.Text = "Other/specify:" Then
            txt_slabother.Enabled = True
        Else
            txt_slabother.Enabled = False
        End If
    End Sub


    Private Sub combo_childdefeac_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_childdefeac.SelectedIndexChanged
        If combo_childdefeac.Text = "Other, specify:" Then
            txt_child_defeacother.Enabled = True
        Else
            txt_child_defeacother.Enabled = False
            txt_child_defeacother.Text = ""
        End If
    End Sub

    Private Sub combo_feacdispose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_feacdispose.SelectedIndexChanged
        If combo_feacdispose.Text = "Other, specify:" Then
            txt_feacdisposeother.Enabled = True
        Else
            txt_feacdisposeother.Enabled = False
            txt_feacdisposeother.Text = ""
        End If
    End Sub

    Private Sub cb_methodtreat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_methodtreat.SelectedIndexChanged
        If cb_methodtreat.Text = "Other chemical, Specify:" Or cb_methodtreat.Text = "Other method, Specify:" Then
            txt_othermethod.Enabled = True
        Else
            txt_othermethod.Enabled = False
            cb_methodtreat.Text = ""
        End If

        'If cb_methodtreat.Text = "Other chemical, Specify" Then
        '    txt_othermethod.Enabled = True
        'Else
        '    txt_othermethod.Enabled = False
        '    cb_methodtreat.Text = ""
        'End If


        If cb_methodtreat.Text = "Chlorine" And cb_methdobsrv.Text = "No" Then
            chk_aquatabs.Enabled = False
            chk_certeza.Enabled = False
            chk_na.Enabled = False
            chk_waterguard.Enabled = False
            chk_watermaker.Enabled = False
            chk_unknown.Enabled = True
            chk_PGpurifier.Enabled = False
            chk_aquaguard.Enabled = False
            chk_chlother.Enabled = False

        Else
            chk_aquatabs.Enabled = False
            chk_certeza.Enabled = False
            chk_na.Enabled = False
            chk_waterguard.Enabled = False
            chk_watermaker.Enabled = False
            chk_unknown.Enabled = False
            chk_PGpurifier.Enabled = False
            chk_aquaguard.Enabled = False
            chk_chlother.Enabled = False
        End If
        If cb_methodtreat.Text.Trim = "Chlorine" And cb_methdobsrv.Text = "Yes" Then
            chk_aquatabs.Enabled = True
            chk_certeza.Enabled = True
            chk_na.Enabled = True
            chk_waterguard.Enabled = True
            chk_watermaker.Enabled = True
            chk_unknown.Enabled = False
            chk_PGpurifier.Enabled = True
            chk_aquaguard.Enabled = True
            chk_chlother.Enabled = True
        Else
            chk_aquatabs.Enabled = False
            chk_certeza.Enabled = False
            chk_na.Enabled = False
            chk_waterguard.Enabled = False
            chk_watermaker.Enabled = False
            chk_unknown.Enabled = False
            chk_PGpurifier.Enabled = False
            chk_aquaguard.Enabled = False
            chk_chlother.Enabled = False
        End If

    End Sub


    Private Sub cb_storedur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_storedur.SelectedIndexChanged
        varstore_dur = cb_storedur.Text
    End Sub

    Private Sub cb_h2otreat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_h2otreat.SelectedIndexChanged
        varh2o_treat = cb_h2otreat.Text
    End Sub

    Private Sub txt_chlresult_TextChanged(sender As Object, e As EventArgs) Handles txt_chlresult.TextChanged
        varcl_test = txt_chlresult.Text
    End Sub

    Private Sub cb_tastenotice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_tastenotice.SelectedIndexChanged

        vartaste_notice = cb_tastenotice.Text
        If cb_tastenotice.Text = "Yes" Then
            cb_badtaste.Enabled = True
        Else
            cb_badtaste.Enabled = False
            cb_badtaste.Text = ""
        End If
        If cb_tastenotice.Text = "Yes" Then
            cb_preventcollection.Enabled = True
        Else
            cb_preventcollection.Enabled = False
            cb_preventcollection.Text = ""
        End If
    End Sub

    Private Sub cb_badtaste_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_badtaste.SelectedIndexChanged
        varbad_taste = cb_badtaste.Text
    End Sub

    Private Sub cb_preventcollection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_preventcollection.SelectedIndexChanged
        varprevent_collection = cb_preventcollection.Text
    End Sub

    Private Sub combo_door_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_door.SelectedIndexChanged
        vardoor = combo_door.Text
    End Sub

    Private Sub combo_unittime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_unittime.SelectedIndexChanged
        If combo_door.Enabled = True Then
            varuse_timeunit = combo_unittime.Text
        End If
    End Sub

    Private Sub combo_toiletshare_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_toiletshare.SelectedIndexChanged
        varsharing = combo_toiletshare.Text
    End Sub

    Private Sub combo_toiletemptied_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_toiletemptied.SelectedIndexChanged
        vartoilet_emptied = combo_toiletemptied.Text
    End Sub

    Private Sub combo_toiletfull_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_toiletfull.SelectedIndexChanged
        vartoilet_full = combo_toiletfull.Text
    End Sub

    Private Sub cb_feacobsrv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_feacobsrv.SelectedIndexChanged
        If cb_feacobsrv.Text = "Others, specify:" Then
            txt_feacobsrv.Enabled = True
        Else
            txt_feacobsrv.Enabled = False
            txt_feacobsrv.Text = ""
        End If
    End Sub

    Private Sub cb_feacobsrvelse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_feacobsrvelse.SelectedIndexChanged
        If cb_feacobsrvelse.Text = "Others, specify:" Then
            txt_feacobsrvelse.Enabled = True
        Else
            txt_feacobsrvelse.Enabled = False
            txt_feacobsrvelse.Text = ""
        End If
    End Sub

    Private Sub cbh2o_obtain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbh2o_obtain.SelectedIndexChanged
        If cbh2o_obtain.Text = "Other, specify:" Then
            txth2o_obtain.Enabled = True
        End If
    End Sub

    Private Sub radio_otherh2o_CheckedChanged(sender As Object, e As EventArgs) Handles radio_otherh2o.CheckedChanged
        If radio_otherh2o.Checked = True Then
            txt_otherh2o.Enabled = True
        Else
            txt_otherh2o.Enabled = False
        End If
    End Sub

    Private Sub txt_toiletother_TextChanged(sender As Object, e As EventArgs) Handles txt_toiletother.TextChanged

    End Sub

    Private Sub radio_shofco_CheckedChanged(sender As Object, e As EventArgs) Handles radio_shofco.CheckedChanged
        If radio_shofco.Checked = True Then
            txt_shofco.Enabled = True
        Else
            txt_shofco.Enabled = False
        End If
    End Sub

    Private Sub cbcont_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcont_type.SelectedIndexChanged

    End Sub

    Private Sub chk_chlother_CheckedChanged(sender As Object, e As EventArgs) Handles chk_chlother.CheckedChanged
        If chk_chlother.Checked = True Then
            txt_chlother.Enabled = True
        Else
            txt_chlother.Enabled = False
        End If
    End Sub


End Class