using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Principal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CoreDelSistema.LoguearUsuario(txtNombreDeUsuario.Text, txtContrasenia.Text) == true)
            {
                frmPrincipal main = new frmPrincipal();
                this.Hide();
                main.Show();
            }
            else
            {
                lblMensajeDeError.Text = "*Usuario o contraseña incorrecto/s";
            }
        }

        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            txtNombreDeUsuario.Text = "Pablo";
            txtContrasenia.Text = "pass123";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
