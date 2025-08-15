using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PETROVALE
{
    public partial class frm_produto : Form
    {
        public frm_produto()
        {
            InitializeComponent();
        }

        string arquivo, caminhoarquivo;

        produto pr = new produto();

        private void btn_inserirProd_Click(object sender, EventArgs e)
        {
            try
            {
                pr.setNome(txt_nomeProd.Text);
                pr.setDescricao(txt_descricaoProd.Text);
                pr.setPreco(decimal.Parse(txt_precoProd.Text));
                pr.setDesconto(int.Parse(txt_descontoProd.Text));

                pr._foto = caminhoarquivo.Replace(@"\", @"\\"); ;
                picturebox.Image.Save("C:\\fotos\\" + arquivo + ".png", System.Drawing.Imaging.ImageFormat.Png);
                string dbfile = carregarfoto.FileName;

                pr.inserir_produto();

                //Consulta após a inserção dos dados.
                dataGridView1.DataSource = pr.consultar_produto();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_consultarProd_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pr.consultar_produto();

            dataGridView1.Columns["id_produto"].HeaderText = "ID";
            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["preco"].HeaderText = "Preço";
            dataGridView1.Columns["desconto"].HeaderText = "Desconto";
            dataGridView1.Columns["foto"].HeaderText = "Foto";
        }

        private void btn_alterarProd_Click(object sender, EventArgs e)
        {
            try
            {
                pr.setId_produto(int.Parse(txt_idProd.Text));
                pr.setNome(txt_nomeProd.Text);
                pr.setDescricao(txt_descricaoProd.Text);
                pr.setPreco(decimal.Parse(txt_precoProd.Text));
                pr.setDesconto(int.Parse(txt_descontoProd.Text));

                pr._foto = caminhoarquivo.Replace(@"\", @"\\"); ;
                picturebox.Image.Save("D:\\fotos\\" + arquivo + ".png", System.Drawing.Imaging.ImageFormat.Png);
                string dbfile = carregarfoto.FileName;

                pr.alterar_produto();

                dataGridView1.DataSource = pr.consultar_produto();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        private void btn_deletarProd_Click(object sender, EventArgs e)
        {
            try
            {
                pr.setId_produto(int.Parse(txt_idProd.Text));
                pr.excluir_produto();

                dataGridView1.DataSource = pr.consultar_produto();
            }
            finally
            {
                MessageBox.Show("Informações excluidas com sucesso");
            }
        }

        private void btn_limparProd_Click(object sender, EventArgs e)
        {
            txt_idProd.Text = "";
            txt_nomeProd.Text = "";
            txt_descricaoProd.Text = "";
            txt_precoProd.Text = "";
            txt_descontoProd.Text = "";
            picturebox.Text = "";
        }

        private void btn_voltarProd_Click(object sender, EventArgs e)
        {
            frm_principal form = new frm_principal();
            form.Show();
            this.Hide();
        }

        public void exibiregistro_produto(int i)
        {
            txt_idProd.Text = "" + dataGridView1[0, i].Value;
            txt_nomeProd.Text = "" + dataGridView1[1, i].Value;
            txt_descricaoProd.Text = "" + dataGridView1[2, i].Value;
            txt_precoProd.Text = "" + dataGridView1[3, i].Value;
            txt_descontoProd.Text = "" + dataGridView1[4, i].Value;
            picturebox.Text = "" + dataGridView1[5, i].Value;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro_produto(dataGridView1.CurrentRow.Index);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picturebox_Click(object sender, EventArgs e)
        {
            try
            {
                carregarfoto.ShowDialog();
                Bitmap bmp = new Bitmap(carregarfoto.FileName);

                Bitmap bmp2 = new Bitmap(bmp);
                picturebox.Image = bmp2;
                string nomeArquivo = Path.GetFileNameWithoutExtension(carregarfoto.FileName);

                arquivo = nomeArquivo;
                caminhoarquivo = ("D:\\fotos\\" + arquivo + ".png");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar.");
            }
        }
    }
}
