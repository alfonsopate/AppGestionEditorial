using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelos
{
    public class Formato
    {
        #region "Atributos"
        private string tipo;
        private string entrega;

        
        #endregion

        #region "Propiedades"
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Entrega
        {
            get { return entrega; }
            set { entrega = value; }
        }
        #endregion
    }
}