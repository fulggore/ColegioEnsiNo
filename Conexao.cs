using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace conexao
{
    public class Conexao
    {
        //atributos
        private MySqlConnection conexao;

        private static string servidor = "localhost";
        private static string usuario = "root";
        private static string banco = "escola";
        private static string senha = "";

        //métodos
        public static MySqlConnection conectar() 
        {
            
            return new MySqlConnection("server = " + servidor + "; User Id = " + usuario + 
                                                          "; database = " + banco + "; password = " + senha + "");
        }

    }
}
