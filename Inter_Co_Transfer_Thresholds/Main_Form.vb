'Title:         Inter County Transfer Thresholds
'Purpose:       To manage progress reports and thresholds for inter-county transfers
'Created:       October 31, 2025
'By:            Shon Garrison
'Last Updated:  March 2026
'Version: 1.0

Option Explicit On
Imports System.Globalization

Imports System.IO
Imports System.Text
Imports System.Windows

Public Class frmMain

    Private title As String = "Inter County Transfer Thresholds"
    Public Shared ReadOnly tdirectory As String = Path.Combine("D:\Temp", "Transfers")
    Public Shared ReadOnly tfile As String = Path.Combine(tdirectory, "ICT_Thresholds.txt")

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
                Using f As New frmEntry()
                    f.ShowDialog()
                End Using
            Else
                Me.Close()
            End If
        Else

            PullData()

        End If
    End Sub

    '------------------------------ Private Subroutines  ---------------------------------------

    Private Sub PullData()
        Try
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

                    Dim words() = Split(sentence, vbTab)

                    'Extract two dates to compute refresh on data pull
                    dteICTThresh = CDate(words(6).TrimEnd)
                    dteProgRptThresh = CDate(words(7).TrimEnd)

                    'get updated days remaining in progress report and program
                    Dim progRptDaysRefresh As Integer = dteProgRptThresh.Subtract(Date.Now).Days
                    Dim ictDaysRefresh As Integer = dteICTThresh.Subtract(Date.Now).Days

                    'inject refreshed days remaining into the appropriate array index for display on form
                    words(8) = progRptDaysRefresh.ToString.PadLeft(3) & " days"
                    words(9) = ictDaysRefresh.ToString.PadLeft(3) & " days"

                    'Put the words back together with padding for display on form

                    display = String.Join(" ".PadRight(5), words)

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

            lblTotalChildren.Text = (listing - 1).ToString
            lblTotReceived.Text = recieve.ToString
            lblTotSent.Text = sent.ToString

        Catch ex As Exception
            MessageBox.Show("An error occurred while pulling data: " &
                            ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    '------------------------------ Button Events ----------------------------------------------

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Hide()
        Using f As New frmEntry()
            f.ShowDialog()
        End Using

    End Sub

    Private Sub brnClose_Click(sender As Object, e As EventArgs) Handles brnClose.Click

        Me.Close()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Hide()
        Using f As New frmSearch()
            f.ShowDialog()
        End Using

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        ' Clear form before each pull to prevent duplication of listings.
        lblListing.Text = String.Empty
        PullData()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.Hide()
        Using f As New frmDelete()
            f.ShowDialog()
        End Using
    End Sub
End Class
