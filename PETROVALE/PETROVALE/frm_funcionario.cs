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
    public partial class frm_funcionario : Form
    {
        public frm_funcionario()
        {
            InitializeComponent();
        }

        private void lbl_cadastroPosto_Click(object sender, EventArgs e)
        {

        }

        funcionario f = new funcionario();

        private void btn_inserirPosto_Click(object sender, EventArgs e)
        {
            try
            {
                f.setNome(txt_nomeFun.Text);
                f.setCtps(txt_ctpsFun.Text);
                f.setEmail(txt_emailFun.Text);
                f.setTelefone(txt_telefoneFun.Text);
                f.setEstado(txt_estadoFun.Text);
                f.setCidade(txt_cidadeFun.Text);
                f.setBairro(txt_bairroFun.Text);
                f.setRua(txt_ruaFun.Text);
                f.setNumero(int.Parse(txt_numeroFun.Text));
                f.setSenha(txt_senhaFun.Text);
                f.setCargo(txt_cargoFun.Text);
                f.setId_posto(int.Parse(txt_idPostoFun.Text));

                f.inserir_funcionario();

                //Consulta após a inserção dos dados.
                dataGridView1.DataSource = f.consultar_funcionario();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_consultarFun_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f.consultar_funcionario();

            dataGridView1.Columns["id_funcionario"].HeaderText = "ID";
            dataGridView1.Columns["ctps"].HeaderText = "CTPS";
            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["estado"].HeaderText = "Estado";
            dataGridView1.Columns["cidade"].HeaderText = "Cidade";
            dataGridView1.Columns["bairro"].HeaderText = "Bairro";
            dataGridView1.Columns["rua"].HeaderText = "Rua";
            dataGridView1.Columns["numero"].HeaderText = "Número";
            dataGridView1.Columns["email"].HeaderText = "E-mail";
            dataGridView1.Columns["telefone"].HeaderText = "Telefone";
            dataGridView1.Columns["senha"].HeaderText = "Senha";
            dataGridView1.Columns["cargo"].HeaderText = "Cargo";
            dataGridView1.Columns["id_posto"].HeaderText = "ID do posto";
        }

        private void btn_alterarFun_Click(object sender, EventArgs e)
        {
            try
            {
                f.setId_funcionario(int.Parse(txt_idFun.Text));
                f.setCtps(txt_ctpsFun.Text);
                f.setNome(txt_nomeFun.Text);
                f.setEstado(txt_estadoFun.Text);
                f.setCidade(txt_cidadeFun.Text);
                f.setBairro(txt_bairroFun.Text);
                f.setRua(txt_ruaFun.Text);
                f.setNumero(int.Parse(txt_numeroFun.Text));
                f.setEmail(txt_emailFun.Text);
                f.setTelefone(txt_telefoneFun.Text);
                f.setSenha(txt_senhaFun.Text);
                f.setCargo(txt_cargoFun.Text);
                f.setId_posto(int.Parse(txt_idPostoFun.Text));

                f.alterar_funcionario();

                dataGridView1.DataSource = f.consultar_funcionario();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void btn_deletarFun_Click(object sender, EventArgs e)
        {
            try
            {
                f.setId_funcionario(int.Parse(txt_idFun.Text));
                f.excluir_funcionario();

                dataGridView1.DataSource = f.consultar_funcionario();
            }
            finally
            {
                MessageBox.Show("Informações excluidas com sucesso");
            }
        }

        private void btn_limparFun_Click(object sender, EventArgs e)
        {
            txt_idFun.Text = "";
            txt_nomeFun.Text = "";
            txt_ctpsFun.Text = "";
            txt_emailFun.Text = "";
            txt_telefoneFun.Text = "";
            txt_estadoFun.Text = "";
            txt_cidadeFun.Text = "";
            txt_bairroFun.Text = "";
            txt_ruaFun.Text = "";
            txt_numeroFun.Text = "";
            txt_senhaFun.Text = "";
            txt_cargoFun.Text = "";
            txt_idPostoFun.Text = "";
        }

        private void btn_voltarFun_Click(object sender, EventArgs e)
        {
            frm_principal form = new frm_principal();
            form.Show();
            this.Hide();
        }

        public void exibiregistro_funcionario(int i)
        {
            txt_idFun.Text = "" + dataGridView1[0, i].Value;
            txt_ctpsFun.Text = "" + dataGridView1[1, i].Value;
            txt_nomeFun.Text = "" + dataGridView1[2, i].Value;
            txt_estadoFun.Text = "" + dataGridView1[3, i].Value;
            txt_cidadeFun.Text = "" + dataGridView1[4, i].Value;
            txt_bairroFun.Text = "" + dataGridView1[5, i].Value;
            txt_ruaFun.Text = "" + dataGridView1[6, i].Value;
            txt_numeroFun.Text = "" + dataGridView1[7, i].Value;
            txt_emailFun.Text = "" + dataGridView1[8, i].Value;
            txt_telefoneFun.Text = "" + dataGridView1[9, i].Value;
            txt_senhaFun.Text = "" + dataGridView1[10, i].Value;
            txt_cargoFun.Text = "" + dataGridView1[11, i].Value;
            txt_idPostoFun.Text = "" + dataGridView1[12, i].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro_funcionario(dataGridView1.CurrentRow.Index);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
