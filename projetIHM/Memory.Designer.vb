<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMemory
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMemory))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabJoueurGame = New System.Windows.Forms.Label()
        Me.LabJoueur = New System.Windows.Forms.Label()
        Me.btnAbandon = New System.Windows.Forms.Button()
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.ImageIndex = 0
        Me.Label1.ImageList = Me.ImageList
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 130)
        Me.Label1.TabIndex = 0
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "BackCard.png")
        Me.ImageList.Images.SetKeyName(1, "Card0.png")
        Me.ImageList.Images.SetKeyName(2, "Card1.png")
        Me.ImageList.Images.SetKeyName(3, "Card2.png")
        Me.ImageList.Images.SetKeyName(4, "Card3.png")
        Me.ImageList.Images.SetKeyName(5, "Card4.png")
        '
        'Label2
        '
        Me.Label2.ImageIndex = 0
        Me.Label2.ImageList = Me.ImageList
        Me.Label2.Location = New System.Drawing.Point(99, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 130)
        Me.Label2.TabIndex = 1
        '
        'LabJoueurGame
        '
        Me.LabJoueurGame.AutoSize = True
        Me.LabJoueurGame.Location = New System.Drawing.Point(22, 9)
        Me.LabJoueurGame.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabJoueurGame.Name = "LabJoueurGame"
        Me.LabJoueurGame.Size = New System.Drawing.Size(48, 13)
        Me.LabJoueurGame.TabIndex = 20
        Me.LabJoueurGame.Text = "Joueur : "
        '
        'LabJoueur
        '
        Me.LabJoueur.AutoSize = True
        Me.LabJoueur.Location = New System.Drawing.Point(74, 9)
        Me.LabJoueur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabJoueur.Name = "LabJoueur"
        Me.LabJoueur.Size = New System.Drawing.Size(57, 13)
        Me.LabJoueur.TabIndex = 21
        Me.LabJoueur.Text = "LabJoueur"
        '
        'btnAbandon
        '
        Me.btnAbandon.Location = New System.Drawing.Point(392, 9)
        Me.btnAbandon.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAbandon.Name = "btnAbandon"
        Me.btnAbandon.Size = New System.Drawing.Size(85, 19)
        Me.btnAbandon.TabIndex = 22
        Me.btnAbandon.Text = "Abandon"
        Me.btnAbandon.UseVisualStyleBackColor = True
        '
        'LabelTimer
        '
        Me.LabelTimer.AutoSize = True
        Me.LabelTimer.Location = New System.Drawing.Point(188, 9)
        Me.LabelTimer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(80, 13)
        Me.LabelTimer.TabIndex = 23
        Me.LabelTimer.Text = "Temps restant :"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.Label3)
        Me.Panel.Controls.Add(Me.Label4)
        Me.Panel.Controls.Add(Me.Label5)
        Me.Panel.Controls.Add(Me.Label6)
        Me.Panel.Controls.Add(Me.Label7)
        Me.Panel.Controls.Add(Me.Label8)
        Me.Panel.Controls.Add(Me.Label16)
        Me.Panel.Controls.Add(Me.Label10)
        Me.Panel.Controls.Add(Me.Label11)
        Me.Panel.Controls.Add(Me.Label12)
        Me.Panel.Controls.Add(Me.Label13)
        Me.Panel.Controls.Add(Me.Label14)
        Me.Panel.Controls.Add(Me.Label15)
        Me.Panel.Controls.Add(Me.Label17)
        Me.Panel.Controls.Add(Me.Label18)
        Me.Panel.Controls.Add(Me.Label19)
        Me.Panel.Controls.Add(Me.Label20)
        Me.Panel.Controls.Add(Me.Label9)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.Label2)
        Me.Panel.Location = New System.Drawing.Point(11, 32)
        Me.Panel.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(478, 563)
        Me.Panel.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.ImageIndex = 0
        Me.Label3.ImageList = Me.ImageList
        Me.Label3.Location = New System.Drawing.Point(193, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 130)
        Me.Label3.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.ImageIndex = 0
        Me.Label4.ImageList = Me.ImageList
        Me.Label4.Location = New System.Drawing.Point(287, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 130)
        Me.Label4.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.ImageIndex = 0
        Me.Label5.ImageList = Me.ImageList
        Me.Label5.Location = New System.Drawing.Point(381, 10)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 130)
        Me.Label5.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.ImageIndex = 0
        Me.Label6.ImageList = Me.ImageList
        Me.Label6.Location = New System.Drawing.Point(5, 146)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 130)
        Me.Label6.TabIndex = 34
        '
        'Label7
        '
        Me.Label7.ImageIndex = 0
        Me.Label7.ImageList = Me.ImageList
        Me.Label7.Location = New System.Drawing.Point(99, 146)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 130)
        Me.Label7.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.ImageIndex = 0
        Me.Label8.ImageList = Me.ImageList
        Me.Label8.Location = New System.Drawing.Point(193, 146)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 130)
        Me.Label8.TabIndex = 32
        '
        'Label16
        '
        Me.Label16.ImageIndex = 0
        Me.Label16.ImageList = Me.ImageList
        Me.Label16.Location = New System.Drawing.Point(9, 426)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 130)
        Me.Label16.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.ImageIndex = 0
        Me.Label10.ImageList = Me.ImageList
        Me.Label10.Location = New System.Drawing.Point(381, 146)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 130)
        Me.Label10.TabIndex = 30
        '
        'Label11
        '
        Me.Label11.ImageIndex = 0
        Me.Label11.ImageList = Me.ImageList
        Me.Label11.Location = New System.Drawing.Point(5, 286)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 130)
        Me.Label11.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.ImageIndex = 0
        Me.Label12.ImageList = Me.ImageList
        Me.Label12.Location = New System.Drawing.Point(99, 286)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 130)
        Me.Label12.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.ImageIndex = 0
        Me.Label13.ImageList = Me.ImageList
        Me.Label13.Location = New System.Drawing.Point(193, 286)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 130)
        Me.Label13.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.ImageIndex = 0
        Me.Label14.ImageList = Me.ImageList
        Me.Label14.Location = New System.Drawing.Point(287, 286)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 130)
        Me.Label14.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.ImageIndex = 0
        Me.Label15.ImageList = Me.ImageList
        Me.Label15.Location = New System.Drawing.Point(381, 286)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(90, 130)
        Me.Label15.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.ImageIndex = 0
        Me.Label17.ImageList = Me.ImageList
        Me.Label17.Location = New System.Drawing.Point(103, 426)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 130)
        Me.Label17.TabIndex = 24
        '
        'Label18
        '
        Me.Label18.ImageIndex = 0
        Me.Label18.ImageList = Me.ImageList
        Me.Label18.Location = New System.Drawing.Point(193, 426)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 130)
        Me.Label18.TabIndex = 23
        '
        'Label19
        '
        Me.Label19.ImageIndex = 0
        Me.Label19.ImageList = Me.ImageList
        Me.Label19.Location = New System.Drawing.Point(287, 426)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 130)
        Me.Label19.TabIndex = 22
        '
        'Label20
        '
        Me.Label20.ImageIndex = 0
        Me.Label20.ImageList = Me.ImageList
        Me.Label20.Location = New System.Drawing.Point(381, 426)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(90, 130)
        Me.Label20.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.ImageIndex = 0
        Me.Label9.ImageList = Me.ImageList
        Me.Label9.Location = New System.Drawing.Point(287, 146)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 130)
        Me.Label9.TabIndex = 20
        '
        'FormMemory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 604)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.LabelTimer)
        Me.Controls.Add(Me.btnAbandon)
        Me.Controls.Add(Me.LabJoueur)
        Me.Controls.Add(Me.LabJoueurGame)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormMemory"
        Me.Text = "Memory"
        Me.Panel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabJoueurGame As Label
    Friend WithEvents LabJoueur As Label
    Friend WithEvents btnAbandon As Button
    Friend WithEvents LabelTimer As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents Panel As Panel
    Friend WithEvents ImageList As ImageList
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label9 As Label
End Class
