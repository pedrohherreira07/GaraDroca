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
    public partial class frmModalAdicional : Form
    {
        public frmModalAdicional()
        {
            InitializeComponent();
            Util.ConfigurarFormulario(this, "Gerenciar adicionais");
            Tema.Aplicar(this);
        }

        private void frmModalAdicional_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarAdicional_Click(object sender, EventArgs e)
        {
            if (Util.ValidarCampos(gpAdicionais))
            {

            }
        }
    }
}
