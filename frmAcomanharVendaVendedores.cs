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
    public partial class frmAcomanharVendaVendedores : Form
    {
        public frmAcomanharVendaVendedores()
        {
            InitializeComponent();
            Util.ConfigurarFormulario(this, "Acompanhar vendedores");
            Util.ConfigurarGrid(grdPesquisaVenda);
            Tema.Aplicar(this);
        }

        private void frmAcomanharVendaVendedores_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPesquisarVendedor_Click(object sender, EventArgs e)
        {
            if (Util.ValidarCampos(grupoVendedor))
            {

            }
        }
    }
}
