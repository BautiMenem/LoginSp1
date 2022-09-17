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
    public partial class frmComparacion : Form
    {
        public frmComparacion()
        {
            InitializeComponent();
        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            if (optMayor.Checked == true)
            {
               if (Convert.ToInt32(txtUno.Text) > Convert.ToInt32(txtDos.Text))
               {
                    MessageBox.Show("El Número uno  SI es mayor");
               }
                else
                {
                    MessageBox.Show("El Número uno NO es mayor");
                }
            }

            if (optMenor.Checked == true)
            {
                if (Convert.ToInt32(txtUno.Text) < Convert.ToInt32(txtDos.Text))
                {
                    MessageBox.Show("El Número uno SI es menor");
                }
                else
                {
                    MessageBox.Show("El Número uno NO es menor");
                }
            }

            if (optIgual.Checked == true)
            {
                if (Convert.ToInt32(txtUno.Text) == Convert.ToInt32(txtDos.Text))
                {
                    MessageBox.Show("Los Números SI son iguales");
                }
                else
                {
                    MessageBox.Show("Los Números NO son iguales");
                }
            }

            if (optDesigual.Checked == true)
            {
                if (Convert.ToInt32(txtUno.Text) != Convert.ToInt32(txtDos.Text))
                {
                    MessageBox.Show("Los Números SI son desiguales");
                }
                else
                {
                    MessageBox.Show("Los Números NO son desiguales");
                }
            }
        
        }
    }
}
