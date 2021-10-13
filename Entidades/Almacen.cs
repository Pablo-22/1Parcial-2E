using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Almacen
    {
        private static List<Producto> productos;
        private static List<Venta> ventas;

        public static List<Venta> Ventas
        {
            get { return ventas; }
        }


        public static List<Producto> Productos 
        { 
            get
            {
                return Almacen.productos;
            }
        }

        static Almacen()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>();
            CargarProductos();
            CargarVentas();
        }

        private static void CargarVentas()
        {
            Ventas.Add(new Venta(CoreDelSistema.Clientes[0].IdCliente, Venta.MetodoDePago.Efectivo,
                Almacen.Productos[0]) );

            Ventas.Add(new Venta(CoreDelSistema.Clientes[1].IdCliente, Venta.MetodoDePago.Credito,
                Almacen.Productos[2]));

            Ventas.Add(new Venta(CoreDelSistema.Clientes[2].IdCliente, Venta.MetodoDePago.Debito,
                Almacen.Productos[1]));
        }

        private static void CargarProductos()
        {

            /*
                string nombre;
                float precio;
                string marca;
                CategoriaAnimal tipoDeAnimal;
                CategoriaProducto tipoDeProducto;
                string descripción;
                int cantidad;
            */

            productos.Add(new Producto("Collar", 375, "petClothes",
                Producto.CategoriaAnimal.Perros, Producto.CategoriaProducto.Indumentaria,
                "Un excelente collar para tu perro",
                9, (float)0.3));

            productos.Add(new Producto("A. Balanceado", 480, "Pedigree",
                Producto.CategoriaAnimal.Perros, Producto.CategoriaProducto.Alimento,
                "Pedigree® Adulto Etapa 2 es alimento completo y balanceado, elaborado con fibras naturales y proteínas de alta calidad para acompañar a tu perro en su etapa adulta, cubriendo las 4 necesidades universales.",
                36, (float)2.5));

            productos.Add(new Producto("Rascador", 3410, "Puppis",
                Producto.CategoriaAnimal.Gatos, Producto.CategoriaProducto.Juguetes,
                "Los gatos tienen un impulso natural de rascarse: la acción les ayuda a eliminar material viejo de sus garras y marcar el territorio con las glándulas olorosas de sus patas.",
                3, 12));
        }



        public static bool BuscarIndiceProducto(int index)
        {
            bool exit = false;

            if(Almacen.Productos.ElementAtOrDefault(index) != null)
            {
                exit = true;
            }
            return exit;
        }

        public static int AniadirProducto(Producto producto)
        {
            Productos.Add(producto);
            return Productos.IndexOf(producto);
        }

        public static int BuscarVentaporId(int id)
        {
            int exit = -1;
            for (int i = 0; i < Almacen.Ventas.Count; i++)
            {
                if (Almacen.Ventas[i].IdVenta == id)
                {
                    exit = i;
                    break;
                }
            }
            return exit;
        }

    }
}
