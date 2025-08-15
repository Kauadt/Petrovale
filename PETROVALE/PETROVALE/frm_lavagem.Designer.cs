namespace PETROVALE
{
    partial class frm_lavagem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_idAl = new System.Windows.Forms.TextBox();
            this.lbl_dataAl = new System.Windows.Forms.Label();
            this.txt_idSerAl = new System.Windows.Forms.TextBox();
            this.lbl_idSerAl = new System.Windows.Forms.Label();
            this.txt_horarioAl = new System.Windows.Forms.TextBox();
            this.lbl_horarioAl = new System.Windows.Forms.Label();
            this.txt_placaAl = new System.Windows.Forms.TextBox();
            this.lbl_placaAl = new System.Windows.Forms.Label();
            this.lbl_idAl = new System.Windows.Forms.Label();
            this.lbl_agendamentoLavagem = new System.Windows.Forms.Label();
            this.btn_voltarAl = new System.Windows.Forms.Button();
            this.btn_consultarAl = new System.Windows.Forms.Button();
            this.btn_alterarAl = new System.Windows.Forms.Button();
            this.btn_deletarAl = new System.Windows.Forms.Button();
            this.btn_limparAl = new System.Windows.Forms.Button();
            this.btn_inserirAl = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_dataAl = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(709, 308);
            this.dataGridView1.TabIndex = 118;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // txt_idAl
            // 
            this.txt_idAl.Location = new System.Drawing.Point(56, 148);
            this.txt_idAl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idAl.Name = "txt_idAl";
            this.txt_idAl.ReadOnly = true;
            this.txt_idAl.Size = new System.Drawing.Size(113, 22);
            this.txt_idAl.TabIndex = 116;
            // 
            // lbl_dataAl
            // 
            this.lbl_dataAl.AutoSize = true;
            this.lbl_dataAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataAl.Location = new System.Drawing.Point(257, 198);
            this.lbl_dataAl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dataAl.Name = "lbl_dataAl";
            this.lbl_dataAl.Size = new System.Drawing.Size(54, 24);
            this.lbl_dataAl.TabIndex = 113;
            this.lbl_dataAl.Text = "Data*";
            // 
            // txt_idSerAl
            // 
            this.txt_idSerAl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_idSerAl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_idSerAl.Location = new System.Drawing.Point(56, 229);
            this.txt_idSerAl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idSerAl.Name = "txt_idSerAl";
            this.txt_idSerAl.Size = new System.Drawing.Size(153, 22);
            this.txt_idSerAl.TabIndex = 112;
            // 
            // lbl_idSerAl
            // 
            this.lbl_idSerAl.AutoSize = true;
            this.lbl_idSerAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idSerAl.Location = new System.Drawing.Point(52, 198);
            this.lbl_idSerAl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idSerAl.Name = "lbl_idSerAl";
            this.lbl_idSerAl.Size = new System.Drawing.Size(129, 24);
            this.lbl_idSerAl.TabIndex = 111;
            this.lbl_idSerAl.Text = "ID do Serviço*";
            // 
            // txt_horarioAl
            // 
            this.txt_horarioAl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_horarioAl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_horarioAl.Location = new System.Drawing.Point(477, 148);
            this.txt_horarioAl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_horarioAl.Name = "txt_horarioAl";
            this.txt_horarioAl.Size = new System.Drawing.Size(160, 22);
            this.txt_horarioAl.TabIndex = 110;
            this.txt_horarioAl.Text = "00:00";
            // 
            // lbl_horarioAl
            // 
            this.lbl_horarioAl.AutoSize = true;
            this.lbl_horarioAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horarioAl.Location = new System.Drawing.Point(473, 117);
            this.lbl_horarioAl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_horarioAl.Name = "lbl_horarioAl";
            this.lbl_horarioAl.Size = new System.Drawing.Size(79, 24);
            this.lbl_horarioAl.TabIndex = 109;
            this.lbl_horarioAl.Text = "Horário*";
            // 
            // txt_placaAl
            // 
            this.txt_placaAl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_placaAl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_placaAl.Location = new System.Drawing.Point(208, 148);
            this.txt_placaAl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_placaAl.Name = "txt_placaAl";
            this.txt_placaAl.Size = new System.Drawing.Size(220, 22);
            this.txt_placaAl.TabIndex = 108;
            // 
            // lbl_placaAl
            // 
            this.lbl_placaAl.AutoSize = true;
            this.lbl_placaAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placaAl.Location = new System.Drawing.Point(204, 117);
            this.lbl_placaAl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_placaAl.Name = "lbl_placaAl";
            this.lbl_placaAl.Size = new System.Drawing.Size(141, 24);
            this.lbl_placaAl.TabIndex = 107;
            this.lbl_placaAl.Text = "Placa do Carro*";
            // 
            // lbl_idAl
            // 
            this.lbl_idAl.AutoSize = true;
            this.lbl_idAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idAl.Location = new System.Drawing.Point(52, 117);
            this.lbl_idAl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idAl.Name = "lbl_idAl";
            this.lbl_idAl.Size = new System.Drawing.Size(27, 24);
            this.lbl_idAl.TabIndex = 106;
            this.lbl_idAl.Text = "ID";
            // 
            // lbl_agendamentoLavagem
            // 
            this.lbl_agendamentoLavagem.AutoSize = true;
            this.lbl_agendamentoLavagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agendamentoLavagem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_agendamentoLavagem.Location = new System.Drawing.Point(32, 16);
            this.lbl_agendamentoLavagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_agendamentoLavagem.Name = "lbl_agendamentoLavagem";
            this.lbl_agendamentoLavagem.Size = new System.Drawing.Size(328, 36);
            this.lbl_agendamentoLavagem.TabIndex = 105;
            this.lbl_agendamentoLavagem.Text = "Agendamento Lavagem";
            // 
            // btn_voltarAl
            // 
            this.btn_voltarAl.BackColor = System.Drawing.Color.DarkGray;
            this.btn_voltarAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltarAl.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltarAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltarAl.Location = new System.Drawing.Point(627, 727);
            this.btn_voltarAl.Margin = new System.Windows.Forms.Padding(4);
            this.btn_voltarAl.Name = "btn_voltarAl";
            this.btn_voltarAl.Size = new System.Drawing.Size(139, 48);
            this.btn_voltarAl.TabIndex = 124;
            this.btn_voltarAl.Text = "Voltar";
            this.btn_voltarAl.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_voltarAl.UseVisualStyleBackColor = false;
            this.btn_voltarAl.Click += new System.EventHandler(this.btn_voltarAg_Click);
            // 
            // btn_consultarAl
            // 
            this.btn_consultarAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_consultarAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultarAl.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consultarAl.Image = global::PETROVALE.Properties.Resources.search_sharp;
            this.btn_consultarAl.Location = new System.Drawing.Point(223, 658);
            this.btn_consultarAl.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultarAl.Name = "btn_consultarAl";
            this.btn_consultarAl.Size = new System.Drawing.Size(139, 48);
            this.btn_consultarAl.TabIndex = 123;
            this.btn_consultarAl.Text = " Consultar";
            this.btn_consultarAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_consultarAl.UseVisualStyleBackColor = false;
            this.btn_consultarAl.Click += new System.EventHandler(this.btn_consultarAg_Click);
            // 
            // btn_alterarAl
            // 
            this.btn_alterarAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_alterarAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterarAl.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_alterarAl.Image = global::PETROVALE.Properties.Resources.icons8_alterar_25;
            this.btn_alterarAl.Location = new System.Drawing.Point(389, 658);
            this.btn_alterarAl.Margin = new System.Windows.Forms.Padding(4);
            this.btn_alterarAl.Name = "btn_alterarAl";
            this.btn_alterarAl.Size = new System.Drawing.Size(139, 48);
            this.btn_alterarAl.TabIndex = 122;
            this.btn_alterarAl.Text = " Alterar";
            this.btn_alterarAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alterarAl.UseVisualStyleBackColor = false;
            this.btn_alterarAl.Click += new System.EventHandler(this.btn_alterarAg_Click);
            // 
            // btn_deletarAl
            // 
            this.btn_deletarAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_deletarAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletarAl.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletarAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deletarAl.Image = global::PETROVALE.Properties.Resources.Vector__1_1;
            this.btn_deletarAl.Location = new System.Drawing.Point(56, 727);
            this.btn_deletarAl.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deletarAl.Name = "btn_deletarAl";
            this.btn_deletarAl.Size = new System.Drawing.Size(139, 48);
            this.btn_deletarAl.TabIndex = 121;
            this.btn_deletarAl.Text = "  Deletar";
            this.btn_deletarAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletarAl.UseVisualStyleBackColor = false;
            this.btn_deletarAl.Click += new System.EventHandler(this.btn_deletarAg_Click);
            // 
            // btn_limparAl
            // 
            this.btn_limparAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_limparAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparAl.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limparAl.Image = global::PETROVALE.Properties.Resources.Untitled_1__2_;
            this.btn_limparAl.Location = new System.Drawing.Point(223, 727);
            this.btn_limparAl.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limparAl.Name = "btn_limparAl";
            this.btn_limparAl.Size = new System.Drawing.Size(139, 48);
            this.btn_limparAl.TabIndex = 120;
            this.btn_limparAl.Text = "  Limpar";
            this.btn_limparAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limparAl.UseVisualStyleBackColor = false;
            this.btn_limparAl.Click += new System.EventHandler(this.btn_limparAg_Click);
            // 
            // btn_inserirAl
            // 
            this.btn_inserirAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_inserirAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserirAl.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserirAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inserirAl.Image = global::PETROVALE.Properties.Resources.icons8_salvar_24;
            this.btn_inserirAl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inserirAl.Location = new System.Drawing.Point(56, 658);
            this.btn_inserirAl.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inserirAl.Name = "btn_inserirAl";
            this.btn_inserirAl.Size = new System.Drawing.Size(139, 48);
            this.btn_inserirAl.TabIndex = 119;
            this.btn_inserirAl.Text = "  Inserir";
            this.btn_inserirAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inserirAl.UseVisualStyleBackColor = false;
            this.btn_inserirAl.Click += new System.EventHandler(this.btn_inserirAg_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PETROVALE.Properties.Resources.Rectangle_30__2_;
            this.pictureBox2.Location = new System.Drawing.Point(888, -11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(499, 848);
            this.pictureBox2.TabIndex = 117;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PETROVALE.Properties.Resources.Group_1251;
            this.pictureBox1.Location = new System.Drawing.Point(529, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 81);
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_dataAl
            // 
            this.dtp_dataAl.Location = new System.Drawing.Point(261, 229);
            this.dtp_dataAl.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_dataAl.Name = "dtp_dataAl";
            this.dtp_dataAl.Size = new System.Drawing.Size(265, 22);
            this.dtp_dataAl.TabIndex = 146;
            this.dtp_dataAl.ValueChanged += new System.EventHandler(this.dtp_dataAl_ValueChanged);
            // 
            // frm_lavagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 833);
            this.Controls.Add(this.dtp_dataAl);
            this.Controls.Add(this.btn_voltarAl);
            this.Controls.Add(this.btn_consultarAl);
            this.Controls.Add(this.btn_alterarAl);
            this.Controls.Add(this.btn_deletarAl);
            this.Controls.Add(this.btn_limparAl);
            this.Controls.Add(this.btn_inserirAl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_idAl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_dataAl);
            this.Controls.Add(this.txt_idSerAl);
            this.Controls.Add(this.lbl_idSerAl);
            this.Controls.Add(this.txt_horarioAl);
            this.Controls.Add(this.lbl_horarioAl);
            this.Controls.Add(this.txt_placaAl);
            this.Controls.Add(this.lbl_placaAl);
            this.Controls.Add(this.lbl_idAl);
            this.Controls.Add(this.lbl_agendamentoLavagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_lavagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_idAl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_dataAl;
        private System.Windows.Forms.TextBox txt_idSerAl;
        private System.Windows.Forms.Label lbl_idSerAl;
        private System.Windows.Forms.TextBox txt_horarioAl;
        private System.Windows.Forms.Label lbl_horarioAl;
        private System.Windows.Forms.TextBox txt_placaAl;
        private System.Windows.Forms.Label lbl_placaAl;
        private System.Windows.Forms.Label lbl_idAl;
        private System.Windows.Forms.Label lbl_agendamentoLavagem;
        private System.Windows.Forms.Button btn_voltarAl;
        private System.Windows.Forms.Button btn_consultarAl;
        private System.Windows.Forms.Button btn_alterarAl;
        private System.Windows.Forms.Button btn_deletarAl;
        private System.Windows.Forms.Button btn_limparAl;
        private System.Windows.Forms.Button btn_inserirAl;
        private System.Windows.Forms.DateTimePicker dtp_dataAl;
    }
}