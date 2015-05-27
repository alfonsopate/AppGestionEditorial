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

namespace AppGestionEditorial.Datos
{
    public class CientificosRepositorios
    {
        #region Guardar Cientificos
        private static List<Cientificos> datac = new List<Cientificos>();
        public List<Cientificos> getCientificos()
        {
            // Creamos la lista genérica de Personas
            List<Cientificos> lista = new List<Cientificos>();

            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/DocumentosXML/Cientifico.xml");

            XDocument doc = XDocument.Load(ruta);

            var cientificosc = from ci in doc.Descendants("Documentos") select ci;

            foreach (XElement ci in cientificosc.Elements("Cientificos"))
            {
                Cientificos cientifico = new Cientificos(

                                                   int.Parse(ci.Element("Codigo").Value),
                                                   ci.Element("Titulo").Value,
                                                   ci.Element("Editoria").Value,
                                                   ci.Element("Edicion").Value,
                                                   ci.Element("Autores").Value,
                                                   ci.Element("Idiomas").Value,
                                                   ci.Element("Categorias").Value,
                                                   int.Parse(ci.Element("Numero De Paginas").Value),
                                                   ci.Element("Fecha De Edicion").Value,
                                                   ci.Element("Fecha De Publicaion").Value,
                                                   ci.Element("Tipos").Value
                                               );
                lista.Add(cientifico);

            }


            return lista;
        }

        public void add(Cientificos ci)
        {
            datac.Add(ci);
            WriteXML(datac);

        }

        private void WriteXML(List<Cientificos> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/DocumentosXML/CientificosRepositorios.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Documentos");
            //Call create nodes method
            foreach (Cientificos ci in list)
            {
                xmlwriter.WriteStartElement("Cientificos");
                xmlwriter.WriteElementString("Titulos Del Documento", ci.Titulo);
                xmlwriter.WriteElementString("Editorial", ci.Editorial);
                xmlwriter.WriteElementString("Fecha De Publicacion", ci.FechaPublicacion);
                xmlwriter.WriteElementString("Fecha De Edicion", ci.FechaEdicion);
                xmlwriter.WriteElementString("NAutores", ci.NAutores.ToString());
                xmlwriter.WriteElementString("NAutores", ci.Autores.ToString());
                xmlwriter.WriteElementString("NIdiomas", ci.NIdiomas.ToString());
                xmlwriter.WriteElementString("NIdiomas", ci.Idiomas.ToString());
                xmlwriter.WriteElementString("codigo", ci.Id.ToString());
                xmlwriter.WriteElementString("Numero De Paginas", ci.NumeroPaginas.ToString());
                xmlwriter.WriteElementString("Categorias", ci.Categoria.ToString());
                xmlwriter.WriteElementString("Tipo", ci.Tipo.ToString());

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