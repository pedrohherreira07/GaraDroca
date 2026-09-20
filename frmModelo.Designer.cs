namespace GaraDroca
{
    partial class frmModelo
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdMarcas = new System.Windows.Forms.DataGridView();
            this.grupoModelos = new System.Windows.Forms.GroupBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btnExcluirModelo = new System.Windows.Forms.Button();
            this.btnAlterarModelo = new System.Windows.Forms.Button();
            this.btnCancelarModelo = new System.Windows.Forms.Button();
            this.btnCadastrarModelo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grdModelo = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarcas)).BeginInit();
            this.grupoModelos.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluir.ForeColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(572, 133);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 37);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, -43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(0, 0);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerenciar marcas";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlterar.Location = new System.Drawing.Point(413, 133);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(117, 37);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.ForeColor = System.Drawing.Color.Gray;
            this.btnCancelar.Location = new System.Drawing.Point(254, 133);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 37);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrar.Location = new System.Drawing.Point(95, 133);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(117, 37);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(95, 83);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(594, 30);
            this.txtMarca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome da marca:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdMarcas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(0, 0);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marcas cadastradas";
            // 
            // grdMarcas
            // 
            this.grdMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMarcas.Location = new System.Drawing.Point(3, 26);
            this.grdMarcas.Name = "grdMarcas";
            this.grdMarcas.Size = new System.Drawing.Size(0, 0);
            this.grdMarcas.TabIndex = 0;
            // 
            // grupoModelos
            // 
            this.grupoModelos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grupoModelos.Controls.Add(this.cbMarca);
            this.grupoModelos.Controls.Add(this.btnExcluirModelo);
            this.grupoModelos.Controls.Add(this.btnAlterarModelo);
            this.grupoModelos.Controls.Add(this.btnCancelarModelo);
            this.grupoModelos.Controls.Add(this.btnCadastrarModelo);
            this.grupoModelos.Controls.Add(this.label3);
            this.grupoModelos.Controls.Add(this.txtModelo);
            this.grupoModelos.Controls.Add(this.label2);
            this.grupoModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoModelos.Location = new System.Drawing.Point(16, 12);
            this.grupoModelos.Name = "grupoModelos";
            this.grupoModelos.Size = new System.Drawing.Size(810, 253);
            this.grupoModelos.TabIndex = 4;
            this.grupoModelos.TabStop = false;
            this.grupoModelos.Text = "Modelos";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(70, 78);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(675, 33);
            this.cbMarca.TabIndex = 1;
            this.cbMarca.Tag = "obg:Selecione a marca";
            // 
            // btnExcluirModelo
            // 
            this.btnExcluirModelo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirModelo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluirModelo.ForeColor = System.Drawing.Color.Red;
            this.btnExcluirModelo.Location = new System.Drawing.Point(628, 202);
            this.btnExcluirModelo.Name = "btnExcluirModelo";
            this.btnExcluirModelo.Size = new System.Drawing.Size(117, 37);
            this.btnExcluirModelo.TabIndex = 6;
            this.btnExcluirModelo.Text = "Excluir";
            this.btnExcluirModelo.UseVisualStyleBackColor = false;
            // 
            // btnAlterarModelo
            // 
            this.btnAlterarModelo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterarModelo.FlatAppearance.BorderSize = 0;
            this.btnAlterarModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlterarModelo.Location = new System.Drawing.Point(442, 202);
            this.btnAlterarModelo.Name = "btnAlterarModelo";
            this.btnAlterarModelo.Size = new System.Drawing.Size(117, 37);
            this.btnAlterarModelo.TabIndex = 5;
            this.btnAlterarModelo.Text = "Alterar";
            this.btnAlterarModelo.UseVisualStyleBackColor = false;
            // 
            // btnCancelarModelo
            // 
            this.btnCancelarModelo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarModelo.ForeColor = System.Drawing.Color.Gray;
            this.btnCancelarModelo.Location = new System.Drawing.Point(256, 202);
            this.btnCancelarModelo.Name = "btnCancelarModelo";
            this.btnCancelarModelo.Size = new System.Drawing.Size(117, 37);
            this.btnCancelarModelo.TabIndex = 4;
            this.btnCancelarModelo.Text = "Cancelar";
            this.btnCancelarModelo.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarModelo
            // 
            this.btnCadastrarModelo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrarModelo.Location = new System.Drawing.Point(70, 202);
            this.btnCadastrarModelo.Name = "btnCadastrarModelo";
            this.btnCadastrarModelo.Size = new System.Drawing.Size(117, 37);
            this.btnCadastrarModelo.TabIndex = 3;
            this.btnCadastrarModelo.Text = "Cadastrar";
            this.btnCadastrarModelo.UseVisualStyleBackColor = false;
            this.btnCadastrarModelo.Click += new System.EventHandler(this.btnCadastrarModelo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Selecione a marca:";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(70, 152);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(675, 30);
            this.txtModelo.TabIndex = 2;
            this.txtModelo.Tag = "obg:Nome do modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do modelo:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdModelo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(16, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(810, 264);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modelos cadastrados";
            // 
            // grdModelo
            // 
            this.grdModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdModelo.Location = new System.Drawing.Point(3, 26);
            this.grdModelo.Name = "grdModelo";
            this.grdModelo.Size = new System.Drawing.Size(804, 235);
            this.grdModelo.TabIndex = 0;
            // 
            // frmModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.grupoModelos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmModelo";
            this.Text = "frmModelos";
            this.Load += new System.EventHandler(this.frmModelo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMarcas)).EndInit();
            this.grupoModelos.ResumeLayout(false);
            this.grupoModelos.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdModelo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdMarcas;
        private System.Windows.Forms.GroupBox grupoModelos;
        private System.Windows.Forms.Button btnExcluirModelo;
        private System.Windows.Forms.Button btnAlterarModelo;
        private System.Windows.Forms.Button btnCancelarModelo;
        private System.Windows.Forms.Button btnCadastrarModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grdModelo;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label label3;
    }
}