using System;

namespace A133590.Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 31.");
            Console.WriteLine("Programa que decide si un ingreso puede interpretarse como un intervalo de tiempo");
            Console.Write("Ingrese un intervalo de tiempo: ");
            TimeSpan intervalo;
            if(TimeSpan.TryParse(Console.ReadLine(), out intervalo))
            {
                Console.WriteLine("El ingreso se puede interpretar como un intervalo");
            }
            else
            {
                Console.WriteLine("El ingreso no se puede interpretar como un intervalo");
            }

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
