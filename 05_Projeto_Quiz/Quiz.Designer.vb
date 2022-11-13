<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiz
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblProjetoquiz = New System.Windows.Forms.Label()
        Me.grpTime = New System.Windows.Forms.GroupBox()
        Me.picTime = New System.Windows.Forms.PictureBox()
        Me.radSemTime = New System.Windows.Forms.RadioButton()
        Me.radCruzeiro = New System.Windows.Forms.RadioButton()
        Me.radCorinthians = New System.Windows.Forms.RadioButton()
        Me.radSaoPaulo = New System.Windows.Forms.RadioButton()
        Me.radPalmeiras = New System.Windows.Forms.RadioButton()
        Me.radSantos = New System.Windows.Forms.RadioButton()
        Me.grpFilme = New System.Windows.Forms.GroupBox()
        Me.picGenero = New System.Windows.Forms.PictureBox()
        Me.radSuspense = New System.Windows.Forms.RadioButton()
        Me.radTerror = New System.Windows.Forms.RadioButton()
        Me.radRomance = New System.Windows.Forms.RadioButton()
        Me.radInfantil = New System.Windows.Forms.RadioButton()
        Me.radDRama = New System.Windows.Forms.RadioButton()
        Me.radComedia = New System.Windows.Forms.RadioButton()
        Me.grpEsporte = New System.Windows.Forms.GroupBox()
        Me.picEsporte = New System.Windows.Forms.PictureBox()
        Me.radVolei = New System.Windows.Forms.RadioButton()
        Me.radTenis = New System.Windows.Forms.RadioButton()
        Me.radSurf = New System.Windows.Forms.RadioButton()
        Me.radSkate = New System.Windows.Forms.RadioButton()
        Me.radPingPong = New System.Windows.Forms.RadioButton()
        Me.radNatacao = New System.Windows.Forms.RadioButton()
        Me.radMusculacao = New System.Windows.Forms.RadioButton()
        Me.radGinastica = New System.Windows.Forms.RadioButton()
        Me.radFutebol = New System.Windows.Forms.RadioButton()
        Me.radCiclismo = New System.Windows.Forms.RadioButton()
        Me.radCapoeira = New System.Windows.Forms.RadioButton()
        Me.radBoxe = New System.Windows.Forms.RadioButton()
        Me.radBasquete = New System.Windows.Forms.RadioButton()
        Me.radBaseball = New System.Windows.Forms.RadioButton()
        Me.radAtletismo = New System.Windows.Forms.RadioButton()
        Me.radArtesMarciais = New System.Windows.Forms.RadioButton()
        Me.grpMusica = New System.Windows.Forms.GroupBox()
        Me.picMusica = New System.Windows.Forms.PictureBox()
        Me.radSertanejo = New System.Windows.Forms.RadioButton()
        Me.radSamba = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.radReggae = New System.Windows.Forms.RadioButton()
        Me.radRap = New System.Windows.Forms.RadioButton()
        Me.radGospel = New System.Windows.Forms.RadioButton()
        Me.radFunk = New System.Windows.Forms.RadioButton()
        Me.radForró = New System.Windows.Forms.RadioButton()
        Me.radEletrônica = New System.Windows.Forms.RadioButton()
        Me.radAxe = New System.Windows.Forms.RadioButton()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.grpTime.SuspendLayout()
        CType(Me.picTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFilme.SuspendLayout()
        CType(Me.picGenero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEsporte.SuspendLayout()
        CType(Me.picEsporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMusica.SuspendLayout()
        CType(Me.picMusica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProjetoquiz
        '
        Me.lblProjetoquiz.AutoSize = True
        Me.lblProjetoquiz.Location = New System.Drawing.Point(382, 9)
        Me.lblProjetoquiz.Name = "lblProjetoquiz"
        Me.lblProjetoquiz.Size = New System.Drawing.Size(64, 13)
        Me.lblProjetoquiz.TabIndex = 0
        Me.lblProjetoquiz.Text = "Projeto Quiz"
        '
        'grpTime
        '
        Me.grpTime.Controls.Add(Me.picTime)
        Me.grpTime.Controls.Add(Me.radSemTime)
        Me.grpTime.Controls.Add(Me.radCruzeiro)
        Me.grpTime.Controls.Add(Me.radCorinthians)
        Me.grpTime.Controls.Add(Me.radSaoPaulo)
        Me.grpTime.Controls.Add(Me.radPalmeiras)
        Me.grpTime.Controls.Add(Me.radSantos)
        Me.grpTime.Location = New System.Drawing.Point(12, 31)
        Me.grpTime.Name = "grpTime"
        Me.grpTime.Size = New System.Drawing.Size(288, 219)
        Me.grpTime.TabIndex = 1
        Me.grpTime.TabStop = False
        Me.grpTime.Text = "Escolha o seu time preferido"
        '
        'picTime
        '
        Me.picTime.Image = Global.Projeto_Quiz.My.Resources.Resources.quiz
        Me.picTime.Location = New System.Drawing.Point(120, 29)
        Me.picTime.Name = "picTime"
        Me.picTime.Size = New System.Drawing.Size(152, 156)
        Me.picTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTime.TabIndex = 8
        Me.picTime.TabStop = False
        '
        'radSemTime
        '
        Me.radSemTime.AutoSize = True
        Me.radSemTime.Location = New System.Drawing.Point(6, 144)
        Me.radSemTime.Name = "radSemTime"
        Me.radSemTime.Size = New System.Drawing.Size(72, 17)
        Me.radSemTime.TabIndex = 7
        Me.radSemTime.Text = "Sem Time"
        Me.radSemTime.UseVisualStyleBackColor = True
        '
        'radCruzeiro
        '
        Me.radCruzeiro.AutoSize = True
        Me.radCruzeiro.Location = New System.Drawing.Point(6, 121)
        Me.radCruzeiro.Name = "radCruzeiro"
        Me.radCruzeiro.Size = New System.Drawing.Size(63, 17)
        Me.radCruzeiro.TabIndex = 6
        Me.radCruzeiro.Text = "Cruzeiro"
        Me.radCruzeiro.UseVisualStyleBackColor = True
        '
        'radCorinthians
        '
        Me.radCorinthians.AutoSize = True
        Me.radCorinthians.Location = New System.Drawing.Point(6, 98)
        Me.radCorinthians.Name = "radCorinthians"
        Me.radCorinthians.Size = New System.Drawing.Size(77, 17)
        Me.radCorinthians.TabIndex = 5
        Me.radCorinthians.Text = "Corinthians"
        Me.radCorinthians.UseVisualStyleBackColor = True
        '
        'radSaoPaulo
        '
        Me.radSaoPaulo.AutoSize = True
        Me.radSaoPaulo.Location = New System.Drawing.Point(6, 75)
        Me.radSaoPaulo.Name = "radSaoPaulo"
        Me.radSaoPaulo.Size = New System.Drawing.Size(74, 17)
        Me.radSaoPaulo.TabIndex = 4
        Me.radSaoPaulo.Text = "São Paulo"
        Me.radSaoPaulo.UseVisualStyleBackColor = True
        '
        'radPalmeiras
        '
        Me.radPalmeiras.AutoSize = True
        Me.radPalmeiras.Location = New System.Drawing.Point(6, 52)
        Me.radPalmeiras.Name = "radPalmeiras"
        Me.radPalmeiras.Size = New System.Drawing.Size(70, 17)
        Me.radPalmeiras.TabIndex = 3
        Me.radPalmeiras.Text = "Palmeiras"
        Me.radPalmeiras.UseVisualStyleBackColor = True
        '
        'radSantos
        '
        Me.radSantos.AutoSize = True
        Me.radSantos.Location = New System.Drawing.Point(6, 29)
        Me.radSantos.Name = "radSantos"
        Me.radSantos.Size = New System.Drawing.Size(58, 17)
        Me.radSantos.TabIndex = 2
        Me.radSantos.Text = "Santos"
        Me.radSantos.UseVisualStyleBackColor = True
        '
        'grpFilme
        '
        Me.grpFilme.Controls.Add(Me.picGenero)
        Me.grpFilme.Controls.Add(Me.radSuspense)
        Me.grpFilme.Controls.Add(Me.radTerror)
        Me.grpFilme.Controls.Add(Me.radRomance)
        Me.grpFilme.Controls.Add(Me.radInfantil)
        Me.grpFilme.Controls.Add(Me.radDRama)
        Me.grpFilme.Controls.Add(Me.radComedia)
        Me.grpFilme.Location = New System.Drawing.Point(12, 270)
        Me.grpFilme.Name = "grpFilme"
        Me.grpFilme.Size = New System.Drawing.Size(288, 279)
        Me.grpFilme.TabIndex = 0
        Me.grpFilme.TabStop = False
        Me.grpFilme.Text = "Escolha seu gênero de filme"
        '
        'picGenero
        '
        Me.picGenero.Image = Global.Projeto_Quiz.My.Resources.Resources.quiz
        Me.picGenero.Location = New System.Drawing.Point(120, 41)
        Me.picGenero.Name = "picGenero"
        Me.picGenero.Size = New System.Drawing.Size(152, 152)
        Me.picGenero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGenero.TabIndex = 15
        Me.picGenero.TabStop = False
        '
        'radSuspense
        '
        Me.radSuspense.AutoSize = True
        Me.radSuspense.Location = New System.Drawing.Point(6, 156)
        Me.radSuspense.Name = "radSuspense"
        Me.radSuspense.Size = New System.Drawing.Size(72, 17)
        Me.radSuspense.TabIndex = 14
        Me.radSuspense.Text = "Suspense"
        Me.radSuspense.UseVisualStyleBackColor = True
        '
        'radTerror
        '
        Me.radTerror.AutoSize = True
        Me.radTerror.Location = New System.Drawing.Point(6, 133)
        Me.radTerror.Name = "radTerror"
        Me.radTerror.Size = New System.Drawing.Size(53, 17)
        Me.radTerror.TabIndex = 13
        Me.radTerror.Text = "Terror"
        Me.radTerror.UseVisualStyleBackColor = True
        '
        'radRomance
        '
        Me.radRomance.AutoSize = True
        Me.radRomance.Location = New System.Drawing.Point(6, 110)
        Me.radRomance.Name = "radRomance"
        Me.radRomance.Size = New System.Drawing.Size(71, 17)
        Me.radRomance.TabIndex = 12
        Me.radRomance.Text = "Romance"
        Me.radRomance.UseVisualStyleBackColor = True
        '
        'radInfantil
        '
        Me.radInfantil.AutoSize = True
        Me.radInfantil.Location = New System.Drawing.Point(6, 87)
        Me.radInfantil.Name = "radInfantil"
        Me.radInfantil.Size = New System.Drawing.Size(56, 17)
        Me.radInfantil.TabIndex = 11
        Me.radInfantil.Text = "Infantil"
        Me.radInfantil.UseVisualStyleBackColor = True
        '
        'radDRama
        '
        Me.radDRama.AutoSize = True
        Me.radDRama.Location = New System.Drawing.Point(6, 64)
        Me.radDRama.Name = "radDRama"
        Me.radDRama.Size = New System.Drawing.Size(56, 17)
        Me.radDRama.TabIndex = 10
        Me.radDRama.Text = "Drama"
        Me.radDRama.UseVisualStyleBackColor = True
        '
        'radComedia
        '
        Me.radComedia.AutoSize = True
        Me.radComedia.Location = New System.Drawing.Point(6, 41)
        Me.radComedia.Name = "radComedia"
        Me.radComedia.Size = New System.Drawing.Size(66, 17)
        Me.radComedia.TabIndex = 9
        Me.radComedia.Text = "Comédia"
        Me.radComedia.UseVisualStyleBackColor = True
        '
        'grpEsporte
        '
        Me.grpEsporte.Controls.Add(Me.picEsporte)
        Me.grpEsporte.Controls.Add(Me.radVolei)
        Me.grpEsporte.Controls.Add(Me.radTenis)
        Me.grpEsporte.Controls.Add(Me.radSurf)
        Me.grpEsporte.Controls.Add(Me.radSkate)
        Me.grpEsporte.Controls.Add(Me.radPingPong)
        Me.grpEsporte.Controls.Add(Me.radNatacao)
        Me.grpEsporte.Controls.Add(Me.radMusculacao)
        Me.grpEsporte.Controls.Add(Me.radGinastica)
        Me.grpEsporte.Controls.Add(Me.radFutebol)
        Me.grpEsporte.Controls.Add(Me.radCiclismo)
        Me.grpEsporte.Controls.Add(Me.radCapoeira)
        Me.grpEsporte.Controls.Add(Me.radBoxe)
        Me.grpEsporte.Controls.Add(Me.radBasquete)
        Me.grpEsporte.Controls.Add(Me.radBaseball)
        Me.grpEsporte.Controls.Add(Me.radAtletismo)
        Me.grpEsporte.Controls.Add(Me.radArtesMarciais)
        Me.grpEsporte.Location = New System.Drawing.Point(475, 31)
        Me.grpEsporte.Name = "grpEsporte"
        Me.grpEsporte.Size = New System.Drawing.Size(391, 256)
        Me.grpEsporte.TabIndex = 0
        Me.grpEsporte.TabStop = False
        Me.grpEsporte.Text = "Escolha seu esporte preferido"
        '
        'picEsporte
        '
        Me.picEsporte.Image = Global.Projeto_Quiz.My.Resources.Resources.quiz
        Me.picEsporte.Location = New System.Drawing.Point(219, 19)
        Me.picEsporte.Name = "picEsporte"
        Me.picEsporte.Size = New System.Drawing.Size(156, 178)
        Me.picEsporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEsporte.TabIndex = 16
        Me.picEsporte.TabStop = False
        '
        'radVolei
        '
        Me.radVolei.AutoSize = True
        Me.radVolei.Location = New System.Drawing.Point(117, 180)
        Me.radVolei.Name = "radVolei"
        Me.radVolei.Size = New System.Drawing.Size(48, 17)
        Me.radVolei.TabIndex = 15
        Me.radVolei.Text = "Volei"
        Me.radVolei.UseVisualStyleBackColor = True
        '
        'radTenis
        '
        Me.radTenis.AutoSize = True
        Me.radTenis.Location = New System.Drawing.Point(117, 157)
        Me.radTenis.Name = "radTenis"
        Me.radTenis.Size = New System.Drawing.Size(51, 17)
        Me.radTenis.TabIndex = 14
        Me.radTenis.Text = "Tênis"
        Me.radTenis.UseVisualStyleBackColor = True
        '
        'radSurf
        '
        Me.radSurf.AutoSize = True
        Me.radSurf.Location = New System.Drawing.Point(117, 134)
        Me.radSurf.Name = "radSurf"
        Me.radSurf.Size = New System.Drawing.Size(44, 17)
        Me.radSurf.TabIndex = 13
        Me.radSurf.Text = "Surf"
        Me.radSurf.UseVisualStyleBackColor = True
        '
        'radSkate
        '
        Me.radSkate.AutoSize = True
        Me.radSkate.Location = New System.Drawing.Point(117, 111)
        Me.radSkate.Name = "radSkate"
        Me.radSkate.Size = New System.Drawing.Size(53, 17)
        Me.radSkate.TabIndex = 12
        Me.radSkate.Text = "Skate"
        Me.radSkate.UseVisualStyleBackColor = True
        '
        'radPingPong
        '
        Me.radPingPong.AutoSize = True
        Me.radPingPong.Location = New System.Drawing.Point(117, 88)
        Me.radPingPong.Name = "radPingPong"
        Me.radPingPong.Size = New System.Drawing.Size(74, 17)
        Me.radPingPong.TabIndex = 11
        Me.radPingPong.Text = "Ping Pong"
        Me.radPingPong.UseVisualStyleBackColor = True
        '
        'radNatacao
        '
        Me.radNatacao.AutoSize = True
        Me.radNatacao.Location = New System.Drawing.Point(117, 65)
        Me.radNatacao.Name = "radNatacao"
        Me.radNatacao.Size = New System.Drawing.Size(66, 17)
        Me.radNatacao.TabIndex = 10
        Me.radNatacao.Text = "Natação"
        Me.radNatacao.UseVisualStyleBackColor = True
        '
        'radMusculacao
        '
        Me.radMusculacao.AutoSize = True
        Me.radMusculacao.Location = New System.Drawing.Point(117, 42)
        Me.radMusculacao.Name = "radMusculacao"
        Me.radMusculacao.Size = New System.Drawing.Size(83, 17)
        Me.radMusculacao.TabIndex = 9
        Me.radMusculacao.Text = "Musculação"
        Me.radMusculacao.UseVisualStyleBackColor = True
        '
        'radGinastica
        '
        Me.radGinastica.AutoSize = True
        Me.radGinastica.Location = New System.Drawing.Point(117, 19)
        Me.radGinastica.Name = "radGinastica"
        Me.radGinastica.Size = New System.Drawing.Size(69, 17)
        Me.radGinastica.TabIndex = 8
        Me.radGinastica.Text = "Ginástica"
        Me.radGinastica.UseVisualStyleBackColor = True
        '
        'radFutebol
        '
        Me.radFutebol.AutoSize = True
        Me.radFutebol.Location = New System.Drawing.Point(6, 180)
        Me.radFutebol.Name = "radFutebol"
        Me.radFutebol.Size = New System.Drawing.Size(60, 17)
        Me.radFutebol.TabIndex = 7
        Me.radFutebol.Text = "Futebol"
        Me.radFutebol.UseVisualStyleBackColor = True
        '
        'radCiclismo
        '
        Me.radCiclismo.AutoSize = True
        Me.radCiclismo.Location = New System.Drawing.Point(6, 157)
        Me.radCiclismo.Name = "radCiclismo"
        Me.radCiclismo.Size = New System.Drawing.Size(63, 17)
        Me.radCiclismo.TabIndex = 6
        Me.radCiclismo.Text = "Ciclismo"
        Me.radCiclismo.UseVisualStyleBackColor = True
        '
        'radCapoeira
        '
        Me.radCapoeira.AutoSize = True
        Me.radCapoeira.Location = New System.Drawing.Point(6, 134)
        Me.radCapoeira.Name = "radCapoeira"
        Me.radCapoeira.Size = New System.Drawing.Size(67, 17)
        Me.radCapoeira.TabIndex = 5
        Me.radCapoeira.Text = "Capoeira"
        Me.radCapoeira.UseVisualStyleBackColor = True
        '
        'radBoxe
        '
        Me.radBoxe.AutoSize = True
        Me.radBoxe.Location = New System.Drawing.Point(6, 111)
        Me.radBoxe.Name = "radBoxe"
        Me.radBoxe.Size = New System.Drawing.Size(49, 17)
        Me.radBoxe.TabIndex = 4
        Me.radBoxe.Text = "Boxe"
        Me.radBoxe.UseVisualStyleBackColor = True
        '
        'radBasquete
        '
        Me.radBasquete.AutoSize = True
        Me.radBasquete.Location = New System.Drawing.Point(6, 88)
        Me.radBasquete.Name = "radBasquete"
        Me.radBasquete.Size = New System.Drawing.Size(70, 17)
        Me.radBasquete.TabIndex = 3
        Me.radBasquete.Text = "Basquete"
        Me.radBasquete.UseVisualStyleBackColor = True
        '
        'radBaseball
        '
        Me.radBaseball.AutoSize = True
        Me.radBaseball.Location = New System.Drawing.Point(6, 65)
        Me.radBaseball.Name = "radBaseball"
        Me.radBaseball.Size = New System.Drawing.Size(65, 17)
        Me.radBaseball.TabIndex = 2
        Me.radBaseball.Text = "Baseball"
        Me.radBaseball.UseVisualStyleBackColor = True
        '
        'radAtletismo
        '
        Me.radAtletismo.AutoSize = True
        Me.radAtletismo.Location = New System.Drawing.Point(6, 42)
        Me.radAtletismo.Name = "radAtletismo"
        Me.radAtletismo.Size = New System.Drawing.Size(67, 17)
        Me.radAtletismo.TabIndex = 1
        Me.radAtletismo.Text = "Atletismo"
        Me.radAtletismo.UseVisualStyleBackColor = True
        '
        'radArtesMarciais
        '
        Me.radArtesMarciais.AutoSize = True
        Me.radArtesMarciais.Location = New System.Drawing.Point(6, 19)
        Me.radArtesMarciais.Name = "radArtesMarciais"
        Me.radArtesMarciais.Size = New System.Drawing.Size(91, 17)
        Me.radArtesMarciais.TabIndex = 0
        Me.radArtesMarciais.Text = "Artes Marciais"
        Me.radArtesMarciais.UseVisualStyleBackColor = True
        '
        'grpMusica
        '
        Me.grpMusica.Controls.Add(Me.picMusica)
        Me.grpMusica.Controls.Add(Me.radSertanejo)
        Me.grpMusica.Controls.Add(Me.radSamba)
        Me.grpMusica.Controls.Add(Me.radRock)
        Me.grpMusica.Controls.Add(Me.radReggae)
        Me.grpMusica.Controls.Add(Me.radRap)
        Me.grpMusica.Controls.Add(Me.radGospel)
        Me.grpMusica.Controls.Add(Me.radFunk)
        Me.grpMusica.Controls.Add(Me.radForró)
        Me.grpMusica.Controls.Add(Me.radEletrônica)
        Me.grpMusica.Controls.Add(Me.radAxe)
        Me.grpMusica.Location = New System.Drawing.Point(475, 293)
        Me.grpMusica.Name = "grpMusica"
        Me.grpMusica.Size = New System.Drawing.Size(391, 256)
        Me.grpMusica.TabIndex = 0
        Me.grpMusica.TabStop = False
        Me.grpMusica.Text = "Escolha seu estilo de música preferida"
        '
        'picMusica
        '
        Me.picMusica.Image = Global.Projeto_Quiz.My.Resources.Resources.quiz
        Me.picMusica.Location = New System.Drawing.Point(219, 29)
        Me.picMusica.Name = "picMusica"
        Me.picMusica.Size = New System.Drawing.Size(156, 162)
        Me.picMusica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMusica.TabIndex = 10
        Me.picMusica.TabStop = False
        '
        'radSertanejo
        '
        Me.radSertanejo.AutoSize = True
        Me.radSertanejo.Location = New System.Drawing.Point(108, 121)
        Me.radSertanejo.Name = "radSertanejo"
        Me.radSertanejo.Size = New System.Drawing.Size(70, 17)
        Me.radSertanejo.TabIndex = 9
        Me.radSertanejo.Text = "Sertanejo"
        Me.radSertanejo.UseVisualStyleBackColor = True
        '
        'radSamba
        '
        Me.radSamba.AutoSize = True
        Me.radSamba.Location = New System.Drawing.Point(108, 98)
        Me.radSamba.Name = "radSamba"
        Me.radSamba.Size = New System.Drawing.Size(58, 17)
        Me.radSamba.TabIndex = 8
        Me.radSamba.Text = "Samba"
        Me.radSamba.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Location = New System.Drawing.Point(108, 75)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(51, 17)
        Me.radRock.TabIndex = 7
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'radReggae
        '
        Me.radReggae.AutoSize = True
        Me.radReggae.Location = New System.Drawing.Point(108, 52)
        Me.radReggae.Name = "radReggae"
        Me.radReggae.Size = New System.Drawing.Size(63, 17)
        Me.radReggae.TabIndex = 6
        Me.radReggae.Text = "Reggae"
        Me.radReggae.UseVisualStyleBackColor = True
        '
        'radRap
        '
        Me.radRap.AutoSize = True
        Me.radRap.Location = New System.Drawing.Point(108, 29)
        Me.radRap.Name = "radRap"
        Me.radRap.Size = New System.Drawing.Size(45, 17)
        Me.radRap.TabIndex = 5
        Me.radRap.Text = "Rap"
        Me.radRap.UseVisualStyleBackColor = True
        '
        'radGospel
        '
        Me.radGospel.AutoSize = True
        Me.radGospel.Location = New System.Drawing.Point(6, 121)
        Me.radGospel.Name = "radGospel"
        Me.radGospel.Size = New System.Drawing.Size(58, 17)
        Me.radGospel.TabIndex = 4
        Me.radGospel.Text = "Gospel"
        Me.radGospel.UseVisualStyleBackColor = True
        '
        'radFunk
        '
        Me.radFunk.AutoSize = True
        Me.radFunk.Location = New System.Drawing.Point(6, 98)
        Me.radFunk.Name = "radFunk"
        Me.radFunk.Size = New System.Drawing.Size(49, 17)
        Me.radFunk.TabIndex = 3
        Me.radFunk.Text = "Funk"
        Me.radFunk.UseVisualStyleBackColor = True
        '
        'radForró
        '
        Me.radForró.AutoSize = True
        Me.radForró.Location = New System.Drawing.Point(6, 75)
        Me.radForró.Name = "radForró"
        Me.radForró.Size = New System.Drawing.Size(49, 17)
        Me.radForró.TabIndex = 2
        Me.radForró.Text = "Forró"
        Me.radForró.UseVisualStyleBackColor = True
        '
        'radEletrônica
        '
        Me.radEletrônica.AutoSize = True
        Me.radEletrônica.Location = New System.Drawing.Point(6, 52)
        Me.radEletrônica.Name = "radEletrônica"
        Me.radEletrônica.Size = New System.Drawing.Size(72, 17)
        Me.radEletrônica.TabIndex = 1
        Me.radEletrônica.Text = "Eletrônica"
        Me.radEletrônica.UseVisualStyleBackColor = True
        '
        'radAxe
        '
        Me.radAxe.AutoSize = True
        Me.radAxe.Location = New System.Drawing.Point(6, 29)
        Me.radAxe.Name = "radAxe"
        Me.radAxe.Size = New System.Drawing.Size(43, 17)
        Me.radAxe.TabIndex = 0
        Me.radAxe.Text = "Axé"
        Me.radAxe.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(14, 555)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpar.TabIndex = 2
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(791, 555)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 680)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.grpMusica)
        Me.Controls.Add(Me.grpEsporte)
        Me.Controls.Add(Me.grpFilme)
        Me.Controls.Add(Me.grpTime)
        Me.Controls.Add(Me.lblProjetoquiz)
        Me.Name = "frmQuiz"
        Me.Text = "Quiz"
        Me.grpTime.ResumeLayout(False)
        Me.grpTime.PerformLayout()
        CType(Me.picTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFilme.ResumeLayout(False)
        Me.grpFilme.PerformLayout()
        CType(Me.picGenero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEsporte.ResumeLayout(False)
        Me.grpEsporte.PerformLayout()
        CType(Me.picEsporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMusica.ResumeLayout(False)
        Me.grpMusica.PerformLayout()
        CType(Me.picMusica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProjetoquiz As System.Windows.Forms.Label
    Friend WithEvents grpTime As System.Windows.Forms.GroupBox
    Friend WithEvents grpFilme As System.Windows.Forms.GroupBox
    Friend WithEvents grpEsporte As System.Windows.Forms.GroupBox
    Friend WithEvents grpMusica As System.Windows.Forms.GroupBox
    Friend WithEvents picTime As System.Windows.Forms.PictureBox
    Friend WithEvents radSemTime As System.Windows.Forms.RadioButton
    Friend WithEvents radCruzeiro As System.Windows.Forms.RadioButton
    Friend WithEvents radCorinthians As System.Windows.Forms.RadioButton
    Friend WithEvents radSaoPaulo As System.Windows.Forms.RadioButton
    Friend WithEvents radPalmeiras As System.Windows.Forms.RadioButton
    Friend WithEvents radSantos As System.Windows.Forms.RadioButton
    Friend WithEvents picGenero As System.Windows.Forms.PictureBox
    Friend WithEvents radSuspense As System.Windows.Forms.RadioButton
    Friend WithEvents radTerror As System.Windows.Forms.RadioButton
    Friend WithEvents radRomance As System.Windows.Forms.RadioButton
    Friend WithEvents radInfantil As System.Windows.Forms.RadioButton
    Friend WithEvents radDRama As System.Windows.Forms.RadioButton
    Friend WithEvents radComedia As System.Windows.Forms.RadioButton
    Friend WithEvents picEsporte As System.Windows.Forms.PictureBox
    Friend WithEvents radVolei As System.Windows.Forms.RadioButton
    Friend WithEvents radTenis As System.Windows.Forms.RadioButton
    Friend WithEvents radSurf As System.Windows.Forms.RadioButton
    Friend WithEvents radSkate As System.Windows.Forms.RadioButton
    Friend WithEvents radPingPong As System.Windows.Forms.RadioButton
    Friend WithEvents radNatacao As System.Windows.Forms.RadioButton
    Friend WithEvents radMusculacao As System.Windows.Forms.RadioButton
    Friend WithEvents radGinastica As System.Windows.Forms.RadioButton
    Friend WithEvents radFutebol As System.Windows.Forms.RadioButton
    Friend WithEvents radCiclismo As System.Windows.Forms.RadioButton
    Friend WithEvents radCapoeira As System.Windows.Forms.RadioButton
    Friend WithEvents radBoxe As System.Windows.Forms.RadioButton
    Friend WithEvents radBasquete As System.Windows.Forms.RadioButton
    Friend WithEvents radBaseball As System.Windows.Forms.RadioButton
    Friend WithEvents radAtletismo As System.Windows.Forms.RadioButton
    Friend WithEvents radArtesMarciais As System.Windows.Forms.RadioButton
    Friend WithEvents picMusica As System.Windows.Forms.PictureBox
    Friend WithEvents radSertanejo As System.Windows.Forms.RadioButton
    Friend WithEvents radSamba As System.Windows.Forms.RadioButton
    Friend WithEvents radRock As System.Windows.Forms.RadioButton
    Friend WithEvents radReggae As System.Windows.Forms.RadioButton
    Friend WithEvents radRap As System.Windows.Forms.RadioButton
    Friend WithEvents radGospel As System.Windows.Forms.RadioButton
    Friend WithEvents radFunk As System.Windows.Forms.RadioButton
    Friend WithEvents radForró As System.Windows.Forms.RadioButton
    Friend WithEvents radEletrônica As System.Windows.Forms.RadioButton
    Friend WithEvents radAxe As System.Windows.Forms.RadioButton
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button

End Class
