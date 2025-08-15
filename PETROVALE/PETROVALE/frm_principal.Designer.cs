namespace PETROVALE
{
    partial class frm_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vagaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoLavagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoEstacionamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaBancariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PETROVALE.Properties.Resources.Group_139;
            this.pictureBox1.Location = new System.Drawing.Point(369, 341);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 103);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.gestãoToolStripMenuItem,
            this.agendamentosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1380, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionarioBackupToolStripMenuItem,
            this.produtoUsuárioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.contaBancariaToolStripMenuItem,
            this.serviçoToolStripMenuItem,
            this.vagaToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.arquivoToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionarioBackupToolStripMenuItem
            // 
            this.funcionarioBackupToolStripMenuItem.Name = "funcionarioBackupToolStripMenuItem";
            this.funcionarioBackupToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.funcionarioBackupToolStripMenuItem.Text = "Funcionário";
            this.funcionarioBackupToolStripMenuItem.Click += new System.EventHandler(this.realizarBackupToolStripMenuItem_Click);
            // 
            // produtoUsuárioToolStripMenuItem
            // 
            this.produtoUsuárioToolStripMenuItem.Name = "produtoUsuárioToolStripMenuItem";
            this.produtoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.produtoUsuárioToolStripMenuItem.Text = "Produto";
            this.produtoUsuárioToolStripMenuItem.Click += new System.EventHandler(this.trocarUsuárioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            this.serviçoToolStripMenuItem.Click += new System.EventHandler(this.serviçosToolStripMenuItem_Click);
            // 
            // vagaToolStripMenuItem
            // 
            this.vagaToolStripMenuItem.Name = "vagaToolStripMenuItem";
            this.vagaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vagaToolStripMenuItem.Text = "Vaga";
            this.vagaToolStripMenuItem.Click += new System.EventHandler(this.vagasToolStripMenuItem_Click);
            // 
            // gestãoToolStripMenuItem
            // 
            this.gestãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vpToolStripMenuItem,
            this.vsToolStripMenuItem});
            this.gestãoToolStripMenuItem.Name = "gestãoToolStripMenuItem";
            this.gestãoToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.gestãoToolStripMenuItem.Text = "Gestão";
            // 
            // vpToolStripMenuItem
            // 
            this.vpToolStripMenuItem.Name = "vpToolStripMenuItem";
            this.vpToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.vpToolStripMenuItem.Text = "Venda de Produtos";
            this.vpToolStripMenuItem.Click += new System.EventHandler(this.colaboradorToolStripMenuItem_Click);
            // 
            // vsToolStripMenuItem
            // 
            this.vsToolStripMenuItem.Name = "vsToolStripMenuItem";
            this.vsToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.vsToolStripMenuItem.Text = "Venda de Serviços";
            this.vsToolStripMenuItem.Click += new System.EventHandler(this.vsToolStripMenuItem_Click);
            // 
            // agendamentosToolStripMenuItem
            // 
            this.agendamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendamentoLavagemToolStripMenuItem,
            this.agendamentoEstacionamentoToolStripMenuItem});
            this.agendamentosToolStripMenuItem.Name = "agendamentosToolStripMenuItem";
            this.agendamentosToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.agendamentosToolStripMenuItem.Text = "Agendamentos";
            // 
            // agendamentoLavagemToolStripMenuItem
            // 
            this.agendamentoLavagemToolStripMenuItem.Name = "agendamentoLavagemToolStripMenuItem";
            this.agendamentoLavagemToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.agendamentoLavagemToolStripMenuItem.Text = "Lavagem";
            this.agendamentoLavagemToolStripMenuItem.Click += new System.EventHandler(this.agendamentoLavagemToolStripMenuItem_Click);
            // 
            // agendamentoEstacionamentoToolStripMenuItem
            // 
            this.agendamentoEstacionamentoToolStripMenuItem.Name = "agendamentoEstacionamentoToolStripMenuItem";
            this.agendamentoEstacionamentoToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.agendamentoEstacionamentoToolStripMenuItem.Text = "Estacionamento";
            this.agendamentoEstacionamentoToolStripMenuItem.Click += new System.EventHandler(this.agendamentoEstacionamentoToolStripMenuItem_Click);
            // 
            // contaBancariaToolStripMenuItem
            // 
            this.contaBancariaToolStripMenuItem.Name = "contaBancariaToolStripMenuItem";
            this.contaBancariaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contaBancariaToolStripMenuItem.Text = "Conta Bancária";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1380, 833);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoLavagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoEstacionamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vagaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaBancariaToolStripMenuItem;
    }
}