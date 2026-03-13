Public Class frmSearch

    Public Const tdirectory As String = "D:\Temp\Transfers"
    Public Const tfile As String = "D:\Temp\Transfers\ICT_Thresholds.txt"
    Dim myText As String = My.Computer.FileSystem.ReadAllText(tfile)
    Dim mySentence() As String = Split(myText, vbCrLf)
    Dim display As String

    Public Sub FillLabel()

        For Each sentence As String In mySentence
            If sentence.Contains(txbLastName.Text) Then

                Dim words() As String = Split(sentence, vbTab)

                'Put the words back together with padding for display on form
                For i = 0 To words.Length - 1
                    If words(i).Length > 0 Then
                        display = String.Join(" ".PadRight(5), words(0) & words(3) &
                                              words(4) & words(6))
                    End If
                Next
                Exit For
            Else
                display = "Name not found."
            End If
        Next

        lblDisplay.Text = display.ToString

    End Sub

    Private Sub CleanForm()
        txbLastName.Clear()
        lblDisplay.Text = String.Empty
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        CleanForm()
        Me.Close()
        frmMain.Show()

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        FillLabel()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        CleanForm()
        txbLastName.Focus()

    End Sub

End Class