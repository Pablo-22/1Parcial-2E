using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Administrador : Usuario
    {
        public Administrador(string nombreDeUsuario, string password, string celular)
            : base(nombreDeUsuario, password, celular, ePermisos.Administrador)
        { }

        private bool AltaUsuario()
        {

            return true;
        }

        private bool EditarUsuario(int index, string nombreDeUsuario, string password, string celular, int legajo, ePermisos nivelDeAcceso)
        {
            bool exit = false;
            Usuario usuario = CoreDelSistema.Usuarios.ElementAtOrDefault<Usuario>(index);
           
            if (usuario != null)
            {
                exit = true;
                usuario.NombreDeUsuario = nombreDeUsuario;
                usuario.Password = password;
                usuario.legajo = legajo;
                usuario.NivelDeAcceso = nivelDeAcceso;
            }
            return exit;
        }


    }
}
