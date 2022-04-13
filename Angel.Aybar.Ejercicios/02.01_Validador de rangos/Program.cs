using System;

namespace _02._01_Validador_de_rangos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02.01 Pagina Web";
            int numero;
            int maximo;
            int minimo;
            float promedio;
            int acumulador;
            int flag;
            int cantidad;
            bool resultado;

            maximo = 0;
            minimo = 0;
            promedio = 0;
            flag = 0;
            cantidad = 0;
            acumulador = 0;

            do
            {
                do
                {   
                    Console.Write("Ingrese numero:");
                    numero = int.Parse(Console.ReadLine());

                    resultado=Validador.Validar(numero, -100, 100);
                    if(resultado==false)
                    {
                        Console.WriteLine("El número no esta en el rango");
                    }
                } while (resultado==false);

                cantidad++;

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

                acumulador = acumulador + numero;//aca ponerlo completo


            } while (cantidad != 10);//aca poner distinto

            promedio = (float)acumulador / 10;//casteo recordar

            Console.WriteLine("Maximo: {0}", maximo);
            Console.WriteLine("Minimo: {0}", minimo);
            Console.WriteLine("Promedio: {0}", promedio);


            Console.ReadKey();
        }
    }
}
