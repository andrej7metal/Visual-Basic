Public Class frmproduto



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnfechar.Click
        End
    End Sub

    Private Sub btnproduto_Click(sender As Object, e As EventArgs) Handles btnproduto.Click
        lblresposta.Text = txtproduto.Text ' resposta recebe produto
    End Sub

    Private Sub btnmarca_Click(sender As Object, e As EventArgs) Handles btnmarca.Click
        lblresposta.Text = txtmarca.Text    'resposta recebe marca
    End Sub

    Private Sub btnpeso_Click(sender As Object, e As EventArgs) Handles btnpeso.Click
        lblresposta.Text = txtpeso.Text 'reposta recebe peso
    End Sub

    Private Sub btndescriçaocompleta_Click(sender As Object, e As EventArgs) Handles btndescriçaocompleta.Click
        lblresposta.Text = "Produto: " & txtproduto.Text & vbCr & "Marca: " & txtmarca.Text & vbCr & "Peso: " & txtpeso.Text ' resposta recebe produto,marca  e peso com quebra de linha








    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnlimpar.Click

        txtproduto.Clear()     ' limpar produto
        txtmarca.Clear() 'limpar sobrenome
        lblresposta.Text = "" '  atribuir  'vazio'  em resposta
        txtproduto.Focus()   'redirecionar o cursor para a caixa de nome'
        txtpeso.Clear() 'limpar peso
        txtproduto.Focus()




    End Sub
End Class
