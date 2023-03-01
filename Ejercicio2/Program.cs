// Segundo ejercicio SALA DE JUEGOS

internal class Program
{
    static void Main(string[] args)
    {
        string nombreCompleto;
        int edad;
        float precioEntrada = 15000;
        float descuento1 = 5;
        float descuento2 = 3;
        double precioCobrar;
        double entrada = 0;
        string linea;

        Console.WriteLine("Nombre  completo");
        nombreCompleto = Console.ReadLine();
        Console.WriteLine("Edad");
        linea = Console.ReadLine();
        edad = int.Parse(linea);

        if (edad < 4)
        {
            precioCobrar = precioEntrada - precioEntrada;
        }
        else if (edad >= 4 && edad <= 18)
        {
            precioCobrar = precioEntrada * descuento1 / 100;
            entrada = precioEntrada - precioCobrar;
        }
        else
        {
            precioCobrar = precioEntrada * descuento2 / 100;
            entrada = precioEntrada - precioCobrar;
        }

        Console.WriteLine("Señor/a " + nombreCompleto + " El valor de su entrada es " + entrada + " y su descuento fue de " + precioCobrar + " pesos ");

        Console.ReadKey();
    }
}






