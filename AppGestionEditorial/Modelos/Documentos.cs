using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelos
{
    public class Documentos
    {
        #region "Atributos"
        private string titulo;
        private string fechaEdicion;
        private string autores;
        private string editorial;

        #endregion

        #region "Atributos"
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string FechaEdicion
        {
            get { return fechaEdicion; }
            set { fechaEdicion = value; }
        }
        public string Autores
        {
            get { return autores; }
            set { autores = value; }
        }
        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }
        #endregion


        #region "Constructores"
        public Documentos ()
        {
            this.titulo = "Titulo del Documento";
            this.fechaEdicion = "dd/mm/aaaa";
            this.autores = "Autores:";
            this.editorial = "Editorial";

        }

        public Documentos(string titulo, string fechaEdicion, string autores, string editorial)
        {
            this.titulo = titulo ;
            this.fechaEdicion = fechaEdicion;
            this.autores = autores;
            this.editorial = editorial;
        }
        #endregion 

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return "\n_________________"+
                "\n Titulo: " + this.titulo +
                " \n Fecha de Edicion: "+ this.fechaEdicion +
                "\n Autores: " + this.autores +
                "\n Editorial: " + this.editorial ;
        }

        public override bool Equals(object obj)
        {
            Documentos doc = (Documentos)obj;
            bool result = false;

            if ((this.titulo == doc.titulo) &&
                (this.fechaEdicion == doc.fechaEdicion) &&
                (this.autores== doc.autores) &&
                (this.editorial == doc.editorial))

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