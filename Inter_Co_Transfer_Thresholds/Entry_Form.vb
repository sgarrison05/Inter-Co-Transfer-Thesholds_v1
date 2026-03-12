Public Class frmEntry

    Public childName As String
    Public sendingCounty As String
    Public receivingCounty As String
    Public typeOfTransfer As String
    Public officer As String
    Private dteStart As Date
    Private dteEnd As Date
    Private dteProgress As Date
    Private dteThreshold As Date

    Private Sub frmEntry_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Add officers to combo box
        cmbOfficer.Items.Add("[Select Officer]")
        cmbOfficer.Items.Add("Garrison")
        cmbOfficer.Items.Add("Anderson")
        cmbOfficer.Items.Add("Klipstein")
        cmbOfficer.Items.Add("Childress")
        cmbOfficer.SelectedIndex = 0

        'Add transfer types to combo box
        cmbType.Items.Add("[Select Type]")
        cmbType.Items.Add("Int Probation")
        cmbType.Items.Add("Int Deferred")
        cmbType.Items.Add("Int Det Sent Prob")
        cmbType.Items.Add("Interim Inter Co Trans")
        cmbType.SelectedIndex = 0

        dtpStart.Text = GetStartDate(dteStart)
        dtpEnd.Text = GetEndDate(dteEnd)

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        ClearForm()
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        CreateEntry()

    End Sub

    Private Sub CreateEntry()

        childName = txbChildName.Text
        receivingCounty = txbReceiveCo.Text
        sendingCounty = txbSendCo.Text
        typeOfTransfer = cmbType.Text
        officer = cmbOfficer.Text

        If My.Computer.FileSystem.FileExists(frmMain.tfile) Then

            My.Computer.FileSystem.WriteAllText(frmMain.tfile,
                                                childName.PadRight(20) & vbTab &
                                                receivingCounty.PadRight(17) & vbTab &
                                                sendingCounty.PadRight(17) & vbTab &
                                                typeOfTransfer.PadRight(22) & vbTab &
                                                officer.PadRight(10) & vbTab &
                                                dteStart.ToString("MM/dd/yyyy") & vbTab &
                                                dteThreshold.ToString("MM/dd/yyyy") & vbTab &
                                                dteProgress.ToString("MM/dd/yyyy") & vbTab &
                                                lblDaysRemainProg.Text & " days".PadRight(12) & vbTab &
                                                lblDaysRemainTrns.Text & " days" & vbCrLf,
                                                True)

        Else
            'Creates the Directory/File and writes the header and first line of data
            My.Computer.FileSystem.CreateDirectory(frmMain.tdirectory)
            My.Computer.FileSystem.WriteAllText(frmMain.tfile,
                                                "Child Name:".PadRight(20) & vbTab &
                                                "Receiving County:" & vbTab &
                                                "Sending County:".PadRight(18) & vbTab &
                                                "Type of Transfer:".PadRight(20) & vbTab &
                                                "Officer:".PadRight(2) & vbTab &
                                                "Start Date:" & vbTab &
                                                "Threshold:" & vbTab &
                                                "Prog Rpt:" & vbTab &
                                                "Prog Rpt Days:" & vbTab &
                                                "Threshold Days:" & vbCrLf &
                                                "-----------".PadRight(20) & vbTab &
                                                "---------------".PadRight(18) & vbTab &
                                                "------------".PadRight(18) & vbTab &
                                                "--------------".PadRight(20) & vbTab &
                                                "----------" & vbTab &
                                                "----------" & vbTab &
                                                "----------" & vbTab &
                                                "----------" & vbTab &
                                                "----------".PadRight(14) & vbTab &
                                                "----------" & ControlChars.NewLine,
                                                True)

            My.Computer.FileSystem.WriteAllText(frmMain.tfile,
                                                childName.PadRight(20) & vbTab &
                                                receivingCounty.PadRight(17) & vbTab &
                                                sendingCounty.PadRight(17) & vbTab &
                                                typeOfTransfer.PadRight(22) & vbTab &
                                                officer.PadRight(10) & vbTab &
                                                dteStart.ToString("MM/dd/yyyy") & vbTab &
                                                dteThreshold.ToString("MM/dd/yyyy") & vbTab &
                                                dteProgress.ToString("MM/dd/yyyy") & vbTab &
                                                lblDaysRemainProg.Text & " days".PadRight(12) & vbTab &
                                                lblDaysRemainTrns.Text & " days" & vbCrLf,
                                                True)

        End If
    End Sub

    Private Sub Separation()

    End Sub

    Private Sub ClearForm()

        txbChildName.Clear()
        txbReceiveCo.Clear()
        txbSendCo.Clear()
        lblProgRptDate.Text = ""
        lblTransThreshold.Text = ""
        lblDaysRemainProg.Text = ""
        lblDaysRemainTrns.Text = ""
        cmbType.SelectedIndex = 0
        cmbOfficer.SelectedIndex = 0
        dtpStart.Text = GetStartDate(dteStart)
        dtpEnd.Text = GetEndDate(dteEnd)

    End Sub

    Private Function GetStartDate(ByVal dtepass As Date) As Date

        dtepass = Date.Today.ToString("MM/dd/yyyy")
        Return dtepass

    End Function

    Private Function GetEndDate(ByVal dtepass As Date) As Date

        dtepass = Date.Today.AddDays(180).ToString("MM/dd/yyyy")
        Return dtepass

    End Function

    Private Sub dtpStart_TextChanged(sender As Object, e As EventArgs) Handles dtpStart.TextChanged

        dteStart = dtpStart.Value
        dteProgress = dteStart.AddDays(90)
        dteThreshold = GetEndDate(dteStart)

    End Sub

    Private Sub dtpEnd_TextChanged(sender As Object, e As EventArgs) Handles dtpEnd.TextChanged

        'TODO: Work on calcuations and the validity of this section
        dtpEnd.Text = dteThreshold.ToString

        lblProgRptDate.Text = dteProgress.ToString
        lblTransThreshold.Text = dteThreshold.ToString
        lblDaysRemainProg.Text = dteProgress.Subtract(Date.Now).Days.ToString
        lblDaysRemainTrns.Text = dteThreshold.Subtract(Date.Now).Days.ToString

        'Strips time out date/time
        If lblProgRptDate.Text.Contains(":") Then
            Dim rindex = lblProgRptDate.Text.IndexOf(":")
            lblProgRptDate.Text = lblProgRptDate.Text.Remove(rindex - 2)
        End If

        If lblTransThreshold.Text.Contains(":") Then
            Dim rindex = lblTransThreshold.Text.IndexOf(":")
            lblTransThreshold.Text = lblTransThreshold.Text.Remove(rindex - 2)
        End If

    End Sub
End Class