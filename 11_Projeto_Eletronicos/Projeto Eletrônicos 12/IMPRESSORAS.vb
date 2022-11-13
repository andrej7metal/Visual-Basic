Public Class FrmIMPRESSORAS


    Private Sub BtnVoltar_Click(sender As Object, e As EventArgs) Handles BtnVoltar.Click
        Me.Hide()
        FrmProjetoEletronicos.RadImpressora.Checked = False


    End Sub

    Private Sub FrmIMPRESSORAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class