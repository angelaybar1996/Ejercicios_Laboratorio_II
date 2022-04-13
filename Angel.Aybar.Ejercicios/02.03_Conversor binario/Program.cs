using System;

namespace _02._03_Conversor_binario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02.03 Pagina Web";
            int numero;
            string cadena;
            bool esNumerico;
            string resultadoD;
            int resultadoB;

            do
            {
                Console.Write("Ingrese numero:");
                cadena = Console.ReadLine();


                esNumerico = int.TryParse(cadena, out numero);
                if (esNumerico == false)
                {
                    Console.WriteLine("ERROR,¡Debe ingresar un número!");
                }
                else if(esNumerico == true)
                {
                    if (numero < 0)
                    {
                        Console.WriteLine("ERROR,¡Debe ingresar números enteros positivos!");
                    }
                }

            } while (!esNumerico && numero < 0);

            resultadoD=Conversor.ConvertirDecimalABinario(numero);
            Console.WriteLine("El "+numero+" en binario es "+resultadoD);

            resultadoB = Conversor.ConvertirBinarioADecimal(numero);
            if(resultadoB!=-1)
            {
               Console.WriteLine("El número " + numero + " en decimal es " + resultadoB);
            }
            else
            {
                Console.WriteLine("Error,el número" +numero+" no es binario");
            }

            Console.ReadKey();
        }
    }
}
