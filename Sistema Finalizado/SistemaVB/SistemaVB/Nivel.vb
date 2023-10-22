Imports System.Data.SqlClient

Public Class Nivel


    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT * FROM produtos where quantidade < nivel_minimo", con)
            da.Fill(dt)
            dg.DataSource = dt

            ContarLinhas()
            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(6).Visible = False

        dg.Columns(1).HeaderText = "Nome"
        dg.Columns(2).HeaderText = "Descriçao"
        dg.Columns(3).HeaderText = "Quantidade"
        dg.Columns(4).HeaderText = "Valor"
        dg.Columns(5).HeaderText = "Data de Cadastro"
        dg.Columns(7).HeaderText = "Nível Minimo"

        dg.Columns(2).Width = 130


    End Sub


    Private Sub ContarLinhas()
        Dim total As Integer = dg.Rows.Count
        lblTotal.Text = CInt(total)

    End Sub

    Private Sub Nivel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub

    Private Sub dg_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellDoubleClick

        Dim id_produto As Integer
        id_produto = dg.CurrentRow.Cells(0).Value
        Dim form = New Estoque(id_produto)

        form.ShowDialog()
    End Sub

    Private Sub Nivel_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Listar()
    End Sub
End Class