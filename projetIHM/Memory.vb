Public Class FormMemory
    Dim cpt As Integer
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
        Timer.Start()

        'Dim compt(5) As Integer
        'Dim rand As New Random()
        'rand.Next(5)

        '  For i As Integer = 0 To Panel.Controls.Count - 1
        'sender.ImageIndex = rand
        ' compt(sender.ImageIndex) = compt(sender.ImageIndex) + 1

        'If (compt(sender.ImageIndex) = 4) Then
        'ImageList.
        'End If
        ' Next i
    End Sub

    Private Sub Panel_Click(sender As Object, e As EventArgs) Handles Panel.Click
        'Dim Timer As New Timer
        Timer.Interval = 1000 '1000 ms = 1 sec
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        If cpt < 60 Then
            cpt += 1
            LabelTimer.Text = "Temps restant :   " & 60 - cpt
        Else
            Timer.Stop()
        End If
    End Sub

    'Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
    '    LabelTimer = Val(Timer.Text)

    '    If LabelTimer = 0 Then
    '        MsgBox("Temps écoulé !")
    '        Timer.Stop()
    '    Else
    '        Dim NouvelleValueLabelTimer As Integer = NouvelleValueLabelTimer + -1
    '        Label1.Text = CStr(NouvelleValueLabelTimer)
    '    End If
    'End Sub
End Class