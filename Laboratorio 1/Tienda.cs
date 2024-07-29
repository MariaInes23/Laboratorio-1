using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Laboratorio_1
{
    public class Tienda
    {
        public string Producto { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public double Compra { get; set; }

        public Tienda(string producto, double precio, int cantidad, double compra)
        {
            Producto = producto;
            Precio = precio;
            Cantidad = cantidad;
            Compra = compra;
        }

        public void CrearProducto()
        {
            Console.WriteLine($"Ingrese el nombre del producto: {Producto}");
            Console.WriteLine($"Ingrese el precio del: {Precio}");
            Console.WriteLine($"Ingrese la cantidad del producto: {Cantidad}");

        }

    }
}

