Imports ClinicaMedica.Classes.UTFPR

Public Class frmLogin

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        End
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim banco As New classBanco
        Dim ds = banco.retornaDataSet("select * from tbusuario where login = '" & txtLogin.Text & "' and senha = '" & txtSenha.Text & "'")
        If ds.Tables(0).Rows.Count = 0 Then
            MessageBox.Show("Login ou Senha Inválido!")
            Return
        End If
        '' preencher objeto do formPrincipal
        frmPrincipal.Usuario = ds.Tables(0).Rows(0)("LOGIN")
        Close()
    End Sub
End Class