using System;
using Entidades;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {

            if(CoreDelSistema.UsuarioLogueado is Administrador)
            {
                Administrador newUser = (Administrador)CoreDelSistema.UsuarioLogueado;
                newUser.NuevoCliente();
            }
            else if(CoreDelSistema.UsuarioLogueado is Empleado)
            {
                Empleado newUser = (Empleado)CoreDelSistema.UsuarioLogueado;
                newUser.NuevoCliente();
            }
        }
    }
}