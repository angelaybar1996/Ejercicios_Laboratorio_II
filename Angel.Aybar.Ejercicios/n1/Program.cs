using System;

namespace n1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Ejercicio Nro1";
            int numero;
            int maximo;
            int minimo;
            float promedio;
            int acumulador;
            int flag;
            int cantidad;

            maximo = 0;
            minimo = 0;
            promedio = 0;
            flag = 0;
            cantidad = 0;
            acumulador = 0;

            do
            {
                cantidad++;
                Console.WriteLine("Ingrese numero:");
                numero = int.Parse(Console.ReadLine());

                if (maximo < numero)
                {
                    maximo = numero;
                    if (flag == 0)
                    {
                        minimo = maximo;
                        flag = 1;
                    }
                }

                if (minimo > numero)
                {
                    minimo = numero;
                }

                acumulador =acumulador +numero;//aca ponerlo completo
               

            } while (cantidad !=5);//aca poner distinto

            promedio = (float) acumulador / 5;//casteo recordar

            Console.WriteLine("Maximo: {0}", maximo);
            Console.WriteLine("Minimo: {0}", minimo);
            Console.WriteLine("Promedio: {0}", promedio);
         
             
            Console.ReadKey();

            

        }
    }
}
