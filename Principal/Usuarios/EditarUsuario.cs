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
    public partial class frmEditarUsuario : frmBase
    {
        private Usuario usuario;

        public frmEditarUsuario()
        {
            InitializeComponent();
        }

        public frmEditarUsuario(Usuario usuarioAEditar) : this()
        {
            this.usuario = usuarioAEditar;
        }

        /// <summary>
        /// Carga los datos del usuario seleccionado para editar, 
        /// en los campos del form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmEditarUsuario_Load(object sender, EventArgs e)
        {
            txtNombreDeUsuario.Text = this.usuario.NombreDeUsuario;
            txtContrasenia.Text = this.usuario.Password;
            if (this.usuario is Administrador)
            {
                cmbNivelDeAcceso.SelectedItem = "Administrador";
            }
            else
            {
                cmbNivelDeAcceso.SelectedItem = "Empleado";
            }

        }

        /// <summary>
        /// Realiza verificaciones necesarias para la edición del usuario
        /// (comprueba que no existan usuarios con el nuevo nombre seleccionado)
        /// y edita el usuario seleccionado con los datos cargados en el form.
        /// Si no se logra, emite un MessageBox con el mensaje de error.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombreDeUsuario.Text != "" && txtContrasenia.Text != "")
            {
                if (Core.UsuarioLogueado is Administrador)
                {
                    Administrador usuarioLogueado = (Administrador)Core.UsuarioLogueado;

                    if (Core.UsuarioRepetido(Core.Usuarios[Core.BuscarUsuarioPorId(this.usuario.IdUsuario)]) == false)
                    {
                        Core.Usuarios[Core.BuscarUsuarioPorId(this.usuario.IdUsuario)] = usuarioLogueado.crearUsuario(this.usuario.IdUsuario,
                            txtNombreDeUsuario.Text, txtContrasenia.Text, cmbNivelDeAcceso.SelectedItem.ToString());

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido editar a este usuario correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Cancel;
                    }

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
