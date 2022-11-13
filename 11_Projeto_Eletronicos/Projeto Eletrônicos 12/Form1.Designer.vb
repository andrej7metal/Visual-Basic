<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProjetoEletronicos
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
        Me.LblTituloEletronicos = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadTelevisores = New System.Windows.Forms.RadioButton()
        Me.RadImpressora = New System.Windows.Forms.RadioButton()
        Me.RadComputador = New System.Windows.Forms.RadioButton()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTituloEletronicos
        '
        Me.LblTituloEletronicos.AutoSize = True
        Me.LblTituloEletronicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTituloEletronicos.ForeColor = System.Drawing.Color.Red
        Me.LblTituloEletronicos.Location = New System.Drawing.Point(42, 21)
        Me.LblTituloEletronicos.Name = "LblTituloEletronicos"
        Me.LblTituloEletronicos.Size = New System.Drawing.Size(114, 16)
        Me.LblTituloEletronicos.TabIndex = 0
        Me.LblTituloEletronicos.Text = "ELETRÔNICOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(522, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(8, 8)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RadTelevisores
        '
        Me.RadTelevisores.AutoSize = True
        Me.RadTelevisores.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadTelevisores.Location = New System.Drawing.Point(12, 57)
        Me.RadTelevisores.Name = "RadTelevisores"
        Me.RadTelevisores.Size = New System.Drawing.Size(106, 25)
        Me.RadTelevisores.TabIndex = 2
        Me.RadTelevisores.Text = "Televisores"
        Me.RadTelevisores.UseVisualStyleBackColor = True
        '
        'RadImpressora
        '
        Me.RadImpressora.AutoSize = True
        Me.RadImpressora.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadImpressora.Location = New System.Drawing.Point(12, 93)
        Me.RadImpressora.Name = "RadImpressora"
        Me.RadImpressora.Size = New System.Drawing.Size(114, 25)
        Me.RadImpressora.TabIndex = 3
        Me.RadImpressora.Text = "Impressoras"
        Me.RadImpressora.UseVisualStyleBackColor = True
        '
        'RadComputador
        '
        Me.RadComputador.AutoSize = True
        Me.RadComputador.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadComputador.Location = New System.Drawing.Point(12, 132)
        Me.RadComputador.Name = "RadComputador"
        Me.RadComputador.Size = New System.Drawing.Size(132, 25)
        Me.RadComputador.TabIndex = 4
        Me.RadComputador.Text = "Computadores"
        Me.RadComputador.UseVisualStyleBackColor = True
        '
        'BtnFechar
        '
        Me.BtnFechar.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFechar.Location = New System.Drawing.Point(45, 242)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(73, 21)
        Me.BtnFechar.TabIndex = 5
        Me.BtnFechar.Text = "FECHAR"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'FrmProjetoEletronicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 275)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.RadComputador)
        Me.Controls.Add(Me.RadImpressora)
        Me.Controls.Add(Me.RadTelevisores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblTituloEletronicos)
        Me.Name = "FrmProjetoEletronicos"
        Me.Text = "Projetos Eletronicos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTituloEletronicos As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadTelevisores As System.Windows.Forms.RadioButton
    Friend WithEvents RadImpressora As System.Windows.Forms.RadioButton
    Friend WithEvents RadComputador As System.Windows.Forms.RadioButton
    Friend WithEvents BtnFechar As System.Windows.Forms.Button

End Class
