using System;
using System.Collections.Generic;
using System.Text;

namespace TarabajoGrupal02.Clases
{
    class Factura
    {
        private string codigoFactura;
        private Factura_Producto factura_producto;


        public string CodigoFactura
        {
            get { return codigoFactura; }
            set { codigoFactura = value; }
        }

       


       
        private float descuento;

        public float Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
     
    }
}
