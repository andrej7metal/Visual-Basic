Public Class Form1

    Private Sub BtnMensagem1_Click(sender As Object, e As EventArgs) Handles BtnMensagem1.Click
        MsgBox("Seja Bem Vindo ao Visual Studio 2013 " & TxtDigiteSeuNome.Text)

    End Sub

    Private Sub BtnMensagem2_Click(sender As Object, e As EventArgs) Handles BtnMensagem2.Click
        MsgBox("Deseja Continuar ? " & TxtDigiteSeuNome.Text, vbQuestion, " Aviso")
    End Sub

    Private Sub BtnMensagem3_Click(sender As Object, e As EventArgs) Handles BtnMensagem3.Click
        MsgBox("Parabens!!!" & TxtDigiteSeuNome.Text, vbExclamation, "saudação ")
    End Sub

    Private Sub BtnMensagem4_Click(sender As Object, e As EventArgs) Handles BtnMensagem4.Click
        MsgBox("Erro " & TxtDigiteSeuNome.Text, vbCritical, "Atenção")
    End Sub

    Private Sub BtnMensagem5_Click(sender As Object, e As EventArgs) Handles BtnMensagem5.Click
        MsgBox("Ignorar" & TxtDigiteSeuNome.Text, vbInformation, "teste")
    End Sub

    Private Sub BtnMensagem6_Click(sender As Object, e As EventArgs) Handles BtnMensagem6.Click
        MsgBox("3 Botôes " & TxtDigiteSeuNome.Text, MsgBoxStyle.AbortRetryIgnore)
    End Sub

    Private Sub BtnMensagem7_Click(sender As Object, e As EventArgs) Handles BtnMensagem7.Click
        MsgBox("2 botões" & TxtDigiteSeuNome.Text, MsgBoxStyle.YesNo)
    End Sub

    Private Sub BtnMensagem8_Click(sender As Object, e As EventArgs) Handles BtnMensagem8.Click
        MsgBox("3 Botoês" & TxtDigiteSeuNome.Text, MsgBoxStyle.YesNoCancel)
    End Sub

    Private Sub LblDigiteSeuNome_Click(sender As Object, e As EventArgs) Handles LblDigiteSeuNome.Click

    End Sub

    Private Sub TxtDigiteSeuNome_TextChanged(sender As Object, e As EventArgs) Handles TxtDigiteSeuNome.TextChanged

    End Sub

    Private Sub LblMensagens_Click(sender As Object, e As EventArgs) Handles LblMensagens.Click

    End Sub

    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub
End Class
