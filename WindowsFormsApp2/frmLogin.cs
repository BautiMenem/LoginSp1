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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        int intentos = 0;
        private void bbtnAceptar_Click(object sender, EventArgs e)
        {
            
            if ((txtUsuario.Text == "Adm" &&
                txtContra.Text == "@1a"))

            {
                if (lstModulo.Text == "ADM" || lstModulo.Text == "COM" || lstModulo.Text == "VTA")
                {
                    MessageBox.Show("Bienvenido");
                }
                else
                {
                    MessageBox.Show("Verifique los datos");
                }

                if (lstModulo.Text == "ADM")
                {
                    var myfrmAdm  = new frmAdm();
                    myfrmAdm.Show();
                    this.Hide();
                }

                if (lstModulo.Text == "COM")
                {
                    var myfrmCom  = new frmCom();
                    myfrmCom.Show();
                    this.Hide();

                }

                if (lstModulo.Text == "VTA")
                {
                    var myfrmVta = new frmVta();
                    myfrmVta.Show();
                    this.Hide();
                }
            }
            else
            {
                if ((txtUsuario.Text == "John" && txtContra.Text == "*2b"))
                {
                    if (lstModulo.Text == "SIST")
                    {
                        MessageBox.Show("Bienvenido");
                    }
                    else
                    {
                        MessageBox.Show("Verifique los datos");
                    }

                    if (lstModulo.Text == "SIST")
                    {
                        var myfrmSist  = new frmSist();
                        myfrmSist.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if ((txtUsuario.Text == "Ceci" && txtContra.Text == "*@3c"))
                    {
                        if (lstModulo.Text == "ADM" || lstModulo.Text == "VTA")
                        {
                            MessageBox.Show("Bienvenido");
                        }
                        else
                        {
                            MessageBox.Show("Verifique los datos");
                        }

                        if (lstModulo.Text == "ADM")
                        {
                           var myfrmAdm = new frmAdm();
                            myfrmAdm.Show();
                            this.Hide();
                        }

                        if (lstModulo.Text == "VTA")
                        {
                            var myfrmVta  = new frmVta();
                            myfrmVta.Show();
                            this.Hide();
                        }
                    }

                }

                if (txtUsuario.Text == "God" && txtContra.Text == "*@#4d")
                {
                    if (lstModulo.Text == "ADM" || lstModulo.Text == "SIST" || lstModulo.Text == "COM" ||
                        lstModulo.Text == "VTA")
                    {
                        MessageBox.Show("Bienvenido");
                    }
                    else
                    {
                        MessageBox.Show("Verifique los datos");
                    }

                    if (lstModulo.Text == "ADM")
                    {
                        var myfrmAdm  = new frmAdm();
                        myfrmAdm.Show();
                        this.Hide();
                    }

                    if (lstModulo.Text == "COM")
                    {
                        var myfrmCom = new frmCom();
                        myfrmCom.Show();
                        this.Hide();
                    }

                    if (lstModulo.Text == "VTA")
                    {
                         var myfrmVta  = new frmVta();
                         myfrmVta.Show();
                         this.Hide();
                    }

                    if (lstModulo.Text == "SIST")
                    {
                        var myfrmSist  = new frmSist();
                        myfrmSist.Show();
                        this.Hide();
                    }
                }


                MessageBox.Show("Usuario y/o contraseña incorrectos para el módulo seleccionado");
                intentos++; 
                if (intentos == 2) 
                {
                    this.Close();
                }


                









            }   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
