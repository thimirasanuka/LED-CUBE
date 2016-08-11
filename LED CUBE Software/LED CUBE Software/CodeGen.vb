Public Class CodeGen

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'For i = 1 To 8
        'For j = 1 To 8
        'For k = 1 To 8
        'TextBox1.Text &= "Private Sub C" & i & j & k & "_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C" & i & j & k & ".CheckedChanged" _
        '   & Environment.NewLine & "If stepChange = false Then CheckChange(" & i & "," & j & "," & k & ", sender" & ")" & Environment.NewLine & _
        '  "End Sub" & Environment.NewLine
        'Next
        'Next
        'Next


        For i = 0 To 7
            For j = 0 To 7
                For k = 0 To 7
                    TextBox1.Text &= "If Integer.Parse(grid2d(" & i & "," & j & ")) \ " & (2 ^ k) & _
                       "Mod 2 = 1 Then C" & j + 1 & i + 1 & k + 1 & ".Checked = True Else C" & _
                    (j + 1 & i + 1 & k + 1 & ".Checked = False" & Environment.NewLine)
                Next
            Next
        Next

        'If Integer.Parse(grid2d(0, 0)) \ 1 Mod 2 = 1 Then C111.Checked = True Else C111.Checked = False
    End Sub
End Class



' Private Sub C111_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles C111.CheckedChanged
'        CheckChange(1, 1, 1)
'    End Sub