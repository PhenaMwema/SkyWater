Public Class clsSQLQueryLibrary
    Private tblName As String = Nothing
    Private fmMode As String = Nothing
    Private curTable As String = Nothing
    Private chkTable As String = Nothing
    Private curTableOption As String = Nothing
    Private chkTableOption As String = Nothing
    Private ptnstatus As String = Nothing
    Private dssID As String = Nothing

    Public Property GetTableName As String
        Get
            Return tblName
        End Get
        Set(ByVal value As String)
            tblName = value
        End Set
    End Property

    Public Property GetFormMode As String

        Get
            Return fmMode
        End Get
        Set(ByVal value As String)
            fmMode = value
        End Set
    End Property

    Public Property GetCurrentTable As String
        Get
            Return curTable
        End Get
        Set(ByVal value As String)
            curTable = value
        End Set
    End Property
    Public Property GetCheckTable As String

        Get
            Return chkTable
        End Get
        Set(ByVal value As String)
            chkTable = value
        End Set
    End Property
    Public Property GetCurrentTableOption As String
        Get
            Return curTableOption
        End Get
        Set(ByVal value As String)
            curTableOption = value
        End Set
    End Property
    Public Property GetCheckTableOption As String
        Get
            Return chkTableOption
        End Get
        Set(ByVal value As String)
            chkTableOption = value
        End Set
    End Property



    'Public Sub GetSamplesReportsPerSite(frm As frmReports)
    '    FillMyGrid(frm.DataGridView1, "select t.location [location], sampletype, " &
    '        "(select count(b.LabRef) from [dbo].[Specimen] b where  t.location = b.location and (t.SampleType = b.SampleType)  And cast(b.receive_date as date) between '" & sdate & "' and  '" & edate & "' )  [#RECEIVED]," &
    '        "(select count(b.LabRef) from [dbo].[Specimen] b where  t.location = b.location and status = 'Accepted' and t.SampleType = b.SampleType And cast(b.receive_date as date) between '" & sdate & "' and  '" & edate & "' )[#ACCEPTED] ," &
    '        "(select count(b.LabRef) from [dbo].[Specimen] b where  t.location = b.location and status = 'Rejected' and t.SampleType = b.SampleType and And cast(b.receive_date as date) between '" & sdate & "' and  '" & edate & "') [#REJECTED]" &
    '        "FROM [eLab].[dbo].[Specimen] t " &
    '        "group by t.location, sampletype")
    'End Sub

    'Public Sub GetSamplesTotal(frm As frmReports)

    '    Dim sql As String = "select sampletype [SAMPLES], " &
    '        "(select count(b.LabRef) from [dbo].[Specimen] b where  t.SampleType = b.SampleType And cast(b.receive_date as date) between '" & sdate & "' and  '" & edate & "' )  [#RECEIVED], " &
    '        "(select count(b.LabRef) from [dbo].[Specimen] b where  t.SampleType = b.SampleType And cast(b.receive_date as date) between '" & sdate & "' and  '" & edate & "' and status = 'Accepted')[#ACCEPTED] ," &
    '        "(select count(b.LabRef) from [dbo].[Specimen] b where  t.SampleType = b.SampleType And cast(b.receive_date as date) between '" & sdate & "' and  '" & edate & "' and status = 'Rejected') [#REJECTED]" &
    '        "FROM [eLab].[dbo].[Specimen] t " &
    '        "group by t.sampletype"
    '    FillMyGrid(frm.DataGridView1, sql)
    'End Sub



    'Public Sub GetSamplesGoup(frm As frmReports)
    '    FillMyGrid(frm.DataGridView1, "select t.sampleGroup, sampletype, " &
    '        "(select count(b.LabRef) from [dbo].[Specimen] b where  t.sampleGroup = b.sampleGroup And cast(b.receive_date as date) between '" & sdate & "' and  '" & edate & "')  [#RECEIVED]," &
    '        "(select count(b.LabRef) from [dbo].[Specimen] b where  t.sampleGroup = b.sampleGroup And cast(b.receive_date as date) between '" & sdate & "' and  '" & edate & "' and status = 'Accepted')[#ACCEPTED] ," &
    '        "(select count(b.LabRef) from [dbo].[Specimen] b where  t.sampleGroup = b.sampleGroup And cast(b.receive_date as date) between '" & sdate & "' and  '" & edate & "' and status = 'Rejected') [#REJECTED]" &
    '        "FROM [eLab].[dbo].[Specimen] t " &
    '        "group by t.sampleGroup, sampletype")
    'End Sub

    'Public Sub GetQCReports(frm As frmReports)


    '    Dim qry As String = "select  sampletype," &
    '        "(select count(b.LabRef) from [dbo].[Specimen] b where  t.SampleType = b.SampleType and status = 'Accepted' And cast(b.receive_date as date) between '" & sdate & "' and  '" & edate & "')[#ACCEPTED] ," &
    '        "(select count(b.LabRef) from [dbo].[Specimen] b where  t.SampleType = b.SampleType and status = 'Rejected' And cast(b.receive_date as date) between '" & sdate & "' and  '" & edate & "') [#REJECTED]" &
    '        "FROM [eLab].[dbo].[Specimen] t " &
    '        "group by t.sampleGroup, sampletype"
    '    FillMyGrid(frm.DataGridView1, qry)
    'End Sub

End Class
