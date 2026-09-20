namespace GaraDroca
{
    partial class frmMarca
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
            this.grupoMarcas = new System.Windows.Forms.GroupBox();
            this.cbGravarOffline = new System.Windows.Forms.CheckBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnExcluirMarca = new System.Windows.Forms.Button();
            this.btnAlterarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnCadastrarMarca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdMarcas = new System.Windows.Forms.DataGridView();
            this.grupoMarcas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoMarcas
            // 
            this.grupoMarcas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grupoMarcas.Controls.Add(this.cbGravarOffline);
            this.grupoMarcas.Controls.Add(this.txtMarca);
            this.grupoMarcas.Controls.Add(this.btnExcluirMarca);
            this.grupoMarcas.Controls.Add(this.btnAlterarMarca);
            this.grupoMarcas.Controls.Add(this.btnCancelarMarca);
            this.grupoMarcas.Controls.Add(this.btnCadastrarMarca);
            this.grupoMarcas.Controls.Add(this.label1);
            this.grupoMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoMarcas.Location = new System.Drawing.Point(17, 13);
            this.grupoMarcas.Name = "grupoMarcas";
            this.grupoMarcas.Size = new System.Drawing.Size(810, 193);
            this.grupoMarcas.TabIndex = 0;
            this.grupoMarcas.TabStop = false;
            this.grupoMarcas.Text = "Cadastro";
            // 
            // cbGravarOffline
            // 
            this.cbGravarOffline.AutoSize = true;
            this.cbGravarOffline.Location = new System.Drawing.Point(605, 39);
            this.cbGravarOffline.Name = "cbGravarOffline";
            this.cbGravarOffline.Size = new System.Drawing.Size(146, 29);
            this.cbGravarOffline.TabIndex = 2;
            this.cbGravarOffline.Text = "Gravar offline";
            this.cbGravarOffline.UseVisualStyleBackColor = true;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(66, 87);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(675, 30);
            this.txtMarca.TabIndex = 1;
            this.txtMarca.Tag = "obg:Nome da marca";
            // 
            // btnExcluirMarca
            // 
            this.btnExcluirMarca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirMarca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluirMarca.ForeColor = System.Drawing.Color.Red;
            this.btnExcluirMarca.Location = new System.Drawing.Point(438, 135);
            this.btnExcluirMarca.Name = "btnExcluirMarca";
            this.btnExcluirMarca.Size = new System.Drawing.Size(117, 37);
            this.btnExcluirMarca.TabIndex = 5;
            this.btnExcluirMarca.Tag = "perigo";
            this.btnExcluirMarca.Text = "Excluir";
            this.btnExcluirMarca.UseVisualStyleBackColor = false;
            // 
            // btnAlterarMarca
            // 
            this.btnAlterarMarca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterarMarca.FlatAppearance.BorderSize = 0;
            this.btnAlterarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlterarMarca.Location = new System.Drawing.Point(624, 135);
            this.btnAlterarMarca.Name = "btnAlterarMarca";
            this.btnAlterarMarca.Size = new System.Drawing.Size(117, 37);
            this.btnAlterarMarca.TabIndex = 6;
            this.btnAlterarMarca.Tag = "aviso";
            this.btnAlterarMarca.Text = "Alterar";
            this.btnAlterarMarca.UseVisualStyleBackColor = false;
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarMarca.ForeColor = System.Drawing.Color.Gray;
            this.btnCancelarMarca.Location = new System.Drawing.Point(252, 135);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(117, 37);
            this.btnCancelarMarca.TabIndex = 4;
            this.btnCancelarMarca.Tag = "neutro";
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarMarca
            // 
            this.btnCadastrarMarca.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrarMarca.Location = new System.Drawing.Point(66, 135);
            this.btnCadastrarMarca.Name = "btnCadastrarMarca";
            this.btnCadastrarMarca.Size = new System.Drawing.Size(117, 37);
            this.btnCadastrarMarca.TabIndex = 3;
            this.btnCadastrarMarca.Tag = "sucesso";
            this.btnCadastrarMarca.Text = "Cadastrar";
            this.btnCadastrarMarca.UseVisualStyleBackColor = false;
            this.btnCadastrarMarca.Click += new System.EventHandler(this.btnCadastrarMarca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome da marca:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdMarcas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 315);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marcas cadastradas";
            // 
            // grdMarcas
            // 
            this.grdMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMarcas.Location = new System.Drawing.Point(3, 26);
            this.grdMarcas.Name = "grdMarcas";
            this.grdMarcas.Size = new System.Drawing.Size(804, 286);
            this.grdMarcas.TabIndex = 0;
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grupoMarcas);
            this.MaximumSize = new System.Drawing.Size(860, 600);
            this.MinimumSize = new System.Drawing.Size(860, 600);
            this.Name = "frmMarca";
            this.Text = "frmMarcas";
            this.grupoMarcas.ResumeLayout(false);
            this.grupoMarcas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoMarcas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdMarcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlterarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnCadastrarMarca;
        private System.Windows.Forms.Button btnExcluirMarca;
        private System.Windows.Forms.CheckBox cbGravarOffline;
        private System.Windows.Forms.TextBox txtMarca;
    }
}