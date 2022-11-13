Public Class frmproduto



    Private Sub btnproduto_Click(sender As Object, e As EventArgs) Handles btnproduto.Click
        lblresposta.Text = txtproduto.Text
    End Sub

    Private Sub btnmarca_Click(sender As Object, e As EventArgs) Handles btnmarca.Click
        lblresposta.Text = txtmarca.Text
    End Sub

    Private Sub btnpeso_Click(sender As Object, e As EventArgs) Handles btnpeso.Click
        lblresposta.Text = txtpeso.Text + " Kg"
    End Sub

    Private Sub btndescriçaocompleta_Click(sender As Object, e As EventArgs) Handles btndescriçaocompleta.Click
        lblresposta.Text = txtproduto.Text + vbCr + txtmarca.Text + vbCr + txtpeso.Text + " Kg"
    End Sub

    Private Sub btnlimpar_Click(sender As Object, e As EventArgs) Handles btnlimpar.Click
        txtproduto.Clear()
        txtmarca.Clear()
        txtpeso.Clear()
        lblresposta.Text = " "
        txtproduto.Focus()
    End Sub

    Private Sub btnfechar_Click(sender As Object, e As EventArgs) Handles btnfechar.Click
        End
    End Sub
End Class
