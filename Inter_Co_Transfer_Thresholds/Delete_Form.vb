Public Class frmDelete
    Public Const tdirectory As String = "D:\Temp\Transfers"
    Public Const tfile As String = "D:\Temp\Transfers\ICT_Thresholds.txt"
    Dim myText As String = My.Computer.FileSystem.ReadAllText(tfile)
    Dim myLines() As String = Split(myText, vbCrLf)
    Dim LinetoDelete As Integer = 0

    Private Sub frmDelete_Load(sender As Object, e As EventArgs) Handles Me.Load
        txbLastName.Focus()
    End Sub

    Public Sub DeleteRecord()

        For Each line As String In myLines

            If line.Contains(txbLastName.Text) Then

                If LinetoDelete >= 0 And LinetoDelete < line.Count Then
                    MessageBox.Show(line & LinetoDelete.ToString.PadLeft(5))
                    'line.Remove(LinetoDelete)
                End If
                Exit For

            Else
                MessageBox.Show("Name not found.", "Delete Child", MessageBoxButtons.OK)
            End If

            LinetoDelete += 1

        Next

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