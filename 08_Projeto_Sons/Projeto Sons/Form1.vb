Public Class FRMSons

   
    Private Sub LstSom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstSom.SelectedIndexChanged
        If LstSom.SelectedItem = "Som1" Then
            My.Computer.Audio.Play(My.Resources.Campainha, AudioPlayMode.Background)
            Picimagem.Image = My.Resources.CampainhaIMG
        End If




        If LstSom.SelectedItem = "Som2" Then
            My.Computer.Audio.Play(My.Resources.Alarme, AudioPlayMode.Background)
            Picimagem.Image = My.Resources.AlarmeIMG
        End If



        If LstSom.SelectedItem = "Som3" Then
            My.Computer.Audio.Play(My.Resources.Aplausos, AudioPlayMode.Background)
            Picimagem.Image = My.Resources.AplausosIMG
        End If

        If LstSom.SelectedItem = "Som4" Then
            My.Computer.Audio.Play(My.Resources.Bomba, AudioPlayMode.Background)
            Picimagem.Image = My.Resources.bombaIMG
        End If


        If LstSom.SelectedItem = "Som5" Then
            My.Computer.Audio.Play(My.Resources.CAMERA, AudioPlayMode.Background)
            Picimagem.Image = My.Resources.cameraIMG
        End If

        If LstSom.SelectedItem = "Som6" Then
            My.Computer.Audio.Play(My.Resources.Dinheiro, AudioPlayMode.Background)
            Picimagem.Image = My.Resources.DinheiroIMG
        End If

        If LstSom.SelectedItem = "som 7" Then
            My.Computer.Audio.Play(My.Resources.Drama, AudioPlayMode.Background)
            Picimagem.Image = My.Resources.DramaIMG
        End If

        If LstSom.SelectedItem = "Som7" Then
            My.Computer.Audio.Play(My.Resources.Espirro, AudioPlayMode.Background)
            Picimagem.Image = My.Resources.EspirrroIMG
        End If

        If LstSom.SelectedItem = "Som8" Then
            My.Computer.Audio.Play(My.Resources.Mágica, AudioPlayMode.Background)
            Picimagem.Image = My.Resources.MágicaIMG
        End If

        If LstSom.SelectedItem = "Som9" Then
            My.Computer.Audio.Play(My.Resources.Mensagem, AudioPlayMode.Background)
            Picimagem.Image = My.Resources.MensagemIMG
        End If

        If LstSom.SelectedItem = "Som9" Then
            My.Computer.Audio.Play(My.Resources.Tosse, AudioPlayMode.Background)
            Picimagem.Image = My.Resources.tosseIMG
        End If


        If LstSom.SelectedItem = "Som10" Then
            My.Computer.Audio.Play(My.Resources.Mensagem, AudioPlayMode.Background)
            Picimagem.Image = My.Resources.MensagemIMG

        End If
    End Sub


    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub
End Class
