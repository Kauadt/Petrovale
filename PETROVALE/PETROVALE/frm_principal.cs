using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PETROVALE
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_vendaProduto form = new frm_vendaProduto();
            form.Show();
            this.Hide();
        }

        private void realizarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_funcionario form = new frm_funcionario();
            form.Show();
            this.Hide();
        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produto form = new frm_produto();
            form.Show();
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cliente form = new frm_cliente();
            form.Show();
            this.Hide();
        }

        private void vsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_vendaServico form = new frm_vendaServico();
            form.Show();
            this.Hide();
        }

        private void agendamentoLavagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lavagem form = new frm_lavagem();
            form.Show();
            this.Hide();
        }

        private void agendamentoEstacionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_estacionamento form = new frm_estacionamento();
            form.Show();
            this.Hide();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_servico form = new frm_servico();
            form.Show();
            this.Hide();
        }

        private void vagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_vagas form = new frm_vagas();
            form.Show();
            this.Hide();
        }
    }
}
