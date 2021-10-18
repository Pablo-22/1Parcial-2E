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
    public partial class frmUsuarios_VistaDeAdmin : frmUsuariosBase
    {
        public frmUsuarios_VistaDeAdmin()
        {
            InitializeComponent();
        }

        private void frmUsuarios_VistaDeAdmin_Load(object sender, EventArgs e)
        {
            lstUsuarios.DataSource = Core.Usuarios;
            lstUsuarios.Refresh();
        }

        /// <summary>
        /// Llama al form de editar usuario, y le envía el usuario seleccionado.
        /// Luego refresca la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)lstUsuarios.SelectedItem;
            frmEditarUsuario editarUsuario = new frmEditarUsuario(usuario);
            editarUsuario.ShowDialog();
            if(editarUsuario.DialogResult == DialogResult.OK)
            {
                lstUsuarios.DataSource = null;
                lstUsuarios.DataSource = Core.Usuarios;
                lstUsuarios.Refresh();
            }
        }

        /// <summary>
        /// Elimina el usuario seleccionado y refresca la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int indiceDelUsuarioAExtraer;
            Usuario usuarioExtraido = (Usuario)lstUsuarios.SelectedItem;
            if (Core.UsuarioLogueado.IdUsuario != usuarioExtraido.IdUsuario)
            {
                indiceDelUsuarioAExtraer = Core.BuscarUsuarioPorId(usuarioExtraido.IdUsuario);
                Core.Usuarios.RemoveAt(indiceDelUsuarioAExtraer);
                lstUsuarios.DataSource = null;
                lstUsuarios.DataSource = Core.Usuarios;
                lstUsuarios.Refresh();

            }
        }
    }
}
