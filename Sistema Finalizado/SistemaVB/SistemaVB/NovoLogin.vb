Imports System.Data.SqlClient

Public Class NovoLogin



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim usuario As String = txtusuario.Text
        Dim senha As String = txtsenha.Text

        If usuario = "" Or senha = "" Then
            MsgBox("Preencha os Campos!!")
        Else

            Dim cmd As New SqlCommand("login", con)

            Try
                abrir()
                cmd.CommandType = 4
                With cmd.Parameters
                    .AddWithValue("@nome", usuario)
                    .AddWithValue("@cpf", senha)
                    .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()
                End With

                usuarioNome = txtusuario.Text

                Dim msg As String = cmd.Parameters("@msg").Value
                MsgBox(msg, vbInformation)

                If (msg = "Dados Incorretos") Then
                    txtsenha.Text = ""
                    txtusuario.Text = ""
                    txtusuario.Focus()
                Else
                    Dim form = New Principal
                    Me.Hide()
                    form.ShowDialog()
                End If


            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try

        End If


    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Me.Close()
    End Sub
End Class
