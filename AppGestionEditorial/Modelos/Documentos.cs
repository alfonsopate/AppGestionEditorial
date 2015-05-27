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
        private int nAutores;
        private string[] autores;
        private int nIdiomas;
        private string[] idiomas;
        private string editorial;
        private string categoria;
        private int numeroPaginas;
        private string fechaEdicion;
        private string fechaPublicacion;

       // private static List<Formato> = new List<Formato>;
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
        public int NAutores
        {
            get { return nAutores; }
            set { nAutores = value; }
        }
        public string[] Autores
        {
            get { return autores; }
            set { autores = value; }
        }
        public int NIdiomas
        {
            get { return nIdiomas; }
            set { nIdiomas = value; }
        }

        public string[] Idiomas
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
        public string FechaEdicion
        {
            get { return fechaEdicion; }
            set { fechaEdicion = value; }
        }

        public string FechaPublicacion
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
            this.editorial = "Editorial";
            this.categoria = "Categoria";
            this.numeroPaginas = 00 ;
            this.fechaEdicion =" 00/00/0000 ";
            this.fechaPublicacion = "dd/mm/aaaa";
            

        }

        public Documentos(string id, string titulo,int nAutores, string []autores,int nIdiomas ,string []idiomas, string editorial, string categoria,
            int numeroPaginas, string fechaEdicion, string fechaPublicacion)
        {
            this.id = id;
            this.titulo = titulo ;
            this.editorial = editorial;
            this.categoria = categoria;
            this.numeroPaginas = numeroPaginas;
            this.fechaEdicion = fechaEdicion;
            this.fechaPublicacion = fechaPublicacion;
            this.nAutores=nAutores;
            this.nIdiomas=nIdiomas;

            for (int i = 0; i < nIdiomas;i++ ) 
            {
                this.idiomas[i] = idiomas[i];
            }
            for (int i = 0; i < nAutores; i++)
            {
                this.autores[i] = autores[i];
            }
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
                (this.nAutores == doc.nAutores) &&
                (this.nIdiomas == doc.nIdiomas) &&
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