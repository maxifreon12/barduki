<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HWID
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HWID))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadPanel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelOffline = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNetwork = New System.Windows.Forms.Label()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.txtHWID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Labelonline = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoadPanel.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(409, 35)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(-11, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 10)
        Me.Label1.TabIndex = 17
        '
        'LoadPanel
        '
        Me.LoadPanel.BackColor = System.Drawing.Color.White
        Me.LoadPanel.BackgroundImage = CType(resources.GetObject("LoadPanel.BackgroundImage"), System.Drawing.Image)
        Me.LoadPanel.Controls.Add(Me.Label7)
        Me.LoadPanel.Controls.Add(Me.Label6)
        Me.LoadPanel.Controls.Add(Me.LabelOffline)
        Me.LoadPanel.Controls.Add(Me.Label5)
        Me.LoadPanel.Controls.Add(Me.lblNetwork)
        Me.LoadPanel.Controls.Add(Me.btnUnlock)
        Me.LoadPanel.Controls.Add(Me.txtHWID)
        Me.LoadPanel.Controls.Add(Me.Label3)
        Me.LoadPanel.Controls.Add(Me.PictureBox8)
        Me.LoadPanel.Controls.Add(Me.Labelonline)
        Me.LoadPanel.Location = New System.Drawing.Point(9, 37)
        Me.LoadPanel.Name = "LoadPanel"
        Me.LoadPanel.Size = New System.Drawing.Size(385, 228)
        Me.LoadPanel.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(88, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 5)
        Me.Label7.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("GeForce", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(63, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(271, 22)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Open CSGO before click the Load button."
        '
        'LabelOffline
        '
        Me.LabelOffline.BackColor = System.Drawing.Color.Transparent
        Me.LabelOffline.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOffline.ForeColor = System.Drawing.Color.Red
        Me.LabelOffline.Location = New System.Drawing.Point(54, 112)
        Me.LabelOffline.Name = "LabelOffline"
        Me.LabelOffline.Size = New System.Drawing.Size(75, 31)
        Me.LabelOffline.TabIndex = 40
        Me.LabelOffline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(207, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNetwork
        '
        Me.lblNetwork.AutoSize = True
        Me.lblNetwork.BackColor = System.Drawing.Color.Transparent
        Me.lblNetwork.Image = CType(resources.GetObject("lblNetwork.Image"), System.Drawing.Image)
        Me.lblNetwork.Location = New System.Drawing.Point(-253, 149)
        Me.lblNetwork.Name = "lblNetwork"
        Me.lblNetwork.Size = New System.Drawing.Size(29, 13)
        Me.lblNetwork.TabIndex = 7
        Me.lblNetwork.Text = "label"
        '
        'btnUnlock
        '
        Me.btnUnlock.BackColor = System.Drawing.Color.White
        Me.btnUnlock.BackgroundImage = CType(resources.GetObject("btnUnlock.BackgroundImage"), System.Drawing.Image)
        Me.btnUnlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUnlock.Location = New System.Drawing.Point(135, 112)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(107, 31)
        Me.btnUnlock.TabIndex = 2
        Me.btnUnlock.UseVisualStyleBackColor = False
        '
        'txtHWID
        '
        Me.txtHWID.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.txtHWID.ForeColor = System.Drawing.SystemColors.Window
        Me.txtHWID.Location = New System.Drawing.Point(83, 162)
        Me.txtHWID.Name = "txtHWID"
        Me.txtHWID.ReadOnly = True
        Me.txtHWID.Size = New System.Drawing.Size(212, 20)
        Me.txtHWID.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(80, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 92)
        Me.Label3.TabIndex = 10
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox8.Location = New System.Drawing.Point(105, 139)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(110, 33)
        Me.PictureBox8.TabIndex = 38
        Me.PictureBox8.TabStop = False
        '
        'Labelonline
        '
        Me.Labelonline.BackColor = System.Drawing.Color.Transparent
        Me.Labelonline.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelonline.ForeColor = System.Drawing.Color.YellowGreen
        Me.Labelonline.Location = New System.Drawing.Point(248, 112)
        Me.Labelonline.Name = "Labelonline"
        Me.Labelonline.Size = New System.Drawing.Size(75, 31)
        Me.Labelonline.TabIndex = 39
        Me.Labelonline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.Location = New System.Drawing.Point(357, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(384, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HWID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(404, 277)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LoadPanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HWID"
        Me.Text = "HWID"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoadPanel.ResumeLayout(False)
        Me.LoadPanel.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadPanel As Panel
    Friend WithEvents LabelOffline As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNetwork As Label
    Friend WithEvents btnUnlock As Button
    Friend WithEvents txtHWID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Labelonline As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
