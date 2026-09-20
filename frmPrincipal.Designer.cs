namespace GaraDroca
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subirOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarVeículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.veículoToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(116, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcasToolStripMenuItem,
            this.modelosToolStripMenuItem,
            this.adicionaisToolStripMenuItem,
            this.subirOnlineToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // modelosToolStripMenuItem
            // 
            this.modelosToolStripMenuItem.Name = "modelosToolStripMenuItem";
            this.modelosToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.modelosToolStripMenuItem.Text = "Modelos";
            this.modelosToolStripMenuItem.Click += new System.EventHandler(this.modelosToolStripMenuItem_Click);
            // 
            // adicionaisToolStripMenuItem
            // 
            this.adicionaisToolStripMenuItem.Name = "adicionaisToolStripMenuItem";
            this.adicionaisToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.adicionaisToolStripMenuItem.Text = "Adicionais";
            this.adicionaisToolStripMenuItem.Click += new System.EventHandler(this.adicionaisToolStripMenuItem_Click);
            // 
            // subirOnlineToolStripMenuItem
            // 
            this.subirOnlineToolStripMenuItem.Name = "subirOnlineToolStripMenuItem";
            this.subirOnlineToolStripMenuItem.Size = new System.Drawing.Size(189, 32);
            this.subirOnlineToolStripMenuItem.Text = "Subir online";
            this.subirOnlineToolStripMenuItem.Click += new System.EventHandler(this.subirOnlineToolStripMenuItem_Click);
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarVendedoresToolStripMenuItem});
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.vendedorToolStripMenuItem.Text = "Vendedor";
            // 
            // gerenciarVendedoresToolStripMenuItem
            // 
            this.gerenciarVendedoresToolStripMenuItem.Name = "gerenciarVendedoresToolStripMenuItem";
            this.gerenciarVendedoresToolStripMenuItem.Size = new System.Drawing.Size(274, 32);
            this.gerenciarVendedoresToolStripMenuItem.Text = "Gerenciar vendedores";
            this.gerenciarVendedoresToolStripMenuItem.Click += new System.EventHandler(this.gerenciarVendedoresToolStripMenuItem_Click);
            // 
            // veículoToolStripMenuItem
            // 
            this.veículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciarVeículosToolStripMenuItem});
            this.veículoToolStripMenuItem.Name = "veículoToolStripMenuItem";
            this.veículoToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.veículoToolStripMenuItem.Text = "Veículo";
            // 
            // gerenciarVeículosToolStripMenuItem
            // 
            this.gerenciarVeículosToolStripMenuItem.Name = "gerenciarVeículosToolStripMenuItem";
            this.gerenciarVeículosToolStripMenuItem.Size = new System.Drawing.Size(242, 32);
            this.gerenciarVeículosToolStripMenuItem.Text = "Gerenciar veículos";
            this.gerenciarVeículosToolStripMenuItem.Click += new System.EventHandler(this.gerenciarVeículosToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porPeríodoToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // porPeríodoToolStripMenuItem
            // 
            this.porPeríodoToolStripMenuItem.Name = "porPeríodoToolStripMenuItem";
            this.porPeríodoToolStripMenuItem.Size = new System.Drawing.Size(188, 32);
            this.porPeríodoToolStripMenuItem.Text = "Por período";
            this.porPeríodoToolStripMenuItem.Click += new System.EventHandler(this.porPeríodoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(690, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GaraDroca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subirOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarVeículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPeríodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}