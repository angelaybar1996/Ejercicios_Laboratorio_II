using System;

namespace n2
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro2";
            int numero;
            double cuadrado;
            double cubo;

            cuadrado = 0;
            cubo = 0;


            do
            {
                Console.WriteLine("Ingrese numero:");
                numero = int.Parse(Console.ReadLine());

                if (numero <= 0)
                {
                    Console.WriteLine("Error,¡Reingresar número!");

                }
            } while (numero <= 0);
           

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("Cuadrado:{0} - Cubo{1}",cuadrado,cubo);

            Console.ReadKey();
         
        }
    }
}
