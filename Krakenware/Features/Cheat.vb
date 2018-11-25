Imports Cheat_Name.cSDK
Imports Cheat_Name.Offsets
Imports Cheat_Name.cUsefulFuncs
Imports Cheat_Name.ENUMS
Imports System.Runtime.InteropServices

#Region "Cheats"

Public Class cAimbot

    Private Target As New cBasePlayer(Nothing)
    Private bOnce As Boolean = True

    Public Sub Aimbot(Aimspot As Integer, Fov As Single, Smooth As Integer, FovPistols As Single, SmoothPistol As Integer, FovSnipers As Single, SmoothSnipers As Integer)
        If GetAsyncKeyState(KeyBinds.AimbotKey) Then
            If pLocalPlayer.ActiveWeapon.Clip > 0 Then

                Dim _FOV As Single
                Dim _Smooth As Integer
                Dim _StopAfter1Shot As Boolean

                Select Case pLocalPlayer.ActiveWeapon.Type
                    Case ENUMS.WeaponType.Pistol
                        _FOV = My.Settings.FovPistols
                        _Smooth = My.Settings.SmoothPistols
                        _StopAfter1Shot = True
                        Aimspot = Aimspot
                    Case ENUMS.WeaponType.Sniper
                        _FOV = My.Settings.FovSnipers
                        _Smooth = My.Settings.SmoothSnipers
                        _StopAfter1Shot = False
                        Aimspot = 8
                    Case ENUMS.WeaponType.Rifle
                        _FOV = My.Settings.FovRifles
                        _Smooth = My.Settings.SmoothRifles
                        _StopAfter1Shot = True
                        Aimspot = Aimspot

                        'If you want to make another My.Settings.SmoothSMG-Heavy-Shotgun, do it yourself. 

                    Case ENUMS.WeaponType.SMG
                        _FOV = My.Settings.FovRifles
                        _Smooth = My.Settings.SmoothRifles
                        _StopAfter1Shot = True
                        Aimspot = Aimspot
                    Case ENUMS.WeaponType.Heavy
                        _FOV = My.Settings.FovRifles
                        _Smooth = My.Settings.SmoothRifles
                        _StopAfter1Shot = True
                        Aimspot = Aimspot
                    Case ENUMS.WeaponType.Shotgun
                        _FOV = My.Settings.FovRifles
                        _Smooth = My.Settings.SmoothRifles
                        _StopAfter1Shot = True
                        Aimspot = Aimspot
                    Case Else
                        _FOV = My.Settings.FovRifles
                        _Smooth = My.Settings.SmoothRifles
                        _StopAfter1Shot = True
                        Aimspot = Aimspot
                End Select

                If bOnce Then
                    _FOV /= 10

                    If GetTargetFov(Aimspot, Settings.RangeBased) <= _FOV Then
                        If Not Target.ptr = Nothing Then bOnce = False
                    Else
                        bOnce = True
                    End If
                End If

                If Not bOnce And Target.ptr And Not Target.isJumping Then

                    Dim Ang As New Vec3(0, 0, 0)

                    If _StopAfter1Shot And pLocalPlayer.ShotsFired < 9999 Then
                        Dim Aimspot2 As Integer = 8
                        If pLocalPlayer.ActiveWeapon.ID = ENUMS.WeaponType.AWP Then Aimspot2 = 5
                        Ang = SmoothAng(ClampAngle(CalcAngle(pLocalPlayer.OriginVec, Target.BonePosition(Aimspot2), pLocalPlayer.PunchAngle, pLocalPlayer.ViewOffset, 2, 2)), _Smooth)
                    ElseIf Not _StopAfter1Shot And Target.SpottedByMask Then
                        Ang = SmoothAng(ClampAngle(CalcAngle(pLocalPlayer.OriginVec, Target.BonePosition(Aimspot), pLocalPlayer.PunchAngle, pLocalPlayer.ViewOffset, 2, 2)), _Smooth)
                    End If

                    If Ang.x + Ang.y + Ang.z <> 0 Then Engine.SetAngles(ClampAngle(Ang))

                End If

                If Not IsValid(Target) Then
                    bOnce = True
                End If

            End If
        Else
            bOnce = True
        End If
    End Sub

#Region "Stuff"
    Private Function IsValid(trgt As cBasePlayer)
        If trgt.Health > 0 And Not trgt.Dormant Then Return True Else Return False
    End Function

    Private Function GetTargetFov(Bone As Integer, Rangebased As Boolean) As Single
        If Rangebased Then
            Return GetNextEnemyToCrosshairRangebased(Bone, Target.ptr) / 10
        Else
            Return GetNextEnemyToCrosshair(Bone, Target.ptr)
        End If
    End Function

    Public Function GetNextEnemyToCrosshairRangebased(Bone As Integer, ByRef pPointer As Integer) As Single
        Dim Fov As Single
        Dim pAngles As Vec3 = Engine.ViewAngles()

        Dim PlayerArray(32) As Integer
        Dim AngleArray(32) As Single


        For i As Integer = 1 To 32
            Dim CurPlayer As New cBasePlayer(cBasePlayer.PointerByIndex(i))

            Dim pAngle As Vec3 = CurPlayer.BonePosition(Bone)
            pAngle = CalcAngle(pLocalPlayer.OriginVec, pAngle, pLocalPlayer.PunchAngle, pLocalPlayer.ViewOffset, 2, 2)
            pAngle = ClampAngle(pAngle)
            Dim iDiff As Single = Get3dDistance(pAngle, pAngles)

            PlayerArray(i) = CurPlayer.ptr
            AngleArray(i) = iDiff
        Next

        Dim ClosestPlayer As Integer = 0
        Dim ClosestAngle As Single = 360

        For i As Integer = 1 To 32
            Dim pPlayer As New cBasePlayer(PlayerArray(i))
            Dim pAngle As Single = AngleArray(i)

            Dim CurPlayerTeam As Integer = pPlayer.Team
            Dim Dormant As Boolean = pPlayer.Dormant
            Dim Health As Integer = pPlayer.Health

            Dim pOriginVec As Vec3 = pPlayer.OriginVec
            pOriginVec.z += 64

            If CurPlayerTeam <> pLocalPlayer.Team And (Not Dormant) And Health > 0 And pAngle < ClosestAngle Then
                ClosestPlayer = pPlayer.ptr
                ClosestAngle = pAngle
                Fov = pAngle

            End If
        Next

        Dim pNearestPlayer As New cBasePlayer(ClosestPlayer)
        Dim myAngle As Vec3 = ClampAngle(Engine.ViewAngles + pLocalPlayer.PunchAngle)
        Dim enemyAngle As Vec3 = CalcAngle(pLocalPlayer.OriginVec, pNearestPlayer.BonePosition(Bone), pLocalPlayer.PunchAngle, pLocalPlayer.ViewOffset, 2, 2)

        Dim AngleY = enemyAngle.y - myAngle.y
        If AngleY < 0 Then AngleY *= -1

        Dim AngleX = enemyAngle.x - myAngle.x
        If AngleX < 0 Then AngleX *= -1

        Dim r = Get3dDistance(pLocalPlayer.OriginVec, pNearestPlayer.OriginVec)

        Dim FovFractionY = Math.Sqrt(2 * r * r - 2 * r * r * Math.Cos(Deg2Rad(AngleY)))
        Dim FovFractionX = Math.Sqrt(2 * r * r - 2 * r * r * Math.Cos(Deg2Rad(AngleX)))

        Fov = Math.Sqrt((FovFractionY * FovFractionY) + (FovFractionX * FovFractionX))

        pPointer = ClosestPlayer
        Return Fov
    End Function

    Public Function Deg2Rad(input As Integer)
        Return input * Math.PI / 180
    End Function

    Public Function GetNextEnemyToCrosshair(Bone As Integer, ByRef pPointer As Integer) As Single
        Dim Fov As Single
        Dim pAngles As Vec3 = Engine.ViewAngles()

        Dim PlayerArray(32) As Integer
        Dim AngleArray(32) As Single


        For i As Integer = 1 To 32
            Dim CurPlayer As New cBasePlayer(cBasePlayer.PointerByIndex(i))

            Dim pAngle As Vec3 = CurPlayer.BonePosition(Bone)
            pAngle = CalcAngle(pLocalPlayer.OriginVec, pAngle, pLocalPlayer.PunchAngle, pLocalPlayer.ViewOffset, 2, 2)
            pAngle = ClampAngle(pAngle)
            Dim iDiff As Single = Get3dDistance(pAngle, pAngles)

            PlayerArray(i) = CurPlayer.ptr
            AngleArray(i) = iDiff
        Next

        Dim ClosestPlayer As Integer = 0
        Dim ClosestAngle As Single = 360

        For i As Integer = 1 To 32
            Dim pPlayer As New cBasePlayer(PlayerArray(i))
            Dim pAngle As Single = AngleArray(i)

            Dim CurPlayerTeam As Integer = pPlayer.Team
            Dim Dormant As Boolean = pPlayer.Dormant
            Dim Health As Integer = pPlayer.Health

            Dim pOriginVec As Vec3 = pPlayer.OriginVec
            pOriginVec.z += 64

            If CurPlayerTeam <> pLocalPlayer.Team And (Not Dormant) And Health > 0 And pAngle < ClosestAngle Then
                ClosestPlayer = pPlayer.ptr
                ClosestAngle = pAngle
                Fov = pAngle

            End If
        Next
        pPointer = ClosestPlayer
        Return Fov
    End Function

    Private Function CalcAngle(PlayerPosition As Vec3, EnemyPosition As Vec3, PunchAngle As Vec3, ViewOffset As Vec3, YawRecoilReductionFactor As Single, PitchRecoilReductionFactor As Single)
        Dim AimAngle As New Vec3(0, 0, 0)
        Dim Delta As New Vec3(PlayerPosition.x - EnemyPosition.x, PlayerPosition.y - EnemyPosition.y, (PlayerPosition.z + ViewOffset.z) - EnemyPosition.z)
        Dim Hyp As Single = Math.Sqrt(Delta.x * Delta.x + Delta.y * Delta.y)

        AimAngle.x = Math.Atan(Delta.z / Hyp) * 57.29578F - PunchAngle.x * YawRecoilReductionFactor
        AimAngle.y = Math.Atan(Delta.y / Delta.x) * 57.29578F - PunchAngle.y * PitchRecoilReductionFactor
        AimAngle.z = 0

        If Delta.x >= 0.0 Then AimAngle.y += 180.0F
        Return ClampAngle(AimAngle)
    End Function

    Private Function ClampAngle(ViewAngle As Vec3)
        If ViewAngle.x < -89.0F Then ViewAngle.x = -89.0F
        If ViewAngle.x > 89.0F Then ViewAngle.x = 89.0F
        If ViewAngle.y < -180.0F Then ViewAngle.y += 360.0F
        If ViewAngle.y > 180.0F Then ViewAngle.y -= 360.0F
        If ViewAngle.z <> 0.0F Then ViewAngle.z = 0.0F
        Return ViewAngle
    End Function

    Public Function Get3dDistance(PlayerPosition As Vec3, EnemyPosition As Vec3)
        Return Math.Sqrt(Math.Pow(EnemyPosition.x - PlayerPosition.x, 2.0F) + Math.Pow(EnemyPosition.y - PlayerPosition.y, 2.0F) + Math.Pow(EnemyPosition.z - PlayerPosition.z, 2.0F))
    End Function

    Public Function SmoothAng(AimAng As Vec3, SmoothPercent As Single)
        If SmoothPercent <= 10 Then Return ClampAngle(AimAng)
        SmoothPercent = SmoothPercent / 10
        Dim Delta As New Vec3(0, 0, 0)
        Dim ViewAngle As Vec3 = Engine.ViewAngles

        Delta.x = ViewAngle.x - AimAng.x
        Delta.y = ViewAngle.y - AimAng.y
        Delta.z = ViewAngle.z - AimAng.z
        Delta = ClampAngle(Delta)

        AimAng.x = ViewAngle.x - Delta.x / SmoothPercent
        AimAng.y = ViewAngle.y - Delta.y / SmoothPercent
        AimAng.z = ViewAngle.z - Delta.z / SmoothPercent

        Return ClampAngle(AimAng)
    End Function
#End Region

End Class

Public Class cTriggerbot

    Private pTriggerPlayer As New cBasePlayer(Nothing)

    Public Sub Triggerbot(Mode As Integer)

        If GetAsyncKeyState(KeyBinds.TriggerKey) Then
            If Mode = 1 Then
                '<< casual incross trigger >>
                Dim IncrossIndex As Integer = pLocalPlayer.IncrossIndex
                If IncrossIndex > 0 And IncrossIndex < 65 Then
                    pTriggerPlayer.ptr = cBasePlayer.PointerByIndex(IncrossIndex)
                    If Not pTriggerPlayer.Team = pLocalPlayer.Team Then
                        Dim WeaponId As Integer = pLocalPlayer.ActiveWeapon.ID
                        If WeaponId <> ENUMS.ItemDefinitionIndex.TASER Then
                            cBasePlayer.ForceAttack(0, 12, 10)
                        ElseIf WeaponId = ENUMS.ItemDefinitionIndex.TASER And GetDistance(pLocalPlayer.OriginVec, pTriggerPlayer.OriginVec) <= 128 Then
                            cBasePlayer.ForceAttack(0, 12, 10)
                        End If

                        If WeaponId <> ENUMS.WeaponType.Sniper Then
                            cBasePlayer.ForceAttack(450, 0, 0)
                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Function GetDistance(v1 As Vec3, v2 As Vec3) As Single

        Return Math.Sqrt((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y) + (v1.z - v2.z) * (v1.z - v2.z))
    End Function
End Class

Public Class cSkinchanger

    Public Shared sDEAGLE = My.Settings.Deagle
    Public Shared sDUALS = 11
    Public Shared sFIVESEVEN = My.Settings.FiveSeven
    Public Shared sGLOCK = My.Settings.Glock
    Public Shared sAK47 = My.Settings.AK47
    Public Shared sAUG = My.Settings.Aug
    Public Shared sAWP = My.Settings.Awp
    Public Shared sFAMAS = My.Settings.Famas
    Public Shared sG3SG1 = My.Settings.Tecott
    Public Shared sGALILAR = My.Settings.Galil
    Public Shared sM249 = My.Settings.Xms
    Public Shared sM4A4 = My.Settings.M4A4
    Public Shared sMAC10 = 38
    Public Shared sP90 = 38
    Public Shared sMP5 = 38
    Public Shared sUMP45 = 38
    Public Shared sXM1014 = 38
    Public Shared sBIZON = My.Settings.Bizon
    Public Shared sMAG7 = 38
    Public Shared sNEGEV = 38
    Public Shared sSAWEDOFF = 38
    Public Shared sTEC9 = My.Settings.Tec9
    Public Shared sP2000 = My.Settings.P250
    Public Shared sMP7 = 38
    Public Shared sMP9 = 38
    Public Shared sNOVA = 38
    Public Shared sP250 = My.Settings.P250
    Public Shared sSCAR20 = My.Settings.Tecoct
    Public Shared sSG556 = My.Settings.Sg350
    Public Shared sSSG08 = My.Settings.Scout
    Public Shared sM4A1 = My.Settings.M4A1
    Public Shared sUSP = My.Settings.Usp
    Public Shared sCZ75A = My.Settings.Cz
    Public Shared sREVOLVER = My.Settings.Revolver

    Private rnd As New Random
    Private pWeapon As New cBaseWeapon(Nothing)

    Public Sub sSkinchanger()


        For i = 1 To 9
            Dim curWeaponIndex As Integer = mem.rdInt(pLocalPlayer.ptr + m_hMyWeapons + ((i - 1) * &H4)) And &HFFF
            Dim curWeaponEnt As Integer = mem.rdInt(mem.ClientpanoramaDLL + dwEntityList + (curWeaponIndex - 1) * &H10)
            pWeapon.ptr = curWeaponEnt
            Dim Xuid As Integer = pLocalPlayer.ActiveWeapon.XuID
            mem.WrtInt(pWeapon.ptr + m_iItemIDHigh, -1)
            mem.WrtInt(pWeapon.ptr + m_OriginalOwnerXuidLow, 0)
            mem.WrtInt(pWeapon.ptr + m_OriginalOwnerXuidHigh, 0)
            mem.WrtInt(pWeapon.ptr + m_nFallbackPaintKit, GetWeaponSkin(pWeapon.ID))
            mem.WrtInt(pWeapon.ptr + m_nFallbackSeed, rnd.Next(1, Integer.MaxValue - 1))
            mem.WrtFloat(pWeapon.ptr + m_flFallbackWear, 0.001)
            mem.WrtInt(pWeapon.ptr + m_iAccountID, Xuid)
        Next
    End Sub

    Private Function GetWeaponSkin(WeaponID As Integer)

        Select Case WeaponID
            Case ItemDefinitionIndex.AK47
                Return sAK47

            Case ItemDefinitionIndex.AUG
                Return sAUG

            Case ItemDefinitionIndex.AWP
                Return sAWP

            Case ItemDefinitionIndex.BIZON
                Return sBIZON

            Case ItemDefinitionIndex.CZ75A
                Return sCZ75A

            Case ItemDefinitionIndex.DEAGLE
                Return sDEAGLE

            Case ItemDefinitionIndex.ELITE
                Return sDUALS

            Case ItemDefinitionIndex.FAMAS
                Return sFAMAS

            Case ItemDefinitionIndex.FIVESEVEN
                Return sFIVESEVEN

            Case ItemDefinitionIndex.G3SG1
                Return sG3SG1

            Case ItemDefinitionIndex.GALILAR
                Return sGALILAR

            Case ItemDefinitionIndex.GLOCK
                Return sGLOCK

            Case ItemDefinitionIndex.M249
                Return sM249

            Case ItemDefinitionIndex.M4A1
                Return sM4A1

            Case ItemDefinitionIndex.M4A4
                Return sM4A4

            Case ItemDefinitionIndex.MAC10
                Return sMAC10

            Case ItemDefinitionIndex.MAG7
                Return sMAG7

            Case ItemDefinitionIndex.MP7
                Return sMP7

            Case ItemDefinitionIndex.MP9
                Return sMP9

            Case ItemDefinitionIndex.NEGEV
                Return sNEGEV

            Case ItemDefinitionIndex.NOVA
                Return sNOVA
            Case ItemDefinitionIndex.P2000
                Return sP2000
            Case ItemDefinitionIndex.P250
                Return sP250
            Case ItemDefinitionIndex.P90
                Return sP90
            Case ItemDefinitionIndex.REVOLVER
                Return sREVOLVER
            Case ItemDefinitionIndex.SAWEDOFF
                Return sSAWEDOFF
            Case ItemDefinitionIndex.SCAR20
                Return sSCAR20
            Case ItemDefinitionIndex.SG556
                Return sSG556
            Case ItemDefinitionIndex.SSG08
                Return sSSG08
            Case ItemDefinitionIndex.TEC9
                Return sTEC9
            Case ItemDefinitionIndex.MP5SD
                Return sMP5
            Case ItemDefinitionIndex.UMP45
                Return sUMP45
            Case ItemDefinitionIndex.USP
                Return sUSP
            Case ItemDefinitionIndex.XM1014
                Return sXM1014
            Case Else
                Return False
        End Select
    End Function
End Class

Public Class cMisc

    Private pRadarPlayer As New cBasePlayer(Nothing)

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

    Public Sub Noflash(value As Integer)
        If pLocalPlayer.FlashMaxAlpha <> value Then
            mem.WrtFloat(pLocalPlayer.ptr + m_flFlashMaxAlpha, value)
        End If

    End Sub

    Public Sub Radar()
        For i = 1 To MAXPLAYERS
            pRadarPlayer.ptr = cBasePlayer.PointerByIndex(i)
            If pRadarPlayer.Spotted = 0 And pRadarPlayer.Health > 0 And Not pRadarPlayer.Dormant Then mem.WrtInt(pRadarPlayer.ptr + m_bSpotted, 1)
        Next

    End Sub

    Private b0nce As Boolean = False
End Class

Public Class KeyBinds
    Public Shared TriggerKey = 6
    Public Shared AimbotKey = 1
    Public Shared SkinchangerKey = 165
    Public Shared UnloadCheat = 45
    Public Shared SkinIDS = -1
End Class

Public Class SkinChangerList
    'add the other weapons yourself.
    Public Shared AK47 = My.Settings.AK47
    Public Shared M4A1 = My.Settings.M4A1
    Public Shared M4A1S = My.Settings.M4A4
    Public Shared Galil = My.Settings.Galil
    Public Shared Aug = My.Settings.Aug
    Public Shared SG350 = My.Settings.SG350
    Public Shared Famas = My.Settings.Famas
    Public Shared Awp = My.Settings.Awp
    Public Shared Scout = My.Settings.Scout
    Public Shared TecoCT = My.Settings.Tecoct
    Public Shared TecoTT = My.Settings.Tecott
    Public Shared XMS = My.Settings.Xms
    Public Shared Bizon = My.Settings.Bizon
    Public Shared Tec9 = My.Settings.Tec9
    Public Shared Deagle = My.Settings.Deagle
    Public Shared Glock = My.Settings.Glock
    Public Shared Usp = My.Settings.Usp
    Public Shared Revolver = My.Settings.Revolver
    Public Shared CZ = My.Settings.Cz
    Public Shared P250 = My.Settings.P250
    Public Shared FiveSeven = My.Settings.FiveSeven
End Class

Public Class cESP
    Public Shared pEspPlayer As New cBasePlayer(Nothing)
    Dim rnd As New Random

    Public Structure Color_t
        Dim R As Single
        Dim G As Single
        Dim B As Single
        Dim A As Single
    End Structure

    Public Structure GlowObject_t
        Dim pEntity As Integer
        Dim r As Single
        Dim g As Single
        Dim b As Single
        Dim a As Single
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)>
        Public unk1 As Byte()
        Dim RenderWhenOccluded As Boolean
        Dim RenderWhenUnoccluded As Boolean
        Dim FullBloom As Boolean
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=12)>
        Public unk2 As Byte()
    End Structure

    Public Structure clr_s
        Dim r As Byte
        Dim g As Byte
        Dim b As Byte
        Dim a As Byte
    End Structure

    Public clr As New clr_s
    Dim Col As New Color_t

    Public Sub GlowESP(Esp As Boolean, ModelColor As Boolean, Mode As Integer)
        If Mode = 1 Then
            GlowESPplayersonly(Esp, ModelColor)
        ElseIf Mode = 2 Then
            GlowESPall(Esp, ModelColor)
        End If
    End Sub

    Public Sub GlowESPplayersonly(Esp As Boolean, ModelColor As Boolean)
        For i = 1 To MAXPLAYERS
            pEspPlayer.ptr = cBasePlayer.PointerByIndex(i)

            If pEspPlayer.Dormant Then Continue For
            If pEspPlayer.Health < 1 Then Continue For
            If pEspPlayer.Team = pLocalPlayer.Team Then Continue For

            If Esp And pEspPlayer.SpottedByMask Then
                pEspPlayer.Glow(My.Settings.ESPcolorEnemyVisR / 255, My.Settings.ESPcolorEnemyVisG / 255, My.Settings.ESPcolorEnemyVisB / 255, My.Settings.ESPcolorEnemyVis / 255, True, False, False)
            ElseIf Esp Then
                pEspPlayer.Glow(My.Settings.ESPcolorEnemyVisR / 255, My.Settings.ESPcolorEnemyVisG / 255, My.Settings.ESPcolorEnemyVisB / 255, My.Settings.ESPcolorEnemyVis / 255, True, False, False)
            End If

            If ModelColor Then pEspPlayer.clrRender(255, 100, 0, 255)
        Next
    End Sub

    Public GlowObject As GlowObject_t

    Public Sub GlowESPall(Esp As Boolean, ModelColor As Boolean)
        If Not GetAsyncKeyState(KeyBinds.SkinchangerKey) Then
            Dim GlowObjectManager As Integer = mem.rdInt(mem.ClientpanoramaDLL + dwGlowObjectManager)
            Dim GlowObjectCount As Integer = mem.rdInt(mem.ClientpanoramaDLL + dwGlowObjectManager + &H4)

            If GlowObjectCount > 1 Then
                For i = 1 To GlowObjectCount
                    If mem.rdInt(GlowObjectManager + (i * &H38)) Then
                        GlowObject = mem.ReadMemory(Of GlowObject_t)(GlowObjectManager + (i * &H38))
                        If GlowObject.pEntity Then
                            Dim ClassID As Integer = GetClassID(mem.rdInt(GlowObjectManager + (i * &H38)))
                            GlowObject = SetColor(ClassID, GlowObject, mem.rdInt(GlowObjectManager + (i * &H38)))
                            mem.WriteStruct(Of GlowObject_t)(GlowObjectManager + (i * &H38), GlowObject)
                            If ModelColor Then mem.WriteStruct(Of clr_s)(mem.rdInt(GlowObjectManager + (i * &H38)) + m_clrRender, GetRenderColorFromGlowObject(GlowObject))
                        End If
                    End If
                Next
            End If
        End If
    End Sub

    Private Function GetClassID(add As Integer) As Integer
        Dim one As Integer = mem.rdInt(add + &H8)
        Dim two As Integer = mem.rdInt(one + 2 * &H4)
        Dim three As Integer = mem.rdInt(two + 1)
        Dim ClassID As Integer = mem.rdInt(three + 20)
        Return ClassID

    End Function

    Private Function SetColor(cID As Integer, GlowObject As GlowObject_t, ptr As Integer) As GlowObject_t
        Select Case cID
            Case ClassID.CCSPlayer
                pEspPlayer.ptr = ptr
                If pEspPlayer.Team <> pLocalPlayer.Team Then
                    If pEspPlayer.SpottedByMask Then
                        GlowObject.r = Settings.ESPcolorEnemyVis.r / 255
                        GlowObject.g = Settings.ESPcolorEnemyVis.g / 255
                        GlowObject.b = Settings.ESPcolorEnemyVis.b / 255
                        GlowObject.a = Settings.ESPcolorEnemyVis.a / 255

                    Else
                        GlowObject.r = Settings.ESPcolorEnemy.r / 255
                        GlowObject.g = Settings.ESPcolorEnemy.g / 255
                        GlowObject.b = Settings.ESPcolorEnemy.b / 255
                        GlowObject.a = Settings.ESPcolorEnemy.a / 255

                    End If
                Else
                    GlowObject.r = Settings.ESPcolorTeammate.r / 255
                    GlowObject.g = Settings.ESPcolorTeammate.g / 255
                    GlowObject.b = Settings.ESPcolorTeammate.b / 255
                    GlowObject.a = Settings.ESPcolorTeammate.a / 255
                End If

            Case ClassID.CAK47, ClassID.CDEagle, ClassID.CWeaponAug, ClassID.CWeaponBizon, ClassID.CWeaponElite, ClassID.CWeaponGalilAR, ClassID.CWeaponUMP45, ClassID.CWeaponMAC10, ClassID.CWeaponFiveSeven, ClassID.CWeaponTec9, ClassID.CWeaponXM1014, ClassID.CWeaponSawedoff, ClassID.CWeaponAWP, ClassID.CWeaponG3SG1, ClassID.CWeaponGalil, ClassID.CWeaponGlock, ClassID.CWeaponHKP2000, ClassID.CWeaponM249, ClassID.CWeaponM4A1, ClassID.CWeaponM3, ClassID.CWeaponMP7, ClassID.CWeaponMP9, ClassID.CWeaponMP5Navy, ClassID.CWeaponMag7, ClassID.CWeaponNOVA, ClassID.CWeaponNegev, ClassID.CWeaponP250, ClassID.CWeaponP90, ClassID.CWeaponSCAR20, ClassID.CSCAR17, ClassID.CWeaponSG552, ClassID.CWeaponSG556, ClassID.CWeaponSSG08, ClassID.CWeaponBizon, ClassID.CWeaponMP5,
                GlowObject.r = Settings.ESPcolorWeapons.r / 255
                GlowObject.g = Settings.ESPcolorWeapons.g / 255
                GlowObject.b = Settings.ESPcolorWeapons.b / 255
                GlowObject.a = Settings.ESPcolorWeapons.a / 255

            Case ClassID.CBaseCSGrenadeProjectile, ClassID.CDecoyGrenade, ClassID.CDecoyProjectile, ClassID.CHEGrenade, ClassID.CSmokeGrenade, ClassID.CMolotovGrenade, ClassID.CSmokeGrenadeProjectile, ClassID.CMolotovProjectile, ClassID.CIncendiaryGrenade, ClassID.CFlashbang, ClassID.ParticleSmokeGrenade, ClassID.CParticleFire
                GlowObject.r = Settings.ESPcolorGrenades.r / 255
                GlowObject.g = Settings.ESPcolorGrenades.g / 255
                GlowObject.b = Settings.ESPcolorGrenades.b / 255
                GlowObject.a = Settings.ESPcolorGrenades.a / 255

            'Case ClassID.Chicken, ClassID.Hostage, ClassID.HostageCarriableProp
            '    GlowObject.R = 1.0F
            '    GlowObject.G = 0.3F
            '    GlowObject.B = 0.5F

            Case ClassID.CC4, ClassID.CPlantedC4
                GlowObject.r = Settings.ESPcolorBomb.r / 255
                GlowObject.g = Settings.ESPcolorBomb.g / 255
                GlowObject.b = Settings.ESPcolorBomb.b / 255
                GlowObject.a = Settings.ESPcolorBomb.a / 255

            Case Else
                GlowObject.RenderWhenOccluded = False
                GlowObject.RenderWhenUnoccluded = False
                GlowObject.FullBloom = False
                Return GlowObject
        End Select

        GlowObject.RenderWhenOccluded = True
        GlowObject.RenderWhenUnoccluded = False
        GlowObject.FullBloom = False
        Return GlowObject

    End Function

    Public Function GetRenderColorFromGlowObject(GlowObject As GlowObject_t) As clr_s
        clr.r = 255 * GlowObject.r
        clr.g = 255 * GlowObject.g
        clr.b = 255 * GlowObject.b
        clr.a = 255 * GlowObject.a
        Return clr

    End Function
End Class

#End Region