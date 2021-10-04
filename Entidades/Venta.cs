using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Venta
    {
        float impuestos;
        float descuentos;
        float precioFinal;
        MetodoDePago metodo;
        List<Producto> productos;
        DateTime FechaDeVenta;

        #region Constructor y sobrecargas
        public Venta(float impuestos, float descuentos, float precioFinal, 
            MetodoDePago metodo, List<Producto> productos, DateTime fechaDeVenta)
        {
            this.impuestos = impuestos;
            this.descuentos = descuentos;
            this.precioFinal = precioFinal;
            this.metodo = metodo;
            this.productos = productos;
            FechaDeVenta = fechaDeVenta;
        }

        public Venta(float impuestos, float descuentos, float precioFinal, MetodoDePago metodo, List<Producto> productos) 
            : this(impuestos, descuentos, precioFinal, metodo, productos, DateTime.Now)
        {  }
        #endregion Constructor y sobrecargas

        public enum MetodoDePago
        {
            Debito,
            Credito,
            Efectivo,
            MercadoPago
        }

    }
}
