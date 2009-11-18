Namespace UTFPR

    Public Class classFornecedor

        Inherits classPessoaJuridica

        Private pID As String
        Public Property ID() As String
            Get
                Return pID
            End Get
            Set(ByVal value As String)
                pID = value
            End Set
        End Property


        Private pCodigo As String
        Public Property Codigo() As String
            Get
                Return pCodigo
            End Get
            Set(ByVal value As String)
                pCodigo = value
            End Set
        End Property

        Private pDataCriacao As String
        Public Property DataCriacao() As String
            Get
                Return pDataCriacao
            End Get
            Set(ByVal value As String)
                pDataCriacao = value
            End Set
        End Property

        Enum TipoAcao
            Inserir
            Atualizar
        End Enum

        Private Acao As TipoAcao

        Public Sub New(Optional ByVal ID As String = "")
            If ID.Length = 0 Then
                Acao = TipoAcao.Inserir
            Else
                Acao = TipoAcao.Atualizar
                pID = ID
                Recuperar()
            End If
        End Sub

        Private Sub Recuperar()
            Dim sql As String
            sql = "select * from TBFORNECEDOR where ID ='" & pID & "'"

            Dim objDR As Data.DataRow
            objDR = retornaDataSet(sql).Tables(0).Rows(0)

            With objDR
                Codigo = .Item("Codigo")
                CNPJ = .Item("CNPJ")
                Nome = .Item("Nome")
                DataCriacao = .Item("DataCriacao")
                InscricaoEstadual = .Item("InscricaoEstadual")
                RazaoSocial = .Item("RazaoSocial")
                Lougradouro = .Item("Logradouro")
                Numero = .Item("Numero")
                Bairro = .Item("Bairro")
                Cidade = .Item("Cidade")
                CEP = .Item("CEP")
                Estado = .Item("Estado")
                Telefone = .Item("Telefone")
            End With
        End Sub

        Public Function Delete() As Boolean

            Dim sql As String
            sql = "delete * from TBFORNECEDOR where ID = '" & pID & "'"

            If ExecuteSQL(sql) = 1 Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Function save() As Boolean
            Dim sql As String

            If Acao = TipoAcao.Inserir Then
                sql = "insert into TBFORNECEDOR(CODIGO,CNPJ,NOME,DATACRIACAO,INSCRICAOESTADUAL,RAZAOSOCIAL,LOGRADOURO,NUMERO,BAIRRO,CIDADE,CEP,ESTADO,TELEFONE) values('" & Codigo & "','" & CNPJ & "','" & Nome & "','" & DataCriacao & "','" & InscricaoEstadual & "','" & RazaoSocial & "','" & Lougradouro & "','" & Numero & "','" & Bairro & "','" & Cidade & "','" & CEP & "','" & Estado & "','" & Telefone & "')"
            Else
                sql = "update TBFORNECEDOR set Codigo ='" & Codigo & _
                    "',CNPJ ='" & CNPJ & _
                    "',Nome ='" & Nome & _
                    "',DataCriacao ='" & DataCriacao & _
                    "',InscricaoEstadual ='" & InscricaoEstadual & _
                    "',RazaoSocial ='" & RazaoSocial & _
                    "',Logradouro ='" & Lougradouro & _
                    "',Numero ='" & Numero & _
                    "',Bairro ='" & Bairro & _
                    "',Cidade ='" & Cidade & _
                    "',CEP ='" & CEP & _
                    "',Estado ='" & Estado & _
                    "',Telefone ='" & Telefone & _
                    "'where ID = '" & ID & "'"
            End If
            If ExecuteSQL(sql) = 1 Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class

End Namespace
