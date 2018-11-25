Imports System.Management
Imports System.IO
Imports System.Net
Imports System.IO.Compression
Imports Shell32
Imports System.Math
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Runtime.ConstrainedExecution
Imports System.Security
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class UpdaterForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Download stuff
        If Not System.IO.File.Exists("C:\Cheat_Name\roblox.wav") Then
            WC.DownloadFileAsync(New Uri("https://your.site/roblox.wav"),
                                         "C:\Cheat_Name\roblox.wav")
            Threading.Thread.Sleep(100)
        ElseIf File.Exists("C:\Cheat_Name\roblox.wav") Then
            Close()
            Cheat_Name.Show()
            Me.Hide()
        End If

        Dim strHostName As String

        Dim strIPAddress As String

        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()

        Label4.Text = "IP:" & strIPAddress & " uwu <3"

    End Sub

    Dim WithEvents WC As New WebClient
    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WC.DownloadProgressChanged
        'For some reason, this shit isnt working
        'I dont fucking know why this isnt working here, and it's working perfectly on my other project xD
        ProgressBar1.Value = e.ProgressPercentage
        If ProgressBar1.Value > 99 Then
            Close()
            Cheat_Name.Show()
            Me.Hide()
        End If
    End Sub

    Dim xpos As Integer
    Dim ypos As Integer
    Dim drag As Boolean
    Dim offSetX As Integer
    Dim offSetY As Integer

    Private Sub topperino_MouseDown(sender As Object, e As MouseEventArgs) Handles topperino.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = True
            xpos = Cursor.Position.X - Me.Left
            ypos = Cursor.Position.Y - Me.Top
        End If
    End Sub
    Private Sub topperino_MouseMove(sender As Object, e As MouseEventArgs) Handles topperino.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - xpos
            Me.Top = Cursor.Position.Y - ypos
        End If
    End Sub
    Private Sub topperino_MouseUp(sender As Object, e As MouseEventArgs) Handles topperino.MouseUp
        drag = False
    End Sub
End Class