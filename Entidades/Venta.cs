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

        public enum MetodoDePago
        {
            Debito,
            Credito,
            Efectivo,
            MercadoPago
        }

    }
}
