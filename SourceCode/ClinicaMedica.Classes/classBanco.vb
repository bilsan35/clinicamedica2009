Namespace UTFPR

    Public Class classBanco

        'Variavel utilizada para armazenar as configura��es de conexao com o banco de dados
        Dim connectionString As String = "Data Source=TIAGUINHO\SQLEXPRESS;Initial Catalog=BASE;Integrated Security=True"

        'funcao que retorna um conjunto de registros de acordo com a instrucao sql enviada
        Public Function retornaDataSet(ByVal SQLComando As String) As System.Data.DataSet

            'objeto de conexao que l� as configura��es de conex�o
            Dim dbConnection As System.Data.IDbConnection = New System.Data.SqlClient.SqlConnection(connectionString)

            'objeto que armazena o comando a ser executado na fonte de dados          
            Dim dbCommand As System.Data.IDbCommand = New System.Data.SqlClient.SqlCommand
            dbCommand.CommandText = SQLComando 'recebe o comando
            dbCommand.Connection = dbConnection 'recebe a conexao

            'objeto que ir� adapatar o conjunto de dados
            Dim dataAdapter As System.Data.IDbDataAdapter = New System.Data.SqlClient.SqlDataAdapter
            'recebendo o conjunto de dados
            dataAdapter.SelectCommand = dbCommand
            'objeto que ir� armazenar os dados recebidos
            Dim dataSet As System.Data.DataSet = New System.Data.DataSet
            'o dataAdapter preenche o objeto com os dados recebidos
            dataAdapter.Fill(dataSet)

            'retorna os dados recebidos
            Return dataSet

        End Function

        'FUN��O QUE EXECUTA UM �NICO COMANDO SQL
        'INSERT, DELETE, UPDATE
        Public Function ExecuteSQL(ByVal SQLComando As String) As Integer

            'objeto de conexao que l� as configura��es de conex�o
            Dim dbConnection As System.Data.IDbConnection = New System.Data.SqlClient.SqlConnection(connectionString)

            'objeto que armazena o comando a ser executado na fonte de dados
            Dim dbCommand As System.Data.IDbCommand = New System.Data.SqlClient.SqlCommand

            'variavel que receber� o retorno do banco de dados
            Dim rowsAffected As Integer = 0

            'abrindo a conexao
            dbConnection.Open()

            'recebendo o comando
            dbCommand.CommandText = SQLComando
            'recebendo a conexao
            dbCommand.Connection = dbConnection

            Try
                'executando o comando sql e armazenando o resultado de retorno
                rowsAffected = dbCommand.ExecuteNonQuery
            Finally
                'fechando a conex�o
                dbConnection.Close()
            End Try

            'devolve o n�mero de registros afetados pelo comando sql
            Return rowsAffected

        End Function

    End Class

End Namespace
