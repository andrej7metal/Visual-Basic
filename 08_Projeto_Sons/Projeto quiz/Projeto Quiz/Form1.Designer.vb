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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuiz))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBTimePeferido = New System.Windows.Forms.GroupBox()
        Me.RadSantos = New System.Windows.Forms.RadioButton()
        Me.RavSemTime = New System.Windows.Forms.RadioButton()
        Me.RadCruzeiro = New System.Windows.Forms.RadioButton()
        Me.RadCorinthians = New System.Windows.Forms.RadioButton()
        Me.RadsaoPaulo = New System.Windows.Forms.RadioButton()
        Me.RadPalmeiras = New System.Windows.Forms.RadioButton()
        Me.GBEsportePreferido = New System.Windows.Forms.GroupBox()
        Me.RadMusculacao = New System.Windows.Forms.RadioButton()
        Me.RadGinastica = New System.Windows.Forms.RadioButton()
        Me.RadSurf = New System.Windows.Forms.RadioButton()
        Me.RadTenis = New System.Windows.Forms.RadioButton()
        Me.RadFutebol = New System.Windows.Forms.RadioButton()
        Me.RadVolei = New System.Windows.Forms.RadioButton()
        Me.RadSkate = New System.Windows.Forms.RadioButton()
        Me.RadNatacao = New System.Windows.Forms.RadioButton()
        Me.RadpingPong = New System.Windows.Forms.RadioButton()
        Me.RadCapoeira = New System.Windows.Forms.RadioButton()
        Me.RadBasquete = New System.Windows.Forms.RadioButton()
        Me.RadAtletismo = New System.Windows.Forms.RadioButton()
        Me.RadArtesMarciais = New System.Windows.Forms.RadioButton()
        Me.RadCiclismo = New System.Windows.Forms.RadioButton()
        Me.RadBoxe = New System.Windows.Forms.RadioButton()
        Me.RadBaseball = New System.Windows.Forms.RadioButton()
        Me.GBGeneroFilme = New System.Windows.Forms.GroupBox()
        Me.RadTerror = New System.Windows.Forms.RadioButton()
        Me.RadSuspense = New System.Windows.Forms.RadioButton()
        Me.RadRomance = New System.Windows.Forms.RadioButton()
        Me.RadInfantil = New System.Windows.Forms.RadioButton()
        Me.RadComedia = New System.Windows.Forms.RadioButton()
        Me.RadDrama = New System.Windows.Forms.RadioButton()
        Me.GBMusicaPreferida = New System.Windows.Forms.GroupBox()
        Me.RadSertanejo = New System.Windows.Forms.RadioButton()
        Me.RadSamba = New System.Windows.Forms.RadioButton()
        Me.RadReggae = New System.Windows.Forms.RadioButton()
        Me.RadRock = New System.Windows.Forms.RadioButton()
        Me.RadFunk = New System.Windows.Forms.RadioButton()
        Me.RadGospel = New System.Windows.Forms.RadioButton()
        Me.RadRap = New System.Windows.Forms.RadioButton()
        Me.RadForro = New System.Windows.Forms.RadioButton()
        Me.RadEletronica = New System.Windows.Forms.RadioButton()
        Me.RadAxe = New System.Windows.Forms.RadioButton()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.picComedia = New System.Windows.Forms.PictureBox()
        Me.PicMusicaPreferida = New System.Windows.Forms.PictureBox()
        Me.PicEsporte = New System.Windows.Forms.PictureBox()
        Me.PicTimes = New System.Windows.Forms.PictureBox()
        Me.GBTimePeferido.SuspendLayout()
        Me.GBEsportePreferido.SuspendLayout()
        Me.GBGeneroFilme.SuspendLayout()
        Me.GBMusicaPreferida.SuspendLayout()
        CType(Me.picComedia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMusicaPreferida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicEsporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTimes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'GBTimePeferido
        '
        Me.GBTimePeferido.Controls.Add(Me.RadSantos)
        Me.GBTimePeferido.Controls.Add(Me.PicTimes)
        Me.GBTimePeferido.Controls.Add(Me.RavSemTime)
        Me.GBTimePeferido.Controls.Add(Me.RadCruzeiro)
        Me.GBTimePeferido.Controls.Add(Me.RadCorinthians)
        Me.GBTimePeferido.Controls.Add(Me.RadsaoPaulo)
        Me.GBTimePeferido.Controls.Add(Me.RadPalmeiras)
        Me.GBTimePeferido.Location = New System.Drawing.Point(0, 38)
        Me.GBTimePeferido.Name = "GBTimePeferido"
        Me.GBTimePeferido.Size = New System.Drawing.Size(335, 196)
        Me.GBTimePeferido.TabIndex = 1
        Me.GBTimePeferido.TabStop = False
        Me.GBTimePeferido.Text = "Escolha seu time Peferido"
        '
        'RadSantos
        '
        Me.RadSantos.AutoSize = True
        Me.RadSantos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadSantos.Location = New System.Drawing.Point(6, 19)
        Me.RadSantos.Name = "RadSantos"
        Me.RadSantos.Size = New System.Drawing.Size(58, 17)
        Me.RadSantos.TabIndex = 7
        Me.RadSantos.Text = "Santos"
        Me.RadSantos.UseVisualStyleBackColor = True
        '
        'RavSemTime
        '
        Me.RavSemTime.AutoSize = True
        Me.RavSemTime.Location = New System.Drawing.Point(6, 132)
        Me.RavSemTime.Name = "RavSemTime"
        Me.RavSemTime.Size = New System.Drawing.Size(72, 17)
        Me.RavSemTime.TabIndex = 5
        Me.RavSemTime.Text = "Sem Time"
        Me.RavSemTime.UseVisualStyleBackColor = True
        '
        'RadCruzeiro
        '
        Me.RadCruzeiro.AutoSize = True
        Me.RadCruzeiro.Location = New System.Drawing.Point(6, 109)
        Me.RadCruzeiro.Name = "RadCruzeiro"
        Me.RadCruzeiro.Size = New System.Drawing.Size(63, 17)
        Me.RadCruzeiro.TabIndex = 4
        Me.RadCruzeiro.Text = "Cruzeiro"
        Me.RadCruzeiro.UseVisualStyleBackColor = True
        '
        'RadCorinthians
        '
        Me.RadCorinthians.AutoSize = True
        Me.RadCorinthians.Location = New System.Drawing.Point(6, 86)
        Me.RadCorinthians.Name = "RadCorinthians"
        Me.RadCorinthians.Size = New System.Drawing.Size(77, 17)
        Me.RadCorinthians.TabIndex = 3
        Me.RadCorinthians.Text = "Corinthians"
        Me.RadCorinthians.UseVisualStyleBackColor = True
        '
        'RadsaoPaulo
        '
        Me.RadsaoPaulo.AutoSize = True
        Me.RadsaoPaulo.Location = New System.Drawing.Point(6, 63)
        Me.RadsaoPaulo.Name = "RadsaoPaulo"
        Me.RadsaoPaulo.Size = New System.Drawing.Size(74, 17)
        Me.RadsaoPaulo.TabIndex = 2
        Me.RadsaoPaulo.Text = "Sao Paulo"
        Me.RadsaoPaulo.UseVisualStyleBackColor = True
        '
        'RadPalmeiras
        '
        Me.RadPalmeiras.AutoSize = True
        Me.RadPalmeiras.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadPalmeiras.Location = New System.Drawing.Point(6, 40)
        Me.RadPalmeiras.Name = "RadPalmeiras"
        Me.RadPalmeiras.Size = New System.Drawing.Size(70, 17)
        Me.RadPalmeiras.TabIndex = 1
        Me.RadPalmeiras.Text = "Palmeiras"
        Me.RadPalmeiras.UseVisualStyleBackColor = True
        '
        'GBEsportePreferido
        '
        Me.GBEsportePreferido.Controls.Add(Me.PicEsporte)
        Me.GBEsportePreferido.Controls.Add(Me.RadMusculacao)
        Me.GBEsportePreferido.Controls.Add(Me.RadGinastica)
        Me.GBEsportePreferido.Controls.Add(Me.RadSurf)
        Me.GBEsportePreferido.Controls.Add(Me.RadTenis)
        Me.GBEsportePreferido.Controls.Add(Me.RadFutebol)
        Me.GBEsportePreferido.Controls.Add(Me.RadVolei)
        Me.GBEsportePreferido.Controls.Add(Me.RadSkate)
        Me.GBEsportePreferido.Controls.Add(Me.RadNatacao)
        Me.GBEsportePreferido.Controls.Add(Me.RadpingPong)
        Me.GBEsportePreferido.Controls.Add(Me.RadCapoeira)
        Me.GBEsportePreferido.Controls.Add(Me.RadBasquete)
        Me.GBEsportePreferido.Controls.Add(Me.RadAtletismo)
        Me.GBEsportePreferido.Controls.Add(Me.RadArtesMarciais)
        Me.GBEsportePreferido.Controls.Add(Me.RadCiclismo)
        Me.GBEsportePreferido.Controls.Add(Me.RadBoxe)
        Me.GBEsportePreferido.Controls.Add(Me.RadBaseball)
        Me.GBEsportePreferido.Location = New System.Drawing.Point(422, 38)
        Me.GBEsportePreferido.Name = "GBEsportePreferido"
        Me.GBEsportePreferido.Size = New System.Drawing.Size(379, 196)
        Me.GBEsportePreferido.TabIndex = 2
        Me.GBEsportePreferido.TabStop = False
        Me.GBEsportePreferido.Text = "Escola seu esporte preferido"
        '
        'RadMusculacao
        '
        Me.RadMusculacao.AutoSize = True
        Me.RadMusculacao.Location = New System.Drawing.Point(103, 42)
        Me.RadMusculacao.Name = "RadMusculacao"
        Me.RadMusculacao.Size = New System.Drawing.Size(83, 17)
        Me.RadMusculacao.TabIndex = 16
        Me.RadMusculacao.Text = "Musculação"
        Me.RadMusculacao.UseVisualStyleBackColor = True
        '
        'RadGinastica
        '
        Me.RadGinastica.AutoSize = True
        Me.RadGinastica.Location = New System.Drawing.Point(103, 24)
        Me.RadGinastica.Name = "RadGinastica"
        Me.RadGinastica.Size = New System.Drawing.Size(69, 17)
        Me.RadGinastica.TabIndex = 15
        Me.RadGinastica.Text = "Ginastica"
        Me.RadGinastica.UseVisualStyleBackColor = True
        '
        'RadSurf
        '
        Me.RadSurf.AutoSize = True
        Me.RadSurf.Location = New System.Drawing.Point(103, 121)
        Me.RadSurf.Name = "RadSurf"
        Me.RadSurf.Size = New System.Drawing.Size(44, 17)
        Me.RadSurf.TabIndex = 14
        Me.RadSurf.Text = "Surf"
        Me.RadSurf.UseVisualStyleBackColor = True
        '
        'RadTenis
        '
        Me.RadTenis.AutoSize = True
        Me.RadTenis.Location = New System.Drawing.Point(103, 137)
        Me.RadTenis.Name = "RadTenis"
        Me.RadTenis.Size = New System.Drawing.Size(51, 17)
        Me.RadTenis.TabIndex = 13
        Me.RadTenis.Text = "Tênis"
        Me.RadTenis.UseVisualStyleBackColor = True
        '
        'RadFutebol
        '
        Me.RadFutebol.AutoSize = True
        Me.RadFutebol.Location = New System.Drawing.Point(6, 170)
        Me.RadFutebol.Name = "RadFutebol"
        Me.RadFutebol.Size = New System.Drawing.Size(60, 17)
        Me.RadFutebol.TabIndex = 12
        Me.RadFutebol.Text = "Futebol"
        Me.RadFutebol.UseVisualStyleBackColor = True
        '
        'RadVolei
        '
        Me.RadVolei.AutoSize = True
        Me.RadVolei.Location = New System.Drawing.Point(103, 157)
        Me.RadVolei.Name = "RadVolei"
        Me.RadVolei.Size = New System.Drawing.Size(48, 17)
        Me.RadVolei.TabIndex = 11
        Me.RadVolei.Text = "Volei"
        Me.RadVolei.UseVisualStyleBackColor = True
        '
        'RadSkate
        '
        Me.RadSkate.AutoSize = True
        Me.RadSkate.Location = New System.Drawing.Point(103, 104)
        Me.RadSkate.Name = "RadSkate"
        Me.RadSkate.Size = New System.Drawing.Size(53, 17)
        Me.RadSkate.TabIndex = 10
        Me.RadSkate.Text = "Skate"
        Me.RadSkate.UseVisualStyleBackColor = True
        '
        'RadNatacao
        '
        Me.RadNatacao.AutoSize = True
        Me.RadNatacao.Location = New System.Drawing.Point(103, 58)
        Me.RadNatacao.Name = "RadNatacao"
        Me.RadNatacao.Size = New System.Drawing.Size(66, 17)
        Me.RadNatacao.TabIndex = 9
        Me.RadNatacao.Text = "Natação"
        Me.RadNatacao.UseVisualStyleBackColor = True
        '
        'RadpingPong
        '
        Me.RadpingPong.AutoSize = True
        Me.RadpingPong.Location = New System.Drawing.Point(103, 81)
        Me.RadpingPong.Name = "RadpingPong"
        Me.RadpingPong.Size = New System.Drawing.Size(74, 17)
        Me.RadpingPong.TabIndex = 8
        Me.RadpingPong.Text = "Ping Pong"
        Me.RadpingPong.UseVisualStyleBackColor = True
        '
        'RadCapoeira
        '
        Me.RadCapoeira.AutoSize = True
        Me.RadCapoeira.Location = New System.Drawing.Point(6, 124)
        Me.RadCapoeira.Name = "RadCapoeira"
        Me.RadCapoeira.Size = New System.Drawing.Size(67, 17)
        Me.RadCapoeira.TabIndex = 7
        Me.RadCapoeira.Text = "Capoeira"
        Me.RadCapoeira.UseVisualStyleBackColor = True
        '
        'RadBasquete
        '
        Me.RadBasquete.AutoSize = True
        Me.RadBasquete.Location = New System.Drawing.Point(6, 76)
        Me.RadBasquete.Name = "RadBasquete"
        Me.RadBasquete.Size = New System.Drawing.Size(70, 17)
        Me.RadBasquete.TabIndex = 6
        Me.RadBasquete.Text = "Basquete"
        Me.RadBasquete.UseVisualStyleBackColor = True
        '
        'RadAtletismo
        '
        Me.RadAtletismo.AutoSize = True
        Me.RadAtletismo.Location = New System.Drawing.Point(6, 37)
        Me.RadAtletismo.Name = "RadAtletismo"
        Me.RadAtletismo.Size = New System.Drawing.Size(67, 17)
        Me.RadAtletismo.TabIndex = 5
        Me.RadAtletismo.Text = "Atletismo"
        Me.RadAtletismo.UseVisualStyleBackColor = True
        '
        'RadArtesMarciais
        '
        Me.RadArtesMarciais.AutoSize = True
        Me.RadArtesMarciais.Location = New System.Drawing.Point(6, 19)
        Me.RadArtesMarciais.Name = "RadArtesMarciais"
        Me.RadArtesMarciais.Size = New System.Drawing.Size(91, 17)
        Me.RadArtesMarciais.TabIndex = 4
        Me.RadArtesMarciais.Text = "Artes Marciais"
        Me.RadArtesMarciais.UseVisualStyleBackColor = True
        '
        'RadCiclismo
        '
        Me.RadCiclismo.AutoSize = True
        Me.RadCiclismo.Location = New System.Drawing.Point(6, 147)
        Me.RadCiclismo.Name = "RadCiclismo"
        Me.RadCiclismo.Size = New System.Drawing.Size(63, 17)
        Me.RadCiclismo.TabIndex = 3
        Me.RadCiclismo.Text = "Ciclismo"
        Me.RadCiclismo.UseVisualStyleBackColor = True
        '
        'RadBoxe
        '
        Me.RadBoxe.AutoSize = True
        Me.RadBoxe.Location = New System.Drawing.Point(6, 99)
        Me.RadBoxe.Name = "RadBoxe"
        Me.RadBoxe.Size = New System.Drawing.Size(49, 17)
        Me.RadBoxe.TabIndex = 2
        Me.RadBoxe.Text = "Boxe"
        Me.RadBoxe.UseVisualStyleBackColor = True
        '
        'RadBaseball
        '
        Me.RadBaseball.AutoSize = True
        Me.RadBaseball.Location = New System.Drawing.Point(6, 53)
        Me.RadBaseball.Name = "RadBaseball"
        Me.RadBaseball.Size = New System.Drawing.Size(65, 17)
        Me.RadBaseball.TabIndex = 1
        Me.RadBaseball.Text = "Baseball"
        Me.RadBaseball.UseVisualStyleBackColor = True
        '
        'GBGeneroFilme
        '
        Me.GBGeneroFilme.Controls.Add(Me.picComedia)
        Me.GBGeneroFilme.Controls.Add(Me.RadTerror)
        Me.GBGeneroFilme.Controls.Add(Me.RadSuspense)
        Me.GBGeneroFilme.Controls.Add(Me.RadRomance)
        Me.GBGeneroFilme.Controls.Add(Me.RadInfantil)
        Me.GBGeneroFilme.Controls.Add(Me.RadComedia)
        Me.GBGeneroFilme.Controls.Add(Me.RadDrama)
        Me.GBGeneroFilme.Location = New System.Drawing.Point(0, 252)
        Me.GBGeneroFilme.Name = "GBGeneroFilme"
        Me.GBGeneroFilme.Size = New System.Drawing.Size(335, 201)
        Me.GBGeneroFilme.TabIndex = 2
        Me.GBGeneroFilme.TabStop = False
        Me.GBGeneroFilme.Text = "Genero"
        '
        'RadTerror
        '
        Me.RadTerror.AutoSize = True
        Me.RadTerror.Location = New System.Drawing.Point(6, 111)
        Me.RadTerror.Name = "RadTerror"
        Me.RadTerror.Size = New System.Drawing.Size(53, 17)
        Me.RadTerror.TabIndex = 6
        Me.RadTerror.Text = "Terror"
        Me.RadTerror.UseVisualStyleBackColor = True
        '
        'RadSuspense
        '
        Me.RadSuspense.AutoSize = True
        Me.RadSuspense.Location = New System.Drawing.Point(6, 134)
        Me.RadSuspense.Name = "RadSuspense"
        Me.RadSuspense.Size = New System.Drawing.Size(72, 17)
        Me.RadSuspense.TabIndex = 5
        Me.RadSuspense.Text = "Suspense"
        Me.RadSuspense.UseVisualStyleBackColor = True
        '
        'RadRomance
        '
        Me.RadRomance.AutoSize = True
        Me.RadRomance.Location = New System.Drawing.Point(6, 88)
        Me.RadRomance.Name = "RadRomance"
        Me.RadRomance.Size = New System.Drawing.Size(71, 17)
        Me.RadRomance.TabIndex = 4
        Me.RadRomance.Text = "Romance"
        Me.RadRomance.UseVisualStyleBackColor = True
        '
        'RadInfantil
        '
        Me.RadInfantil.AutoSize = True
        Me.RadInfantil.Location = New System.Drawing.Point(6, 65)
        Me.RadInfantil.Name = "RadInfantil"
        Me.RadInfantil.Size = New System.Drawing.Size(56, 17)
        Me.RadInfantil.TabIndex = 3
        Me.RadInfantil.Text = "Infantil"
        Me.RadInfantil.UseVisualStyleBackColor = True
        '
        'RadComedia
        '
        Me.RadComedia.AutoSize = True
        Me.RadComedia.Location = New System.Drawing.Point(6, 19)
        Me.RadComedia.Name = "RadComedia"
        Me.RadComedia.Size = New System.Drawing.Size(66, 17)
        Me.RadComedia.TabIndex = 2
        Me.RadComedia.Text = "Comédia"
        Me.RadComedia.UseVisualStyleBackColor = True
        '
        'RadDrama
        '
        Me.RadDrama.AutoSize = True
        Me.RadDrama.Location = New System.Drawing.Point(6, 42)
        Me.RadDrama.Name = "RadDrama"
        Me.RadDrama.Size = New System.Drawing.Size(56, 17)
        Me.RadDrama.TabIndex = 1
        Me.RadDrama.Text = "Drama"
        Me.RadDrama.UseVisualStyleBackColor = True
        '
        'GBMusicaPreferida
        '
        Me.GBMusicaPreferida.Controls.Add(Me.PicMusicaPreferida)
        Me.GBMusicaPreferida.Controls.Add(Me.RadSertanejo)
        Me.GBMusicaPreferida.Controls.Add(Me.RadSamba)
        Me.GBMusicaPreferida.Controls.Add(Me.RadReggae)
        Me.GBMusicaPreferida.Controls.Add(Me.RadRock)
        Me.GBMusicaPreferida.Controls.Add(Me.RadFunk)
        Me.GBMusicaPreferida.Controls.Add(Me.RadGospel)
        Me.GBMusicaPreferida.Controls.Add(Me.RadRap)
        Me.GBMusicaPreferida.Controls.Add(Me.RadForro)
        Me.GBMusicaPreferida.Controls.Add(Me.RadEletronica)
        Me.GBMusicaPreferida.Controls.Add(Me.RadAxe)
        Me.GBMusicaPreferida.Location = New System.Drawing.Point(422, 261)
        Me.GBMusicaPreferida.Name = "GBMusicaPreferida"
        Me.GBMusicaPreferida.Size = New System.Drawing.Size(379, 192)
        Me.GBMusicaPreferida.TabIndex = 2
        Me.GBMusicaPreferida.TabStop = False
        Me.GBMusicaPreferida.Text = "Escolha seu estilo de musica preferida"
        '
        'RadSertanejo
        '
        Me.RadSertanejo.AutoSize = True
        Me.RadSertanejo.Location = New System.Drawing.Point(106, 125)
        Me.RadSertanejo.Name = "RadSertanejo"
        Me.RadSertanejo.Size = New System.Drawing.Size(70, 17)
        Me.RadSertanejo.TabIndex = 10
        Me.RadSertanejo.Text = "Sertanejo"
        Me.RadSertanejo.UseVisualStyleBackColor = True
        '
        'RadSamba
        '
        Me.RadSamba.AutoSize = True
        Me.RadSamba.Location = New System.Drawing.Point(106, 102)
        Me.RadSamba.Name = "RadSamba"
        Me.RadSamba.Size = New System.Drawing.Size(58, 17)
        Me.RadSamba.TabIndex = 9
        Me.RadSamba.Text = "Samba"
        Me.RadSamba.UseVisualStyleBackColor = True
        '
        'RadReggae
        '
        Me.RadReggae.AutoSize = True
        Me.RadReggae.Location = New System.Drawing.Point(106, 56)
        Me.RadReggae.Name = "RadReggae"
        Me.RadReggae.Size = New System.Drawing.Size(63, 17)
        Me.RadReggae.TabIndex = 8
        Me.RadReggae.Text = "Reggae"
        Me.RadReggae.UseVisualStyleBackColor = True
        '
        'RadRock
        '
        Me.RadRock.AutoSize = True
        Me.RadRock.Location = New System.Drawing.Point(106, 79)
        Me.RadRock.Name = "RadRock"
        Me.RadRock.Size = New System.Drawing.Size(51, 17)
        Me.RadRock.TabIndex = 7
        Me.RadRock.Text = "Rock"
        Me.RadRock.UseVisualStyleBackColor = True
        '
        'RadFunk
        '
        Me.RadFunk.AutoSize = True
        Me.RadFunk.Location = New System.Drawing.Point(6, 102)
        Me.RadFunk.Name = "RadFunk"
        Me.RadFunk.Size = New System.Drawing.Size(49, 17)
        Me.RadFunk.TabIndex = 6
        Me.RadFunk.Text = "Funk"
        Me.RadFunk.UseVisualStyleBackColor = True
        '
        'RadGospel
        '
        Me.RadGospel.AutoSize = True
        Me.RadGospel.Location = New System.Drawing.Point(6, 126)
        Me.RadGospel.Name = "RadGospel"
        Me.RadGospel.Size = New System.Drawing.Size(58, 17)
        Me.RadGospel.TabIndex = 5
        Me.RadGospel.Text = "Gospel"
        Me.RadGospel.UseVisualStyleBackColor = True
        '
        'RadRap
        '
        Me.RadRap.AutoSize = True
        Me.RadRap.Location = New System.Drawing.Point(106, 33)
        Me.RadRap.Name = "RadRap"
        Me.RadRap.Size = New System.Drawing.Size(45, 17)
        Me.RadRap.TabIndex = 4
        Me.RadRap.Text = "Rap"
        Me.RadRap.UseVisualStyleBackColor = True
        '
        'RadForro
        '
        Me.RadForro.AutoSize = True
        Me.RadForro.Location = New System.Drawing.Point(6, 79)
        Me.RadForro.Name = "RadForro"
        Me.RadForro.Size = New System.Drawing.Size(49, 17)
        Me.RadForro.TabIndex = 3
        Me.RadForro.Text = "Forró"
        Me.RadForro.UseVisualStyleBackColor = True
        '
        'RadEletronica
        '
        Me.RadEletronica.AutoSize = True
        Me.RadEletronica.Location = New System.Drawing.Point(6, 56)
        Me.RadEletronica.Name = "RadEletronica"
        Me.RadEletronica.Size = New System.Drawing.Size(72, 17)
        Me.RadEletronica.TabIndex = 2
        Me.RadEletronica.Text = "Eletronica"
        Me.RadEletronica.UseVisualStyleBackColor = True
        '
        'RadAxe
        '
        Me.RadAxe.AutoSize = True
        Me.RadAxe.Location = New System.Drawing.Point(6, 33)
        Me.RadAxe.Name = "RadAxe"
        Me.RadAxe.Size = New System.Drawing.Size(43, 17)
        Me.RadAxe.TabIndex = 1
        Me.RadAxe.Text = "Axé"
        Me.RadAxe.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Location = New System.Drawing.Point(234, 459)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpar.TabIndex = 11
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(428, 459)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(75, 23)
        Me.BtnSair.TabIndex = 12
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'picComedia
        '
        Me.picComedia.Image = CType(resources.GetObject("picComedia.Image"), System.Drawing.Image)
        Me.picComedia.Location = New System.Drawing.Point(132, 31)
        Me.picComedia.Name = "picComedia"
        Me.picComedia.Size = New System.Drawing.Size(177, 144)
        Me.picComedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComedia.TabIndex = 8
        Me.picComedia.TabStop = False
        '
        'PicMusicaPreferida
        '
        Me.PicMusicaPreferida.Image = CType(resources.GetObject("PicMusicaPreferida.Image"), System.Drawing.Image)
        Me.PicMusicaPreferida.Location = New System.Drawing.Point(182, 19)
        Me.PicMusicaPreferida.Name = "PicMusicaPreferida"
        Me.PicMusicaPreferida.Size = New System.Drawing.Size(177, 144)
        Me.PicMusicaPreferida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMusicaPreferida.TabIndex = 7
        Me.PicMusicaPreferida.TabStop = False
        '
        'PicEsporte
        '
        Me.PicEsporte.Image = CType(resources.GetObject("PicEsporte.Image"), System.Drawing.Image)
        Me.PicEsporte.Location = New System.Drawing.Point(183, 30)
        Me.PicEsporte.Name = "PicEsporte"
        Me.PicEsporte.Size = New System.Drawing.Size(177, 148)
        Me.PicEsporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicEsporte.TabIndex = 9
        Me.PicEsporte.TabStop = False
        '
        'PicTimes
        '
        Me.PicTimes.Image = CType(resources.GetObject("PicTimes.Image"), System.Drawing.Image)
        Me.PicTimes.Location = New System.Drawing.Point(132, 30)
        Me.PicTimes.Name = "PicTimes"
        Me.PicTimes.Size = New System.Drawing.Size(177, 147)
        Me.PicTimes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicTimes.TabIndex = 6
        Me.PicTimes.TabStop = False
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 481)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.GBGeneroFilme)
        Me.Controls.Add(Me.GBMusicaPreferida)
        Me.Controls.Add(Me.GBEsportePreferido)
        Me.Controls.Add(Me.GBTimePeferido)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuiz"
        Me.Text = "Projeto Quiz"
        Me.GBTimePeferido.ResumeLayout(False)
        Me.GBTimePeferido.PerformLayout()
        Me.GBEsportePreferido.ResumeLayout(False)
        Me.GBEsportePreferido.PerformLayout()
        Me.GBGeneroFilme.ResumeLayout(False)
        Me.GBGeneroFilme.PerformLayout()
        Me.GBMusicaPreferida.ResumeLayout(False)
        Me.GBMusicaPreferida.PerformLayout()
        CType(Me.picComedia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMusicaPreferida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicEsporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTimes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GBTimePeferido As System.Windows.Forms.GroupBox
    Friend WithEvents GBEsportePreferido As System.Windows.Forms.GroupBox
    Friend WithEvents GBGeneroFilme As System.Windows.Forms.GroupBox
    Friend WithEvents GBMusicaPreferida As System.Windows.Forms.GroupBox
    Friend WithEvents RavSemTime As System.Windows.Forms.RadioButton
    Friend WithEvents RadCruzeiro As System.Windows.Forms.RadioButton
    Friend WithEvents RadCorinthians As System.Windows.Forms.RadioButton
    Friend WithEvents RadsaoPaulo As System.Windows.Forms.RadioButton
    Friend WithEvents RadPalmeiras As System.Windows.Forms.RadioButton
    Friend WithEvents RadMusculacao As System.Windows.Forms.RadioButton
    Friend WithEvents RadGinastica As System.Windows.Forms.RadioButton
    Friend WithEvents RadSurf As System.Windows.Forms.RadioButton
    Friend WithEvents RadTenis As System.Windows.Forms.RadioButton
    Friend WithEvents RadFutebol As System.Windows.Forms.RadioButton
    Friend WithEvents RadVolei As System.Windows.Forms.RadioButton
    Friend WithEvents RadSkate As System.Windows.Forms.RadioButton
    Friend WithEvents RadNatacao As System.Windows.Forms.RadioButton
    Friend WithEvents RadpingPong As System.Windows.Forms.RadioButton
    Friend WithEvents RadCapoeira As System.Windows.Forms.RadioButton
    Friend WithEvents RadBasquete As System.Windows.Forms.RadioButton
    Friend WithEvents RadAtletismo As System.Windows.Forms.RadioButton
    Friend WithEvents RadArtesMarciais As System.Windows.Forms.RadioButton
    Friend WithEvents RadCiclismo As System.Windows.Forms.RadioButton
    Friend WithEvents RadBoxe As System.Windows.Forms.RadioButton
    Friend WithEvents RadBaseball As System.Windows.Forms.RadioButton
    Friend WithEvents RadTerror As System.Windows.Forms.RadioButton
    Friend WithEvents RadSuspense As System.Windows.Forms.RadioButton
    Friend WithEvents RadRomance As System.Windows.Forms.RadioButton
    Friend WithEvents RadInfantil As System.Windows.Forms.RadioButton
    Friend WithEvents RadComedia As System.Windows.Forms.RadioButton
    Friend WithEvents RadDrama As System.Windows.Forms.RadioButton
    Friend WithEvents RadSertanejo As System.Windows.Forms.RadioButton
    Friend WithEvents RadSamba As System.Windows.Forms.RadioButton
    Friend WithEvents RadReggae As System.Windows.Forms.RadioButton
    Friend WithEvents RadRock As System.Windows.Forms.RadioButton
    Friend WithEvents RadFunk As System.Windows.Forms.RadioButton
    Friend WithEvents RadGospel As System.Windows.Forms.RadioButton
    Friend WithEvents RadRap As System.Windows.Forms.RadioButton
    Friend WithEvents RadForro As System.Windows.Forms.RadioButton
    Friend WithEvents RadEletronica As System.Windows.Forms.RadioButton
    Friend WithEvents RadAxe As System.Windows.Forms.RadioButton
    Friend WithEvents BtnLimpar As System.Windows.Forms.Button
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents PicTimes As System.Windows.Forms.PictureBox
    Friend WithEvents PicEsporte As System.Windows.Forms.PictureBox
    Friend WithEvents picComedia As System.Windows.Forms.PictureBox
    Friend WithEvents PicMusicaPreferida As System.Windows.Forms.PictureBox
    Friend WithEvents RadSantos As System.Windows.Forms.RadioButton

End Class
