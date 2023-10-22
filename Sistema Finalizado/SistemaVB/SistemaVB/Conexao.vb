Imports System.Data.SqlClient

Module Conexao
    Public con As New SqlConnection("Server=DESKTOP-VA5UM3C; DataBase=sistemavb; Integrated Security=SSPI")
    Public labelcaixa As String

    Sub abrir()
        If con.State = 0 Then
            con.Open()
        End If
    End Sub

    Sub fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub


    Public usuarioNome As String

End Module
