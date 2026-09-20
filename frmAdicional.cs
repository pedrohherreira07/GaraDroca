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
    public partial class frmAdicional : Form
    {
        public frmAdicional()
        {
            InitializeComponent();
            Util.ConfigurarFormulario(this, "Adicionais");
            Util.ConfigurarGrid(grdAdicionais);
            Tema.Aplicar(this);
        }

        private void frmAdicional_Load(object sender, EventArgs e)
        {

        }
    }
}
