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

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

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


            'TODO: File Exists Path

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
                                                "Theshold:" & vbTab &
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

    Private Sub dtpEnd_Leave(sender As Object, e As EventArgs) Handles dtpEnd.Leave

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

    Private Sub dtpStart_Leave(sender As Object, e As EventArgs) Handles dtpStart.Leave

        dteStart = dtpStart.Value
        dteProgress = dteStart.AddDays(90)
        dteThreshold = dteStart.AddDays(180)

    End Sub

End Class