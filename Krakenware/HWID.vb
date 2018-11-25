Imports System.Management
Imports System.IO
Imports Cheat_Name
Imports System.Text

Imports System.Security.Cryptography

Public Class HWID
    Shared Function GetAsyncKeyState(ByVal vKey As Integer) As Short
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Generate HWID

        Dim hw As New clsComputerInfo

        Dim hdd As String
        Dim cpu As String
        Dim mb As String
        Dim mac As String
        Dim hwid As String

        cpu = hw.GetProcessorId()
        hdd = hw.GetVolumeSerial("C")
        mb = hw.GetMotherBoardID()
        mac = hw.GetMACAddress()
        hwid = cpu + hdd + mb + mac

        Dim hwidEncrypted As String = Strings.UCase(hw.Encrypt(cpu & hdd & mb & mac))

        txtHWID.Text = hwidEncrypted
        Label5.Text = Environment.UserName

        Dim WC As New System.Net.WebClient


        'Just if you are online.
        Dim addressonline As String = "https://your.site/online.txt"
        Dim clientonline As System.Net.WebClient = New System.Net.WebClient()
        Dim readeronline As StreamReader = New StreamReader(clientonline.OpenRead(addressonline))
        Labelonline.Text = readeronline.ReadToEnd

        'Just when you delete the On.txt file
        Dim addressoffline As String = "https://your.site/offline.txt"
        Dim clientoffline As System.Net.WebClient = New System.Net.WebClient()
        Dim readeroffline As StreamReader = New StreamReader(clientoffline.OpenRead(addressoffline))
        LabelOffline.Text = readeroffline.ReadToEnd

        'Here you could use some url with the ON.txt file, the cheat will check if the url exist and it will work.
        Try
            My.Computer.Network.Ping("https://your.site/ON.txt")
            lblNetwork.ForeColor = Color.Green
            lblNetwork.Text = "Online!"
        Catch
            lblNetwork.ForeColor = Color.Red
            lblNetwork.Text = "Offline!"
        End Try

        MsgBox("Put the cheat inside a USB.")

        If Not System.IO.Directory.Exists("C:\Cheat_Name") Then
            Directory.CreateDirectory("C:\Cheat_Name")
        End If
    End Sub

    Public Class clsComputerInfo

        Friend Function GetProcessorId() As String
            Dim strProcessorId As String = String.Empty
            Dim query As New SelectQuery("Win32_processor")
            Dim search As New ManagementObjectSearcher(query)
            Dim info As ManagementObject

            For Each info In search.Get()
                strProcessorId = info("processorId").ToString()
            Next
            Return strProcessorId

        End Function

        Friend Function GetMACAddress() As String

            Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            Dim MACAddress As String = String.Empty
            For Each mo As ManagementObject In moc

                If (MACAddress.Equals(String.Empty)) Then
                    If CBool(mo("IPEnabled")) Then MACAddress = mo("MacAddress").ToString()

                    mo.Dispose()
                End If
                MACAddress = MACAddress.Replace(":", String.Empty)

            Next
            Return MACAddress
        End Function

        Friend Function GetVolumeSerial(Optional ByVal strDriveLetter As String = "C") As String

            Dim disk As ManagementObject = New ManagementObject(String.Format("win32_logicaldisk.deviceid=""{0}:""", strDriveLetter))
            disk.Get()
            Return disk("VolumeSerialNumber").ToString()
        End Function

        Friend Function GetMotherBoardID() As String

            Dim strMotherBoardID As String = String.Empty
            Dim query As New SelectQuery("Win32_BaseBoard")
            Dim search As New ManagementObjectSearcher(query)
            Dim info As ManagementObject
            For Each info In search.Get()

                strMotherBoardID = info("product").ToString()

            Next
            Return strMotherBoardID

        End Function


        Friend Function getMD5Hash(ByVal strToHash As String) As String
            Dim md5Obj As New Security.Cryptography.MD5CryptoServiceProvider
            Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

            bytesToHash = md5Obj.ComputeHash(bytesToHash)

            Dim strResult As String = ""

            For Each b As Byte In bytesToHash
                strResult += b.ToString("x2")
            Next

            Return strResult
        End Function

        ' You can use this instead of getMD5Hash if you want. This encryption method can be decrypted with the code below.
        Friend Function Encrypt(ByVal plainText As String) As String

            Dim passPhrase As String = "yourPassPhrase"
            Dim saltValue As String = "mySaltValue"
            Dim hashAlgorithm As String = "MD5"

            Dim passwordIterations As Integer = 2
            Dim initVector As String = "@1B2c3D4e5F6g7H8"
            Dim keySize As Integer = 256

            Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
            Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

            Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)


            Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

            Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
            Dim symmetricKey As New RijndaelManaged()

            symmetricKey.Mode = CipherMode.CBC

            Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

            Dim memoryStream As New MemoryStream()
            Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
            cryptoStream.FlushFinalBlock()
            Dim cipherTextBytes As Byte() = memoryStream.ToArray()
            memoryStream.Close()
            cryptoStream.Close()
            Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
            Return cipherText
        End Function
        ' Decrypt code
        Friend Function Decrypt(ByVal cipherText As String) As String
            Dim passPhrase As String = "yourPassPhrase"
            Dim saltValue As String = "mySaltValue"
            Dim hashAlgorithm As String = "MD5"

            Dim passwordIterations As Integer = 2
            Dim initVector As String = "@1B2c3D4e5F6g7H8"
            Dim keySize As Integer = 256
            ' Convert strings defining encryption key characteristics into byte
            ' arrays. Let us assume that strings only contain ASCII codes.
            ' If strings include Unicode characters, use Unicode, UTF7, or UTF8
            ' encoding.
            Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
            Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

            ' Convert our ciphertext into a byte array.
            Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)

            ' First, we must create a password, from which the key will be 
            ' derived. This password will be generated from the specified 
            ' passphrase and salt value. The password will be created using
            ' the specified hash algorithm. Password creation can be done in
            ' several iterations.
            Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

            ' Use the password to generate pseudo-random bytes for the encryption
            ' key. Specify the size of the key in bytes (instead of bits).
            Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)

            ' Create uninitialized Rijndael encryption object.
            Dim symmetricKey As New RijndaelManaged()

            ' It is reasonable to set encryption mode to Cipher Block Chaining
            ' (CBC). Use default options for other symmetric key parameters.
            symmetricKey.Mode = CipherMode.CBC

            ' Generate decryptor from the existing key bytes and initialization 
            ' vector. Key size will be defined based on the number of the key 
            ' bytes.
            Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

            ' Define memory stream which will be used to hold encrypted data.
            Dim memoryStream As New MemoryStream(cipherTextBytes)

            ' Define cryptographic stream (always use Read mode for encryption).
            Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)

            ' Since at this point we don't know what the size of decrypted data
            ' will be, allocate the buffer long enough to hold ciphertext;
            ' plaintext is never longer than ciphertext.
            Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}

            ' Start decrypting.
            Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)

            ' Close both streams.
            memoryStream.Close()
            cryptoStream.Close()

            ' Convert decrypted data into a string. 
            ' Let us assume that the original plaintext string was UTF8-encoded.
            Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)

            ' Return decrypted string.   
            Return plainText
        End Function

    End Class

    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        Dim WC As New System.Net.WebClient

        Try
            Dim http3 As String = WC.DownloadString("https://your.site/hwid.txt")
            Dim http3banned As String = WC.DownloadString("https://your.site/hwidbanned.txt")
            If http3.Contains(txtHWID.Text) Then
                Me.Hide()
                UpdaterForm.Show()
            ElseIf http3banned.Contains(txtHWID.Text) Then
                MessageBox.Show("You has been banned from Cheat_Name, please contact me on discord: Discord#1337", "Cheat_Name")
                Application.Exit()
                Me.Close()
            Else
                MsgBox("Wrong HWID!")
                Me.Close()
                Application.Exit()
            End If


        Catch
            MsgBox("Offline")
            Me.Close()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Close()
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Dim xpos As Integer
    Dim ypos As Integer
    Dim drag As Boolean
    Dim offSetX As Integer
    Dim offSetY As Integer
    Private Sub topperino_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = True
            xpos = Cursor.Position.X - Me.Left
            ypos = Cursor.Position.Y - Me.Top
        End If
    End Sub
    Private Sub topperino_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - xpos
            Me.Top = Cursor.Position.Y - ypos
        End If
    End Sub
    Private Sub topperino_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        drag = False
    End Sub
End Class