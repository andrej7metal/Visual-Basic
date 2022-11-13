<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComputadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmComputadores))
        Me.LblPC = New System.Windows.Forms.Label()
        Me.LblNotebook = New System.Windows.Forms.Label()
        Me.PicPC = New System.Windows.Forms.PictureBox()
        Me.PicNotbook = New System.Windows.Forms.PictureBox()
        Me.BtnVoltar = New System.Windows.Forms.Button()
        CType(Me.PicPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicNotbook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblPC
        '
        Me.LblPC.AutoSize = True
        Me.LblPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPC.Location = New System.Drawing.Point(115, 36)
        Me.LblPC.Name = "LblPC"
        Me.LblPC.Size = New System.Drawing.Size(25, 15)
        Me.LblPC.TabIndex = 0
        Me.LblPC.Text = "PC"
        '
        'LblNotebook
        '
        Me.LblNotebook.AutoSize = True
        Me.LblNotebook.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNotebook.Location = New System.Drawing.Point(322, 36)
        Me.LblNotebook.Name = "LblNotebook"
        Me.LblNotebook.Size = New System.Drawing.Size(68, 15)
        Me.LblNotebook.TabIndex = 1
        Me.LblNotebook.Text = "Notebook"
        '
        'PicPC
        '
        Me.PicPC.Image = CType(resources.GetObject("PicPC.Image"), System.Drawing.Image)
        Me.PicPC.Location = New System.Drawing.Point(51, 62)
        Me.PicPC.Name = "PicPC"
        Me.PicPC.Size = New System.Drawing.Size(171, 134)
        Me.PicPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicPC.TabIndex = 2
        Me.PicPC.TabStop = False
        '
        'PicNotbook
        '
        Me.PicNotbook.Image = CType(resources.GetObject("PicNotbook.Image"), System.Drawing.Image)
        Me.PicNotbook.Location = New System.Drawing.Point(264, 62)
        Me.PicNotbook.Name = "PicNotbook"
        Me.PicNotbook.Size = New System.Drawing.Size(171, 134)
        Me.PicNotbook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicNotbook.TabIndex = 3
        Me.PicNotbook.TabStop = False
        '
        'BtnVoltar
        '
        Me.BtnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVoltar.Location = New System.Drawing.Point(205, 241)
        Me.BtnVoltar.Name = "BtnVoltar"
        Me.BtnVoltar.Size = New System.Drawing.Size(99, 23)
        Me.BtnVoltar.TabIndex = 4
        Me.BtnVoltar.Text = "Voltar"
        Me.BtnVoltar.UseVisualStyleBackColor = True
        '
        'FrmComputadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 303)
        Me.Controls.Add(Me.BtnVoltar)
        Me.Controls.Add(Me.PicNotbook)
        Me.Controls.Add(Me.PicPC)
        Me.Controls.Add(Me.LblNotebook)
        Me.Controls.Add(Me.LblPC)
        Me.Name = "FrmComputadores"
        Me.Text = "Computadores"
        CType(Me.PicPC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicNotbook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblPC As System.Windows.Forms.Label
    Friend WithEvents LblNotebook As System.Windows.Forms.Label
    Friend WithEvents PicPC As System.Windows.Forms.PictureBox
    Friend WithEvents PicNotbook As System.Windows.Forms.PictureBox
    Friend WithEvents BtnVoltar As System.Windows.Forms.Button
End Class
