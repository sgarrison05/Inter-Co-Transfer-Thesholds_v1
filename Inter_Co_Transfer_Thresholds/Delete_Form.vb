Public Class frmDelete
    Public Const tdirectory As String = "D:\Temp\Transfers"
    Public Const tfile As String = "D:\Temp\Transfers\ICT_Thresholds.txt"
    Dim lines As New List(Of String)()
    Dim LinetoDelete As Integer = 0

    Private Sub frmDelete_Load(sender As Object, e As EventArgs) Handles Me.Load
        txbLastName.Focus()
    End Sub

    Public Sub DeleteRecord()

        FileOpen(1, tfile, OpenMode.Input)
        While Not EOF(1)
            Dim line As String = LineInput(1)
            lines.Add(line)

            If lines.Contains(txbLastName.Text) Then
                Exit While
            End If

            LinetoDelete += 1

        End While
        FileClose(1)

        If LinetoDelete >= 0 And LinetoDelete < lines.Count Then
            lines.RemoveAt(LinetoDelete)
        End If

        FileOpen(1, tfile, OpenMode.Output)
        For Each line In lines
            PrintLine(1, line)
        Next
        FileClose(1)

    End Sub

    Public Sub CleanForm()
        txbLastName.Clear()
        txbLastName.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        DeleteRecord()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        CleanForm()
        txbLastName.Focus()

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        CleanForm()
        Me.Close()
        frmMain.Show()

    End Sub

End Class