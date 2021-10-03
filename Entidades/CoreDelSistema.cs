

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class CoreDelSistema
    {
        static List<Usuario> usuarios;
        static int ultimoIdGenerado;
        static List<Cliente> clientes;

        internal static List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        public static int UltimoIdGenerado { get => ultimoIdGenerado; set => ultimoIdGenerado = value; }
        internal static List<Cliente> Clientes { get => clientes; set => clientes = value; }

        static CoreDelSistema()
        {
            usuarios = new List<Usuario>();
            clientes = new List<Cliente>();
            ultimoIdGenerado = 0;
        }


        private static void cargarUsuarios()
        {
            CoreDelSistema.Usuarios.Add(new Administrador("Pablo", "pass123", "11 3297-7202", 1));
        }

        private static void cargarClientes()
        {
            CoreDelSistema.Clientes.Add(new Cliente("Julio", "julioribera@gmail.com", 2400));
        }


        public static int asignarId()
        {
            return CoreDelSistema.ultimoIdGenerado++;
        }
    }
}
