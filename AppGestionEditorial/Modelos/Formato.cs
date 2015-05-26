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

        #region "propiedades"
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public bool Leer
        {
            get { return leer; }
            set { leer = value; }
        }

        public bool Guardar
        {
            get { return guardar; }
            set { guardar = value; }
        }
        public bool Imprimir
        {
            get { return imprimir; }
            set { imprimir = value; }
        }
        public bool Editar
        {
            get { return editar; }
            set { editar = value; }
        }
        public bool Escuchar
        {
            get { return escuchar; }
            set { escuchar = value; }
        }

        public bool Visualizar
        {
            get { return visualizar; }
            set { visualizar = value; }
        }
        #endregion

        #region "____CONSTRUCTORES________"
        public Formato()
        {

            this.codigo = 0112;
            this.nombre = "nombre";
            this.leer = true;
            this.guardar = true;
            this.imprimir = true;
            this.editar = true;
            this.escuchar = true;
            this.escuchar = true;
            this.visualizar = true;


        }
        public Formato(int codigo, string nombre, bool leer, bool guardar, bool imprimir, bool editar, bool escuchar, bool visualizar)
        {

            this.codigo = codigo;
            this.nombre = nombre;
            this.leer = leer;
            this.guardar = guardar;
            this.imprimir = imprimir;
            this.editar = editar;
            this.escuchar = escuchar;
            this.visualizar = visualizar;
        }


        #endregion

        #region "Métodos SobreEscritos"

        public override string ToString()
        {
            return base.ToString() +
                               "\n Id " + this.codigo +
                               "\n Nombres " + this.nombre +
                               "\n Apellidos " + this.leer +
                               "\n Direccion " + this.guardar +
                               "\n Telefono " + this.imprimir +
                               "\n Email " + this.editar +
                                "\n Email " + this.escuchar +
                                 "\n Email " + this.visualizar;
                             
        }
        
        public override bool Equals(object obj)
        {
            Formato doc = (Formato)obj;
            bool result = false;

            if (base.Equals(doc) && (this.codigo == doc.codigo)
                && (this.nombre == doc.nombre)
                && (this.leer == doc.leer)
                && (this.guardar == doc.guardar)
                && (this.imprimir == doc.imprimir)
                && (this.editar == doc.editar)
                && (this.escuchar == doc.escuchar)
                && (this.visualizar == doc.visualizar)

                )

                result = true;

            return result;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        #endregion
    }
}
