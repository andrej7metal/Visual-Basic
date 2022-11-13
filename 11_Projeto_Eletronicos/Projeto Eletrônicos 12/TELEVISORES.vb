Public Class FrmTELEVISORES

  
 
  
    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Hide()
        FrmProjetoEletronicos.RadTelevisores.Checked = False   ' quando fecha janela tira seleção no botao rad da tela anterior



    End Sub

    Private Sub FrmTELEVISORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class