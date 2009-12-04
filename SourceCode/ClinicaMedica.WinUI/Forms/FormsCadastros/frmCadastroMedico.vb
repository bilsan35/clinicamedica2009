Imports ClinicaMedica.Classes

Public Class frmCadastroMedico

    'Private pID As Integer

    'Private Sub LimparFormulario()

    '    txtNome.Text = ""
    '    txtRG.Text = ""
    '    txtCPF.Text = ""
    '    txtDataNascimento.Text = ""
    '    cboEstadoCivil.SelectedIndex = 0
    '    rdoMasculino.Checked = True
    '    txtCRM.Text = ""
    '    txtEmail.Text = ""
    '    txtLogradouro.Text = ""
    '    txtNumero.Text = ""
    '    txtBairro.Text = ""
    '    txtCidade.Text = ""
    '    txtCEP.Text = ""
    '    cboEstado.SelectedIndex = 0
    '    txtTelefone.Text = ""

    'End Sub

    'Public Sub CarregaObjeto(ByVal ID As String)

    '    Dim objMedico As New UTFPR.classMedico(Convert.ToInt32(ID))
    '    With objMedico
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
    '        txtCRM.Text = .CRM
    '        txtEmail.Text = .Email
    '        txtLogradouro.Text = .Lougradouro
    '        txtNumero.Text = .Numero
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
            'pID = ID
            'CarregaObjeto(ID)
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If pID = 0 Then
    '        LimparFormulario()
    '    End If
    '    CarregaObjeto(pID)
    'End Sub

    'Private Sub btnCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try

    '        Dim objMedico As UTFPR.classMedico

    '        If pID = 0 Then
    '            objMedico = New UTFPR.classMedico
    '        Else
    '            objMedico = New UTFPR.classMedico(pID)
    '        End If
    '        With objMedico
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
    '            .CRM = txtCRM.Text
    '            .Email = txtEmail.Text
    '            .Lougradouro = txtLogradouro.Text
    '            .Numero = txtNumero.Text
    '            .Bairro = txtBairro.Text
    '            .Cidade = txtCidade.Text
    '            .CEP = txtCEP.Text
    '            .Estado = cboEstado.SelectedItem
    '            .Telefone = txtTelefone.Text

    '        End With

    '        If objMedico.save = True Then
    '            MessageBox.Show("Salvo com Sucesso!")
    '            LimparFormulario()
    '        Else
    '            MessageBox.Show("Salvo sem Sucesso!")
    '        End If
    '        If (IsNothing(frmPrincipal.frmMedicos) OrElse frmPrincipal.frmMedicos.IsDisposed) Then
    '            Return
    '        End If
    '        frmPrincipal.frmMedicos.AtualizarGrid()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btnFechar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Hide()
    End Sub
End Class