using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace escola
{
    public class Pessoa
    {
        private String nome;
        private int idade;
        private String genero;
        private String cpf;


        public String getNome() { return nome; }
        public int getIdade() { return idade;}
        public String getGenero() { return genero; }
        public String getCpf() { return cpf;}
        public void setNome(String p_nome) { this.nome = p_nome; }
        public void setIdade(int p_idade) { this.idade = p_idade; }
        public void setGenero(String p_genero) { this.genero = p_genero;}
        public void getCpf(String p_cpf) { this.cpf = p_cpf; }
    }


}
