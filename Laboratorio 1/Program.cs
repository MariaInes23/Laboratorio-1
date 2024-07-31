Console.WriteLine("-----------EJERCICIO 2------------");
static void Main(string[] args)
{
    string nombre;
    double precio = 0;
    int stock = 0;

    Console.Write("Ingrese el nombre del producto: ");
    nombre = Console.ReadLine();

    while (true)
    {
        Console.Write("Ingrese el precio del producto: ");
        string entradaPrecio = Console.ReadLine();
        try
        {
            precio = Convert.ToDouble(entradaPrecio);
            if (precio < 0)
            {
                Console.WriteLine("El precio no puede ser negativo.");
                continue;
            }
            break;
        }
        catch
        {
            Console.WriteLine("Precio inválido. Ingrese un valor numérico positivo.");
        }
    }

    while (true)
    {
        Console.Write("Ingrese la cantidad en stock del producto: ");
        string entradaStock = Console.ReadLine();
        try
        {
            stock = Convert.ToInt32(entradaStock);
            if (stock < 0)
            {
                Console.WriteLine("La cantidad en stock no puede ser negativa.");
                continue;
            }
            break;
        }
        catch
        {
            Console.WriteLine("Cantidad en stock inválida. Por favor, ingrese un valor numérico positivo.");
        }
    }

    Tienda producto = new Tienda(nombre, precio, stock);

    bool continuar = true;

    while (continuar)
    {
        Console.WriteLine("\nMENÚ:");
        Console.WriteLine("1. Consultar producto");
        Console.WriteLine("2. Vender producto");
        Console.WriteLine("3. Reabastecer producto");
        Console.WriteLine("4. Actualizar precio del producto");
        Console.WriteLine("5. Mostrar resumen del producto");
        Console.WriteLine("6. Salir");

        int opcion;
        Console.Write("Ingrese su opción: ");
        string entradaOpcion = Console.ReadLine();
        try
        {
            opcion = Convert.ToInt32(entradaOpcion);
        }
        catch
        {
            Console.WriteLine("Opción no válida. Seleccione un número del 1 al 6.");
            continue;
        }

        switch (opcion)
        {
            case 1:
                producto.Consultar();
                break;
            case 2:
                while (true)
                {
                    Console.Write("Ingrese la cantidad a vender: ");
                    string entradaVenta = Console.ReadLine();
                    try
                    {
                        int cantidadVenta = Convert.ToInt32(entradaVenta);
                        if (cantidadVenta < 0)
                        {
                            Console.WriteLine("La cantidad a vender no puede ser negativa.");
                            continue;
                        }
                        producto.Vender(cantidadVenta);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Cantidad inválida. Por favor, ingrese un valor numérico positivo.");
                    }
                }
                break;
            case 3:
                while (true)
                {
                    Console.Write("Ingrese la cantidad a reabastecer: ");
                    string entradaReabastecimiento = Console.ReadLine();
                    try
                    {
                        int cantidadReabastecimiento = Convert.ToInt32(entradaReabastecimiento);
                        if (cantidadReabastecimiento < 0)
                        {
                            Console.WriteLine("La cantidad a reabastecer no puede ser negativa.");
                            continue;
                        }
                        producto.Reabastecer(cantidadReabastecimiento);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Cantidad inválida. Por favor, ingrese un valor numérico positivo.");
                    }
                }
                break;
            case 4:
                while (true)
                {
                    Console.Write("Ingrese el nuevo precio: ");
                    string entradaNuevoPrecio = Console.ReadLine();
                    try
                    {
                        double nuevoPrecio = Convert.ToDouble(entradaNuevoPrecio);
                        if (nuevoPrecio < 0)
                        {
                            Console.WriteLine("El nuevo precio no puede ser negativo.");
                            continue;
                        }
                        producto.ActualizarPrecio(nuevoPrecio);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Precio inválido. Por favor, ingrese un valor numérico positivo.");
                    }
                }
                break;
            case 5:
                producto.MostrarResumen();
                break;
            case 6:
                continuar = false;
                break;
            default:
                Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 6.");
                break;
        }
    }

    Console.WriteLine("Gracias por usar el Programa :)");
}