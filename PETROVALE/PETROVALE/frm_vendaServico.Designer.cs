namespace PETROVALE
{
    partial class frm_vendaServico
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
            this.dtp_dataVs = new System.Windows.Forms.DateTimePicker();
            this.lbl_dataVs = new System.Windows.Forms.Label();
            this.txt_idClienteVs = new System.Windows.Forms.TextBox();
            this.lbl_idClienteVs = new System.Windows.Forms.Label();
            this.txt_idSerVs = new System.Windows.Forms.TextBox();
            this.lbl_idSerVs = new System.Windows.Forms.Label();
            this.txt_idVs = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_idFunVs = new System.Windows.Forms.TextBox();
            this.lbl_idFunVs = new System.Windows.Forms.Label();
            this.lbl_idVs = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_vendaServicos = new System.Windows.Forms.Label();
            this.btn_voltarVs = new System.Windows.Forms.Button();
            this.btn_consultarVs = new System.Windows.Forms.Button();
            this.btn_alterarVs = new System.Windows.Forms.Button();
            this.btn_deletarVs = new System.Windows.Forms.Button();
            this.btn_limparVs = new System.Windows.Forms.Button();
            this.btn_inserirVs = new System.Windows.Forms.Button();
            this.txt_combustivelVs = new System.Windows.Forms.TextBox();
            this.lbl_combustivelVs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_dataVs
            // 
            this.dtp_dataVs.Location = new System.Drawing.Point(56, 437);
            this.dtp_dataVs.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_dataVs.Name = "dtp_dataVs";
            this.dtp_dataVs.Size = new System.Drawing.Size(265, 22);
            this.dtp_dataVs.TabIndex = 154;
            // 
            // lbl_dataVs
            // 
            this.lbl_dataVs.AutoSize = true;
            this.lbl_dataVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataVs.Location = new System.Drawing.Point(52, 406);
            this.lbl_dataVs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dataVs.Name = "lbl_dataVs";
            this.lbl_dataVs.Size = new System.Drawing.Size(54, 24);
            this.lbl_dataVs.TabIndex = 153;
            this.lbl_dataVs.Text = "Data*";
            // 
            // txt_idClienteVs
            // 
            this.txt_idClienteVs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_idClienteVs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_idClienteVs.Location = new System.Drawing.Point(472, 293);
            this.txt_idClienteVs.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idClienteVs.Name = "txt_idClienteVs";
            this.txt_idClienteVs.Size = new System.Drawing.Size(113, 22);
            this.txt_idClienteVs.TabIndex = 152;
            // 
            // lbl_idClienteVs
            // 
            this.lbl_idClienteVs.AutoSize = true;
            this.lbl_idClienteVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idClienteVs.Location = new System.Drawing.Point(468, 261);
            this.lbl_idClienteVs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idClienteVs.Name = "lbl_idClienteVs";
            this.lbl_idClienteVs.Size = new System.Drawing.Size(121, 24);
            this.lbl_idClienteVs.TabIndex = 151;
            this.lbl_idClienteVs.Text = "ID do cliente*";
            // 
            // txt_idSerVs
            // 
            this.txt_idSerVs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_idSerVs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_idSerVs.Location = new System.Drawing.Point(267, 293);
            this.txt_idSerVs.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idSerVs.Name = "txt_idSerVs";
            this.txt_idSerVs.Size = new System.Drawing.Size(113, 22);
            this.txt_idSerVs.TabIndex = 150;
            // 
            // lbl_idSerVs
            // 
            this.lbl_idSerVs.AutoSize = true;
            this.lbl_idSerVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idSerVs.Location = new System.Drawing.Point(263, 261);
            this.lbl_idSerVs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idSerVs.Name = "lbl_idSerVs";
            this.lbl_idSerVs.Size = new System.Drawing.Size(126, 24);
            this.lbl_idSerVs.TabIndex = 149;
            this.lbl_idSerVs.Text = "ID do serviço*";
            // 
            // txt_idVs
            // 
            this.txt_idVs.Location = new System.Drawing.Point(56, 160);
            this.txt_idVs.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idVs.Name = "txt_idVs";
            this.txt_idVs.ReadOnly = true;
            this.txt_idVs.Size = new System.Drawing.Size(113, 22);
            this.txt_idVs.TabIndex = 146;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PETROVALE.Properties.Resources.Group_1251;
            this.pictureBox1.Location = new System.Drawing.Point(529, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 81);
            this.pictureBox1.TabIndex = 145;
            this.pictureBox1.TabStop = false;
            // 
            // txt_idFunVs
            // 
            this.txt_idFunVs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_idFunVs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_idFunVs.Location = new System.Drawing.Point(56, 293);
            this.txt_idFunVs.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idFunVs.Name = "txt_idFunVs";
            this.txt_idFunVs.Size = new System.Drawing.Size(113, 22);
            this.txt_idFunVs.TabIndex = 144;
            // 
            // lbl_idFunVs
            // 
            this.lbl_idFunVs.AutoSize = true;
            this.lbl_idFunVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idFunVs.Location = new System.Drawing.Point(52, 261);
            this.lbl_idFunVs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idFunVs.Name = "lbl_idFunVs";
            this.lbl_idFunVs.Size = new System.Drawing.Size(152, 24);
            this.lbl_idFunVs.TabIndex = 143;
            this.lbl_idFunVs.Text = "ID do funcionário";
            // 
            // lbl_idVs
            // 
            this.lbl_idVs.AutoSize = true;
            this.lbl_idVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idVs.Location = new System.Drawing.Point(52, 129);
            this.lbl_idVs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idVs.Name = "lbl_idVs";
            this.lbl_idVs.Size = new System.Drawing.Size(27, 24);
            this.lbl_idVs.TabIndex = 141;
            this.lbl_idVs.Text = "ID";
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
            this.dataGridView1.TabIndex = 142;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // lbl_vendaServicos
            // 
            this.lbl_vendaServicos.AutoSize = true;
            this.lbl_vendaServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendaServicos.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_vendaServicos.Location = new System.Drawing.Point(32, 16);
            this.lbl_vendaServicos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vendaServicos.Name = "lbl_vendaServicos";
            this.lbl_vendaServicos.Size = new System.Drawing.Size(225, 36);
            this.lbl_vendaServicos.TabIndex = 140;
            this.lbl_vendaServicos.Text = "Venda Serviços";
            // 
            // btn_voltarVs
            // 
            this.btn_voltarVs.BackColor = System.Drawing.Color.DarkGray;
            this.btn_voltarVs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltarVs.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltarVs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltarVs.Location = new System.Drawing.Point(1084, 722);
            this.btn_voltarVs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_voltarVs.Name = "btn_voltarVs";
            this.btn_voltarVs.Size = new System.Drawing.Size(139, 48);
            this.btn_voltarVs.TabIndex = 160;
            this.btn_voltarVs.Text = "Voltar";
            this.btn_voltarVs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_voltarVs.UseVisualStyleBackColor = false;
            this.btn_voltarVs.Click += new System.EventHandler(this.btn_voltarVs_Click);
            // 
            // btn_consultarVs
            // 
            this.btn_consultarVs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_consultarVs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultarVs.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarVs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consultarVs.Image = global::PETROVALE.Properties.Resources.search_sharp;
            this.btn_consultarVs.Location = new System.Drawing.Point(341, 722);
            this.btn_consultarVs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultarVs.Name = "btn_consultarVs";
            this.btn_consultarVs.Size = new System.Drawing.Size(139, 48);
            this.btn_consultarVs.TabIndex = 159;
            this.btn_consultarVs.Text = " Consultar";
            this.btn_consultarVs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_consultarVs.UseVisualStyleBackColor = false;
            this.btn_consultarVs.Click += new System.EventHandler(this.btn_consultarVs_Click);
            // 
            // btn_alterarVs
            // 
            this.btn_alterarVs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_alterarVs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterarVs.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarVs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_alterarVs.Image = global::PETROVALE.Properties.Resources.icons8_alterar_25;
            this.btn_alterarVs.Location = new System.Drawing.Point(508, 722);
            this.btn_alterarVs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_alterarVs.Name = "btn_alterarVs";
            this.btn_alterarVs.Size = new System.Drawing.Size(139, 48);
            this.btn_alterarVs.TabIndex = 158;
            this.btn_alterarVs.Text = " Alterar";
            this.btn_alterarVs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alterarVs.UseVisualStyleBackColor = false;
            this.btn_alterarVs.Click += new System.EventHandler(this.btn_alterarVs_Click);
            // 
            // btn_deletarVs
            // 
            this.btn_deletarVs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_deletarVs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletarVs.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletarVs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deletarVs.Image = global::PETROVALE.Properties.Resources.Vector__1_1;
            this.btn_deletarVs.Location = new System.Drawing.Point(677, 722);
            this.btn_deletarVs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deletarVs.Name = "btn_deletarVs";
            this.btn_deletarVs.Size = new System.Drawing.Size(139, 48);
            this.btn_deletarVs.TabIndex = 157;
            this.btn_deletarVs.Text = "  Deletar";
            this.btn_deletarVs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletarVs.UseVisualStyleBackColor = false;
            this.btn_deletarVs.Click += new System.EventHandler(this.btn_deletarVs_Click);
            // 
            // btn_limparVs
            // 
            this.btn_limparVs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_limparVs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparVs.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparVs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limparVs.Image = global::PETROVALE.Properties.Resources.Untitled_1__2_;
            this.btn_limparVs.Location = new System.Drawing.Point(844, 722);
            this.btn_limparVs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limparVs.Name = "btn_limparVs";
            this.btn_limparVs.Size = new System.Drawing.Size(139, 48);
            this.btn_limparVs.TabIndex = 156;
            this.btn_limparVs.Text = "  Limpar";
            this.btn_limparVs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limparVs.UseVisualStyleBackColor = false;
            this.btn_limparVs.Click += new System.EventHandler(this.btn_limparVs_Click);
            // 
            // btn_inserirVs
            // 
            this.btn_inserirVs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_inserirVs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserirVs.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserirVs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inserirVs.Image = global::PETROVALE.Properties.Resources.icons8_salvar_24;
            this.btn_inserirVs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inserirVs.Location = new System.Drawing.Point(175, 722);
            this.btn_inserirVs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inserirVs.Name = "btn_inserirVs";
            this.btn_inserirVs.Size = new System.Drawing.Size(139, 48);
            this.btn_inserirVs.TabIndex = 155;
            this.btn_inserirVs.Text = "  Inserir";
            this.btn_inserirVs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inserirVs.UseVisualStyleBackColor = false;
            this.btn_inserirVs.Click += new System.EventHandler(this.btn_inserirVs_Click);
            // 
            // txt_combustivelVs
            // 
            this.txt_combustivelVs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_combustivelVs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_combustivelVs.Location = new System.Drawing.Point(365, 437);
            this.txt_combustivelVs.Margin = new System.Windows.Forms.Padding(4);
            this.txt_combustivelVs.Name = "txt_combustivelVs";
            this.txt_combustivelVs.Size = new System.Drawing.Size(113, 22);
            this.txt_combustivelVs.TabIndex = 162;
            // 
            // lbl_combustivelVs
            // 
            this.lbl_combustivelVs.AutoSize = true;
            this.lbl_combustivelVs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_combustivelVs.Location = new System.Drawing.Point(361, 405);
            this.lbl_combustivelVs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_combustivelVs.Name = "lbl_combustivelVs";
            this.lbl_combustivelVs.Size = new System.Drawing.Size(240, 24);
            this.lbl_combustivelVs.TabIndex = 161;
            this.lbl_combustivelVs.Text = "Quantidade de combustível";
            // 
            // frm_vendaServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 833);
            this.Controls.Add(this.txt_combustivelVs);
            this.Controls.Add(this.lbl_combustivelVs);
            this.Controls.Add(this.btn_voltarVs);
            this.Controls.Add(this.btn_consultarVs);
            this.Controls.Add(this.btn_alterarVs);
            this.Controls.Add(this.btn_deletarVs);
            this.Controls.Add(this.btn_limparVs);
            this.Controls.Add(this.btn_inserirVs);
            this.Controls.Add(this.dtp_dataVs);
            this.Controls.Add(this.lbl_dataVs);
            this.Controls.Add(this.txt_idClienteVs);
            this.Controls.Add(this.lbl_idClienteVs);
            this.Controls.Add(this.txt_idSerVs);
            this.Controls.Add(this.lbl_idSerVs);
            this.Controls.Add(this.txt_idVs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_idFunVs);
            this.Controls.Add(this.lbl_idFunVs);
            this.Controls.Add(this.lbl_idVs);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_vendaServicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_vendaServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_vendaServico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_dataVs;
        private System.Windows.Forms.Label lbl_dataVs;
        private System.Windows.Forms.TextBox txt_idClienteVs;
        private System.Windows.Forms.Label lbl_idClienteVs;
        private System.Windows.Forms.TextBox txt_idSerVs;
        private System.Windows.Forms.Label lbl_idSerVs;
        private System.Windows.Forms.TextBox txt_idVs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_idFunVs;
        private System.Windows.Forms.Label lbl_idFunVs;
        private System.Windows.Forms.Label lbl_idVs;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_vendaServicos;
        private System.Windows.Forms.Button btn_voltarVs;
        private System.Windows.Forms.Button btn_consultarVs;
        private System.Windows.Forms.Button btn_alterarVs;
        private System.Windows.Forms.Button btn_deletarVs;
        private System.Windows.Forms.Button btn_limparVs;
        private System.Windows.Forms.Button btn_inserirVs;
        private System.Windows.Forms.TextBox txt_combustivelVs;
        private System.Windows.Forms.Label lbl_combustivelVs;
    }
}