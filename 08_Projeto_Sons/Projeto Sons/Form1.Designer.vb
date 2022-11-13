<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMSons
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
        Me.LstSom = New System.Windows.Forms.ListBox()
        Me.lblEscolhaSom = New System.Windows.Forms.Label()
        Me.LblSons = New System.Windows.Forms.Label()
        Me.Picimagem = New System.Windows.Forms.PictureBox()
        Me.BtnSair = New System.Windows.Forms.Button()
        CType(Me.Picimagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstSom
        '
        Me.LstSom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstSom.FormattingEnabled = True
        Me.LstSom.ItemHeight = 20
        Me.LstSom.Items.AddRange(New Object() {"Som1", "Som2", "Som3", "Som4", "Som5", "Som6", "Som7", "Som8", "Som9", "Som10"})
        Me.LstSom.Location = New System.Drawing.Point(15, 37)
        Me.LstSom.Name = "LstSom"
        Me.LstSom.Size = New System.Drawing.Size(211, 204)
        Me.LstSom.TabIndex = 0
        '
        'lblEscolhaSom
        '
        Me.lblEscolhaSom.AutoSize = True
        Me.lblEscolhaSom.Location = New System.Drawing.Point(12, 21)
        Me.lblEscolhaSom.Name = "lblEscolhaSom"
        Me.lblEscolhaSom.Size = New System.Drawing.Size(84, 13)
        Me.lblEscolhaSom.TabIndex = 1
        Me.lblEscolhaSom.Text = "Escolha um som"
        '
        'LblSons
        '
        Me.LblSons.AutoSize = True
        Me.LblSons.Location = New System.Drawing.Point(238, 9)
        Me.LblSons.Name = "LblSons"
        Me.LblSons.Size = New System.Drawing.Size(31, 13)
        Me.LblSons.TabIndex = 2
        Me.LblSons.Text = "Sons"
        '
        'Picimagem
        '
        Me.Picimagem.Location = New System.Drawing.Point(288, 37)
        Me.Picimagem.Name = "Picimagem"
        Me.Picimagem.Size = New System.Drawing.Size(204, 199)
        Me.Picimagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picimagem.TabIndex = 3
        Me.Picimagem.TabStop = False
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(214, 273)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(75, 23)
        Me.BtnSair.TabIndex = 4
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'FRMSons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 318)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.Picimagem)
        Me.Controls.Add(Me.LblSons)
        Me.Controls.Add(Me.lblEscolhaSom)
        Me.Controls.Add(Me.LstSom)
        Me.Name = "FRMSons"
        Me.Text = "Projeto Sons"
        CType(Me.Picimagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LstSom As System.Windows.Forms.ListBox
    Friend WithEvents lblEscolhaSom As System.Windows.Forms.Label
    Friend WithEvents LblSons As System.Windows.Forms.Label
    Friend WithEvents Picimagem As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSair As System.Windows.Forms.Button

End Class
