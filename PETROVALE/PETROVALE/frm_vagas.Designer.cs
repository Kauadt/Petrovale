namespace PETROVALE
{
    partial class frm_vagas
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
            this.cbo_statusVagas = new System.Windows.Forms.ComboBox();
            this.txt_idVagas = new System.Windows.Forms.TextBox();
            this.lbl_statusVagas = new System.Windows.Forms.Label();
            this.txt_idEsVagas = new System.Windows.Forms.TextBox();
            this.lbl_idEsVagas = new System.Windows.Forms.Label();
            this.txt_numeroVagas = new System.Windows.Forms.TextBox();
            this.lbl_numeroVagas = new System.Windows.Forms.Label();
            this.lbl_idVagas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_agendamentoEs = new System.Windows.Forms.Label();
            this.btn_voltarVagas = new System.Windows.Forms.Button();
            this.btn_consultarVagas = new System.Windows.Forms.Button();
            this.btn_alterarVagas = new System.Windows.Forms.Button();
            this.btn_deletarVagas = new System.Windows.Forms.Button();
            this.btn_limparVagas = new System.Windows.Forms.Button();
            this.btn_inserirVagas = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_statusVagas
            // 
            this.cbo_statusVagas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_statusVagas.FormattingEnabled = true;
            this.cbo_statusVagas.Items.AddRange(new object[] {
            "Ocupado",
            "Vago"});
            this.cbo_statusVagas.Location = new System.Drawing.Point(311, 230);
            this.cbo_statusVagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_statusVagas.Name = "cbo_statusVagas";
            this.cbo_statusVagas.Size = new System.Drawing.Size(179, 24);
            this.cbo_statusVagas.TabIndex = 150;
            this.cbo_statusVagas.SelectedIndexChanged += new System.EventHandler(this.cbo_statusEs_SelectedIndexChanged);
            // 
            // txt_idVagas
            // 
            this.txt_idVagas.Location = new System.Drawing.Point(56, 148);
            this.txt_idVagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idVagas.Name = "txt_idVagas";
            this.txt_idVagas.ReadOnly = true;
            this.txt_idVagas.Size = new System.Drawing.Size(113, 22);
            this.txt_idVagas.TabIndex = 149;
            // 
            // lbl_statusVagas
            // 
            this.lbl_statusVagas.AutoSize = true;
            this.lbl_statusVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_statusVagas.Location = new System.Drawing.Point(307, 198);
            this.lbl_statusVagas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_statusVagas.Name = "lbl_statusVagas";
            this.lbl_statusVagas.Size = new System.Drawing.Size(67, 24);
            this.lbl_statusVagas.TabIndex = 148;
            this.lbl_statusVagas.Text = "Status*";
            this.lbl_statusVagas.Click += new System.EventHandler(this.lbl_statusEs_Click);
            // 
            // txt_idEsVagas
            // 
            this.txt_idEsVagas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_idEsVagas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_idEsVagas.Location = new System.Drawing.Point(56, 230);
            this.txt_idEsVagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idEsVagas.Name = "txt_idEsVagas";
            this.txt_idEsVagas.Size = new System.Drawing.Size(143, 22);
            this.txt_idEsVagas.TabIndex = 147;
            // 
            // lbl_idEsVagas
            // 
            this.lbl_idEsVagas.AutoSize = true;
            this.lbl_idEsVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idEsVagas.Location = new System.Drawing.Point(52, 198);
            this.lbl_idEsVagas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idEsVagas.Name = "lbl_idEsVagas";
            this.lbl_idEsVagas.Size = new System.Drawing.Size(201, 24);
            this.lbl_idEsVagas.TabIndex = 146;
            this.lbl_idEsVagas.Text = "ID do Estacionamento*";
            // 
            // txt_numeroVagas
            // 
            this.txt_numeroVagas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_numeroVagas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_numeroVagas.Location = new System.Drawing.Point(208, 148);
            this.txt_numeroVagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_numeroVagas.Name = "txt_numeroVagas";
            this.txt_numeroVagas.Size = new System.Drawing.Size(220, 22);
            this.txt_numeroVagas.TabIndex = 143;
            // 
            // lbl_numeroVagas
            // 
            this.lbl_numeroVagas.AutoSize = true;
            this.lbl_numeroVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numeroVagas.Location = new System.Drawing.Point(204, 117);
            this.lbl_numeroVagas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numeroVagas.Name = "lbl_numeroVagas";
            this.lbl_numeroVagas.Size = new System.Drawing.Size(161, 24);
            this.lbl_numeroVagas.TabIndex = 142;
            this.lbl_numeroVagas.Text = "Número da Vaga*";
            // 
            // lbl_idVagas
            // 
            this.lbl_idVagas.AutoSize = true;
            this.lbl_idVagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idVagas.Location = new System.Drawing.Point(52, 117);
            this.lbl_idVagas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idVagas.Name = "lbl_idVagas";
            this.lbl_idVagas.Size = new System.Drawing.Size(27, 24);
            this.lbl_idVagas.TabIndex = 141;
            this.lbl_idVagas.Text = "ID";
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
            this.dataGridView1.Location = new System.Drawing.Point(56, 293);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(709, 308);
            this.dataGridView1.TabIndex = 140;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // lbl_agendamentoEs
            // 
            this.lbl_agendamentoEs.AutoSize = true;
            this.lbl_agendamentoEs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agendamentoEs.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_agendamentoEs.Location = new System.Drawing.Point(32, 16);
            this.lbl_agendamentoEs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_agendamentoEs.Name = "lbl_agendamentoEs";
            this.lbl_agendamentoEs.Size = new System.Drawing.Size(228, 36);
            this.lbl_agendamentoEs.TabIndex = 137;
            this.lbl_agendamentoEs.Text = "Cadastro Vagas";
            // 
            // btn_voltarVagas
            // 
            this.btn_voltarVagas.BackColor = System.Drawing.Color.DarkGray;
            this.btn_voltarVagas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltarVagas.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltarVagas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltarVagas.Location = new System.Drawing.Point(627, 727);
            this.btn_voltarVagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_voltarVagas.Name = "btn_voltarVagas";
            this.btn_voltarVagas.Size = new System.Drawing.Size(139, 48);
            this.btn_voltarVagas.TabIndex = 156;
            this.btn_voltarVagas.Text = "Voltar";
            this.btn_voltarVagas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_voltarVagas.UseVisualStyleBackColor = false;
            this.btn_voltarVagas.Click += new System.EventHandler(this.btn_voltarVagas_Click);
            // 
            // btn_consultarVagas
            // 
            this.btn_consultarVagas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_consultarVagas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultarVagas.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarVagas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consultarVagas.Image = global::PETROVALE.Properties.Resources.search_sharp;
            this.btn_consultarVagas.Location = new System.Drawing.Point(223, 658);
            this.btn_consultarVagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_consultarVagas.Name = "btn_consultarVagas";
            this.btn_consultarVagas.Size = new System.Drawing.Size(139, 48);
            this.btn_consultarVagas.TabIndex = 155;
            this.btn_consultarVagas.Text = " Consultar";
            this.btn_consultarVagas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_consultarVagas.UseVisualStyleBackColor = false;
            this.btn_consultarVagas.Click += new System.EventHandler(this.btn_consultarVagas_Click);
            // 
            // btn_alterarVagas
            // 
            this.btn_alterarVagas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_alterarVagas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterarVagas.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarVagas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_alterarVagas.Image = global::PETROVALE.Properties.Resources.icons8_alterar_25;
            this.btn_alterarVagas.Location = new System.Drawing.Point(389, 658);
            this.btn_alterarVagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_alterarVagas.Name = "btn_alterarVagas";
            this.btn_alterarVagas.Size = new System.Drawing.Size(139, 48);
            this.btn_alterarVagas.TabIndex = 154;
            this.btn_alterarVagas.Text = " Alterar";
            this.btn_alterarVagas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alterarVagas.UseVisualStyleBackColor = false;
            this.btn_alterarVagas.Click += new System.EventHandler(this.btn_alterarVagas_Click);
            // 
            // btn_deletarVagas
            // 
            this.btn_deletarVagas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_deletarVagas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletarVagas.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletarVagas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deletarVagas.Image = global::PETROVALE.Properties.Resources.Vector__1_1;
            this.btn_deletarVagas.Location = new System.Drawing.Point(56, 727);
            this.btn_deletarVagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_deletarVagas.Name = "btn_deletarVagas";
            this.btn_deletarVagas.Size = new System.Drawing.Size(139, 48);
            this.btn_deletarVagas.TabIndex = 153;
            this.btn_deletarVagas.Text = "  Deletar";
            this.btn_deletarVagas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletarVagas.UseVisualStyleBackColor = false;
            this.btn_deletarVagas.Click += new System.EventHandler(this.btn_deletarVagas_Click);
            // 
            // btn_limparVagas
            // 
            this.btn_limparVagas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_limparVagas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparVagas.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparVagas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limparVagas.Image = global::PETROVALE.Properties.Resources.Untitled_1__2_;
            this.btn_limparVagas.Location = new System.Drawing.Point(223, 727);
            this.btn_limparVagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_limparVagas.Name = "btn_limparVagas";
            this.btn_limparVagas.Size = new System.Drawing.Size(139, 48);
            this.btn_limparVagas.TabIndex = 152;
            this.btn_limparVagas.Text = "  Limpar";
            this.btn_limparVagas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limparVagas.UseVisualStyleBackColor = false;
            this.btn_limparVagas.Click += new System.EventHandler(this.btn_limparVagas_Click);
            // 
            // btn_inserirVagas
            // 
            this.btn_inserirVagas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_inserirVagas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserirVagas.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserirVagas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inserirVagas.Image = global::PETROVALE.Properties.Resources.icons8_salvar_24;
            this.btn_inserirVagas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inserirVagas.Location = new System.Drawing.Point(56, 658);
            this.btn_inserirVagas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_inserirVagas.Name = "btn_inserirVagas";
            this.btn_inserirVagas.Size = new System.Drawing.Size(139, 48);
            this.btn_inserirVagas.TabIndex = 151;
            this.btn_inserirVagas.Text = "  Inserir";
            this.btn_inserirVagas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inserirVagas.UseVisualStyleBackColor = false;
            this.btn_inserirVagas.Click += new System.EventHandler(this.btn_inserirVagas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PETROVALE.Properties.Resources.pexels_alex_akulov_18501358_1__1_2;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox2.Location = new System.Drawing.Point(888, -11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(499, 848);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 139;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PETROVALE.Properties.Resources.Group_1251;
            this.pictureBox1.Location = new System.Drawing.Point(529, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 81);
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // frm_vagas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 833);
            this.Controls.Add(this.btn_voltarVagas);
            this.Controls.Add(this.btn_consultarVagas);
            this.Controls.Add(this.btn_alterarVagas);
            this.Controls.Add(this.btn_deletarVagas);
            this.Controls.Add(this.btn_limparVagas);
            this.Controls.Add(this.btn_inserirVagas);
            this.Controls.Add(this.cbo_statusVagas);
            this.Controls.Add(this.txt_idVagas);
            this.Controls.Add(this.lbl_statusVagas);
            this.Controls.Add(this.txt_idEsVagas);
            this.Controls.Add(this.lbl_idEsVagas);
            this.Controls.Add(this.txt_numeroVagas);
            this.Controls.Add(this.lbl_numeroVagas);
            this.Controls.Add(this.lbl_idVagas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_agendamentoEs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_vagas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_vagas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_statusVagas;
        private System.Windows.Forms.TextBox txt_idVagas;
        private System.Windows.Forms.Label lbl_statusVagas;
        private System.Windows.Forms.TextBox txt_idEsVagas;
        private System.Windows.Forms.Label lbl_idEsVagas;
        private System.Windows.Forms.TextBox txt_numeroVagas;
        private System.Windows.Forms.Label lbl_numeroVagas;
        private System.Windows.Forms.Label lbl_idVagas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_agendamentoEs;
        private System.Windows.Forms.Button btn_voltarVagas;
        private System.Windows.Forms.Button btn_consultarVagas;
        private System.Windows.Forms.Button btn_alterarVagas;
        private System.Windows.Forms.Button btn_deletarVagas;
        private System.Windows.Forms.Button btn_limparVagas;
        private System.Windows.Forms.Button btn_inserirVagas;
    }
}