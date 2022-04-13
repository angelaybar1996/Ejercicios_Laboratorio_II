using System;

namespace _06_años_bisiestos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio Nro6 Pagina Web ";
            int inicio = 0;
            int fin;
            bool esNumerico;
            string cadena;
           

           //año de inicio
            do
            {
                Console.WriteLine("Ingrese un anio de inicio:");
                cadena = Console.ReadLine();


                esNumerico = int.TryParse(cadena, out inicio);
                if (esNumerico == false)
                {
                    Console.WriteLine("ERROR,¡Debe ingresar un número!");
                }

            } while (!esNumerico);

            //año de fin
           
            Console.WriteLine("Ingrese anio de fin:");
            fin = int.Parse(Console.ReadLine());


            //rango de años biciestos
            for (int i =inicio; i <= fin; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    Console.WriteLine("Es bisiesto {0}\n", i);    
                }

            }
      
            Console.ReadKey();

        }
    }
}
