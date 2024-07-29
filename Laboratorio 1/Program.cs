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
                IngresarProducto();
                break;
            case 2:
                AcumularProducto();
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

static void IngresarProducto()
{
        string nombreProducto;
        double precioProducto;

            Console.Write($"Ingrese el producto: ");
            try
            {
                nombreProducto= Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.Write("Entrada no válida. Ingrese un número válido: ");
            }

            Console.Write($"Ingrese el precio del precio ");
            try
            {
                precioProducto = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("Entrada no válida. Ingrese un número válido: ");
            }
}
static void AcumularProducto()
{

    Console.Write("Cantidad");
    try
    {
        nombreProducto = Console.ReadLine();
    }
    catch (FormatException)
    {
        Console.Write("Entrada no válida. Ingrese un número válido: ");
    }

    Console.Write($"Ingrese el precio del precio ");
    try
    {
        precioProducto = Convert.ToDouble(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.Write("Entrada no válida. Ingrese un número válido: ");
    }
}
