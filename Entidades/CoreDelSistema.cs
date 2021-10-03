

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class CoreDelSistema
    {
        static List<Usuario> usuarios;


        static CoreDelSistema()
        {
            usuarios = new List<Usuario>();
        }

        internal static List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }

        private static void cargarUsuarios()
        {
            CoreDelSistema.usuarios.Add(new Administrador("Pablo", "pass123", "11 3297-7202", 1));
        }



    }
}
