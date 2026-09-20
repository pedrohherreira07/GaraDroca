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
    public partial class frmVeiculo : Form
    {
        public frmVeiculo()
        {
            InitializeComponent();
            Util.ConfigurarFormulario(this, "Veículos");
            Util.ConfigurarGrid(grdAdicionais);
            Tema.Aplicar(this);
        }

        private void frmVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            if (Util.ValidarCampos(grupoVeiculos))
            {

            }
        }
    }
}
