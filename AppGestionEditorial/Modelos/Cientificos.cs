using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelos
{
    public class Cientificos: Documentos

    {
   #region "Atributos"
        private string tipo;
       
        #endregion

        #region "Propiedades"
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        } 
        #endregion

        #region "Constructores"
        
        public Cientificos(): base()
        {
            this.tipo = "";
        }

        public Cientificos(string codigo, string titulo, int nAutores, string[] autores, int nIdioma, string[] idioma, string editorial,
           string categoria, int nPaginas, string fEdicion, string fPublicacion, string tipo)
            : base(codigo, titulo, nAutores, autores, nIdioma, idioma, editorial,
            categoria, nPaginas, fEdicion, fPublicacion)
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