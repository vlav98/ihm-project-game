Module Joueur
    Structure JOUEUR
        Dim nom As String
        Dim meilleurTps As Integer
        Dim nbParties As Integer
        Dim tempsJeu As Integer
    End Structure

    Dim j As JOUEUR()
    Dim nbJoueurs As Integer

    Sub ajout(jou As JOUEUR)
        j(nbJoueurs) = jou
        nbJoueurs += 1
    End Sub

    Sub listeNoms()
        For i As Integer = 0 To nbJoueurs - 1
            FormMenu.ComboBoxNom.Sorted = True
            FormMenu.ComboBoxNom.Items.Add(j(i).nom)
        Next i
    End Sub

End Module
