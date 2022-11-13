<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProjetoIdiomas
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
        Me.LblBemVindoProgramaInternacional = New System.Windows.Forms.Label()
        Me.LblFrase = New System.Windows.Forms.Label()
        Me.BtnSair = New System.Windows.Forms.Button()
        Me.ListIdiomas = New System.Windows.Forms.ListBox()
        Me.Picbandeira = New System.Windows.Forms.PictureBox()
        Me.LblEscolhaIdioma = New System.Windows.Forms.Label()
        CType(Me.Picbandeira, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblBemVindoProgramaInternacional
        '
        Me.LblBemVindoProgramaInternacional.AutoSize = True
        Me.LblBemVindoProgramaInternacional.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBemVindoProgramaInternacional.Location = New System.Drawing.Point(184, 21)
        Me.LblBemVindoProgramaInternacional.Name = "LblBemVindoProgramaInternacional"
        Me.LblBemVindoProgramaInternacional.Size = New System.Drawing.Size(374, 28)
        Me.LblBemVindoProgramaInternacional.TabIndex = 0
        Me.LblBemVindoProgramaInternacional.Text = "Bem Vindo ao Programa Internacional"
        '
        'LblFrase
        '
        Me.LblFrase.AutoSize = True
        Me.LblFrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFrase.Location = New System.Drawing.Point(461, 103)
        Me.LblFrase.Name = "LblFrase"
        Me.LblFrase.Size = New System.Drawing.Size(55, 20)
        Me.LblFrase.TabIndex = 1
        Me.LblFrase.Text = "Frase"
        '
        'BtnSair
        '
        Me.BtnSair.Location = New System.Drawing.Point(465, 248)
        Me.BtnSair.Name = "BtnSair"
        Me.BtnSair.Size = New System.Drawing.Size(75, 23)
        Me.BtnSair.TabIndex = 2
        Me.BtnSair.Text = "Sair"
        Me.BtnSair.UseVisualStyleBackColor = True
        '
        'ListIdiomas
        '
        Me.ListIdiomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListIdiomas.FormattingEnabled = True
        Me.ListIdiomas.ItemHeight = 20
        Me.ListIdiomas.Items.AddRange(New Object() {"Inglês", "Espanhol", "Francês", "Alemão", "Italiano", "Português"})
        Me.ListIdiomas.Location = New System.Drawing.Point(31, 87)
        Me.ListIdiomas.Name = "ListIdiomas"
        Me.ListIdiomas.Size = New System.Drawing.Size(196, 184)
        Me.ListIdiomas.TabIndex = 3
        '
        'Picbandeira
        '
        Me.Picbandeira.Location = New System.Drawing.Point(248, 87)
        Me.Picbandeira.Name = "Picbandeira"
        Me.Picbandeira.Size = New System.Drawing.Size(179, 184)
        Me.Picbandeira.TabIndex = 4
        Me.Picbandeira.TabStop = False
        '
        'LblEscolhaIdioma
        '
        Me.LblEscolhaIdioma.AutoSize = True
        Me.LblEscolhaIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEscolhaIdioma.ForeColor = System.Drawing.Color.Black
        Me.LblEscolhaIdioma.Location = New System.Drawing.Point(50, 64)
        Me.LblEscolhaIdioma.Name = "LblEscolhaIdioma"
        Me.LblEscolhaIdioma.Size = New System.Drawing.Size(159, 20)
        Me.LblEscolhaIdioma.TabIndex = 5
        Me.LblEscolhaIdioma.Text = "Escolha um idioma"
        '
        'FrmProjetoIdiomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(753, 376)
        Me.Controls.Add(Me.LblEscolhaIdioma)
        Me.Controls.Add(Me.Picbandeira)
        Me.Controls.Add(Me.ListIdiomas)
        Me.Controls.Add(Me.BtnSair)
        Me.Controls.Add(Me.LblFrase)
        Me.Controls.Add(Me.LblBemVindoProgramaInternacional)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FrmProjetoIdiomas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Projeto Idiomas"
        CType(Me.Picbandeira, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblBemVindoProgramaInternacional As System.Windows.Forms.Label
    Friend WithEvents LblFrase As System.Windows.Forms.Label
    Friend WithEvents BtnSair As System.Windows.Forms.Button
    Friend WithEvents ListIdiomas As System.Windows.Forms.ListBox
    Friend WithEvents Picbandeira As System.Windows.Forms.PictureBox
    Friend WithEvents LblEscolhaIdioma As System.Windows.Forms.Label

End Class
