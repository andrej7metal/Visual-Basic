Public Class FRMLivros

    
    Private Sub ChkSuspenseLivro1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSuspenseLivro1.CheckedChanged
        If ChkSuspenseLivro1.Checked = True Then
            PicSuspenseLivro1.Visible = True
            ChkSuspenseLivro1.Text = "Atraves do fogo"   '  texto aparece no CHK '
            ChkSuspenseLivro1.ForeColor = Color.Red      ' muda a cor do titulo do texto digital em chk '  

        Else
            ChkSuspenseLivro1.Text = " Livro1" ' volta escrever nome do  > através do fogo para > LIVRO1'
            ChkSuspenseLivro1.ForeColor = Color.Black ' muda cor do texto chk para preto de novo
            PicSuspenseLivro1.Visible = False
        End If

    End Sub

    Private Sub ChkSuspenseLivro2_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSuspenseLivro2.CheckedChanged
        If ChkSuspenseLivro2.Checked = True Then
            PicSuspenseLivro2.Visible = True
            ChkSuspenseLivro2.Text = "Coraçoes suspenso" + vbCr + " no vazio" ' Quebra de texto vbCr '
            ChkSuspenseLivro2.ForeColor = Color.Red
        Else
            ChkSuspenseLivro2.Text = "Livro2"
            ChkSuspenseLivro2.ForeColor = Color.Black
            PicSuspenseLivro2.Visible = False
        End If

    End Sub

    Private Sub ChkSuspenseLivro3_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSuspenseLivro3.CheckedChanged
        If ChkSuspenseLivro3.Checked = True Then
            PicSuspenseLivro3.Visible = True
            ChkSuspenseLivro3.Text = "Misterios no caribe"
            ChkSuspenseLivro3.ForeColor = Color.Red
        Else
            PicSuspenseLivro3.Visible = False
            ChkSuspenseLivro3.Text = "Livro3"
            ChkSuspenseLivro3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ChkSuspenseLivro4_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSuspenseLivro4.CheckedChanged
        If ChkSuspenseLivro4.Checked = True Then
            PicSuspenselivro4.Visible = True
            ChkSuspenseLivro4.ForeColor = Color.Red
            ChkSuspenseLivro4.Text = "Fortaleza Digital"
        Else
            PicSuspenselivro4.Visible = False
            ChkSuspenseLivro4.Text = "Livro4"
            ChkSuspenseLivro4.ForeColor = Color.Black

        End If
    End Sub









    Private Sub ChkTerrorLivro1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTerrorLivro1.CheckedChanged
        If ChkTerrorLivro1.Checked = True Then
            PicTerrorLivro1.Visible = True
            ChkTerrorLivro1.ForeColor = Color.BlueViolet
            ChkTerrorLivro1.Text = "Sombras na casa"
        Else
            PicTerrorLivro1.Visible = False
            ChkTerrorLivro1.Text = "Livro1"
            ChkTerrorLivro1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ChkTerrorLivro2_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTerrorLivro2.CheckedChanged
        If ChkTerrorLivro2.Checked = True Then
            PicTerrorLivro2.Visible = True
            ChkTerrorLivro2.ForeColor = Color.BlueViolet
            ChkTerrorLivro2.Text = "A estrada da noite"
        Else
            PicTerrorLivro2.Visible = False
            ChkTerrorLivro2.Text = "Livro2"
            ChkTerrorLivro2.ForeColor = Color.Black

        End If
    End Sub

    Private Sub ChkTerrorLivro3_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTerrorLivro3.CheckedChanged
        If ChkTerrorLivro3.Checked = True Then
            PicTerrorLivro3.Visible = True
            ChkTerrorLivro3.Text = "Fim do jogo"
            ChkTerrorLivro3.ForeColor = Color.BlueViolet
        Else
            PicTerrorLivro3.Visible = False
            ChkTerrorLivro3.Text = "Livro3"
            ChkTerrorLivro3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ChkTerrorLivro4_CheckedChanged(sender As Object, e As EventArgs) Handles ChkTerrorLivro4.CheckedChanged
        If ChkTerrorLivro4.Checked = True Then
            PicTerrorLivro4.Visible = True
            ChkTerrorLivro4.Text = "A passagem"
            ChkTerrorLivro4.ForeColor = Color.BlueViolet
        Else
            PicTerrorLivro4.Visible = False
            ChkTerrorLivro4.Text = " Livro4"
            ChkTerrorLivro4.ForeColor = Color.Black
        End If
    End Sub











    Private Sub ChkFiccaoLivro1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFiccaoLivro1.CheckedChanged
        If ChkFiccaoLivro1.Checked = True Then
            PicFiccaoLivro1.Visible = True
            ChkFiccaoLivro1.Text = "Walking Dead"
            ChkFiccaoLivro1.ForeColor = Color.ForestGreen
        Else
            PicFiccaoLivro1.Visible = False
            ChkFiccaoLivro1.Text = "Livro1"
            ChkFiccaoLivro1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ChkFiccaoLivro2_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFiccaoLivro2.CheckedChanged
        If ChkFiccaoLivro2.Checked = True Then
            PicFiccaoLivro2.Visible = True
            ChkFiccaoLivro2.Text = "Star Trek"
            ChkFiccaoLivro2.ForeColor = Color.ForestGreen
        Else
            PicFiccaoLivro2.Visible = False
            ChkFiccaoLivro2.Text = "Livro2"
            ChkFiccaoLivro2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ChkFiccaoLivro3_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFiccaoLivro3.CheckedChanged
        If ChkFiccaoLivro3.Checked = True Then
            PicFiccaoLivro3.Visible = True
            ChkFiccaoLivro3.Text = "O outro lado da vida"
            ChkFiccaoLivro3.ForeColor = Color.ForestGreen
        Else
            PicFiccaoLivro3.Visible = False
            ChkFiccaoLivro3.Text = "Livro3"
            ChkFiccaoLivro3.ForeColor = Color.Black

        End If

    End Sub

    Private Sub ChkFiccaoLivro4_CheckedChanged(sender As Object, e As EventArgs) Handles ChkFiccaoLivro4.CheckedChanged
        If ChkFiccaoLivro4.Checked = True Then
            PicFiccaoLivro4.Visible = True
            ChkFiccaoLivro4.Text = "Destinados"
            ChkFiccaoLivro4.ForeColor = Color.ForestGreen
        Else
            PicFiccaoLivro4.Visible = False
            ChkFiccaoLivro4.Text = "Livro4"
            ChkFiccaoLivro4.ForeColor = Color.Black
        End If
    End Sub








    Private Sub ChkRomanceLivro1_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRomanceLivro1.CheckedChanged
        If ChkRomanceLivro1.Checked = True Then
            PicRomanceLivro1.Visible = True
            ChkRomanceLivro1.Text = "Para sempre"
            ChkRomanceLivro1.ForeColor = Color.Orange
        Else
            PicRomanceLivro1.Visible = False
            ChkRomanceLivro1.Text = "Livro1"
            ChkRomanceLivro1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ChkRomanceLivro2_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRomanceLivro2.CheckedChanged
        If ChkRomanceLivro2.Checked = True Then
            PicRomanceLivro2.Visible = True
            ChkRomanceLivro2.Text = "Um dia"
            ChkRomanceLivro2.ForeColor = Color.Orange
        Else
            PicRomanceLivro2.Visible = False
            ChkRomanceLivro2.Text = "Livro2"
            ChkRomanceLivro2.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ChkRomanceLivro3_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRomanceLivro3.CheckedChanged
        If ChkRomanceLivro3.Checked = True Then
            PicRomanceLivro3.Visible = True
            ChkRomanceLivro3.Text = "Predator"
            ChkRomanceLivro3.ForeColor = Color.Orange
        Else
            PicRomanceLivro3.Visible = False
            ChkRomanceLivro3.Text = "Livro3"
            ChkRomanceLivro3.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ChkRomanceLivro4_CheckedChanged(sender As Object, e As EventArgs) Handles ChkRomanceLivro4.CheckedChanged
        If ChkRomanceLivro4.Checked = True Then
            PicRomanceLivro4.Visible = True
            ChkRomanceLivro4.Text = "God of war"
            ChkRomanceLivro4.ForeColor = Color.Orange

        Else
            PicRomanceLivro4.Visible = False
            ChkRomanceLivro4.Text = "Livro4"
            ChkRomanceLivro4.ForeColor = Color.Black

        End If
    End Sub
    Private Sub BtnSair_Click(sender As Object, e As EventArgs) Handles BtnSair.Click
        End
    End Sub
End Class
