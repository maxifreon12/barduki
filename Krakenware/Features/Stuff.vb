Imports Cheat_Name.cSDK
Imports Cheat_Name.Offsets
Imports Cheat_Name.ENUMS
Imports System.Math
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Runtime.ConstrainedExecution
Imports System.Security
Imports System.Globalization
Imports System.Text.RegularExpressions
Imports Cheat_Name

#Region "Offsets-Settings"
Public Class Offsets

    Public Shared m_bDormant = &HE9
    Public Shared m_clrRender = &H70
    Public Shared m_dwInGame = &H108
    Public Shared m_nModelIndex = &H254
    Public Shared m_hViewModel = &H32DC
    Public Shared m_iWorldModelIndex = &H31E4
    Public Shared m_szArmsModel = &H38F3
    Public Shared m_iObserverMode = &H334C

    'Just use hazedumper and delete the repeated offsets, which are: m_clrRender and m_iObserverMode
    Public Const m_ArmorValue As Integer = &HB270
    Public Const m_Collision As Integer = &H318
    Public Const m_CollisionGroup As Integer = &H470
    Public Const m_Local As Integer = &H2FAC
    Public Const m_MoveType As Integer = &H258
    Public Const m_OriginalOwnerXuidHigh As Integer = &H31A4
    Public Const m_OriginalOwnerXuidLow As Integer = &H31A0
    Public Const m_aimPunchAngle As Integer = &H301C
    Public Const m_aimPunchAngleVel As Integer = &H3028
    Public Const m_bGunGameImmunity As Integer = &H38C0
    Public Const m_bHasDefuser As Integer = &HB280
    Public Const m_bHasHelmet As Integer = &HB264
    Public Const m_bInReload As Integer = &H3275
    Public Const m_bIsDefusing As Integer = &H38B4
    Public Const m_bIsScoped As Integer = &H38AA
    Public Const m_bSpotted As Integer = &H939
    Public Const m_bSpottedByMask As Integer = &H97C
    Public Const m_dwBoneMatrix As Integer = &H2698
    Public Const m_fAccuracyPenalty As Integer = &H32E0
    Public Const m_fFlags As Integer = &H100
    Public Const m_flC4Blow As Integer = &H2980
    Public Const m_flDefuseCountDown As Integer = &H2998
    Public Const m_flDefuseLength As Integer = &H2994
    Public Const m_flFallbackWear As Integer = &H31B0
    Public Const m_flFlashDuration As Integer = &HA32C
    Public Const m_flFlashMaxAlpha As Integer = &HA328
    Public Const m_flNextPrimaryAttack As Integer = &H3208
    Public Const m_flTimerLength As Integer = &H2984
    Public Const m_hActiveWeapon As Integer = &H2EE8
    Public Const m_hMyWeapons As Integer = &H2DE8
    Public Const m_hObserverTarget As Integer = &H3360
    Public Const m_hOwner As Integer = &H29BC
    Public Const m_hOwnerEntity As Integer = &H148
    Public Const m_iAccountID As Integer = &H2FB8
    Public Const m_iClip1 As Integer = &H3234
    Public Const m_iCompetitiveRanking As Integer = &H1A84
    Public Const m_iCompetitiveWins As Integer = &H1B88
    Public Const m_iCrosshairId As Integer = &HB2DC
    Public Const m_iEntityQuality As Integer = &H2F9C
    Public Const m_iFOVStart As Integer = &H31D8
    Public Const m_iGlowIndex As Integer = &HA344
    Public Const m_iHealth As Integer = &HFC
    Public Const m_iItemDefinitionIndex As Integer = &H2F9A
    Public Const m_iItemIDHigh As Integer = &H2FB0
    Public Const m_iShotsFired As Integer = &HA2E0
    Public Const m_iState As Integer = &H3228
    Public Const m_iTeamNum As Integer = &HF0
    Public Const m_lifeState As Integer = &H25B
    Public Const m_nFallbackPaintKit As Integer = &H31A8
    Public Const m_nFallbackSeed As Integer = &H31AC
    Public Const m_nFallbackStatTrak As Integer = &H31B4
    Public Const m_nForceBone As Integer = &H267C
    Public Const m_nTickBase As Integer = &H3404
    Public Const m_rgflCoordinateFrame As Integer = &H440
    Public Const m_szCustomName As Integer = &H302C
    Public Const m_szLastPlaceName As Integer = &H3588
    Public Const m_thirdPersonViewAngles As Integer = &H31C8
    Public Const m_vecOrigin As Integer = &H134
    Public Const m_vecVelocity As Integer = &H110
    Public Const m_vecViewOffset As Integer = &H104
    Public Const m_viewPunchAngle As Integer = &H3010
    Public Const clientstate_choked_commands As Integer = &H4CB0
    Public Const clientstate_delta_ticks As Integer = &H174
    Public Const clientstate_last_outgoing_command As Integer = &H4CAC
    Public Const clientstate_net_channel As Integer = &H9C
    Public Const convar_name_hash_table As Integer = &H2F0F8
    Public Const dwClientState As Integer = &H588B34
    Public Const dwClientState_GetLocalPlayer As Integer = &H180
    Public Const dwClientState_IsHLTV As Integer = &H4CC8
    Public Const dwClientState_Map As Integer = &H28C
    Public Const dwClientState_MapDirectory As Integer = &H188
    Public Const dwClientState_MaxPlayer As Integer = &H310
    Public Const dwClientState_PlayerInfo As Integer = &H5240
    Public Const dwClientState_State As Integer = &H108
    Public Const dwClientState_ViewAngles As Integer = &H4D10
    Public Const dwEntityList As Integer = &H4C40664
    Public Const dwForceAttack As Integer = &H3081D40
    Public Const dwForceAttack2 As Integer = &H3081D4C
    Public Const dwForceBackward As Integer = &H3081D94
    Public Const dwForceForward As Integer = &H3081D70
    Public Const dwForceJump As Integer = &H50E33AC
    Public Const dwForceLeft As Integer = &H3081D88
    Public Const dwForceRight As Integer = &H3081DAC
    Public Const dwGameDir As Integer = &H626C70
    Public Const dwGameRulesProxy As Integer = &H51556F4
    Public Const dwGetAllClasses As Integer = &HC8548C
    Public Const dwGlobalVars As Integer = &H588838
    Public Const dwGlowObjectManager As Integer = &H517F940
    Public Const dwInput As Integer = &H508B320
    Public Const dwInterfaceLinkList As Integer = &H85B634
    Public Const dwLocalPlayer As Integer = &HC638AC
    Public Const dwMouseEnable As Integer = &HC69278
    Public Const dwMouseEnablePtr As Integer = &HC69248
    Public Const dwPlayerResource As Integer = &H30800DC
    Public Const dwRadarBase As Integer = &H507534C
    Public Const dwSensitivity As Integer = &HC69114
    Public Const dwSensitivityPtr As Integer = &HC690E8
    Public Const dwSetClanTag As Integer = &H88AD0
    Public Const dwViewMatrix As Integer = &H4C32094
    Public Const dwWeaponTable As Integer = &H508BDBC
    Public Const dwWeaponTableIndex As Integer = &H322C
    Public Const dwYawPtr As Integer = &HC68ED8
    Public Const dwZoomSensitivityRatioPtr As Integer = &HC6DF98
    Public Const dwbSendPackets As Integer = &HD0FDA
    Public Const dwppDirect3DDevice9 As Integer = &HA2F20
    Public Const interface_engine_cvar As Integer = &H3E9EC
    Public Const m_pStudioHdr As Integer = &H293C
    Public Const m_pitchClassPtr As Integer = &H50755F8
    Public Const m_yawClassPtr As Integer = &HC68ED8


End Class

Public Class cSettings

    Public Aimbot As Boolean = True
    Public AimSpot As Integer = 8
    Public FovRifles As Integer = 200
    Public SmoothRifles As Integer = 200
    Public FovPistols As Integer = 200
    Public SmoothPistols As Integer = 200
    Public FovSnipers As Integer = 200
    Public SmoothSnipers As Integer = 200
    Public RangeBased As Boolean = True
    Public ESP As Boolean = True
    Public ESPmode As Integer = 1
    Public ESPcolorEnemyVis As cConfig.RGBA
    Public ESPcolorEnemy As cConfig.RGBA
    Public ESPcolorTeammate As cConfig.RGBA
    Public ESPcolorWeapons As cConfig.RGBA
    Public ESPcolorGrenades As cConfig.RGBA
    Public ESPcolorBomb As cConfig.RGBA
    Public clrRender As Boolean = False
    Public Trigger As Boolean = True
    Public TriggerMode As Integer = 1
    Public Bhop As Boolean = True
    Public Radar As Boolean = True
    Public Noflash As Boolean = True
    Public NoflashMaxAlpha As Integer = 50
    Public SkinChangera As Boolean = True
    Public Active As Boolean = True


    Public Function Load()
        Try

            AimSpot = cfg.read("AIMBOT", "AimSpot")
            Bhop = cfg.read("MISC", "Bhop")
            Radar = cfg.read("MISC", "Radar")
            Noflash = cfg.read("MISC", "Noflash")
            KeyBinds.AimbotKey = cfg.read("KEYS", "Aimbot")
            KeyBinds.TriggerKey = cfg.read("KEYS", "Trigger")
            KeyBinds.SkinchangerKey = cfg.read("KEYS", "Skinchanger")
            KeyBinds.UnloadCheat = cfg.read("KEYS", "Unload Cheat")

            cSkinchanger.sDEAGLE = My.Settings.Deagle
            cSkinchanger.sM4A1 = My.Settings.M4A1
            cSkinchanger.sAK47 = My.Settings.AK47
            cSkinchanger.sAWP = My.Settings.Awp
            cSkinchanger.sUSP = My.Settings.Usp


        Catch ex As Exception
            cUsefulFuncs.wl(ex.ToString)
        End Try
#Disable Warning BC42105
    End Function
#Enable Warning BC42105
End Class
#End Region

#Region "Stuff"

Public Class cBasePlayer
    Public ptr As Integer

    Public Sub New(Pointer As Integer)
        ptr = Pointer
    End Sub

    Public Shared Function LocalPlayer() As Integer
        Return mem.rdInt(mem.ClientpanoramaDLL + dwLocalPlayer)
    End Function

    Public Shared Function PointerByIndex(Index As Integer) As Integer
        Return mem.rdInt(mem.ClientpanoramaDLL + dwEntityList + ((Index - 1) * 16))
    End Function

    Public Function Health() As Integer
        Return mem.rdInt(ptr + m_iHealth)
    End Function

    Public Function fFlags() As Integer
        Return mem.rdInt(ptr + m_fFlags)
    End Function

    Public Function Team() As Integer
        Return mem.rdInt(ptr + m_iTeamNum)
    End Function

    Public Function Dormant() As Boolean
        Return mem.rdInt(ptr + m_bDormant)
    End Function

    Public Function FlashDuration() As Integer
        Return mem.rdFloat(ptr + m_flFlashDuration)
    End Function

    Public Function FlashMaxAlpha() As Integer
        Return mem.rdInt(ptr + m_flFlashMaxAlpha)
    End Function

    Public Function OriginVec() As Vec3
        Return mem.ReadMemory(Of Vec3)(ptr + m_vecOrigin)
    End Function

    Public Function PunchAngle() As Vec3
        Return mem.ReadMemory(Of Vec3)(ptr + m_aimPunchAngle)
    End Function

    Public Function ViewOffset() As Vec3
        Return mem.ReadMemory(Of Vec3)(ptr + m_vecViewOffset)
    End Function

    Public Function Spotted() As Boolean
        Return mem.rdInt(ptr + m_bSpotted)
    End Function

    Public Function ShotsFired() As Integer
        Return mem.rdInt(ptr + m_iShotsFired)
    End Function

    Public Function IncrossIndex()
        Return mem.rdInt(ptr + m_iCrosshairId)
    End Function

    Public Function Name(Index As Integer) As String
        Dim RadarBase As Integer = mem.rdInt(mem.ClientpanoramaDLL + dwRadarBase)
        Dim Radar As Integer = mem.rdInt(RadarBase + &H20)
        Dim sName As String = mem.rdString(Radar + (&H1EC * (Index) + &H3C))
        Return sName
    End Function

    Public Function Wins(Index As Integer) As Integer
        Dim GameResources As Integer = mem.rdInt(mem.ClientpanoramaDLL + dwPlayerResource)
        Return mem.rdInt(GameResources + m_iCompetitiveWins + (Index * 4))
    End Function

    Public Ranks As String() = {"Unranked", "Silver I", "Silver II", "Silver III", "Silver IV", "Silver Elite", "Silver Elite Master", "Gold Nova I", "Gold Nova II", "Gold Nova III", "Gold Nova Elite", "Master Guardian I", "Master Guardian II", "Master Guardian Elite", "Distinguished Master Guardian", "Legendary Eagle", "Legendary Eagle Master", "Supreme Master First Class", "The Global Elite"}

    Public Function Rank(Index As Integer) As String
        Dim GameResources As Integer = mem.rdInt(mem.ClientpanoramaDLL + dwPlayerResource)
        Dim r As Integer = mem.rdInt(GameResources + m_iCompetitiveRanking + (Index * 4))
        If r <= Ranks.Length Then Return Ranks(r) Else Return "Error"
    End Function

    Public Function isJumping() As Boolean
        Dim fflags As Integer = mem.rdInt(ptr + m_fFlags)
        If fflags = 770 Or fflags = 774 Then Return True Else Return False
    End Function

    Public Function Immune() As Boolean
        Return mem.rdInt(ptr + m_bGunGameImmunity)
    End Function

    Public Function SpottedByMask() As Boolean
        Try
            Dim y As String = cUsefulFuncs.ConvertToBinary(mem.rdInt(ptr + m_bSpottedByMask), 30)
            Dim x As Char = y(y.Count - mem.rdInt(LocalPlayer() + &H64))
            If x = "1" Then Return True Else Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function BonePosition(BoneID As Integer) As Vec3
        Dim BoneMatrix As Integer = mem.rdInt(ptr + m_dwBoneMatrix)
        Dim buffer As Byte() = New Byte(36) {}
        buffer = mem.rdMem(BoneMatrix + &H30 * BoneID + &HC, 36)
        Return New Vec3(BitConverter.ToSingle(buffer, 0), BitConverter.ToSingle(buffer, 16), BitConverter.ToSingle(buffer, 32))
    End Function

    Public Function ActiveWeapon() As cBaseWeapon
        Dim WeaponIndex As Integer = mem.rdInt(ptr + m_hActiveWeapon) And &HFFFF
        Return New cBaseWeapon(mem.rdInt(mem.ClientpanoramaDLL + dwEntityList + (WeaponIndex - 1) * &H10))
    End Function


    Public Function Velocity() As Single
        Return mem.ReadMemory(Of Vec3)(LocalPlayer() + m_vecVelocity).Length
    End Function

    Public Sub Glow(Glow_r As Single, Glow_g As Single, Glow_b As Single, Glow_a As Single, Glow_rwo As Boolean, Glow_rwuo As Boolean, Glow_fb As Boolean)
        Dim GlowIndex As Integer = mem.rdInt(ptr + m_iGlowIndex)
        Dim GlowObjectManager As Integer = mem.rdInt(mem.ClientpanoramaDLL + dwGlowObjectManager)
        Dim GlowObject As cESP.GlowObject_t = mem.ReadMemory(Of cESP.GlowObject_t)(GlowObjectManager + (GlowIndex * &H38))

        GlowObject.r = Glow_r
        GlowObject.g = Glow_g
        GlowObject.b = Glow_b
        GlowObject.a = Glow_a
        GlowObject.RenderWhenOccluded = Glow_rwo
        GlowObject.RenderWhenUnoccluded = Glow_rwuo
        GlowObject.FullBloom = Glow_fb

        mem.WriteStruct(Of cESP.GlowObject_t)(GlowObjectManager + (GlowIndex * &H38), GlowObject)
    End Sub

    Public Structure clr_s
        Dim r As Byte
        Dim g As Byte
        Dim b As Byte
        Dim a As Byte
    End Structure

    Public clr As New clr_s

    Public Sub clrRender(R As Byte, G As Byte, B As Byte, A As Byte)
        clr.r = R
        clr.g = G
        clr.b = B
        clr.a = A
        mem.WriteStruct(Of clr_s)(ptr + m_clrRender, clr)
    End Sub

    Public Shared Sub ForceJump(val As Integer)
        mem.WrtInt(mem.ClientpanoramaDLL + dwForceJump, val)
    End Sub

    Public Shared Sub ForceAttack(Delay1 As Integer, Delay2 As Integer, Delay3 As Integer)
        cUsefulFuncs.sleep(Delay1)
        mem.WrtInt(mem.ClientpanoramaDLL + dwForceAttack, 5)
        cUsefulFuncs.sleep(Delay2)
        mem.WrtInt(mem.ClientpanoramaDLL + dwForceAttack, 4)
        cUsefulFuncs.sleep(Delay3)
    End Sub
End Class

Public Class cBaseWeapon
    Public ptr As Integer

    Public Sub New(Pointer As Integer)
        ptr = Pointer
    End Sub

    Public Function Clip()
        Return mem.rdInt(ptr + m_iClip1)
    End Function

    Public Function ID()
        Return mem.rdInt(ptr + m_iItemDefinitionIndex)
    End Function

    Public Function XuID()
        Return mem.rdInt(ptr + m_OriginalOwnerXuidLow)
    End Function


    Public Function Type() As Short
        Select Case ID()
            Case 1
                Return WeaponType.Pistol 'Deagle"
            Case 2
                Return WeaponType.Pistol 'Duals"
            Case 3
                Return WeaponType.Pistol 'FiveSeven"
            Case 4
                Return WeaponType.Pistol 'Glock"
            Case 7
                Return WeaponType.Rifle 'AK47"
            Case 8
                Return WeaponType.Rifle 'AUG"
            Case 9
                Return WeaponType.AWP 'AWP"
            Case 10
                Return WeaponType.Rifle 'Famas"
            Case 11
                Return WeaponType.Sniper 'G3SG1"
            Case 13
                Return WeaponType.Rifle 'Galil"
            Case 14
                Return WeaponType.Heavy 'M249"
            Case 16
                Return WeaponType.Rifle 'M4A4"
            Case 17
                Return WeaponType.Rifle 'Mac10"
            Case 19
                Return WeaponType.Rifle 'P90"
            Case 23
                Return WeaponType.Rifle 'MP5"
            Case 24
                Return WeaponType.Rifle 'UMP45"
            Case 25
                Return WeaponType.Shotgun 'XM1014"
            Case 26
                Return WeaponType.Rifle 'Bizon"
            Case 27
                Return WeaponType.Shotgun    'Mag7"
            Case 28
                Return WeaponType.Heavy 'Negev"
            Case 29
                Return WeaponType.Shotgun 'Sawedoff"
            Case 30
                Return WeaponType.Pistol 'Tec9"
            Case 31
                Return -1'Taser"
            Case 32
                Return WeaponType.Pistol 'P2000"
            Case 33
                Return WeaponType.Rifle 'MP7"
            Case 34
                Return WeaponType.Rifle 'MP9"
            Case 35
                Return WeaponType.Shotgun 'Nova"
            Case 36
                Return WeaponType.Pistol 'P250"
            Case 38
                Return WeaponType.Sniper 'Scar20"
            Case 39
                Return WeaponType.Rifle 'SG556"
            Case 40
                Return WeaponType.Sniper 'SSG08"
            Case 42
                Return WeaponType.Knife 'Knife"
            Case 43
                Return WeaponType.Grenade 'Flashbang"
            Case 44
                Return WeaponType.Grenade 'Grenade"
            Case 45
                Return WeaponType.Grenade 'Smoke"
            Case 46
                Return WeaponType.Grenade 'Molotov"
            Case 47
                Return WeaponType.Grenade 'Decoy"
            Case 48
                Return WeaponType.Grenade 'Molotov"
            Case 49
                Return -1 'C4"
            Case 59
                Return WeaponType.Knife 'Knife"
            Case 60
                Return WeaponType.Rifle 'M4A1"
            Case 61
                Return WeaponType.Pistol 'USP"
            Case 63
                Return WeaponType.Pistol 'CZ75"
            Case 64
                Return WeaponType.Pistol 'Revolver"

                'Old Stuff for the old knifechanger, wich it doesnt works anymore.
            Case 500
                Return WeaponType.Knife 'Bayonet"
            Case 505
                Return WeaponType.Knife 'Flipknife"
            Case 506
                Return WeaponType.Knife 'Gutknife"
            Case 507
                Return WeaponType.Knife 'Karambit"
            Case 508
                Return WeaponType.Knife 'M9 Bayonet"
            Case 509
                Return WeaponType.Knife 'Huntsman"
            Case 512
                Return WeaponType.Knife 'Falchion"
            Case 515
                Return WeaponType.Knife 'Butterfly"
            Case 516
                Return WeaponType.Knife 'Knife"
            Case 519
                Return WeaponType.Knife 'Ursus"
            Case 520
                Return WeaponType.Knife 'Navaja"
            Case 522
                Return WeaponType.Knife 'Stiletto"
            Case 523
                Return WeaponType.Knife 'Talon"
            Case Else
                Return -1 'Unknown Weapon"
        End Select
    End Function

    Public Function Name() As String
        Select Case ID()
            Case 1
                Return "Deagle"
            Case 2
                Return "Duals"
            Case 3
                Return "FiveSeven"
            Case 4
                Return "Glock"
            Case 7
                Return "AK47"
            Case 8
                Return "AUG"
            Case 9
                Return "AWP"
            Case 10
                Return "Famas"
            Case 11
                Return "G3SG1"
            Case 13
                Return "Galil"
            Case 14
                Return "M249"
            Case 16
                Return "M4A4"
            Case 17
                Return "Mac10"
            Case 19
                Return "P90"
            Case 23
                Return "MP5"
            Case 24
                Return "UMP45"
            Case 25
                Return "XM1014"
            Case 26
                Return "Bizon"
            Case 27
                Return "Mag7"
            Case 28
                Return "Negev"
            Case 29
                Return "Sawedoff"
            Case 30
                Return "Tec9"
            Case 31
                Return "Taser"
            Case 32
                Return "P2000"
            Case 33
                Return "MP7"
            Case 34
                Return "MP9"
            Case 35
                Return "Nova"
            Case 36
                Return "P250"
            Case 38
                Return "Scar20"
            Case 39
                Return "SG556"
            Case 40
                Return "SSG08"
            Case 42
                Return "Knife"
            Case 43
                Return "Flashbang"
            Case 44
                Return "Grenade"
            Case 45
                Return "Smoke"
            Case 46
                Return "Molotov"
            Case 47
                Return "Decoy"
            Case 48
                Return "Molotov"
            Case 49
                Return "C4"
            Case 59
                Return "Knife"
            Case 60
                Return "M4A1"
            Case 61
                Return "USP"
            Case 63
                Return "CZ75"
            Case 64
                Return "Revolver"
            Case 500
                Return "Bayonet"
            Case 505
                Return "Flipknife"
            Case 506
                Return "Gutknife"
            Case 507
                Return "Karambit"
            Case 508
                Return "M9 Bayonet"
            Case 509
                Return "Huntsman"
            Case 512
                Return "Falchion"
            Case 515
                Return "Butterfly "
            Case 516
                Return "Knife"
            Case 519
                Return "Ursus"
            Case 520
                Return "Navaja"
            Case 522
                Return "Stiletto"
            Case 523
                Return "Talon"
            Case Else
                Return "Unknown Weapon"
        End Select
    End Function
End Class

Public Class cConfig
    Private Declare Ansi Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    <DllImport("kernel32", EntryPoint:="GetPrivateProfileString")>
    Private Shared Function ReadINI(
        ByVal Sektion As String, ByVal Key As String, ByVal StandartVal As String,
        ByVal Result As StringBuilder, ByVal Size As Int32, ByVal Dateiname As String) As Int32
    End Function

    Public Structure RGBA
        Dim r As Single
        Dim g As Single
        Dim b As Single
        Dim a As Single

        Public Sub New(_r As Single, _g As Single, _b As Single, _a As Single)
            r = _r
            g = _g
            b = _b
            a = _a
        End Sub
    End Structure

    Public Path As String

    ' Public Sub(_FolderPath As String)
    '      FolderPath = _FolderPath
    ' End Sub
    Public Function exist()
        If File.Exists(Path) Then Return True
        Return False
    End Function
    Public Function createFolder()
        File.Create(Path)
        Return True
    End Function

    Public ConfigPath As String

    Public Sub New(_ConfigPath As String)
        ConfigPath = _ConfigPath
    End Sub

    Public Function exists()
        If File.Exists(ConfigPath) Then Return True
        Return False
    End Function

    Public Function createConfig()
        File.Create(ConfigPath)
        Return True
    End Function

    Public Function read(Sektion As String, Parameter As String)
        Dim sb As StringBuilder = New StringBuilder(1024)

        ReadINI(Sektion, Parameter, "", sb, sb.Capacity, ConfigPath)
        Return sb.ToString
    End Function

    Public Function write(Sektion As String, Parameter As String, ByVal Value As String) As Boolean
        WritePrivateProfileString(Sektion, Parameter, Value, ConfigPath)
        Return True
    End Function

    Public Function ReadRGBA(Sektion As String, Parameter As String) As RGBA
        Dim sb As StringBuilder = New StringBuilder(1024)
        ReadINI(Sektion, Parameter, "", sb, sb.Capacity, ConfigPath)

        Dim cs As String() = sb.ToString.Split("/")
        Dim cc As RGBA
        cc.r = cs(0)
        cc.g = cs(1)
        cc.b = cs(2)
        cc.a = cs(3)

        Return cc
    End Function

    Public Function WriteRGBA(Sektion As String, Parameter As String, RGBAcolor As RGBA)
        Dim cString As String = """" & RGBAcolor.r & "/" & RGBAcolor.g & "/" & RGBAcolor.b & "/" & RGBAcolor.a & """"
        WritePrivateProfileString(Sektion, Parameter, cString, ConfigPath)
        Return True
    End Function

    Public Function RGBAtoString(RGBAColor As RGBA) As String
        Dim c As RGBA = RGBAColor
        Return "red: " & c.r & ", green: " & c.g & ", blue: " & c.b & ", alpha: " & c.a
    End Function
End Class

Public Class cEngine

    Public Function Clientstate() As Integer
        Return mem.rdInt(mem.EngineDLL + dwClientState)
    End Function

    Public Function Ingame() As Boolean
        Return mem.rdInt(Clientstate() + m_dwInGame) > 5
    End Function

    Public Function MaxPlayers() As Integer
        Return mem.rdInt(Clientstate() + &H308)
    End Function

    Public Sub SetAngles(ang As Vec3)
        Dim clienstate As Integer = Clientstate()
        mem.WrtFloat(clienstate + dwClientState_ViewAngles, ang.x)
        mem.WrtFloat(clienstate + dwClientState_ViewAngles + &H4, ang.y)
        'mem.WriteStruct(Of Vec3)(GetClientstate() + m_dwViewAngles, ang)
    End Sub

    Public Function ViewAngles() As Vec3
        Return mem.ReadMemory(Of Vec3)(Clientstate() + dwClientState_ViewAngles)
    End Function

    Public Sub Fullupdate()
        mem.WrtInt(Clientstate() + &H174, -1)
    End Sub
End Class

Public Class ENUMS

    Public Enum ItemDefinitionIndex

        DEAGLE = 1
        ELITE = 2
        FIVESEVEN = 3
        GLOCK = 4
        AK47 = 7
        AUG = 8
        AWP = 9
        FAMAS = 10
        G3SG1 = 11
        GALILAR = 13
        M249 = 14
        M4A4 = 16
        MAC10 = 17
        P90 = 19
        MP5SD = 23
        UMP45 = 24
        XM1014 = 25
        BIZON = 26
        MAG7 = 27
        NEGEV = 28
        SAWEDOFF = 29
        TEC9 = 30
        TASER = 31
        P2000 = 32
        MP7 = 33
        MP9 = 34
        NOVA = 35
        P250 = 36
        SCAR20 = 38
        SG556 = 39
        SSG08 = 40
        KNIFE = 42
        FLASHBANG = 43
        HEGRENADE = 44
        SMOKEGRENADE = 45
        MOLOTOV = 46
        DECOY = 47
        INCGRENADE = 48
        C4 = 49
        KNIFE_T = 59
        M4A1 = 60
        USP = 61
        CZ75A = 63
        REVOLVER = 64
        KNIFE_BAYONET = 500
        KNIFE_FLIP = 505
        KNIFE_GUT = 506
        KNIFE_KARAMBIT = 507
        KNIFE_M9_BAYONET = 508
        KNIFE_TACTICAL = 509
        KNIFE_FALCHION = 512
        KNIFE_BUTTERFLY = 515
        KNIFE_PUSH = 516
        KNIFE_URSUS = 519
        KNIFE_NAVAJA = 520
        KNIFE_STILETTO = 522
        KNIFE_TALON = 523

    End Enum

    Public Enum WeaponType
        Knife = 0
        Pistol = 1
        SMG = 2
        Rifle = 3
        Sniper = 4
        Shotgun = 5
        Heavy = 6
        Grenade = 7
        AWP = 8
    End Enum

    Public Enum ClassID
        CAK47 = 1
        CBaseAnimating = 2
        CBaseAnimatingOverlay = 3
        CBaseAttributableItem = 4
        CBaseButton = 5
        CBaseCombatCharacter = 6
        CBaseCombatWeapon = 7
        CBaseCSGrenade = 8
        CBaseCSGrenadeProjectile = 9
        CBaseDoor = 10
        CBaseEntity = 11
        CBaseFlex = 12
        CBaseGrenade = 13
        CBaseParticleEntity = 14
        CBasePlayer = 15
        CBasePropDoor = 16
        CBaseTeamObjectiveResource = 17
        CBaseTempEntity = 18
        CBaseToggle = 19
        CBaseTrigger = 20
        CBaseViewModel = 21
        CBaseVPhysicsTrigger = 22
        CBaseWeaponWorldModel = 23
        CBeam = 24
        CBeamSpotlight = 25
        CBoneFollower = 26
        CBreakableProp = 27
        CBreakableSurface = 28
        CC4 = 29
        CCascadeLight = 30
        CChicken = 31
        CColorCorrection = 32
        CColorCorrectionVolume = 33
        CCSGameRulesProxy = 34
        CCSPlayer = 35
        CCSPlayerResource = 36
        CCSRagdoll = 37
        CCSTeam = 38
        CDEagle = 39
        CDecoyGrenade = 40
        CDecoyProjectile = 41
        CDynamicLight = 42
        CDynamicProp = 43
        CEconEntity = 44
        CEconWearable = 45
        CEmbers = 46
        CEntityDissolve = 47
        CEntityFlame = 48
        CEntityFreezing = 49
        CEntityParticleTrail = 50
        CEnvAmbientLight = 51
        CEnvDetailController = 52
        CEnvDOFController = 53
        CEnvParticleScript = 54
        CEnvProjectedTexture = 55
        CEnvQuadraticBeam = 56
        CEnvScreenEffect = 57
        CEnvScreenOverlay = 58
        CEnvTonemapController = 59
        CEnvWind = 60
        CFEPlayerDecal = 61
        CFireCrackerBlast = 62
        CFireSmoke = 63
        CFireTrail = 64
        CFish = 65
        CFlashbang = 66
        CFogController = 67
        CFootstepControl = 68
        CFunc_Dust = 69
        CFunc_LOD = 70
        CFuncAreaPortalWindow = 71
        CFuncBrush = 72
        CFuncConveyor = 73
        CFuncLadder = 74
        CFuncMonitor = 75
        CFuncMoveLinear = 76
        CFuncOccluder = 77
        CFuncReflectiveGlass = 78
        CFuncRotating = 79
        CFuncSmokeVolume = 80
        CFuncTrackTrain = 81
        CGameRulesProxy = 82
        CHandleTest = 83
        CHEGrenade = 84
        CHostage = 85
        CHostageCarriableProp = 86
        CIncendiaryGrenade = 87
        CInferno = 88
        CInfoLadderDismount = 89
        CInfoOverlayAccessor = 90
        CItem_Healthshot = 91
        CItemDogtags = 92
        CKnife = 93
        CKnifeGG = 94
        CLightGlow = 95
        CMaterialModifyControl = 96
        CMolotovGrenade = 97
        CMolotovProjectile = 98
        CMovieDisplay = 99
        CParticleFire = 100
        CParticlePerformanceMonitor = 101
        CParticleSystem = 102
        CPhysBox = 103
        CPhysBoxMultiplayer = 104
        CPhysicsProp = 105
        CPhysicsPropMultiplayer = 106
        CPhysMagnet = 107
        CPlantedC4 = 108
        CPlasma = 109
        CPlayerResource = 110
        CPointCamera = 111
        CPointCommentaryNode = 112
        CPointWorldText = 113
        CPoseController = 114
        CPostProcessController = 115
        CPrecipitation = 116
        CPrecipitationBlocker = 117
        CPredictedViewModel = 118
        CProp_Hallucination = 119
        CPropDoorRotating = 120
        CPropJeep = 121
        CPropVehicleDriveable = 122
        CRagdollManager = 123
        CRagdollProp = 124
        CRagdollPropAttached = 125
        CRopeKeyframe = 126
        CSCAR17 = 127
        CSceneEntity = 128
        CSensorGrenade = 129
        CSensorGrenadeProjectile = 130
        CShadowControl = 131
        CSlideshowDisplay = 132
        CSmokeGrenade = 133
        CSmokeGrenadeProjectile = 134
        CSmokeStack = 135
        CSpatialEntity = 136
        CSpotlightEnd = 137
        CSprite = 138
        CSpriteOriented = 139
        CSpriteTrail = 140
        CStatueProp = 141
        CSteamJet = 142
        CSun = 143
        CSunlightShadowControl = 144
        CTeam = 145
        CTeamplayRoundBasedRulesProxy = 146
        CTEArmorRicochet = 147
        CTEBaseBeam = 148
        CTEBeamEntPoint = 149
        CTEBeamEnts = 150
        CTEBeamFollow = 151
        CTEBeamLaser = 152
        CTEBeamPoints = 153
        CTEBeamRing = 154
        CTEBeamRingPoint = 155
        CTEBeamSpline = 156
        CTEBloodSprite = 157
        CTEBloodStream = 158
        CTEBreakModel = 159
        CTEBSPDecal = 160
        CTEBubbles = 161
        CTEBubbleTrail = 162
        CTEClientProjectile = 163
        CTEDecal = 164
        CTEDust = 165
        CTEDynamicLight = 166
        CTEEffectDispatch = 167
        CTEEnergySplash = 168
        CTEExplosion = 169
        CTEFireBullets = 170
        CTEFizz = 171
        CTEFootprintDecal = 172
        CTEFoundryHelpers = 173
        CTEGaussExplosion = 174
        CTEGlowSprite = 175
        CTEImpact = 176
        CTEKillPlayerAttachments = 177
        CTELargeFunnel = 178
        CTEMetalSparks = 179
        CTEMuzzleFlash = 180
        CTEParticleSystem = 181
        CTEPhysicsProp = 182
        CTEPlantBomb = 183
        CTEPlayerAnimEvent = 184
        CTEPlayerDecal = 185
        CTEProjectedDecal = 186
        CTERadioIcon = 187
        CTEShatterSurface = 188
        CTEShowLine = 189
        CTesla = 190
        CTESmoke = 191
        CTESparks = 192
        CTESprite = 193
        CTESpriteSpray = 194
        CTest_ProxyToggle_Networkable = 194
        CTestTraceline = 196
        CTEWorldDecal = 197
        CTriggerPlayerMovement = 198
        CTriggerSoundOperator = 199
        CVGuiScreen = 200
        CVoteController = 201
        CWaterBullet = 202
        CWaterLODControl = 203
        CWeaponAug = 204
        CWeaponAWP = 205
        CWeaponBaseItem = 206
        CWeaponBizon = 207
        CWeaponCSBase = 208
        CWeaponCSBaseGun = 209
        CWeaponCycler = 210
        CWeaponElite = 211
        CWeaponFamas = 212
        CWeaponFiveSeven = 213
        CWeaponG3SG1 = 214
        CWeaponGalil = 215
        CWeaponGalilAR = 216
        CWeaponGlock = 217
        CWeaponHKP2000 = 218
        CWeaponM249 = 219
        CWeaponM3 = 220
        CWeaponM4A1 = 221
        CWeaponMAC10 = 222
        CWeaponMag7 = 223
        CWeaponMP5Navy = 224
        CWeaponMP5 = 225
        CWeaponMP7 = 225
        CWeaponMP9 = 226
        CWeaponNegev = 227
        CWeaponNOVA = 228
        CWeaponP228 = 229
        CWeaponP250 = 230
        CWeaponP90 = 231
        CWeaponSawedoff = 232
        CWeaponSCAR20 = 233
        CWeaponScout = 234
        CWeaponSG550 = 235
        CWeaponSG552 = 236
        CWeaponSG556 = 237
        CWeaponSSG08 = 238
        CWeaponTaser = 239
        CWeaponTec9 = 240
        CWeaponTMP = 241
        CWeaponUMP45 = 242
        CWeaponUSP = 243
        CWeaponXM1014 = 244
        CWorld = 245
        DustTrail = 246
        MovieExplosion = 247
        ParticleSmokeGrenade = 248
        RocketTrail = 249
        SmokeTrail = 250
        SporeExplosion = 251
        SporeTrail = 252
    End Enum

    Public Enum WeaponSkin
        Groundwater = 2
        andy_Apple = 3
        Asterion = 4
        Forest_DDPAT = 5
        Arctic_Camo = 6

        Desert_Storm = 8
        Bengal_Tiger = 9
        opperhead = 10
        Skulls = 11
        rimson_Web = 12
        Blue_Streak = 13
        Red_Laminate = 14
        Gunsmoke = 15
        Jungle_Tiger = 16



        Virus = 20
        Granite_Marbleized = 21
        ontrast_Spray = 22


        Forest_Leaves = 25
        Lichen_Dashed = 26
        Bone_Mask = 27
        Anodized_Navy = 28

        Snake_Camo = 30

        Silver = 32
        Hot_Rod = 33
        Metallic_DDPAT = 34

        Ossified = 36
        Blaze = 37
        Fade = 38
        Night = 40
        opper = 41
        Blue_Steel = 42
        Stained = 43
        ase_Hardened = 44

        ontractor = 46
        olony = 47
        Dragon_Tattoo = 48


        Lightning_Strike = 51







        Slaughter = 59
        Dark_Water = 60
        Hypnotic = 61









        Scorpion = 71
        Safari_Mesh = 72
        Wings = 73
        Polar_Camo = 74



        Boreal_Forest = 77
        Forest_Night = 78





        Pink_DDPAT = 84






        Mudder = 90

        yanospatter = 92



        Grassland = 95

        Ultraviolet = 98
        Tornado = 101
        Storm = 100


        Grassland_Leaves = 104










        ondemned = 110











        Jungle_Spray = 122
        Orange_Peel = 141
        Urban_Masked = 143
        Jungle_Dashed = 147
        Jungle = 151
        Demolition = 153
        Afterimage = 154
        Bullet_Rain = 155
        Brass = 159
        Modern_Hunter = 164
        Radiation_Hazard = 167
        Predator = 170
        Black_Laminate = 172
        BOOM = 174
        Scorched = 175
        Faded_Zebra = 176
        Doomkitty = 178
        Nuclear_Threat = 179
        Fire_Serpent = 180
        orticera = 181
        Overgrowth = 183
        orticera2 = 184
        Golden_Koi = 185
        Zirka = 187
        Bright_Water = 189
        Black_Limba = 190
        Spitfire = 194

        Sand_Dune = 208
        Anodized_Gunmetal = 210
        Ocean_Foam = 211
        Graphite = 212
        X_Ray = 215
        Blue_Titanium = 216
        Blood_Tiger = 217
        Hexane = 218
        Hemoglobin = 220
        Serum = 221
        Nightshade = 223
        Blue_Laminate = 226
        Electric_Hive = 227
        Azure_Zebra = 229
        Steel_Disruption = 230
        obalt_Disruption = 231
        VariCamo = 235
        Night_Ops = 236
        Urban_Rubble = 237
        Army_Mesh = 242
        Teardown = 244
        Amber_Fade = 246
        Red_Quartz = 248
        obalt_Quartz = 249
        Pit_Viper = 251
        Silver_Quartz = 252
        Nitro = 254
        AsiimovM4 = 255
        Guardian = 257
        Redline = 259
        Pulse = 260
        Marina = 261
        Kami = 265
        Tread_Plate = 268
        The_Fuschia_Is_Now = 269
        Victoria = 270
        Heirloom = 273
        opper_Galaxy = 274
        Red_FragCam = 275
        Panther = 276
        Titanium_Bit = 272
        Stainless = 277
        Blue_Fissure = 278
        Asiimov = 279
        hameleon = 280
        Redline2 = 282
        Sergeant = 288
        Sandstorm = 289
        Guardian2 = 290
        Death_Rattle = 293
        Green_Apple = 294
        Meteorite = 296
        Tuxedo = 297
        Emerald_Pinstripe = 300
        Atomic_Alloy = 301
        Vulcan = 302
        Isaac = 303
        Torque = 305
        Retribution = 307
        Howl = 309
        Orion = 313
        Poison_Dart = 315
        Jaguar = 316
        Road_Rash = 318
        Master_Piece = 321
        Rust_Coat = 323
        halice = 325
        Knight = 326
        hainmail = 327
        Hand_Cannon = 328
        Briar = 330
        Royal_Blue = 332
        Twist = 334
        aiman = 339
        Jet_Set = 340
        First_Class = 341
        Dragon_Lore = 344
        oach_Class = 346
        Pilot = 347
        Tigris = 350
        onspiracy = 351
        Fowl_Play = 352
        Water_Elemental = 353
        Ivory = 357
        yrex = 360
        Business_Class = 364
        Green_Plaid = 366
        Styx = 371

        Reactor = 367
        Toxic = 374
        Hot_Shot = 377
        Wasteland_Rebel = 380
        Grinder = 381
        Murky = 382
        Basilisk = 383
        Griffin = 384
        Fire_Elemental = 389
        artel = 394
        Urban_Shock = 396
        Man_o_war = 395
        Naga = 397
        atacombs = 399
        Dragon_King = 400
        Tiger_Tooth = 409
        Damascus_Steel = 410
        Marble_Fade = 413

        Doppler_Ruby = 415
        Doppler_Sapphire = 416
        Doppler_Blackpearl = 417
        Doppler_Phase_1 = 418
        Doppler_Phase_2 = 419
        Doppler_Phase_3 = 420
        Doppler_Phase_4 = 421
        Elite_Build = 422
        Worm_God = 424
        Bronze_Deco = 425
        Monkey_Business = 427
        Djinn = 429
        Hyper_Beast = 430
        Pole_Position = 435
        Twilight_Galaxy = 437
        hronos = 438
        Hades = 439
        Icarus_Fell = 440
        Pathfinder = 443
        Daedalus = 444
        Medusa = 446
        Duelist = 447
        Poseidon = 449
        Moon_in_Libra = 450
        Sun_in_Leo = 451
        Emerald = 453
        Para_Green = 454
        Akihabara_Accept = 455
        Hydroponic = 456
        Bamboo_Forest = 459
        Terrace = 463
        Neon_Kimono = 464
        Orange_Kimono = 465
        Midnight_Storm = 468
        Sunset_Storm = 470
        Daybreak = 471
        Aquamarine_Revenge = 474
        Hyper_Beast2 = 475
        Yellow_Jacket = 476
        Neural_Net = 477
        Bunsen_Burner = 479
        Evil_Daimyo = 480
        Handgun = 485
        Neon_Rider = 707
        Code_Red = 711
        Paw = 718
        Nightmare = 714
        Eye_of_Athena = 723
        Devourer = 720
        Powercore = 719
        Toy_Soldier = 716
        Eco = 709
        High_Seas = 712
        Amber_Slipstream = 708
        Warhawk = 713
        Shred = 710
        Capillary = 715
        Survivalist = 721
        Snek_9 = 722
        Traction = 717

    End Enum
End Class

Public Class cFindPattern

    Public Function Scanf(Dll As Integer, Pattern As String, Extra As Integer, Offset As Integer, ModeSubtract As Boolean) As Integer
        Dim Off As Integer = BitConverter.ToInt32(mem.rdMem(AobScan(Dll, &H1800000, Pattern, 0) + Extra, 4), 0) + Offset
        If ModeSubtract Then Off -= Dll
        Return Off
    End Function

    Private Function AobScan(ByVal Base As Integer, ByVal _Range As Integer, ByVal Signature As String, ByVal Instance As Integer) As Integer
        'Credits to whoever the fuck created this :)
        If (Signature <> String.Empty) Then
            Dim New_String As String = Regex.Replace(Signature.Replace("??", "3F"), "[^a-fA-F0-9]", "")
            Dim Count As Integer = -1
            Dim SearchFor As Byte() = New Byte((New_String.Length / 2) - 1) {}
            For i As Integer = 0 To SearchFor.Length - 1
                SearchFor(i) = Byte.Parse(New_String.Substring(i * 2, 2), NumberStyles.HexNumber)
            Next i
            Dim Sin As Byte() = mem.rdMem(Base, _Range)

            Dim Z As Integer = 0, P As Integer = 0
            Dim iEnd As Integer = If(SearchFor.Length < &H20, SearchFor.Length, &H20)
            Dim sBytes As Integer() = New Integer(&H100 - 1) {}
            For j As Integer = 0 To iEnd - 1
                If (SearchFor(j) = &H3F) Then
                    Z = (Z Or (CInt(1) << ((iEnd - j) - 1)))
                End If
            Next j
            If (Z <> 0) Then
                For k As Integer = 0 To sBytes.Length - 1
                    sBytes(k) = Z
                Next k
            End If
            Z = 1
            Dim index As Integer = (iEnd - 1)
            Do While (index >= 0)
                sBytes(SearchFor(index)) = (sBytes(SearchFor(index)) Or Z)
                index -= 1
                Z = (Z << 1)
            Loop
            Do While (P <= (Sin.Length - SearchFor.Length))
                Z = (SearchFor.Length - 1)
                Dim last As Integer = SearchFor.Length
                Dim m As Integer = -1
                Do While (m <> 0)
                    m = (m And sBytes(Sin(P + Z)))
                    If (m <> 0) Then
                        If (Z = 0) Then
                            Count += 1
                            If Count = Instance Then
                                Return Base + P
                            End If
                            P += 2
                        End If
                        last = Z
                    End If
                    Z -= 1
                    m = (m << 1)
                Loop
                P += last
            Loop
        End If
        Return -1
    End Function
End Class

Public Enum Keys
    '
    ' Zusammenfassung:
    '     Die Bitmaske zum Extrahieren von Modifizierern aus einem Tastenwert.
    Modifiers = -65536
    '
    ' Zusammenfassung:
    '     Keine Taste gedrückt.
    None = 0
    '
    ' Zusammenfassung:
    '     Die linke Maustaste.
    LButton = 1
    '
    ' Zusammenfassung:
    '     Die rechte Maustaste.
    RButton = 2
    '
    ' Zusammenfassung:
    '     Die CANCEL-TASTE.
    Cancel = 3
    '
    ' Zusammenfassung:
    '     Die mittlere Maustaste (Drei-Tasten-Maus).
    MButton = 4
    '
    ' Zusammenfassung:
    '     Die erste X-Maus-Taste (Fünf-Tasten-Maus).
    XButton1 = 5
    '
    ' Zusammenfassung:
    '     Die zweite X-Maus-Taste (Fünf-Tasten-Maus).
    XButton2 = 6
    '
    ' Zusammenfassung:
    '     Die RÜCKTASTE.
    Back = 8
    '
    ' Zusammenfassung:
    '     Die TAB-TASTE.
    Tab = 9
    '
    ' Zusammenfassung:
    '     Die ZEILENVORSCHUBTASTE.
    LineFeed = 10
    '
    ' Zusammenfassung:
    '     Die CLEAR-TASTE.
    Clear = 12
    '
    ' Zusammenfassung:
    '     Die RETURN-TASTE.
    [Return] = 13
    '
    ' Zusammenfassung:
    '     Die EINGABETASTE.
    Enter = 13
    '
    ' Zusammenfassung:
    '     Die UMSCHALTTASTE.
    ShiftKey = 16
    '
    ' Zusammenfassung:
    '     Die CTRL-TASTE.
    ControlKey = 17
    '
    ' Zusammenfassung:
    '     Die ALT-TASTE.
    Menu = 18
    '
    ' Zusammenfassung:
    '     Die PAUSE-TASTE.
    Pause = 19
    '
    ' Zusammenfassung:
    '     Die CAPS-abhängige LOCK-TASTE.
    Capital = 20
    '
    ' Zusammenfassung:
    '     Die CAPS-abhängige LOCK-TASTE.
    CapsLock = 20
    '
    ' Zusammenfassung:
    '     Die Taste für den IME-Kana-Modus.
    KanaMode = 21
    '
    ' Zusammenfassung:
    '     Die Taste für den IME-Hanguel-Modus.(aus Kompatibilitätsgründen beibehalten;
    '     verwenden Sie HangulMode)
    HanguelMode = 21
    '
    ' Zusammenfassung:
    '     Die Taste für den IME-Hangul-Modus.
    HangulMode = 21
    '
    ' Zusammenfassung:
    '     Die Taste für den IME-Junja-Modus.
    JunjaMode = 23
    '
    ' Zusammenfassung:
    '     Die Taste für den IME-Abschlussmodus.
    FinalMode = 24
    '
    ' Zusammenfassung:
    '     Die Taste für den IME-Hanja-Modus.
    HanjaMode = 25
    '
    ' Zusammenfassung:
    '     Die Taste für den IME-Kanji-Modus.
    KanjiMode = 25
    '
    ' Zusammenfassung:
    '     Die ESC-TASTE.
    Escape = 27
    '
    ' Zusammenfassung:
    '     Die Taste für die IME-Konvertierung.
    IMEConvert = 28
    '
    ' Zusammenfassung:
    '     Die Taste für die IME-Nicht-Konvertierung.
    IMENonconvert = 29
    '
    ' Zusammenfassung:
    '     Die Taste für das Annehmen im IME (ersetzt System.Windows.Forms.Keys.IMEAceept).
    IMEAccept = 30
    '
    ' Zusammenfassung:
    '     Die Taste für das Annehmen im IME.Veraltet, verwenden Sie stattdessen System.Windows.Forms.Keys.IMEAccept.
    IMEAceept = 30
    '
    ' Zusammenfassung:
    '     Die Taste für den IME-Moduswechsel.
    IMEModeChange = 31
    '
    ' Zusammenfassung:
    '     Die LEERTASTE.
    Space = 32
    '
    ' Zusammenfassung:
    '     Die BILD-AUF-TASTE.
    Prior = 33
    '
    ' Zusammenfassung:
    '     Die BILD-AUF-TASTE.
    PageUp = 33
    '
    ' Zusammenfassung:
    '     Die PAGE-abhängige DOWN-TASTE.
    [Next] = 34
    '
    ' Zusammenfassung:
    '     Die PAGE-abhängige DOWN-TASTE.
    PageDown = 34
    '
    ' Zusammenfassung:
    '     Die ENDE-TASTE.
    [End] = 35
    '
    ' Zusammenfassung:
    '     Die POS1-TASTE.
    Home = 36
    '
    ' Zusammenfassung:
    '     Die NACH-LINKS-TASTE.
    Left = 37
    '
    ' Zusammenfassung:
    '     Die NACH-OBEN-TASTE.
    Up = 38
    '
    ' Zusammenfassung:
    '     Die NACH-RECHTS-TASTE.
    Right = 39
    '
    ' Zusammenfassung:
    '     Die NACH-UNTEN-TASTE.
    Down = 40
    '
    ' Zusammenfassung:
    '     Die SELECT-TASTE.
    [Select] = 41
    '
    ' Zusammenfassung:
    '     Die DRUCKTASTE.
    Print = 42
    '
    ' Zusammenfassung:
    '     Die EXECUTE-TASTE.
    Execute = 43
    '
    ' Zusammenfassung:
    '     Die DRUCK-TASTE.
    Snapshot = 44
    '
    ' Zusammenfassung:
    '     Die DRUCK-TASTE.
    PrintScreen = 44
    '
    ' Zusammenfassung:
    '     Die INS-TASTE.
    Insert = 45
    '
    ' Zusammenfassung:
    '     Die DEL-TASTE.
    Delete = 46
    '
    ' Zusammenfassung:
    '     Die HELP-TASTE.
    Help = 47
    '
    ' Zusammenfassung:
    '     Die 0-TASTE.
    D0 = 48
    '
    ' Zusammenfassung:
    '     Die 1-TASTE.
    D1 = 49
    '
    ' Zusammenfassung:
    '     Die 2-TASTE.
    D2 = 50
    '
    ' Zusammenfassung:
    '     Die 3-TASTE.
    D3 = 51
    '
    ' Zusammenfassung:
    '     Die 4-TASTE.
    D4 = 52
    '
    ' Zusammenfassung:
    '     Die 5-TASTE.
    D5 = 53
    '
    ' Zusammenfassung:
    '     Die 6-TASTE.
    D6 = 54
    '
    ' Zusammenfassung:
    '     Die 7-TASTE.
    D7 = 55
    '
    ' Zusammenfassung:
    '     Die 8-TASTE.
    D8 = 56
    '
    ' Zusammenfassung:
    '     Die 9-TASTE.
    D9 = 57
    '
    ' Zusammenfassung:
    '     Die A-TASTE.
    A = 65
    '
    ' Zusammenfassung:
    '     Die B-TASTE.
    B = 66
    '
    ' Zusammenfassung:
    '     Die C-TASTE.
    C = 67
    '
    ' Zusammenfassung:
    '     Die D-TASTE.
    D = 68
    '
    ' Zusammenfassung:
    '     Die E-TASTE.
    E = 69
    '
    ' Zusammenfassung:
    '     Die F-TASTE.
    F = 70
    '
    ' Zusammenfassung:
    '     Die G-TASTE.
    G = 71
    '
    ' Zusammenfassung:
    '     Die H-TASTE.
    H = 72
    '
    ' Zusammenfassung:
    '     Die I-TASTE.
    I = 73
    '
    ' Zusammenfassung:
    '     Die J-TASTE.
    J = 74
    '
    ' Zusammenfassung:
    '     Die K-TASTE.
    K = 75
    '
    ' Zusammenfassung:
    '     Die L-TASTE.
    L = 76
    '
    ' Zusammenfassung:
    '     Die M-TASTE.
    M = 77
    '
    ' Zusammenfassung:
    '     Die N-TASTE.
    N = 78
    '
    ' Zusammenfassung:
    '     Die O-TASTE.
    O = 79
    '
    ' Zusammenfassung:
    '     Die P-TASTE.
    P = 80
    '
    ' Zusammenfassung:
    '     Die Q-TASTE.
    Q = 81
    '
    ' Zusammenfassung:
    '     Die R-TASTE.
    R = 82
    '
    ' Zusammenfassung:
    '     Die S-TASTE.
    S = 83
    '
    ' Zusammenfassung:
    '     Die T-TASTE.
    T = 84
    '
    ' Zusammenfassung:
    '     Die U-TASTE.
    U = 85
    '
    ' Zusammenfassung:
    '     Die V-TASTE.
    V = 86
    '
    ' Zusammenfassung:
    '     Die W-TASTE.
    W = 87
    '
    ' Zusammenfassung:
    '     Die X-TASTE.
    X = 88
    '
    ' Zusammenfassung:
    '     Die Y-TASTE.
    Y = 89
    '
    ' Zusammenfassung:
    '     Die Z-TASTE.
    Z = 90
    '
    ' Zusammenfassung:
    '     Die linke WINDOWS-TASTE (Microsoft Natural Keyboard).
    LWin = 91
    '
    ' Zusammenfassung:
    '     Die rechte WINDOWS-TASTE (Microsoft Natural Keyboard).
    RWin = 92
    '
    ' Zusammenfassung:
    '     Die ANWENDUNGSTASTE (Microsoft Natural Keyboard).
    Apps = 93
    '
    ' Zusammenfassung:
    '     Die Standbytaste des Computers.
    Sleep = 95
    '
    ' Zusammenfassung:
    '     Die 0-TASTE auf der Zehnertastatur.
    NumPad0 = 96
    '
    ' Zusammenfassung:
    '     Die 1-TASTE auf der Zehnertastatur.
    NumPad1 = 97
    '
    ' Zusammenfassung:
    '     Die 2-TASTE auf der Zehnertastatur.
    NumPad2 = 98
    '
    ' Zusammenfassung:
    '     Die 3-TASTE auf der Zehnertastatur.
    NumPad3 = 99
    '
    ' Zusammenfassung:
    '     Die 4-TASTE auf der Zehnertastatur.
    NumPad4 = 100
    '
    ' Zusammenfassung:
    '     Die 5-TASTE auf der Zehnertastatur.
    NumPad5 = 101
    '
    ' Zusammenfassung:
    '     Die 6-TASTE auf der Zehnertastatur.
    NumPad6 = 102
    '
    ' Zusammenfassung:
    '     Die 7-TASTE auf der Zehnertastatur.
    NumPad7 = 103
    '
    ' Zusammenfassung:
    '     Die 8-TASTE auf der Zehnertastatur.
    NumPad8 = 104
    '
    ' Zusammenfassung:
    '     Die 9-TASTE auf der Zehnertastatur.
    NumPad9 = 105
    '
    ' Zusammenfassung:
    '     Die MULTIPLIKATIONSTASTE.
    Multiply = 106
    '
    ' Zusammenfassung:
    '     Die ADDITIONSTASTE.
    Add = 107
    '
    ' Zusammenfassung:
    '     Die TRENNZEICHENTASTE.
    Separator = 108
    '
    ' Zusammenfassung:
    '     Die SUBTRAKTIONSTASTE.
    Subtract = 109
    '
    ' Zusammenfassung:
    '     Die KOMMATASTE.
    [Decimal] = 110
    '
    ' Zusammenfassung:
    '     Die DIVISIONSTASTE.
    Divide = 111
    '
    ' Zusammenfassung:
    '     Die F1-TASTE.
    F1 = 112
    '
    ' Zusammenfassung:
    '     Die F2-TASTE.
    F2 = 113
    '
    ' Zusammenfassung:
    '     Die F3-TASTE.
    F3 = 114
    '
    ' Zusammenfassung:
    '     Die F4-TASTE.
    F4 = 115
    '
    ' Zusammenfassung:
    '     Die F5-TASTE.
    F5 = 116
    '
    ' Zusammenfassung:
    '     Die F6-TASTE.
    F6 = 117
    '
    ' Zusammenfassung:
    '     Die F7-TASTE.
    F7 = 118
    '
    ' Zusammenfassung:
    '     Die F8-TASTE.
    F8 = 119
    '
    ' Zusammenfassung:
    '     Die F9-TASTE.
    F9 = 120
    '
    ' Zusammenfassung:
    '     Die F10-TASTE.
    F10 = 121
    '
    ' Zusammenfassung:
    '     Die F11-TASTE.
    F11 = 122
    '
    ' Zusammenfassung:
    '     Die F12-TASTE.
    F12 = 123
    '
    ' Zusammenfassung:
    '     Die F13-TASTE.
    F13 = 124
    '
    ' Zusammenfassung:
    '     Die F14-TASTE.
    F14 = 125
    '
    ' Zusammenfassung:
    '     Die F15-TASTE.
    F15 = 126
    '
    ' Zusammenfassung:
    '     Die F16-TASTE.
    F16 = 127
    '
    ' Zusammenfassung:
    '     Die F17-TASTE.
    F17 = 128
    '
    ' Zusammenfassung:
    '     Die F18-TASTE.
    F18 = 129
    '
    ' Zusammenfassung:
    '     Die F19-TASTE.
    F19 = 130
    '
    ' Zusammenfassung:
    '     Die F20-TASTE.
    F20 = 131
    '
    ' Zusammenfassung:
    '     Die F21-TASTE.
    F21 = 132
    '
    ' Zusammenfassung:
    '     Die F22-TASTE.
    F22 = 133
    '
    ' Zusammenfassung:
    '     Die F23-TASTE.
    F23 = 134
    '
    ' Zusammenfassung:
    '     Die F24-TASTE.
    F24 = 135
    '
    ' Zusammenfassung:
    '     Die NUM-abhängige LOCK-TASTE.
    NumLock = 144
    '
    ' Zusammenfassung:
    '     Die ROLLEN-TASTE.
    Scroll = 145
    '
    ' Zusammenfassung:
    '     Die linke UMSCHALTTASTE.
    LShiftKey = 160
    '
    ' Zusammenfassung:
    '     Die rechte UMSCHALTTASTE.
    RShiftKey = 161
    '
    ' Zusammenfassung:
    '     Die STRG-TASTE links.
    LControlKey = 162
    '
    ' Zusammenfassung:
    '     Die STRG-TASTE rechts.
    RControlKey = 163
    '
    ' Zusammenfassung:
    '     Die linke ALT-TASTE.
    LMenu = 164
    '
    ' Zusammenfassung:
    '     Die rechte ALT-TASTE.
    RMenu = 165
    '
    ' Zusammenfassung:
    '     Die BROWSER-ZURÜCK-TASTE (Windows 2000 oder höher).
    BrowserBack = 166
    '
    ' Zusammenfassung:
    '     Die BROWSER-VORWÄRTS-TASTE (Windows 2000 oder höher).
    BrowserForward = 167
    '
    ' Zusammenfassung:
    '     Die BROWSER-AKTUALISIEREN-TASTE (Windows 2000 oder höher).
    BrowserRefresh = 168
    '
    ' Zusammenfassung:
    '     Die BROWSER-ABBRECHEN-TASTE (Windows 2000 oder höher).
    BrowserStop = 169
    '
    ' Zusammenfassung:
    '     Die BROWSER-SUCHEN-TASTE (Windows 2000 oder höher).
    BrowserSearch = 170
    '
    ' Zusammenfassung:
    '     Die BROWSER-FAVORITEN-TASTE (Windows 2000 oder höher).
    BrowserFavorites = 171
    '
    ' Zusammenfassung:
    '     Die BROWSER-STARTSEITE-TASTE (Windows 2000 oder höher).
    BrowserHome = 172
    '
    ' Zusammenfassung:
    '     Die Taste zum Stummschalten (Windows 2000 oder höher).
    VolumeMute = 173
    '
    ' Zusammenfassung:
    '     Die Taste zum Verringern der Lautstärke (Windows 2000 oder höher).
    VolumeDown = 174
    '
    ' Zusammenfassung:
    '     Die Taste zum Erhöhen der Lautstärke (Windows 2000 oder höher).
    VolumeUp = 175
    '
    ' Zusammenfassung:
    '     Die Playertaste für den nächsten Titel (Windows 2000 oder höher).
    MediaNextTrack = 176
    '
    ' Zusammenfassung:
    '     Die Playertaste für den vorherigen Titel (Windows 2000 oder höher).
    MediaPreviousTrack = 177
    '
    ' Zusammenfassung:
    '     Die Playertaste für das Beenden der Wiedergabe (Windows 2000 oder höher).
    MediaStop = 178
    '
    ' Zusammenfassung:
    '     Die Playertaste für Wiedergabe und Pause (Windows 2000 oder höher).
    MediaPlayPause = 179
    '
    ' Zusammenfassung:
    '     Die MAILTASTE (Windows 2000 oder höher).
    LaunchMail = 180
    '
    ' Zusammenfassung:
    '     Die Taste für die Medienauswahl (Windows 2000 oder höher).
    SelectMedia = 181
    '
    ' Zusammenfassung:
    '     Die ANWENDUNGSSTARTTASTE 1 (Windows 2000 oder höher).
    LaunchApplication1 = 182
    '
    ' Zusammenfassung:
    '     Die ANWENDUNGSSTARTTASTE 2 (Windows 2000 oder höher).
    LaunchApplication2 = 183
    '
    ' Zusammenfassung:
    '     Die OEM-abhängige SEMIKOLONTASTE auf einer US-Standardtastatur (Windows 2000
    '     oder höher).
    OemSemicolon = 186
    '
    ' Zusammenfassung:
    '     Die OEM 1-TASTE.
    Oem1 = 186
    '
    ' Zusammenfassung:
    '     Die OEM-abhängige PLUSTASTE auf Tastaturen beliebiger Länder/Regionen (Windows
    '     2000 oder höher).
    Oemplus = 187
    '
    ' Zusammenfassung:
    '     Die OEM-abhängige KOMMATASTE auf Tastaturen beliebiger Länder/Regionen (Windows
    '     2000 oder höher).
    Oemcomma = 188
    '
    ' Zusammenfassung:
    '     Die OEM-abhängige MINUSTASTE auf Tastaturen beliebiger Länder/Regionen (Windows
    '     2000 oder höher).
    OemMinus = 189
    '
    ' Zusammenfassung:
    '     Die OEM-abhängige PUNKTTASTE auf Tastaturen beliebiger Länder/Regionen (Windows
    '     2000 oder höher).
    OemPeriod = 190
    '
    ' Zusammenfassung:
    '     Die OEM-abhängige FRAGEZEICHENTASTE auf einer US-Standardtastatur (Windows 2000
    '     oder höher).
    OemQuestion = 191
    '
    ' Zusammenfassung:
    '     Die OEM 2-TASTE.
    Oem2 = 191
    '
    ' Zusammenfassung:
    '     Die OEM-abhängige TILDETASTE auf einer US-Standardtastatur (Windows 2000 oder
    '     höher).
    Oemtilde = 192
    '
    ' Zusammenfassung:
    '     Die OEM 3-TASTE.
    Oem3 = 192
    '
    ' Zusammenfassung:
    '     Die OEM-abhängige Taste mit der öffnenden Klammer auf einer US-Standardtastatur
    '     (Windows 2000 oder höher).
    OemOpenBrackets = 219
    '
    ' Zusammenfassung:
    '     Die OEM 4-TASTE.
    Oem4 = 219
    '
    ' Zusammenfassung:
    '     Die OEM-abhängige Taste mit dem senkrechten Balken auf einer US-Standardtastatur
    '     (Windows 2000 oder höher).
    OemPipe = 220
    '
    ' Zusammenfassung:
    '     Die OEM 5-TASTE.
    Oem5 = 220
    '
    ' Zusammenfassung:
    '     Die OEM-abhängige Taste mit der schließenden Klammer auf einer US-Standardtastatur
    '     (Windows 2000 oder höher).
    OemCloseBrackets = 221
    '
    ' Zusammenfassung:
    '     Die OEM 6-TASTE.
    Oem6 = 221
    '
    ' Zusammenfassung:
    '     Die OEM-abhängige ANFÜHRUNGSZEICHENTASTE auf einer US-Standardtastatur (Windows
    '     2000 oder höher).
    OemQuotes = 222
    '
    ' Zusammenfassung:
    '     Die OEM 7-TASTE.
    Oem7 = 222
    '
    ' Zusammenfassung:
    '     Die OEM 8-TASTE.
    Oem8 = 223
    '
    ' Zusammenfassung:
    '     Die OEM-abhängige Taste mit der spitzen Klammer oder Taste mit dem umgekehrten
    '     Schrägstrich auf der RT-102-Tastatur (Windows 2000 oder höher).
    OemBackslash = 226
    '
    ' Zusammenfassung:
    '     Die OEM 102-TASTE.
    Oem102 = 226
    '
    ' Zusammenfassung:
    '     Die PROCESS KEY-TASTE.
    ProcessKey = 229
    '
    ' Zusammenfassung:
    '     Wird verwendet, um Unicode-Zeichen wie Tastaturanschläge zu übergeben.Der Packet-Tastenwert
    '     ist das niedrige WORD eines virtuellen 32-Bit-Tastenwerts, der für Tastatur-unabhängige
    '     Eingabemethoden verwendet wird.
    Packet = 231
    '
    ' Zusammenfassung:
    '     Die ATTN-TASTE.
    Attn = 246
    '
    ' Zusammenfassung:
    '     Die CRSEL-TASTE.
    Crsel = 247
    '
    ' Zusammenfassung:
    '     Die EXSEL-TASTE.
    Exsel = 248
    '
    ' Zusammenfassung:
    '     Die ERASE EOF-TASTE.
    EraseEof = 249
    '
    ' Zusammenfassung:
    '     Die PLAY-TASTE.
    Play = 250
    '
    ' Zusammenfassung:
    '     Die ZOOM-TASTE.
    Zoom = 251
    '
    ' Zusammenfassung:
    '     Eine für die zukünftige Verwendung reservierte Konstante.
    NoName = 252
    '
    ' Zusammenfassung:
    '     Die PA1-TASTE.
    Pa1 = 253
    '
    ' Zusammenfassung:
    '     Die CLEAR-TASTE.
    OemClear = 254
    '
    ' Zusammenfassung:
    '     Die Bitmaske zum Extrahieren eines Tastencodes aus einem Tastenwert.
    KeyCode = 65535
    '
    ' Zusammenfassung:
    '     Die Modifizierertaste UMSCHALT.
    Shift = 65536
    '
    ' Zusammenfassung:
    '     Die Zusatztaste STRG.
    Control = 131072
    '
    ' Zusammenfassung:
    '     Die Modifizierertaste ALT.
    Alt = 262144



End Enum

Public Class cMemoryManager

#Region "WinAPI"
    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function ReadProcessMemory(
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    <Out()> ByVal lpBuffer As Byte(),
    ByVal dwSize As Integer,
    ByRef lpNumberOfBytesRead As Integer) As Boolean
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function WriteProcessMemory(
    ByVal hProcess As Integer,
    ByVal lpBaseAddress As Integer,
    ByVal lpBuffer As Byte(),
    ByVal nSize As Int32,
    <Out()> ByRef lpNumberOfBytesWritten As Integer) As Boolean
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function OpenProcess(
    ByVal dwDesiredAcces As Integer,
    ByVal bInheritHandle As Boolean,
    ByVal processID As Integer
     ) As Integer
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    <ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)>
    <SuppressUnmanagedCodeSecurity>
    Public Shared Function CloseHandle(ByVal hObject As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
#End Region

    Private pProcess As Process()
    Private ProcHandle As Integer
    Public ClientpanoramaDLL As Integer
    Public EngineDLL As Integer

    Public Function Setup(ProcessName As String) As Boolean
        pProcess = Process.GetProcessesByName(ProcessName)
        If pProcess.Length > 0 Then
            ProcHandle = OpenProcess(2035711, False, pProcess(0).Id)
            If ProcHandle > 0 Then
                For Each [Module] As System.Diagnostics.ProcessModule In pProcess(0).Modules
                    If [Module].ModuleName = "engine.dll" Then
                        EngineDLL = [Module].BaseAddress
                    End If
                    If [Module].ModuleName = "client_panorama.dll" Then
                        ClientpanoramaDLL = [Module].BaseAddress
                    End If
                    If EngineDLL > 0 And ClientpanoramaDLL > 0 Then Return True
                Next
            End If
        End If
        Return False
    End Function

    Public Function rdMem(Offset As Integer, Size As Integer) As Byte()
        Dim buffer As Byte() = New Byte(Size - 1) {}
        ReadProcessMemory(ProcHandle, Offset, buffer, Size, 0)
        Return buffer
    End Function

    Public Sub WrtMem(pOffset As Integer, pBytes As Byte())
        WriteProcessMemory(ProcHandle, pOffset, pBytes, pBytes.Length, 0)
    End Sub

    Public Function rdInt(pOffset As Integer) As Integer
        Return BitConverter.ToInt32(rdMem(pOffset, 4), 0)
    End Function

    Public Sub WrtInt(pOffset As Integer, pBytes As Integer)
        WrtMem(pOffset, BitConverter.GetBytes(pBytes))
    End Sub

    Public Function rdShort(pOffset As Integer) As Short
        Return BitConverter.ToInt16(rdMem(pOffset, 4), 0)
    End Function

    Public Sub WrtShort(pOffset As Integer, pBytes As Short)
        WrtMem(pOffset, BitConverter.GetBytes(pBytes))
    End Sub

    Public Function rdFloat(pOffset As Integer) As Single
        Return BitConverter.ToSingle(rdMem(pOffset, 4), 0)
    End Function

    Public Sub WrtFloat(pOffset As Integer, pBytes As Single)
        WrtMem(pOffset, BitConverter.GetBytes(pBytes))
    End Sub

    Public Sub WrtByte(pOffset As Integer, pBytes As Byte)
        WrtMem(pOffset, BitConverter.GetBytes(CShort(pBytes)))
    End Sub

    Public Function ReadMemory(Of T)(address As Integer) As T
        Dim buffer As Byte()
        Dim length As Integer = Marshal.SizeOf(GetType(T))

        If GetType(T) Is GetType(Byte()) Then
            buffer = New Byte(length - 1) {}
        Else
            buffer = New Byte(Marshal.SizeOf(GetType(T)) - 1) {}
        End If

        If Not ReadProcessMemory(ProcHandle, New IntPtr(address), buffer, New IntPtr(buffer.Length), IntPtr.Zero) Then Return Nothing

        If GetType(T) Is GetType(Byte()) Then Return CType(CType(buffer, Object), T)

        Dim gcHandle As GCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned)
        Dim returnObject As T
        returnObject = CType(Marshal.PtrToStructure(gcHandle.AddrOfPinnedObject, GetType(T)), T)
        gcHandle.Free()
        Return returnObject
    End Function

    Public Function rdString(address As Integer) As String
        Dim buffer As Byte() = New Byte(27) {}
        ReadProcessMemory(ProcHandle, address, buffer, buffer.Length, 0)
        Return Encoding.Unicode.GetString(buffer).Trim
    End Function

    Public Function rdStringASCII(address As Integer) As String
        Dim buffer As Byte() = New Byte(27) {}
        ReadProcessMemory(ProcHandle, address, buffer, buffer.Length, 0)
        Return Encoding.ASCII.GetString(buffer).Trim
    End Function

    Public Sub WriteStruct(Of T)(address As Integer, mystruct As T)
        Dim Ptr As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(mystruct))
        Dim ByteArray(Marshal.SizeOf(mystruct) - 1) As Byte

        Marshal.StructureToPtr(mystruct, Ptr, False)

        Marshal.Copy(Ptr, ByteArray, 0, Marshal.SizeOf(mystruct))
        Marshal.FreeHGlobal(Ptr)

        WrtMem(address, ByteArray)
    End Sub
End Class


Public Class cray
    Dim origin, direction, directionInverse As Vec3

    Public Sub Ray(_origin As Vec3, _direction As Vec3)
        origin = _origin
        direction = _direction

        directionInverse.x = 1.0F / direction.x
        directionInverse.y = 1.0F / direction.y
        directionInverse.z = 1.0F / direction.z
    End Sub

    Public Sub New(_origin As Vec3, _direction As Vec3)
        origin = _origin
        direction = _direction
        directionInverse = New Vec3(1.0F / direction.x, 1.0F / direction.y, 1.0F / direction.z)
    End Sub

    Public Shared Function AngleToDirection(angle As Vec3) As Vec3
        angle.x = angle.x * 3.14159265 / 180
        angle.y = angle.y * 3.14159265 / 180

        Dim sinYaw As Single = Sin(angle.y)
        Dim cosYaw As Single = Cos(angle.y)

        Dim sinPitch As Single = Sin(angle.x)
        Dim cosPitch As Single = Cos(angle.x)

        Dim direction As Vec3 = angle
        direction.x = cosPitch * cosYaw
        direction.y = cosPitch * sinYaw
        direction.z = -sinPitch

        Return direction
    End Function

    Public Function Trace(leftbottom As Vec3, righttop As Vec3, ByRef distance As Single) As Boolean

        If (direction.x = 0.0F And (origin.x < Min(leftbottom.x, righttop.x) Or origin.x > Max(leftbottom.x, righttop.x))) Then Return False

        If (direction.y = 0.0F And (origin.y < Min(leftbottom.y, righttop.y) Or origin.y > Max(leftbottom.y, righttop.y))) Then Return False


        If direction.z = 0.0F And (origin.z < Min(leftbottom.z, righttop.z Or origin.z > Max(leftbottom.z, righttop.z))) Then Return False

        Dim t1 As Single = (leftbottom.x - origin.x) * directionInverse.x
        Dim t2 As Single = (righttop.x - origin.x) * directionInverse.x
        Dim t3 As Single = (leftbottom.y - origin.y) * directionInverse.y
        Dim t4 As Single = (righttop.y - origin.y) * directionInverse.y
        Dim t5 As Single = (leftbottom.z - origin.z) * directionInverse.z
        Dim t6 As Single = (righttop.z - origin.z) * directionInverse.z


        Dim tmin As Single = Max(Max(Min(t1, t2), Min(t3, t4)), Min(t5, t6))
        Dim tmax As Single = Min(Min(Max(t1, t2), Max(t3, t4)), Max(t5, t6))

        If tmax < 0 Then
            distance = tmax
            Return False
        End If


        If tmin > tmax Then
            distance = tmax
            Return False
        End If

        distance = tmin
        Return True
    End Function
End Class

Public Class cUsefulFuncs

    <DllImport("user32.dll")>
    Shared Function GetAsyncKeyState(ByVal vKey As Integer) As Short
    End Function

    Public Shared Sub sleep(amount As Integer)
        Threading.Thread.Sleep(amount)
    End Sub
    Public Shared Sub wl(text As String)
        Console.WriteLine(text)
    End Sub

    Public Shared Function ConvertToBinary(xValue As Long, maxpower As Integer) As String
        Dim i As Long, x As Long, bin As String
        bin = ""
        x = xValue

        If x > 2 ^ maxpower Then Return Nothing

        If x < 0 Then bin = bin + "1" Else bin = bin + "0"

        For i = maxpower To 0 Step -1
            If x And (2 ^ i) Then
                bin = bin + "1"
            Else
                bin = bin + "0"
            End If
        Next
        Return bin
    End Function

#Region "Caption/ WindowText"

    <DllImport("user32.dll")>
    Public Shared Function GetForegroundWindow() As IntPtr
    End Function

    <DllImport("user32.dll", EntryPoint:="GetWindowText")>
    Public Shared Function GetWindowText(ByVal hwnd As Integer, ByVal lpString As System.Text.StringBuilder, ByVal cch As Integer) As Integer
    End Function

    Public Shared Function GetCaption() As String
        Dim Caption As New System.Text.StringBuilder(256)
        Dim hWnd As IntPtr = GetForegroundWindow()
        GetWindowText(hWnd, Caption, Caption.Capacity)
        Return Caption.ToString()
    End Function
#End Region

    Public Shared Sub CheckIfAppIsAllreadyRunning()
        Dim pProcess As Process() = Process.GetProcessesByName("Cheat_Name")
        Dim pID As Integer = Process.GetCurrentProcess.Id
        For i = 0 To pProcess.Length - 1
            If pProcess(i).Id <> pID Then pProcess(i).Kill()
        Next
    End Sub

    Public Shared Sub RestartIfCsgoNotValid()
        If Process.GetProcessesByName("csgo").Length <= 0 Then
            Dim RunningProcess() As Process = Process.GetProcessesByName("Cheat_Name")
            Dim ProgramPath As String = RunningProcess(0).MainModule.FileName
            RunningProcess(0).Kill()
            Process.Start(ProgramPath)
        End If
    End Sub
End Class

Public Structure Vec3

    Public x As Single
    Public y As Single
    Public z As Single

    Public Function Length()
        If x < 0 Then x *= -1
        If y < 0 Then y *= -1
        If z < 0 Then z *= -1
        Return Math.Sqrt(x * x + y * y + z * y)
    End Function

    Public Function tostring() As String
        Return (x & " " & y & " " & z)
    End Function

    Public Sub New(_x As Single, _y As Single, _z As Single)
        x = _x
        y = _y
        z = _z
    End Sub

    Public Shared Operator -(vec1 As Vec3, vec2 As Vec3) As Vec3
        Return New Vec3(vec1.x - vec2.x, vec1.y - vec2.y, vec1.z - vec2.z)
    End Operator

    Public Shared Operator +(vec1 As Vec3, vec2 As Vec3) As Vec3
        Return New Vec3(vec1.x + vec2.x, vec1.y + vec2.y, vec1.z + vec2.z)
    End Operator

    Public Shared Operator *(vec1 As Vec3, vec2 As Vec3) As Vec3
        Return New Vec3(vec1.x * vec2.x, vec1.y * vec2.y, vec1.z * vec2.z)
    End Operator

    Public Shared Operator *(vec1 As Vec3, multiplier As Single) As Vec3
        Return New Vec3(vec1.x * multiplier, vec1.y * multiplier, vec1.z * multiplier)
    End Operator

    Public Shared Operator <>(vec1 As Vec3, vec2 As Vec3) As Boolean
        If vec1.x <> vec2.x Or vec1.y <> vec2.y Or vec1.z <> vec2.z Then Return True : Return False
    End Operator

    Public Shared Operator =(vec1 As Vec3, vec2 As Vec3) As Boolean
        If vec1.x = vec2.x And vec1.y = vec2.y And vec1.z = vec2.z Then Return True : Return False
    End Operator

    Public Shared Operator /(vec1 As Vec3, vec2 As Vec3) As Vec3
        Return New Vec3(vec1.x / vec2.x, vec1.y / vec2.y, vec1.z / vec2.z)
    End Operator

    Public Shared Operator /(vec1 As Vec3, divisor As Single) As Vec3
        Return New Vec3(vec1.x / divisor, vec1.y / divisor, vec1.z / divisor)
    End Operator
End Structure

Public Class cSDK
    Public Const MAXPLAYERS = 32
    Public Const GameCaption As String = "Counter-Strike: Global Offensive"

    Public Shared Caption As String = String.Empty
    Public Shared InGame As Boolean
    Public Shared TabX As Boolean

    Public Shared mem As New cMemoryManager
    Public Shared Engine As New cEngine
    Public Shared Settings As New cSettings
    Public Shared FindPattern As New cFindPattern
    Public Shared cfg As New cConfig("C:\Cheat_Name\Config.ini")

    Public Shared Misc As New cMisc
    Public Shared Aimbot As New cAimbot
    Public Shared ESP As New cESP
    Public Shared Triggerbot As New cTriggerbot
    Public Shared SkinChanger As New cSkinchanger

    Public Shared pLocalPlayer As New cBasePlayer(Nothing)
End Class

#End Region

