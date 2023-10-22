Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmRelEstoque
    Private Sub frmRelEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'estoquesDataSet.BuscarEntradasSaidas'. Você pode movê-la ou removê-la conforme necessário.

        'TODO: esta linha de código carrega dados na tabela 'ProdutosDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.

        'TODO: esta linha de código carrega dados na tabela 'ProdutosDataSet.produtos'. Você pode movê-la ou removê-la conforme necessário.

        dtDataInicio.Value = Now.ToShortDateString
        dtDataFinal.Value = Now.ToShortDateString

        rbEntrada.Checked = True
        cbEntrada.Visible = True
        cbEntrada.Text = "Entrada"

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
        Me.ReportViewer2.RefreshReport()
    End Sub


    Private Sub dtDataInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtDataInicio.ValueChanged
        buscarPorData()
        If rbEntrada.Checked = True Then
            ChamarRelEntradaSaida()
        End If
    End Sub


    Sub buscarPorData()
        Me.EstoquePorDataTableAdapter.Fill(Me.estoquesDataSet.EstoquePorData, dtDataInicio.Text, dtDataFinal.Text)
        Me.BuscarEntradasTableAdapter.Fill(Me.estoquesDataSet.BuscarEntradas, dtDataInicio.Text, dtDataFinal.Text)
        Me.BuscarSaidasTableAdapter.Fill(Me.estoquesDataSet.BuscarSaidas, dtDataInicio.Text, dtDataFinal.Text)

        'Parametros vindos do relatório
        Dim parametro(1) As ReportParameter
        parametro(0) = New ReportParameter("data_inicial", dtDataInicio.Value)

        parametro(1) = New ReportParameter("data_final", dtDataFinal.Value)

        Me.ReportViewer1.LocalReport.SetParameters(parametro)


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub dtDataFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtDataFinal.ValueChanged
        buscarPorData()

        If rbEntrada.Checked = True Then
            ChamarRelEntradaSaida()
        End If

    End Sub

    Private Sub rbEntrada_CheckedChanged(sender As Object, e As EventArgs) Handles rbEntrada.CheckedChanged

        cbEntrada.Text = ""
        cbEntrada.Visible = True
        ReportViewer1.Visible = False
        ReportViewer2.Visible = True

    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged

        ReportViewer1.Visible = True
        ReportViewer2.Visible = False

        cbEntrada.Text = ""
        cbEntrada.Visible = False

        lblDataFinal.Visible = True
        lblDataInicio.Visible = True
        dtDataInicio.Visible = True
        dtDataFinal.Visible = True
    End Sub


    Private Sub cbEntrada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEntrada.SelectedIndexChanged

        ChamarRelEntradaSaida()

    End Sub


    Sub ChamarRelEntradaSaida()

        Dim descricao As String
        If cbEntrada.Text = "Entrada" Then
            descricao = "Entradas"
        Else
            descricao = "Saídas"
        End If

        Me.BuscarEntradasSaidasTableAdapter.Fill(Me.estoquesDataSet.BuscarEntradasSaidas, cbEntrada.Text, dtDataInicio.Text, dtDataFinal.Text)

        'Parametros vindos do relatório
        Dim parametro(2) As ReportParameter
        parametro(0) = New ReportParameter("data_inicial", dtDataInicio.Value)

        parametro(1) = New ReportParameter("data_final", dtDataFinal.Value)

        parametro(2) = New ReportParameter("descricao", descricao)

        Me.ReportViewer2.LocalReport.SetParameters(parametro)


        Me.ReportViewer2.RefreshReport()
    End Sub

End Class