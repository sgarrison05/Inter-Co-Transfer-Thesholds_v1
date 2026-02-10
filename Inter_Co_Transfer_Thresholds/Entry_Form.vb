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

        If My.Computer.FileSystem.FileExists(frmMain.tfile) Then



        Else

            My.Computer.FileSystem.CreateDirectory(frmMain.tdirectory)
            My.Computer.FileSystem.WriteAllText(frmMain.tfile,
                                                "Child Name:".PadRight(20) & vbTab &
                                                "Receiving County:" & vbTab &
                                                "Sending County:".PadRight(6) & vbTab &
                                                "Type of Transfer:" & vbTab &
                                                "Officer:".PadRight(2) & vbTab &
                                                "Start Date:" & vbTab &
                                                "Progress Rpt:" & vbTab &
                                                "Prog Rpt Days Rem:" & vbTab &
                                                "Days till Threshold:" & vbCrLf &
                                                "-----------".PadRight(20) & vbTab &
                                                "----------".PadRight(7) & vbTab &
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
                                                typeOfTransfer.PadRight(17) & vbTab &
                                                officer.PadRight(10) & vbTab &
                                                dteStart.ToString("MM/dd/yyyy") & vbTab &
                                                dteThreshold.ToString("MM/dd/yyyy") & vbTab &
                                                dteProgress.ToString("MM/dd/yyyy") & vbTab &
                                                DateDiff(DateInterval.Day, dteProgress, dteStart) &
                                                DateDiff(DateInterval.Day, dteThreshold, dteStart) & vbCrLf,
                                                True)



        End If





    End Sub

End Class