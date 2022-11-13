Public Class FrmProjetoEletronicos

    Private Sub RadTelevisores_CheckedChanged(sender As Object, e As EventArgs) Handles RadTelevisores.CheckedChanged
        If RadTelevisores.Checked = True Then    ' não deixa a tela de televisores abrir quando selecionar para ver impressoras se nao abre 2 telas em múltuo '
            FrmTELEVISORES.Show() ' abre e motra a janela de televisores '
        End If



    End Sub

    Private Sub RadImpressora_CheckedChanged(sender As Object, e As EventArgs) Handles RadImpressora.CheckedChanged
        If RadImpressora.Checked = True Then
            FrmIMPRESSORAS.Show()
        End If

    End Sub


    Private Sub RadComputador_CheckedChanged(sender As Object, e As EventArgs) Handles RadComputador.CheckedChanged
        If RadComputador.Checked = True Then
            FrmComputadores.Show()


        End If
    End Sub

    Private Sub FrmProjetoEletronicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        End
    End Sub
End Class
