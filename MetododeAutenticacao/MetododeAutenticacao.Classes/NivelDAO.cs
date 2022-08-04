using ModuloAuteticacao.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetododeAutenticacao.Classes
{
    public class NivelDAO
    {
        public string Inserir(string nome)
        {//abrindo a conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Definindo  DML
            comando.CommandText = "INSERT INTO Nivel(Nome)Values(@Nome)";
            //Adicionando parâmetros contra SQL Injection
            comando.Parameters.Add(new SqlParameter("@Nome", nome));
            //Esta tudo pronto! Vamos executar o comando
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();



           
            return "Dados inseridos com sucesso!";

        }

        public string Atualizar()
        {
            return "você vai atualizaar";

        }
        public DataTable Pesquisar()
        {
            //Abrra a conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Definindo DQL - pesquisa
            comando.CommandText = "select * from Nivel";

            //DataTable (tabela na memória)
            DataTable dataTable = new DataTable();
            //Executa o SQL
            SqlDataReader reader = comando.ExecuteReader();//Comando usado para pesquisar
            //Carrega a tabela DataTable

            dataTable.Load(reader);//carregar pesquisa
            //Fecha conexão
            Conexao.MinhaInstancia.Close();
            //Retorna os dados da tabela.
            return dataTable;
        }

        public DataTable PesquisarPorNome(string nome)
        {
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("SELECT * from Nivel where Nome=@Nome;");
            comando.Parameters.AddWithValue("@Nome", nome);
            DataTable dataTable = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();

            return dataTable;

        }








        public string Deletar(string id)
        {
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("delete Nivel where codigo=@id");//DELETE FROM Nivel WHERE Codigo=5;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "";



        }







    }
}
