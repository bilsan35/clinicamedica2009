﻿Imports ClinicaMedica.Classes

Public Class frmCadastroSecretaria


    Private pID As Integer

    'Private Sub LimparFormulario()

    '    txtNome.Text = ""
    '    txtRG.Text = ""
    '    txtCPF.Text = ""
    '    txtDataNascimento.Text = ""
    '    cboEstadoCivil.SelectedIndex = 0
    '    rdoMasculino.Checked = True
    '    txtCelular.Text = ""
    '    txtEmail.Text = ""
    '    txtLogradouro.Text = ""
    '    txtNumero.Text = ""
    '    txtComplemento.Text = ""
    '    txtBairro.Text = ""
    '    txtCidade.Text = ""
    '    txtCEP.Text = ""
    '    cboEstado.SelectedIndex = 0
    '    txtTelefone.Text = ""

    'End Sub

    'Public Sub CarregaObjeto(ByVal ID As String)

    '    Dim objSecretaria As New UTFPR.classSecretaria(Convert.ToInt32(ID))
    '    With objSecretaria
    '        txtNome.Text = .Nome
    '        txtRG.Text = .RG
    '        txtCPF.Text = .CPF
    '        txtDataNascimento.Text = .DataNascimento
    '        cboEstadoCivil.SelectedItem = .Estado
    '        If .Sexo = "M" Then
    '            rdoMasculino.Checked = True
    '        Else
    '            rdoFeminino.Checked = True
    '        End If
    '        txtCelular.Text = .Celular
    '        txtEmail.Text = .Email
    '        txtLogradouro.Text = .Lougradouro
    '        txtNumero.Text = .Numero
    '        txtComplemento.Text = .Complemento
    '        txtBairro.Text = .Bairro
    '        txtCidade.Text = .Cidade
    '        txtCEP.Text = .CEP
    '        cboEstado.SelectedItem = .Estado
    '        txtTelefone.Text = .Telefone

    '    End With
    'End Sub

    Public Sub New(Optional ByVal ID As Integer = 0)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        cboEstado.SelectedIndex = 0
        cboEstadoCivil.SelectedIndex = 0

        If ID > 0 Then
            pID = ID
            'CarregaObjeto(ID)
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If pID = 0 Then
            'LimparFormulario()
        End If
        'CarregaObjeto(pID)
    End Sub

    'Private Sub btnCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try

    '        Dim objSecretaria As UTFPR.classSecretaria

    '        If pID = 0 Then
    '            objSecretaria = New UTFPR.classSecretaria
    '        Else
    '            objSecretaria = New UTFPR.classSecretaria(pID)
    '        End If
    '        With objSecretaria
    '            .Nome = txtNome.Text
    '            .RG = txtRG.Text
    '            .CPF = txtCPF.Text
    '            .DataNascimento = txtDataNascimento.Text
    '            .EstadoCivil = cboEstadoCivil.SelectedItem
    '            If rdoMasculino.Checked = True Then
    '                .Sexo = "M"
    '            ElseIf rdoFeminino.Checked = True Then
    '                .Sexo = "F"
    '            End If
    '            .Celular = txtCelular.Text
    '            .Email = txtEmail.Text
    '            .Lougradouro = txtLogradouro.Text
    '            .Numero = txtNumero.Text
    '            .Complemento = txtComplemento.Text
    '            .Bairro = txtBairro.Text
    '            .Cidade = txtCidade.Text
    '            .CEP = txtCEP.Text
    '            .Estado = cboEstado.SelectedItem
    '            .Telefone = txtTelefone.Text

    '        End With

    '        If objSecretaria.save = True Then
    '            MessageBox.Show("Salvo com Sucesso!")
    '            LimparFormulario()
    '        Else
    '            MessageBox.Show("Salvo sem Sucesso!")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnFechar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub
End Class