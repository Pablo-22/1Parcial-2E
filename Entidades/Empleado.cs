using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Empleado : Usuario
    {
        public Empleado(string nombreDeUsuario, string password, string celular, ePermisos nivelDeAcceso, int id) 
            : base(nombreDeUsuario, password, celular, nivelDeAcceso)
        {
            this.idUsuario = id;
        }

        public Empleado(string nombreDeUsuario, string password, string celular, ePermisos nivelDeAcceso)
            : base(nombreDeUsuario, password, celular, nivelDeAcceso)
        { }
    }
}
