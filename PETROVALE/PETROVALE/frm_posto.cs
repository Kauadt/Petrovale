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
    public partial class frm_posto : Form
    {
        public frm_posto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_codigo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_telefonePosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_senha_Click(object sender, EventArgs e)
        {

        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_posto_Load(object sender, EventArgs e)
        {

        }

        posto p = new posto();

        private void btn_consultarPosto_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p.consultar_posto();

            dataGridView1.Columns["id_posto"].HeaderText = "ID";
            dataGridView1.Columns["cnpj"].HeaderText = "CNPJ";
            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["estado"].HeaderText = "Estado";
            dataGridView1.Columns["cidade"].HeaderText = "Cidade";
            dataGridView1.Columns["bairro"].HeaderText = "Bairro";
            dataGridView1.Columns["rua"].HeaderText = "Rua";
            dataGridView1.Columns["numero"].HeaderText = "Número";
            dataGridView1.Columns["email"].HeaderText = "E-mail";
            dataGridView1.Columns["telefone"].HeaderText = "Telefone";
            dataGridView1.Columns["senha"].HeaderText = "Senha";
        }

        private void btn_inserirPosto_Click(object sender, EventArgs e)
        {
            try
            {
                p.setNome(txt_nomePosto.Text);
                p.setCnpj(txt_cnpjPosto.Text);
                p.setEmail(txt_emailPosto.Text);
                p.setTelefone(txt_telefonePosto.Text);
                p.setEstado(txt_estadoPosto.Text);
                p.setCidade(txt_cidadePosto.Text);
                p.setBairro(txt_bairroPosto.Text);
                p.setRua(txt_ruaPosto.Text);
                p.setNumero(int.Parse(txt_numeroPosto.Text));
                p.setSenha(txt_senhaPosto.Text);

                p.inserir_posto();

                //Consulta após a inserção dos dados.
                dataGridView1.DataSource = p.consultar_posto();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_alterarPosto_Click(object sender, EventArgs e)
        {
            try
            {
                p.setId_posto(int.Parse(txt_idPosto.Text));
                p.setCnpj(txt_cnpjPosto.Text);
                p.setNome(txt_nomePosto.Text);
                p.setEstado(txt_estadoPosto.Text);
                p.setCidade(txt_cidadePosto.Text);
                p.setBairro(txt_bairroPosto.Text);
                p.setRua(txt_ruaPosto.Text);
                p.setNumero(int.Parse(txt_numeroPosto.Text));
                p.setEmail(txt_emailPosto.Text);
                p.setTelefone(txt_telefonePosto.Text);
                p.setSenha(txt_senhaPosto.Text);

                p.alterar_posto();

                dataGridView1.DataSource = p.consultar_posto();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void btn_deletarPosto_Click(object sender, EventArgs e)
        {
            try
            {
                p.setId_posto(int.Parse(txt_idPosto.Text));
                p.excluir_posto();

                dataGridView1.DataSource = p.consultar_posto();
            }
            finally
            {
                MessageBox.Show("Informações excluidas com sucesso");
            }
        }

        private void btn_limparPosto_Click(object sender, EventArgs e)
        {
            txt_idPosto.Text = "";
            txt_nomePosto.Text = "";
            txt_cnpjPosto.Text = "";
            txt_emailPosto.Text = "";
            txt_telefonePosto.Text = "";
            txt_estadoPosto.Text = "";
            txt_cidadePosto.Text = "";
            txt_bairroPosto.Text = "";
            txt_ruaPosto.Text = "";
            txt_numeroPosto.Text = "";
            txt_senhaPosto.Text = "";
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void btn_voltarPosto_Click(object sender, EventArgs e)
        {

        }
        public void exibiregistro_posto(int i)
        {
            txt_idPosto.Text = "" + dataGridView1[0, i].Value;
            txt_cnpjPosto.Text = "" + dataGridView1[1, i].Value;
            txt_nomePosto.Text = "" + dataGridView1[2, i].Value;
            txt_estadoPosto.Text = "" + dataGridView1[3, i].Value;
            txt_cidadePosto.Text = "" + dataGridView1[4, i].Value;
            txt_bairroPosto.Text = "" + dataGridView1[5, i].Value;
            txt_ruaPosto.Text = "" + dataGridView1[6, i].Value;
            txt_numeroPosto.Text = "" + dataGridView1[7, i].Value;
            txt_emailPosto.Text = "" + dataGridView1[8, i].Value;
            txt_telefonePosto.Text = "" + dataGridView1[9, i].Value;
            txt_senhaPosto.Text = "" + dataGridView1[10, i].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro_posto(dataGridView1.CurrentRow.Index);
        }

        private void txt_senhaPosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_voltarPosto_Click_1(object sender, EventArgs e)
        {
            frm_login form = new frm_login();
            form.Show();
            this.Hide();
        }
    }
}
