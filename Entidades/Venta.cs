using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        private int idVenta;
        private int idCliente;
        private float precioTotal;
        private float precioEnvio;
        private MetodoDePago metodo;
        private Producto producto;
        private DateTime fechaDeVenta;
        private FormaDeEnvio formaDeEnvio;

        public int IdVenta { get => idVenta;}
        public int IdCliente { get => idCliente; }

        public float PrecioTotal
        { 
            get
            {
                return this.precioTotal; 

            }
            set
            {
                this.precioTotal = value;
            }
        }

        public MetodoDePago Metodo { get => metodo; set => metodo = value; }
        public Producto Producto { get => producto; set => producto = value; }
        public DateTime FechaDeVenta { get => fechaDeVenta; set => fechaDeVenta = value; }
        public FormaDeEnvio FormaDeEnvio1 { get => formaDeEnvio; set => formaDeEnvio = value; }

        #region Constructor y sobrecargas
        public Venta(int idCliente, MetodoDePago metodoPago,
                     Producto producto, DateTime fechaDeVenta)
        {
            this.producto = producto;
            this.metodo = metodoPago;
            this.fechaDeVenta = fechaDeVenta;
            idVenta = CoreDelSistema.AsignarId();
            this.formaDeEnvio = CalcularFormaDeEnvio();
            this.idCliente = idCliente;
            this.precioEnvio = ObtenerPrecioEnvio();
            this.precioTotal = ObtenerPrecioTotal();
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
            float precioEnvio = 0;

            cliente = CoreDelSistema.BuscarClienteporId(this.idCliente);
            precioEnvio = (float)CoreDelSistema.Clientes[cliente].Distancia * (int)this.formaDeEnvio;
            return precioEnvio;
        }

        private float ObtenerPrecioTotal()
        {
            float precioTotal = this.producto.Precio * this.producto.Cantidad + this.precioEnvio;
            return precioTotal;
        }


        public override string ToString()
        {
            StringBuilder ticket = new StringBuilder();
            ticket.Append("Producto: " + this.producto.Nombre);
            ticket.Append("    ||    Precio Total: $" + this.precioTotal);
            ticket.Append("    ||    Método de pago: " + this.metodo);
            ticket.Append("    ||    Fecha de venta: " + this.fechaDeVenta);
            ticket.Append("    ||    Cliente: " + this.idCliente);
            ticket.Append("    ||    Forma de envío: " + this.formaDeEnvio);

            return ticket.ToString();
        }
    }
}
