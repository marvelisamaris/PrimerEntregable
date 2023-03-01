//Cuarto Ejercicio Puntuacion Empleados

namespace puntuacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double puntuacion1 = 0.0;
            double puntuacion2 = 0.4;
            double puntuacion3 = 0.6;
            int bonoficacion = 50000;
            double bonoficacionDinero1;
            double bonoficacionDinero2;
            double bonoficacionDinero3;
            string nivel1 = "Inaceptable";
            string nivel2 = "Aceptable";
            string nivel3 = "Meritorio";
            string linea;

            bonoficacionDinero1 = bonoficacion * puntuacion1;
            bonoficacionDinero2 = bonoficacion * puntuacion2;
            bonoficacionDinero3 = bonoficacion * puntuacion3;


            Console.WriteLine("Su nivel es " + nivel1 + " y su bonificacion es de " + bonoficacionDinero1);
            Console.WriteLine("Su nivel es " + nivel2 + " y su bonificacion es de " + bonoficacionDinero2);
            Console.WriteLine("Su nivel es " + nivel3 + " y su bonificacion es de " + bonoficacionDinero3);

            Console.ReadKey();
        }
    }
}
