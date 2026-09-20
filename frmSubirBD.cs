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
    public partial class frmSubirBD : Form
    {
        public frmSubirBD()
        {
            InitializeComponent();
            Util.ConfigurarFormulario(this, "Subir online");
            Util.ConfigurarGrid(grdItens);
            Tema.Aplicar(this);
        }

        private void frmSubirBD_Load(object sender, EventArgs e)
        {

        }
    }
}
