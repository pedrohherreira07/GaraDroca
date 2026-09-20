using System;
using System.Windows.Forms;

namespace GaraDroca.Comum
{
    public static class Util
    {
        public static void ConfigurarFormulario(Form formulario, string titulo)
        {
            formulario.Text = titulo;
            formulario.MaximizeBox = false;
            formulario.MinimizeBox = false;
            formulario.StartPosition = FormStartPosition.CenterScreen;
            formulario.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public static void ConfigurarGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AllowUserToAddRows = false;
            grid.RowHeadersVisible = false;
            grid.AllowUserToResizeRows = false;
            grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        public static bool ValidarCampos(GroupBox grupo)
        {
            string campos = "";
            bool flag = true;

            foreach(var item in grupo.Controls)
            {
                //Textbox

                if (item is TextBox && ((TextBox)item).Tag.ToString().Contains("obg"))
                {
                    var campo = ((TextBox)item);
                    
                    //Verificar se é vazio
                    if(campo.Text.Trim() == string.Empty)
                    {
                        flag = false;
                        campos += "-" + campo.Tag.ToString().Split(':')[1]+"\n"; 
                    }
                }

                //maskedTextBox
                else if(item is MaskedTextBox && ((MaskedTextBox)item).Tag.ToString().Contains("obg"))
                {
                    var campo = ((MaskedTextBox)item);

                    //Verificar se é vazio
                    if(campo.Text.Trim() == string.Empty)
                    {
                        flag = false;
                        campos += "-" + campo.Tag.ToString().Split(':')[1]+"\n";
                    }
                }

                //Combobox
                else if(item is ComboBox && ((ComboBox)item).Tag.ToString().Contains("obg"))
                {
                    var campo = ((ComboBox)item);

                    //verificar se é vazio
                    if(campo.SelectedIndex == -1)
                    {
                        flag = false;
                        campos += "-" + campo.Tag.ToString().Split(':')[1] + "\n";
                    }
                } 
            }

            if(!flag)
            {
                MessageBox.Show("Corrigir o(s) campos(s)\n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return flag;
        }
    }
}
