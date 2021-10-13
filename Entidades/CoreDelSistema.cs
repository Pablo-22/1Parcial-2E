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
            usuarioLogueado = new Administrador("admin", "admin", "00 0000-0000");
            ultimoIdGenerado = 0;

            CargarUsuarios();
            CargarClientes();
        }
        
        #region Hardcodeo
        private static void CargarUsuarios()
        {
            CoreDelSistema.Usuarios.Add(new Administrador("Pablo", "pass123", "11 3297-7202"));
        }

        private static void CargarClientes()
        {
            CoreDelSistema.Clientes.Add(new Cliente("Julio", "julioribera@gmail.com", 2400));
            CoreDelSistema.Clientes.Add(new Cliente("Pedro", "pedro@gmail.com", 3605));
            CoreDelSistema.Clientes.Add(new Cliente("Domingo", "domingofaustino@gmail.com", 2400));
            CoreDelSistema.Clientes.Add(new Cliente("Domingo", "diegoarmando@gmail.com", 3893));
        }
        #endregion Hardcodeo

        public static int AsignarId()
        {
            return CoreDelSistema.ultimoIdGenerado++;
        }

        public static bool LoguearUsuario(string nombreDeUsuario, string password)
        {
            bool exit = false;

            if (CoreDelSistema.ValidarNombre(nombreDeUsuario) == true
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

        public static bool RegistrarUsuario(string nombreDeUsuario, string password)
        {
            bool exit = false;

            if (CoreDelSistema.ValidarNombre(nombreDeUsuario) == true
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


        #region Búsquedas
        public static int BuscarClienteporId(int id)
        {
            int exit = -1;
            for (int i = 0; i < CoreDelSistema.Clientes.Count; i++)
            {
                if (CoreDelSistema.Clientes[i].IdCliente == id)
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

            if (CoreDelSistema.Clientes.ElementAtOrDefault(index) != default)
            {
                exit = true;
            }
            return exit;
        }


        public static List<int> BuscarClientesPorNombre(string nombre)
        {
            List<int> indiceDeNombresEncontrados = new List<int>();

            for (int i = 0; i < CoreDelSistema.Clientes.Count; i++)
            {
                if (CoreDelSistema.Clientes[i].Nombre == nombre)
                {
                    indiceDeNombresEncontrados.Add(i);
                }
            }
            return indiceDeNombresEncontrados;
        }
        #endregion Búsquedas

        public static int AniadirCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
            return Clientes.IndexOf(cliente);
        }


        #region Validaciones
        public static int ValidarEntero(string strNumero)
        {
            int numeroFinal;
            if (string.IsNullOrEmpty(strNumero) == false && int.TryParse(strNumero, out numeroFinal) == true && numeroFinal > 0)
            {
                return numeroFinal;
            }
            return -1;
        }

        public static float ValidarFlotante(string strNumero)
        {
            float numeroFinal;
            if (string.IsNullOrEmpty(strNumero) == false && float.TryParse(strNumero, out numeroFinal) == true && numeroFinal > 0)
            {
                return numeroFinal;
            }
            return -1;
        }

        public static bool ValidarNombre(string nombre)
        {
            bool exit = false;
            if (string.IsNullOrEmpty(nombre) == false && nombre.Length < 18)
            {
                for (int i = 0; i < nombre.Length; i++)
                {
                    if (char.IsLetter(nombre[i]) == true)
                    {
                        exit = true;
                    }
                }
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
        #endregion Validaciones
    }
}
