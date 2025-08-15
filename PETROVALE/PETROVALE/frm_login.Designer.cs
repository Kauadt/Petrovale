namespace PETROVALE
{
    partial class frm_login
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.txt_emailLogin = new System.Windows.Forms.TextBox();
            this.lbl_emailLogin = new System.Windows.Forms.Label();
            this.txt_senhaLogin = new System.Windows.Forms.TextBox();
            this.lbl_senhaLogin = new System.Windows.Forms.Label();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PETROVALE.Properties.Resources.Group_1251;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 81);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(319, 124);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(792, 590);
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.White;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(64)))));
            this.lbl_login.Location = new System.Drawing.Point(459, 186);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(193, 78);
            this.lbl_login.TabIndex = 55;
            this.lbl_login.Text = "Login";
            // 
            // txt_emailLogin
            // 
            this.txt_emailLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_emailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_emailLogin.Location = new System.Drawing.Point(472, 372);
            this.txt_emailLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_emailLogin.Name = "txt_emailLogin";
            this.txt_emailLogin.Size = new System.Drawing.Size(483, 29);
            this.txt_emailLogin.TabIndex = 57;
            this.txt_emailLogin.TextChanged += new System.EventHandler(this.txt_emailLogin_TextChanged);
            // 
            // lbl_emailLogin
            // 
            this.lbl_emailLogin.AutoSize = true;
            this.lbl_emailLogin.BackColor = System.Drawing.Color.White;
            this.lbl_emailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emailLogin.Location = new System.Drawing.Point(468, 332);
            this.lbl_emailLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_emailLogin.Name = "lbl_emailLogin";
            this.lbl_emailLogin.Size = new System.Drawing.Size(75, 25);
            this.lbl_emailLogin.TabIndex = 56;
            this.lbl_emailLogin.Text = "E-mail*";
            // 
            // txt_senhaLogin
            // 
            this.txt_senhaLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_senhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senhaLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_senhaLogin.Location = new System.Drawing.Point(472, 495);
            this.txt_senhaLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_senhaLogin.Name = "txt_senhaLogin";
            this.txt_senhaLogin.PasswordChar = '*';
            this.txt_senhaLogin.Size = new System.Drawing.Size(483, 30);
            this.txt_senhaLogin.TabIndex = 59;
            // 
            // lbl_senhaLogin
            // 
            this.lbl_senhaLogin.AutoSize = true;
            this.lbl_senhaLogin.BackColor = System.Drawing.Color.White;
            this.lbl_senhaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_senhaLogin.Location = new System.Drawing.Point(468, 453);
            this.lbl_senhaLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_senhaLogin.Name = "lbl_senhaLogin";
            this.lbl_senhaLogin.Size = new System.Drawing.Size(78, 25);
            this.lbl_senhaLogin.TabIndex = 58;
            this.lbl_senhaLogin.Text = "Senha*";
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_fechar.Location = new System.Drawing.Point(817, 613);
            this.btn_fechar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(139, 48);
            this.btn_fechar.TabIndex = 61;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_entrar
            // 
            this.btn_entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(141)))), ((int)(((byte)(92)))));
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_entrar.Location = new System.Drawing.Point(649, 613);
            this.btn_entrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(139, 48);
            this.btn_entrar.TabIndex = 60;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_entrar.UseVisualStyleBackColor = false;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1423, 815);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.txt_senhaLogin);
            this.Controls.Add(this.lbl_senhaLogin);
            this.Controls.Add(this.txt_emailLogin);
            this.Controls.Add(this.lbl_emailLogin);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TextBox txt_emailLogin;
        private System.Windows.Forms.Label lbl_emailLogin;
        private System.Windows.Forms.TextBox txt_senhaLogin;
        private System.Windows.Forms.Label lbl_senhaLogin;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_entrar;
    }
}