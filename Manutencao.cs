using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    public class Manutencao : Pessoa
    {
        private String setor;
        private float salario;
        private DateTime dia_servico;

        public String getSetor() { return setor; }
        public void setSetor(String p_setor) { this.setor = p_setor; }
        public float getValor() { return salario; }
        public void setValor(float p_salario) { this.salario = p_salario; }
        public DateTime getDate() { return dia_servico; }
        public void setDate(DateTime p_dia_serviço) { this.dia_servico = p_dia_serviço; }
    }
}
