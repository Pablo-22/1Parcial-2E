using System;
using Entidades;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {

            if(Core.UsuarioLogueado is Administrador)
            {
                Administrador newUser = (Administrador)Core.UsuarioLogueado;
                newUser.ExportarVenta(Almacen.Ventas[0]);
            }
            else if(Core.UsuarioLogueado is Empleado)
            {
                Empleado newUser = (Empleado)Core.UsuarioLogueado;
                newUser.ExportarVenta(Almacen.Ventas[0]);
            }
        }
    }
}