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
        private List<Venta> historialDeCompras;
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
                if (CoreDelSistema.UsuarioLogueado is Administrador && this.ValidarSaldo(value) == true)
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
                if (CoreDelSistema.UsuarioLogueado is Administrador && this.ValidarEmail(value) == true)
                {
                    email = value;
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
                if (CoreDelSistema.UsuarioLogueado is Administrador && this.ValidarNombre(value) == true)
                {
                    this.nombre = value;
                }
                else
                {
                    this.nombre = null;
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

        public List<Venta> HistorialDeCompras 
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
            this.historialDeCompras = new List<Venta>();
            this.idCliente = CoreDelSistema.AsignarId();
            this.distancia = (float)(random.NextDouble() + 1) * 10;
        }

        public Cliente(string nombre, string email, float saldo)
        {
            var random = new Random();

            this.nombre = nombre;
            this.historialDeCompras = new List<Venta>();
            this.saldo = saldo;
            this.idCliente = CoreDelSistema.AsignarId();
            this.email = email;
            this.distancia = (float)(random.NextDouble() + 1) * 10 ;
        }


        public Cliente(string nombre, string email, float saldo, float distancia)
        {
            var random = new Random();

            this.nombre = nombre;
            this.historialDeCompras = new List<Venta>();
            this.saldo = saldo;
            this.idCliente = CoreDelSistema.AsignarId();
            this.email = email;
            this.distancia = distancia;
        }
        #endregion Constructor y sobrecargas


        public override string ToString()
        {
            StringBuilder cliente = new StringBuilder();
            cliente.Append("Nombre: " + this.Nombre);
            cliente.Append("    ||    Saldo: $" + this.Saldo);
            cliente.Append("    ||    Email: " + this.Email);

            return cliente.ToString();
        }


        #region Validaciones
        private bool ValidarSaldo(float saldo)
        {
            if(saldo > -1)
            {
                return true;
            }
            return false;
        }

        private bool ValidarVenta(Venta venta)
        {
            if (venta.ProductoVendido != null && (this.Saldo - venta.PrecioTotal) > -1)
            {
                return true;
            }
            return false;
        }

        private bool ValidarEmail(string email)
        {
            if (email.Contains('@') == true && email.Contains("email.com") == true)
            {
                return true;
            }
            return false;
        }

        private bool ValidarNombre(string nombre)
        {
            if (CoreDelSistema.ValidarLetras(nombre) == true && nombre != "admin" && nombre.Length < 20)
            {
                return true;
            }
            return false;
        }

        public bool ValidarTodoCliente(string nombre, string email, string saldo)
        {
            if (CoreDelSistema.ValidarLetras(nombre) && CoreDelSistema.ValidarLetras(email)
                &&  CoreDelSistema.ValidarFlotante(saldo) )
            {
                return true;
            }
            return false;
        }

        public void SetearTodoCliente(string nombre, string email, float saldo)
        {
            this.Nombre = nombre;
            this.Email = email;
            this.Saldo = saldo;
        }
        #endregion Validaciones
    }
}

