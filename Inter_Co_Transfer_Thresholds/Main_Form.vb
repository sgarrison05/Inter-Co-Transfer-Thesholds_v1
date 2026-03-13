'Title:         Inter County Transfer Thresholds
'Purpose:       To manage progress reports and thresholds for inter-county transfers
'Created:       October 31, 2025
'By:            Shon Garrison
'Last Updated:  March 2026
'Version: 1.0

Option Explicit On
Imports System.Globalization

Public Class frmMain

    Private title As String = "Inter County Transfer Thresholds"
    Public Const tdirectory As String = "D:\Temp\Transfers"
    Public Const tfile As String = "D:\Temp\Transfers\ICT_Thresholds.txt"

    '------------------------------ Form Events --------------------------------------------------

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim dteToday As Date = Date.Today
        Dim dteNinety As Date = dteToday.AddDays(90)
        Dim dteOneEighty As Date = dteToday.AddDays(180)

        dtpNinety.Text = dteNinety.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)
        dtpOneEighty.Text = dteOneEighty.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture)

        Dim button As DialogResult

        If Not My.Computer.FileSystem.FileExists(tfile) Then

            button = MessageBox.Show("Thresholds file not found." & vbCrLf &
                                     "Would you like to Create it?",
                                     title, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                     MessageBoxDefaultButton.Button1)

            If button = DialogResult.Yes Then
                Me.Hide()
                frmEntry.ShowDialog()
            Else
                button = DialogResult.No
                Me.Close()
            End If
        Else
            PullData()
        End If

    End Sub

    '------------------------------ Private Subroutines  ---------------------------------------

    Private Sub PullData()

        Dim myText As String = My.Computer.FileSystem.ReadAllText(tfile)
        Dim mySentence() As String = Split(myText, vbCrLf)
        Dim listing As Integer = 1  ' Counter for each record
        Dim recieve As Integer = 0  ' Counter for receiving County
        Dim sent As Integer = 0     ' Counter for sending County
        Dim dteICTThresh As Date
        Dim dteProgRptThresh As Date
        Dim display As String

        For Each sentence As String In mySentence
            If sentence.Contains("/"c) Then

                Dim words() As String = Split(sentence, vbTab)

                'Extract two dates to compute refresh on data pull
                dteICTThresh = CDate(words(6).TrimEnd)
                dteProgRptThresh = CDate(words(7).TrimEnd)

                'get updated days remaining in progress report and program
                Dim progRptDaysRefresh As Integer = dteProgRptThresh.Subtract(Date.Now).Days.ToString
                Dim ictDaysRefresh As Integer = dteICTThresh.Subtract(Date.Now).Days.ToString

                'inject refreshed days remaining into the appropriate array index for display on form
                words(8) = progRptDaysRefresh.ToString.PadLeft(3) & " days"
                words(9) = ictDaysRefresh.ToString.PadLeft(3) & " days"

                'Put the words back together with padding for display on form
                For i = 0 To words.Length - 1
                    If words(i).Length > 0 Then
                        display = String.Join(" ".PadRight(5), words)
                    End If
                Next

                'Compute numbers of sending/receiving counties for summary at bottom of form
                If words(1).TrimEnd = "Orange" Then
                    recieve += 1
                End If

                If words(2).TrimEnd = "Orange" Then
                    sent += 1
                End If

                lblListing.Text &= listing.ToString & ".)  " & display & vbCrLf
                listing += 1

            End If
        Next

        lblTotalChildren.Text = listing.ToString - 1
        lblTotReceived.Text = recieve.ToString
        lblTotSent.Text = sent.ToString

    End Sub

    '------------------------------ Button Events ----------------------------------------------

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Hide()
        frmEntry.ShowDialog()

    End Sub

    Private Sub brnClose_Click(sender As Object, e As EventArgs) Handles brnClose.Click

        Me.Close()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Hide()
        frmSearch.ShowDialog()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        ' Clear form before each pull to prevent duplication of listings.
        lblListing.Text = String.Empty
        PullData()
    End Sub


End Class
