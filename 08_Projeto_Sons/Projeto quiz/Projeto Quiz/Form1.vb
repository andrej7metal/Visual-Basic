Public Class frmQuiz

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PicTimes.Click


    End Sub

    Private Sub RadSantos_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadSantos_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadSantos.CheckedChanged
        PicTimes.Image = My.Resources.Santos
    End Sub

    Private Sub RadPalmeiras_CheckedChanged(sender As Object, e As EventArgs) Handles RadPalmeiras.CheckedChanged
        PicTimes.Image = My.Resources.Palmeiras
    End Sub

    Private Sub RadsaoPaulo_CheckedChanged(sender As Object, e As EventArgs) Handles RadsaoPaulo.CheckedChanged
        PicTimes.Image = My.Resources.Sao_Paulo
    End Sub

    Private Sub RadCorinthians_CheckedChanged(sender As Object, e As EventArgs) Handles RadCorinthians.CheckedChanged
        PicTimes.Image = My.Resources.Corinthians
    End Sub

    Private Sub RadCruzeiro_CheckedChanged(sender As Object, e As EventArgs) Handles RadCruzeiro.CheckedChanged
        PicTimes.Image = My.Resources.Cruzeiro
    End Sub

    Private Sub RavSemTime_CheckedChanged(sender As Object, e As EventArgs) Handles RavSemTime.CheckedChanged
        PicTimes.Image = My.Resources.sem_time
    End Sub

    Private Sub RadComedia_CheckedChanged(sender As Object, e As EventArgs) Handles RadComedia.CheckedChanged
        picComedia.Image = My.Resources.comédia
    End Sub

    Private Sub RadDrama_CheckedChanged(sender As Object, e As EventArgs) Handles RadDrama.CheckedChanged
        picComedia.Image = My.Resources.drama
    End Sub

    Private Sub RadInfantil_CheckedChanged(sender As Object, e As EventArgs) Handles RadInfantil.CheckedChanged
        picComedia.Image = My.Resources.infantil
    End Sub

    Private Sub RadRomance_CheckedChanged(sender As Object, e As EventArgs) Handles RadRomance.CheckedChanged
        picComedia.Image = My.Resources.romance
    End Sub

    Private Sub RadTerror_CheckedChanged(sender As Object, e As EventArgs) Handles RadTerror.CheckedChanged
        picComedia.Image = My.Resources.Terror
    End Sub

    Private Sub RadSuspense_CheckedChanged(sender As Object, e As EventArgs) Handles RadSuspense.CheckedChanged
        picComedia.Image = My.Resources.suspense
    End Sub

    Private Sub RadArtesMarciais_CheckedChanged(sender As Object, e As EventArgs) Handles RadArtesMarciais.CheckedChanged
        PicEsporte.Image = My.Resources.artes_marciais
    End Sub

    Private Sub RadAtletismo_CheckedChanged(sender As Object, e As EventArgs) Handles RadAtletismo.CheckedChanged
        PicEsporte.Image = My.Resources.atletismo
    End Sub

    Private Sub RadBaseball_CheckedChanged(sender As Object, e As EventArgs) Handles RadBaseball.CheckedChanged
        PicEsporte.Image = My.Resources.baseball
    End Sub

    Private Sub RadBasquete_CheckedChanged(sender As Object, e As EventArgs) Handles RadBasquete.CheckedChanged
        PicEsporte.Image = My.Resources.Basquete
    End Sub

    Private Sub RadBoxe_CheckedChanged(sender As Object, e As EventArgs) Handles RadBoxe.CheckedChanged
        PicEsporte.Image = My.Resources.box
    End Sub

    Private Sub RadCapoeira_CheckedChanged(sender As Object, e As EventArgs) Handles RadCapoeira.CheckedChanged
        PicEsporte.Image = My.Resources.capoeira
    End Sub

    Private Sub RadCiclismo_CheckedChanged(sender As Object, e As EventArgs) Handles RadCiclismo.CheckedChanged
        PicEsporte.Image = My.Resources.Ciclismo
    End Sub

    Private Sub RadFutebol_CheckedChanged(sender As Object, e As EventArgs) Handles RadFutebol.CheckedChanged
        PicEsporte.Image = My.Resources.Ciclismo
    End Sub

    Private Sub RadGinastica_CheckedChanged(sender As Object, e As EventArgs) Handles RadGinastica.CheckedChanged
        PicEsporte.Image = My.Resources.ginástica
    End Sub

    Private Sub RadMusculacao_CheckedChanged(sender As Object, e As EventArgs) Handles RadMusculacao.CheckedChanged
        PicEsporte.Image = My.Resources.musculação
    End Sub

    Private Sub RadNatacao_CheckedChanged(sender As Object, e As EventArgs) Handles RadNatacao.CheckedChanged
        PicEsporte.Image = My.Resources.natação
    End Sub

    Private Sub RadpingPong_CheckedChanged(sender As Object, e As EventArgs) Handles RadpingPong.CheckedChanged
        PicEsporte.Image = My.Resources.ping_pong
    End Sub

    Private Sub RadSkate_CheckedChanged(sender As Object, e As EventArgs) Handles RadSkate.CheckedChanged
        PicEsporte.Image = My.Resources.skate
    End Sub

    Private Sub RadSurf_CheckedChanged(sender As Object, e As EventArgs) Handles RadSurf.CheckedChanged
        PicEsporte.Image = My.Resources.surf
    End Sub

    Private Sub RadTenis_CheckedChanged(sender As Object, e As EventArgs) Handles RadTenis.CheckedChanged
        PicEsporte.Image = My.Resources.tênis
    End Sub

    Private Sub RadVolei_CheckedChanged(sender As Object, e As EventArgs) Handles RadVolei.CheckedChanged
        PicEsporte.Image = My.Resources.voleibol
    End Sub

    Private Sub RadAxe_CheckedChanged(sender As Object, e As EventArgs) Handles RadAxe.CheckedChanged
        PicMusicaPreferida.Image = My.Resources.axé
    End Sub

    Private Sub RadEletronica_CheckedChanged(sender As Object, e As EventArgs) Handles RadEletronica.CheckedChanged
        PicMusicaPreferida.Image = My.Resources.eletrônica
    End Sub

    Private Sub RadForro_CheckedChanged(sender As Object, e As EventArgs) Handles RadForro.CheckedChanged
        PicMusicaPreferida.Image = My.Resources.forró
    End Sub

    Private Sub RadFunk_CheckedChanged(sender As Object, e As EventArgs) Handles RadFunk.CheckedChanged
        PicMusicaPreferida.Image = My.Resources.funk
    End Sub

    Private Sub RadGospel_CheckedChanged(sender As Object, e As EventArgs) Handles RadGospel.CheckedChanged
        PicMusicaPreferida.Image = My.Resources.gospel
    End Sub

    Private Sub RadRap_CheckedChanged(sender As Object, e As EventArgs) Handles RadRap.CheckedChanged
        PicMusicaPreferida.Image = My.Resources.rap
    End Sub

    Private Sub RadReggae_CheckedChanged(sender As Object, e As EventArgs) Handles RadReggae.CheckedChanged
        PicMusicaPreferida.Image = My.Resources.reggae
    End Sub

    Private Sub RadRock_CheckedChanged(sender As Object, e As EventArgs) Handles RadRock.CheckedChanged
        PicMusicaPreferida.Image = My.Resources.rock
    End Sub

    Private Sub RadSamba_CheckedChanged(sender As Object, e As EventArgs) Handles RadSamba.CheckedChanged
        PicMusicaPreferida.Image = My.Resources.samba
    End Sub

    Private Sub RadSertanejo_CheckedChanged(sender As Object, e As EventArgs) Handles RadSertanejo.CheckedChanged
        PicMusicaPreferida.Image = My.Resources.sertanejo
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click

        RadSantos.Checked = False
        RadPalmeiras.Checked = False
        RadsaoPaulo.Checked = False
        RadCorinthians.Checked = False
        RadCruzeiro.Checked = False



        RadComedia.Checked = False
        RadDrama.Checked = False
        RadInfantil.Checked = False
        RadTerror.Checked = False
        RadSuspense.Checked = False


        RadArtesMarciais.Checked = False
        RadAtletismo.Checked = False
        RadBaseball.Checked = False
        RadBasquete.Checked = False
        RadBoxe.Checked = False
        RadCapoeira.Checked = False
        RadCiclismo.Checked = False
        RadFutebol.Checked = False
        RadGinastica.Checked = False
        RadMusculacao.Checked = False
        RadNatacao.Checked = False
        RadpingPong.Checked = False
        RadSkate.Checked = False
        RadSurf.Checked = False
        RadTenis.Checked = False
        RadVolei.Checked = False


        RadAxe.Checked = False
        RadEletronica.Checked = False
        RadForro.Checked = False
        RadGospel.Checked = False
        RadRap.Checked = False
        RadReggae.Checked = False
        RadRock.Checked = False
        RadSamba.Checked = False
        RadSertanejo.Checked = False

        PicTimes.Image = My.Resources.quiz

        picComedia.Image = My.Resources.quiz
        PicEsporte.Image = My.Resources.quiz
        PicMusicaPreferida.Image = My.Resources.quiz
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub
End Class
