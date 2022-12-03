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
    public class AlunoDAO
    {
        //Cadastrar

        public bool cadastrar(Aluno p_aluno) //Assinatura Método 

        {
            string sql_INSERT = @"INSERT INTO aluno(nome, idade, cpf, genero, rgm, ano, id_boletim) VALUES(?, ?, ?, ?, ?, ?, ?)";

            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                MySqlCommand sql_comando = new MySqlCommand(sql_INSERT, conexao);
                sql_comando.Parameters.AddWithValue("@nome", p_aluno.getNome());
                sql_comando.Parameters.AddWithValue("@cpf", p_aluno.getCpf());
                sql_comando.Parameters.AddWithValue("@genero", p_aluno.getGenero());
                sql_comando.Parameters.AddWithValue("@rgm", p_aluno.getRgm());
                sql_comando.Parameters.AddWithValue("@idade", p_aluno.getIdade());
                sql_comando.Parameters.AddWithValue("@ano", p_aluno.getAno());
                sql_comando.Parameters.AddWithValue("@id_boletim", p_aluno.getId_boletim());
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
            string sql_SELECT = "SELECT * FROM escola";
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
        public bool alterar(Aluno p_aluno) //Assinatura Método
        {
            string sql_UPDATE = @"UPDATE aluno SET nome=?, idade=?, cpf=?, genero=?, rgm=?, ano=?, id_boletim=? WHERE id = ?";

            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                MySqlCommand sql_comando = new MySqlCommand(sql_UPDATE, conexao);
                sql_comando.Parameters.AddWithValue("@nome", p_aluno.getNome());
                sql_comando.Parameters.AddWithValue("@cpf", p_aluno.getCpf());
                sql_comando.Parameters.AddWithValue("@genero", p_aluno.getGenero());
                sql_comando.Parameters.AddWithValue("@rgm", p_aluno.getRgm());
                sql_comando.Parameters.AddWithValue("@idade", p_aluno.getIdade());
                sql_comando.Parameters.AddWithValue("@ano", p_aluno.getAno());
                sql_comando.Parameters.AddWithValue("@id_boletim", p_aluno.getId_boletim());

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
        public bool deletar(Aluno p_aluno) //ASSINATURA DO MÉTODO
        {

            string sql_DELETE = "@DELETE FROM aluno WHERE rgm = ?";

            try
            {
                MySqlConnection conexao = Conexao.conectar();
                conexao.Open();
                MySqlCommand sql_comando = new MySqlCommand(sql_DELETE, conexao);
                sql_comando.Parameters.AddWithValue("@rgm", p_aluno.getRgm());
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