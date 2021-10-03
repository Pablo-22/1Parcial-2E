using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cliente
    {
        float saldo;
        List<Venta> historialDeCompras;
        string email;
        string nombre;
        int idCliente;


        public Cliente(string nombre, string email, float saldo)
        {
            this.nombre = nombre;
            this.historialDeCompras = new List<Venta>();
            this.saldo = saldo;
            this.idCliente = CoreDelSistema.asignarId();
            this.email = email;
        }

    }
}
