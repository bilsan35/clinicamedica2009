Public Class frmCirurgias

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Dim frmCadastroCirurgia As New frmCadastroCirurgia
        frmCadastroCirurgia.ShowDialog()
    End Sub
End Class