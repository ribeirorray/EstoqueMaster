Public Class frmRelProdutos
    Private Sub frmRelProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ProdutosDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.
        Me.produtosTableAdapter.Fill(Me.ProdutosDataSet.produtos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class