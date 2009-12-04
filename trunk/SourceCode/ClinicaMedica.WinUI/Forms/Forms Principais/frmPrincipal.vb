Imports ClinicaMedica.Classes
Imports ClinicaMedica.Classes.UTFPR

Public Class frmPrincipal

    Public Shared frmMedicos As frmMedicos
    Public Shared frmPacientes As frmPacientes
    Public Shared frmSecretarias As frmSecretarias
    Public Shared frmFornecedores As frmFornecedores
    Public Shared frmConvenios As frmConvenios

    Private Shared _usuario As classUsuario
    Public Shared Property Usuario() As classUsuario
        Get
            Return _usuario
        End Get
        Set(ByVal value As classUsuario)
            _usuario = value
        End Set
    End Property

    Public Sub bloquear()
        'btnSecretarias.Enabled = _usuario.Tipo <> 2
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

    Private Sub btnFornecedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFornecedores.Click
        'If Usuario.ToUpper() <> "TIAGO" Then
        '    Return
        'End If
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

    Private Sub btnConvenios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvenios.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmConvenios).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmConvenios = New frmConvenios

        frmConvenios.MdiParent = Me
        frmConvenios.Show()
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
        frmCirurgias.Show()
    End Sub

    Private Sub btnLeitos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMateriais.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmMateriais).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmMateriais = New frmMateriais

        frmMateriais.MdiParent = Me
        frmMateriais.Show()
    End Sub

    Private Sub btnLeitos_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeitos.Click
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmLeitos).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmLeitos = New frmLeitos

        frmLeitos.MdiParent = Me
        frmLeitos.Show()
    End Sub

    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim frmLogin As New frmLogin
        frmLogin.ShowDialog()
        bloquear()
    End Sub

    Private Sub btnUsuarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmUsuarios).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        Dim frmUsuarios = New frmUsuarios

        frmUsuarios.MdiParent = Me
        frmUsuarios.Show()
    End Sub

    Private Sub btnEnfermeiras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSecretárias.Click
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

    Private Sub btnSecretarias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each frm As Form In My.Application.OpenForms
            If frm.GetType().FullName = GetType(frmSecretarias).FullName Then
                frm.BringToFront()
                Return
            End If
        Next
        frmSecretarias = New frmSecretarias

        frmSecretarias.MdiParent = Me
        frmSecretarias.Show()
    End Sub
End Class


