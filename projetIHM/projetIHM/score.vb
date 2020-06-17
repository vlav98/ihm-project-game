Public Class score
    Private Sub ListBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged, ListBoxMeilleurTps.SelectedIndexChanged
        'Dim index As Integer
        'index = sender.selectedIndex
        'ListBoxNom.SelectedIndex = index
        'ListBoxScore.SelectedIndex = index
    End Sub

    Private Sub score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ListBoxNom.Items.Add(FormMenu.ComboBoxNom.Text)
        Joueur.listNom()
        Joueur.listMeilleurTps()
        Joueur.listNbParties()
        Joueur.listTempsJeu()
    End Sub

    Private Sub btnreteturnmenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        FormMenu.Show()
        Me.Close()
    End Sub
End Class