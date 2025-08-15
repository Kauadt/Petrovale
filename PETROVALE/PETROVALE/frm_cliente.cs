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
    public partial class frm_cliente : Form
    {
        public frm_cliente()
        {
            InitializeComponent();
        }

        cliente c = new cliente();

        private void btn_consultarCliente_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.consultar_cliente();

            dataGridView1.Columns["id_cliente"].HeaderText = "ID";
            dataGridView1.Columns["cpf"].HeaderText = "CPF";
            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["estado"].HeaderText = "Estado";
            dataGridView1.Columns["cidade"].HeaderText = "Cidade";
            dataGridView1.Columns["bairro"].HeaderText = "Bairro";
            dataGridView1.Columns["rua"].HeaderText = "Rua";
            dataGridView1.Columns["numero"].HeaderText = "Número";
            dataGridView1.Columns["email"].HeaderText = "E-mail";
            dataGridView1.Columns["telefone"].HeaderText = "Telefone";
            dataGridView1.Columns["senha"].HeaderText = "Senha";
            dataGridView1.Columns["id_contaBancaria"].HeaderText = "Conta Bancária";
        }

        private void btn_voltarCliente_Click(object sender, EventArgs e)
        {
            frm_principal form = new frm_principal();
            form.Show();
            this.Hide();
        }

        private void btn_alterarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                c.setId_cliente(int.Parse(txt_idCliente.Text));
                c.setCpf(txt_cpfCliente.Text);
                c.setNome(txt_nomeCliente.Text);
                c.setEstado(txt_estadoCliente.Text);
                c.setCidade(txt_cidadeCliente.Text);
                c.setBairro(txt_bairroCliente.Text);
                c.setRua(txt_ruaCliente.Text);
                c.setNumero(int.Parse(txt_numeroCliente.Text));
                c.setEmail(txt_emailCliente.Text);
                c.setTelefone(txt_telefoneCliente.Text);
                c.setSenha(txt_senhaCliente.Text);
                c.setId_contaBancaria(int.Parse(txt_idCBCliente.Text));

                c.alterar_cliente();

                dataGridView1.DataSource = c.consultar_cliente();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void btn_deletarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                c.setId_cliente(int.Parse(txt_idCliente.Text));
                c.excluir_cliente();

                dataGridView1.DataSource = c.consultar_cliente();
            }
            finally
            {
                MessageBox.Show("Informações excluidas com sucesso");
            }
        }

        private void btn_limparCliente_Click(object sender, EventArgs e)
        {
            txt_idCliente.Text = "";
            txt_nomeCliente.Text = "";
            txt_cpfCliente.Text = "";
            txt_emailCliente.Text = "";
            txt_telefoneCliente.Text = "";
            txt_estadoCliente.Text = "";
            txt_cidadeCliente.Text = "";
            txt_bairroCliente.Text = "";
            txt_ruaCliente.Text = "";
            txt_numeroCliente.Text = "";
            txt_senhaCliente.Text = "";
            txt_idCBCliente.Text = "";
        }

        private void btn_inserirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                c.setNome(txt_nomeCliente.Text);
                c.setCpf(txt_cpfCliente.Text);
                c.setEmail(txt_emailCliente.Text);
                c.setTelefone(txt_telefoneCliente.Text);
                c.setEstado(txt_estadoCliente.Text);
                c.setCidade(txt_cidadeCliente.Text);
                c.setBairro(txt_bairroCliente.Text);
                c.setRua(txt_ruaCliente.Text);
                c.setNumero(int.Parse(txt_numeroCliente.Text));
                c.setSenha(txt_senhaCliente.Text);
                c.setId_contaBancaria(int.Parse(txt_idCBCliente.Text));

                c.inserir_cliente();

                //Consulta após a inserção dos dados.
                dataGridView1.DataSource = c.consultar_cliente();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }
        public void exibiregistro_cliente(int i)
        {
            txt_idCliente.Text = "" + dataGridView1[0, i].Value;
            txt_cpfCliente.Text = "" + dataGridView1[1, i].Value;
            txt_nomeCliente.Text = "" + dataGridView1[2, i].Value;
            txt_estadoCliente.Text = "" + dataGridView1[3, i].Value;
            txt_cidadeCliente.Text = "" + dataGridView1[4, i].Value;
            txt_bairroCliente.Text = "" + dataGridView1[5, i].Value;
            txt_ruaCliente.Text = "" + dataGridView1[6, i].Value;
            txt_numeroCliente.Text = "" + dataGridView1[7, i].Value;
            txt_emailCliente.Text = "" + dataGridView1[8, i].Value;
            txt_telefoneCliente.Text = "" + dataGridView1[9, i].Value;
            txt_senhaCliente.Text = "" + dataGridView1[10, i].Value;
            txt_idCBCliente.Text = "" + dataGridView1[11, i].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro_cliente(dataGridView1.CurrentRow.Index);
        }
    }
}
