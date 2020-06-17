Public Class FormMemory
    Dim cpt As Integer = 0
    Dim rand As New Random()
    Dim tagPrec As Integer = 0
    Dim nbClick As Integer = 0
    Dim nbCartes() As Integer = {0, 0, 0, 0, 0}
    Dim comptCartes As Integer = 20
    Dim comptBon As Integer = 0
    Dim decompte As Integer = 60


    Private Sub btnAbandon_Click(sender As Object, e As EventArgs) Handles btnAbandon.Click
        Timer.Stop()
        Dim style As MsgBoxStyle = MsgBoxStyle.YesNo
        Dim response = MsgBox("Etes-vous sûr de vouloir abandonner la partie?", style)
        If response = MsgBoxResult.Yes Then
            Me.Close()
            FormMenu.Show()
        Else Me.Show()
            Timer.Start()
        End If
    End Sub

    Private Sub game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelTimer.Text = "Temps restant :   " & decompte

        For Each lab In Panel.Controls
            If TypeOf lab Is Label Then
                lab.Image = ImageList.Images(0)
                lab.Tag = Aleatoire()
                lab.Enabled = True
            End If
        Next
    End Sub

    Function Aleatoire()
        Dim n As Integer = rand.Next(1, 6)

        While nbCartes(n - 1) = 4
            n = rand.Next(1, 6)
        End While
        nbCartes(n - 1) += 1
        Return n
    End Function

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        decompte = 60 - cpt
        If cpt <= 60 Then
            cpt += 1
            LabelTimer.Text = "Temps restant :   " & decompte
        Else
            Timer.Stop()
        End If
        If cpt > 45 Then
            LabelTimer.ForeColor = Color.Red
        End If
        If decompte = 0 Then
            MsgBox("Temps écoulé!")
            FormMenu.Show()
            Me.Close()
        End If

    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click, Label7.Click, Label8.Click, Label9.Click, Label10.Click, Label11.Click, Label12.Click, Label13.Click, Label14.Click, Label15.Click, Label16.Click, Label17.Click, Label18.Click, Label19.Click, Label20.Click
        sender.Image = ImageList.Images(sender.Tag)
        nbClick += 1


        If nbClick = 1 Then
            tagPrec = sender.Tag
            comptBon += 1
            Timer.Start()

        End If

        If tagPrec <> sender.Tag And tagPrec <> 0 And nbClick <> 1 Then
            wait(0.55)
            'MsgBox("")
            nbClick = 0
            tagPrec = 0
            comptBon = 0
            For Each lab In Panel.Controls
                If TypeOf lab Is Label And lab.Enabled = True Then
                    lab.Image = ImageList.Images(0)
                End If
            Next
        End If

        If tagPrec = sender.Tag Then
            If comptBon = 4 Then
                For Each lab In Panel.Controls
                    If TypeOf lab Is Label Then
                        If lab.Tag = sender.Tag Then
                            lab.Enabled = False
                            comptCartes -= 1
                            If comptCartes = 0 Then
                                Timer.Stop()
                                MsgBox("Félicitations! Vous avez gagné en " & cpt & " secondes")
                                Joueur.miseAJour()
                                FormMenu.Show()
                                Me.Close()
                            End If
                        End If
                    End If
                Next
                tagPrec = 0
                comptBon = 0
                nbClick = 0
            Else comptBon += 1
            End If
        End If

    End Sub

    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Function getCpt()
        Return cpt
    End Function

End Class