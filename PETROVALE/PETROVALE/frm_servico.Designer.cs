namespace PETROVALE
{
    partial class frm_servico
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
            this.txt_idSer = new System.Windows.Forms.TextBox();
            this.txt_descontoSer = new System.Windows.Forms.TextBox();
            this.lbl_telefoneFun = new System.Windows.Forms.Label();
            this.txt_tipoSer = new System.Windows.Forms.TextBox();
            this.lbl_tipoSer = new System.Windows.Forms.Label();
            this.txt_precoSer = new System.Windows.Forms.TextBox();
            this.lbl_precoSer = new System.Windows.Forms.Label();
            this.txt_nomeSer = new System.Windows.Forms.TextBox();
            this.lbl_nomeSer = new System.Windows.Forms.Label();
            this.lbl_idSer = new System.Windows.Forms.Label();
            this.lbl_cadastroServicos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_voltarSer = new System.Windows.Forms.Button();
            this.btn_consultarSer = new System.Windows.Forms.Button();
            this.btn_alterarSer = new System.Windows.Forms.Button();
            this.btn_limparSer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_idSer
            // 
            this.txt_idSer.Location = new System.Drawing.Point(56, 148);
            this.txt_idSer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idSer.Name = "txt_idSer";
            this.txt_idSer.ReadOnly = true;
            this.txt_idSer.Size = new System.Drawing.Size(113, 22);
            this.txt_idSer.TabIndex = 96;
            // 
            // txt_descontoSer
            // 
            this.txt_descontoSer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_descontoSer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_descontoSer.Location = new System.Drawing.Point(324, 229);
            this.txt_descontoSer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descontoSer.Name = "txt_descontoSer";
            this.txt_descontoSer.Size = new System.Drawing.Size(188, 22);
            this.txt_descontoSer.TabIndex = 94;
            this.txt_descontoSer.Text = "0";
            // 
            // lbl_telefoneFun
            // 
            this.lbl_telefoneFun.AutoSize = true;
            this.lbl_telefoneFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefoneFun.Location = new System.Drawing.Point(320, 198);
            this.lbl_telefoneFun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefoneFun.Name = "lbl_telefoneFun";
            this.lbl_telefoneFun.Size = new System.Drawing.Size(122, 24);
            this.lbl_telefoneFun.TabIndex = 93;
            this.lbl_telefoneFun.Text = "Desconto (%)";
            // 
            // txt_tipoSer
            // 
            this.txt_tipoSer.BackColor = System.Drawing.SystemColors.Control;
            this.txt_tipoSer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_tipoSer.Location = new System.Drawing.Point(56, 229);
            this.txt_tipoSer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tipoSer.Name = "txt_tipoSer";
            this.txt_tipoSer.ReadOnly = true;
            this.txt_tipoSer.Size = new System.Drawing.Size(221, 22);
            this.txt_tipoSer.TabIndex = 92;
            // 
            // lbl_tipoSer
            // 
            this.lbl_tipoSer.AutoSize = true;
            this.lbl_tipoSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipoSer.Location = new System.Drawing.Point(52, 198);
            this.lbl_tipoSer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipoSer.Name = "lbl_tipoSer";
            this.lbl_tipoSer.Size = new System.Drawing.Size(55, 24);
            this.lbl_tipoSer.TabIndex = 91;
            this.lbl_tipoSer.Text = "Tipo*";
            // 
            // txt_precoSer
            // 
            this.txt_precoSer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_precoSer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_precoSer.Location = new System.Drawing.Point(477, 148);
            this.txt_precoSer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_precoSer.Name = "txt_precoSer";
            this.txt_precoSer.Size = new System.Drawing.Size(160, 22);
            this.txt_precoSer.TabIndex = 90;
            // 
            // lbl_precoSer
            // 
            this.lbl_precoSer.AutoSize = true;
            this.lbl_precoSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precoSer.Location = new System.Drawing.Point(473, 117);
            this.lbl_precoSer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_precoSer.Name = "lbl_precoSer";
            this.lbl_precoSer.Size = new System.Drawing.Size(67, 24);
            this.lbl_precoSer.TabIndex = 89;
            this.lbl_precoSer.Text = "Preço*";
            // 
            // txt_nomeSer
            // 
            this.txt_nomeSer.BackColor = System.Drawing.SystemColors.Control;
            this.txt_nomeSer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_nomeSer.Location = new System.Drawing.Point(208, 148);
            this.txt_nomeSer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nomeSer.Name = "txt_nomeSer";
            this.txt_nomeSer.ReadOnly = true;
            this.txt_nomeSer.Size = new System.Drawing.Size(220, 22);
            this.txt_nomeSer.TabIndex = 88;
            // 
            // lbl_nomeSer
            // 
            this.lbl_nomeSer.AutoSize = true;
            this.lbl_nomeSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeSer.Location = new System.Drawing.Point(204, 117);
            this.lbl_nomeSer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomeSer.Name = "lbl_nomeSer";
            this.lbl_nomeSer.Size = new System.Drawing.Size(69, 24);
            this.lbl_nomeSer.TabIndex = 87;
            this.lbl_nomeSer.Text = "Nome*";
            // 
            // lbl_idSer
            // 
            this.lbl_idSer.AutoSize = true;
            this.lbl_idSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idSer.Location = new System.Drawing.Point(52, 117);
            this.lbl_idSer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idSer.Name = "lbl_idSer";
            this.lbl_idSer.Size = new System.Drawing.Size(27, 24);
            this.lbl_idSer.TabIndex = 84;
            this.lbl_idSer.Text = "ID";
            // 
            // lbl_cadastroServicos
            // 
            this.lbl_cadastroServicos.AutoSize = true;
            this.lbl_cadastroServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastroServicos.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_cadastroServicos.Location = new System.Drawing.Point(32, 16);
            this.lbl_cadastroServicos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cadastroServicos.Name = "lbl_cadastroServicos";
            this.lbl_cadastroServicos.Size = new System.Drawing.Size(258, 36);
            this.lbl_cadastroServicos.TabIndex = 83;
            this.lbl_cadastroServicos.Text = "Cadastro Serviços";
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
            this.dataGridView1.TabIndex = 104;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btn_voltarSer
            // 
            this.btn_voltarSer.BackColor = System.Drawing.Color.DarkGray;
            this.btn_voltarSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltarSer.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltarSer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltarSer.Location = new System.Drawing.Point(627, 727);
            this.btn_voltarSer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_voltarSer.Name = "btn_voltarSer";
            this.btn_voltarSer.Size = new System.Drawing.Size(139, 48);
            this.btn_voltarSer.TabIndex = 110;
            this.btn_voltarSer.Text = "Voltar";
            this.btn_voltarSer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_voltarSer.UseVisualStyleBackColor = false;
            this.btn_voltarSer.Click += new System.EventHandler(this.btn_voltarSer_Click);
            // 
            // btn_consultarSer
            // 
            this.btn_consultarSer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_consultarSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultarSer.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarSer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consultarSer.Image = global::PETROVALE.Properties.Resources.search_sharp;
            this.btn_consultarSer.Location = new System.Drawing.Point(51, 658);
            this.btn_consultarSer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_consultarSer.Name = "btn_consultarSer";
            this.btn_consultarSer.Size = new System.Drawing.Size(139, 48);
            this.btn_consultarSer.TabIndex = 109;
            this.btn_consultarSer.Text = " Consultar";
            this.btn_consultarSer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_consultarSer.UseVisualStyleBackColor = false;
            this.btn_consultarSer.Click += new System.EventHandler(this.btn_consultarSer_Click);
            // 
            // btn_alterarSer
            // 
            this.btn_alterarSer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_alterarSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterarSer.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarSer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_alterarSer.Image = global::PETROVALE.Properties.Resources.icons8_alterar_25;
            this.btn_alterarSer.Location = new System.Drawing.Point(201, 658);
            this.btn_alterarSer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_alterarSer.Name = "btn_alterarSer";
            this.btn_alterarSer.Size = new System.Drawing.Size(139, 48);
            this.btn_alterarSer.TabIndex = 108;
            this.btn_alterarSer.Text = " Alterar";
            this.btn_alterarSer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alterarSer.UseVisualStyleBackColor = false;
            this.btn_alterarSer.Click += new System.EventHandler(this.btn_alterarSer_Click);
            // 
            // btn_limparSer
            // 
            this.btn_limparSer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_limparSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparSer.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparSer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limparSer.Image = global::PETROVALE.Properties.Resources.Untitled_1__2_;
            this.btn_limparSer.Location = new System.Drawing.Point(50, 727);
            this.btn_limparSer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limparSer.Name = "btn_limparSer";
            this.btn_limparSer.Size = new System.Drawing.Size(139, 48);
            this.btn_limparSer.TabIndex = 106;
            this.btn_limparSer.Text = "  Limpar";
            this.btn_limparSer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limparSer.UseVisualStyleBackColor = false;
            this.btn_limparSer.Click += new System.EventHandler(this.btn_limparSer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::PETROVALE.Properties.Resources.Rectangle_30__1_;
            this.pictureBox2.Location = new System.Drawing.Point(888, -11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(499, 848);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 103;
            this.pictureBox2.TabStop = false;
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
            // frm_servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 833);
            this.Controls.Add(this.btn_voltarSer);
            this.Controls.Add(this.btn_consultarSer);
            this.Controls.Add(this.btn_alterarSer);
            this.Controls.Add(this.btn_limparSer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_idSer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_descontoSer);
            this.Controls.Add(this.lbl_telefoneFun);
            this.Controls.Add(this.txt_tipoSer);
            this.Controls.Add(this.lbl_tipoSer);
            this.Controls.Add(this.txt_precoSer);
            this.Controls.Add(this.lbl_precoSer);
            this.Controls.Add(this.txt_nomeSer);
            this.Controls.Add(this.lbl_nomeSer);
            this.Controls.Add(this.lbl_idSer);
            this.Controls.Add(this.lbl_cadastroServicos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_servico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_sevico";
            this.Load += new System.EventHandler(this.frm_servico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_idSer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_descontoSer;
        private System.Windows.Forms.Label lbl_telefoneFun;
        private System.Windows.Forms.TextBox txt_tipoSer;
        private System.Windows.Forms.Label lbl_tipoSer;
        private System.Windows.Forms.TextBox txt_precoSer;
        private System.Windows.Forms.Label lbl_precoSer;
        private System.Windows.Forms.TextBox txt_nomeSer;
        private System.Windows.Forms.Label lbl_nomeSer;
        private System.Windows.Forms.Label lbl_idSer;
        private System.Windows.Forms.Label lbl_cadastroServicos;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_voltarSer;
        private System.Windows.Forms.Button btn_consultarSer;
        private System.Windows.Forms.Button btn_alterarSer;
        private System.Windows.Forms.Button btn_limparSer;
    }
}