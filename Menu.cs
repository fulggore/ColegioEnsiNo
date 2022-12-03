using ColegioEnsiNo.FORMS.SECRETARIA;
using ColegioEnsiNo.PROFESSOR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColegioEnsiNo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInserirAluno aluno_inserir = new frmInserirAluno(); 
            aluno_inserir.MdiParent = this;
            aluno_inserir.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunoConsultar aluno_consultar = new frmAlunoConsultar();
            aluno_consultar.MdiParent = this;
            aluno_consultar.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunoAlterar aluno_alterar = new frmAlunoAlterar();
            aluno_alterar.MdiParent = this;
            aluno_alterar.Show();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunoApagar aluno_apagar = new frmAlunoApagar();
            aluno_apagar.MdiParent = this;
            aluno_apagar.Show();
        }

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           ProfessorInserir professorInserir = new ProfessorInserir();
            professorInserir.MdiParent = this;
            professorInserir.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfessorConsultar professorConsultar = new ProfessorConsultar();
            professorConsultar.MdiParent = this;
            professorConsultar.Show();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfessorAlterar professorAlterar = new ProfessorAlterar();
            professorAlterar.MdiParent = this;
            professorAlterar.Show();
        }

        private void apagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProfessorApagar professorApagar = new ProfessorApagar();
            professorApagar.MdiParent = this;
            professorApagar.Show();
        }

        private void inserirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManutencaoInserir manutencaoInserir = new ManutencaoInserir();
            manutencaoInserir.MdiParent = this;
            manutencaoInserir.Show();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ManutencaoConsultar manutencaoConsultar = new ManutencaoConsultar();
            manutencaoConsultar.MdiParent = this;
            manutencaoConsultar.Show();
        }

        private void alterarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ManutencaoAlterar manutencaoAlterar = new ManutencaoAlterar();
            manutencaoAlterar.MdiParent = this;
            manutencaoAlterar.Show();
        }

        private void apagarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ManutencaoApagar manutencaoApagar= new ManutencaoApagar();
            manutencaoApagar.MdiParent = this;
            manutencaoApagar.Show();
        }

        private void inserirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SecretariaInserir secretariaInserir = new SecretariaInserir();
            secretariaInserir.MdiParent = this;
            secretariaInserir.Show();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SecretariaConsultar secretariaConsultar= new SecretariaConsultar();
            secretariaConsultar.MdiParent = this;
            secretariaConsultar.Show();
        }

        private void alterarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SecretariaAlterar secretariaAlterar = new SecretariaAlterar();
            secretariaAlterar.MdiParent = this;
            secretariaAlterar.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cASCATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void hORIZONTALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void vERTICALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void iCONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
    }
}
