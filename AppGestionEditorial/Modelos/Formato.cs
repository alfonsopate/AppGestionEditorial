using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelos
{
    public class Formato
    {
        #region "Atributos"
        private string tipo;
        private string entrega;

        
        #endregion

        #region "Propiedades"
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Entrega
        {
            get { return entrega; }
            set { entrega = value; }
        }
        #endregion

        #region "Constructores"

        public  Formato()
        {
            this.tipo = "Tipo";
            this.entrega = "Entrega";
        }

        public Formato(string tipo, string entrega)
        {
            this.tipo = tipo;
            this.entrega =  entrega;
        }

        #endregion

        #region "Constructores"
    
    public override string ToString()
        {
            return "\n______________________" +
    "\n Tipo: " + this.tipo +
    "\n Entrega: " + this.entrega ;


        }

    public override bool Equals(object obj)
    {
        Formato doc = (Formato)obj;
        bool result = false;

        if ((this.tipo == doc.tipo) &&
            (this.entrega == doc.entrega))

            result = true;
        return result;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
        #endregion
    }
}
