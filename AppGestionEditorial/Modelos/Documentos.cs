using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace AppGestionEditorial.Modelos
{
    public class Documentos
    {
        #region "Atributos"
        private string id;
        private string titulo;
        private string autores;
        private string idiomas;
        private string editorial;
        private string categoria;
        private int numeroPaginas;
        private DateTime fechaEdicion;
        private DateTime fechaPublicacion;
        #endregion

        #region "Atributos"

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }    
        public string Autores
        {
            get { return autores; }
            set { autores = value; }
        }
        public string Idiomas
        {
            get { return idiomas; }
            set { idiomas = value; }
        }
        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }
        public DateTime FechaEdicion
        {
            get { return fechaEdicion; }
            set { fechaEdicion = value; }
        }

        public DateTime FechaPublicacion
        {
            get { return fechaPublicacion; }
            set { fechaPublicacion = value; }
        }
        #endregion

        #region "Constructores"
        public Documentos ()
        {
            this.id = "xxxxx";
            this.titulo = "Titulo del Documento";
            this.autores = "Autores";
            this.idiomas = "Idiomas";
            this.editorial = "Editorial";
            this.categoria = "Categoria";
            this.numeroPaginas = 00 ;
            this.fechaEdicion = 00/00/0000;
            this.fechaPublicacion = "dd/mm/aaaa";
            

        }

        public Documentos(string id, string titulo, string autores, string idiomas, string editorial, string categoria,
            int numeroPaginas, DateTime fechaEdicion, DateTime fechaPublicacion)
        {
            this.id = id;
            this.titulo = titulo ;
            this.autores = autores;
            this.idiomas = idiomas;
            this.editorial = editorial;
            this.categoria = categoria;
            this.numeroPaginas = numeroPaginas;
            this.fechaEdicion = fechaEdicion;
            this.fechaPublicacion = fechaPublicacion;
        }
        #endregion 

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return "\n_________________"+
                "\n Id:" + this.id +
                "\n Titulo: " + this.titulo +
                "\n Autores: " + this.autores +
                "\n Idiomas: " + this.idiomas +
                "\n Editorial: " + this.editorial +
                "\n Categoria: " + this.categoria +
                "\n NumeroPaginas: " + this.numeroPaginas +
                "\n Fecha de Edicion: "+ this.fechaEdicion +
                "\n Fecha de Publicacion:" + this.fechaPublicacion ;
        }

        public override bool Equals(object obj)
        {
            Documentos doc = (Documentos)obj;
            bool result = false;

            if ((this.id == doc.id)&&
                (this.titulo == doc.titulo) &&
                (this.autores == doc.autores) &&
                (this.idiomas == doc.idiomas) &&
                (this.editorial == doc.editorial) &&
                (this.categoria == doc.categoria) &&
                (this.numeroPaginas == doc.numeroPaginas) &&
                (this.fechaEdicion == doc.fechaEdicion) &&
                (this.fechaPublicacion == doc.fechaPublicacion))

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