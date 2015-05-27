using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppGestionEditorial.Modelos;
using System.Xml;
using System.Web.Hosting;
using System.IO;
using System.Xml.Linq;
using AppGestionEditorial.Web;
namespace AppGestionEditorial.Datos
{
    public class RevistasRepositorios
    {
        #region Guardar Revistas
        private static List<Revistas> datab = new List<Revistas>();
        public List<Revistas> getRevistas()
        {
            // Creamos la lista genérica de Personas
            List<Revistas> lista = new List<Revistas>();

            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/DocumentosXML/RevistasRepositorios.xml");

            XDocument doc = XDocument.Load(ruta);

            var revistac = from r in doc.Descendants("Documentos") select r;

            foreach (XElement r in revistac.Elements("Revistas"))
            {
                Revistas revista = new Revistas(

                                                   r.Element("Id").Value,
                                                   r.Element("Titulo").Value,                                                   
                                                   int.Parse(r.Element("NAutores").Value),
                                                  // r.Element("Autores").Value,
                                                   int.Parse(r.Element("NIdiomas").Value),
                                                  // r.Element("Idiomas").Value,
                                                   r.Element("Editoria").Value,
                                                    r.Element("Categorias").Value,
                                                   int.Parse(r.Element("Numero De Paginas").Value),
                                                   r.Element("Fecha De Edicion").Value,
                                                   r.Element("Fecha De Publicaion").Value,
                                                   int.Parse(r.Element("Numero De Articulos").Value),
                                                   int.Parse(r.Element("Numero De Volumenes").Value)



                                               );
                lista.Add(revista);

            }


            return lista;
        }

        public void add(Revistas r)
        {
            datab.Add(r);
            WriteXML(datab);

        }

        private void WriteXML(List<Revistas> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/Revistas.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Documentos");
            //Call create nodes method
            foreach (Revistas r in list)
            {
                xmlwriter.WriteStartElement("Revistas");
                xmlwriter.WriteElementString("Titulos Del Documento", r.Titulo);
                xmlwriter.WriteElementString("Editorial", r.Editorial);
                xmlwriter.WriteElementString("Fecha De Publicacion", r.FechaPublicacion);
                xmlwriter.WriteElementString("Fecha De Edicion", r.FechaEdicion);
                xmlwriter.WriteElementString("NAutores", r.NAutores.ToString());
                xmlwriter.WriteElementString("NAutores", r.Autores.ToString());
                xmlwriter.WriteElementString("NIdiomas", r.NIdiomas.ToString());
                xmlwriter.WriteElementString("NIdiomas", r.Idiomas.ToString());
                xmlwriter.WriteElementString("codigo", r.Id.ToString());
                xmlwriter.WriteElementString("Numero De Paginas", r.NumeroPaginas.ToString());
                xmlwriter.WriteElementString("Categorias", r.Categoria.ToString());
                xmlwriter.WriteElementString("Numero De Articulos", r.NArticulos.ToString());
                xmlwriter.WriteElementString("Numero De Volumenes", r.NVolumen.ToString());
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