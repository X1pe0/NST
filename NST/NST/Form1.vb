Imports Microsoft.VisualBasic.FileIO
Imports CefSharp
Imports CefSharp.WinForms
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Environment
Imports System.Text
Imports System.IO
Public Class Form1
    Dim files As System.IO.StreamWriter
    Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Private Sub frmNotary_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason <> CloseReason.FormOwnerClosing Then
            Me.Hide()
            e.Cancel = True
        End If
    End Sub
    Private Chromium As ChromiumWebBrowser
    Private ReadOnly IDownloadHandler As New Download_Handler
    Sub Form_Load(ByVal Caller As Object, ByVal Arguments As System.EventArgs) Handles MyBase.Load
        Dim Settings = New CefSettings
        Settings.BackgroundColor = Cef.ColorSetARGB(255, 255, 255, 255)
        Settings.CefCommandLineArgs.Add("enable-media-stream", "1")
        Settings.CefCommandLineArgs.Add("disable-web-security", "1")
        Settings.CefCommandLineArgs.Add("allow-file-access-from-files", "1")
        Settings.CefCommandLineArgs.Add("allow-universal-access-from-files", "1")
        Settings.CefCommandLineArgs.Add("file-access-from-urls", "1")
        Settings.CefCommandLineArgs.Add("fake-ui-for-media-stream", "1")
        Settings.CachePath = System.Windows.Forms.Application.UserAppDataPath
        CefSharp.Cef.Initialize(Settings)

        Chromium = New ChromiumWebBrowser("https://teams.microsoft.com") With {.DownloadHandler = IDownloadHandler, .Dock = DockStyle.Fill}

        Controls.Add(Chromium)
    End Sub
    Public Class Download_Handler
        Implements IDownloadHandler
        Public Sub Before(Chromium As IWebBrowser, Browser As IBrowser, Item As DownloadItem, Callback As IBeforeDownloadCallback) Implements IDownloadHandler.OnBeforeDownload
            If Not Callback.IsDisposed Then Callback.Continue(IO.Path.Combine(SpecialDirectories.MyDocuments, Item.SuggestedFileName), False)
            Process.Start("explorer.exe", "/select," + IO.Path.Combine(SpecialDirectories.MyDocuments, Item.SuggestedFileName))
        End Sub
        Public Sub Updated(Chromium As IWebBrowser, Browser As IBrowser, Item As DownloadItem, Callback As IDownloadItemCallback) Implements IDownloadHandler.OnDownloadUpdated
        End Sub
    End Class
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Chromium.Load("https://outlook.office.com")
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        Chromium.Load("https://teams.microsoft.com")
    End Sub
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.Show()
    End Sub
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        System.Diagnostics.Process.Start("notepad.exe", System.Windows.Forms.Application.UserAppDataPath + "\LOG")
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        About.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim flipit_check As String
        flipit_check = File.ReadAllText(appData + "/NST_Cache/flipit.config").Replace(vbCr, "").Replace(vbLf, "")
        If flipit_check = "0" Then
            files = My.Computer.FileSystem.OpenTextFileWriter(appData + "/NST_Cache/flipit.config", False)
            files.WriteLine("1")
            files.Close()
            Me.Show()

        End If
    End Sub






















    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()

    End Sub
End Class
