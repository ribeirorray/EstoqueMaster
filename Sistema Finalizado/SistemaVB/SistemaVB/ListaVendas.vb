Imports System.Data.SqlClient

Public Class ListaVendas
    Private Sub rbCliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliente.CheckedChanged

        cbCliente.Text = ""
        cbFuncionario.Text = ""

        cbCliente.Visible = True
        cbFuncionario.Visible = False
        dtData.Visible = False

    End Sub

    Private Sub rbFuncionario_CheckedChanged(sender As Object, e As EventArgs) Handles rbFuncionario.CheckedChanged
        cbCliente.Text = ""
        cbFuncionario.Text = ""

        cbCliente.Visible = False
        cbFuncionario.Visible = True
        dtData.Visible = False
    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
        cbCliente.Text = ""
        cbFuncionario.Text = ""

        cbCliente.Visible = False
        cbFuncionario.Visible = False
        dtData.Visible = True
    End Sub

    Private Sub ListaVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarFuncionarios()
        CarregarClientes()
        Listar()
    End Sub


    Sub CarregarClientes()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("SELECT * FROM clientes", con)
            DA.Fill(DT)
            cbCliente.DisplayMember = "nome"
            cbCliente.ValueMember = "id_cliente"
            cbCliente.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub


    Sub CarregarFuncionarios()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("SELECT * FROM funcionarios", con)
            DA.Fill(DT)
            cbFuncionario.DisplayMember = "nome"
            cbFuncionario.ValueMember = "id_func"
            cbFuncionario.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub



    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas as ven INNER JOIN produtos as pro on ven.id_produto = pro.id_produto INNER JOIN clientes as cli on ven.id_cliente = cli.id_cliente where ven.data_venda =  @data order by num_vendas desc", con)
            cmd.Parameters.AddWithValue("@data", Now.Date())

            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            dg.DataSource = dt


            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try

    End Sub


    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(9).Visible = False
        dg.Columns(10).Visible = False

        dg.Columns(1).HeaderText = "Núm Venda"
        dg.Columns(2).HeaderText = "Produto"
        dg.Columns(3).HeaderText = "Cliente"
        dg.Columns(4).HeaderText = "Valor Unit"
        dg.Columns(5).HeaderText = "Quantidade"
        dg.Columns(6).HeaderText = "Valor Total"
        dg.Columns(7).HeaderText = "Funcionário"
        dg.Columns(8).HeaderText = "Data Venda"


        dg.Columns(4).Width = 80
        dg.Columns(5).Width = 80
        dg.Columns(6).Width = 90

    End Sub

    Private Sub dt_ValueChanged(sender As Object, e As EventArgs) Handles dtData.ValueChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas as ven INNER JOIN produtos as pro on ven.id_produto = pro.id_produto INNER JOIN clientes as cli on ven.id_cliente = cli.id_cliente where ven.data_venda =  @data order by num_vendas desc", con)

            cmd.Parameters.AddWithValue("@data", dtData.Text)


            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            dg.DataSource = dt


            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub cbFuncionario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFuncionario.SelectedIndexChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas as ven INNER JOIN produtos as pro on ven.id_produto = pro.id_produto INNER JOIN clientes as cli on ven.id_cliente = cli.id_cliente where ven.funcionario =  @func order by num_vendas desc", con)

            cmd.Parameters.AddWithValue("@func", cbFuncionario.Text)


            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            dg.DataSource = dt


            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCliente.SelectedIndexChanged
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas as ven INNER JOIN produtos as pro on ven.id_produto = pro.id_produto INNER JOIN clientes as cli on ven.id_cliente = cli.id_cliente where ven.id_cliente =  @cli order by num_vendas desc", con)

            cmd.Parameters.AddWithValue("@cli", cbCliente.SelectedValue)


            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            dg.DataSource = dt


            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try
    End Sub
End Class