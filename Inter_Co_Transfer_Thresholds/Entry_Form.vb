Public Class frmEntry

    Public childName As String
    Public sendingCounty As String
    Public receivingCounty As String
    Public typeOfTransfer As String
    Public officer As String
    Private dteStart As Date
    Private dteEnd As Date
    Private dteProgress As Date

    Private Sub frmEntry_Load(sender As Object, e As EventArgs) Handles Me.Load

        RefillCombo()

        FillData()

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        ClearForm()
        cmbType.Items.Clear()
        cmbOfficer.Items.Clear()
        Me.Close()
        frmMain.Show()
        frmMain.btnRefresh.PerformClick()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        CreateEntry()

        ClearForm()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ClearForm()

        txbChildName.Focus()

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
                                                dteEnd.ToString("MM/dd/yyyy") & vbTab &
                                                dteProgress.ToString("MM/dd/yyyy") & vbTab &
                                                lblDaysRemainProg.Text.PadLeft(3) & " days" & Space(4) & vbTab &
                                                lblDaysRemainTrns.Text.PadLeft(3) & " days" & vbCrLf,
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
                                                dteEnd.ToString("MM/dd/yyyy") & vbTab &
                                                dteProgress.ToString("MM/dd/yyyy") & vbTab &
                                                lblDaysRemainProg.Text.PadLeft(3) & " days" & Space(4) & vbTab &
                                                lblDaysRemainTrns.Text.PadLeft(3) & " days" & vbCrLf,
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
        cmbOfficer.SelectedIndex = 0
        cmbType.SelectedIndex = 0
        dtpStart.Value = Date.Today
        dtpEnd.Value = dteStart.AddDays(180)
        txbChildName.Focus()

    End Sub

    Private Sub FillData()

        dteStart = CDate(dtpStart.Value)
        dteProgress = CDate(dteStart.AddDays(90))
        dteEnd = CDate(dteStart.AddDays(180))

        dtpEnd.Value = dteEnd

        lblProgRptDate.Text = dteProgress.ToString("MM/dd/yyyy")
        lblTransThreshold.Text = dteEnd.ToString("MM/dd/yyyy")
        lblDaysRemainProg.Text = dteProgress.Subtract(Date.Now).Days.ToString
        lblDaysRemainTrns.Text = dteEnd.Subtract(Date.Now).Days.ToString

    End Sub

    Private Sub RefillCombo()

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

    Private Sub dtpStart_TextChanged(sender As Object, e As EventArgs) Handles dtpStart.TextChanged

        FillData()

    End Sub

    Private Sub dtpEnd_TextChanged(sender As Object, e As EventArgs) Handles dtpEnd.TextChanged

        'todo: work on calcuations and the validity of this section

    End Sub

    Private Sub txbReceiveCo_TextChanged(sender As Object, e As EventArgs) Handles txbReceiveCo.TextChanged

        If txbReceiveCo.Text = "Orange" Then
            txbReceiveCo.BackColor = Color.Orange
        Else
            txbReceiveCo.BackColor = Color.White
        End If

    End Sub

    Private Sub txbSendCo_TextChanged(sender As Object, e As EventArgs) Handles txbSendCo.TextChanged

        If txbSendCo.Text = "Orange" Then
            txbSendCo.BackColor = Color.Orange
        Else
            txbSendCo.BackColor = Color.White
        End If

    End Sub
End Class