using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelos
{
    public class Factura : Cliente
    {
        #region Atributos

        private int idFactura;
        private string fecha;
        private string item;
        private string sucursal;
        private string estado;

        #endregion


        #region Propiedades
        public int IdFactura
        {
            get { return idFactura; }
            set { idFactura = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        public string Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion


        #region Constructores


        public Factura()
            : base()
        {

            this.idFactura = 123;
            this.fecha = "12/05/2015";
            this.item = "objeto";
            this.sucursal = "sucursal";
            this.estado = "comprado";

        }

        public Factura(int id, string nombres, string apellidos, string direccion, int telefono, string email, int idFactura, string fecha, string item, string sucursal, string estado)
            : base(id, nombres, apellidos, direccion, telefono, email)
        {


            this.idFactura = idFactura;
            this.fecha = fecha;
            this.item = item;
            this.sucursal = sucursal;
            this.estado = estado;
        }


        #endregion


        #region "Métodos SobreEscritos"
        public override string ToString()
        {
            return base.ToString() +
                               "\nIdf: " + this.idFactura +
                               "\nFecha: " + this.fecha +
                               "\nItem: " + this.item +
                                "\nSucursal: " + this.sucursal +
                                 "\nEstado: " + this.estado +
                               "\n_______________________________________";
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            Factura o = (Factura)obj;
            bool result = false;

            if (base.Equals(o) && (this.idFactura == o.idFactura) && (this.fecha == o.fecha)
                && (this.item == o.item) && (this.sucursal == o.sucursal) && (this.estado == o.estado))

                result = true;

            return result;
        }
        #endregion


    }
}