Imports System.Data.SqlClient
Imports System.IO

Public Class Estoque

    Dim id_produto As Integer

    Sub New(id_produto As Integer)

        InitializeComponent()
        Me.id_produto = id_produto



    End Sub

    Private Sub Estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarProdutosBuscar()
        cbBuscar.Text = ""
        DesabilitarCampos()

        btnSalvar.Enabled = False
        cbDescricao.Text = "Entrada"

        CarregarProdutos()

        If id_produto > 0 Then
            cbProduto.SelectedValue = id_produto
            txtQuantidade.Enabled = True
            btnSalvar.Enabled = True

        End If


        Listar()


        btnExcluir.Enabled = False
    End Sub


    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("SELECT est.id_estoque, pro.nome, est.descricao, est.quantidade, est.data_alteracao, est.id_produto, est.funcionario, est.motivo from estoque as est INNER JOIN produtos as pro on est.id_produto = pro.id_produto order by id_estoque desc", con)
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
        dg.Columns(5).Visible = False

        dg.Columns(1).HeaderText = "Produto"
        dg.Columns(2).HeaderText = "Descrição"
        dg.Columns(3).HeaderText = "Quantidade"
        dg.Columns(4).HeaderText = "Data"

        dg.Columns(6).HeaderText = "Funcionário"
        dg.Columns(7).HeaderText = "Motivo"


    End Sub

    Private Sub DesabilitarCampos()
        cbDescricao.Enabled = False
        txtQuantidade.Enabled = False
        cbProduto.Enabled = False


    End Sub

    Private Sub HabilitarCampos()
        cbDescricao.Enabled = True
        txtQuantidade.Enabled = True
        cbProduto.Enabled = True


    End Sub

    Private Sub Limpar()

        txtQuantidade.Text = ""
        cbBuscar.Text = ""

        cbDescricao.Text = "Entrada"

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


    Sub CarregarProdutosBuscar()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("SELECT * FROM produtos", con)
            DA.Fill(DT)
            cbBuscar.DisplayMember = "nome"
            cbBuscar.ValueMember = "id_produto"
            cbBuscar.DataSource = DT


        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        HabilitarCampos()
        Limpar()
        btnSalvar.Enabled = True

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand


        If txtQuantidade.Text <> "" Then

            Try
                abrir()


                'ABATENDO QUANTIDADE EM ESTOQUE
                Dim quantidade As Decimal
                Dim estoque As Decimal
                Dim Totestoque As Decimal

                quantidade = txtQuantidade.Text
                estoque = txtEstoque.Text

                If cbDescricao.Text = "Saída" Then
                    Totestoque = estoque - quantidade
                Else
                    Totestoque = estoque + quantidade
                End If


                cmd = New SqlCommand("sp_editarEstoquepro", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quantidade", Totestoque)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()



                cmd = New SqlCommand("sp_salvarEstoque", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@descricao", cbDescricao.Text)
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text)
                cmd.Parameters.AddWithValue("@data_alteracao", Now.ToShortDateString)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)

                If cbDescricao.Text = "Entrada" Then
                    cmd.Parameters.AddWithValue("@motivo", "Compra")
                Else
                    cmd.Parameters.AddWithValue("@motivo", "Desperdício")
                End If


                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)



                Listar()
                atualizarValor()

                Limpar()
                DesabilitarCampos()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try

        Else
            MsgBox("Preencha os campos corretamente!!")
        End If
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



            Dim quant As Int32 = cmd.Parameters("@quant").Value
            txtEstoque.Text = CStr(quant)


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



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        btnExcluir.Enabled = True
        HabilitarCampos()
        atualizarValor()

        txtCodigo.Text = dg.CurrentRow.Cells(0).Value
        cbDescricao.Text = dg.CurrentRow.Cells(2).Value
        txtQuantidade.Text = dg.CurrentRow.Cells(3).Value
        cbProduto.SelectedValue = dg.CurrentRow.Cells(5).Value


    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As SqlCommand

        If txtCodigo.Text <> "" Then

            Try
                abrir()


                'ABATENDO QUANTIDADE EM ESTOQUE
                Dim quantidade As Decimal
                Dim estoque As Decimal
                Dim Totestoque As Decimal

                quantidade = txtQuantidade.Text
                estoque = txtEstoque.Text

                If cbDescricao.Text = "Saída" Then
                    Totestoque = estoque + quantidade
                Else
                    Totestoque = estoque - quantidade
                End If


                cmd = New SqlCommand("sp_editarEstoquepro", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@quantidade", Totestoque)
                cmd.Parameters.AddWithValue("@id_produto", cbProduto.SelectedValue)
                cmd.ExecuteNonQuery()





                cmd = New SqlCommand("sp_excluirEstoque", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                Limpar()

                atualizarValor()

                btnExcluir.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub



    Private Sub cbBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBuscar.SelectedIndexChanged
        If cbBuscar.Text = "" And dg.Rows.Count > 0 Then
            Listar()


        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_buscarEstoque", con)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@id_produto", cbBuscar.SelectedValue)

                da.Fill(dt)
                dg.DataSource = dt





            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub cbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduto.SelectedIndexChanged
        atualizarValor()
    End Sub
End Class