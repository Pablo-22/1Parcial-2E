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

        /// <summary>
        /// Hardcodeo de ventas para la lista.
        /// </summary>
        private static void CargarVentas()
        {
            Ventas.Add(new Venta(Core.Clientes[0].IdCliente, Venta.MetodoDePago.Efectivo,
                Almacen.Productos[0]) );

            Core.Clientes[0].HistorialDeCompras.Add(0,new Venta(Core.Clientes[0].IdCliente, Venta.MetodoDePago.Efectivo,
                Almacen.Productos[0]));

            Ventas.Add(new Venta(Core.Clientes[1].IdCliente, Venta.MetodoDePago.Credito,
                Almacen.Productos[2]));

            Core.Clientes[2].HistorialDeCompras.Add(1, new Venta(Core.Clientes[1].IdCliente, Venta.MetodoDePago.Credito,
                Almacen.Productos[2]));

            Ventas.Add(new Venta(Core.Clientes[2].IdCliente, Venta.MetodoDePago.Debito,
                Almacen.Productos[1]));

            Core.Clientes[0].HistorialDeCompras.Add(2, new Venta(Core.Clientes[2].IdCliente, Venta.MetodoDePago.Debito,
                Almacen.Productos[1]));
        }

        /// <summary>
        /// Hardcodeo de productos para la lista
        /// </summary>
        private static void CargarProductos()
        {
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


        /// <summary>
        /// Comprueba que el índice recibido como parámetro exista en la lista de productos
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool BuscarIndiceProducto(int index)
        {
            bool exit = false;

            if(Almacen.Productos.ElementAtOrDefault(index) != null)
            {
                exit = true;
            }
            return exit;
        }

        /// <summary>
        /// Guarda un producto en la lista
        /// </summary>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static int GuardarProducto(Producto producto)
        {
            Productos.Add(producto);
            return Productos.IndexOf(producto);
        }

        /// <summary>
        /// Guarda una venta en la lista
        /// </summary>
        /// <param name="venta"></param>
        /// <returns></returns>
        public static int GuardarVenta(Venta venta)
        {
            Almacen.Ventas.Add(venta);
            return Almacen.Ventas.IndexOf(venta);
        }


        /// <summary>
        /// Recibe un id, y lo busca en la lista de ventas.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int BuscarVentaPorId(int id)
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

        /// <summary>
        /// Recibe un id y lo busca en la lista de productos.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int BuscarProductoPorId(int id)
        {
            int exit = -1;
            for (int i = 0; i < Almacen.Productos.Count; i++)
            {
                if (Almacen.Productos[i].IdProducto == id)
                {
                    exit = i;
                    break;
                }
            }
            return exit;
        }


        /// <summary>
        /// Comprueba que se den las condiciones para realizar una venta
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="venta"></param>
        public static void ConfirmarCondicionesDeVenta(int idCliente, Venta venta)
        {
            if (Almacen.Productos[Almacen.BuscarProductoPorId(venta.ProductoVendido.IdProducto)].Cantidad > 0 &&
                Almacen.Productos[Almacen.BuscarProductoPorId(venta.ProductoVendido.IdProducto)].Cantidad - venta.ProductoVendido.Cantidad > -1)
            {
                if (Core.Clientes[Core.BuscarClienteporId(idCliente)].Saldo 
                    - venta.PrecioTotal < 0 )
                {
                    throw new ClienteSinDineroExcepcion();
                }
            }
            else
            {
                throw new SinStockExcepcion();
            }
        }

    }
}