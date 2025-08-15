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
    public partial class frm_lavagem : Form
    {
        public frm_lavagem()
        {
            InitializeComponent();
        }

        lavagem lg = new lavagem();

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_inserirAg_Click(object sender, EventArgs e)
        {
            try
            {
               lg.setHorario(txt_horarioAl.Text);
               string dataFormatada = dtp_dataAl.Value.ToString("yyMMdd");
               lg.setData_agendamento(dataFormatada);
               lg.setPlaca(txt_placaAl.Text);
               lg.setId_servico(int.Parse(txt_idSerAl.Text));

               lg.inserir_agendamentoLavagem();

                //Consulta após a inserção dos dados.
                dataGridView1.DataSource =lg.consultar_agendamentoLavagem();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_consultarAg_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource =lg.consultar_agendamentoLavagem();

            dataGridView1.Columns["id_agendamentoLavagem"].HeaderText = "ID";
            dataGridView1.Columns["horario"].HeaderText = "Horário";
            dataGridView1.Columns["data_agendamento"].HeaderText = "Data";
            dataGridView1.Columns["placa"].HeaderText = "Placa";
            dataGridView1.Columns["id_servico"].HeaderText = "ID do Serviço";
        }

        private void btn_alterarAg_Click(object sender, EventArgs e)
        {
            try
            {
               lg.setId_agendamentoLavagem(int.Parse(txt_idAl.Text));
               lg.setHorario(txt_horarioAl.Text);
                string dataFormatada = dtp_dataAl.Value.ToString("yyMMdd");
                lg.setData_agendamento(dataFormatada);
                lg.setPlaca(txt_placaAl.Text);
               lg.setId_servico(int.Parse(txt_idSerAl.Text));

               lg.alterar_agendamentoLavagem();

                dataGridView1.DataSource =lg.consultar_agendamentoLavagem();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void btn_deletarAg_Click(object sender, EventArgs e)
        {
            try
            {
               lg.setId_agendamentoLavagem(int.Parse(txt_idAl.Text));
               lg.excluir_agendamentoLavagem();

                dataGridView1.DataSource =lg.consultar_agendamentoLavagem();
            }
            finally
            {
                MessageBox.Show("Informações excluidas com sucesso");
            }
        }

        private void btn_limparAg_Click(object sender, EventArgs e)
        {
            txt_idAl.Text = "";
            txt_horarioAl.Text = "";
            dtp_dataAl.Text = "";
            txt_placaAl.Text = "";
            txt_idSerAl.Text = "";
        }

        private void btn_voltarAg_Click(object sender, EventArgs e)
        {
            frm_principal form = new frm_principal();
            form.Show();
            this.Hide();
        }

        public void exibiregistro_agendamento(int i)
        {
            txt_idAl.Text = "" + dataGridView1[0, i].Value;
            txt_horarioAl.Text = "" + dataGridView1[1, i].Value;
            dtp_dataAl.Text = "" + dataGridView1[2, i].Value;
            txt_placaAl.Text = "" + dataGridView1[3, i].Value;
            txt_idSerAl.Text = "" + dataGridView1[4, i].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro_agendamento(dataGridView1.CurrentRow.Index);
        }

        private void dtp_dataAl_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
