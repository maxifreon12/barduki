Imports System.Management
Imports System.IO
Imports System.Net
Imports Cheat_Name

Public Class SkinList
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Dim xpos As Integer
    Dim ypos As Integer
    Dim drag As Boolean
    Dim offSetX As Integer
    Dim offSetY As Integer
    Private Sub topperino_MouseDown(sender As Object, e As MouseEventArgs) Handles LabelSkinID.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = True
            xpos = Cursor.Position.X - Me.Left
            ypos = Cursor.Position.Y - Me.Top
        End If
    End Sub
    Private Sub topperino_MouseMove(sender As Object, e As MouseEventArgs) Handles LabelSkinID.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - xpos
            Me.Top = Cursor.Position.Y - ypos
        End If
    End Sub
    Private Sub topperino_MouseUp(sender As Object, e As MouseEventArgs) Handles LabelSkinID.MouseUp
        drag = False
    End Sub

    Private Sub CloseSkinList_Click(sender As Object, e As EventArgs) Handles CloseSkinList.Click
        Me.Close()
        Close()
        SkinchangerForm.Close()
    End Sub
End Class
