'Title:         Inter County Transfer Thresholds
'Purpose:       To manage progress reports and thresholds for inter-county transfers
'Created:       10312025
'By:            Shon Garrison
'Last Updated:  10312025
'Version: 1.0

Option Explicit On
Imports System.Globalization

Public Class frmMain

    Private title As String = "Inter County Transfer Thresholds"
    Public Const rdirectory As String = "D:\Temp\Transfers"
    Public Const rfile As String = "D:\Temp\Transfers\ICT_Thresholds.txt"

    '------------------------------ Form Events --------------------------------------------------

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim button As DialogResult

        If Not My.Computer.FileSystem.FileExists(rfile) Then

            button = MessageBox.Show("Thresholds file not found. Create new file?" & vbCrLf &
                                     "Would you like to Create it?",
                                     title, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                     MessageBoxDefaultButton.Button1)

            If button = DialogResult.Yes Then
                frmEntry.ShowDialog()
                Me.Hide()

                'TODO: Add code to create new file and initialize thresholds "PullData()"

            Else
                button = DialogResult.No
                Me.Close()
            End If

        Else

            'TODO: Add code to read existing thresholds file and populate form "PullData()"
            PullData()


        End If

    End Sub

    '------------------------------ Private Subroutines  -----------------------------------------------

    Private Sub PullData()

        Dim myText As String
        Dim newLineIndex As Integer = 0
        Dim entryIndex As Integer = 0
        Dim entry As String
        Dim myEntry As String = Nothing

        myText = My.Computer.FileSystem.ReadAllText(rfile)

        lblListing.Text = myText

        'TODO: Add code for Formatting lblLIsting.Text

    End Sub

End Class
