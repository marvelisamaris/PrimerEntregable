// Tercer ejercicio Pizzas el Fercho

internal class Program
{
    static void Main(string[] args)
    {
        string pizzaVegetariana;
        string pizzaNoVegetariana;
        string pizza;
        int opt = 0;
        string linea;

        Console.WriteLine("** Pizzas el Fercho **");
        Console.WriteLine("¿que tipo de pizza quieres?");
        Console.WriteLine("1. pizza vegetariana.");
        Console.WriteLine("2. pizza no vetariana.");
        opt = int.Parse(Console.ReadLine());
        switch (opt)
        {
            case 1:
                pizzaVegetariana = "vegetariana con ingredientes pimienta, champiñones, mozarella, tomate";
                pizza = pizzaVegetariana;
                break;
            case 2:
                pizzaNoVegetariana = "no vegetariana con ingredientes peperoni, salami, pollo, mozarella, tomate";
                pizza = pizzaNoVegetariana;
                break;
            default:
                pizza = "error";
                break;
        }

        Console.WriteLine("su pizza es " + pizza);
        Console.ReadKey();
    }
}








