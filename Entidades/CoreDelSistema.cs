

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
        static Usuario usuarioLogueado;

        internal static List<Usuario> Usuarios { get => usuarios; set => usuarios = value; }
        public static int UltimoIdGenerado { get => ultimoIdGenerado; set => ultimoIdGenerado = value; }
        internal static List<Cliente> Clientes { get => clientes; set => clientes = value; }
        internal static Usuario UsuarioLogueado { get => usuarioLogueado; set => usuarioLogueado = value; }

        static CoreDelSistema()
        {
            usuarios = new List<Usuario>();
            clientes = new List<Cliente>();
            ultimoIdGenerado = 0;
        }


        private static void cargarUsuarios()
        {
            CoreDelSistema.Usuarios.Add(new Administrador("Pablo", "pass123", "11 3297-7202"));
        }

        private static void cargarClientes()
        {
            CoreDelSistema.Clientes.Add(new Cliente("Julio", "julioribera@gmail.com", 2400));
        }


        public static int asignarId()
        {
            return CoreDelSistema.ultimoIdGenerado++;
        }

        public static bool loguearUsuario(string nombreDeUsuario, string password)
        {
            bool exit = false;

            if (CoreDelSistema.validarUsuario(nombreDeUsuario) == true
                && CoreDelSistema.validarContrasenia(password) == true)
            {
                foreach (Usuario item in CoreDelSistema.Usuarios)
                {
                    if (item.NombreDeUsuario == nombreDeUsuario && item.Password == password)
                    {
                        usuarioLogueado = item;
                        exit = true;
                    }
                }
            }
            return exit;
        }

        public static bool validarUsuario(string nombreDeUsuario)
        {
            bool exit = false;
            if( !string.IsNullOrEmpty(nombreDeUsuario) 
                && nombreDeUsuario.Length < 16 )
            {
                exit = true;
            }
            return exit;
        }

        public static bool validarContrasenia(string password)
        {
            bool exit = false;
            if (!string.IsNullOrEmpty(password) && password.Length < 16 
                && password.Length > 6)
            {
                exit = true;
            }
            return exit;
        }
    }
}
