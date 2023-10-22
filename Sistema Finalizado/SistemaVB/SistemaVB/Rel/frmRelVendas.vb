Imports System.Data.SqlClient

Public Class frmRelVendas
    Private Sub frmRelVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        rel()
        dtData.Value = Now.Date()
        CarregarFuncionarios()
    End Sub
    Private Sub dtData_ValueChanged(sender As Object, e As EventArgs) Handles dtData.ValueChanged

        rel()
    End Sub

    Private Sub rel()

        Me.ListaDeVendasTableAdapter.Fill(Me.VendasDataSet.ListaDeVendas, dtData.Text, cbFuncionario.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Sub CarregarFuncionarios()
        Dim DT As New DataTable
        Dim DA As SqlDataAdapter
        Try
            abrir()
            DA = New SqlDataAdapter("SELECT * FROM funcionarios", con)
            DA.Fill(DT)
            cbFuncionario.DisplayMember = "nome"
            cbFuncionario.ValueMember = "id_func"
            cbFuncionario.DataSource = DT
        Catch ex As Exception : MessageBox.Show(ex.Message)
        End Try
        fechar()
    End Sub

    Private Sub cbFuncionario_TextChanged(sender As Object, e As EventArgs) Handles cbFuncionario.SelectedIndexChanged


        rel()
    End Sub
End Class