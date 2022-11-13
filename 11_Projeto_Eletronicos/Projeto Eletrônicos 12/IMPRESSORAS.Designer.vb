<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIMPRESSORAS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIMPRESSORAS))
        Me.LblJatoDeTinta = New System.Windows.Forms.Label()
        Me.LblLaser = New System.Windows.Forms.Label()
        Me.LblMultifuncional = New System.Windows.Forms.Label()
        Me.PicJatoTinta = New System.Windows.Forms.PictureBox()
        Me.PicLaser = New System.Windows.Forms.PictureBox()
        Me.PicMultifuncional = New System.Windows.Forms.PictureBox()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        CType(Me.PicJatoTinta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLaser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicMultifuncional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblJatoDeTinta
        '
        Me.LblJatoDeTinta.AutoSize = True
        Me.LblJatoDeTinta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJatoDeTinta.Location = New System.Drawing.Point(55, 20)
        Me.LblJatoDeTinta.Name = "LblJatoDeTinta"
        Me.LblJatoDeTinta.Size = New System.Drawing.Size(90, 15)
        Me.LblJatoDeTinta.TabIndex = 0
        Me.LblJatoDeTinta.Text = "Jato de Tinta"
        '
        'LblLaser
        '
        Me.LblLaser.AutoSize = True
        Me.LblLaser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLaser.Location = New System.Drawing.Point(226, 20)
        Me.LblLaser.Name = "LblLaser"
        Me.LblLaser.Size = New System.Drawing.Size(43, 15)
        Me.LblLaser.TabIndex = 1
        Me.LblLaser.Text = "Laser"
        '
        'LblMultifuncional
        '
        Me.LblMultifuncional.AutoSize = True
        Me.LblMultifuncional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMultifuncional.Location = New System.Drawing.Point(400, 20)
        Me.LblMultifuncional.Name = "LblMultifuncional"
        Me.LblMultifuncional.Size = New System.Drawing.Size(98, 15)
        Me.LblMultifuncional.TabIndex = 2
        Me.LblMultifuncional.Text = "Multifuncional"
        '
        'PicJatoTinta
        '
        Me.PicJatoTinta.Image = CType(resources.GetObject("PicJatoTinta.Image"), System.Drawing.Image)
        Me.PicJatoTinta.Location = New System.Drawing.Point(12, 48)
        Me.PicJatoTinta.Name = "PicJatoTinta"
        Me.PicJatoTinta.Size = New System.Drawing.Size(149, 160)
        Me.PicJatoTinta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicJatoTinta.TabIndex = 3
        Me.PicJatoTinta.TabStop = False
        '
        'PicLaser
        '
        Me.PicLaser.Image = CType(resources.GetObject("PicLaser.Image"), System.Drawing.Image)
        Me.PicLaser.Location = New System.Drawing.Point(178, 48)
        Me.PicLaser.Name = "PicLaser"
        Me.PicLaser.Size = New System.Drawing.Size(160, 160)
        Me.PicLaser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLaser.TabIndex = 4
        Me.PicLaser.TabStop = False
        '
        'PicMultifuncional
        '
        Me.PicMultifuncional.Image = CType(resources.GetObject("PicMultifuncional.Image"), System.Drawing.Image)
        Me.PicMultifuncional.Location = New System.Drawing.Point(354, 48)
        Me.PicMultifuncional.Name = "PicMultifuncional"
        Me.PicMultifuncional.Size = New System.Drawing.Size(160, 160)
        Me.PicMultifuncional.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicMultifuncional.TabIndex = 5
        Me.PicMultifuncional.TabStop = False
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltar.Location = New System.Drawing.Point(229, 238)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.BtnVoltar.TabIndex = 6
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'FrmIMPRESSORAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 290)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.PicMultifuncional)
        Me.Controls.Add(Me.PicLaser)
        Me.Controls.Add(Me.PicJatoTinta)
        Me.Controls.Add(Me.LblMultifuncional)
        Me.Controls.Add(Me.LblLaser)
        Me.Controls.Add(Me.LblJatoDeTinta)
        Me.Name = "FrmIMPRESSORAS"
        Me.Text = "IMPRESSORAS"
        CType(Me.PicJatoTinta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLaser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicMultifuncional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblJatoDeTinta As System.Windows.Forms.Label
    Friend WithEvents LblLaser As System.Windows.Forms.Label
    Friend WithEvents LblMultifuncional As System.Windows.Forms.Label
    Friend WithEvents PicJatoTinta As System.Windows.Forms.PictureBox
    Friend WithEvents PicLaser As System.Windows.Forms.PictureBox
    Friend WithEvents PicMultifuncional As System.Windows.Forms.PictureBox
    Friend WithEvents BtnVoltar As System.Windows.Forms.Button
End Class
