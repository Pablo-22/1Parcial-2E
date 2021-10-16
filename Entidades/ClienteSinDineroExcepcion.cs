using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClienteSinDineroExcepcion : Exception
    {
        public ClienteSinDineroExcepcion() : base("El cliente no tiene el dinero suficiente para la compra.")
        { }

        public ClienteSinDineroExcepcion(string message) : base(message)
        {
        }

        public ClienteSinDineroExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
