Imports System.Data.SqlClient

Public Class frmRelCaixa
    Private Sub frmRelCaixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'CaixaaDataSet.caixa'. Você pode movê-la ou removê-la conforme necessário.
        Me.CaixaTableAdapter.Fill(Me.CaixaaDataSet.caixa, cbFunc.Text, dt.Value)


        dt.Value = Now.ToShortDateString
        cbFunc.Text = usuarioNome

        CarregarFuncionarios()
        IniciarRel()
        'TODO: esta linha de código carrega dados na tabela 'caixaDataSet.caixa'. Você pode movê-la ou removê-la conforme necessário.

    End Sub


    Sub CarregarFuncionarios()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("SELECT * FROM funcionarios", con)
            DA.Fill(DT)
            cbFunc.DisplayMember = "nome"
            cbFunc.ValueMember = "id_func"
            cbFunc.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub cbFunc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFunc.SelectedIndexChanged
        IniciarRel()
    End Sub

    Sub IniciarRel()
        Me.CaixaTableAdapter.Fill(Me.CaixaaDataSet.caixa, cbFunc.Text, dt.Value)
        'Me.ListadeVendasTableAdapter.Fill(Me.VendasDataSet.ListadeVendas, dt.Value, cbFunc.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dt_ValueChanged(sender As Object, e As EventArgs) Handles dt.ValueChanged
        IniciarRel()
    End Sub
End Class