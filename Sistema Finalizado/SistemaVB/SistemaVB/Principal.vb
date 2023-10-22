Imports System.Data.SqlClient

Public Class Principal

    Private imagemCarregada As Image
    Dim data As Date
    Public Shared hoverr As Color = Color.FromArgb(57, 87, 211) ' 
    Dim abertura As Boolean

    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        Dim form = New NovoLogin
        Me.Hide()
        form.ShowDialog()

    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Dim form = New Funcionarios
        form.ShowDialog()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim form = New Clientes
        form.ShowDialog()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        Dim form = New Produtos
        form.ShowDialog()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUsuario.Text = usuarioNome
        If (usuarioNome = "Admin") Then
            FuncionáriosToolStripMenuItem.Enabled = True

        End If

        Listar()
        totalizar()
    End Sub

    Private Sub CarregarDados()

        Dim cmd As New SqlCommand("sp_buscarDadosCaixa", con)
        Try
            abrir()
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@data_ab", Now.ToShortDateString())
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
            cmd.Parameters.Add("@hora_ab", SqlDbType.Time).Direction = 2
            cmd.Parameters.Add("@hora_sangria", SqlDbType.Time).Direction = 2
            cmd.Parameters.Add("@valor_ab", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@valor_sangria", SqlDbType.Decimal).Direction = 2
            cmd.Parameters.Add("@total_caixa", SqlDbType.Decimal).Direction = 2

            cmd.ExecuteNonQuery()

            Dim hora_ab As TimeSpan = cmd.Parameters("@hora_ab").Value
            lblHoraAb.Text = hora_ab.ToString()

            Dim hora_sangria As TimeSpan = cmd.Parameters("@hora_sangria").Value
            lblHoraSangria.Text = hora_sangria.ToString()



            Dim valor_ab As Decimal = cmd.Parameters("@valor_ab").Value
            lblVlrAb.Text = CStr(valor_ab)

            Dim valor_sangria As Decimal = cmd.Parameters("@valor_sangria").Value
            lblTotSang.Text = CStr(valor_sangria)

            Dim total_caixa As Decimal = cmd.Parameters("@total_caixa").Value
            lblTotalCaixa.Text = CStr(total_caixa)

            If total_caixa > 0 Then
                abertura = False
                CarregarImagem()
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = Now.ToLongTimeString()
        lblData.Text = Now.ToShortDateString()
    End Sub

    Private Sub RegistrarVendaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrarVendaToolStripMenuItem.Click


        data = Now.ToShortDateString()

        'DATA FORMATADA PARA BANCO COM CONFIGURAÇÃO ANO / DIA / MES
        'data = Now.ToString("yyyy/dd/MM")

        Dim cmd As New SqlCommand("sp_verificar_abertura", con)

        Try
            abrir()
            cmd.CommandType = 4
            With cmd.Parameters
                .AddWithValue("@data", data)
                .AddWithValue("@funcionario", usuarioNome)
                .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
            End With



            Dim msg As String = cmd.Parameters("@msg").Value


            If (msg = "Abra primeiro o Caixa" Or lblTextoCaixa.Text = "CAIXA FECHADO") Then
                MessageBox.Show("O caixa não está aberto!!!")
            Else

                Dim form = New Vendas
                form.ShowDialog()
            End If


        Catch ex As Exception
            MessageBox.Show("Erro ao Listar " + ex.Message)
            fechar()
        End Try


    End Sub


    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("SELECT ven.id_vendas, ven.num_vendas, pro.nome, cli.nome, pro.valor, ven.quantidade, ven.valor, ven.funcionario, ven.data_venda, ven.id_produto, ven.id_cliente FROM vendas as ven INNER JOIN produtos as pro on ven.id_produto = pro.id_produto INNER JOIN clientes as cli on ven.id_cliente = cli.id_cliente where ven.data_venda =  @data and ven.funcionario = @funcionario order by num_vendas desc", con)
            cmd.Parameters.AddWithValue("@data", Now.Date())
            cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt)
            dg.DataSource = dt


            FormatarDG()

            lblVendasDia.Text = dg.Rows.Count()
            SomarQuantidadeProdutos()

        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try

    End Sub

    Private Sub FormatarDG()
        dg.Columns(0).Visible = False
        dg.Columns(9).Visible = False
        dg.Columns(10).Visible = False
        dg.Columns(4).Visible = False
        dg.Columns(7).Visible = False
        dg.Columns(8).Visible = False
        dg.Columns(1).Visible = False

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

    Sub SomarQuantidadeProdutos()
        Dim quant As Decimal
        For Each linha As DataGridViewRow In dg.Rows
            quant = quant + linha.Cells(5).Value
        Next
        lblProdutosVendidos.Text = quant
    End Sub


    Private Sub totalizar()
        Dim total As Decimal
        For Each lin As DataGridViewRow In dg.Rows
            total = total + lin.Cells(6).Value
        Next

        lblTotal.Text = total
    End Sub

    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Principal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        VerificarNiveis()

        VerificarAbertura()
        Listar()
        totalizar()

        lblVlrAb.Text = 0

        If abertura = True Then
            CarregarDados()
        End If


    End Sub

    Private Sub ListaDeVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeVendasToolStripMenuItem.Click
        Dim form = New ListaVendas
        form.ShowDialog()
    End Sub

    Private Sub FiltroDeVendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FiltroDeVendasToolStripMenuItem.Click
        Dim form = New frmRelVendas
        form.ShowDialog()
    End Sub


    Sub CarregarImagem()

        If abertura = True Then
            imagem.Image = My.Resources.btVerde
            lblTextoCaixa.Text = "CAIXA ABERTO"
            lblAbrirFechar.Text = "FECHAR CAIXA"
        Else
            imagem.Image = My.Resources.btVermelho
            lblTextoCaixa.Text = "CAIXA FECHADO"
            lblAbrirFechar.Text = "ABRIR CAIXA"
        End If


    End Sub





    Sub VerificarAbertura()
        data = Now.ToShortDateString()

        'DATA FORMATADA PARA BANCO COM CONFIGURAÇÃO ANO / DIA / MES
        'data = Now.ToString("yyyy/dd/MM")


        Dim cmd As New SqlCommand("sp_verificar_abertura", con)

        Try
            abrir()
            cmd.CommandType = 4
            With cmd.Parameters
                .AddWithValue("@data", data)
                .AddWithValue("@funcionario", usuarioNome)
                .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
            End With



            Dim msg As String = cmd.Parameters("@msg").Value


            If (msg = "Abra primeiro o Caixa") Then

                abertura = False
                CarregarImagem()
            Else

                abertura = True
                CarregarImagem()
            End If


        Catch ex As Exception
            MessageBox.Show("Erro ao Listar " + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub imagem_Click(sender As Object, e As EventArgs) Handles imagem.Click
        If abertura = True Then


            Dim valor_abertura As Decimal
            valor_abertura = lblVlrAb.Text

            Dim quant_vendas As Integer
            quant_vendas = lblVendasDia.Text

            Dim prod_vendidos As Integer
            prod_vendidos = lblProdutosVendidos.Text

            Dim total_vendido As Decimal
            total_vendido = lblTotal.Text

            Dim valor_sangria As Decimal
            valor_sangria = lblTotSang.Text

            Dim formP = New FecharCaixa(valor_abertura, quant_vendas, prod_vendidos, total_vendido, valor_sangria)


            Dim form = New LoginAdm(formP)
            form.ShowDialog()
        Else

            Dim valorAb As Decimal
            valorAb = lblVlrAb.Text
            If valorAb > 0 Then
                MsgBox("O caixa não pode ser aberto novamente Hoje!")
                labelcaixa = "Caixa Fechado"
                labelmenor.Text = "Caixa Fechado"
            Else
                Dim formP As Form
                labelcaixa = "O caixa está fechado volte amanha."

                formP = AbrirCaixa
                Dim form = New LoginAdm(formP)
                form.ShowDialog()
            End If


        End If
    End Sub

    Private Sub SangriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SangriaToolStripMenuItem.Click

        Dim formP As Form
        formP = Sangria

        Dim form = New LoginAdm(formP)
        form.ShowDialog()
    End Sub

    Sub verificarFechamento()

    End Sub

    Private Sub RelatórioDoCaixaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioDoCaixaToolStripMenuItem.Click
        Dim form = New frmRelCaixa
        form.ShowDialog()
    End Sub

    Private Sub EntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaToolStripMenuItem.Click
        Dim form = New Estoque(0)
        form.ShowDialog()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultasToolStripMenuItem.Click
        Dim form = New ConsultaEstoque
        form.ShowDialog()
    End Sub

    Private Sub EntradaSaídaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaSaídaToolStripMenuItem.Click
        Dim form = New frmRelEstoque
        form.ShowDialog()
    End Sub

    Private Sub NíveisBaixoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NíveisBaixoToolStripMenuItem.Click
        Dim form = New Nivel
        form.ShowDialog()
    End Sub


    Sub VerificarNiveis()
        Dim cmd As New SqlCommand("sp_verificar_nivel", con)

        Try
            abrir()
            cmd.CommandType = 4
            With cmd.Parameters

                .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
            End With



            Dim msg As String = cmd.Parameters("@msg").Value


            If (msg = "Estoque Baixo") Then
                'MsgBox("O Nível de estoque está baixo")

                imagemNivel.Image = My.Resources.btVermelho
                lblNivel.Text = "ESTOQUE BAIXO"

            Else
                imagemNivel.Image = My.Resources.btVerde
                lblNivel.Text = "ESTOQUE BOM"

            End If


        Catch ex As Exception
            MessageBox.Show("Erro ao Listar" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub imagemNivel_Click(sender As Object, e As EventArgs) Handles imagemNivel.Click
        Dim form = New Nivel
        form.ShowDialog()
    End Sub




    Private Sub CatalogoDeProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoDeProdutosToolStripMenuItem.Click
        Dim form = New frmRelProdutos
        form.ShowDialog()
    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles btnCadastro.Click
        Form1.ShowDialog()

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles btnEstoque.Click
        Form2.ShowDialog()


    End Sub

    Private Sub lblAbrirFechar_Click(sender As Object, e As EventArgs) Handles lblAbrirFechar.Click

    End Sub

    Private Sub btnVendas_Click(sender As Object, e As EventArgs) Handles btnVendas.Click
        Form3.ShowDialog()
    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Form4.ShowDialog()
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Application.Exit()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class