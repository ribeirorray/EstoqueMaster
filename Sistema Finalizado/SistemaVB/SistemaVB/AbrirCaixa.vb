Imports System.Data.SqlClient

Public Class AbrirCaixa


    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtAbertura.Text = "" Then
            MsgBox("Digite um valor")
        Else

            Dim cmd As SqlCommand

            Try

                abrir()
                cmd = New SqlCommand("sp_abertura_caixa", con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@data_ab", Now.ToShortDateString())
                cmd.Parameters.AddWithValue("@hora_ab", Now.ToLongTimeString())
                cmd.Parameters.AddWithValue("@funcionario", usuarioNome)
                cmd.Parameters.AddWithValue("@valor_ab", txtAbertura.Text)
                cmd.Parameters.AddWithValue("@valor_sangria", 0)
                cmd.Parameters.AddWithValue("@hora_sangria", Now.ToLongTimeString())
                cmd.Parameters.AddWithValue("@quant_vendas", 0)
                cmd.Parameters.AddWithValue("@prod_vendidos", 0)
                cmd.Parameters.AddWithValue("@total_vendido", 0)
                cmd.Parameters.AddWithValue("@total_caixa", 0)
                cmd.Parameters.AddWithValue("@saldo_total", 0)
                cmd.Parameters.AddWithValue("@valor_quebra", 0)
                cmd.Parameters.AddWithValue("@hora_fecha", Now.ToLongTimeString())

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)




                Me.Hide()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados" + ex.Message)
                fechar()
            End Try

        End If
    End Sub


End Class