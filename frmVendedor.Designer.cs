namespace GaraDroca
{
    partial class frmVendedor
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
            this.grupoVendedores = new System.Windows.Forms.GroupBox();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.mtxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.btnExcluirVendedor = new System.Windows.Forms.Button();
            this.btnAlterarVendedor = new System.Windows.Forms.Button();
            this.btnCancelarVendedor = new System.Windows.Forms.Button();
            this.btnCadastrarVendedor = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdVendedor = new System.Windows.Forms.DataGridView();
            this.txtFiltrarNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grupoVendedores.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoVendedores
            // 
            this.grupoVendedores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grupoVendedores.Controls.Add(this.cbAtivo);
            this.grupoVendedores.Controls.Add(this.mtxtCpf);
            this.grupoVendedores.Controls.Add(this.mtxtCelular);
            this.grupoVendedores.Controls.Add(this.btnExcluirVendedor);
            this.grupoVendedores.Controls.Add(this.btnAlterarVendedor);
            this.grupoVendedores.Controls.Add(this.btnCancelarVendedor);
            this.grupoVendedores.Controls.Add(this.btnCadastrarVendedor);
            this.grupoVendedores.Controls.Add(this.txtEndereco);
            this.grupoVendedores.Controls.Add(this.txtEmail);
            this.grupoVendedores.Controls.Add(this.label4);
            this.grupoVendedores.Controls.Add(this.label3);
            this.grupoVendedores.Controls.Add(this.txtNomeVendedor);
            this.grupoVendedores.Controls.Add(this.label5);
            this.grupoVendedores.Controls.Add(this.label2);
            this.grupoVendedores.Controls.Add(this.label1);
            this.grupoVendedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoVendedores.Location = new System.Drawing.Point(16, 12);
            this.grupoVendedores.Name = "grupoVendedores";
            this.grupoVendedores.Size = new System.Drawing.Size(810, 338);
            this.grupoVendedores.TabIndex = 1;
            this.grupoVendedores.TabStop = false;
            this.grupoVendedores.Text = "Gerenciar Vendedores";
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Location = new System.Drawing.Point(494, 225);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(75, 29);
            this.cbAtivo.TabIndex = 6;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // mtxtCpf
            // 
            this.mtxtCpf.Location = new System.Drawing.Point(494, 153);
            this.mtxtCpf.Mask = "00000000000";
            this.mtxtCpf.Name = "mtxtCpf";
            this.mtxtCpf.Size = new System.Drawing.Size(244, 30);
            this.mtxtCpf.TabIndex = 4;
            this.mtxtCpf.Tag = "obg:CPF";
            this.mtxtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtCpf.ValidatingType = typeof(int);
            // 
            // mtxtCelular
            // 
            this.mtxtCelular.Location = new System.Drawing.Point(494, 83);
            this.mtxtCelular.Mask = "(00)00000-0000";
            this.mtxtCelular.Name = "mtxtCelular";
            this.mtxtCelular.Size = new System.Drawing.Size(244, 30);
            this.mtxtCelular.TabIndex = 2;
            this.mtxtCelular.Tag = "obg:Celular";
            this.mtxtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnExcluirVendedor
            // 
            this.btnExcluirVendedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirVendedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluirVendedor.ForeColor = System.Drawing.Color.Red;
            this.btnExcluirVendedor.Location = new System.Drawing.Point(621, 281);
            this.btnExcluirVendedor.Name = "btnExcluirVendedor";
            this.btnExcluirVendedor.Size = new System.Drawing.Size(117, 37);
            this.btnExcluirVendedor.TabIndex = 10;
            this.btnExcluirVendedor.Text = "Excluir";
            this.btnExcluirVendedor.UseVisualStyleBackColor = false;
            // 
            // btnAlterarVendedor
            // 
            this.btnAlterarVendedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterarVendedor.FlatAppearance.BorderSize = 0;
            this.btnAlterarVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlterarVendedor.Location = new System.Drawing.Point(439, 281);
            this.btnAlterarVendedor.Name = "btnAlterarVendedor";
            this.btnAlterarVendedor.Size = new System.Drawing.Size(117, 37);
            this.btnAlterarVendedor.TabIndex = 9;
            this.btnAlterarVendedor.Text = "Alterar";
            this.btnAlterarVendedor.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVendedor
            // 
            this.btnCancelarVendedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarVendedor.ForeColor = System.Drawing.Color.Gray;
            this.btnCancelarVendedor.Location = new System.Drawing.Point(257, 281);
            this.btnCancelarVendedor.Name = "btnCancelarVendedor";
            this.btnCancelarVendedor.Size = new System.Drawing.Size(117, 37);
            this.btnCancelarVendedor.TabIndex = 8;
            this.btnCancelarVendedor.Text = "Cancelar";
            this.btnCancelarVendedor.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarVendedor
            // 
            this.btnCadastrarVendedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrarVendedor.Location = new System.Drawing.Point(75, 281);
            this.btnCadastrarVendedor.Name = "btnCadastrarVendedor";
            this.btnCadastrarVendedor.Size = new System.Drawing.Size(117, 37);
            this.btnCadastrarVendedor.TabIndex = 7;
            this.btnCadastrarVendedor.Text = "Cadastrar";
            this.btnCadastrarVendedor.UseVisualStyleBackColor = false;
            this.btnCadastrarVendedor.Click += new System.EventHandler(this.btnCadastrarVendedor_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(75, 223);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(370, 30);
            this.txtEndereco.TabIndex = 5;
            this.txtEndereco.Tag = "obg:Endereço";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(75, 153);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(370, 30);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Tag = "obg:E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(75, 83);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(370, 30);
            this.txtNomeVendedor.TabIndex = 1;
            this.txtNomeVendedor.Tag = "obg:Nome do vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do vendedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Celular:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdVendedor);
            this.groupBox2.Controls.Add(this.txtFiltrarNome);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 272);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar Vendedores";
            // 
            // grdVendedor
            // 
            this.grdVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVendedor.Location = new System.Drawing.Point(27, 86);
            this.grdVendedor.Name = "grdVendedor";
            this.grdVendedor.Size = new System.Drawing.Size(746, 165);
            this.grdVendedor.TabIndex = 0;
            // 
            // txtFiltrarNome
            // 
            this.txtFiltrarNome.Location = new System.Drawing.Point(273, 38);
            this.txtFiltrarNome.Name = "txtFiltrarNome";
            this.txtFiltrarNome.Size = new System.Drawing.Size(399, 30);
            this.txtFiltrarNome.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filtrar pelo nome:";
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(844, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grupoVendedores);
            this.Name = "frmVendedor";
            this.Text = "frmVendedor";
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            this.grupoVendedores.ResumeLayout(false);
            this.grupoVendedores.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoVendedores;
        private System.Windows.Forms.Button btnExcluirVendedor;
        private System.Windows.Forms.Button btnAlterarVendedor;
        private System.Windows.Forms.Button btnCancelarVendedor;
        private System.Windows.Forms.Button btnCadastrarVendedor;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtxtCelular;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbAtivo;
        private System.Windows.Forms.TextBox txtFiltrarNome;
        private System.Windows.Forms.Label label6;
    }
}