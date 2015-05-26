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
        private int nuEdicion;
        private string nivel;
       
        #endregion

        #region "Propiedades"
        public int Capitulos
        {
            get { return capitulos; }
            set { capitulos = value; }
        }
        public int NuEdicion
        {
            get { return nuEdicion; }
            set { nuEdicion = value; }
        }
        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        #endregion

        #region "Constructores"
        
        public Libros(): base()
        {
            this.capitulos = 2;
            this.nuEdicion =2;
            this.nivel = "nivel";
        }

        public Libros(string id, string titulo, string autores, string idiomas, string editorial, string categoria, int numeropaginas, string fechaedicion, string fechapublicacion, int capitulos, int nuEdicion, string nivel)
            : base( id, titulo , autores, idiomas,editorial,categoria, numeropaginas, fechaedicion, fechapublicacion)
        {
            this.capitulos = capitulos;
            this.nuEdicion = nuEdicion;
            this.nivel = nivel;

        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                "\n Numero de Capitulos: " + this.capitulos +
                "\n Numero de Edicion: " + this.nuEdicion +
                "\n Nivel:" + this.nivel;
        }

        public override bool Equals(object obj)
        {
            Libros doc = (Libros)obj;
            bool result = false;

            if ((base.Equals(doc)) &&
                (this.capitulos == doc.capitulos) &&
                (this.nuEdicion == doc.nuEdicion) &&
                (this.nivel == doc.nivel))
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