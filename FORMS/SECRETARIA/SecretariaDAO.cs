using conexao;
using escola;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioEnsiNo
{
    public class SecretariaDAO
    {
        //Cadastrar

        public bool cadastrar(Secretaria p_sec) //Assinatura Método 

        {
            string sql_INSERT = @"INSERT INTO secretaria(nome, idade, cpf, setor, id_funcionario, salario, genero) VALUES(?, ?, ?, ?, ?, ?, ?)";

            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                MySqlCommand sql_comando = new MySqlCommand(sql_INSERT, conexao);
                sql_comando.Parameters.AddWithValue("@nome", p_sec.getNome());
                sql_comando.Parameters.AddWithValue("@cpf", p_sec.getCpf());
                sql_comando.Parameters.AddWithValue("@genero", p_sec.getGenero());
                sql_comando.Parameters.AddWithValue("@id_funcionario", p_sec.getId());
                sql_comando.Parameters.AddWithValue("@idade", p_sec.getIdade());
                sql_comando.Parameters.AddWithValue("@salario", p_sec.getValor());
                sql_comando.Parameters.AddWithValue("@setor", p_sec.getSetor());
                sql_comando.ExecuteNonQuery();
                conexao.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!!" + ex);
                return false;
            }
        }

        //======================================================================//

        //Consultar
        public DataTable consultar() //Assinatura Método 
        {
            string sql_SELECT = "SELECT * FROM secretaria";
            DataTable dt = new DataTable();

            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();

                MySqlDataAdapter da = new MySqlDataAdapter(sql_SELECT, conexao);
                using (da)
                {
                    da.Fill(dt);
                }
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!!" + ex);
            }
            return dt;
        }

        //======================================================================//

        //Alterar
        public bool alterar(Secretaria p_sec) //Assinatura Método
        {
            string sql_UPDATE = @"UPDATE secretaria SET nome=?, idade=?, cpf=?, genero=?, id_prof=?, materia=?, salario=? WHERE id = ?";

            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                MySqlCommand sql_comando = new MySqlCommand(sql_UPDATE, conexao);
                sql_comando.Parameters.AddWithValue("@nome", p_sec.getNome());
                sql_comando.Parameters.AddWithValue("@cpf", p_sec.getCpf());
                sql_comando.Parameters.AddWithValue("@genero", p_sec.getGenero());
                sql_comando.Parameters.AddWithValue("@id_funcionario", p_sec.getId());
                sql_comando.Parameters.AddWithValue("@idade", p_sec.getIdade());
                sql_comando.Parameters.AddWithValue("@salario", p_sec.getValor());
                sql_comando.Parameters.AddWithValue("@setor", p_sec.getSetor());

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO!!" + ex);
                return false;
            }
        }

        //======================================================================//

        //DELETAR
        public bool deletar(Secretaria p_sec) //ASSINATURA DO MÉTODO
        {

            string sql_DELETE = "@DELETE FROM secretaria WHERE id_funcionario = ?";

            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                MySqlCommand sql_comando = new MySqlCommand(sql_DELETE, conexao);
                sql_comando.Parameters.AddWithValue("@id_funcionario", p_sec.getId());
                sql_comando.ExecuteNonQuery();
                conexao.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!" + ex);
                return false;
            }
        }
    }
}