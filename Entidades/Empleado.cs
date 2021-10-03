using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Empleado : Usuario
    {
        private string celular;
        private int legajo;

        public Empleado(string nombreDeUsuario, string password, string celular, int legajo) 
            : base(nombreDeUsuario, password, Permisos.Empleado)
        {
            this.celular = celular;
            this.legajo = legajo;
        }

        public Empleado(string nombreDeUsuario, string password, string celular, int legajo, Permisos nivelDeAcceso)
            : base(nombreDeUsuario, password, nivelDeAcceso)
        {
            this.celular = celular;
            this.legajo = legajo;
        }

        public string Celular
        {
            get
            {
                return this.celular;
            }
            set
            {
                this.celular = value;
            }
        }

        public int Legajo
        {
            get
            {
                return this.legajo;
            }
            set
            {
                this.legajo = value;
            }
        }
    }
}
