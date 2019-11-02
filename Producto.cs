using System;
using System.Collections.Generic;
using System.Text;

namespace TarabajoGrupal02.Clases
{
 
    class Producto
    {
        private string codigo;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private float precio;

        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private float cantidad;

        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

    
    }
}
