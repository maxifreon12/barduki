Imports Cheat_Name.cUsefulFuncs
Imports Cheat_Name.cSDK
Imports Cheat_Name.KeyBinds
Imports WMPLib
Imports System.Management
Imports System.IO
Imports System.Net

Public Class Cheat_Name
    Public Misc_thread As Threading.Thread = New Threading.Thread(AddressOf loop_Misc)
    Public Aimbot_thread As Threading.Thread = New Threading.Thread(AddressOf loop_Aimbot)
    Public Trigger_thread As Threading.Thread = New Threading.Thread(AddressOf loop_triggerbot)
    Public ESP_thread As Threading.Thread = New Threading.Thread(AddressOf loop_esp)
    Public SkinChanger_thread As Threading.Thread = New Threading.Thread(AddressOf loop_SkinChanger)

    Public Sub loop_Misc()
        While True
            If InGame Then
                If Settings.Bhop Then Misc.Bhop()
                If Settings.Noflash Then Misc.Noflash(Settings.NoflashMaxAlpha)
                If Settings.Radar Then Misc.Radar()
            End If
        End While
    End Sub
    Public Sub loop_Aimbot()
        While True
            InGame = Engine.Ingame
            Caption = GetCaption()
            RestartIfCsgoNotValid()
            If InGame And Caption = GameCaption Then
                If Settings.Aimbot Then Aimbot.Aimbot(Settings.AimSpot, Settings.FovRifles, Settings.SmoothRifles, Settings.FovPistols, Settings.SmoothPistols, Settings.FovSnipers, Settings.SmoothSnipers)
            End If

            sleep(1)
        End While
    End Sub
    Public Sub loop_triggerbot()
        While True
            If InGame And Caption = GameCaption Then

                If Settings.Trigger Then Triggerbot.Triggerbot(Settings.TriggerMode)
            End If
        End While
    End Sub
    Public Sub loop_esp()
        While True

            If InGame Then
                pLocalPlayer.ptr = cBasePlayer.LocalPlayer()
                If Settings.ESP Or Settings.clrRender Then ESP.GlowESP(Settings.ESP, Settings.clrRender, Settings.ESPmode)
            End If

            sleep(1)
        End While
    End Sub

    Public Sub loop_SkinChanger()
        While True
            If GetAsyncKeyState(SkinchangerKey) Then Engine.Fullupdate()
            If InGame And Not GetAsyncKeyState(Keys.Tab) Then
                If Settings.SkinChangera Then SkinChanger.sSkinchanger()
            End If

            sleep(1)
        End While
    End Sub

    Public Sub Bhop()
        If GetAsyncKeyState(32) And pLocalPlayer.Velocity > 20 Then
            Dim fflags As Integer = pLocalPlayer.fFlags
            If fflags < 263 And fflags <> 257 Then
                cBasePlayer.ForceJump(4)
            Else
                cBasePlayer.ForceJump(5)
            End If
        End If
    End Sub
    Dim xTo, yTo As Integer
    Private Sub Cheat_Name_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckIfAppIsAllreadyRunning()
        Panel4.Visible = False
        Panel4.Enabled = False

        sleep(1)

        Settings.Load()
        Do Until mem.Setup("csgo")
            sleep(1000)
        Loop

        If GetAsyncKeyState(KeyBinds.UnloadCheat) Then
            Environment.Exit(0)
            Application.Exit()
            Me.Close()
            Close()
        End If

        Settings.Load()
        Timer1.Start()
        TrackBar1.Value = My.Settings.ESPcolorEnemyVis
        TrackBar2.Value = My.Settings.ESPcolorEnemyVisB
        TrackBar3.Value = My.Settings.ESPcolorEnemyVisG
        TrackBar4.Value = My.Settings.ESPcolorEnemyVisR
        TrackBar5.Value = My.Settings.SmoothRifles
        TrackBar6.Value = My.Settings.SmoothSnipers
        TrackBar7.Value = My.Settings.SmoothPistols
        TrackBar8.Value = My.Settings.FovRifles
        TrackBar9.Value = My.Settings.FovSnipers
        TrackBar10.Value = My.Settings.FovPistols
        Show()
        xTo = Width / 2
        yTo = Height / 2

        Dim x As Single = Width / 2
        Dim y As Single = Height / 2

        Dim WC As New WebClient
        If Not System.IO.File.Exists("C:\Cheat_Name\roblox.wav") Then
            WC.DownloadFileAsync(New Uri("https://cdn.discordapp.com/attachments/479129290613456898/485947571454607360/roblox.wav"),
                                         "C:\Cheat_Name\roblox.wav")

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Settings.ESPcolorEnemyVis = TrackBar1.Value
        My.Settings.ESPcolorEnemyVisB = TrackBar2.Value
        My.Settings.ESPcolorEnemyVisG = TrackBar3.Value
        My.Settings.ESPcolorEnemyVisR = TrackBar4.Value
        My.Settings.SmoothRifles = TrackBar5.Value
        My.Settings.SmoothSnipers = TrackBar6.Value
        My.Settings.SmoothPistols = TrackBar7.Value
        My.Settings.FovRifles = TrackBar8.Value
        My.Settings.FovSnipers = TrackBar9.Value
        My.Settings.FovPistols = TrackBar10.Value
        If GetAsyncKeyState(Keys.F6) Then
            If CheckBox1.Checked = True Then
                CheckBox1.Checked = False
            Else
                CheckBox1.Checked = True
            End If
        End If

        Label109.Text = TrackBar8.Value.ToString() + "%"
        Label113.Text = TrackBar5.Value.ToString() + "%"
        Label110.Text = TrackBar9.Value.ToString() + "%"
        Label114.Text = TrackBar6.Value.ToString() + "%"
        Label112.Text = TrackBar7.Value.ToString() + "%"
        Label111.Text = TrackBar10.Value.ToString() + "%"

        If Panel1.Visible = True Then
            Panel2.BackColor = Color.Brown
            Panel3.BackColor = Color.SlateGray
        ElseIf Panel4.Visible = True Then
            Panel3.BackColor = Color.Brown
            Panel2.BackColor = Color.SlateGray
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Settings.Load()
    End Sub
    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Settings.Load()
    End Sub
    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        Settings.Load()
    End Sub
    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        Settings.Load()
    End Sub
    Private Sub TrackBar5_Scroll(sender As Object, e As EventArgs) Handles TrackBar5.Scroll
        Settings.Load()
    End Sub
    Private Sub TrackBar6_Scroll(sender As Object, e As EventArgs) Handles TrackBar6.Scroll
        Settings.Load()
    End Sub
    Private Sub TrackBar7_Scroll(sender As Object, e As EventArgs) Handles TrackBar7.Scroll
        Settings.Load()
    End Sub
    Private Sub TrackBar8_Scroll(sender As Object, e As EventArgs) Handles TrackBar8.Scroll
        Settings.Load()
    End Sub
    Private Sub TrackBar9_Scroll(sender As Object, e As EventArgs) Handles TrackBar9.Scroll
        Settings.Load()
    End Sub
    Private Sub TrackBar10_Scroll(sender As Object, e As EventArgs) Handles TrackBar10.Scroll
        Settings.Load()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Panel4.Visible = False
        Panel4.Enabled = False
        Panel1.Visible = True
        Panel1.Enabled = True
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            If ESP_thread.IsAlive Then
                ESP_thread.Resume()
            Else
                ESP_thread.Start()
            End If
        Else
            ESP_thread.Suspend()
        End If
    End Sub
    Private Sub Checkbox1_Click_1(sender As Object, e As EventArgs) Handles CheckBox1.Click
        My.Computer.Audio.Play("C:\Cheat_Name\roblox.wav", AudioPlayMode.Background)
    End Sub
    Private Sub Checkbox2_Click_1(sender As Object, e As EventArgs) Handles CheckBox2.Click
        My.Computer.Audio.Play("C:\Cheat_Name\roblox.wav", AudioPlayMode.Background)
    End Sub
    Private Sub Checkbox3_Click_1(sender As Object, e As EventArgs) Handles CheckBox3.Click
        My.Computer.Audio.Play("C:\Cheat_Name\roblox.wav", AudioPlayMode.Background)
    End Sub
    Private Sub Checkbox4_Click_1(sender As Object, e As EventArgs) Handles CheckBox4.Click
        My.Computer.Audio.Play("C:\Cheat_Name\roblox.wav", AudioPlayMode.Background)
    End Sub
    Private Sub Checkbox5_Click_1(sender As Object, e As EventArgs) Handles CheckBox5.Click
        My.Computer.Audio.Play("C:\Cheat_Name\roblox.wav", AudioPlayMode.Background)
    End Sub


    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then

            If Trigger_thread.IsAlive Then
                Trigger_thread.Resume()
            Else
                Trigger_thread.Start()
            End If
        Else
            Trigger_thread.Suspend()
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then

            If Aimbot_thread.IsAlive Then
                Aimbot_thread.Resume()
            Else
                Aimbot_thread.Start()
            End If
        Else
            Aimbot_thread.Suspend()
        End If
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then

            If SkinChanger_thread.IsAlive Then
                SkinChanger_thread.Resume()
            Else
                SkinChanger_thread.Start()
            End If
        Else
            SkinChanger_thread.Suspend()
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then

            If Misc_thread.IsAlive Then
                Misc_thread.Resume()
            Else
                Misc_thread.Start()
            End If
        Else
            Misc_thread.Suspend()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
        Panel1.Enabled = False
        Panel4.Visible = True
        Panel4.Enabled = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        My.Settings.Save()
        Me.Close()
        Close()
        Aimbot_thread.Abort()
        ESP_thread.Abort()
        SkinchangerForm.Close()
        SkinList.Close()
        Application.Exit()
        Environment.Exit(0)
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

    Private Sub Label33_Click(sender As Object, e As EventArgs) Handles Label33.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs)
        Process.Start("C:\Cheat_Name")
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        SkinchangerForm.Show()
    End Sub
End Class