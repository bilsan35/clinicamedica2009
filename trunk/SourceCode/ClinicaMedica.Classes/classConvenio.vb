Namespace UTFPR

    Public Class classConvenio

        Inherits UTFPR.classPessoaFisica

        Private pID As Integer
        Public Property ID() As Integer
            Get
                Return pID
            End Get
            Set(ByVal value As Integer)
                pID = value
            End Set
        End Property

        Private pRegistro As String
        Public Property Registro() As String
            Get
                Return pRegistro
            End Get
            Set(ByVal value As String)
                pRegistro = value
            End Set
        End Property

        Private pValidade As Date
        Public Property Validade() As Date
            Get
                Return pValidade
            End Get
            Set(ByVal value As Date)
                pValidade = value
            End Set
        End Property

        Private pValor As String
        Public Property Valor() As String
            Get
                Return pValor
            End Get
            Set(ByVal value As String)
                pValor = value
            End Set
        End Property

        Private pDataInclusao As DateTime
        Public Property DataInclusao() As DateTime
            Get
                Return pDataInclusao
            End Get
            Set(ByVal value As DateTime)
                pDataInclusao = value
            End Set
        End Property

        Private pPlano As String
        Public Property Plano() As String
            Get
                Return pPlano
            End Get
            Set(ByVal value As String)
                pPlano = value
            End Set
        End Property

        Private pWebsite As String
        Public Property Website() As String
            Get
                Return pWebsite
            End Get
            Set(ByVal value As String)
                pWebsite = value
            End Set
        End Property

        Private pComplemento As String
        Public Property Complemento() As String
            Get
                Return pComplemento
            End Get
            Set(ByVal value As String)
                pComplemento = value
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
            sql = "select * from TBCONVENIO where ID ='" & pID & "'"

            Dim objDR As Data.DataRow
            objDR = retornaDataSet(sql).Tables(0).Rows(0)

            With objDR
                Nome = .Item("Nome")
                Registro = .Item("Registro")
                Validade = .Item("Validade")
                Valor = .Item("Valor")
                DataInclusao = .Item("DataInclusao")
                Plano = .Item("Plano")
                Website = .Item("Website")
                Lougradouro = .Item("Logradouro")
                Numero = .Item("Numero")
                Complemento = .Item("Complemento")
                Bairro = .Item("Bairro")
                Cidade = .Item("Cidade")
                CEP = .Item("CEP")
                Estado = .Item("Estado")
                Telefone = .Item("Telefone")
            End With
        End Sub

        Public Function Delete() As Boolean

            Dim sql As String
            sql = "delete * from TBCONVENIO where ID = '" & pID & "'"

            If ExecuteSQL(sql) = 1 Then
                Return True
            Else
                Return False
            End If

        End Function

        Public Function save() As Boolean
            Dim sql As String

            If Acao = TipoAcao.Inserir Then
                sql = "insert into TBCONVENIO(NOME,REGISTRO,VALIDADE,VALOR,DATAINCLUSAO,PLANO,WEBSITE,LOGRADOURO,NUMERO,COMPLEMENTO,BAIRRO,CIDADE,CEP,ESTADO,TELEFONE) values('" & Nome & "','" & Registro & "','" & Validade & "','" & Valor & "','" & DataInclusao & "','" & Plano & "','" & Website & "','" & Lougradouro & "','" & Numero & "','" & Complemento & "','" & Bairro & "','" & Cidade & "','" & CEP & "','" & Estado & "','" & Telefone & "')"
            Else
                sql = "update TBCONVENIO set Nome ='" & Nome & _
                    "',Registro ='" & Registro & _
                    "',Validade ='" & Validade & _
                    "',Valor ='" & Valor & _
                    "',DataInclusao ='" & DataInclusao & _
                    "',Plano ='" & Plano & _
                    "',Website ='" & Website & _
                    "',Logradouro ='" & Lougradouro & _
                    "',Numero ='" & Numero & _
                    "',Complemento ='" & Complemento & _
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
