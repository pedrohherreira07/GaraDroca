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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
            Util.ConfigurarFormulario(this, "Gerenciar vendedores");
            Util.ConfigurarGrid(grdVendedor);
            Tema.Aplicar(this);
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarVendedor_Click(object sender, EventArgs e)
        {
            if(Util.ValidarCampos(grupoVendedores))
            {

            }
        }
    }
}
