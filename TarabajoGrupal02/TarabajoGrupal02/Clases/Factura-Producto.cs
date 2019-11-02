using System;
using System.Collections.Generic;
using System.Text;

namespace TarabajoGrupal02.Clases
{
    class Factura_Producto
    {

        Factura factura = new Factura();
        Producto producto = new Producto();


        public float CalcularSubtotal(float Precio, float Cantidad)
        {
            float x = Precio * Cantidad;
            float subtotalacumolado = 0;
            subtotalacumolado = subtotalacumolado + x;
            return subtotalacumolado;
        }
        public float CalcularIVA(float subtotal)
        {
            float iva = subtotal * 12 / 100;
            return iva;
        }
        public float CalcularTotalsinIVA(float subtotal, float descuento)
        {
            return subtotal - descuento;

}
        public float CalcularTotal(float subtotalsiniva, float iva)
        {
            return subtotalsiniva - iva;
        }
       

        
    }
}

