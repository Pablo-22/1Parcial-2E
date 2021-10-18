using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int idCliente;
        private float saldo;
        private Dictionary<int, Venta> historialDeCompras;
        private string email;
        private string nombre;
        private float distancia;


        #region Propiedades
        public float Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                if (Core.UsuarioLogueado is Administrador && this.ValidarSaldo(value) == true)
                {
                    saldo = value;
                }
            }
        }

        public string Email 
        {
            get
            {
                return this.email;
            }
            set
            {
                if (Core.UsuarioLogueado is Administrador && this.ValidarEmail(value) == true)
                {
                    this.email = value;
                }
                else
                {
                    this.email = "Email inválido";
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;  
            }
            set
            {
                if (Core.UsuarioLogueado is Administrador && this.ValidarNombre(value) == true)
                {
                    this.nombre = value;
                }
                else
                {
                    this.nombre = "Nombre inválido";
                }
            }
        }

        public int IdCliente 
        {
            get
            {
                return this.idCliente;
            }
        }

        public Dictionary<int, Venta> HistorialDeCompras 
        {
            get
            {
                return this.historialDeCompras;
            }
        }

        public float Distancia
        {
            get
            {
                return this.distancia;
            }
        }
        #endregion Propiedades

        #region Constructor y sobrecargas
        public Cliente()
        {
            var random = new Random();
            this.historialDeCompras = new Dictionary<int, Venta>();
            this.idCliente = Core.AsignarId();
            this.distancia = (float)(random.NextDouble() + 1) * 10;
        }

        public Cliente(float distancia, int id)
        {
            var random = new Random();
            this.historialDeCompras = new Dictionary<int, Venta>();
            this.distancia = distancia;
            this.idCliente = id;
        }

        public Cliente(string nombre, string email, float saldo)
        {
            var random = new Random();

            this.nombre = nombre;
            this.historialDeCompras = new Dictionary<int, Venta>();
            this.saldo = saldo;
            this.idCliente = Core.AsignarId();
            this.email = email;
            this.distancia = (float)(random.NextDouble() + 1) * 10 ;
        }


        public Cliente(string nombre, string email, float saldo, float distancia)
        {
            var random = new Random();

            this.nombre = nombre;
            this.historialDeCompras = new Dictionary<int, Venta>();
            this.saldo = saldo;
            this.idCliente = Core.AsignarId();
            this.email = email;
            this.distancia = distancia;
        }
        #endregion Constructor y sobrecargas

        /// <summary>
        /// Muestra los datos de un cliente.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder cliente = new StringBuilder();
            cliente.Append("Nombre: " + this.Nombre);
            cliente.Append("    ||    Saldo: $" + this.Saldo);
            cliente.Append("    ||    Email: " + this.Email);

            return cliente.ToString();
        }


        #region Validaciones
        /// <summary>
        /// Validación para el saldo,
        /// En esta capa van las validaciones referidas a las reglas de negocio.
        /// </summary>
        /// <param name="saldo"></param>
        /// <returns></returns>
        private bool ValidarSaldo(float saldo)
        {
            if(saldo > -1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validación para el email.
        /// En esta capa van las validaciones referidas a las reglas de negocio.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool ValidarEmail(string email)
        {
            if (email.Contains('@') == true && email.Contains("mail.com") == true)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validación para el nombre.
        /// En esta capa van las validaciones referidas a las reglas de negocio.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        private bool ValidarNombre(string nombre)
        {
            if (Core.ValidarLetras(nombre) == true && nombre != "admin" && nombre.Length < 20)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Llama a todas las validaciones de la capa de reglas de negocio.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="email"></param>
        /// <param name="saldo"></param>
        /// <returns></returns>
        public bool ValidarTodoCliente(string nombre, string email, string saldo)
        {
            if (Core.ValidarLetras(nombre)  &&  Core.ValidarFlotante(saldo) )
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Utiliza las propiedades para escribir todos los datos de un cliente.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="email"></param>
        /// <param name="saldo"></param>
        public void SetearTodoCliente(string nombre, string email, float saldo)
        {
            this.Nombre = nombre;
            this.Email = email;
            this.Saldo = saldo;
        }
        #endregion Validaciones
    }
}

