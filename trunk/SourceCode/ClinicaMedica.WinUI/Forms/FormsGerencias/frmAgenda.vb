Public Class frmAgenda

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub

    'Private Sub btnCalendario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalendario.Click
    '    For Each frm As Form In My.Application.OpenForms
    '        If frm.GetType().FullName = GetType(frmCalendario).FullName Then
    '            frm.BringToFront()
    '            Return
    '        End If
    '    Next
    '    Dim frmCalendario As New frmCalendario

    '    frmCalendario.MdiParent = frmAgenda
    '    frmCalendario.ShowDialog()
    'End Sub
End Class