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
            this.capitulos = 0;
            this.nuEdicion = 0 ;
            this.nivel = "nivel";
        }

        public Libros(string codigo, string titulo, int nAutores, string[] autores, int nIdioma, string[] idioma, string editorial,
            string categoria, int nPaginas, string fEdicion, string fPublicacion, int capitulos, int nuEdicion, string nivel)
            : base(codigo, titulo, nAutores, autores, nIdioma, idioma, editorial,
            categoria, nPaginas, fEdicion, fPublicacion)
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