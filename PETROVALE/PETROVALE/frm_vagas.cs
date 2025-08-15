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
    public partial class frm_vagas : Form
    {
        public frm_vagas()
        {
            InitializeComponent();
        }

        vagas vg = new vagas();

        private void lbl_statusEs_Click(object sender, EventArgs e)
        {

        }

        private void cbo_statusEs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_inserirVagas_Click(object sender, EventArgs e)
        {
            try
            {
                vg.setNumero_vagas(int.Parse(txt_numeroVagas.Text));
                vg.setStatus_vagas(cbo_statusVagas.Text);
                vg.setId_agendamentoEstacionamento(int.Parse(txt_idEsVagas.Text));

                vg.inserir_vagas();

                //Consulta após a inserção dos dados.
                dataGridView1.DataSource = vg.consultar_vagas();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_consultarVagas_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vg.consultar_vagas();

            dataGridView1.Columns["id_vaga"].HeaderText = "ID";
            dataGridView1.Columns["numero_vagas"].HeaderText = "Número da Vaga";
            dataGridView1.Columns["status_vagas"].HeaderText = "Status da Vaga";
            dataGridView1.Columns["id_agendamentoEstacionamento"].HeaderText = "ID do Estacionamento";
        }

        private void btn_alterarVagas_Click(object sender, EventArgs e)
        {
            try
            {
                vg.setId_vaga(int.Parse(txt_idVagas.Text));
                vg.setNumero_vagas(int.Parse(txt_numeroVagas.Text));
                vg.setStatus_vagas(cbo_statusVagas.Text);
                vg.setId_agendamentoEstacionamento(int.Parse(txt_idEsVagas.Text));

                vg.alterar_vagas();

                dataGridView1.DataSource = vg.consultar_vagas();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void btn_deletarVagas_Click(object sender, EventArgs e)
        {
            try
            {
                vg.setId_vaga(int.Parse(txt_idVagas.Text));
                vg.excluir_vagas();

                dataGridView1.DataSource = vg.consultar_vagas();
            }
            finally
            {
                MessageBox.Show("Informações excluidas com sucesso");
            }
        }

        private void btn_limparVagas_Click(object sender, EventArgs e)
        {
            txt_idVagas.Text = "";
            txt_numeroVagas.Text = "";
            cbo_statusVagas.Text = "Vago";
            txt_idEsVagas.Text = "";
        }

        private void btn_voltarVagas_Click(object sender, EventArgs e)
        {
            frm_principal form = new frm_principal();
            form.Show();
            this.Hide();
        }

        public void exibiregistro_vagas(int i)
        {
            txt_idVagas.Text = "" + dataGridView1[0, i].Value;
            txt_numeroVagas.Text = "" + dataGridView1[1, i].Value;
            cbo_statusVagas.Text = "" + dataGridView1[2, i].Value;
            txt_idEsVagas.Text = "" + dataGridView1[3, i].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro_vagas(dataGridView1.CurrentRow.Index);
        }
    }
}
