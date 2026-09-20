namespace GaraDroca
{
    partial class frmAcomanharVendaVendedores
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
            this.grupoVendedor = new System.Windows.Forms.GroupBox();
            this.btnPesquisarVendedor = new System.Windows.Forms.Button();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdPesquisaVenda = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.grupoVendedor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisaVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoVendedor
            // 
            this.grupoVendedor.Controls.Add(this.btnPesquisarVendedor);
            this.grupoVendedor.Controls.Add(this.dtInicial);
            this.grupoVendedor.Controls.Add(this.dtFinal);
            this.grupoVendedor.Controls.Add(this.cbVendedor);
            this.grupoVendedor.Controls.Add(this.label3);
            this.grupoVendedor.Controls.Add(this.label2);
            this.grupoVendedor.Controls.Add(this.label1);
            this.grupoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoVendedor.Location = new System.Drawing.Point(18, 19);
            this.grupoVendedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grupoVendedor.Name = "grupoVendedor";
            this.grupoVendedor.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grupoVendedor.Size = new System.Drawing.Size(810, 306);
            this.grupoVendedor.TabIndex = 0;
            this.grupoVendedor.TabStop = false;
            this.grupoVendedor.Text = "Filtrar por Vendedor";
            // 
            // btnPesquisarVendedor
            // 
            this.btnPesquisarVendedor.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisarVendedor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPesquisarVendedor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPesquisarVendedor.Location = new System.Drawing.Point(320, 231);
            this.btnPesquisarVendedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPesquisarVendedor.Name = "btnPesquisarVendedor";
            this.btnPesquisarVendedor.Size = new System.Drawing.Size(162, 51);
            this.btnPesquisarVendedor.TabIndex = 4;
            this.btnPesquisarVendedor.Text = "Pesquisar";
            this.btnPesquisarVendedor.UseVisualStyleBackColor = false;
            this.btnPesquisarVendedor.Click += new System.EventHandler(this.btnPesquisarVendedor_Click);
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(66, 180);
            this.dtInicial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(298, 30);
            this.dtInicial.TabIndex = 2;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(443, 180);
            this.dtFinal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(298, 30);
            this.dtFinal.TabIndex = 3;
            // 
            // cbVendedor
            // 
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(66, 92);
            this.cbVendedor.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(675, 33);
            this.cbVendedor.TabIndex = 1;
            this.cbVendedor.Tag = "obg:Selecione o vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Data final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o vendedor:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdPesquisaVenda);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 342);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.groupBox2.Size = new System.Drawing.Size(810, 300);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado da pesquisa";
            // 
            // grdPesquisaVenda
            // 
            this.grdPesquisaVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPesquisaVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPesquisaVenda.Location = new System.Drawing.Point(4, 29);
            this.grdPesquisaVenda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grdPesquisaVenda.Name = "grdPesquisaVenda";
            this.grdPesquisaVenda.Size = new System.Drawing.Size(802, 265);
            this.grdPesquisaVenda.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(960, 953);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total de vendas";
            // 
            // frmAcomanharVendaVendedores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(844, 661);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grupoVendedor);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Inch, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(860, 700);
            this.MinimumSize = new System.Drawing.Size(860, 700);
            this.Name = "frmAcomanharVendaVendedores";
            this.Text = "frmAcomanhar vendas";
            this.Load += new System.EventHandler(this.frmAcomanharVendaVendedores_Load);
            this.grupoVendedor.ResumeLayout(false);
            this.grupoVendedor.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisaVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoVendedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.ComboBox cbVendedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPesquisaVenda;
        private System.Windows.Forms.Button btnPesquisarVendedor;
        private System.Windows.Forms.Label label4;
    }
}