using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Core
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
                return Core.usuarioLogueado;
            }
            set
            {
                Core.usuarioLogueado = value;
            }
        }

        public static List<Cliente> Clientes
        { 
            get
            {
                return Core.clientes;
            }
        }


        static Core()
        {
            Usuarios = new List<Usuario>();
            clientes = new List<Cliente>();
            usuarioLogueado = new Administrador("admin", "admin");
            ultimoIdGenerado = 0;

            CargarUsuarios();
            CargarClientes();
        }
        
        #region Hardcodeo
        private static void CargarUsuarios()
        {
            Core.Usuarios.Add(new Administrador("Pablo", "pass123"));
            Core.Usuarios.Add(new Empleado("Juan", "password"));
            Core.Usuarios.Add(new Administrador("Daniela", "contra"));
            Core.Usuarios.Add(new Administrador("Sofía", "pass000"));
            Core.Usuarios.Add(new Empleado("Ramiro", "pass999"));
        }

        private static void CargarClientes()
        {
            Core.Clientes.Add(new Cliente("Julio", "julioribera@gmail.com", 2400));
            Core.Clientes.Add(new Cliente("Pedro", "pedro@gmail.com", 3605));
            Core.Clientes.Add(new Cliente("Domingo", "domingofaustino@gmail.com", 2400));
            Core.Clientes.Add(new Cliente("Domingo", "diegoarmando@gmail.com", 3893));
        }
        #endregion Hardcodeo

        public static int AsignarId()
        {
            return Core.ultimoIdGenerado++;
        }

        public static bool LoguearUsuario(string nombreDeUsuario, string password)
        {
            bool exit = false;

            foreach (Usuario item in Core.Usuarios)
            {
                if (item.NombreDeUsuario == nombreDeUsuario && item.Password == password)
                {
                    usuarioLogueado = item;
                    exit = true;
                }
            }
            if (exit == false)
            {
                throw new UsuarioInvalidoExcepcion();
            }

            return exit;
        }

        public static bool RegistrarUsuario(string nombreDeUsuario, string password)
        {
            bool exit = false;
            Empleado newUser = new Empleado();
            newUser.NombreDeUsuario = nombreDeUsuario;
            newUser.Password = password;

            if (TienePropiedadesNulas(newUser) == false && !Core.Usuarios.Contains(newUser))
            {
                Core.GuardarUsuario(newUser);
                exit = true;
            }
            return exit;
        }


        #region Búsquedas
        public static int BuscarClienteporId(int id)
        {
            int exit = -1;
            for (int i = 0; i < Core.Clientes.Count; i++)
            {
                if (Core.Clientes[i].IdCliente == id)
                {
                    exit = i;
                    break;
                }
            }
            return exit;
        }


        public static bool BuscarIndiceCliente(int index)
        {
            bool exit = false;

            if (Core.Clientes.ElementAtOrDefault(index) != default)
            {
                exit = true;
            }
            return exit;
        }


        public static List<int> BuscarClientesPorNombre(string nombre)
        {
            List<int> indiceDeNombresEncontrados = new List<int>();

            for (int i = 0; i < Core.Clientes.Count; i++)
            {
                if (Core.Clientes[i].Nombre == nombre)
                {
                    indiceDeNombresEncontrados.Add(i);
                }
            }
            return indiceDeNombresEncontrados;
        }
        #endregion Búsquedas

        public static int GuardarCliente(Cliente cliente)
        {
            Core.Clientes.Add(cliente);
            return Core.Clientes.IndexOf(cliente);
        }

        public static int GuardarUsuario(Usuario usuario)
        {
            Core.Usuarios.Add(usuario);
            return Core.Usuarios.IndexOf(usuario);
        }


        #region Validaciones
        public static bool ValidarEntero(string strNumero)
        {
            if (string.IsNullOrEmpty(strNumero) == false && int.TryParse(strNumero, out _) == true)
            {
                return true;
            }
            return false;
        }

        public static bool ValidarFlotante(string strNumero)
        {
            if (string.IsNullOrEmpty(strNumero) == false && float.TryParse(strNumero, out _) == true)
            {
                return true;
            }
            return false;
        }

        public static bool ValidarLetras(string cadena)
        {
            bool exit = false;
            if (string.IsNullOrEmpty(cadena) == false)
            {
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (char.IsLetter(cadena[i]) == true)
                    {
                        exit = true;
                    }
                }
            }
            return exit;
        }


        public static bool ValidarCelular(string celular)
        {
            bool exit = false;
            if (!string.IsNullOrEmpty(celular) && celular.Length < 16
                && celular.Length > 6)
            {
                exit = true;
            }
            return exit;
        }

        public static bool TienePropiedadesNulas(Usuario user)
        {
            if (user.Password == null || user.NombreDeUsuario == null)
            {
                return true;
            }
            return false;
        }
        #endregion Validaciones
    }
}
