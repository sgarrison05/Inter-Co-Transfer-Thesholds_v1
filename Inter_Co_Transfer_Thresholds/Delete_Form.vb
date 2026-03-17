Imports System.IO
Imports System.Text

Public Class frmDelete
    Public Const tdirectory As String = "D:\Temp\Transfers"
    Public Const tfile As String = "D:\Temp\Transfers\ICT_Thresholds.txt"


    Private Sub frmDelete_Load(sender As Object, e As EventArgs) Handles Me.Load
        txbLastName.Focus()
    End Sub

    Private Sub DeleteRecord(filepath As String, name As String)

        Dim tempPath = Path.Combine(Path.GetDirectoryName(filepath),
                        Path.GetFileNameWithoutExtension(filepath) & ".tmp" &
                        Path.GetExtension(filepath))

        Dim readtxt As String
        Dim entry As String
        Dim newLineIndex As Integer = 0
        Dim entryIndex As Integer = 0

        If My.Computer.FileSystem.FileExists(filepath) Then

            readtxt = File.ReadAllText(filepath)

            'Primer for first red of readtext
            newLineIndex = readtxt.IndexOf(ControlChars.NewLine, entryIndex)

            Do Until newLineIndex = -1

                'get each line (don't forget about the new line character " + 1")
                entry = readtxt.Substring(entryIndex, (newLineIndex - entryIndex) + 1)

                'finds line with name and skips it
                If entry.Contains(name) Then

                    MessageBox.Show("Record deleted.")

                    entryIndex = newLineIndex + 1
                    newLineIndex = readtxt.IndexOf(ControlChars.NewLine, entryIndex)

                Else

                    'if not found writes line to temp file and moves on
                    My.Computer.FileSystem.WriteAllText(tempPath, entry, True)

                    entryIndex = newLineIndex + 1
                    newLineIndex = readtxt.IndexOf(ControlChars.NewLine, entryIndex)

                End If

            Loop

            'Deletes original file and renames temp file to original name
            File.Delete(filepath)
            File.Move(tempPath, filepath)

        Else

            MessageBox.Show("File does not exist.")

        End If

    End Sub

    Public Sub CleanForm()
        txbLastName.Clear()
        txbLastName.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim lastName As String = txbLastName.Text.Trim()
        DeleteRecord(tfile, lastName)
        CleanForm()


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        CleanForm()
        txbLastName.Focus()

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        CleanForm()
        Me.Close()
        frmMain.Show()
        frmMain.btnRefresh.PerformClick()

    End Sub

End Class