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
           
            if (CoreDelSistema.Usuarios[index] != null)
            {
                exit = true;
                CoreDelSistema.Usuarios[index].NombreDeUsuario = nombreDeUsuario;
                CoreDelSistema.Usuarios[index].Password = password;
            }
            return exit;
        }



        public override void NuevoCliente()
        {
            Console.WriteLine("Desde Admin");
        }
    }
}
