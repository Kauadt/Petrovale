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
    public partial class frm_vendaProduto : Form
    {
        public frm_vendaProduto()
        {
            InitializeComponent();
        }

        vendaProduto vp = new vendaProduto();

        private void lbl_idProdVP_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_idClienteVP_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_inserirVp_Click(object sender, EventArgs e)
        {
            try
            {
                vp.setValor(decimal.Parse(txt_valorVp.Text));
                string dataFormatada = dtp_dataVp.Value.ToString("yyMMdd");
                vp.setData_vendaproduto(dataFormatada);
                vp.setQuantidade(int.Parse(txt_quantVp.Text));
                vp.setId_posto(int.Parse(txt_idPostoVp.Text));
                vp.setId_produto(int.Parse(txt_idProdVp.Text));
                vp.setId_funcionario(int.Parse(txt_idFunVp.Text));
                vp.setId_cliente(int.Parse(txt_idClienteVp.Text));


                vp.inserir_vendaProduto();

                //Consulta após a inserção dos dados.
                dataGridView1.DataSource = vp.consultar_vendaProduto();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_consultarVp_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vp.consultar_vendaProduto();

            dataGridView1.Columns["id_vendaproduto"].HeaderText = "ID";
            dataGridView1.Columns["valor"].HeaderText = "Valor";
            dataGridView1.Columns["data_vendaproduto"].HeaderText = "Data";
            dataGridView1.Columns["quantidade"].HeaderText = "Quantidade";
            dataGridView1.Columns["id_funcionario"].HeaderText = "ID do Funcionário";
            dataGridView1.Columns["id_produto"].HeaderText = "ID do Produto";
            dataGridView1.Columns["id_cliente"].HeaderText = "ID do Cliente";
        }

        private void btn_alterarVp_Click(object sender, EventArgs e)
        {
            try
            {
                vp.setId_vendaproduto(int.Parse(txt_idVp.Text));
                vp.setValor(decimal.Parse(txt_valorVp.Text));
                string dataFormatada = dtp_dataVp.Value.ToString("yyMMdd");
                vp.setData_vendaproduto(dataFormatada);
                vp.setQuantidade(int.Parse(txt_quantVp.Text));
                vp.setId_posto(int.Parse(txt_idPostoVp.Text));
                vp.setId_produto(int.Parse(txt_idProdVp.Text));
                vp.setId_funcionario(int.Parse(txt_idFunVp.Text));
                vp.setId_cliente(int.Parse(txt_idClienteVp.Text));

                vp.alterar_vendaProduto();

                dataGridView1.DataSource = vp.consultar_vendaProduto();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void btn_deletarVp_Click(object sender, EventArgs e)
        {
            try
            {
                vp.setId_vendaproduto(int.Parse(txt_idVp.Text));
                vp.excluir_vendaProduto();

                dataGridView1.DataSource = vp.consultar_vendaProduto();
            }
            finally
            {
                MessageBox.Show("Informações excluidas com sucesso");
            }
        }

        private void btn_limparVp_Click(object sender, EventArgs e)
        {
            txt_idVp.Text = "";
            txt_valorVp.Text = "";
            dtp_dataVp.Text = "";
            txt_quantVp.Text = "";
            txt_idPostoVp.Text = "";
            txt_idProdVp.Text = "";
            txt_idFunVp.Text = "";
            txt_idClienteVp.Text = "";
        }

        private void btn_voltarVp_Click(object sender, EventArgs e)
        {
            frm_principal form = new frm_principal();
            form.Show();
            this.Hide();
        }

        public void exibiregistro_vendaProduto(int i)
        {
            txt_idVp.Text = "" + dataGridView1[0, i].Value;
            txt_valorVp.Text = "" + dataGridView1[1, i].Value;
            dtp_dataVp.Text = "" + dataGridView1[2, i].Value;
            txt_quantVp.Text = "" + dataGridView1[3, i].Value;
            txt_idPostoVp.Text = "" + dataGridView1[4, i].Value;
            txt_idProdVp.Text = "" + dataGridView1[5, i].Value;
            txt_idFunVp.Text = "" + dataGridView1[6, i].Value;
            txt_idClienteVp.Text = "" + dataGridView1[7, i].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro_vendaProduto(dataGridView1.CurrentRow.Index);
        }

        private void frm_vendaProduto_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
