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
    public class ProfessorDAO
    {
        //Cadastrar

        public bool cadastrar(Professor p_prof) //Assinatura Método 

        {
            string sql_INSERT = @"INSERT INTO professor(nome, idade, cpf, id_prof, materia, salario, genero) VALUES(?, ?, ?, ?, ?, ?, ?)";

            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                MySqlCommand sql_comando = new MySqlCommand(sql_INSERT, conexao);
                sql_comando.Parameters.AddWithValue("@nome", p_prof.getNome());
                sql_comando.Parameters.AddWithValue("@cpf", p_prof.getCpf());
                sql_comando.Parameters.AddWithValue("@genero", p_prof.getGenero());
                sql_comando.Parameters.AddWithValue("@id_prof", p_prof.getId());
                sql_comando.Parameters.AddWithValue("@idade", p_prof.getIdade());
                sql_comando.Parameters.AddWithValue("@salario", p_prof.getValor());
                sql_comando.Parameters.AddWithValue("@materia", p_prof.getMateria());
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
            string sql_SELECT = "SELECT * FROM professor";
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
        public bool alterar(Professor p_prof) //Assinatura Método
        {
            string sql_UPDATE = @"UPDATE professor SET nome=?, idade=?, cpf=?, genero=?, id_prof=?, materia=?, salario=? WHERE id = ?";

            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                MySqlCommand sql_comando = new MySqlCommand(sql_UPDATE, conexao);
                sql_comando.Parameters.AddWithValue("@nome", p_prof.getNome());
                sql_comando.Parameters.AddWithValue("@cpf", p_prof.getCpf());
                sql_comando.Parameters.AddWithValue("@genero", p_prof.getGenero());
                sql_comando.Parameters.AddWithValue("@id_prof", p_prof.getId());
                sql_comando.Parameters.AddWithValue("@idade", p_prof.getIdade());
                sql_comando.Parameters.AddWithValue("@salario", p_prof.getValor());
                sql_comando.Parameters.AddWithValue("@materia", p_prof.getMateria());

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
        public bool deletar(Professor p_prof) //ASSINATURA DO MÉTODO
        {

            string sql_DELETE = "@DELETE FROM professor WHERE id_prof = ?";

            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                MySqlCommand sql_comando = new MySqlCommand(sql_DELETE, conexao);
                sql_comando.Parameters.AddWithValue("@id_prof", p_prof.getId());
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