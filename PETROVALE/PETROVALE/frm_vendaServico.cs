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
    public partial class frm_vendaServico : Form
    {
        public frm_vendaServico()
        {
            InitializeComponent();
        }

        vendaServico vs = new vendaServico();

        private void btn_inserirVs_Click(object sender, EventArgs e)
        {
            try
            {
                vs.setId_funcionario(int.Parse(txt_idFunVs.Text));
                string dataFormatada = dtp_dataVs.Value.ToString("yyMMdd");
                vs.setData_vendaservicos(dataFormatada);
                vs.setQuantidade_combustivel(decimal.Parse(txt_combustivelVs.Text));
                vs.setId_cliente(int.Parse(txt_idClienteVs.Text));
                vs.setId_servico(int.Parse(txt_idSerVs.Text));


                vs.inserir_vendaServico();

                //Consulta após a inserção dos dados.
                dataGridView1.DataSource = vs.consultar_vendaServico();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_consultarVs_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vs.consultar_vendaServico();

            dataGridView1.Columns["id_vendaservicos"].HeaderText = "ID";
            dataGridView1.Columns["data_vendaservicos"].HeaderText = "Data";
            dataGridView1.Columns["quantidade_combustivel"].HeaderText = "Quantidade de Combustível";
            dataGridView1.Columns["id_funcionario"].HeaderText = "ID do Funcionário";
            dataGridView1.Columns["id_cliente"].HeaderText = "ID do Cliente";
            dataGridView1.Columns["id_servico"].HeaderText = "ID do Serviço";
        }

        private void btn_alterarVs_Click(object sender, EventArgs e)
        {
            try
            {
                vs.setId_vendaservicos(int.Parse(txt_idVs.Text));
                string dataFormatada = dtp_dataVs.Value.ToString("yyMMdd");
                vs.setData_vendaservicos(dataFormatada);
                vs.setQuantidade_combustivel(decimal.Parse(txt_combustivelVs.Text));
                vs.setId_funcionario(int.Parse(txt_idFunVs.Text));
                vs.setId_cliente(int.Parse(txt_idClienteVs.Text));
                vs.setId_servico(int.Parse(txt_idSerVs.Text));

                vs.alterar_vendaServico();

                dataGridView1.DataSource = vs.consultar_vendaServico();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void btn_deletarVs_Click(object sender, EventArgs e)
        {
            try
            {
                vs.setId_vendaservicos(int.Parse(txt_idVs.Text));
                vs.excluir_vendaServico();

                dataGridView1.DataSource = vs.consultar_vendaServico();
            }
            finally
            {
                MessageBox.Show("Informações excluidas com sucesso");
            }
        }

        private void btn_limparVs_Click(object sender, EventArgs e)
        {
            txt_idVs.Text = "";
            dtp_dataVs.Text = "";
            txt_combustivelVs.Text = "";
            txt_idFunVs.Text = "";
            txt_idClienteVs.Text = "";
            txt_idSerVs.Text = "";
        }

        private void btn_voltarVs_Click(object sender, EventArgs e)
        {
            frm_principal form = new frm_principal();
            form.Show();
            this.Hide();
        }

        public void exibiregistro_vendaServico(int i)
        {
            txt_idVs.Text = "" + dataGridView1[0, i].Value;
            dtp_dataVs.Text = "" + dataGridView1[1, i].Value;
            txt_combustivelVs.Text = "" + dataGridView1[2, i].Value;
            txt_idFunVs.Text = "" + dataGridView1[3, i].Value;
            txt_idClienteVs.Text = "" + dataGridView1[4, i].Value;
            txt_idSerVs.Text = "" + dataGridView1[5, i].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro_vendaServico(dataGridView1.CurrentRow.Index);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
