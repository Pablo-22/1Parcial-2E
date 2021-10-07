using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class CoreDelSistema
    {
        //static List<Usuario> usuarios;
        static int ultimoIdGenerado;
        private static List<Cliente> clientes;
        static Usuario usuarioLogueado;

        public static List<Usuario> Usuarios { get; set; }
        public static int UltimoIdGenerado { get; set; }

        public static Usuario UsuarioLogueado 
        { 
            get
            {
                return CoreDelSistema.usuarioLogueado;
            }
            set
            {
                CoreDelSistema.usuarioLogueado = value;
            }
        }

        public static List<Cliente> Clientes
        { 
            get
            {
                return CoreDelSistema.clientes;
            }
        }


        static CoreDelSistema()
        {
            Usuarios = new List<Usuario>();
            clientes = new List<Cliente>();
            usuarioLogueado = new Administrador("admin", "admin", "00 0000-0000", -1);
            ultimoIdGenerado = 0;

            CargarUsuarios();
            CargarClientes();
        }


        private static void CargarUsuarios()
        {
            CoreDelSistema.Usuarios.Add(new Administrador("Pablo", "pass123", "11 3297-7202"));
        }

        private static void CargarClientes()
        {
            CoreDelSistema.Clientes.Add(new Cliente("Julio", "julioribera@gmail.com", 2400));
            CoreDelSistema.Clientes.Add(new Cliente("Pedro", "pedro@gmail.com", 3605));
            CoreDelSistema.Clientes.Add(new Cliente("Domingo", "domingofaustino@gmail.com", 2400));
            CoreDelSistema.Clientes.Add(new Cliente("Diego", "diegoarmando@gmail.com", 3893));
        }


        public static int AsignarId()
        {
            return CoreDelSistema.ultimoIdGenerado++;
        }

        public static bool LoguearUsuario(string nombreDeUsuario, string password)
        {
            bool exit = false;

            if (CoreDelSistema.ValidarUsuario(nombreDeUsuario) == true
                && CoreDelSistema.ValidarContrasenia(password) == true)
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

        public static bool ValidarUsuario(string nombreDeUsuario)
        {
            bool exit = false;
            if( !string.IsNullOrEmpty(nombreDeUsuario) 
                && nombreDeUsuario.Length < 16 )
            {
                exit = true;
            }
            return exit;
        }

        public static bool ValidarContrasenia(string password)
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
