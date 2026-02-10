'Title:         Inter County Transfer Thresholds
'Purpose:       To manage progress reports and thresholds for inter-county transfers
'Created:       October 31, 2025
'By:            Shon Garrison
'Last Updated:  February 5, 2026
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

                'TODO: Add code to create new file and initialize thresholds "PullData()"

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
        Dim listing As Integer = 0  ' Counter for each record
        Dim recieve As Integer = 0  ' Counter for receiving County

        For Each sentence As String In mySentence

            If sentence.Contains("/"c) Then

                Dim words() As String = Split(sentence, vbTab)

                For Each word As String In words
                    If word.Length > 0 Then
                        Dim paddedWord As String = word.PadRight(20)
                        sentence = sentence.Replace(word, paddedWord)
                    End If
                Next

                'TODO: Continue formatting once file creation through the application
                'is complete and data is consistent

                If words(1).TrimEnd = "Orange" Then
                    recieve += 1
                End If

                lblListing.Text &= listing.ToString & ".)  " & sentence & vbCrLf
                listing += 1

            End If



        Next

        lblTotalChildren.Text = listing.ToString
        lblTotReceived.Text = recieve.ToString

    End Sub

    '------------------------------ Button Events ----------------------------------------------

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Me.Hide()
        frmEntry.ShowDialog()

    End Sub

    Private Sub brnClose_Click(sender As Object, e As EventArgs) Handles brnClose.Click

        Me.Close()

    End Sub


End Class
