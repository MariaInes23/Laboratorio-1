List<double> numeros = new List<double>();

while (true)
{
    Console.Clear();
    MostrarMenu();
    int opcion = Convert.ToInt32(Console.ReadLine());
    try
    {
        switch (opcion)
        {
            case 1:
                producto = ListaProducto();
                break;
            case 6:
                Console.WriteLine("Saliendo...");
                return;
            default:
                Console.WriteLine("Opción no válida, intenta de nuevo.");
                break;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Asegúrese de ingresar un número entero.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error inesperado: {ex.Message}");
    }
    Console.WriteLine("\nPresiona Enter para continuar...");
    Console.ReadLine();
}


static void MostrarMenu()
{
    Console.WriteLine("Menú Cálculos Estadísticos:");
    Console.WriteLine("1. Ingresar Prodcuto");
    Console.WriteLine("2. Mostrar Produtos Acumulados");
    Console.WriteLine("3. Calcular y Mostrar Mediana");
    Console.WriteLine("4. Calcular Total de Compra");
    Console.WriteLine("5. Mostrar Resultados");
    Console.WriteLine("6. Salir");
    Console.Write("Selecciona una opción: ");
}

static List<string> ListaProducto()
{
    List<string> producto = new List<string>();
    List<double> precio = new List<double>();

    Console.Write("Ingrese la cantidad de productos que desea introducir: ");
    int cantidad;
    while (true)
    {
        try
        {
            cantidad = Convert.ToInt32(Console.ReadLine());
            if (cantidad <= 0)
            {
                Console.Write("La cantidad debe ser un número entero positivo. Inténtelo de nuevo: ");
                continue;
            }
            break;
        }
        catch (FormatException)
        {
            Console.Write("Entrada no válida. Ingrese un número entero positivo: ");
        }
    }

    for (int i = 0; i < cantidad; i++)
    {
        string nombreProducto;
        double precioProducto;
        while (true)
        {
            Console.Write($"Ingrese el producto {i + 1}: ");
            try
            {
                nombreProducto= Console.ReadLine();
                break;
            }
            catch (FormatException)
            {
                Console.Write("Entrada no válida. Ingrese un número válido: ");
            }
        }
        nombreProducto.Add(producto);

        while (true)
        {
            Console.Write($"Ingrese el precio del producto {i + 1}: ");
            try
            {
                precioProducto = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.Write("Entrada no válida. Ingrese un número válido: ");
            }
        }
        precioProducto.Add(precio);
    }
}