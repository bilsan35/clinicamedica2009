Public Class frmCadastroConsulta

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim frmCadastroPacientes As New frmCadastroPacientes
        frmCadastroPacientes.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim frmCadastroMedico As New frmCadastroMedico
        frmCadastroMedico.ShowDialog()
    End Sub

    Private Sub LinkLabel3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim frmCadastroConvenio As New frmCadastroConvenio
        frmCadastroConvenio.ShowDialog()
    End Sub
End Class