namespace PETROVALE
{
    partial class frm_posto
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
            this.lbl_cadastroPosto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ruaPosto = new System.Windows.Forms.TextBox();
            this.lbl_ruaPosto = new System.Windows.Forms.Label();
            this.txt_bairroPosto = new System.Windows.Forms.TextBox();
            this.lbl_bairroPosto = new System.Windows.Forms.Label();
            this.txt_cidadePosto = new System.Windows.Forms.TextBox();
            this.lbl_cidadePosto = new System.Windows.Forms.Label();
            this.txt_estadoPosto = new System.Windows.Forms.TextBox();
            this.lbl_estadoPosto = new System.Windows.Forms.Label();
            this.txt_numeroPosto = new System.Windows.Forms.TextBox();
            this.lbl_numeroPosto = new System.Windows.Forms.Label();
            this.lbl_idPosto = new System.Windows.Forms.Label();
            this.lbl_nomePosto = new System.Windows.Forms.Label();
            this.lbl_cnpjPosto = new System.Windows.Forms.Label();
            this.txt_telefonePosto = new System.Windows.Forms.TextBox();
            this.lbl_telefonePosto = new System.Windows.Forms.Label();
            this.txt_emailPosto = new System.Windows.Forms.TextBox();
            this.lbl_emailPosto = new System.Windows.Forms.Label();
            this.txt_cnpjPosto = new System.Windows.Forms.TextBox();
            this.txt_nomePosto = new System.Windows.Forms.TextBox();
            this.btn_voltarPosto = new System.Windows.Forms.Button();
            this.txt_idPosto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_consultarPosto = new System.Windows.Forms.Button();
            this.btn_alterarPosto = new System.Windows.Forms.Button();
            this.btn_deletarPosto = new System.Windows.Forms.Button();
            this.btn_limparPosto = new System.Windows.Forms.Button();
            this.btn_inserirPosto = new System.Windows.Forms.Button();
            this.txt_senhaPosto = new System.Windows.Forms.TextBox();
            this.lbl_senhaPosto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cadastroPosto
            // 
            this.lbl_cadastroPosto.AutoSize = true;
            this.lbl_cadastroPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cadastroPosto.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_cadastroPosto.Location = new System.Drawing.Point(32, 16);
            this.lbl_cadastroPosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cadastroPosto.Name = "lbl_cadastroPosto";
            this.lbl_cadastroPosto.Size = new System.Drawing.Size(220, 36);
            this.lbl_cadastroPosto.TabIndex = 0;
            this.lbl_cadastroPosto.Text = "Cadastro Posto";
            this.lbl_cadastroPosto.Click += new System.EventHandler(this.label1_Click);
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(593, 559);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ruaPosto);
            this.groupBox1.Controls.Add(this.lbl_ruaPosto);
            this.groupBox1.Controls.Add(this.txt_bairroPosto);
            this.groupBox1.Controls.Add(this.lbl_bairroPosto);
            this.groupBox1.Controls.Add(this.txt_cidadePosto);
            this.groupBox1.Controls.Add(this.lbl_cidadePosto);
            this.groupBox1.Controls.Add(this.txt_estadoPosto);
            this.groupBox1.Controls.Add(this.lbl_estadoPosto);
            this.groupBox1.Controls.Add(this.txt_numeroPosto);
            this.groupBox1.Controls.Add(this.lbl_numeroPosto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 373);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(583, 303);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_ruaPosto
            // 
            this.txt_ruaPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ruaPosto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ruaPosto.Location = new System.Drawing.Point(303, 166);
            this.txt_ruaPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ruaPosto.Name = "txt_ruaPosto";
            this.txt_ruaPosto.Size = new System.Drawing.Size(205, 23);
            this.txt_ruaPosto.TabIndex = 9;
            // 
            // lbl_ruaPosto
            // 
            this.lbl_ruaPosto.AutoSize = true;
            this.lbl_ruaPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ruaPosto.Location = new System.Drawing.Point(299, 129);
            this.lbl_ruaPosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ruaPosto.Name = "lbl_ruaPosto";
            this.lbl_ruaPosto.Size = new System.Drawing.Size(51, 24);
            this.lbl_ruaPosto.TabIndex = 8;
            this.lbl_ruaPosto.Text = "Rua*";
            // 
            // txt_bairroPosto
            // 
            this.txt_bairroPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairroPosto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_bairroPosto.Location = new System.Drawing.Point(47, 166);
            this.txt_bairroPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_bairroPosto.Name = "txt_bairroPosto";
            this.txt_bairroPosto.Size = new System.Drawing.Size(205, 23);
            this.txt_bairroPosto.TabIndex = 7;
            this.txt_bairroPosto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_bairroPosto
            // 
            this.lbl_bairroPosto.AutoSize = true;
            this.lbl_bairroPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bairroPosto.Location = new System.Drawing.Point(43, 129);
            this.lbl_bairroPosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bairroPosto.Name = "lbl_bairroPosto";
            this.lbl_bairroPosto.Size = new System.Drawing.Size(66, 24);
            this.lbl_bairroPosto.TabIndex = 6;
            this.lbl_bairroPosto.Text = "Bairro*";
            this.lbl_bairroPosto.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txt_cidadePosto
            // 
            this.txt_cidadePosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidadePosto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_cidadePosto.Location = new System.Drawing.Point(181, 82);
            this.txt_cidadePosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cidadePosto.Name = "txt_cidadePosto";
            this.txt_cidadePosto.Size = new System.Drawing.Size(205, 23);
            this.txt_cidadePosto.TabIndex = 5;
            // 
            // lbl_cidadePosto
            // 
            this.lbl_cidadePosto.AutoSize = true;
            this.lbl_cidadePosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cidadePosto.Location = new System.Drawing.Point(177, 46);
            this.lbl_cidadePosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cidadePosto.Name = "lbl_cidadePosto";
            this.lbl_cidadePosto.Size = new System.Drawing.Size(77, 24);
            this.lbl_cidadePosto.TabIndex = 4;
            this.lbl_cidadePosto.Text = "Cidade*";
            // 
            // txt_estadoPosto
            // 
            this.txt_estadoPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estadoPosto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_estadoPosto.Location = new System.Drawing.Point(47, 82);
            this.txt_estadoPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_estadoPosto.Name = "txt_estadoPosto";
            this.txt_estadoPosto.Size = new System.Drawing.Size(91, 23);
            this.txt_estadoPosto.TabIndex = 3;
            // 
            // lbl_estadoPosto
            // 
            this.lbl_estadoPosto.AutoSize = true;
            this.lbl_estadoPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estadoPosto.Location = new System.Drawing.Point(43, 46);
            this.lbl_estadoPosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_estadoPosto.Name = "lbl_estadoPosto";
            this.lbl_estadoPosto.Size = new System.Drawing.Size(75, 24);
            this.lbl_estadoPosto.TabIndex = 2;
            this.lbl_estadoPosto.Text = "Estado*";
            // 
            // txt_numeroPosto
            // 
            this.txt_numeroPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroPosto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_numeroPosto.Location = new System.Drawing.Point(47, 254);
            this.txt_numeroPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_numeroPosto.Name = "txt_numeroPosto";
            this.txt_numeroPosto.Size = new System.Drawing.Size(277, 23);
            this.txt_numeroPosto.TabIndex = 1;
            this.txt_numeroPosto.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // lbl_numeroPosto
            // 
            this.lbl_numeroPosto.AutoSize = true;
            this.lbl_numeroPosto.Location = new System.Drawing.Point(43, 217);
            this.lbl_numeroPosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numeroPosto.Name = "lbl_numeroPosto";
            this.lbl_numeroPosto.Size = new System.Drawing.Size(86, 24);
            this.lbl_numeroPosto.TabIndex = 0;
            this.lbl_numeroPosto.Text = "Número*";
            this.lbl_numeroPosto.Click += new System.EventHandler(this.lbl_senha_Click);
            // 
            // lbl_idPosto
            // 
            this.lbl_idPosto.AutoSize = true;
            this.lbl_idPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idPosto.Location = new System.Drawing.Point(52, 117);
            this.lbl_idPosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idPosto.Name = "lbl_idPosto";
            this.lbl_idPosto.Size = new System.Drawing.Size(27, 24);
            this.lbl_idPosto.TabIndex = 14;
            this.lbl_idPosto.Text = "ID";
            this.lbl_idPosto.Click += new System.EventHandler(this.lbl_codigo_Click);
            // 
            // lbl_nomePosto
            // 
            this.lbl_nomePosto.AutoSize = true;
            this.lbl_nomePosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomePosto.Location = new System.Drawing.Point(204, 117);
            this.lbl_nomePosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomePosto.Name = "lbl_nomePosto";
            this.lbl_nomePosto.Size = new System.Drawing.Size(69, 24);
            this.lbl_nomePosto.TabIndex = 38;
            this.lbl_nomePosto.Text = "Nome*";
            this.lbl_nomePosto.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_cnpjPosto
            // 
            this.lbl_cnpjPosto.AutoSize = true;
            this.lbl_cnpjPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cnpjPosto.Location = new System.Drawing.Point(473, 117);
            this.lbl_cnpjPosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cnpjPosto.Name = "lbl_cnpjPosto";
            this.lbl_cnpjPosto.Size = new System.Drawing.Size(65, 24);
            this.lbl_cnpjPosto.TabIndex = 40;
            this.lbl_cnpjPosto.Text = "CNPJ*";
            // 
            // txt_telefonePosto
            // 
            this.txt_telefonePosto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_telefonePosto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_telefonePosto.Location = new System.Drawing.Point(324, 229);
            this.txt_telefonePosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_telefonePosto.Name = "txt_telefonePosto";
            this.txt_telefonePosto.Size = new System.Drawing.Size(220, 22);
            this.txt_telefonePosto.TabIndex = 45;
            this.txt_telefonePosto.TextChanged += new System.EventHandler(this.txt_telefonePosto_TextChanged);
            // 
            // lbl_telefonePosto
            // 
            this.lbl_telefonePosto.AutoSize = true;
            this.lbl_telefonePosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telefonePosto.Location = new System.Drawing.Point(320, 198);
            this.lbl_telefonePosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_telefonePosto.Name = "lbl_telefonePosto";
            this.lbl_telefonePosto.Size = new System.Drawing.Size(92, 24);
            this.lbl_telefonePosto.TabIndex = 44;
            this.lbl_telefonePosto.Text = "Telefone*";
            this.lbl_telefonePosto.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_emailPosto
            // 
            this.txt_emailPosto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_emailPosto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_emailPosto.Location = new System.Drawing.Point(56, 229);
            this.txt_emailPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_emailPosto.Name = "txt_emailPosto";
            this.txt_emailPosto.Size = new System.Drawing.Size(221, 22);
            this.txt_emailPosto.TabIndex = 43;
            // 
            // lbl_emailPosto
            // 
            this.lbl_emailPosto.AutoSize = true;
            this.lbl_emailPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailPosto.Location = new System.Drawing.Point(52, 198);
            this.lbl_emailPosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_emailPosto.Name = "lbl_emailPosto";
            this.lbl_emailPosto.Size = new System.Drawing.Size(70, 24);
            this.lbl_emailPosto.TabIndex = 42;
            this.lbl_emailPosto.Text = "E-mail*";
            // 
            // txt_cnpjPosto
            // 
            this.txt_cnpjPosto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_cnpjPosto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_cnpjPosto.Location = new System.Drawing.Point(477, 148);
            this.txt_cnpjPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cnpjPosto.Name = "txt_cnpjPosto";
            this.txt_cnpjPosto.Size = new System.Drawing.Size(160, 22);
            this.txt_cnpjPosto.TabIndex = 41;
            // 
            // txt_nomePosto
            // 
            this.txt_nomePosto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_nomePosto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_nomePosto.Location = new System.Drawing.Point(208, 148);
            this.txt_nomePosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nomePosto.Name = "txt_nomePosto";
            this.txt_nomePosto.Size = new System.Drawing.Size(220, 22);
            this.txt_nomePosto.TabIndex = 39;
            // 
            // btn_voltarPosto
            // 
            this.btn_voltarPosto.BackColor = System.Drawing.Color.DarkGray;
            this.btn_voltarPosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltarPosto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltarPosto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_voltarPosto.Location = new System.Drawing.Point(1084, 722);
            this.btn_voltarPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_voltarPosto.Name = "btn_voltarPosto";
            this.btn_voltarPosto.Size = new System.Drawing.Size(139, 48);
            this.btn_voltarPosto.TabIndex = 51;
            this.btn_voltarPosto.Text = "Voltar";
            this.btn_voltarPosto.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_voltarPosto.UseVisualStyleBackColor = false;
            this.btn_voltarPosto.Click += new System.EventHandler(this.btn_voltarPosto_Click_1);
            // 
            // txt_idPosto
            // 
            this.txt_idPosto.Location = new System.Drawing.Point(56, 148);
            this.txt_idPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idPosto.Name = "txt_idPosto";
            this.txt_idPosto.ReadOnly = true;
            this.txt_idPosto.Size = new System.Drawing.Size(113, 22);
            this.txt_idPosto.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PETROVALE.Properties.Resources.Group_1251;
            this.pictureBox1.Location = new System.Drawing.Point(529, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 81);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btn_consultarPosto
            // 
            this.btn_consultarPosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_consultarPosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultarPosto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultarPosto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_consultarPosto.Image = global::PETROVALE.Properties.Resources.search_sharp;
            this.btn_consultarPosto.Location = new System.Drawing.Point(341, 722);
            this.btn_consultarPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_consultarPosto.Name = "btn_consultarPosto";
            this.btn_consultarPosto.Size = new System.Drawing.Size(139, 48);
            this.btn_consultarPosto.TabIndex = 50;
            this.btn_consultarPosto.Text = " Consultar";
            this.btn_consultarPosto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_consultarPosto.UseVisualStyleBackColor = false;
            this.btn_consultarPosto.Click += new System.EventHandler(this.btn_consultarPosto_Click);
            // 
            // btn_alterarPosto
            // 
            this.btn_alterarPosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_alterarPosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterarPosto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarPosto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_alterarPosto.Image = global::PETROVALE.Properties.Resources.icons8_alterar_25;
            this.btn_alterarPosto.Location = new System.Drawing.Point(508, 722);
            this.btn_alterarPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_alterarPosto.Name = "btn_alterarPosto";
            this.btn_alterarPosto.Size = new System.Drawing.Size(139, 48);
            this.btn_alterarPosto.TabIndex = 49;
            this.btn_alterarPosto.Text = " Alterar";
            this.btn_alterarPosto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_alterarPosto.UseVisualStyleBackColor = false;
            this.btn_alterarPosto.Click += new System.EventHandler(this.btn_alterarPosto_Click);
            // 
            // btn_deletarPosto
            // 
            this.btn_deletarPosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_deletarPosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletarPosto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletarPosto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_deletarPosto.Image = global::PETROVALE.Properties.Resources.Vector__1_1;
            this.btn_deletarPosto.Location = new System.Drawing.Point(677, 722);
            this.btn_deletarPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_deletarPosto.Name = "btn_deletarPosto";
            this.btn_deletarPosto.Size = new System.Drawing.Size(139, 48);
            this.btn_deletarPosto.TabIndex = 48;
            this.btn_deletarPosto.Text = "  Deletar";
            this.btn_deletarPosto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletarPosto.UseVisualStyleBackColor = false;
            this.btn_deletarPosto.Click += new System.EventHandler(this.btn_deletarPosto_Click);
            // 
            // btn_limparPosto
            // 
            this.btn_limparPosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_limparPosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparPosto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparPosto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_limparPosto.Image = global::PETROVALE.Properties.Resources.Untitled_1__2_;
            this.btn_limparPosto.Location = new System.Drawing.Point(844, 722);
            this.btn_limparPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_limparPosto.Name = "btn_limparPosto";
            this.btn_limparPosto.Size = new System.Drawing.Size(139, 48);
            this.btn_limparPosto.TabIndex = 47;
            this.btn_limparPosto.Text = "  Limpar";
            this.btn_limparPosto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_limparPosto.UseVisualStyleBackColor = false;
            this.btn_limparPosto.Click += new System.EventHandler(this.btn_limparPosto_Click);
            // 
            // btn_inserirPosto
            // 
            this.btn_inserirPosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_inserirPosto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserirPosto.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserirPosto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inserirPosto.Image = global::PETROVALE.Properties.Resources.icons8_salvar_24;
            this.btn_inserirPosto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inserirPosto.Location = new System.Drawing.Point(175, 722);
            this.btn_inserirPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_inserirPosto.Name = "btn_inserirPosto";
            this.btn_inserirPosto.Size = new System.Drawing.Size(139, 48);
            this.btn_inserirPosto.TabIndex = 46;
            this.btn_inserirPosto.Text = "  Inserir";
            this.btn_inserirPosto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_inserirPosto.UseVisualStyleBackColor = false;
            this.btn_inserirPosto.Click += new System.EventHandler(this.btn_inserirPosto_Click);
            // 
            // txt_senhaPosto
            // 
            this.txt_senhaPosto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_senhaPosto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_senhaPosto.Location = new System.Drawing.Point(57, 305);
            this.txt_senhaPosto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_senhaPosto.Name = "txt_senhaPosto";
            this.txt_senhaPosto.Size = new System.Drawing.Size(220, 22);
            this.txt_senhaPosto.TabIndex = 56;
            this.txt_senhaPosto.TextChanged += new System.EventHandler(this.txt_senhaPosto_TextChanged);
            // 
            // lbl_senhaPosto
            // 
            this.lbl_senhaPosto.AutoSize = true;
            this.lbl_senhaPosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhaPosto.Location = new System.Drawing.Point(53, 274);
            this.lbl_senhaPosto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_senhaPosto.Name = "lbl_senhaPosto";
            this.lbl_senhaPosto.Size = new System.Drawing.Size(72, 24);
            this.lbl_senhaPosto.TabIndex = 55;
            this.lbl_senhaPosto.Text = "Senha*";
            // 
            // frm_posto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 833);
            this.Controls.Add(this.txt_senhaPosto);
            this.Controls.Add(this.lbl_senhaPosto);
            this.Controls.Add(this.txt_idPosto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_voltarPosto);
            this.Controls.Add(this.btn_consultarPosto);
            this.Controls.Add(this.btn_alterarPosto);
            this.Controls.Add(this.btn_deletarPosto);
            this.Controls.Add(this.btn_limparPosto);
            this.Controls.Add(this.btn_inserirPosto);
            this.Controls.Add(this.txt_telefonePosto);
            this.Controls.Add(this.lbl_telefonePosto);
            this.Controls.Add(this.txt_emailPosto);
            this.Controls.Add(this.lbl_emailPosto);
            this.Controls.Add(this.txt_cnpjPosto);
            this.Controls.Add(this.lbl_cnpjPosto);
            this.Controls.Add(this.txt_nomePosto);
            this.Controls.Add(this.lbl_nomePosto);
            this.Controls.Add(this.lbl_idPosto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_cadastroPosto);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_posto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_posto";
            this.Load += new System.EventHandler(this.frm_posto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cadastroPosto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_estadoPosto;
        private System.Windows.Forms.Label lbl_estadoPosto;
        private System.Windows.Forms.TextBox txt_numeroPosto;
        private System.Windows.Forms.Label lbl_numeroPosto;
        private System.Windows.Forms.Label lbl_idPosto;
        private System.Windows.Forms.Label lbl_nomePosto;
        private System.Windows.Forms.Label lbl_cnpjPosto;
        private System.Windows.Forms.TextBox txt_telefonePosto;
        private System.Windows.Forms.Label lbl_telefonePosto;
        private System.Windows.Forms.TextBox txt_emailPosto;
        private System.Windows.Forms.Label lbl_emailPosto;
        private System.Windows.Forms.TextBox txt_bairroPosto;
        private System.Windows.Forms.Label lbl_bairroPosto;
        private System.Windows.Forms.TextBox txt_cidadePosto;
        private System.Windows.Forms.Label lbl_cidadePosto;
        private System.Windows.Forms.TextBox txt_cnpjPosto;
        private System.Windows.Forms.TextBox txt_nomePosto;
        private System.Windows.Forms.TextBox txt_ruaPosto;
        private System.Windows.Forms.Label lbl_ruaPosto;
        private System.Windows.Forms.Button btn_inserirPosto;
        private System.Windows.Forms.Button btn_limparPosto;
        private System.Windows.Forms.Button btn_deletarPosto;
        private System.Windows.Forms.Button btn_alterarPosto;
        private System.Windows.Forms.Button btn_consultarPosto;
        private System.Windows.Forms.Button btn_voltarPosto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_idPosto;
        private System.Windows.Forms.TextBox txt_senhaPosto;
        private System.Windows.Forms.Label lbl_senhaPosto;
    }
}