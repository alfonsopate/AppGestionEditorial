using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelos
{
    public class Cientificos: Documentos

    {
   #region "Atributos"
        private int investigacion;
       
        #endregion

        #region "Propiedades"
        public int Investigacion
        {
            get { return investigacion; }
            set { investigacion = value; }
        } 
        #endregion

        #region "Constructores"
        
        public Cientificos(): base()
        {
            this.investigacion = 1;
        }

        public Cientificos(string nombre,  string autores, string editorial, string fechaDePublicacion, int investigacion) : 
            base(nombre,  autores, editorial, fechaDePublicacion)
        {
            this.investigacion = investigacion;
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                "\n Investigacion: " + this.investigacion;
        }

        public override bool Equals(object obj)
        {
            Cientificos doc = (Cientificos)obj;
            bool result = false;

            if ((base.Equals(doc)) &&
                (this.investigacion == doc.investigacion))
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