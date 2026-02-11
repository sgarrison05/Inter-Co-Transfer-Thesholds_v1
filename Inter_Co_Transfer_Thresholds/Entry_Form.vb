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

        'StripTime()

        childName = txbChildName.Text
        receivingCounty = txbReceiveCo.Text
        sendingCounty = txbSendCo.Text
        typeOfTransfer = cmbType.Text
        officer = cmbOfficer.Text
        dteStart = dtpStart.Value
        dteProgress = dteStart.AddDays(90)
        dteThreshold = dteStart.AddDays(180)
        dtpEnd.Text = dteThreshold.ToString

        lblProgRptDate.Text = dteProgress.ToString
        lblTransThreshold.Text = dteThreshold.ToString
        lblDaysRemainProg.Text = dteProgress.Subtract(DateTime.Now).Days.ToString
        lblDaysRemainTrns.Text = dteThreshold.Subtract(DateTime.Now).Days.ToString

        If lblProgRptDate.Text.Contains(":") Then
            Dim rindex = lblProgRptDate.Text.IndexOf(":")
            lblProgRptDate.Text = lblProgRptDate.Text.Remove(rindex - 2)
        End If

        If lblTransThreshold.Text.Contains(":") Then
            Dim rindex = lblTransThreshold.Text.IndexOf(":")
            lblTransThreshold.Text = lblTransThreshold.Text.Remove(rindex - 2)
        End If

        If My.Computer.FileSystem.FileExists(frmMain.tfile) Then



        Else

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
                                                "---------------" & vbTab &
                                                "------------".PadRight(5) & vbTab &
                                                "----------" & vbTab &
                                                "----------" & vbTab &
                                                "----------" & vbTab &
                                                "----------" & vbTab &
                                                "----------" & vbTab &
                                                "----------" & vbTab &
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

    Private Sub StripTime()

        dtpStart.Format = DateTimePickerFormat.Custom
        dtpStart.CustomFormat = "MM/dd/yyyy"
        dtpEnd.Format = DateTimePickerFormat.Custom
        dtpEnd.CustomFormat = "MM/dd/yyyy"
        dteStart = Convert.ToDateTime(dtpStart.Text)
        dteEnd = Convert.ToDateTime(dtpEnd.Text)

    End Sub

End Class