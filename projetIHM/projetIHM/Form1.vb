Public Class Menu

    Private Sub TextBoxNomJoueur_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar >= "0" AndAlso e.KeyChar <= "9" Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub btnJouer_Click(sender As Object, e As EventArgs) Handles btnJouer.Click
        game.LabJoueur.Text = ComboBoxNom.Text
        game.Show()
    End Sub

    Private Sub ComboBoxNom_KeyDown(ByVal sender As Object, e As System.Windows.Forms.KeyEventArgs)
        game.LabJoueur.Text = ComboBoxNom.Text
        ComboBoxNom.Items.Add(ComboBoxNom.Text)
        If e.KeyCode = Keys.Enter Then
            game.Show()
        End If
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ComboBoxNom.Text.IsNullOrEmpty Then
            btnJouer.Enabled = False
        Else
            btnJouer.Enabled = True
        End If
    End Sub

End Class
