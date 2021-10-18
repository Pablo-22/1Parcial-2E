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
    public partial class frmUsuariosBase : frmBase
    {
        public frmUsuariosBase()
        {
            InitializeComponent();
        }

        protected void CargarUsuarios()
        {
            lstUsuarios.DataSource = Core.Usuarios;
            lstUsuarios.Refresh();
        }


        private void frmUsuariosBase_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
        }

        /// <summary>
        /// Exporta los datos de los usuarios a un archivo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportarTicket_Click(object sender, EventArgs e)
        {
            if (Core.UsuarioLogueado is Administrador)
            {
                Administrador adminLogueado = (Administrador)Core.UsuarioLogueado;
                adminLogueado.ExportarUsuarios();
            }
            else
            {
                Empleado adminLogueado = (Empleado)Core.UsuarioLogueado;
                adminLogueado.ExportarUsuarios();
            }
            //Reproducir sonido
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"notification-sound.wav");
            player.Play();
        }
    }
}
