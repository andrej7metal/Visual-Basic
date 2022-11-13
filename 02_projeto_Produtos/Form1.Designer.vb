<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproduto
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
        Me.btnproduto = New System.Windows.Forms.Button()
        Me.btnmarca = New System.Windows.Forms.Button()
        Me.txtproduto = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.lblproduto = New System.Windows.Forms.Label()
        Me.lblmarca = New System.Windows.Forms.Label()
        Me.Lblpeso = New System.Windows.Forms.Label()
        Me.lbldedescricao = New System.Windows.Forms.Label()
        Me.btnpeso = New System.Windows.Forms.Button()
        Me.btndescriçaocompleta = New System.Windows.Forms.Button()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.btnfechar = New System.Windows.Forms.Button()
        Me.txtpeso = New System.Windows.Forms.TextBox()
        Me.lblresposta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnproduto
        '
        Me.btnproduto.BackColor = System.Drawing.Color.Transparent
        Me.btnproduto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnproduto.FlatAppearance.BorderSize = 2
        Me.btnproduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnproduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnproduto.ForeColor = System.Drawing.Color.Black
        Me.btnproduto.Location = New System.Drawing.Point(351, 60)
        Me.btnproduto.Name = "btnproduto"
        Me.btnproduto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnproduto.Size = New System.Drawing.Size(84, 25)
        Me.btnproduto.TabIndex = 4
        Me.btnproduto.Text = "Produtos"
        Me.btnproduto.UseVisualStyleBackColor = False
        '
        'btnmarca
        '
        Me.btnmarca.BackColor = System.Drawing.Color.Transparent
        Me.btnmarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmarca.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnmarca.FlatAppearance.BorderSize = 2
        Me.btnmarca.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnmarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnmarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmarca.ForeColor = System.Drawing.Color.Black
        Me.btnmarca.Location = New System.Drawing.Point(351, 125)
        Me.btnmarca.Name = "btnmarca"
        Me.btnmarca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnmarca.Size = New System.Drawing.Size(84, 29)
        Me.btnmarca.TabIndex = 5
        Me.btnmarca.Text = "Marca"
        Me.btnmarca.UseVisualStyleBackColor = False
        '
        'txtproduto
        '
        Me.txtproduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproduto.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproduto.Location = New System.Drawing.Point(136, 62)
        Me.txtproduto.Name = "txtproduto"
        Me.txtproduto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtproduto.Size = New System.Drawing.Size(178, 25)
        Me.txtproduto.TabIndex = 1
        '
        'txtmarca
        '
        Me.txtmarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmarca.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmarca.Location = New System.Drawing.Point(136, 129)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtmarca.Size = New System.Drawing.Size(178, 25)
        Me.txtmarca.TabIndex = 2
        '
        'lblproduto
        '
        Me.lblproduto.AutoSize = True
        Me.lblproduto.BackColor = System.Drawing.Color.Transparent
        Me.lblproduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblproduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblproduto.Location = New System.Drawing.Point(41, 69)
        Me.lblproduto.Name = "lblproduto"
        Me.lblproduto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblproduto.Size = New System.Drawing.Size(62, 16)
        Me.lblproduto.TabIndex = 5
        Me.lblproduto.Text = "Produto"
        '
        'lblmarca
        '
        Me.lblmarca.AutoSize = True
        Me.lblmarca.BackColor = System.Drawing.Color.Transparent
        Me.lblmarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblmarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblmarca.Location = New System.Drawing.Point(41, 141)
        Me.lblmarca.Name = "lblmarca"
        Me.lblmarca.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmarca.Size = New System.Drawing.Size(51, 16)
        Me.lblmarca.TabIndex = 6
        Me.lblmarca.Text = "Marca"
        '
        'Lblpeso
        '
        Me.Lblpeso.AutoSize = True
        Me.Lblpeso.BackColor = System.Drawing.Color.Transparent
        Me.Lblpeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lblpeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpeso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lblpeso.Location = New System.Drawing.Point(41, 201)
        Me.Lblpeso.Name = "Lblpeso"
        Me.Lblpeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lblpeso.Size = New System.Drawing.Size(63, 16)
        Me.Lblpeso.TabIndex = 7
        Me.Lblpeso.Text = "Peso(g)"
        '
        'lbldedescricao
        '
        Me.lbldedescricao.AutoSize = True
        Me.lbldedescricao.BackColor = System.Drawing.Color.Transparent
        Me.lbldedescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbldedescricao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldedescricao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbldedescricao.Location = New System.Drawing.Point(41, 240)
        Me.lbldedescricao.Name = "lbldedescricao"
        Me.lbldedescricao.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldedescricao.Size = New System.Drawing.Size(71, 15)
        Me.lbldedescricao.TabIndex = 8
        Me.lbldedescricao.Text = "Descriçao"
        '
        'btnpeso
        '
        Me.btnpeso.BackColor = System.Drawing.Color.Transparent
        Me.btnpeso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnpeso.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnpeso.FlatAppearance.BorderSize = 2
        Me.btnpeso.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnpeso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnpeso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpeso.ForeColor = System.Drawing.Color.Black
        Me.btnpeso.Location = New System.Drawing.Point(351, 191)
        Me.btnpeso.Name = "btnpeso"
        Me.btnpeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnpeso.Size = New System.Drawing.Size(84, 26)
        Me.btnpeso.TabIndex = 6
        Me.btnpeso.Text = "Peso"
        Me.btnpeso.UseVisualStyleBackColor = False
        '
        'btndescriçaocompleta
        '
        Me.btndescriçaocompleta.BackColor = System.Drawing.Color.Transparent
        Me.btndescriçaocompleta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndescriçaocompleta.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btndescriçaocompleta.FlatAppearance.BorderSize = 2
        Me.btndescriçaocompleta.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btndescriçaocompleta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btndescriçaocompleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndescriçaocompleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndescriçaocompleta.ForeColor = System.Drawing.Color.Black
        Me.btndescriçaocompleta.Location = New System.Drawing.Point(351, 240)
        Me.btndescriçaocompleta.Name = "btndescriçaocompleta"
        Me.btndescriçaocompleta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btndescriçaocompleta.Size = New System.Drawing.Size(84, 45)
        Me.btndescriçaocompleta.TabIndex = 7
        Me.btndescriçaocompleta.Text = "Descrição completa"
        Me.btndescriçaocompleta.UseVisualStyleBackColor = False
        '
        'btnlimpar
        '
        Me.btnlimpar.BackColor = System.Drawing.Color.Transparent
        Me.btnlimpar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnlimpar.FlatAppearance.BorderSize = 2
        Me.btnlimpar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnlimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlimpar.Location = New System.Drawing.Point(126, 321)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnlimpar.Size = New System.Drawing.Size(75, 32)
        Me.btnlimpar.TabIndex = 8
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.UseVisualStyleBackColor = False
        '
        'btnfechar
        '
        Me.btnfechar.BackColor = System.Drawing.Color.Transparent
        Me.btnfechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnfechar.FlatAppearance.BorderSize = 2
        Me.btnfechar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfechar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnfechar.Location = New System.Drawing.Point(250, 321)
        Me.btnfechar.Name = "btnfechar"
        Me.btnfechar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnfechar.Size = New System.Drawing.Size(75, 32)
        Me.btnfechar.TabIndex = 9
        Me.btnfechar.Text = "Fechar"
        Me.btnfechar.UseVisualStyleBackColor = False
        '
        'txtpeso
        '
        Me.txtpeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpeso.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpeso.Location = New System.Drawing.Point(136, 191)
        Me.txtpeso.Name = "txtpeso"
        Me.txtpeso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtpeso.Size = New System.Drawing.Size(178, 25)
        Me.txtpeso.TabIndex = 3
        '
        'lblresposta
        '
        Me.lblresposta.AutoSize = True
        Me.lblresposta.BackColor = System.Drawing.Color.Transparent
        Me.lblresposta.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblresposta.ForeColor = System.Drawing.Color.Black
        Me.lblresposta.Location = New System.Drawing.Point(133, 240)
        Me.lblresposta.Name = "lblresposta"
        Me.lblresposta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblresposta.Size = New System.Drawing.Size(0, 19)
        Me.lblresposta.TabIndex = 16
        '
        'frmproduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(598, 415)
        Me.Controls.Add(Me.lblresposta)
        Me.Controls.Add(Me.txtpeso)
        Me.Controls.Add(Me.btnfechar)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.btndescriçaocompleta)
        Me.Controls.Add(Me.btnpeso)
        Me.Controls.Add(Me.lbldedescricao)
        Me.Controls.Add(Me.Lblpeso)
        Me.Controls.Add(Me.lblmarca)
        Me.Controls.Add(Me.lblproduto)
        Me.Controls.Add(Me.txtmarca)
        Me.Controls.Add(Me.txtproduto)
        Me.Controls.Add(Me.btnmarca)
        Me.Controls.Add(Me.btnproduto)
        Me.Name = "frmproduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnproduto As System.Windows.Forms.Button
    Friend WithEvents btnmarca As System.Windows.Forms.Button
    Friend WithEvents txtproduto As System.Windows.Forms.TextBox
    Friend WithEvents txtmarca As System.Windows.Forms.TextBox
    Friend WithEvents lblproduto As System.Windows.Forms.Label
    Friend WithEvents lblmarca As System.Windows.Forms.Label
    Friend WithEvents Lblpeso As System.Windows.Forms.Label
    Friend WithEvents lbldedescricao As System.Windows.Forms.Label
    Friend WithEvents btnpeso As System.Windows.Forms.Button
    Friend WithEvents btndescriçaocompleta As System.Windows.Forms.Button
    Friend WithEvents btnlimpar As System.Windows.Forms.Button
    Friend WithEvents btnfechar As System.Windows.Forms.Button
    Friend WithEvents txtpeso As System.Windows.Forms.TextBox
    Friend WithEvents lblresposta As System.Windows.Forms.Label

End Class
