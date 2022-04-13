using System;

namespace n4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro4";
            int numero = 0;
            bool esNumerico;
            string cadena;
            string divisores="";
            int b;
   
            //validacion para que el usuario ingrese un número(TENER EN CUENTA)
            do
            {
                Console.WriteLine("Ingrese numero:");
                cadena = Console.ReadLine();


                esNumerico = int.TryParse(cadena, out numero);
                if (esNumerico == false)
                {
                    Console.WriteLine("ERROR,¡Debe ingresar un número!");
                }

            } while (!esNumerico);

            //Logica para averiguar numeros perfectos a partir del ingreso de un numero por el usuario
            for (int i = 1; i <= numero; i++)
            {
                b = 0;

                for (int j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {
                        b += j;
                        divisores += " " + j + " ";
                    }
                }
                if (b == i)
                Console.WriteLine("El numero " + i + " es perfecto y su divisores son: " + divisores);
                divisores = "";
            }

            Console.ReadKey();

        }
    }
}
