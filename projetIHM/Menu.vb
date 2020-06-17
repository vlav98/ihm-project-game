Public Class FormMenu

    Private Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        FormMemory.LabJoueur.Text = ComboBoxNom.Text
        FormMemory.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBoxNom_KeyDown(ByVal sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxNom.KeyDown
        ComboBoxNom.Items.Add(ComboBoxNom.Text)
        If e.KeyCode = Keys.Enter Then
            FormMemory.LabJoueur.Text = ComboBoxNom.Text
            FormMemory.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnJouer.Enabled = False

        Dim joueur(5) As String
        ' joueur(joueur.Count) = ComboBoxNom.Text
        'For i As Integer = 0 To (joueur.Count - 1)
        'ComboBoxNom.Items.Add(joueur(i))
        'ComboBoxNom.Sorted = True
        'If Not ComboBoxNom.Items.Contains(joueur(i)) Then
        '    ComboBoxNom.Items.Add(joueur(i))
        'End If
        ' Next i
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Dim style As MsgBoxStyle = MsgBoxStyle.YesNo
        Dim response = MsgBox("Etes-vous sûr de vouloir quitter Memory?", style)
        If response = MsgBoxResult.Yes Then
            Me.Close()
        Else Me.Show()
        End If
    End Sub

    Private Sub ComboBoxNom_TextChanged(sender As Object, e As EventArgs) Handles ComboBoxNom.TextChanged
        If ComboBoxNom.Text <> "" Then
            btnJouer.Enabled = True
        End If
    End Sub
End Class
