using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Cliente
    {
        private float saldo;
        private List<Venta> historialDeCompras;
        private string email;
        private string nombre;
        private int idCliente;


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
                if (CoreDelSistema.UsuarioLogueado.NivelDeAcceso == Usuario.ePermisos.Administrador)
                {
                    this.nombre = value;
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
        #endregion Propiedades



        public Cliente(string nombre, string email, float saldo)
        {
            this.nombre = nombre;
            this.historialDeCompras = new List<Venta>();
            this.saldo = saldo;
            this.idCliente = CoreDelSistema.asignarId();
            this.email = email;
        }

    }
}
