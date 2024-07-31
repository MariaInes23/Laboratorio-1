Console.WriteLine("-----------EJERCICIO 1------------");

double totalCompra = 0;
int conteoProductos = 0;
bool continuar = true;

while (continuar)
{
    MostrarMenu();
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            (totalCompra, conteoProductos) = SolicitarProducto(totalCompra, conteoProductos);
            break;
        case "2":
            CalcularTotal(totalCompra, conteoProductos);
            break;
        case "3":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opción no válida, por favor intente nuevamente.");
            break;
    }
}


    static void MostrarMenu()
{
    Console.WriteLine("===== Menú =====");
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Calcular total de la compra");
    Console.WriteLine("3. Salir");
    Console.WriteLine("Ingrese una opción:");
}

static (double, int) SolicitarProducto(double totalCompra, int conteoProductos)
{
    while (true)
    {
        try
        {
            Console.WriteLine("Ingrese el nombre del producto:");
            string nombreProducto = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto:");
            double precioProducto = Convert.ToDouble(Console.ReadLine());

            if (precioProducto < 0)
            {
                throw new ArgumentException("El precio no puede ser negativo.");
            }

            totalCompra += precioProducto;
            conteoProductos++;
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. El precio debe ser un número. Intente nuevamente.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    return (totalCompra, conteoProductos);
}

static void CalcularTotal(double totalCompra, int conteoProductos)
{
    double descuento = 0;
    double umbralDescuento = 100.00; 
    double porcentajeDescuento = 0.10;

    if (totalCompra > umbralDescuento)
    {
        descuento = totalCompra * porcentajeDescuento;
    }

    double totalConDescuento = totalCompra - descuento;

    Console.WriteLine("===== Resumen de la compra =====");
    Console.WriteLine($"Productos comprados: {conteoProductos}");
    Console.WriteLine($"Total: ${totalCompra:F2}");
    if (descuento > 0)
    {
        Console.WriteLine($"Descuento aplicado: -${descuento:F2}");
    }
    Console.WriteLine($"Total a pagar: ${totalConDescuento:F2}");
}