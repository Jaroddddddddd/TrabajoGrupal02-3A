using System;
using System.Collections.Generic;
using TarabajoGrupal02.Clases;
namespace TarabajoGrupal02
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<string> listacodigo = new List<string>();
            List<string> listadescripcion = new List<string>();
            List<float> listaprecio = new List<float>();
            List<float> listacantidad = new List<float>();


            Cliente cliente = new Cliente();
            Factura factura = new Factura();
            Producto producto = new Producto();
            Factura_Producto factura_Producto = new Factura_Producto();
            float subtotall = 0;
            float subtotall2 = 0;
            float totalsiniva = 0;
            float iva = 0;
            float total = 0;
            

            Console.WriteLine("Ingrese el codigo de la factura");
            factura.CodigoFactura = Console.ReadLine();
            Console.WriteLine("Ingrese su identificacion");
            cliente.Identificacion = Console.ReadLine();
            Console.WriteLine("Ingrese su nombre");
            cliente.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su dirección");
            cliente.Direccion = Console.ReadLine();
            Console.WriteLine("Ingrese su telefono");
            cliente.Telefono = int.Parse(Console.ReadLine());
            byte decicion = 1;
            while (decicion==1)
            {
                
                Console.WriteLine("Ingrese codigo del producto");
            producto.Codigo = Console.ReadLine();
                listacodigo.Add(producto.Codigo);
            Console.WriteLine("Ingrese la descripcion del producto");
            producto.Descripcion = Console.ReadLine();
                listadescripcion.Add(producto.Descripcion);
                Console.WriteLine("Ingrese el precio del producto");
                producto.Precio = float.Parse(Console.ReadLine());
                listaprecio.Add(producto.Precio);
                Console.WriteLine("Ingrese la cantidad del producto");
            producto.Cantidad = int.Parse(Console.ReadLine());
                listacantidad.Add(producto.Cantidad);

                subtotall = new Factura_Producto().CalcularSubtotal(producto.Precio, producto.Cantidad);
                subtotall2 = subtotall2 + subtotall;
                Console.WriteLine("¿Ingresara más productos?");
                Console.WriteLine("1. SI");
                Console.WriteLine("2. NO");
                decicion = byte.Parse(Console.ReadLine());


            }


          
            Console.WriteLine("Ingrese el descuento");
            factura.Descuento = float.Parse(Console.ReadLine());
            Console.WriteLine("________________________________________________________________________________");
            Console.WriteLine("Cliente: " + cliente.Nombre + "      Identificación: " + cliente.Identificacion);
            Console.WriteLine("Dirección: " + cliente.Direccion + "                  Telefono: " + cliente.Telefono);
            Console.WriteLine("________________________________________________________________________________");
            totalsiniva = new Factura_Producto().CalcularTotalsinIVA(subtotall2, factura.Descuento);
            iva = new Factura_Producto().CalcularIVA(subtotall2);
            total = new Factura_Producto().CalcularTotal(totalsiniva, iva);

                       

            foreach (var item in listacodigo)
            {
                Console.WriteLine("Cod: " + item);

            }
            foreach (var item in listadescripcion)
            {
                Console.WriteLine("Descripción: " + item);

            }
            foreach (var item in listaprecio)
            {
                Console.WriteLine("Precio: " + item);

            }
            foreach (var item in listacantidad)
            {
                Console.WriteLine("Cantidad: " + item);

            }

            Console.WriteLine("subtotal: " + subtotall2);
            Console.WriteLine("Descuento: " + factura.Descuento);

           
            Console.WriteLine("Subtotal-Descuento: " + totalsiniva);

            Console.WriteLine("IVA: " + iva);

            Console.WriteLine("Total: " + total);
            }
            
        
    }
}
