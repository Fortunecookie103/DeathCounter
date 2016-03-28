Public Class AboutForm

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        MainForm.Location = New Point(Me.Location)
        MainForm.Show()
        Me.Hide()
    End Sub
End Class