using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    public class Aluno : Pessoa 
    {
        private int rgm;
        private String ano;
        private int id_boletim;


        public int getRgm() { return rgm; }
        public String getAno() { return ano; }
        public int getId_boletim() { return id_boletim; }
        public void setRgm(int p_rgm) { this.rgm = p_rgm; }
        public void setAno(String p_ano) { this.ano = p_ano; }
        public void setBoletim(int p_id_boletim) { this.id_boletim= p_id_boletim; }

    }
}
