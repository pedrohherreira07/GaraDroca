using GaraDroca.Comum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaraDroca
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Tema.Aplicar(this);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMarca().ShowDialog();
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmModelo().ShowDialog();
        }

        private void adicionaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAdicional().ShowDialog();
        }

        private void subirOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSubirBD().ShowDialog();
        }

        private void gerenciarVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmVendedor().ShowDialog();
        }

        private void gerenciarVeículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmVeiculo().ShowDialog();
        }

        private void porPeríodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAcomanharVendaVendedores().ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
