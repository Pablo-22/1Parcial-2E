using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Administrador : Usuario
    {
        public Administrador(string nombreDeUsuario, string password, string celular, int legajo)
            : base(nombreDeUsuario, password, Permisos.Administrador)
        { }


    }
}
