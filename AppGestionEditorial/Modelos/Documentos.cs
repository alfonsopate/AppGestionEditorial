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
        private string creadopor;
        private string nuEdicion;
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
        public string Creadopor
        {
            get { return creadopor; }
            set { creadopor = value; }
        }

        public string NuEdicion
        {
            get { return nuEdicion; }
            set { nuEdicion = value; }
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
            this.creadopor = "Autor:";
            this.nuEdicion = "Numero de Edicion";
            this.editorial = "Editorial";

        }

        public Documentos(string titulo, string fechaEdicion, string creadopor, string nuEdicion, string editorial)
        {
            this.titulo = titulo ;
            this.fechaEdicion = fechaEdicion;
            this.creadopor = creadopor;
            this.nuEdicion = nuEdicion;
            this.editorial = editorial;
        }
        #endregion 

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return "\n_________________"+
                "\n Titulo: " + this.titulo +
                " \n Fecha de Edicion: "+ this.fechaEdicion +
                "\n Autor: " + this.creadopor +
                "\n Nuemero de Edicion: " + this.nuEdicion +
                "\n Editorial: " + this.editorial ;
        }

        public override bool Equals(object obj)
        {
            Documentos doc = (Documentos)obj;
            bool result = false;

            if ((this.titulo == doc.titulo) &&
                (this.fechaEdicion == doc.fechaEdicion) &&
                (this.creadopor == doc.creadopor) &&
                (this.nuEdicion == doc.nuEdicion) &&
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