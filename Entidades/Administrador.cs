using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Empleado
    {
        public Administrador(string nombreDeUsuario, string password)
            : base(nombreDeUsuario, password)
        { }

        private bool AltaUsuario()
        {

            return true;
        }

        private bool EditarUsuario(int index, string nombreDeUsuario, string password, int legajo)
        {
            bool exit = false;
           
            if (Core.Usuarios[index] != null)
            {
                exit = true;
                Core.Usuarios[index].NombreDeUsuario = nombreDeUsuario;
                Core.Usuarios[index].Password = password;
            }
            return exit;
        }



        public override void NuevoCliente()
        {
            Console.WriteLine("Desde Admin");
        }

        protected override string UsuarioAFormatoCsv(Usuario usuarioAConvertir)
        {
            StringBuilder usuario = new StringBuilder();
            usuario.Append(base.UsuarioAFormatoCsv(usuarioAConvertir));
            usuario.Append("," + usuarioAConvertir.Password);

            return usuario.ToString();
        }

        protected override string UsuariosAFormatoCsv()
        {
            StringBuilder usuarios = new StringBuilder();
            usuarios.AppendLine("Id,Nombre, Permisos, Password");
            foreach (Usuario item in Core.Usuarios)
            {
                usuarios.AppendLine(UsuarioAFormatoCsv(item));
            }
            return usuarios.ToString();
        }
    }
}
