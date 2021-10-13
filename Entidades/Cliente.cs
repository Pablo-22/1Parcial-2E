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
                if (CoreDelSistema.UsuarioLogueado.NivelDeAcceso == Usuario.ePermisos.Administrador)
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
                if (CoreDelSistema.UsuarioLogueado.NivelDeAcceso == Usuario.ePermisos.Administrador)
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
                if (CoreDelSistema.UsuarioLogueado.NivelDeAcceso == Usuario.ePermisos.Administrador 
                    && CoreDelSistema.ValidarNombre(value) == true)
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
            set
            {
                if (CoreDelSistema.UsuarioLogueado.NivelDeAcceso == Usuario.ePermisos.Administrador)
                {
                    this.historialDeCompras = value;
                }
            }
        }

        public float Distancia { get => distancia; }
        #endregion Propiedades


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


        public override string ToString()
        {
            StringBuilder cliente = new StringBuilder();
            cliente.Append("Nombre: " + this.Nombre);
            cliente.Append("    ||    Saldo: $" + this.Saldo);
            cliente.Append("    ||    Email: " + this.Email);

            return cliente.ToString();
        }
    }
}
