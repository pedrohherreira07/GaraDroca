namespace GaraDroca
{
    partial class frmModalAdicional
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
            this.gpAdicionais = new System.Windows.Forms.GroupBox();
            this.btnExcluirAdicional = new System.Windows.Forms.Button();
            this.btnAlterarAdicional = new System.Windows.Forms.Button();
            this.btnCancelarAdicional = new System.Windows.Forms.Button();
            this.btnCadastrarAdicional = new System.Windows.Forms.Button();
            this.txtAdicional = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpAdicionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpAdicionais
            // 
            this.gpAdicionais.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpAdicionais.Controls.Add(this.btnExcluirAdicional);
            this.gpAdicionais.Controls.Add(this.btnAlterarAdicional);
            this.gpAdicionais.Controls.Add(this.btnCancelarAdicional);
            this.gpAdicionais.Controls.Add(this.btnCadastrarAdicional);
            this.gpAdicionais.Controls.Add(this.txtAdicional);
            this.gpAdicionais.Controls.Add(this.label1);
            this.gpAdicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpAdicionais.Location = new System.Drawing.Point(17, 14);
            this.gpAdicionais.Name = "gpAdicionais";
            this.gpAdicionais.Size = new System.Drawing.Size(810, 192);
            this.gpAdicionais.TabIndex = 1;
            this.gpAdicionais.TabStop = false;
            this.gpAdicionais.Text = "Gerenciar adicionais";
            // 
            // btnExcluirAdicional
            // 
            this.btnExcluirAdicional.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExcluirAdicional.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExcluirAdicional.ForeColor = System.Drawing.Color.Red;
            this.btnExcluirAdicional.Location = new System.Drawing.Point(626, 133);
            this.btnExcluirAdicional.Name = "btnExcluirAdicional";
            this.btnExcluirAdicional.Size = new System.Drawing.Size(117, 37);
            this.btnExcluirAdicional.TabIndex = 5;
            this.btnExcluirAdicional.Text = "Excluir";
            this.btnExcluirAdicional.UseVisualStyleBackColor = false;
            // 
            // btnAlterarAdicional
            // 
            this.btnAlterarAdicional.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAlterarAdicional.FlatAppearance.BorderSize = 0;
            this.btnAlterarAdicional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAlterarAdicional.Location = new System.Drawing.Point(440, 133);
            this.btnAlterarAdicional.Name = "btnAlterarAdicional";
            this.btnAlterarAdicional.Size = new System.Drawing.Size(117, 37);
            this.btnAlterarAdicional.TabIndex = 4;
            this.btnAlterarAdicional.Text = "Alterar";
            this.btnAlterarAdicional.UseVisualStyleBackColor = false;
            // 
            // btnCancelarAdicional
            // 
            this.btnCancelarAdicional.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelarAdicional.ForeColor = System.Drawing.Color.Gray;
            this.btnCancelarAdicional.Location = new System.Drawing.Point(254, 133);
            this.btnCancelarAdicional.Name = "btnCancelarAdicional";
            this.btnCancelarAdicional.Size = new System.Drawing.Size(117, 37);
            this.btnCancelarAdicional.TabIndex = 3;
            this.btnCancelarAdicional.Text = "Cancelar";
            this.btnCancelarAdicional.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarAdicional
            // 
            this.btnCadastrarAdicional.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrarAdicional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCadastrarAdicional.Location = new System.Drawing.Point(68, 133);
            this.btnCadastrarAdicional.Name = "btnCadastrarAdicional";
            this.btnCadastrarAdicional.Size = new System.Drawing.Size(117, 37);
            this.btnCadastrarAdicional.TabIndex = 2;
            this.btnCadastrarAdicional.Text = "Cadastrar";
            this.btnCadastrarAdicional.UseVisualStyleBackColor = false;
            this.btnCadastrarAdicional.Click += new System.EventHandler(this.btnCadastrarAdicional_Click);
            // 
            // txtAdicional
            // 
            this.txtAdicional.Location = new System.Drawing.Point(68, 83);
            this.txtAdicional.Name = "txtAdicional";
            this.txtAdicional.Size = new System.Drawing.Size(675, 30);
            this.txtAdicional.TabIndex = 1;
            this.txtAdicional.Tag = "obg:Nome do adicional";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do adicional:";
            // 
            // frmModalAdicional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 223);
            this.Controls.Add(this.gpAdicionais);
            this.Name = "frmModalAdicional";
            this.Text = "frmModalAdicional";
            this.Load += new System.EventHandler(this.frmModalAdicional_Load);
            this.gpAdicionais.ResumeLayout(false);
            this.gpAdicionais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpAdicionais;
        private System.Windows.Forms.Button btnExcluirAdicional;
        private System.Windows.Forms.Button btnAlterarAdicional;
        private System.Windows.Forms.Button btnCancelarAdicional;
        private System.Windows.Forms.Button btnCadastrarAdicional;
        private System.Windows.Forms.TextBox txtAdicional;
        private System.Windows.Forms.Label label1;
    }
}