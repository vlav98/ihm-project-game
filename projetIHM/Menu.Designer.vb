<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
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
        resources.ApplyResources(Me.LabNomJoueur, "LabNomJoueur")
        Me.LabNomJoueur.Name = "LabNomJoueur"
        '
        'btnJouer
        '
        resources.ApplyResources(Me.btnJouer, "btnJouer")
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.UseVisualStyleBackColor = True
        '
        'btnScores
        '
        resources.ApplyResources(Me.btnScores, "btnScores")
        Me.btnScores.Name = "btnScores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'btnOptions
        '
        resources.ApplyResources(Me.btnOptions, "btnOptions")
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.UseVisualStyleBackColor = True
        '
        'btnQuitter
        '
        resources.ApplyResources(Me.btnQuitter, "btnQuitter")
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'LabMemory
        '
        resources.ApplyResources(Me.LabMemory, "LabMemory")
        Me.LabMemory.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.LabMemory.ForeColor = System.Drawing.SystemColors.Window
        Me.LabMemory.Name = "LabMemory"
        '
        'ComboBoxNom
        '
        resources.ApplyResources(Me.ComboBoxNom, "ComboBoxNom")
        Me.ComboBoxNom.FormattingEnabled = True
        Me.ComboBoxNom.Name = "ComboBoxNom"
        '
        'FormMenu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBoxNom)
        Me.Controls.Add(Me.LabMemory)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.btnJouer)
        Me.Controls.Add(Me.LabNomJoueur)
        Me.Name = "FormMenu"
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
