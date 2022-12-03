using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    public class Secretaria : Pessoa
    {
        private int id_func;
        private String setor;
        private float salario;

        public int getId() { return id_func; }
        public void setId(int p_id) { id_func = p_id; }
        public String getSetor() { return setor; }
        public void setSetor(String p_setor) { this.setor = p_setor; }
        public float getValor() { return salario; }
        public void setValor(float p_salario) { this.salario = p_salario; }
    }
}