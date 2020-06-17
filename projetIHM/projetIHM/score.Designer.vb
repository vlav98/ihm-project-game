<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class score
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.ListBoxMeilleurTps = New System.Windows.Forms.ListBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.ListBoxNbParties = New System.Windows.Forms.ListBox()
        Me.ListBoxTempsJeu = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBoxNom
        '
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.Location = New System.Drawing.Point(17, 19)
        Me.ListBoxNom.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(95, 251)
        Me.ListBoxNom.TabIndex = 0
        '
        'ListBoxMeilleurTps
        '
        Me.ListBoxMeilleurTps.FormattingEnabled = True
        Me.ListBoxMeilleurTps.Location = New System.Drawing.Point(133, 19)
        Me.ListBoxMeilleurTps.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxMeilleurTps.Name = "ListBoxMeilleurTps"
        Me.ListBoxMeilleurTps.Size = New System.Drawing.Size(77, 251)
        Me.ListBoxMeilleurTps.TabIndex = 1
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(351, 296)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(82, 22)
        Me.btnMenu.TabIndex = 2
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'ListBoxNbParties
        '
        Me.ListBoxNbParties.FormattingEnabled = True
        Me.ListBoxNbParties.Location = New System.Drawing.Point(243, 19)
        Me.ListBoxNbParties.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxNbParties.Name = "ListBoxNbParties"
        Me.ListBoxNbParties.Size = New System.Drawing.Size(77, 251)
        Me.ListBoxNbParties.TabIndex = 3
        '
        'ListBoxTempsJeu
        '
        Me.ListBoxTempsJeu.FormattingEnabled = True
        Me.ListBoxTempsJeu.Location = New System.Drawing.Point(351, 19)
        Me.ListBoxTempsJeu.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBoxTempsJeu.Name = "ListBoxTempsJeu"
        Me.ListBoxTempsJeu.Size = New System.Drawing.Size(77, 251)
        Me.ListBoxTempsJeu.TabIndex = 4
        '
        'score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 337)
        Me.Controls.Add(Me.ListBoxTempsJeu)
        Me.Controls.Add(Me.ListBoxNbParties)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.ListBoxMeilleurTps)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "score"
        Me.Text = "score"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents ListBoxMeilleurTps As ListBox
    Friend WithEvents btnMenu As Button
    Friend WithEvents ListBoxNbParties As ListBox
    Friend WithEvents ListBoxTempsJeu As ListBox
End Class
