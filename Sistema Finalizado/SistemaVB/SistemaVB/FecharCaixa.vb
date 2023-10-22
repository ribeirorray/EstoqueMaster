Imports System.Data.SqlClient

Public Class FecharCaixa
    Private valor_abertura As Decimal
    Private quant_vendas As Integer
    Private prod_vendidos As Integer
    Private total_vendido As Decimal
    Private valor_sangria As Decimal

    Private total_caixa As Decimal




    Public Sub New(valor_abertura As Decimal, quant_vendas As Integer, prod_vendidos As Integer, total_vendido As Decimal, valor_sangria As Decimal)
        InitializeComponent()
        Me.valor_abertura = valor_abertura
        Me.quant_vendas = quant_vendas
        Me.prod_vendidos = prod_vendidos
        Me.total_vendido = total_vendido
        Me.valor_sangria = valor_sangria



    End Sub

    Private Sub FecharCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAbertura.Text = valor_abertura
        Listar()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cmd As SqlCommand


        If txtTotalCaixa.Text <> "" Then

            total_caixa = txtTotalCaixa.Text
            Dim subtotal As Decimal
            subtotal = total_caixa - valor_abertura + valor_sangria

            Dim quebra As Decimal
            quebra = total_caixa - total_vendido - valor_abertura + valor_sangria

            Try
                abrir()


                cmd = New SqlCommand("sp_fechar_caixa", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@data_ab", Now.ToShortDateString)
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@valor_ab", txtAbertura.Text)
                cmd.Parameters.AddWithValue("@quant_vendas", quant_vendas)
                cmd.Parameters.AddWithValue("@prod_vendidos", prod_vendidos)
                cmd.Parameters.AddWithValue("@total_vendido", total_vendido)
                cmd.Parameters.AddWithValue("@total_caixa", txtTotalCaixa.Text)
                cmd.Parameters.AddWithValue("@saldo_total", subtotal)
                cmd.Parameters.AddWithValue("@valor_quebra", quebra)
                cmd.Parameters.AddWithValue("@hora_fecha", Now.ToShortTimeString)


                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                Me.Hide()

            Catch ex As Exception
                MessageBox.Show("Erro ao editar os dados" + ex.Message)
                fechar()
            End Try
        End If
    End Sub



    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            abrir()
            cmd = New SqlCommand("SELECT * FROM caixa where funcionario = @func and data_ab = @data", con)
            cmd.Parameters.AddWithValue("@func", usuarioNome)
            cmd.Parameters.AddWithValue("@data", Now.ToShortDateString)
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
        dg.Columns(1).Visible = False
        dg.Columns(3).Visible = False
        dg.Columns(6).Visible = False
        dg.Columns(8).Visible = False
        dg.Columns(10).Visible = False
        dg.Columns(11).Visible = False
        dg.Columns(12).Visible = False
        dg.Columns(13).Visible = False


        dg.Columns(2).HeaderText = "Hora Abertura"
        dg.Columns(4).HeaderText = "Valor da Abertura"
        dg.Columns(5).HeaderText = "Total Sangria"
        dg.Columns(7).HeaderText = "Quantidade Vendas"
        dg.Columns(9).HeaderText = "Total Vendido"




    End Sub



End Class