namespace GaraDroca
{
    partial class frmSubirBD
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grdItens = new System.Windows.Forms.DataGridView();
            this.grupoSubirBD = new System.Windows.Forms.GroupBox();
            this.cbTela = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubirOnlineAcesso = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItens)).BeginInit();
            this.grupoSubirBD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdItens);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(17, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(810, 297);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Itens encontrados";
            // 
            // grdItens
            // 
            this.grdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdItens.Location = new System.Drawing.Point(3, 26);
            this.grdItens.Name = "grdItens";
            this.grdItens.Size = new System.Drawing.Size(804, 268);
            this.grdItens.TabIndex = 0;
            // 
            // grupoSubirBD
            // 
            this.grupoSubirBD.Controls.Add(this.cbTela);
            this.grupoSubirBD.Controls.Add(this.label7);
            this.grupoSubirBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoSubirBD.Location = new System.Drawing.Point(17, 15);
            this.grupoSubirBD.Name = "grupoSubirBD";
            this.grupoSubirBD.Size = new System.Drawing.Size(810, 155);
            this.grupoSubirBD.TabIndex = 11;
            this.grupoSubirBD.TabStop = false;
            this.grupoSubirBD.Text = "Subir Online";
            // 
            // cbTela
            // 
            this.cbTela.FormattingEnabled = true;
            this.cbTela.Items.AddRange(new object[] {
            "Vendedor",
            "Marca",
            "Adicional"});
            this.cbTela.Location = new System.Drawing.Point(262, 84);
            this.cbTela.Name = "cbTela";
            this.cbTela.Size = new System.Drawing.Size(285, 33);
            this.cbTela.TabIndex = 1;
            this.cbTela.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Selecione a tela:";
            // 
            // btnSubirOnlineAcesso
            // 
            this.btnSubirOnlineAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirOnlineAcesso.Location = new System.Drawing.Point(357, 497);
            this.btnSubirOnlineAcesso.Name = "btnSubirOnlineAcesso";
            this.btnSubirOnlineAcesso.Size = new System.Drawing.Size(140, 42);
            this.btnSubirOnlineAcesso.TabIndex = 12;
            this.btnSubirOnlineAcesso.Text = "Subir online";
            this.btnSubirOnlineAcesso.UseVisualStyleBackColor = true;
            // 
            // frmSubirBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 561);
            this.Controls.Add(this.btnSubirOnlineAcesso);
            this.Controls.Add(this.grupoSubirBD);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmSubirBD";
            this.Text = "frmSubirBD";
            this.Load += new System.EventHandler(this.frmSubirBD_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdItens)).EndInit();
            this.grupoSubirBD.ResumeLayout(false);
            this.grupoSubirBD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grdItens;
        private System.Windows.Forms.GroupBox grupoSubirBD;
        private System.Windows.Forms.ComboBox cbTela;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSubirOnlineAcesso;
    }
}