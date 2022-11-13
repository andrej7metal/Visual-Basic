Public Class FrmComputadores

    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Hide()

        FrmProjetoEletronicos.RadComputador.Checked = False
    End Sub



    Private Sub FrmComputadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class