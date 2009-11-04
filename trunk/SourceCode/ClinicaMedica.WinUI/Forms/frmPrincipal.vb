Public Class frmPrincipal

    Private Sub btnMedicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedicos.Click

        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmMedicos).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        Dim frmMedicos As New frmMedicos

        frmMedicos.MdiParent = Me
        frmMedicos.Show()

    End Sub

    Private Sub btnPacientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPacientes.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmPacientes).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        Dim frmPacientes As New frmPacientes

        frmPacientes.MdiParent = Me
        frmPacientes.Show()
    End Sub

    Private Sub btnAtendentes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtendentes.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmAtendentes).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        Dim frmAtendentes As New frmAtendentes

        frmAtendentes.MdiParent = Me
        frmAtendentes.Show()
    End Sub

    Private Sub btnAgenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgenda.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmAgenda).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        Dim frmAgenda As New frmAgenda

        frmAgenda.MdiParent = Me
        frmAgenda.Show()
    End Sub

    Private Sub btnFornecedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFornecedores.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmFornecedores).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        Dim frmFornecedores As New frmFornecedores

        frmFornecedores.MdiParent = Me
        frmFornecedores.Show()
    End Sub
End Class
