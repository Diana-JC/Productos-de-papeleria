using System;

public abstract class Producto
{
    protected string? Codigo { get; set; }
    protected string? Nombre { get; set; }
    protected string? Marca { get; set; }
    protected decimal? Precio { get; set; }

    public void AlmacenarDatos()
    {
        Console.WriteLine("Introduzca el código del producto:");
        Codigo = Console.ReadLine();

        Console.WriteLine("Introduzca el nombre del producto:");
        Nombre = Console.ReadLine();

        Console.WriteLine("Introduzca la marca del producto:");
        Marca = Console.ReadLine();

        Console.WriteLine("Introduzca el precio del producto:");
        Precio = Convert.ToDecimal(Console.ReadLine());
    }

    public void MostrarDatos()
    {
        Console.WriteLine("\nDatos del producto:");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Precio: {Precio}");
    }
}

public class Papeles : Producto
{
    public string Tipo { get; set; }
    public string Color { get; set; }
    public string Tamaño { get; set; }

    public void IntroducirDatos()
    {
        AlmacenarDatos();

        Console.WriteLine("Introduzca el tipo de papel:");
        Tipo = Console.ReadLine();

        Console.WriteLine("Introduzca el color del papel:");
        Color = Console.ReadLine();

        Console.WriteLine("Introduzca el tamaño del papel:");
        Tamaño = Console.ReadLine();
    }

    public void MostrarPapeles()
    {
        MostrarDatos();

        Console.WriteLine($"Tipo: {Tipo}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Tamaño: {Tamaño}");
    }
}

public class Utensilios : Producto
{
    public string Categoria { get; set; }
    public decimal Peso { get; set; }

    public void IntroducirDatos()
    {
        AlmacenarDatos();

        Console.WriteLine("Introduzca la categoría del utensilio:");
        Categoria = Console.ReadLine();

        Console.WriteLine("Introduzca el peso del utensilio:");
        Peso = Convert.ToDecimal(Console.ReadLine());
    }

    public void MostrarUtensilios()
    {
        MostrarDatos();

        Console.WriteLine($"Categoría: {Categoria}");
        Console.WriteLine($"Peso: {Peso}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string opcion;

        do
        {
            Console.WriteLine("\nSeleccione una opción:");
            Console.WriteLine("1. Papeles");
            Console.WriteLine("2. Utensilios");
            Console.WriteLine("3. Salir");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Papeles papel = new Papeles();
                    papel.IntroducirDatos();
                    papel.MostrarPapeles();
                    break;
                case "2":
                    Utensilios utensilio = new Utensilios();
                    utensilio.IntroducirDatos();
                    utensilio.MostrarUtensilios();
                    break;
                case "3":
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;


            }

            Console.WriteLine("\n¿Desea continuar? (si/no)");
            opcion = Console.ReadLine();
        } while (opcion.ToLower() == "si");
    }
}
