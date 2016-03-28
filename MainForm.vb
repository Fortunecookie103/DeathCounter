Public Class MainForm
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

        'If the file deaths.txt exists in the specified directory, delete it, and create a new one with +1 death.
        If My.Computer.FileSystem.FileExists("C:\Users/User/Documents/Deathcounter/Deaths.txt") = True Then
            My.Computer.FileSystem.DeleteFile("C:\Users/User/Documents/Deathcounter/Deaths.txt")

            DeathcounterINVISIBLE.Text = DeathcounterINVISIBLE.Text + 1
            Deaths.Text = DeathcounterINVISIBLE.Text()

            Dim DeathFile As System.IO.StreamWriter
            DeathFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users/User/Documents/Deathcounter/Deaths.txt", True)
            DeathFile.WriteLine(Deaths.Text)
            DeathFile.Close()

        Else
            DeathcounterINVISIBLE.Text = DeathcounterINVISIBLE.Text + 1
            Deaths.Text = DeathcounterINVISIBLE.Text()

            My.Computer.FileSystem.CreateDirectory("C:\Users/User/Documents/Deathcounter")

            Dim DeathFile As System.IO.StreamWriter
            DeathFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users/User/Documents/Deathcounter/Deaths.txt", True)
            DeathFile.WriteLine(Deaths.Text)
            DeathFile.Close()

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

        If Deaths.Text = 0 Then

        Else

            If My.Computer.FileSystem.FileExists("C:\Users/User/Documents/Deathcounter/Deaths.txt") = True Then
                My.Computer.FileSystem.DeleteFile("C:\Users/User/Documents/Deathcounter/Deaths.txt")

                DeathcounterINVISIBLE.Text = DeathcounterINVISIBLE.Text - 1
                Deaths.Text = DeathcounterINVISIBLE.Text()

                Dim DeathFile As System.IO.StreamWriter
                DeathFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users/User/Documents/Deathcounter/Deaths.txt", True)
                DeathFile.WriteLine(Deaths.Text)
                DeathFile.Close()

            Else
                DeathcounterINVISIBLE.Text = DeathcounterINVISIBLE.Text - 1
                Deaths.Text = DeathcounterINVISIBLE.Text()

                My.Computer.FileSystem.CreateDirectory("C:\Users/User/Documents/Deathcounter")

                Dim DeathFile As System.IO.StreamWriter
                DeathFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users/User/Documents/Deathcounter/Deaths.txt", True)
                DeathFile.WriteLine(Deaths.Text)
                DeathFile.Close()

            End If

        End If
    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.FileExists("C:\Users/User/Documents/Deathcounter/Deaths.txt") Then

            Dim ObjReader As New System.IO.StreamReader("C:\Users/User/Documents/Deathcounter/Deaths.txt")

            DeathcounterINVISIBLE.Text = ObjReader.ReadToEnd

            Deaths.Text = DeathcounterINVISIBLE.Text

            ObjReader.Close()

        Else

            My.Computer.FileSystem.CreateDirectory("C:\Users/User/Documents/Deathcounter")

            Dim DeathFile As System.IO.StreamWriter
            DeathFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users/User/Documents/Deathcounter/Deaths.txt", True)
            DeathFile.WriteLine(Deaths.Text)
            DeathFile.Close()

        End If

    End Sub

    Private Sub AboutButton_Click(sender As System.Object, e As System.EventArgs) Handles AboutButton.Click
        AboutForm.Show()
        AboutForm.Location = New Point(Me.Location)
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)

        If MsgBox("Are you sure you want to reset all your deaths?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If My.Computer.FileSystem.FileExists("C:\Users/User/Documents/Deathcounter/Deaths.txt") Then
                My.Computer.FileSystem.DeleteFile("C:\Users/User/Documents/Deathcounter/Deaths.txt")

                My.Computer.FileSystem.CreateDirectory("C:\Users/User/Documents/Deathcounter")

                Dim DeathFile As System.IO.StreamWriter
                DeathFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users/User/Documents/Deathcounter/Deaths.txt", True)
                DeathFile.WriteLine("0")
                DeathFile.Close()

                Dim ObjReader As New System.IO.StreamReader("C:\Users/User/Documents/Deathcounter/Deaths.txt")

                DeathcounterINVISIBLE.Text = ObjReader.ReadToEnd
                Deaths.Text = DeathcounterINVISIBLE.Text
                ObjReader.Close()
            Else
                Dim DeathFile As System.IO.StreamWriter
                DeathFile = My.Computer.FileSystem.OpenTextFileWriter("C:\Users/User/Documents/Deathcounter/Deaths.txt", True)
                DeathFile.WriteLine("0")
                DeathFile.Close()
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        OptionsForm.Show()
        OptionsForm.Location = New Point(Me.Location)
        Me.Hide()

    End Sub
End Class
