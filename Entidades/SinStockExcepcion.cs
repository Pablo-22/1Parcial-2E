using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class SinStockExcepcion : Exception
    {
        public SinStockExcepcion() : this("No hay stock disponible de ese producto")
        {
        }

        public SinStockExcepcion(string message) : base(message)
        {
        }

        public SinStockExcepcion(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
