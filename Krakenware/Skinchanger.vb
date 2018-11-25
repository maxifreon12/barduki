Imports System.Management
Imports System.IO
Imports System.Net
Imports Cheat_Name.cSkinchanger
Imports Cheat_Name.cSDK

'i didnt find some code for make the skinchanger work without restarting all the cheat and saving my.settings pBrain
'If there arent some weapons, add them yourself.
Public Class SkinchangerForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm()
        Refresh()
        Settings.Load()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AK47_TextChanged(sender As Object, e As EventArgs) Handles AK47.TextChanged
        Try
            Dim AK47SKIN As Integer = Integer.Parse(AK47.Text)
            My.Settings.AK47 = AK47SKIN
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        My.Settings.Save()
        Me.Close()
        SkinList.Close()
    End Sub
    Function LoadForm()
        AK47.Text = My.Settings.AK47
        M4A1S.Text = My.Settings.M4A1
        M4A4.Text = My.Settings.M4A4
        GALIL.Text = My.Settings.Galil
        AUG.Text = My.Settings.Aug
        SG350.Text = My.Settings.Sg350
        FAMAS.Text = My.Settings.Famas
        AWP.Text = My.Settings.Awp
        SCOUT.Text = My.Settings.Scout
        TECOTT.Text = My.Settings.Tecott
        SCAR20.Text = My.Settings.Tecoct
        XMS.Text = My.Settings.Xms
        BIZON.Text = My.Settings.Bizon
        TEC9.Text = My.Settings.Tec9
        DEAGLE.Text = My.Settings.Deagle
        GLOCK.Text = My.Settings.Glock
        USP.Text = My.Settings.Usp
        REVOLVER.Text = My.Settings.Revolver
        CZ.Text = My.Settings.Cz
        P250.Text = My.Settings.P250
        FIVESEVEN.Text = My.Settings.FiveSeven

    End Function

    Private Sub M4A1_TextChanged(sender As Object, e As EventArgs) Handles M4A4.TextChanged
        Try
            Dim M4A1Skin As Integer = Integer.Parse(M4A4.Text)
            My.Settings.M4A1 = M4A1Skin
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub M4A1S_TextChanged(sender As Object, e As EventArgs) Handles M4A1S.TextChanged
        Try
            Dim M4A1SS As Integer = Integer.Parse(M4A1S.Text)
            My.Settings.M4A4 = M4A1SS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub GALIL_TextChanged(sender As Object, e As EventArgs) Handles GALIL.TextChanged
        Try
            Dim GALS As Integer = Integer.Parse(GALIL.Text)
            My.Settings.Galil = GALS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub AUG_TextChanged(sender As Object, e As EventArgs) Handles AUG.TextChanged
        Try
            Dim AUGS As Integer = Integer.Parse(AUG.Text)
            My.Settings.Aug = AUGS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub SG350_TextChanged(sender As Object, e As EventArgs) Handles SG350.TextChanged
        Try
            Dim SGS As Integer = Integer.Parse(SG350.Text)
            My.Settings.SG350 = SGS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub FAMAS_TextChanged(sender As Object, e As EventArgs) Handles FAMAS.TextChanged
        Try
            Dim FS As Integer = Integer.Parse(FAMAS.Text)
            My.Settings.Famas = FS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub AWP_TextChanged(sender As Object, e As EventArgs) Handles AWP.TextChanged
        Try
            Dim ASS As Integer = Integer.Parse(AWP.Text)
            My.Settings.Awp = ASS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub SCOUT_TextChanged(sender As Object, e As EventArgs) Handles SCOUT.TextChanged
        Try
            Dim SCS As Integer = Integer.Parse(SCOUT.Text)
            My.Settings.Scout = SCS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub SCAR20_TextChanged(sender As Object, e As EventArgs) Handles SCAR20.TextChanged
        Try
            Dim SCAS As Integer = Integer.Parse(SCAR20.Text)
            My.Settings.Tecoct = SCAS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub TECOTT_TextChanged(sender As Object, e As EventArgs) Handles TECOTT.TextChanged
        Try
            Dim TCS As Integer = Integer.Parse(TECOTT.Text)
            My.Settings.Tecott = TCS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub XMS_TextChanged(sender As Object, e As EventArgs) Handles XMS.TextChanged
        Try
            Dim XS As Integer = Integer.Parse(XMS.Text)
            My.Settings.Xms = XS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub BIZON_TextChanged(sender As Object, e As EventArgs) Handles BIZON.TextChanged
        Try
            Dim BS As Integer = Integer.Parse(BIZON.Text)
            My.Settings.Bizon = BS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub TEC9_TextChanged(sender As Object, e As EventArgs) Handles TEC9.TextChanged
        Try
            Dim TS As Integer = Integer.Parse(TEC9.Text)
            My.Settings.Tec9 = TS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub DEAGLE_TextChanged(sender As Object, e As EventArgs) Handles DEAGLE.TextChanged
        Try
            Dim DS As Integer = Integer.Parse(DEAGLE.Text)
            My.Settings.Deagle = DS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub GLOCK_TextChanged(sender As Object, e As EventArgs) Handles GLOCK.TextChanged
        Try
            Dim GS As Integer = Integer.Parse(GLOCK.Text)
            My.Settings.Glock = GS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub USP_TextChanged(sender As Object, e As EventArgs) Handles USP.TextChanged
        Try
            Dim US As Integer = Integer.Parse(USP.Text)
            My.Settings.Usp = US
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub REVOLVER_TextChanged(sender As Object, e As EventArgs) Handles REVOLVER.TextChanged
        Try
            Dim RS As Integer = Integer.Parse(REVOLVER.Text)
            My.Settings.Revolver = RS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub CZ_TextChanged(sender As Object, e As EventArgs) Handles CZ.TextChanged
        Try
            Dim CS As Integer = Integer.Parse(CZ.Text)
            My.Settings.Cz = CS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub P250_TextChanged(sender As Object, e As EventArgs) Handles P250.TextChanged
        Try
            Dim PS As Integer = Integer.Parse(P250.Text)
            My.Settings.P250 = PS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub FIVESEVEN_TextChanged(sender As Object, e As EventArgs) Handles FIVESEVEN.TextChanged
        Try
            Dim FSS As Integer = Integer.Parse(FIVESEVEN.Text)
            My.Settings.FiveSeven = FSS
        Catch
        End Try
        My.Settings.Save()
        Settings.Load()
    End Sub

    Public Function Restart()
        Application.Restart()
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadForm()
        My.Settings.Save()
        Me.Refresh()
        If Restart() Then
            Cheat_Name.Refresh()
            Settings.Load()
            Cheat_Name.Show()
        End If
    End Sub

    Dim xpos As Integer
    Dim ypos As Integer
    Dim drag As Boolean
    Dim offSetX As Integer
    Dim offSetY As Integer
    Private Sub topperino_MouseDown(sender As Object, e As MouseEventArgs) Handles Topperino.MouseDown
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

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Settings.Load()
        My.Settings.Save()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        SkinList.Show()
    End Sub
End Class
