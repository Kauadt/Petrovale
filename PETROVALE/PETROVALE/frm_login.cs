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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair ?", "PETROVALE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        posto p = new posto();

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            p.setEmail(txt_emailLogin.Text);
            p.setSenha(txt_senhaLogin.Text);

            p.consultar_login();

            int valor = p.consultar_login();
            if (valor == 1)
            {
                frm_principal form = new frm_principal();
                form.Show();
                this.Hide();
            }
            else if (txt_emailLogin.Text == "admin" && txt_senhaLogin.Text == "admin")
            {
                frm_posto form = new frm_posto();
                form.Show();
                this.Hide();
            }
            else { MessageBox.Show("Usuário e Senha Invalidos", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void txt_emailLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
