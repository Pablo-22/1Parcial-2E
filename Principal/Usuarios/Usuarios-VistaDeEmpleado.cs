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
    public partial class frmUsuarios_VistaDeEmpleado : frmUsuariosBase
    {
        public frmUsuarios_VistaDeEmpleado()
        {
            InitializeComponent();
        }

        private void frmUsuarios_VistaDeEmpleado_Load(object sender, EventArgs e)
        {
            lstUsuarios.DataSource = Core.Usuarios;
            lstUsuarios.Refresh();
        }

        private void btnCambiarContrasenia_Click(object sender, EventArgs e)
        {

        }
    }
}
