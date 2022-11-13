Public Class Frmnomes


    Private Sub btnNome_Click(sender As Object, e As EventArgs) Handles btnNome.Click
        lblresposta.Text = txtnome.Text
    End Sub

    Private Sub BtnSobrenome_Click(sender As Object, e As EventArgs) Handles BtnSobrenome.Click
        lblresposta.Text = txtSobrenome.Text
    End Sub

    Private Sub btnNomeCompleto_Click(sender As Object, e As EventArgs) Handles btnNomeCompleto.Click
        lblresposta.Text = txtnome.Text + " " + txtSobrenome.Text
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        lblresposta.Text = " "
        txtnome.Clear()
        txtSobrenome.Clear()
        txtnome.Focus()
    End Sub

    Private Sub BtnFechar_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        End
    End Sub
End Class
