using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Administrador : Empleado
    {
        public Administrador(string nombreDeUsuario, string password, string celular)
            : base(nombreDeUsuario, password, celular, ePermisos.Administrador)
        { }

        public Administrador(string nombreDeUsuario, string password, string celular, int id)
            : base(nombreDeUsuario, password, celular, ePermisos.Administrador, id)
        { }

        private bool AltaUsuario()
        {

            return true;
        }

        private bool EditarUsuario(int index, string nombreDeUsuario, string password, string celular, int legajo, ePermisos nivelDeAcceso)
        {
            bool exit = false;
           
            if (CoreDelSistema.Usuarios[index] != null)
            {
                exit = true;
                CoreDelSistema.Usuarios[index].NombreDeUsuario = nombreDeUsuario;
                CoreDelSistema.Usuarios[index].Password = password;
                CoreDelSistema.Usuarios[index].legajo = legajo;
                CoreDelSistema.Usuarios[index].NivelDeAcceso = nivelDeAcceso;
                CoreDelSistema.Usuarios[index].celular = celular;
            }
            return exit;
        }
    }
}
