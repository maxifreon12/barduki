<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SkinList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SkinList))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelSkinID = New System.Windows.Forms.Label()
        Me.r1chB0xT3xt = New System.Windows.Forms.RichTextBox()
        Me.CloseSkinList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(-6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 5)
        Me.Label1.TabIndex = 0
        '
        'LabelSkinID
        '
        Me.LabelSkinID.BackColor = System.Drawing.Color.Transparent
        Me.LabelSkinID.Image = CType(resources.GetObject("LabelSkinID.Image"), System.Drawing.Image)
        Me.LabelSkinID.Location = New System.Drawing.Point(-1, -3)
        Me.LabelSkinID.Name = "LabelSkinID"
        Me.LabelSkinID.Size = New System.Drawing.Size(280, 34)
        Me.LabelSkinID.TabIndex = 1
        '
        'r1chB0xT3xt
        '
        Me.r1chB0xT3xt.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.r1chB0xT3xt.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1chB0xT3xt.ForeColor = System.Drawing.SystemColors.Control
        Me.r1chB0xT3xt.Location = New System.Drawing.Point(12, 34)
        Me.r1chB0xT3xt.Name = "r1chB0xT3xt"
        Me.r1chB0xT3xt.ReadOnly = True
        Me.r1chB0xT3xt.Size = New System.Drawing.Size(253, 275)
        Me.r1chB0xT3xt.TabIndex = 3
        Me.r1chB0xT3xt.Text = resources.GetString("r1chB0xT3xt.Text")
        '
        'CloseSkinList
        '
        Me.CloseSkinList.BackColor = System.Drawing.Color.Transparent
        Me.CloseSkinList.Image = CType(resources.GetObject("CloseSkinList.Image"), System.Drawing.Image)
        Me.CloseSkinList.Location = New System.Drawing.Point(264, 0)
        Me.CloseSkinList.Name = "CloseSkinList"
        Me.CloseSkinList.Size = New System.Drawing.Size(15, 15)
        Me.CloseSkinList.TabIndex = 4
        '
        'SkinList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(279, 323)
        Me.Controls.Add(Me.CloseSkinList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.r1chB0xT3xt)
        Me.Controls.Add(Me.LabelSkinID)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SkinList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheat_Name"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelSkinID As Label
    Friend WithEvents r1chB0xT3xt As RichTextBox
    Friend WithEvents CloseSkinList As Label
End Class
