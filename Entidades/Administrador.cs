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
            : base(nombreDeUsuario, password, ePermisos.Administrador)
        { }

        private bool AltaUsuario()
        {
            return true;
        }

        private bool EditarUsuario(Empleado usuario, string nombreDeUsuario, string password, string celular, int legajo, ePermisos nivelDeAcceso)
        {
            foreach (Empleado item in CoreDelSistema.Usuarios)
            {
                if (item == usuario)
                {
                    usuario.NombreDeUsuario = nombreDeUsuario;
                    usuario.Password = password;
                    usuario.legajo = legajo;
                }
            }
            return true;
        }
    }
}
