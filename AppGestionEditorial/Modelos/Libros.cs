using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelos
{
    public class Libros: Documentos    
 {
        #region "Atributos"
        private int capitulos;

       
        #endregion

        #region "Propiedades"
        public int Capitulos
        {
            get { return capitulos; }
            set { capitulos = value; }
        }        
        #endregion

        #region "Constructores"
        
        public Libros(): base()
        {
            this.capitulos = 1;
        }

        public Libros(string nombre, string codigo, string autor, string editorial, string fechaDePublicacion, int capitulos): 
            base(nombre, codigo, autor, editorial, fechaDePublicacion)
        {
            this.capitulos = capitulos;
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                "\n Capitulos: " + this.capitulos;
        }

        public override bool Equals(object obj)
        {
            Libros doc = (Libros)obj;
            bool result = false;

            if ((base.Equals(doc)) &&
                (this.capitulos == doc.capitulos))
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