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

        public Producto ProductoVendido
        {
            get
            {
                return this.producto;
            }
            set
            {
                if (ValidarProducto(value) == false)
                {
                    this.producto = value;
                }
            }
        }

        public MetodoDePago FormaDePago { get => metodo; set => metodo = value; }
        public DateTime FechaDeVenta { get => fechaDeVenta; set => fechaDeVenta = value; }
        public FormaDeEnvio MetodoDeEnvio { get => formaDeEnvio; set => formaDeEnvio = value; }
        public float PrecioEnvio { get => precioEnvio; set => precioEnvio = value; }

        #region Constructor y sobrecargas
        public Venta(int idCliente, MetodoDePago metodoPago,
                     Producto producto, DateTime fechaDeVenta)
        {
            this.producto = producto;
            this.metodo = metodoPago;
            this.fechaDeVenta = fechaDeVenta;
            idVenta = Core.AsignarId();
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

            cliente = Core.BuscarClienteporId(this.idCliente);
            precioEnvio = (float)Core.Clientes[cliente].Distancia * (int)this.formaDeEnvio;
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
            ticket.Append("    ||    Cantidad: " + this.producto.Cantidad);
            ticket.Append("    ||    Precio Total: $" + this.precioTotal);
            ticket.Append("    ||    Método de pago: " + this.metodo);
            ticket.Append("    ||    Fecha de venta: " + this.fechaDeVenta.ToShortDateString() );
            ticket.Append("    ||    Cliente: " + Core.Clientes[Core.BuscarClienteporId
                                                                    (this.IdCliente)].Nombre);
            ticket.Append("    ||    Forma de envío: " + this.formaDeEnvio);

            return ticket.ToString();
        }

        private bool ValidarProducto(Producto producto)
        {
            if(producto.Descripcion != null ||
                producto.Marca != null ||
                producto.Nombre != null)
            {
                return true;
            }
            return false;
        }


        public string TicketDeCompra()
        {
            StringBuilder venta = new StringBuilder();
            venta.AppendLine("--------- Petshop - Ticket de Compra ---------");
            venta.AppendLine("Producto comprado: " + this.ProductoVendido.Nombre);
            venta.AppendLine("Precio unitario: $" + this.ProductoVendido.Precio);
            venta.AppendLine("Cantidad: " + this.ProductoVendido.Cantidad);
            venta.AppendLine("Precio de envío: $" + this.PrecioEnvio);
            venta.AppendLine("----------------------------------------------");
            venta.AppendLine("Precio total: $" + this.PrecioTotal);
            venta.AppendLine("----------------------------------------------");
            venta.AppendLine("Fecha: " + this.FechaDeVenta.ToLongDateString() );
            venta.AppendLine("Cliente: " + Core.Clientes[Core.BuscarClienteporId(this.IdCliente)].Nombre);

            return venta.ToString();
        }
    }
}
