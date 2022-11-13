Public Class FrmPrincipal

    Private Sub radPrimavera_CheckedChanged(sender As Object, e As EventArgs) Handles radPrimavera.CheckedChanged
        PicImg.Image = My.Resources.primavera
        lblTitulo.Text = radPrimavera.Text
    End Sub

    Private Sub radVerão_CheckedChanged(sender As Object, e As EventArgs) Handles radVerão.CheckedChanged
        PicImg.Image = My.Resources.verão
        lblTitulo.Text = radVerão.Text
    End Sub

    Private Sub radOutono_CheckedChanged(sender As Object, e As EventArgs) Handles radOutono.CheckedChanged
        PicImg.Image = My.Resources.outono
        lblTitulo.Text = radOutono.Text
    End Sub

    Private Sub radInverno_CheckedChanged(sender As Object, e As EventArgs) Handles radInverno.CheckedChanged
        PicImg.Image = My.Resources.inverno
        lblTitulo.Text = radInverno.Text
    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub
End Class
