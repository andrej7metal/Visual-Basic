<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTELEVISORES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTELEVISORES))
        Me.LblLcd = New System.Windows.Forms.Label()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        Me.LblLed = New System.Windows.Forms.Label()
        Me.LblPlasma = New System.Windows.Forms.Label()
        Me.LblOled = New System.Windows.Forms.Label()
        Me.PicLSD = New System.Windows.Forms.PictureBox()
        Me.PicPlasma = New System.Windows.Forms.PictureBox()
        Me.PicLED = New System.Windows.Forms.PictureBox()
        Me.PicOLED = New System.Windows.Forms.PictureBox()
        CType(Me.PicLSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPlasma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicOLED, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblLcd
        '
        Me.LblLcd.AutoSize = True
        Me.LblLcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLcd.Location = New System.Drawing.Point(76, 46)
        Me.LblLcd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLcd.Name = "LblLcd"
        Me.LblLcd.Size = New System.Drawing.Size(34, 15)
        Me.LblLcd.TabIndex = 0
        Me.LblLcd.Text = "LCD"
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltar.Location = New System.Drawing.Point(389, 301)
        Me.BtnVoltar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(100, 27)
        Me.BtnVoltar.TabIndex = 1
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'LblLed
        '
        Me.LblLed.AutoSize = True
        Me.LblLed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLed.Location = New System.Drawing.Point(546, 46)
        Me.LblLed.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLed.Name = "LblLed"
        Me.LblLed.Size = New System.Drawing.Size(34, 15)
        Me.LblLed.TabIndex = 2
        Me.LblLed.Text = "LED"
        '
        'LblPlasma
        '
        Me.LblPlasma.AutoSize = True
        Me.LblPlasma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPlasma.Location = New System.Drawing.Point(280, 46)
        Me.LblPlasma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPlasma.Name = "LblPlasma"
        Me.LblPlasma.Size = New System.Drawing.Size(61, 15)
        Me.LblPlasma.TabIndex = 3
        Me.LblPlasma.Text = "PLASMA"
        '
        'LblOled
        '
        Me.LblOled.AutoSize = True
        Me.LblOled.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOled.Location = New System.Drawing.Point(774, 46)
        Me.LblOled.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblOled.Name = "LblOled"
        Me.LblOled.Size = New System.Drawing.Size(44, 15)
        Me.LblOled.TabIndex = 4
        Me.LblOled.Text = "OLED"
        '
        'PicLSD
        '
        Me.PicLSD.Image = CType(resources.GetObject("PicLSD.Image"), System.Drawing.Image)
        Me.PicLSD.Location = New System.Drawing.Point(16, 75)
        Me.PicLSD.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PicLSD.Name = "PicLSD"
        Me.PicLSD.Size = New System.Drawing.Size(178, 175)
        Me.PicLSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLSD.TabIndex = 5
        Me.PicLSD.TabStop = False
        '
        'PicPlasma
        '
        Me.PicPlasma.Image = CType(resources.GetObject("PicPlasma.Image"), System.Drawing.Image)
        Me.PicPlasma.Location = New System.Drawing.Point(470, 75)
        Me.PicPlasma.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PicPlasma.Name = "PicPlasma"
        Me.PicPlasma.Size = New System.Drawing.Size(186, 175)
        Me.PicPlasma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPlasma.TabIndex = 6
        Me.PicPlasma.TabStop = False
        '
        'PicLED
        '
        Me.PicLED.Image = CType(resources.GetObject("PicLED.Image"), System.Drawing.Image)
        Me.PicLED.Location = New System.Drawing.Point(231, 75)
        Me.PicLED.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PicLED.Name = "PicLED"
        Me.PicLED.Size = New System.Drawing.Size(186, 175)
        Me.PicLED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLED.TabIndex = 7
        Me.PicLED.TabStop = False
        '
        'PicOLED
        '
        Me.PicOLED.Image = CType(resources.GetObject("PicOLED.Image"), System.Drawing.Image)
        Me.PicOLED.Location = New System.Drawing.Point(710, 75)
        Me.PicOLED.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PicOLED.Name = "PicOLED"
        Me.PicOLED.Size = New System.Drawing.Size(182, 175)
        Me.PicOLED.TabIndex = 8
        Me.PicOLED.TabStop = False
        '
        'FrmTELEVISORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 417)
        Me.Controls.Add(Me.PicOLED)
        Me.Controls.Add(Me.PicLED)
        Me.Controls.Add(Me.PicPlasma)
        Me.Controls.Add(Me.PicLSD)
        Me.Controls.Add(Me.LblOled)
        Me.Controls.Add(Me.LblPlasma)
        Me.Controls.Add(Me.LblLed)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.LblLcd)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmTELEVISORES"
        Me.Text = "TELEVISORES"
        CType(Me.PicLSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPlasma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicOLED, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblLcd As System.Windows.Forms.Label
    Friend WithEvents BtnVoltar As System.Windows.Forms.Button
    Friend WithEvents LblLed As System.Windows.Forms.Label
    Friend WithEvents LblPlasma As System.Windows.Forms.Label
    Friend WithEvents LblOled As System.Windows.Forms.Label
    Friend WithEvents PicLSD As System.Windows.Forms.PictureBox
    Friend WithEvents PicPlasma As System.Windows.Forms.PictureBox
    Friend WithEvents PicLED As System.Windows.Forms.PictureBox
    Friend WithEvents PicOLED As System.Windows.Forms.PictureBox
End Class
