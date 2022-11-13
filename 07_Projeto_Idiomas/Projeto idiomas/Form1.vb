Public Class FrmProjetoIdiomas

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListIdiomas.SelectedIndexChanged
        If ListIdiomas.SelectedItem = "Inglês" Then
            LblFrase.Text = "Hello Hy"
            My.Computer.Audio.Play(My.Resources.Inglês, AudioPlayMode.Background)
            Picbandeira.Image = My.Resources.eua
        End If

           



            If ListIdiomas.SelectedItem = "Espanhol" Then
                LblFrase.Text = "Hola Mundo"
                My.Computer.Audio.Play(My.Resources.Espanhol, AudioPlayMode.Background)
                Picbandeira.Image = My.Resources.espanha
            End If





            If ListIdiomas.SelectedItem = "Francês" Then
                LblFrase.Text = "Bonjour Le Monde"
                My.Computer.Audio.Play(My.Resources.Francês, AudioPlayMode.Background)
                Picbandeira.Image = My.Resources.frança
            End If




            If ListIdiomas.SelectedItem = "Alemão" Then
                LblFrase.Text = "Hallo Welt"
                My.Computer.Audio.Play(My.Resources.Alemão, AudioPlayMode.Background)
                Picbandeira.Image = My.Resources.alemanha
            End If



            If ListIdiomas.SelectedItem = "Italiano" Then
                LblFrase.Text = "Cião Mundo"
                My.Computer.Audio.Play(My.Resources.Italiano, AudioPlayMode.Background)
                Picbandeira.Image = My.Resources.itália
            End If

            If ListIdiomas.SelectedItem = "Português" Then
                LblFrase.Text = "Olá Mundo"
                My.Computer.Audio.Play(My.Resources.Italiano, AudioPlayMode.Background)
                Picbandeira.Image = My.Resources.brasil
            End If
    End Sub

    

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub
End Class
