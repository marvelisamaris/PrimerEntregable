//Primer ejercicio declaracion de renta
namespace DeclaracionRenta
{
    class Program
    {
        static void Main(string[] args)
        {

            double porcentaje = 0;

            Console.WriteLine("Ingrese el valor del primer trimestre: ");
            double T1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del segundo trimestre: ");
            double T2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del tercer trimestre: ");
            double T3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del cuarto trimestre: ");
            double T4 = double.Parse(Console.ReadLine());


            double rentaAnual = T1 + T2 + T3 + T4;


            double impuesto = 0;
            if (rentaAnual < 10000)
            {
                porcentaje = 0.05;
                impuesto = rentaAnual * 0.05 + rentaAnual;
            }
            else if (rentaAnual >= 10000 && rentaAnual < 20000)
            {
                porcentaje = 0.1;
                impuesto = rentaAnual * 0.1 + rentaAnual;
            }
            else if (rentaAnual >= 20000 && rentaAnual < 35000)
            {
                porcentaje = 0.15;
                impuesto = rentaAnual * porcentaje + rentaAnual;
            }
            else if (rentaAnual >= 35000 && rentaAnual < 45000)
            {
                porcentaje = 0.2;
                impuesto = rentaAnual * porcentaje + rentaAnual;
            }
            else
            {
                porcentaje = 0.3;
                impuesto = rentaAnual * porcentaje + rentaAnual;
            }

            double porcentajeImpuesto = porcentaje * 100;


            Console.WriteLine("Renta anual: " + rentaAnual);
            Console.WriteLine("Total de renta a pagar: " + impuesto);
            Console.WriteLine("% de impuesto agregado: " + porcentajeImpuesto + "%");

            Console.ReadKey();
        }
    }
}