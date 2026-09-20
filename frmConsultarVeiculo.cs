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
    public partial class frmConsultarVeiculo : Form
    {
        public frmConsultarVeiculo()
        {
            InitializeComponent();
            Util.ConfigurarFormulario(this, "Consultar veículos");
            Util.ConfigurarGrid(grdPesquisaVeiculo);
            Tema.Aplicar(this);
        }

        private void frmConsultarVeiculo_Load(object sender, EventArgs e)
        {

        }
    }
}
