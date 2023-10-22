Imports System.Data.SqlClient
Imports System.IO

Public Class Vendas


    Private Sub Vendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        DesabilitarCampos()

        btnSalvar.Enabled = False


        CarregarClientes()

        Listar()

        txtCodBarras.Focus()

        btnExcluir.Enabled = False
        btnRel.Enabled = False
        totalizar()

    End Sub


    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()

            cmd = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas as ven INNER JOIN produtos as pro on ven.id_produto = pro.id_produto INNER JOIN clientes as cli on ven.id_cliente = cli.id_cliente where ven.data_venda =  @data and funcionario = @funcionario order by num_vendas desc", con)

            cmd.Parameters.AddWithValue("@data", Now.ToShortDateString)
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)

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
        dg.Columns(3).Visible = False
        dg.Columns(4).Visible = False
        dg.Columns(7).Visible = False
        dg.Columns(8).Visible = False

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

    Private Sub DesabilitarCampos()
        txtNum.Enabled = False
        txtQuantidade.Enabled = False
        cbCliente.Enabled = False
        cbProduto.Enabled = False
        btnRel.Enabled = False

    End Sub

    Private Sub HabilitarCampos()
        txtNum.Enabled = True
        txtQuantidade.Enabled = True
        cbCliente.Enabled = True
        cbProduto.Enabled = True


    End Sub

    Private Sub Limpar()
        txtCodBarras.Focus()

        txtNum.Text = ""


        txtQuantidade.Text = "0"

        txtBuscar.Text = ""

    End Sub

    Sub CarregarProdutos()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("SELECT * FROM produtos", con)
            DA.Fill(DT)
            cbProduto.DisplayMember = "nome"
            cbProduto.ValueMember = "id_produto"
            cbProduto.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        fechar()
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

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True
        GerarNum()
        CarregarProdutos()


    End Sub

    Private Sub cbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        atualizarValor()
    End Sub

    Private Sub atualizarValor()
        Dim cmd As New SqlCommand("buscarValorProd", con)

        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
            cmd.Parameters.Add("@valor", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@quant", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@quant_vendida", SqlDbType.Int).Direction = 2
            cmd.Parameters.Add("@codigo_barras", SqlDbType.VarChar, 100).Direction = 2

            cmd.ExecuteNonQuery()



            Dim valor As Decimal = cmd.Parameters("@valor").Value
            txtValor.Text = CStr(valor)

            Dim quant As Int32 = cmd.Parameters("@quant").Value
            txtEstoque.Text = CStr(quant)



            Dim quant_vendida As Int32 = cmd.Parameters("@quant_vendida").Value
            txtQuantVendida.Text = CStr(quant_vendida)




            Dim cmd2 As New SqlCommand("select imagem from produtos where id_produto = @id", con)
            cmd2.Parameters.AddWithValue("@id", cbProduto.SelectedValue)
            cmd2.ExecuteNonQuery()

            Dim tempImagem As Byte() = DirectCast(cmd2.ExecuteScalar, Byte())
            If tempImagem Is Nothing Then
                MessageBox.Show("Imagem não localizada", "Erro")
                Exit Sub
            End If
            Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
            Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
            fs.Write(tempImagem, 0, tempImagem.Length)
            fs.Flush()
            fs.Close()
            imagem.Image = Image.FromFile(strArquivo)


            Dim cod_barras As String = cmd.Parameters("@codigo_barras").Value
            txtCodBarras.Text = cod_barras


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand

        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim Totestoque As Decimal
        Dim quant_vendida As Decimal
        Dim TotQuantidade As Decimal



        quantidade = txtQuantidade.Text
        estoque = txtEstoque.Text
        Totestoque = estoque - quantidade

        quant_vendida = txtQuantVendida.Text
        TotQuantidade = quant_vendida + quantidade



        If txtNum.Text <> "0" And Totestoque >= 0 Then
            Dim total As Decimal
            Dim valor As Decimal
            Dim quant As Decimal

            valor = txtValor.Text
            quant = txtQuantidade.Text

            total = valor * quant

            Try
                abrir()

                'ABATENDO QUANTIDADE EM ESTOQUE
                cmd = New SqlCommand("sp_editarEstoquepro", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quantidade", Totestoque)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()


                'ACRESCENTAR QUANTIDADE DE PRODUTOS VENDIDOS
                cmd = New SqlCommand("sp_editarQuantidadeVendida", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quant_vendida", TotQuantidade)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()


                'SALVAR SAÍDA NA TABELA ESTOQUE
                cmd = New SqlCommand("sp_salvarEstoque", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@descricao", "Saída")
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@data_alteracao", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@motivo", "Venda")
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()


                cmd = New SqlCommand("sp_salvarvenda", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@num_vendas", txtNum.Text)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@id_cliente", cbCliente.SelectedValue)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor", total)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@data_venda", Now.Date())

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                atualizarValor()

                'Listar()
                BuscarVenda()
                totalizar()

                cbCliente.Enabled = False
                txtNum.Enabled = False


                txtQuantidade.Text = "0"
                btnRel.Enabled = True

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try

        Else
            MsgBox("A quantidade em estoque é insuficiente!!")
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs)
        Dim cmd As SqlCommand

        If txtNum.Text <> "" Then

            Dim total As Decimal
            Dim valor As Decimal
            Dim quant As Decimal

            valor = txtValor.Text
            quant = txtQuantidade.Text

            total = valor * quant

            Try
                abrir()
                cmd = New SqlCommand("sp_editarvenda", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@id_vendas", txtCodigo.Text)
                cmd.Parameters.AddWithValue("@num_vendas", txtNum.Text)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)

                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@valor", total)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                Limpar()
                totalizar()

            Catch ex As Exception
                MessageBox.Show("Erro ao editar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Dim quantidade As Decimal
        Dim estoque As Decimal
        Dim Totestoque As Decimal


        Dim quant_vendida As Decimal
        Dim TotQuantidade As Decimal



        quantidade = txtQuantidade.Text
        estoque = txtEstoque.Text
        Totestoque = estoque + quantidade

        quant_vendida = txtQuantVendida.Text
        TotQuantidade = quant_vendida - quantidade

        Dim cmd As SqlCommand

        If txtCodigo.Text <> "" Then

            Try
                abrir()


                'SALVAR SAÍDA NA TABELA ESTOQUE
                cmd = New SqlCommand("sp_salvarEstoque", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@descricao", "Entrada")
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@data_alteracao", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@motivo", "Cancelamento")
                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()


                'RETIRAR QUANTIDADE DE PRODUTOS VENDIDOS
                cmd = New SqlCommand("sp_editarQuantidadeVendida", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quant_vendida", TotQuantidade)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()


                'DEVOLVENDO QUANTIDADE AO ESTOQUE
                cmd = New SqlCommand("sp_editarEstoquepro", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quantidade", Totestoque)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()

                cmd = New SqlCommand("sp_excluirVenda", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@id_vendas", txtCodigo.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                Limpar()
                totalizar()
                atualizarValor()

                btnExcluir.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick

        btnRel.Enabled = False
        btnExcluir.Enabled = True
        HabilitarCampos()

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        txtNum.Text = dg.CurrentRow.Cells(1).Value
        cbProduto.SelectedValue = dg.CurrentRow.Cells(9).Value
        cbCliente.SelectedValue = dg.CurrentRow.Cells(10).Value
        txtQuantidade.Text = CInt(dg.CurrentRow.Cells(5).Value)



    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" And dg.Rows.Count > 0 Then
            Listar()
            totalizar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_buscarVenda", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@num_vendas", txtBuscar.Text)

                da.Fill(dt)
                dg.DataSource = dt


                totalizar()


            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub totalizar()
        Dim total As Decimal
        For Each lin As DataGridViewRow In dg.Rows
            total = total + lin.Cells(6).Value
        Next

        lblTotal.Text = total
    End Sub



    Private Sub BuscarVenda()
        If txtNum.Text = "" Then
            Listar()
            totalizar()

        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_buscarVenda", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@num_vendas", txtNum.Text)

                da.Fill(dt)
                dg.DataSource = dt


                totalizar()


            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub



    Private Sub GerarNum()

        Dim cmd As New SqlCommand("buscarNumVenda", con)
        Try
            abrir()
            cmd.CommandType = 4

            cmd.Parameters.Add("@num_venda", SqlDbType.Int).Direction = 2

            cmd.ExecuteNonQuery()


            Dim num As Integer = cmd.Parameters("@num_venda").Value

            'Dim hora As String = Now.Second



            Dim num_final As Integer
            num_final = num + 1

            'Dim num_pers As String

            'num_pers = num_final.ToString + hora

            txtNum.Text = CStr(num_final)






        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        fechar()

    End Sub

    Private Sub btnRel_Click(sender As Object, e As EventArgs) Handles btnRel.Click
        If txtNum.Text = "" Then
            MsgBox("Selecione uma venda na tabela!!")
            Exit Sub
        End If

        Dim num As String
        num = txtNum.Text

        Dim subTotal As String
        Dim desconto As String
        Dim totalCompra As String
        Dim valorRecebido As String
        Dim troco As String


        subTotal = lblTotal.Text
        desconto = txtDesconto.Text
        totalCompra = lblTotalFinal.Text
        valorRecebido = txtValorReceb.Text
        troco = lblTroco.Text

        ' Dim form = New frmRelComprovante(num, subTotal, desconto, totalCompra, valorRecebido, troco)
        ' Form.ShowDialog()

    End Sub

    Private Sub txtCodBarras_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodBarras.KeyDown
        If e.Control = True And e.KeyCode = Keys.NumPad1 Then

            txtCodBarras.Text = ""
        End If
        If e.Control = True And e.KeyCode = Keys.NumPad2 Then

            atualizarValorCod()
        End If


    End Sub



    Private Sub atualizarValorCod()
        Dim cmd As New SqlCommand("buscarCodBarras", con)

        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigo_barras", txtCodBarras.Text)

            cmd.Parameters.Add("@id_produto", SqlDbType.Int).Direction = 2


            cmd.ExecuteNonQuery()


            Dim id_produto As Int32 = cmd.Parameters("@id_produto").Value
            cbProduto.SelectedValue = id_produto
            My.Computer.Audio.Play(My.Resources.barCode, AudioPlayMode.WaitToComplete)

        Catch ex As Exception
            'MsgBox("Produto não Encontrado")
        End Try
        fechar()
    End Sub

    Private Sub txtCodBarras_TextChanged(sender As Object, e As EventArgs) Handles txtCodBarras.TextChanged
        atualizarValorCod()
    End Sub

    Private Sub txtQuantidade_TextChanged(sender As Object, e As EventArgs) Handles txtQuantidade.TextChanged

        If txtQuantidade.Text <> "0" And txtValor.Text <> "" Then
            Dim valor As Decimal
            Dim quant As Decimal
            Dim total As Decimal
            valor = txtValor.Text
            quant = txtQuantidade.Text
            total = valor * quant
            lblTotalUnit.Text = total
        End If


    End Sub

    Private Sub txtDesconto_TextChanged(sender As Object, e As EventArgs) Handles txtDesconto.TextChanged

        If lblTotal.Text <> "0" And txtDesconto.Text <> "" Then
            Dim subTotal As Decimal
            Dim desc As Decimal
            Dim total As Decimal
            subTotal = lblTotal.Text
            desc = txtDesconto.Text
            total = subTotal - desc
            lblTotalFinal.Text = total
        End If


    End Sub

    Private Sub txtValorReceb_TextChanged(sender As Object, e As EventArgs) Handles txtValorReceb.TextChanged
        If lblTotalFinal.Text <> "0" And txtValorReceb.Text <> "" Then
            Dim totalFinal As Decimal
            Dim valorPago As Decimal
            Dim total As Decimal
            totalFinal = lblTotalFinal.Text
            valorPago = txtValorReceb.Text
            total = valorPago - totalFinal
            lblTroco.Text = total
        End If
    End Sub
End Class