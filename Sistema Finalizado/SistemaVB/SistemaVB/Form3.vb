Imports System.Data.SqlClient

Public Class Form3
    Dim data As Date
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Dim form = New ListaVendas
        form.ShowDialog()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim formP As Form
        formP = Sangria

        Dim form = New LoginAdm(formP)
        form.ShowDialog()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Data = Now.ToShortDateString()

        'DATA FORMATADA PARA BANCO COM CONFIGURAÇÃO ANO / DIA / MES
        'data = Now.ToString("yyyy/dd/MM")

        Dim cmd As New SqlCommand("sp_verificar_abertura", con)

        Try
            abrir()
            cmd.CommandType = 4
            With cmd.Parameters
                .AddWithValue("@data", Data)
                .AddWithValue("@funcionario", usuarioNome)
                .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()
            End With



            Dim msg As String = cmd.Parameters("@msg").Value


            If (msg = "Abra primeiro o Caixa" Or labelcaixa = "CAIXA FECHADO") Then
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
End Class