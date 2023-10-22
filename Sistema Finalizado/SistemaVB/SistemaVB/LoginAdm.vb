Imports System.Data.SqlClient

Public Class LoginAdm

    Dim form As Form

    Sub New(formP As Form)

        InitializeComponent()
        form = formP


    End Sub

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        Dim usuario As String = "Admin"
        Dim senha As String = txtSenha.Text

        If senha = "" Then
            MsgBox("Preencha a senha!!")
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

                Dim msg As String = cmd.Parameters("@msg").Value


                If (msg = "Dados Incorretos") Then
                    txtSenha.Clear()

                Else

                    Me.Hide()
                    form.ShowDialog()
                End If


            Catch ex As Exception
                MessageBox.Show("Erro ao Listar" + ex.Message)
                fechar()
            End Try

        End If

    End Sub
End Class