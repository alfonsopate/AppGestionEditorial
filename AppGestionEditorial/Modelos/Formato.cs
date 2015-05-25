using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppGestionEditorial.Modelos
{
    public abstract class Formato
    {
        #region "Atributos"
        public int codigo;
        public string nombre;
        public bool leer;
        public bool guardar;
        public bool imprimir;
        public bool editar;
        public bool escuchar;
        public bool visualizar;
        #endregion

        
    }
}
