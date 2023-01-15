Imports System.Environment
Imports System.IO
Public Class loading
    Dim files As System.IO.StreamWriter
    Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not System.IO.Directory.Exists(appData + "/NST_Cache") Then
            System.IO.Directory.CreateDirectory(appData + "/NST_Cache")
            files = My.Computer.FileSystem.OpenTextFileWriter(appData + "/NST_Cache/flipit.config", False)
            files.WriteLine("1")
            files.Close()
        End If
        Try
            Dim flipit As String
            flipit = File.ReadAllText(appData + "/NST_Cache/flipit.config")
        Catch ex As Exception
            System.IO.Directory.CreateDirectory(appData + "/NST_Cache")
            files = My.Computer.FileSystem.OpenTextFileWriter(appData + "/NST_Cache/flipit.config", False)
            files.WriteLine("1")
            files.Close()
        End Try
        Dim p() As Process
        p = Process.GetProcessesByName("Non Shitty Teams")
        If p.Count > 1 Then
            files = My.Computer.FileSystem.OpenTextFileWriter(appData + "/NST_Cache/flipit.config", False)
            files.WriteLine("0")
            files.Close()
            End
        Else
            ' Process is not running
        End If
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        Form1.Show()
        Timer1.Stop()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub
End Class