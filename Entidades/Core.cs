using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Core
    {
        private static List<Usuario> usuarios;
        private static int ultimoIdGenerado;
        private static List<Cliente> clientes;
        private static Usuario usuarioLogueado;

        public static List<Usuario> Usuarios { get => Core.usuarios; }
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
            Core.usuarios = new List<Usuario>();
            Core.clientes = new List<Cliente>();
            Core.usuarioLogueado = null;
            Core.ultimoIdGenerado = 0;

            CargarUsuarios();
            CargarClientes();
        }
        
        #region Hardcodeo
        private static void CargarUsuarios()
        {
            Core.Usuarios.Add(new Administrador("Pablo", "pass123"));
            Core.Usuarios.Add(new Empleado("Juan", "password"));
            Core.Usuarios.Add(new Administrador("Daniela", "contrasenia"));
            Core.Usuarios.Add(new Administrador("Sofia", "pass000"));
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

        /// <summary>
        /// Le suma 1 al atributo estático UltimoIdGenerado.
        /// esta función se utiliza en todo lugar, para asignar un ID.
        /// De esta forma se logra que no exista ningún número identificador repetido
        /// en toda la aplicación, sin importar la entidad.
        /// </summary>
        /// <returns> el ID generado (ultimoId + 1) </returns>
        public static int AsignarId()
        {
            return Core.ultimoIdGenerado++;
        }

        /// <summary>
        /// Recibe los datos de un usuario y los busca en la lista.
        /// 
        /// </summary>
        /// <param name="nombreDeUsuario"></param>
        /// <param name="password"></param>
        /// <returns>Devuelve true si lo encuentra y false si no lo encuentra.
        /// Si puede loguear, cambia el estado del atributo UsuarioLogueado, por el usuario encontrado.</returns>
        public static bool LoguearUsuario(string nombreDeUsuario, string password)
        {
            bool exit = false;

            foreach (Usuario item in Core.Usuarios)
            {
                if (item.NombreDeUsuario == nombreDeUsuario && item.Password == password)
                {
                    Core.UsuarioLogueado = item;
                    exit = true;
                }
            }
            if (exit == false)
            {
                throw new UsuarioInvalidoExcepcion();
            }

            return exit;
        }

        /// <summary>
        /// Comprueba que no exista un usuario con el mismo nombre recibido por parámetro,
        /// y si no lo encuentra, lo crea y lo añade a la lista.
        /// </summary>
        /// <param name="nombreDeUsuario"></param>
        /// <param name="password"></param>
        /// <returns>devuelve true si puede registrar, y false si no puede.</returns>
        public static bool RegistrarUsuario(string nombreDeUsuario, string password)
        {
            bool exit = false;
            Empleado newUser = new Empleado();
            newUser.NombreDeUsuario = nombreDeUsuario;
            newUser.Password = password;

            if (TienePropiedadesNulas(newUser) == false && !Core.UsuarioRepetido(newUser))
            {
                Core.GuardarUsuario(newUser);
                exit = true;
            }
            return exit;
        }


        #region Búsquedas
        public static int BuscarUsuarioPorId(int id)
        {
            int exit = -1;
            for (int i = 0; i < Core.Usuarios.Count; i++)
            {
                if ((int)Core.Usuarios[i] == id)
                {
                    exit = i;
                    break;
                }
            }
            return exit;
        }

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
        /// <summary>
        /// Guarda un cliente en la lista.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>Retorna el índice donde se guardó.</returns>
        public static int GuardarCliente(Cliente cliente)
        {
            Core.Clientes.Add(cliente);
            return Core.Clientes.IndexOf(cliente);
        }

        /// <summary>
        /// Guarda un usuario en la lista.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Retorna el índice donde se guardó.</returns>
        public static int GuardarUsuario(Usuario usuario)
        {
            Core.Usuarios.Add(usuario);
            return Core.Usuarios.IndexOf(usuario);
        }


        #region Validaciones
        /// <summary>
        /// Verifica que la cadena recibida como parámetro sea un entero.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Devuelve true si es un entero, false si no lo es.</returns>
        public static bool ValidarEntero(string strNumero)
        {
            if (string.IsNullOrEmpty(strNumero) == false && int.TryParse(strNumero, out _) == true)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que la cadena recibida como parámetro sea un flotante.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Devuelve true si es un flotante, false si no lo es.</returns>
        public static bool ValidarFlotante(string strNumero)
        {
            if (string.IsNullOrEmpty(strNumero) == false && float.TryParse(strNumero, out _) == true)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica que la cadena recibida como parámetro contenga solo letras.
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns>Devuelve true si la cadena contiene solo letras, false si no lo es.</returns>
        public static bool ValidarLetras(string cadena)
        {
            if (string.IsNullOrEmpty(cadena) == false)
            {
                for (int i = 0; i < cadena.Length; i++)
                {
                    if (char.IsLetter(cadena[i]) == false)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Comprueba que un usuario no contenga propiedades nulas
        /// </summary>
        /// <param name="user"></param>
        /// <returns> Devuelve true si tiene nombre o password nula, false si no. </returns>
        public static bool TienePropiedadesNulas(Usuario user)
        {
            if (user.Password == null || user.NombreDeUsuario == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Comprueba si ya existe un usuario con el mismo nombre y diferente id
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns> Retorna true si el usuario está repetido, false si no. </returns>
        public static bool UsuarioRepetido(Usuario usuario)
        {
            foreach (Usuario item in Core.Usuarios)
            {
                if (item.NombreDeUsuario == usuario.NombreDeUsuario && item.IdUsuario != usuario.IdUsuario)
                {
                    return true;
                }
            }
            return false;
        }

        #endregion Validaciones
    }
}
