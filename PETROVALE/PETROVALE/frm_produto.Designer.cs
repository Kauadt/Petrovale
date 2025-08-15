namespace PETROVALE
{
    partial class frm_produto
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
            this.txt_idProd = new System.Windows.Forms.TextBox();
            this.txt_precoProd = new System.Windows.Forms.TextBox();
            this.lbl_precoProd = new System.Windows.Forms.Label();
            this.txt_nomeProd = new System.Windows.Forms.TextBox();
            this.lbl_nomeProd = new System.Windows.Forms.Label();
            this.txt_descontoProd = new System.Windows.Forms.TextBox();
            this.lbl_descontoProd = new System.Windows.Forms.Label();
            this.lbl_idProd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_cadastroFuncionario = new System.Windows.Forms.Label();
            this.btn_voltarProd = new System.Windows.Forms.Button();
            this.lbl_fotoProd = new System.Windows.Forms.Label();
            this.txt_descricaoProd = new System.Windows.Forms.TextBox();
            this.lbl_descricaoProd = new System.Windows.Forms.Label();
            this.carregarfoto = new System.Windows.Forms.OpenFileDialog();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.btn_consultarProd = new System.Windows.Forms.Button();
            this.btn_alterarProd = new System.Windows.Forms.Button();
            this.btn_deletarProd = new System.Windows.Forms.Button();
            this.btn_limparProd = new System.Windows.Forms.Button();
            this.btn_inserirProd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_idProd
            // 
            this.txt_idProd.Location = new System.Drawing.Point(56, 160);
            this.txt_idProd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idProd.Name = "txt_idProd";
            this.txt_idProd.ReadOnly = true;
            this.txt_idProd.Size = new System.Drawing.Size(113, 22);
            this.txt_idProd.TabIndex = 96;
            // 
            // txt_precoProd
            // 
            this.txt_precoProd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_precoProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_precoProd.Location = new System.Drawing.Point(324, 292);
            this.txt_precoProd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precoProd.Name = "txt_precoProd";
            this.txt_precoProd.Size = new System.Drawing.Size(220, 22);
            this.txt_precoProd.TabIndex = 94;
            // 
            // lbl_precoProd
            // 
            this.lbl_precoProd.AutoSize = true;
            this.lbl_precoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precoProd.Location = new System.Drawing.Point(320, 261);
            this.lbl_precoProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precoProd.Name = "lbl_precoProd";
            this.lbl_precoProd.Size = new System.Drawing.Size(67, 24);
            this.lbl_precoProd.TabIndex = 93;
            this.lbl_precoProd.Text = "Preço*";
            // 
            // txt_nomeProd
            // 
            this.txt_nomeProd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_nomeProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_nomeProd.Location = new System.Drawing.Point(56, 292);
            this.txt_nomeProd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomeProd.Name = "txt_nomeProd";
            this.txt_nomeProd.Size = new System.Drawing.Size(221, 22);
            this.txt_nomeProd.TabIndex = 92;
            // 
            // lbl_nomeProd
            // 
            this.lbl_nomeProd.AutoSize = true;
            this.lbl_nomeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeProd.Location = new System.Drawing.Point(52, 261);
            this.lbl_nomeProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomeProd.Name = "lbl_nomeProd";
            this.lbl_nomeProd.Size = new System.Drawing.Size(167, 24);
            this.lbl_nomeProd.TabIndex = 91;
            this.lbl_nomeProd.Text = "Nome do Preduto*";
            // 
            // txt_descontoProd
            // 
            this.txt_descontoProd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_descontoProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_descontoProd.Location = new System.Drawing.Point(208, 160);
            this.txt_descontoProd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descontoProd.Name = "txt_descontoProd";
            this.txt_descontoProd.Size = new System.Drawing.Size(220, 22);
            this.txt_descontoProd.TabIndex = 88;
            // 
            // lbl_descontoProd
            // 
            this.lbl_descontoProd.AutoSize = true;
            this.lbl_descontoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descontoProd.Location = new System.Drawing.Point(204, 129);
            this.lbl_descontoProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descontoProd.Name = "lbl_descontoProd";
            this.lbl_descontoProd.Size = new System.Drawing.Size(122, 24);
            this.lbl_descontoProd.TabIndex = 87;
            this.lbl_descontoProd.Text = "Desconto (%)";
            // 
            // lbl_idProd
            // 
            this.lbl_idProd.AutoSize = true;
            this.lbl_idProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idProd.Location = new System.Drawing.Point(52, 129);
            this.lbl_idProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idProd.Name = "lbl_idProd";
            this.lbl_idProd.Size = new System.Drawing.Size(27, 24);
            this.lbl_idProd.TabIndex = 84;
            this.lbl_idProd.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(720, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(593, 559);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // lbl_cadastroFuncionario
            // 
            this.lbl_cadastroFuncionario.AutoSize = true;
            this.lbl_cadastroFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastroFuncionario.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_cadastroFuncionario.Location = new System.Drawing.Point(32, 16);
            this.lbl_cadastroFuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cadastroFuncionario.Name = "lbl_cadastroFuncionario";
            this.lbl_cadastroFuncionario.Size = new System.Drawing.Size(264, 36);
            this.lbl_cadastroFuncionario.TabIndex = 83;
            this.lbl_cadastroFuncionario.Text = "Cadastro Produtos";
            // 
            // btn_voltarProd
            // 
            this.btn_voltarProd.BackColor = System.Drawing.Color.DarkGray;
            this.btn_voltarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltarProd.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltarProd.Location = new System.Drawing.Point(1084, 722);
            this.btn_voltarProd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_voltarProd.Name = "btn_voltarProd";
            this.btn_voltarProd.Size = new System.Drawing.Size(139, 48);
            this.btn_voltarProd.TabIndex = 108;
            this.btn_voltarProd.Text = "Voltar";
            this.btn_voltarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_voltarProd.UseVisualStyleBackColor = false;
            this.btn_voltarProd.Click += new System.EventHandler(this.btn_voltarProd_Click);
            // 
            // lbl_fotoProd
            // 
            this.lbl_fotoProd.AutoSize = true;
            this.lbl_fotoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fotoProd.Location = new System.Drawing.Point(384, 398);
            this.lbl_fotoProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fotoProd.Name = "lbl_fotoProd";
            this.lbl_fotoProd.Size = new System.Drawing.Size(55, 24);
            this.lbl_fotoProd.TabIndex = 111;
            this.lbl_fotoProd.Text = "Foto*";
            // 
            // txt_descricaoProd
            // 
            this.txt_descricaoProd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_descricaoProd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_descricaoProd.Location = new System.Drawing.Point(57, 428);
            this.txt_descricaoProd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descricaoProd.Multiline = true;
            this.txt_descricaoProd.Name = "txt_descricaoProd";
            this.txt_descricaoProd.Size = new System.Drawing.Size(279, 245);
            this.txt_descricaoProd.TabIndex = 110;
            // 
            // lbl_descricaoProd
            // 
            this.lbl_descricaoProd.AutoSize = true;
            this.lbl_descricaoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descricaoProd.Location = new System.Drawing.Point(53, 398);
            this.lbl_descricaoProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descricaoProd.Name = "lbl_descricaoProd";
            this.lbl_descricaoProd.Size = new System.Drawing.Size(101, 24);
            this.lbl_descricaoProd.TabIndex = 109;
            this.lbl_descricaoProd.Text = "Descrição*";
            // 
            // carregarfoto
            // 
            this.carregarfoto.FileName = "carregarfoto";
            // 
            // picturebox
            // 
            this.picturebox.BackgroundImage = global::PETROVALE.Properties.Resources.Frame_35;
            this.picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox.Location = new System.Drawing.Point(388, 423);
            this.picturebox.Margin = new System.Windows.Forms.Padding(4);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(279, 246);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox.TabIndex = 112;
            this.picturebox.TabStop = false;
            this.picturebox.Click += new System.EventHandler(this.picturebox_Click);
            // 
            // btn_consultarProd
            // 
            this.btn_consultarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_consultarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultarProd.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consultarProd.Image = global::PETROVALE.Properties.Resources.search_sharp;
            this.btn_consultarProd.Location = new System.Drawing.Point(341, 722);
            this.btn_consultarProd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultarProd.Name = "btn_consultarProd";
            this.btn_consultarProd.Size = new System.Drawing.Size(139, 48);
            this.btn_consultarProd.TabIndex = 107;
            this.btn_consultarProd.Text = " Consultar";
            this.btn_consultarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_consultarProd.UseVisualStyleBackColor = false;
            this.btn_consultarProd.Click += new System.EventHandler(this.btn_consultarProd_Click);
            // 
            // btn_alterarProd
            // 
            this.btn_alterarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_alterarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterarProd.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_alterarProd.Image = global::PETROVALE.Properties.Resources.icons8_alterar_25;
            this.btn_alterarProd.Location = new System.Drawing.Point(508, 722);
            this.btn_alterarProd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_alterarProd.Name = "btn_alterarProd";
            this.btn_alterarProd.Size = new System.Drawing.Size(139, 48);
            this.btn_alterarProd.TabIndex = 106;
            this.btn_alterarProd.Text = " Alterar";
            this.btn_alterarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alterarProd.UseVisualStyleBackColor = false;
            this.btn_alterarProd.Click += new System.EventHandler(this.btn_alterarProd_Click);
            // 
            // btn_deletarProd
            // 
            this.btn_deletarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_deletarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletarProd.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deletarProd.Image = global::PETROVALE.Properties.Resources.Vector__1_1;
            this.btn_deletarProd.Location = new System.Drawing.Point(677, 722);
            this.btn_deletarProd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deletarProd.Name = "btn_deletarProd";
            this.btn_deletarProd.Size = new System.Drawing.Size(139, 48);
            this.btn_deletarProd.TabIndex = 105;
            this.btn_deletarProd.Text = "  Deletar";
            this.btn_deletarProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletarProd.UseVisualStyleBackColor = false;
            this.btn_deletarProd.Click += new System.EventHandler(this.btn_deletarProd_Click);
            // 
            // btn_limparProd
            // 
            this.btn_limparProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_limparProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparProd.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limparProd.Image = global::PETROVALE.Properties.Resources.Untitled_1__2_;
            this.btn_limparProd.Location = new System.Drawing.Point(844, 722);
            this.btn_limparProd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limparProd.Name = "btn_limparProd";
            this.btn_limparProd.Size = new System.Drawing.Size(139, 48);
            this.btn_limparProd.TabIndex = 104;
            this.btn_limparProd.Text = "  Limpar";
            this.btn_limparProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limparProd.UseVisualStyleBackColor = false;
            this.btn_limparProd.Click += new System.EventHandler(this.btn_limparProd_Click);
            // 
            // btn_inserirProd
            // 
            this.btn_inserirProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_inserirProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserirProd.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserirProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inserirProd.Image = global::PETROVALE.Properties.Resources.icons8_salvar_24;
            this.btn_inserirProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inserirProd.Location = new System.Drawing.Point(175, 722);
            this.btn_inserirProd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inserirProd.Name = "btn_inserirProd";
            this.btn_inserirProd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_inserirProd.Size = new System.Drawing.Size(139, 48);
            this.btn_inserirProd.TabIndex = 103;
            this.btn_inserirProd.Text = "  Inserir";
            this.btn_inserirProd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inserirProd.UseVisualStyleBackColor = false;
            this.btn_inserirProd.Click += new System.EventHandler(this.btn_inserirProd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PETROVALE.Properties.Resources.Group_1251;
            this.pictureBox1.Location = new System.Drawing.Point(529, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 81);
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // frm_produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 833);
            this.Controls.Add(this.picturebox);
            this.Controls.Add(this.lbl_fotoProd);
            this.Controls.Add(this.txt_descricaoProd);
            this.Controls.Add(this.lbl_descricaoProd);
            this.Controls.Add(this.btn_voltarProd);
            this.Controls.Add(this.btn_consultarProd);
            this.Controls.Add(this.btn_alterarProd);
            this.Controls.Add(this.btn_deletarProd);
            this.Controls.Add(this.btn_limparProd);
            this.Controls.Add(this.btn_inserirProd);
            this.Controls.Add(this.txt_idProd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_precoProd);
            this.Controls.Add(this.lbl_precoProd);
            this.Controls.Add(this.txt_nomeProd);
            this.Controls.Add(this.lbl_nomeProd);
            this.Controls.Add(this.txt_descontoProd);
            this.Controls.Add(this.lbl_descontoProd);
            this.Controls.Add(this.lbl_idProd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_cadastroFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_idProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_precoProd;
        private System.Windows.Forms.Label lbl_precoProd;
        private System.Windows.Forms.TextBox txt_nomeProd;
        private System.Windows.Forms.Label lbl_nomeProd;
        private System.Windows.Forms.TextBox txt_descontoProd;
        private System.Windows.Forms.Label lbl_descontoProd;
        private System.Windows.Forms.Label lbl_idProd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_cadastroFuncionario;
        private System.Windows.Forms.Button btn_voltarProd;
        private System.Windows.Forms.Button btn_consultarProd;
        private System.Windows.Forms.Button btn_alterarProd;
        private System.Windows.Forms.Button btn_deletarProd;
        private System.Windows.Forms.Button btn_limparProd;
        private System.Windows.Forms.Button btn_inserirProd;
        private System.Windows.Forms.Label lbl_fotoProd;
        private System.Windows.Forms.TextBox txt_descricaoProd;
        private System.Windows.Forms.Label lbl_descricaoProd;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.OpenFileDialog carregarfoto;
    }
}