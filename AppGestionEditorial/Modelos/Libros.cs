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
        private string nuEdicion;
       
        #endregion

        #region "Propiedades"
        public int Capitulos
        {
            get { return capitulos; }
            set { capitulos = value; }
        }
        public string NuEdicion
        {
            get { return nuEdicion; }
            set { nuEdicion = value; }
        }
        #endregion

        #region "Constructores"
        
        public Libros(): base()
        {
            this.capitulos = 1;
            this.nuEdicion = "Numero de Edicion";
        }

        public Libros(string titulo, string fechaEdicion, string autores, string editorial, int capitulos, string nuEdicion) :
            base(titulo, fechaEdicion, autores, editorial)
        {
            this.capitulos = capitulos;
            this.nuEdicion = nuEdicion;
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