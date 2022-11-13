Public Class frmQuiz



    Private Sub radSantos_CheckedChanged(sender As Object, e As EventArgs) Handles radSantos.CheckedChanged
        picTime.Image = My.Resources.Santos
    End Sub

    Private Sub radPalmeiras_CheckedChanged(sender As Object, e As EventArgs) Handles radPalmeiras.CheckedChanged
        picTime.Image = My.Resources.Palmeiras
    End Sub

    Private Sub radSãoPaulo_CheckedChanged(sender As Object, e As EventArgs) Handles radSaoPaulo.CheckedChanged
        picTime.Image = My.Resources.Sao_Paulo
    End Sub

    Private Sub radCorinthians_CheckedChanged(sender As Object, e As EventArgs) Handles radCorinthians.CheckedChanged
        picTime.Image = My.Resources.Corinthians
    End Sub

    Private Sub radCruzeiro_CheckedChanged(sender As Object, e As EventArgs) Handles radCruzeiro.CheckedChanged
        picTime.Image = My.Resources.Cruzeiro
    End Sub

    Private Sub radSemTime_CheckedChanged(sender As Object, e As EventArgs) Handles radSemTime.CheckedChanged
        picTime.Image = My.Resources.sem_time
    End Sub

    Private Sub radArtesMarciais_CheckedChanged(sender As Object, e As EventArgs) Handles radArtesMarciais.CheckedChanged
        picEsporte.Image = My.Resources.artes_marciais
    End Sub

    Private Sub radAtletismo_CheckedChanged(sender As Object, e As EventArgs) Handles radAtletismo.CheckedChanged
        picEsporte.Image = My.Resources.atletismo
    End Sub

    Private Sub radBaseball_CheckedChanged(sender As Object, e As EventArgs) Handles radBaseball.CheckedChanged
        picEsporte.Image = My.Resources.baseball
    End Sub

    Private Sub radBasquete_CheckedChanged(sender As Object, e As EventArgs) Handles radBasquete.CheckedChanged
        picEsporte.Image = My.Resources.Basquete
    End Sub

    Private Sub radBoxe_CheckedChanged(sender As Object, e As EventArgs) Handles radBoxe.CheckedChanged
        picEsporte.Image = My.Resources.box
    End Sub

    Private Sub radCapoeira_CheckedChanged(sender As Object, e As EventArgs) Handles radCapoeira.CheckedChanged
        picEsporte.Image = My.Resources.capoeira
    End Sub

    Private Sub radCiclismo_CheckedChanged(sender As Object, e As EventArgs) Handles radCiclismo.CheckedChanged
        picEsporte.Image = My.Resources.Ciclismo
    End Sub

    Private Sub radFutebol_CheckedChanged(sender As Object, e As EventArgs) Handles radFutebol.CheckedChanged
        picEsporte.Image = My.Resources.futebol
    End Sub

    Private Sub radGinastica_CheckedChanged(sender As Object, e As EventArgs) Handles radGinastica.CheckedChanged
        picEsporte.Image = My.Resources.ginástica
    End Sub

    Private Sub radMusculacao_CheckedChanged(sender As Object, e As EventArgs) Handles radMusculacao.CheckedChanged
        picEsporte.Image = My.Resources.musculação
    End Sub

    Private Sub radNatacao_CheckedChanged(sender As Object, e As EventArgs) Handles radNatacao.CheckedChanged
        picEsporte.Image = My.Resources.natação
    End Sub

    Private Sub radPingPong_CheckedChanged(sender As Object, e As EventArgs) Handles radPingPong.CheckedChanged
        picEsporte.Image = My.Resources.ping_pong
    End Sub

    Private Sub radSkate_CheckedChanged(sender As Object, e As EventArgs) Handles radSkate.CheckedChanged
        picEsporte.Image = My.Resources.skate
    End Sub

    Private Sub radSurf_CheckedChanged(sender As Object, e As EventArgs) Handles radSurf.CheckedChanged
        picEsporte.Image = My.Resources.surf
    End Sub

    Private Sub radTenis_CheckedChanged(sender As Object, e As EventArgs) Handles radTenis.CheckedChanged
        picEsporte.Image = My.Resources.tênis
    End Sub

    Private Sub radVolei_CheckedChanged(sender As Object, e As EventArgs) Handles radVolei.CheckedChanged
        picEsporte.Image = My.Resources.voleibol
    End Sub

    Private Sub radComedia_CheckedChanged(sender As Object, e As EventArgs) Handles radComedia.CheckedChanged
        picGenero.Image = My.Resources.comédia
    End Sub

    Private Sub radDRama_CheckedChanged(sender As Object, e As EventArgs) Handles radDRama.CheckedChanged
        picGenero.Image = My.Resources.drama
    End Sub

    Private Sub radInfantil_CheckedChanged(sender As Object, e As EventArgs) Handles radInfantil.CheckedChanged
        picGenero.Image = My.Resources.infantil
    End Sub

    Private Sub radRomance_CheckedChanged(sender As Object, e As EventArgs) Handles radRomance.CheckedChanged
        picGenero.Image = My.Resources.romance
    End Sub

    Private Sub radTerror_CheckedChanged(sender As Object, e As EventArgs) Handles radTerror.CheckedChanged
        picGenero.Image = My.Resources.Terror
    End Sub

    Private Sub radSuspense_CheckedChanged(sender As Object, e As EventArgs) Handles radSuspense.CheckedChanged
        picGenero.Image = My.Resources.suspense
    End Sub

    Private Sub radAxe_CheckedChanged(sender As Object, e As EventArgs) Handles radAxe.CheckedChanged
        picMusica.Image = My.Resources.axé
    End Sub

    Private Sub radEletrônica_CheckedChanged(sender As Object, e As EventArgs) Handles radEletrônica.CheckedChanged
        picMusica.Image = My.Resources.eletrônica
    End Sub

    Private Sub radForró_CheckedChanged(sender As Object, e As EventArgs) Handles radForró.CheckedChanged
        picMusica.Image = My.Resources.forró
    End Sub

    Private Sub radFunk_CheckedChanged(sender As Object, e As EventArgs) Handles radFunk.CheckedChanged
        picMusica.Image = My.Resources.funk
    End Sub

    Private Sub radGospel_CheckedChanged(sender As Object, e As EventArgs) Handles radGospel.CheckedChanged
        picMusica.Image = My.Resources.gospel
    End Sub

    Private Sub radRap_CheckedChanged(sender As Object, e As EventArgs) Handles radRap.CheckedChanged
        picMusica.Image = My.Resources.rap
    End Sub

    Private Sub radReggae_CheckedChanged(sender As Object, e As EventArgs) Handles radReggae.CheckedChanged
        picMusica.Image = My.Resources.reggae
    End Sub

    Private Sub radRock_CheckedChanged(sender As Object, e As EventArgs) Handles radRock.CheckedChanged
        picMusica.Image = My.Resources.rock
    End Sub

    Private Sub radSamba_CheckedChanged(sender As Object, e As EventArgs) Handles radSamba.CheckedChanged
        picMusica.Image = My.Resources.samba
    End Sub

    Private Sub radSertanejo_CheckedChanged(sender As Object, e As EventArgs) Handles radSertanejo.CheckedChanged
        picMusica.Image = My.Resources.sertanejo
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        radSantos.Checked = False
        radPalmeiras.Checked = False
        radSaoPaulo.Checked = False
        radCorinthians.Checked = False
        radCruzeiro.Checked = False
        radSemTime.Checked = False
        picTime.Image = My.Resources.quiz
        radArtesMarciais.Checked = False
        radAtletismo.Checked = False
        radBaseball.Checked = False
        radBasquete.Checked = False
        radBoxe.Checked = False
        radCapoeira.Checked = False
        radCiclismo.Checked = False
        radFutebol.Checked = False
        radGinastica.Checked = False
        radMusculacao.Checked = False
        radNatacao.Checked = False
        radPingPong.Checked = False
        radSkate.Checked = False
        radSurf.Checked = False
        radTenis.Checked = False
        radVolei.Checked = False
        picEsporte.Image = My.Resources.quiz
        radComedia.Checked = False
        radDRama.Checked = False
        radInfantil.Checked = False
        radRomance.Checked = False
        radTerror.Checked = False
        radSuspense.Checked = False
        picGenero.Image = My.Resources.quiz
        radAxe.Checked = False
        radEletrônica.Checked = False
        radForró.Checked = False
        radFunk.Checked = False
        radGospel.Checked = False
        radRap.Checked = False
        radReggae.Checked = False
        radRock.Checked = False
        radSamba.Checked = False
        radSertanejo.Checked = False
        picMusica.Image = My.Resources.quiz

    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        End
    End Sub
End Class
