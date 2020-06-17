Module Joueur

    Structure PLAYER
        Dim nom As String
        Dim meilleurTps As Integer
        Dim nbParties As Integer
        Dim tempsJeu As Integer
    End Structure

    Dim joueurs As PLAYER()
    Dim nbJoueurs As Integer = 0
    Dim jExist As Boolean = False
    Dim indice As Integer

    Sub init()
        ReDim joueurs(nbJoueurs)

    End Sub

    Sub ajout(p As PLAYER)
        joueurs(nbJoueurs) = p
        nbJoueurs += 1
        ReDim Preserve joueurs(nbJoueurs)
    End Sub

    Sub miseAJour()
        For i As Integer = 0 To nbJoueurs - 1
            If FormMemory.LabJoueur.Text = joueurs(i).nom Then
                jExist = True
                indice = i
            Else jExist = False
            End If
        Next i
        If jExist = True Then
            joueurs(indice).nbParties += 1
            joueurs(indice).tempsJeu += FormMemory.getCpt()
            If joueurs(indice).meilleurTps > FormMemory.getCpt() Then
                joueurs(indice).meilleurTps = FormMemory.getCpt()
            End If
        Else
                Dim J As PLAYER
                J.nom = FormMemory.LabJoueur.Text
                J.meilleurTps = FormMemory.getCpt()
                J.nbParties = 1
                J.tempsJeu = FormMemory.getCpt()
                Joueur.ajout(J)
            End If
    End Sub

    Sub listNom()
        For i As Integer = 0 To nbJoueurs - 1
            score.ListBoxNom.Items.Add(joueurs(i).nom)
        Next
    End Sub

    Sub listMeilleurTps()
        For i As Integer = 0 To nbJoueurs - 1
            score.ListBoxMeilleurTps.Items.Add(joueurs(i).meilleurTps)
        Next
    End Sub

    Sub listNbParties()
        For i As Integer = 0 To nbJoueurs - 1
            score.ListBoxNbParties.Items.Add(joueurs(i).nbParties)
        Next
    End Sub

    Sub listTempsJeu()
        For i As Integer = 0 To nbJoueurs - 1
            score.ListBoxTempsJeu.Items.Add(joueurs(i).tempsJeu)
        Next
    End Sub

    Sub main()
        Application.Run(FormMenu)
        init()
    End Sub

End Module
