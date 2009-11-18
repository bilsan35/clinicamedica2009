Namespace UTFPR

    Public Class classPessoaFisica

        Inherits UTFPR.classPessoa

        'Private Celular As String
        'Private DataNascimento As String
        'Private CPF As String
        'Private RG As String
        'Private Sexo As String
        'Private EstadoCivil As String
        'Private Email As String
        'Private CNH As String
        'Private DataValidadeCNH As String
        'Private ContaBancaria As String
        'Private Agencia As String
        'Private CC As String

        Private pCelular As String
        Public Property Celular() As String
            Get
                Return pCelular
            End Get
            Set(ByVal value As String)
                pCelular = value
            End Set
        End Property

        Private pDataNascimento As String
        Public Property DataNascimento() As String
            Get
                Return pDataNascimento
            End Get
            Set(ByVal value As String)
                pDataNascimento = value
            End Set
        End Property

        Private pCPF As String
        Public Property CPF() As String
            Get
                Return pCPF
            End Get
            Set(ByVal value As String)
                pCPF = value
            End Set
        End Property

        Private pRG As String
        Public Property RG() As String
            Get
                Return pRG
            End Get
            Set(ByVal value As String)
                pRG = value
            End Set
        End Property

        Private pSexo As String
        Public Property Sexo() As String
            Get
                Return pSexo
            End Get
            Set(ByVal value As String)
                pSexo = value
            End Set
        End Property

        Private pEstadoCivil As String
        Public Property EstadoCivil() As String
            Get
                Return pEstadoCivil
            End Get
            Set(ByVal value As String)
                pEstadoCivil = value
            End Set
        End Property

        Private pEmail As String
        Public Property Email() As String
            Get
                Return pEmail
            End Get
            Set(ByVal value As String)
                pEmail = value
            End Set
        End Property

        Private pCNH As String
        Public Property CNH() As String
            Get
                Return pCNH
            End Get
            Set(ByVal value As String)
                pCNH = value
            End Set
        End Property

        Private pDataValidadeCNH As String
        Public Property DataValidadeCNH() As String
            Get
                Return pDataValidadeCNH
            End Get
            Set(ByVal value As String)
                pDataValidadeCNH = value
            End Set
        End Property

        Private pContaBancaria As String
        Public Property ContaBancaria() As String
            Get
                Return pContaBancaria
            End Get
            Set(ByVal value As String)
                pContaBancaria = value
            End Set
        End Property

        Private pAgencia As String
        Public Property Agencia() As String
            Get
                Return pAgencia
            End Get
            Set(ByVal value As String)
                pAgencia = value
            End Set
        End Property

        Private pCC As String
        Public Property CC() As String
            Get
                Return pCC
            End Get
            Set(ByVal value As String)
                pCC = value
            End Set
        End Property

    End Class

End Namespace
