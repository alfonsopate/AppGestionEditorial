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

namespace AppGestionEditorial.Datos
{
    public class ClientesRepositorio
    {
        #region Registrar Clientes
        private static List<Cliente> datac = new List<Cliente>();

        public List<Cliente> getClientes()
        {
            // Creamos la lista genérica de Personas
            List<Cliente> lista = new List<Cliente>();

            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/DocumentosXML/FacturasRepositorios.xml");

            XDocument doc = XDocument.Load(ruta);

            var clientesc = from c in doc.Descendants("Documentos") select c;

            foreach (XElement c in clientesc.Elements("Clientes"))
            {
                Cliente cliente = new Cliente(


                                                   int.Parse(c.Element("Id").Value),
                                                   c.Element("Nombres").Value,
                                                   c.Element("Apellidos").Value,
                                                   c.Element("Direccion").Value,
                                                   int.Parse(c.Element("Telefono").Value),
                                                   c.Element("Email").Value


                                               );
                lista.Add(cliente);

            }


            return lista;
        }

        public void add(Cliente c)
        {
            datac.Add(c);
            WriteXML(datac);

        }

        private void WriteXML(List<Cliente> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/Clientes.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Documentos");
            //Call create nodes method
            foreach (Cliente c in list)
            {
                xmlwriter.WriteStartElement("Cliente");
                xmlwriter.WriteElementString("Nombres", c.Nombres);
                xmlwriter.WriteElementString("Apellidos", c.Apellidos);
                xmlwriter.WriteElementString("Direccion", c.Direccion);
                xmlwriter.WriteElementString("Email", c.Email);
                xmlwriter.WriteElementString("Id", c.Id.ToString());
                xmlwriter.WriteElementString("Telefono", c.Telefono.ToString());
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