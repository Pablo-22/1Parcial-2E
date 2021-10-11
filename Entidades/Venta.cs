using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        int idVenta;
        int idCliente;
        float precioTotal;
        float precioEnvio;
        MetodoDePago metodo;
        Producto producto;
        DateTime fechaDeVenta;
        FormaDeEnvio formaDeEnvio;

        #region Constructor y sobrecargas
        public Venta(int idCliente, MetodoDePago metodoPago,
            Producto producto, DateTime fechaDeVenta)
        {
            this.producto = producto;
            this.metodo = metodoPago;
            this.fechaDeVenta = fechaDeVenta;
            idVenta = CoreDelSistema.AsignarId();
            this.formaDeEnvio = CalcularFormaDeEnvio();
            this.precioEnvio = ObtenerPrecioEnvio();
            this.precioTotal = ObtenerPrecioTotal();
            this.idCliente = idCliente;
        }

        public Venta(int idCliente, MetodoDePago metodoPago, Producto producto) 
            : this(idCliente, metodoPago, producto, DateTime.Now)
        {  }
        #endregion Constructor y sobrecargas

        public enum MetodoDePago
        {
            Efectivo,
            Debito,
            Credito,
            MercadoPago
        }

        public enum FormaDeEnvio
        {
            Moto = 23,
            Miniflete = 35
        }

        private FormaDeEnvio CalcularFormaDeEnvio()
        {
            if (this.producto.Peso > 20 || this.producto.Cantidad > 5)
            {
                return FormaDeEnvio.Miniflete;
            }
            else
            {
                return FormaDeEnvio.Moto;
            }
        }

        private float ObtenerPrecioEnvio()
        {
            int cliente;
            float precioEnvio;

            cliente = CoreDelSistema.BuscarClienteporId(this.idCliente);
            precioEnvio = (float)CoreDelSistema.Clientes[cliente].Distancia * (int)this.formaDeEnvio;
            return precioEnvio;
        }

        private float ObtenerPrecioTotal()
        {
            float precioTotal = this.producto.Precio * this.producto.Cantidad + ObtenerPrecioEnvio();
            return precioTotal;
        }


        public override string ToString()
        {
            StringBuilder ticket = new StringBuilder();
            ticket.Append("Producto: " + this.producto.Nombre);
            ticket.Append(" - Método de pago: " + this.metodo);
            ticket.Append(" - Fecha de venta: " + this.fechaDeVenta);
            ticket.Append(" - Precio Total: " + this.precioTotal);

            return ticket.ToString();
        }
    }
}