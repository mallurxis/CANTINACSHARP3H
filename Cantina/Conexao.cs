using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Cantina
{
    class Conexao
    {
        private static string conectaDB = "server=localhost;port=3306;database=dbcantina;uid=etecia;pwd=123456";
        private static MySqlConnection conn = null;

        public static MySqlConnection obterConexao()
        {
            conn = new MySqlConnection(conectaDB);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                conn = null; 
            }
            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }

        }
    }
}
