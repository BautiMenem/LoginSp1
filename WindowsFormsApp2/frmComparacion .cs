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
            if (optMayor.Checked)
            {
                if (Convert.ToInt32(txtUno.Text) > (Convert.ToInt32(txtDos.Text)


                    MessageBox.Show("El numero 1 SI es mayor");
                else
                {
                    MessageBox.Show("El numero uno NO es mayor");
                }
            }

        }
    }
}
