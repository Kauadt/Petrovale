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
    public partial class frm_estacionamento : Form
    {
        public frm_estacionamento()
        {
            InitializeComponent();
        }

        estacionamento es = new estacionamento();

        private void btn_inserirEs_Click(object sender, EventArgs e)
        {
            try
            {
                string dataFormatada = dtp_dataAe.Value.ToString("yyMMdd");
                es.setData_agendamento(dataFormatada);
                es.setHorario(txt_horarioAe.Text);
                es.setTempo(txt_tempoAe.Text);
                es.setPlaca(txt_placaAe.Text);
                es.setId_servico(int.Parse(txt_idSerAe.Text));

                es.inserir_agendamentoEstacionamento();

                //Consulta após a inserção dos dados.
                dataGridView1.DataSource = es.consultar_agendamentoEstacionamento();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_consultarEs_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = es.consultar_agendamentoEstacionamento();

            dataGridView1.Columns["id_agendamentoEstacionamento"].HeaderText = "ID";
            dataGridView1.Columns["horario"].HeaderText = "Horário";
            dataGridView1.Columns["data_agendamento"].HeaderText = "Data";
            dataGridView1.Columns["tempo"].HeaderText = "Tempo";
            dataGridView1.Columns["placa"].HeaderText = "Placa";
            dataGridView1.Columns["id_servico"].HeaderText = "ID do Serviço";
        }

        private void btn_alterarEs_Click(object sender, EventArgs e)
        {
            try
            {
                es.setId_agendamentoEstacionamento(int.Parse(txt_idAe.Text));
                es.setHorario(txt_horarioAe.Text);
                string dataFormatada = dtp_dataAe.Value.ToString("yyMMdd");
                es.setData_agendamento(dataFormatada);
                es.setTempo(txt_tempoAe.Text);
                es.setPlaca(txt_placaAe.Text);
                es.setId_servico(int.Parse(txt_idSerAe.Text));

                es.alterar_agendamentoEstacionamento();

                dataGridView1.DataSource = es.consultar_agendamentoEstacionamento();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void btn_deletarEs_Click(object sender, EventArgs e)
        {
            try
            {
                es.setId_agendamentoEstacionamento(int.Parse(txt_idAe.Text));
                es.excluir_agendamentoEstacionamento();

                dataGridView1.DataSource = es.consultar_agendamentoEstacionamento();
            }
            finally
            {
                MessageBox.Show("Informações excluidas com sucesso");
            }
        }

        private void btn_limparEs_Click(object sender, EventArgs e)
        {
            txt_idAe.Text = "";
            txt_horarioAe.Text = "";
            dtp_dataAe.Text = "";
            txt_tempoAe.Text = "";
            txt_placaAe.Text = "";
            txt_idSerAe.Text = "";
        }

        private void btn_voltarEs_Click(object sender, EventArgs e)
        {
            frm_principal form = new frm_principal();
            form.Show();
            this.Hide();
        }

        public void exibiregistro_estacionamento(int i)
        {
            txt_idAe.Text = "" + dataGridView1[0, i].Value;
            txt_horarioAe.Text = "" + dataGridView1[1, i].Value;
            dtp_dataAe.Text = "" + dataGridView1[2, i].Value;
            txt_tempoAe.Text = "" + dataGridView1[3, i].Value;
            txt_placaAe.Text = "" + dataGridView1[4, i].Value;
            txt_idSerAe.Text = "" + dataGridView1[5, i].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro_estacionamento(dataGridView1.CurrentRow.Index);
        }

        private void dtp_dataAe_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
