using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    public class Professor : Pessoa
    {
        private String id_prof;
        private String materia;
        private float salario;

        public String getId() { return id_prof; }
        public String getMateria() { return materia; }
        public void setId(String p_id) { this.id_prof = p_id; }
        public void setMateria(String p_materia) { this.materia = p_materia; }
        public float getValor() { return salario; }
        public void setValor(float p_salario) { this.salario = p_salario; }
    }
}