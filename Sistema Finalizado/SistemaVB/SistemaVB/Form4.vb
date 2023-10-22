Public Class Form4
    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Dim form = New frmRelProdutos
        form.ShowDialog()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim form = New frmRelVendas
        form.ShowDialog()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim form = New frmRelCaixa
        form.ShowDialog()
    End Sub
End Class