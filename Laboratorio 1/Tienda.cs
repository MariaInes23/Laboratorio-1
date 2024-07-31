class Tienda
{
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Stock { get; set; }

    public Tienda(string nombre, double precio, int stock)
    {
        Nombre = nombre;
        Precio = precio;
        Stock = stock;
    }
    public void Consultar()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: {Precio}");
        Console.WriteLine($"Stock disponible: {Stock}");
    }

    public void Vender(int cantidad)
    {
        if (cantidad <= Stock)
        {
            Stock -= cantidad;
            Console.WriteLine($"Venta realizada: {cantidad} unidades de {Nombre}. Stock restante: {Stock}");
        }
        else
        {
            Console.WriteLine($"No hay suficiente stock para vender {cantidad} unidades de {Nombre}. Stock disponible: {Stock}");
        }
    }

    public void Reabastecer(int cantidad)
    {
        Stock += cantidad;
        Console.WriteLine($"Stock de {Nombre} reabastecido en {cantidad} unidades. Stock actual: {Stock}");
    }

    public void ActualizarPrecio(double nuevoPrecio)
    {
        Precio = nuevoPrecio;
        Console.WriteLine($"Precio de {Nombre} actualizado a {Precio:C}");
    }

    public void MostrarResumen()
    {
        Console.WriteLine("Resumen del Producto:");
        Consultar();
    }
}
