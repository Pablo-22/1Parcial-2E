using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioInvalidoExcepcion : Exception
    {
        public UsuarioInvalidoExcepcion() : base("Credenciales inválidas.")
        { }

        public UsuarioInvalidoExcepcion(string message) : base(message)
        {
        }

        public UsuarioInvalidoExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
