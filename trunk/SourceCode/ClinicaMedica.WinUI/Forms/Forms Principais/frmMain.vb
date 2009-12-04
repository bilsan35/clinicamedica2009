Public Class frmMain

    Public Shared frmMedicos As frmMedicos
    Public Shared frmPacientes As frmPacientes
    Public Shared frmSecretarias As frmSecretarias
    Public Shared frmFornecedores As frmFornecedores
    Public Shared frmConsultas As frmConsultas
    Public Shared frmConvenios As frmConvenios
    Public Shared frmCirurgias As frmCirurgias
    Public Shared frmLeitos As frmLeitos
    Public Shared frmMateriais As frmMateriais
    Public Shared frmUsuarios As frmUsuarios

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim frmLogin As New frmLogin
        frmLogin.ShowDialog()
        'bloquear()
    End Sub

    Private Sub btnMedicos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedicos.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmMedicos).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmMedicos = New frmMedicos

        frmMedicos.MdiParent = Me
        frmMedicos.Dock = DockStyle.Fill
        frmMedicos.Show()
    End Sub

    Private Sub btnPacientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPacientes.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmPacientes).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmPacientes = New frmPacientes

        frmPacientes.MdiParent = Me
        frmPacientes.Dock = DockStyle.Fill
        frmPacientes.Show()
    End Sub

    Private Sub btnSecretarias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSecretarias.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmSecretarias).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmSecretarias = New frmSecretarias

        frmSecretarias.MdiParent = Me
        frmSecretarias.Dock = DockStyle.Fill
        frmSecretarias.Show()
    End Sub

    Private Sub btnFornecedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFornecedores.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmFornecedores).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmFornecedores = New frmFornecedores

        frmFornecedores.MdiParent = Me
        frmFornecedores.Dock = DockStyle.Fill
        frmFornecedores.Show()
    End Sub

    Private Sub btnConsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultas.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmConsultas).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmConsultas = New frmConsultas

        frmConsultas.MdiParent = Me
        frmConsultas.Dock = DockStyle.Fill
        frmConsultas.Show()
    End Sub

    Private Sub btnCirurgias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCirurgias.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmCirurgias).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmCirurgias = New frmCirurgias

        frmCirurgias.MdiParent = Me
        frmCirurgias.Dock = DockStyle.Fill
        frmCirurgias.Show()
    End Sub

    Private Sub btnConvenios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvenios.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmConvenios).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmConvenios = New frmConvenios

        frmConvenios.MdiParent = Me
        frmConvenios.Dock = DockStyle.Fill
        frmConvenios.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub PacientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacientesToolStripMenuItem.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmPacientes).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmPacientes = New frmPacientes

        frmPacientes.MdiParent = Me
        frmPacientes.Dock = DockStyle.Fill
        frmPacientes.Show()
    End Sub

    Private Sub MédicosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MédicosToolStripMenuItem.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmMedicos).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmMedicos = New frmMedicos

        frmMedicos.MdiParent = Me
        frmMedicos.Dock = DockStyle.Fill
        frmMedicos.Show()
    End Sub

    Private Sub SecretáriasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecretáriasToolStripMenuItem.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmSecretarias).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmSecretarias = New frmSecretarias

        frmSecretarias.MdiParent = Me
        frmSecretarias.Dock = DockStyle.Fill
        frmSecretarias.Show()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FornecedoresToolStripMenuItem.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmFornecedores).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmFornecedores = New frmFornecedores

        frmFornecedores.MdiParent = Me
        frmFornecedores.Dock = DockStyle.Fill
        frmFornecedores.Show()
    End Sub

    Private Sub ConvêniosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConvêniosToolStripMenuItem.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmConvenios).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmConvenios = New frmConvenios

        frmConvenios.MdiParent = Me
        frmConvenios.Dock = DockStyle.Fill
        frmConvenios.Show()
    End Sub

    Private Sub ConsultasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultasToolStripMenuItem.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmConsultas).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmConsultas = New frmConsultas

        frmConsultas.MdiParent = Me
        frmConsultas.Dock = DockStyle.Fill
        frmConsultas.Show()
    End Sub

    Private Sub CirurgiasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CirurgiasToolStripMenuItem.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmCirurgias).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmCirurgias = New frmCirurgias

        frmCirurgias.MdiParent = Me
        frmCirurgias.Dock = DockStyle.Fill
        frmCirurgias.Show()
    End Sub

    Private Sub LeitosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeitosToolStripMenuItem.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmLeitos).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmLeitos = New frmLeitos

        frmLeitos.MdiParent = Me
        frmLeitos.Dock = DockStyle.Fill
        frmLeitos.Show()
    End Sub

    Private Sub MateriaisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MateriaisToolStripMenuItem.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmMateriais).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmMateriais = New frmMateriais

        frmMateriais.MdiParent = Me
        frmMateriais.Dock = DockStyle.Fill
        frmMateriais.Show()
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuáriosToolStripMenuItem.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmUsuarios).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmUsuarios = New frmUsuarios

        frmUsuarios.MdiParent = Me
        frmUsuarios.Dock = DockStyle.Fill
        frmUsuarios.Show()
    End Sub
End Class