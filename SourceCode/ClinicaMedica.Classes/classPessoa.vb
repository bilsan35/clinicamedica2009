Namespace UTFPR

    Public Class classPessoa

        Inherits UTFPR.classBanco
        'Private Nome As String
        'Private Logradouro As String
        'Private Numero As Integer
        'Private Bairro As String
        'Private Cidade As String
        'Private CEP As String
        'Private Estado As String
        'Private Telefone As String
        'Private DataCadastro as String
        'Private Situacao As String (Ativo, Inativo, Suspenso)

        Private pNome As String
        Public Property Nome() As String
            Get
                Return pNome
            End Get
            Set(ByVal value As String)
                pNome = value
            End Set
        End Property

        Private pLogradouro As String
        Public Property Lougradouro() As String
            Get
                Return pLogradouro
            End Get
            Set(ByVal value As String)
                pLogradouro = value
            End Set
        End Property

        Private pNumero As Integer
        Public Property Numero() As Integer
            Get
                Return pNumero
            End Get
            Set(ByVal value As Integer)
                pNumero = value
            End Set
        End Property

        Private pBairro As String
        Public Property Bairro() As String
            Get
                Return pBairro
            End Get
            Set(ByVal value As String)
                pBairro = value
            End Set
        End Property

        Private pCidade As String
        Public Property Cidade() As String
            Get
                Return pCidade
            End Get
            Set(ByVal value As String)
                pCidade = value
            End Set
        End Property

        Private pCEP As String
        Public Property CEP() As String
            Get
                Return pCEP
            End Get
            Set(ByVal value As String)
                pCEP = value
            End Set
        End Property

        Private pEstado As String
        Public Property Estado() As String
            Get
                Return pEstado
            End Get
            Set(ByVal value As String)
                pEstado = value
            End Set
        End Property

        Private pTelefone As String
        Public Property Telefone() As String
            Get
                Return pTelefone
            End Get
            Set(ByVal value As String)
                pTelefone = value
            End Set
        End Property

        Private pDataCadastro As String
        Public Property DataCadastro() As String
            Get
                Return pDataCadastro
            End Get
            Set(ByVal value As String)
                pDataCadastro = value
            End Set
        End Property

        Private pSituacao As String
        Public Property Situacao() As String
            Get
                Return pSituacao
            End Get
            Set(ByVal value As String)
                pSituacao = value
            End Set
        End Property

    End Class

End Namespace
