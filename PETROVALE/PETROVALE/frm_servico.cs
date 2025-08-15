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
    public partial class frm_servico : Form
    {
        public frm_servico()
        {
            InitializeComponent();
        }

        servico s = new servico();

      

        private void btn_consultarSer_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = s.consultar_servico();

            dataGridView1.Columns["id_servico"].HeaderText = "ID";
            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["tipo"].HeaderText = "Tipo";
            dataGridView1.Columns["preco"].HeaderText = "Preço";
            dataGridView1.Columns["desconto"].HeaderText = "Desconto";
        }

        private void btn_alterarSer_Click(object sender, EventArgs e)
        {
            try
            {
                s.setId_servico(int.Parse(txt_idSer.Text));
                s.setPreco(decimal.Parse(txt_precoSer.Text));
                s.setDesconto(int.Parse(txt_descontoSer.Text));

                s.alterar_servico();

                dataGridView1.DataSource = s.consultar_servico();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }


        private void btn_limparSer_Click(object sender, EventArgs e)
        {
            txt_idSer.Text = "";
            txt_nomeSer.Text = "";
            txt_tipoSer.Text = "";
            txt_precoSer.Text = "";
            txt_descontoSer.Text = "";
        }

        private void btn_voltarSer_Click(object sender, EventArgs e)
        {
            frm_principal form = new frm_principal();
            form.Show();
            this.Hide();
        }

        public void exibiregistro_servico(int i)
        {
            txt_idSer.Text = "" + dataGridView1[0, i].Value;
            txt_nomeSer.Text = "" + dataGridView1[1, i].Value;
            txt_tipoSer.Text = "" + dataGridView1[2, i].Value;
            txt_precoSer.Text = "" + dataGridView1[3, i].Value;
            txt_descontoSer.Text = "" + dataGridView1[4, i].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro_servico(dataGridView1.CurrentRow.Index);
        }

        private void frm_servico_Load(object sender, EventArgs e)
        {

        }
    }
}
