using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelos
{
    public class Cientificos: Documentos

    {
   #region "Atributos"
        private int tipo;
       
        #endregion

        #region "Propiedades"
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        } 
        #endregion

        #region "Constructores"
        
        public Cientificos(): base()
        {
            this.tipo = 1;
        }

         public Cientificos(string id, string titulo, string autores, string idiomas, string editorial, string categoria, int numeropaginas, string fechaedicion, string fechapublicacion, int tipo)
            : base( id, titulo , autores, idiomas,editorial,categoria, numeropaginas, fechaedicion, fechapublicacion)
        {
            this.tipo = tipo;
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                "\n tipo : " + this.tipo;
        }

        public override bool Equals(object obj)
        {
            Cientificos doc = (Cientificos)obj;
            bool result = false;

            if ((base.Equals(doc)) &&
                (this.tipo == doc.tipo))
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