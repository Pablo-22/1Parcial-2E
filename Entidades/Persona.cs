using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private int idUsuario;
        private string nombreDeUsuario;

        public string NombreDeUsuario
        {
            get
            {
                return this.nombreDeUsuario;
            }
            set
            {
                if (this.ValidarNombre(value) == true)
                {
                    this.nombreDeUsuario = value;
                }
            }
        }

        public int IdUsuario
        {
            get
            {
                return this.idUsuario;
            }
        }

        public Persona() : this(Core.AsignarId())
        { }

        public Persona(int id)
        {
            this.idUsuario = id;
        }

        public Persona(string nombreDePersona) : this()
        {
            this.nombreDeUsuario = nombreDePersona;
        }

        public Persona(string nombreDePersona, int id) : this(nombreDePersona)
        {
            this.idUsuario = id;
        }


        /// <summary>
        /// Valida el nombre. En esta capa se realizan las validaciones de reglas de negocio.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>true si es válido, false si no es válido</returns>
        private bool ValidarNombre(string nombre)
        {
            if (Core.ValidarLetras(nombre) == true && nombre != "admin" && nombre.Length < 20)
            {
                return true;
            }
            return false;
        }
    }
}
