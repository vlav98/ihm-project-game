<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
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
        Me.LabNomJoueur = New System.Windows.Forms.Label()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.LabMemory = New System.Windows.Forms.Label()
        Me.ComboBoxNom = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LabNomJoueur
        '
        Me.LabNomJoueur.AutoSize = True
        Me.LabNomJoueur.Location = New System.Drawing.Point(60, 84)
        Me.LabNomJoueur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabNomJoueur.Name = "LabNomJoueur"
        Me.LabNomJoueur.Size = New System.Drawing.Size(93, 13)
        Me.LabNomJoueur.TabIndex = 1
        Me.LabNomJoueur.Text = "Entrez votre nom :"
        '
        'btnJouer
        '
        Me.btnJouer.Location = New System.Drawing.Point(219, 24)
        Me.btnJouer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(72, 22)
        Me.btnJouer.TabIndex = 2
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = True
        '
        'btnScores
        '
        Me.btnScores.Location = New System.Drawing.Point(219, 59)
        Me.btnScores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(72, 23)
        Me.btnScores.TabIndex = 3
        Me.btnScores.Text = "Scores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        Me.btnOptions.Location = New System.Drawing.Point(219, 97)
        Me.btnOptions.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(72, 24)
        Me.btnOptions.TabIndex = 4
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(219, 132)
        Me.btnQuitter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(72, 22)
        Me.btnQuitter.TabIndex = 5
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'LabMemory
        '
        Me.LabMemory.AutoSize = True
        Me.LabMemory.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabMemory.Font = New System.Drawing.Font("Trajan Pro", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMemory.ForeColor = System.Drawing.SystemColors.Window
        Me.LabMemory.Location = New System.Drawing.Point(55, 33)
        Me.LabMemory.Name = "LabMemory"
        Me.LabMemory.Size = New System.Drawing.Size(98, 24)
        Me.LabMemory.TabIndex = 6
        Me.LabMemory.Text = "Memory"
        '
        'ComboBoxNom
        '
        Me.ComboBoxNom.FormattingEnabled = True
        Me.ComboBoxNom.Location = New System.Drawing.Point(44, 115)
        Me.ComboBoxNom.Name = "ComboBoxNom"
        Me.ComboBoxNom.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxNom.TabIndex = 7
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 185)
        Me.Controls.Add(Me.ComboBoxNom)
        Me.Controls.Add(Me.LabMemory)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.LabNomJoueur)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabNomJoueur As Label
    Friend WithEvents btnJouer As Button
    Friend WithEvents btnScores As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents LabMemory As Label
    Friend WithEvents ComboBoxNom As ComboBox
End Class
