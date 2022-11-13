<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PicImg = New System.Windows.Forms.PictureBox()
        Me.radInverno = New System.Windows.Forms.RadioButton()
        Me.radOutono = New System.Windows.Forms.RadioButton()
        Me.radVerão = New System.Windows.Forms.RadioButton()
        Me.radPrimavera = New System.Windows.Forms.RadioButton()
        CType(Me.PicImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(489, 322)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(64, 20)
        Me.BtnSair.TabIndex = 19
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(227, 16)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(193, 25)
        Me.lblTitulo.TabIndex = 18
        Me.lblTitulo.Text = "Estações Do Ano"
        '
        'PicImg
        '
        Me.PicImg.Location = New System.Drawing.Point(147, 54)
        Me.PicImg.Name = "PicImg"
        Me.PicImg.Size = New System.Drawing.Size(339, 249)
        Me.PicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicImg.TabIndex = 17
        Me.PicImg.TabStop = False
        '
        'radInverno
        '
        Me.radInverno.AutoSize = True
        Me.radInverno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInverno.Location = New System.Drawing.Point(7, 286)
        Me.radInverno.Name = "radInverno"
        Me.radInverno.Size = New System.Drawing.Size(77, 20)
        Me.radInverno.TabIndex = 16
        Me.radInverno.Text = "Inverno"
        Me.radInverno.UseVisualStyleBackColor = True
        '
        'radOutono
        '
        Me.radOutono.AutoSize = True
        Me.radOutono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radOutono.Location = New System.Drawing.Point(7, 207)
        Me.radOutono.Name = "radOutono"
        Me.radOutono.Size = New System.Drawing.Size(75, 20)
        Me.radOutono.TabIndex = 15
        Me.radOutono.Text = "Outono"
        Me.radOutono.UseVisualStyleBackColor = True
        '
        'radVerão
        '
        Me.radVerão.AutoSize = True
        Me.radVerão.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radVerão.Location = New System.Drawing.Point(7, 135)
        Me.radVerão.Name = "radVerão"
        Me.radVerão.Size = New System.Drawing.Size(68, 20)
        Me.radVerão.TabIndex = 14
        Me.radVerão.Text = "Verão"
        Me.radVerão.UseVisualStyleBackColor = True
        '
        'radPrimavera
        '
        Me.radPrimavera.AutoSize = True
        Me.radPrimavera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPrimavera.Location = New System.Drawing.Point(7, 54)
        Me.radPrimavera.Name = "radPrimavera"
        Me.radPrimavera.Size = New System.Drawing.Size(97, 20)
        Me.radPrimavera.TabIndex = 13
        Me.radPrimavera.Text = "Primavera"
        Me.radPrimavera.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(565, 354)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PicImg)
        Me.Controls.Add(Me.radInverno)
        Me.Controls.Add(Me.radOutono)
        Me.Controls.Add(Me.radVerão)
        Me.Controls.Add(Me.radPrimavera)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estações do Ano"
        CType(Me.PicImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents PicImg As System.Windows.Forms.PictureBox
    Friend WithEvents radInverno As System.Windows.Forms.RadioButton
    Friend WithEvents radOutono As System.Windows.Forms.RadioButton
    Friend WithEvents radVerão As System.Windows.Forms.RadioButton
    Friend WithEvents radPrimavera As System.Windows.Forms.RadioButton

End Class
