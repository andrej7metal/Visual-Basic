<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmnomes
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
        Me.btnNome = New System.Windows.Forms.Button()
        Me.BtnSobrenome = New System.Windows.Forms.Button()
        Me.btnNomeCompleto = New System.Windows.Forms.Button()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtSobrenome = New System.Windows.Forms.TextBox()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.lblresposta = New System.Windows.Forms.Label()
        Me.LblSobrenome = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNome
        '
        Me.btnNome.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnNome.Location = New System.Drawing.Point(472, 59)
        Me.btnNome.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnNome.Name = "btnNome"
        Me.btnNome.Size = New System.Drawing.Size(99, 31)
        Me.btnNome.TabIndex = 0
        Me.btnNome.Text = "Nome"
        Me.btnNome.UseVisualStyleBackColor = True
        '
        'BtnSobrenome
        '
        Me.BtnSobrenome.Location = New System.Drawing.Point(472, 137)
        Me.BtnSobrenome.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnSobrenome.Name = "BtnSobrenome"
        Me.BtnSobrenome.Size = New System.Drawing.Size(99, 31)
        Me.BtnSobrenome.TabIndex = 1
        Me.BtnSobrenome.Text = "Sobrenome"
        Me.BtnSobrenome.UseVisualStyleBackColor = True
        '
        'btnNomeCompleto
        '
        Me.btnNomeCompleto.Location = New System.Drawing.Point(472, 203)
        Me.btnNomeCompleto.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnNomeCompleto.Name = "btnNomeCompleto"
        Me.btnNomeCompleto.Size = New System.Drawing.Size(99, 47)
        Me.btnNomeCompleto.TabIndex = 2
        Me.btnNomeCompleto.Text = "Nome Completo"
        Me.btnNomeCompleto.UseVisualStyleBackColor = True
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(27, 72)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(41, 18)
        Me.lblNome.TabIndex = 3
        Me.lblNome.Text = "Nome"
        '
        'txtSobrenome
        '
        Me.txtSobrenome.Location = New System.Drawing.Point(115, 132)
        Me.txtSobrenome.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtSobrenome.Name = "txtSobrenome"
        Me.txtSobrenome.Size = New System.Drawing.Size(225, 26)
        Me.txtSobrenome.TabIndex = 1
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Location = New System.Drawing.Point(115, 335)
        Me.BtnLimpar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(99, 31)
        Me.BtnLimpar.TabIndex = 6
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnFechar
        '
        Me.BtnFechar.Location = New System.Drawing.Point(269, 335)
        Me.BtnFechar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(99, 31)
        Me.BtnFechar.TabIndex = 7
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'lblresposta
        '
        Me.lblresposta.AutoSize = True
        Me.lblresposta.Location = New System.Drawing.Point(132, 203)
        Me.lblresposta.Name = "lblresposta"
        Me.lblresposta.Size = New System.Drawing.Size(179, 18)
        Me.lblresposta.TabIndex = 8
        Me.lblresposta.Text = "Confira seus Dados Pessoais"
        '
        'LblSobrenome
        '
        Me.LblSobrenome.AutoSize = True
        Me.LblSobrenome.Location = New System.Drawing.Point(27, 143)
        Me.LblSobrenome.Name = "LblSobrenome"
        Me.LblSobrenome.Size = New System.Drawing.Size(75, 18)
        Me.LblSobrenome.TabIndex = 9
        Me.LblSobrenome.Text = "Sobrenome"
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(115, 72)
        Me.txtnome.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtnome.Multiline = True
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(225, 23)
        Me.txtnome.TabIndex = 0
        '
        'Frmnomes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(643, 397)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.LblSobrenome)
        Me.Controls.Add(Me.lblresposta)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.txtSobrenome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.btnNome)
        Me.Controls.Add(Me.btnNomeCompleto)
        Me.Controls.Add(Me.BtnSobrenome)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Frmnomes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nomes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNome As System.Windows.Forms.Button
    Friend WithEvents BtnSobrenome As System.Windows.Forms.Button
    Friend WithEvents btnNomeCompleto As System.Windows.Forms.Button
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txtSobrenome As System.Windows.Forms.TextBox
    Friend WithEvents BtnLimpar As System.Windows.Forms.Button
    Friend WithEvents BtnFechar As System.Windows.Forms.Button
    Friend WithEvents lblresposta As System.Windows.Forms.Label
    Friend WithEvents LblSobrenome As System.Windows.Forms.Label
    Friend WithEvents txtnome As System.Windows.Forms.TextBox

End Class
