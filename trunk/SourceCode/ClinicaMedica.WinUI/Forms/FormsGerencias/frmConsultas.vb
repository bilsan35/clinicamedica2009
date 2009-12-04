Public Class frmConsultas

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Dim frmCadastroConsulta As New frmCadastroConsulta
        frmCadastroConsulta.ShowDialog()
    End Sub

End Class