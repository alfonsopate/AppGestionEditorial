using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelos
{
    public class Revistas: Documentos
    {

    #region "Atributos"
        private int articulos;
       
        #endregion

        #region "Propiedades"
        public int Articulos
        {
            get { return articulos; }
            set { articulos = value; }
        } 
        #endregion

        #region "Constructores"
        
        public Revistas(): base()
        {
            this.articulos = 1;
        }

        public Revistas(string nombre, string codigo, string autor, string editorial, string fechaDePublicacion, int articulos): 
            base(nombre, codigo, autor, editorial, fechaDePublicacion)
        {
            this.articulos = articulos;
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                "\n Articulos: " + this.articulos;
        }

        public override bool Equals(object obj)
        {
            Revistas doc = (Revistas)obj;
            bool result = false;

            if ((base.Equals(doc)) &&
                (this.articulos == doc.articulos))
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