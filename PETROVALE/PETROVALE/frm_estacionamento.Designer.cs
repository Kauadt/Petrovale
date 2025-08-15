namespace PETROVALE
{
    partial class frm_estacionamento
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
            this.lbl_agendamentoEs = new System.Windows.Forms.Label();
            this.btn_voltarAe = new System.Windows.Forms.Button();
            this.txt_idAe = new System.Windows.Forms.TextBox();
            this.txt_idSerAe = new System.Windows.Forms.TextBox();
            this.lbl_idSerAe = new System.Windows.Forms.Label();
            this.txt_tempoAe = new System.Windows.Forms.TextBox();
            this.lbl_tempoAe = new System.Windows.Forms.Label();
            this.txt_placaAe = new System.Windows.Forms.TextBox();
            this.lbl_placaAe = new System.Windows.Forms.Label();
            this.lbl_idAe = new System.Windows.Forms.Label();
            this.btn_consultarAe = new System.Windows.Forms.Button();
            this.btn_alterarAe = new System.Windows.Forms.Button();
            this.btn_deletarAe = new System.Windows.Forms.Button();
            this.btn_limparAe = new System.Windows.Forms.Button();
            this.btn_inserirAe = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_dataAe = new System.Windows.Forms.Label();
            this.txt_horarioAe = new System.Windows.Forms.TextBox();
            this.lbl_horarioAe = new System.Windows.Forms.Label();
            this.dtp_dataAe = new System.Windows.Forms.DateTimePicker();
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
            this.dataGridView1.Location = new System.Drawing.Point(56, 298);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(709, 302);
            this.dataGridView1.TabIndex = 118;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.lbl_agendamentoEs.Size = new System.Drawing.Size(420, 36);
            this.lbl_agendamentoEs.TabIndex = 105;
            this.lbl_agendamentoEs.Text = "Agendamento Estacionamento";
            // 
            // btn_voltarAe
            // 
            this.btn_voltarAe.BackColor = System.Drawing.Color.DarkGray;
            this.btn_voltarAe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltarAe.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltarAe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltarAe.Location = new System.Drawing.Point(627, 727);
            this.btn_voltarAe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_voltarAe.Name = "btn_voltarAe";
            this.btn_voltarAe.Size = new System.Drawing.Size(139, 48);
            this.btn_voltarAe.TabIndex = 124;
            this.btn_voltarAe.Text = "Voltar";
            this.btn_voltarAe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_voltarAe.UseVisualStyleBackColor = false;
            this.btn_voltarAe.Click += new System.EventHandler(this.btn_voltarEs_Click);
            // 
            // txt_idAe
            // 
            this.txt_idAe.Location = new System.Drawing.Point(56, 148);
            this.txt_idAe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idAe.Name = "txt_idAe";
            this.txt_idAe.ReadOnly = true;
            this.txt_idAe.Size = new System.Drawing.Size(113, 22);
            this.txt_idAe.TabIndex = 134;
            // 
            // txt_idSerAe
            // 
            this.txt_idSerAe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_idSerAe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_idSerAe.Location = new System.Drawing.Point(560, 231);
            this.txt_idSerAe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idSerAe.Name = "txt_idSerAe";
            this.txt_idSerAe.Size = new System.Drawing.Size(153, 22);
            this.txt_idSerAe.TabIndex = 132;
            // 
            // lbl_idSerAe
            // 
            this.lbl_idSerAe.AutoSize = true;
            this.lbl_idSerAe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idSerAe.Location = new System.Drawing.Point(556, 201);
            this.lbl_idSerAe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idSerAe.Name = "lbl_idSerAe";
            this.lbl_idSerAe.Size = new System.Drawing.Size(129, 24);
            this.lbl_idSerAe.TabIndex = 131;
            this.lbl_idSerAe.Text = "ID do Serviço*";
            // 
            // txt_tempoAe
            // 
            this.txt_tempoAe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_tempoAe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_tempoAe.Location = new System.Drawing.Point(461, 148);
            this.txt_tempoAe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tempoAe.Name = "txt_tempoAe";
            this.txt_tempoAe.Size = new System.Drawing.Size(116, 22);
            this.txt_tempoAe.TabIndex = 130;
            this.txt_tempoAe.Text = "00:00";
            // 
            // lbl_tempoAe
            // 
            this.lbl_tempoAe.AutoSize = true;
            this.lbl_tempoAe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempoAe.Location = new System.Drawing.Point(457, 117);
            this.lbl_tempoAe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tempoAe.Name = "lbl_tempoAe";
            this.lbl_tempoAe.Size = new System.Drawing.Size(78, 24);
            this.lbl_tempoAe.TabIndex = 129;
            this.lbl_tempoAe.Text = "Tempo*";
            // 
            // txt_placaAe
            // 
            this.txt_placaAe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_placaAe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_placaAe.Location = new System.Drawing.Point(203, 148);
            this.txt_placaAe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_placaAe.Name = "txt_placaAe";
            this.txt_placaAe.Size = new System.Drawing.Size(220, 22);
            this.txt_placaAe.TabIndex = 128;
            // 
            // lbl_placaAe
            // 
            this.lbl_placaAe.AutoSize = true;
            this.lbl_placaAe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placaAe.Location = new System.Drawing.Point(199, 117);
            this.lbl_placaAe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_placaAe.Name = "lbl_placaAe";
            this.lbl_placaAe.Size = new System.Drawing.Size(141, 24);
            this.lbl_placaAe.TabIndex = 127;
            this.lbl_placaAe.Text = "Placa do Carro*";
            // 
            // lbl_idAe
            // 
            this.lbl_idAe.AutoSize = true;
            this.lbl_idAe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idAe.Location = new System.Drawing.Point(52, 117);
            this.lbl_idAe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idAe.Name = "lbl_idAe";
            this.lbl_idAe.Size = new System.Drawing.Size(27, 24);
            this.lbl_idAe.TabIndex = 126;
            this.lbl_idAe.Text = "ID";
            // 
            // btn_consultarAe
            // 
            this.btn_consultarAe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_consultarAe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultarAe.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarAe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consultarAe.Image = global::PETROVALE.Properties.Resources.search_sharp;
            this.btn_consultarAe.Location = new System.Drawing.Point(223, 658);
            this.btn_consultarAe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultarAe.Name = "btn_consultarAe";
            this.btn_consultarAe.Size = new System.Drawing.Size(139, 48);
            this.btn_consultarAe.TabIndex = 123;
            this.btn_consultarAe.Text = " Consultar";
            this.btn_consultarAe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_consultarAe.UseVisualStyleBackColor = false;
            this.btn_consultarAe.Click += new System.EventHandler(this.btn_consultarEs_Click);
            // 
            // btn_alterarAe
            // 
            this.btn_alterarAe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_alterarAe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterarAe.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarAe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_alterarAe.Image = global::PETROVALE.Properties.Resources.icons8_alterar_25;
            this.btn_alterarAe.Location = new System.Drawing.Point(389, 658);
            this.btn_alterarAe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_alterarAe.Name = "btn_alterarAe";
            this.btn_alterarAe.Size = new System.Drawing.Size(139, 48);
            this.btn_alterarAe.TabIndex = 122;
            this.btn_alterarAe.Text = " Alterar";
            this.btn_alterarAe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alterarAe.UseVisualStyleBackColor = false;
            this.btn_alterarAe.Click += new System.EventHandler(this.btn_alterarEs_Click);
            // 
            // btn_deletarAe
            // 
            this.btn_deletarAe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_deletarAe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletarAe.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletarAe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deletarAe.Image = global::PETROVALE.Properties.Resources.Vector__1_1;
            this.btn_deletarAe.Location = new System.Drawing.Point(56, 727);
            this.btn_deletarAe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_deletarAe.Name = "btn_deletarAe";
            this.btn_deletarAe.Size = new System.Drawing.Size(139, 48);
            this.btn_deletarAe.TabIndex = 121;
            this.btn_deletarAe.Text = "  Deletar";
            this.btn_deletarAe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletarAe.UseVisualStyleBackColor = false;
            this.btn_deletarAe.Click += new System.EventHandler(this.btn_deletarEs_Click);
            // 
            // btn_limparAe
            // 
            this.btn_limparAe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_limparAe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparAe.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparAe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limparAe.Image = global::PETROVALE.Properties.Resources.Untitled_1__2_;
            this.btn_limparAe.Location = new System.Drawing.Point(223, 727);
            this.btn_limparAe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limparAe.Name = "btn_limparAe";
            this.btn_limparAe.Size = new System.Drawing.Size(139, 48);
            this.btn_limparAe.TabIndex = 120;
            this.btn_limparAe.Text = "  Limpar";
            this.btn_limparAe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limparAe.UseVisualStyleBackColor = false;
            this.btn_limparAe.Click += new System.EventHandler(this.btn_limparEs_Click);
            // 
            // btn_inserirAe
            // 
            this.btn_inserirAe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_inserirAe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserirAe.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserirAe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inserirAe.Image = global::PETROVALE.Properties.Resources.icons8_salvar_24;
            this.btn_inserirAe.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inserirAe.Location = new System.Drawing.Point(56, 658);
            this.btn_inserirAe.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inserirAe.Name = "btn_inserirAe";
            this.btn_inserirAe.Size = new System.Drawing.Size(139, 48);
            this.btn_inserirAe.TabIndex = 119;
            this.btn_inserirAe.Text = "  Inserir";
            this.btn_inserirAe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inserirAe.UseVisualStyleBackColor = false;
            this.btn_inserirAe.Click += new System.EventHandler(this.btn_inserirEs_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PETROVALE.Properties.Resources.pexels_alex_akulov_18501358_1;
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
            // lbl_dataAe
            // 
            this.lbl_dataAe.AutoSize = true;
            this.lbl_dataAe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataAe.Location = new System.Drawing.Point(252, 201);
            this.lbl_dataAe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dataAe.Name = "lbl_dataAe";
            this.lbl_dataAe.Size = new System.Drawing.Size(54, 24);
            this.lbl_dataAe.TabIndex = 141;
            this.lbl_dataAe.Text = "Data*";
            // 
            // txt_horarioAe
            // 
            this.txt_horarioAe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_horarioAe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_horarioAe.Location = new System.Drawing.Point(56, 231);
            this.txt_horarioAe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_horarioAe.Name = "txt_horarioAe";
            this.txt_horarioAe.Size = new System.Drawing.Size(160, 22);
            this.txt_horarioAe.TabIndex = 138;
            this.txt_horarioAe.Text = "00:00";
            // 
            // lbl_horarioAe
            // 
            this.lbl_horarioAe.AutoSize = true;
            this.lbl_horarioAe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horarioAe.Location = new System.Drawing.Point(52, 201);
            this.lbl_horarioAe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_horarioAe.Name = "lbl_horarioAe";
            this.lbl_horarioAe.Size = new System.Drawing.Size(79, 24);
            this.lbl_horarioAe.TabIndex = 137;
            this.lbl_horarioAe.Text = "Horário*";
            // 
            // dtp_dataAe
            // 
            this.dtp_dataAe.Location = new System.Drawing.Point(256, 231);
            this.dtp_dataAe.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_dataAe.Name = "dtp_dataAe";
            this.dtp_dataAe.Size = new System.Drawing.Size(265, 22);
            this.dtp_dataAe.TabIndex = 145;
            this.dtp_dataAe.ValueChanged += new System.EventHandler(this.dtp_dataAe_ValueChanged);
            // 
            // frm_estacionamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 833);
            this.Controls.Add(this.dtp_dataAe);
            this.Controls.Add(this.lbl_dataAe);
            this.Controls.Add(this.txt_horarioAe);
            this.Controls.Add(this.lbl_horarioAe);
            this.Controls.Add(this.txt_idAe);
            this.Controls.Add(this.txt_idSerAe);
            this.Controls.Add(this.lbl_idSerAe);
            this.Controls.Add(this.txt_tempoAe);
            this.Controls.Add(this.lbl_tempoAe);
            this.Controls.Add(this.txt_placaAe);
            this.Controls.Add(this.lbl_placaAe);
            this.Controls.Add(this.lbl_idAe);
            this.Controls.Add(this.btn_voltarAe);
            this.Controls.Add(this.btn_consultarAe);
            this.Controls.Add(this.btn_alterarAe);
            this.Controls.Add(this.btn_deletarAe);
            this.Controls.Add(this.btn_limparAe);
            this.Controls.Add(this.btn_inserirAe);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_agendamentoEs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_estacionamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_agendamentoEs;
        private System.Windows.Forms.Button btn_voltarAe;
        private System.Windows.Forms.Button btn_consultarAe;
        private System.Windows.Forms.Button btn_alterarAe;
        private System.Windows.Forms.Button btn_deletarAe;
        private System.Windows.Forms.Button btn_limparAe;
        private System.Windows.Forms.Button btn_inserirAe;
        private System.Windows.Forms.TextBox txt_idAe;
        private System.Windows.Forms.TextBox txt_idSerAe;
        private System.Windows.Forms.Label lbl_idSerAe;
        private System.Windows.Forms.TextBox txt_tempoAe;
        private System.Windows.Forms.Label lbl_tempoAe;
        private System.Windows.Forms.TextBox txt_placaAe;
        private System.Windows.Forms.Label lbl_placaAe;
        private System.Windows.Forms.Label lbl_idAe;
        private System.Windows.Forms.Label lbl_dataAe;
        private System.Windows.Forms.TextBox txt_horarioAe;
        private System.Windows.Forms.Label lbl_horarioAe;
        private System.Windows.Forms.DateTimePicker dtp_dataAe;
    }
}