using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelos
{
    public class Cliente: Factura
    {
        #region atributos
        private int id;
        private string nombres;
        private string apellidos;
        private string direccion;
        private int telefono;
        private string email;

        #endregion

        #region propiedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        #region constructores
        public Cliente()
        {
            this.id = 0;
            this.nombres = "nombre";
            this.apellidos = "apellido";
            this.direccion = "xxxxx";
            this.telefono = 000000;
            this.email = "xxxxx@gmail.com";
        }
        public Cliente(int id, string nombres, string apellidos, string direccion, int telefono, string email)
        {

            this.id = id;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;

        }
        #endregion
        #region "Métodos SobreEscritos"

        public override string ToString()
        {
            return base.ToString() +
                               "\n Id " + this.id +
                               "\n Nombres " + this.nombres +
                               "\n Apellidos " + this.apellidos +
                               "\n Direccion " + this.direccion +
                               "\n Telefono " + this.telefono +
                               "\n Email " + this.email +
                               "\n_______________________________________";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Cliente o = (Cliente)obj;
            bool result = false;

            if (base.Equals(o) && (this.id == o.id)
                && (this.nombres == o.nombres)
                && (this.apellidos == o.apellidos)
                && (this.direccion == o.direccion)
                && (this.telefono == o.telefono)
                && (this.email == o.email)
                )

                result = true;

            return result;
        }
        #endregion



    }
}