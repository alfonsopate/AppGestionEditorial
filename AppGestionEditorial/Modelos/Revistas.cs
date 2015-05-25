using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelos
{
    public class Revistas: Documentos
    {

    #region "Atributos"

        private int nVolumen;
        private int nArticulos;
        
        #endregion

        #region "Propiedades"

        public int NVolumen
        {
            get { return nVolumen; }
            set { nVolumen = value; }
        }
        public int NArticulos
        {
            get { return nArticulos; }
            set { nArticulos = value; }
        } 
        #endregion

        #region "Constructores"
        
        public Revistas(): base()
        {
            this.nVolumen = 1;
            this.nArticulos = 1;
        }
         public Revistas(string id, string titulo, string autores, string idiomas, string editorial, string categoria, int numeropaginas, DateTime fechaedicion, DateTime fechapublicacion, int nVolumen,int nArticulos)
            : base( id, titulo , autores, idiomas,editorial,categoria, numeropaginas, fechaedicion, fechapublicacion)

        
        {
            this.nVolumen = nVolumen;
            this.nArticulos = nArticulos;
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                "\nNumero de volumenes: " + this.nVolumen +
                "\n Articulos: " + this.nArticulos;
        }

        public override bool Equals(object obj)
        {
            Revistas doc = (Revistas)obj;
            bool result = false;

            if ((base.Equals(doc)) &&
                (this.nVolumen == doc.nVolumen) &&
                (this.nArticulos == doc.nArticulos))
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