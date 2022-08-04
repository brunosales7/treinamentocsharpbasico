using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAuteticacao.Classes
{
    internal class Conexao
    {
        public static SqlConnection _conn;

        //Propriedade Automática

        public static SqlConnection MinhaInstancia
        {

            get
            {
                //se não existe conexão.
                if (_conn == null)
                {
                    //criar a conexão com SqlServer   //nos parênteses -connection string
                    _conn = new SqlConnection(@"Server = Lab206_8\SQLEXPRESS; Database = projetoestoquev; Uid = sa; Pwd = teste*123;");
                }
                //retorna a conexão
                return _conn;

            }

        }


        /* public int numero;
         * public double PI = 34.67;
         * public int idade = 31;
         * int bolsa = 10; = variavel de valor
         * Bolsa bolsa; = variavel de referencia
         * 
         * 
         * 
         * 
         * 
         * 
        */



    }
}

