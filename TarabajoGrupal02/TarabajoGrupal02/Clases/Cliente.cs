using System;
using System.Collections.Generic;
using System.Text;

namespace TarabajoGrupal02.Clases
{
    class Cliente
    {
        private string identificacion;

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private List<Factura> listaFactura;
        public List<Factura> ListaFactura
        {
            get { return listaFactura; }
            set { }

        }

    
}
}
