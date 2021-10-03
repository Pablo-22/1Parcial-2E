using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cliente : Usuario
    {
        float saldo;
        List<Producto> carrito;
        List<Venta> historialDeCompras;


        protected Cliente(string nombreDeUsuario, string password, float saldo)
            : base(nombreDeUsuario, password, Permisos.Cliente)
        {
            this.carrito = new List<Producto>();
            this.historialDeCompras = new List<Venta>();
            this.saldo = saldo;
        }
    }
}
