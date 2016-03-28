Public Class OptionsForm

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If MsgBox("Are you sure you want to reset all your deaths?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If My.Computer.FileSystem.FileExists("C:\Users/User/Documents/Deathcounter/Deaths.txt") Then
                My.Computer.FileSystem.DeleteFile("C:\Users/User/Documents/Deathcounter/Deaths.txt")

                My.Computer.FileSystem.CreateDirectory("C:\Users/User/Documents/Deathcounter")

                Dim DeathFile As System.IO.StreamWriter
                DeathFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users/User/Documents/Deathcounter/Deaths.txt", True)
                DeathFile.WriteLine("0")
                DeathFile.Close()

                Dim ObjReader As New System.IO.StreamReader("C:\Users/User/Documents/Deathcounter/Deaths.txt")

                MainForm.DeathcounterINVISIBLE.Text = ObjReader.ReadToEnd
                MainForm.Deaths.Text = MainForm.DeathcounterINVISIBLE.Text
                ObjReader.Close()

            Else
                Dim DeathFile As System.IO.StreamWriter
                DeathFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users/User/Documents/Deathcounter/Deaths.txt", True)
                DeathFile.WriteLine("0")
                DeathFile.Close()
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        MainForm.Location = New Point(Me.Location)
        MainForm.Show()
        Me.Hide()

    End Sub
End Class