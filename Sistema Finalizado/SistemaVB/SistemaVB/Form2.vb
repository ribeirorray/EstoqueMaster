Public Class Form2
    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Dim form = New Estoque(0)
        form.ShowDialog()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim form = New ConsultaEstoque
        form.ShowDialog()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim form = New Nivel
        form.ShowDialog()
    End Sub
End Class