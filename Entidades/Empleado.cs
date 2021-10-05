using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Empleado : Usuario
    {
        public Empleado(string nombreDeUsuario, string password, string celular, int legajo) 
            : base(nombreDeUsuario, password, celular, ePermisos.Empleado)
        {
            this.legajo = legajo;
        }

        public Empleado(string nombreDeUsuario, string password, string celular, ePermisos nivelDeAcceso)
            : base(nombreDeUsuario, password, celular, nivelDeAcceso)
        { }
    }
}
