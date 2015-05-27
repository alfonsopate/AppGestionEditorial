using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppGestionEditorial.Modelos;
using AppGestionEditorial.Datos;
using System.Xml;
using System.Web.Hosting;
using System.IO;
using System.Xml.Linq;
using AppGestionEditorial.Web;

namespace AppGestionEditorial.DocumentosXML
{
    public class LibrosRepositorios
    {
        #region Guardar Libros
        private static List<Libros> data = new List<Libros>();
        public List<Libros> getLibros()
        {
            // Creamos la lista genérica de Personas
            List<Libros> lista = new List<Libros>();

            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/DocumentosXML/LibrosRepositorios.xml");

            XDocument doc = XDocument.Load(ruta);

            var librosc = from c in doc.Descendants("Documentos") select c;

            foreach (XElement c in librosc.Elements("Libros"))
            {
                Libros libro = new Libros(

                        c.Element("Id").Value,
                        c.Element("Titulo").Value,
                        int.Parse(c.Element("NAutores").Value),
                     // r.Element("Autores").Value,
                        int.Parse(c.Element("NIdiomas").Value),
                     // r.Element("Idiomas").Value,
                        c.Element("Editoria").Value,
                        c.Element("Categorias").Value,
                        int.Parse(c.Element("Numero De Paginas").Value),
                        c.Element("Fecha De Edicion").Value,
                        c.Element("Fecha De Publicaion").Value,
                        int.Parse(c.Element("Numero De Tomos").Value),
                        int.Parse(c.Element("Numero De Capitulos").Value),
                        c.Element("Nivel").Value);
                                              
                lista.Add(libro);

            }


            return lista;
        }

        public void add(Libros c)
        {
            data.Add(c);
            WriteXML(data);

        }

        private void WriteXML(List<Libros> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/Libros.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Documentos");
            //Call create nodes method
            foreach (Libros c in list)
            {
                xmlwriter.WriteStartElement("Libros");
                xmlwriter.WriteElementString("Titulos Del Documento", c.Titulo);
                xmlwriter.WriteElementString("Editorial", c.Editorial);
                xmlwriter.WriteElementString("Fecha De Publicacion", c.FechaPublicacion);
                xmlwriter.WriteElementString("Fecha De Edicion", c.FechaEdicion);
                xmlwriter.WriteElementString("NAutores", c.NAutores.ToString());
                xmlwriter.WriteElementString("NAutores", c.Autores.ToString());
                xmlwriter.WriteElementString("NIdiomas", c.NIdiomas.ToString());
                xmlwriter.WriteElementString("NIdiomas", c.Idiomas.ToString());
                xmlwriter.WriteElementString("codigo", c.Id.ToString());
                xmlwriter.WriteElementString("Numero De Paginas", c.NumeroPaginas.ToString());
                xmlwriter.WriteElementString("Categorias", c.Categoria.ToString());
                xmlwriter.WriteElementString("Capitulos", c.Capitulos.ToString());
                xmlwriter.WriteElementString("Numero Edicion", c.NuEdicion.ToString());                
                xmlwriter.WriteElementString("Nivel", c.Nivel);
                xmlwriter.WriteEndElement();
            }

            xmlwriter.WriteEndElement();

            //End XML Document
            xmlwriter.WriteEndDocument();

            //Close Write
            xmlwriter.Close();
        }

        #endregion
    }
}