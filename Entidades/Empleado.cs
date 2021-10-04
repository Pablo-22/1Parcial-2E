using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Empleado : Usuario
    {
        //PASAR ESTOS DOS DATOS A LA CLASE USUARIO
        public string celular;
        public int legajo;

        public Empleado(string nombreDeUsuario, string password, string celular, int legajo) 
            : base(nombreDeUsuario, password, ePermisos.Empleado)
        {
            this.celular = celular;
            this.legajo = CoreDelSistema.asignarId();
        }

        public Empleado(string nombreDeUsuario, string password, string celular, ePermisos nivelDeAcceso)
            : base(nombreDeUsuario, password, nivelDeAcceso)
        {
            this.celular = celular;
            this.legajo = CoreDelSistema.asignarId();
        }
    }
}
