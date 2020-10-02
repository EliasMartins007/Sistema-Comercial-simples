using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaComercial_Manha
{
    class clsConexao
    {
        private static MySqlConnection conexao = new MySqlConnection(
           "Persist Security Info=False;" +
           "Server=127.0.0.1;" +    //Servidor
           "Database=mydb;" + //Banco de dados
           "uid=root;"   +           //username
           "pwd=root;");           //senha

        public static Boolean AbrirConexao()
        {
            try
            {
                conexao.Open(); //Abri a conexão
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean FecharConexao()
        {
            //Verifica se a conexão esta aberta
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close(); //Fecha a conexão
                return true;
            }
            else
                return false;
        }

        public static MySqlConnection getConexao()
        {
            return conexao;
        }
    }
}
