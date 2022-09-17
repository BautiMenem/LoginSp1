using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void bbtnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Adm" &&
                txtContra.Text == "@1a" && lstModulo.Text == "ADM" ||
                lstModulo.Text == "COM"|| lstModulo.Text == "VTA") ||

                (txtUsuario.Text == "John" &&
                txtContra.Text == "*2b" && lstModulo.Text == "SIST") ||

                (txtUsuario.Text == "Ceci" &&
                txtContra.Text == "*@3c" && lstModulo.Text == "ADM" ||
                lstModulo.Text == "VTA") ||

                (txtUsuario.Text == "God" &&
                txtContra.Text == "*@#4d" && lstModulo.Text == "ADM" ||
                lstModulo.Text == " SIST" || lstModulo.Text == "COM" ||
                lstModulo.Text == "VTA"))

             MessageBox.Show("Bienvenido");

            else
            {
             MessageBox.Show("Incorrecto");
            }
            

            
                
        }
    }
}
