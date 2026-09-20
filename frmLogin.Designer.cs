namespace GaraDroca
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grupoAcesso = new System.Windows.Forms.GroupBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grupoAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // grupoAcesso
            // 
            this.grupoAcesso.Controls.Add(this.btnAcessar);
            this.grupoAcesso.Controls.Add(this.txtSenha);
            this.grupoAcesso.Controls.Add(this.txtLogin);
            this.grupoAcesso.Controls.Add(this.label2);
            this.grupoAcesso.Controls.Add(this.label1);
            this.grupoAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoAcesso.Location = new System.Drawing.Point(385, 12);
            this.grupoAcesso.Name = "grupoAcesso";
            this.grupoAcesso.Size = new System.Drawing.Size(376, 337);
            this.grupoAcesso.TabIndex = 1;
            this.grupoAcesso.TabStop = false;
            this.grupoAcesso.Text = "Acesso";
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAcessar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcessar.Location = new System.Drawing.Point(55, 242);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(257, 53);
            this.btnAcessar.TabIndex = 3;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(55, 178);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(257, 30);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Tag = "obg:Senha";
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(55, 89);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(257, 30);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Tag = "obg:Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.grupoAcesso);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLogin";
            this.Text = " frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grupoAcesso.ResumeLayout(false);
            this.grupoAcesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grupoAcesso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
    }
}

